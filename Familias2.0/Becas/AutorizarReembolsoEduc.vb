' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AutorizarReembolsoEduc
    Dim miembro As Integer
    Dim porcentaje As Double
    Dim difDias As Integer = bdEntero("SELECT PropertyValue N FROM FwApplicationProperty WHERE Organization = '*' AND Category = 'REEM' AND  Name = 'DaysOfLateReimbursement'", "N")

    Private Sub AutorizarReembolsoEduc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        MiembroV.Focus()
        If Len(MiembroV.Text) > 0 Then
            valoresIniciales()
        End If
    End Sub

    Private Sub ACHCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACHCheckBox.CheckedChanged
        If ACHCheckBox.Checked = True Then
            EfectivoCheckBox.Checked = False
            ChequeCheckBox.Checked = False
        End If
    End Sub

    Private Sub ActividadesL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActividadesL.Click
        listaActividades()
    End Sub

    Private Sub AprobadoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AprobadoV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub avisosFamiliares()
        If S = "E" Or S = "A" Then
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                Dim g As System.Drawing.Graphics = Me.CreateGraphics
                Dim ancho As Integer = 0
                Dim avisoLargo As String = ""

                sql = "SELECT Aviso FROM dbo.fn_WARN_avisosES('" + S + "', " + FamiliaV.Text + ") "
                bdGrid(sql, AvisosGrid)

                For f = 0 To AvisosGrid.RowCount - 1
                    If Len(AvisosGrid.Item(0, f).Value()) > ancho Then
                        avisoLargo = AvisosGrid.Item(0, f).Value()
                    End If
                Next

                AvisosGrid.Height = AvisosGrid.RowCount * 25
                AvisosGrid.Width = g.MeasureString(avisoLargo, AvisosGrid.Font).Width
                AvisosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                AvisosGrid.AutoResizeColumns()
                AvisosGrid.Visible = True
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub calcularValorAprobado()
        If Len(ValorV.Text) > 0 Then
            Dim total As Double
            'If Integer.Parse(ValorV.Text) > 0 Then
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

    Private Sub ChequeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequeCheckBox.CheckedChanged
        If ChequeCheckBox.Checked = True Then
            EfectivoCheckBox.Checked = False
            ACHCheckBox.Checked = False
        End If
    End Sub

    Private Sub EfectivoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EfectivoCheckBox.CheckedChanged
        If EfectivoCheckBox.Checked = True Then
            ChequeCheckBox.Checked = False
            ACHCheckBox.Checked = False
        End If
    End Sub

    Private Function esCorrecto() As Boolean
        esCorrecto = True
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
            End If

            If AprobadoV.Text = "" Or AprobadoV.Text = " " Then
                MsgBox("El valor aprobado debe ser mayor a 0", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                esCorrecto = False
            End If
        ElseIf EfectivoCheckBox.Checked = False And ChequeCheckBox.Checked = False And ACHCheckBox.Checked = False Then
            MsgBox("Necesita indicar la forma de pago", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            esCorrecto = False
        ElseIf Double.Parse(AprobadoV.Text) > Double.Parse(ValorV.Text) Then
            MsgBox("La cantidad aprobada no puede ser mayor al valor de la factura", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            esCorrecto = False
        ElseIf verificarDiferenciaFechas() = False Then
            esCorrecto = False
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
        calcularValorAprobado()
        If esCorrecto() = True Then
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            response = MsgBox("¿Necesita hacer alguna modificación antes de guardar? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                ValorV.Enabled = True
                AprobadoV.Enabled = True
            Else
                GuardarButton.Visible = False
                ingresarAutorizacion()
            End If
        End If
    End Sub

    Private Sub HistorialPagosL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialPagosL.Click
        listaReembolsos()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ingresarAutorizacion()
        Dim apro As String = Double.Parse(AprobadoV.Text).ToString
        Dim formaPago As String = ""

        If ACHCheckBox.Checked = True Then
            formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'ACH'"
        ElseIf EfectivoCheckBox.Checked = True Then
            formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'EFEC'"
            'ElseIf provFavCheckBox.Checked = True Then
            '    formaPago = ", '" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'PROV'"
        Else
            formaPago = ", NULL, NULL, NULL, '" + Replace(NotasV.Text, "'", "''") + "', 'CHEQ'"
        End If

        'Project, FunctionalArea, MemberId, Type, ApprovedDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Amount, ApprovedAmount, 
        'ApprovedBy, ReimbursementDateTime, CheckNumber, ReceiptNumber, Notes, Pay, PrescriptionDate, Indications, ReimbursementBy
        sql = "INSERT INTO dbo.MemberReimbursement VALUES ('" + S + "', 'EDUC',  " + MiembroV.Text + ", '" + TipoV.SelectedValue + "', " + _
              "'" + FechaAutoV.Value.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, " + ValorV.Text + ", " + _
              apro + ", '" + AprobadoPorV.Text + "' " + formaPago + ", NULL, NULL, NULL) "
        bdEjecutarSQL(sql)
        listaReembolsos()

        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox("¿Necesita autorizar otro reembolso para el mismo apadrinado? ", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            GuardarButton.Visible = True
            limpiarCampos()
        Else
            Panel1.Visible = False
            GuardarButton.Visible = False
            NuevoButton.Focus()
        End If
    End Sub

    Private Sub irMiembrosDeFamilia()
        Dim nxt As New MiembrosFamilia
        nxt.familyId = FamiliaV.Text
        nxt.transac = "IREM"
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        TipoV.SelectedIndex = -1
        FechaAutoV.Value = DateTime.Now
        ValorV.Text = ""
        TotalDifCheck.Visible = False
        AprobadoV.Text = ""
        NotasV.Text = ""

        porcentajeEduc()
        tipoPagoInicial()
    End Sub

    Private Sub listaReembolsos()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT Tipo, Autorizado, Pagado, Cantidad Total, [Cantidad Aprobada] Aprobado, Porcentaje, AprobadoPor, Observaciones " + _
              "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
              "WHERE YEAR(FechaA) >= YEAR(GETDATE()) AND Area = 'EDUC' " + _
              "ORDER BY FechaA DESC "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Visible = True
    End Sub

    Private Sub listaActividades()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT cdMAT.DescSpanish AS Actividad, dbo.fn_GEN_FormatDate(MA.ActivityDateTime, 'ES') AS Fecha, MA.Notes AS Observaciones, MA.UserId AS Usuario " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdMAT ON MA.Type = cdMAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND FunctionalArea IN ('EDUC', 'APJO') AND MA.Project = '" + S + "' AND YEAR(MA.ActivityDateTime) = YEAR(GETDATE()) AND MA.MemberId = " + MiembroV.Text + _
              " ORDER BY MA.ActivityDateTime DESC "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Visible = True
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(MiembroV.Text) > 0 Then
                miembro = Integer.Parse(MiembroV.Text)
                valoresIniciales()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New AutorizarReembolsoEduc
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub porcentajeEduc()
        porcentaje = porcentajeReembolsosBecas(S, MiembroV.Text) / 100
        PorcentajeV.Text = porcentaje.ToString("P", CultureInfo.CreateSpecificCulture("es-GT"))
    End Sub

    Private Sub listaReembolsosPorTipo()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        sql = "SELECT Tipo, SUM(Cantidad) Total, SUM([Cantidad Aprobada]) Aprobado  " + _
              "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
              "WHERE YEAR(FechaA) = " + FechaAutoV.Value.Year.ToString + " AND Area = 'EDUC' " + _
              "GROUP BY  Tipo ORDER BY  Tipo "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        ListadoGrid.Visible = True
    End Sub

    Private Sub ResumenBecaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenBecaButton.Click
        Dim nxt As New ResumenBecas
        nxt.MiembroV.Text = MiembroV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub reembolsosTipoL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reembolsosTipoL.Click
        listaReembolsosPorTipo()
    End Sub

    Private Sub tipoPagoInicial()
        If S = "N" Then
            sql = "SELECT  dbo.fn_CONT_conCntsNE('" + S + "', " + FamiliaV.Text + "  )  T "
            '  InputBox("select", "Familias", sql)
            If bdEntero(sql, "T") = 0 Then
                ChequeCheckBox.Checked = True
            Else
                ACHCheckBox.Checked = True
                ACHCheckBox.Text = ACHCheckBox.Text '+ " (Familia tiene cuenta) "
            End If

            ChequeCheckBox.Text = ChequeCheckBox.Text + " o Efectivo "
        Else
            If S = "R" Then
                EfectivoCheckBox.Visible = True
                EfectivoCheckBox.Checked = True
            Else
                ChequeCheckBox.Checked = True
            End If

            If S = "F" Then
                ACHCheckBox.Visible = False
            End If
        End If
    End Sub

    Private Sub TotalDifCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDifCheck.CheckedChanged
        If TotalDifCheck.Checked = True Then
            AprobadoV.Enabled = True
        Else
            AprobadoV.Enabled = False
        End If
    End Sub

    Private Function validarMiembro() As Boolean
        If miembroEsValido(S, MiembroV.Text) Then
            If esApadrinado(S, MiembroV.Text) = True Then
                DatosTable.Visible = True
                FamiliaV.Enabled = False
                validarMiembro = True
            Else
                MsgBox("El miembro que ha seleccionado no es apadrinado", vbQuestion, My.Resources.versionFamilias2)
                MiembroV.Text = ""
                validarMiembro = False
            End If
        Else
            MsgBox("El miembro que ha seleccionado no es válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
            validarMiembro = False
        End If
    End Function

    Private Sub valoresIniciales()
        If validarMiembro() = True Then
            Dim genInfo As New DataTable

            sql = "SELECT FirstNames + ' ' + LastNames Nombre, LastFamilyId Familia FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
            bdDataTable(sql, genInfo)
            NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
            FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
            NombreV.Visible = True
            FamiliaV.Enabled = False
            MiembroV.Enabled = False
            If esApadrinado(S, MiembroV.Text) = True Then
                sql = "SELECT MEY.SchoolYear AS Año, S.Name AS Escuela, CdG.DescSpanish AS Grado, cdES.DescSpanish AS Estado, MEY.Notes 'Observaciones'" + _
                      "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.School S ON MEY.Project = S.Project AND MEY.SchoolCode = S.Code AND MEY.RecordStatus = S.RecordStatus " + _
                      "INNER JOIN dbo.CdGrade CdG ON MEY.Grade = CdG.Code INNER JOIN dbo.CdEducationStatus cdES ON MEY.Status = cdES.Code " + _
                      "WHERE MEY.RecordStatus = ' ' AND MEY.Project = '" + S + "' AND MEY.MemberId = " + MiembroV.Text + " AND SchoolYear IN (YEAR(GETDATE()), YEAR(GETDATE()) -1, YEAR(GETDATE()) +1)  " + _
                      "ORDER BY MEY.SchoolYear DESC "
                bdGrid(sql, EducGrid)
                EducGrid.Visible = True

                sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Organization = '" + S + "' AND Status = 'ACTV' AND Role IN ('ASED', 'ASIG', 'ADED', 'AFAC', 'EEDU')  GROUP BY EmployeeId "
                bdComboSinCodigo(sql, AprobadoPorV)
                'AprobadoPorV.Text = U

                sql = "SELECT COUNT(*) Total FROM FwEmployeeRole WHERE Organization = '" + S + "' AND Status = 'ACTV' AND Role IN ('ASED', 'ASIG', 'ADED', 'AFAC', 'EEDU')  GROUP BY EmployeeId "
                If bdEntero(sql, "Total") > 0 Then
                    AprobadoPorV.Text = U
                    AprobadoPorV.Enabled = False
                End If

                sql = "SELECT Code AS Codigo, DescSpanish AS Descripcion FROM dbo.CdReimbursementType " + _
                      "WHERE FunctionalArea = 'EDUC' AND Active = 1 AND Project IN ('" + S + "', '*') "
                bdCombo(sql, TipoV, "Codigo", "Descripcion")
                TipoV.SelectedIndex = -1

                porcentajeEduc()
                GuardarButton.Visible = True
                GenInfoTable.Visible = True
                avisosFamiliares()
                tipoPagoInicial()
                'selTipoPago()
                listaReembolsos()
                PagoInfoPanel.Visible = True
                AvisosLink.Visible = True
                TipoV.Focus()
            End If
        Else
        End If
    End Sub

    Private Sub ValorV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValorV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
        End If

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

    Private Function verificarDiferenciaFechas() As Boolean
        Dim dif As Integer = DateDiff(DateInterval.Day, FechaAutoV.Value, DateTime.Now)
        If dif < 0 Then
            If FechaAutoV.Value.Day = 1 And FechaAutoV.Value.Month = 1 Then
                verificarDiferenciaFechas = True
            Else
                verificarDiferenciaFechas = False
                MsgBox("No puede ingresar autorizaciones a futuro", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            End If
        ElseIf dif > difDias Then
            verificarDiferenciaFechas = False
            MsgBox("La fecha de autorización no puede exceder a los " + difDias.ToString + " dias. La diferencia es: " + dif.ToString + " días", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
        Else
            verificarDiferenciaFechas = True
        End If
    End Function
End Class