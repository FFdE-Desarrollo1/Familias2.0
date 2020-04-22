Public Class ReportesAmbienteSeg
    Dim gradoSel, trans, codeRazones As String

    Private Sub ReportesAmbienteSeg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        ValoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()

        Dim cSel As String
        If Len(CategoriaCombo.Text) > 0 Then
            cSel = "AND Categoria = '" + CategoriaCombo.Text + "'"
        Else
            cSel = ""
        End If

        sql = "SELECT * FROM dbo.v_ENE_Reportes " + _
              "WHERE Grado = '" + GradoCombo.Text + "' " + cSel
        bdGrid(sql, ListadoGrid)

        'ListadoGrid.Columns.Item(2).Visible = False
        ListadoGrid.Visible = True
        ListadoGrid.Columns(2).Frozen = True
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New ReportesAmbienteSeg
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ValoresIniciales()
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
            sql = "SELECT EducationLevel L FROM CdGrade WHERE Code = '" + gradoSel + "' "
            GradoCombo.SelectedValue = gradoSel
            GradoCombo.Enabled = False
        Else
            gradoSel = ""
        End If

        ''categorias
        sql = "SELECT Code, DescSpanish D FROM  CdReportCategoryENE "
        bdCombo(sql, CategoriaCombo, "Code", "D")
    End Sub

    Private Sub ListadoButton_Click(sender As Object, e As EventArgs) Handles ListadoButton.Click
        If Len(AñoEscolar.Text) > 0 And GradoCombo.SelectedIndex > -1 Then
            listado()
        End If

    End Sub


End Class