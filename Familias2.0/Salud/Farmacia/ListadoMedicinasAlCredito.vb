' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ListadoMedicinasAlCredito

    Private Sub ListadoMedicinasAlCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        MostrarButton.Focus()
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
        sql = "SELECT Sitio, Nombre, Entregado, ROUND(SUM(Total),2) Total " + _
              "FROM dbo.fn_HEAL_FARM_MedsAlCredito_Empleados ('" + S + "', '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', '" + aFecha.Value.ToString(en.DateTimeFormat) + "') " + _
              "GROUP BY Sitio, Nombre, Entregado " + _
              "ORDER BY Sitio, Nombre, Entregado "
        bdGrid(sql, ListadoGrid)

        For i = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
    End Sub

    Private Sub listadoConDetalle()
        sql = "SELECT * from dbo.fn_HEAL_FARM_MedsAlCredito_Empleados ('" + S + "', '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', '" + aFecha.Value.ToString(en.DateTimeFormat) + "')"
        bdGrid(sql, ListadoGrid)
    End Sub

    Private Sub MostrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarButton.Click
        If detalleCheck.Checked = True Then
            listadoConDetalle()
        Else
            listado()
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ListadoMedicinasAlCredito
        nxt.Show()
        Me.Close()
    End Sub

End Class