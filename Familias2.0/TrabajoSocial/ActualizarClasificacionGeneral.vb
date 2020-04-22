' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActualizarClasificacionGeneral

    Private Sub ActualizarClasificacionGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ActualizarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarButton.Click
        Dim mes As Integer = DateTime.Now.Month
        Dim año As Integer = DateTime.Now.Year
        Dim fecha, nuevoA As String
        Dim ingreso As DateTime = DateTime.Now

        If mes < 4 Then
            nuevoA = año.ToString
        Else
            nuevoA = año + 1
        End If

        fecha = nuevoA.ToString + "/01/01 00:00:00 AM"
        Dim dt As New DataTable

        sql = "SELECT F.Project, F.FamilyId, F.CreationDateTime " + _
              "FROM dbo.FamilyClassificationHistory FCH INNER JOIN Family F ON FCH.Project = F.Project AND FCH.FamilyId = F.FamilyId AND FCH.RecordStatus = F.RecordStatus  " + _
              "WHERE FCH.RecordStatus = ' ' AND FCH.Project = '" + S + "' AND FCH.YearClassification = " + nuevoA.ToString + " AND F.AffiliationStatus = 'AFIL'"
        bdDataTable(sql, dt)

        sql = "INSERT INTO Family " + _
              "SELECT F.Project, F.FamilyId, '" + ingreso.ToString(en.DateTimeFormat) + "', F.RecordStatus, '" + U + "', F.ExpirationDateTime, AffiliationLevel, AffiliationStatus, AffiliationStatusDate, Area, Pueblo,  " + _
              "Address, TelephoneNumber, Ethnicity, AffiliationLevelOverrideStartDate, AffiliationLevelOverrideEndDate, LastUpdateDate, FCH.Classification, '" + fecha + "', " + _
              "Municipality, TimeOnPlace, NextClassification, RFaroNumber " + _
              "FROM dbo.FamilyClassificationHistory FCH INNER JOIN Family F ON FCH.Project = F.Project AND FCH.FamilyId = F.FamilyId AND FCH.RecordStatus = F.RecordStatus  " + _
              "WHERE FCH.RecordStatus = ' ' AND FCH.Project = '" + S + "' AND FCH.YearClassification = " + nuevoA.ToString + " AND F.AffiliationStatus = 'AFIL'"
        bdInsertar(sql)

        Dim familias As String = dt.Rows(0)("FamilyId")
        For f = 1 To dt.Rows.Count - 1
            familias = familias + ", " + dt.Rows(f)("FamilyId").ToString
        Next

        sql = "UPDATE dbo.Family SET RecordStatus = 'H', ExpirationDateTime = GETDATE()  " + _
              "WHERE  RecordStatus = ' ' AND  Project = '" + S + "' AND CreationDateTime <> '" + ingreso.ToString(en.DateTimeFormat) + "' AND FamilyId IN (" + familias + ") "
        bdEjecutarSQL(sql)
        listado()
        ActualizarButton.Visible = False
        MsgBox("Actualización finalizada", vbQuestion, My.Resources.versionFamilias2)
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
        sql = "SELECT FamilyId Familia, Classification Clasificación, dbo.fn_GEN_FormatDate (ClassificationDate, 'ES') Fecha, dbo.fn_GEN_TS(Project, FamilyId) AS TS, Pueblo " + _
              "FROM Family WHERE RecordStatus = ' ' AND Project = '" + S + "' AND AffiliationStatus = 'AFIL' " + _
              "ORDER BY FamilyId "
        bdGrid(sql, ListadoGrid)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
    End Sub

    Private Sub valoresIniciales()
        listado()
    End Sub

End Class