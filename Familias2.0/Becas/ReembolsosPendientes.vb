' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReembolsosPendientes

    Private Sub ReembolsosPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        listado()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub conDetalle()
        sql = "SELECT MR.MemberId AS 'No. Miembro', M.FirstNames + ' ' + M.LastNames AS Nombre, cdT.DescSpanish AS Tipo, " + _
                  "MR.ApprovedDateTime AS Aprobado, S.Name AS Establecimiento, MR.ApprovedBy AS Aprobó, " + _
                  "MR.Amount AS Cantidad, MR.ApprovedAmount AS 'Cantidad Aprobada' " + _
                  "FROM dbo.MemberReimbursement MR INNER JOIN dbo.Member M ON MR.Project = M.Project AND " + _
                   "MR.MemberId = M.MemberId AND MR.RecordStatus = M.RecordStatus INNER JOIN " + _
                   "dbo.CdReimbursementType cdT ON MR.Type = cdT.Code INNER JOIN dbo.MemberEducationYear MEY " + _
                   "ON M.Project = MEY.Project AND M.MemberId = MEY.MemberId AND M.RecordStatus = MEY.RecordStatus AND  " + _
                   "MEY.SchoolYear = YEAR(MR.ApprovedDateTime) INNER JOIN dbo.School S ON " + _
                   "MEY.Project = S.Project AND MEY.SchoolCode = S.Code AND MEY.RecordStatus = S.RecordStatus " + _
                  "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND MR.ReimbursementDateTime IS NULL AND MR.Pay = 'CHEQ' " + _
                  "AND cdT.FunctionalArea = 'EDUC' AND M.AffiliationStatus = 'AFIL'" + _
                  "ORDER BY S.Name, cdT.DescSpanish "
        bdGrid(sql, ListGrid)
    End Sub

    Private Sub Detalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detalle.CheckedChanged
        If Detalle.Checked = True Then
            Tipo.Checked = False
        End If
        listado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        ListGrid.Visible = True
        If Tipo.Checked = True Then
            porTipo()
        Else
            conDetalle()
        End If
    End Sub

    Private Sub porTipo()
        sql = "SELECT S.Name AS Establecimiento, cdT.DescSpanish AS Tipo, COUNT(M.MemberId) AS Total " + _
                  "FROM dbo.MemberReimbursement MR INNER JOIN dbo.Member M ON MR.Project = M.Project AND " + _
                   "MR.MemberId = M.MemberId AND MR.RecordStatus = M.RecordStatus INNER JOIN " + _
                   "dbo.CdReimbursementType cdT ON MR.Type = cdT.Code INNER JOIN dbo.MemberEducationYear MEY " + _
                   "ON M.Project = MEY.Project AND M.MemberId = MEY.MemberId AND M.RecordStatus = MEY.RecordStatus AND " + _
                   "MEY.SchoolYear = YEAR(MR.ApprovedDateTime) INNER JOIN dbo.School S ON MEY.Project = S.Project AND " + _
                   "MEY.SchoolCode = S.Code AND MEY.RecordStatus = S.RecordStatus " + _
                  "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND " + _
                   "MR.ReimbursementDateTime IS NULL AND MR.Pay = 'CHEQ' AND cdT.FunctionalArea = 'EDUC' AND M.AffiliationStatus = 'AFIL'" + _
                  "GROUP BY S.Name, cdT.DescSpanish " + _
                  "ORDER BY S.Name, cdT.DescSpanish "
        bdGrid(sql, ListGrid)
    End Sub

    Private Sub Tipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tipo.CheckedChanged
        If Tipo.Checked = True Then
            Detalle.Checked = False
        End If
        listado()
    End Sub

End Class