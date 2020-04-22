Public Class ReportesPREPA
    Dim gradoSel As String

    Private Sub NotasPorGradoPREPA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        ValoresIniciales()
    End Sub

    Private Sub AlumnosFM()
        ListadoGrid.Visible = False
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT Grado, dbo.fn_ENE_totalMF_PREP(Grado, 'F') AS F, dbo.fn_ENE_totalMF_PREP(Grado, 'M') AS M, COUNT(*) AS Total " + _
              "FROM dbo.v_ENE_CalificacionesPREPA L " + _
              "WHERE Ciclo = 'Micro I' AND AñoEscolar = " + AñoV.Text + " " + _
              "GROUP BY Grado "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Visible = True
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub Calificaciones()
        ListadoGrid.Visible = False
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT * " + _
              "FROM dbo.v_ENE_CalificacionesPREPA L " + _
              "WHERE Grado = '" + GradoCombo.Text + "' AND Ciclo = '" + CicloCombo.Text + "' AND AñoEscolar = " + AñoV.Text + " " + _
              "ORDER BY Apellidos, Nombres "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(0).Visible = False 'año
        ListadoGrid.Columns.Item(1).Visible = False 'sitio
        listadoFormat()
        ListadoGrid.Visible = True
        ListadoGrid.Columns(4).Frozen = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listadoFormat()
        For i = 0 To ListadoGrid.Columns.Count - 1
            ListadoGrid.Columns(i).HeaderCell.Style.Font = New Font("Arial Narrow", 9)
        Next
    End Sub

    Private Sub ListadoButton_Click(sender As Object, e As EventArgs) Handles ListadoButton.Click
        If Len(AñoV.Text) > 0 And GradoCombo.SelectedIndex > -1 And CicloCombo.SelectedIndex > -1 And TipoCombo.SelectedIndex > -1 Then
            AñoV.Enabled = False
            If TipoCombo.Text = "Calificaciones" Then
                MsgBox("Este reporte puede tardar unos segundos en mostrarse", vbQuestion, My.Resources.versionFamilias2)
                Calificaciones()
                nAlumnosL.Text = "Alumnos: " + ListadoGrid.RowCount.ToString
                nAlumnosL.Visible = True
            ElseIf TipoCombo.Text = "Para Maestros" Then
                MsgBox("Este reporte puede tardar unos segundos en mostrarse", vbQuestion, My.Resources.versionFamilias2)
                ParaMaestros()
                nAlumnosL.Text = "Alumnos: " + ListadoGrid.RowCount.ToString
                nAlumnosL.Visible = True
            ElseIf TipoCombo.Text = "Alumnos Por M/F ***" Then
                AlumnosFM()
            ElseIf TipoCombo.Text = "Promedio Por Grado ***" Then
                PromedioPorGrado()
            Else
            End If

        Else
            MsgBox("Tiene que llenar todos los campos ", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New ReportesPREPA
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ParaMaestros()
        ListadoGrid.Visible = False
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT Apellidos, Nombres, Grado, Ciclo _Destrezas, [_Comunicación y Lenguaje], " + _
              "[_Medio Social y Natural], [_Educación Musical], [_Educación Física], _Inglés, _Promedio " + _
              "FROM dbo.v_ENE_CalificacionesPREPA L " + _
              "WHERE Grado = '" + GradoCombo.Text + "' AND Ciclo = '" + CicloCombo.Text + "' AND AñoEscolar = " + AñoV.Text + " " + _
              "ORDER BY Apellidos, Nombres "
        bdGrid(sql, ListadoGrid)
        listadoFormat()
        ListadoGrid.Visible = True
        ListadoGrid.Columns(1).Frozen = True
        ListadoGrid.Columns(4).Frozen = False
    End Sub

    Private Sub PromedioPorGrado()
        ListadoGrid.Visible = False
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT Grado, Ciclo, AVG(Destrezas) AS Destrezas, AVG([Comunicación y Lenguaje]) AS [Comunicación y Lenguaje], " + _
              "AVG([Medio Social y Natural]) AS [Medio Social y Natural], AVG([Educación Musical]) AS [Educación Musical], " + _
              "AVG([Educación Física]) AS [Educación Física], AVG(Inglés) AS Inglés " + _
              "FROM dbo.v_ENE_CalificacionesPREPA L " + _
              "WHERE Ciclo = '" + CicloCombo.Text + "' AND AñoEscolar = " + AñoV.Text + " " + _
              "GROUP BY Grado, Ciclo "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Visible = True
    End Sub

    Private Sub ValoresIniciales()
        AñoV.Text = Now.Year.ToString

        ''Grado
        sql = "SELECT Code, DescSpanish FROM CdGrade WHERE EducationLevel = 'PREP' " + _
                "AND Code NOT IN ('DI', 'ET1', 'ET2', 'ET3', 'ET4', 'ET5', 'ET6') ORDER BY Orden"
        bdCombo(sql, GradoCombo, "Code", "DescSpanish")

        sql = "SELECT CASE WHEN CustomField3 IS NULL THEN '' ELSE CustomField3 END Grado FROM FwEmployee WHERE EmployeeId = '" + U + "'"
        gradoSel = bdPalabra(sql, "Grado")
        If Len(gradoSel) > 0 Then
            sql = "SELECT EducationLevel L FROM CdGrade WHERE Code = '" + gradoSel + "' "
            GradoCombo.SelectedValue = gradoSel
            GradoCombo.Enabled = False
        Else
            gradoSel = ""
        End If

        ''ciclo
        sql = "SELECT Cycle, DescSpanish D FROM CdCycleENE WHERE Active = 1 "
        bdCombo(sql, CicloCombo, "Cycle", "D")
    End Sub


End Class