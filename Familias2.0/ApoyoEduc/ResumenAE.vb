' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ResumenAE
    Dim fechaOr As String
    Dim days As Integer = 180

    Private Sub ResumenAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()

        If Len(MiembroV.Text) > 0 Then
            valoresIniciales()
        Else
            PrincipalPanel.Visible = True
            MiembroV.Focus()
        End If
    End Sub

    Private Sub areasLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles areasLink.LinkClicked
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        Dim actual As DateTime = DateTime.Now
        sql = "SELECT Fecha, Actividad FROM fn_GEN_HistorialFamiliar('" + S + "', " + FamiliaV.Text + ", 'es', " + days.ToString + ", '" + actual.ToString(en.DateTimeFormat) + "') " + _
              "WHERE Fecha IS NOT NULL " + _
              "UNION ALL " + _
              "SELECT FECHA, Actividad FROM fn_GEN_HistorialIndividual('" + S + "', " + MiembroV.Text + ", 'es', " + days.ToString + ", '" + actual.ToString(en.DateTimeFormat) + "') " + _
              "WHERE Fecha IS NOT NULL AND Area NOT IN ('PSIC') "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()
        ListadoGrid.Visible = True
    End Sub

    Private Sub avisosFamiliares()
        If S = "E" Or S = "A" Then
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                ListadoGrid.DataSource = Nothing
                ListadoGrid.Rows.Clear()
                ListadoGrid.Visible = False
                sql = "SELECT Aviso FROM dbo.fn_WARN_avisosES('" + S + "', " + FamiliaV.Text + ") "
                bdGrid(sql, ListadoGrid)
                ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                ListadoGrid.AutoResizeColumns()
                ListadoGrid.Visible = True
            End If
        End If
    End Sub

    Private Sub AvisosLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AvisosLink.LinkClicked
        avisosFamiliares()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrarCita()
        sql = "UPDATE MemberHealthAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + ' (" + U + ")' " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND  CONVERT(nvarchar(50), CreationDateTime, 20) = '" + fechaOr + "' "
        bdEjecutarSQL(sql)
        historialCitas()
        idL.Text = "0"
        fechaOr = ""
    End Sub

    Private Sub CitaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CitaCheck.CheckedChanged
        If CitaCheck.Checked = True Then
            If tieneDerechosSalud(S, MiembroV.Text) = True Then
                valoresInicialesCita()
            Else
                MsgBox("El miembro no tiene derechos", vbExclamation, My.Resources.versionFamilias2)
            End If
        Else
            valoresInicialesCita()
            citaPanel.Visible = False
            GuardarButton.Visible = False
        End If
    End Sub

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

    Private Function fechaCita() As String
        Dim AmPm As String

        If Integer.Parse(HoraV.Text) < 7 Or Integer.Parse(HoraV.Text) > 11 Then
            AmPm = "PM"
        Else
            AmPm = "AM"
        End If

        fechaCita = "'" + DateP.Value.Month.ToString + "/" + DateP.Value.Day.ToString + "/" + DateP.Value.Year.ToString + " " + HoraV.Text + ":" + MinutosV.Text + ":00 " + AmPm + "'"
    End Function

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim asis As String = "NULL"
        If idL.Text = "0" Then 'NUEVA CITA
            If Len(TerapeutaCombo.Text) = 0 Or Len(ClinicaCombo.Text) = 0 Or Len(TipoCombo.Text) = 0 Or Len(HoraV.Text) = 0 Or Len(MinutosV.Text) = 0 Then
                MsgBox("Necesita llenar todos los campos con *", vbExclamation, My.Resources.versionFamilias2)
            Else
                If Len(AsistenciaCombo.Text) > 0 Then
                    asis = "'" + AsistenciaCombo.SelectedValue + "'"
                End If
                Dim fecha As String = unirFechaHoraMinuto(DateP.Value, HoraV.Text, MinutosV.Text)
                GuardarButton.Visible = False
                sql = "INSERT INTO dbo.MemberHealthAppointment VALUES (" + _
                      "'" + S + "', 'PSIC', " + MiembroV.Text + ", '" + fecha + "', GETDATE(), ' ', '" + U + "', " + _
                      "NULL, '" + ClinicaCombo.SelectedValue + "', '" + TerapeutaCombo.Text + "', '" + TipoCombo.SelectedValue + "', " + _
                      asis + ", NULL, '" + NotasV.Text + "')"
                bdInsertar(sql)
                limpiarCampos()
                historialCitas()

            End If
        ElseIf idL.Text = "1" Then 'MODIFICA CITA
            Dim msg As String = "¿Esta seguro de modificar la cita?"
            Dim title As String = "Apoyo Educativo"
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox(msg, style, title)
            If response = MsgBoxResult.Yes Then
                If Len(TerapeutaCombo.Text) = 0 Or Len(ClinicaCombo.Text) = 0 Or Len(TipoCombo.Text) = 0 Then
                    MsgBox("Necesita llenar todos los campos con *", vbExclamation, My.Resources.versionFamilias2)
                Else
                    If Len(AsistenciaCombo.Text) > 0 Then
                        asis = "'" + AsistenciaCombo.SelectedValue + "'"
                    End If

                    sql = "INSERT INTO dbo.MemberHealthAppointment " + _
                          "SELECT Project, FunctionalArea, MemberId, AppointmentDateTime, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, " + _
                          "'" + ClinicaCombo.SelectedValue + "', '" + TerapeutaCombo.Text + "', '" + TipoCombo.SelectedValue + "', " + _
                          asis + ", ConsultationDateTime, '" + NotasV.Text + "' " + _
                          "FROM dbo.MemberHealthAppointment " + _
                          "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND  CONVERT(nvarchar(50), CreationDateTime, 20) = '" + fechaOr + "' "
                    bdInsertar(sql)
                    sql = "UPDATE MemberHealthAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + ' (" + U + ")' " + _
                          "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND  CONVERT(nvarchar(50), CreationDateTime, 20) = '" + fechaOr + "' "
                    bdInsertar(sql)
                    historialCitas()
                    limpiarCampos()
                End If
            Else
                limpiarCampos()
            End If
        Else

        End If
    End Sub

    Private Sub HistoriaCitasGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HistoriaCitasGrid.CellContentClick
        Dim f, c As Integer
        c = HistoriaCitasGrid.CurrentCellAddress.X
        f = HistoriaCitasGrid.CurrentCellAddress.Y

        If c = 0 Then
            Dim msg As String = "¿Esta seguro de borrar la cita?"
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox(msg, style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                fechaOr = HistoriaCitasGrid.Item(2, f).Value()
                borrarCita()
                limpiarCampos()
            End If
        ElseIf c = 1 Then
            CitaCheck.Checked = True
            valoresInicialesCita()
            idL.Text = "1"
            fechaOr = HistoriaCitasGrid.Item(2, f).Value()
            DateP.Value = HistoriaCitasGrid.Item(3, f).Value()
            HoraV.Text = DateP.Value.Hour.ToString
            MinutosV.Text = DateP.Value.Minute.ToString
            TerapeutaCombo.Text = HistoriaCitasGrid.Item(5, f).Value()
            ClinicaCombo.Text = HistoriaCitasGrid.Item(4, f).Value()
            TipoCombo.Text = HistoriaCitasGrid.Item(6, f).Value()
            AsistenciaCombo.Text = chequearValor(HistoriaCitasGrid.Item(7, f).Value())
            NotasV.Text = chequearValor(HistoriaCitasGrid.Item(8, f).Value())
            CitaCheck.Text = "Modificar Cita"
            DateP.Enabled = False
            HoraV.Enabled = False
            MinutosV.Enabled = False

        Else

        End If
    End Sub

    Private Sub historialCitas()
        HistoriaCitasGrid.DataSource = Nothing
        HistoriaCitasGrid.Rows.Clear()
        'HistoriaCitasGrid.Visible = False

        sql = "SELECT CONVERT(nvarchar(50), MHA.CreationDateTime, 20) Creat, CONVERT(nvarchar(50), MHA.AppointmentDateTime, 20) AS Fecha, cdHC.DescSpanish AS Clínica, MHA.EmployeeId AS Terapeuta, " + _
              "cdHCT.DescSpanish AS Tipo, cdAA.DescSpanish AS Asistencia, MHA.Notes AS Notas " + _
              "FROM dbo.MemberHealthAppointment MHA LEFT OUTER JOIN dbo.CdHealthClinic cdHC ON MHA.HealthClinic = cdHC.Code " + _
              "LEFT OUTER JOIN dbo.CdHealthConsultationType cdHCT ON MHA.ConsultationType = cdHCT.Code " + _
              "LEFT OUTER JOIN dbo.CdAppointmentAttendance cdAA ON MHA.Attendance = cdAA.Code " + _
              "WHERE MHA.FunctionalArea = 'PSIC' AND MHA.RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
              "ORDER BY MHA.AppointmentDateTime DESC, MHA.HealthClinic, MHA.EmployeeId "
        bdGrid(sql, HistoriaCitasGrid)
        HistoriaCitasGrid.Columns.Item(0).Visible = True 'borrar
        HistoriaCitasGrid.Columns.Item(1).Visible = True 'modificar
        HistoriaCitasGrid.Columns.Item(2).Visible = False 'creat

        For i = 0 To HistoriaCitasGrid.Rows.Count - 1
            HistoriaCitasGrid.Item(0, i).Value = "Borrar"
            HistoriaCitasGrid.Item(1, i).Value = "Modificar"
        Next
        HistoriaCitasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistoriaCitasGrid.AutoResizeColumns()
        HistoriaCitasGrid.Visible = True
    End Sub

    Private Sub historialCitasPorClinicaAñoTera()
        HistoriaCitasGrid.DataSource = Nothing
        HistoriaCitasGrid.Rows.Clear()
        'HistoriaCitasGrid.Visible = False

        sql = "SELECT cdHC.DescSpanish AS Clínica, YEAR(MHA.CreationDateTime) Año, MHA.EmployeeId Terapeuta, COUNT(*) Total " + _
              "FROM dbo.MemberHealthAppointment MHA LEFT OUTER JOIN dbo.CdHealthClinic cdHC ON MHA.HealthClinic = cdHC.Code " + _
              "WHERE MHA.FunctionalArea = 'PSIC' AND MHA.RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
              "AND MHA.Attendance IN ('SI', 'TARD') " + _
              "GROUP BY cdHC.DescSpanish, YEAR(MHA.CreationDateTime), MHA.EmployeeId " + _
              "ORDER BY cdHC.DescSpanish, YEAR(MHA.CreationDateTime), MHA.EmployeeId "
        bdGrid(sql, HistoriaCitasGrid)
        HistoriaCitasGrid.Columns.Item(0).Visible = False 'borrar
        HistoriaCitasGrid.Columns.Item(1).Visible = False 'modificar
        HistoriaCitasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistoriaCitasGrid.AutoResizeColumns()
        HistoriaCitasGrid.Visible = True
    End Sub

    Private Sub HistorialCitasL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialCitasL.Click
        historialCitas()
    End Sub

    Private Sub HoraV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HoraV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
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
            nxt.transac = "NCIP"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarCampos()
        DateP.Enabled = True
        HoraV.Enabled = True
        MinutosV.Enabled = True
        DateP.Value = DateTime.Now
        HoraV.Text = ""
        MinutosV.Text = ""
        TerapeutaCombo.SelectedIndex = -1
        ClinicaCombo.SelectedIndex = -1
        TipoCombo.SelectedIndex = -1
        AsistenciaCombo.SelectedIndex = -1
        CitaCheck.Text = "Cita"
        NotasV.Text = ""
        idL.Text = "0"
        fechaOr = ""
        citaPanel.Visible = False
        CitaCheck.Checked = False
    End Sub

    Private Sub ListadoTelefonosL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ListadoTelefonosL.LinkClicked
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        sql = "SELECT * FROM dbo.fn_GEN_ListaTelefonosFamilia('" + S + "', " + FamiliaV.Text + ") L"
        bdGrid(sql, ListadoGrid)
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()
        ListadoGrid.Visible = True
        TableLayoutPanel1.Refresh()
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            valoresIniciales()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub MinutosV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MinutosV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevaCitaLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        If tieneDerechosSalud(S, MiembroV.Text) = True Then
            valoresInicialesCita()
        Else
            MsgBox("El miembro no tiene derechos", vbExclamation, My.Resources.versionFamilias2)
        End If

    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ResumenAE
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub RefMedicasButton_Click(sender As Object, e As EventArgs) Handles RefMedicasButton.Click
        Dim nxt As New ReferenciasMedicasAE
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub referenciaMedica()
        sql = " SELECT COUNT(*)  Ref FROM dbo.fn_HEAL_ReferenciasInternas('PSIC')  " + _
                 "WHERE  Miembro = " + MiembroV.Text + " AND Sitio = '" + S + "' AND Estado = 'Referencia' "
        If bdEntero(sql, "Ref") > 0 Then
            sql = " SELECT Nombres + ' tiene referencia médica' Ref " + _
                     "FROM dbo.fn_HEAL_ReferenciasInternas('PSIC')  " + _
                     "WHERE  Miembro = " + MiembroV.Text + " AND Sitio = '" + S + "' AND Estado = 'Referencia' "
            Dim referencia As String = chequearValor(bdPalabra(sql, "Ref"))
            MsgBox(referencia, vbExclamation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub referenciaMedicaEnProceso()
        sql = " SELECT COUNT(*)  Ref FROM dbo.fn_HEAL_ReferenciasInternas('PSIC')  " + _
                 "WHERE  Miembro = " + MiembroV.Text + " AND Sitio = '" + S + "' AND Estado = 'En proceso' "
        If bdEntero(sql, "Ref") > 0 Then
            sql = " SELECT 'Tiene referencia médica: ' + estado  Ref " + _
                     "FROM dbo.fn_HEAL_ReferenciasInternas('PSIC')  " + _
                     "WHERE  Miembro = " + MiembroV.Text + " AND Sitio = '" + S + "' AND Estado = 'En proceso' "
            Dim referencia As String = chequearValor(bdPalabra(sql, "Ref"))
            ReferenciaV.Text = referencia
        Else
            ReferenciaV.Text = ""
        End If
    End Sub

    Private Sub resumenL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resumenL.Click
        historialCitasPorClinicaAñoTera()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT COUNT(*) Total FROM Member WHERE RecordStatus = ' ' AND Project = '" + S + "'"
        Dim n As Integer = bdEntero(sql, "Total")

        If n > 0 Then
            Dim ahora As DateTime = DateTime.Now
            Dim listTable As New DataTable
            sql = "SELECT Nombres, Apellidos, Edad, EstadoAfil, semaforo, Estado_Educ, Grado, Año, Familia, clasificación, TS,  Region, dbo.fn_GEN_tipoMiembro('" + S + "', " + MiembroV.Text + ") TipoMiembro " + _
                     "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + ahora.Year.ToString + ") L "
            bdDataTable(sql, listTable)

            If listTable.Rows.Count > 0 Then
                NombreV.Text = chequearValor(listTable.Rows(0)("Nombres")) + " " + chequearValor(listTable.Rows(0)("Apellidos"))
                EdadV.Text = " - " + chequearValor(listTable.Rows(0)("Edad"))
                FamiliaV.Text = chequearValor(listTable.Rows(0)("Familia"))
                ClasificacionV.Text = chequearValor(listTable.Rows(0)("clasificación"))
                TSV.Text = chequearValor(listTable.Rows(0)("TS"))
                RegionV.Text = chequearValor(listTable.Rows(0)("Region"))
                tipoMV.Text = chequearValor(listTable.Rows(0)("TipoMiembro"))
                Dim color As String = chequearValor(listTable.Rows(0)("semaforo"))

                If Len(color) > 0 Then
                    semaforo(color, SemaforoV)
                    semaforoL.Text = "Semáforo:"
                    semaforoL.Visible = True
                End If

                If Len(chequearValor(listTable.Rows(0)("Grado"))) > 0 Then
                    GradoV.Text = chequearValor(listTable.Rows(0)("Estado_Educ")) + " " + chequearValor(listTable.Rows(0)("Grado")) + " (" + chequearValor(listTable.Rows(0)("Año")) + ")"
                    GradoV.Visible = True
                    GradoL.Visible = True
                End If

                referenciaMedica()
                referenciaMedicaEnProceso()
                historialCitas()
                avisosFamiliares()
                CitaCheck.Focus()

                MiembroV.ReadOnly = True
                FamiliaV.ReadOnly = True
                PanelSecundario.Visible = True
                ListadoTelefonosL.Visible = True
                CitaCheck.Visible = True
                AvisosLink.Visible = True
                areasLink.Visible = True
                HistorialCitasL.Visible = True
                resumenL.Visible = True

                sql = "SELECT EmployeeId FROM dbo.FwEmployeeRole WHERE Role = 'TERA' AND Status = 'ACTV' AND Organization = '" + S + "' "
                bdComboSinCodigo(sql, TerapeutaCombo)

                sql = "SELECT Code, DescSpanish AS Clinica FROM dbo.CdHealthClinic WHERE FunctionalArea = 'PSIC' AND Active = 1 "
                bdCombo(sql, ClinicaCombo, "Code", "Clinica")

                sql = "SELECT Code,  DescSpanish 'Tipo' FROM CdHealthConsultationType WHERE FunctionalArea = '****' ORDER BY DescSpanish DESC"
                bdCombo(sql, TipoCombo, "Code", "Tipo")

                sql = "SELECT Code, DescSpanish 'Asistencia' FROM dbo.CdAppointmentAttendance WHERE ValidSelection = 1 "
                bdCombo(sql, AsistenciaCombo, "Code", "Asistencia")
                FamiliaV.Focus()
            End If
        Else
            MsgBox("El miembro no existe", vbExclamation, My.Resources.versionFamilias2)
            MiembroV.Text = ""
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub valoresInicialesCita()
        citaPanel.Visible = True
        GuardarButton.Visible = True

        HoraV.Text = ""
        MinutosV.Text = ""
        DateP.Enabled = True
        HoraV.Enabled = True
        MinutosV.Enabled = True
        DateP.Value = Now
        TerapeutaCombo.Text = ""
        ClinicaCombo.SelectedIndex = -1
        AsistenciaCombo.SelectedIndex = -1
        TipoCombo.SelectedIndex = -1
        NotasV.Text = ""
    End Sub

End Class