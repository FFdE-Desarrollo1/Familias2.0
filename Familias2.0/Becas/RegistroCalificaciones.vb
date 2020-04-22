Public Class RegistroCalificaciones
    Dim año As Integer = Today.Year
    Dim ref As String = ""
    Dim correlativo As Integer = 1
    Dim aux As Integer = 0
    Dim nivel As String = ""
    Dim semaforo As String = ""
    Dim codClase, catClase As String
    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
    Dim response As MsgBoxResult
    Dim modificar As String = "No"

    Private Sub RegistroCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    'Private Sub actualizarSemaforo()
    '    sql = "SELECT LEFT(dbo.fn_EDUC_semaforoEsp('" + SitioCombo.Text + "'," + ApadrinadoV.Text + "," + año.ToString + ",'" + UnidadCombo.SelectedValue + "'),4) Color "
    '    'InputBox("", "", sql)
    '    Dim semaforo As String = bdPalabra(sql, "Color")
    '    Dim razon As String = "'PERD'"

    '    If semaforo.ToUpper = "VERD" Then
    '        razon = "'GANO'"
    '    End If

    '    '"SELECT     Project, MemberId, EducSemaphore, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, StartDate, EndDate"
    '    sql = "UPDATE MemberEducationSemaphore SET EndDate = GETDATE() " + _
    '          "WHERE RecordStatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + ApadrinadoV.Text + " AND EndDate IS NULL"
    '    'InputBox("", "", sql)
    '    bdEjecutarSQL(sql)

    '    sql = "INSERT INTO MemberEducationSemaphore VALUES ('" + SitioCombo.Text + "'," + ApadrinadoV.Text + ", '" + semaforo.ToUpper + "', " + _
    '          "GETDATE(), ' ', '" + U + "',NULL,GETDATE(),NULL,'" + UnidadCombo.SelectedValue + "'," + razon + ") "
    '    'InputBox("", "", sql)
    '    bdInsertar(sql)

    'End Sub

    Private Sub AgregarClaseCombo()
        Dim nxt As New AgregarClaseCombo
        nxt.ClaseEspV.Text = ClaseCombo.Text
        nxt.Show()
        ClaseListadoL.Text = "Actualizar"
    End Sub

    Private Sub ApadrinadoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApadrinadoV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If esApadrinado(SitioCombo.Text, ApadrinadoV.Text) = True Then
                infoGen()
            Else
                MsgBox("Esta función es solo para apadrinados", vbExclamation, My.Resources.versionFamilias2)
            End If
        End If

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

    Private Sub bloquearCampos()
        UnidadCombo.Enabled = False
        FuenteCombo.Enabled = False
        todasCheck.Enabled = False
        PromedioV.Enabled = False
        PerdidasV.Enabled = False
        ObservacionesV.Enabled = False
        TotalClasesV.Enabled = False
    End Sub

    Private Sub borrarClasePerdida(ByVal ref As String, ByVal corr As String)
        sql = "UPDATE dbo.MemberEducationClassFailed SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
              "WHERE RecordStatus = ' '  AND Ref = '" + ref + "' AND Correlative = " + corr + " "
        bdEjecutarSQL(sql)
        listadoClasesPerdidas(ref)
        listadoCalificaciones()
    End Sub

    Private Sub borrarRegistro(ByVal sitio As String, ByVal apadrinado As String, ByVal unidad As String, ByVal refe As String)
        'borrar Calificaciones
        sql = "UPDATE MemberEducationClassGrade SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
              "WHERE RecordStatus = ' ' AND Project = '" + sitio + "' AND MemberId = " + apadrinado + " AND SchoolYear = " + año.ToString + " AND Unit = '" + unidad + "' "
        bdEjecutarSQL(sql)

        'borrar clases ingresadas
        If bdEntero("SELECT COUNT(*) T FROM MemberEducationClassFailed WHERE RecordStatus = ' ' AND Ref = '" + refe + "' ", "T") > 0 Then
            sql = "UPDATE MemberEducationClassFailed SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
                 "WHERE RecordStatus = ' ' AND Ref = '" + refe + "' "
            bdEjecutarSQL(sql)
        End If

        'borrar semaforo
        sql = "UPDATE MemberEducationSemaphore SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
              "WHERE RecordStatus = ' ' AND Project = '" + sitio + "' AND MemberId = " + apadrinado + " AND YEAR(StartDate) = " + año.ToString + " AND Unit = '" + unidad + "' "
        bdEjecutarSQL(sql)

        listadoCalificaciones()
    End Sub

    Private Sub CalificacionesLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CalificacionesLink.LinkClicked
        listadoCalificaciones()
    End Sub

    Private Sub ClasesGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClasesGrid.CellContentClick
        Dim filaSel = ClasesGrid.CurrentCellAddress.Y

        If ClasesGrid.CurrentCellAddress.X = 4 Then
            response = MsgBox("¿Está seguro de borrar la clase?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                borrarClasePerdida(ClasesGrid.Item(0, filaSel).Value(), ClasesGrid.Item(1, filaSel).Value())
            End If
        End If
    End Sub

    Private Sub ClaseListadoL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ClaseListadoL.LinkClicked
        If ClaseListadoL.Text = "Actualizar" Then
            comboClases()
            ClaseListadoL.Text = "Agregar Clase" + vbLf + "al Listado"
        Else
            AgregarClaseCombo()
        End If
    End Sub

    Private Sub comboClases()
        sql = "SELECT Code, DescSpanish FROM dbo.CdClassSubjectFailed WHERE Active = 1 ORDER BY DescSpanish "
        bdCombo(sql, ClaseCombo, "Code", "DescSpanish")
    End Sub

    Private Sub guardar()
        GuardarButton.Visible = False
        Dim todas, promedio As String
        If todasCheck.Checked = True Then
            todas = "1"
            nuevaClaseLink.Visible = False
        Else
            todas = "0"
            nuevaClaseLink.Visible = True
        End If

        If Len(PromedioV.Text) = 0 Then
            promedio = "NULL"
        Else
            promedio = PromedioV.Text
        End If

        ref = SitioCombo.Text + ApadrinadoV.Text + "-" + año.ToString + "-" + UnidadCombo.SelectedValue
        sql = "INSERT INTO dbo.MemberEducationClassGrade (Project, MemberId, SchoolYear, Unit, CreationDateTime, RecordStatus, " + _
              "UserId, ExpirationDateTime, Source, TotalClasses, ApprovedAll, Average80, FailedClasses, Ref, Notes) " + _
              "VALUES ('" + SitioCombo.Text + "', " + ApadrinadoV.Text + "," + año.ToString + ",'" + UnidadCombo.SelectedValue + "', GETDATE(), ' '," + _
              "'" + U + "',NULL,'" + FuenteCombo.SelectedValue + "'," + TotalClasesV.Text + ", " + todas + "," + promedio + "," + PerdidasV.Text + _
              ",'" + ref + "','" + ObservacionesV.Text + "')"
        'InputBox("", "", sql)
        bdInsertar(sql)
        guardarClase()
        'actualizarSemaforo()
        bloquearCampos()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If validarRegistroUnidad() = True Then
            guardar()
            listadoCalificaciones()
        Else
        End If
    End Sub

    Private Sub guardarClase()
        If todasCheck.Checked = False Then
            If ClaseCombo.SelectedIndex < -1 Or Len(ClaseCombo.Text) = 0 Or Len(ClaseCombo.SelectedValue) = 0 Then
                MsgBox("No ha seleccionado una clase para ingresar", vbExclamation, My.Resources.versionFamilias2)
            Else
                sql = "SELECT COUNT(*) T " + _
                      "FROM dbo.MemberEducationClassFailed MECL " + _
                      "WHERE MECL.RecordStatus = ' ' AND MECL.Ref = '" + ref.ToString + "' "
                Dim nRegistradas As Integer = bdEntero(sql, "T")

                If nRegistradas < Integer.Parse(PerdidasV.Text) Then
                    insertClase()
                Else
                    response = MsgBox("Está seguro de agregar más clases de las que indicó en ""Cantidad pérdidas""", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        insertClase()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub HistorialGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        Dim f, c As Integer
        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y

        If c = 8 Then
            If HistorialGrid.Item(7, f).Value() = 0 Then
                MsgBox("No tiene clases registradas", vbExclamation, My.Resources.versionFamilias2)
            Else
                listadoClasesPerdidas(HistorialGrid.Item(0, f).Value())
            End If
        ElseIf c = 11 Then
            response = MsgBox("¿Está seguro de borrar la unidad " + HistorialGrid.Item(2, f).Value() + "?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                borrarRegistro(SitioCombo.Text, ApadrinadoV.Text, HistorialGrid.Item(2, f).Value(), HistorialGrid.Item(0, f).Value())
            End If
        End If

    End Sub

    Private Sub HistorialGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialGrid.CellContentDoubleClick
        Dim f, c As Integer
        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y

        If c = 2 Then
            response = MsgBox("¿Está seguro de modificar la unidad " + HistorialGrid.Item(2, f).Value() + "?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                modificar = "Si"
                ref = HistorialGrid.Item(0, f).Value()
                UnidadCombo.Text = HistorialGrid.Item(2, f).Value()
                FuenteCombo.Text = HistorialGrid.Item(3, f).Value()
                TotalClasesV.Text = HistorialGrid.Item(4, f).Value()
                If HistorialGrid.Item(5, f).Value() = "SI" Then
                    todasCheck.Checked = True
                Else
                    todasCheck.Checked = False
                End If
                PromedioV.Text = chequearValor(HistorialGrid.Item(6, f).Value())
                PerdidasV.Text = chequearValor(HistorialGrid.Item(7, f).Value())
                ObservacionesV.Text = chequearValor(HistorialGrid.Item(9, f).Value())
                UnidadCombo.Enabled = False
                FuenteCombo.Enabled = True
                TotalClasesV.Enabled = True
                todasCheck.Enabled = False
                PromedioV.Enabled = True
                PerdidasV.Enabled = False
                ObservacionesV.Enabled = True
            Else
                modificar = "No"
            End If
        End If




    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable

        sql = "SELECT * " + _
              "FROM dbo.fn_GEN_InfoGenMiembro('" + SitioCombo.Text + "', " + ApadrinadoV.Text + ", " + año.ToString + ") L "
        bdDataTable(sql, listTable)

        For f = 0 To listTable.Rows.Count - 1
            Dim seccion, carrera As String
            ApadrinadoV.ReadOnly = True
            SitioCombo.Enabled = False
            NombreL.Text = listTable.Rows(f)("Nombres") + " " + listTable.Rows(f)("Apellidos") + " - " + chequearValor(listTable.Rows(f)("Edad"))
            FamiliaV.Text = listTable.Rows(f)("Familia")
            FamiliaV.ReadOnly = True

            'info educacional
            If Len(chequearValor(listTable.Rows(0)("Grado"))) > 0 Then
                If Len(chequearValor(listTable.Rows(0)("Sección"))) = 0 Then
                    seccion = ""
                Else
                    seccion = " sección " + chequearValor(listTable.Rows(0)("Sección")) + " "
                End If

                If Len(chequearValor(listTable.Rows(0)("Carrera"))) = 0 Then
                    carrera = ""
                Else
                    carrera = " - " + chequearValor(listTable.Rows(0)("Carrera")) + " - "
                End If

                GradoL.Text = chequearValor(listTable.Rows(0)("Estado_Educ")) + " " + _
                              chequearValor(listTable.Rows(0)("Grado")) + seccion + _
                              carrera + " " + chequearValor(listTable.Rows(0)("Escuela")) + " (" + año.ToString + ")"
                nivel = chequearValor(listTable.Rows(0)("Nivel_Educ"))
                Table1.BackColor = Color.Ivory
                UnidadCombo.Focus()

                sql = "SELECT Code, DescSpanish FROM dbo.CdSchoolGradeUnit "
                bdCombo(sql, UnidadCombo, "Code", "DescSpanish")
                ultimaUnidad()

                sql = "SELECT Code, DescSpanish FROM dbo.CdSchoolGradeSource WHERE Active = 1 ORDER BY DescSpanish "
                bdCombo(sql, FuenteCombo, "Code", "DescSpanish")
                If S = "N" Then
                    FuenteCombo.SelectedValue = "PADR"
                Else
                    FuenteCombo.SelectedValue = "ESCU"
                End If


                comboClases()
                listadoCalificaciones()

                GuardarButton.Visible = True
                Table2.Visible = True
                Table3.Visible = True
            Else
                GradoL.Text = "No tiene registro escolar actual"
            End If

            NombreL.Visible = True
            GradoL.Visible = True
        Next
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub insertClase()
        sql = "SELECT COUNT(*) T " + _
              "FROM dbo.MemberEducationClassFailed MECL " + _
              "WHERE MECL.RecordStatus = ' ' AND MECL.Ref = '" + ref.ToString + "' AND Class = " + ClaseCombo.SelectedValue.ToString + " "
        Dim mismaClase As Integer = bdEntero(sql, "T")
        If mismaClase > 0 Then
            MsgBox("Esta clase ya fue ingresada", vbExclamation, My.Resources.versionFamilias2)
        Else
            sql = "INSERT INTO dbo.MemberEducationClassFailed (Ref, Correlative, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Class, Notes) " + _
                  "VALUES ('" + ref + "'," + correlativo.ToString + ",GETDATE(),'','" + U + "',NULL,'" + ClaseCombo.SelectedValue.ToString + "','')"
            'InputBox("", "", sql)
            bdInsertar(sql)
            listadoClasesPerdidas(ref)
            listadoCalificaciones()
            correlativo = correlativo + 1
        End If
    End Sub

    Private Sub listadoCalificaciones()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        sql = "SELECT  MECG.Ref, dbo.fn_EDUC_semaforoEsp('" + SitioCombo.Text + "', " + ApadrinadoV.Text + ", " + año.ToString + ", MECG.Unit) AS Semáforo, " + _
              "MECG.Unit AS Unidad, cdS.DescSpanish AS Fuente, MECG.TotalClasses 'Total Clases', " + _
              "CASE WHEN MECG.ApprovedAll = 1 THEN 'SI' ELSE 'NO' END AS 'Ganó todas', MECG.Average80 AS 'Promedio >80%', " + _
              "MECG.FailedClasses AS 'Pérdidas',  " + _
              " (SELECT COUNT(*) FROM MemberEducationClassFailed AS MECF WHERE RecordStatus = ' ' AND Ref = MECG.Ref) AS Registradas, MECG.Notes Notas, " + _
              "MECG.UserId Usuario, 'Borrar' '-' " + _
              "FROM dbo.MemberEducationClassGrade AS MECG " + _
              "INNER JOIN dbo.CdSchoolGradeSource AS cdS ON MECG.Source = cdS.Code " + _
              "WHERE MECG.RecordStatus = ' ' AND MECG.Project = '" + SitioCombo.Text + "' AND MECG.MemberId = " + ApadrinadoV.Text + " AND MECG.SchoolYear = " + año.ToString + " " + _
              "ORDER BY MECG.Unit "
        'InputBox("", "", sql)
        bdGrid(sql, HistorialGrid)
        For f = 0 To HistorialGrid.Rows.Count - 1
            If HistorialGrid.Item(1, f).Value = "Rojo" Then
                HistorialGrid.Item(1, f).Style.BackColor = Color.Red
            ElseIf HistorialGrid.Item(1, f).Value = "Amarillo" Then
                HistorialGrid.Item(1, f).Style.BackColor = Color.Yellow
            Else
                HistorialGrid.Item(1, f).Style.BackColor = Color.LawnGreen
            End If
            'HistorialGrid.Item(2, f).
        Next

        agregarColumnaAccion(11, HistorialGrid)
        HistorialGrid.Columns(0).Visible = False
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        'HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub listadoClasesPerdidas(ByVal refId As String)
        ClasesGrid.DataSource = Nothing
        ClasesGrid.Rows.Clear()
        ClasesGrid.Visible = False
        sql = "SELECT     MECL.Ref, MECL.Correlative '#', cdC.DescSpanish AS Clase, cdT.DescSpanish Tipo, 'Eliminar' 'Acción' " + _
              "FROM dbo.MemberEducationClassFailed AS MECL INNER JOIN dbo.CdClassSubjectFailed AS cdC ON MECL.Class = cdC.Code " + _
              "INNER JOIN CdClassSubjectFailedType cdT ON cdT.Code = cdC.Type " + _
              "WHERE MECL.RecordStatus = ' ' AND MECL.Ref = '" + refId + "' ORDER BY MECL.Correlative"
        bdGrid(sql, ClasesGrid)

        agregarColumnaAccion(4, ClasesGrid)
        ClasesGrid.Columns(0).Visible = False 'ref
        ClasesGrid.Columns(1).Visible = False 'correlativo
        'ClasesGrid.Columns(4).Visible = False 'para borrar
        ClasesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ClasesGrid.AutoResizeColumns()

        ListadoClasesPL.Text = "Listado Clases Pérdidas (" + ClasesGrid.RowCount.ToString + ")"
        ClasesGrid.Visible = True
        ListadoClasesPL.Visible = True
    End Sub

    Private Sub nuevaClaseLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles nuevaClaseLink.LinkClicked
        If ClaseCombo.SelectedIndex < -1 Then
        Else
            guardarClase()
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New RegistroCalificaciones
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PerdidasV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PromedioV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PromedioV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub todasCheck_CheckedChanged(sender As Object, e As EventArgs) Handles todasCheck.CheckedChanged
        If todasCheck.Checked = True Then
            datosTable3.Visible = False
            nuevaClaseLink.Visible = False
            ClaseListadoL.Visible = False
        Else
            datosTable3.Visible = True
        End If

    End Sub

    Private Sub TotalClasesV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TotalClasesV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ultimaUnidad()
        sql = "SELECT COUNT(*) T FROM dbo.MemberEducationClassGrade AS MECG INNER JOIN dbo.CdSchoolGradeUnit AS cdU ON MECG.Unit = cdU.Code " + _
              "WHERE MECG.RecordStatus = ' ' AND MECG.Project = '" + SitioCombo.Text + "' AND MECG.MemberId = " + ApadrinadoV.Text + " AND MECG.SchoolYear = " + año.ToString + " "
        If bdEntero(sql, "T") = 0 Then
        Else
            sql = "SELECT cdU.Next Prox, MECG.TotalClasses T FROM dbo.MemberEducationClassGrade AS MECG " + _
                  "INNER JOIN dbo.CdSchoolGradeUnit AS cdU ON MECG.Unit = cdU.Code " + _
                  "WHERE MECG.RecordStatus = ' ' AND MECG.Project = '" + SitioCombo.Text + "' AND MECG.MemberId = " + ApadrinadoV.Text + " AND MECG.SchoolYear = " + año.ToString + " " + _
                  "ORDER BY MECG.Unit DESC "
            'InputBox("", "", sql)
            Dim ul As String = bdPalabra(sql, "Prox")
            If ul = "0" Then
            Else
                UnidadCombo.SelectedValue = ul
            End If

            TotalClasesV.Text = bdPalabra(sql, "T")
        End If
    End Sub

    Private Function validarRegistroUnidad() As Boolean
        Dim uni, fuent, nClas, nPer, prom As Integer
        sql = "SELECT COUNT(*) T FROM MemberEducationClassGrade " + _
              "WHERE RecordStatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + ApadrinadoV.Text + " AND SchoolYear = " + año.ToString + " AND Unit = '" + UnidadCombo.SelectedValue + "' "
        Dim unidadReg As Integer = bdEntero(sql, "T")
        'InputBox("", "", sql)

        If (UnidadCombo.SelectedIndex < -1 Or Len(UnidadCombo.Text) = 0 Or unidadReg > 0) And modificar = "No" Then
            uni = 0
            MsgBox("Verifique la Unidad:" + vbLf + vbLf + "-La unidad ya tiene registro", vbCritical, My.Resources.versionFamilias2)
        Else
            uni = 1
        End If

        If FuenteCombo.SelectedIndex < -1 Or Len(FuenteCombo.Text) = 0 Then
            fuent = 0
            MsgBox("Necesita seleccionar la fuente", vbCritical, My.Resources.versionFamilias2)
        Else
            fuent = 1
        End If

        If Len(TotalClasesV.Text) = 0 Then
            nClas = 0
            MsgBox("Necesita ingresar el total de clases", vbCritical, My.Resources.versionFamilias2)
        Else
            nClas = 1
        End If

        If todasCheck.Checked = True Then
            If Len(PromedioV.Text) > 0 Then
                If Integer.Parse(PromedioV.Text) > 80 And Integer.Parse(PromedioV.Text) <= 100 Then
                    prom = 1
                Else
                    prom = 0
                    MsgBox("El promedio ingresado no es válido", vbCritical, My.Resources.versionFamilias2)
                End If
            Else
                prom = 1
            End If
            nPer = 1 'clases pérdidas correcto
        Else
            If Integer.Parse(TotalClasesV.Text) >= Integer.Parse(PerdidasV.Text) Then
                nPer = 1
            Else
                nPer = 0
                MsgBox("El total de clases perdidas no puede ser mayor al total de clases", vbCritical, My.Resources.versionFamilias2)
            End If

            prom = 1 'promedio correcto
        End If

        If uni + fuent + nClas + nPer + prom = 5 Then
            validarRegistroUnidad = True
        Else
            validarRegistroUnidad = False
        End If
    End Function

    Private Sub valoresIniciales()
        ApadrinadoV.Focus()

        If S = "F" Then
            ClaseListadoL.Visible = True

            sql = "SELECT Code FROM FwCdOrganization WHERE Code NOT IN ('A', 'E', '*', 'S')"
            bdComboSinCodigo(sql, SitioCombo)
            SitioCombo.Enabled = True
        End If

        SitioCombo.SelectedText = S
    End Sub


   
End Class

'Private Sub listaNumericas()
'    Try
'        Dim numericas As New DataGridViewComboBoxColumn()
'        Dim datos As New DataTable

'        sql = "SELECT Code, DescSpanish Descripcion FROM dbo.CdClassSubjectList WHERE Active = 1 "
'        bdDataTable(sql, datos)

'        numericas.DataSource = datos
'        numericas.ValueMember = "Code"
'        numericas.DisplayMember = "Descripcion"
'        PerdidasListGrid.Columns().Add(numericas)
'    Catch ex As Exception
'        MsgBox(Err.Description)
'    End Try
'End Sub