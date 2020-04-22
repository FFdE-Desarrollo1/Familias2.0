' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class CobrosFarmaciaPendientes
    Dim año As String = Today.Year.ToString
    Dim total As Integer

    Private Sub CobrosFarmaciaPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        porTipo()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub detalle()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        TotalL.Visible = False
        sql = "SELECT Sitio, No_Miembro, Paciente, Familia, Médico, Medicina, Cantidad, Total " + _
                  "FROM  v_FARM_RecetasPendientes " + _
                  "WHERE Total > 0 AND ( Exonerado = 'No' Or AlCredito = 'No')  AND Pago IS NULL " + _
                  "ORDER BY Sitio, Paciente "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()

        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
        TotalL.Visible = True
        ListadoGrid.Visible = True
    End Sub

    Private Sub detalleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles detalleRadio.CheckedChanged
        If detalleRadio.Checked = True Then
            detalle()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub porTipo()
        total = 0
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        TotalL.Visible = False

        sql = "SELECT Sitio, No_Miembro, Paciente, Familia, Médico, ROUND(SUM(Total) , 2 ) Total, COUNT(Medicina) Medicinas " + _
                 "FROM  v_FARM_RecetasPendientes " + _
                 "WHERE Total > 0 AND ( Exonerado = 'No' Or AlCredito = 'No')  AND Pago IS NULL " + _
                 "GROUP BY Sitio, No_Miembro, Paciente, Familia, Médico " + _
                 "ORDER BY Sitio, Paciente "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()
        TotalL.Visible = False
        ListadoGrid.Visible = True
    End Sub

    Private Sub tipoRadio_CheckedChanged(sender As Object, e As EventArgs) Handles tipoRadio.CheckedChanged
        If tipoRadio.Checked = True Then
            porTipo()
        End If
    End Sub
End Class