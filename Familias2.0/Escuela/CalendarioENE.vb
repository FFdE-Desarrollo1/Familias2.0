Public Class CalendarioENE
    Dim tipo As String = "Nuevo"
    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
    Dim response As MsgBoxResult

    Private Sub CalendarioENE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub listado()
        sql = "SELECT Code, Year AS Año, Month AS Mes, Week AS Semana, WeekNumber AS NoSemana, Attendance AS Asistencia, " + _
              "Unit AS Ciclo, CreationDateTime AS Fecha, UserId AS Usuario " + _
              "FROM dbo.CdCalendarENE WHERE Year = " + AñoV.Text
        bdGrid(sql, FechasGrid)
        FechasGrid.Columns(0).Visible = False 'Codigo
    End Sub

    Private Sub valoresIniciales()
        AñoV.Text = Now.Year.ToString

        sql = "SELECT 1 Codigo, 'Ene' Mes UNION ALL SELECT 2 , 'Feb'  UNION ALL SELECT 3 , 'Mar' " + _
              "UNION ALL SELECT 4 , 'Abr' UNION ALL SELECT 5 , 'May'  UNION ALL SELECT 6 , 'Jun' " + _
              "UNION ALL SELECT 7 , 'Jul' UNION ALL SELECT 8 , 'Ago'  UNION ALL SELECT 9 , 'Sep' " + _
              "UNION ALL SELECT 10 , 'Oct' UNION ALL SELECT 11 , 'Nov'  UNION ALL SELECT 12 , 'Dic' "
        bdCombo(sql, MesCombo, "Codigo", "Mes")

        sql = "SELECT Cycle, DescSpanish D FROM CdCycleENE WHERE Active = 1 "
        bdCombo(sql, CicloCombo, "Cycle", "D")
        listado()
    End Sub

    Private Sub FechasGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles FechasGrid.CellContentDoubleClick
        Dim f, c As Integer
        c = FechasGrid.CurrentCellAddress.X
        f = FechasGrid.CurrentCellAddress.Y
        response = MsgBox("¿Esta seguro de modificar la semana " + FechasGrid.Item(3, f).Value() + "?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            tipo = "Modificar"
            MesCombo.SelectedValue = FechasGrid.Item(2, f).Value()
            NoSemanaV.Text = FechasGrid.Item(4, f).Value()
            AsistenciasV.Text = FechasGrid.Item(5, f).Value()
            CicloCombo.SelectedValue = FechasGrid.Item(6, f).Value()
            'Del.SelectedValue = FechasGrid.Item(6, f).Value()
        End If



    End Sub
End Class