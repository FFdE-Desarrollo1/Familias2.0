' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class RegistroActividadesEduc
    Dim dt As New DataTable

    Private Sub RegistroActividadesMisc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        TipoList.Focus()
        valoresIniciales()
    End Sub

    Private Sub ActividadButton_Click(sender As Object, e As EventArgs)
        ListadoActividades()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrarAsistencia(ByVal memberId As Integer, ByVal dateA As String)
        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        Dim response As MsgBoxResult
        response = MsgBox("¿Esta seguro de borrar la actividad?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "UPDATE dbo.MemberActivity SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
              "WHERE RecordStatus = ''  AND Project = '" + S + "' AND MemberId = " + memberId.ToString + _
              " AND convert(varchar, ActivityDateTime, 120) = convert(varchar, '" + dateA + "', 120) "
            bdInsertar(sql)
            ListadoActividades()
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
                If valor = m(j) Then
                    ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                    ListadoGrid.Rows(j).DefaultCellStyle.BackColor = Color.LightSalmon
                End If
            Next
        Next

    End Sub

    Private Sub DuplicadosCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicadosCheck.CheckedChanged
        duplicados()
    End Sub

    Private Function esCorrecto() As Boolean
        If Len(MiembroV.Text) > 0 Then
            If esApadrinado(S, MiembroV.Text) = True Then 'esAfiliado(S, MiembroV.Text) = True Or
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
                MsgBox("El número " + MiembroV.Text + " no corresponde a un apadrinado", vbQuestion, My.Resources.versionFamilias2)
                esCorrecto = False
            End If
        Else
            MsgBox("El número " + MiembroV.Text + " no es válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
            esCorrecto = False
        End If
    End Function

    Private Function esDuplicado(ByVal type As String, ByVal dateA As DateTime) As Boolean
        sql = "SELECT COUNT(*) AS Total FROM dbo.MemberActivity " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND Type = '" + type + "' " + _
              " AND YEAR(ActivityDateTime) = " + dateA.Year.ToString + " AND MONTH(ActivityDateTime) = " + dateA.Month.ToString + _
              " AND DAY(ActivityDateTime) = " + dateA.Day.ToString

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

    Private Sub FaroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FaroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            sql = "SELECT COUNT(*) Total FROM Family WHERE RecordStatus = ' '  AND RFaroNumber =  " + FaroV.Text
            If bdEntero(sql, "Total") > 0 Then
                sql = "SELECT FamilyId Familia FROM Family WHERE RecordStatus = ' '  AND RFaroNumber =  " + FaroV.Text
                FamiliaV.Text = bdEntero(sql, "Familia")
                irMiembrosDeFamilia()
            Else
                MsgBox("El No. Faro no existe", vbInformation, My.Resources.versionFamilias2)
                FaroV.Text = ""
            End If
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

    Private Sub genInfo()
        sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, E1.EstadoEduc + ' ' + E1.Grado  + '  ' +   E1.Escuela AS Educ, " + _
                 "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro, dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad " + _
                 "FROM dbo.Member M LEFT OUTER JOIN dbo.fn_EDUC_añoEscolar(" + Now.Year.ToString + ") E1 ON E1.Project = M.Project AND E1.MemberId = M.MemberId " + _
                 "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND M.MemberId = " + MiembroV.Text
        bdDataTable(sql, dt)
        NombreL.Text = chequearValor(dt.Rows(0)("Nombre"))
        EdadL.Text = chequearValor(dt.Rows(0)("Edad"))
        TipoMiembroL.Text = "(" + chequearValor(dt.Rows(0)("TipoMiembro")) + ")"
        GradoL.Text = chequearValor(dt.Rows(0)("Educ"))
        NombreL.Visible = True
        TipoMiembroL.Visible = True
        EdadL.Visible = True
        GradoL.Visible = True
        dt.Clear()
    End Sub

    Private Sub guardarActividad()
        If esCorrecto() = True Then
            If verInfoCheck.Checked = True Then
                genInfo()
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox("¿Esta seguro de ingresar la actividad?", style, My.Resources.versionFamilias2)
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
        guardarActividad()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub Insertar(ByVal type As String)
        HoraV.Value = Now
        Dim fechaHora As String = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HoraV.Value.ToLongTimeString
        'Dim dateIns As DateTime = DateTime.Now
        ' Project, MemberId, Type, ActivityDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes
        sql = "INSERT INTO  dbo.MemberActivity VALUES ('" + S + "', " + MiembroV.Text + ", '" + type + "', '" + Convert.ToDateTime(fechaHora).ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, '" + NotasV.Text + "')"
        bdInsertar(sql)
        ListadoActividades()
        limpiar()
    End Sub

    Private Sub irMiembrosDeFamilia()
        Dim nxt As New MiembrosFamilia
        nxt.familyId = FamiliaV.Text
        nxt.transac = "IMAM"
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiar()
        dt.Clear()
        sql = ""
        MiembroV.Text = ""
        NotasV.Text = ""
        NombreL.Text = ""
        TipoMiembroL.Text = ""
        EdadL.Text = ""
        GradoL.Text = ""
        HoraV.Value = Date.Now
        DuplicadosCheck.Checked = False
        NombreL.Visible = False
        TipoMiembroL.Visible = False
        EdadL.Visible = False
        GradoL.Visible = False
        GuardarButton.Visible = True
        MiembroV.Focus()
    End Sub

    Private Sub ListadoActividades()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()

        Dim today As DateTime = FechaV.Value 'Date.Today
        sql = "SELECT MAP.MemberId AS Miembro, M.FirstNames + ' ' + M.LastNames AS Nombre, dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad, " + _
            "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro,  " + _
            "convert(varchar(50), MAP.ActivityDateTime, 120) 'Fecha/Hora', " + _
            "cdMAT.DescSpanish AS Asistencia, MAP.UserId AS Usuario, MAP.Notes as Observaciones, M.LastFamilyId Familia  " + _
            "FROM dbo.MemberActivity MAP " + _
            "INNER JOIN dbo.Member M ON MAP.Project = M.Project AND MAP.MemberId = M.MemberId AND MAP.RecordStatus = M.RecordStatus " + _
            "INNER JOIN dbo.CdMemberActivityType cdMAT ON MAP.Type = cdMAT.Code " + _
            "WHERE MAP.RecordStatus = ' ' AND MAP.Project = '" + S + "' AND YEAR(MAP.ActivityDateTime) = " + today.Year.ToString + _
            " AND MONTH(MAP.ActivityDateTime) = " + today.Month.ToString + " AND DAY(MAP.ActivityDateTime) = " + today.Day.ToString + "  " + _
            " AND cdMAT.DescSpanish = '" + TipoList.Text + "' " + _
            "ORDER BY MAP.ActivityDateTime DESC "
        bdGrid(sql, ListadoGrid)
        Dim n As String = ListadoGrid.Rows.Count
        For f = 0 To ListadoGrid.Rows.Count - 1
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
        If c = 1 Then
            member = Integer.Parse(ListadoGrid.Item(2, f).Value)
            dateAt = (ListadoGrid.Item(6, f).Value).ToString
            borrarAsistencia(member, dateAt)
        Else
        End If

    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            guardarActividad()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TipoList_TextChanged(sender As Object, e As EventArgs) Handles TipoList.TextChanged
        If Len(TipoList.Text) = 0 Or TipoList.Text = "System.Data.DataRowView" Or TipoList.SelectedIndex = -1 Then
        Else
            ListadoActividades()
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
        sql = "SELECT Code, DescSpanish FROM dbo.CdMemberActivityType " + _
              "WHERE Active = 1 AND Project IN ('*', '" + S + "')  AND FunctionalArea = 'EDUC' " + _
              "ORDER BY DescSpanish "
        bdCombo(sql, TipoList, "Code", "DescSpanish")

        If S = "R" Then
            FaroL.Visible = True
            FaroV.Visible = True
        End If
    End Sub

End Class