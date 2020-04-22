' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class BusquedaOtraInfo

    Private Sub BusquedaOtraInfo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
        NombresV.Focus()
    End Sub

    Private Sub añoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ApellidosV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            busqueda()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub busqueda()
        If validarCampos() = True Then
            listado()
            TotalL.Text = "Total: " + ListadoGrid.Rows.Count.ToString
            TotalL.Visible = True
            CamposPanel.Visible = False
            ListadoGrid.Visible = True
        End If
    End Sub

    Private Sub buscarButton_Click_1(sender As Object, e As EventArgs) Handles buscarButton.Click
        busqueda()
    End Sub

    Private Sub inicioButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        Dim whereSQL As String
        If S = "E" Or S = "A" Then
            sql = "SELECT Sitio, Miembro, Familia, Nombres, Apellidos, [Nombre Usual], [Fecha Nacimiento], Género, TipoMiembro, Dirección " + _
                     "FROM dbo.fn_GEN_PoblacionGeneral() L " + _
                     "WHERE L.Sitio = '" + S + "' "
        Else
            If conInfoEducL.Checked = False Then 'Con Info General
                sql = "SELECT * " + _
                      "FROM  dbo.fn_GEN_PoblacionGeneral() L " + _
                      "WHERE L.Sitio = '" + S + "' "

            Else 'con Info Educ
                sql = "SELECT L.*, MEY.SchoolYear AS Año, cdG.DescSpanish AS Grado, cdES.DescSpanish AS Estado_Educ, MEY.ClassSection AS Sección, " + _
                      "cdL.DescSpanish AS Nivel_Educ, S.Name AS Escuela, cdEC.DescSpanish AS Carrera " + _
                      "FROM dbo.fn_GEN_PoblacionGeneral() L " + _
                      "LEFT OUTER JOIN dbo.MemberEducationYear MEY ON L.Sitio = MEY.Project AND L.Miembro = MEY.MemberId AND MEY.RecordStatus = ' ' " + _
                      "AND MEY.SchoolYear = " + AñoV.Text + " AND MEY.Grade = dbo.fn_GEN_getActualGrade(MEY.Project, MEY.MemberId, MEY.SchoolYear)  " + _
                      "LEFT OUTER JOIN dbo.CdGrade cdG ON MEY.Grade = cdG.Code " + _
                      "LEFT OUTER JOIN dbo.CdEducationStatus cdES ON cdES.Code = MEY.Status " + _
                      "LEFT OUTER JOIN dbo.CdEducationCareer cdEC ON cdEC.Code = MEY.Career " + _
                      "LEFT OUTER JOIN dbo.School S ON S.Project = MEY.Project AND S.RecordStatus = MEY.RecordStatus AND S.Code = MEY.SchoolCode " + _
                      "LEFT OUTER JOIN dbo.CdEducationLevel cdL ON cdL.Code = cdG.EducationLevel " + _
                      "WHERE L.Sitio = '" + S + "' "
            End If
        End If
        whereSQL = ""

        'nombres
        If Len(NombresV.Text) > 0 Then
            whereSQL = whereSQL + " AND L.Nombres LIKE '" + NombresV.Text + "' "
        End If

        'apellidos
        If Len(ApellidosV.Text) > 0 Then
            whereSQL = whereSQL + " AND L.Apellidos LIKE '" + ApellidosV.Text + "' "
        End If

        'nombre usual
        If Len(nombreUV.Text) > 0 Then
            whereSQL = whereSQL + " AND [Nombre Usual] LIKE '" + nombreUV.Text + "' "
        End If

        'pueblo
        If Len(PuebloCombo.Text) > 0 Then
            whereSQL = whereSQL + " AND L.Pueblo = '" + PuebloCombo.Text + "' "
        End If

        'area
        If Len(AreaCombo.Text) > 0 Then
            whereSQL = whereSQL + " AND L.Area = '" + AreaCombo.Text + "' "
        End If

        sql = sql + whereSQL + tipoMiembro() + " ORDER BY Nombres, TipoMiembro "
        'InputBox("", "", sql)
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(0).Visible = False ' Sitio
        numeracion()
        agregarColumnaAccion(1, ListadoGrid)
        agregarColumnaAccion(2, ListadoGrid)
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub NombresV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            busqueda()
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        'Dim nxt As New BusquedaOtraInfo
        'nxt.Show()
        'Me.Close()
        CamposPanel.Visible = True
        ListadoGrid.Visible = False
        TotalL.Visible = False
    End Sub

    Private Sub numeracion()
        For i = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
    End Sub

    Private Function tipoMiembro() As String
        Dim tipo As String = ""
        If S = "E" Or S = "A" Then
        Else
            If ApadrinadosCheck.Checked = True Then
                tipo = tipo + ",'" + ApadrinadosCheck.Text + "'"
            End If

            If DesafiliadosCheck.Checked = True Then
                tipo = tipo + ",'" + DesafiliadosCheck.Text + "'"
            End If

            If graduadosCheck.Checked = True Then
                tipo = tipo + ",'" + graduadosCheck.Text + "'"
            End If

            If OtrosCheck.Checked = True Then
                tipo = tipo + ",'" + OtrosCheck.Text + "'"
            End If

            If familiaresACheck.Checked = True Then
                tipo = tipo + ",'" + familiaresACheck.Text + "'"
            End If

            If familiaresDCheck.Checked = True Then
                tipo = tipo + ",'" + familiaresDCheck.Text + "'"
            End If

            If familiaresGCheck.Checked = True Then
                tipo = tipo + ",'" + familiaresGCheck.Text + "'"
            End If

            If InactivosCheck.Checked = True Then
                If Len(tipo) = 0 Then
                    tipo = " AND TipoMiembro like '%(Inactivo)%'"
                Else
                    tipo = " AND (TipoMiembro IN (" + tipo.Remove(0, 1) + ") OR TipoMiembro like '%(Inactivo)%')"
                End If
            Else
                tipo = " AND TipoMiembro IN (" + tipo.Remove(0, 1) + ")"
            End If
        End If
        tipoMiembro = tipo
    End Function

    Private Sub traducir()
        Dim tr As New recursosFamilias
        ApadrinadosCheck.Text = tr.traduce("Affiliate")
        ApellidosL.Text = tr.traduce("LastNames") + ":*"
        conInfoEducL.Text = tr.traduce("IncludeEducationInformation")
        DesafiliadosCheck.Text = tr.traduce("Disaffiliate")
        familiaresACheck.Text = tr.traduce("Familiar")
        familiaresDCheck.Text = tr.traduce("RelativesOfDisaffiliatedFamilies")
        familiaresGCheck.Text = tr.traduce("RelativesOfGraduatedFamilies")
        graduadosCheck.Text = tr.traduce("Graduate")
        InactivosCheck.Text = tr.traduce("Inactive")
        nacimientoL.Text = tr.traduce("BirthDate")
        NombresL.Text = tr.traduce("Names") + ":*"
        nombreUL.Text = tr.traduce("PreferredName") + ":*"
        OtrosCheck.Text = tr.traduce("Others")
        PuebloL.Text = tr.traduce("Town")
        TiposL.Text = tr.traduce("MemberType")
        TSL.Text = tr.traduce("SocialWorker")
        Title.Text = tr.traduce("MemberSearchByOtherInfo")
    End Sub

    Private Function validarCampos() As Boolean
        Dim result As Boolean

        If Len(NombresV.Text) = 0 And Len(ApellidosV.Text) = 0 And Len(nombreUV.Text) = 0 And Len(diaNacV.Text) = 0 And Len(añoNacV.Text) = 0 _
           And Len(MesCombo.Text) = 0 Then
            MsgBox("Necesita información en alguno de los campos disponibles", vbInformation, My.Resources.versionFamilias2)
            result = False
        Else
            If S = "E" Or S = "A" Then
                result = True
            Else
                If ApadrinadosCheck.Checked = False And familiaresACheck.Checked = False And DesafiliadosCheck.Checked = False And familiaresDCheck.Checked = False _
                And graduadosCheck.Checked = False And familiaresGCheck.Checked = False _
                And OtrosCheck.Checked = False And InactivosCheck.Checked = False Then
                    MsgBox("Necesita chequear alguno de los tipos de miembro", vbInformation, My.Resources.versionFamilias2)
                    result = False
                Else
                    result = True
                End If
            End If
        End If
        validarCampos = result
    End Function

    Private Sub valoresIniciales()
        If L = "en" Then
            traducir()
        End If

        If S = "E" Or S = "A" Then
            conInfoEducL.Visible = False
            AñoV.Visible = False
            TiposL.Visible = False
            ApadrinadosCheck.Visible = False
            familiaresACheck.Visible = False
            DesafiliadosCheck.Visible = False
            familiaresDCheck.Visible = False
            graduadosCheck.Visible = False
            familiaresGCheck.Visible = False
            OtrosCheck.Visible = False
            InactivosCheck.Visible = False
            EducIncludTable.Visible = False
            AreaCombo.Visible = False
            AreaL.Visible = False
            PuebloCombo.Visible = False
            PuebloL.Visible = False
        End If

        sql = "SELECT Pueblo FROM dbo.CdGeographicArea WHERE Active = 1  AND Project = '" + S + "' " + _
              "GROUP BY Pueblo ORDER BY Pueblo "
        bdComboSinCodigo(sql, PuebloCombo)
        PuebloCombo.Size = New Point(50 + (50 * 5), 21)

        sql = "SELECT " + descripcion() + " FROM dbo.CdGeographicArea WHERE Active = 1  AND Project = '" + S + "' " + _
              "ORDER BY DescSpanish "
        bdComboSinCodigo(sql, AreaCombo)
        AreaCombo.Size = New Point(50 + (50 * 5), 21)

        AñoV.Text = Now.Year.ToString
    End Sub


End Class