' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Francisco Berganza
' @updated: PatyL (Dic 2016)
' @version 1.0

Public Class BusquedaInfoEduc

    Private Sub BusquedaInfoEduc_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If L = "en" Then
            traducir()
            infoInicialEN()
        Else
            infoInicialES()
        End If
        TbAño.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub buscarButton_Click(sender As Object, e As EventArgs) Handles buscarButton.Click
        busqueda()
    End Sub

    'llena los ComboBox en inglés
    Private Sub infoInicialEN()
        sql = "SELECT Code, DescEnglish FROM dbo.CdEducationStatus  ORDER BY Orden"
        bdCombo(sql, CbEstadoEduc, "Code", "DescEnglish")
        'CbEstadoEduc.SelectedValue = "ERC"

        sql = "SELECT Code, DescEnglish FROM dbo.CdEducationReasonNotToContinue WHERE Active = 1 ORDER BY DescEnglish"
        bdCombo(sql, ExcepcionEstadoCombo, "Code", "DescEnglish")

        sql = "SELECT Code,  DescEnglish FROM dbo.CdGrade WHERE ValidValue=1 ORDER BY Orden"
        bdCombo(sql, CbGrado, "Code", "DescEnglish")

        sql = "SELECT Code, DescEnglish FROM dbo.CdEducationLevel"
        bdCombo(sql, CbNivelEduc, "Code", "DescEnglish")

        sql = "SELECT Code, DescEnglish FROM dbo.CdEducationCareer ORDER BY DescEnglish"
        bdCombo(sql, CbCarrera, "Code", "DescEnglish")

        sql = "SELECT Code, Name FROM dbo.School WHERE Project='" + S + "' and RecordStatus=' ' and Active=1 ORDER BY Name"
        bdCombo(sql, CbEscuela, "Code", "Name")

        sql = "SELECT Code, DescEnglish FROM dbo.CdSchoolType"
        bdCombo(sql, CbTipoEscuela, "Code", "DescEnglish")

        sql = "SELECT Code, DescEnglish FROM dbo.CdAffiliationType ORDER BY DescEnglish"
        bdCombo(sql, CbTipoAfil, "Code", "DescEnglish")

        sql = "SELECT EmployeeId FROM dbo.FwEmployeeRole WHERE Organization='" + S + "' and Role='MSTR' and Status='ACTV' ORDER BY EmployeeId"
        bdComboSinCodigo(sql, CbMaestro)

        sql = "SELECT Code, DescEnglish FROM dbo.CdGeographicArea WHERE Project='" + S + "' and Active=1 ORDER BY DescEnglish"
        bdCombo(sql, CbPueblo, "Code", "DescEnglish")

        TbAño.Text = Now.Year.ToString
    End Sub

    'llena los ComboBox en español
    Private Sub infoInicialES()
        sql = "SELECT Code, DescSpanish FROM dbo.CdEducationStatus ORDER BY Orden"
        bdCombo(sql, CbEstadoEduc, "Code", "DescSpanish")
        'CbEstadoEduc.SelectedValue = "ERC"

        sql = "SELECT Code, DescSpanish FROM dbo.CdEducationReasonNotToContinue WHERE Active = 1 ORDER BY DescSpanish"
        bdCombo(sql, ExcepcionEstadoCombo, "Code", "DescSpanish")

        sql = "SELECT  Code, DescSpanish FROM dbo.CdGrade WHERE ValidValue=1 ORDER BY Orden"
        bdCombo(sql, CbGrado, "Code", "DescSpanish")

        sql = "SELECT Code, DescSpanish FROM dbo.CdEducationLevel"
        bdCombo(sql, CbNivelEduc, "Code", "DescSpanish")

        sql = "SELECT Code,  DescSpanish FROM dbo.CdEducationCareer ORDER BY DescSpanish"
        bdCombo(sql, CbCarrera, "Code", "DescSpanish")

        sql = "SELECT Code, Name FROM dbo.School WHERE Project='" + S + "' and RecordStatus=' ' and Active=1 ORDER BY Name"
        bdCombo(sql, CbEscuela, "Code", "Name")

        sql = "SELECT Code, DescSpanish FROM dbo.CdSchoolType"
        bdCombo(sql, CbTipoEscuela, "Code", "DescSpanish")

        sql = "SELECT Code, DescSpanish FROM dbo.CdAffiliationType ORDER BY DescSpanish"
        bdCombo(sql, CbTipoAfil, "Code", "DescSpanish")

        sql = "SELECT EmployeeId FROM dbo.FwEmployeeRole WHERE Organization='" + S + "' and Role='MSTR' and Status='ACTV' ORDER BY EmployeeId"
        bdComboSinCodigo(sql, CbMaestro)

        sql = "SELECT Code, DescSpanish FROM dbo.CdGeographicArea WHERE Project='" + S + "' and Active=1 ORDER BY DescSpanish"
        bdCombo(sql, CbPueblo, "Code", "DescSpanish")

        TbAño.Text = Now.Year.ToString
    End Sub

    'para que acepte solo número en la fecha
    Private Sub TbAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
    End Sub

    Private Function validarCampos() As Boolean
        If Len(TbAño.Text) = 0 Then
            If L = "en" Then
                MsgBox("For information on the year", vbInformation, My.Resources.versionFamilias2)
            Else
                MsgBox("Necesita información en el año", vbInformation, My.Resources.versionFamilias2)
            End If
            validarCampos = False

        ElseIf ChApadrinados.Checked = False And ChDesafiliados.Checked = False And ChGraduados.Checked = False Then
            If L = "en" Then
                MsgBox("You need to check any of the types of member", vbInformation, My.Resources.versionFamilias2)
            Else
                MsgBox("Necesita chequear alguno de los tipos de miembro", vbInformation, My.Resources.versionFamilias2)
            End If
            validarCampos = False
        Else
            validarCampos = True
        End If

    End Function

    'para validar el tipo de miembro
    Private Function tipoMiembro() As String
        Dim tipo, Tafil As String

        tipo = ""
        If ChApadrinados.Checked = True Then
            tipo = tipo + "'AFIL',"
        End If
        If ChDesafiliados.Checked = True Then
            tipo = tipo + "'DESA',"
        End If
        If ChGraduados.Checked = True Then
            tipo = tipo + "'GRAD',"
        End If

        'borra la coma del tipo de miembro
        Dim ultimoChar As Integer = Len(tipo) - 1
        tipo = tipo.Remove(Len(tipo) - 1, 1)

        Tafil = " AND M.AffiliationStatus IN (" + tipo + ")"
        tipoMiembro = Tafil

    End Function

    'listado de candidatos según la búsqueda en español
    Private Sub ListadoES()
        DataGridListado.DataSource = Nothing
        DataGridListado.Rows.Clear()
        Dim Sql, selectSQL, wSQL As String
        selectSQL = "Select	M.MemberId as Miembro, M.LastFamilyId as Familia, M.FirstNames as Nombre, M.LastNames as Apellidos,  " + _
                "F.Classification as Clasificación, FER.EmployeeId as TS, MEY.SchoolYear as Año, CdG.DescSpanish as Grado, " + _
                "Sc.Name as Escuela, CdES.DescSpanish as Estado_Educativo,  cdEx.DescSpanish AS 'Excepción_EstadoEduc', CdEC.DescSpanish as Carrera, " + _
                "CdAT.DescSpanish as Tipo_Afiliación, PG.TipoMiembro, F.Pueblo as Pueblo, PG.Region as Región " + _
                "From	dbo.fn_GEN_PoblacionGeneral() PG " + _
                "INNER JOIN Member M ON (PG.Miembro=M.MemberId) and (PG.Sitio=M.Project) " + _
                "INNER JOIN Family F ON (M.Project=F.Project) and (M.RecordStatus=F.RecordStatus) and (M.LastFamilyId=F.FamilyId)" + _
                "INNER JOIN CdAffiliationType CdAT ON (M.AffiliationType=CdAT.Code) " + _
                "INNER JOIN CdAffiliationStatus CdAS ON (CdAS.Code=M.AffiliationStatus) " + _
                "LEFT JOIN MemberEducationYear MEY ON (M.Project=MEY.Project) and (M.MemberId=MEY.MemberId) and (M.RecordStatus=MEY.RecordStatus) " + _
                "LEFT JOIN FamilyEmployeeRelation FER ON (FER.Project=F.Project) and (FER.FamilyId=F.FamilyId) and (FER.RecordStatus=F.RecordStatus) and FER.Role='TS' AND FER.EndDate IS NULL " + _
                "INNER JOIN CdGrade CdG ON (cdG.Code=MEY.Grade) " + _
                "INNER JOIN CdEducationLevel CdEL ON (CdEL.Code=CdG.EducationLevel)" + _
                "INNER JOIN School Sc ON (Sc.Project=MEY.Project) and (Sc.Code=MEY.SchoolCode) and Sc.RecordStatus=' ' and Sc.Active=1 " + _
                "INNER JOIN CdEducationStatus CdES ON (CdES.Code=MEY.Status) " + _
                "INNER JOIN CdSchoolType CdST ON (CdST.Code=Sc.SchoolType)" + _
                "LEFT JOIN CdEducationCareer CdEC ON (CdEC.Code=MEY.Career) " + _
                "LEFT JOIN CdEducationReasonNotToContinue cdEx ON cdEx.Code = MEY.ReasonNotToContinue " + _
                "WHERE	M.RecordStatus=' ' and MEY.SchoolYear= " + TbAño.Text + " AND M.Project= '" + S + "' "

        wSQL = ""
        If CbEstadoEduc.Text = "" And CbNivelEduc.Text = "" And CbGrado.Text = "" And CbCarrera.Text = "" And CbEscuela.Text = "" And CbTipoAfil.Text = "" And CbMaestro.Text = "" And CbPueblo.Text = "" And ExcepcionEstadoCombo.Text = "" Then

            wSQL = wSQL + tipoMiembro() + "Order by M.MemberId, M.LastFamilyId"

            'Sql = selectSQL + wSQL
            'bdGrid(Sql, DataGridListado)
            'numeracion()
            'agregarColumnaAccion(0, DataGridListado)
            'agregarColumnaAccion(1, DataGridListado)
            'DataGridListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Else
            'Estado de Educación
            If CbEstadoEduc.Text <> "" Then
                If CbEstadoEduc.SelectedValue = "ERC" Then 'Estudiando, Repitiendo o Condicional
                    wSQL = wSQL + " AND MEY.Status IN ('ESTU', 'REPI', 'COND', 'ESEF', 'ESTA', 'ESTE', 'REPE', 'REPF') "
                ElseIf CbEstadoEduc.SelectedValue = "ULTA" Then '_Graduandos (Estudiando y Repitiendo Ultimo Año, Graduado)
                    wSQL = wSQL + " AND MEY.Status IN ('ESTG', 'REPG', 'GRAD','GRAE', 'GRAP') "
                ElseIf CbEstadoEduc.SelectedValue = "NOEX" Then 'no tiene registro escolar
                    wSQL = wSQL + " AND MEY.SchoolYear IS NULL "
                Else
                    wSQL = wSQL + " AND CdES.DescSpanish LIKE '" + CbEstadoEduc.Text + "' "
                End If
            End If

            'Excepción de estado educativo
            If ExcepcionEstadoCombo.Text <> "" Then
                wSQL = wSQL + " AND cdEx.DescSpanish = '" + ExcepcionEstadoCombo.Text + "' "
            End If

            'Grado
            If CbGrado.Text <> "" Then
                wSQL = wSQL + " AND CdG.DescSpanish LIKE '" + CbGrado.Text + "' "
            End If

            'Nivel Educativo
            If CbNivelEduc.Text <> "" Then
                wSQL = wSQL + " AND CdEL.DescSpanish LIKE '" + CbNivelEduc.Text + "' "
            End If

            'Carrera
            If CbCarrera.Text <> "" Then
                wSQL = wSQL + " AND CdEC.DescSpanish LIKE '" + CbCarrera.Text + "' "
            End If

            'Escuela
            If CbEscuela.Text <> "" Then
                wSQL = wSQL + " AND Sc.Name LIKE '" + CbEscuela.Text + "' "
            End If

            'Tipo de Escuela
            If CbTipoEscuela.Text <> "" Then
                wSQL = wSQL + " AND CdST.DescSpanish LIKE '" + CbTipoEscuela.Text + "' "
            End If

            'Tipo de Afiliación
            If CbTipoAfil.Text <> "" Then
                wSQL = wSQL + " AND CdAT.DescSpanish LIKE '" + CbTipoAfil.Text + "' "
            End If

            'Por Maestro
            If CbMaestro.Text <> "" Then
                wSQL = wSQL + " AND MEY.SingleTeacher LIKE '" + CbMaestro.Text + "' "
            End If

            'Pueblo
            If CbPueblo.Text <> "" Then
                wSQL = wSQL + " AND F.Pueblo LIKE '" + CbPueblo.Text + "' "
            End If

            wSQL = wSQL + tipoMiembro() + "Order by M.MemberId, M.LastFamilyId"
        End If


        Sql = selectSQL + wSQL
        'InputBox("", "", "", wSQL)
        bdGrid(Sql.ToString, DataGridListado)
        numeracion()
        agregarColumnaAccion(0, DataGridListado)
        agregarColumnaAccion(1, DataGridListado)
    End Sub

    'listado de candidatos según la búsqueda en inglés
    Private Sub ListadoEN()
        DataGridListado.DataSource = Nothing
        DataGridListado.Rows.Clear()
        Dim Sql, selectSQL, wSQL As String

        selectSQL = "Select	M.MemberId as Member_Id, M.LastFamilyId as Family_Id, M.FirstNames as First_Names, M.LastNames as Last_Names,  " + _
                "F.Classification as Classification, FER.EmployeeId as Social_Worker, MEY.SchoolYear as School_Year, CdG.DescEnglish as Grade, " + _
                "Sc.Name as School_Name, CdES.DescEnglish as Education_Status, cdEx.DescEnglish AS 'Exception_StatusEduc', CdEC.DescEnglish as Career, " + _
                "CdAT.DescEnglish as Affiliation_Type, PG.TipoMiembro, F.Pueblo as Town, PG.Region as Region " + _
                "From	dbo.fn_GEN_PoblacionGeneral() PG " + _
                "INNER JOIN Member M ON (PG.Miembro=M.MemberId) and (PG.Sitio=M.Project) " + _
                "INNER JOIN Family F ON (M.Project=F.Project) and (M.RecordStatus=F.RecordStatus) and (M.LastFamilyId=F.FamilyId)" + _
                "INNER JOIN CdAffiliationType CdAT ON (M.AffiliationType=CdAT.Code) " + _
                "INNER JOIN CdAffiliationStatus CdAS ON (CdAS.Code=M.AffiliationStatus) " + _
                "INNER JOIN MemberEducationYear MEY ON (M.Project=MEY.Project) and (M.MemberId=MEY.MemberId) and (M.RecordStatus=MEY.RecordStatus) " + _
                "INNER JOIN FamilyEmployeeRelation FER ON (FER.Project=F.Project) and (FER.FamilyId=F.FamilyId) and (FER.RecordStatus=F.RecordStatus) and FER.Role='TS' AND FER.EndDate IS NULL " + _
                "INNER JOIN CdGrade CdG ON (cdG.Code=MEY.Grade) " + _
                "INNER JOIN CdEducationLevel CdEL ON (CdEL.Code=CdG.EducationLevel)" + _
                "INNER JOIN School Sc ON (Sc.Project=MEY.Project) and (Sc.Code=MEY.SchoolCode) and Sc.RecordStatus=' ' and Sc.Active=1 " + _
                "INNER JOIN CdEducationStatus CdES ON (CdES.Code=MEY.Status) " + _
                "INNER JOIN CdSchoolType CdST ON (CdST.Code=Sc.SchoolType)" + _
                "LEFT JOIN CdEducationCareer CdEC ON (CdEC.Code=MEY.Career) " + _
                "LEFT JOIN CdEducationReasonNotToContinue cdEx ON cdEx.Code = MEY.ReasonNotToContinue " + _
                "WHERE	M.RecordStatus=' ' and MEY.SchoolYear= " + TbAño.Text + " AND M.Project= '" + S + "' "


        wSQL = ""
        If CbEstadoEduc.Text = "" And CbNivelEduc.Text = "" And CbGrado.Text = "" And CbCarrera.Text = "" And CbEscuela.Text = "" And CbTipoAfil.Text = "" And CbMaestro.Text = "" And CbPueblo.Text = "" Then

            wSQL = wSQL + tipoMiembro() + "Order by M.MemberId, M.LastFamilyId"
        Else
            'Estado de Educación
            If CbEstadoEduc.Text <> "" Then
                If CbEstadoEduc.SelectedValue = "ERC" Then 'Estudiando, Repitiendo o Condicional
                    wSQL = wSQL + " AND MEY.Status IN ('ESTU', 'REPI', 'COND','ESEF', 'ESTA', 'ESTE', 'REPE', 'REPF') "
                ElseIf CbEstadoEduc.SelectedValue = "ULTA" Then '_Graduandos (Estudiando y Repitiendo Ultimo Año, Graduado)
                    wSQL = wSQL + " AND MEY.Status IN ('ESTG', 'REPG', 'GRAD','GRAE', 'GRAP') "
                ElseIf CbEstadoEduc.SelectedValue = "NOEX" Then 'no tiene registro escolar
                    wSQL = wSQL + " AND MEY.SchoolYear IS NULL "
                Else
                    wSQL = wSQL + " AND CdES.DescSpanish LIKE '" + CbEstadoEduc.Text + "' "
                End If
            End If

            'Excepción de estado educativo
            If ExcepcionEstadoCombo.Text <> "" Then
                wSQL = wSQL + " AND cdEx.DescEnglish = '" + ExcepcionEstadoCombo.Text + "' "
            End If

            'Grado
            If CbGrado.Text <> "" Then
                wSQL = wSQL + " AND CdG.DescEnglish LIKE '" + CbGrado.Text + "' "
            End If

            'Nivel Educativo
            If CbNivelEduc.Text <> "" Then
                wSQL = wSQL + " AND CdEL.DescEnglish LIKE '" + CbNivelEduc.Text + "' "
            End If

            'Carrera
            If CbCarrera.Text <> "" Then
                wSQL = wSQL + " AND CdEC.DescEnglish LIKE '" + CbCarrera.Text + "' "
            End If

            'Escuela
            If CbEscuela.Text <> "" Then
                wSQL = wSQL + " AND Sc.Name LIKE '" + CbEscuela.Text + "' "
            End If

            'Tipo de Escuela
            If CbTipoEscuela.Text <> "" Then
                wSQL = wSQL + " AND CdST.DescEnglish LIKE '" + CbTipoEscuela.Text + "' "
            End If

            'Tipo de Afiliación
            If CbTipoAfil.Text <> "" Then
                wSQL = wSQL + " AND CdAT.DescEnglish LIKE '" + CbTipoAfil.Text + "' "
            End If

            'Por Maestro
            If CbMaestro.Text <> "" Then
                wSQL = wSQL + " AND MEY.SingleTeacher LIKE '" + CbMaestro.Text + "' "
            End If

            'Pueblo
            If CbPueblo.Text <> "" Then
                wSQL = wSQL + " AND F.Pueblo LIKE '" + CbPueblo.Text + "' "
            End If

            wSQL = wSQL + tipoMiembro() + "Order by M.MemberId, M.LastFamilyId"
            'Sql = selectSQL + wSQL
            'bdGrid(Sql, DataGridListado)
            'numeracion()
            'agregarColumnaAccion(0, DataGridListado)
            'agregarColumnaAccion(1, DataGridListado)
            'DataGridListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If

        Sql = selectSQL + wSQL
        bdGrid(Sql, DataGridListado)
        numeracion()
        agregarColumnaAccion(0, DataGridListado)
        agregarColumnaAccion(1, DataGridListado)
        DataGridListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub


    'hacia perfilMiembro o perfilFamilia al dar clic en el grid
    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim columna As Integer = DataGridListado.CurrentCellAddress.X
        Dim fila As Integer = DataGridListado.CurrentCellAddress.Y

        If columna = 0 Then
            Dim pm As New PerfilMiembro
            pm.MiembroV.Text = DataGridListado.Item(0, fila).Value().ToString
            pm.Show()
            Me.Close()
        ElseIf columna = 1 Then
            Dim pf As New PerfilFamilia
            pf.FamiliaV.Text = DataGridListado.Item(1, fila).Value().ToString
            pf.Show()
            Me.Close()
        End If
    End Sub

    'valida y llama al grid
    Private Sub busqueda()
        If validarCampos() = True Then
            If L = "en" Then
                ListadoEN()
            Else
                ListadoES()
            End If

            'DataGridListado.Size = New Point(766, 560)
            'DataGridListado.Location = New Point(7, 151)
            DataGridListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'MsgBox("...")
            TotalL.Text = "Total: " + DataGridListado.Rows.Count.ToString
            TotalL.Visible = True
            'CamposPanel.Size = New Point(10, 10)
            CamposPanel.Visible = False
            DataGridListado.Visible = True
        End If
    End Sub

    'numeración para el grid
    Private Sub numeracion()
        For i = 0 To DataGridListado.Rows.Count - 1
            DataGridListado.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        'Dim nxt As New BusquedaInfoEduc
        'nxt.Show()
        'Me.Close()

        CamposPanel.Visible = True
        DataGridListado.Visible = False
        TotalL.Visible = False
    End Sub

    Private Sub inicioButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    'traducciones para el form
    Private Sub traducir()
        Dim tr As New recursosFamilias
        Title.Text = tr.traduce("SearchByYearOfEducationInformation")
        AñoL.Text = tr.traduce("Year") + ":"
        EstadoEducL.Text = tr.traduce("EducationStatus") + ":"
        GradoL.Text = tr.traduce("Grade") + ":"
        NivelEducL.Text = tr.traduce("EducationLevel")
        CarreraL.Text = tr.traduce("Career")
        EscuelaL.Text = tr.traduce("SchoolName")
        TipoEscuelaL.Text = tr.traduce("SchoolType")
        TipoAfilL.Text = tr.traduce("AffiliationType")
        MaestroL.Text = tr.traduce("Teacher")
        PuebloL.Text = tr.traduce("Town")
        TiposL.Text = tr.traduce("MemberType")

        ChApadrinados.Text = tr.traduce("Affiliate")
        ChDesafiliados.Text = tr.traduce("Disaffiliates")
        ChGraduados.Text = tr.traduce("Graduates")

        otrasBusquedasL.Text = tr.traduce("OtherSearchs")
        OtraInfoLink.Text = tr.traduce("MemberSearchByOtherInfo")

    End Sub

    Private Sub CbNivelEduc_Click(ByVal sender As Object, ByVal e As EventArgs)
        If CbNivelEduc.SelectedIndex = 0 Then
            CbGrado.Enabled = True
        Else
            CbGrado.Enabled = False
        End If
    End Sub

    Private Sub CbGrado_Click(ByVal sender As Object, ByVal e As EventArgs)
        If CbGrado.SelectedIndex = 0 Then
            CbNivelEduc.Enabled = True
        Else
            CbNivelEduc.Enabled = False
        End If
    End Sub

    Private Sub OtraInfoLink_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
        Dim nxt As New BusquedaOtraInfo
        nxt.Show()
        Me.Close()
    End Sub


End Class