Public Class AsistenciaENE
    Dim nDias As Integer
    Dim gradoSel, tipo, miembroSel As String
    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
    Dim response As MsgBoxResult

    Private Sub AsistenciaENE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
        gradoCombo.Focus()
    End Sub

    Private Sub ActualizarButton_Click(sender As Object, e As EventArgs) Handles ActualizarButton.Click
        If Integer.Parse(AsistenciasV.Text) >= 0 And Integer.Parse(AsistenciasV.Text) <= nDias Then
            Guardar(miembroSel, AsistenciasV.Text)
            listadoAsistencia()
            DatosActualizar(False)
        Else
            MsgBox("Verifique la cantidad de asistencias que ingresó. El máximo que puede ingresar es " + nDias.ToString, vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub AsistenciasV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AsistenciasV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
        End If

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

    Private Sub bloquearColumnas(ByVal n As Integer)
        For i = 0 To n - 1
            ListadoGrid.Columns(i).ReadOnly = True
        Next
    End Sub

    Private Sub DatosActualizar(ByVal visible As Boolean)
        If visible = True Then
            AlumnoSelL.Visible = True
            AlumnoSelV.Visible = True
            AsistenciasL.Visible = True
            AsistenciasV.Visible = True
            ActualizarButton.Visible = True
        Else
            AlumnoSelL.Visible = False
            AlumnoSelV.Visible = False
            AsistenciasL.Visible = False
            AsistenciasV.Visible = False
            ActualizarButton.Visible = False
        End If
    End Sub

    Private Function existeAsistencia() As Boolean
        sql = "SELECT COUNT(*) N FROM MemberAttendanceENE A " + _
              "INNER JOIN dbo.MemberEducationYear Y ON A.Project = Y.Project AND A.MemberId = Y.MemberId AND A.SchoolYear = Y.SchoolYear AND A.RecordStatus = Y.RecordStatus " + _
              "WHERE A.Recordstatus = ' ' AND A.Project = 'N' AND A.SchoolYear = " + _
              AñoV.Text + " AND Week =  " + SemanaCombo.SelectedValue.ToString + " AND Y.Grade = '" + GradoCombo.SelectedValue + "'"
        Dim n As Integer = bdEntero(sql, "N")
        If n = 0 Then
            existeAsistencia = False
        Else
            existeAsistencia = True
        End If
    End Function

    Private Sub Guardar(ByVal miembro As String, ByVal asistencia As String)
        sql = "INSERT INTO MemberAttendanceENE VALUES('" + S + "', " + miembro + ", " + SemanaCombo.SelectedValue.ToString + _
              ", " + AñoV.Text + ", GETDATE(), " + asistencia + ", ' ', '" + U + "', NULL)"
        'InputBox("", "", sql)
        bdInsertar(sql)
    End Sub

    Private Sub guardarAsistencia()
        If verificaAsistencia() = True Then
            For i = 0 To ListadoGrid.RowCount - 1
                Guardar(ListadoGrid(3, i).Value, ListadoGrid(0, i).Value)
            Next
        Else
            MsgBox("Verifique las asistencias en verde. El máximo que puede ingresar es " + nDias.ToString, vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        GuardarButton.Visible = False
        guardarAsistencia()
        listadoAsistencia()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT Attendance N FROM CdCalendarENE WHERE [Year] = " + AñoV.Text + " AND Code = " + SemanaCombo.SelectedValue.ToString
        nDias = bdEntero(sql, "N")
        tipo = "Ingreso"

        sql = "SELECT " + nDias.ToString + " Asistencia, M.LastNames AS Apellidos, M.FirstNames AS Nombres, M.MemberId AS Miembro  " + _
                "FROM dbo.Member M INNER JOIN dbo.MemberEducationYear MEY ON M.Project = MEY.Project AND M.MemberId = MEY.MemberId " + _
                "AND M.RecordStatus = MEY.RecordStatus  " + _
                "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "'  " + _
                "AND MEY.SchoolYear = " + AñoV.Text + " AND MEY.Grade = '" + GradoCombo.SelectedValue + "' " +
                " ORDER BY M.LastNames, M.FirstNames "
        bdGrid(sql, ListadoGrid)
        bloquearColumnas(3)
        ListadoGrid.Columns(0).ReadOnly = False 'Miembro
        'ListadoGrid.Columns(1).ReadOnly = True 'Apellidos
        'ListadoGrid.Columns(2).ReadOnly = True 'Nombre
        'ListadoGrid.Columns(3).ReadOnly = True 'Miembro

        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        ListadoGrid.ClearSelection()
        ListadoGrid.Columns(3).Selected = True
        nAlumnosL.Text = "Alumnos: " + ListadoGrid.RowCount.ToString
        nAlumnosL.Visible = True
        ListadoGrid.Visible = True
    End Sub

    Private Sub listadoAsistencia()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        tipo = "Asistencia"
        sql = "SELECT  M.MemberId Código, M.LastNames Apellidos, M.FirstNames Nombres, M.LastFamilyId Familia, A.Days Asistencias " + _
              "FROM dbo.MemberAttendanceENE A " + _
              "INNER JOIN dbo.Member M ON A.Project = M.Project AND A.MemberId = M.MemberId AND A.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.MemberEducationYear Y ON A.Project = Y.Project AND A.MemberId = Y.MemberId AND A.SchoolYear = Y.SchoolYear AND A.RecordStatus = Y.RecordStatus " + _
              "INNER JOIN dbo.CdGrade ON Y.Grade = dbo.CdGrade.Code " + _
              "WHERE A.RecordStatus = ' ' AND A.Project = 'N' AND A.SchoolYear = " + AñoV.Text + _
              " AND Y.Grade = '" + GradoCombo.SelectedValue + "' AND A.Week = " + SemanaCombo.SelectedValue.ToString + _
              " ORDER BY M.LastNames, M.FirstNames "
        bdGrid(sql, ListadoGrid)
        bloquearColumnas(5)
        ListadoGrid.Visible = True
    End Sub

    Private Sub ListadoButton_Click(sender As Object, e As EventArgs) Handles ListadoButton.Click
        If Len(AñoV.Text) > 0 And Len(GradoCombo.SelectedValue) > 0 And Len(SemanaCombo.SelectedValue) > 0 Then
            If existeAsistencia() = False Then
                ListadoButton.Visible = False
                AñoV.Enabled = False
                GradoCombo.Enabled = False
                SemanaCombo.Enabled = False
                GuardarButton.Visible = True
                listado()
            Else
                MsgBox("Este grado ya tiene asistencia en la semana seleccionada", vbQuestion, My.Resources.versionFamilias2)
                listadoAsistencia()
                GuardarButton.Visible = False
            End If

        Else
            MsgBox("Tiene que llenar todos los campos ", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub ListadoGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoGrid.CellContentDoubleClick
        If tipo = "Asistencia" Then
            Dim f As Integer
            f = ListadoGrid.CurrentCellAddress.Y
            response = MsgBox("¿Esta seguro de actualizar la asistencia de " + ListadoGrid.Item(1, f).Value() + " " + ListadoGrid.Item(2, f).Value() + "?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "SELECT Attendance N FROM CdCalendarENE WHERE [Year] = " + AñoV.Text + " AND Code = " + SemanaCombo.SelectedValue.ToString
                nDias = bdEntero(sql, "N")

                miembroSel = ListadoGrid.Item(0, f).Value()
                AlumnoSelV.Text = ListadoGrid.Item(1, f).Value() + " " + ListadoGrid.Item(2, f).Value()
                AsistenciasV.Text = ListadoGrid.Item(4, f).Value()
                DatosActualizar(True)
            Else
                DatosActualizar(False)
            End If
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        AñoV.Text = Now.Year.ToString
        nDias = 0
        AñoV.Enabled = True
        GradoCombo.Enabled = True
        SemanaCombo.Enabled = True
        ListadoButton.Visible = True
        GradoCombo.SelectedValue = -1
        SemanaCombo.SelectedValue = -1
        ListadoGrid.Visible = False
        nAlumnosL.Visible = False
        If Len(gradoSel) > 0 Then
            GradoCombo.SelectedValue = gradoSel
            GradoCombo.Enabled = False
        Else
            gradoSel = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        AñoV.Text = Now.Year.ToString
        sql = "SELECT Code, DescSpanish Grade FROM CdGrade " + _
              "WHERE EducationLevel IN ('PRIM', 'PREP') AND Code NOT IN ('DI', 'ET1', 'ET2', 'ET3', 'ET4', 'ET5', 'ET6') " + _
              "ORDER BY Rank "
        bdCombo(sql, GradoCombo, "Code", "Grade")

        ''grado del usuario
        sql = "SELECT CASE WHEN CustomField3 IS NULL THEN '' ELSE CustomField3 END Grado FROM FwEmployee WHERE EmployeeId = '" + U + "'"
        gradoSel = bdPalabra(sql, "Grado")
        If Len(gradoSel) > 0 Then
            GradoCombo.SelectedValue = gradoSel
            GradoCombo.Enabled = False
        Else
            gradoSel = ""
        End If

        sql = "SELECT Code, Week  FROM CdCalendarENE WHERE [Year] = " + AñoV.Text + " ORDER BY Code "

        bdCombo(sql, SemanaCombo, "Code", "Week")
    End Sub

    Private Function verificaAsistencia() As Boolean
        Dim n As Integer = 0
        For i = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid(0, i).Value >= 0 And ListadoGrid(0, i).Value <= nDias Then
                n = n + 1
            Else
                ListadoGrid.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                n = n - 1
            End If
        Next
        If n = ListadoGrid.RowCount Then
            verificaAsistencia = True
        Else
            verificaAsistencia = False
        End If
    End Function

    'Private Sub AñoV_Enter(sender As Object, e As EventArgs) Handles AñoV.Enter
    '    sql = "SELECT Code, Week  FROM CdCalendarENE WHERE [Year] = " + AñoV.Text + " ORDER BY Code "
    'End Sub


End Class