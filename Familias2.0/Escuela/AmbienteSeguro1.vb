Public Class AmbienteSeguro1
    Dim gradoSel, trans, codeRazones, miembroSel As String

    Private Sub AmbienteSeguro1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        ValoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub CatCodL_TextChanged(sender As Object, e As EventArgs) Handles CatCodL.TextChanged
        If CatCodL.Text = "0" Then
        Else
            razonesLista()
            DetReporteTable.Visible = True
            GuardarButton.Visible = True
        End If
    End Sub

    Private Sub CategoriaCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CategoriaCombo.SelectionChangeCommitted
        If CategoriaCombo.SelectedIndex = -1 Then
        Else
            CatCodL.Text = CategoriaCombo.SelectedValue
        End If
    End Sub

    Private Sub guardar()
        Dim numero As Integer = numeroReporte() + 1
        sql = "INSERT INTO MemberEducationReportENE VALUES('" + S + "'," + miembroSel + ", " + AñoV.Text + "," + numero.ToString + ",'" + _
              CategoriaCombo.SelectedValue + "', '" + FechaPicker.Value.ToString(en.DateTimeFormat) + "', '" + U + "', '', NULL, '" + codeRazones + "', '" + ObservacionesV.Text + "',NULL,NULL,NULL,NULL)"
        'InputBox("", "", sql)
        bdInsertar(sql)
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        codeRazones = razonesSeleccionadas()
        If Len(miembroSel) > 1 And Len(CategoriaCombo.SelectedValue) > 0 And Len(codeRazones) > 1 Then
            GuardarButton.Visible = True
            guardar()
            listado()
            ReportesPorCategoria(miembroSel) ', CategoriaCombo.SelectedValue)
            MsgBox("El reporte se ingresado correctamente", vbQuestion, My.Resources.versionFamilias2)
            limpiarCampos()
        Else
            MsgBox("Tiene que llenar todos los campos con * ", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT M.LastNames AS Apellidos, M.FirstNames AS Nombres, M.MemberId AS Miembro " + _
              ", dbo.fn_ENE_nReportesCat(M.MemberId, " + AñoV.Text + ", 'COND') 'Conducta' " + _
              ", dbo.fn_ENE_nReportesCat(M.MemberId, " + AñoV.Text + ", 'ACAD') 'Academicos' " + _
              ", dbo.fn_ENE_nReportesCat(M.MemberId, " + AñoV.Text + ", 'ACCI') 'Accidentes' " + _
              ", dbo.fn_ENE_nReportesCat(M.MemberId, " + AñoV.Text + ", 'ENFE') 'Enfermedad' " + _
              "FROM dbo.Member M INNER JOIN dbo.MemberEducationYear MEY ON M.Project = MEY.Project " + _
              "AND M.MemberId = MEY.MemberId AND M.RecordStatus = MEY.RecordStatus  " + _
              "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "'  " + _
              "AND MEY.SchoolYear = " + AñoV.Text + " AND MEY.Grade = '" + GradoCombo.SelectedValue + "' " +
              " ORDER BY M.LastNames, M.FirstNames "
        bdGrid(sql, ListadoGrid)
        For i = 2 To 6
            ListadoGrid.Columns(i).HeaderCell.Style.Font = New Font("Arial Narrow", 8)
        Next

        ListadoGrid.Columns.Item(2).Visible = False
        ListadoGrid.Visible = True
        ListadoGrid.Columns(1).Frozen = True
    End Sub

    Private Sub ListadoGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoGrid.CellDoubleClick
        Dim cat As String = ""
        Dim f = ListadoGrid.CurrentCellAddress.Y
        Dim c = ListadoGrid.CurrentCellAddress.X
        miembroSel = ListadoGrid.Item(2, f).Value()
        Dim nombre = ListadoGrid.Item(0, f).Value() + ", " + ListadoGrid.Item(1, f).Value()

        If c = 3 Then
            cat = "Conducta" ' "COND"
        ElseIf c = 4 Then
            cat = "Académico" '  "ACAD"
        ElseIf c = 5 Then
            cat = "Accidente" ' "ACCI"
        Else
            cat = "Enfermedad" ' "ENFE"
        End If

        ReportesPorCategoria(miembroSel) ', cat)
        nuevoReporte(miembroSel, nombre)
    End Sub

    Private Sub nuevoReporte(ByVal miembro As String, ByVal nombre As String)
        'MiembroV.Text = miembro
        AlumnoV.Text = nombre + " - " + nombre
        MemberInfoTable.Visible = True
        'DetReporteTable.Visible = True
    End Sub

    Private Sub limpiarCampos()
        RazonList.DataSource = Nothing
        miembroSel = ""
        AlumnoV.Text = ""
        ObservacionesV.Text = ""
        FechaPicker.Value = Today
        CategoriaCombo.SelectedValue = -1
    End Sub

    Private Sub ListadoButton_Click(sender As Object, e As EventArgs) Handles ListadoButton.Click
        If Len(AñoV.Text) > 0 And Len(GradoCombo.SelectedValue.ToString) > 0 Then
            FechaL.Visible = True
            FechaPicker.Visible = True
            CategoriaL.Visible = True
            CategoriaCombo.Visible = True
            ObservacionesL.Visible = True
            ObservacionesV.Visible = True
            listado()
            ListadoCatGrid.Visible = False
            DetReporteTable.Visible = False
            MemberInfoTable.Visible = False
        Else
            MsgBox("Tiene que llenar todos los campos ", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New CalificacionesPREPA
        nxt.Show()
        Me.Close()
    End Sub

    Private Function numeroReporte() As Integer
        sql = "SELECT CASE WHEN MAX(ReportNumber) IS NULL THEN 0 ELSE MAX(ReportNumber) END 'M' " + _
              "FROM MemberEducationReportENE WHERE RecordStatus = ' ' AND Project = '" + S + "' " + _
              "AND MemberId = " + miembroSel + " AND SchoolYear = " + AñoV.Text + " AND Category = '" + CategoriaCombo.SelectedValue + "' "
        numeroReporte = bdEntero(sql, "M")
    End Function

    Private Sub razonesLista()
        'RazonList.ClearSelected()
        Dim razones As New DataTable
        sql = "SELECT Code, DescSpanish 'Desc' FROM CdReportCategoryReasonENE WHERE ReportCategory = '" + _
              CategoriaCombo.SelectedValue + "' AND Active = 1 " + _
              "ORDER BY OrderList "
        'InputBox("", "", sql)
        bdDataTable(sql, razones)

        If razones.Rows.Count > 0 Then
            RazonList.DataSource = razones
            RazonList.ValueMember = "Code"
            RazonList.DisplayMember = "Desc"
        End If
    End Sub

    Private Function razonesSeleccionadas() As String
        Dim raz As String = ""
        razonesSeleccionadas = ""
        For i As Integer = 0 To RazonList.Items.Count - 1
            If (RazonList.GetItemChecked(i)) Then
                Dim dtrv As DataRowView = CType(RazonList.Items(i), DataRowView)
                Dim dtr As DataRow = dtrv.Row
                Dim dtrValueMember As String = dtr(RazonList.ValueMember).ToString()
                raz = raz + dtrValueMember + ":"
            End If
        Next
        razonesSeleccionadas = raz
        'Dim razonesSel As String = ""
        'For i = 0 To RazonList.Items.Count - 1
        '    razonesSel = razonesSel + 
        'Next

        'RazonList.DataSource = razones
        'RazonList.ValueMember = "Code"
        'RazonList.DisplayMember = "Desc"
        '    End If
    End Function

    Private Sub ReportesPorCategoria(ByVal miembro As String) ', ByVal categoria As String)
        ListadoCatGrid.DataSource = Nothing
        ListadoCatGrid.Rows.Clear()
        sql = "SELECT ReportNumber 'No.', cdC.DescSpanish Categoria, CONVERT(varchar,CreationDateTime,105) Fecha, NotesReasons Observaciones, R1.DescSpanish AS R1, " + _
              "R2.DescSpanish AS R2, R3.DescSpanish AS R3,  R4.DescSpanish AS R4, R5.DescSpanish AS R5 " + _
              "FROM dbo.MemberEducationReportENE INNER JOIN  CdReportCategoryENE cdC ON cdC.Code = Category " + _
              "LEFT JOIN CdReportCategoryReasonENE R1 ON R1.Code = RTRIM(SUBSTRING(Reasons, 1, CHARINDEX(':', Reasons) - 1)) " + _
              "LEFT JOIN CdReportCategoryReasonENE R2 ON R2.Code = RTRIM(SUBSTRING(Reasons, 6, CHARINDEX(':', Reasons) - 1)) " + _
              "LEFT JOIN CdReportCategoryReasonENE R3 ON R3.Code = RTRIM(SUBSTRING(Reasons, 11, CHARINDEX(':', Reasons) - 1)) " + _
              "LEFT JOIN CdReportCategoryReasonENE R4 ON R4.Code = RTRIM(SUBSTRING(Reasons, 16, CHARINDEX(':', Reasons) - 1)) " + _
              "LEFT JOIN CdReportCategoryReasonENE R5 ON R5.Code = RTRIM(SUBSTRING(Reasons, 21, CHARINDEX(':', Reasons) - 1)) " + _
              "WHERE RecordStatus = ' ' AND Project = 'N' AND MemberId = " + miembro + " AND SchoolYear = " + AñoV.Text '+ " AND Category = '" + categoria + "'"
        bdGrid(sql, ListadoCatGrid)
        'InputBox("", "", sql)

        ListadoCatGrid.Columns.Item(8).Visible = False
        ListadoCatGrid.Visible = True
        ListadoCatGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub ValoresIniciales()
        trans = "N"
        AñoV.Text = Now.Year.ToString

        ''Grado
        sql = "SELECT Code, DescSpanish Grade FROM CdGrade " + _
              "WHERE EducationLevel IN ('PRIM', 'PREP') AND Code NOT IN ('DI', 'ET1', 'ET2', 'ET3', 'ET4', 'ET5', 'ET6') " + _
              "ORDER BY Rank "
        bdCombo(sql, GradoCombo, "Code", "Grade")

        ''grado del usuario
        sql = "SELECT CASE WHEN CustomField3 IS NULL THEN '' ELSE CustomField3 END Grado FROM FwEmployee WHERE EmployeeId = '" + U + "'"
        gradoSel = bdPalabra(sql, "Grado")
        If Len(gradoSel) > 0 Then
            GradoCombo.SelectedValue = gradoSel
            GradoCombo.Enabled = False
        Else
            gradoSel = ""
        End If

        ''categorias
        sql = "SELECT Code, DescSpanish D FROM  CdReportCategoryENE "
        bdCombo(sql, CategoriaCombo, "Code", "D")
    End Sub


End Class