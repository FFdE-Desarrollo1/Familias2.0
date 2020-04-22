' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActualizaEstadoPorGrupo
    Dim ahora As DateTime
    Dim style As MsgBoxStyle
    Dim response As MsgBoxResult
    Dim añoA, n As Integer
    Dim gradoId, escuelaId As String

    Private Sub ActualizaEstadoPorGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub actualizarEstado(ByVal miembro As Integer, ByVal creacion As String, ByVal estadoAct As String)
        Dim nEstado = "'" + nEstadoCombo.SelectedValue + "'"
        ahora = DateTime.Now

        sql = "INSERT INTO  dbo.MemberEducationYear " + _
                "SELECT Project, MemberId, SchoolYear, SchoolCode,  Grade, '" + ahora.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, " + _
                "'" + U + "' UserId, ExpirationDateTime, ClassSection, PercentOfExpensesToPay,  ReasonNotToContinue, " + nEstado + " Status,  Career, SingleTeacher, " + _
                "TransportationStartDate, TransportationEndDate, Notes, ExceptionPercent,  HasCertificate, NYSPackage, Typing " + _
                "FROM  dbo.MemberEducationYear " + _
                "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + miembro.ToString + " AND SchoolYear = " + AñoV.Text + " AND Grade = '" + gradoId + "' " + _
                "AND Status = '" + estadoAct + "' AND SchoolCode = '" + escuelaId + "'"
        bdInsertar(sql)
        'inactiva el historial del record
        sql = "UPDATE dbo.MemberEducationYear SET RecordStatus = 'H', ExpirationDateTime = '" + ahora.ToString(en.DateTimeFormat) + " '  " + _
              "WHERE  RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + miembro.ToString + " AND schoolYear = " + AñoV.Text + "  " + _
              "AND schoolCode = '" + escuelaId + "' AND grade = '" + gradoId + "' AND " + _
              "Convert(nvarchar(30), CreationDateTime, 20) = '" + creacion + "' "

        bdEjecutarSQL(sql)
        ingresarObservacion("ESTA", miembro)
        ingresarActividad(nEstadoCombo, miembro)

        'nuevoAño()
    End Sub

    Private Sub AñoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AñoV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        If Len(AñoV.Text) = 0 Or GradoCombo.SelectedIndex < 0 Or EscuelaCombo.SelectedIndex < 0 Then
            MsgBox("Necesita llenar todos los campos con *", vbInformation, My.Resources.versionFamilias2)
        Else
            Dim estado As String = ""
            If EstadoCombo.SelectedIndex < 0 Then
                estado = " AND cdES.InsertValue = 1 "
            Else
                estado = " AND Status = '" + EstadoCombo.SelectedValue + "' "
            End If
            sql = "SELECT   CONVERT(nvarchar(30), MEY.CreationDateTime, 20) AS CreationDT, M.MemberId AS Miembro, M.FirstNames + ' ' + M.LastNames AS Nombre, " + _
                     "M.LastFamilyId AS Familia, cdES.DescSpanish AS Estado, cdES.Code " + _
                     "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.Member M ON MEY.Project = M.Project AND MEY.MemberId = M.MemberId AND MEY.RecordStatus = M.RecordStatus " + _
                     "INNER JOIN dbo.CdEducationStatus cdES ON MEY.Status = cdES.Code  " + _
                     "WHERE MEY.RecordStatus = ' ' AND MEY.Project = '" + S + "' AND MEY.SchoolYear = " + AñoV.Text + " AND MEY.Grade = '" + GradoCombo.SelectedValue + "' " + _
                     "AND MEY.SchoolCode = '" + EscuelaCombo.SelectedValue + "' " + estado + " " + _
                     "ORDER BY M.MemberId "
            'InputBox("SELECT", "", sql)
            bdGrid(sql, ListadoGrid)
            ListadoGrid.Columns.Item(1).Visible = False 'CreationDT
            ListadoGrid.Columns.Item(6).Visible = False 'idEstado

            For i = 0 To ListadoGrid.RowCount - 1
                ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
            Next

            For i = 1 To ListadoGrid.ColumnCount - 1
                ListadoGrid.Columns(i).ReadOnly = True
            Next

            ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            ListadoGrid.AutoResizeColumns()

            'nuevo estado 
            sql = "SELECT Code, DescSpanish Estado FROM dbo.CdEducationStatus WHERE ValidValue = 1 AND InsertValue = 0 ORDER BY DescSpanish "
            bdCombo(sql, nEstadoCombo, "Code", "Estado")

            'inactivar campos de busqueda
            AñoV.Enabled = False
            GradoCombo.Enabled = False
            EscuelaCombo.Enabled = False
            EstadoCombo.Enabled = False

            If Len(EstadoCombo.Text) > 0 Then
                EstadoCombo.Enabled = False
            Else
                EstadoCombo.Visible = False
                EstadoL.Visible = False
            End If

            If Len(SeccionV.Text) > 0 Then
                SeccionV.Enabled = False
            Else
                SeccionV.Visible = False
                SeccionL.Visible = False
            End If

            gradoId = GradoCombo.SelectedValue
            escuelaId = EscuelaCombo.SelectedValue

            EscuelaCombo.DropDownStyle = ComboBoxStyle.Simple
            GradoCombo.DropDownStyle = ComboBoxStyle.Simple
            EstadoCombo.DropDownStyle = ComboBoxStyle.Simple

            If ListadoGrid.RowCount > 0 Then
                BuscarButton.Visible = False
                GuardarButton.Visible = True
                nEstadoCombo.Visible = True
                nEstadoL.Visible = True
                SeleccionarCheck.Visible = True
            End If
            ListadoGrid.Visible = True

        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If nEstadoCombo.SelectedIndex < 0 Then
            MsgBox("Necesita seleccionar el *Nuevo Estado", vbInformation, My.Resources.versionFamilias2)
        Else
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            response = MsgBox("¿Esta seguro de cambiar el estado educativo a todos los seleccionados? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                GuardarButton.Visible = False
                For i = 0 To ListadoGrid.RowCount - 1
                    If ListadoGrid.Item(0, i).Value = True Then
                        actualizarEstado(ListadoGrid.Item(2, i).Value, ListadoGrid.Item(1, i).Value, ListadoGrid.Item(6, i).Value)
                    End If
                Next
                If n > 0 Then
                    MsgBox("Se ha ingresado " + n.ToString + " actividad(es) automática(s) de ""gano o perdió grado"" ", vbInformation, My.Resources.versionFamilias2)
                End If
                ingresos()
            End If
        End If
    End Sub

    Private Sub ingresarActividad(ByRef estado As ComboBox, ByVal miembro As Integer)
        If estado.SelectedValue = "GANO" Or estado.SelectedValue = "GANC" Or estado.SelectedValue = "PERD" Or estado.SelectedValue = "PERS" Then
            Dim actividad As String = ""
            actividad = "'EGAN'"

            If estado.SelectedValue = "GANO" Or estado.SelectedValue = "GANC" Then
                actividad = "'EGAN'"
            ElseIf estado.SelectedValue = "PERD" Or estado.SelectedValue = "PERS" Then
                actividad = "'EPER'"
            End If
            If Len(actividad) > 0 Then

                Dim fechaT As String
                If Integer.Parse(AñoV.Text) = DateTime.Today.Year Then
                    fechaT = ahora.ToString(en.DateTimeFormat)
                Else
                    fechaT = AñoV.Text + "/12/31 " + Now.ToLongTimeString
                End If
                sql = "INSERT INTO MemberActivity VALUES ('" + S + "', " + miembro.ToString + ", " + actividad + ", '" + fechaT + "', GETDATE(), ' ', '" + U + "', NULL, '')"
                bdInsertar(sql)
                n += 1
            End If

        End If
    End Sub

    Private Sub ingresarObservacion(ByVal idCategoria As String, ByVal miembro As Integer)
        Dim n As Integer
        sql = "SELECT MAX(IdObservation) 'Ultimo' FROM MemberEducationObservation "
        n = bdEntero(sql, "Ultimo") + 1

        sql = "INSERT INTO MemberEducationObservation VALUES (" + n.ToString + ", GETDATE(), '" + S + "', " + miembro.ToString + ", '" + idCategoria + "', GETDATE(), '', ' ', '" + U + "', NULL)"
        bdInsertar(sql)
    End Sub

    Private Sub ingresos()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        sql = "SELECT  M.MemberId AS Miembro, M.FirstNames + ' ' + M.LastNames AS Nombre, " + _
         "M.LastFamilyId AS Familia, cdES.DescSpanish AS Estado  " + _
         "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.Member M ON MEY.Project = M.Project AND MEY.MemberId = M.MemberId AND MEY.RecordStatus = M.RecordStatus " + _
         "INNER JOIN dbo.CdEducationStatus cdES ON MEY.Status = cdES.Code  " + _
         "WHERE MEY.RecordStatus = ' ' AND MEY.Project = '" + S + "' AND MEY.SchoolYear = " + AñoV.Text + " AND MEY.Grade = '" + gradoId + "' " + _
         "AND MEY.SchoolCode = '" + EscuelaCombo.SelectedValue + "' AND MEY.Status = '" + nEstadoCombo.SelectedValue + "'   " + _
         "AND YEAR(MEY.CreationDateTime)  = " + ahora.Year.ToString + " " + _
         "AND MONTH(MEY.CreationDateTime)  = " + ahora.Month.ToString + " " + _
         "AND DAY(MEY.CreationDateTime)  = " + ahora.Day.ToString + " " + _
          "AND { fn HOUR(MEY.CreationDateTime) }  = " + ahora.Hour.ToString + " " + _
          "AND { fn MINUTE(MEY.CreationDateTime) }  = " + ahora.Minute.ToString + " " + _
         "ORDER BY M.MemberId "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(0).Visible = False 'Selección
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()
        ListadoGrid.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ActualizaEstadoPorGrupo
        nxt.Show()
        Me.Close()
    End Sub


    Private Sub SeleccionarCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SeleccionarCheck.CheckedChanged
        For i = 0 To ListadoGrid.RowCount - 1
            ListadoGrid.Item(0, i).Value = SeleccionarCheck.Checked
        Next
    End Sub

    Private Sub valoresIniciales()
        If DateTime.Now.Month >= 10 Then
            añoA = DateTime.Now.Year
        Else
            añoA = DateTime.Now.Year - 1
        End If
        AñoV.Text = añoA.ToString

        sql = "SELECT Code, DescSpanish  Grado FROM dbo.CdGrade WHERE EducationLevel NOT IN ('NOES', 'TERA', 'UNIV') ORDER BY Orden "
        bdCombo(sql, GradoCombo, "Code", "Grado")

        sql = "SELECT Code, DescSpanish Estado FROM dbo.CdEducationStatus WHERE ValidValue = 1 AND InsertValue = 1 ORDER BY DescSpanish "
        bdCombo(sql, EstadoCombo, "Code", "Estado")

        sql = "SELECT Code, Name FROM dbo.School WHERE Project = '" + S + "' AND RecordStatus = ' ' AND Active= 1 ORDER BY Name"
        bdCombo(sql, EscuelaCombo, "Code", "Name")

        If S = "R" Then
            SeccionL.Visible = True
            SeccionV.Visible = True
        End If
        n = 0
    End Sub




End Class