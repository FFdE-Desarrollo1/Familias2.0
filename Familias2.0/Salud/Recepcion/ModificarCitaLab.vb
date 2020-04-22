' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ModificarCitaLab
    Public sMember As String
    Public IDApp As Integer

    Dim listTable As New DataTable
    Dim IdConsul, total, estadoOr As String
    Dim turnoOr As Integer

    Private Sub ModificarCitaLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        PacienteV.Focus()
        valoresIniciales()
    End Sub

    Private Sub actualizarLab()
        Dim turn As String
        If turnoOr > 0 Then
            turn = turnoOr 'proximoTurno.ToString
        Else
            If StatusC.SelectedValue = "NOAS" Or StatusC.SelectedValue = "REFE" Then
                turn = "0"
            Else
                turn = proximoTurno.ToString
            End If
        End If

        sql = "SELECT Code FROM dbo.CdAppointmentStatus WHERE DescSpanish = '" + StatusC.Text + "' "
        Dim idStatus As String = bdPalabra(sql, "Code")
        'IdAppLab, CreationDateTime, Project, MemberId, UserId, ExpirationDateTime, ReferenceDate, IdConsultation, StatusApp, Turn, 
        'DrReferred, PendPay, RecordStatus, TotalNormalPrice, emergency
        sql = "INSERT INTO dbo.MemberHealthLabAppointment " + _
                 "SELECT IdAppLab, GETDATE(), Project, MemberId, UserId, ExpirationDateTime, '" + DateP.Value.ToString(en.DateTimeFormat) + "', IdConsultation, " + _
                 "'" + StatusC.SelectedValue + "', " + turn + ", DrReferred, PendPay, RecordStatus, TotalNormalPrice, Emergency " + _
                 "FROM dbo.MemberHealthLabAppointment " + _
                 "WHERE RecordStatus = ' ' AND IdAppLab = " + IDApp.ToString
        bdInsertar(sql)
    End Sub

    Private Sub agenda()
        sql = "SELECT MHL.Turn AS Turno, M.FirstNames + ' ' + M.LastNames AS Nombre, M.MemberId AS 'Paciente', MHL.DrReferred AS Refirió, " + _
                "M.Project AS Sitio, cdAS.DescSpanish Estado, M.LastFamilyId Familia " + _
            "FROM dbo.MemberHealthLabAppointment MHL INNER JOIN dbo.Member M ON MHL.Project = M.Project AND MHL.MemberId = M.MemberId AND MHL.RecordStatus = M.RecordStatus " + _
                "INNER JOIN dbo.MemberHealthLabExam EXA ON MHL.IdAppLab = EXA.IdAppLab AND MHL.RecordStatus = EXA.RecordStatus " + _
                "LEFT JOIN dbo.MemberHealthLabResult RES ON EXA.Examen_ID = RES.Examen_ID AND EXA.RecordStatus = RES.RecordStatus " + _
                "INNER JOIN dbo.CdAppointmentStatus cdAS ON MHL.StatusApp = cdAS.Code " + _
            "WHERE MHL.RecordStatus = ' ' And Year(MHL.ReferenceDate) = " + DateP.Value.Year.ToString + " And Month(MHL.ReferenceDate) = " + DateP.Value.Month.ToString + _
                " And Day(MHL.ReferenceDate) = " + DateP.Value.Day.ToString + " " + _
            "GROUP BY MHL.Turn, MHL.ReferenceDate, M.FirstNames, M.LastNames, M.MemberId, M.LastFamilyId, MHL.PendPay, MHL.DrReferred, " + _
                "MHL.TotalNormalPrice, MHL.IdAppLab, M.Project, cdAS.DescSpanish " + _
            "ORDER BY MHL.Turn "
        bdGrid(sql, AgendaGrid)
        For f = 0 To AgendaGrid.RowCount - 1
            AgendaGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
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
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BorrarCitaLabButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarCitaLabButton.Click
        If ResultadoLabL.Text = "0" Then
            If ExamenesGrid.RowCount > 0 Then
                If tieneResultsLab() = 0 Then
                    Dim style As MsgBoxStyle
                    Dim response As MsgBoxResult
                    style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                    response = MsgBox("El paciente tiene " + ExamenesGrid.RowCount.ToString + " examenes ingresados. " + vbCr + "¿Esta seguro de borrar la cita al laboratorio?", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        IdCitaLabL.Text = ExamenesGrid.Item(0, 0).Value()
                        sql = "UPDATE  dbo.MemberHealthLabAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                              "WHERE RecordStatus = ' '  AND IdAppLab = " + IdCitaLabL.Text
                        bdEjecutarSQL(sql)

                        sql = "UPDATE  dbo.MemberHealthLabExam SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                              "WHERE RecordStatus = ' '  AND IdAppLab = " + IdCitaLabL.Text
                        bdEjecutarSQL(sql)
                        laboratorios()
                        agenda()
                    End If
                Else
                End If
            End If
        End If
    End Sub

    Private Sub BorrarLabButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarLabButton.Click
        If ResultadoLabL.Text = "0" Then
            If IdLabL.Text = "0" Then
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
                          "WHERE RecordStatus = ' '  AND Examen_ID = " + IdLabL.Text
                    bdEjecutarSQL(sql)

                    If ExamenesGrid.RowCount = 1 Then
                        sql = "UPDATE  dbo.MemberHealthLabAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                              "WHERE RecordStatus = ' '  AND IdAppLab = " + IdCitaLabL.Text
                    End If
                    bdEjecutarSQL(sql)
                    limpiarExamenLab()
                    laboratorios()
                    agenda()
                End If
            End If
        Else

        End If
    End Sub

    Private Function checkingAvailableTurns() As Boolean
        Dim needTurn As Boolean
        Dim intervalo As TimeSpan = DateP.Value - DateTime.Now
        If intervalo.Days < 0 Then
            MsgBox("La fecha no puede ser menor a la actual", vbInformation, My.Resources.versionFamilias2)
            checkingAvailableTurns = False
        Else
            If DateP.Value.ToShortDateString = Now.ToShortDateString And Now.Hour > 9 Then 'si es en el mismo día, envia mensaje de confirmación
                Dim msg As String = "¿Esta seguro de ingresar referencia al laboratorio hoy?"
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox(msg, style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    checkingAvailableTurns = True
                    needTurn = True
                Else
                    checkingAvailableTurns = False
                    needTurn = False
                End If
            Else
                needTurn = False
                Dim nDates, nTurns As Integer
                Dim nDatesSQL, nTurnsSQL As String
                nDatesSQL = "SELECT COUNT(*) AS Total FROM dbo.MemberHealthLabAppointment LD " + _
                            "WHERE RecordStatus = ' ' AND YEAR(ReferenceDate) = " + DateP.Value.Year.ToString + _
                             " AND MONTH(ReferenceDate) = " + DateP.Value.Month.ToString + " AND DAY(ReferenceDate) = " + DateP.Value.Day.ToString
                nDates = bdEntero(nDatesSQL, "Total")

                nTurnsSQL = "SELECT PropertyValue FROM FwApplicationProperty " + _
                            "WHERE Category = 'LABO' AND Organization = 'F' AND Name = 'TurnsByDay'"
                nTurns = bdEntero(nTurnsSQL, "PropertyValue")

                If nDates < nTurns Then
                    checkingAvailableTurns = True
                Else
                    checkingAvailableTurns = False
                    MsgBox("No hay espacio suficiente para el día " + DateP.Value.ToLongDateString, vbInformation, My.Resources.versionFamilias2)
                End If
            End If
        End If
    End Function

    Private Sub ExamenesGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ExamenesGrid.CellContentClick
        Dim f As Integer
        f = ExamenesGrid.CurrentCellAddress.Y
        limpiarExamenLab()

        IdCitaLabL.Text = ExamenesGrid.Item(0, f).Value()
        IdLabL.Text = ExamenesGrid.Item(1, f).Value()
        ResultadoLabL.Text = ExamenesGrid.Item(2, f).Value()
        ExamenesCombo.Text = ExamenesGrid.Item(5, f).Value()
        NotesV.Text = chequearValor(ExamenesGrid.Item(6, f).Value())

        If ResultadoLabL.Text = "0" Then
            ExamenesCombo.Enabled = True
            NotesV.Enabled = True
        Else
            ExamenesCombo.Enabled = False
            NotesV.Enabled = False
            MsgBox("Ya tiene resultados", vbInformation, My.Resources.versionFamilias2)
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

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If validacion() = True Then
            guardarCita()
        End If
    End Sub

    Private Sub guardarCita()
        actualizarLab()
        agenda()
        laboratorios()
        GuardarButton.Visible = False
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub laboratorios()
        sql = "SELECT MHLA.IdAppLab, MHLE.Examen_ID, (SELECT COUNT(*) N FROM dbo.MemberHealthLabResult MHLR " + _
              " WHERE RecordStatus = ' ' AND MHLR.Examen_ID = MHLE.Examen_ID) AS Resultados, CONVERT(nvarchar(30), MHLA.ReferenceDate, 21) F, dbo.fn_GEN_FormatDate (MHLA.ReferenceDate, 'ES') Fecha, cdLET.DescSpanish AS Laboratorio, MHLE.Notes AS Notas " + _
              "FROM dbo.MemberHealthLabExam MHLE INNER JOIN dbo.MemberHealthLabAppointment MHLA ON MHLE.IdAppLab = MHLA.IdAppLab AND MHLE.RecordStatus = MHLA.RecordStatus " + _
              "INNER JOIN dbo.CdLabExamen_Type cdLET ON MHLE.Examen_Tipo_ID = cdLET.Examen_Tipo_ID " + _
              "WHERE MHLE.RecordStatus = ' ' AND MHLE.IdAppLab = " + IDApp.ToString
        bdGrid(sql, ExamenesGrid)
        ExamenesGrid.Columns.Item(0).Visible = False 'IDCita
        ExamenesGrid.Columns.Item(1).Visible = False 'IDLab
        ExamenesGrid.Columns.Item(2).Visible = False 'Resultados
        ExamenesGrid.Columns.Item(3).Visible = False 'fecha
    End Sub

    Private Sub limpiarExamenLab()
        ExamenesCombo.SelectedIndex = -1
        NotesV.Text = ""
        IdCitaLabL.Text = "0"
        IdLabL.Text = "0"
        ResultadoLabL.Text = "0"
        'ResultadosL.Text = ""
    End Sub

    Private Sub LimpiarLabsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarLabsButton.Click
        limpiarExamenLab()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim mn As New AgendaLaboratorio
        mn.ActualDateP.Value = DateP.Value
        mn.Show()
        Me.Close()
    End Sub

    Private Sub NuevoLabButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoLabButton.Click
        If IdLabL.Text = "0" Then 'NUEVO EXAMEN
            If Len(ExamenesCombo.Text) > 0 Then
                Dim idEx As Integer = bdEntero("SELECT MAX(Examen_ID) ID FROM dbo.MemberHealthLabExam ", "ID") + 1 'IdExam
                IdCitaLabL.Text = ExamenesGrid.Item(0, 0).Value()
                ' Examen_ID, Examen_Tipo_ID, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, IdAppLab
                sql = "INSERT INTO dbo.MemberHealthLabExam VALUES(" + idEx.ToString + ", " + ExamenesCombo.SelectedValue.ToString + ", '" + _
                         DateP.Value.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, '" + Replace(NotesV.Text, "'", "''") + "', " + IdCitaLabL.Text + ") "
                bdInsertar(sql)
                limpiarExamenLab()
                laboratorios()
            End If
        Else 'MODIFICAR LAB
            If ResultadoLabL.Text = "0" Then 'SIN RESULTADOS
                sql = "INSERT INTO dbo.MemberHealthLabExam " + _
                      "SELECT Examen_ID, " + ExamenesCombo.SelectedValue.ToString + ", GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, '" + Replace(NotesV.Text, "'", "''") + "', IdAppLab " + _
                      "FROM dbo.MemberHealthLabExam " + _
                      "WHERE RecordStatus = ' '  AND Examen_ID = " + IdLabL.Text
                bdInsertar(sql)
                limpiarExamenLab()
                laboratorios()
            Else
                MsgBox("No se puede modificar porque ya tiene resultados", vbInformation, My.Resources.versionFamilias2)
            End If
        End If
    End Sub

    Private Function proximoTurno() As Integer
        sql = "SELECT CASE WHEN MAX(Turn) IS NULL THEN 0 ELSE MAX(Turn) END as Turn " + _
                   "FROM dbo.MemberHealthLabAppointment MHL " + _
                   "WHERE MHL.RecordStatus = ' ' AND  StatusApp NOT IN ('NOAS') AND YEAR(MHL.ReferenceDate) = " + DateP.Value.Year.ToString + _
                    " AND MONTH(MHL.ReferenceDate) = " + DateP.Value.Month.ToString + " AND DAY(MHL.ReferenceDate) = " + DateP.Value.Day.ToString + " "
        Dim turn As Integer = bdEntero(sql, "Turn")

        If turn = 0 Then
            proximoTurno = 1
        Else
            proximoTurno = turn + 1
        End If
    End Function

    Private Function tieneResultsLab() As Integer
        Dim total As Integer = 0
        For f = 0 To ExamenesGrid.RowCount - 1
            total = total + Integer.Parse(ExamenesGrid.Item(2, f).Value())
        Next
        tieneResultsLab = total
    End Function

    Private Function turnosDisponibles() As Boolean
        sql = "SELECT COUNT(*) T " + _
                   "FROM dbo.MemberHealthLabAppointment MHL " + _
                   "WHERE MHL.RecordStatus = ' ' AND  StatusApp NOT IN ('NOAS') AND YEAR(MHL.ReferenceDate) = " + DateP.Value.Year.ToString + _
                    " AND MONTH(MHL.ReferenceDate) = " + DateP.Value.Month.ToString + " AND DAY(MHL.ReferenceDate) = " + DateP.Value.Day.ToString + " "
        Dim nPacientes As Integer = bdEntero(sql, "T")

        sql = "SELECT PropertyValue T FROM FwApplicationProperty " + _
                                "WHERE Category = 'LABO' AND Organization = 'F' AND Name = 'TurnsByDay'"
        Dim nDisponibles = bdEntero(sql, "T")

        If nPacientes < nDisponibles Then
            turnosDisponibles = True
        Else
            turnosDisponibles = False
        End If
    End Function

    Private Function validacion() As Boolean
        If (StatusC.Text = "" Or StatusC.Text = " ") And StatusC.SelectedIndex = -1 Then
            MsgBox("Necesita el estado de la consulta", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            validacion = False
        Else
            validacion = True
        End If
    End Function

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish   FROM CdAppointmentStatus cdAS   WHERE Active = 1 AND Code NOT IN ('PEND') "
        bdCombo(sql, StatusC, "Code", "DescSpanish")
        valoresInicialesCita()
    End Sub

    Private Sub valoresInicialesCita()
        sql = "SELECT MHLA.ReferenceDate AS Fecha, cdAS.DescSpanish AS Estado, MHLA.Turn AS Turno, MHLA.DrReferred, " + _
              "MHLA.IdConsultation, TotalNormalPrice " + _
              "FROM dbo.MemberHealthLabAppointment MHLA INNER JOIN dbo.CdAppointmentStatus cdAS ON MHLA.StatusApp = cdAS.Code " + _
              "WHERE MHLA.IdAppLab = " + IDApp.ToString + " AND MHLA.RecordStatus = ' ' "
        bdDataTable(sql, listTable)
        DateP.Value = chequearValor(listTable.Rows(0)("Fecha")).ToString
        StatusC.Text = chequearValor(listTable.Rows(0)("Estado")).ToString
        DoctorC.Text = chequearValor(listTable.Rows(0)("DrReferred")).ToString
        IdConsul = chequearValor(listTable.Rows(0)("IdConsultation")).ToString
        total = chequearValor(listTable.Rows(0)("TotalNormalPrice")).ToString
        turnoOr = chequearValor(listTable.Rows(0)("Turno")).ToString

        'fill LabReferences
        sql = "SELECT Examen_Tipo_ID Code, DescSpanish Lab FROM dbo.CdLabExamen_Type WHERE Active = 1 ORDER BY DescSpanish"
        bdCombo(sql, ExamenesCombo, "Code", "Lab")
        laboratorios()
        avisosFamiliares()
    End Sub



End Class