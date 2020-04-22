' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class PagosPendientes
    Dim año As String = Today.Year.ToString
    Dim total As Integer

    Private Sub PagosPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sql = "SELECT * " + _
                  "FROM dbo.fn_CAJA_pendientesDePago('" + S + "', " + año + ") " + _
                  "ORDER BY Area DESC, Aprobado DESC, Escuela"
        bdGrid(sql, ListadoGrid)

        'If ListaGrid.RowCount > 0 Then
        '    For Each r As DataGridViewRow In ListaGrid.Rows
        '        ListaGrid.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
        '    Next
        'End If
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

        sql = "SELECT Tipo, Escuela, COUNT(*) Total " + _
                 "FROM dbo.fn_CAJA_pendientesDePago('" + S + "', " + año + ") " + _
                 "GROUP BY Area, Tipo, Escuela " + _
                 "ORDER BY Area, Tipo, Escuela "
        bdGrid(sql, ListadoGrid)
        'If ListaGrid.RowCount > 0 Then
        '    For Each r As DataGridViewRow In ListaGrid.Rows
        '        r.HeaderCell.Value = (r.Index + 1).ToString()
        '        total = total + ListaGrid.Item(1, r.Index).Value
        '    Next
        'End If
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