' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ResumenBecas
    Dim fotoDire, estadoOr, escuelaOr, gradoOr, carreraOr, excepEsOr As String
    Dim days As Integer = 180
    Dim porcentaje As Double
    Private imgOriginal As Image
    Dim ahora As DateTime
    Dim certificadoOr As Boolean = False
    Dim estadoSel As String = ""
    Dim n As Integer = 0

    Private Sub ResumenBecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        MiembroV.Focus()

        If Len(MiembroV.Text) > 0 Then
            validaMiembro()
        Else
            PrincipalPanel.Visible = True
        End If
    End Sub

    'Private Sub actividadesL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles actividadesL.LinkClicked

    'End Sub

    Private Sub actualizarTipoAfil(ByVal CodGrado As String, ByVal miembro As String, ByVal familia As String)
        Dim nivel, tipoAfilT, tipoAfil As String
        sql = "SELECT EducationLevel Nivel FROM dbo.CdGrade WHERE Code = '" + CodGrado + "'"
        nivel = bdPalabra(sql, "Nivel")
        If nivel = "BASI" Or nivel = "DIVE" Or nivel = "VOCA" Or nivel = "MADU" Then
            sql = "SELECT Pueblo FROM Family WHERE RecordStatus = ' '  AND FamilyId = " + familia + " AND Project = '" + S + "'"
            Dim pueblo As String = bdPalabra(sql, "Pueblo")
            If pueblo = "EXT" Then
                tipoAfilT = "EXBE"
            Else
                tipoAfilT = "BECA"
            End If
        ElseIf nivel = "UNIV" Then
            tipoAfilT = "BECU"
        Else
            tipoAfilT = "NORM"
        End If

        sql = "SELECT AffiliationType Tipo FROM Member WHERE Memberid = " + miembro + " AND Project = '" + S + "' AND Recordstatus = ' '"
        tipoAfil = bdPalabra(sql, "Tipo")

        If tipoAfilT = tipoAfil Then
        Else
            sql = "INSERT INTO dbo.Member " + _
                     "SELECT Project, MemberId, GETDATE() CreationDateTime, RecordStatus, '" + U + "' UserId, ExpirationDateTime, LastFamilyId, FirstNames, LastNames, PreferredName, BirthDate, " + _
                     "Gender, '" + tipoAfilT + "' AffiliationType, AffiliationStatus, AffiliationStatusDate, LiveDead, DeathDate, BiologicalMotherMemberId, BiologicalFatherMemberId, " + _
                     "OtherAffiliation, OfficialId, HasFaithOfAgeOrOfficialId, CellularPhoneNumber, Literacy, LastGradePassed, HasHealthCard, ExceptionInAgePolicy, " + _
                     "LastGradePassedYear, LastGradePassedStatus " + _
                     "FROM dbo.Member " + _
                     "WHERE Memberid = " + miembro + " AND Project = '" + S + "' AND RecordStatus = ' ' "
            bdInsertar(sql)
            MsgBox("Con el cambio de grado se ha actualizado el tipo de afiliación", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub agregarActividad(ByRef estado As ComboBox)
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
                sql = "INSERT INTO MemberActivity VALUES ('" + S + "', " + MiembroV.Text + ", " + actividad + ", '" + fechaT + "', GETDATE(), ' ', '" + U + "', NULL, '')"
                bdInsertar(sql)
                MsgBox("Se ha ingresado una actividad automática de ""gano o perdió grado""", vbInformation, My.Resources.versionFamilias2)
            End If
        End If
    End Sub

    Private Sub autorizarReemLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles autorizarReemLink.LinkClicked
        Dim nxt As New AutorizarReembolsoEduc
        nxt.MiembroV.Text = MiembroV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub avisosFamiliares()
        If S = "E" Or S = "A" Then
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                Dim g As System.Drawing.Graphics = Me.CreateGraphics
                Dim ancho As Integer = 0
                Dim avisoLargo As String = ""

                sql = "SELECT Aviso FROM dbo.fn_WARN_avisosES('" + S + "', " + FamiliaV.Text + ") "
                bdGrid(sql, AvisosGrid)

                If AvisosGrid.RowCount > 0 Then
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
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrarObservacion(ByVal id As Integer)
        sql = "UPDATE dbo.MemberEducationObservation SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Observation = Observation + ' (" + U + ")' " + _
              "WHERE RecordStatus = ' ' AND IdObservation = " + id.ToString + " "
        bdInsertar(sql)
        listaObservaciones()
    End Sub

    Private Sub comboOpciones()
        sql = "SELECT 'ACTI' Code, 'Actividades' 'Descripcion' " + _
              "UNION ALL SELECT 'HEDU' Code, 'Historial Educativo' " + _
              "UNION ALL SELECT 'HARE' Code, 'Historial Areas' " + _
              "UNION ALL SELECT 'TELE' Code, 'Teléfonos'" + _
              "UNION ALL SELECT 'INFG' Code, 'Información General' " + _
              "UNION ALL SELECT 'HUTI' Code, 'Historial Feria Utiles' " + _
              "UNION ALL SELECT 'HCAL' Code, 'Historial Calificaciones' " + _
              "UNION ALL SELECT 'HSEM' Code, 'Historial Semáforos' "
        'InputBox("", "", sql)
        bdCombo(sql, OpcionesCombo, "Code", "Descripcion")
    End Sub

    Private Function estadoCorrecto() As Boolean
        If n = 1 Then
            If Len(RazonV.Text) = 0 Then
                MsgBox("Necesita seleccionar la razón de no continuar estudiando", vbQuestion, My.Resources.versionFamilias2)
                estadoCorrecto = False
            Else
                estadoCorrecto = True
            End If
        Else
            RazonV.Text = ""
            estadoCorrecto = True
        End If
    End Function

    Private Sub EstadoV_TextChanged(sender As Object, e As EventArgs) Handles EstadoV.TextChanged
        If Len(EstadoV.Text) > 0 Then
            estadoSel = EstadoV.Text
            'razonNoContinuar()
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fotoMiembro()
        ApadrinadoPic.Visible = True
        Try
            If Len(fotoDire) > 0 Then
                fotoDire = fotoDire.Remove(0, 3)
            End If
            'fotoDire = "\\" + My.Resources.svr + "\FamilyFotos\" + fotoDire
            fotoDire = "\\svrfamilias\FamilyFotos\" + fotoDire
            imgOriginal = Image.FromFile(fotoDire)
        Catch ex As Exception
            imgOriginal = My.Resources.Resources.CH_Heart
        Finally
        End Try
        ApadrinadoPic.Image = imgOriginal
        ApadrinadoPic.SizeMode = PictureBoxSizeMode.StretchImage
        ApadrinadoPic.Size = New Point(147, 158)
    End Sub

    Private Sub guardarActividad()
        'Project, MemberId, Type, ActivityDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Notes
        sql = "INSERT INTO dbo.MemberActivity VALUES('" + S + "', " + MiembroV.Text + ", '" + actividadCombo.SelectedValue + _
              "', '" + Now.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, '" + ActividadNotasV.Text + "')"
        bdInsertar(sql)
        actividadCombo.SelectedIndex = -1
        ActividadNotasV.Text = ""
        listaActividades()
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If Len(escuelaCombo.Text) = 0 Or Len(gradoCombo.Text) = 0 Or Len(EstadoV.Text) = 0 Then
        Else
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            Dim snGrado As Boolean = False
            Dim snEscuela As Boolean = False
            Dim snCarrera As Boolean = False
            Dim snEstado As Boolean = False
            Dim snExcepcionEs As Boolean = False
            Dim snCertificado As Boolean = False

            Dim nGrado As String = "Grade"
            Dim nEscuela As String = "SchoolCode"
            Dim nCarrera As String = "Career"
            Dim nEstado As String = "Status"
            Dim nCertificado As String = "HasCertificate"
            Dim certificado As String = "HasCertificate"
            Dim nRazon As String '= "ExcepciónEstado"


            If Len(excepEsOr) > 0 Then
                nRazon = "'" + RazonV.SelectedValue + "'"
            Else
                nRazon = "NULL"
            End If

            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            If gradoCombo.SelectedValue <> gradoOr Then
                response = MsgBox("¿Esta seguro de cambiar el grado? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snGrado = True
                    nGrado = "'" + gradoCombo.SelectedValue + "'"
                End If
            End If

            If escuelaCombo.SelectedValue <> escuelaOr Then
                response = MsgBox("¿Esta seguro de cambiar la escuela? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snEscuela = True
                    nEscuela = "'" + escuelaCombo.SelectedValue + "'"
                End If
            End If

            If EstadoV.SelectedValue <> estadoOr Then
                response = MsgBox("¿Esta seguro de cambiar el estado educativo? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snEstado = True
                    nEstado = "'" + EstadoV.SelectedValue + "'"
                End If
            End If


            If RazonV.Text <> excepEsOr Then
                response = MsgBox("¿Esta seguro de la excepción de estado educativo? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snExcepcionEs = True
                    nRazon = "'" + RazonV.SelectedValue + "'"
                End If
            End If



            If carreraCombo.SelectedValue <> carreraOr Then
                response = MsgBox("¿Esta seguro de cambiar la carrera? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snCarrera = True
                    nCarrera = "'" + carreraCombo.SelectedValue + "'"
                End If
            End If

            If certificadoOr <> CertificadoV.Checked Then
                response = MsgBox("¿Esta seguro de cambiar certificado? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snCertificado = True

                    If CertificadoV.Checked = True Then
                        certificado = "1"
                    Else
                        certificado = "0"
                    End If
                End If
            End If

            If snGrado = True Or snEscuela = True Or snCarrera = True Or snEstado = True Or snExcepcionEs = True Or snCertificado = True Then
                ahora = DateTime.Now

                sql = "INSERT INTO  dbo.MemberEducationYear " + _
                        "SELECT Project, MemberId, SchoolYear, " + nEscuela + " SchoolCode, " + nGrado + " Grade, '" + ahora.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, " + _
                        "'" + U + "' UserId, ExpirationDateTime, ClassSection, PercentOfExpensesToPay, " + nRazon + " ReasonNotToContinue, " + nEstado + " Status, " + nCarrera + " Career, SingleTeacher, " + _
                        "TransportationStartDate, TransportationEndDate, Notes, ExceptionPercent, " + certificado + " HasCertificate, NYSPackage, Typing " + _
                        "FROM  dbo.MemberEducationYear " + _
                        "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND SchoolYear = " + AñoV.Text + " AND Grade = '" + gradoOr + "' " + _
                        "AND Status = '" + estadoOr + "' AND SchoolCode = '" + escuelaOr + "'"
                bdInsertar(sql)

                'inactiva el historial del record
                sql = "UPDATE dbo.MemberEducationYear SET RecordStatus = 'H', ExpirationDateTime = '" + ahora.ToString(en.DateTimeFormat) + " '  " + _
                      "WHERE  RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND schoolYear = " + AñoV.Text + "  " + _
                      "AND schoolCode = '" + escuelaOr + "' AND grade = '" + gradoOr + "' AND " + _
                      "Convert(nvarchar(30), CreationDateTime, 20) = '" + CreationDateL.Text + "' "
                bdEjecutarSQL(sql)

                If snGrado = True Then
                    ingresarNuevaObservacion("GRAD")

                    If Integer.Parse(AñoV.Text) >= Today.Year Then
                        actualizarTipoAfil(gradoCombo.SelectedValue, MiembroV.Text, FamiliaV.Text)
                    End If
                End If

                If snEscuela = True Then
                    ingresarNuevaObservacion("ESCU")
                End If

                If snCarrera = True Then
                    ingresarNuevaObservacion("CARR")
                End If

                If snEstado = True Then
                    ingresarNuevaObservacion("ESTA")
                    agregarActividad(EstadoV)
                End If

                If snExcepcionEs = True Then
                    ingresarNuevaObservacion("EXCE")
                End If

                MsgBox("Actualización correcta", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                infoGen()
                HistorialEduc()
            End If
        End If
    End Sub

    Private Sub GuardarObsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarObsButton.Click
        If Len(categoriaCombo.Text) = 0 Or Len(ObservacionesV.Text) = 0 Then
            MsgBox("Necesita información en los 2 campos de la observación", vbQuestion, My.Resources.versionFamilias2)
        Else
            If idObsL.Text = "0" Then
                ingresarNuevaObservacion(categoriaCombo.SelectedValue)
            Else
                sql = "INSERT INTO dbo.MemberEducationObservation " + _
                      "SELECT IdObservation, GETDATE(), Project, MemberId, Category, ObservationDateTime, '" + ObservacionesV.Text + "', RecordStatus, " + _
                      "'" + U + "', ExpirationDateTime " + _
                      "FROM dbo.MemberEducationObservation " +
                      "WHERE RecordStatus = ' ' AND IdObservation = " + idObsL.Text
                bdInsertar(sql)
                categoriaCombo.SelectedIndex = -1
                ObservacionesV.Text = ""
                idObsL.Text = "0"
                listaObservaciones()
            End If
        End If
    End Sub

    Private Sub HistorialAreas()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        Dim actual As DateTime = DateTime.Now
        sql = "SELECT Fecha, Actividad FROM fn_GEN_HistorialFamiliar('" + S + "', " + FamiliaV.Text + ", 'es', " + days.ToString + ", '" + actual.ToString(en.DateTimeFormat) + "') " + _
              "WHERE Fecha IS NOT NULL " + _
              "UNION ALL " + _
              "SELECT FECHA, Actividad FROM fn_GEN_HistorialIndividual('" + S + "', " + MiembroV.Text + ", 'es', " + days.ToString + ", '" + actual.ToString(en.DateTimeFormat) + "') " + _
              "WHERE Fecha IS NOT NULL AND Area NOT IN ('BECA') "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialCalificaciones()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT   dbo.fn_EDUC_semaforoEsp('" + S + "', " + MiembroV.Text + ", " + AñoV.Text + ", MECG.Unit) AS Semáforo, " + _
              "MECG.Unit AS Unidad, cdS.DescSpanish AS Fuente, MECG.TotalClasses 'Total Clases', " + _
              "CASE WHEN MECG.ApprovedAll = 1 THEN 'SI' ELSE 'NO' END AS 'Ganó todas', MECG.Average80 AS 'Promedio (>80%)', " + _
              "MECG.FailedClasses AS 'Cantidad Pérdidas',  " + _
              " (SELECT COUNT(*) FROM MemberEducationClassFailed AS MECF WHERE RecordStatus = ' ' AND Ref = MECG.Ref) AS Registradas, MECG.Notes Notas, " + _
              "MECG.UserId Usuario " + _
              "FROM dbo.MemberEducationClassGrade AS MECG " + _
              "INNER JOIN dbo.CdSchoolGradeSource AS cdS ON MECG.Source = cdS.Code " + _
              "WHERE MECG.RecordStatus = ' ' AND MECG.Project = '" + S + "' AND MECG.MemberId = " + MiembroV.Text + " AND MECG.SchoolYear = " + AñoV.Text + " " + _
              "ORDER BY MECG.Unit "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialEduc()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT MEY.SchoolYear Año, CdG.DescSpanish Grado, CdES.DescSpanish Estado, S.Name Escuela, cdEC.DescSpanish Carrera,  MEY.UserId 'Usuario' " + _
              "FROM	MemberEducationYear MEY INNER JOIN School S On MEY.Project=S.Project and MEY.SchoolCode=S.Code AND MEY.RecordStatus = S.RecordStatus " + _
              "INNER JOIN CdGrade CdG On MEY.Grade=CdG.Code INNER JOIN CdEducationStatus CdES On MEY.Status=CdES.Code " + _
              "LEFT JOIN CdEducationCareer cdEC ON cdEC.Code = MEY.Career " + _
              "WHERE MEY.RecordStatus=' ' AND MEY.Project = '" + S + "' AND MEY.MemberId = " + MiembroV.Text + " " + _
              "GROUP BY MEY.SchoolYear, CdG.DescSpanish, CdEs.DescSpanish, S.Name, cdEC.DescSpanish, MEY.UserId " + _
              "ORDER BY MEY.SchoolYear DESC  "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    'Private Sub HistorialEducL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles HistorialEducL.LinkClicked

    'End Sub

    Private Sub HistorialFerias()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT   MEF.SchoolYear Año, CdST.DescSpanish TipoBolsa, " + _
              "CASE WHEN CdSSa.DescSpanish IS NULL THEN Cast(LeathersS as nvarchar(5)) +'-'+ MEF.LeatherSD ELSE Cast(LeathersS as nvarchar(5)) +'-'+ CdSSa.DescSpanish END as ZapatoCuero, " + _
              "CASE WHEN CdSSb.DescSpanish IS NULL THEN (Cast(TennisSS as nvarchar(5)) +'-'+ MEF.TennisSD) ELSE Cast(TennisSS as nvarchar(5)) +'-'+ CdSSb.DescSpanish END as ZapatoTenis, " + _
              "BlouseShirt BlusaCamisa, MEF.Polo, Cloth Tela, Sweater Sueter, Tshirt " + _
              "Playera, Jacket Chumpa, Pants, Vest Chaleco, S.name ProxEscuela, cdEC.DescSpanish ProxCarrera, MEF.UserId Usuario " + _
              "FROM MemberEducationFair MEF LEFT JOIN CdSchoolSuppliesTypeBag CdST ON MEF.SchoolSuppliesTypeBag = CdST.Code " + _
              "LEFT JOIN CdShoeStyle CdSSa ON CdSSa.Code=MEF.LeatherSD " + _
              "LEFT JOIN CdShoeStyle CdSSb ON CdSSb.Code=MEF.TennisSD " + _
              "LEFT JOIN dbo.CdEducationCareer cdEC ON cdEC.Code = MEF.NextCareer  " +
              "LEFT JOIN dbo.School S ON S.Code = MEF.NextSchool AND S.Project = MEF.Project AND S.RecordStatus = MEF.RecordStatus " + _
              "WHERE  MEF.Project='" + S + "' and MEF.RecordStatus=' ' and MEF.MemberId=" + MiembroV.Text + " " + _
              "ORDER BY MEF.SchoolYear DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialSemaforos()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        '
        sql = "SELECT cdEs.DescSpanish Semáforo, Unit Unidad , dbo.fn_GEN_formatDate(StartDate, 'es') Registro, CASE WHEN EndDate IS NULL THEN 'ACTUAL' ELSE 'histórico' END Estado, UserId Usuario " + _
              "FROM dbo.MemberEducationSemaphore MES " + _
              " INNER JOIN dbo.CdEducationSemaphore cdES ON  cdES.Code = MES.EducSemaphore " + _
              "WHERE  MES.Project='" + S + "' and MES.RecordStatus=' ' and MES.MemberId=" + MiembroV.Text + " AND YEAR(creationdatetime) = " + AñoV.Text + " " + _
              "ORDER BY Unit, creationdatetime "

        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable
        Dim actualD As DateTime = DateTime.Now
        AñoV.Text = actualD.Year.ToString
        Dim secc As String = ""

        sql = "SELECT * " + _
              "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + AñoV.Text + ") L "
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            'Info General
            NombreV.Text = listTable.Rows(f)("Nombres") + " " + listTable.Rows(f)("Apellidos")
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad"))
            FamiliaV.Text = listTable.Rows(f)("Familia")
            FamiliaV.ReadOnly = True
            ClasificacionV.Text = chequearValor(listTable.Rows(0)("Clasificación"))
            TSV.Text = chequearValor(listTable.Rows(0)("TS"))
            fotoDire = chequearValor(listTable.Rows(0)("Foto"))
            AfiliacionV.Text = chequearValor(listTable.Rows(0)("TipoAfil"))
            EstadoAfilV.Text = chequearValor(listTable.Rows(0)("EstadoAfil"))

            FaseV.Text = chequearValor(listTable.Rows(0)("Fase"))
            semaforo(chequearValor(listTable.Rows(0)("Semaforo")), SemaforoV)

            ' If esApadrinado(S, MiembroV.Text) = True Then
            If Len(EstadoAfilV.Text) > 0 Then
                'Info Educ
                gradoOr = chequearValor(listTable.Rows(0)("GradoId"))
                gradoCombo.SelectedValue = gradoOr
                gradoCombo.Size = New Point(100 + (Len(chequearValor(listTable.Rows(0)("Grado"))) * 5), 21)

                escuelaOr = chequearValor(listTable.Rows(0)("EscuelaId"))
                escuelaCombo.SelectedValue = escuelaOr
                escuelaCombo.Size = New Point(100 + (Len(chequearValor(listTable.Rows(0)("Escuela"))) * 5), 21)

                carreraOr = chequearValor(listTable.Rows(0)("CarreraId"))

                If Len(carreraOr) = 0 Then
                    carreraCombo.Visible = False
                    carreraL.Visible = False
                Else
                    carreraL.Visible = True
                    carreraCombo.Visible = True
                    carreraCombo.SelectedValue = carreraOr
                    carreraCombo.Size = New Point(100 + (Len(chequearValor(listTable.Rows(0)("Carrera"))) * 5), 21)
                End If

                If Len(chequearValor(listTable.Rows(0)("Sección"))) > 0 Then
                    SeccionV.Text = chequearValor(listTable.Rows(0)("Sección"))
                    SeccionL.Text = "Sección:"
                    SeccionV.Visible = True
                    SeccionL.Visible = True
                End If

                estadoOr = chequearValor(listTable.Rows(0)("EstadoId"))
                EstadoV.Text = chequearValor(listTable.Rows(0)("Estado_Educ"))
                excepEsOr = chequearValor(listTable.Rows(0)("RazonNoContinuar"))
                RazonV.Text = excepEsOr

                If Len(chequearValor(listTable.Rows(0)("ExcepPorcentaje"))) > 0 Then
                    ExcepcionPorcentajeV.Text = chequearValor(listTable.Rows(0)("ExcepPorcentaje"))
                    ExcepcionPorcentajeL.Text = "Excepción %:"
                    ExcepcionPorcentajeV.Visible = True
                    ExcepcionPorcentajeL.Visible = True
                End If

                If Len(chequearValor(listTable.Rows(0)("Maestro"))) > 0 Then
                    MaestroV.Visible = True
                    MaestroL.Visible = True
                    MaestroL.Text = "Maestro:"
                    MaestroV.Text = chequearValor(listTable.Rows(0)("Maestro"))
                End If

                CertificadoV.Checked = listTable.Rows(0)("TieneCertificado")
                certificadoOr = CertificadoV.Checked

                'If Len(chequearValor(listTable.Rows(0)("RazonNoContinuar"))) > 0 Then
                '    RazonV.Text = chequearValor(listTable.Rows(0)("RazonNoContinuar"))
                '    RazonL.Text = "No Continuar:"
                '    RazonV.Visible = True
                '    RazonL.Visible = True
                'End If

                CreationDateL.Text = chequearValor(listTable.Rows(0)("CreationDT"))
                porcentajeEduc()
            Else
                gradoCombo.Text = ""
                SeccionV.Text = ""
                EstadoV.Text = ""
                PorcentajeV.Text = ""
                ExcepcionPorcentajeV.Text = ""
                MaestroV.Text = ""
                CertificadoV.Checked = False
                RazonV.Text = ""
                EstadoAfilV.Text.ToUpper()
            End If

            fotoMiembro()
            listaReembolsos()
            HistorialCalificaciones()
            avisosFamiliares()
            PanelInfoGen.Visible = True
        Next

        MiembroV.Enabled = False
        PanelSecundario.Visible = True
        PanelInfoGen.Visible = True
        GridsTable.Visible = True
        listaObservaciones()
        HistorialCalificaciones()
        AvisosLink.Focus()
    End Sub

    Private Sub ingresarNuevaObservacion(ByVal idCategoria As String)
        Dim n As Integer
        sql = "SELECT MAX(IdObservation) 'Ultimo' FROM MemberEducationObservation "
        n = bdEntero(sql, "Ultimo") + 1
        Dim fecha As DateTime = Now
        sql = "INSERT INTO MemberEducationObservation VALUES (" + n.ToString + ", GETDATE(), '" + S + "', " + MiembroV.Text + ", '" + idCategoria + "', GETDATE(), '" + ObservacionesV.Text + "', ' ', '" + U + "', NULL)"
        bdInsertar(sql)
        categoriaCombo.SelectedIndex = -1
        ObservacionesV.Text = ""
        idObsL.Text = "0"
        listaObservaciones()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()

    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, FamiliaV.Text) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "RIAE"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbInformation, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub listaActividades()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT cdMAT.DescSpanish AS ACTIVIDAD, dbo.fn_GEN_FormatDate(MA.ActivityDateTime, 'ES') AS Fecha, MA.Notes AS Observaciones, MA.UserId AS Usuario " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdMAT ON MA.Type = cdMAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND cdMAT.FunctionalArea = 'EDUC' AND MA.Project = '" + S + "' AND YEAR(MA.ActivityDateTime) = " + AñoV.Text + " AND MA.MemberId = " + MiembroV.Text + _
              " ORDER BY MA.ActivityDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub ListadoTelefonos()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT * FROM dbo.fn_GEN_ListaTelefonosFamilia('" + S + "', " + FamiliaV.Text + ") L"
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub listaObservaciones()
        ObservacionesGrid.DataSource = Nothing
        ObservacionesGrid.Rows.Clear()
        sql = "SELECT 'Borrar' '_', cdC.DescSpanish AS Categoría, dbo.fn_GEN_FormatDate(MEO.ObservationDateTime, 'ES')  + ' ' + CONVERT(varchar, MEO.ObservationDateTime, 108)  AS Fecha, " + _
                 "MEO.Observation AS Observación,  MEO.UserId AS Usuario,  MEO.IdObservation " + _
              "FROM  dbo.MemberEducationObservation MEO INNER JOIN dbo.CdMemberEducObservationCategory cdC ON MEO.Category = cdC.Code " + _
              "WHERE MEO.RecordStatus = ' ' AND MEO.Project = '" + S + "' AND YEAR(MEO.ObservationDateTime) = " + AñoV.Text + " AND MEO.MemberId = " + MiembroV.Text + _
              " ORDER BY MEO.ObservationDateTime DESC "
        bdGrid(sql, ObservacionesGrid)
        ObservacionesGrid.Columns.Item(5).Visible = False
        agregarColumnaAccion(0, ObservacionesGrid)
        For i = 0 To ObservacionesGrid.Rows.Count - 1
            ObservacionesGrid.Item(0, i).Value = "Borrar"
        Next
    End Sub

    Private Sub listaReembolsos()
        ReembolsosGrid.DataSource = Nothing
        ReembolsosGrid.Rows.Clear()
        ReembolsosGrid.Visible = False
        sql = "SELECT Tipo, Autorizado, Pagado, Cantidad Total, [Cantidad Aprobada] Aprobado, Porcentaje, AprobadoPor, Observaciones " + _
              "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
              "WHERE YEAR(FechaA) = " + AñoV.Text + " AND Area = 'EDUC' " + _
              "ORDER BY FechaA DESC "
        bdGrid(sql, ReembolsosGrid)
        ReembolsosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ReembolsosGrid.AutoResizeColumns()
        ReembolsosGrid.Visible = True
    End Sub

    Private Sub listaReembolsosPorTipo()
        ReembolsosGrid.DataSource = Nothing
        ReembolsosGrid.Rows.Clear()
        ReembolsosGrid.Visible = False
        sql = "SELECT Tipo, SUM(Cantidad) Total, SUM([Cantidad Aprobada]) Aprobado  " + _
              "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
              "WHERE YEAR(FechaA) = " + AñoV.Text + " AND Area = 'EDUC' " + _
              "GROUP BY  Tipo ORDER BY  Tipo "
        bdGrid(sql, ReembolsosGrid)
        ReembolsosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ReembolsosGrid.AutoResizeColumns()
        ReembolsosGrid.Visible = True
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            validaMiembro()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub miscInfo()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT * FROM dbo.fn_BECA_miscIngo('" + S + "'," + MiembroV.Text + ")"
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub nuevaActividadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevaActividadButton.Click
        If Len(actividadCombo.Text) = 0 Then
            MsgBox("No ha seleccionado la actividad", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
        Else
            guardarActividad()
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ResumenBecas
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ObservacionesGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ObservacionesGrid.CellContentClick
        Dim f, c, id As Integer
        c = ObservacionesGrid.CurrentCellAddress.X
        f = ObservacionesGrid.CurrentCellAddress.Y

        If c = 0 Then
            Dim msg As String = "¿Esta seguro de borrar la observación?"
            Dim title As String = "Becas"
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox(msg, style, title)
            If response = MsgBoxResult.Yes Then
                id = ObservacionesGrid.Item(5, f).Value()
                borrarObservacion(id)
            End If
        Else
            idObsL.Text = ObservacionesGrid.Item(5, f).Value()
            categoriaCombo.Text = ObservacionesGrid.Item(1, f).Value()
            ObservacionesV.Text = ObservacionesGrid.Item(3, f).Value()
            categoriaCombo.Enabled = False
        End If
    End Sub

    Private Sub OpcionesButton_Click(sender As Object, e As EventArgs) Handles OpcionesButton.Click
        If OpcionesCombo.SelectedValue = "ACTI" Then
            listaActividades()
        ElseIf OpcionesCombo.SelectedValue = "HEDU" Then
            HistorialEduc()
        ElseIf OpcionesCombo.SelectedValue = "HARE" Then
            HistorialAreas()
        ElseIf OpcionesCombo.SelectedValue = "TELE" Then
            ListadoTelefonos()
        ElseIf OpcionesCombo.SelectedValue = "INFG" Then
            miscInfo()
        ElseIf OpcionesCombo.SelectedValue = "HUTI" Then
            HistorialFerias()
        ElseIf OpcionesCombo.SelectedValue = "HSEM" Then
            HistorialSemaforos()
        Else
            HistorialCalificaciones()
        End If
    End Sub


    Private Sub porcentajeEduc()
        porcentaje = porcentajeReembolsosBecas(S, MiembroV.Text) / 100
        PorcentajeV.Text = porcentaje.ToString("P", CultureInfo.CreateSpecificCulture("es-GT"))
    End Sub

    'Private Sub razonNoContinuar()
    '    If estadoSel = "NOSI" Or estadoSel = "NOSR" Or estadoSel = "No siguió" Or estadoSel = "No siguió (para desafiliar)" Then

    '        sql = "SELECT Code, DescSpanish Razon FROM CdEducationReasonNotToContinue WHERE Active = 1 ORDER BY DescSpanish "
    '        bdCombo(sql, RazonV, "Code", "Razon")
    '        RazonV.Visible = True
    '        RazonL.Visible = True
    '        n = 1
    '    Else
    '        estadoSel = ""
    '        RazonV.Visible = False
    '        RazonL.Visible = False
    '        n = 0
    '    End If
    'End Sub


    Private Sub ReembolsosDet_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ReembolsosDet.LinkClicked
        listaReembolsos()
    End Sub

    Private Sub ReembolsosGrup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ReembolsosGrup.LinkClicked
        listaReembolsosPorTipo()
    End Sub

    Private Sub validaMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            If esApadrinado(S, MiembroV.Text) = True Or esGraduado(S, MiembroV.Text) = True Or esDesafiliado(S, MiembroV.Text) = True Then
                valoresIniciales()
            Else
                MsgBox("Esta pantalla es solo para apadrinados, desafiliados o graduados", vbQuestion, My.Resources.versionFamilias2)
                MiembroV.Text = ""
                FamiliaV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        Dim n As Integer
        'lista categoria observaciones
        sql = "SELECT Code, " + descripcion() + " 'Categoria' FROM dbo.CdMemberEducObservationCategory WHERE Active = 1 ORDER BY DescSpanish "
        bdCombo(sql, categoriaCombo, "Code", "Categoria")

        ''lista activiades
        sql = "SELECT Code, " + descripcion() + " 'Actividad' FROM dbo.CdMemberActivityType " + _
              "WHERE Project IN ('" + S + "', '*') AND FunctionalArea = 'EDUC' AND Active = 1 AND NotesRequired = 0 " + _
              "ORDER BY DescSpanish "
        bdCombo(sql, actividadCombo, "Code", "Actividad")

        ''lista grados
        sql = "SELECT Code, " + descripcion() + " 'Grado' FROM dbo.CdGrade WHERE ValidValue = 1 ORDER BY Orden"
        bdCombo(sql, gradoCombo, "Code", "Grado")

        ''lista estados educativos
        sql = "SELECT Code, " + descripcion() + " Estado  FROM CdEducationStatus  WHERE ValidValue = 1 "
        bdCombo(sql, EstadoV, "Code", "Estado")

        ''lista excepciones de estados educativos
        sql = "SELECT Code, " + descripcion() + " Excep  FROM CdEducationReasonNotToContinue  WHERE Active = 1 "
        bdCombo(sql, RazonV, "Code", "Excep")

        ''lista escuelas
        sql = "SELECT Code, Name AS Escuela FROM dbo.School WHERE RecordStatus = ' ' AND Project = '" + S + "' AND (Active = 1) ORDER BY Name"
        bdCombo(sql, escuelaCombo, "Code", "Escuela")

        ''lista carreras
        sql = "SELECT Code, " + descripcion() + " AS carrera FROM dbo.CdEducationCareer WHERE  EducationLevel <> 'UNIV' ORDER BY DescSpanish"
        bdCombo(sql, carreraCombo, "Code", "carrera")

        comboOpciones()
        OpcionesCombo.SelectedValue = "HCAL"


        'información general
        infoGen()

        ''acceso a modificar
        sql = "SELECT COUNT(*) Total FROM dbo.FwEmployeeRole " + _
              "WHERE EmployeeId = '" + U + "' AND Organization = '" + S + "' AND Status = 'ACTV' AND Role IN ('ASED', 'ADED', 'SUPE') "
        n = bdEntero(sql, "Total")
        If n = 0 Or EstadoAfilV.Text = "Graduado" Or EstadoAfilV.Text = "Desafiliado" Then
            gradoCombo.Enabled = False
            escuelaCombo.Enabled = False
            carreraCombo.Enabled = False
            EstadoV.Enabled = False
            CertificadoV.Enabled = False
            GuardarButton.Visible = False

            gradoCombo.DropDownStyle = ComboBoxStyle.Simple
            escuelaCombo.DropDownStyle = ComboBoxStyle.Simple
            EstadoV.DropDownStyle = ComboBoxStyle.Simple
            'RazonNoContinuarCombo.DropDownStyle = ComboBoxStyle.Simple
            carreraCombo.DropDownStyle = ComboBoxStyle.Simple

            ObservacionesGrid.Columns.Item(0).Visible = False 'Borrar
            nuevaObservacionL.Visible = False
            categoriaCombo.Visible = False
            ObservacionesV.Visible = False
            GuardarButton.Visible = False

            nActividadL.Visible = False
            actividadCombo.Visible = False
            ActividadNotasV.Visible = False
            nuevaActividadButton.Visible = False
            GuardarObsButton.Visible = False
            autorizarReemLink.Visible = False

        Else
            gradoCombo.Enabled = True
            escuelaCombo.Enabled = True
            carreraCombo.Enabled = True
            GuardarButton.Visible = True
        End If

        EstadoV.Focus()
    End Sub





End Class