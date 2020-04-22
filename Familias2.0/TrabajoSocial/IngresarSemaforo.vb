' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0
' @code ASEM

Public Class IngresarSemaforo
    Dim ahora As DateTime = Date.Now
    'Dim trans As String

    Private Sub IngresarSemaforo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()

        If Len(NoMiembro) > 0 Then
            MiembroV.Text = NoMiembro

        End If

        If Len(MiembroV.Text) > 0 Then
            validaMiembro()
        Else
            PrincipalPanel.Visible = True
        End If
        MiembroV.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub finalizarSemaforo(ByVal idSemaforo As String)
        ahora = Date.Now
        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        Dim response As MsgBoxResult
        response = MsgBox("¿Esta seguro de finalizar el semáforo?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "INSERT INTO dbo.MemberEducationSemaphore " + _
                  "SELECT Project, MemberId, EducSemaphore, '" + ahora.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, '" + U + "' UserId, " + _
                  "ExpirationDateTime, StartDate, '" + ahora.ToString(en.DateTimeFormat) + "' EndDate " + _
                  "FROM dbo.MemberEducationSemaphore " + _
                  "WHERE Project + CONVERT(varchar, MemberId) + EducSemaphore + CONVERT(varchar, CreationDateTime, 20) = '" + idSemaforo + "'"
            bdInsertar(sql)
            Listado()
        End If
    End Sub

    Private Sub genInfo()
        Dim ahora As DateTime = DateTime.Now
        Dim listTable As New DataTable
        sql = "SELECT Nombres, Apellidos, Edad, EstadoAfil, Fase, semaforo, Estado_Educ, Grado, Año, Familia, clasificación, TS,  Region, dbo.fn_GEN_tipoMiembro('" + S + "', " + MiembroV.Text + ") TipoMiembro " + _
              "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + ahora.Year.ToString + ") L "
        bdDataTable(sql, listTable)

        If listTable.Rows.Count > 0 Then
            NombreV.Text = chequearValor(listTable.Rows(0)("Nombres")) + " " + chequearValor(listTable.Rows(0)("Apellidos"))
            EdadV.Text = " - " + chequearValor(listTable.Rows(0)("Edad"))
            FamiliaV.Text = chequearValor(listTable.Rows(0)("Familia"))
            ClasificacionV.Text = chequearValor(listTable.Rows(0)("clasificación"))
            TSV.Text = chequearValor(listTable.Rows(0)("TS"))
            RegionV.Text = chequearValor(listTable.Rows(0)("Region"))
            TipoMiembroL.Text = chequearValor(listTable.Rows(0)("TipoMiembro"))
            FaseV.Text = chequearValor(listTable.Rows(0)("Fase"))
            Dim color As String = chequearValor(listTable.Rows(0)("semaforo"))

            NoFamilia = FamiliaV.Text

            If Len(color) > 0 Then
                semaforo(color, semaforoV)
                semaforoL.Text = "Semáforo:"
                semaforoL.Visible = True
            End If

            If Len(chequearValor(listTable.Rows(0)("Grado"))) > 0 Then
                GradoV.Text = chequearValor(listTable.Rows(0)("Estado_Educ")) + " " + chequearValor(listTable.Rows(0)("Grado")) + " (" + chequearValor(listTable.Rows(0)("Año")) + ")"
                GradoV.Visible = True
                GradoL.Visible = True
            End If

            MiembroV.ReadOnly = True
            FamiliaV.ReadOnly = True
            infoGenTable.Visible = True
            Listado()
            FamiliaV.Focus()
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        GuardarButton.Visible = False
        ahora = Date.Now
        sql = "INSERT INTO dbo.MemberEducationSemaphore VALUES(" + _
              "'" + S + "', " + MiembroV.Text + ", '" + SemaforoCombo.SelectedValue.ToString + "', '" + _
              ahora.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, '" + ahora.ToString(en.DateTimeFormat) + "', NULL) "
        bdInsertar(sql)
        Listado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub Listado()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        'dbo.fn_GEN_FormatDate(MES.StartDate, 'es')
        sql = "SELECT MES.Project + CONVERT(varchar, MES.MemberId) + MES.EducSemaphore + CONVERT(varchar, MES.CreationDateTime, 20) AS ID, " + _
              "CASE WHEN MES.EndDate IS NULL THEN 'Finalizar' ELSE '' END  ' ', 'Borrar' '  ', " + _
              "cdES.DescSpanish AS Semáforo, MES.StartDate AS Inicio, MES.EndDate AS Fin " + _
              "FROM dbo.MemberEducationSemaphore MES INNER JOIN dbo.CdEducationSemaphore cdES ON MES.EducSemaphore = cdES.Code " + _
              "WHERE MES.RecordStatus = ' ' AND MES.Project = '" + S + "' AND MES.MemberId = " + MiembroV.Text + " " + _
              "ORDER BY MES.StartDate DESC "
        bdGrid(sql, ListadoGrid)
        agregarColumnaAccion(1, ListadoGrid) 'modificar
        agregarColumnaAccion(2, ListadoGrid) 'borrar
        ListadoGrid.Columns(4).DefaultCellStyle.Format = "dd/MM/yyyy " '"dd.MM.yyyy HH:mm:ss" ' "d"
        ListadoGrid.Columns(5).DefaultCellStyle.Format = "dd/MM/yyyy "
        ListadoGrid.Columns.Item(0).Visible = False 'id
        ListadoGrid.Visible = True
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        'MsgBox(Len(ListadoGrid.Item(5, 0).Value().ToString))
        If Len(ListadoGrid.Item(5, 0).Value().ToString) = 0 Then 'sin fecha fin
            'MsgBox("Tiene un color activo de semáforo." + ChrW(9) + _
            '       "Verifique el ultimo color asignado en el historial de semáforos", vbQuestion, My.Resources.versionFamilias2)
            semaforoTable.Visible = False
            nuevoSemButton.Visible = False
        Else
            'semaforoTable.Visible = True
            nuevoSemButton.Visible = True
        End If

        'DataGridView1.Columns(0).ValueType = GetType(Date)

    End Sub

    Private Sub ListadoGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        Dim c = ListadoGrid.CurrentCellAddress.X
        Dim f = ListadoGrid.CurrentCellAddress.Y
        Dim id As String = ListadoGrid.Item(0, f).Value().ToString()

        ListadoGrid.Rows(f).DefaultCellStyle.BackColor = Color.GhostWhite
        ListadoGrid.Item(3, f).Style.BackColor = Color.Ivory



        If c = 1 Then
            If ListadoGrid.Item(1, f).Value().ToString() = "Finalizar" Then
                finalizarSemaforo(id)
            End If
        ElseIf c = 2 Then
            ahora = Date.Now
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox("¿Esta seguro de BORRAR el semáforo: " + ListadoGrid.Item(3, f).Value().ToString + "?", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "INSERT INTO dbo.MemberEducationSemaphore " + _
                      "SELECT Project, MemberId, EducSemaphore, '" + ahora.ToString(en.DateTimeFormat) + "' CreationDateTime, 'H' RecordStatus, '" + U + "' UserId, " + _
                      "'" + ahora.ToString(en.DateTimeFormat) + "' ExpirationDateTime, StartDate, EndDate " + _
                      "FROM dbo.MemberEducationSemaphore " + _
                      "WHERE Project + CONVERT(varchar, MemberId) + EducSemaphore + CONVERT(varchar, CreationDateTime, 20) = '" + id + "'"
                'InputBox("", "", sql)
                bdInsertar(sql)
                sql = "UPDATE dbo.MemberEducationSemaphore SET RecordStatus = 'H', ExpirationDateTime = '" + ahora.ToString(en.DateTimeFormat) + "' " + _
                      "WHERE Project + CONVERT(varchar, MemberId) + EducSemaphore + CONVERT(varchar, CreationDateTime, 20) = '" + id + "'"
                bdInsertar(sql)
                Listado()
            End If
        Else

        End If
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then ' Or (Keys.Control Or Keys.V)
            validaMiembro()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub modificarSemaforo(ByVal idSemaforo As String)
        sql = "INSERT INTO dbo.MemberEducationSemaphore " + _
              "SELECT Project, MemberId, EducSemaphore, '" + ahora.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, '" + U + "' UserId, " + _
              "ExpirationDateTime, StartDate, '" + ahora.ToString(en.DateTimeFormat) + "' EndDate " + _
              "FROM dbo.MemberEducationSemaphore " + _
              "WHERE Project + CONVERT(varchar, MemberId) + EducSemaphore + CONVERT(varchar, CreationDateTime, 20) = '" + idSemaforo + "'"
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New IngresarSemaforo
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub nuevoSemButton_Click(sender As Object, e As EventArgs) Handles nuevoSemButton.Click
        semaforoTable.Visible = True
        GuardarButton.Visible = True
        FinPicher.Visible = False
        fFinL.Visible = False
    End Sub

    Private Sub opcionesSemaforo()
        sql = "SELECT Code, DescSpanish Color FROM dbo.CdEducationSemaphore"
        bdCombo(sql, SemaforoCombo, "Code", "Color")
    End Sub

    Private Sub validaMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            valoresIniciales()
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        PrincipalPanel.Visible = True
        genInfo()
        opcionesSemaforo()
    End Sub

End Class