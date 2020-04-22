' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class RevisarPreconsultas

    Private Sub RevisarPreconsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()
        If Len(PacienteV.Text) > 0 Then
            validaPaciente()
        ElseIf (S = "E" Or S = "A") And Len(PacienteV.Text) = 0 Then
            Dim emp As New BusquedaEmpleado
            emp.TransL.Text = "RCIM"
            emp.Show()
            Me.Close()
        Else
            PrincipalPanel.Visible = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrarCita(ByVal idapp As Integer)
        sql = "UPDATE dbo.MemberClinicAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
            "WHERE Project = '" + S + "' AND RecordStatus = ' ' AND AppId = " + idapp.ToString
        bdEjecutarSQL(sql)
        MsgBox("La cita ya ha sido borrada", vbQuestion, My.Resources.versionFamilias2)
        historial()
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub historial()
        sql = "SELECT *  " + _
                 "FROM dbo.fn_HEAL_RECE_HistorialPreconsulta('" + S + "', " + PacienteV.Text + ") " + _
                 "ORDER BY Date DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.Columns.Item(2).Visible = False 'AppId
        HistorialGrid.Columns.Item(3).Visible = False 'Date
        agregarColumnaAccion(0, HistorialGrid)
        agregarColumnaAccion(1, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        Dim f, c, Id As Integer
        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y
        Id = HistorialGrid.Item(2, f).Value()

        If c = 0 And Len(HistorialGrid.Item(0, f).Value()) > 0 And Id > 0 And HistorialGrid.Item(6, f).Value() = "No" Then 'Modificar
            irModificarCita(Id)
        ElseIf c = 1 And Len(HistorialGrid.Item(1, f).Value()) > 0 And Id > 0 And HistorialGrid.Item(6, f).Value() = "No" Then 'Borrar
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            response = MsgBox("¿Esta seguro de querer borrar la cita? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                borrarCita(Id)
            End If
        End If
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable
        sql = "SELECT FirstNames + ' ' +  LastNames As CompleteName, dbo.fn_GEN_CalcularEdad(BirthDate) AS Edad, LastFamilyId Familia FROM  dbo.Member M " + _
                                   "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            NombreV.Text = listTable.Rows(f)("CompleteName") 'conn.Word(sql, "CompleteName")
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad")) '+ " año(s)"
            FamiliaV.Text = listTable.Rows(f)("Familia") 'conn.Word(sql, "Familia")
        Next
    End Sub

    Private Sub infoInicial()
        PrincipalPanel.Visible = True
        PanelSecundario.Visible = True
        infoGen()
        historial()
        PacienteV.Enabled = False
        FamiliaV.Enabled = False
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "RCIM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub irModificarCita(ByVal idapp As Integer)
        Dim modCita As New ModificarPreconsulta
        modCita.pre = "RCIM"
        modCita.IDApp = idapp
        modCita.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New RevisarPreconsultas
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PacienteV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PacienteV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            validaPaciente()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub validaPaciente()
        If miembroEsValido(S, PacienteV.Text) = True Then
            If tieneDerechosSalud(S, PacienteV.Text) = True Then
                sql = "SELECT LastFamilyId as Familia FROM dbo.Member M WHERE RecordStatus= ' '  AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
                FamiliaV.Text = bdEntero(sql, "Familia")
                If familiaEsValida(S, FamiliaV.Text) Then
                    infoInicial()
                Else
                    MsgBox("La familia no existe", vbQuestion, My.Resources.versionFamilias2)
                    PacienteV.Text = ""
                End If
            Else
                MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
                PacienteV.Text = ""
                FamiliaV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            PacienteV.Text = ""
        End If
    End Sub

End Class