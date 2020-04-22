' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ConsultaMedica
    Public sMember As String
    Public memberId, appid As Integer

    Dim iMeds, iLabs, consid, init As Integer
    Dim hPercent, orPercentage As Integer
    Dim dr, emergency, turn, status, nCita As String
    Dim presDT As DateTime
    Dim hc As New HistorialConsulta

    Private Sub ConsultaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
        PacienteV.Focus()
        init = 0
    End Sub

    Private Sub ConsultaMedica_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
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
        If esValidaNuevaMedicinaExt() = True Then 'need fill med, quantity and instructions
            If existeEnListado(MedsCombo.Text, RecetasExtGrid, 1) = True Then 'check if the med is not in the list
                MsgBox("La medicina ya existe", vbInformation, My.Resources.versionFamilias2)
            Else
                llenarExMedsGrid()
            End If
            ExMedicineV.Focus()
            ExMedicineV.Text = ""
            ExQuantityV.Text = ""
            ExtIndicationsV.Text = ""
        End If
    End Sub

    Private Sub AgregarRefButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarRefButton.Click
        If esValidaNuevaExRef() = True Then 'need fill med, quantity and instructions
            If existeEnListado(MedsCombo.Text, ReferenciaExtGrid, 1) = True Then 'check if the med is not in the list
                MsgBox("La medicina ya existe", vbInformation, My.Resources.versionFamilias2)
            Else
                llenarExRefsGrid()
            End If
            ExternalPlaceV.Focus()
            ExternalPlaceV.SelectedIndex = -1
            ExternalReasonV.SelectedIndex = -1
            rpRefEV.Text = ""
        End If
    End Sub

    Private Function asignarId() As Integer
        sql = "SELECT MAX(AppId) AS Ultimo FROM  dbo.MemberClinicAppointment "
        asignarId = bdPalabra(sql, "Ultimo") + 1
    End Function

    Private Sub AsignarPaciente()
        If Len(DrL.Text) = 0 Then
            If esMedico(U) = True Then
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                response = MsgBox("¿Quiere asignarse al paciente? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    sql = "INSERT INTO dbo.MemberClinicAppointment " + _
                          "SELECT AppId, GETDATE(), Project, MemberId, AppointmentDateTime, RecordStatus, '" + U + "', ExpirationDateTime, HealthClinic, '" + U + "', " + _
                          " ConsultationType, Status, Turn, AMorPM, Temperature, Weight, Stature, BloodPressure, HeartRate, RespiratoryRate, Notes, IdConsultationReference " + _
                          "FROM dbo.MemberClinicAppointment WHERE RecordStatus = ' ' AND AppId = " + appid.ToString
                    bdInsertar(sql)
                    dr = U
                Else
                    irAgenda()
                End If
            Else
                MsgBox("Puede asignar un médico en la función ""Cambiar Médico""", vbInformation, My.Resources.versionFamilias2)
                irCambiarMedico()
            End If
        Else
            dr = DrL.Text
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub calculateTotalPrice()
        Dim colaboracion As String = bdPalabra("SELECT dbo.fn_SALU_ColaboracionPorServicios('" + sMember + "', " + PacienteV.Text + ") C ", "C")
        normalTotalV.Text = colaboracion
        PrecioNormalV.Text = colaboracion

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
    End Sub


    'Private Sub calculateTotalPrice()
    '    Dim normalPrice, totalPrice As Double
    '    If MedsGrid.RowCount = 0 Then
    '        normalTotalV.Text = "0.00"
    '        PrecioNormalV.Text = "0.00"
    '    Else
    '        normalPrice = sumarPrecios(7)
    '        totalPrice = sumarPrecios(8)
    '        PrecioNormalV.Text = normalPrice.ToString("F", CultureInfo.InvariantCulture) 'normal Price
    '        normalTotalV.Text = totalPrice.ToString("F", CultureInfo.InvariantCulture)
    '    End If

    '    If sMember = "F" Or sMember = "S" Then
    '        If normalTotalV.Text = "0.00" Or normalTotalV.Text = "0" Or Double.Parse(normalPercentageV.Text) = 0 Then
    '            ExoneracionCheck.Visible = False
    '            ExoneracionCheck.Checked = False
    '        Else
    '            ExoneracionCheck.Visible = True
    '        End If
    '    Else
    '        ExoneracionCheck.Visible = False
    '    End If
    '    MsGPay()
    'End Sub

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

    Private Sub correlativosMeds()
        Dim rowNumber As Integer = 1
        For Each row As DataGridViewRow In MedsGrid.Rows
            If row.IsNewRow Then Continue For
            row.HeaderCell.Value = "Row " & rowNumber
            rowNumber = rowNumber + 1
        Next
        calculateTotalPrice()
    End Sub

    Private Function esCitaLabValida() As Boolean
        status = "REFE"
        emergency = "NULL"
        turn = 0

        sql = "SELECT  COUNT(*) Total FROM dbo.MemberHealthLabAppointment MHLA " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + PacienteV.Text + " AND YEAR(ReferenceDate) = " + DateReferencePicker.Value.Year.ToString + _
              " AND MONTH(ReferenceDate) = " + DateReferencePicker.Value.Month.ToString + " AND DAY(ReferenceDate) = " + DateReferencePicker.Value.Day.ToString
        Dim existeEnAgenda As Integer = bdPalabra(sql, "Total")

        If existeEnAgenda = 0 Then
            sql = "SELECT PropertyValue Total FROM dbo.FwApplicationProperty WHERE Category = 'LABO' AND Name = 'TurnsByDay' AND Organization = 'F'"
            Dim topeTurnos As Integer = bdEntero(sql, "Total") - 5
            Dim intervalo As TimeSpan = DateReferencePicker.Value - DateTime.Now
            Dim total As Integer = 0

            If intervalo.Days < 0 Then 'menos a la fecha actual
                MsgBox("La fecha no puede ser menor a la actual", vbInformation, My.Resources.versionFamilias2)
                esCitaLabValida = False
            Else
                If DateReferencePicker.Value.Year = Now.Year And DateReferencePicker.Value.Month = Now.Month And DateReferencePicker.Value.Day = Now.Day Then 'en el mismo día
                    sql = "SELECT PropertyValue Total FROM dbo.FwApplicationProperty WHERE Category = 'LABO' AND Name = 'EmergenciesByDay' AND Organization = 'F'"
                    Dim emergencias As Integer = bdEntero(sql, "Total")

                    sql = "SELECT  COUNT(*) Total FROM dbo.MemberHealthLabAppointment MHLA " + _
                          "WHERE RecordStatus = ' ' AND Emergency = 1 AND YEAR(ReferenceDate) = " + DateReferencePicker.Value.Year.ToString + _
                          " AND MONTH(ReferenceDate) = " + DateReferencePicker.Value.Month.ToString + " AND DAY(ReferenceDate) = " + DateReferencePicker.Value.Day.ToString
                    total = bdEntero(sql, "Total")

                    If total < emergencias Then
                        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                        Dim response As MsgBoxResult
                        response = MsgBox("¿Esta seguro de ingresar referencia al laboratorio hoy?", style, My.Resources.versionFamilias2)
                        If response = MsgBoxResult.Yes Then
                            sql = "SELECT  MAX(Turn) Turno FROM dbo.MemberHealthLabAppointment MHLA " + _
                                  "WHERE RecordStatus = ' '  AND YEAR(ReferenceDate) = " + DateReferencePicker.Value.Year.ToString + _
                                  " AND MONTH(ReferenceDate) = " + DateReferencePicker.Value.Month.ToString + " AND DAY(ReferenceDate) = " + DateReferencePicker.Value.Day.ToString
                            turn = bdEntero(sql, "Turno") + 1
                            status = "COMP"
                            emergency = "1"
                            esCitaLabValida = True
                        Else
                            esCitaLabValida = False
                        End If
                    Else
                        MsgBox("No hay turnos disponibles.", vbInformation, My.Resources.versionFamilias2)
                        esCitaLabValida = False
                    End If
                Else 'cita a futuro
                    sql = "SELECT  COUNT(*) Total FROM dbo.MemberHealthLabAppointment MHLA " + _
                          "WHERE RecordStatus = ' ' AND YEAR(ReferenceDate) = " + DateReferencePicker.Value.Year.ToString + _
                          " AND MONTH(ReferenceDate) = " + DateReferencePicker.Value.Month.ToString + " AND DAY(ReferenceDate) = " + DateReferencePicker.Value.Day.ToString
                    total = bdEntero(sql, "Total")

                    If total < topeTurnos Then
                        esCitaLabValida = True
                    Else
                        MsgBox("No hay turnos disponibles en la fecha seleccionada", vbInformation, My.Resources.versionFamilias2)
                        esCitaLabValida = False
                    End If
                End If
            End If
        Else
            MsgBox("Ya existe una cita de laboratorio para este paciente en la fecha seleccionada", vbInformation, My.Resources.versionFamilias2)
            esCitaLabValida = False
        End If
    End Function

    Private Function esCitaEnfermeriaValida() As Boolean
        If TratamientosGrid.Rows.Count = 0 Then
            esCitaEnfermeriaValida = True
        Else
            Dim N, turnos As Integer
            sql = "SELECT PropertyValue FROM dbo.FwApplicationProperty WHERE Category = 'ENFE' AND Name = 'TurnsByDay'"
            turnos = Integer.Parse(bdPalabra(sql, "PropertyValue"))

            sql = "SELECT dbo.fn_HEAL_ENFE_Pacientes('" + FechaTratPicker.Value.ToString(en.DateTimeFormat) + "') Pacientes "
            N = bdEntero(sql, "Pacientes")

            If N < turnos Then
                esCitaEnfermeriaValida = True
            Else
                esCitaEnfermeriaValida = False
                MsgBox("No hay turnos disponible en enfermería en la fecha seleccionada, necesita eliminar el existente y reingresarlo con la nueva fecha", vbQuestion, My.Resources.versionFamilias2)
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
        Else
            esConsultaValida = True
        End If
    End Function

    Private Function esRecetaValida() As Boolean
        If MedsGrid.Rows.Count() >= 1 Then
            Dim t As Integer = 0
            For i = 0 To MedsGrid.Rows.Count() - 1
                If suficienteExistencia(MedsGrid.Item(1, i).Value(), MedsGrid.Item(3, i).Value(), MedsGrid.Item(2, i).Value()) = False Then
                    t = t + 1
                End If
            Next

            If t > 0 Then
                esRecetaValida = False
            Else
                esRecetaValida = True
            End If
        Else
            esRecetaValida = True
        End If
    End Function

    Private Function esRefInternaValida() As Boolean
        If (Len(CategoriaTSCombo.Text) = 0 And Len(DescRefTS.Text) = 0) Or (Len(CategoriaPsicCombo.Text) = 0 And Len(DescRefPsic.Text) = 0) Then
            esRefInternaValida = True
        Else
            If (Len(CategoriaTSCombo.Text) = 0 And Len(DescRefTS.Text) > 0) Or (Len(CategoriaTSCombo.Text) > 0 And Len(DescRefTS.Text) = 0) Then
                MsgBox("Verifique la referencia a TS " + Chr(9) + _
                       "(Los 2 campos tienen que tener valores si esta enviando una referencia, caso contrario los 2 deben estar vacios)", vbInformation, My.Resources.versionFamilias2)
                esRefInternaValida = False
            ElseIf (Len(CategoriaPsicCombo.Text) = 0 And Len(DescRefPsic.Text) > 0) Or (Len(CategoriaPsicCombo.Text) > 0 And Len(DescRefPsic.Text) = 0) Then
                MsgBox("Verifique la referencia a Psicología " + Chr(9) + _
                       "(Los 2 campos tienen que tener valores si esta enviando una referencia , caso contrario los 2 deben estar vacios)", vbInformation, My.Resources.versionFamilias2)
                esRefInternaValida = False
            ElseIf CategoriaPsicCombo.SelectedIndex = -1 Or CategoriaTSCombo.SelectedIndex = -1 Then
                MsgBox("La categoria que ha seleccionado no es válida", vbInformation, My.Resources.versionFamilias2)
                esRefInternaValida = False
            Else
                esRefInternaValida = True
            End If
        End If
    End Function

    Private Function esValidaNuevaExRef() As Boolean
        If ExternalPlaceV.Text = "" Or IsDBNull(ExternalPlaceV.Text) Then
            MsgBox("Necesita indicar lugar de referencia", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaExRef = False
        ElseIf ExternalReasonV.Text = "" Or IsDBNull(ExternalReasonV.Text) Then
            MsgBox("Necesita indicar la razón de referencia", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaExRef = False
        ElseIf rpRefEV.Text = "" Or IsDBNull(rpRefEV.Text) Then
            MsgBox("Necesita indicar información en Rp.", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaExRef = False
        Else
            esValidaNuevaExRef = True
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

    Private Function esValidaNuevaMedicinaExt() As Boolean
        If ExMedicineV.Text = "" Or IsDBNull(ExMedicineV.Text) Then
            MsgBox("Necesita indicar una medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicinaExt = False
        ElseIf ExQuantityV.Text = "" Or IsDBNull(ExQuantityV.Text) Then
            MsgBox("Necesita ingresar la cantidad de la medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicinaExt = False
        ElseIf ExtIndicationsV.Text = "" Or IsDBNull(ExtIndicationsV.Text) Then
            MsgBox("Necesita ingresar las instrucciones de la medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicinaExt = False
        Else
            esValidaNuevaMedicinaExt = True
        End If
    End Function

    Private Function esValidaOpSum() As Boolean
        If sTipoCombo.Text = "" Or IsDBNull(MedsCombo.Text) Then
            MsgBox("Necesita seleccionar un tipo", vbInformation, My.Resources.versionFamilias2)
            esValidaOpSum = False
        Else
            esValidaOpSum = True
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

    Private Sub ExoneracionCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExoneracionCheck.CheckedChanged
        MsGPay()
    End Sub

    Private Sub fCardiacaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fCardiacaV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fRespiratoriaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fRespiratoriaV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If validaDatos() = True Then 'verificar campos requeridos
            presDT = DateTime.Now '.ToString(en.DateTimeFormat)
            consid = idConsulta()
            If insertarConsulta(presDT.ToString(en.DateTimeFormat)) = True Then
                actualizarCita()
                guardarSummary()
                guardarListadoMeds(presDT.ToString(en.DateTimeFormat))
                guardarLabs()
                guardarRecetasExt()
                guardarReferenciasExt()
                guardarTratamientos()
                guardarReferenciasInternas()

                MasMedsBoton.Visible = False
                AgregarRecetaButton.Visible = False
                AgregarRefButton.Visible = False

                MsgBox("Consulta ingresada", vbInformation, My.Resources.versionFamilias2)
                irAgenda()
            End If
        End If
    End Sub

    Private Sub guardarEnfer(ByVal fecha As DateTime, ByVal treat As String, ByVal obs As String, ByVal quant As String)
        Dim q As String
        If quant = "" Or IsDBNull(quant) Then
            q = "NULL"
        Else
            q = quant
        End If

        sql = "SELECT MAX(IdTreatment) mx FROM dbo.MemberNursTreatment "
        Dim id As Integer = bdEntero(sql, "mx") + 1

        'IdTreatment, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Project, MemberId, Physician, RefDateTime, Treatment, Quantity, 
        'Instruction, IdConsultation, TreatDateTime, TreatBy, observations
        sql = "INSERT INTO dbo.MemberNursTreatment VALUES (" + id.ToString + ", GETDATE(), ' ', '" + U + "', NULL, '" + sMember + "', " + memberId.ToString + ", " + _
             "'" + dr + "', '" + fecha.ToString(en.DateTimeFormat) + "', '" + treat + "', " + q + ",'" + Replace(obs, "'", "''") + "', " + consid.ToString + ", NULL, NULL, NULL)"
        bdInsertar(sql)
    End Sub

    Private Sub guardarLabs()
        If ExamenesGrid.Rows.Count > 0 Then
            '*Nueva ID cita
            sql = "SELECT  MAX(IdAppLab) AS Id FROM dbo.MemberHealthLabAppointment " 'WHERE recordStatus = ' ' "
            Dim idRefLab As Integer = bdEntero(sql, "Id") + 1

            '*insertar cita a laboratorio
            'IdAppLab, CreationDateTime, Project, MemberId, UserId, ExpirationDateTime, ReferenceDate, IdConsultation, StatusApp, Turn, 
            'DrReferred, PendPay, RecordStatus, TotalNormalPrice, emergency
            sql = "INSERT INTO dbo.MemberHealthLabAppointment  " + _
                  " VALUES(" + idRefLab.ToString + ", GETDATE(), '" + sMember + "', " + memberId.ToString + ", '" + _
                  U + "', NULL, '" + DateReferencePicker.Value.ToString(en.DateTimeFormat) + "', " + consid.ToString + ", '" + status + "', " + turn.ToString + ", '" + U + "', " + _
                  "0, ' ', 0, " + emergency + ")"
            bdInsertar(sql)

            '*insertar laboratorios
            For f = 0 To ExamenesGrid.RowCount - 1
                insertLaboratorio(ExamenesGrid.Item(1, f).Value, ExamenesGrid.Item(3, f).Value, ExamenesGrid.Item(4, f).Value, idRefLab)
            Next
        End If
    End Sub

    Private Sub guardarListadoMeds(ByVal fechaCon As String)
        If MedsGrid.Rows.Count() >= 1 Then
            For i = 0 To MedsGrid.Rows.Count() - 1
                insertarMedicina(fechaCon, MedsGrid.Item(1, i).Value(), MedsGrid.Item(3, i).Value(), MedsGrid.Item(4, i).Value(),
                                 MedsGrid.Item(5, i).Value(), MedsGrid.Item(6, i).Value(), MedsGrid.Item(8, i).Value())
            Next
        End If
    End Sub

    Private Sub guardarRecetasExt()
        If RecetasExtGrid.Rows.Count() >= 1 Then
            For i = 0 To RecetasExtGrid.Rows.Count() - 1
                insertarRecetaExt(RecetasExtGrid.Item(1, i).Value(), RecetasExtGrid.Item(2, i).Value(), RecetasExtGrid.Item(3, i).Value())
            Next
        End If
    End Sub

    Private Sub guardarReferenciasInternas()
        Dim sqlId = "SELECT MAX(IdInternalRef) U FROM dbo.MemberInternalReference "
        Dim idIRTS, idIRPsic As Integer
        'IdInternalRef, CreationDateTime, RecordStatus, Project, MemberId, Program, Category, ReferenceDateTime, UserId, ExpirationDateTime, 
        'status, StatusDate, ReferredBy, description, Observations, IdConsultation

        'Referencia TS
        If Len(CategoriaTSCombo.Text) > 0 And Len(DescRefTS.Text) > 0 Then
            idIRTS = bdEntero(sqlId, "U") + 1
            sql = "INSERT INTO dbo.MemberInternalReference VALUES (" + idIRTS.ToString + ", GETDATE(), ' ', '" + sMember + "', " + memberId.ToString + ", 'TS', '" + _
                  CategoriaTSCombo.SelectedValue + "', GETDATE(), '" + U + "', NULL, 'REFE', GETDATE(), '" + dr + "', '" + Replace(Replace(DescRefTS.Text, "'", "''"), Chr(10), vbNewLine) + "', NULL, " + consid.ToString + " )"
            bdInsertar(sql)
        End If

        'Referencia PSICOLOGIA
        If Len(CategoriaPsicCombo.Text) > 0 And Len(DescRefPsic.Text) > 0 Then
            idIRPsic = bdEntero(sqlId, "U") + 1
            sql = "INSERT INTO dbo.MemberInternalReference VALUES (" + idIRPsic.ToString + ", GETDATE(), ' ', '" + sMember + "', " + memberId.ToString + ", 'PSIC', '" + _
                  CategoriaPsicCombo.SelectedValue + "', GETDATE(), '" + U + "', NULL, 'REFE', GETDATE(), '" + dr + "', '" + Replace(Replace(DescRefPsic.Text, "'", "''"), Chr(10), vbNewLine) + "', NULL, " + consid.ToString + " )"
            bdInsertar(sql)
        End If
    End Sub

    Private Sub guardarReferenciasExt()
        If ReferenciaExtGrid.Rows.Count() >= 1 Then
            For i = 0 To ReferenciaExtGrid.Rows.Count() - 1
                insertarRefExt(ReferenciaExtGrid.Item(1, i).Value(), ReferenciaExtGrid.Item(3, i).Value(), ReferenciaExtGrid.Item(5, i).Value())
            Next
        End If
    End Sub

    Private Sub guardarSummary()
        If SumaryGrid.Rows.Count() >= 1 Then
            For i = 0 To SumaryGrid.Rows.Count() - 1
                guardarSumOpcion(SumaryGrid.Item(0, i).Value(), SumaryGrid.Item(1, i).Value(), SumaryGrid.Item(4, i).Value(), SumaryGrid.Item(3, i).Value())
            Next
        End If
    End Sub

    Private Sub guardarSumOpcion(ByVal fecha As DateTime, ByVal typ As String, ByVal obs As String, ByVal quant As String)
        Dim q As String
        Dim idMS As Integer
        If quant = "" Or IsDBNull(quant) Then
            q = "NULL"
        Else
            q = quant
        End If
        sql = "SELECT CASE WHEN MAX(IdMedSum) IS NULL THEN 0  ELSE MAX(IdMedSum)  END  Id " + _
              "FROM dbo.MemberMedicalSummaryHistory WHERE Project = '" + sMember + "' AND MemberId = " + memberId.ToString + " "
        idMS = bdEntero(sql, "Id") + 1

        'IdMedSum, CreationDateTime, Project, MemberId, DateTimeSum, Type, RecordStatus, UserId, ExpirationDateTime, Observations, Quantity, RegisterBy()
        sql = "INSERT INTO dbo.MemberMedicalSummaryHistory VALUES (" + idMS.ToString + ", GETDATE(), '" + sMember + "', " + memberId.ToString + ", '" + fecha.ToString(en.DateTimeFormat) + "', '" + typ + "', ' ', '" + U + "', NULL, " + _
              "'" + Replace(Replace(obs, "'", "''"), Chr(10), vbNewLine) + "', " + q + ", '" + dr + "')"
        bdInsertar(sql)
    End Sub

    Private Sub guardarTratamientos()
        If turnoDisponibleEnf() = True And TratamientosGrid.Rows.Count > 0 Then
            For f = 0 To TratamientosGrid.RowCount - 1
                guardarEnfer(DateTime.Parse(TratamientosGrid.Item(5, f).Value()), TratamientosGrid.Item(1, f).Value(), TratamientosGrid.Item(3, f).Value(), TratamientosGrid.Item(4, f).Value())
            Next
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

    Private Function idConsulta() As Integer
        sql = "SELECT MAX(IdConsultation) AS Ultimo FROM dbo.MemberClinicConsultation " '
        idConsulta = bdEntero(sql, "Ultimo") + 1
    End Function

    Private Sub infoGen()
        Dim listTable As New DataTable
        sql = "SELECT  MCA.Temperature, MCA.Weight, MCA.Stature, MCA.BloodPressure, MCA.HeartRate, MCA.RespiratoryRate " + _
              "FROM dbo.MemberClinicAppointment MCA " + _
              "WHERE MCA.RecordStatus = ' ' AND MCA.AppId = " + appid.ToString
        bdDataTable(sql, listTable)

        'description()
        TempV.Text = chequearValor(listTable.Rows(0)("Temperature")).ToString
        PesoV.Text = chequearValor(listTable.Rows(0)("Weight")).ToString
        TallaV.Text = chequearValor(listTable.Rows(0)("Stature")).ToString
        PresionV.Text = chequearValor(listTable.Rows(0)("BloodPressure")).ToString
        fCardiacaV.Text = chequearValor(listTable.Rows(0)("HeartRate")).ToString
        fRespiratoriaV.Text = chequearValor(listTable.Rows(0)("RespiratoryRate")).ToString

        If sMember = "A" Or sMember = "E" Then
        Else
            ClassificationV.Text = chequearValor(clasificacionFamiliar(sMember, FamiliaV.Text))
        End If


        hPercent = porcentajeSalud(sMember, PacienteV.Text)
        memTypeV.Text = tipo_Miembro(sMember, PacienteV.Text)


        DrL.Text = "Médico: " + dr
        normalPercentageV.Text = hPercent.ToString
        orPercentage = Convert.ToDouble(normalPercentageV.Text)
        normalPercentageV2.Text = normalPercentageV.Text + "%"

        IMCL.Text = calcularIMC(PesoV.Text, TallaV.Text)

        If Len(ClassificationV.Text) = 0 Then
            ClassificationV.Visible = False
            ClassificationL.Visible = False
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Function insertarConsulta(ByVal fecha As String) As Boolean
        sql = "SELECT COUNT(*) Total FROM dbo.MemberClinicConsultation WHERE RecordStatus = ' ' AND AppId = " + appid.ToString
        If bdEntero(sql, "Total") = 0 Then
            calculateTotalPrice()
            Dim diags, exonerar, dg1, dg2, dg3 As String

            dg1 = "'" + Diagnostico1V.SelectedValue + "'"

            If Diagnostico2V.Text = "" Or Len(Diagnostico2V.Text) = 0 Then
                dg2 = "NULL"
            Else
                dg2 = "'" + Diagnostico2V.SelectedValue + "'"
            End If

            If Diagnostico3V.Text = "" Or Len(Diagnostico3V.Text) = 0 Then
                dg3 = "NULL"
            Else
                dg3 = "'" + Diagnostico3V.SelectedValue + "'"
            End If

            diags = dg1 + ", " + dg2 + ", " + dg3

            If ExoneracionCheck.Checked = True Then
                exonerar = "1, '" + U + "'"
            Else
                exonerar = "0, NULL"
            End If

            'sql = "SELECT     IdConsultation, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, ConsultationDateTime, PrimaryDiagnosis, SecondaryDiagnosis1, " + _
            '     "SecondaryDiagnosis2, ProblemData, SubjetiveData, ObjetiveData, NewData, Others, EducationalPlan, TotalNormalPrice, ApprovedPrice, Exoneration, " + _
            '   "ApprovedBy, PayDateTime, Cashier, AppId " + _
            sql = "INSERT INTO dbo.MemberClinicConsultation VALUES (" + consid.ToString + ", GETDATE(), ' ', '" + U + "', NULL, '" + fecha + "', " + diags + ", " + _
                  "'" + Replace(Replace(ProblemaV.Text, "'", "''"), Chr(10), vbNewLine) + "', '" + Replace(Replace(dSubjetivosV.Text, "'", "''"), Chr(10), vbNewLine) + "','" + _
                  Replace(Replace(dObjetivosV.Text, "'", "''"), Chr(10), vbNewLine) + "','" + Replace(Replace(NuevosDatosV.Text, "'", "''"), Chr(10), vbNewLine) + _
                  "', '" + Replace(Replace(OtrosV.Text, "'", "''"), Chr(10), vbNewLine) + "','" + Replace(Replace(PlanV.Text, "'", "''"), Chr(10), vbNewLine) + "', " + _
                  PrecioNormalV.Text + ", " + normalTotalV.Text + ", " + exonerar + ", NULL, NULL," + appid.ToString + ")"
            'InputBox("", "", sql)
            bdInsertar(sql)

            sql = "SELECT COUNT(*) Total FROM dbo.MemberClinicConsultation  WHERE IdConsultation = " + consid.ToString + " AND RecordStatus = ' ' "
            Dim n As Integer = bdEntero(sql, "Total")
            If n = 0 Then
                insertarConsulta = False
            Else
                insertarConsulta = True
                GuardarButton.Visible = False
            End If

        Else
            insertarConsulta = False
        End If
    End Function

    Private Sub insertLaboratorio(ByVal codeExam As String, _
                             ByVal notes As String, _
                             ByVal hasSubE As String, _
                             ByVal idReLab As Integer)
        sql = "SELECT MAX(Examen_ID) as Id FROM dbo.MemberHealthLabExam " 'WHERE recordStatus = ' ' "
        Dim idExam As Integer = bdEntero(sql, "Id") + 1

        ' Examen_ID, Examen_Tipo_ID, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, IdAppLab
        sql = "INSERT INTO dbo.MemberHealthLabExam  VALUES (" + _
                idExam.ToString + ", " + codeExam + ", GETDATE(), ' ', '" + _
                U + "', NULL, '" + Replace(Replace(notes, "'", "''"), Chr(10), vbNewLine) + "', " + idReLab.ToString + ")"
        bdInsertar(sql)
    End Sub

    Private Sub insertarMedicina(ByVal fechaCon As String, ByVal codMed As String, ByVal cant As String, ByVal indi As String,
                                     ByVal obse As String, ByVal uPri As String, ByVal pApr As String)
        Dim credito As String = 0
        Dim exon As String

        If ExoneracionCheck.Checked = True Then
            exon = 1
        Else
            exon = 0
        End If

        Dim tranId As Integer
        sql = "SELECT MAX(IdTransac) AS Ultimo FROM dbo.HealthInventoryTransactionMedi "
        tranId = bdEntero(sql, "Ultimo") + 1
        'IdTransac, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea,
        'MemberProject, memberId, UnitPrice, ApprovedTotalPrice, Indications, Notes, IdConsultation, PayDateTime, DeliveryDateTime, DeliveredBy,ByCredit, Exoneration, TypePres)
        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi VALUES (" + tranId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, 'F" + _
              "', '" + fechaCon + "', '" + dr + "', '" + codMed + "', " + (cant * -1).ToString + ", 'CLIN', '" + sMember + "', " + memberId.ToString + ", " + uPri + _
              ", '" + pApr + "', '" + Replace(indi, "'", "''") + "', '" + Replace(obse, "'", "''") + "', " + consid.ToString + ", NULL, NULL, NULL, " + credito.ToString + ", " + exon + ", 'CONS')"
        bdInsertar(sql)
    End Sub

    Private Sub insertarRecetaExt(ByVal med As String,
                              ByVal cant As String,
                              ByVal inst As String)
        Dim reExId As Integer = 0
        sql = "SELECT MAX( IdExternalPres) AS Ultimo FROM dbo.MemberClinicExternalPrescription "
        reExId = bdEntero(sql, "Ultimo") + 1
        'SELECT IdExternalPres, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, IdProgram, Project, MemberId, PresDateTime, Medicine, Quantity  , 
        'Instruction, IdConsultation
        sql = "INSERT INTO dbo.MemberClinicExternalPrescription VALUES (" + reExId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, 'CLIN', '" + sMember + _
              "', " + memberId.ToString + ", '" + presDT.ToString(en.DateTimeFormat) + "', '" + Replace(med, "'", "''") + "', '" + Replace(cant, "'", "''") + _
              "', '" + Replace(inst, "'", "''") + "', " + consid.ToString + ")"
        bdInsertar(sql)
    End Sub

    Private Sub insertarRefExt(ByVal lugar As String,
                          ByVal razon As String,
                          ByVal rp As String)
        Dim refExId As Integer
        sql = "SELECT MAX( IdExternalRef) AS Ultimo FROM dbo.MemberClinicExternalReference "
        refExId = bdEntero(sql, "Ultimo") + 1
        'IdExternalRef, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, IdProgram, Project, MembeId, ReferenceDateTime, Place, Reason, Rp, IdConsultation
        sql = "INSERT INTO dbo.MemberClinicExternalReference VALUES (" + refExId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, 'CLIN', '" + sMember + _
              "', " + memberId.ToString + ", '" + presDT.ToString(en.DateTimeFormat) + "', '" + lugar + "', '" + razon + "', '" + Replace(Replace(rp, "'", "''"), Chr(10), vbNewLine) + "', " + consid.ToString + ")"
        bdInsertar(sql)
    End Sub

    Private Sub irAgenda()
        Dim nv As New AgendaMedico
        nv.DateP.Value = Now
        nv.Show()
        Me.Close()
    End Sub

    Private Sub irCambiarMedico()
        Dim nv As New CambiarMedico
        nv.Show()
        Me.Close()
    End Sub

    Private Sub llenarCombos()
        'para diagnosis lists
        sql = "SELECT Code, CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish Diag FROM dbo.CdDiagnosis WHERE Active = 1 AND FunctionalArea = 'CLIN' "
        bdCombo(sql, Diagnostico1V, "Code", "Diag")
        bdCombo(sql, Diagnostico2V, "Code", "Diag")
        bdCombo(sql, Diagnostico3V, "Code", "Diag")

        'para summary category
        sql = "SELECT Code, CASE WHEN RequiredQuantity = 1 THEN DescSpanish + ' (+)' ELSE DescSpanish END  Type FROM dbo.CdMedicalSummaryType WHERE Active = 1  ORDER BY DescSpanish"
        bdCombo(sql, sTipoCombo, "Code", "Type")

        'para medList
        '"+ CASE WHEN  dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) IS NULL THEN '' ELSE ' #' + CAST(dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) AS Varchar(5))  END AS Medicine " + _
        sql = "SELECT Code, CASE WHEN DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + '(' + DosageDesc_es + ')') " + _
                 "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END AS Medicine " + _
                "FROM dbo.CdHealthInventoryItem WHERE Active = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, MedsCombo, "Code", "Medicine")

        'para LabReferences
        sql = "SELECT Examen_Tipo_ID Code, DescSpanish Lab FROM dbo.CdLabExamen_Type WHERE Active = 1 ORDER BY DescSpanish"
        bdCombo(sql, ExamenesCombo, "Code", "Lab")

        'para tratamientos
        sql = "SELECT Code, DescSpanish Treat FROM dbo.CdHealthTreatment WHERE FunctionalArea = 'CLIN' AND Active = 1 ORDER BY DescSpanish "
        bdCombo(sql, TratamientosCombo, "Code", "Treat")

        'para referencias internas
        sql = "SELECT Code, DescSpanish 'Categoria' FROM CdInternalReferenceCategory WHERE Active = 1 AND Project = '" + S + "' AND Program = 'MEDI' "
        bdCombo(sql, CategoriaTSCombo, "Code", "Categoria")
        bdCombo(sql, CategoriaPsicCombo, "Code", "Categoria")

        'para referencias externas
        sql = "SELECT Code, DescSpanish Place FROM dbo.CdHealthExternalReferencePlace WHERE Active = 1 AND Project IN('F', '*') AND Program = 'MEDI'"
        bdCombo(sql, ExternalPlaceV, "Code", "Place")

        sql = "SELECT Code, DescSpanish Razon FROM dbo.CdHealthExternalReferenceReason WHERE Active = 1 AND Program IN('MEDI', '****') "
        bdCombo(sql, ExternalReasonV, "Code", "Razon")

        ConsultaTab.Visible = True
    End Sub

    Private Sub llenarExMedsGrid()
        Dim a() As String = {"", ExMedicineV.Text, ExQuantityV.Text, ExtIndicationsV.Text}
        RecetasExtGrid.Rows.Add(a)

        Dim n As Integer = RecetasExtGrid.Rows.Count - 1
        For f = 0 To n
            RecetasExtGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
        Next
    End Sub

    Private Sub llenarExRefsGrid()
        Dim a() As String = {"", ExternalPlaceV.SelectedValue, ExternalPlaceV.Text, ExternalReasonV.SelectedValue, ExternalReasonV.Text, rpRefEV.Text}
        ReferenciaExtGrid.Rows.Add(a)
    End Sub

    Private Sub llenarLabsGrid()
        Dim hasSubLaboratory As Boolean = tieneSubLabs(ExamenesCombo.SelectedValue)

        Dim a() As String = {"", ExamenesCombo.SelectedValue, ExamenesCombo.Text, NotesV.Text, hasSubLaboratory.ToString, 0}
        ExamenesGrid.Rows.Add(a)
        ExamenesCombo.Focus()
    End Sub

    Private Sub llenarMedsGrid()
        Dim price, totalByMed, apr, normalPercentage As Double
        price = precioMed(MedsCombo.SelectedValue)
        If price < 0 Then
            price = 0
        End If

        normalPercentage = Double.Parse(normalPercentageV.Text)

        If normalPercentage < 0 Then
            normalPercentage = 0
        End If

        totalByMed = price * Convert.ToDouble(CantidadV.Text)
        apr = totalByMed * (normalPercentage / 100)

        Dim a() As String = {"", MedsCombo.SelectedValue, MedsCombo.Text, CantidadV.Text, InstrucV.Text, ObservacionesV.Text, price.ToString("F2"), totalByMed.ToString("F2"), apr.ToString("F2")}
        MedsGrid.Rows.Add(a)

        correlativosMeds()
    End Sub

    Private Sub llenarMedsGridConPrecio(ByVal precioS As String)
        Dim totalByMed, apr As Double
        Dim price As Double = 0.0
        Double.TryParse(precioS, price)

        totalByMed = price * Convert.ToDouble(CantidadV.Text)
        apr = totalByMed * (Double.Parse(normalPercentageV.Text) / 100)

        Dim a() As String = {"", MedsCombo.SelectedValue, MedsCombo.Text, CantidadV.Text, InstrucV.Text, ObservacionesV.Text, price.ToString("F2"), totalByMed.ToString("F2"), apr.ToString("F2")}
        MedsGrid.Rows.Add(a)

        correlativosMeds()
    End Sub

    Private Sub llenarSumaryList(ByVal fecha As String, ByVal tCod As String, ByVal tDesc As String, ByVal quant As String, ByVal notes As String)
        Dim a() As String = {fecha, tCod, tDesc, quant, notes}
        SumaryGrid.Rows.Add(a)
    End Sub

    Private Sub llenarTratsGrid()
        Dim a() As String = {"", TratamientosCombo.SelectedValue, TratamientosCombo.Text, ObserTratV.Text, CantidadTratV.Text, FechaTratPicker.Value.ToShortDateString}
        TratamientosGrid.Rows.Add(a)
        TratamientosCombo.Focus()
    End Sub

    Private Sub MasMedsBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasMedsBoton.Click
        If esValidaNuevaMedicina() = True Then
            If Mid(MedsCombo.SelectedValue, 3) = "00" Or Mid(MedsCombo.SelectedValue, 3) = "0" Then
                MsgBox("Esta seleccionando una categoria, no un medicamento", vbInformation, My.Resources.versionFamilias2)
            Else
                If existeEnListado(MedsCombo.SelectedValue, MedsGrid, 1) = True Then 'check if the med is not in the list
                    MsgBox("La medicina seleccionada ya existe en la receta", vbInformation, My.Resources.versionFamilias2)
                Else
                    If suficienteExistencia(MedsCombo.SelectedValue, CantidadV.Text, MedsCombo.Text) = True Then 'check actually quantity
                        If MedsCombo.SelectedValue = "OTRA" Then
                            llenarMedsGridConPrecio("0")
                            iMeds = iMeds + 1
                        Else
                            llenarMedsGrid()
                            iMeds = iMeds + 1
                        End If
                    End If
                End If
                MedsCombo.SelectedIndex = -1
                CantidadV.Text = ""
                InstrucV.Text = ""
                ObservacionesV.Text = ""
                MedsCombo.Focus()
            End If
        End If
    End Sub

    Private Sub MsGPay()
        If normalTotalV.Text = "0.00" Or normalTotalV.Text = "0" Or Double.Parse(normalPercentageV.Text) = 0 Then
            If MedsGrid.Rows.Count = 0 Then
                MSGv.Text = ""
            Else
                MSGv.Text = "El paciente puede pasar a Farmacia a recoger su medicina"
            End If
        Else
            If ExoneracionCheck.Checked = True Then
                MSGv.Text = "El paciente puede pasar a Farmacia a recoger su medicina"
            Else
                MSGv.Text = "El paciente necesita ir a CAJA a pagar: Q. " + normalTotalV.Text
            End If
        End If
        MSGv.Visible = True
    End Sub

    Private Sub NewExamButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewExamButton.Click
        If ExamenesCombo.Text = "" Or IsDBNull(ExamenesCombo.Text) Then
            MsgBox("Necesita seleccionar un examen", vbInformation, My.Resources.versionFamilias2)
        Else
            If esCitaLabValida() Then
                If existeEnListado(ExamenesCombo.SelectedValue, ExamenesGrid, 1) = True Then
                    MsgBox("El examen seleccionado ya existe", vbInformation, My.Resources.versionFamilias2)
                Else
                    llenarLabsGrid()
                    iLabs = iLabs + 1
                End If
                ExamenesCombo.SelectedIndex = -1
                NotesV.Text = ""
            End If
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        irAgenda()
    End Sub

    Private Function precioMed(ByVal code As String) As String
        sql = "SELECT Price FROM dbo.CdHealthInventoryItem WHERE code = '" + code + "' "
        precioMed = bdDoble(sql, "Price").ToString("F2")
    End Function

    Private Sub PresionV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PresionV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDiagonal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PesoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PesoV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles MedsGrid.RowsRemoved
        calculateTotalPrice()
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
                Else
                    suficienteExistencia = True
                End If
            End If
        End If
    End Function

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

    Private Sub SumaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumaryButton.Click
        If esValidaOpSum() = True Then
            llenarSumaryList(sFechaDateTimePicker.Value.ToShortDateString, sTipoCombo.SelectedValue, sTipoCombo.Text, "0", sObservacionesV.Text)
        End If
        sTipoCombo.SelectedIndex = -1
        sObservacionesV.Text = ""
        sFechaDateTimePicker.Focus()
    End Sub

    Private Sub TallaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TallaV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TempV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TempV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function tieneSubLabs(ByVal code As String) As Boolean
        Dim n As Integer
        sql = "SELECT COUNT(*) AS HasSubExam FROM dbo.CdLabSubExamen_Type cdT WHERE Examen_Tipo_ID = '" + code + "' "
        n = bdEntero(sql, "HasSubExam")
        If n = 0 Then
            tieneSubLabs = False
        Else
            tieneSubLabs = True
        End If
    End Function

    Private Sub TratamientosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TratamientosButton.Click
        If TratamientosCombo.Text = "" Or IsDBNull(TratamientosCombo.Text) Then
            MsgBox("Necesita seleccionar un tratamiento", vbInformation, My.Resources.versionFamilias2)
        Else
            If existeEnListado(TratamientosCombo.SelectedValue, TratamientosGrid, 1) = True Then
                MsgBox("El tratamiento seleccionado ya existe", vbInformation, My.Resources.versionFamilias2)
            Else
                llenarTratsGrid()
            End If

            TratamientosCombo.SelectedIndex = -1
            ObserTratV.Text = ""
            CantidadTratV.Text = ""
        End If
    End Sub

    Private Function turnoDisponibleEnf() As Boolean
        Dim actual As DateTime = DateTime.Now
        Dim N, turnos As Integer
        sql = "SELECT PropertyValue FROM dbo.FwApplicationProperty WHERE Category = 'ENFE' AND Name = 'TurnsByDay'"
        turnos = Integer.Parse(bdPalabra(sql, "PropertyValue"))

        sql = "SELECT dbo.fn_HEAL_ENFE_Pacientes('" + FechaTratPicker.Value.ToString(en.DateTimeFormat) + "') Pacientes "
        N = bdEntero(sql, "Pacientes")

        If N < turnos Then
            turnoDisponibleEnf = True
        Else
            turnoDisponibleEnf = False
            MsgBox("No hay turnos disponibles en Enfermería para la fecha indicada", vbInformation, My.Resources.versionFamilias2)
        End If
    End Function

    Private Function validaDatos() As Boolean
        If esConsultaValida() = True Then
            If esRecetaValida() = True And esCitaEnfermeriaValida() = True And esRefInternaValida() = True Then
                validaDatos = True
            Else
                validaDatos = False
            End If
        Else
            validaDatos = False
        End If
    End Function

    Private Sub valoresIniciales()
        AsignarPaciente()
        If Len(dr) > 0 Then
            infoGen()

            llenarCombos()
            ProblemaV.Focus()
            EvolPanel1.Visible = True
        End If
    End Sub


End Class