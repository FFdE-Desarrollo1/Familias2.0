' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class Recolector
    Dim descActividad, idActividad, nombre, edad As String
    Dim z As Integer = 0

    Private Sub Recolector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
    End Sub

    Private Sub actividad(ByVal actv As String)
        Dim dt As New DataTable
        sql = "SELECT Code,  DescSpanish FROM dbo.CdMemberActivityType WHERE codeInt = '" + actv + "'"
        bdDataTable(sql, dt)
        If dt.Rows.Count > 0 Then
            idActividad = chequearValor(dt.Rows(0)("Code"))
            descActividad = chequearValor(dt.Rows(0)("DescSpanish"))
        Else
            idActividad = "No_Válido"
            descActividad = "Actividad No_Válida".ToUpper
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub


    Private Sub buscarDuplicados()
        Dim qty As Integer = 500
        Dim m(qty), t(qty), i, j, n, valor, act, dup As Integer
        Dim d(qty), fecha As Date
        Dim list As String = ""
        n = ListGrid.Rows.Count() - 1

        For i = 0 To n
            m(i) = ListGrid.Item(3, i).Value()
            t(i) = ListGrid.Item(2, i).Value()
            d(i) = Convert.ToDateTime(ListGrid.Item(4, i).Value()).ToShortDateString
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
                        ListGrid.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
                        ListGrid.Item(0, i).Value = False
                    End If
                End If
            Next
        Next

        DuplicadosV.Visible = True
        DuplicadosV.Text = list
    End Sub

    Private Sub buscarNoValidos()
        Dim n, i As Integer
        n = ListGrid.Rows.Count() - 1

        For i = 0 To n
            If ListGrid.Item(6, i).Value = "Miembro No_Válido".ToUpper Or _
               ListGrid.Item(8, i).Value = "Actividad No_Válida".ToUpper Or _
               ListGrid.Item(10, i).Value = "Usuario No_Válido".ToUpper Then
                ListGrid.Rows(i).DefaultCellStyle.BackColor = Color.SandyBrown
                ListGrid.Item(0, i).Value = False
            End If
        Next
    End Sub

    Private Sub Duplicados_Click(sender As Object, e As EventArgs) Handles Duplicados.Click
        buscarDuplicados()
    End Sub

    Private Function formatoFecha(ByVal dat As String, _
                         ByVal tim As String) As String
        Dim dateActi, timeActi As Date
        dateActi = Convert.ToDateTime(dat)
        timeActi = Convert.ToDateTime(tim)

        Dim dt As New DateTime(dateActi.Year, dateActi.Month, dateActi.Day, timeActi.Hour, timeActi.Minute, timeActi.Second)
        formatoFecha = dt.ToString(en.DateTimeFormat)
    End Function

    Private Sub infoMiembro(ByVal id As String)
        sql = "SELECT Count(*) Total FROM dbo.Member WHERE memberId = " + id + " AND RecordStatus = ' ' AND Project = '" + S + "' "

        If bdPalabra(sql, "Total") > 0 Then
            sql = "SELECT FirstNames + ' ' + LastNames AS Name, dbo.fn_GEN_CalcularEdad(BirthDate) AS Edad FROM dbo.Member WHERE memberId = " + id + " AND RecordStatus = ' ' AND Project = '" + S + "' "
            nombre = chequearValor(bdPalabra(sql, "Name"))
            edad = chequearValor(bdPalabra(sql, "Edad"))
        Else
            nombre = "Miembro No_Válido".ToUpper
            edad = ""
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
                           ByVal user As String)
        'insertSQL = "INSERT INTO dbo.MemberActivity (Project, MemberId, Type, ActivityDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes) " + _
        '"VALUES ('" + S + "', " + member + ", '" + type + "', '" + activityDT + "', '" + actual + "', ' ', '" + user + "', NULL, '" + NotesV.Text + "') "
        sql = "INSERT INTO dbo.MemberAssistanceProgram (Project, MemberId, Type, AssistanceDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes, EndDateTime) " + _
                    "VALUES ('" + S + "', " + member + ", " + type + ", '" + activityDT + "', '" + actual + "', ' ', '" + user + "', NULL, '" + conversionValorTextBox(NotesV.Text) + "', NULL) "
        bdInsertar(sql)
    End Sub

    Private Sub leerArchivo()
        Dim DGBox As New OpenFileDialog
        DGBox.Filter = "Archivos de texto plano (.txt)|*.txt"
        DGBox.Multiselect = False
        DGBox.ShowDialog()
        If DGBox.FileName.Length > 0 Then
            Using Archivo As New System.IO.StreamReader(DGBox.FileName)
                Dim Columna() As String
                Dim Linea As Integer = 0
                While Not Archivo.EndOfStream
                    Columna = Archivo.ReadLine.Split(",")
                    Linea += 1
                    'indice, empleado, actividad, miembroId, fecha, hora)
                    llenarGrid(Linea, Columna(0), Columna(1), Columna(2).Replace(" "c, String.Empty), Columna(3), Columna(4))
                End While
            End Using

            ListGrid.Visible = True
            GuardarButton.Visible = True
            opcionesTable.Visible = True
            TableLayoutPanel1.Visible = True
            UploadButton.Visible = False

            MsgBox("Si aparecen marcados, por favor verifiquelos".ToUpper + Chr(13) + Chr(13) + _
                    "Los amarillos son posibles duplicados" + Chr(13) + _
                    "Los anaranjados son No_Válidos" + Chr(13) + Chr(13) + _
                    "De ser necesario ingreselos manualmente", MsgBoxStyle.Critical, My.Resources.versionFamilias2)

            'SearchIdButton.Location = New Point(Me.Width - 200, 65)
            NotesV.Focus()
        Else

        End If
    End Sub

    Private Sub llenarGrid(ByVal i As Integer, _
                       ByVal empl As String, _
                       ByVal Acti As String, _
                       ByVal memb As String, _
                       ByVal datA As String, _
                       ByVal timA As String)

        Dim a() As String = {True, empl, Acti, memb, datA, timA}
        ListGrid.Rows.Add(a)
        ListGrid.Columns.Item(1).Visible = False
        ListGrid.Columns.Item(2).Visible = False 'tipo asistencia
        ListGrid.Columns.Item(4).Visible = False 'fecha
        ListGrid.Columns.Item(5).Visible = False  'hora
        ListGrid.Columns.Item(9).Visible = False

        TotalV.Visible = True
        TotalL.Visible = True

        If z < ListGrid.Rows.Count Then
            actividad(Trim$(ListGrid.Item(2, z).Value()))
            infoMiembro(memb)
            ListGrid.Item(7, z).Value = formatoFecha(Trim$(ListGrid.Item(4, z).Value()), Trim$(ListGrid.Item(5, z).Value()))
            ListGrid.Item(8, z).Value = descActividad
            ListGrid.Item(9, z).Value = idActividad
            ListGrid.Item(10, z).Value = usuario(Trim$(ListGrid.Item(1, z).Value()))
            ListGrid.Item(6, z).Value = nombre
            ListGrid.Item(11, z).Value = edad
            ListGrid.Item(12, z).Value = tipo_Miembro(S, memb)
            z = z + 1
        End If


        TotalV.Text = ListGrid.Rows.Count.ToString
        buscarDuplicados()
        buscarNoValidos()
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New Recolector
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub guardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Dim actualDate As Date = Date.Now
        Dim checkIt As New CheckBox
        Dim i, n, nI As Integer
        n = ListGrid.Rows.Count()
        For i = 0 To n - 1
            If ListGrid.Item(0, i).Value() = True Then
                insertarAsistencia(ListGrid.Item(3, i).Value(), ListGrid.Item(2, i).Value(), ListGrid.Item(7, i).Value(), actualDate.ToString(en.DateTimeFormat), ListGrid.Item(10, i).Value())
            End If
        Next

        sql = "SELECT COUNT(*) as Total FROM dbo.MemberAssistanceProgram WHERE RecordStatus = ' ' AND Project = '" + S + _
                   "' AND CreationDateTime = '" + actualDate.ToString(en.DateTimeFormat) + "' "
        nI = bdEntero(sql, "Total")
        MsgBox("Se ha ingresado " + nI.ToString + " asistencias" + Chr(13) + Chr(13) + Chr(13) + _
               "(Si la cantidad es 0 quizas el archivo ya habia sido cargado anteriormente) ", vbQuestion, My.Resources.versionFamilias2)
        GuardarButton.Visible = False
        UploadButton.Visible = False
        NotesV.Text = ""
        DuplicadosV.Text = ""
        TotalV.Text = ""

        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        Dim response As MsgBoxResult
        response = MsgBox("¿Necesita revisar los ingresos?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            Dim nxt As New RegistroAsistencia
            nxt.Show()
            Me.Close()
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

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        leerArchivo()
    End Sub

End Class