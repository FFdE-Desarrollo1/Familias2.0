' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReembolsosEduc
    Dim creat, tipo, cheque, recibo, formaPago As String
    Dim miembro As Integer

    Private Sub ReembolsosEduc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(MiembroV.Text) = 0 Then
            MiembroV.Focus()
        Else
            validarMiembro()
        End If
    End Sub

    Private Sub ACHCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACHCheckBox.CheckedChanged
        If ACHCheckBox.Checked = True Then
            EfectivoCheckBox.Checked = False
            ChequeCheckBox.Checked = False
            provFavCheckBox.Checked = False
        End If
    End Sub

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
        If Len(ValorV.Text) = 0 And Len(AprobadoV.Text) = 0 Then
            MsgBox("Necesita llenar Valor Total y Total Aprobado", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
        Else
            Dim resultado As Double

            If Double.Parse(AprobadoV.Text) > Double.Parse(ValorV.Text) Then
                MsgBox("Total Aprobado NO puede ser mayor al Valor Total", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            Else
                resultado = Double.Parse(AprobadoV.Text) * 100 / Double.Parse(ValorV.Text)
                PorcentajeV.Text = resultado.ToString("N", CultureInfo.CreateSpecificCulture("es-GT")) + "%"
            End If
        End If
    End Sub

    Private Sub ChequeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeCheckBox.CheckedChanged
        If ChequeCheckBox.Checked = True Then
            EfectivoCheckBox.Checked = False
            ACHCheckBox.Checked = False
            provFavCheckBox.Checked = False
        End If
    End Sub

    Private Sub EfectivoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EfectivoCheckBox.CheckedChanged
        If EfectivoCheckBox.Checked = True Then
            ChequeCheckBox.Checked = False
            ACHCheckBox.Checked = False
            provFavCheckBox.Checked = False
        End If
    End Sub

    Private Function esCorrecto() As Boolean
        esCorrecto = True
        calcularValorAprobado()
        If EfectivoCheckBox.Checked = False And ChequeCheckBox.Checked = False And ACHCheckBox.Checked = False And provFavCheckBox.Checked = False Then
            MsgBox("Necesita indicar la forma de pago", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            esCorrecto = False
        ElseIf Double.Parse(AprobadoV.Text) > Double.Parse(ValorV.Text) Then
            esCorrecto = False
        End If
    End Function

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            irMiembrosDeFamilia()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If esCorrecto() = True Then
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox("¿Esta seguro de guardar los cambios?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                ingresarAutorizacion()
            End If
        End If
    End Sub

    Private Sub ingresarAutorizacion()
        Dim formaPago As String
        Dim apro As String = Double.Parse(AprobadoV.Text).ToString
        ' Project, FunctionalArea, MemberId, Type, ApprovedDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Amount, ApprovedAmount, 
        ' ApprovedBy, ReimbursementDateTime, CheckNumber, ReceiptNumber, Notes, Pay, PrescriptionDate, Indications, ReimbursementBy
        If ACHCheckBox.Checked = True Then
            formaPago = ", ApprovedDateTime, NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'ACH'"
        ElseIf EfectivoCheckBox.Checked = True Then
            formaPago = ", ApprovedDateTime, NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'EFEC'"
        ElseIf provFavCheckBox.Checked = True Then
            formaPago = ", ApprovedDateTime, NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'PROV'"
        Else
            formaPago = ", NULL, NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'CHEQ'"
        End If
        sql = "INSERT INTO dbo.MemberReimbursement " + _
              "SELECT Project, FunctionalArea, MemberId, Type, ApprovedDateTime, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, " + _
              ValorV.Text + ", " + apro + ", ApprovedBy" + formaPago + ", PrescriptionDate, Indications, ReimbursementBy " + _
              "FROM dbo.MemberReimbursement " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
              "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + tipo + "'"
        bdEjecutarSQL(sql)
        limpiar()
        listaReembolsos()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        Dim nxt As New MiembrosFamilia
        nxt.familyId = FamiliaV.Text
        nxt.transac = "RHEM"
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiar()
        cheque = ""
        recibo = ""
        FechaAutoV.Value = Today
        AprobadoPorV.SelectedIndex = -1
        TipoV.SelectedIndex = -1
        ValorV.Text = ""
        AprobadoV.Text = ""
        NotasV.Text = ""
        ACHCheckBox.Checked = False
        EfectivoCheckBox.Checked = False
        ChequeCheckBox.Checked = False
        provFavCheckBox.Checked = False
        ReembolsoInfoPanel.Visible = False
        GuardarButton.Visible = False
    End Sub

    Private Sub ListadoGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        limpiar()
        Dim f, c As Integer
        c = ListadoGrid.CurrentCellAddress.X
        f = ListadoGrid.CurrentCellAddress.Y

        creat = ListadoGrid.Item(2, f).Value()
        tipo = ListadoGrid.Item(3, f).Value()
        Dim pago As String = chequearValor(ListadoGrid.Item(5, f).Value())
        formaPago = chequearValor(ListadoGrid.Item(13, f).Value())
        tipo_Pago()
        If c = 0 Then 'BORRAR
            'If tipoPago = "Efectivo" Or tipoPago = "Proveedor" Or tipoPago = "ACH" Or (tipoPago = "Cheque" And Len(pago) = 0) Then
            If formaPago = "EFEC" Or formaPago = "PROV" Or formaPago = "ACH" Or (formaPago = "CHEQ" And Len(pago) = 0) Then
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox("¿Esta seguro de borrar el reembolso?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    sql = "UPDATE dbo.MemberReimbursement SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + '" + U + "' " + _
                          "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
                          "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + tipo + "'"
                    bdEjecutarSQL(sql)
                    listaReembolsos()
                End If
            Else
                MsgBox("Este reembolso ya tiene fecha de pago, no puede ser borrado", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
            End If
        ElseIf c = 1 Then 'MODIFICAR
            If formaPago = "EFEC" Or formaPago = "PROV" Or formaPago = "ACH" Or (formaPago = "CHEQ" And Len(pago) = 0) Then
                Dim fechaAct As DateTime = ListadoGrid.Item(14, f).Value()
                FechaAutoV.Value = fechaAct
                AprobadoPorV.Text = ListadoGrid.Item(11, f).Value()
                TipoV.Text = ListadoGrid.Item(6, f).Value()
                ValorV.Text = ListadoGrid.Item(8, f).Value()
                PorcentajeV.Text = (ListadoGrid.Item(10, f).Value() * 100).ToString + "%"
                AprobadoV.Text = ListadoGrid.Item(9, f).Value()
                NotasV.Text = chequearValor(ListadoGrid.Item(7, f).Value())

                ReembolsoInfoPanel.Visible = True
                GuardarButton.Visible = True
            Else
                MsgBox("Este reembolso ya tiene fecha de pago, no puede ser modificado", vbQuestion, My.Resources.versionFamilias2)
            End If
        Else
        End If
    End Sub

    Private Sub listaReembolsos()
        'CAST(MR.ApprovedAmount * 100 / MR.Amount AS decimal(6, 2)) AS Porcentaje
        sql = "SELECT 'Borrar' AS Borrar, 'Modificar' AS Modificar, CONVERT(nvarchar(30), MR.CreationDateTime, 21) AS Crea, MR.Type, " + _
              "dbo.fn_GEN_FormatDate(MR.ApprovedDateTime, 'ES') AS Autorizado, dbo.fn_GEN_FormatDate(MR.ReimbursementDateTime, 'ES') AS Pagado, " + _
              "cdT.DescSpanish AS Tipo, MR.Notes AS Observaciones, CAST(MR.Amount AS decimal(6, 2)) AS Cantidad, " + _
              "CAST(MR.ApprovedAmount AS decimal(6, 2)) AS 'Cantidad Aprobada', (MR.ApprovedAmount / MR.Amount)  AS Porcentaje, " + _
              "MR.ApprovedBy AS AprobadoPor, MR.UserId AS Usuario, Pay, CONVERT(nvarchar(30), MR.ApprovedDateTime, 21), cdTP.DescSpanish FormaPago " + _
              "FROM dbo.MemberReimbursement MR INNER JOIN dbo.CdReimbursementType cdT ON MR.Type = cdT.Code " + _
              "LEFT JOIN  CdReimbursementException cdTP ON cdTP.Code = MR.Pay " + _
              "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND MR.MemberId = " + MiembroV.Text + " AND MR.FunctionalArea = 'EDUC' " + _
              "ORDER BY MR.ApprovedDateTime DESC "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(2).Visible = False 'crea
        ListadoGrid.Columns.Item(3).Visible = False 'Tipo
        ListadoGrid.Columns.Item(13).Visible = False ''forma pago
        ListadoGrid.Columns.Item(14).Visible = False ''aprob
        agregarColumnaAccion(0, ListadoGrid)
        agregarColumnaAccion(1, ListadoGrid)
        ListadoGrid.Columns(10).DefaultCellStyle.Format = "p2"
        ListadoGrid.Visible = True
    End Sub

    Private Sub llenarCampos()
        Dim genInfo As New DataTable
        sql = "SELECT FirstNames + ' ' + LastNames Nombre, LastFamilyId Familia FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
        bdDataTable(sql, genInfo)
        NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
        tipoPagoOp()
        listaReembolsos()
        MiembroV.Enabled = False
        FamiliaV.Enabled = False
        ListadoGrid.Visible = True
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
        Dim nxt As New ReembolsosEduc
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub provFavCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles provFavCheckBox.CheckedChanged
        If provFavCheckBox.Checked = True Then
            ChequeCheckBox.Checked = False
            ACHCheckBox.Checked = False
            EfectivoCheckBox.Checked = False
        End If
    End Sub

    Private Sub tipo_Pago()
        If formaPago = "EFEC" Then
            EfectivoCheckBox.Checked = True
        ElseIf formaPago = "PROV" Then
            provFavCheckBox.Checked = True
            provFavCheckBox.Visible = True
        ElseIf formaPago = "ACH" Then
            ACHCheckBox.Checked = True
            ACHCheckBox.Visible = True
        Else
            ChequeCheckBox.Checked = True
            ChequeCheckBox.Visible = True
        End If

        If S = "R" Then
            EfectivoCheckBox.Visible = True
        End If

        ACHCheckBox.Visible = True
        ChequeCheckBox.Visible = True
    End Sub

    Private Sub tipoPagoOp()
        If S = "M" Or S = "N" Then
            ACHCheckBox.Visible = True
            ChequeCheckBox.Visible = True
        ElseIf S = "R" Then
            ACHCheckBox.Visible = True
            EfectivoCheckBox.Visible = True
            ChequeCheckBox.Visible = True
        Else
            ChequeCheckBox.Visible = True
            provFavCheckBox.Visible = False
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
End Class