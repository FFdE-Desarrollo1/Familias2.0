' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class Preconsulta
    Dim desc, clinic, AmPm As String
    Dim memberId, familyId, turno, edad, hora As Integer
    Dim difDias As Integer = 1
    Dim verComboDr As Boolean = False

    Private Sub Preconsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()
        If Len(PacienteV.Text) > 0 Then
            validaPaciente()
        ElseIf (S = "E" Or S = "A") And Len(PacienteV.Text) = 0 Then
            Dim emp As New BusquedaEmpleado
            emp.TransL.Text = "CM"
            emp.Show()
            Me.Close()
        Else
            PrincipalPanel.Visible = True
        End If
    End Sub

    Private Sub AgendaButton_Click(sender As Object, e As EventArgs) Handles AgendaButton.Click
        Dim nxt As New AgendaMedica
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub AgendaCheck_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AgendaCheck.LinkClicked
        appointmentsList(DateP.Value)
    End Sub

    Private Sub appointmentsList(ByVal DateSelec As String)
        sql = ""
        AgendaGrid.DataSource = Nothing

        Dim dateS As Date
        Dim site, medico As String
        dateS = DateSelec

        If S = "E" Or S = "F" Or S = "S" Or S = "A" Then
            site = "MHA.Project IN('E', 'F', 'S', 'A') "
        Else
            site = "MHA.Project = '" + S + "'"
        End If

        If Len(DoctorC.Text) = 0 Then
            medico = ""
        Else
            medico = " AND MHA.EmployeeId = '" + DoctorC.Text + "'"
        End If
        'AND MHA.IdConsultation IS NULL 
        sql = "SELECT MHA.AMorPM AM_PM, MHA.Turn AS Turno, M.MemberId AS 'Paciente', M.FirstNames + ' ' + M.LastNames AS Nombre, M.LastFamilyId AS 'Familia', cdAS.DescSpanish AS Estado, " + _
              "CAST({ fn HOUR(MHA.AppointmentDateTime) } AS varchar(5)) + ':' + CASE WHEN CAST({ fn MINUTE(AppointmentDateTime) } AS varchar(5))  = '0' THEN '00' " + _
              "ELSE CAST({ fn MINUTE(AppointmentDateTime) } AS varchar(5)) END AS Horario, " + _
              "CASE WHEN (SELECT     COUNT(*) AS Total FROM         dbo.MemberClinicConsultation MC " + _
                "WHERE  RecordStatus = ' ' AND MC.AppId = MHA.AppId AND MC.RecordStatus = MHA.RecordStatus)= 0 THEN 'No' ELSE 'Si' END Consulta " + _
              "FROM dbo.MemberClinicAppointment MHA INNER JOIN dbo.Member M ON MHA.Project = M.Project AND MHA.MemberId = M.MemberId AND MHA.RecordStatus = M.RecordStatus " + _
              "LEFT JOIN dbo.CdAppointmentStatus cdAS ON MHA.Status = cdAS.Code " + _
              "WHERE MHA.RecordStatus = ' ' AND " + site + " AND YEAR(MHA.AppointmentDateTime) = " + dateS.Year.ToString + _
              " AND MONTH(MHA.AppointmentDateTime) = " + dateS.Month.ToString + " AND DAY(MHA.AppointmentDateTime) = " + dateS.Day.ToString + _
               medico + "  " + _
              "ORDER BY MHA.AMorPM DESC, turn DESC, MHA.AppointmentDateTime "
        bdGrid(sql, AgendaGrid)
        AgendaGrid.Visible = True

        Dim n As Integer = AgendaGrid.Rows.Count - 1
        For f = 0 To n
            AgendaGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
        Next
        AgendaGrid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
    End Sub

    Private Sub asignaClinica()
        Try
            Dim edad As Integer = edadInt(PacienteV.Text)
            If edad > 0 And edad < 12 Then
                ClinicC.SelectedValue = "EXTN"
            ElseIf edad >= 12 And edad < 18 Then
                ClinicC.SelectedValue = "ADOL"
            ElseIf edad >= 18 Then
                ClinicC.SelectedValue = "EXTA"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: " & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Function asignarId() As Integer
        sql = "SELECT MAX(AppId) AS Ultimo FROM  dbo.MemberClinicAppointment "
        asignarId = bdEntero(sql, "Ultimo") + 1
    End Function

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
                End If
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub colaboracion()
        Dim col As String = bdPalabra("SELECT dbo.fn_SALU_ColaboracionPorServicios('" + S + "', " + PacienteV.Text + ") C ", "C")
        If col = "0.00" Then
            ColaboracionL.Visible = False
        Else
            sql = "SELECT Price FROM CdHealthConsultationType WHERE Code = '" + CodTipo.Text + "'"
            Dim dona As Integer = bdEntero(sql, "Price")
            'If IsDBNull(dona) = True Then
            '    MsgBox(dona)
            'End If

            If dona = 0 Then
                ColaboracionL.Visible = False
            Else
                ColaboracionL.Text = "Colaboración: Q" + col
                ColaboracionL.Visible = True
            End If
        End If
    End Sub

    Private Function existeCita() As Boolean
        Dim N As Integer
        sql = "SELECT COUNT(*) AS Total FROM dbo.MemberClinicAppointment WHERE RecordStatus = ' '  AND Project = '" + S + "' AND Memberid = " + memberId.ToString +
              " AND YEAR(AppointmentDateTime) = " + DateP.Value.Year.ToString + " AND MONTH(AppointmentDateTime) = " + DateP.Value.Month.ToString + " AND DAY(AppointmentDateTime) = " + DateP.Value.Day.ToString + " "
        N = bdEntero(sql, "Total")
        If N > 0 Then
            existeCita = True
        Else
            existeCita = False
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

    Private Sub FrecCarV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FrecCarV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrecResV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FrecResV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If validacion() = True Then
            If Len(TallaV.Text) > 0 Then
                If Double.Parse(TallaV.Text) > 3 Then
                    Dim style As MsgBoxStyle
                    Dim response As MsgBoxResult
                    style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                    appointmentsList(DateP.Value)
                    response = MsgBox("La talla debe ser en metros. Ej. 1.10, 0.50, etc." + Chr(13) +
                                      "Si deja incorrecta la talla puede afectar el resultado del IMC " + Chr(13) +
                                      "¿Quiere ingresar la nueva cita? ", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        saveApp()
                    End If
                Else
                    saveApp()
                End If
            Else
                saveApp()
            End If
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
            nxt.transac = "NCM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable
        sql = "SELECT FirstNames + ' ' +  LastNames As CompleteName, dbo.fn_GEN_CalcularEdad(BirthDate) AS Edad, LastFamilyId Familia FROM  dbo.Member M " + _
                                   "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            NombreV.Text = listTable.Rows(f)("CompleteName") 'conn.Word(sql, "CompleteName")
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad")) '+ " año(s)"
            FamiliaV.Text = listTable.Rows(f)("Familia") 'conn.Word(sql, "Familia")
        Next


    End Sub

    Private Sub infoInicial()
        PrincipalPanel.Visible = True
        PanelSecundario.Visible = True
        memberId = Integer.Parse(PacienteV.Text)
        clinic = "CLIN"
        DateP.Focus()
        sql = "SELECT Code, " + descripcion() + " 'Clinica' FROM dbo.CdHealthClinic WHERE Active = 1 AND FunctionalArea = 'CLIN' "
        bdCombo(sql, ClinicC, "Code", "Clinica")

        If S = "E" Or S = "A" Then
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization IN('" + S + "', 'F')  GROUP BY EmployeeId "
            bdComboSinCodigo(sql, DoctorC)
        Else
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization = '" + S + "' GROUP BY EmployeeId  "
            bdComboSinCodigo(sql, DoctorC)
        End If

        sql = "SELECT Code,  DescSpanish 'Tipo' FROM CdHealthConsultationType ORDER BY DescSpanish "
        bdCombo(sql, TypeC, "Code", "Tipo")
        'TypeC.SelectedValue = "RECO"

        sql = "SELECT Code, DescSpanish 'Estado' FROM CdAppointmentStatus WHERE Active = 1 "
        bdCombo(sql, StatusC, "Code", "Estado")

        StatusC.Text = "Pendiente datos Pre-consulta"
        infoGen()
        asignaClinica()
        avisosFamiliares()
        Panel3.Visible = True
        GuardarButton.Visible = True
        PacienteV.Enabled = False
        FamiliaV.Enabled = False
        NotasV.Focus()
    End Sub

    Private Sub ingresarNuevaCita(ByVal clinic As String, _
                                  ByVal type As String, _
                                  ByVal status As String)
        Dim area = "CLIN"
        Dim medico As String
        If Len(DoctorC.Text) = 0 Then
            medico = "NULL"
        Else
            medico = "'" + DoctorC.Text + "'"
        End If
        Dim appDateTime As DateTime = DateP.Value
        sql = "INSERT INTO dbo.MemberClinicAppointment (AppId, CreationDateTime, Project, MemberId, AppointmentDateTime, RecordStatus, UserId, ExpirationDateTime, HealthClinic, EmployeeId, " + _
              "ConsultationType, status, Turn, AMorPM, Temperature, Weight, Stature, BloodPressure, HeartRate, RespiratoryRate,  Notes, IdConsultationReference) " + _
              "VALUES (" + asignarId.ToString + ", GETDATE(), '" + S + "', " + memberId.ToString + ", '" + appDateTime.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, '" + clinic + "', " + medico + ", " + _
              "'" + type + "', '" + status + "', " + turno.ToString + ", " + AmPm + ",'" + TempV.Text + "', '" + PesoV.Text + "', '" + TallaV.Text + "', '" + PresionV.Text + "', '" + FrecCarV.Text + "', '" + FrecResV.Text + "', '" + Replace(NotasV.Text, "'", "''") + "', NULL)"
        bdInsertar(sql)

        GuardarButton.Visible = False
        TableLayoutPanel1.Visible = False
        InfoCitaL.Visible = False
        appointmentsList(DateP.Value)
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New Preconsulta
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PacienteV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PacienteV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            validaPaciente()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
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

    Private Sub PresionV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PresionV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDiagonal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub saveApp()
        Dim idClinic As String = ClinicC.SelectedValue
        Dim idType As String = TypeC.SelectedValue
        Dim idStatus As String = StatusC.SelectedValue
        turno = medi_ProximoTurno(idStatus, DateP.Value)
        If turno > 0 Then
            AmPm = "'" + medi_AMorPM(DateP.Value) + "'"
        Else
            AmPm = "NULL"
        End If

        If existeCita() = True Then
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            appointmentsList(DateP.Value)
            response = MsgBox("Ya existe una cita para este paciente en esta fecha " + Chr(13) +
                              "¿Quiere ingresar una nueva cita? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                ingresarNuevaCita(idClinic, idType, idStatus)
            End If
        Else
            ingresarNuevaCita(idClinic, idType, idStatus)
        End If
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

    Private Sub TypeC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeC.SelectedIndexChanged
        If Len(FamiliaV.Text) = 0 Then
            CodTipo.Text = "NO"
        Else
            CodTipo.Text = TypeC.SelectedValue
            colaboracion()
        End If
    End Sub

    Private Function validacion() As Boolean
        verComboMedicos()
        If verComboDr = True And (DoctorC.Text = "" Or DoctorC.Text = " ") Then
            MsgBox("Necesita seleccionar un médico", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            validacion = False
        ElseIf verificaTurnosPreconsulta() = False Then
            validacion = False
        ElseIf (ClinicC.Text = "" Or ClinicC.Text = " ") And ClinicC.SelectedIndex = -1 Then
            MsgBox("Necesita seleccionar la clínica", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            validacion = False
        ElseIf (TypeC.Text = "" Or TypeC.Text = " ") And TypeC.SelectedIndex = -1 Then
            MsgBox("Necesita el tipo de consulta", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            validacion = False
        ElseIf (StatusC.Text = "" Or StatusC.Text = " ") And StatusC.SelectedIndex = -1 Then
            MsgBox("Necesita el estado de la consulta", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            validacion = False
        ElseIf StatusC.Text = "Completa" Then
            If Len(PesoV.Text) = 0 Or Len(TallaV.Text) = 0 Then
                MsgBox("Necesita Peso y Talla", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                validacion = False
            ElseIf ClinicC.Text = "Nutrición" Then
                If Len(PesoV.Text) = 0 Or Len(TallaV.Text) = 0 Then
                    MsgBox("Necesita Peso y Talla", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                    validacion = False
                Else
                    validacion = True
                End If
            Else
                If edad < 14 Then
                    If Len(PesoV.Text) = 0 Or Len(TallaV.Text) = 0 Or Len(TempV.Text) = 0 Then
                        MsgBox("Necesita Temperatura, Talla y Peso", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                        validacion = False
                    Else
                        validacion = True
                    End If
                Else
                    If Len(PresionV.Text) = 0 Or Len(FrecCarV.Text) = 0 Or Len(FrecResV.Text) = 0 Or Len(TempV.Text) = 0 Then
                        MsgBox("Necesita Temperatura, Presión y Frecuencias", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                        validacion = False
                    Else
                        validacion = True
                    End If
                End If
            End If
        Else
            validacion = True
        End If
    End Function

    Private Sub validaPaciente()
        If miembroEsValido(S, PacienteV.Text) = True Then
            If tieneDerechosSalud(S, PacienteV.Text) = True Then
                sql = "SELECT LastFamilyId as Familia FROM dbo.Member M WHERE RecordStatus= ' '  AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
                familyId = bdEntero(sql, "Familia")
                If familiaEsValida(S, familyId) Then
                    infoInicial()
                    FamiliaV.Enabled = False
                    PacienteV.Enabled = False
                Else
                    MsgBox("La familia no existe", vbQuestion, My.Resources.versionFamilias2)
                    PacienteV.Text = ""
                End If
            Else
                MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
                PacienteV.Text = ""
                FamiliaV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            PacienteV.Text = ""
        End If
    End Sub

    Private Sub verComboMedicos()
        sql = "SELECT dbo.fn_HEAL_ExternalPhysician('" + ClinicC.SelectedValue + "') R"
        If bdEntero(sql, "R") > 0 Then
            DoctorC.Visible = True
            DoctorL.Visible = True
            verComboDr = True
        Else
            verComboDr = False
            DoctorC.Text = ""
            DoctorC.Visible = False
            DoctorL.Visible = False
        End If
    End Sub

    Private Function verificarDiferenciaFechas() As Boolean
        Dim dif As Integer = DateDiff(DateInterval.Day, DateP.Value, DateTime.Now)

        If dif > difDias Then
            verificarDiferenciaFechas = False
            MsgBox("La fecha no puede exceder a " + difDias.ToString + " dia(s). La diferencia es: " + dif.ToString + " día(s)", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
        Else
            verificarDiferenciaFechas = True
        End If
    End Function

    Private Function verificaTurnosPreconsulta() As Boolean
        Dim dif As Integer = DateDiff(DateInterval.Day, DateTime.Now, DateP.Value)

        If dif < 0 Then
            verificaTurnosPreconsulta = False
            MsgBox("No puede ingresar preconsultas o citas antiguas a la fecha actual", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
        Else
            verificaTurnosPreconsulta = True
        End If
    End Function




End Class