' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class EstadisticasEnfermeria
    Dim total As Integer

    Private Sub EstadisticasEnfermeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        DeFecha.Value = Convert.ToDateTime(DeFecha.Value.Year.ToString + "/" + DeFecha.Value.Month.ToString + "/01")
    End Sub

    Private Sub AtendidosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtendidosButton.Click
        sql = "SELECT AtendidoPor, COUNT(*) Total FROM  dbo.fn_HEAL_ENFE_Tratamientos('" + DateTime.Now.ToString(en.DateTimeFormat) + "')" + _
              "WHERE AtendidoPor IS NOT NULL AND (CAST(CONVERT(NVARCHAR, TreatDateTime, 112) AS smallDateTime) " + _
              "BETWEEN CAST(CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime) AND " + _
              "CAST(CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime)) " + _
              "GROUP BY AtendidoPor " + _
              "ORDER BY AtendidoPor "
        generarListado(sql)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub generarListado(ByVal list As String)
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        bdGrid(list, ListadoGrid)
        ListadoGrid.AutoResizeColumns()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PendientesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendientesButton.Click
        sql = "SELECT RefDateTime, Referido, COUNT(*) Pacientes, SUM(Cantidad) Total FROM  dbo.fn_HEAL_ENFE_Tratamientos('" + DateTime.Now.ToString(en.DateTimeFormat) + "')" + _
              "WHERE AtendidoPor IS NULL AND (CAST(CONVERT(NVARCHAR, RefDateTime, 112) AS smallDateTime) " + _
              "BETWEEN CAST(CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime) AND " + _
              "CAST(CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime)) " + _
              "GROUP BY RefDateTime, Referido " + _
              "ORDER BY RefDateTime"
        generarListado(sql)
        ListadoGrid.Columns.Item(0).Visible = False 'fecha
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
    End Sub

    Private Sub porMedicoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles porMedicoButton.Click
        sql = "SELECT Médico,  COUNT(*) Pacientes, SUM(Cantidad) Tratamientos FROM  dbo.fn_HEAL_ENFE_Tratamientos('" + DateTime.Now.ToString(en.DateTimeFormat) + "')" + _
              "WHERE Médico Is Not null AND (CAST(CONVERT(NVARCHAR, RefDateTime, 112) AS smallDateTime) " + _
              "BETWEEN CAST(CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime) AND " + _
              "CAST(CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime)) " + _
              "GROUP BY Médico " + _
              "ORDER BY Médico "
        generarListado(sql)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
    End Sub

    Private Sub PorTratamientosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorTratamientosButton.Click
        sql = "SELECT Tratamiento, COUNT(*) Pacientes, SUM(Cantidad) Total FROM  dbo.fn_HEAL_ENFE_Tratamientos('" + DateTime.Now.ToString(en.DateTimeFormat) + "')" + _
                "WHERE (CAST(CONVERT(NVARCHAR, TreatDateTime, 112) AS smallDateTime) " + _
                "BETWEEN CAST(CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime) AND " + _
                "CAST(CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime)) " + _
              "GROUP BY Tratamiento " + _
              "ORDER BY COUNT(*) DESC "
        generarListado(sql)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
    End Sub

    Private Sub ListadoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoButton.Click
        sql = "SELECT Sitio, Paciente, Nombre, Familia, Edad, Médico, Referido Referencia, Tratamiento, Cantidad, Instrucciones, Atendido, AtendidoPor, Observaciones_Enfermería " + _
              "FROM  dbo.fn_HEAL_ENFE_Tratamientos('" + DateTime.Now.ToString(en.DateTimeFormat) + "')" + _
              "WHERE ((CAST(CONVERT(NVARCHAR, RefDateTime, 112) AS smallDateTime) " + _
              "BETWEEN CAST(CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime) AND " + _
              "CAST(CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime)))  OR " + _
              "((CAST(CONVERT(NVARCHAR, TreatDateTime, 112) AS smallDateTime) " + _
              "BETWEEN CAST(CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime) AND " + _
              "CAST(CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime))) " + _
              "ORDER BY RefDateTime "
        generarListado(sql)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
    End Sub

    Private Sub TratamientosDiaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TratamientosDiaButton.Click
        sql = "SELECT TreatDT, Tratamiento, Atendido, COUNT(*) Pacientes, SUM(Cantidad) Total FROM  dbo.fn_HEAL_ENFE_Tratamientos('" + DateTime.Now.ToString(en.DateTimeFormat) + "')" + _
              "WHERE TreatDT  " + _
              "BETWEEN CONVERT(datetime, CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 111)) AND " + _
              "CONVERT(datetime, CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 111)) " + _
              "GROUP BY TreatDT, Tratamiento, Atendido " + _
              "ORDER BY TreatDT"
        generarListado(sql)
        ListadoGrid.Columns.Item(0).Visible = False 'fecha
        total = 0
    End Sub
End Class