' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActualizarPreciosMeds

    Private Sub ActualizarPreciosMeds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ActualizarPrecio()
        Dim newPrice As Double = Double.Parse(NuevoPrecioV.Text)
        sql = "UPDATE CdHealthInventoryItem SET Price = " + newPrice.ToString("F2") + " WHERE Code = '" + MedBoxV.SelectedValue + "' "
        bdInsertar(sql)
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        ActualizarPrecio()
        QActualV.Text = Double.Parse(precioMedicina(MedBoxV.SelectedValue)).ToString("F2")
        NuevoPrecioV.Text = ""
        GuardarButton.Visible = False
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ActualizarPreciosMeds
        nxt.Show()
        Me.Close()
    End Sub

    Private Function precioMedicina(ByVal codeArti As String) As String
        Dim codeSQL As String
        codeSQL = "SELECT CASE WHEN Price IS NULL THEN 0 ELSE Price END AS Price FROM dbo.CdHealthInventoryItem I " + _
                  "WHERE Code = '" + codeArti + "' "
        precioMedicina = bdPalabra(codeSQL, "Price")
    End Function

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Dim cost As Double = Double.Parse(precioMedicina(MedBoxV.SelectedValue))
        TableLayoutPanel1.Visible = True
        GuardarButton.Visible = True
        QActualV.Text = cost.ToString("F2")
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, CASE WHEN DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + '(' + DosageDesc_es+ ')') " + _
                 " ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END + ' #' + CONVERT(varchar, CurrentQuantity)  AS Medicine " + _
                 "FROM dbo.CdHealthInventoryItem I " + _
                 "WHERE Active = 1 AND ValidSelection = 1  AND Category = 'MEDI' AND Code <> 'OTRA' "
        bdCombo(sql, MedBoxV, "Code", "Medicine")
    End Sub

End Class