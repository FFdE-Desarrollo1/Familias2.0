Public Class ActualizarSolicitud
    Public idSolicitud As String
    Dim idAnalisis, foto, folder As String
    Dim fVivi, fCons, fEntr
    Dim visitD, fV, fC, fE As Integer
    Dim msError = "El número de familia que ingresó no es válido" + Chr(13) + _
           "Verifique que sea una familia afiliada"

    Private Sub ActualizarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()

        If Len(FamiliaV.Text) = 0 Then
            FamiliaV.Focus()
        Else
            verificarDatos()
        End If
    End Sub

    Private Sub actualizarFotoInicial()
        Dim fotoI
        If Len(FotoIV.Text) = 0 Then
            fotoI = "NULL"
        Else
            fotoI = "'" + FotoIV.Text + "'"

            Dim msg As String
            Try
                sql = "INSERT INTO dbo.FamilyAmbFamSolicitude " + _
                      "SELECT IdSolicitude, Project, FamilyId, ProgramType, ProgramStartDate, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Status, StatusDate, " + _
                      " TotalHours, Exoneration, Notes, HoursWorked, Material, Quantity, DimensionX, DimensionY, Floor, Wall, Ceiling, AmbFamVisitDate, " + fotoI + ", " + _
                      " EndPhoto, ConstructionDate, WorkTeam, DeliveryDate, IdAnalysis " + _
                      "FROM dbo.FamilyAmbFamSolicitude WHERE IdSolicitude = '" + idSolicitud + "' AND RecordStatus = ' '  "
                bdInsertar(sql)
                msg = ""
            Catch ex As Exception
                msg = ex.Message
            End Try

            If msg = "" Then
                MsgBox("Actualización correcta de la foto inicial!", vbExclamation, My.Resources.versionFamilias2)
            Else
                InputBox("Error en la Actualización", "Envie el siguiente mensaje a Sistemas", msg)
            End If
        End If
    End Sub

    Private Sub actualizarFotoFinal()
        Dim fotoF

        If Len(FotoFV.Text) = 0 Then
            fotoF = "NULL"
        Else
            fotoF = "'" + FotoFV.Text + "'"

            Dim msg As String
            Try
                sql = "INSERT INTO dbo.FamilyAmbFamSolicitude " + _
                      "SELECT IdSolicitude, Project, FamilyId, ProgramType, ProgramStartDate, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Status, StatusDate, " + _
                      " TotalHours, Exoneration, Notes, HoursWorked, Material, Quantity, DimensionX, DimensionY, Floor, Wall, Ceiling, AmbFamVisitDate, InitialPhoto, " + _
                      fotoF + ", ConstructionDate, WorkTeam, DeliveryDate, IdAnalysis " + _
                      "FROM dbo.FamilyAmbFamSolicitude WHERE IdSolicitude = '" + idSolicitud + "' AND RecordStatus = ' '  "
                bdInsertar(sql)
                msg = ""
            Catch ex As Exception
                msg = ex.Message
            End Try

            If msg = "" Then
                MsgBox("Actualización correcta de la foto final!", vbExclamation, My.Resources.versionFamilias2)
            Else
                InputBox("Error en la Actualización", "Envie el siguiente mensaje a Sistemas", msg)
            End If

        End If
    End Sub

    Private Sub actualizarSolicitud()
        Dim visita, construccion, brigada, entrega, estado As String

        If fV = 0 Then
            visita = "NULL"
        Else
            visita = " '" + VisitaPicker.Value.ToString(en.DateTimeFormat) + "' "
        End If

        If fE = 0 Then
            entrega = "NULL"
            estado = "Status"
        Else
            entrega = " '" + EntregaPicker.Value.ToString(en.DateTimeFormat) + "' "
            estado = "'TERM'"
        End If

        If fC = 0 Then
            construccion = "NULL"
        Else
            construccion = " '" + ConstruccionPicker.Value.ToString(en.DateTimeFormat) + "' "
        End If

        If Len(BrigadaV.Text) = 0 Then
            brigada = "NULL"
        Else
            brigada = "'" + BrigadaV.Text + "'"
        End If

        Dim msg As String
        Try
            sql = "INSERT INTO dbo.FamilyAmbFamSolicitude " + _
                  "SELECT IdSolicitude, Project, FamilyId, ProgramType, ProgramStartDate, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, " + estado + ", StatusDate, " + _
                  " TotalHours, Exoneration, '" + NotasV.Text + "', HoursWorked, Material, Quantity, DimensionX, DimensionY, Floor, Wall, Ceiling, " + visita + ", InitialPhoto, " + _
                  " EndPhoto, " + construccion + ", " + brigada + ", " + entrega + ", IdAnalysis " + _
                  "FROM dbo.FamilyAmbFamSolicitude WHERE IdSolicitude = '" + idSolicitud + "' AND RecordStatus = ' '  "
            'InputBox("", "", sql)
            bdInsertar(sql)
            msg = ""
        Catch ex As Exception
            msg = ex.Message
        End Try

        If msg = "" Then
            MsgBox("Actualización correcta!", vbExclamation, My.Resources.versionFamilias2)
        Else
            InputBox("Error en la Actualización", "Envie el siguiente mensaje a Sistemas", msg)
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub ConstruccionPicker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ConstruccionPicker.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                ConstruccionPicker.Format = DateTimePickerFormat.Short
                ConstruccionPicker.Value = Date.Today
                fC = 1
        End Select
    End Sub

    Private Sub EntregaPicker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles EntregaPicker.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                EntregaPicker.Format = DateTimePickerFormat.Short
                EntregaPicker.Value = Date.Today
                fE = 1
        End Select
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

    Private Sub FotoInicialButton_Click(sender As Object, e As EventArgs) Handles FotoInicialButton.Click
        If tieneFotoI() = True Then
            MsgBox("Ya tiene foto inicial", vbCritical, My.Resources.versionFamilias2)
        Else
            'folder = "C:\Users\PatyL\Documents\Viviendas\" + S + FamiliaV.Text
            folder = "\\Portal\Viviendas\" + S + FamiliaV.Text
            foto = S + FamiliaV.Text + "_" + FechaV.Value.Year.ToString + "Inicial.jpg"
            Dim DirectorioFoto = folder + "\" + foto

            Dim existeFolder As Boolean = System.IO.Directory.Exists(folder)
            Dim existeFoto As Boolean = System.IO.Directory.Exists(DirectorioFoto)

            'Crea carpeta
            If existeFolder = False Then
                Directory.CreateDirectory(folder)
            End If

            'Crea copia foto
            If existeFoto = False Then
                Dim openFileDialog1 As New OpenFileDialog()
                openFileDialog1.InitialDirectory = "c:\"
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                openFileDialog1.FilterIndex = 2
                openFileDialog1.RestoreDirectory = True

                If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    'DirectorioV.Text = openFileDialog1.FileName()
                    System.IO.File.Copy(openFileDialog1.FileName(), DirectorioFoto)
                    FotoIV.Text = DirectorioFoto
                    actualizarFotoInicial()
                    MsgBox("Foto guardada correctamente en:" + DirectorioFoto, vbExclamation, My.Resources.versionFamilias2)
                Else
                    MsgBox("El archivo de la foto no se puede abrir", vbCritical, My.Resources.versionFamilias2)
                End If
            End If
        End If
    End Sub

    Private Sub FotoFinalButton_Click(sender As Object, e As EventArgs) Handles FotoFinalButton.Click
        If tieneFotoF() = True Then
            MsgBox("Ya tiene foto final", vbCritical, My.Resources.versionFamilias2)
        Else
            'folder = "C:\Users\PatyL\Documents\Viviendas\" + S + FamiliaV.Text
            folder = "\\Portal\Viviendas\" + S + FamiliaV.Text
            foto = S + FamiliaV.Text + "_" + FechaV.Value.Year.ToString + "Final.jpg"
            Dim DirectorioFoto = folder + "\" + foto

            Dim existeFolder As Boolean = System.IO.Directory.Exists(folder)
            Dim existeFoto As Boolean = System.IO.Directory.Exists(DirectorioFoto)

            'Crea carpeta
            If existeFolder = False Then
                Directory.CreateDirectory(folder)
            End If

            'Crea copia foto
            If existeFoto = False Then
                Dim openFileDialog1 As New OpenFileDialog()
                openFileDialog1.InitialDirectory = "c:\"
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                openFileDialog1.FilterIndex = 2
                openFileDialog1.RestoreDirectory = True

                If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    'DirectorioV.Text = openFileDialog1.FileName()
                    System.IO.File.Copy(openFileDialog1.FileName(), DirectorioFoto)
                    FotoFV.Text = DirectorioFoto
                    actualizarFotoFinal()
                    MsgBox("Foto guardada correctamente en:" + DirectorioFoto, vbExclamation, My.Resources.versionFamilias2)
                Else
                    MsgBox("El archivo de la foto no se puede abrir", vbCritical, My.Resources.versionFamilias2)
                End If
            End If
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Dim result As Integer = DateTime.Compare(ConstruccionPicker.Value.ToShortDateString, EntregaPicker.Value.ToShortDateString)
        If result < 0 Then
            actualizarSolicitud()
            solicitud()
        Else
            msError = "La fecha de entrega no puede ser menor a la de construcción"
            MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
        End If

    End Sub

    Private Sub HorasTrabajadas()
        listadoGrid.DataSource = Nothing
        listadoGrid.Rows.Clear()
        listadoGrid.Visible = False
        sql = "SELECT  CONVERT(varchar, FromDate, 103) AS De, " + _
              "CONVERT(varchar, ToDate, 103) AS A, Hours AS Horas, UserId AS Usuario, Notes AS Notas " + _
              "FROM dbo.FamilyHoursWorked WHERE RecordStatus = ' ' AND IdSolicitude = '" + idSolicitud + "'"
        bdGrid(sql, listadoGrid)
        listadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        listadoGrid.AutoResizeColumns()
        listadoGrid.Visible = True
        ListadoT.Text = "HORAS LABORADAS"
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
        listadoGrid.DataSource = Nothing
        listadoGrid.Rows.Clear()
        listadoGrid.Visible = False
        sql = "SELECT Edad, Nombre + ' (' + CONVERT(varchar, Miembro) + ')' Nombre, RelaciónFamiliar " + _
              "FROM dbo.v_TS_ViviendasMayores18 WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " ORDER BY Edad "
        bdGrid(sql, listadoGrid)
        listadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        listadoGrid.AutoResizeColumns()
        listadoGrid.Visible = True
        ListadoT.Text = "MIEMBROS MAYORES A 17 AÑOS"
    End Sub

    Private Sub nuevo()
        Dim nxt As New ActualizarSolicitud
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

    Private Sub solicitud()
        Dim solicitudInfo As New DataTable
        sql = "SELECT     ProgramType, ProgramStartDate, CreationDateTime, UserId, ExpirationDateTime, Status, StatusDate, " + _
              "TotalHours, Exoneration, Notes, HoursWorked, Material, Quantity, DimensionX, DimensionY, Floor, Wall, Ceiling, AmbFamVisitDate, InitialPhoto, " + _
              "EndPhoto, ConstructionDate, WorkTeam, DeliveryDate, IdAnalysis " + _
              "FROM dbo.FamilyAmbFamSolicitude WHERE RecordStatus = ' ' AND IdSolicitude = '" + idSolicitud + "'"
        bdDataTable(sql, solicitudInfo)
        FechaV.Text = chequearValor(solicitudInfo.Rows(0)("ProgramStartDate"))
        EstadoV.SelectedValue = chequearValor(solicitudInfo.Rows(0)("Status"))
        EstadoPicker.Value = chequearValor(solicitudInfo.Rows(0)("StatusDate"))
        HorasV.Text = chequearValor(solicitudInfo.Rows(0)("TotalHours"))
        TotalHorasV.Text = chequearValor(solicitudInfo.Rows(0)("HoursWorked"))
        ExoneradaCheck.Checked = chequearValor(solicitudInfo.Rows(0)("Exoneration"))
        NotasV.Text = chequearValor(solicitudInfo.Rows(0)("Notes"))
        UsuarioV.Text = chequearValor(solicitudInfo.Rows(0)("UserId"))
        SolicitaCombo.SelectedValue = chequearValor(solicitudInfo.Rows(0)("Material"))
        CantidadV.Text = chequearValor(solicitudInfo.Rows(0)("Quantity"))
        DimensionXV.Text = chequearValor(solicitudInfo.Rows(0)("DimensionX"))
        DimensionYV.Text = chequearValor(solicitudInfo.Rows(0)("DimensionY"))
        PisoCombo.SelectedValue = chequearValor(solicitudInfo.Rows(0)("Floor"))
        ParedCombo.SelectedValue = chequearValor(solicitudInfo.Rows(0)("Wall"))
        TechoCombo.SelectedValue = chequearValor(solicitudInfo.Rows(0)("Ceiling"))
        idAnalisis = chequearValor(solicitudInfo.Rows(0)("IdAnalysis"))
        FotoIV.Text = chequearValor(solicitudInfo.Rows(0)("InitialPhoto"))
        FotoFV.Text = chequearValor(solicitudInfo.Rows(0)("EndPhoto"))
        fVivi = chequearValor(solicitudInfo.Rows(0)("AmbFamVisitDate")) 'fecha visita ambiente
        fCons = chequearValor(solicitudInfo.Rows(0)("ConstructionDate")) 'fecha construcción
        fEntr = chequearValor(solicitudInfo.Rows(0)("DeliveryDate")) ' fecha entrega

        If Len(fVivi) = 0 Then
            fV = 0
            VisitaPicker.Format = DateTimePickerFormat.Custom
            VisitaPicker.CustomFormat = " "
        Else
            fV = 1
            VisitaPicker.Value = fVivi
        End If

        If Len(fCons) = 0 Then
            fC = 0
            ConstruccionPicker.Format = DateTimePickerFormat.Custom
            ConstruccionPicker.CustomFormat = " "
        Else
            fC = 1
            ConstruccionPicker.Value = fCons
        End If

        If Len(fEntr) = 0 Then
            fE = 0
            EntregaPicker.Format = DateTimePickerFormat.Custom
            EntregaPicker.CustomFormat = " "
        Else
            fE = 1
            EntregaPicker.Value = fEntr
        End If


    End Sub

    Private Function tieneFotoI() As Boolean
        If Len(FotoIV.Text) = 0 Then
            tieneFotoI = False
        Else
            tieneFotoI = True
        End If
    End Function

    Private Function tieneFotoF() As Boolean
        If Len(FotoFV.Text) = 0 Then
            tieneFotoF = False
        Else
            tieneFotoF = True
        End If
    End Function

    Private Function tieneSolicitud()
        sql = "SELECT COUNT(*) T FROM dbo.FamilyAmbFamSolicitude WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
        If bdEntero(sql, "T") = 0 Then
            tieneSolicitud = False
            msError = "La familia no cuenta con solicitudes"
        Else
            sql = "SELECT MAX(IdSolicitude) IdSol FROM dbo.FamilyAmbFamSolicitude WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
            idSolicitud = bdPalabra(sql, "IdSol")
            tieneSolicitud = True
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
        solicitud()
        preAnalisis()
        HorasTrabajadas()
        EstadoV.Focus()
        DireccionV.Visible = True
        DireccionL.Visible = True
        regionL.Visible = True
        RegionV.Visible = True
        SolPanel.Visible = True
        Table2.Visible = True
        complementoInfoTable.Visible = True
        EstadoPicker.Enabled = False
        TotalHorasV.ReadOnly = True
        GuardarButton.Visible = True
    End Sub

    Private Sub verificarDatos()
        If Len(FamiliaV.Text) > 0 Then
            If familiaEsAfiliada(S, Integer.Parse(FamiliaV.Text)) = True Then
                FamiliaV.ReadOnly = True
                If tieneSolicitud() = True Then
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

    Private Sub VisitaPicker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VisitaPicker.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                VisitaPicker.Format = DateTimePickerFormat.Short
                VisitaPicker.Value = Date.Today
                fV = 1
        End Select
    End Sub

    Private Sub VerCarpetaButton_Click(sender As Object, e As EventArgs) Handles VerCarpetaButton.Click
        'folder = "C:\Users\PatyL\Documents\Viviendas\" + S + FamiliaV.Text
        folder = "\\Portal\Viviendas\" + S + FamiliaV.Text
        Dim existeFolder As Boolean = System.IO.Directory.Exists(folder)
        If existeFolder = False Then
            MsgBox("No existe carpeta de fotos de esta familia", vbExclamation, My.Resources.versionFamilias2)
        Else
            Process.Start("explorer.exe", folder)
        End If
    End Sub

    Private Sub VerMiembrosL_Click(sender As Object, e As EventArgs) Handles VerMiembrosL.Click
        miembrosMayores17()
    End Sub

    Private Sub VerHorasL_Click(sender As Object, e As EventArgs) Handles VerHorasL.Click
        HorasTrabajadas()
    End Sub
End Class