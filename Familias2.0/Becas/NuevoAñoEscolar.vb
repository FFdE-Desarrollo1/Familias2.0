' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class NuevoAñoEscolar
    Dim actualAñoE, nuevoAñoE As Integer
    Dim aGrado, aEstado, aCarrera, aEscuela, aNivel, nuevoN, proxGrad As String
    Dim añosHistorial As String = ""
    Dim ahora As DateTime
    Dim style As MsgBoxStyle
    Dim response As MsgBoxResult
    Dim nuevo As Integer

    Private Sub NuevoAñoEscolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        MiembroV.Focus()

        If Len(MiembroV.Text) > 0 Then
            validaMiembro()
        Else
            PrincipalPanel.Visible = True
        End If
    End Sub

    Private Sub actualizarEstado()
        Dim nEstado As String = ""
        If Len(EstadoCombo.Text) > 0 Then
            response = MsgBox("¿Esta seguro de cambiar el estado educativo? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                nEstado = "'" + EstadoCombo.SelectedValue + "'"

                ahora = DateTime.Now

                sql = "INSERT INTO  dbo.MemberEducationYear " + _
                        "SELECT Project, MemberId, SchoolYear, SchoolCode,  Grade, '" + ahora.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, " + _
                        "'" + U + "' UserId, ExpirationDateTime, ClassSection, PercentOfExpensesToPay,  ReasonNotToContinue, " + nEstado + " Status,  Career, SingleTeacher, " + _
                        "TransportationStartDate, TransportationEndDate, Notes, ExceptionPercent,  HasCertificate, NYSPackage, Typing " + _
                        "FROM  dbo.MemberEducationYear " + _
                        "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND SchoolYear = " + AñoV.Text + " AND Grade = '" + aGrado + "' " + _
                        "AND Status = '" + aEstado + "' AND SchoolCode = '" + aEscuela + "'"
                bdInsertar(sql)
                'inactiva el historial del record
                sql = "UPDATE dbo.MemberEducationYear SET RecordStatus = 'H', ExpirationDateTime = '" + ahora.ToString(en.DateTimeFormat) + " '  " + _
                      "WHERE  RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND schoolYear = " + AñoV.Text + "  " + _
                      "AND schoolCode = '" + aEscuela + "' AND grade = '" + aGrado + "' AND " + _
                      "Convert(nvarchar(30), CreationDateTime, 20) = '" + CreationDateL.Text + "' "
                bdEjecutarSQL(sql)
                ingresarObservacion("ESTA")
                ingresarActividad(EstadoCombo)
                nuevoAño()
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub comboCarrera()
        If Len(nGradoId.Text) = 0 Then
            nCarreraCombo.DataSource = Nothing
            nCarreraCombo.Text = ""
            nCarreraCombo.Visible = False
            nCarreraL.Visible = False
        Else
            proximoNivel()
            If nuevoN = "Diversificado" Or nuevoN = "Vocacional" Then
                'lista carreras
                sql = "SELECT Code, " + descripcion() + " AS carrera FROM dbo.CdEducationCareer WHERE  EducationLevel <> 'UNIV' ORDER BY DescSpanish"
                bdCombo(sql, nCarreraCombo, "Code", "carrera")

                If Len(aCarrera) > 0 Then
                    nCarreraCombo.SelectedValue = aCarrera
                End If

                nCarreraCombo.Visible = True
                nCarreraL.Visible = True
            ElseIf nuevoN = "Primaria" Then
                nSeccionL.Visible = True
                nSeccionV.Visible = True
            Else
                nCarreraCombo.DataSource = Nothing
                nCarreraCombo.Visible = False
                nCarreraL.Visible = False
            End If
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 And familiaEsValida(S, FamiliaV.Text) = True Then
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

        If nuevo = 1 Then 'guardar nuevo año escolar
            guardarNuevoAño()
        Else 'actualizar estado
            actualizarEstado()
        End If
    End Sub

    Private Sub guardarNuevoAño()
        GuardarButton.Visible = False
        Dim ingresar As Boolean
        Dim icarrera, iporcen, imaestro, iexpor, iexE As String
        icarrera = ""
        If Len(nAñoV.Text) > 0 And nEscuelaCombo.SelectedIndex >= 0 And nGradoCombo.SelectedIndex >= 0 And nEstadoCombo.SelectedIndex >= 0 Then
            If nCarreraCombo.Visible = True Then 'con carrera
                If nCarreraCombo.SelectedIndex >= 0 Then
                    ingresar = True
                    icarrera = "'" + nCarreraCombo.SelectedValue + "'"
                Else
                    ingresar = False
                    MsgBox("Necesita ingresar carrera", vbInformation, My.Resources.versionFamilias2)
                End If
            Else 'sin carrera
                ingresar = True
                icarrera = "NULL"
            End If
        Else
            ingresar = False
            MsgBox("Todos los campos con asterisco ""*"" son requisito", vbInformation, My.Resources.versionFamilias2)
        End If

        If ingresar = True Then
            If S = "F" Or S = "M" Then
                iporcen = "NULL"

                If Len(PorcentajeV.Text) > 0 Then
                    iexpor = PorcentajeV.Text
                Else
                    iexpor = "NULL"
                End If
            Else
                If Len(PorcentajeV.Text) > 0 Then
                    iporcen = PorcentajeV.Text
                Else
                    iporcen = "NULL"
                End If
                iexpor = "NULL"
            End If

            If nMaestroCombo.SelectedIndex >= 0 Then
                imaestro = "'" + nMaestroCombo.SelectedText + "'"
            Else
                imaestro = "NULL"
            End If

            If ExcepcionECombo.SelectedIndex >= 0 Then
                iexE = "'" + ExcepcionECombo.SelectedValue + "'"
            Else
                iexE = "NULL"
            End If

            ' Project, MemberId, SchoolYear, SchoolCode, Grade, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, ClassSection, 
            'PercentOfExpensesToPay, ReasonNotToContinue, Status, Career, SingleTeacher, TransportationStartDate, TransportationEndDate, Notes,
            'ExceptionPercent, HasCertificate, NYSPackage, Typing
            sql = "INSERT INTO dbo.MemberEducationYear VALUES('" + S + "', " + MiembroV.Text + ", " + nAñoV.Text + ", '" + nEscuelaCombo.SelectedValue + "', " + _
                     "'" + nGradoCombo.SelectedValue + "', GETDATE(), ' ', '" + U + "', NULL, '" + nSeccionV.Text + "', " + _
                     iporcen + ", " + iexE + ", '" + nEstadoCombo.SelectedValue + "', " + icarrera + ", " + imaestro + ", NULL, NULL, '" + nNotasV.Text + "', " + _
                     iexpor + ", 0, 0, 0)"
            bdInsertar(sql)
            HistorialEducCheck.Checked = False
            HistorialEducCheck.Checked = True
        End If
    End Sub

    Private Sub historialActividades()
        limpiarGrid()
        sql = "SELECT cdMAT.DescSpanish AS ACTIVIDAD, dbo.fn_GEN_FormatDate(MA.ActivityDateTime, 'ES') AS Fecha, MA.Notes AS Observaciones, MA.UserId AS Usuario " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdMAT ON MA.Type = cdMAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND cdMAT.FunctionalArea = 'EDUC' AND MA.Project = '" + S + "' AND YEAR(MA.ActivityDateTime) IN " + añosHistorial + " AND MA.MemberId = " + MiembroV.Text + _
              " ORDER BY MA.ActivityDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialActividadesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialActividadesCheck.CheckedChanged
        If HistorialActividadesCheck.Checked = True Then
            historialActividades()
            HistorialObserCheck.Checked = False
            HistorialEducCheck.Checked = False
        End If
    End Sub

    Private Sub historialEduc()
        limpiarGrid()
        sql = "SELECT MEY.SchoolYear Año, CdG.DescSpanish Grado, CdES.DescSpanish Estado, cdEE.DescSpanish ExcepcionEstado, S.Name Escuela, cdEC.DescSpanish Carrera, " + _
              "MEY.Notes Notas, MEY.UserId 'Usuario' " + _
              "FROM	MemberEducationYear MEY INNER JOIN School S On MEY.Project=S.Project and MEY.SchoolCode=S.Code AND MEY.RecordStatus = S.RecordStatus " + _
              "INNER JOIN CdGrade CdG On MEY.Grade=CdG.Code INNER JOIN CdEducationStatus CdES On MEY.Status=CdES.Code " + _
              "LEFT JOIN CdEducationCareer cdEC ON cdEC.Code = MEY.Career " + _
              "LEFT JOIN CdEducationReasonNotToContinue cdEE ON cdEE.Code = MEY.ReasonNotToContinue " + _
              "WHERE MEY.RecordStatus=' ' AND MEY.Project = '" + S + "' AND MEY.MemberId = " + MiembroV.Text + " " + _
              "GROUP BY MEY.SchoolYear, CdG.DescSpanish, CdG.Orden, CdEs.DescSpanish, cdEE.DescSpanish, S.Name, cdEC.DescSpanish, MEY.Notes, MEY.UserId, CONVERT(nvarchar(30), MEY.CreationDateTime, 21) " + _
              "ORDER BY MEY.SchoolYear DESC, CdG.Orden DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialEducCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialEducCheck.CheckedChanged
        If HistorialEducCheck.Checked = True Then
            historialEduc()
            HistorialObserCheck.Checked = False
            HistorialActividadesCheck.Checked = False
        End If
    End Sub

    Private Sub historialObservaciones()
        limpiarGrid()
        sql = "SELECT cdC.DescSpanish AS Categoría, dbo.fn_GEN_FormatDate(MEO.ObservationDateTime, 'ES')  + ' ' + CONVERT(varchar, MEO.ObservationDateTime, 108)  AS Fecha, " + _
                 "MEO.Observation AS Observación,  MEO.UserId AS Usuario " + _
              "FROM  dbo.MemberEducationObservation MEO INNER JOIN dbo.CdMemberEducObservationCategory cdC ON MEO.Category = cdC.Code " + _
              "WHERE MEO.RecordStatus = ' ' AND MEO.Project = '" + S + "' AND YEAR(MEO.ObservationDateTime) IN " + añosHistorial + " AND MEO.MemberId = " + MiembroV.Text + _
              " ORDER BY MEO.ObservationDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialObserCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialObserCheck.CheckedChanged
        If HistorialObserCheck.Checked = True Then
            historialObservaciones()
            HistorialActividadesCheck.Checked = False
            HistorialEducCheck.Checked = False
        End If
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable
        Dim secc As String = ""

        sql = "SELECT * " + _
                 "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + AñoV.Text + ") L "
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            'Info General
            NombreV.Text = listTable.Rows(f)("Nombres") + " " + listTable.Rows(f)("Apellidos")
            'EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad"))
            FamiliaV.Text = listTable.Rows(f)("Familia")
            FamiliaV.ReadOnly = True
            ClasificacionV.Text = chequearValor(listTable.Rows(0)("Clasificación"))

            If esApadrinado(S, MiembroV.Text) = True Then
                ' Info Educ
                GradoV.Text = chequearValor(listTable.Rows(0)("Grado"))
                EstadoV.Text = chequearValor(listTable.Rows(0)("Estado_Educ"))
                EscuelaV.Text = chequearValor(listTable.Rows(0)("Escuela"))

                aGrado = chequearValor(listTable.Rows(0)("GradoId"))
                aEstado = chequearValor(listTable.Rows(0)("EstadoId"))
                aCarrera = chequearValor(listTable.Rows(0)("CarreraId"))
                aEscuela = chequearValor(listTable.Rows(0)("EscuelaId"))
                aNivel = chequearValor(listTable.Rows(0)("Nivel_Educ"))
            End If
        Next

        MiembroV.Enabled = False
        PanelSecundario.Visible = True
    End Sub

    Private Sub ingresarActividad(ByRef estado As ComboBox)
        If estado.SelectedValue = "GANO" Or estado.SelectedValue = "GANC" Or estado.SelectedValue = "PERD" Or estado.SelectedValue = "PERS" Then
            Dim actividad As String = ""
            actividad = "'EGAN'"

            If estado.SelectedValue = "GANO" Or estado.SelectedValue = "GANC" Then
                actividad = "'EGAN'"
            ElseIf estado.SelectedValue = "PERD" Or estado.SelectedValue = "PERS" Then
                actividad = "'EPER'"
            End If

            If Len(actividad) > 0 Then
                sql = "INSERT INTO MemberActivity VALUES ('" + S + "', " + MiembroV.Text + ", " + actividad + ", '" + ahora.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, '')"
                bdInsertar(sql)
                MsgBox("Se ha ingresado una actividad automática de ""gano o perdió grado""", vbInformation, My.Resources.versionFamilias2)
            End If
        End If
    End Sub

    Private Sub ingresarObservacion(ByVal idCategoria As String)
        Dim n As Integer
        sql = "SELECT MAX(IdObservation) 'Ultimo' FROM MemberEducationObservation "
        n = bdEntero(sql, "Ultimo") + 1

        sql = "INSERT INTO MemberEducationObservation VALUES (" + n.ToString + ", GETDATE(), '" + S + "', " + MiembroV.Text + ", '" + idCategoria + "', GETDATE(), '', ' ', '" + U + "', NULL)"
        bdInsertar(sql)
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
            nxt.transac = "IIAE"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbInformation, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarGrid()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
    End Sub

    Private Sub llenarCampos()
        If nEstadoCombo.Text = "System.Data.DataRowView" Then
        Else
            If Len(aEstado) > 0 Then
                If aEstado = "GANO" Or aEstado = "GANC" Then
                    'proximo estado
                    nEstadoCombo.SelectedValue = "ESTU"

                    'proximo grado
                    sql = "SELECT CASE WHEN NextGrade IS NULL THEN '' ELSE NextGrade END Prox FROM CdGrade WHERE Code ='" + aGrado + "' "
                    proxGrad = bdPalabra(sql, "Prox")
                    nGradoCombo.SelectedValue = proxGrad

                    'próxima escuela
                    proximoNivel()
                    If aNivel = nuevoN Then
                        nEscuelaCombo.Text = EscuelaV.Text
                    Else
                        nEscuelaCombo.Text = ""
                    End If
                ElseIf aEstado = "PERD" Or aEstado = "PERS" Or aEstado = "NOSI" Or aEstado = "NOSR" Then
                    'proximo estado
                    nEstadoCombo.SelectedValue = "REPI"

                    'proximo grado
                    nGradoCombo.SelectedValue = aGrado

                    'próxima escuela
                    nEscuelaCombo.Text = EscuelaV.Text
                Else ' no tiene info anterior
                    nGradoCombo.Text = ""
                    nEscuelaCombo.Text = ""
                End If
            Else
                nEstadoCombo.Text = ""
            End If
        End If
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

    Private Sub nGradoCombo_TextChanged(sender As Object, e As EventArgs) Handles nGradoCombo.TextChanged
        If Len(nGradoCombo.Text) = 0 Or nGradoCombo.Text = "System.Data.DataRowView" Then
        Else
            nGradoId.Text = nGradoCombo.SelectedValue
            comboCarrera()
        End If
    End Sub

    Private Sub nuevoAño()
        infoGen()

        sql = "SELECT COUNT(*) Total " + _
                 "FROM MemberEducationYear MEY INNER JOIN CdEducationStatus cdES ON cdES.Code = MEY.Status " + _
                 "WHERE MEY.MemberId = " + MiembroV.Text + " AND MEY.Project = '" + S + "' AND MEY.Recordstatus = ' ' AND MEY.Schoolyear IN (" + actualAñoE.ToString + ", " + nuevoAñoE.ToString + ") AND cdES.InsertValue = 1 "

        If bdEntero(sql, "Total") > 0 Then 'con año escolar activo
            nuevo = 0
            MsgBox("Por favor verifique y cambie el estado del ultimo año escolar, a ganó, perdió, no siguió, segun corresponda", vbQuestion, My.Resources.versionFamilias2)

            'estado actual
            sql = "SELECT Code, " + descripcion() + " Estado  FROM CdEducationStatus  WHERE ValidValue = 1 AND InsertValue = 0 AND Code NOT IN ('NOSI', 'NOSR')"
            bdCombo(sql, EstadoCombo, "Code", "Estado")
            GuardarButton.Visible = True
            EstadoCombo.Enabled = True
            EstadoCombo.Visible = True
            EstadoL.TextAlign = ContentAlignment.MiddleLeft
            EstadoCombo.Focus()
        Else 'nuevo año escolar
            nuevo = 1
            EstadoL.TextAlign = ContentAlignment.TopLeft
            EstadoCombo.Enabled = False
            EstadoCombo.Visible = False

            'grados
            Dim nNivel As String = ""
            sql = "SELECT Code, " + descripcion() + " 'Grado' FROM dbo.CdGrade WHERE ValidValue = 1 ORDER BY Orden"
            bdCombo(sql, nGradoCombo, "Code", "Grado")

            ''estados educativos
            sql = "SELECT Code, " + descripcion() + " Estado  FROM CdEducationStatus  WHERE ValidValue = 1 AND InsertValue = 1 "
            bdCombo(sql, nEstadoCombo, "Code", "Estado")
            nEstadoCombo.Focus()

            ''lista excepciones de estados educativos
            sql = "SELECT Code, " + descripcion() + " Excep  FROM CdEducationReasonNotToContinue  WHERE Active = 1 "
            bdCombo(sql, ExcepcionECombo, "Code", "Excep")

            ''escuelas
            sql = "SELECT Code, Name AS Escuela FROM dbo.School WHERE RecordStatus = ' ' AND Project = '" + S + "' AND Active = 1  ORDER BY Name"
            bdCombo(sql, nEscuelaCombo, "Code", "Escuela")

            'Maestros
            sql = "SELECT EmployeeId FROM dbo.FwEmployeeRole " + _
                    "WHERE Role = 'MSTR' AND Status = 'ACTV' AND Organization = '" + S + "'"
            bdComboSinCodigo(sql, nMaestroCombo)
            llenarCampos()
            nAñoPanel.Focus()
            nAñoV.Focus()
            nAñoPanel.Visible = True
        End If

        HistorialEducCheck.Checked = True
        historialEduc()
        GuardarButton.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New NuevoAñoEscolar
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub proximoNivel()
        If Len(nGradoId.Text) > 1 Then
            sql = "SELECT L.DescSpanish Nivel FROM CdGrade G INNER JOIN CdEducationLevel L ON G.EducationLevel = L.Code WHERE G.Code = '" + nGradoId.Text + "' "
            nuevoN = bdPalabra(sql, "Nivel")
        End If
    End Sub

    Private Sub validaMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            If esApadrinado(S, MiembroV.Text) = True Then
                valoresIniciales()
            Else
                MsgBox("Esta pantalla es solo para apadrinados", vbQuestion, My.Resources.versionFamilias2)
                MiembroV.Text = ""
                FamiliaV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        'años escolares
        sql = "SELECT CASE WHEN MAX(SchoolYear) IS NULL THEN 0 ELSE MAX(SchoolYear) END  Ultimo FROM dbo.MemberEducationYear WHERE  RecordStatus = ' ' and Project = '" + S + "' AND Memberid = " + MiembroV.Text
        actualAñoE = bdEntero(sql, "Ultimo")

        If actualAñoE = 0 Then
            If DateTime.Now.Month >= 10 Then
                actualAñoE = DateTime.Now.Year
            Else
                actualAñoE = DateTime.Now.Year - 1
            End If
        End If

        If DateTime.Now.Month >= 10 Then
            nuevoAñoE = DateTime.Now.Year + 1
        Else
            nuevoAñoE = DateTime.Now.Year
        End If

        AñoV.Text = actualAñoE.ToString
        nAñoV.Text = nuevoAñoE.ToString

        añosHistorial = "(" + AñoV.Text + ", " + nAñoV.Text + ") "

        'Información para nuevo año escolar
        nuevoAño()

        '% para pagos
        If S = "F" Or S = "M" Then
            PorcentajeL.Text = "Excepción en %:"
        Else
            PorcentajeL.Text = "%:"
        End If

        HistorialTable.Visible = True
    End Sub

End Class

