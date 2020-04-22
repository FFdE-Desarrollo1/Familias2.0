' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AsistenciaExcel
    Dim nombre, tipoMiembro As String

    Private Sub AsistenciaExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub buscarDuplicados()
        Dim qty As Integer = 500
        Dim m(qty), t(qty), i, j, valor, act, dup, n As Integer
        Dim d(qty), fecha As Date
        Dim list As String = ""

        n = ListadoGrid.Rows.Count() - 1

        For i = 0 To n
            m(i) = ListadoGrid.Item(5, i).Value()
            t(i) = ListadoGrid.Item(3, i).Value()
            If Len(ListadoGrid.Item(2, i).Value()) > 0 Then
                d(i) = Convert.ToDateTime(ListadoGrid.Item(2, i).Value()).ToShortDateString
            End If
        Next

        For i = 0 To n
            valor = m(i)
            act = t(i)
            fecha = d(i)
            For j = i + 1 To n
                If S = "N" And valor = 50 Then
                Else
                    If valor = m(j) And act = t(j) And fecha = d(j) Then
                        dup = dup + 1
                        list = list + valor.ToString + ", "
                        ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
                        ListadoGrid.Item(0, i).Value = False
                    End If
                End If
            Next
        Next

        DuplicadosV.Visible = True
        DuplicadosV.Text = list
    End Sub

    Private Sub buscarNoValidos()
        Dim i As Integer
        For i = 0 To ListadoGrid.Rows.Count() - 1
            If ListadoGrid.Item(7, i).Value = "Miembro No_Válido".ToUpper _
                Or ListadoGrid.Item(9, i).Value = "Actividad No_Válida".ToUpper _
                Or ListadoGrid.Item(10, i).Value = "Usuario No_Válido".ToUpper Then
                ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.SandyBrown
                ListadoGrid.Item(0, i).Value = False
            End If
        Next
    End Sub

    Private Sub columnasRead()
        ListadoGrid.Columns(1).ReadOnly = True
        ListadoGrid.Columns(2).ReadOnly = True
        ListadoGrid.Columns(3).ReadOnly = True
        ListadoGrid.Columns(4).ReadOnly = True
        ListadoGrid.Columns(5).ReadOnly = True
        ListadoGrid.Columns(6).ReadOnly = True
        ListadoGrid.Columns(7).ReadOnly = True
        ListadoGrid.Columns(8).ReadOnly = True
        ListadoGrid.Columns(9).ReadOnly = True
        ListadoGrid.Columns(10).ReadOnly = True
    End Sub

    Private Function descActividad(ByVal actividadInt As String) As String
        sql = "SELECT COUNT(*) Total FROM dbo.CdMemberActivityType WHERE CodeInt = " + actividadInt + " "
        If bdEntero(sql, "Total") = 0 Then
            descActividad = "Actividad No_Válida".ToUpper
        Else
            sql = "SELECT DescSpanish Actividad FROM dbo.CdMemberActivityType WHERE CodeInt = " + actividadInt + " "
            descActividad = chequearValor(bdPalabra(sql, "Actividad"))
        End If
    End Function

    Private Sub Duplicados_Click(sender As Object, e As EventArgs) Handles Duplicados.Click
        buscarDuplicados()
    End Sub

    Private Sub infoGen(ByVal miembro As String)
        If miembroEsValido(S, miembro) = True Then
            sql = "SELECT FirstNames + ' ' + LastNames AS Name, dbo.fn_GEN_tipoMiembro(Project, MemberId) TipoMiembro " + _
                  "FROM dbo.Member WHERE memberId = " + miembro + " AND RecordStatus = ' ' AND Project = '" + S + "' "
            nombre = chequearValor(bdPalabra(sql, "Name"))
            tipoMiembro = chequearValor(bdPalabra(sql, "TipoMiembro"))
        Else
            nombre = "Miembro No_Válido".ToUpper
            tipoMiembro = ""
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub insertarAsistencia(ByVal member As String, _
                       ByVal type As String, _
                       ByVal activityDT As String, _
                       ByVal actual As String, _
                       ByVal user As String, _
                       ByVal notes As String)
        'insertSQL = "INSERT INTO dbo.MemberActivity (Project, MemberId, Type, ActivityDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes) " + _
        '"VALUES ('" + S + "', " + member + ", '" + type + "', '" + activityDT + "', '" + actual + "', ' ', '" + user + "', NULL, '" + NotesV.Text + "') "
        sql = "INSERT INTO dbo.MemberAssistanceProgram (Project, MemberId, Type, AssistanceDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, EndDateTime) " + _
                    "VALUES ('" + S + "', " + member + ", " + type + ", '" + activityDT + "', '" + actual + "', ' ', '" + user + "', NULL, '" + conversionValorTextBox(notes) + "', NULL) "
        bdInsertar(sql)
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New AsistenciaExcel
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Dim actualDate As Date = Date.Now
        Dim checkIt As New CheckBox
        Dim i, n, nI As Integer
        n = ListadoGrid.Rows.Count()
        For i = 0 To n - 1
            If ListadoGrid.Item(0, i).Value() = True Then
                insertarAsistencia(ListadoGrid.Item(5, i).Value(), ListadoGrid.Item(3, i).Value(), DateTime.Parse(ListadoGrid.Item(2, i).Value()).ToString(en.DateTimeFormat), _
                                   actualDate.ToString(en.DateTimeFormat), ListadoGrid.Item(10, i).Value(), chequearValor(ListadoGrid.Item(4, i).Value()))
            End If
        Next

        sql = "SELECT COUNT(*) as Total FROM dbo.MemberAssistanceProgram WHERE RecordStatus = ' ' AND Project = '" + S + _
                   "' AND CreationDateTime = '" + actualDate.ToString(en.DateTimeFormat) + "' "
        nI = bdEntero(sql, "Total")

        MsgBox("Se ha ingresado " + nI.ToString + " asistencias", vbQuestion, My.Resources.versionFamilias2)
        GuardarButton.Visible = False
        UploadButton.Visible = False

        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        Dim response As MsgBoxResult
        response = MsgBox("¿Necesita revisar los ingresos?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            Dim nxt As New RegistroAsistencia
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Dim DGBox As New OpenFileDialog
        'DGBox.Filter = "Excel Worksheets|*.xlsx|All files (*.*)|*.*"
        DGBox.Filter = "Excel Worksheets|*.xlsx"
        DGBox.Multiselect = False
        DGBox.ShowDialog()
        If DGBox.FileName.Length > 0 Then
            MsgBox("Si aparecen marcados, por favor verifiquelos".ToUpper + Chr(13) + Chr(13) + _
                    "Los amarillos son posibles duplicados" + Chr(13) + _
                    "Los anaranjados son No_Válidos" + Chr(13) + Chr(13) + _
                    "De ser necesario ingreselos manualmente", MsgBoxStyle.Critical, My.Resources.versionFamilias2)

            Dim address As String = DGBox.FileName
            If importarAsistenciaDesdeExcel(address, ListadoGrid) = True Then
                ListadoGrid.Visible = True

                Dim colB As New DataGridViewTextBoxColumn
                colB.HeaderText = "Nombre (en Familias)"
                colB.Name = "NombreBD"
                ListadoGrid.Columns.Add(colB)

                Dim colC As New DataGridViewTextBoxColumn
                colC.HeaderText = "TipoMiembro"
                colC.Name = "TipoMiembro"
                ListadoGrid.Columns.Add(colC)

                Dim colA As New DataGridViewTextBoxColumn
                colA.HeaderText = "Actividad"
                colA.Name = "Actividad"
                ListadoGrid.Columns.Add(colA)

                Dim colD As New DataGridViewTextBoxColumn
                colD.HeaderText = "Usuario"
                colD.Name = "Usuario"
                ListadoGrid.Columns.Add(colD)

                Dim i As Integer = 0
                For i = 0 To ListadoGrid.Rows.Count - 1
                    infoGen(ListadoGrid.Item(5, i).Value().ToString)

                    ListadoGrid.Item(0, i).Value = True
                    ListadoGrid.Item(7, i).Value = nombre
                    ListadoGrid.Item(8, i).Value = tipoMiembro
                    ListadoGrid.Item(9, i).Value = descActividad(ListadoGrid.Item(3, i).Value().ToString)
                    ListadoGrid.Item(10, i).Value = usuario(ListadoGrid.Item(1, i).Value().ToString)
                Next

                buscarDuplicados()
                buscarNoValidos()
                EjemploPicture.Size = New Point(300, 65)
                InfoTable.Height = 70
                columnasRead()
                TotalV.Text = ListadoGrid.RowCount.ToString
                ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                TableLayoutPanel1.Visible = True
                opcionesTable.Visible = True
                GuardarButton.Visible = True
                UploadButton.Visible = False

                'inicioButton.Location = New Point(Me.Width - 200, 65)
            End If
        Else
            opcionesTable.Visible = False
            ListadoGrid.Visible = False
        End If
    End Sub

    Private Function usuario(ByVal empl As String) As String
        sql = "SELECT COUNT(*) Total FROM dbo.FwEmployee WHERE codeInt = '" + empl + "'"

        If bdPalabra(sql, "Total") > 0 Then
            sql = "SELECT EmployeeId FROM dbo.FwEmployee WHERE codeInt = '" + empl + "'"
            usuario = bdPalabra(sql, "EmployeeId")
        Else
            usuario = "Usuario No_Válido".ToUpper
        End If
    End Function


End Class