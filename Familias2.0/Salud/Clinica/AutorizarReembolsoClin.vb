' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AutorizarReembolsoClin
    Dim miembro As Integer
    Dim porcentaje As Double
    Dim nDiasHistorial As Integer = 365
    Dim total As Double
    Dim tieneCta As Boolean

    Private Sub AutorizarReembolsoClin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        GenInfoTable.Visible = False
        If Len(MiembroV.Text) = 0 Then
            FamiliaV.Focus()
        Else
            validarMiembro()
        End If
    End Sub

    'Private Sub ACHCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If ACHCheckBox.Checked = True Then
    '        EfectivoCheckBox.Checked = False
    '        ChequeCheckBox.Checked = False
    '    End If
    'End Sub

    Private Sub AprobadoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AprobadoV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub calcularValorAprobado()
        If Len(ValorV.Text) > 0 Then

            If TotalDifCheck.Checked = True Then
                If Len(AprobadoV.Text) = 0 Or Len(ValorV.Text) = 0 Then
                Else
                    total = Double.Parse(AprobadoV.Text) * 100 / Double.Parse(ValorV.Text)
                    PorcentajeV.Text = total.ToString("N", CultureInfo.CreateSpecificCulture("es-GT")) + "%"
                End If
            Else
                total = Double.Parse(ValorV.Text) * porcentaje
                AprobadoV.Text = total.ToString("N", CultureInfo.CreateSpecificCulture("es-GT"))
            End If
        Else
        End If
    End Sub

    'Private Sub ChequeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If ChequeCheckBox.Checked = True Then
    '        EfectivoCheckBox.Checked = False
    '        ACHCheckBox.Checked = False
    '    End If
    'End Sub

    Private Sub Consultas_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Consultas.LinkClicked
        'fill consultation history
        sql = "SELECT dbo.fn_GEN_FormatDate(MCC.ConsultationDateTime, 'ES') AS Fecha,  D1.DescSpanish AS Diagnostico1, " + _
              "D2.DescSpanish AS Diagnostico2, D3.DescSpanish AS Diagnostico3 " + _
              "FROM  dbo.MemberClinicConsultation MCC INNER JOIN " + _
              "dbo.MemberClinicAppointment MCA ON MCC.AppId = MCA.AppId AND MCC.RecordStatus = MCA.RecordStatus " + _
              "INNER JOIN dbo.CdDiagnosis D1 ON MCC.PrimaryDiagnosis = D1.Code " + _
              "LEFT OUTER JOIN dbo.CdDiagnosis D2 ON MCC.SecondaryDiagnosis1 = D2.Code " + _
              "LEFT OUTER JOIN dbo.CdDiagnosis D3 ON MCC.SecondaryDiagnosis2 = D3.Code " + _
              "WHERE MCC.RecordStatus = ' ' AND DateDiff(d, MCC.ConsultationDateTime, Getdate()) <= " + nDiasHistorial.ToString + "  AND MCA.Project = '" + S + "' AND MCA.MemberId = " + MiembroV.Text
        bdGrid(sql, ListadoGrid)
    End Sub

    'Private Sub EfectivoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If EfectivoCheckBox.Checked = True Then
    '        ChequeCheckBox.Checked = False
    '        ACHCheckBox.Checked = False
    '    End If
    'End Sub

    Private Function esCorrecto() As Boolean
        esCorrecto = True
        calcularValorAprobado()

        If Len(AprobadoPorV.Text) = 0 Or Len(TipoV.Text) = 0 Or Len(ValorV.Text) = 0 Or Len(AprobadoV.Text) = 0 Then
            If AprobadoPorV.Text = "" Or AprobadoPorV.Text = " " Then
                MsgBox("Necesita seleccionar quien esta autorizando la factura", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                esCorrecto = False
            End If

            If TipoV.Text = "" Or TipoV.Text = " " Then
                MsgBox("Necesita seleccionar el tipo de pago que se esta autorizando", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                esCorrecto = False
            End If

            If ValorV.Text = "" Or ValorV.Text = " " Then
                MsgBox("El valor debe ser mayor a 0", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                esCorrecto = False
            Else
            End If

            If AprobadoV.Text = "" Or AprobadoV.Text = " " Then
                MsgBox("El valor aprobado debe ser mayor a 0", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                esCorrecto = False
            End If
        ElseIf formaCombo.SelectedIndex < 0 Then
            MsgBox("Necesita indicar la forma de pago", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            esCorrecto = False
        End If

        If Double.Parse(AprobadoV.Text) > Double.Parse(ValorV.Text) Then
            MsgBox("Lo aprobado no puede ser mayor al total", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            esCorrecto = False
        End If

        Dim intervalo As TimeSpan = FechaAutoV.Value - DateTime.Now

        If FechaAutoV.Value.Year = DateTime.Now.Year And FechaAutoV.Value.Month = DateTime.Now.Month And FechaAutoV.Value.Day = DateTime.Now.Day Then
        Else
            If intervalo.Days < 0 Then
                MsgBox("La fecha no puede ser menor a la actual", vbInformation, My.Resources.versionFamilias2)
                esCorrecto = False
            Else
                If formaCombo.SelectedValue = "CHEQ" Then
                    MsgBox("No puede ingresar reembolsos a futuro con pago - cheque", vbInformation, My.Resources.versionFamilias2)
                    esCorrecto = False
                End If
            End If
        End If
    End Function

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) = 0 Then
            Else
                If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                    irMiembrosDeFamilia()
                Else
                    MsgBox("La familia que ha seleccionado no es afiliada", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                    FamiliaV.Text = ""
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox("¿Necesita hacer alguna modificación antes de guardar? ", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            ValorV.Enabled = True
            AprobadoV.Enabled = True
        Else
            If esCorrecto() = True Then
                GuardarButton.Visible = False
                ingresarAutorizacion()
                limpiarCampos()
            End If
        End If
    End Sub

    Private Sub ingresarAutorizacion()
        Dim apro As String = Double.Parse(AprobadoV.Text).ToString
        Dim formaPago As String = ""

        formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', '" + formaCombo.SelectedValue + "'"

        'Project, FunctionalArea, MemberId, Type, ApprovedDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Amount, ApprovedAmount, 
        'ApprovedBy, ReimbursementDateTime, CheckNumber, ReceiptNumber, Notes, Pay, PrescriptionDate, Indications, ReimbursementBy
        sql = "INSERT INTO dbo.MemberReimbursement VALUES ('" + S + "', 'CLIN',  " + MiembroV.Text + ", '" + TipoV.SelectedValue + "', " + _
              "'" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, " + ValorV.Text + ", " + _
              apro + ", '" + AprobadoPorV.Text + "' " + formaPago + ", NULL, NULL, NULL) "
        bdEjecutarSQL(sql)
        listaReembolsos()
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
            nxt.transac = "IRCM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarCampos()
        FechaAutoV.Value = DateTime.Now
        AprobadoPorV.SelectedIndex = -1
        TipoV.SelectedIndex = -1
        formaCombo.SelectedIndex = -1
        ValorV.Text = ""
        PorcentajeV.Text = porcentaje.ToString("P", CultureInfo.CreateSpecificCulture("es-GT"))
        AprobadoV.Text = ""
        NotasV.Text = ""
        TotalDifCheck.Checked = False
        TotalDifCheck.Visible = False
        tipoPagoOp()
        FechaAutoV.Focus()
    End Sub

    Private Sub listaReembolsos()
        'fill reimbursement history 
        sql = "SELECT Tipo, Autorizado, Pagado, Cantidad Total, [Cantidad Aprobada] Aprobado, Porcentaje, AprobadoPor, Observaciones " + _
             "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
             "WHERE DateDiff(d, FechaA, Getdate()) <= " + nDiasHistorial.ToString + " AND Area = 'CLIN' " + _
             "ORDER BY FechaA DESC "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Visible = True
    End Sub

    Private Sub llenarCampos()
        Dim genInfo As New DataTable
        sql = "SELECT FirstNames + ' ' + LastNames Nombre, LastFamilyId Familia FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId = " + miembro.ToString
        bdDataTable(sql, genInfo)
        NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
        ClasificacionV.Text = "Clasificación: " & clasificacionFamiliar(S, FamiliaV.Text)

        If S = "F" Or S = "S" Or S = "E" Then
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization ='F' "
        Else
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'AFAC' AND Organization = '" + S + "' "
        End If
        bdComboSinCodigo(sql, AprobadoPorV)
        AprobadoPorV.Text = U

        sql = "SELECT COUNT(*) Total FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization ='" + S + "' AND EmployeeId = '" + U + "' "
        If bdEntero(sql, "Total") > 0 Then
            AprobadoPorV.Text = U
            AprobadoPorV.Enabled = False
        End If

        sql = "SELECT     Code AS Codigo, DescSpanish AS Descripcion FROM dbo.CdReimbursementType " + _
              "WHERE FunctionalArea = 'CLIN' AND Active = 1 AND Project IN ('" + S + "', '*') "
        bdCombo(sql, TipoV, "Codigo", "Descripcion")
        TipoV.SelectedIndex = -1

        sql = "SELECT Code, DescSpanish AS D FROM CdPayMode WHERE Active = 1 "
        bdCombo(sql, formaCombo, "Code", "D")

        tipoPagoOp()
        listaReembolsos()
        porcentajeSalud()

        MiembroV.Enabled = False
        FamiliaV.Enabled = False
        GuardarButton.Visible = True
        ListadoGrid.Visible = True

        Reembolsos.Visible = True
        RecetasExt.Visible = True
        ReferenciasExt.Visible = True
        Consultas.Visible = True
        Medicina.Visible = True
        ReembolsoInfoPanel.Visible = True
        GenInfoTable.Visible = True
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If (MiembroV.Text) = 0 Then
            Else
                validarMiembro()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Medicina_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Medicina.LinkClicked
        'fill meds history
        sql = "SELECT Prescripción, Entrega, Medicina, Observaciones " + _
              "FROM dbo.fn_HEAL_getItemHistory('" + S + "', " + MiembroV.Text + ") " + _
              "WHERE Cantidad < 0  AND DateDiff(d, dateT, Getdate()) <= " + nDiasHistorial.ToString + "  " + _
              "ORDER BY DateT DESC "
        bdGrid(sql, ListadoGrid)
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New AutorizarReembolsoClin
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub porcentajeSalud()
        porcentaje = porcentajeReembolsosSalud(S, MiembroV.Text) / 100
        PorcentajeV.Text = porcentaje.ToString("P", CultureInfo.CreateSpecificCulture("es-GT"))
    End Sub

    Private Sub RecetasExt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RecetasExt.LinkClicked
        'fill external prescriptions
        sql = "SELECT dbo.fn_GEN_FormatDate(PresDateTime, 'ES') AS Fecha, Medicine AS Medicina, Quantity AS Cantidad, Instruction AS Rp " + _
              "FROM dbo.MemberClinicExternalPrescription MCEP " + _
              "WHERE DateDiff(d, PresDateTime, Getdate()) <= " + nDiasHistorial.ToString + " AND RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
        bdGrid(sql, ListadoGrid)
    End Sub

    Private Sub Reembolsos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Reembolsos.LinkClicked
        listaReembolsos()
    End Sub

    Private Sub ReferenciasExt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ReferenciasExt.LinkClicked
        'fill external references
        sql = "SELECT dbo.fn_GEN_FormatDate(MCER.ReferenceDateTime, 'ES') AS Fecha, cdP.DescSpanish AS [Referido A], cdR.DescSpanish AS Motivo, MCER.Rp " + _
              "FROM dbo.MemberClinicExternalReference MCER INNER JOIN dbo.CdHealthExternalReferencePlace cdP ON MCER.Place = cdP.Code " + _
              "INNER JOIN dbo.CdHealthExternalReferenceReason cdR ON MCER.Reason = cdR.Code " + _
              "WHERE MCER.RecordStatus = ' ' AND DateDiff(d, ReferenceDateTime, Getdate()) <= " + nDiasHistorial.ToString + " AND MCER.Project = '" + S + "' AND MCER.MemberId = " + MiembroV.Text
        bdGrid(sql, ListadoGrid)
    End Sub

    Private Sub tipoPagoOp()
        sql = "SELECT COUNT(*) AS T FROM dbo.FamilyACHAccount " + _
                "WHERE RecordStatus = ' ' AND Active = 1 AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
        Dim nCtas As Integer = bdEntero(sql, "T")

        If nCtas > 0 Then 'tiene cuenta bancaria
            tieneCta = True
            formaCombo.SelectedValue = "ACH"
            CtaL.Text = "*La familia tiene cuenta bancaria"
            CtaL.Visible = True
        Else
            tieneCta = False
            CtaL.Visible = False
            formaCombo.SelectedValue = "CHEQ"
        End If

        'If S = "N" Then
        '    sql = "SELECT COUNT(*) AS T FROM FamilyMiscInfo " +
        '          "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " AND ActiveBankAccount = 1 "
        '    If bdEntero(sql, "T") = 0 Then
        '        ChequeCheckBox.Checked = True
        '    Else
        '        ACHCheckBox.Checked = True
        '        ACHCheckBox.Text = ACHCheckBox.Text + " (Familia tiene cuenta) "
        '    End If

        '    ChequeCheckBox.Text = ChequeCheckBox.Text + " o Efectivo "
        'Else
        '    If S = "R" Then
        '        EfectivoCheckBox.Visible = True
        '        EfectivoCheckBox.Checked = True
        '    ElseIf S = "F" Then
        '        ACHCheckBox.Visible = False
        '        ChequeCheckBox.Checked = True
        '    Else
        '        ChequeCheckBox.Checked = True
        '    End If
        'End If
    End Sub

    Private Sub TotalDifCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDifCheck.CheckedChanged
        If TotalDifCheck.Checked = True Then
            AprobadoV.Enabled = True
        Else
            TotalDifCheck.Visible = False
        End If
    End Sub

    Private Sub validarMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            If tieneDerechosSalud(S, MiembroV.Text) = True Then
                miembro = Integer.Parse(MiembroV.Text)
                llenarCampos()
                Dim familia As Integer = Integer.Parse(FamiliaV.Text)

                DatosTable.Visible = True
                FamiliaV.Enabled = False
            Else
                MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
                MiembroV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
        End If
    End Sub

    Private Sub ValorV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValorV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ValorV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorV.TextChanged
        AprobadoV.Enabled = False
        TotalDifCheck.Visible = True
    End Sub

    Private Sub ValorV_Leave(sender As Object, e As EventArgs) Handles ValorV.Leave
        calcularValorAprobado()

        If tieneCta = True Then
            If total < 50.0 Then
                formaCombo.SelectedValue = "CHEQ"
            End If
        End If
    End Sub
End Class