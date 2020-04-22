Imports System.Security.Permissions
Imports System.Threading

' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class CitaLaboratorio
    Dim memberid, familyId, iLabs, turno As Integer

    Private Sub CitaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()

        If Len(PacienteV.Text) > 0 Then
            validaPaciente()
        ElseIf S = "E" And Len(PacienteV.Text) = 0 Then
            Dim emp As New BusquedaEmpleado
            emp.TransL.Text = "CL"
            emp.Show()
            Me.Close()
        Else
            PrincipalPanel.Visible = True
            PacienteV.Focus()
        End If
    End Sub

    Private Sub AgendaCheck_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AgendaCheck.LinkClicked
        verAgenda()
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

    Private Function esCitaLabValida() As Boolean
        Dim fecha As String = FechaPicker.Value.Year.ToString + "/" + FechaPicker.Value.Month.ToString + "/" + FechaPicker.Value.Day.ToString
        sql = "SELECT COUNT(*) Total FROM dbo.fn_HEAL_citasLab() WHERE Fecha = CONVERT(varchar, convert(datetime,'" + fecha + "'), 111) AND MemberId = " + PacienteV.Text
        Dim existeEnAgenda As Integer = bdPalabra(sql, "Total")
        If existeEnAgenda = 0 Then
            esCitaLabValida = True
        Else
            MsgBox("Ya existe una cita de laboratorio para este paciente en la fecha seleccionada", vbInformation, My.Resources.versionFamilias2)
            esCitaLabValida = False
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

    Private Sub guardarLabs()
        If ExamenesGrid.Rows.Count > 0 And esCitaLabValida() = True Then
            sql = "SELECT DATEDIFF(d, '" + FechaPicker.Value.ToString(en.DateTimeFormat) + "', GETDATE()) N"
            Dim resul As Integer = bdEntero(sql, "N")
            Dim estado As String

            If resul < 0 Then
                estado = "REFE"
                turno = 0
            Else
                estado = "COMP"
                sql = "SELECT CASE  WHEN MAX(Turn) IS NULL THEN 0 ELSE MAX(Turn) END   AS Id FROM dbo.MemberHealthLabAppointment MHL " +
                         "WHERE MHL.RecordStatus = ' ' AND YEAR(MHL.ReferenceDate) = " + FechaPicker.Value.Year.ToString + _
                         " AND MONTH(MHL.ReferenceDate) = " + FechaPicker.Value.Month.ToString + " AND DAY(MHL.ReferenceDate) = " + FechaPicker.Value.Day.ToString + " AND StatusApp <> 'NOAS'"
                turno = bdEntero(sql, "Id")
                turno = turno + 1
            End If

            '*new id laboratory appointment
            Dim idRefLab, idExam As Integer
            sql = "SELECT  MAX(IdAppLab) AS Id FROM dbo.MemberHealthLabAppointment " 'WHERE recordStatus = ' ' "
            idRefLab = bdEntero(sql, "Id") + 1

            '*insertar cita a laboratorio
            'IdAppLab, CreationDateTime, Project, memberId, UserId, ExpirationDateTime, ReferenceDate, IdConsultation, StatusApp, turn,
            'DrReferred, PendPay, RecordStatus, TotalNormalPrice, Emergency
            sql = "INSERT INTO dbo.MemberHealthLabAppointment  " + _
                  " VALUES(" + idRefLab.ToString + ", GETDATE(), '" + S + "', " + memberid.ToString + ", '" + _
                  U + "', NULL, '" + FechaPicker.Value.ToString(en.DateTimeFormat) + "', NULL, '" + estado + "', " + turno.ToString + ", '" + U + "', " + _
                            "0, ' ', 0, NULL)"
            bdInsertar(sql)

            '*insertar laboratorios
            For f = 0 To ExamenesGrid.RowCount - 1
                insertLaboratorio(ExamenesGrid.Item(1, f).Value, ExamenesGrid.Item(3, f).Value, ExamenesGrid.Item(4, f).Value, idRefLab)
                idExam = idExam + 1
            Next

            GuardarButton.Visible = False

            Dim nxt As New AgendaLaboratorio
            nxt.ActualDateP.Value = FechaPicker.Value
            nxt.Show()
            Me.Close()

        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        guardarLabs()
        verAgenda()
        FechaPicker.Value = DateTime.Now
        StatusC.SelectedIndex = -1
        ExamenesCombo.SelectedIndex = -1
        NotesV.Text = ""
        ExamenesGrid.Rows.Clear()
        FechaPicker.Focus()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub infoGen()
        Dim edad As String
        Dim listTable As New DataTable
        sql = "SELECT FirstNames + ' ' +  LastNames As CompleteName, DATEDIFF(M, BirthDate, GETDATE()) / 12 AS Edad, LastFamilyId Familia FROM  dbo.Member M " + _
                                   "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            NombreV.Text = listTable.Rows(f)("CompleteName") 'conn.Word(sql, "CompleteName")
            If Len(chequearValor(listTable.Rows(f)("Edad"))) = 0 Then
                edad = 0
            Else
                edad = chequearValor(listTable.Rows(f)("Edad"))
            End If

            EdadV.Text = " - " + edad.ToString + " año(s)"
            FamiliaV.Text = listTable.Rows(f)("Familia") 'conn.Word(sql, "Familia")
            PanelSecundario.Visible = True
        Next

        avisosFamiliares()
        verAgenda()
    End Sub

    Private Sub insertLaboratorio(ByVal codeExam As String, _
                         ByVal notes As String, _
                         ByVal hasSubE As String, _
                         ByVal idReLab As Integer)

        '*new idLab
        sql = "SELECT MAX(Examen_ID) as Id FROM dbo.MemberHealthLabExam " 'WHERE recordStatus = ' ' "
        Dim idExam As Integer = bdEntero(sql, "Id") + 1

        ' Examen_ID, Examen_Tipo_ID, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, IdAppLab
        sql = "INSERT INTO dbo.MemberHealthLabExam  VALUES (" + _
                idExam.ToString + ", " + codeExam + ", GETDATE(), ' ', '" + _
                U + "', NULL, '" + Replace(notes, "'", "''") + "', " + idReLab.ToString + ")"
        bdInsertar(sql)
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "CL"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub llenarLabsGrid()
        Dim hasSubLaboratory As Boolean = tieneSubLabs(ExamenesCombo.SelectedValue)

        Dim a() As String = {"", ExamenesCombo.SelectedValue, ExamenesCombo.Text, NotesV.Text, hasSubLaboratory.ToString, "0"}
        ExamenesGrid.Rows.Add(a)
        ExamenesCombo.Focus()

    End Sub

    Private Sub NewExamButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewExamButton.Click
        If ExamenesCombo.Text = "" Or IsDBNull(ExamenesCombo.Text) Then
            MsgBox("Necesita seleccionar un examen", vbInformation, "Clínica")
        Else
            If existeEnListado(ExamenesCombo.SelectedValue, ExamenesGrid, 1) = True Then
                MsgBox("El examen seleccionado ya existe", vbInformation, "Clínica")
            Else
                llenarLabsGrid()
                iLabs = iLabs + 1
            End If
            ExamenesCombo.Text = ""
            NotesV.Text = ""
            GuardarButton.Visible = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New CitaLaboratorio
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

    Private Function turnoDisponible() As Boolean
        sql = "SELECT PropertyValue T FROM FwApplicationProperty WHERE Category = 'LABO' AND Organization = 'F' AND Name = 'TurnsByDay' "
        Dim lt As String = bdPalabra(sql, "T")

        Dim turnosActuales As Integer = turnoLab(FechaPicker.Value)
        Dim limiteTurnos As Integer = Integer.Parse(lt)

        If turnosActuales < limiteTurnos Then
            turnoDisponible = True
            turno = turnosActuales + 1
        Else
            turnoDisponible = False
        End If
    End Function

    Private Function turnoLab(ByVal DateSelec As DateTime) As Integer
        sql = "SELECT COUNT(*) as Turn " + _
                   "FROM dbo.MemberHealthLabAppointment MHL " + _
                   "WHERE MHL.RecordStatus = ' ' AND YEAR(MHL.ReferenceDate) = " + DateSelec.Year.ToString + _
                    " AND MONTH(MHL.ReferenceDate) = " + DateSelec.Month.ToString + " AND DAY(MHL.ReferenceDate) = " + DateSelec.Day.ToString + " AND StatusApp <> 'NOAS'"
        turnoLab = bdEntero(sql, "Turn")
    End Function

    Private Function turnosLabDisponibles() As Boolean
        If ExamenesGrid.RowCount > 0 Then
            Dim intervalo As TimeSpan = FechaPicker.Value - DateTime.Now
            If intervalo.Days < 0 Then
                MsgBox("La fecha no puede ser menor a la actual", vbInformation, My.Resources.versionFamilias2)
                turnosLabDisponibles = False
            ElseIf intervalo.Days = 0 Then
                sql = "SELECT dbo.fn_HEAL_LAB_espacioDisponible_RECE('" + FechaPicker.Value.ToString(en.DateTimeFormat) + "') RESUL "
                Dim disponibles As String = bdPalabra(sql, "RESUL")

                If disponibles = "SI" Then
                    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                    Dim response As MsgBoxResult
                    response = MsgBox("¿Esta seguro de ingresar referencia al laboratorio hoy?", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        turnosLabDisponibles = True
                    Else
                        turnosLabDisponibles = True
                    End If
                Else
                    MsgBox("No hay espacio suficiente en laboratorio", vbInformation, My.Resources.versionFamilias2)
                    turnosLabDisponibles = False
                End If
            Else
                sql = "SELECT dbo.fn_HEAL_LAB_espacioDisponible_RECE('" + FechaPicker.Value.ToString(en.DateTimeFormat) + "') RESUL "
                Dim disponibles As String = bdPalabra(sql, "RESUL")
                If disponibles = "SI" Then
                    turnosLabDisponibles = True
                Else
                    MsgBox("No hay espacio suficiente en laboratorio", vbInformation, My.Resources.versionFamilias2)
                    turnosLabDisponibles = False
                End If
            End If
        Else
            MsgBox("Aun no ha ingresado los laboratorios a realizar" + FechaPicker.Value.ToLongDateString, vbInformation, My.Resources.versionFamilias2)
            turnosLabDisponibles = False
        End If
    End Function


    Private Sub validaPaciente()
        memberid = Integer.Parse(PacienteV.Text)
        If miembroEsValido(S, PacienteV.Text) = True Then
            If tieneDerechosSalud(S, PacienteV.Text) = True Then
                sql = "SELECT LastFamilyId as Familia FROM dbo.Member M WHERE RecordStatus= ' '  AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
                familyId = bdEntero(sql, "Familia")
                If familiaEsValida(S, familyId) Then
                    FamiliaV.Text = familyId.ToString
                    valoresIniciales()
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



    'Private Sub validaPaciente()
    '    memberid = Integer.Parse(PacienteV.Text)
    '    If miembroEsValido(S, memberid) = True Then
    '        sql = "SELECT LastFamilyId as Familia FROM dbo.Member M WHERE RecordStatus= ' '  AND Project = '" + S + "' AND MemberId = " + PacienteV.Text
    '        familyId = bdEntero(sql, "Familia")
    '        If familiaEsValida(S, familyId) Then
    '            FamiliaV.Text = familyId.ToString
    '            If derechosSalud(S, memberid, familyId) = True Or S = "E" Then
    '                valoresIniciales()
    '                FamiliaV.Enabled = False
    '                PacienteV.Enabled = False
    '            Else
    '                MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
    '                PacienteV.Text = ""
    '                FamiliaV.Text = ""
    '            End If
    '        Else
    '            MsgBox("La familia no existe", vbQuestion, My.Resources.versionFamilias2)
    '            PacienteV.Text = ""
    '        End If
    '    Else
    '        MsgBox("El No. Paciente ingresado no existe", vbQuestion, My.Resources.versionFamilias2)
    '        PacienteV.Text = ""
    '    End If
    'End Sub

    Private Sub valoresIniciales()
        turno = 0
        sql = "SELECT Code, DescSpanish   FROM CdAppointmentStatus cdAS   WHERE Active = 1 AND Code NOT IN ('PEND') "
        bdCombo(sql, StatusC, "Code", "DescSpanish")

        'fill LabReferences
        sql = "SELECT Examen_Tipo_ID Code, DescSpanish Lab FROM dbo.CdLabExamen_Type WHERE Active = 1 ORDER BY DescSpanish"
        bdCombo(sql, ExamenesCombo, "Code", "Lab")

        CitaPanel.Visible = True
        infoGen()
    End Sub

    Private Sub verAgenda()
        Dim y, m, d As String
        y = FechaPicker.Value.Year
        m = FechaPicker.Value.Month
        d = FechaPicker.Value.Day

        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es", False)

        sql = "SELECT MHL.IdAppLab, COUNT(RES.Resultado) AS Resultados, MHL.Turn AS Turno, M.FirstNames + ' ' + M.LastNames AS Nombre, M.MemberId AS 'Paciente', MHL.DrReferred AS Refirió, " + _
                     "M.Project AS Sitio, cdAS.DescSpanish Estado, M.LastFamilyId Familia " + _
              "FROM dbo.MemberHealthLabAppointment MHL INNER JOIN dbo.Member M ON MHL.Project = M.Project AND MHL.MemberId = M.MemberId AND MHL.RecordStatus = M.RecordStatus " + _
                    "INNER JOIN dbo.MemberHealthLabExam EXA ON MHL.IdAppLab = EXA.IdAppLab AND MHL.RecordStatus = EXA.RecordStatus " + _
                    "LEFT JOIN dbo.MemberHealthLabResult RES ON EXA.Examen_ID = RES.Examen_ID AND EXA.RecordStatus = RES.RecordStatus " + _
                    "INNER JOIN dbo.CdAppointmentStatus cdAS ON MHL.StatusApp = cdAS.Code " + _
            "WHERE MHL.RecordStatus = ' ' And Year(MHL.ReferenceDate) = " + y + " And Month(MHL.ReferenceDate) = " + m + _
                " And Day(MHL.ReferenceDate) = " + d + " " + _
            "GROUP BY MHL.Turn, MHL.ReferenceDate, M.FirstNames, M.LastNames, M.MemberId, M.LastFamilyId, MHL.PendPay, MHL.DrReferred, " + _
                      "MHL.TotalNormalPrice, MHL.IdAppLab, M.Project, cdAS.DescSpanish " + _
            "ORDER BY MHL.Turn "
        bdGrid(sql, AgendaGrid)

        AgendaGrid.Columns.Item(0).Visible = False
        AgendaGrid.Columns.Item(1).Visible = False

        For f = 0 To AgendaGrid.Rows.Count - 1
            AgendaGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
        Next
    End Sub

End Class