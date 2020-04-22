Public Class NuevoAñoEscolar_PorGrupo
    Dim ahora As DateTime
    Dim style As MsgBoxStyle
    Dim response As MsgBoxResult
    Dim añoA, n As Integer
    Dim gradoId, escuelaId As String

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

    Private Sub GradoCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradoCombo.SelectedIndexChanged
        If GradoCombo.SelectedIndex = -1 Then
            codigoG.Text = ""
        Else
            codigoG.Text = GradoCombo.SelectedValue.ToString

        End If
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
                'nEstadoL.Visible = True
                SeleccionarCheck.Visible = True
            End If
            ListadoGrid.Visible = True

        End If
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
        sql = "SELECT Code, Name FROM dbo.School WHERE Project = '" + S + "' AND RecordStatus = ' ' AND Active= 1 ORDER BY Name"
        bdCombo(sql, nEscuelaCombo, "Code", "Name")
        nEscuelaCombo.SelectedValue = EscuelaCombo.SelectedValue
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