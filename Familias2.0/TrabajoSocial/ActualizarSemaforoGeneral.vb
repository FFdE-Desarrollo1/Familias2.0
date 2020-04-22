' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActualizarSemaforoGeneral

    Private Sub ActualizarSemaforoGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ActualizarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarButton.Click
        Dim mes As Integer = DateTime.Now.Month
        Dim año As Integer = DateTime.Now.Year
        Dim fecha As String

        If mes < 4 Then
            fecha = año.ToString + "/01/01 00:00:00 AM"
        Else
            fecha = (año + 1).ToString + "/01/01 00:00:00 AM"
        End If

        sql = "UPDATE MemberEducationSemaphore SET EndDate = '" + fecha + "' " + _
              "FROM MemberEducationSemaphore MES INNER JOIN Member M ON MES.Project = M.Project AND MES.RecordStatus = M.RecordStatus AND MES.MemberId = M.MemberId " + _
              "WHERE M.recordstatus = ' '  AND EndDate IS NULL AND M.Project = '" + S + "' ANd AffiliationStatus = 'AFIL' "
        bdEjecutarSQL(sql)

        sql = "INSERT INTO  MemberEducationSemaphore " + _
              "SELECT Project, MemberId, 'VERD', GETDATE(), ' ', '" + U + "', NULL, '" + fecha + "', NULL " + _
              "FROM Member WHERE recordstatus = ' ' and affiliationstatus = 'AFIL'  AND Project = '" + S + "'"
        bdInsertar(sql)
        listado()
        ActualizarButton.Visible = False
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
        sql = "SELECT M.MemberId AS Miembro, M.FirstNames AS Nombres, M.LastNames AS Apellidos, M.LastFamilyId AS Familia, dbo.fn_GEN_TS(M.Project, M.LastFamilyId) AS TS, " + _
                "cdS.DescSpanish AS Semáforo, dbo.fn_GEN_FormatDate (MES.StartDate, 'ES')  AS Inicio " + _
                "FROM dbo.Member M LEFT OUTER JOIN dbo.MemberEducationSemaphore MES ON M.Project = MES.Project AND M.MemberId = MES.MemberId AND M.RecordStatus = MES.RecordStatus AND " + _
                "MES.EndDate IS NULL LEFT OUTER JOIN dbo.CdEducationSemaphore cdS ON MES.EducSemaphore = cdS.Code " + _
                "WHERE M.RecordStatus = ' ' AND M.AffiliationStatus = 'AFIL' AND M.Project = '" + S + "'"
        bdGrid(sql, ListadoGrid)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
    End Sub

    Private Sub valoresIniciales()
        listado()
    End Sub
End Class