' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ModificarConsultaMedica
    Public sMember, preTrans As String
    Public memberId, appid, consId As Integer

    Dim infoTable As New DataTable
    Dim hc As New HistorialConsulta
    Dim dr, exon, emergency, status, IdSM, IdTrans, IdLab, IdCitaLab, IdRefE, IdRecE As String
    Dim pago, AprobadoM, realiz, idCita, ResultadoLab, idrTS, IdrAE, Resultados, Entrega, IdTrat As String
    Dim turn As Integer
    Dim nDiasHistorial As Integer = 365
    Dim orTotal, hPercent, orPercentage As Double
    Dim needTurn As Boolean = False
    Dim exonera As Boolean = False
    Dim FechaTratPicker As DateTime

    Private Sub ModificarConsultaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        infoGen()
        PacienteV.Focus()
        limpiarExamenLab()
        limpiarMeds()
        limpiarSM()
        limpiarRefExt()
        limpiarTrats()
    End Sub

    Private Sub ModificarMedica_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        hc.Close()
    End Sub

    Private Sub actualizarCita()
        sql = "INSERT INTO dbo.MemberClinicAppointment " + _
              "SELECT AppId, GETDATE(), Project, MemberId, AppointmentDateTime, RecordStatus, UserId, ExpirationDateTime, HealthClinic, EmployeeId, " + _
                "ConsultationType, status, turn, AMorPM, '" + TempV.Text + "', '" + PesoV.Text + "', '" + TallaV.Text + "', '" + PresionV.Text + "', '" + fCardiacaV.Text + "', '" + fRespiratoriaV.Text + "', Notes, IdConsultationReference " + _
              "FROM dbo.MemberClinicAppointment " + _
              "WHERE RecordStatus = ' ' AND AppId = " + appid.ToString
        bdInsertar(sql)
    End Sub

    Private Sub AgregarRecetaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarRecetaButton.Click
        If Len(ExMedicineV.Text) = 0 Or Len(ExQuantityV.Text) = 0 Or Len(ExtIndicationsV.Text) = 0 Then
            MsgBox("Todos los campos con * necesitan información", vbInformation, My.Resources.versionFamilias2)
        Else
            If Len(IdRecE) = 0 Then
                Dim reExId As Integer = 0
                sql = "SELECT MAX( IdExternalPres) AS Ultimo FROM dbo.MemberClinicExternalPrescription "
                IdRecE = (bdEntero(sql, "Ultimo") + 1).ToString

                Dim fechaRE As String
                If RecetasExtGrid.RowCount > 0 Then
                    fechaRE = RecetasExtGrid.Item(1, 0).Value()
                Else
                    fechaRE = FechaConsulta.Text
                End If

                'SELECT IdExternalPres, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, IdProgram, Project, MemberId, PresDateTime, Medicine, Quantity  , 
                'Instruction, IdConsultation
                sql = "INSERT INTO dbo.MemberClinicExternalPrescription VALUES (" + IdRecE + ", GETDATE(), ' ', '" + U + "', NULL, 'CLIN', '" + sMember + _
                      "', " + memberId.ToString + ", '" + fechaRE.ToString(en.DateTimeFormat) + "', '" + Replace(ExMedicineV.Text, "'", "''") + "', '" + _
                      Replace(ExQuantityV.Text, "'", "''") + "', '" + Replace(ExtIndicationsV.Text, "'", "''") + "', " + consId.ToString + ")"
                bdInsertar(sql)

                IdRecE = ""
                ExMedicineV.Text = ""
                ExQuantityV.Text = ""
                ExtIndicationsV.Text = ""
                recetasExternas()

            Else
                sql = "INSERT INTO dbo.MemberClinicExternalPrescription " + _
                      "SELECT IdExternalPres, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, IdProgram, Project, MemberId, " + _
                      "PresDateTime, '" + Replace(ExMedicineV.Text, "'", "''") + "', '" + Replace(ExQuantityV.Text, "'", "''") + _
                      "', '" + Replace(ExtIndicationsV.Text, "'", "''") + "', IdConsultation " + _
                      "FROM dbo.MemberClinicExternalPrescription " + _
                      "WHERE RecordStatus = ' ' AND  IdExternalPres = " + IdRecE
                bdInsertar(sql)

                IdRecE = ""
                ExMedicineV.Text = ""
                ExQuantityV.Text = ""
                ExtIndicationsV.Text = ""
                recetasExternas()
            End If
        End If
    End Sub

    Private Sub AgregarRefButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarRefButton.Click
        If Len(ExternalPlaceV.Text) = 0 Or Len(ExternalReasonV.Text) = 0 Or Len(rpRefEV.Text) = 0 Then
            MsgBox("Todos los campos con * necesitan información", vbInformation, My.Resources.versionFamilias2)
        Else
            If Len(IdRefE) = 0 Then 'NUEVA
                Dim reRefEId As Integer = 0
                sql = "SELECT MAX( IdExternalRef) AS Ultimo FROM dbo.MemberClinicExternalReference "
                IdRefE = (bdEntero(sql, "Ultimo") + 1).ToString

                Dim fechaRE As String
                If ReferenciaExtGrid.RowCount > 0 Then
                    fechaRE = ReferenciaExtGrid.Item(1, 0).Value()
                Else
                    fechaRE = FechaConsulta.Text
                End If
                ' IdExternalRef, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, IdProgram, Project, MemberId, ReferenceDateTime, Place, Reason, Rp, IdConsultation

                sql = "INSERT INTO dbo.MemberClinicExternalReference VALUES (" + IdRefE + ", GETDATE(), ' ', '" + U + "', NULL, 'CLIN', '" + sMember + "', " + memberId.ToString + ", " + _
                      "'" + fechaRE.ToString(en.DateTimeFormat) + "', '" + ExternalPlaceV.SelectedValue + "', '" + ExternalReasonV.SelectedValue + "', '" + _
                      Replace(Replace(rpRefEV.Text, "'", "''"), Chr(10), vbNewLine) + "', " + consId.ToString + ") "
                bdInsertar(sql)
                limpiarRefExt()
                referenciasExternas()
            Else 'MODIFICA
                ' IdExternalRef, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, IdProgram, Project, MemberId, ReferenceDateTime, Place, Reason, Rp, IdConsultation
                sql = "INSERT INTO dbo.MemberClinicExternalReference " + _
                      "SELECT IdExternalRef, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, IdProgram, Project, MemberId, ReferenceDateTime, " + _
                      "'" + ExternalPlaceV.SelectedValue + "', '" + ExternalReasonV.SelectedValue + "', '" + Replace(Replace(rpRefEV.Text, "'", "''"), Chr(10), vbNewLine) + _
                      "', IdConsultation " + _
                      "FROM dbo.MemberClinicExternalReference " + _
                      "WHERE RecordStatus = ' ' AND  IdExternalRef = " + IdRefE + " "
                bdInsertar(sql)
                limpiarRefExt()
                referenciasExternas()
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BorrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarButton.Click
        If Len(IdRecE) > 0 Then
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            response = MsgBox("¿Esta seguro de borrar esta receta externa? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberClinicExternalPrescription SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                      "WHERE RecordStatus = ' ' AND  IdExternalPres = " + IdRecE
                bdEjecutarSQL(sql)

                IdRecE = ""
                ExMedicineV.Text = ""
                ExQuantityV.Text = ""
                ExtIndicationsV.Text = ""
                recetasExternas()
            End If
        End If
    End Sub

    Private Sub BorrarRefExtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarRefExtButton.Click
        If Len(IdRefE) > 0 Then
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            response = MsgBox("¿Esta seguro de borrar esta referencia externa? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberClinicExternalReference SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                      "WHERE RecordStatus = ' ' AND  IdExternalRef = " + IdRefE
                bdEjecutarSQL(sql)
                limpiarRefExt()
                referenciasExternas()
            End If
        End If
    End Sub

    Private Sub BorrarSMButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarSMButton.Click
        If Len(IdSM) > 0 Then
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            response = MsgBox("¿Esta seguro de borrar nota del sumario médico? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberMedicalSummaryHistory SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                      "WHERE RecordStatus = ' ' AND IdMedSum = " + IdSM + " AND  Project = '" + sMember + "' AND MemberId = " + memberId.ToString + " "
                bdEjecutarSQL(sql)
                limpiarSM()
                verSumario()
            End If
        End If
    End Sub

    Private Sub BorrarMedsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarMedsButton.Click
        If IdTrans = "0" Or Len(IdTrans) = 0 Then
        Else
            If Len(pago) > 1 And Double.Parse(AprobadoM) > 0 Then
                MsgBox("La medicina seleccionada ya tiene pago, no puede ser eliminada", vbInformation, My.Resources.versionFamilias2)
            Else
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                response = MsgBox("¿Esta seguro de borrar este medicamento? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    sql = "UPDATE  dbo.HealthInventoryTransactionMedi SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                          "WHERE RecordStatus = ' '  AND IdTransac = " + IdTrans
                    bdEjecutarSQL(sql)
                    medicinas()
                    'calculateTotalPrice()
                    limpiarMeds()

                    If ExoneracionCheck.Checked = True Then
                        exon = "1"
                    Else
                        exon = "0"
                    End If
                    'sql = "UPDATE MemberClinicConsultation SET TotalNormalPrice = " + PrecioNormalV.Text.ToString + ", ApprovedPrice = " + normalTotalV.Text.ToString + ", Exoneration =  " + exon.ToString + " " + _
                    sql = "UPDATE MemberClinicConsultation SET Exoneration =  " + exon.ToString + " " + _
                          "WHERE RecordStatus = ' ' AND  IdConsultation = " + consId.ToString
                    bdEjecutarSQL(sql)
                End If
            End If

        End If
    End Sub

    Private Sub BorrarTratButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarTratButton.Click
        If Len(IdTrat) = 0 Then
        Else
            If Len(realiz) > 1 Then
                MsgBox("El tratamiento seleccionado no puede ser eliminado, ya fue realizado", vbInformation, My.Resources.versionFamilias2)
                limpiarTrats()
            Else
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                response = MsgBox("¿Esta seguro de borrar este tratamiento de enfermería? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    sql = "UPDATE  dbo.MemberNursTreatment SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                          "WHERE RecordStatus = ' '  AND IdTreatment = " + IdTrat
                    bdEjecutarSQL(sql)
                    tratamientos()
                    limpiarTrats()
                End If
            End If
        End If
    End Sub

    Private Sub BorrarCitaLabButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarCitaLabButton.Click
        If ResultadoLab = "0" Then
            If ExamenesGrid.RowCount > 0 Then
                If tieneResultsLab() = 0 Then
                    Dim style As MsgBoxStyle
                    Dim response As MsgBoxResult
                    style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                    response = MsgBox("El paciente tiene " + ExamenesGrid.RowCount.ToString + " examenes ingresados. " + vbCr + "¿Esta seguro de borrar la cita al laboratorio?", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        IdCitaLab = ExamenesGrid.Item(0, 0).Value()
                        sql = "UPDATE  dbo.MemberHealthLabAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                              "WHERE RecordStatus = ' '  AND IdAppLab = " + IdCitaLab
                        bdEjecutarSQL(sql)

                        sql = "UPDATE  dbo.MemberHealthLabExam SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                              "WHERE RecordStatus = ' '  AND IdAppLab = " + IdCitaLab
                        bdEjecutarSQL(sql)
                        laboratorios()
                    End If
                Else
                End If
            End If
        End If
    End Sub

    Private Sub BorrarLabButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarLabButton.Click
        If ResultadoLab = "0" Then
            If IdLab = "0" Then
                If ExamenesGrid.RowCount > 0 Then
                    MsgBox("Necesita seleccionar el laboratorio a borrar", vbInformation, My.Resources.versionFamilias2)
                End If
            Else
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                response = MsgBox("¿Esta seguro de borrar este laboratorio? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    sql = "UPDATE  dbo.MemberHealthLabExam SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                          "WHERE RecordStatus = ' '  AND Examen_ID = " + IdLab
                    bdEjecutarSQL(sql)

                    If ExamenesGrid.RowCount = 1 Then
                        sql = "UPDATE  dbo.MemberHealthLabAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                              "WHERE RecordStatus = ' '  AND IdAppLab = " + IdCitaLab
                    End If
                    bdEjecutarSQL(sql)
                    limpiarExamenLab()
                    laboratorios()
                End If
            End If
        Else

        End If
    End Sub

    Private Sub BorrarRefTSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarRefTSButton.Click
        If idrTS = "0" Then
        Else
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            response = MsgBox("¿Esta seguro de borrar la referencia a TS?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberInternalReference SET RecordStatus = 'H', ExpirationDatetime = GETDATE() " + _
                      "WHERE RecordStatus = ' ' AND IdInternalRef = " + idrTS
                bdEjecutarSQL(sql)
                CategoriaTSCombo.SelectedIndex = -1
                DescRefTS.Text = ""
                BorrarRefTSButton.Visible = False
                idrTS = "0"
            End If
        End If
    End Sub

    Private Sub BorrarRefAEButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarRefAEButton.Click
        If IdrAE = "0" Then
        Else
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            response = MsgBox("¿Esta seguro de borrar la referencia a Psicología (AE)?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberInternalReference SET RecordStatus = 'H', ExpirationDatetime = GETDATE() " + _
                      "WHERE RecordStatus = ' ' AND IdInternalRef = " + IdrAE
                bdEjecutarSQL(sql)
                CategoriaPsicCombo.SelectedIndex = -1
                DescRefPsic.Text = ""
                BorrarRefAEButton.Visible = False
                IdrAE = "0"
            End If
        End If
    End Sub

    Private Sub CancelarRefExtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarRefExtButton.Click
        limpiarRefExt()
    End Sub

    Private Sub CancelarSMButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarSMButton.Click
        limpiarSM()
    End Sub

    Private Sub CantidadTratV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadTratV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub consultaInfo()
        infoTable.Clear()
        ProblemaV.Text = ""
        dSubjetivosV.Text = ""
        dObjetivosV.Text = ""
        NuevosDatosV.Text = ""
        OtrosV.Text = ""
        PlanV.Text = ""

        sql = "SELECT PrimaryDiagnosis, SecondaryDiagnosis1, SecondaryDiagnosis2, ProblemData, SubjetiveData, ObjetiveData, NewData, Others, EducationalPlan, " + _
              "TotalNormalPrice, ApprovedPrice, Exoneration, Convert(nvarchar(30), ConsultationDateTime, 21) fecha " + _
              "FROM dbo.MemberClinicConsultation " + _
              "WHERE RecordStatus = ' ' AND  IdConsultation = " + consId.ToString
        bdDataTable(sql, infoTable)

        ProblemaV.Text = Replace(chequearValor(infoTable.Rows(0)("ProblemData")).ToString, Chr(10), vbNewLine)
        dSubjetivosV.Text = Replace(chequearValor(infoTable.Rows(0)("SubjetiveData")).ToString, Chr(10), vbNewLine)
        dObjetivosV.Text = Replace(chequearValor(infoTable.Rows(0)("ObjetiveData")).ToString, Chr(10), vbNewLine)
        NuevosDatosV.Text = Replace(chequearValor(infoTable.Rows(0)("NewData")).ToString, Chr(10), vbNewLine)
        OtrosV.Text = Replace(chequearValor(infoTable.Rows(0)("Others")).ToString, Chr(10), vbNewLine)
        PlanV.Text = Replace(chequearValor(infoTable.Rows(0)("EducationalPlan")).ToString, Chr(10), vbNewLine)

        Diagnostico1V.SelectedValue = chequearValor(infoTable.Rows(0)("PrimaryDiagnosis")).ToString
        Diagnostico2V.SelectedValue = chequearValor(infoTable.Rows(0)("SecondaryDiagnosis1")).ToString
        Diagnostico3V.SelectedValue = chequearValor(infoTable.Rows(0)("SecondaryDiagnosis2")).ToString
        PrecioNormalV.Text = chequearValor(infoTable.Rows(0)("TotalNormalPrice")).ToString
        normalTotalV.Text = chequearValor(infoTable.Rows(0)("ApprovedPrice")).ToString

        FechaConsulta.Text = chequearValor(infoTable.Rows(0)("fecha")).ToString
        exonera = infoTable.Rows(0)("Exoneration")

        If exonera = True Then
            ExoneracionCheck.Checked = True
        Else
            ExoneracionCheck.Checked = False
        End If

        If Double.Parse(normalTotalV.Text) > 0 And ExoneracionCheck.Checked = False And sMember <> "E" Then
            ExonerarButton.Visible = True
        Else
            ExonerarButton.Visible = False
        End If

        ExoneracionCheck.Enabled = False
    End Sub

    Private Sub CancelarMedsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarMedsButton.Click
        limpiarMeds()
    End Sub

    Private Sub calculateTotalPrice()
        Dim normalPrice, totalPrice As Double
        If MedsGrid.RowCount = 0 Then
            normalTotalV.Text = "0.00"
            PrecioNormalV.Text = "0.00"
        Else
            normalPrice = sumarPrecios(7)
            totalPrice = sumarPrecios(8)
            PrecioNormalV.Text = normalPrice.ToString("F", CultureInfo.InvariantCulture) 'normal Price
            normalTotalV.Text = totalPrice.ToString("F", CultureInfo.InvariantCulture)
        End If

        If sMember = "F" Or sMember = "S" Then
            If normalTotalV.Text = "0.00" Or normalTotalV.Text = "0" Then ' Or Double.Parse(normalPercentageV.Text) = 0 Then
                ExoneracionCheck.Visible = False
                ExoneracionCheck.Checked = False
            Else
                ExoneracionCheck.Visible = True
            End If
        Else
            ExoneracionCheck.Visible = False
        End If
        MsGPay()
    End Sub

    Private Function checkingAvailableTurns() As Boolean
        turn = 0
        emergency = "0"
        Dim intervalo As TimeSpan = DateReferencePicker.Value - DateTime.Now
        If intervalo.Days < 0 Then
            MsgBox("La fecha no puede ser menor a la actual", vbInformation, My.Resources.versionFamilias2)
            checkingAvailableTurns = False
        Else
            If DateReferencePicker.Value.Year = Now.Year And DateReferencePicker.Value.Month = Now.Month And DateReferencePicker.Value.Day = Now.Day Then 'si es en el mismo día, envia mensaje de confirmación And Now.Hour > 8
                Dim msg As String = "¿Esta seguro de ingresar referencia al laboratorio hoy?"
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox(msg, style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    checkingAvailableTurns = True
                    needTurn = True
                    turn = turnoLab(DateReferencePicker.Value).ToString
                    status = "COMP"
                    emergency = "1"
                Else
                    checkingAvailableTurns = False
                    needTurn = False
                End If
            Else
                needTurn = False
                Dim nDates, nTurns As Integer
                Dim nTurnsSQL As String
                sql = "SELECT dbo.fn_HEAL_LABO_Pacientes('" + DateReferencePicker.Value.ToString(en.DateTimeFormat) + "') Pacientes "
                nDates = bdEntero(sql, "Pacientes")
                nTurnsSQL = "SELECT PropertyValue FROM FwApplicationProperty " + _
                            "WHERE Category = 'LABO' AND Organization = 'F' AND Name = 'TurnsByDay'"
                nTurns = bdEntero(nTurnsSQL, "PropertyValue")

                If nDates < nTurns Then
                    checkingAvailableTurns = True
                    status = "REFE"
                Else
                    checkingAvailableTurns = False
                    MsgBox("No hay espacio suficiente para el día " + DateReferencePicker.Value.ToLongDateString, vbInformation, My.Resources.versionFamilias2)
                End If
            End If
        End If
    End Function

    Private Function esConsultaValida() As Boolean
        If (Diagnostico1V.Text = "" Or IsDBNull(Diagnostico1V.Text)) And Diagnostico1V.SelectedIndex = -1 Then
            MsgBox("Necesita indicar el diagnostico principal", vbInformation, My.Resources.versionFamilias2)
            esConsultaValida = False
        ElseIf ProblemaV.Text = "" Or IsDBNull(ProblemaV.Text) Then
            MsgBox("Necesita ingresar información en problema", vbInformation, My.Resources.versionFamilias2)
            esConsultaValida = False
        ElseIf Mid(Diagnostico1V.Text, 3) = "00" Then
            MsgBox("Ha seleccionado una categoria en el diagnostico 1", vbInformation, My.Resources.versionFamilias2)
            esConsultaValida = False
        ElseIf Len(Diagnostico2V.Text) > 0 And Mid(Diagnostico2V.Text, 3) = "00" Then
            MsgBox("Ha seleccionado una categoria en el diagnostico 2", vbInformation, My.Resources.versionFamilias2)
            esConsultaValida = False
        ElseIf Len(Diagnostico3V.Text) > 0 And Mid(Diagnostico3V.Text, 3) = "00" Then
            MsgBox("Ha seleccionado una categoria en el diagnostico 3", vbInformation, My.Resources.versionFamilias2)
            esConsultaValida = False
        Else
            esConsultaValida = True
        End If
    End Function

    'Private Sub EvolGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EvolGrid.CellContentClick
    '    Dim f As Integer = EvolGrid.CurrentCellAddress.Y
    '    RevisarEvolL.Text = "Consulta seleccionada: " + fn.chequearValor(EvolGrid.Item(0, f).Value())
    '    rProblemaV.Text = fn.chequearValor(EvolGrid.Item(2, f).Value())
    '    rDsubjetivosV.Text = fn.chequearValor(EvolGrid.Item(3, f).Value())
    '    rDobjetivosV.Text = fn.chequearValor(EvolGrid.Item(4, f).Value())
    '    rNdatosV.Text = fn.chequearValor(EvolGrid.Item(5, f).Value())
    '    rOtrosV.Text = fn.chequearValor(EvolGrid.Item(6, f).Value())
    'End Sub

    Private Sub ExamenesGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ExamenesGrid.CellContentClick
        Dim f As Integer
        f = ExamenesGrid.CurrentCellAddress.Y
        limpiarExamenLab()

        IdCitaLab = ExamenesGrid.Item(0, f).Value()
        IdLab = ExamenesGrid.Item(1, f).Value()
        ResultadoLab = ExamenesGrid.Item(2, f).Value()
        DateReferencePicker.Value = ExamenesGrid.Item(3, f).Value()
        ExamenesCombo.Text = ExamenesGrid.Item(5, f).Value()
        NotesV.Text = chequearValor(ExamenesGrid.Item(6, f).Value())

        DateReferencePicker.Enabled = False

        If ResultadoLab = "0" Then
            ExamenesCombo.Enabled = True
            NotesV.Enabled = True
            Resultados = ""
        Else
            ExamenesCombo.Enabled = False
            NotesV.Enabled = False
            Resultados = "Ya tiene resultados"
        End If
    End Sub

    Private Function esCitaLabValida() As Boolean
        sql = "SELECT COUNT(*) Total FROM dbo.fn_HEAL_citasLab() WHERE Fecha = CONVERT(varchar, '" + DateReferencePicker.Value.ToString(en.DateTimeFormat) + "', 111) AND MemberId = " + PacienteV.Text
        Dim existeEnAgenda As Integer = bdPalabra(sql, "Total")

        If turnosLabDisponibles() = True Then
            If existeEnAgenda = 0 Then
                esCitaLabValida = True
            Else
                MsgBox("Ya existe una cita de laboratorio para este paciente en la fecha seleccionada", vbInformation, My.Resources.versionFamilias2)
                esCitaLabValida = False
            End If
        Else
            esCitaLabValida = False
        End If
    End Function

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

    Private Function existeEnListado(ByVal newCod As String,
                             ByVal listGrid As DataGridView,
                             ByVal col As Integer) As Boolean
        If newCod = "OTRA" Then
            existeEnListado = False
        Else
            Dim n As Integer = listGrid.Rows.Count - 1
            Dim exist As Integer = 0
            For f = 0 To n
                listGrid.Item(0, f).Value = f
                If listGrid.Item(col, f).Value = newCod Then
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

    Private Sub ExonerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExonerarButton.Click
        sql = "UPDATE dbo.MemberClinicConsultation SET Exoneration = 1, UserId = '" + U + "' " + _
              "WHERE IdConsultation = " + consId.ToString + " AND RecordStatus = ' ' "
        bdEjecutarSQL(sql)

        sql = "UPDATE dbo.HealthInventoryTransactionMedi SET Exoneration = 1, UserId = '" + U + "' " + _
              "WHERE IdConsultation = " + consId.ToString + " AND RecordStatus = ' ' "
        bdEjecutarSQL(sql)
        consultaInfo()
        MsgBox("La exoneración ha sido guardada correctamente", vbInformation, My.Resources.versionFamilias2)

        medicinas()
    End Sub

    Private Sub fCardiacaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fRespiratoriaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardaEvolucionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardaEvolucionButton.Click
        If esConsultaValida() = True Then
            Dim d2, d3 As String
            If Len(Diagnostico2V.Text) = 0 Then
                d2 = "NULL"
            Else
                d2 = "'" + Diagnostico2V.SelectedValue.ToString + "'"
            End If

            If Len(Diagnostico3V.Text) = 0 Then
                d3 = "NULL"
            Else
                d3 = "'" + Diagnostico3V.SelectedValue.ToString + "'"
            End If

            ' IdConsultation, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, ConsultationDateTime, PrimaryDiagnosis, SecondaryDiagnosis1, 
            'SecondaryDiagnosis2, ProblemData, SubjetiveData, ObjetiveData, NewData, Others, EducationalPlan, TotalNormalPrice, ApprovedPrice, Exoneration,
            'ApprovedBy, PayDateTime, Cashier, AppId
            sql = "INSERT INTO dbo.MemberClinicConsultation " + _
                  "SELECT IdConsultation, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, ConsultationDateTime, '" + Diagnostico1V.SelectedValue.ToString + "', " + d2 + ", " + _
                  d3 + ", '" + Replace(Replace(ProblemaV.Text, "'", "''"), Chr(10), vbNewLine) + "', '" + Replace(Replace(dSubjetivosV.Text, "'", "''"), Chr(10), vbNewLine) + "','" + Replace(Replace(dObjetivosV.Text, "'", "''"), Chr(10), vbNewLine) + "','" + _
                  Replace(Replace(NuevosDatosV.Text, "'", "''"), Chr(10), vbNewLine) + "', '" + Replace(Replace(OtrosV.Text, "'", "''"), Chr(10), vbNewLine) + "', EducationalPlan, TotalNormalPrice, ApprovedPrice, Exoneration, " + _
                  "ApprovedBy, PayDateTime, Cashier, AppId " + _
                  "FROM dbo.MemberClinicConsultation " + _
                  "WHERE RecordStatus = ' '  AND IdConsultation = " + consId.ToString
            bdInsertar(sql)
            actualizarCita()
            consultaInfo()
            MsgBox("Los cambios se han guardado correctamente", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub GuardarMedsBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarMedsBoton.Click
        If Entrega = "" Or Len(Entrega) = 0 Or Entrega = "_" Then
            If IdTrans = "0" Or Len(IdTrans) = 0 Then
                nuevaMed()
            Else
                If suficienteExistencia(MedsCombo.SelectedValue, CantidadV.Text, MedsCombo.Text) = True Then 'check actually quantity
                    modificaMed()
                End If
            End If
        Else
        End If
    End Sub

    Private Sub guardarRefTSButton_Click(sender As Object, e As EventArgs) Handles guardarRefTSButton.Click
        If Len(CategoriaTSCombo.Text) > 0 Then
            If idrTS = "0" Then
                'nueva ref
                idrTS = (bdEntero("SELECT MAX(IdInternalRef) ID FROM dbo.MemberInternalReference ", "ID") + 1).ToString
                sql = "INSERT INTO  dbo.MemberInternalReference VALUES(" + idrTS + ", GETDATE(), ' ', '" + sMember + "', " + memberId.ToString + ", 'TS', '" + _
                      CategoriaTSCombo.SelectedValue + "', GETDATE(), '" + U + "', NULL, 'REFE', GETDATE(), '" + dr + "', '" + Replace(Replace(DescRefTS.Text, "'", "''"), Chr(10), vbNewLine) + "', NULL, " + consId.ToString + " )"
                bdInsertar(sql)
            Else
                sql = "INSERT INTO  dbo.MemberInternalReference " + _
                      "SELECT IdInternalRef, GETDATE(), RecordStatus, Project, MemberId, Program, '" + CategoriaTSCombo.SelectedValue + "', ReferenceDateTime, '" + U + "', ExpirationDateTime, " + _
                      "Status, StatusDate, ReferredBy, '" + Replace(Replace(DescRefTS.Text, "'", "''"), Chr(10), vbNewLine) + "', Observations, IdConsultation " + _
                      "FROM dbo.MemberInternalReference " + _
                      "WHERE RecordStatus = ' ' AND IdInternalRef = " + idrTS
                bdInsertar(sql)
            End If
            MsgBox("La actualización ha sido guardada correctamente", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub guardarRefAEButton_Click(sender As Object, e As EventArgs) Handles guardarRefAEButton.Click
        If Len(CategoriaPsicCombo.Text) > 0 Then
            If IdrAE = "0" Then
                'nueva ref
                Dim idrAE As Integer = bdEntero("SELECT MAX(IdInternalRef) ID FROM dbo.MemberInternalReference ", "ID") + 1
                sql = "INSERT INTO  dbo.MemberInternalReference VALUES(" + idrAE.ToString + ", GETDATE(), ' ', '" + sMember + "', " + memberId.ToString + ", 'PSIC', '" + _
                      CategoriaPsicCombo.SelectedValue + "', GETDATE(), '" + U + "', NULL, 'REFE', GETDATE(), '" + dr + "', '" + Replace(Replace(DescRefPsic.Text, "'", "''"), Chr(10), vbNewLine) + "', NULL, " + consId.ToString + " )"
                bdInsertar(sql)

            Else
                sql = "INSERT INTO  dbo.MemberInternalReference " + _
                      "SELECT IdInternalRef, GETDATE(), RecordStatus, Project, MemberId, Program, '" + CategoriaPsicCombo.SelectedValue + "', ReferenceDateTime, '" + U + "', ExpirationDateTime, " + _
                      "Status, StatusDate, ReferredBy, '" + Replace(Replace(DescRefPsic.Text, "'", "''"), Chr(10), vbNewLine) + "', Observations, IdConsultation " + _
                      "FROM dbo.MemberInternalReference " + _
                      "WHERE RecordStatus = ' ' AND IdInternalRef = " + IdrAE
                bdInsertar(sql)
            End If
            MsgBox("La actualización ha sido guardada correctamente", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub GuardarTratButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarTratButton.Click
        Dim cant As String
        If Len(IdTrat) = 0 Then
            If Len(TratamientosCombo.Text) = 0 And Len(ObserTratV.Text) = 0 Then
                MsgBox("Necesita llenar los campos con * para un nuevo tratamiento", vbInformation, My.Resources.versionFamilias2)
            Else
                Dim idTra As Integer = bdEntero("SELECT MAX(IdTreatment) ID FROM dbo.MemberNursTreatment ", "ID") + 1

                If Len(CantidadTratV.Text) = 0 Then
                    cant = "NULL"
                Else
                    cant = CantidadTratV.Text
                End If
                'IdTreatment, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Project, MemberId, Physician, RefDateTime, Treatment, Quantity, 
                'Instruction, IdConsultation, TreatDateTime, TreatBy, Observations
                sql = "INSERT INTO dbo.MemberNursTreatment VALUES(" + idTra.ToString + ", GETDATE(), ' ', '" + U + "', NULL, '" + sMember + "', " + memberId.ToString + _
                      ", '" + dr + "', '" + DateTime.Parse(FechaConsulta.Text).ToString(en.DateTimeFormat) + "', '" + TratamientosCombo.SelectedValue + "', " + cant + _
                      ", '" + Replace(ObserTratV.Text, "'", "''") + "', " + consId.ToString + ", NULL, NULL, NULL)"
                bdInsertar(sql)
                tratamientos()
                limpiarTrats()
            End If
        Else
            If Len(realiz) > 1 Then
            Else
                If Len(CantidadTratV.Text) = 0 Then
                    cant = "NULL"
                Else
                    cant = CantidadTratV.Text
                End If

                sql = "INSERT INTO dbo.MemberNursTreatment " + _
                      "SELECT IdTreatment, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, MemberId, Physician, RefDateTime, Treatment, " + cant + ", " + _
                      "'" + Replace(ObserTratV.Text, "'", "''") + "', IdConsultation, TreatDateTime, TreatBy, Observations " + _
                      "FROM dbo.MemberNursTreatment " + _
                      "WHERE RecordStatus = ' '  AND IdTreatment = " + IdTrat
                bdInsertar(sql)
                tratamientos()
                limpiarTrats()
            End If
        End If
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

    Private Sub infoGen()
        infoTable.Clear()
        sql = "SELECT  MCA.Temperature, MCA.Weight, MCA.Stature, MCA.BloodPressure, MCA.HeartRate, MCA.RespiratoryRate " + _
              "FROM dbo.MemberClinicAppointment MCA " + _
              "WHERE MCA.RecordStatus = ' ' AND MCA.AppId = " + appid.ToString
        bdDataTable(sql, infoTable)
        TempV.Text = chequearValor(infoTable.Rows(0)("Temperature")).ToString
        PesoV.Text = chequearValor(infoTable.Rows(0)("Weight")).ToString
        TallaV.Text = chequearValor(infoTable.Rows(0)("Stature")).ToString
        PresionV.Text = chequearValor(infoTable.Rows(0)("BloodPressure")).ToString
        fCardiacaV.Text = chequearValor(infoTable.Rows(0)("HeartRate")).ToString
        fRespiratoriaV.Text = chequearValor(infoTable.Rows(0)("RespiratoryRate")).ToString

        hPercent = porcentajeSalud(sMember, PacienteV.Text)
        ClassificationV.Text = chequearValor(clasificacionFamiliar(sMember, FamiliaV.Text))
        memTypeV.Text = tipo_Miembro(sMember, PacienteV.Text)

        normalPercentageV.Text = hPercent.ToString
        orPercentage = Convert.ToDouble(normalPercentageV.Text)
        normalPercentageV2.Text = normalPercentageV.Text + "%"

        IMCL.Text = calcularIMC(PesoV.Text, TallaV.Text)

        dr = DrL.Text
        DrL.Text = "Médico:  " + dr

        '--lista diagnosticos
        sql = "SELECT Code, CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish Diag FROM dbo.CdDiagnosis WHERE Active = 1 AND FunctionalArea = 'CLIN' "
        bdCombo(sql, Diagnostico1V, "Code", "Diag")
        bdCombo(sql, Diagnostico2V, "Code", "Diag")
        bdCombo(sql, Diagnostico3V, "Code", "Diag")

        '--lista referencias internas
        sql = "SELECT Code, DescSpanish 'Categoria' FROM CdInternalReferenceCategory WHERE Active = 1 AND Project = '" + S + "' AND Program = 'MEDI' "
        bdCombo(sql, CategoriaTSCombo, "Code", "Categoria")
        bdCombo(sql, CategoriaPsicCombo, "Code", "Categoria")

        'fill externalReferences
        sql = "SELECT Code, DescSpanish Place " + _
                         "FROM dbo.CdHealthExternalReferencePlace " + _
                         "WHERE Active = 1 AND Project IN('F', '*') AND Program = 'MEDI'"
        bdCombo(sql, ExternalPlaceV, "Code", "Place")

        sql = "SELECT Code, DescSpanish Razon " + _
                                  "FROM dbo.CdHealthExternalReferenceReason " + _
                                  "WHERE Active = 1 AND Program IN('MEDI', '****') "
        bdCombo(sql, ExternalReasonV, "Code", "Razon")

        'fill summary category
        sql = "SELECT Code, CASE WHEN RequiredQuantity = 1 THEN DescSpanish + ' (+)' ELSE DescSpanish END  Type FROM dbo.CdMedicalSummaryType WHERE Active = 1  ORDER BY DescSpanish"
        bdCombo(sql, sTipoCombo, "Code", "Type")

        'para medList
        '"+ CASE WHEN  dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) IS NULL THEN '' ELSE ' #' + CAST(dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) AS Varchar(5))  END AS Medicine " + _
        sql = "SELECT Code, CASE WHEN DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + '(' + DosageDesc_es + ')') " + _
                 "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END AS Medicine  " + _
                "FROM dbo.CdHealthInventoryItem WHERE Active = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, MedsCombo, "Code", "Medicine")

        'fill tratamientos
        sql = "SELECT Code, DescSpanish Treat FROM dbo.CdHealthTreatment WHERE FunctionalArea = 'CLIN' AND Active = 1 ORDER BY DescSpanish "
        bdCombo(sql, TratamientosCombo, "Code", "Treat")

        'fill LabReferences
        sql = "SELECT Examen_Tipo_ID Code, DescSpanish Lab FROM dbo.CdLabExamen_Type WHERE Active = 1 ORDER BY DescSpanish"
        bdCombo(sql, ExamenesCombo, "Code", "Lab")

        consultaInfo()
        referenciasAE()
        referenciasTS()
        recetasExternas()
        referenciasExternas()
        verSumario()
        medicinas()
        tratamientos()
        laboratorios()
        MsGPay()
        ConsultaTab.Visible = True

        ConsultaTab.BackColor = Color.White
        ProblemaV.Focus()
    End Sub

    Private Sub laboratorios()
        sql = "SELECT MHLA.IdAppLab, MHLE.Examen_ID, (SELECT COUNT(*) N FROM dbo.MemberHealthLabResult MHLR " + _
              " WHERE RecordStatus = ' ' AND MHLR.Examen_ID = MHLE.Examen_ID) AS Resultados, CONVERT(nvarchar(30), MHLA.ReferenceDate, 21) F, dbo.fn_GEN_FormatDate (MHLA.ReferenceDate, 'ES') Fecha, cdLET.DescSpanish AS Laboratorio, MHLE.Notes AS Notas " + _
              "FROM dbo.MemberHealthLabExam MHLE INNER JOIN dbo.MemberHealthLabAppointment MHLA ON MHLE.IdAppLab = MHLA.IdAppLab AND MHLE.RecordStatus = MHLA.RecordStatus " + _
              "INNER JOIN dbo.CdLabExamen_Type cdLET ON MHLE.Examen_Tipo_ID = cdLET.Examen_Tipo_ID " + _
              "WHERE MHLE.RecordStatus = ' ' AND MHLA.IdConsultation = " + consId.ToString
        bdGrid(sql, ExamenesGrid)

        ExamenesGrid.Columns.Item(0).Visible = False 'IDCita
        ExamenesGrid.Columns.Item(1).Visible = False 'IDLab
        ExamenesGrid.Columns.Item(2).Visible = False 'Resultados
        ExamenesGrid.Columns.Item(3).Visible = False 'fecha

        If ExamenesGrid.RowCount > 0 Then
            DateReferencePicker.Value = DateTime.Parse(ExamenesGrid.Item(3, 0).Value())
        Else
            DateReferencePicker.Value = Now
        End If

    End Sub

    Private Sub limpiarExamenLab()
        ExamenesCombo.SelectedIndex = -1
        NotesV.Text = ""
        IdCitaLab = "0"
        IdLab = "0"
        ResultadoLab = "0"
        Resultados = ""

        If ExamenesGrid.RowCount > 0 Then
            DateReferencePicker.Value = DateTime.Parse(ExamenesGrid.Item(3, 0).Value())
        Else
            DateReferencePicker.Value = Now
        End If
        DateReferencePicker.Enabled = True
    End Sub

    Private Sub LimpiarLabsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarLabsButton.Click
        limpiarExamenLab()
    End Sub

    Private Sub limpiarMeds()
        IdTrans = ""
        MedsCombo.SelectedValue = -1
        CantidadV.Text = ""
        InstrucV.Text = ""
        ObservacionesV.Text = ""
        Entrega = ""
        AprobadoM = ""
        qUnitL.Text = ""
        pago = ""

        MedsCombo.Enabled = True
        CantidadV.Enabled = True
        InstrucV.Enabled = True
        ObservacionesV.Enabled = True
        GuardarMedsBoton.Enabled = True
        BorrarMedsButton.Enabled = True

        MedsCombo.Focus()
    End Sub

    Private Sub limpiarSM()
        IdSM = "0"
        sTipoCombo.SelectedIndex = -1
        sFechaDateTimePicker.Value = Today
        sObservacionesV.Text = ""
    End Sub

    Private Sub LimpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarButton.Click
        IdRecE = ""
        ExMedicineV.Text = ""
        ExQuantityV.Text = ""
        ExtIndicationsV.Text = ""
    End Sub

    Private Sub limpiarRefExt()
        IDRefE = ""
        ExternalPlaceV.SelectedIndex = -1
        ExternalReasonV.SelectedIndex = -1
        rpRefEV.Text = ""
    End Sub

    Private Sub limpiarTrats()
        TratamientosCombo.SelectedIndex = -1
        ObserTratV.Text = ""
        CantidadTratV.Text = ""
        FechaTratPicker = Now
        IdTrat = ""
        realiz = ""

        TratamientosCombo.Enabled = True
        ObserTratV.Enabled = True
        CantidadTratV.Enabled = True
    End Sub

    Private Sub LimpiarTratButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarTratButton.Click
        limpiarTrats()
    End Sub

    Private Sub medicinas()
        'UnitPrice 'Precio U.', ((UnitPrice * Quantity) * - 1) Total, ApprovedTotalPrice Aprobado,
        'dbo.fn_GEN_FormatDate(HITM.PayDateTime, 'ES') Pago,
        sql = "SELECT IdTransac, Code, CASE WHEN DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + ' (' + DosageDesc_es + ')') " + _
              "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END AS Medicina, Quantity * - 1 Cantidad, HITM.Indications Indicaciones, " + _
              "HITM.Notes Observaciones,  " + _
              "dbo.fn_GEN_FormatDate(HITM.PrescriptionDateTime, 'ES') AS Prescripción,  " + _
              "dbo.fn_GEN_FormatDate(HITM.DeliveryDateTime, 'ES') AS Entrega " + _
              "FROM  dbo.HealthInventoryTransactionMedi HITM INNER JOIN dbo.CdHealthInventoryItem cdI ON HITM.Item = cdI.Code " + _
              "WHERE HITM.RecordStatus = ' ' AND Quantity < 0 AND HITM.IdConsultation = " + consId.ToString
        bdGrid(sql, MedsGrid)
        MedsGrid.Columns.Item(0).Visible = False 'ID
        MedsGrid.Columns.Item(1).Visible = False 'codMed
    End Sub

    Private Sub MedsGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MedsGrid.CellContentClick
        Dim f As Integer
        f = MedsGrid.CurrentCellAddress.Y
        limpiarMeds()

        IdTrans = MedsGrid.Item(0, f).Value()
        MedsCombo.SelectedValue = MedsGrid.Item(1, f).Value()
        CantidadV.Text = MedsGrid.Item(3, f).Value()
        InstrucV.Text = MedsGrid.Item(4, f).Value()
        ObservacionesV.Text = chequearValor(MedsGrid.Item(5, f).Value())
        Entrega = chequearValor(MedsGrid.Item(7, f).Value().ToString) ' 11

        pago = "" 'chequearValor(MedsGrid.Item(10, f).Value())
        AprobadoM = 0 'MedsGrid.Item(8, f).Value()
        qUnitL.Text = MedsGrid.Item(6, f).Value()

        MedsCombo.Enabled = False
        CantidadV.Enabled = False
        InstrucV.Enabled = False
        ObservacionesV.Enabled = False
        GuardarMedsBoton.Enabled = False
        BorrarMedsButton.Enabled = False

        If Len(Entrega) = 0 Then
            If Double.Parse(AprobadoM) = 0 Then
                CantidadV.Enabled = True
                InstrucV.Enabled = True
                ObservacionesV.Enabled = True
                GuardarMedsBoton.Enabled = True
                BorrarMedsButton.Enabled = True
            Else
                If Len(pago) = 0 Then
                    CantidadV.Enabled = True
                Else
                    CantidadV.Enabled = False
                End If
                InstrucV.Enabled = True
                ObservacionesV.Enabled = True
                GuardarMedsBoton.Enabled = True
                BorrarMedsButton.Enabled = True
            End If
        End If
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
                MSGv.Text = "El total de medicamentos es: Q. " + normalTotalV.Text
            End If
        End If
        'MSGv.Visible = True
    End Sub

    Private Sub modificaMed()
        'Dim total As Double = (Integer.Parse(CantidadV.Text) * Double.Parse(qUnitL.Text)) * (Double.Parse(normalPercentageV.Text) / 100)

        If ExoneracionCheck.Checked = True Then ' And total > 0 Then
            exon = "1"
        Else
            exon = "0"
        End If

        Dim cant As Integer = Integer.Parse(CantidadV.Text)

        If cant > 0 Then
            cant = cant * -1
        End If

        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi " + _
              "SELECT IdTransac, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, " + cant.ToString + ", FunctionalArea, " + _
              "MemberProject, memberId, UnitPrice, ApprovedTotalPrice, '" + Replace(InstrucV.Text, "'", "''") + "', '" + Replace(ObservacionesV.Text, "'", "''") + "', IdConsultation, PayDateTime, DeliveryDateTime, DeliveredBy, ByCredit, " + _
              exon.ToString + ", TypePres " + _
              "FROM dbo.HealthInventoryTransactionMedi " + _
              "WHERE RecordStatus = ' '  AND IdTransac = " + IdTrans
        bdInsertar(sql)

        medicinas()
        'calculateTotalPrice()
        limpiarMeds()

        'sql = "UPDATE MemberClinicConsultation SET TotalNormalPrice = " + PrecioNormalV.Text.ToString + ", ApprovedPrice = " + normalTotalV.Text.ToString + " " + _
        '      "WHERE RecordStatus = ' ' AND  IdConsultation = " + consId.ToString
        'bdEjecutarSQL(sql)
    End Sub

    Private Sub GuardarLabButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarLabButton.Click
        If esCitaLabValida() = True Then
            If IdLab = "0" Then
                If Len(ExamenesCombo.Text) > 0 Then
                    Dim idEx As Integer = bdEntero("SELECT MAX(Examen_ID) ID FROM dbo.MemberHealthLabExam ", "ID") + 1
                    If ExamenesGrid.RowCount = 0 Then
                        'If checkingAvailableTurns() = True Then
                        'necesita cita al lab
                        IdCitaLab = (bdEntero("SELECT Max(IdAppLab) ID FROM dbo.MemberHealthLabAppointment ", "ID") + 1).ToString
                        'IdAppLab, CreationDateTime, Project, MemberId, UserId, ExpirationDateTime, ReferenceDate, IdConsultation, StatusApp, Turn, DrReferred, PendPay, RecordStatus, TotalNormalPrice, Emergency
                        sql = "INSERT INTO dbo.MemberHealthLabAppointment VALUES(" + IdCitaLab + ", GETDATE(), '" + sMember + "', " + memberId.ToString + ", '" + _
                              U + "', NULL, '" + DateReferencePicker.Value.ToString(en.DateTimeFormat) + "', " + consId.ToString + ", '" + status + "', " + turn.ToString + ", '" + dr + _
                              "', 0, ' ', 0,  " + emergency + ")"
                        bdInsertar(sql)

                        ' Examen_ID, Examen_Tipo_ID, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, IdAppLab
                        sql = "INSERT INTO dbo.MemberHealthLabExam VALUES(" + idEx.ToString + ", " + ExamenesCombo.SelectedValue.ToString + ", '" + _
                            DateReferencePicker.Value.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, '" + Replace(NotesV.Text, "'", "''") + "', " + IdCitaLab.ToString + ") "
                        bdInsertar(sql)
                        limpiarExamenLab()
                        laboratorios()
                        'End If
                    Else
                        IdCitaLab = ExamenesGrid.Item(0, 0).Value()
                        ' Examen_ID, Examen_Tipo_ID, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, IdAppLab
                        sql = "INSERT INTO dbo.MemberHealthLabExam VALUES(" + idEx.ToString + ", " + ExamenesCombo.SelectedValue.ToString + ", '" + _
                            DateReferencePicker.Value.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, '" + Replace(NotesV.Text, "'", "''") + "', " + IdCitaLab.ToString + ") "
                        bdInsertar(sql)
                        limpiarExamenLab()
                        laboratorios()
                    End If

                End If
            Else
                If ResultadoLab = "0" Then
                    sql = "INSERT INTO dbo.MemberHealthLabExam " + _
                          "SELECT Examen_ID, " + ExamenesCombo.SelectedValue.ToString + ", GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, '" + Replace(NotesV.Text, "'", "''") + "', IdAppLab " + _
                          "FROM dbo.MemberHealthLabExam " + _
                          "WHERE RecordStatus = ' '  AND Examen_ID = " + IdLab
                    bdInsertar(sql)
                    limpiarExamenLab()
                    laboratorios()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub nuevaMed()
        If esValidaNuevaMedicina() = True Then
            If Mid(MedsCombo.SelectedValue, 3) = "00" Or Mid(MedsCombo.SelectedValue, 3) = "0" Then
                MsgBox("Esta seleccionando una categoria, no un medicamento", vbInformation, My.Resources.versionFamilias2)
            Else
                If existeEnListado(MedsCombo.SelectedValue, MedsGrid, 1) = True Then 'check if the med is not in the list
                    MsgBox("La medicina seleccionada ya existe en la receta", vbInformation, My.Resources.versionFamilias2)
                Else
                    If suficienteExistencia(MedsCombo.SelectedValue, CantidadV.Text, MedsCombo.Text) = True Then 'check actually quantity
                        Dim IdTra As Integer = bdEntero("SELECT MAX(IdTransac) ID FROM  dbo.HealthInventoryTransactionMedi ", "ID") + 1
                        Dim precio As Double = bdDoble("SELECT Price FROM dbo.CdHealthInventoryItem WHERE Code = '" + MedsCombo.SelectedValue + "'", "Price").ToString("F2")
                        Dim total As Double = (Integer.Parse(CantidadV.Text) * precio) * (Double.Parse(normalPercentageV.Text) / 100)

                        If ExoneracionCheck.Checked = True And total > 0 Then
                            exon = "1"
                        Else
                            exon = "0"
                        End If
                        'IdTransac, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea, 
                        'MemberProject, memberId, UnitPrice, ApprovedTotalPrice, Indications, Notes, IdConsultation, PayDateTime, DeliveryDateTime, DeliveredBy, ByCredit,
                        'Exoneration, TypePres
                        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi VALUES(" + IdTra.ToString + ", GETDATE(), ' ', '" + U + "', NULL, '" + S + _
                              "', GETDATE(), '" + dr + "', '" + MedsCombo.SelectedValue + "', " + (Integer.Parse(CantidadV.Text) * -1).ToString + ", 'CLIN', '" + sMember + "', " + memberId.ToString + ", " + _
                              precio.ToString + ", " + total.ToString("F2") + ", '" + Replace(InstrucV.Text, "'", "''") + "', '" + Replace(ObservacionesV.Text, "'", "''") + "', " + consId.ToString + ", " + _
                              "NULL, NULL, NULL, 0, " + exon + ", 'CONS')"
                        bdInsertar(sql)

                        medicinas()
                        'calculateTotalPrice()
                        limpiarMeds()

                        'sql = "UPDATE MemberClinicConsultation SET TotalNormalPrice = " + PrecioNormalV.Text.ToString + ", ApprovedPrice = " + normalTotalV.Text.ToString + " " + _
                        '      "WHERE RecordStatus = ' ' AND  IdConsultation = " + consId.ToString
                        'bdEjecutarSQL(sql)
                    End If
                End If
            End If
        End If
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

    Private Sub planButton_LinkClicked(sender As Object, e As EventArgs) Handles planButton.Click
        sql = "INSERT INTO dbo.MemberClinicConsultation " + _
                "SELECT IdConsultation, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, ConsultationDateTime, PrimaryDiagnosis, SecondaryDiagnosis1, " + _
                "SecondaryDiagnosis2, ProblemData, SubjetiveData, ObjetiveData, NewData, Others, '" + Replace(Replace(PlanV.Text, "'", "''"), Chr(10), vbNewLine) + "', TotalNormalPrice, ApprovedPrice, Exoneration, " + _
                "ApprovedBy, PayDateTime, Cashier, AppId " + _
                "FROM dbo.MemberClinicConsultation " + _
                "WHERE RecordStatus = ' '  AND IdConsultation = " + consId.ToString
        bdInsertar(sql)
        MsgBox("La actualización ha sido guardada correctamente", vbInformation, My.Resources.versionFamilias2)
    End Sub

    Private Sub PresionV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDiagonal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PesoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub recetasExternas()
        IdRecE = ""
        sql = "SELECT IdExternalPres ID, Convert(nvarchar(30), PresDateTime, 21) fecha, Medicine Medicina, Quantity Cantidad, Instruction Instrucciones " + _
              "FROM dbo.MemberClinicExternalPrescription " + _
              "WHERE RecordStatus = ' ' AND  IdConsultation = " + consId.ToString
        bdGrid(sql, RecetasExtGrid)
        RecetasExtGrid.Columns.Item(0).Visible = False 'ID
        RecetasExtGrid.Columns.Item(1).Visible = False 'fecha
    End Sub

    Private Sub referenciasExternas()
        IdRefE = ""
        sql = "SELECT MCER.IdExternalRef, Convert(nvarchar(30), MCER.ReferenceDateTime, 21) fecha, MCER.Place, MCER.Reason, cdERP.DescSpanish AS [Referido A], cdERR.DescSpanish AS Motivo, MCER.Rp " + _
              "FROM dbo.MemberClinicExternalReference MCER INNER JOIN dbo.CdHealthExternalReferencePlace cdERP ON MCER.Place = cdERP.Code " + _
              "INNER JOIN dbo.CdHealthExternalReferenceReason cdERR ON MCER.Reason = cdERR.Code " + _
              "WHERE MCER.RecordStatus = ' ' AND  MCER.IdConsultation = " + consId.ToString
        bdGrid(sql, ReferenciaExtGrid)
        ReferenciaExtGrid.Columns.Item(0).Visible = False 'ID
        ReferenciaExtGrid.Columns.Item(1).Visible = False 'fecha
        ReferenciaExtGrid.Columns.Item(2).Visible = False 'place
        ReferenciaExtGrid.Columns.Item(3).Visible = False 'reason

    End Sub

    Private Sub referenciasAE()
        infoTable.Clear()
        Dim estado As String
        estado = ""
        sql = "SELECT IdInternalRef ID, Program, Category, Status, Description " + _
              "FROM dbo.MemberInternalReference " + _
              "WHERE RecordStatus = ' ' AND Program = 'PSIC' AND  IdConsultation = " + consId.ToString
        bdDataTable(sql, infoTable)

        If infoTable.Rows.Count > 0 Then
            IdrAE = infoTable.Rows(0)("ID").ToString
            estado = chequearValor(infoTable.Rows(0)("Status")).ToString
            CategoriaPsicCombo.SelectedValue = chequearValor(infoTable.Rows(0)("Category")).ToString
            DescRefPsic.Text = chequearValor(infoTable.Rows(0)("Description")).ToString

            If estado = "REFE" Then
                CategoriaPsicCombo.Enabled = True
                DescRefPsic.Enabled = True
                BorrarRefAEButton.Visible = True
            Else
                CategoriaPsicCombo.Enabled = False
                DescRefPsic.Enabled = False
                BorrarRefAEButton.Visible = False
            End If
        Else
            IdrAE = "0"
            BorrarRefAEButton.Visible = False
        End If
    End Sub

    Private Sub referenciasTS()
        infoTable.Clear()
        Dim estado As String
        sql = "SELECT  IdInternalRef ID, Program, Category, Status, Description " + _
              "FROM dbo.MemberInternalReference " + _
              "WHERE RecordStatus = ' ' AND Program = 'TS' AND  IdConsultation = " + consId.ToString
        bdDataTable(sql, infoTable)

        If infoTable.Rows.Count > 0 Then
            idrTS = infoTable.Rows(0)("ID").ToString
            estado = chequearValor(infoTable.Rows(0)("Status")).ToString
            CategoriaTSCombo.SelectedValue = chequearValor(infoTable.Rows(0)("Category")).ToString
            DescRefTS.Text = chequearValor(infoTable.Rows(0)("Description")).ToString

            If estado = "REFE" Then
                CategoriaTSCombo.Enabled = True
                DescRefTS.Enabled = True
                BorrarRefTSButton.Visible = True
            Else
                CategoriaTSCombo.Enabled = False
                DescRefTS.Enabled = False
                BorrarRefTSButton.Visible = False
            End If
        Else
            BorrarRefTSButton.Visible = False
            idrTS = "0"
        End If
    End Sub

    Private Sub RecetasExtGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecetasExtGrid.CellContentClick
        Dim f As Integer
        f = RecetasExtGrid.CurrentCellAddress.Y
        IdRecE = RecetasExtGrid.Item(0, f).Value()
        ExMedicineV.Text = RecetasExtGrid.Item(2, f).Value()
        ExQuantityV.Text = RecetasExtGrid.Item(3, f).Value()
        ExtIndicationsV.Text = RecetasExtGrid.Item(4, f).Value()
    End Sub

    Private Sub ReferenciaExtGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReferenciaExtGrid.CellContentClick
        Dim f As Integer
        f = ReferenciaExtGrid.CurrentCellAddress.Y
        IdRefE = ReferenciaExtGrid.Item(0, f).Value()
        ExternalPlaceV.SelectedValue = ReferenciaExtGrid.Item(2, f).Value()
        ExternalReasonV.SelectedValue = ReferenciaExtGrid.Item(3, f).Value()
        rpRefEV.Text = Replace(ReferenciaExtGrid.Item(6, f).Value(), Chr(10), vbNewLine)
    End Sub

    Private Sub SumarioGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SumarioGrid.CellContentClick
        Dim f As Integer
        f = SumarioGrid.CurrentCellAddress.Y
        IdSM = ""
        sTipoCombo.Text = ""

        sFechaDateTimePicker.Value = SumarioGrid.Item(1, f).Value()
        sTipoCombo.SelectedValue = SumarioGrid.Item(2, f).Value()
        sObservacionesV.Text = Replace(SumarioGrid.Item(6, f).Value(), Chr(10), vbNewLine)
        IdSM = SumarioGrid.Item(0, f).Value()
        sTipoCombo.Text = SumarioGrid.Item(2, f).Value()
    End Sub

    Private Sub SumaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumaryButton.Click
        If Len(sTipoCombo.Text) = 0 Or Len(sObservacionesV.Text) = 0 Then
            MsgBox("Todos los campos con * necesitan información", vbInformation, My.Resources.versionFamilias2)
        Else
            'IdMedSum, CreationDateTime, Project, MemberId, DateTimeSum, Type, RecordStatus, UserId, ExpirationDateTime, Observations, Quantity, RegisterBy
            If IdSM = "0" Or Len(IdSM) = 0 Then
                Dim idMS As Integer
                sql = "SELECT CASE WHEN MAX(IdMedSum) IS NULL THEN 0  ELSE MAX(IdMedSum)  END  Id " + _
                      "FROM dbo.MemberMedicalSummaryHistory WHERE Project = '" + sMember + "' AND MemberId = " + memberId.ToString + " "
                idMS = bdEntero(sql, "Id") + 1
                sql = "INSERT INTO dbo.MemberMedicalSummaryHistory VALUES (" + idMS.ToString + ", GETDATE(), '" + sMember + "', " + memberId.ToString + ", '" + sFechaDateTimePicker.Value.ToString(en.DateTimeFormat) + "', '" + sTipoCombo.SelectedValue + "', ' ', '" + U + "', NULL, " + _
                      "'" + Replace(Replace(sObservacionesV.Text, "'", "''"), Chr(10), vbNewLine) + "', NULL, '" + dr + "')"
                bdInsertar(sql)
                limpiarSM()
                verSumario()
            Else
                sql = "INSERT INTO dbo.MemberMedicalSummaryHistory " + _
                      "SELECT IdMedSum, GETDATE(), Project, MemberId, DateTimeSum, '" + sTipoCombo.SelectedValue + "', RecordStatus, '" + U + "', ExpirationDateTime, " + _
                      "'" + Replace(Replace(sObservacionesV.Text, "'", "''"), Chr(10), vbNewLine) + "', Quantity, RegisterBy " + _
                      "FROM dbo.MemberMedicalSummaryHistory " + _
                      "WHERE RecordStatus = ' ' AND IdMedSum = " + IdSM + " AND  Project = '" + sMember + "' AND MemberId = " + memberId.ToString + " "
                bdInsertar(sql)
                limpiarSM()
                verSumario()
            End If
        End If
    End Sub

    Private Function suficienteExistencia(ByVal medicine As String, ByVal quantity As Integer, ByVal medicineDes As String) As Boolean
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
                    MsgBox("La existencia actual para " + medicineDes + " es de: " + actualQuant.ToString, vbCritical, My.Resources.versionFamilias2)
                    suficienteExistencia = False
                    limpiarMeds()
                Else
                    suficienteExistencia = True
                End If
            End If
        End If
    End Function

    Private Sub SumarioL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        verSumario()
    End Sub

    Private Function sumarPrecios(ByVal col As Integer) As Double
        Dim n As Integer = MedsGrid.Rows.Count
        If n = 0 Then
            sumarPrecios = 0.0
        Else
            Dim total, precio As Double
            Dim z As Integer
            total = 0
            precio = 0

            Do While z < n
                precio = Convert.ToDouble(MedsGrid.Item(col, z).Value)
                total = total + precio
                z = z + 1
            Loop
            sumarPrecios = total
        End If
    End Function

    Private Sub TallaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TempV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function tieneResultsLab() As Integer
        Dim total As Integer = 0
        For f = 0 To ExamenesGrid.RowCount - 1
            total = total + Integer.Parse(ExamenesGrid.Item(2, f).Value())
        Next
        tieneResultsLab = total
    End Function

    Private Sub tratamientos()
        sql = "SELECT MNT.IdTreatment, MNT.Treatment, dbo.fn_GEN_FormatDate(MNT.RefDateTime, 'ES') AS Referido, MNT.Physician AS Médico, " + _
              "cdTT.DescSpanish AS Tratamiento, MNT.Quantity Cantidad, MNT.Instruction AS Indicaciones, dbo.fn_GEN_FormatDate(MNT.TreatDateTime, 'ES') AS Realizado,  " + _
              "MNT.TreatBy AS Realizado_Por, MNT.Observations AS Observaciones " + _
              "FROM dbo.MemberNursTreatment MNT INNER JOIN dbo.CdHealthTreatment cdTT ON MNT.Treatment = cdTT.Code " + _
              "WHERE MNT.RecordStatus = ' ' AND IdConsultation = " + consId.ToString
        bdGrid(sql, TratamientosGrid)
        TratamientosGrid.Columns.Item(0).Visible = False 'ID
        TratamientosGrid.Columns.Item(1).Visible = False 'codigo
    End Sub

    Private Sub TratamientosGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TratamientosGrid.CellContentClick
        Dim f As Integer
        f = TratamientosGrid.CurrentCellAddress.Y
        limpiarTrats()

        IdTrat = TratamientosGrid.Item(0, f).Value()
        TratamientosCombo.SelectedValue = TratamientosGrid.Item(1, f).Value()
        ObserTratV.Text = chequearValor(TratamientosGrid.Item(6, f).Value())
        CantidadTratV.Text = chequearValor(TratamientosGrid.Item(5, f).Value().ToString)
        realiz = chequearValor(TratamientosGrid.Item(7, f).Value().ToString)

        TratamientosCombo.Enabled = False

        If Len(realiz) > 1 Then
            ObserTratV.Enabled = False
            CantidadTratV.Enabled = False
        Else
            ObserTratV.Enabled = True
            CantidadTratV.Enabled = True
        End If
    End Sub

    Private Function turnoLab(ByVal DateSelec As DateTime) As Integer
        sql = "SELECT CASE WHEN MAX(Turn) IS NULL THEN 0 ELSE MAX(Turn) END as Turn " + _
                   "FROM dbo.MemberHealthLabAppointment MHL " + _
                   "WHERE MHL.RecordStatus = ' ' AND YEAR(MHL.ReferenceDate) = " + DateSelec.Year.ToString + _
                    " AND MONTH(MHL.ReferenceDate) = " + DateSelec.Month.ToString + " AND DAY(MHL.ReferenceDate) = " + DateSelec.Day.ToString + " "
        turnoLab = bdEntero(sql, "Turn") + 1
    End Function

    Private Function turnosLabDisponibles() As Boolean
        turn = 0
        emergency = "0"
        status = "REFE"
        Dim intervalo As TimeSpan = DateReferencePicker.Value - DateTime.Now
        If intervalo.Days < 0 Then
            MsgBox("La fecha no puede ser menor a la actual", vbInformation, My.Resources.versionFamilias2)
            turnosLabDisponibles = False
        ElseIf intervalo.Days = 0 Then
            sql = "SELECT dbo.fn_HEAL_LAB_espacioDisponible_MEDI('" + DateReferencePicker.Value.ToString(en.DateTimeFormat) + "', " + intervalo.Days.ToString + ") RESUL "
            Dim disponibles As String = bdPalabra(sql, "RESUL")

            If disponibles = "SI" Then
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox("¿Esta seguro de ingresar referencia al laboratorio hoy?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    turnosLabDisponibles = True
                    needTurn = True
                    turn = turnoLab(DateReferencePicker.Value).ToString
                    status = "COMP"
                    emergency = "1"
                Else
                    turnosLabDisponibles = True
                End If
            Else
                MsgBox("No hay espacio suficiente en laboratorio", vbInformation, My.Resources.versionFamilias2)
                turnosLabDisponibles = False
            End If
        Else
            sql = "SELECT dbo.fn_HEAL_LAB_espacioDisponible_MEDI('" + DateReferencePicker.Value.ToString(en.DateTimeFormat) + "', " + intervalo.Days.ToString + ") RESUL "
            Dim disponibles As String = bdPalabra(sql, "RESUL")
            If disponibles = "SI" Then
                turnosLabDisponibles = True
                needTurn = False
            Else
                MsgBox("No hay espacio suficiente en laboratorio", vbInformation, My.Resources.versionFamilias2)
                turnosLabDisponibles = False
            End If
        End If
    End Function

    Private Sub verSumario()
        'fill sumary history
        sql = "SELECT IdMedSum, CONVERT(nvarchar(50), MMS.DateTimeSum, 21) AS FechaSM, MMS.Type, CdT.DescSpanish AS Tipo,  dbo.fn_GEN_FormatDate(MMS.DateTimeSum, 'ES') AS Fecha, " + _
              "MMS.RegisterBy 'Registró', MMS.Observations AS Observaciones, MMS.UserId Usuario " + _
              "FROM dbo.MemberMedicalSummaryHistory MMS INNER JOIN dbo.CdMedicalSummaryType CdT ON MMS.Type = CdT.Code " + _
                "INNER JOIN dbo.CdMedicalSummaryCategory CdC ON CdT.Category = CdC.Code " + _
              "WHERE MMS.RecordStatus = ' ' AND MMS.Project = '" + sMember + "' AND MMS.MemberId = " + memberId.ToString + _
              " ORDER BY MMS.Type,MMS.DateTimeSum DESC"
        bdGrid(sql, SumarioGrid)

        SumarioGrid.Columns(3).Frozen = True
        SumarioGrid.Columns.Item(0).Visible = False 'ID
        SumarioGrid.Columns.Item(1).Visible = False 'Fecha
        SumarioGrid.Columns.Item(2).Visible = False 'tipo
    End Sub
End Class