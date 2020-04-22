Public Class NuevaSolicitud
    Public idAnalisis As String
    Dim foto, folder As String
    Dim visitD As Integer
    Dim msError = "El número de familia que ingresó no es válido" + Chr(13) + _
               "Verifique que sea una familia afiliada"

    Private Sub NuevaSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()

        If Len(FamiliaV.Text) = 0 Then
            FamiliaV.Focus()
        Else
            verificarDatos()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub DimensionXV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DimensionXV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub DimensionYV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DimensionYV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ExoneradaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ExoneradaCheck.CheckedChanged
        If ExoneradaCheck.Checked = True Then
            HorasV.Text = "0"
            HorasV.Enabled = False
            EstadoV.SelectedValue = "TERH"
            EstadoV.Enabled = False
        Else
            HorasV.Text = ""
            HorasV.Enabled = True
            EstadoV.SelectedValue = -1
            EstadoV.Enabled = True
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            verificarDatos()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fotoInicial()
        Dim existeFoto As Boolean = System.IO.Directory.Exists(folder + "\" + foto)
        InputBox("", "", folder + "\" + foto)
        MsgBox(System.IO.Directory.EnumerateDirectories(folder + "\" + foto).ToString)



        If existeFoto = False Then
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                DirectorioV.Text = openFileDialog1.FileName()
                System.IO.File.Copy(openFileDialog1.FileName(), folder + "\" + foto)
                MsgBox("Foto guardada correctamente en:" + folder + "\" + foto, vbExclamation, My.Resources.versionFamilias2)
            Else
                MsgBox("El archivo de la foto no se puede abrir", vbCritical, My.Resources.versionFamilias2)
            End If

            'System.IO.File.Move(openFileDialog1.FileName(), directorio + "\" + S + FamiliaV.Text + "_" + FechaV.Value.Year.ToString + "Inicial.jpg")

        Else
            MsgBox("La foto ya existe", vbCritical, My.Resources.versionFamilias2)
            InputBox("", "", folder + "\" + foto)
        End If
    End Sub

    Private Sub FotoInicialButton_Click(sender As Object, e As EventArgs) Handles FotoInicialButton.Click
        folder = "C:\Users\PatyL\Documents\Viviendas\" + S + FamiliaV.Text
        foto = S + FamiliaV.Text + "_" + FechaV.Value.Year.ToString + "Inicial.jpg"

        Dim exists As Boolean = System.IO.Directory.Exists(folder)
        If exists = True Then
            fotoInicial()
        Else
            Directory.CreateDirectory(folder)
            fotoInicial()
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        If validarDatos() = True Then
            Dim id As String = S + FamiliaV.Text + "_" + Now.Year.ToString + Now.Month.ToString
            Dim exon, piso, pared, techo, visita, dirFoto As String
            If ExoneradaCheck.Checked = True Then
                exon = "1"
            Else
                exon = "0"
            End If

            If Len(PisoCombo.Text) > 0 Then
                piso = "'" + PisoCombo.SelectedValue + "'"
            Else
                piso = "NULL"
            End If

            If Len(ParedCombo.Text) > 0 Then
                pared = "'" + ParedCombo.SelectedValue + "'"
            Else
                pared = "NULL"
            End If

            If Len(TechoCombo.Text) > 0 Then
                techo = "'" + TechoCombo.SelectedValue + "'"
            Else
                techo = "NULL"
            End If

            If visitD > 0 Then
                visita = "'" + VisitaPicker.Value.ToString(en.DateTimeFormat) + "'"
            Else
                visita = "NULL"
            End If

            Dim exists As Boolean = System.IO.Directory.Exists(folder + "\" + foto)

            If exists = False Then
                dirFoto = "NULL"
            Else
                dirFoto = folder + "\" + foto
            End If
            sql = "INSERT INTO dbo.FamilyAmbFamSolicitude VALUES('" + id + "', '" + S + "', " + FamiliaV.Text + ", 'VIVI', '" + FechaV.Value.ToString(en.DateTimeFormat) + "', " + _
                "GETDATE(), ' ', '" + U + "', NULL, '" + EstadoV.SelectedValue + "', '" + EstadoPicker.Value.ToString(en.DateTimeFormat) + "', " + HorasV.Text + ", " + _
            exon + ", '" + NotasV.Text + "', 0, '" + SolicitaCombo.SelectedValue + "', " + CantidadV.Text + ", " + DimensionXV.Text + ", " + DimensionYV.Text + ", " + _
            piso + ", " + pared + ", " + techo + ", NULL, NULL,NULL, NULL, NULL, NULL, '" + idAnalisis + "')"
            'InputBox("", "", sql)
            bdInsertar(sql)

            sql = "SELECT COUNT(*) T FROM dbo.FamilyAmbFamSolicitude WHERE Recordstatus = ' ' AND IdSolicitude = '" + id + "'"
            If bdEntero(sql, "T") = 0 Then
                msError = "Hubo un error al guardar comuniquese con Sistemas"
                MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
            Else
                MsgBox("Ingreso correcto!", vbExclamation, My.Resources.versionFamilias2)
                GuardarButton.Visible = False
            End If
        Else
            msError = "Verifique que todos los campos con asterisco (*) tengan la información correspondiente"
            MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
        End If

    End Sub

    Private Sub HorasV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HorasV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ListadoButton_Clic(sender As Object, e As EventArgs) Handles ListadoButton.Click
        Dim nxt As New SolicitudesVivienda
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub miembrosMayores17()
        sql = "SELECT Edad, Nombre + ' (' + CONVERT(varchar, Miembro) + ')' Nombre, RelaciónFamiliar " + _
              "FROM dbo.v_TS_ViviendasMayores18 WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " ORDER BY Edad "
        bdGrid(sql, miembrosGrid)
        miembrosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        miembrosGrid.AutoResizeColumns()
    End Sub

    Private Sub nuevo()
        Dim nxt As New NuevaSolicitud
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        nuevo()
    End Sub

    Private Sub preAnalisis()
        sql = "SELECT dbo. fn_GEN_FormatDate(FLA.AnalysisDateTime, 'es') Fecha, CASE WHEN cdFLD.Applies = 1 THEN 'SI' ELSE 'NO' END + '-' + cdFLD.DescSpanish + '(' + cdFLD.Comments + ')' AS Aplica, FLA.Notes " + _
              "FROM dbo.FamilyLivingAnalysis FLA INNER JOIN dbo.CdFamilyLivingDiagnosis cdFLD ON FLA.Diagnosis = cdFLD.Code " + _
              "WHERE FLA.RecordStatus = ' ' AND FLA.IdAnalysis = '" + idAnalisis + "'"
        AplicaPAV.Text = bdPalabra(sql, "Aplica")
        FechaPAV.Text = bdPalabra(sql, "Fecha")
        NotasPAV.Text = bdPalabra(sql, "Notes")
    End Sub

    Private Function tieneAnalisis()
        sql = "SELECT COUNT(*) T FROM FamilyLivingAnalysis WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
        If bdEntero(sql, "T") = 0 Then
            tieneAnalisis = False
            msError = "La familia no cuenta con análisis preliminar"
        Else
            sql = "SELECT MAX(IdAnalysis) IdSol FROM FamilyLivingAnalysis WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
            idAnalisis = bdPalabra(sql, "IdSol")
            tieneAnalisis = True
        End If
    End Function

    Private Function validarDatos()
        'CantidadV.Text
        If Len(CantidadV.Text) = 0 Then
            MsgBox("La cantidad no puede estar vacía", vbCritical, My.Resources.versionFamilias2)
            validarDatos = False
        ElseIf Double.Parse(CantidadV.Text) <= 0 Then
            MsgBox("La cantidad debe ser mayor a 0", vbCritical, My.Resources.versionFamilias2)
            validarDatos = False
        ElseIf Len(DimensionXV.Text) = 0 Or Len(DimensionYV.Text) = 0 Then
            MsgBox("Las casillas para la dimensión para construir no pueden estar vacías", vbCritical, My.Resources.versionFamilias2)
            validarDatos = False
        ElseIf Double.Parse(DimensionXV.Text) <= 0 Or Double.Parse(DimensionYV.Text) <= 0 Then
            MsgBox("La dimensión para construir debe ser mayor a 0 en ambas casillas", vbCritical, My.Resources.versionFamilias2)
            validarDatos = False
        ElseIf EstadoV.SelectedIndex > -1 And Len(HorasV.Text) > 0 And SolicitaCombo.SelectedIndex > -1 And Len(CantidadV.Text) > 0 Then
            validarDatos = True
        Else
            validarDatos = False
        End If
    End Function

    Private Sub valoresIniciales()
        sql = "SELECT Address + ' - ' + Pueblo Direccion, dbo.fn_GEN_regionFamilia(F.Project, F.FamilyId) AS Region FROM dbo.Family F WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        DireccionV.Text = bdPalabra(sql, "Direccion")
        RegionV.Text = bdPalabra(sql, "Region")

        sql = "SELECT Code,  DescSpanish Type FROM CdFamilyProgramStatus WHERE Active = 1 ORDER BY Orden "
        bdCombo(sql, EstadoV, "Code", "Type")

        sql = "SELECT Code, DescSpanish Sol FROM CdSolicitudeType WHERE Active = 1 AND Type = 'SOLI' ORDER BY DescSpanish "
        bdCombo(sql, SolicitaCombo, "Code", "Sol")

        sql = "SELECT Code, DescSpanish Sol FROM CdSolicitudeType WHERE Active = 1 AND Type = 'PISO' ORDER BY DescSpanish "
        bdCombo(sql, PisoCombo, "Code", "Sol")

        sql = "SELECT Code, DescSpanish Sol FROM CdSolicitudeType WHERE Active = 1 AND Type = 'PARE' ORDER BY DescSpanish "
        bdCombo(sql, ParedCombo, "Code", "Sol")

        sql = "SELECT Code, DescSpanish Sol FROM CdSolicitudeType WHERE Active = 1 AND Type = 'TECH' ORDER BY DescSpanish "
        bdCombo(sql, TechoCombo, "Code", "Sol")


        visitD = 0
        folder = ""
        foto = ""

        preAnalisis()
        If Microsoft.VisualBasic.Left(AplicaPAV.Text, 2) = "SI" Then
            GuardarButton.Visible = True
        Else
            MsgBox("Esta familia NO aplicó para un proceso de Vivienda", vbCritical, My.Resources.versionFamilias2)
        End If

        DireccionV.Visible = True
        DireccionL.Visible = True
        regionL.Visible = True
        RegionV.Visible = True
        SolPanel.Visible = True
        complementoInfoTable.Visible = True
        EstadoPicker.Enabled = False
        TotalHorasV.ReadOnly = True
        EstadoV.Focus()
        miembrosMayores17()

    End Sub

    Private Sub verificarDatos()
        If Len(FamiliaV.Text) > 0 Then
            If familiaEsAfiliada(S, Integer.Parse(FamiliaV.Text)) = True Then
                FamiliaV.ReadOnly = True
                If Len(idAnalisis) > 0 Then
                    valoresIniciales()
                ElseIf tieneAnalisis() = True Then
                    valoresIniciales()
                Else
                    MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
                    nuevo()
                End If
            Else
                MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
                FamiliaV.Text = ""
            End If
            Else
                MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
                FamiliaV.Text = ""
                FamiliaV.Focus()
            End If
    End Sub

    Private Sub VerCarpetaButton_Click(sender As Object, e As EventArgs) Handles VerCarpetaButton.Click
        folder = "C:\Users\PatyL\Documents\Viviendas\" + S + FamiliaV.Text
        Process.Start("explorer.exe", folder)




        'Dim exists As Boolean
        'Dim directorio = "C:\Users\PatyL\Documents\Viviendas\" + S + FamiliaV.Text + "_" + FechaV.Value.Year.ToString
        'exists = System.IO.Directory.Exists(directorio)

        'If exists = True Then
        '    DirectorioV.Text = directorio
        'Else
        '    Directory.CreateDirectory(directorio)
        '    'DirectorioV.Text = directorio
        'End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim openFileDialog1 As New OpenFileDialog()

    '    openFileDialog1.InitialDirectory = "c:\"
    '    openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
    '    openFileDialog1.FilterIndex = 2
    '    openFileDialog1.RestoreDirectory = True

    '    If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

    '        DirectorioV.Text = openFileDialog1.FileName()

    '    End If
    'End Sub

    Private Sub VisitaPicker_ValueChanged(sender As Object, e As EventArgs) Handles VisitaPicker.ValueChanged
        visitD = 1
    End Sub
End Class