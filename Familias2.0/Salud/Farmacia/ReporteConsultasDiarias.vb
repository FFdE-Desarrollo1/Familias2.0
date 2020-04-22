' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReporteConsultasDiarias
    Dim idC As Integer = 0

    Private Sub ReporteConsultasDiarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        listado()
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
        RecetaSelGrid.DataSource = Nothing
        RecetaSelGrid.Rows.Clear()
        sql = "SELECT * FROM dbo.fn_HEAL_FARM_informeConsultasDiarias('" + DateP.Value.ToString(en.DateTimeFormat) + "') " + _
              "ORDER BY 'Meds Entregadas', IdConsultation DESC "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(0).Visible = False 'IdConsul

        For i = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
        PacienteL.Visible = False
        MedicoL.Visible = False
        FarmaciaL.Visible = False
        RecetaSelGrid.Visible = False
    End Sub

    Private Sub ListadoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoButton.Click
        listado()
    End Sub

    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        Dim fila As Integer
        fila = ListadoGrid.CurrentCellAddress.Y()

        PacienteL.Text = ListadoGrid.Item(3, fila).Value + " (" + ListadoGrid.Item(2, fila).Value.ToString + ")"
        MedicoL.Text = "Médico: " + chequearValor(ListadoGrid.Item(7, fila).Value)
        FarmaciaL.Text = chequearValor(ListadoGrid.Item(11, fila).Value)
        idC = ListadoGrid.Item(0, fila).Value

        RecetaSelGrid.DataSource = Nothing
        RecetaSelGrid.Rows.Clear()
        RecetaSelGrid.Visible = False
        sql = "SELECT HITM.Item + ' - ' + cdII.DescSpanish + ' (' + cdII.DosageDesc_es + ')' AS Medicina, HITM.Quantity * - 1 AS Cantidad, " + _
              "HITM.Indications AS Indicaciones, HITM.Notes AS Notas, dbo.fn_GEN_FormatDate(HITM.PayDateTime, 'ES') Pago, " + _
              "dbo.fn_GEN_FormatDate(HITM.DeliveryDateTime, 'ES') Entrega, CASE WHEN Exoneration = 0 THEN '' ELSE 'Si' END Exoneración, " + _
              "CASE WHEN HITM.ByCredit = 0 THEN '' ELSE 'Si' END 'Al credito' " + _
              "FROM dbo.HealthInventoryTransactionMedi HITM INNER JOIN dbo.CdHealthInventoryItem cdII ON HITM.Item = cdII.Code " + _
              "WHERE HITM.RecordStatus = ' ' AND HITM.Quantity  < 0 AND HITM.IdConsultation = " + idC.ToString
        bdGrid(sql, RecetaSelGrid)

        For i = 0 To RecetaSelGrid.Rows.Count - 1
            RecetaSelGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next

        PacienteL.Visible = True
        MedicoL.Visible = True
        FarmaciaL.Visible = True
        RecetaSelGrid.Visible = True
    End Sub


End Class