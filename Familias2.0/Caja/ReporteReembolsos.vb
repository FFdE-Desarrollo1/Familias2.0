' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReporteReembolsos
    Dim total As Double

    Private Sub ReporteReembolsos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Function formatoFecha(ByVal selectedDate As Date, _
               ByVal AmPm As String) As String
        formatoFecha = selectedDate.Year.ToString + "/" + selectedDate.Month.ToString + "/" + selectedDate.Day.ToString
        If AmPm = "AM" Then
            formatoFecha = formatoFecha + " 00:00:00 AM"
        Else
            formatoFecha = formatoFecha + " 23:00:00 PM"
        End If
    End Function

    Private Sub GenerarButton_Click(sender As Object, e As EventArgs) Handles GenerarButton.Click
        Informe()
    End Sub

    Private Sub Informe()
        ListaGrid.DataSource = Nothing
        ListaGrid.Rows.Clear()
        ListaGrid.Visible = False
        total = 0
        TotalL.Text = "Reembolsos:  "
        Dim addTipo As String
        Dim fecha1, fecha2 As String

        fecha1 = formatoFecha(DeFechaV.Value, "AM")
        fecha2 = formatoFecha(AFechaV.Value, "PM")

        If Len(TipoV.Text) = 0 Then
            addTipo = ""
        Else
            addTipo = " AND cdRT.DescSpanish = '" + TipoV.Text + "' "
        End If

        sql = "SELECT  MR.MemberId AS 'No. Miembro', M.FirstNames + ' ' + M.LastNames AS Nombre, cdRT.DescSpanish AS Tipo, " + _
                "MR.ApprovedDateTime AS 'Fecha Aprobado', MR.ReimbursementDateTime AS 'Fecha Cancelado', MR.Amount AS Valor, MR.ApprovedAmount AS 'Valor Aprobado', " + _
                "MR.ApprovedBy AS 'Aprobado Por', MR.CheckNumber AS 'No. Cheque', MR.ReceiptNumber AS 'No. Recibo', MR.Notes AS Notas, F.Classification AS Clasificacion, MR.Type " + _
                "FROM dbo.MemberReimbursement MR INNER JOIN " + _
                "dbo.Member M ON MR.Project = M.Project AND MR.MemberId = M.MemberId AND MR.RecordStatus = M.RecordStatus INNER JOIN " + _
                "dbo.CdReimbursementType cdRT ON MR.Type = cdRT.Code INNER JOIN " + _
                "dbo.Family F ON M.Project = F.Project AND M.LastFamilyId = F.FamilyId AND M.RecordStatus = F.RecordStatus " + _
                "WHERE MR.RecordStatus = ' ' AND MR.Pay = 'CHEQ' AND  MR.Project = '" + S + "'AND MR.ReimbursementDateTime BETWEEN '" + fecha1 + "' " + _
                 "AND '" + fecha2 + "'" + addTipo
        bdGrid(sql, ListaGrid)
        ListaGrid.Columns.Item(12).Visible = False

        If ListaGrid.RowCount > 0 Then
            For Each r As DataGridViewRow In ListaGrid.Rows
                ListaGrid.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
                total = total + ListaGrid.Item(6, r.Index).Value
            Next
        End If

        TotalL.Text = TotalL.Text & ListaGrid.RowCount.ToString
        TotalGenV.Text = total.ToString
        ListaGrid.Visible = True
        totalesTable.Visible = True

    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT DescSpanish tipo " + _
                     "FROM dbo.CdReimbursementType " + _
                   "WHERE Project IN ('F','*') AND Active = 1 AND FunctionalArea IN ('EDUC', 'CLIN') "
        bdComboSinCodigo(sql, TipoV)
    End Sub


End Class