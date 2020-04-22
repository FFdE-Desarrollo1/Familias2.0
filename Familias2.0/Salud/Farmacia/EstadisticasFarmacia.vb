' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class EstadisticasFarmacia

    Private Sub EstadisticasFarmacia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
    End Sub

    Private Sub AlCreditoLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AlCreditoLink.LinkClicked
        If detalleCheck.Checked = True Then
            listadoConDetalle()
        Else
            listado()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub limpiarGrid()
        TotalesL.Text = ""
        listadoGrid.DataSource = Nothing
        listadoGrid.Rows.Clear()
        listadoGrid.Visible = False
        TotalesL.Visible = False
    End Sub

    Private Sub listado()
        limpiarGrid()
        sql = "SELECT Sitio, Nombre, Prescripcion,  Entregado Entrega, ROUND(SUM(Total),2) Total " + _
              "FROM dbo.fn_HEAL_FARM_MedsAlCredito_Empleados ('" + S + "', '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', '" + aFecha.Value.ToString(en.DateTimeFormat) + "') " + _
              "GROUP BY Sitio, Nombre, Prescripcion, Entregado " + _
              "ORDER BY Sitio, Nombre, Prescripcion, Entregado "
        bdGrid(sql, listadoGrid)
        For i = 0 To listadoGrid.Rows.Count - 1
            listadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
        listadoGrid.Visible = True
    End Sub

    Private Sub listadoConDetalle()
        limpiarGrid()
        sql = "SELECT * from dbo.fn_HEAL_FARM_MedsAlCredito_Empleados ('" + S + "', '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', '" + aFecha.Value.ToString(en.DateTimeFormat) + "')"
        bdGrid(sql, listadoGrid)
        listadoGrid.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub pendientesLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles pendientesLink.LinkClicked
        MsgBox("El listado de ""Pendientes de Entrega"" NO aplican las fechas seleccionadas " + vbNewLine + "(Es general, sin tomar en cuenta las fechas que ha seleccionado)", vbInformation, My.Resources.versionFamilias2)
        limpiarGrid()
        Dim tit As String
        If detalleCheck.Checked = True Then
            sql = "SELECT * " + _
                    "FROM dbo.v_FARM_RecetasPendientes " + _
                    "ORDER BY Prescripción, Sitio, Paciente "
            tit = "Total de recetas pendientes: "
        Else
            sql = "SELECT Sitio, No_Miembro,  Paciente, Familia, Prescripción, COUNT(*) AS Medicinas " + _
                    "FROM dbo.v_FARM_RecetasPendientes " + _
                    "GROUP  BY Sitio, No_Miembro, Paciente, Familia, Prescripción " + _
                    "ORDER BY Prescripción, Sitio, No_Miembro, Paciente "
            tit = "Total de pacientes con medicina pendiente de entrega: "
        End If
        bdGrid(sql, listadoGrid)

        For i = 0 To listadoGrid.Rows.Count - 1
            listadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next

        TotalesL.Text = tit + listadoGrid.RowCount.ToString
        listadoGrid.Visible = True
        TotalesL.Visible = True
    End Sub

    Private Sub recetasLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles recetasLink.LinkClicked
        limpiarGrid()
        Dim total As Integer = 0
        Dim totales As String = ""
        Dim col As Integer = 0

        Dim de As String = DeFecha.Value.Year.ToString + "/" + DeFecha.Value.Month.ToString + "/" + DeFecha.Value.Day.ToString
        Dim a As String = aFecha.Value.Year.ToString + "/" + aFecha.Value.Month.ToString + "/" + aFecha.Value.Day.ToString

        If detalleCheck.Checked = True Then
            sql = "SELECT SitioMiembro, Miembro, Nombre, Familia, CONVERT(nvarchar, Prescripción, 103) Prescripción, CONVERT(nvarchar, Entrega, 103) Entrega, Artículo, Cantidad * -1 Cantidad, Total, Prescribió, Notas " + _
                  "FROM dbo.fn_HEAL_FARM_TransaccionesInv('F', '" + de + "', '" + a + "') " + _
                  "WHERE Cantidad < 0 And Miembro Is Not NULL AND Entrega IS NOT NULL " + _
                  "ORDER BY CONVERT(nvarchar, Prescripción, 103), SitioMiembro, Miembro "
            bdGrid(sql, listadoGrid)

            For i = 0 To listadoGrid.Rows.Count - 1
                listadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
                total = total + listadoGrid.Item(7, i).Value
            Next

            TotalesL.Text = "Medicinas Entregadas: " + listadoGrid.RowCount.ToString
        Else
            sql = "SELECT SitioMiembro AS Sitio, Miembro, Nombre, Familia, CONVERT(nvarchar, Entrega, 103) Entrega, COUNT(*) Medicinas " + _
                  "FROM dbo.fn_HEAL_FARM_TransaccionesInv('F','" + de + "', '" + a + "') " + _
                  "WHERE Cantidad < 0 And Miembro Is Not NULL AND Entrega IS NOT NULL " + _
                  "GROUP BY SitioMiembro, Miembro, Nombre, Familia, CONVERT(nvarchar, Entrega, 103) " + _
                  "ORDER BY CONVERT(nvarchar, Entrega, 103), SitioMiembro, Miembro "
            bdGrid(sql, listadoGrid)

            For i = 0 To listadoGrid.Rows.Count - 1
                listadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
                total = total + listadoGrid.Item(5, i).Value
            Next
            TotalesL.Text = "Pacientes Atendidos: " + listadoGrid.RowCount.ToString + "   Medicinas Entregadas: " + total.ToString
        End If

        listadoGrid.Visible = True
        TotalesL.Visible = True
    End Sub
End Class