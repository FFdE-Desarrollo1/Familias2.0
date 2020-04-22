﻿' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AutorizarReembolsosRece
    Dim porcentaje As Double
    Dim nDiasHistorial As Integer = 365
    Dim tieneCta As Boolean
    Dim total As Double

    Private Sub AutorizarReembolsosRece_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    '        provFavCheckBox.Checked = False
    '    End If
    'End Sub

    Private Sub avisosFamiliares()
        If S = "E" Or S = "A" Then
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                Dim g As System.Drawing.Graphics = Me.CreateGraphics
                Dim ancho As Integer = 0
                Dim avisoLargo As String = ""

                sql = "SELECT Aviso FROM dbo.fn_WARN_avisosES('" + S + "', " + FamiliaV.Text + ") "
                bdGrid(sql, AvisosGrid)

                If AvisosGrid.RowCount > 0 Then
                    AvisosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                    AvisosGrid.AutoResizeColumns()
                    AvisosGrid.Visible = True
                    AvisosL.Visible = True
                End If
            End If
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
    '        provFavCheckBox.Checked = False
    '    End If
    'End Sub

    'Private Sub EfectivoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If EfectivoCheckBox.Checked = True Then
    '        ChequeCheckBox.Checked = False
    '        ACHCheckBox.Checked = False
    '        provFavCheckBox.Checked = False
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
            If Len(FamiliaV.Text) > 0 Then
                irMiembrosDeFamilia()
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
                'limpiarCampos()
            End If
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ingresarAutorizacion()
        Dim apro As String = Double.Parse(AprobadoV.Text).ToString
        Dim formaPago As String = ""

        'If ACHCheckBox.Checked = True Then
        '    formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'ACH'"
        'ElseIf EfectivoCheckBox.Checked = True Then
        '    formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'EFEC'"
        'ElseIf provFavCheckBox.Checked = True Then
        '    formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'PROV'"
        'Else
        '    formaPago = ", NULL, NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'CHEQ'"
        'End If

        formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', '" + formaCombo.SelectedValue + "'"

        'Project, FunctionalArea, MemberId, Type, ApprovedDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Amount, ApprovedAmount, 
        'ApprovedBy, ReimbursementDateTime, CheckNumber, ReceiptNumber, Notes, Pay, PrescriptionDate, Indications, ReimbursementBy
        sql = "INSERT INTO dbo.MemberReimbursement VALUES ('" + S + "', 'CLIN',  " + MiembroV.Text + ", '" + TipoV.SelectedValue + "', " + _
              "'" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, " + ValorV.Text + ", " + _
              apro + ", '" + AprobadoPorV.Text + "' " + formaPago + ", NULL, NULL, NULL) "
        bdEjecutarSQL(sql)
        listaReembolsos()

        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox("¿Necesita autorizar otro reembolso para el mismo paciente? ", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            GuardarButton.Visible = True
            limpiarCampos()
        Else
            Panel1.Visible = False
            GuardarButton.Visible = False
            NuevoButton.Focus()
            limpiarCampos()
            FacturaTable.Visible = False
        End If


    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "IRCR"
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
        sql = "SELECT Tipo, Autorizado, Pagado, Cantidad Total, [Cantidad Aprobada] Aprobado, Porcentaje, AprobadoPor, Observaciones " + _
             "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
             "WHERE DateDiff(d, FechaA, Getdate()) <= " + nDiasHistorial.ToString + " AND Area = 'CLIN' " + _
             "ORDER BY FechaA DESC "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Visible = True
    End Sub

    Private Sub llenarCampos()
        Dim genInfo As New DataTable
        sql = "SELECT FirstNames + ' ' + LastNames Nombre, LastFamilyId Familia FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
        bdDataTable(sql, genInfo)
        NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
        TipoMiembroV.Text = chequearValor(tipo_Miembro(S, MiembroV.Text))
        ClasificacionV.Text = "Clasificación: " & clasificacionFamiliar(S, FamiliaV.Text)

        If S = "F" Or S = "S" Or S = "E" Then
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization ='F' "
            bdComboSinCodigo(sql, AprobadoPorV)
        Else
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'AFAC' AND Organization = '" + S + "' "
            bdComboSinCodigo(sql, AprobadoPorV)
        End If

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
        avisosFamiliares()
        MiembroV.Enabled = False
        FamiliaV.Enabled = False
        GuardarButton.Visible = True
        ListadoGrid.Visible = True
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

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New AutorizarReembolsosRece
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub porcentajeSalud()
        porcentaje = porcentajeReembolsosSalud(S, MiembroV.Text) / 100
        PorcentajeV.Text = porcentaje.ToString("P", CultureInfo.CreateSpecificCulture("es-GT"))
    End Sub

    'Private Sub provFavCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If provFavCheckBox.Checked = True Then
    '        ChequeCheckBox.Checked = False
    '        ACHCheckBox.Checked = False
    '        EfectivoCheckBox.Checked = False
    '    End If
    'End Sub

    Private Sub tipoPagoOp()
        sql = "SELECT COUNT(*) AS T FROM dbo.FamilyACHAccount " + _
              "WHERE RecordStatus = ' ' AND Active = 1 AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
        Dim nCtas As Integer = bdEntero(sql, "T")

        If nCtas > 0 Then 'tiene cuenta bancaria
            tieneCta = True
            formaCombo.SelectedValue = "ACH"
            CtaL.Text = "*La familia tiene cuenta bancaria"
            CtaL.Visible = True
            'ACHCheckBox.Checked = True
            'ACHCheckBox.Text = ACHCheckBox.Text + " (Familia tiene cuenta) "
            'ACHCheckBox.Visible = True
        Else
            tieneCta = False
            CtaL.Visible = False
            formaCombo.SelectedValue = "CHEQ"
        End If


        'If S = "N" Then
        '    'sql = "SELECT COUNT(*) AS T FROM FamilyMiscInfo " +
        '    '      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " AND ActiveBankAccount = 1 "
        '    'If bdEntero(sql, "T") = 0 Then
        '    '    ChequeCheckBox.Checked = True
        '    'Else
        '    '    ACHCheckBox.Checked = True
        '    '    ACHCheckBox.Text = ACHCheckBox.Text + " (Familia tiene cuenta) "
        '    'End If

        '    'ChequeCheckBox.Text = ChequeCheckBox.Text + " o Efectivo "
        'Else
        '    If S = "R" Then
        '        EfectivoCheckBox.Visible = True
        '        EfectivoCheckBox.Checked = True
        '    Else
        '        ChequeCheckBox.Checked = True
        '    End If

        '    If S = "F" Then
        '        ACHCheckBox.Visible = False
        '        provFavCheckBox.Visible = True
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