' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class RevisarConsultaMedica
    Public sMember, preTrans As String
    Public memberId, consid, appid As Integer

    Dim hc As New HistorialConsulta
    Dim infoTable As New DataTable
    Dim sql As String
    Dim affilStatus, dr As String
    Dim nDiasHistorial As Integer = 365
    Dim hPercent As Double
    Dim TamañoPersonal As New Printing.PaperSize("MediaCarta", 550, 850) '850, 550)
    Dim exonera As Boolean = False

    Private Sub RevisarConsultaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub RevisarConsultaMedica_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        hc.Close()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub consultaInfo()
        infoTable.Clear()
        sql = "SELECT Problema, DatosSubjetivos, DatosObjetivos, NuevosDatos, Otros, EducationalPlan, Diagnostico1, Diagnostico2, Diagnostico3, TotalNormalPrice, " + _
              "ApprovedPrice, Exoneration, CASE WHEN ApprovedPrice = 0.00 THEN 0.00 ELSE ROUND((ApprovedPrice * 100.00 / TotalNormalPrice), 2) END as Porcen, " + _
              "Convert(nvarchar(30), ConsultationDateTime, 20) fecha " + _
              "FROM fn_HEAL_CLIN_HistorialConsultas('" + sMember + "', " + memberId.ToString + ") " + _
              "WHERE  IdConsultation = " + consid.ToString
        bdDataTable(sql, infoTable)

        If infoTable.Rows.Count > 0 Then
            ProblemaV.Text = Replace(chequearValor(infoTable.Rows(0)("Problema")).ToString, Chr(10), vbNewLine)
            dSubjetivosV.Text = Replace(chequearValor(infoTable.Rows(0)("DatosSubjetivos")).ToString, Chr(10), vbNewLine)
            dObjetivosV.Text = Replace(chequearValor(infoTable.Rows(0)("DatosObjetivos")).ToString, Chr(10), vbNewLine)
            NuevosDatosV.Text = Replace(chequearValor(infoTable.Rows(0)("NuevosDatos")).ToString, Chr(10), vbNewLine)
            OtrosV.Text = Replace(chequearValor(infoTable.Rows(0)("Otros")).ToString, Chr(10), vbNewLine)
            PlanV.Text = Replace(chequearValor(infoTable.Rows(0)("EducationalPlan")).ToString, Chr(10), vbNewLine)

            Diagnostico1V.Text = infoTable.Rows(0)("Diagnostico1").ToString
            Diagnostico2V.Text = chequearValor(infoTable.Rows(0)("Diagnostico2")).ToString
            Diagnostico3V.Text = chequearValor(infoTable.Rows(0)("Diagnostico3")).ToString
            PrecioNormalV.Text = chequearValor(infoTable.Rows(0)("TotalNormalPrice")).ToString
            normalTotalV.Text = chequearValor(infoTable.Rows(0)("ApprovedPrice")).ToString
            normalPercentageV2.Text = chequearValor(infoTable.Rows(0)("Porcen")).ToString
            FechaConsulta.Text = chequearValor(infoTable.Rows(0)("fecha")).ToString
            exonera = infoTable.Rows(0)("Exoneration")

            normalPercentageV.Text = normalPercentageV2.Text

            If exonera = True Then
                ExoneracionCheck.Checked = True
            Else
                ExoneracionCheck.Checked = False
            End If
            ExoneracionCheck.Enabled = False
        End If
    End Sub

    Private Sub enfermeriaInfo()
        sql = "SELECT dbo.fn_GEN_FormatDate(MNT.RefDateTime, 'ES') AS Referido, MNT.Physician AS Médico, " + _
              "cdTT.DescSpanish AS Tratamiento, MNT.Quantity Cantidad, MNT.Instruction AS Indicaciones, dbo.fn_GEN_FormatDate(MNT.TreatDateTime, 'ES') AS Realizado,  " + _
              "MNT.TreatBy AS Realizado_Por, MNT.Observations AS Observaciones " + _
              "FROM dbo.MemberNursTreatment MNT INNER JOIN dbo.CdHealthTreatment cdTT ON MNT.Treatment = cdTT.Code " + _
              "WHERE MNT.RecordStatus = ' ' AND IdConsultation = " + consid.ToString
        bdGrid(sql, TratamientosGrid)
    End Sub

    Private Sub farmaciaInfo()
        'fill meds history
        ', ApprovedTotalPrice Aprobado
        sql = "SELECT Medicina, Prescripción, Entrega, (Cantidad *-1) Cantidad, Indications Indicaciones, Observaciones " + _
              "FROM dbo.fn_HEAL_getItemHistory('" + sMember + "', " + memberId.ToString + ") F " + _
              "WHERE Cantidad < 0  AND  IdConsultation = " + consid.ToString
        bdGrid(sql, MedsGrid)
    End Sub

    Private Sub genInfo()
        Dim listTable As New DataTable
        sql = "SELECT  MCA.AppId, M.LastFamilyId AS Familia, M.FirstNames + ' ' + M.LastNames AS Nombre, DATEDIFF(M, M.BirthDate, GETDATE()) / 12 AS Edad,  " + _
              "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoM, " + _
              "F.Classification C, dbo.fn_SALU_porcentajeCobro(M.Project, M.MemberId, GETDATE()) HealthPercent, MCA.Temperature, MCA.Weight, MCA.Stature, " + _
              "MCA.BloodPressure, MCA.HeartRate, MCA.RespiratoryRate, MCA.EmployeeId Dr, MCA.Notes Obs " + _
              "FROM dbo.MemberClinicAppointment MCA INNER JOIN dbo.CdAppointmentStatus cdS ON MCA.Status = cdS.Code " +
              "INNER JOIN dbo.CdHealthClinic cdC ON MCA.HealthClinic = cdC.Code INNER JOIN dbo.CdHealthConsultationType cdT ON MCA.ConsultationType = cdT.Code " + _
              "INNER JOIN dbo.Member M ON MCA.Project = M.Project AND MCA.MemberId = M.MemberId AND MCA.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.Family F ON F.Project = M.Project AND F.FamilyId = M.LastFamilyId AND F.RecordStatus = M.RecordStatus " + _
              "LEFT OUTER JOIN dbo.CdAffiliationType cdAT ON cdAT.Code = M.AffiliationType " + _
              "LEFT JOIN dbo.CdFamilyClassification cdCl ON cdCl.Code = F.Classification " + _
              "WHERE MCA.RecordStatus = ' ' AND M.MemberId = " + memberId.ToString + " AND M.Project = '" + sMember + "' AND MCA.AppId = " + appid.ToString
        bdDataTable(sql, listTable)
        PacienteV.Text = memberId.ToString
        NombreV.Text = listTable.Rows(0)("Nombre")
        EdadV.Text = " - " + listTable.Rows(0)("Edad").ToString + " año(s)"
        FamiliaV.Text = listTable.Rows(0)("Familia").ToString
        TempV.Text = chequearValor(listTable.Rows(0)("Temperature")).ToString
        PesoV.Text = chequearValor(listTable.Rows(0)("Weight")).ToString
        TallaV.Text = chequearValor(listTable.Rows(0)("Stature")).ToString
        PresionV.Text = chequearValor(listTable.Rows(0)("BloodPressure")).ToString
        fCardiacaV.Text = chequearValor(listTable.Rows(0)("HeartRate")).ToString
        fRespiratoriaV.Text = chequearValor(listTable.Rows(0)("RespiratoryRate")).ToString
        obsV.Text = chequearValor(listTable.Rows(0)("Obs")).ToString
        hPercent = chequearValor(listTable.Rows(0)("HealthPercent")).ToString
        ClassificationV.Text = chequearValor(listTable.Rows(0)("C")).ToString
        memTypeV.Text = chequearValor(listTable.Rows(0)("TipoM")).ToString

        IMCL.Text = calcularIMC(PesoV.Text, TallaV.Text)

        dr = chequearValor(listTable.Rows(0)("Dr")).ToString
        DrL.Text = DrL.Text + dr
    End Sub

    Private Sub HistorialLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HistorialLink.LinkClicked
        hc = New HistorialConsulta
        hc.sMember = sMember
        hc.PacienteV.Text = PacienteV.Text
        hc.FamiliaV.Text = FamiliaV.Text
        hc.NombreV.Text = NombreV.Text
        hc.EdadV.Text = EdadV.Text
        hc.Show()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub laboratorioInfo()
        sql = "SELECT dbo.fn_GEN_FormatDate (MHLA.ReferenceDate, 'ES') Fecha, cdLET.DescSpanish AS Laboratorio, MHLE.Notes AS Notas, " + _
              "(SELECT CASE WHEN COUNT(*)  = 0 THEN 'No' ELSE 'Si' END AS N FROM dbo.MemberHealthLabResult MHLR " + _
              " WHERE RecordStatus = ' ' AND MHLR.Examen_ID = MHLE.Examen_ID) AS Resultados " + _
              "FROM dbo.MemberHealthLabExam MHLE INNER JOIN dbo.MemberHealthLabAppointment MHLA ON MHLE.IdAppLab = MHLA.IdAppLab AND MHLE.RecordStatus = MHLA.RecordStatus " + _
              "INNER JOIN dbo.CdLabExamen_Type cdLET ON MHLE.Examen_Tipo_ID = cdLET.Examen_Tipo_ID " + _
              "WHERE MHLE.RecordStatus = ' ' AND MHLA.IdConsultation = " + consid.ToString
        bdGrid(sql, ExamenesGrid)
    End Sub

    Private Sub MsGPay()
        If normalTotalV.Text = "0.00" Or normalTotalV.Text = "0" Or Double.Parse(normalPercentageV.Text) = 0 Then 'Or            (CambiarPerTotCheck.Checked = True And Double.Parse(newValueV.Text) = 0.0) Then
            If MedsGrid.Rows.Count = 0 Then
                MSGv.Text = ""
            Else
                MSGv.Text = "El paciente no paga"
            End If
        Else
            If ExoneracionCheck.Checked = True Then
                MSGv.Text = "El paciente no paga (tiene exoneración) "
            Else
                MSGv.Text = "El total de medicamentos es: Q." + normalTotalV.Text
            End If
        End If

        MSGv.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        If preTrans = "NCMS" Then
            Dim nxt As New AgendaMedico
            nxt.DateP.Value = DateTime.Parse(FechaConsulta.Text)
            nxt.Show()
            Me.Close()
        Else
            Dim nxt As New HistorialConsultasMedicas
            nxt.PacienteV.Text = PacienteV.Text
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub proximaCita()
        sql = "SELECT dbo.fn_GEN_FormatDate(MCA.AppointmentDateTime, 'ES') AS Cita, MCA.EmployeeId AS Médico, cdC.DescSpanish AS Clínica, " + _
              "cdCT.DescSpanish AS Tipo, cdS.DescSpanish AS Estado, MCA.Notes AS Observaciones, MCA.UserId AS Ultimo_Cambio " + _
              "FROM dbo.MemberClinicAppointment MCA INNER JOIN dbo.CdHealthClinic cdC ON MCA.HealthClinic = cdC.Code " + _
              "INNER JOIN dbo.CdHealthConsultationType cdCT ON MCA.ConsultationType = cdCT.Code INNER JOIN dbo.CdAppointmentStatus cdS ON MCA.Status = cdS.Code " + _
              "WHERE MCA.RecordStatus = ' ' AND MCA.IdConsultationReference = " + consid.ToString
        bdGrid(sql, CitaGrid)
    End Sub

    Private Sub recetasExtInfo()
        'fill recetasExternas
        sql = "SELECT dbo.fn_GEN_FormatDate(PresDateTime, 'ES') AS Fecha, Medicine AS Medicina, Quantity AS Cantidad, Instruction AS Rp " + _
              "FROM  dbo.MemberClinicExternalPrescription MCEP " + _
              "WHERE RecordStatus = ' ' AND IdConsultation = " + consid.ToString
        bdGrid(sql, RecetasExtGrid)
    End Sub

    Private Sub referenciasExtInfo()
        'fill external references
        sql = "SELECT dbo.fn_GEN_FormatDate(MCER.ReferenceDateTime, 'ES') AS Fecha, cdP.DescSpanish AS [Referido A], cdR.DescSpanish AS Motivo, MCER.Rp " + _
              "FROM dbo.MemberClinicExternalReference MCER INNER JOIN dbo.CdHealthExternalReferencePlace cdP ON MCER.Place = cdP.Code " + _
              "INNER JOIN dbo.CdHealthExternalReferenceReason cdR ON MCER.Reason = cdR.Code " + _
              "WHERE MCER.RecordStatus = ' ' AND MCER.IdConsultation = " + consid.ToString
        bdGrid(sql, ReferenciaExtGrid)
    End Sub

    Private Sub referenciasInternas()
        infoTable.Clear()
        Dim estado As String
        sql = "SELECT cdIRC.DescSpanish Category, Status, Description, Observations ObservacionesTS, UserId Usuario " + _
              "FROM dbo.MemberInternalReference MIR INNER JOIN CdInternalReferenceCategory cdIRC ON cdIRC.code = MIR.Category " + _
              "WHERE RecordStatus = ' ' AND MIR.Program = 'TS' AND  IdConsultation = " + consid.ToString
        bdDataTable(sql, infoTable)

        If infoTable.Rows.Count > 0 Then
            estado = chequearValor(infoTable.Rows(0)("Status")).ToString
            CategoriaTSCombo.Text = chequearValor(infoTable.Rows(0)("Category")).ToString
            DescRefTS.Text = chequearValor(infoTable.Rows(0)("Description")).ToString
        End If

        infoTable.Clear()
        estado = ""
        sql = "SELECT cdIRC.DescSpanish Category, Status, Description, Observations ObservacionesTS, UserId Usuario " + _
              "FROM dbo.MemberInternalReference  MIR INNER JOIN CdInternalReferenceCategory cdIRC ON cdIRC.code = MIR.Category " + _
              "WHERE RecordStatus = ' ' AND MIR.Program = 'PSIC' AND  IdConsultation = " + consid.ToString
        bdDataTable(sql, infoTable)

        If infoTable.Rows.Count > 0 Then
            estado = chequearValor(infoTable.Rows(0)("Status")).ToString
            CategoriaPsicCombo.Text = chequearValor(infoTable.Rows(0)("Category")).ToString
            DescRefPsic.Text = chequearValor(infoTable.Rows(0)("Description")).ToString
        End If
    End Sub

    Private Sub valoresIniciales()
        genInfo()
        consultaInfo()
        farmaciaInfo()
        laboratorioInfo()
        recetasExtInfo()
        referenciasExtInfo()
        enfermeriaInfo()
        proximaCita()
        referenciasInternas()
        'MsGPay()

        'fill sumary history
        sql = "SELECT CASE WHEN Cdt.RequiredQuantity = 1 THEN CdT.DescSpanish + ' (' + CONVERT(NVARCHAR, MMS.Quantity) + ')' ELSE CdT.DescSpanish END AS Tipo, " + _
                    "dbo.fn_GEN_FormatDate(MMS.DateTimeSum, 'ES') AS Fecha, MMS.RegisterBy 'Registró', MMS.Observations AS Observaciones " + _
              "FROM dbo.MemberMedicalSummaryHistory MMS INNER JOIN dbo.CdMedicalSummaryType CdT ON MMS.Type = CdT.Code " + _
                "INNER JOIN dbo.CdMedicalSummaryCategory CdC ON CdT.Category = CdC.Code " + _
              "WHERE MMS.RecordStatus = ' ' AND MMS.Project = '" + sMember + "' AND MMS.MemberId = " + memberId.ToString + _
              " ORDER BY CdC.DescSpanish, MMS.DateTimeSum DESC"
        bdGrid(sql, SumaryGrid)

        If SumaryGrid.RowCount > 0 Then
            SumaryGrid.Columns(0).Frozen = True
        End If
    End Sub

End Class