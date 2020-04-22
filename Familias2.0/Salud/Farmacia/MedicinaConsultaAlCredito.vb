' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class MedicinaConsultaAlCredito

    Private Sub MedicinaConsultaAlCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        MiembroV.Focus()
        If Len(MiembroV.Text) > 0 Then
            valoresIniciales()
        Else
            Dim emp As New BusquedaEmpleado
            emp.TransL.Text = "MECR"
            emp.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Actualizar(ByVal idTrans As String)
        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi " + _
                "SELECT  IdTransac, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea, " + _
                "MemberProject, MemberId, UnitPrice,  ApprovedTotalPrice, Indications, Notes, IdConsultation, PayDateTime, GETDATE(), DeliveredBy, 1, Exoneration, TypePres " + _
                "FROM dbo.HealthInventoryTransactionMedi WHERE IdTransac = " + idTrans + " AND RecordStatus = ' ' "
        bdInsertar(sql)
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim med As String
        Dim isCheck As New CheckBox
        If MedicinasGrid.RowCount > 0 Then
            For f = 0 To MedicinasGrid.Rows.Count - 1
                med = MedicinasGrid.Item(8, f).Value()
                If MedicinasGrid.Item(0, f).Value() = True Then
                    Actualizar(med)
                End If
            Next
            listado()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        sql = "SELECT MITM.Item + ' - ' + cdII.DescSpanish + ' (' + cdII.DosageDesc_es + ')' AS Medicina, MITM.Quantity * - 1 AS Cantidad, MITM.ApprovedTotalPrice AS Total, " + _
                "MITM.Indications AS Indicaciones, MITM.Notes AS Notas, dbo.fn_GEN_FormatDate(MCC.ConsultationDateTime, 'ES') AS Consulta, MITM.Physician AS Médico, MITM.IdTransac " + _
                "FROM dbo.HealthInventoryTransactionMedi MITM INNER JOIN dbo.MemberClinicConsultation MCC ON MITM.IdConsultation = MCC.IdConsultation AND MITM.RecordStatus = MCC.RecordStatus " + _
                "INNER JOIN dbo.MemberClinicAppointment MCA ON MCC.AppId = MCA.AppId AND MCC.RecordStatus = MCA.RecordStatus " + _
                "INNER JOIN dbo.Member M ON MCA.RecordStatus = M.RecordStatus AND MCA.Project = M.Project AND MCA.MemberId = M.MemberId " + _
                "INNER JOIN dbo.CdHealthInventoryItem cdII ON MITM.Item = cdII.Code " + _
                "WHERE Quantity < 0 AND  MITM.RecordStatus = ' ' AND MITM.DeliveryDateTime IS NULL AND DATEDIFF(d, MCC.ConsultationDateTime, GETDATE()) < 30 " + _
                "AND M.Project = '" + S + "' AND MITM.ApprovedTotalPrice  > 0 AND ByCredit = 0  AND MCC.Exoneration = 0 AND MCC.PayDateTime IS NULL AND M.MemberId = " + MiembroV.Text
        bdGrid(sql, MedicinasGrid)
        MedicinasGrid.Columns.Item(8).Visible = False 'IdTransac
        MedicinasGrid.AutoResizeColumns()
        For f = 0 To MedicinasGrid.Rows.Count - 1
            MedicinasGrid.Item(0, f).Value() = True
        Next

        GuardarButton.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New MedicinaConsultaAlCredito
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        Dim listTable As New DataTable
        Dim edad As Integer
        sql = "SELECT FirstNames + ' ' +  LastNames As CompleteName, DATEDIFF(M, BirthDate, GETDATE()) / 12 AS Edad, LastFamilyId Familia FROM  dbo.Member M " + _
                                   "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            NombreV.Text = listTable.Rows(f)("CompleteName")
            edad = listTable.Rows(f)("Edad")
            EdadV.Text = " - " + edad.ToString + " año(s)"
            FamiliaV.Text = listTable.Rows(f)("Familia")
            PanelSecundario.Visible = True
            FamiliaV.ReadOnly = True
            MiembroV.ReadOnly = True
        Next
        listado()
    End Sub
End Class