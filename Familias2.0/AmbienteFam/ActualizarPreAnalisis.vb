Public Class ActualizarPreAnalisis
    Public idSolicitud As String
    Dim t As Integer = 0
    Dim aplica, codigo As String

    Private Sub ActualizarPreAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub


    Private Sub AmbienteHist()
        sql = "SELECT cdFPS.DescSpanish AS Estado, YEAR(FP.StatusDate) AS AñoEstado, cdST.DescSpanish AS Solicitado, FP.Notes AS Notas " + _
              "FROM dbo.FamilyProgram FP INNER JOIN dbo.CdFamilyProgramStatus cdFPS ON cdFPS.Code = FP.Status INNER JOIN dbo.FamilyProgramSolicitude FPS ON FP.CreationDateTime = FPS.CreationDateTime " + _
              "AND FP.FamilyId = FPS.FamilyId AND  FP.Project = FPS.Project INNER JOIN dbo.CdSolicitudeType cdST ON cdST.Code = FPS.SolicitudeType " + _
              "WHERE FP.RecordStatus = ' ' AND FP.Project = '" + S + "' AND FP.FamilyId = " + FamiliaV.Text + " ORDER BY cdFPS.DescSpanish "
        bdGrid(sql, AmbienteGrid)
    End Sub

    Private Sub avisosFamiliares()
        If S = "E" Or S = "A" Then
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                Dim g As System.Drawing.Graphics = Me.CreateGraphics
                Dim ancho As Integer = 0
                Dim avisoLargo As String = ""

                sql = "SELECT dbo.fn_GEN_FormatDate(FW.WarningDate, 'es') AS Fecha, cdFWT.DescSpanish AS AvisoFamiliar " + _
                      "FROM dbo.FamilyWarning FW INNER JOIN dbo.CdFamilyWarningType cdFWT ON FW.Warning = cdFWT.Code " + _
                      "WHERE FW.RecordStatus = ' ' AND cdFWT.Code IN ('ACON', 'ACOR', 'AFOG', 'AFON', 'AHAB', 'CFIB', 'CMET', 'NESP', 'NPER', 'REDA', 'RGEO') AND FW.Project = '" + S + "' AND FW.FamilyId = " + FamiliaV.Text + "  "
                bdGrid(sql, AvisosGrid)
                'InputBox("", "", sql)
                For f = 0 To AvisosGrid.RowCount - 1
                    If Len(AvisosGrid.Item(0, f).Value()) > ancho Then
                        avisoLargo = AvisosGrid.Item(0, f).Value()
                    End If
                Next

                AvisosGrid.Height = AvisosGrid.RowCount * 25
                AvisosGrid.Width = g.MeasureString(avisoLargo, AvisosGrid.Font).Width
                AvisosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                AvisosGrid.AutoResizeColumns()
                AvisosGrid.Visible = True
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub ComentariosAplica()
        sql = "SELECT Comments C FROM CdFamilyLivingDiagnosis WHERE Code = '" + codeD.Text + "' "
        ComentarioV.Text = bdPalabra(sql, "C")
        If Microsoft.VisualBasic.Left(DiagnosticoCombo.Text, 2) = "SI" Then
            AplicaCheckBox.Checked = True
            aplica = 1
        Else
            AplicaCheckBox.Checked = False
            aplica = 0
        End If
        AplicaCheckBox.Visible = True
        ComentarioV.Visible = True
        comentarioL.Visible = True
    End Sub

    Private Sub DiagnosticoCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiagnosticoCombo.SelectedIndexChanged
        If t = 1 Then
            codeD.Text = DiagnosticoCombo.SelectedValue
            ComentariosAplica()
        End If
    End Sub

    Private Sub EducacionApadrinados()
        sql = "SELECT No_Afiliación 'No.', Nombre, Nivel_Educ, Grado, Escuela, Semaforo, Fase " + _
              "FROM dbo.v_TS_ViviendasEducApadrinados " + _
              "WHERE Project = '" + S + "' AND Familia = " + FamiliaV.Text
        bdGrid(sql, EducGrid)
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Dim id As String = S + FamiliaV.Text + "_" + Today.Year.ToString

        If Len(codeD.Text) <= 1 Then
            MsgBox("Necesita seleccionar el diagnostico", vbCritical, My.Resources.versionFamilias2)
        Else
            sql = "INSERT INTO  dbo.FamilyLivingAnalysis VALUES ('" + id + "','" + S + "', " + FamiliaV.Text + ", GETDATE(), GETDATE(), ' ', '" + U + "', NULL, " + _
                  aplica + ", '" + codeD.Text + "', '" + NotasV.Text + "') "
            bdInsertar(sql)

            sql = "SELECT COUNT(*) T FROM dbo.FamilyLivingAnalysis WHERE RecordStatus = ' ' AND IdAnalysis = '" + id + "'"
            If bdEntero(sql, "T") = 1 Then
                MsgBox("Actualización correcta", vbInformation, My.Resources.versionFamilias2)
                GuardarButton.Visible = False
            Else
                MsgBox("Revise la actualización del analisis preliminar", vbInformation, My.Resources.versionFamilias2)
            End If

        End If

    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ListadoButton_Clic(sender As Object, e As EventArgs) Handles ListadoButton.Click
        Dim nxt As New ListadoGeneralFamiliasAP
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ListadoGeneralLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim nxt As New ListadoGeneralFamiliasAP
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New PreAnalisisVivienda
        nxt.Show()
        Me.Close()
    End Sub

    Private Function tieneAnalisisPreliminar() As Boolean
        sql = "SELECT COUNT(*) T FROM dbo.FamilyLivingAnalysis WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " AND RecordStatus = ' ' "
        Dim t As Integer = bdEntero(sql, "T")
        If t = 0 Then
            tieneAnalisisPreliminar = False
        Else
            tieneAnalisisPreliminar = True
        End If
    End Function

    Private Sub valoresIniciales()
        sql = "SELECT Address + ' - ' + Pueblo Direccion, dbo.fn_GEN_regionFamilia(F.Project, F.FamilyId) AS Region FROM dbo.Family F WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        DireccionV.Text = bdPalabra(sql, "Direccion")
        RegionV.Text = bdPalabra(sql, "Region")

        sql = "SELECT Code, CASE WHEN Applies = 1 THEN 'SI - ' ELSE 'NO - ' END + DescSpanish Type " + _
              "FROM CdFamilyLivingDiagnosis WHERE Project IN ('*', '" + S + "') AND Active = 1 ORDER BY Applies DESC, DescSpanish "
        bdCombo(sql, DiagnosticoCombo, "Code", "Type")
        t = 1

        Dim solicitudInfo As New DataTable
        sql = "SELECT AnalysisDateTime, Applies, Diagnosis, Notes " + _
              "FROM dbo.FamilyLivingAnalysis WHERE RecordStatus = ' ' AND IdAnalysis = '" + idSolicitud + "'"
        bdDataTable(sql, solicitudInfo)

        DiagnosticoCombo.SelectedValue = solicitudInfo.Rows(0)("Diagnosis")
        NotasV.Text = chequearValor(solicitudInfo.Rows(0)("Notes"))
        AplicaCheckBox.Checked = chequearValor(solicitudInfo.Rows(0)("Applies"))

        EducacionApadrinados()
        AmbienteHist()
        viviendaActual()
        avisosFamiliares()
        DireccionV.Visible = True
        DireccionL.Visible = True
        regionL.Visible = True
        RegionV.Visible = True
        diagnosisTable.Visible = True
        GuardarButton.Visible = True
        FamiliaV.ReadOnly = True
        OtrosTable.Visible = True
        CondiconesActualesTable.Visible = True
    End Sub

    Private Sub viviendaActual()
        sql = "SELECT Cuartos, Tenencia, Paredes, Paredes_Calidad, Paredes_Notas, Piso, Piso_Calidad, Piso_Notas, Tamaño, Estufa " + _
              "FROM v_AMBF_CondicionesVivienda WHERE Sitio = '" + S + "' AND Familia = " + FamiliaV.Text
        CuartosV.Text = bdPalabra(sql, "Cuartos")
        TerrenoV.Text = bdPalabra(sql, "Tenencia")
        TamañoV.Text = bdPalabra(sql, "Tamaño")
        ParedesV.Text = bdPalabra(sql, "Paredes") + " (" + bdPalabra(sql, "Paredes_Calidad") + ") " + bdPalabra(sql, "Paredes_Notas")
        PisoV.Text = bdPalabra(sql, "Piso") + " (" + bdPalabra(sql, "Piso_Calidad") + ") " + bdPalabra(sql, "Piso_Notas")
        CocinaV.Text = bdPalabra(sql, "Estufa")
    End Sub

End Class