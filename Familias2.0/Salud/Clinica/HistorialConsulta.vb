' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class HistorialConsulta
    Public sMember As String

    Dim nDiasHistorial As Integer = 365

    Private Sub HistorialConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valoresIniciales()
    End Sub

    Private Sub EvolGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EvolGrid.CellContentClick
        Dim f As Integer = EvolGrid.CurrentCellAddress.Y
        RevisarEvolL.Text = "Consulta seleccionada: " + chequearValor(EvolGrid.Item(0, f).Value())
        rProblemaV.Text = chequearValor(EvolGrid.Item(2, f).Value())
        rDsubjetivosV.Text = chequearValor(EvolGrid.Item(3, f).Value())
        rDobjetivosV.Text = chequearValor(EvolGrid.Item(4, f).Value())
        rNdatosV.Text = chequearValor(EvolGrid.Item(5, f).Value())
        rOtrosV.Text = chequearValor(EvolGrid.Item(6, f).Value())
        rPlanV.Text = chequearValor(EvolGrid.Item(7, f).Value())
    End Sub

    Private Sub LabsHistoryGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LabsHistoryGrid.CellContentClick
        Dim c As Integer = LabsHistoryGrid.CurrentCellAddress.X
        Dim f As Integer = LabsHistoryGrid.CurrentCellAddress.Y
        Dim id As Integer
        Dim hasSub As Boolean
        id = LabsHistoryGrid.Item(3, f).Value()
        hasSub = LabsHistoryGrid.Item(2, f).Value()
        If hasSub = True Then
            resultadosConSub(id)
        Else
            resultados(id)
        End If
    End Sub

    Private Sub resultados(ByVal id As Integer)
        ResulLabsGrid.DataSource = Nothing
        sql = "SELECT CdT.DescSpanish AS Laboratorio, RES.Resultado " + _
              "FROM dbo.MemberHealthLabResult RES INNER JOIN dbo.MemberHealthLabExam MHLE ON RES.Examen_ID = MHLE.Examen_ID AND  RES.RecordStatus = MHLE.RecordStatus " + _
                "INNER JOIN dbo.CdLabExamen_Type CdT ON MHLE.Examen_Tipo_ID = CdT.Examen_Tipo_ID " + _
              "WHERE RES.RecordStatus = ' ' AND RES.Examen_ID = " + id.ToString
        bdGrid(sql, ResulLabsGrid)
        ResulLabsGrid.Columns(0).Width = 150
    End Sub

    Private Sub resultadosConSub(ByVal id As Integer)
        ResulLabsGrid.DataSource = Nothing
        sql = "SELECT CdST.DescSpanish AS Descripción, RES.Resultado " + _
              "FROM dbo.MemberHealthLabResult RES INNER JOIN dbo.MemberHealthLabExam MHLE ON RES.Examen_ID = MHLE.Examen_ID AND  RES.RecordStatus = MHLE.RecordStatus " + _
                "INNER JOIN dbo.CdLabExamen_Type CdT ON MHLE.Examen_Tipo_ID = CdT.Examen_Tipo_ID " + _
                "INNER JOIN dbo.CdLabSubExamen_Type CdST ON RES.SubExamen_ID = CdST.SubExamen_ID " + _
              "WHERE RES.RecordStatus = ' ' AND RES.Examen_ID = " + id.ToString
        bdGrid(sql, ResulLabsGrid)
        ResulLabsGrid.Columns(0).Width = 130
        ResulLabsGrid.Columns(1).Width = 300
    End Sub

    Private Sub valoresIniciales()
        verSumario()
        verHistorialConsultas()
        verHistorialMedicinas()
        verHistorialLaboratorios()
        verHistorialTratamientos()
        verHistorialReferenciasTS()
        verHistorialReferenciasPsic()
        verHistorialRecetasExternas()
        verHistorialReferenciasExternas()
        verHistorialPagos()
    End Sub

    Private Sub verSumario()
        'fill sumary history
        sql = "SELECT CASE WHEN Cdt.RequiredQuantity = 1 THEN CdT.DescSpanish + ' (' + CONVERT(NVARCHAR, MMS.Quantity) + ')' ELSE CdT.DescSpanish END AS Tipo, " + _
                    "dbo.fn_GEN_FormatDate(MMS.DateTimeSum, 'ES') AS Fecha, MMS.RegisterBy 'Usuario', MMS.Observations AS Observaciones " + _
              "FROM dbo.MemberMedicalSummaryHistory MMS INNER JOIN dbo.CdMedicalSummaryType CdT ON MMS.Type = CdT.Code " + _
                "INNER JOIN dbo.CdMedicalSummaryCategory CdC ON CdT.Category = CdC.Code " + _
              "WHERE MMS.RecordStatus = ' ' AND MMS.Project = '" + sMember + "' AND MMS.MemberId = " + PacienteV.Text + _
              " ORDER BY CdC.DescSpanish, MMS.DateTimeSum DESC"
        bdGrid(sql, SumarioGrid)
        SumarioGrid.Columns(0).Frozen = True
    End Sub

    Private Sub verHistorialConsultas()
        'fill consultation history
        sql = "SELECT Fecha, Médico, Problema, DatosSubjetivos,DatosObjetivos, NuevosDatos, Otros, educationalPlan, Diagnostico1, Diagnostico2, Diagnostico3, " + _
              "TipoConsulta, Clinica, IMC, Temperatura, Peso, Estatura, Presión, fCardiaca, fRespiratoria,  Observaciones " + _
              "FROM fn_HEAL_CLIN_HistorialConsultas('" + sMember + "', " + PacienteV.Text + ") " + _
              "WHERE DateDiff(d, ConsultationDateTime, Getdate()) <= " + nDiasHistorial.ToString + " " + _
              "ORDER BY ConsultationDateTime DESC "
        bdGrid(sql, EvolGrid)
        EvolGrid.Columns.Item(2).Visible = False 'problema
        EvolGrid.Columns.Item(3).Visible = False 'datos subjetivos
        EvolGrid.Columns.Item(4).Visible = False 'datos objetivos
        EvolGrid.Columns.Item(5).Visible = False 'nuevos datos
        EvolGrid.Columns.Item(6).Visible = False 'datos otros
        EvolGrid.Columns.Item(7).Visible = False 'plan

        EvolGrid.Columns(1).Frozen = True

    End Sub

    Private Sub verHistorialMedicinas()
        'fill meds history
        sql = "SELECT Medicina, Prescripción, Entrega, (Cantidad *-1) Cantidad, Indications Indicaciones, Observaciones, Autorizado, EntregadoPor " + _
              "FROM dbo.fn_HEAL_getItemHistory('" + sMember + "', " + PacienteV.Text + ") " + _
              "WHERE Cantidad < 0  AND DateDiff(d, DateT, Getdate()) <= " + nDiasHistorial.ToString + " " + _
              "ORDER BY DateT DESC "
        bdGrid(sql, MedsHistorialGrid)
        MedsHistorialGrid.Columns(0).Frozen = True
        MedsHistorialGrid.Columns(0).Width = 100
    End Sub

    Private Sub verHistorialLaboratorios()
        'fill labs
        sql = "SELECT dbo.fn_GEN_FormatDate(MLA.ReferenceDate, 'ES') AS Fecha, cdT.DescSpanish AS Laboratorio, cdT.HasSubExam, MLE.Examen_ID, " + _
              "(SELECT CASE WHEN COUNT(*)  = 0 THEN 'No' ELSE 'Si' END AS N FROM dbo.MemberHealthLabResult MHLR " + _
              " WHERE RecordStatus = ' ' AND MHLR.Examen_ID = MLE.Examen_ID) AS Resultados " + _
              "FROM dbo.MemberHealthLabAppointment MLA INNER JOIN dbo.MemberHealthLabExam MLE ON MLA.IdAppLab = MLE.IdAppLab AND  MLA.RecordStatus = MLE.RecordStatus " + _
              "INNER JOIN dbo.CdLabExamen_Type cdT ON MLE.Examen_Tipo_ID = cdT.Examen_Tipo_ID " + _
              "WHERE MLA.RecordStatus = ' ' AND MLA.Project = '" + sMember + "' AND MLA.MemberId = " + PacienteV.Text + " " + _
              "AND DateDiff(d, MLA.ReferenceDate, Getdate()) <= " + nDiasHistorial.ToString + " " + _
              "ORDER BY MLA.ReferenceDate DESC"
        bdGrid(sql, LabsHistoryGrid)
        LabsHistoryGrid.Columns.Item(2).Visible = False
        LabsHistoryGrid.Columns.Item(3).Visible = False

    End Sub

    Private Sub verHistorialPagos()
        'fill reimbursement history
        sql = "SELECT Tipo, Autorizado, Pagado, Cantidad Total, [Cantidad Aprobada] Aprobado, Porcentaje, AprobadoPor, Observaciones " + _
              "FROM dbo.fn_GEN_HistorialPagos('" + sMember + "', " + PacienteV.Text + ") " + _
              "WHERE DateDiff(d, FechaA, Getdate()) <= " + nDiasHistorial.ToString + " AND Area = 'CLIN' " + _
              "ORDER BY FechaA DESC "
        bdGrid(sql, PagosHistorialGrid)
    End Sub

    Private Sub verHistorialRecetasExternas()
        'fill external prescriptions
        sql = "SELECT dbo.fn_GEN_FormatDate(PresDateTime, 'ES') AS Fecha, Medicine AS Medicina, Quantity AS Cantidad, Instruction AS Rp " + _
              "FROM dbo.MemberClinicExternalPrescription MCEP " + _
              "WHERE RecordStatus = ' ' AND Project = '" + sMember + "' AND MemberId = " + PacienteV.Text + " " + _
              "AND DateDiff(d, PresDateTime, Getdate()) <= " + nDiasHistorial.ToString + " " + _
              "ORDER BY PresDateTime DESC"
        bdGrid(sql, RecExtHistorialGrid)
    End Sub

    Private Sub verHistorialReferenciasExternas()
        'fill external references
        sql = "SELECT dbo.fn_GEN_FormatDate(MCER.ReferenceDateTime, 'ES') AS Fecha, cdP.DescSpanish AS [Referido A], cdR.DescSpanish AS Motivo, MCER.Rp " + _
              "FROM dbo.MemberClinicExternalReference MCER INNER JOIN dbo.CdHealthExternalReferencePlace cdP ON MCER.Place = cdP.Code " + _
              "INNER JOIN dbo.CdHealthExternalReferenceReason cdR ON MCER.Reason = cdR.Code " + _
              "WHERE MCER.RecordStatus = ' ' AND MCER.Project = '" + sMember + "' AND MCER.MemberId = " + PacienteV.Text + " " + _
               "AND  DateDiff(d, MCER.ReferenceDateTime, Getdate()) <= " + nDiasHistorial.ToString + " " + _
              "ORDER BY MCER.ReferenceDateTime DESC"
        bdGrid(sql, RefExtHistorialGrid)
    End Sub

    Private Sub verHistorialReferenciasPsic()
        sql = "SELECT cdC.DescSpanish AS Categoría, dbo.fn_GEN_FormatDate(MIR.ReferenceDateTime, 'ES') AS Referido, cdS.DescSpanish AS Estado, " + _
              "MIR.ReferredBy AS 'Referido Por', MIR.Description AS Descripción " + _
              "FROM dbo.MemberInternalReference MIR INNER JOIN dbo.CdInternalReferenceCategory cdC ON MIR.Category = cdC.Code " + _
              "INNER JOIN dbo.CdInternalReferenceStatus cdS ON MIR.Status = cdS.Code " + _
              "WHERE MIR.RecordStatus = ' ' AND MIR.Project = '" + sMember + "' AND MIR.MemberId = " + PacienteV.Text + " AND cdC.Program = 'MEDI' " + _
              "AND MIR.Program = 'PSIC' AND DateDiff(d, MIR.ReferenceDateTime, Getdate()) <= " + nDiasHistorial.ToString + " "
        bdGrid(sql, HistorialRefPsicGrid)
    End Sub

    Private Sub verHistorialReferenciasTS()
        sql = "SELECT cdC.DescSpanish AS Categoría, dbo.fn_GEN_FormatDate(MIR.ReferenceDateTime, 'ES') AS Referido, cdS.DescSpanish AS Estado, " + _
              "MIR.ReferredBy AS 'Referido Por', MIR.Description AS Descripción " + _
              "FROM dbo.MemberInternalReference MIR INNER JOIN dbo.CdInternalReferenceCategory cdC ON MIR.Category = cdC.Code " + _
              "INNER JOIN dbo.CdInternalReferenceStatus cdS ON MIR.Status = cdS.Code " + _
              "WHERE MIR.RecordStatus = ' ' AND MIR.Project = '" + sMember + "' AND MIR.MemberId = " + PacienteV.Text + " AND cdC.Program = 'MEDI' " + _
              "AND MIR.Program = 'TS' AND DateDiff(d, MIR.ReferenceDateTime, Getdate()) <= " + nDiasHistorial.ToString + " "
        bdGrid(sql, HistorialRefTSGrid)
    End Sub

    Private Sub verHistorialTratamientos()
        'fill treatments
        sql = "SELECT dbo.fn_GEN_FormatDate(T.RefDateTime, 'ES') AS Referido, CdT.DescSpanish AS Tratamiento, T.Quantity AS Cantidad, " + _
                "T.Instruction AS Instrucciones, T.Physician AS 'Referido Por', dbo.fn_GEN_FormatDate(T.TreatDateTime, 'ES') AS Atendido, " + _
                "T.TreatBy AS 'Atendido Por', Observations Observaciones " + _
              "FROM dbo.MemberNursTreatment T INNER JOIN dbo.CdHealthTreatment CdT ON T.Treatment = CdT.Code " + _
              "WHERE T.RecordStatus = ' ' AND T.Project = '" + sMember + "' AND T.MemberId = " + PacienteV.Text + " " + _
              "AND DateDiff(d, T.RefDateTime, Getdate()) <= " + nDiasHistorial.ToString + " " + _
              "ORDER BY T.RefDateTime DESC"
        bdGrid(sql, EnferHistory)
    End Sub

End Class