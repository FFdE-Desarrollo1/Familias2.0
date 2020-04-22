' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActividadesSalud

    Private Sub ActividadesSalud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        PacienteV.Focus()
        If Len(PacienteV.Text) > 0 Then
            validaPaciente()
        ElseIf (S = "E" Or S = "A") And Len(PacienteV.Text) = 0 Then
            MsgBox("Función solo para afiliados", vbQuestion, My.Resources.versionFamilias2)
        Else
            PrincipalPanel.Visible = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
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

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If valida() = True Then
            GuardarButton.Visible = False
            ' Project, MemberId, Type, ActivityDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes
            sql = "INSERT INTO dbo.MemberActivity VALUES ('" + S + "', " + PacienteV.Text + ", '" + ActividadesCombo.SelectedValue + "', '" + _
                  FechaPicker.Value.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, '" + ObservacionesV.Text + "')"
            bdInsertar(sql)
            historial()
            limpiarCamposActividad()
        End If
    End Sub

    Private Sub historial()
        sql = "SELECT 'Borrar' '_', CONVERT(nvarchar(30), MA.CreationDateTime, 21) Crea, cdAT.Code Cod,dbo.fn_GEN_FormatDate(MA.ActivityDateTime, 'ES') AS Fecha, cdAT.DescSpanish AS Actividad, MA.Notes AS Observaciones, MA.UserId Usuario " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdAT ON MA.Type = cdAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND MA.Project = '" + S + "' AND cdAT.FunctionalArea = 'CLIN' AND MA.MemberId = " + PacienteV.Text + " AND Type NOT IN ('CMLF', 'COMF', 'CONF', 'NUTF')"
        bdGrid(sql, HistorialGrid)
        HistorialGrid.Columns.Item(1).Visible = False 'creat
        HistorialGrid.Columns.Item(2).Visible = False 'Tipo
        agregarColumnaAccion(0, HistorialGrid)
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Columns.Item(1).SortMode = False
        HistorialGrid.Columns.Item(2).SortMode = False
        HistorialGrid.Columns.Item(3).SortMode = False
        HistorialGrid.Columns.Item(4).SortMode = False
    End Sub

    Private Sub HistorialGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        Dim f, c As Integer
        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y

        If c = 0 And f >= 0 Then
            Dim tipo As String = HistorialGrid.Item(2, f).Value()
            Dim creat As String = HistorialGrid.Item(1, f).Value()

            Dim msg As String = "¿Esta seguro de borrar la actividad?"
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox(msg, style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberActivity SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + '" + U + "' " + _
                      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + PacienteV.Text + " " + _
                      "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + tipo + "'"
                bdEjecutarSQL(sql)
                historial()
            End If
        End If
    End Sub

    Private Sub HistorialL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialL.Click
        historial()
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable
        sql = "SELECT FirstNames + ' ' +  LastNames As CompleteName, dbo.fn_GEN_CalcularEdad(BirthDate) AS Edad, LastFamilyId Familia FROM  dbo.Member M " + _
                                   "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            NombreV.Text = chequearValor(listTable.Rows(f)("CompleteName"))
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad"))
            FamiliaV.Text = listTable.Rows(f)("Familia")
            PanelSecundario.Visible = True
            GuardarButton.Visible = True
        Next

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
            nxt.transac = "IACM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarCamposActividad()
        GuardarButton.Visible = True
        FechaPicker.Value = Today
        ActividadesCombo.SelectedIndex = -1
        ObservacionesV.Text = ""
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ActividadesSalud
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

    Private Function valida() As Boolean
        valida = True
        If Len(ActividadesCombo.Text) = 0 Then
            MsgBox("Necesita seleccionar la actividad", vbQuestion, My.Resources.versionFamilias2)
            valida = False
        End If
    End Function

    Private Sub validaPaciente()
        If miembroEsValido(S, PacienteV.Text) = True Then
            If tieneDerechosSalud(S, PacienteV.Text) = True Then
                sql = "SELECT LastFamilyId as Familia FROM dbo.Member M WHERE RecordStatus= ' '  AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
                FamiliaV.Text = bdEntero(sql, "Familia")
                If familiaEsValida(S, FamiliaV.Text) Then
                    valoresIniciales()
                    FamiliaV.Enabled = False
                    PacienteV.Enabled = False
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

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish actividad FROM dbo.CdMemberActivityType WHERE FunctionalArea = 'CLIN' AND Project IN ('*', '" + S + "') AND Active = 1 "
        bdCombo(sql, ActividadesCombo, "Code", "actividad")

        PrincipalTable.Visible = True
        infoGen()
        historial()
    End Sub

End Class