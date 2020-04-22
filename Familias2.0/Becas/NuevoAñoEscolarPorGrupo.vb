Public Class NuevoAñoEscolarPorGrupo
    Dim ahora As DateTime
    Dim style As MsgBoxStyle
    Dim response As MsgBoxResult
    Dim añoA, n As Integer
    Dim gradoId, escuelaId, nuevoN As String

    Private Sub NuevoAñoEscolarPorGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
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
                estado = " AND MEY.Status = '" + EstadoCombo.SelectedValue + "' "
            End If
            sql = "SELECT   CONVERT(nvarchar(30), MEY.CreationDateTime, 20) AS CreationDT, M.MemberId AS Miembro, M.FirstNames AS Nombres, M.LastNames AS Apellidos, " + _
                     "M.LastFamilyId AS Familia, cdES.DescSpanish AS Estado, cdES.Code " + _
                     "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.Member M ON MEY.Project = M.Project AND MEY.MemberId = M.MemberId AND MEY.RecordStatus = M.RecordStatus " + _
                     "INNER JOIN dbo.CdEducationStatus cdES ON MEY.Status = cdES.Code  " + _
                     "LEFT OUTER JOIN  dbo.MemberEducationYear MEY2 ON MEY.MemberId = MEY2.MemberId AND MEY.Project = MEY2.Project AND " + _
                     "MEY.RecordStatus = MEY2.RecordStatus And MEY2.SchoolYear = " + (añoA + 1).ToString + " " + _
                     "WHERE MEY.RecordStatus = ' ' AND MEY.Project = '" + S + "' AND MEY.SchoolYear = " + AñoV.Text + " AND MEY.Grade = '" + GradoCombo.SelectedValue + "' " + _
                     "AND MEY.SchoolCode = '" + EscuelaCombo.SelectedValue + "' " + estado + " AND MEY2.SchoolYear IS NULL " + _
                     "ORDER BY M.MemberId "
            'InputBox("SELECT", "", sql)
            bdGrid(sql, ListadoGrid)
            ListadoGrid.Columns.Item(1).Visible = False 'CreationDT
            ListadoGrid.Columns.Item(6).Visible = False 'Estado
            ListadoGrid.Columns.Item(7).Visible = False 'idEstado


            For i = 0 To ListadoGrid.RowCount - 1
                ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
            Next

            For i = 1 To ListadoGrid.ColumnCount - 1
                ListadoGrid.Columns(i).ReadOnly = True
            Next

            ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            ListadoGrid.AutoResizeColumns()

            ''nuevo estado 
            'sql = "SELECT Code, DescSpanish Estado FROM dbo.CdEducationStatus WHERE ValidValue = 1 AND InsertValue = 0 ORDER BY DescSpanish "
            'bdCombo(sql, nEstadoCombo, "Code", "Estado")

            nuevoGrado()
            registroTable.Visible = True
            SeleccionarCheck.Visible = True

            'inactivar campos de busqueda
            AñoV.Enabled = False
            GradoCombo.Enabled = False
            EscuelaCombo.Enabled = False
            EstadoCombo.Enabled = False
            CarreraCombo.Enabled = False

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
            CarreraCombo.DropDownStyle = ComboBoxStyle.Simple

            If ListadoGrid.RowCount > 0 Then
                BuscarButton.Visible = False
                GuardarButton.Visible = True
                nEstadoCombo.Visible = True
                'nEstadoL.Visible = True
                SeleccionarCheck.Visible = True
            End If

            SeleccionarCheck.Text = SeleccionarCheck.Text + " (" + ListadoGrid.RowCount.ToString + " registros)"
            ListadoGrid.Visible = True

            If ListadoGrid.RowCount = 0 Then
                MsgBox("Los candidatos de su busqueda ya tienen un registro escolar " + (añoA + 1).ToString, style, My.Resources.versionFamilias2)
            End If

        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Dim n As Integer = 0
        For i = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid.Item(0, i).Value = True Then
                n = n + 1
            End If
        Next

        If n > 0 Then
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            response = MsgBox("Verifique los datos en la seccion anaranjada" + vbLf + "¿Estan correctos para el ingreso del nuevo año escolar? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                response = MsgBox("¿Esta seguro de hacer el ingreso del nuevo año escolar? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    For i = 0 To ListadoGrid.RowCount - 1
                        If ListadoGrid.Item(0, i).Value = True Then
                            guardarNuevoAño(ListadoGrid.Item(2, i).Value)

                        End If
                    Next

                End If
            End If
        Else
            MsgBox("Necesita seleccionar por lo menos 1 registro", style, My.Resources.versionFamilias2)
        End If

    End Sub

    Private Sub guardarNuevoAño(ByVal miembro As String)
        GuardarButton.Visible = False
        Dim nCarrera As String
        If Len(nCarreraCombo.Text) > 0 Then
            nCarrera = "'" + nCarreraCombo.SelectedValue + "'"
        Else
            nCarrera = "NULL"
        End If
        ' Project, MemberId, SchoolYear, SchoolCode, Grade, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, ClassSection, 
        'PercentOfExpensesToPay, ReasonNotToContinue, Status, Career, SingleTeacher, TransportationStartDate, TransportationEndDate, Notes,
        'ExceptionPercent, HasCertificate, NYSPackage, Typing
        sql = "INSERT INTO dbo.MemberEducationYear VALUES('" + S + "', " + miembro + ", " + nAñoV.Text + ", '" + nEscuelaCombo.SelectedValue + "', " + _
                 "'" + nGradoCombo.SelectedValue + "', GETDATE(), ' ', '" + U + "', NULL, '" + nSeccionV.Text + "', NULL, NULL, '" + _
                 nEstadoCombo.SelectedValue + "', " + nCarrera + ", NULL, NULL, NULL, '', NULL, 0, 0, 0)"
        bdInsertar(sql)
        'InputBox("", "", sql)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New NuevoAñoEscolarPorGrupo
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub nuevoGrado()
        'nueva año
        nAñoV.Text = (añoA + 1).ToString

        'nueva grado
        sql = "SELECT Code, DescSpanish  Grado FROM dbo.CdGrade WHERE EducationLevel NOT IN ('CEIF', 'NOES', 'TERA', 'UNIV') ORDER BY Orden "
        bdCombo(sql, nGradoCombo, "Code", "Grado")

        If Len(GradoCombo.SelectedValue) > 0 And Len(GradoCombo.SelectedValue) < 5 Then
            sql = "SELECT CASE WHEN NExtGrade IS NULL THEN '' ELSE NextGrade END Next FROM dbo.CdGrade WHERE Code = '" + GradoCombo.SelectedValue + "' "
            nGradoCombo.SelectedValue = bdPalabra(sql, "Next")
        Else
            nGradoCombo.Text = ""
        End If

        'nueva estado
        sql = "SELECT Code, DescSpanish Estado FROM dbo.CdEducationStatus WHERE ValidValue = 1 AND InsertValue = 1 ORDER BY DescSpanish "
        bdCombo(sql, nEstadoCombo, "Code", "Estado")

        If EstadoCombo.SelectedValue = "GANO" Then
            nEstadoCombo.SelectedValue = "ESTU"
        ElseIf EstadoCombo.SelectedValue = "PERD" Or EstadoCombo.SelectedValue = "NOSI" Then
            nEstadoCombo.SelectedValue = "REPI"
        End If


        'nueva escuela
        Dim nivelesEduc As New DataTable
        sql = "SELECT EducationLevel FROM dbo.CdGrade WHERE CODE IN ('" + GradoCombo.SelectedValue + "', '" + nGradoCombo.SelectedValue + "')"
        bdDataTable(sql, nivelesEduc)
        Dim nivel1 = chequearValor(nivelesEduc.Rows(0)("EducationLevel"))
        Dim nivel2 = chequearValor(nivelesEduc.Rows(1)("EducationLevel"))

        sql = "SELECT Code, Name FROM dbo.School WHERE Project = '" + S + "' AND RecordStatus = ' ' AND Active= 1 ORDER BY Name"
        bdCombo(sql, nEscuelaCombo, "Code", "Name")

        If nivel1 = nivel2 Then
            nEscuelaCombo.SelectedValue = EscuelaCombo.SelectedValue
        End If


    End Sub

    Private Sub llenarCampos()
        If nEstadoCombo.Text = "System.Data.DataRowView" Then
        Else
            If EstadoCombo.SelectedValue = "GANO" Or EstadoCombo.SelectedValue = "GANC" Then
                'proximo estado
                nEstadoCombo.SelectedValue = "ESTU"

                'proximo grado
                sql = "SELECT CASE WHEN NextGrade IS NULL THEN '' ELSE NextGrade END Prox FROM CdGrade WHERE Code ='" + GradoCombo.SelectedValue + "' "
                Dim proxGrad = bdPalabra(sql, "Prox")
                nGradoCombo.SelectedValue = proxGrad

                'próxima escuela

                If proximoNivel(GradoCombo.SelectedValue) = proximoNivel(nGradoCombo.SelectedValue) Then
                    nEscuelaCombo.Text = EscuelaCombo.Text
                Else
                    nEscuelaCombo.Text = ""
                End If
            ElseIf EstadoCombo.SelectedValue = "PERD" Or EstadoCombo.SelectedValue = "PERS" Or EstadoCombo.SelectedValue = "NOSI" Or EstadoCombo.SelectedValue = "NOSR" Then
                'proximo estado
                nEstadoCombo.SelectedValue = "REPI"

                'proximo grado
                nGradoCombo.SelectedValue = GradoCombo.SelectedValue

                'próxima escuela
                nEscuelaCombo.Text = nEscuelaCombo.Text
            Else ' no tiene info anterior
                nGradoCombo.Text = ""
                nEscuelaCombo.Text = ""
            End If

            nCarreraCombo.SelectedValue = CarreraCombo.SelectedValue
        End If
    End Sub

    Private Function proximoNivel(ByVal grado) As String
        sql = "SELECT L.DescSpanish Nivel FROM CdGrade G INNER JOIN CdEducationLevel L ON G.EducationLevel = L.Code WHERE G.Code = '" + grado + "' "
        proximoNivel = bdPalabra(sql, "Nivel")
    End Function

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

        sql = "SELECT Code, DescSpanish  Grado FROM dbo.CdGrade WHERE EducationLevel NOT IN ('CEIF', 'NOES', 'TERA', 'UNIV') ORDER BY Orden "
        bdCombo(sql, GradoCombo, "Code", "Grado")

        sql = "SELECT Code, DescSpanish Estado FROM dbo.CdEducationStatus WHERE ValidValue = 1 AND InsertValue = 0 ORDER BY DescSpanish "
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