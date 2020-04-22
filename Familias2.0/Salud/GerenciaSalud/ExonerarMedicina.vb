' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ExonerarMedicina

    Private Sub ExonerarMedicina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(PacienteV.Text) > 0 Then
            valoresIniciales()
        Else
            If S = "E" Then
                Dim nxt As New BusquedaEmpleado
                nxt.TransL.Text = "ECM"
                nxt.Show()
                Me.Close()
            Else
                FamiliaV.Focus()
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub ExonerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExonerarButton.Click
        sql = "UPDATE dbo.MemberClinicConsultation SET Exoneration = 1, ApprovedBy = '" + U + "' " + _
              "WHERE IdConsultation = " + IdConsultaV.Text + " AND RecordStatus = ' ' "
        bdEjecutarSQL(sql)

        sql = "UPDATE dbo.HealthInventoryTransactionMedi SET Exoneration = 1 " + _
              "WHERE IdConsultation = " + IdConsultaV.Text + " AND RecordStatus = ' '   AND ApprovedTotalPrice > 0 and Quantity < 0 "
        bdEjecutarSQL(sql)
        listado()
        IdConsultaV.Text = ""
        FechaV.Text = ""
        DrV.Text = ""
        TotalV.Text = ""
        ExonerarButton.Visible = False
        UpdateTable.Visible = False
    End Sub

    Private Sub ExonerarMedButton_Click(sender As Object, e As EventArgs) Handles ExonerarMedButton.Click
        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi " + _
                 "SELECT IdTransac, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, " + _
                 "FunctionalArea, MemberProject, MemberId, UnitPrice, ApprovedTotalPrice, Indications, Notes, IdConsultation, PayDateTime, DeliveryDateTime, " + _
                 "DeliveredBy, ByCredit, 1, TypePres " + _
                 "FROM dbo.HealthInventoryTransactionMedi " + _
                 "WHERE RecordStatus = ' '  AND IdTransac = " + IdTransacV.Text
        bdInsertar(sql)
        medList()
        IdTransacV.Text = ""
        FechaMedV.Text = ""
        DrMedV.Text = ""
        TotalMedV.Text = ""
        ExonerarMedButton.Visible = False
        actualizarMedTable.Visible = False
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) = 0 Then
            Else
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "ECM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub listado()
        sql = "SELECT MCC.IdConsultation, dbo.fn_GEN_FormatDate(MCC.ConsultationDateTime, 'ES') AS FechaConsulta, MCA.EmployeeId AS Médico, " + _
                "MCC.TotalNormalPrice AS Q_Total, MCC.ApprovedPrice AS Q_SegunClasificacion " + _
                 "FROM dbo.MemberClinicConsultation MCC INNER JOIN dbo.MemberClinicAppointment MCA ON MCC.AppId = MCA.AppId AND MCC.RecordStatus = MCA.RecordStatus " + _
                "WHERE MCC.RecordStatus = ' ' AND MCA.Project = '" + S + "' AND MCA.MemberId = " + PacienteV.Text + " AND MCC.ApprovedPrice > 0  AND MCC.Exoneration = 0 " + _
                "  AND MCC.PayDateTime IS NULL " 'AND DATEDIFF(d, MCC.ConsultationDateTime, GETDATE()) <= 30 "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(0).Visible = False
        If ListadoGrid.RowCount = 0 Then
            ListadoGrid.Visible = False
        End If
    End Sub

    Private Sub medList()
        'fill meds history
        sql = "SELECT  HITM.IdTransac, cdHII.Code + ' - ' + CASE WHEN cdHII.DosageDesc_es IS NULL  THEN cdHII.DescSpanish ELSE cdHII.DescSpanish + ' (' + cdHII.DosageDesc_es + ')' END Medicina, " + _
                 "Quantity * - 1 Cantidad, ApprovedTotalPrice, Physician 'Prescrito Por', dbo.fn_GEN_FormatDate(HITM.PrescriptionDateTime, 'ES') AS Prescripción " + _
                 "FROM  dbo.HealthInventoryTransactionMedi HITM INNER JOIN dbo.CdHealthInventoryItem cdHII ON HITM.Item = cdHII.Code " + _
                 "WHERE HITM.DeliveryDateTime IS NULL AND HITM.ApprovedTotalPrice > 0 AND HITM.RecordStatus = ' ' AND HITM.Exoneration = 0 " + _
                 "AND Quantity < 0 AND DeliveryDateTime IS NULL  AND IdConsultation IS NULL " + _
                 "AND MemberProject = '" + S + "' AND MemberId = " + PacienteV.Text + " " + _
                 "ORDER BY HITM.PrescriptionDateTime DESC "
        bdGrid(sql, MedsGrid)
        MedsGrid.Columns.Item(0).Visible = False 'IdTransac

        If MedsGrid.RowCount = 0 Then
            MedsGrid.Visible = False
        End If
    End Sub

    Private Sub MedsGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MedsGrid.CellContentClick
        Dim fila, columna, IdTrans As Integer
        fila = MedsGrid.CurrentCellAddress.Y()
        columna = MedsGrid.CurrentCellAddress.X()
        IdTrans = MedsGrid.Item(0, fila).Value
        IdTransacV.Text = IdTrans.ToString
        MedV.Text = MedsGrid.Item(1, fila).Value
        FechaMedV.Text = MedsGrid.Item(5, fila).Value
        DrMedV.Text = MedsGrid.Item(4, fila).Value
        TotalMedV.Text = MedsGrid.Item(3, fila).Value
        actualizarMedTable.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ExonerarMedicina
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        Dim fila, columna, IdCons As Integer
        fila = ListadoGrid.CurrentCellAddress.Y()
        columna = ListadoGrid.CurrentCellAddress.X()
        IdCons = ListadoGrid.Item(0, fila).Value
        IdConsultaV.Text = IdCons.ToString
        FechaV.Text = ListadoGrid.Item(1, fila).Value
        DrV.Text = ListadoGrid.Item(2, fila).Value
        TotalV.Text = ListadoGrid.Item(4, fila).Value

        If verificaAlCredito(IdCons) = True Then
            MsgBox("Medicina al crédito", vbExclamation, My.Resources.versionFamilias2)
        Else
            UpdateTable.Visible = True
        End If
    End Sub

    Private Sub PacienteV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PacienteV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(PacienteV.Text) = 0 Then
            Else
                valoresIniciales()
                If derechosSalud(S, PacienteV.Text, FamiliaV.Text) = True Then
                    FamiliaV.Enabled = False
                    PacienteV.Enabled = False
                Else
                    MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub valoresIniciales()
        Dim genInfo As New DataTable
        sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, M.LastFamilyId Familia, F.Classification Clasificacion " + _
              "FROM Member M INNER JOIN Family F ON M.RecordStatus = F.RecordStatus AND " + _
              "M.Project = F.Project AND M.LastFamilyId = F.FamilyId WHERE M.RecordStatus = ' '  AND M.Project = '" + S + "' AND M.MemberId = " + PacienteV.Text
        bdDataTable(sql, genInfo)
        NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
        PacienteV.ReadOnly = True
        FamiliaV.ReadOnly = True
        GenInfoTable.Visible = True
        listado()
        medList()
        InfoPanel.Visible = True
    End Sub

    Private Function verificaAlCredito(ByVal idConsulta As Integer) As Boolean
        verificaAlCredito = False
        If S = "E" Then
            sql = "SELECT COUNT(*) AS total FROM dbo.HealthInventoryTransactionMedi WHERE RecordStatus = ' ' AND IdConsultation = " + idConsulta.ToString + " AND ByCredit = 1 "
            If bdEntero(sql, "total") > 0 Then
                verificaAlCredito = True
            End If
        End If
    End Function
End Class