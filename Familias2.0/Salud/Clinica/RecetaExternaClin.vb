' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class RecetaExternaClin
    Public sMember As String
    Dim dosage, affilStatus As String
    Dim memberId, iMeds As Integer
    Dim orTotal, hPercent, orPercentage, costExam As Double

    Private Sub RecetaExternaClin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(PacienteV.Text) > 0 Then
            valoresIniciales()
        Else
            FamiliaV.Focus()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub calculateTotalPrice(ByVal mostrarMsGPay As Boolean)
        Dim normalPrice, totalPrice As Double
        If MedsGrid.RowCount = 0 Then
            normalTotalV.Text = "0.00"
            PrecioNormalV.Text = "0.00"
            ExonerarCheck.Visible = False
        Else
            normalPrice = sumarPreciosMeds()
            totalPrice = (normalPrice * Convert.ToDouble(normalPercentageV.Text)) / 100
            orTotal = totalPrice
            PrecioNormalV.Text = normalPrice.ToString("F", CultureInfo.InvariantCulture) 'normal Price
            normalTotalV.Text = totalPrice.ToString("F", CultureInfo.InvariantCulture)
        End If

        If S = "F" Or S = "S" Then
            If normalTotalV.Text = "0.00" Or normalTotalV.Text = "0" Or Double.Parse(normalPercentageV.Text) = 0 Then
                ExonerarCheck.Visible = False
                ExonerarCheck.Checked = False
            Else
                ExonerarCheck.Visible = True
            End If
        Else
            ExonerarCheck.Visible = False
        End If

        MsGPay()
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub checkCorrelativeMeds()
        Dim n As Integer = MedsGrid.Rows.Count - 1
        For f = 0 To n
            MedsGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
        Next
        calculateTotalPrice(False)
    End Sub

    Private Function esValidaNuevaMedicina() As Boolean
        If MedsCombo.Text = "" Or IsDBNull(MedsCombo.Text) Then
            MsgBox("Necesita seleccionar una medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        ElseIf CantidadV.Text = "" Or IsDBNull(CantidadV.Text) Then
            MsgBox("Necesita ingresar la cantidad de la medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        ElseIf InstrucV.Text = "" Or IsDBNull(InstrucV.Text) Then
            MsgBox("Necesita ingresar las instrucciones de la medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        Else
            esValidaNuevaMedicina = True
        End If
    End Function

    Private Function existeEnListado(ByVal insert As String,
                                 ByVal listGrid As DataGridView,
                                 ByVal col As Integer) As Boolean
        If insert = "OTRA" Then
            existeEnListado = False
        Else
            Dim n As Integer = listGrid.Rows.Count - 1
            Dim exist As Integer = 0
            For f = 0 To n
                listGrid.Item(0, f).Value = f
                If listGrid.Item(col, f).Value = insert Then
                    exist = exist + 1
                End If
            Next

            If exist > 0 Then
                existeEnListado = True
            Else
                existeEnListado = False
            End If
        End If
    End Function

    Private Sub ExonerarCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExonerarCheck.CheckedChanged
        MsGPay()
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) = 0 Then
            Else
                If familiaEsValida(S, FamiliaV.Text) = True Then
                    irMiembrosDeFamilia()
                Else
                    MsgBox("La familia no es válida: " + FamiliaV.Text, vbInformation, My.Resources.versionFamilias2)
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

    Private Sub fillMedsGrid()
        Dim price, totalByMed, apr As Double
        price = getMedPrice(MedsCombo.SelectedValue)
        totalByMed = price * Convert.ToDouble(CantidadV.Text)
        apr = totalByMed * (Double.Parse(normalPercentageV.Text) / 100)

        Dim a() As String = {"", MedsCombo.SelectedValue, MedsCombo.Text, CantidadV.Text, InstrucV.Text, ObservacionesV.Text, price.ToString("F2"), totalByMed.ToString("F2"), apr.ToString("F2")}
        MedsGrid.Rows.Add(a)
        checkCorrelativeMeds()
        calculateTotalPrice(True)
    End Sub

    Private Sub getClassificationAndPercentage()
        If esApadrinado(S, memberId) = True Then
            memTypeV.Text = "Apadrinado"
            normalPercentageV.Text = "0.00"
            normalTotalV.Text = "0.00"
        ElseIf Len(ClassificationV.Text) > 0 Then
            sql = "SELECT HealthPercent FROM  dbo.CdFamilyClassification WHERE Code = '" + ClassificationV.Text + "' "
            memTypeV.Text = "Familiar"
            normalPercentageV.Text = bdEntero(sql, "HealthPercent")
        Else
            Dim exception, excSQL As String
            excSQL = "FROM dbo.MemberRightException MRE " + _
                     "WHERE RecordStatus = ' ' AND MRE.Project = '" + S + "' AND AddOrRemove = 'A' AND ProjectRight = 'CLIN' AND " + _
                     "(EndDate IS NULL OR EndDate > GETDATE()) AND MRE.MemberId = " + memberId.ToString + " "

            exception = bdEntero("SELECT  COUNT(*) as Total " + excSQL, "Total")
            If exception > 0 Then
                Dim exPercentage As Integer
                exPercentage = bdEntero("SELECT  PercentageToPay " + excSQL, "PercentageToPay")
                normalPercentageV.Text = exPercentage.ToString
            Else
                normalPercentageV.Text = "50.00"
            End If
        End If

        orPercentage = Convert.ToDouble(normalPercentageV.Text)
        normalPercentageV2.Text = normalPercentageV.Text + "%"
    End Sub

    Private Function getMedPrice(ByVal code As String) As String
        Dim codeSQL As String
        codeSQL = "SELECT Price FROM dbo.CdHealthInventoryItem WHERE code = '" + code + "' "
        getMedPrice = bdDoble(codeSQL, "Price")
    End Function

    Private Sub guardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        calculateTotalPrice(True)
        guardarListadoMeds()
    End Sub

    Private Sub guardarListadoMeds()
        If MedsGrid.Rows.Count() >= 1 Then
            Dim actual As DateTime = DateTime.Now
            For i = 0 To MedsGrid.Rows.Count() - 1
                insertarMedicina(actual.ToString(en.DateTimeFormat), MedsGrid.Item(1, i).Value().ToString, MedsGrid.Item(3, i).Value().ToString, MedsGrid.Item(4, i).Value().ToString,
                                 MedsGrid.Item(5, i).Value().ToString, MedsGrid.Item(6, i).Value().ToString, MedsGrid.Item(8, i).Value().ToString)
            Next
            If Double.Parse(normalTotalV.Text) > 0 And ExonerarCheck.Checked = False Then
                MsgBox("El total a pagar es: Q" + normalTotalV.Text, vbInformation, My.Resources.versionFamilias2)
            End If

            historial()
            MasMedsBoton.Visible = False
            GuardarButton.Visible = False
            MedsGrid.Enabled = False
        End If
    End Sub

    Private Sub historial()
        'fill meds history
        sql = "SELECT Prescripción, Entrega, Medicina, Cantidad * -1 Cantidad,  Observaciones, Indications Indicaciones " + _
              "FROM dbo.fn_HEAL_getItemHistory('" + S + "', " + PacienteV.Text + ") " + _
              "WHERE Cantidad < 0  " + _
              "ORDER BY DateT DESC "
        bdGrid(sql, MedsHistorialGrid)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub insertarMedicina(ByVal fech As String, ByVal codMed As String, ByVal cant As String,
                                 ByVal indi As String, ByVal obse As String, ByVal uPri As String,
                                 ByVal aTpri As String)
        Dim tranId As Integer
        sql = "SELECT MAX(IdTransac) AS Ultimo FROM dbo.HealthInventoryTransactionMedi "
        tranId = bdEntero(sql, "Ultimo") + 1

        Dim exon As String
        If ExonerarCheck.Checked = True Then
            exon = "1"
        Else
            exon = "0"
        End If

        'IdTransac, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea, 
        'MemberProject, MemberId, UnitPrice, TotalApproved, Indications, Notes, IdConsultation, PayDateTime, DeliveryDateTime, DeliveredBy, ByCredit, Exoneration, TypePres
        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi VALUES (" + tranId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, 'F', " + _
         "'" + fech + "', '" + U + "', '" + codMed + "', " + (cant * -1).ToString + ", 'CLIN', '" + S + "', " + PacienteV.Text + ", " + uPri + ", " + aTpri + _
         ", '" + indi + "', '" + obse + "', NULL, NULL, NULL, NULL, 0, " + exon + ", '" + TipoRecetaCombo.SelectedValue + "')"
        bdInsertar(sql)
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "ARE"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub MasMedsBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasMedsBoton.Click
        If esValidaNuevaMedicina() = True Then
            If existeEnListado(MedsCombo.SelectedValue, MedsGrid, 1) = True Then 'check if the med is not in the list
                MsgBox("La medicina seleccionada ya existe en la receta", vbInformation, My.Resources.versionFamilias2)
            Else
                If Mid(MedsCombo.SelectedValue, 3) = "00" Or Mid(MedsCombo.SelectedValue, 3) = "0" Then
                    MsgBox("Esta seleccionando una categoria, no un medicamento", vbInformation, My.Resources.versionFamilias2)
                Else
                    If suficienteExistencia(MedsCombo.SelectedValue, CantidadV.Text, MedsCombo.Text) = True Then 'check actually quantity
                        fillMedsGrid()
                        iMeds = iMeds + 1
                    End If
                End If
                MedsCombo.SelectedIndex = -1
                CantidadV.Text = ""
                InstrucV.Text = ""
                ObservacionesV.Text = ""
                checkCorrelativeMeds()
                MedsCombo.Focus()
            End If
        End If
    End Sub

    Private Sub MsGPay()
        If normalTotalV.Text = "0.00" Or normalTotalV.Text = "0" Or Double.Parse(normalPercentageV.Text) = 0 Then 'Or            (CambiarPerTotCheck.Checked = True And Double.Parse(newValueV.Text) = 0.0) Then
            If MedsGrid.Rows.Count = 0 Then
                MSGv.Text = ""
            Else
                MSGv.Text = "El paciente puede pasar a Farmacia a recoger su medicina"
            End If
        Else
            If ExonerarCheck.Checked = True Then
                MSGv.Text = "El paciente puede pasar a Farmacia a recoger su medicina"
            Else
                MSGv.Text = "El paciente necesita ir a CAJA a pagar: Q. " + normalTotalV.Text
            End If

        End If
        MSGv.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New RecetaExternaClin
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PacienteV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PacienteV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(PacienteV.Text) = 0 Then
            Else
                If miembroEsValido(S, PacienteV.Text) = True Then
                    memberId = Integer.Parse(PacienteV.Text)
                    valoresIniciales()
                    Dim familia As Integer = Integer.Parse(FamiliaV.Text)

                    If derechosSalud(S, memberId, familia) = True Then
                        TratPanel.Visible = True
                        FamiliaV.Enabled = False
                        PacienteV.Enabled = False
                    Else
                        TratPanel.Visible = False
                        MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
                    End If
                Else
                    MsgBox("El No. Paciente no es válido: " + PacienteV.Text, vbQuestion, My.Resources.versionFamilias2)
                    PacienteV.Text = ""
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles MedsGrid.RowsRemoved
        calculateTotalPrice(True)
    End Sub

    Private Function suficienteExistencia(ByVal medicine As String, _
                                        ByVal quantity As Integer, _
                                        ByVal descMed As String) As Boolean
        If quantity = 0 Then
            MsgBox("La cantidad de " + medicine.ToUpper + " tiene que ser mayor a 0", vbCritical, My.Resources.versionFamilias2)
            suficienteExistencia = False
        Else
            If medicine = "OTRA" Then
                suficienteExistencia = True
            Else
                sql = "SELECT dbo.fn_HEAL_existenciaConReservas('" + medicine + "', GETDATE()) Total "
                Dim actualQuant As Integer = bdEntero(sql, "Total")

                If actualQuant < quantity Then
                    MsgBox("La existencia actual para " + descMed + " es de: " + actualQuant.ToString, vbCritical, My.Resources.versionFamilias2)
                    suficienteExistencia = False
                Else
                    suficienteExistencia = True
                End If
            End If
        End If
    End Function

    Private Function sumarPreciosMeds() As Double
        Dim n As Integer = MedsGrid.Rows.Count
        If n = 0 Then
            sumarPreciosMeds = 0.0
        Else
            Dim total, precio As Double
            Dim z As Integer
            total = 0
            precio = 0

            Do While z < n
                precio = Convert.ToDouble(MedsGrid.Item(7, z).Value)
                total = total + precio
                z = z + 1
            Loop
            sumarPreciosMeds = total
        End If
    End Function

    Private Sub TotalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalButton.Click
        calculateTotalPrice(True)
    End Sub

    Private Sub valoresIniciales()
        Dim genInfo As New DataTable
        sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, dbo.fn_GEN_CalcularEdad(BirthDate) AS Edad, M.LastFamilyId Familia, F.Classification Clasificacion, " + _
              "dbo.fn_SALU_porcentajeCobro(M.Project, M.MemberId, GETDATE()) HealthPercent " + _
              "FROM Member M INNER JOIN Family F ON M.RecordStatus = F.RecordStatus AND " + _
              "M.Project = F.Project AND M.LastFamilyId = F.FamilyId WHERE M.RecordStatus = ' '  AND M.Project = '" + S + "' AND M.MemberId = " + PacienteV.Text
        bdDataTable(sql, genInfo)
        NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
        ClassificationV.Text = chequearValor(genInfo.Rows(0)("Clasificacion")).ToString
        hPercent = chequearValor(genInfo.Rows(0)("HealthPercent")).ToString
        EdadV.Text = " - " + genInfo.Rows(0)("Edad")
        memTypeV.Text = tipo_Miembro(S, PacienteV.Text)

        GeneralTabControl.Visible = True

        normalPercentageV.Text = hPercent.ToString
        orPercentage = Convert.ToDouble(normalPercentageV.Text)
        normalPercentageV2.Text = normalPercentageV.Text + "%"

        'fill medList
        sql = "SELECT Code, CASE WHEN DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + '(' + DosageDesc_es+ ')') " + _
                         "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END " + _
                         "+ CASE WHEN  dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) IS NULL THEN '' ELSE ' #' + CAST(dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) AS Varchar(5))  END AS Medicine " + _
                        "FROM dbo.CdHealthInventoryItem WHERE Active = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, MedsCombo, "Code", "Medicine")

        sql = "SELECT Code, DescSpanish Tipo FROM dbo.CdPrescriptionType WHERE Active = 1 AND Code NOT IN ('CONS', 'DENT') "
        bdCombo(sql, TipoRecetaCombo, "Code", "Tipo")
        TipoRecetaCombo.Text = "Receta Externa"

        PacienteV.ReadOnly = True
        FamiliaV.ReadOnly = True
        historial()
        MedsCombo.Focus()
        GuardarButton.Visible = True
        GenInfoTable.Visible = True
    End Sub
End Class