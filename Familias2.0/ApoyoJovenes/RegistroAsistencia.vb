' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class RegistroAsistencia
    Private imgOriginal As Image
    Dim dt As New DataTable
    Dim fotoDire As String

    Private Sub RegistroAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ActividadButton_Click(sender As Object, e As EventArgs) Handles ActividadButton.Click
        ListadoAsistencia()
    End Sub

    Private Sub agregarImpresiones(ByVal memberId As Integer, _
                             ByVal dateA As String)
        Dim cantidad As Integer = 0

        Dim cantidadImpr = InputBox("IMPRESIONES - Asistencia CDI " + vbCrLf + "Ingrese la cantidad y presione ACEPTAR para seguir)", My.Resources.versionFamilias2, "0")
        Integer.TryParse(cantidadImpr, cantidad)

        sql = "UPDATE dbo.MemberAssistanceProgram SET PrintNumber = " + cantidad.ToString + _
        "WHERE RecordStatus = ''  AND Project = '" + S + "' AND MemberId = " + memberId.ToString + _
        " AND convert(varchar, AssistanceDateTime, 120) = convert(varchar, '" + dateA + "', 120) "
        bdInsertar(sql)
        ListadoAsistencia()
        limpiar()

    End Sub

    Private Sub Asistencia_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        HoraV.Value = Date.Now
    End Sub

    Private Sub Asistencia_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        HoraV.Value = Date.Now
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrarAsistencia(ByVal memberId As Integer, _
                             ByVal dateA As String)

        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        Dim response As MsgBoxResult
        response = MsgBox("¿Esta seguro de borrar la asistencia?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "UPDATE dbo.MemberAssistanceProgram SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
              "WHERE RecordStatus = ''  AND Project = '" + S + "' AND MemberId = " + memberId.ToString + _
              " AND convert(varchar, AssistanceDateTime, 120) = convert(varchar, '" + dateA + "', 120) "
            bdInsertar(sql)
            ListadoAsistencia()
            limpiar()
        End If
    End Sub

    Private Sub duplicados()
        Dim qty As Integer = 500
        Dim m(qty), i, j, n, valor As Integer
        n = ListadoGrid.Rows.Count() - 1

        For i = 0 To qty
            m(i) = 0
        Next

        For i = 0 To n
            m(i) = ListadoGrid.Item(2, i).Value()
        Next

        For i = 0 To n
            valor = m(i)
            For j = i + 1 To n
                If S = "N" And valor = 50 Then
                Else
                    If valor = m(j) Then
                        ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                        ListadoGrid.Rows(j).DefaultCellStyle.BackColor = Color.LightSalmon
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub DuplicadosCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicadosCheck.CheckedChanged
        If DuplicadosCheck.Checked = True Then
            duplicados()
        End If
    End Sub

    Private Function esCorrecto() As Boolean
        If Len(MiembroV.Text) > 0 Then
            sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, M.AffiliationStatus Estado, MMSI.Photo Foto, " + _
                  "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro, dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad " + _
                  "FROM dbo.Member M LEFT JOIN dbo.MiscMemberSponsorInfo MMSI ON M.RecordStatus = MMSI.RecordStatus AND M.Project = MMSI.Project AND M.MemberId = MMSI.MemberId " + _
                  "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND M.MemberId = " + MiembroV.Text
            bdDataTable(sql, dt)

            If dt.Rows.Count > 0 Then
                If validarFecha(FechaV.Value) = False Then
                    MsgBox("La fecha no puede ser mayor a la actual", vbQuestion, My.Resources.versionFamilias2)
                    MiembroV.Text = ""
                    MiembroV.Focus()
                    esCorrecto = False
                ElseIf TipoList.Text = " " Or TipoList.Text = "" Then
                    MsgBox("Necesita seleccionar la actividad ", vbQuestion, My.Resources.versionFamilias2)
                    MiembroV.Text = ""
                    MiembroV.Focus()
                    esCorrecto = False
                ElseIf fechaAnterior(FechaV.Value) = True Then
                    Dim style As MsgBoxStyle
                    Dim response As MsgBoxResult
                    style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                    response = MsgBox("Esta ingresando una actividad con fecha anterior" + vbNewLine + " ¿Esta seguro de agregarla?", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        If esDuplicado(TipoList.SelectedValue, FechaV.Value) = False Then
                            esCorrecto = True
                        Else
                            esCorrecto = False
                            limpiar()
                        End If
                    Else
                        MiembroV.Text = ""
                        MiembroV.Focus()
                        esCorrecto = False
                    End If
                Else
                    If esDuplicado(TipoList.SelectedValue, FechaV.Value) = False Then
                        esCorrecto = True
                    Else
                        esCorrecto = False
                    End If
                End If
            Else
                esCorrecto = False
            End If
        Else
            MiembroV.Text = ""
            esCorrecto = False
        End If
    End Function

    Private Function esDuplicado(ByVal type As String, ByVal dateA As DateTime) As Boolean
        If S = "N" And MiembroV.Text = "50" Then
            esDuplicado = False
        Else
            sql = "SELECT COUNT(*) AS Total FROM dbo.MemberAssistanceProgram " + _
                  "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND Type = " + type + _
                  " AND YEAR(AssistanceDateTime) = " + dateA.Year.ToString + " AND MONTH(AssistanceDateTime) = " + dateA.Month.ToString + _
                  " AND DAY(AssistanceDateTime) = " + dateA.Day.ToString
            If bdEntero(sql, "Total") = 0 Then
                esDuplicado = False
            Else
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                response = MsgBox("¿Necesita agregar nuevamente la misma actividad para este miembro?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    esDuplicado = False
                Else
                    esDuplicado = True
                    limpiar()
                End If
            End If
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

    Private Function fechaAnterior(ByVal fechaIn As DateTime) As Boolean
        Dim nowDate As DateTime = DateTime.Now
        Dim nDays As Integer = DateDiff(DateInterval.Day, Convert.ToDateTime(fechaIn.ToShortDateString), Convert.ToDateTime(nowDate.ToShortDateString))

        If nDays > 0 Then
            fechaAnterior = True
        Else
            fechaAnterior = False
        End If
    End Function

    Private Sub fotoMiembro()
        ApadrinadoPic.Visible = True
        Try
            If Len(fotoDire) > 0 Then
                fotoDire = fotoDire.Remove(0, 3)
            End If
            fotoDire = "\\" + My.Resources.svr + "\FamilyFotos\" + fotoDire
            imgOriginal = Image.FromFile(fotoDire)
            fotoL.Text = ""
            fotoL.Visible = False
        Catch ex As Exception
            imgOriginal = My.Resources.CH_Heart
            fotoL.Text = "Sin foto disponible. " + vbNewLine + _
                         "Ingresan solo para Apadrinados y algunos Desafiliados o Graduados"
            fotoL.Visible = True
        Finally
        End Try
        ApadrinadoPic.Image = imgOriginal
        ApadrinadoPic.SizeMode = PictureBoxSizeMode.StretchImage
        ApadrinadoPic.Size = New Point(220, 220)
    End Sub

    Private Sub guardarAsitencia()
        If esCorrecto() = True Then
            If verFotoCheck.Checked = True Then
                fotoDire = ""
                Dim afilDesGrad As String = chequearValor(dt.Rows(0)("Estado"))
                fotoDire = chequearValor(dt.Rows(0)("Foto"))
                fotoMiembro()
                NombreL.Text = chequearValor(dt.Rows(0)("Nombre"))
                EdadL.Text = chequearValor(dt.Rows(0)("Edad"))
                TipoMiembroL.Text = "(" + chequearValor(dt.Rows(0)("TipoMiembro")) + ")"
                NombreL.Visible = True
                TipoMiembroL.Visible = True
                EdadL.Visible = True
                dt.Clear()

                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox("¿Esta seguro de ingresar la asistencia?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    Insertar(TipoList.SelectedValue)
                Else
                    limpiar()
                End If
            Else
                Insertar(TipoList.SelectedValue)
            End If
        Else
            limpiar()
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        guardarAsitencia()
    End Sub

    Private Sub horaButton_Click(sender As Object, e As EventArgs) Handles horaButton.Click
        HoraV.Value = Date.Now
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub Insertar(ByVal type As String)
        Dim fechaHora As String = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HoraV.Value.ToLongTimeString
        Dim dateIns As DateTime = DateTime.Now
        ' Project, MemberId, Type, AssistanceDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, PrintNumber
        sql = "INSERT INTO  dbo.MemberAssistanceProgram VALUES ('" + S + "', " + MiembroV.Text + ", " + type + ", '" + Convert.ToDateTime(fechaHora).ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, '" + NotasV.Text + "',0,NULL)"
        bdInsertar(sql)
        ListadoAsistencia()
        limpiar()
    End Sub

    Private Sub irMiembrosDeFamilia()
        Dim nxt As New MiembrosFamilia
        nxt.familyId = FamiliaV.Text
        nxt.transac = "COAS"
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiar()
        ApadrinadoPic.Image = Nothing
        dt.Clear()
        sql = ""
        MiembroV.Text = ""
        NotasV.Text = ""
        fotoDire = ""
        NombreL.Text = ""
        TipoMiembroL.Text = ""
        EdadL.Text = ""
        HoraV.Value = Date.Now
        DuplicadosCheck.Checked = False
        ApadrinadoPic.Visible = False
        NombreL.Visible = False
        TipoMiembroL.Visible = False
        EdadL.Visible = False
        GuardarButton.Visible = True
        MiembroV.Focus()
        fotoL.Visible = False
    End Sub

    Private Sub ListadoAsistencia()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()

        Dim today As DateTime = FechaV.Value 'Date.Today
        sql = "SELECT MAP.MemberId AS Miembro, M.FirstNames + ' ' + M.LastNames AS Nombre, dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad, " + _
            "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro, M.lastFamilyId Familia, " + _
            "convert(varchar(50), MAP.AssistanceDateTime, 120) 'Fecha/Hora', " + _
            "cdMAT.DescSpanish AS Asistencia, PrintNumber Impresiones, MAP.UserId AS Usuario, MAP.Notes as Observaciones  " + _
            "FROM dbo.MemberAssistanceProgram MAP " + _
            "INNER JOIN dbo.Member M ON MAP.Project = M.Project AND MAP.MemberId = M.MemberId AND MAP.RecordStatus = M.RecordStatus " + _
            "INNER JOIN dbo.CdMemberActivityType cdMAT ON MAP.Type = cdMAT.CodeInt " + _
            "WHERE MAP.RecordStatus = ' ' AND MAP.Project = '" + S + "' AND YEAR(MAP.AssistanceDateTime) = " + today.Year.ToString + _
            " AND MONTH(MAP.AssistanceDateTime) = " + today.Month.ToString + " AND DAY(MAP.AssistanceDateTime) = " + today.Day.ToString + "  " + _
            " AND cdMAT.DescSpanish = '" + TipoList.Text + "' " + _
            "ORDER BY MAP.AssistanceDateTime DESC "
        bdGrid(sql, ListadoGrid)

        Dim n As String = ListadoGrid.Rows.Count
        For f = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Item(2, f).Value = "Agregar"
            ListadoGrid.Item(1, f).Value = "Borrar"
            ListadoGrid.Item(0, f).Value = n
            n = n - 1
        Next
        MiembroV.Focus()
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HoraV.Value = Date.Now
    End Sub

    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        Dim f, c, member As Integer
        Dim dateAt As String
        c = ListadoGrid.CurrentCellAddress.X
        f = ListadoGrid.CurrentCellAddress.Y
        member = Integer.Parse(ListadoGrid.Item(3, f).Value)  '2
        dateAt = (ListadoGrid.Item(8, f).Value).ToString  '7
        If c = 1 Then
            borrarAsistencia(member, dateAt)
        ElseIf c = 2 Then
            agregarImpresiones(member, dateAt)
        Else
        End If

    End Sub

    Private Sub ListadoLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ListadoAsistencia()
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            guardarAsitencia()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New RegistroAsistencia
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub TipoList_TextChanged(sender As Object, e As EventArgs) Handles TipoList.TextChanged
        If Len(TipoList.Text) = 0 Or TipoList.Text = "System.Data.DataRowView" Or TipoList.SelectedIndex = -1 Then
        Else
            ListadoAsistencia()
        End If
    End Sub

    Private Function validarFecha(ByVal fechaIn As DateTime) As Boolean
        Dim nowDate As DateTime = DateTime.Now
        Dim nDays As Integer = DateDiff(DateInterval.Day, Convert.ToDateTime(fechaIn.ToShortDateString), Convert.ToDateTime(nowDate.ToShortDateString))

        If nDays < 0 Then
            validarFecha = False
        Else
            validarFecha = True
        End If
    End Function

    Private Sub valoresIniciales()
        Dim order As String
        If S = "N" Then
            order = "CodeInt"
        Else
            order = "DescSpanish"
        End If
        sql = "SELECT CodeInt, DescSpanish FROM dbo.CdMemberActivityType " + _
              "WHERE Active = 1 AND Project IN ('*', '" + S + "')  AND FunctionalArea = 'APJO' AND CodeInt IS NOT NULL " + _
              "ORDER BY " + order
        bdCombo(sql, TipoList, "CodeInt", "DescSpanish")

        sql = "SELECT CASE WHEN CustomField4 IS NULL THEN 'NO' ELSE CustomField4 END AS PreAct FROM dbo.FwEmployee WHERE EmployeeId = '" + U + "' "
        Dim codeAct As String = bdPalabra(sql, "PreAct")

        If codeAct = "NO" Then
            TipoList.Text = ""
        Else
            sql = "SELECT  DescSpanish FROM dbo.CdMemberActivityType WHERE  CodeInt = " + codeAct + " "
            codeAct = bdPalabra(sql, "DescSpanish")
            TipoList.Text = codeAct
        End If

        ListadoAsistencia()
        GuardarButton.Visible = True
    End Sub

End Class