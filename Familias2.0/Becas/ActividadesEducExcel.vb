' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActividadesEducExcel
    Dim nombre, tipoMiembro As String
    Dim totalIngresados As Integer = 0

    Private Sub AsistenciaMiscExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
        GuardarButton.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub buscarDuplicados()
        Dim qty As Integer = 500
        Dim m(qty), t(qty), i, j, valor, dup, n As Integer
        Dim list As String = ""

        n = ListadoGrid.Rows.Count() - 1

        For i = 0 To n
            m(i) = ListadoGrid.Item(1, i).Value()
        Next

        For i = 0 To n
            valor = m(i)
            For j = i + 1 To n
                If valor = m(j) Then
                    dup = dup + 1
                    list = list + valor.ToString + ", "
                    ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
                    ListadoGrid.Item(0, i).Value = False
                End If
            Next
        Next

        DuplicadosV.Visible = True
        DuplicadosV.Text = list
    End Sub

    Private Sub buscarIngresados()
        If Len(TipoList.Text) = 0 Then
            MsgBox("Por favor seleccione la actividad", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
        Else
            For i = 0 To ListadoGrid.Rows.Count() - 1
                If existeActividad(ListadoGrid.Item(1, i).Value) > 0 Then
                    ListadoGrid.Item(5, i).Value() = "Ya esta ingresado".ToUpper
                    ListadoGrid.Item(0, i).Value = False
                    ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.DarkSeaGreen
                    totalIngresados = +1
                End If
            Next
        End If
    End Sub

    Private Sub buscarNoValidos()
        Dim i As Integer
        For i = 0 To ListadoGrid.Rows.Count() - 1
            If ListadoGrid.Item(3, i).Value = "Miembro No_Válido".ToUpper Then
                ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.SandyBrown
                ListadoGrid.Item(0, i).Value = False
            End If
        Next
    End Sub

    Private Function existeActividad(ByVal id As String) As Integer
        sql = "SELECT dbo.fn_MISC_checkExistActivity('" + S + "', " + id + _
               ", '" + FechaV.Value.ToString(en.DateTimeFormat) + "', '" + TipoList.SelectedValue + "') AS Total"
        existeActividad = bdEntero(sql, "Total")
    End Function

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(TipoList.Text) > 0 Then
            Dim actualDate As Date = Date.Now
            Dim fechaHora As DateTime = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HoraV.Value.ToLongTimeString
            Dim checkIt As New CheckBox
            Dim i, n, nI As Integer
            n = ListadoGrid.Rows.Count()
            For i = 0 To n - 1
                If ListadoGrid.Item(0, i).Value() = True Then
                    insertarActividad(ListadoGrid.Item(1, i).Value(), fechaHora.ToString(en.DateTimeFormat), actualDate.ToString(en.DateTimeFormat))
                End If
            Next

            sql = "SELECT COUNT(*) as Total FROM dbo.MemberActivity WHERE RecordStatus = ' ' AND Project = '" + S + _
                       "' AND CreationDateTime = '" + actualDate.ToString(en.DateTimeFormat) + "' "
            nI = bdEntero(sql, "Total")

            MsgBox("Se ha ingresado " + nI.ToString + " registros", vbQuestion, My.Resources.versionFamilias2)
            nuevo()
        Else
            MsgBox("Necesita seleccionar la actividad", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub insertarActividad(ByVal member As String, _
               ByVal activityDT As String, _
               ByVal actual As String)
        sql = "INSERT INTO  dbo.MemberActivity VALUES ('" + S + "', " + member + ", '" + TipoList.SelectedValue + "', '" + activityDT + "', '" + actual + "', ' ', '" + U + "', NULL, '" + conversionValorTextBox(NotasV.Text) + "')"
        bdInsertar(sql)
    End Sub

    Private Sub infoGen(ByVal miembro As String)
        If miembroEsValido(S, miembro) = True Then
            sql = "SELECT FirstNames + ' ' + LastNames AS Name, dbo.fn_GEN_tipoMiembro(Project, MemberId) TipoMiembro " + _
                  "FROM dbo.Member WHERE memberId = " + miembro + " AND RecordStatus = ' ' AND Project = '" + S + "' "
            nombre = chequearValor(bdPalabra(sql, "Name"))
            tipoMiembro = chequearValor(bdPalabra(sql, "TipoMiembro"))
        Else
            nombre = "Miembro No_Válido".ToUpper
            tipoMiembro = ""
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub nuevo()
        Dim nxt As New ActividadesEducExcel
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        nuevo()
    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        If Len(TipoList.Text) > 0 Then
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            Dim DGBox As New OpenFileDialog
            'DGBox.Filter = "Excel Worksheets|*.xlsx|All files (*.*)|*.*"
            DGBox.Filter = "Excel Worksheets|*.xlsx"
            DGBox.Multiselect = False
            DGBox.ShowDialog()
            If DGBox.FileName.Length > 0 Then
                MsgBox("Si aparecen marcados, por favor verifiquelos".ToUpper + Chr(13) + Chr(13) + _
                       "VERDE: ya ingresados" + Chr(13) + _
                       "AMARILLO: posibles duplicados" + Chr(13) + _
                       "NARANJA: son No_Válidos" + Chr(13) + Chr(13) + _
                       "De ser necesario ingreselos manualmente", MsgBoxStyle.Critical, My.Resources.versionFamilias2)

                Dim address As String = DGBox.FileName
                If importarAsistenciaDesdeExcel(address, ListadoGrid) = True Then
                    ListadoGrid.Visible = True

                    Dim colB As New DataGridViewTextBoxColumn
                    colB.HeaderText = "Nombre (en Familias)"
                    colB.Name = "NombreBD"
                    ListadoGrid.Columns.Add(colB)

                    Dim colC As New DataGridViewTextBoxColumn
                    colC.HeaderText = "TipoMiembro"
                    colC.Name = "TipoMiembro"
                    ListadoGrid.Columns.Add(colC)

                    Dim colD As New DataGridViewTextBoxColumn
                    colD.HeaderText = "Revision"
                    colD.Name = "_"
                    ListadoGrid.Columns.Add(colD)

                    Dim i As Integer = 0
                    For i = 0 To ListadoGrid.Rows.Count - 1
                        infoGen(ListadoGrid.Item(1, i).Value().ToString)

                        ListadoGrid.Item(0, i).Value = True
                        ListadoGrid.Item(3, i).Value = nombre
                        ListadoGrid.Item(4, i).Value = tipoMiembro
                    Next

                    buscarDuplicados()
                    buscarNoValidos()
                    buscarIngresados()
                    EjemploPicture.Size = New Point(250, 140)
                    InfoTable.Height = 140

                    For i = 1 To 5
                        ListadoGrid.Columns(i).ReadOnly = True
                    Next

                    'columnasRead()
                    TotalV.Text = ListadoGrid.RowCount.ToString
                    ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                    opcionesTable.Visible = True
                    OpcionesActTable.Visible = True
                    GuardarButton.Visible = True
                    UploadButton.Visible = False
                End If
            Else
                opcionesTable.Visible = False
                ListadoGrid.Visible = False
            End If
        Else
            MsgBox("Necesita seleccionar la actividad", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish FROM dbo.CdMemberActivityType " + _
                 "WHERE Active = 1 AND Project IN ('*', '" + S + "')  AND FunctionalArea = 'EDUC' " + _
                 "ORDER BY DescSpanish "
        bdCombo(sql, TipoList, "Code", "DescSpanish")
    End Sub

End Class