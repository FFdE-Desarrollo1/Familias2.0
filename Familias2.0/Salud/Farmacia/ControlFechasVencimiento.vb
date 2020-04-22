' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ControlFechasVencimiento

    Private Sub ControlFechasVencimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub actualizar(ByVal trans As String, ByVal creat As String, ByVal item As String, ByVal quant As Integer, ByVal fini As String)
        If fini = "Si" Then
            MsgBox("El código " + item.ToString + " ya esta finalizado", vbQuestion, My.Resources.versionFamilias2)
        Else
            sql = "UPDATE dbo.HealthInventoryTransaction  SET FinishedMed = 1 " + _
                  "WHERE RecordStatus = ' ' AND Project = 'F'  AND Category = 'MEDI' AND TransactionDateTime = convert(nvarchar,'" + trans + "',21) " + _
                  "AND CreationDateTime = convert(nvarchar,'" + creat + "',21) AND Item = '" + item + "' AND Quantity = " + quant.ToString
            bdInsertar(sql)
            listado()
        End If

    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        For f = 0 To HistorialGrid.Rows.Count - 1
            If HistorialGrid.Item(0, f).Value() = True Then
                actualizar(HistorialGrid.Item(10, f).Value(), HistorialGrid.Item(11, f).Value(), HistorialGrid.Item(1, f).Value(),
                           HistorialGrid.Item(7, f).Value(), HistorialGrid.Item(9, f).Value())
            End If
        Next
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        Listado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        If Len(MedsCombo.Text) = 0 Then
        Else
            HistorialGrid.DataSource = Nothing
            HistorialGrid.Rows.Clear()

            sql = "SELECT * FROM fn__HEAL_FARM_IngresosInventarioFarmacia('" + DeFechaPicker.Value.ToString(en.DateTimeFormat) + "','" + AFechaPicker.Value.ToString(en.DateTimeFormat) + "')  " + _
                  "WHERE Code = '" + MedsCombo.SelectedValue.ToString + "' " + _
                  "ORDER BY ExpirationDateMed "
            bdGrid(sql, HistorialGrid)
            HistorialGrid.AutoResizeColumns()
            HistorialGrid.Columns.Item(2).Visible = False 'Precio
            HistorialGrid.Columns.Item(10).Visible = False 'TransactionDateTime
            HistorialGrid.Columns.Item(11).Visible = False 'CreationDateTime
            HistorialGrid.Columns.Item(12).Visible = False 'ExpirationDateTime

            sql = "SELECT ROUND(Price, 2) Price FROM dbo.CdHealthInventoryItem WHERE Code = '" + MedsCombo.SelectedValue.ToString + "'"
            PrecioActualV.Text = bdDoble(sql, "Price")

            sql = "SELECT CurrentQuantity Cantidad  FROM dbo.CdHealthInventoryItem WHERE Code = '" + MedsCombo.SelectedValue.ToString + "'"
            ExistenciaV.Text = bdDoble(sql, "Cantidad")

            sql = "SELECT dbo.fn_HEAL_FARM_VencimientoMasReciente('" + MedsCombo.SelectedValue.ToString + "') Fecha"
            UltimaFechaV.Text = bdPalabra(sql, "Fecha")

            If Len(UltimaFechaV.Text) = 0 Then
                UltimaFechaL.BackColor = Color.DodgerBlue
                UltimaFechaL.ForeColor = Color.White
            Else
                UltimaFechaL.BackColor = Color.White
                UltimaFechaL.ForeColor = Color.Black
            End If

            PrecioActualL.Visible = True
            PrecioActualV.Visible = True

            UltimaFechaL.Visible = True
            UltimaFechaV.Visible = True
            ExistenciaV.Visible = True
            ExistenciaL.Visible = True
            GuardarButton.Visible = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ControlFechasVencimiento
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT cdII.Code, cdII.Code + ' - ' + CASE WHEN cdII.DosageDesc_es IS NULL THEN cdII.DescSpanish ELSE cdII.DescSpanish + ' (' + cdII.DosageDesc_es + ')' END Med " + _
              "FROM dbo.CdHealthInventoryItem cdII WHERE Active = 1 AND ValidSelection = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, MedsCombo, "Code", "Med")

        DeFechaPicker.Value = DateTime.Parse(DateTime.Today.Year.ToString + "/01/01")
    End Sub
End Class