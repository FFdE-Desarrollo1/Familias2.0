' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AñoEscolar
    Public gradoOr, estadoOr, escuelaOr, carreraOr, razonOr As String
    Dim ahora As DateTime
    Dim n As Integer = 0
    Dim estadoSel As String = ""
    Dim certificadoOr As Boolean
    Dim tipo As String = ""

    Private Property EstadoCod As Object

    Private Sub AñoEscolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()

        valoresIniciales()
    End Sub

    Private Sub ActividadesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ActividadesCheck.CheckedChanged
        If ActividadesCheck.Checked = True Then
            tipo = "ACTIVIDAD"
            ReembolsosCheck.Checked = False
            ObservacionesCheck.Checked = False
            listaActividades()
        End If
    End Sub

    Private Sub ActividadesGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim f, c As Integer
        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y

        If c = 0 And f >= 0 Then
            Dim tipo As String = HistorialGrid.Item(2, f).Value()
            Dim creat As String = HistorialGrid.Item(1, f).Value()

            Dim msg As String = "¿Esta seguro de borrar la actividad?"
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox(msg, style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberActivity SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + '" + U + "' " + _
                      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
                      "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + tipo + "'"
                bdEjecutarSQL(sql)
                listaActividades()
            End If
        End If
    End Sub

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

                    'AvisosGrid.Height = AvisosGrid.RowCount * 25
                    'AvisosGrid.Width = g.MeasureString(avisoLargo, AvisosGrid.Font).Width
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

    'Private Function estadoCorrecto() As Boolean
    '    If n = 1 Then
    '        If Len(RazonNoContinuarCombo.Text) = 0 Then
    '            MsgBox("Necesita seleccionar la razón de no continuar estudiando", vbQuestion, My.Resources.versionFamilias2)
    '            estadoCorrecto = False
    '        Else
    '            estadoCorrecto = True
    '        End If
    '    Else
    '        RazonNoContinuarCombo.Text = ""
    '        estadoCorrecto = True
    '    End If
    'End Function

    Private Sub EstadoV_TextChanged(sender As Object, e As EventArgs) Handles EstadoV.TextChanged
        If Len(EstadoV.Text) > 0 Then
            estadoSel = EstadoV.Text
            'razonNoContinuar()
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(escuelaCombo.Text) = 0 Or Len(gradoCombo.Text) = 0 Or Len(EstadoV.Text) = 0 Then
        Else
            ahora = Now
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
            Dim nRazon As String = "ReasonNotToContinue"

            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            If gradoCombo.SelectedValue <> gradoOr Then
                response = MsgBox("¿Esta seguro de cambiar el grado? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snGrado = True
                    nGrado = "'" + gradoCombo.SelectedValue + "'"
                End If
            End If

            'ESCUELA
            Dim tEscuela As String = ""
            If Len(escuelaCombo.SelectedValue) = 0 Then
                verificarCod(tEscuela, "escuela")
            Else
                tEscuela = escuelaCombo.SelectedValue
            End If

            If tEscuela <> escuelaOr Then
                response = MsgBox("¿Esta seguro de cambiar la escuela? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snEscuela = True
                    nEscuela = "'" + escuelaCombo.SelectedValue + "'"
                End If
            End If


            'ESTADO
            Dim tEstado As String = ""
            If Len(EstadoV.SelectedValue) = 0 Then
                verificarCod(tEstado, "estado")
            Else
                tEstado = EstadoV.SelectedValue
            End If
            If tEstado <> estadoOr Then
                response = MsgBox("¿Esta seguro de cambiar el estado educativo? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then

                    snEstado = True
                    nEstado = "'" + EstadoV.SelectedValue + "'"
                Else
                    snEstado = False

                End If
            End If

            'EXCEPCION
            Dim tExcepcion As String = ""
            If Len(RazonNoContinuarCombo.Text) > 0 Then
                verificarCod(tExcepcion, "excepcion")
            End If

            If tExcepcion <> razonOr Then
                response = MsgBox("¿Esta seguro de la excepción de estado educativo? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    snExcepcionEs = True
                    nRazon = "'" + RazonNoContinuarCombo.SelectedValue + "'"
                Else
                    If Len(RazonNoContinuarCombo.Text) > 0 Then
                        nRazon = "'" + RazonNoContinuarCombo.SelectedValue + "'"
                    Else
                        nRazon = "NULL"
                    End If
                End If
            End If

            'CARRERA
            Dim tCarrera As String = ""
            If Len(carreraCombo.Text) > 0 Then
                verificarCod(tCarrera, "carrera")
            End If

            If tCarrera <> carreraOr Then
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
                'InputBox("", "", sql)
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
                    escuelaOr = escuelaCombo.SelectedValue
                End If

                If snCarrera = True Then
                    ingresarNuevaObservacion("CARR")
                    carreraOr = carreraCombo.SelectedValue
                End If

                If snEstado = True Then
                    ingresarNuevaObservacion("ESTA")
                    agregarActividad(EstadoV)
                    estadoOr = EstadoV.SelectedValue
                End If

                If snExcepcionEs = True Then
                    ingresarNuevaObservacion("EXCE")
                    razonOr = RazonNoContinuarCombo.SelectedValue
                End If

                MsgBox("Actualización correcta", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                regresar()
                'infoGen()
                'HistorialEduc()
            End If
            End If
    End Sub

    Private Sub HistorialGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        Dim f, c, id As Integer
        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y

        If tipo = "REEMBOLSO" Then

        ElseIf tipo = "ACTIVIDAD" Then
            If c = 0 And f >= 0 Then
                Dim tipo As String = HistorialGrid.Item(2, f).Value()
                Dim creat As String = HistorialGrid.Item(1, f).Value()

                Dim msg As String = "¿Esta seguro de borrar la actividad?"
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox(msg, style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    sql = "UPDATE dbo.MemberActivity SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + '" + U + "' " + _
                          "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
                          "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + tipo + "'"
                    bdEjecutarSQL(sql)
                    ActividadesCheck.Checked = False
                    ActividadesCheck.Checked = True
                End If
            End If
        ElseIf tipo = "OBSERVACION" Then
            If c = 0 Then
                Dim msg As String = "¿Esta seguro de borrar la observación?"
                Dim title As String = "Becas"
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then
                    id = HistorialGrid.Item(5, f).Value()
                    sql = "UPDATE dbo.MemberEducationObservation SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Observation = Observation + ' (" + U + ")' " + _
                             "WHERE RecordStatus = ' ' AND IdObservation = " + id.ToString + " "
                    bdInsertar(sql)
                    ObservacionesCheck.Checked = False
                    ObservacionesCheck.Checked = True
                End If
            End If
        Else

        End If
    End Sub

    Private Sub infoGeneral()
        Dim listTable As New DataTable
        sql = "SELECT * FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + AñoV.Text + ") L "
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            'Info General
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad"))
            
            ClasificacionV.Text = chequearValor(listTable.Rows(0)("Clasificación"))
            TSV.Text = chequearValor(listTable.Rows(0)("TS"))
            'fotoDire = chequearValor(listTable.Rows(0)("Foto"))
            AfiliacionV.Text = chequearValor(listTable.Rows(0)("TipoAfil"))
            EstadoAfilV.Text = chequearValor(listTable.Rows(0)("EstadoAfil"))
            FaseV.Text = chequearValor(listTable.Rows(0)("Fase"))
            semaforo(chequearValor(listTable.Rows(0)("Semaforo")), SemaforoV)
            If esApadrinado(S, MiembroV.Text) = True Then
                'Info Educ
                If Len(carreraCombo.Text) = 0 Then
                    carreraCombo.Visible = False
                    carreraL.Visible = False
                End If

                If Len(chequearValor(listTable.Rows(0)("Sección"))) > 0 Then
                    SeccionV.Text = chequearValor(listTable.Rows(0)("Sección"))
                    SeccionL.Text = "Sección:"
                    SeccionV.Visible = True
                    SeccionL.Visible = True
                End If

                'If Len(chequearValor(listTable.Rows(0)("ExcepPorcentaje"))) > 0 Then
                '    ExcepcionPorcentajeV.Text = chequearValor(listTable.Rows(0)("ExcepPorcentaje"))
                '    ExcepcionPorcentajeL.Text = "Excepción %:"
                '    ExcepcionPorcentajeV.Visible = True
                '    ExcepcionPorcentajeL.Visible = True
                'End If

                If Len(chequearValor(listTable.Rows(0)("Maestro"))) > 0 Then
                    MaestroV.Visible = True
                    MaestroL.Visible = True
                    MaestroL.Text = "Maestro:"
                    MaestroV.Text = chequearValor(listTable.Rows(0)("Maestro"))
                End If

                certificadoOr = listTable.Rows(0)("TieneCertificado")
                CertificadoV.Checked = certificadoOr

                'If Len(chequearValor(listTable.Rows(0)("RazonNoContinuar"))) > 0 Then
                '    RazonNoContinuarCombo.Text = chequearValor(listTable.Rows(0)("RazonNoContinuar"))
                '    RazonL.Text = "No Continuar:"
                '    RazonNoContinuarCombo.Visible = True
                '    RazonL.Visible = True
                'End If

                CreationDateL.Text = chequearValor(listTable.Rows(0)("CreationDT"))

                'porcentajeEduc()
            Else
                gradoCombo.Text = ""
                SeccionV.Text = ""
                EstadoV.Text = ""
                'PorcentajeV.Text = ""
                'ExcepcionPorcentajeV.Text = ""
                MaestroV.Text = ""

                EstadoAfilV.Text.ToUpper()
            End If

            'fotoMiembro()
            'listaReembolsos()
            'listaActividades()
            avisosFamiliares()
            'PanelInfoGen.Visible = True
        Next
    End Sub

    Private Sub ingresarNuevaObservacion(ByVal idCategoria As String)
        'Dim fechaOb As DateTime
        'fechaOb = AñoV.Text + "/" + ahora.Month.ToString + "/" + ahora.Day.ToString + " " + ahora.ToLongTimeString

        Dim n As Integer
        sql = "SELECT MAX(IdObservation) 'Ultimo' FROM MemberEducationObservation "
        n = bdEntero(sql, "Ultimo") + 1

        'sql = "INSERT INTO MemberEducationObservation VALUES (" + n.ToString + ", GETDATE(), '" + S + "', " + MiembroV.Text + ", '" + idCategoria + "', '" + fechaOb.ToString(en.DateTimeFormat) + "', '', ' ', '" + U + "', NULL)"
        sql = "INSERT INTO MemberEducationObservation VALUES (" + n.ToString + ", GETDATE(), '" + S + "', " + MiembroV.Text + ", '" + idCategoria + "', GETDATE(), '', ' ', '" + U + "', NULL)"
        bdInsertar(sql)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiarGrid()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
    End Sub

    Private Sub listaActividades()
        limpiarGrid()
        sql = "SELECT 'Borrar' ' ', CONVERT(nvarchar(30), MA.CreationDateTime, 21) Crea, cdAT.Code Cod,dbo.fn_GEN_FormatDate(MA.ActivityDateTime, 'ES') AS Fecha, cdAT.DescSpanish AS Actividad, MA.Notes AS Observaciones, MA.UserId Usuario " + _
                 "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdAT ON MA.Type = cdAT.Code " + _
                 "WHERE MA.RecordStatus = ' ' AND cdAT.FunctionalArea = 'EDUC' AND MA.Project = '" + S + "' AND YEAR(MA.ActivityDateTime) = " + AñoV.Text + " AND MA.MemberId = " + MiembroV.Text + " " + _
                 "ORDER BY MA.CreationDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.Columns.Item(1).Visible = False 'creat
        HistorialGrid.Columns.Item(2).Visible = False 'Tipo
        agregarColumnaAccion(0, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub listaObservaciones()
        limpiarGrid()
        sql = "SELECT 'Borrar' ' ', cdC.DescSpanish AS Categoría, dbo.fn_GEN_FormatDate(MEO.ObservationDateTime, 'ES')  + ' ' + CONVERT(varchar, MEO.ObservationDateTime, 108)  AS Fecha, " + _
                 "MEO.Observation AS Observación,  MEO.UserId AS Usuario,  MEO.IdObservation " + _
              "FROM  dbo.MemberEducationObservation MEO INNER JOIN dbo.CdMemberEducObservationCategory cdC ON MEO.Category = cdC.Code " + _
              "WHERE MEO.RecordStatus = ' ' AND MEO.Project = '" + S + "' AND YEAR(MEO.ObservationDateTime) = " + AñoV.Text + " AND MEO.MemberId = " + MiembroV.Text + _
              " ORDER BY MEO.ObservationDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.Columns.Item(5).Visible = False
        agregarColumnaAccion(0, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub listaReembolsos()
         limpiarGrid()
        sql = "SELECT Tipo, Autorizado, Pagado, Cantidad Total, [Cantidad Aprobada] Aprobado, Porcentaje, AprobadoPor, Observaciones " + _
              "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
              "WHERE YEAR(FechaA) = " + AñoV.Text + " AND Area = 'EDUC' " + _
              "ORDER BY FechaA DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New HistorialEducativo
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ObservacionesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ObservacionesCheck.CheckedChanged
        If ObservacionesCheck.Checked = True Then
            tipo = "OBSERVACION"
            ReembolsosCheck.Checked = False
            ActividadesCheck.Checked = False
            listaObservaciones()
        End If
    End Sub

    'Private Sub razonNoContinuar()
    '    If estadoSel = "NOSI" Or estadoSel = "NOSR" Or estadoSel = "No siguió" Or estadoSel = "No siguió (para desafiliar)" Then

    '        sql = "SELECT Code, DescSpanish Razon FROM CdEducationReasonNotToContinue WHERE Active = 1 ORDER BY DescSpanish "
    '        bdCombo(sql, RazonNoContinuarCombo, "Code", "Razon")
    '        RazonNoContinuarCombo.Visible = True
    '        RazonL.Visible = True
    '        n = 1
    '    Else
    '        estadoSel = ""
    '        RazonNoContinuarCombo.Visible = False
    '        RazonL.Visible = False
    '        n = 0
    '    End If
    'End Sub

    Private Sub ReembolsosCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ReembolsosCheck.CheckedChanged
        If ReembolsosCheck.Checked = True Then
            tipo = "REEMBOLSO"
            ActividadesCheck.Checked = False
            ObservacionesCheck.Checked = False
            listaReembolsos()
        End If
    End Sub

    Private Sub regresar()
        Dim nxt As New HistorialEducativo
        nxt.MiembroV.Text = MiembroV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub RegresarButton_Click(sender As Object, e As EventArgs) Handles RegresarButton.Click
        regresar()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT COUNT(*) Total FROM dbo.FwEmployeeRole " + _
                 "WHERE EmployeeId = '" + U + "' AND Organization = '" + S + "' AND Status = 'ACTV' AND Role IN ('ASED', 'ADED', 'SUPE') "
        Dim n = bdEntero(sql, "Total")

        'MsgBox(gradoOr & "..." & estadoOr & "..." & escuelaOr & "..." & carreraOr)
        If n = 0 Then
            gradoCombo.Enabled = False
            escuelaCombo.Enabled = False
            carreraCombo.Enabled = False
            EstadoV.Enabled = False
            CertificadoV.Enabled = False
            'RazonNoContinuarCombo.Enabled = False
            gradoCombo.DropDownStyle = ComboBoxStyle.Simple
            escuelaCombo.DropDownStyle = ComboBoxStyle.Simple
            EstadoV.DropDownStyle = ComboBoxStyle.Simple
            RazonNoContinuarCombo.DropDownStyle = ComboBoxStyle.Simple
            carreraCombo.DropDownStyle = ComboBoxStyle.Simple
        Else
            'lista de grados
            sql = "SELECT Code, " + descripcion() + " 'Grado' FROM dbo.CdGrade WHERE ValidValue = 1 ORDER BY Orden"
            bdCombo(sql, gradoCombo, "Code", "Grado")
            '  gradoCombo.Text = gradoOr

            ''lista estados educativos
            sql = "SELECT Code, " + descripcion() + " Estado  FROM CdEducationStatus  WHERE ValidValue = 1 "
            bdCombo(sql, EstadoV, "Code", "Estado")
            '   EstadoV.Text = estadoOr

            ''lista excepciones de estados educativos
            sql = "SELECT Code, " + descripcion() + " Excep  FROM CdEducationReasonNotToContinue  WHERE Active = 1 "
            bdCombo(sql, RazonNoContinuarCombo, "Code", "Excep")

            ''lista escuelas
            sql = "SELECT Code, Name AS Escuela FROM dbo.School WHERE RecordStatus = ' ' AND Project = '" + S + "' AND (Active = 1) ORDER BY Name"
            bdCombo(sql, escuelaCombo, "Code", "Escuela")
            ' escuelaCombo.Text = escuelaOr

            ''lista carreras
            sql = "SELECT Code, " + descripcion() + " AS carrera FROM dbo.CdEducationCareer WHERE  EducationLevel <> 'UNIV' ORDER BY DescSpanish"
            bdCombo(sql, carreraCombo, "Code", "carrera")
            '  carreraCombo.Text = carreraOr


            'MsgBox(gradoOr & "..." & estadoOr & "..." & escuelaOr & "..." & carreraOr)
            GuardarButton.Visible = True
        End If
        'MsgBox(gradoOr & "..." & estadoOr & "..." & escuelaOr & "..." & carreraOr)
        gradoCombo.Text = gradoOr
        EstadoV.Text = estadoOr
        escuelaCombo.Text = escuelaOr
        carreraCombo.Text = carreraOr
        RazonNoContinuarCombo.Text = razonOr
        gradoOr = gradoCombo.SelectedValue

        estadoOr = EstadoV.SelectedValue
        If Len(estadoOr) = 0 Then
            verificarCod(estadoOr, "estado")
        End If

        escuelaOr = escuelaCombo.SelectedValue
        If Len(escuelaOr) = 0 Then
            verificarCod(escuelaOr, "escuela")
        End If

        carreraOr = carreraCombo.SelectedValue
        If Len(carreraCombo.Text) > 0 Then
            verificarCod(carreraOr, "carrera")
        End If

        razonOr = RazonNoContinuarCombo.SelectedValue
        If Len(RazonNoContinuarCombo.Text) > 0 Then
            verificarCod(razonOr, "excepcion")
        End If

        ' MsgBox(gradoOr & "...estado: " & estadoOr & "...excep: " & razonOr & "...escuela:" & escuelaOr & "...carrera:" & carreraOr)
        AñoL.Text = AñoL.Text & AñoV.Text
        infoGeneral()
        ActividadesCheck.Checked = True
    End Sub

    Private Sub verificarCod(ByRef campo, ByVal opcion)
        Dim tCampo As String = "Code"
        sql = "SELECT Code "
        If opcion = "carrera" Then
            sql = sql + "FROM CdEducationCareer  WHERE DescSpanish = '" + carreraCombo.Text + "'"
        ElseIf opcion = "estado" Then
            sql = sql + "FROM CdEducationStatus  WHERE DescSpanish = '" + EstadoV.Text + "'"
        ElseIf opcion = "escuela" Then
            tCampo = "Name"
            sql = sql + "FROM School  WHERE RecordStatus = ' ' AND Name = '" + escuelaCombo.Text + "'"
        ElseIf opcion = "excepcion" Then
            sql = sql + "FROM CdEducationReasonNotToContinue  WHERE DescSpanish = '" + RazonNoContinuarCombo.Text + "'"
        End If

        campo = bdPalabra(sql, tCampo)
    End Sub


End Class