' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class HistorialEducativo

    Private Sub HistorialEducativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(MiembroV.Text) > 0 Then
            valoresIniciales()
        End If
        MiembroV.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                If familiaEsValida(S, FamiliaV.Text) = True Then
                    irMiembrosDeFamilia()
                Else
                    MsgBox("El número de familia no existe", vbInformation, My.Resources.versionFamilias2)
                    FamiliaV.Text = ""
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub HistorialEduc()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT 'Detalle' 'Revisar',  'Borrar' AS Borrar, CONVERT(nvarchar(30), MEY.CreationDateTime, 21) AS Crea, " + _
              "MEY.SchoolYear Año, CdG.DescSpanish Grado, CdES.DescSpanish Estado, cdEES.DescSpanish ExcepcionEstado, S.Name Escuela, cdEC.DescSpanish Carrera, MEY.Notes Notas, MEY.UserId 'Usuario' " + _
              "FROM	MemberEducationYear MEY INNER JOIN School S On MEY.Project=S.Project and MEY.SchoolCode=S.Code AND MEY.RecordStatus = S.RecordStatus " + _
              "INNER JOIN CdGrade CdG On MEY.Grade=CdG.Code INNER JOIN CdEducationStatus CdES On MEY.Status=CdES.Code " + _
              "LEFT JOIN CdEducationCareer cdEC ON cdEC.Code = MEY.Career " + _
              "LEFT JOIN CdEducationReasonNotToContinue cdEES ON cdEES.Code = MEY.ReasonNotToContinue " + _
              "WHERE MEY.RecordStatus=' ' AND MEY.Project = '" + S + "' AND MEY.MemberId = " + MiembroV.Text + " " + _
              "GROUP BY MEY.SchoolYear, CdG.DescSpanish, cdEES.DescSpanish, CdG.Orden, CdEs.DescSpanish, S.Name, cdEC.DescSpanish, MEY.Notes, MEY.UserId, CONVERT(nvarchar(30), MEY.CreationDateTime, 21) " + _
              "ORDER BY MEY.SchoolYear DESC, CdG.Orden DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.Columns.Item(2).Visible = False 'crea
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        agregarColumnaAccion(0, HistorialGrid)
        agregarColumnaAccion(1, HistorialGrid)
        HistorialGrid.Visible = True
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable

        sql = "SELECT * " + _
              "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + Today.Year.ToString + ") L "
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            'Info General
            NombreV.Text = listTable.Rows(f)("Nombres") + " " + listTable.Rows(f)("Apellidos")
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad"))
            FamiliaV.Text = listTable.Rows(f)("Familia")
            FamiliaV.ReadOnly = True

            TSV.Text = chequearValor(listTable.Rows(0)("TS"))

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
        Dim nxt As New MiembrosFamilia
        nxt.familyId = FamiliaV.Text
        nxt.transac = "RHEM"
        nxt.Show()
        Me.Close()
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
        Dim nxt As New HistorialEducativo
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub validaMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            If esApadrinado(S, MiembroV.Text) = True Or esGraduado(S, MiembroV.Text) = True Or esDesafiliado(S, MiembroV.Text) = True Then
                valoresIniciales()
            Else
                MsgBox("Esta pantalla es solo para apadrinados, desafiliados o graduados", vbQuestion, My.Resources.versionFamilias2)
                MiembroV.Text = ""
                FamiliaV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        infoGen()
        HistorialEduc()
    End Sub

    Private Sub HistorialGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        Dim f, c, año As Integer
        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y
        año = HistorialGrid.Item(3, f).Value()
        If c = 0 Then
            Dim nxt As New AñoEscolar
            nxt.MiembroV.Text = MiembroV.Text
            nxt.FamiliaV.Text = FamiliaV.Text
            nxt.NombreV.Text = NombreV.Text

            nxt.AñoV.Text = año.ToString
            nxt.gradoOr = HistorialGrid.Item(4, f).Value()
            nxt.estadoOr = HistorialGrid.Item(5, f).Value()
            nxt.razonOr = chequearValor(HistorialGrid.Item(6, f).Value())
            nxt.escuelaOr = HistorialGrid.Item(7, f).Value()
            nxt.carreraOr = chequearValor(HistorialGrid.Item(8, f).Value())
            nxt.escuelaCombo.Size = New Point(100 + (Len(chequearValor(HistorialGrid.Item(7, f).Value())) * 5), 21)
            nxt.Show()
            Me.Close()

        ElseIf c = 1 Then
            sql = "SELECT COUNT(*) AS Total FROM dbo.MemberActivity MA INNER JOIN CdMemberActivityType cdMAT ON cdMAT.Code = MA.Type " + _
                     "WHERE MemberId = " + MiembroV.Text + " AND MA.Project = '" + S + "' AND RecordStatus = ' ' AND YEAR(ActivityDateTime)  = " + año.ToString + " AND FunctionalArea = 'EDUC' "
            Dim nAct As Integer = bdEntero(sql, "Total")

            sql = "SELECT COUNT(*) AS Total FROM dbo.MemberReimbursement " + _
                     "WHERE MemberId = " + MiembroV.Text + " AND Project = '" + S + "' AND RecordStatus = ' ' AND YEAR(ApprovedDateTime)  = " + año.ToString + " AND FunctionalArea = 'EDUC' "
            Dim nRee As Integer = bdEntero(sql, "Total")

            If nAct > 0 Or nRee > 0 Then
                MsgBox("No es posible borrar información de un año de educación si ya existe reembolsos o actividades del mismo año. ", vbInformation, My.Resources.versionFamilias2)
            Else
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox("¿Está seguro de borrar el año escolar " + año.ToString + " ?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                Else
                End If

            End If
        End If

    End Sub
End Class