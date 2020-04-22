' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0
Public Class RegistroCDIs
    Private imgOriginal As Image
    Dim dt As New DataTable
    Dim anterior As Boolean = False
    Dim tipoR, salidaSel, dateA, fotoDire As String
    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
    Dim response As MsgBoxResult

    Private Sub RegistroCDIs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ActividadButton_Click(sender As Object, e As EventArgs) Handles ActividadButton.Click
        ListadoAsistencia()
    End Sub

    Private Sub actualizar()
        Dim dSalida As String
        If salidaCheckBox.Checked = True Then
            dSalida = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HSalidaV.Value.ToLongTimeString
            dSalida = "'" + Convert.ToDateTime(dSalida).ToString(en.DateTimeFormat) + "'" 'formato FechaHora salida
        Else
            dSalida = "NULL"
        End If

        sql = "UPDATE dbo.MemberAssistanceProgram " + _
              "SET PrintNumber = " + nImpresionS.Text + ", Notes = '" + ObservacionesS.Text + "', EndDateTime = " + dSalida + " " + _
              "WHERE RecordStatus = ''  AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + _
              " AND convert(varchar, AssistanceDateTime, 120) = '" + dateA + "' "
        'InputBox("", "", sql)
        bdInsertar(sql)
        If asistenciasAnterioresCheck.Checked = True Then
            valoresInicialesAsistenciaAnterior()
        Else
            valoresInicialesNuevaAsistencia()
        End If

        ListadoAsistencia()

    End Sub

    Private Sub asistenciasAnterioresCheck_CheckedChanged(sender As Object, e As EventArgs) Handles asistenciasAnterioresCheck.CheckedChanged
        If asistenciasAnterioresCheck.Checked = True Then
            valoresInicialesAsistenciaAnterior()
        Else
            valoresInicialesNuevaAsistencia()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrarAsistencia(ByVal miembroS As String, ByVal fechaS As String)
        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        Dim response As MsgBoxResult
        response = MsgBox("¿Esta seguro de borrar la asistencia?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "UPDATE dbo.MemberAssistanceProgram SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
              "WHERE RecordStatus = ''  AND Project = '" + S + "' AND MemberId = " + miembroS + _
              " AND convert(varchar, AssistanceDateTime, 120) = '" + fechaS + "' "
            bdInsertar(sql)
            ListadoAsistencia()
            limpiar()
        End If
    End Sub

    Private Sub buscar()
        Dim n As String = ListadoGrid.Rows.Count
        Dim fila As Integer
        For f = 0 To ListadoGrid.Rows.Count - 1
            If ListadoGrid.Item(4, f).Value = MiembroV.Text Then
                fila = f
            End If
        Next

        'limpiar()
        miembroSeleccionado(fila)

    End Sub

    Private Sub datosMiembro() '(ByVal miembro As String)
        sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, M.AffiliationStatus Estado, MMSI.Photo Foto, " + _
              "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro, dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad " + _
              "FROM dbo.Member M LEFT JOIN dbo.MiscMemberSponsorInfo MMSI ON M.RecordStatus = MMSI.RecordStatus AND M.Project = MMSI.Project AND M.MemberId = MMSI.MemberId " + _
              "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND M.MemberId = " + MiembroV.Text
        bdDataTable(sql, dt)
    End Sub

    Private Function esCorrecto() As Boolean
        If Len(MiembroV.Text) > 0 Then
            datosMiembro() '(MiembroV.Text)
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
            anterior = True
        Else
            fechaAnterior = False
            anterior = True
        End If
    End Function

    Private Sub FechaButton_Click(sender As Object, e As EventArgs) Handles FechaButton.Click
        ListadoAsistencia()
    End Sub

    Private Sub FechaV_ValueChanged(sender As Object, e As EventArgs) Handles FechaV.ValueChanged
        ListadoAsistencia()
    End Sub

    Private Sub fotoMiembro()
        ApadrinadoFoto.Visible = True
        Try
            If Len(fotoDire) > 0 Then
                fotoDire = fotoDire.Remove(0, 3)
            End If
            'fotoDire = "\\" + My.Resources.svr + "\FamilyFotos\" + fotoDire
            fotoDire = "\\svrfamilias\FamilyFotos\" + fotoDire
            imgOriginal = Image.FromFile(fotoDire)

            fotoL.Text = ""
            fotoL.Visible = False
            'principalTable.ColumnStyles = TableLayoutColumnStyleCollection.
            'principalTable.Item(0, 0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            imgOriginal = My.Resources.CH_Heart
            fotoL.Text = "Sin foto disponible. " + vbNewLine + _
                         "Ingresan solo para Apadrinados y algunos Desafiliados o Graduados"
            fotoL.Visible = True
        Finally
        End Try

        ApadrinadoFoto.Image = imgOriginal
        ApadrinadoFoto.SizeMode = PictureBoxSizeMode.StretchImage
        'ApadrinadoFoto.Size = New Point(124, 137)
    End Sub

    Private Sub Guardar()
        If tipoR = "N" Or tipoR = "A" Then
            guardarAsistencia()
        ElseIf tipoR = "M" Then
            actualizar()
        End If
    End Sub

    Private Sub guardarAsistencia()
        If esCorrecto() = True Then
            If verFotoCheck.Checked = True Then
                fotoDire = ""
                Dim afilDesGrad As String = chequearValor(dt.Rows(0)("Estado"))
                fotoDire = chequearValor(dt.Rows(0)("Foto"))
                fotoMiembro()
                'MiembroS.Text = MiembroV.Text
                NombreS.Text = chequearValor(dt.Rows(0)("Nombre"))
                TipoMiembroS.Text = "(" + chequearValor(dt.Rows(0)("TipoMiembro")) + ")"
                TipoMiembroS.Visible = True
                dt.Clear()
                response = MsgBox("¿Esta seguro de ingresar la asistencia?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    InsertarAsistencia(TipoList.SelectedValue)
                Else
                    If asistenciasAnterioresCheck.Checked = False Then
                        valoresInicialesAsistenciaAnterior()
                    Else
                        valoresInicialesNuevaAsistencia()
                    End If
                End If
            Else
                InsertarAsistencia(TipoList.SelectedValue)
            End If
        Else
            valoresInicialesNuevaAsistencia()
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Guardar()
    End Sub

    Private Sub GuardarSalida(ByVal miembro As String, ByVal fecha As String)
        sql = "UPDATE dbo.MemberAssistanceProgram SET EndDateTime = GETDATE() " + _
              "WHERE RecordStatus = ''  AND Project = '" + S + "' AND MemberId = " + miembro + _
              " AND convert(varchar, AssistanceDateTime, 120) = '" + fecha + "' "
        'InputBox("", "", sql)
        bdInsertar(sql)
        MsgBox("Salida registrada", vbExclamation, My.Resources.versionFamilias2)
        ListadoAsistencia()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub InsertarAsistencia(ByVal type As String)
        Dim salida, impresion As String
        Dim ingreso As String

        If asistenciasAnterioresCheck.Checked = False Then 'ACTUAL ASISTENCIA
            ingreso = "GETDATE()"
            'HEntradaV.Refresh()
            salida = "NULL"
            impresion = "0"
        Else 'ASISTENCIA CON FECHA ANTERIOR
            ingreso = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HEntradaV.Value.ToLongTimeString
            ingreso = "'" + Convert.ToDateTime(ingreso).ToString(en.DateTimeFormat) + "'" 'formato FechaHora ingreso
            salida = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HSalidaV.Value.ToLongTimeString
            salida = "'" + Convert.ToDateTime(salida).ToString(en.DateTimeFormat) + "'" 'formato FechaHora salida
            impresion = nImpresionS.Text
        End If

        'Cadena: Project, MemberId, Type, AssistanceDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, PrintNumber, EndDateTime
        sql = "INSERT INTO  dbo.MemberAssistanceProgram VALUES ('" + S + "', " + MiembroV.Text + ", " + type + ", " + ingreso + ", GETDATE(), ' ', '" + U + "', NULL, '" + ObservacionesS.Text + "'," + impresion + ", " + salida + ")"

        bdInsertar(sql)
        'InputBox("", "", sql)
        ListadoAsistencia()

        If asistenciasAnterioresCheck.Checked = False Then
            valoresInicialesNuevaAsistencia()
        Else
            valoresInicialesAsistenciaAnterior()
        End If

    End Sub

    Private Sub irMiembrosDeFamilia()
        Dim nxt As New MiembrosFamilia
        nxt.familyId = FamiliaV.Text
        nxt.transac = "COAS"
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiar()
        ApadrinadoFoto.Image = Nothing
        dt.Clear()
        sql = ""
        MiembroV.Text = ""
        'MiembroS.Text = "Miembro"
        NotasV.Text = ""
        fotoDire = ""
        NombreS.Text = "Nombre"
        TipoMiembroS.Text = "tipo de miembro"
        nImpresionS.Text = "0"
        ObservacionesS.Text = ""
        'EdadS.Text = ""

        MiembroV.Focus()
        'SeleccionadoTable.Visible = False
    End Sub

    Private Sub ListadoAsistencia()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()

        Dim today As DateTime = FechaV.Value 'Date.Today
        '
        sql = "SELECT convert(varchar(50), MAP.AssistanceDateTime, 120) fecha, MAP.MemberId AS Miembro, M.FirstNames + ' ' + M.LastNames AS Nombre, " + _
             "CONVERT(varchar(10),MAP.AssistanceDateTime,108) AS Entrada, " + _
             "CONVERT(varchar(10),MAP.EndDateTime,108) AS Salida, " + _
            "PrintNumber Impresiones, MAP.Notes as Observaciones, dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro, M.lastFamilyId Familia, MAP.UserId AS Usuario, 'Borrar' '-' " + _
            "FROM dbo.MemberAssistanceProgram MAP " + _
            "INNER JOIN dbo.Member M ON MAP.Project = M.Project AND MAP.MemberId = M.MemberId AND MAP.RecordStatus = M.RecordStatus " + _
            "INNER JOIN dbo.CdMemberActivityType cdMAT ON MAP.Type = cdMAT.CodeInt AND MAP.Project = cdMAT.Project " + _
            "WHERE MAP.RecordStatus = ' ' AND MAP.Project = '" + S + "' AND YEAR(MAP.AssistanceDateTime) = " + today.Year.ToString + _
            " AND MONTH(MAP.AssistanceDateTime) = " + today.Month.ToString + " AND DAY(MAP.AssistanceDateTime) = " + today.Day.ToString + "  " + _
            " AND cdMAT.DescSpanish = '" + TipoList.Text + "' " + _
            "ORDER BY  MAP.AssistanceDateTime DESC, MAP.CreationDateTime DESC "
        'InputBox("", "", sql)
        bdGrid(sql, ListadoGrid)

        Dim n As String = ListadoGrid.Rows.Count
        For f = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Item(0, f).Value = n
            ListadoGrid.Item(1, f).Value = "Actualizar"
            ListadoGrid.Item(2, f).Value = "Salida"
            n = n - 1
        Next

        MiembroV.Focus()
        ListadoGrid.Columns(2).ReadOnly = False
        ListadoGrid.Columns.Item(3).Visible = False 'MAP.Type -- col0 #, col1 modif, col2 salida col3 fecha
        agregarColumnaAccion(13, ListadoGrid)
        'ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub ListadoGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoGrid.CellContentDoubleClick
        Dim col = ListadoGrid.CurrentCellAddress.X
        Dim fila = ListadoGrid.CurrentCellAddress.Y

        If col = 13 Then
            borrarAsistencia(ListadoGrid.Item(4, fila).Value, ListadoGrid.Item(3, fila).Value)
        End If
    End Sub

    Private Sub ListadoGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        Dim f, c As Integer
        c = ListadoGrid.CurrentCellAddress.X
        f = ListadoGrid.CurrentCellAddress.Y

        If c = 1 Then
            miembroSeleccionado(f)
        ElseIf c = 2 Then
            Dim fSalida As String = chequearValor(ListadoGrid.Item(9, f).Value)
            If Len(fSalida) <= 1 Then
                GuardarSalida(ListadoGrid.Item(4, f).Value, ListadoGrid.Item(3, f).Value)
            Else
                MsgBox("Ya tiene datos de salida", vbExclamation, My.Resources.versionFamilias2)
            End If
            'SeleccionadoTable.Visible = False
            limpiar()
        Else
            'SeleccionadoTable.Visible = False
            limpiar()
        End If
    End Sub

    Private Sub miembroSeleccionado(ByVal fila As Integer)
        tipoR = "M"
        MiembroV.Text = ListadoGrid.Item(4, fila).Value
        NombreS.Text = ListadoGrid.Item(5, fila).Value
        TipoMiembroS.Text = "(" + ListadoGrid.Item(10, fila).Value + ")"
        nImpresionS.Text = ListadoGrid.Item(8, fila).Value
        ObservacionesS.Text = ListadoGrid.Item(9, fila).Value
        dateA = ListadoGrid.Item(3, fila).Value
        salidaCheckBox.Checked = True
        HEntradaV.Value = Convert.ToDateTime(ListadoGrid.Item(6, fila).Value)

        If Len(chequearValor(ListadoGrid.Item(7, fila).Value)) > 0 Then
            salidaSel = ListadoGrid.Item(7, fila).Value
            HSalidaV.Value = Convert.ToDateTime(salidaSel)
        Else
            salidaSel = ""
            HSalidaV.Value = Date.Now
        End If

        HEntradaV.Enabled = False
        MiembroV.ReadOnly = True

        EntradaL.Visible = True
        HEntradaV.Visible = True
        SalidaL.Visible = True
        HSalidaV.Visible = True
        ImpresionesS.Visible = True
        nImpresionS.Visible = True
        salidaCheckBox.Visible = True

        If verFotoCheck.Checked = True Then
            datosMiembro() '(MiembroS.Text)
            fotoDire = ""
            Dim afilDesGrad As String = chequearValor(dt.Rows(0)("Estado"))
            fotoDire = chequearValor(dt.Rows(0)("Foto"))
            fotoMiembro()
        End If
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If BuscarCheck.Checked = True Then
                buscar()
            Else
                Guardar()
            End If

        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub nImpresionS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nImpresionS.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Guardar()
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New RegistroCDIs
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ObservacionesS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ObservacionesS.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Guardar()
        End If
    End Sub

    Private Sub TipoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoList.SelectedIndexChanged
        ListadoAsistencia()
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
        Dim order, wP As String
        If S = "N" Then
            order = "CodeInt"
            wP = " AND Project = '" + S + "' "
        Else
            order = "DescSpanish"
            wP = " AND Project IN ('*', '" + S + "') "
        End If

        sql = "SELECT CodeInt, DescSpanish FROM dbo.CdMemberActivityType " + _
              "WHERE Active = 1  " + wP + " AND FunctionalArea = 'APJO' AND CodeInt IS NOT NULL " + _
              "ORDER BY " + order
        bdCombo(sql, TipoList, "CodeInt", "DescSpanish")

        sql = "SELECT CASE WHEN CustomField4 IS NULL THEN 'NO' ELSE CustomField4 END AS PreAct FROM dbo.FwEmployee " + _
              "WHERE EmployeeId = '" + U + "' AND DefaultOrganization = '" + S + "'"
        Dim codeAct As String = bdPalabra(sql, "PreAct")

        If codeAct = "NO" Then
            TipoList.Text = ""
        Else
            sql = "SELECT  DescSpanish FROM dbo.CdMemberActivityType WHERE  CodeInt = " + codeAct + " "
            codeAct = bdPalabra(sql, "DescSpanish")
            TipoList.Text = codeAct
        End If

        ListadoAsistencia()
        valoresInicialesNuevaAsistencia()
        'GuardarButton.Visible = True
    End Sub

    Private Sub valoresInicialesAsistenciaAnterior()
        tipoR = "A"
        MiembroV.Text = ""
        FamiliaV.Text = ""
        NombreS.Text = "Nombre"
        TipoMiembroS.Text = "Tipo Miembro"
        nImpresionS.Text = "0"
        ObservacionesS.Text = ""
        fotoDire = ""
        salidaCheckBox.Checked = True
        asistenciasAnterioresCheck.Checked = True

        MiembroV.ReadOnly = False
        HEntradaV.Enabled = True

        EntradaL.Visible = True
        HEntradaV.Visible = True
        SalidaL.Visible = True
        HSalidaV.Visible = True
        ImpresionesS.Visible = True
        nImpresionS.Visible = True
        salidaCheckBox.Visible = True
        ApadrinadoFoto.Visible = False
    End Sub

    Private Sub valoresInicialesNuevaAsistencia()
        tipoR = "N"
        FechaV.Value = Date.Now
        MiembroV.Text = ""
        FamiliaV.Text = ""
        NombreS.Text = "Nombre"
        TipoMiembroS.Text = "Tipo Miembro"
        HSalidaV.Value = Date.Now
        HEntradaV.Value = Date.Now
        nImpresionS.Text = "0"
        ObservacionesS.Text = ""
        fotoDire = ""
        salidaCheckBox.Checked = False
        asistenciasAnterioresCheck.Checked = False

        MiembroV.ReadOnly = False
        FamiliaV.ReadOnly = False
        HEntradaV.Enabled = True

        EntradaL.Visible = False
        HEntradaV.Visible = False
        SalidaL.Visible = False
        HSalidaV.Visible = False
        ImpresionesS.Visible = False
        nImpresionS.Visible = False
        salidaCheckBox.Visible = False
        ApadrinadoFoto.Visible = False
    End Sub

End Class

'Private Sub ActualizarButton_Click(sender As Object, e As EventArgs) Handles ActualizarButton.Click
'    actualizar()
'End Sub

'Private Sub Asistencia_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
'    HEntradaV.Value = Date.Now
'End Sub

'Private Sub Asistencia_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
'    HEntradaV.Refresh()
'End Sub

'Private Sub BorrarButton_Click(sender As Object, e As EventArgs) Handles BorrarButton.Click
'    borrarAsistencia()
'End Sub

'Private Sub RegistroCDIs_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
'    HEntradaV.Value = Date.Now
'End Sub
