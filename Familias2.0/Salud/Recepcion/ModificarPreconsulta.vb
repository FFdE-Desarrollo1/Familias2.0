' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ModificarPreconsulta
    Public IDApp As Integer
    Public pre As String

    Dim clinic, AmPm, AmPmOr, estadoOr, clinicOr, medi As String
    Dim turno, turnoOr, edad, hora As Integer
    Dim verComboDr As Boolean = False

    Private Sub ModificarPreconsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        PacienteV.Focus()
        valoresIniciales()
    End Sub

    Private Sub AgendaCheck_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AgendaCheck.LinkClicked
        appointmentsList(DateP.Value)
    End Sub

    Private Sub appointmentsList(ByVal DateSelec As String)
        AgendaGrid.DataSource = Nothing
        Dim dateS As Date
        Dim site, medico As String
        dateS = DateSelec

        If S = "E" Or S = "F" Or S = "S" Or S = "A" Then
            site = "MHA.Project IN ('E', 'F', 'S', 'A') "
        Else
            site = "MHA.Project = '" + S + "'"
        End If

        If Len(DoctorC.Text) = 0 Then
            medico = ""
        Else
            medico = " AND MHA.EmployeeId = '" + DoctorC.Text + "'"
        End If

        sql = "SELECT MHA.AMorPM AM_PM, MHA.Turn AS Turno, M.MemberId AS 'No. Paciente', M.FirstNames + ' ' + M.LastNames AS Nombre, M.LastFamilyId AS 'No. Familia', cdAS.DescSpanish AS Estado, " + _
              "CAST({ fn HOUR(MHA.AppointmentDateTime) } AS varchar(5)) + ':' + CASE WHEN CAST({ fn MINUTE(AppointmentDateTime) } AS varchar(5))  = '0' THEN '00' " + _
              "ELSE CAST({ fn MINUTE(AppointmentDateTime) } AS varchar(5)) END AS Horario " + _
              "FROM dbo.MemberClinicAppointment MHA " + _
              "INNER JOIN dbo.Member M ON MHA.Project = M.Project AND MHA.MemberId = M.MemberId AND MHA.RecordStatus = M.RecordStatus " + _
              "LEFT JOIN MemberClinicConsultation MCC ON MCC.AppId = MHA.AppId AND MCC.RecordStatus = MHA.RecordStatus " + _
              "LEFT JOIN dbo.CdAppointmentStatus cdAS ON MHA.Status = cdAS.Code " + _
              "WHERE MHA.RecordStatus = ' ' AND " + site + " AND YEAR(MHA.AppointmentDateTime) = " + dateS.Year.ToString + _
              " AND MONTH(MHA.AppointmentDateTime) = " + dateS.Month.ToString + " AND DAY(MHA.AppointmentDateTime) = " + dateS.Day.ToString + _
              medico + " AND MCC.IdConsultation IS NULL  AND MHA.Status NOT IN ('NOAS') " + _
              "ORDER BY MHA.AMorPM DESC, turn DESC, MHA.AppointmentDateTime "
        bdGrid(sql, AgendaGrid)
        AgendaGrid.Visible = True

        Dim n As Integer = AgendaGrid.Rows.Count - 1
        For f = 0 To n
            AgendaGrid.Rows(f).HeaderCell.Value = f + 1
        Next
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
        sql = "SELECT COUNT(*) AS Total FROM dbo.MemberHealthAppointment WHERE RecordStatus = ' '  AND Project = '" + S + "' AND Memberid = " + PacienteV.Text +
              " AND YEAR(AppointmentDateTime) = " + DateP.Value.Year.ToString + " AND MONTH(AppointmentDateTime) = " + DateP.Value.Month.ToString + " AND DAY(AppointmentDateTime) = " + DateP.Value.Day.ToString + " "
        N = bdEntero(sql, "Total")
        If N > 0 Then
            existeCita = True
        Else
            existeCita = False
        End If
    End Function

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
                        guardarPreconsulta()
                    End If
                Else
                    guardarPreconsulta()
                End If
            Else
                guardarPreconsulta()
            End If
        End If
    End Sub

    Private Sub guardarPreconsulta()
        Dim idClinic As String = ClinicC.SelectedValue
        Dim idType As String = TypeC.SelectedValue
        Dim idStatus As String = StatusC.SelectedValue
        If turnoOr > 0 Then
            turno = turnoOr
            AmPm = "'" + AmPmOr + "'"
        Else
            turno = medi_ProximoTurno(idStatus, DateP.Value)
            If turno > 0 Then
                AmPm = "'" + medi_AMorPM(DateP.Value) + "'"
            Else
                AmPm = "NULL"
            End If
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

    Private Sub infoGen()
        Dim listTable As New DataTable
        sql = "SELECT MCA.*, cdS.DescSpanish AS Stat, cdC.DescSpanish AS Clin, cdT.DescSpanish AS Typ, M.LastFamilyId AS Familia, M.FirstNames + ' ' + M.LastNames AS Nombre, dbo.fn_GEN_CalcularEdad(BirthDate) AS Edad  " + _
                "FROM dbo.MemberClinicAppointment MCA INNER JOIN dbo.CdAppointmentStatus cdS ON MCA.Status = cdS.Code " +
                "INNER JOIN dbo.CdHealthClinic cdC ON MCA.HealthClinic = cdC.Code INNER JOIN dbo.CdHealthConsultationType cdT ON MCA.ConsultationType = cdT.Code " + _
                "INNER JOIN dbo.Member M ON MCA.Project = M.Project AND MCA.MemberId = M.MemberId AND MCA.RecordStatus = M.RecordStatus " + _
                "WHERE MCA.RecordStatus = ' ' AND MCA.AppId = " + IDApp.ToString + ""
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            NombreV.Text = listTable.Rows(f)("Nombre")
            'edad =
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad")) '+ " año(s)"
            FamiliaV.Text = listTable.Rows(f)("Familia").ToString
            PacienteV.Text = listTable.Rows(f)("MemberId").ToString
            StatusC.Text = listTable.Rows(f)("Stat")
            medi = chequearValor(listTable.Rows(f)("EmployeeId"))
            DoctorC.Text = medi
            clinicOr = listTable.Rows(f)("Clin")
            ClinicC.Text = clinicOr
            TypeC.Text = listTable.Rows(f)("Typ")
            TempV.Text = chequearValor(listTable.Rows(f)("Temperature"))
            PesoV.Text = chequearValor(listTable.Rows(f)("Weight"))
            TallaV.Text = chequearValor(listTable.Rows(f)("Stature"))
            PresionV.Text = chequearValor(listTable.Rows(f)("BloodPressure"))
            FrecCarV.Text = chequearValor(listTable.Rows(f)("HeartRate"))
            FrecResV.Text = chequearValor(listTable.Rows(f)("RespiratoryRate"))
            NotasV.Text = chequearValor(listTable.Rows(f)("Notes"))
            turnoOr = chequearValor(listTable.Rows(f)("Turn"))
            AmPmOr = chequearValor(listTable.Rows(f)("AMorPM"))
            DateP.Value = listTable.Rows(f)("AppointmentDateTime")
            estadoOr = StatusC.Text
            avisosFamiliares()

            Dim colaboracion As String = bdPalabra("SELECT dbo.fn_SALU_ColaboracionPorServicios('" + S + "', " + PacienteV.Text + ") C ", "C")
            If colaboracion = "0.00" Then
                ColaboracionL.Visible = False
            Else
                ColaboracionL.Text = "Colaboración: Q" + colaboracion
                ColaboracionL.Visible = True
            End If
        Next

    End Sub

    Private Sub ingresarNuevaCita(ByVal clinic As String, _
                                   ByVal type As String, _
                                   ByVal status As String)
        GuardarButton.Visible = False

        Dim area = "CLIN"
        Dim appDateTime As DateTime = DateP.Value
        Dim medico As String

        If Len(medi) > 0 Then
            medico = "'" + medi + "'"
        ElseIf Len(DoctorC.Text) = 0 Or verComboDr = False Then
            medico = "NULL"
        Else
            medico = "'" + DoctorC.Text + "'"
        End If

        sql = "INSERT INTO dbo.MemberClinicAppointment " + _
              "SELECT AppId, GETDATE(), Project, MemberId, '" + appDateTime.ToString(en.DateTimeFormat) + "', RecordStatus, '" + U + "', ExpirationDateTime, '" + clinic + "', " + medico + ", " + _
                      "'" + type + "', '" + status + "', " + turno.ToString + ", " + AmPm + ",'" + TempV.Text + "', '" + PesoV.Text + "', '" + TallaV.Text + "', '" + PresionV.Text + "', '" + FrecCarV.Text + _
                      "', '" + FrecResV.Text + "', '" + Replace(NotasV.Text, "'", "''") + "',  " + "IdConsultationReference " + _
              "FROM dbo.MemberClinicAppointment WHERE RecordStatus = ' ' AND AppId = " + IDApp.ToString
        bdInsertar(sql)
        TableLayoutPanel1.Visible = False
        InfoCitaL.Visible = False
        appointmentsList(DateP.Value)

        nuevoRegresar()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub nuevoRegresar()
        If pre = "RCIM" Then
            Dim nxt As New RevisarPreconsultas
            nxt.PacienteV.Text = PacienteV.Text
            nxt.Show()
            Me.Close()
        Else
            Dim nxt As New AgendaMedica
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        nuevoRegresar()
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

    Private Sub valoresIniciales()
        sql = "SELECT Code,  " + descripcion() + " d FROM dbo.CdAppointmentStatus WHERE Active = 1 "
        bdCombo(sql, StatusC, "Code", "d")

        sql = "SELECT Code, " + descripcion() + " d FROM dbo.CdHealthClinic WHERE Active = 1 AND FunctionalArea = 'CLIN' "
        bdCombo(sql, ClinicC, "Code", "d")

        If S = "E" Or S = "A" Then
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization IN('" + S + "', 'F') "
        Else
            sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization = '" + S + "' "
        End If
        bdComboSinCodigo(sql, DoctorC)

        sql = "SELECT Code, " + descripcion() + " d FROM CdHealthConsultationType ORDER BY " + descripcion() + " "
        bdCombo(sql, TypeC, "Code", "d")

        sql = "SELECT Code, " + descripcion() + " d FROM CdAppointmentStatus WHERE Active = 1 "
        bdCombo(sql, StatusC, "Code", "d")

        infoGen()
        colaboracion()
        Panel3.Visible = True
        PacienteV.Enabled = False
        FamiliaV.Enabled = False
        TempV.Focus()
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

    Private Function verificaTurnosPreconsulta() As Boolean
        Dim dif As Integer = DateDiff(DateInterval.Day, DateTime.Now, DateP.Value)
        If turnoOr > 0 Then
            verificaTurnosPreconsulta = True
        Else
            If dif < 0 Then
                verificaTurnosPreconsulta = False
                MsgBox("No puede ingresar preconsultas o citas antiguas a la fecha actual", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            Else
                verificaTurnosPreconsulta = True
            End If
        End If
    End Function




End Class