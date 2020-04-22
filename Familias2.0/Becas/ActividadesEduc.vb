' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActividadesEduc
    Dim actualAñoE, n As Integer

    Private Sub ActividadesEduc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()

        MiembroV.Focus()

        If Len(MiembroV.Text) > 0 Then
            validaMiembro()
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
            If Len(FamiliaV.Text) > 0 And familiaEsValida(S, FamiliaV.Text) = True Then
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
            sql = "INSERT INTO dbo.MemberActivity VALUES ('" + S + "', " + MiembroV.Text + ", '" + ActividadesCombo.SelectedValue + "', '" + _
                  FechaPicker.Value.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, '" + ObservacionesV.Text + "')"
            bdInsertar(sql)
            historial()
            limpiarCamposActividad()
        End If
    End Sub

    Private Sub historial()
        sql = "SELECT 'Borrar' '_', CONVERT(nvarchar(30), MA.CreationDateTime, 21) Crea, cdAT.Code Cod,dbo.fn_GEN_FormatDate(MA.ActivityDateTime, 'ES') AS Fecha, cdAT.DescSpanish AS Actividad, MA.Notes AS Observaciones, MA.UserId Usuario " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdAT ON MA.Type = cdAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND MA.Project = '" + S + "' AND cdAT.FunctionalArea = 'EDUC' AND MA.MemberId = " + MiembroV.Text + " " + _
              "ORDER BY MA.CreationDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.Columns.Item(1).Visible = False 'creat
        HistorialGrid.Columns.Item(2).Visible = False 'Tipo
        If n > 1 Then
            agregarColumnaAccion(0, HistorialGrid)
        Else
            HistorialGrid.Columns.Item(0).Visible = False 'borrar
        End If

        HistorialGrid.AutoResizeColumns()
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
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
                      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
                      "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + tipo + "'"
                bdEjecutarSQL(sql)
                historial()
            End If
        End If
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable
        Dim secc As String = ""

        sql = "SELECT * " + _
                 "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + AñoV.Text + ") L "
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            'Info General
            NombreV.Text = listTable.Rows(f)("Nombres") + " " + listTable.Rows(f)("Apellidos")
            'EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad"))
            FamiliaV.Text = listTable.Rows(f)("Familia")
            FamiliaV.ReadOnly = True

            If esApadrinado(S, MiembroV.Text) = True Then
                ' Info Educ
                GradoV.Text = chequearValor(listTable.Rows(0)("Grado"))
                EstadoV.Text = chequearValor(listTable.Rows(0)("Estado_Educ"))
                EscuelaV.Text = chequearValor(listTable.Rows(0)("Escuela"))
            End If
        Next

        MiembroV.Enabled = False
        PanelSecundario.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, FamiliaV.Text) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "RAEM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbInformation, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarCamposActividad()
        GuardarButton.Visible = True
        FechaPicker.Value = Today
        ActividadesCombo.SelectedIndex = -1
        ObservacionesV.Text = ""
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            validaMiembro()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ActividadesEduc
        nxt.Show()
        Me.Close()
    End Sub

    Private Function valida() As Boolean
        valida = True
        If Len(ActividadesCombo.Text) = 0 Then
            MsgBox("Necesita seleccionar la actividad", vbQuestion, My.Resources.versionFamilias2)
            valida = False
        End If
    End Function

    Private Sub validaMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            If esApadrinado(S, MiembroV.Text) = True Then
                valoresIniciales()
            Else
                MsgBox("Esta pantalla es solo para apadrinados", vbQuestion, My.Resources.versionFamilias2)
                MiembroV.Text = ""
                FamiliaV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT dbo.fn_BECA_actualizaInfoEduc('" + S + "', '" + U + "') Resul "
        n = bdEntero(sql, "Resul")
        If n = 0 Then
            FechaPicker.Visible = False
            FechaL.Visible = False
            ActividadesCombo.Visible = False
            ActividadL.Visible = False
            ActividadTL.Visible = False
            NotasL.Visible = False
            ObservacionesV.Visible = False
        Else
            sql = "SELECT CASE WHEN MAX(SchoolYear) IS NULL THEN 0 ELSE MAX(SchoolYear) END  Ultimo FROM dbo.MemberEducationYear WHERE  RecordStatus = ' ' and Project = '" + S + "' AND Memberid = " + MiembroV.Text
            actualAñoE = bdEntero(sql, "Ultimo")
        End If


        If actualAñoE = 0 Then
            If DateTime.Now.Month >= 10 Then
                actualAñoE = DateTime.Now.Year
            Else
                actualAñoE = DateTime.Now.Year - 1
            End If
        End If

        AñoV.Text = actualAñoE.ToString

        sql = "SELECT Code, DescSpanish actividad FROM dbo.CdMemberActivityType WHERE FunctionalArea = 'EDUC' AND Project IN ('*', '" + S + "') AND Active = 1 "
        bdCombo(sql, ActividadesCombo, "Code", "actividad")

        infoGen()
        historial()
        ActividadesTable.Visible = True
        GuardarButton.Visible = True
    End Sub
End Class