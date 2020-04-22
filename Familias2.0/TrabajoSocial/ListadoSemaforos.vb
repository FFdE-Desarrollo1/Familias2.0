' Copyright:  Copyright (c) 2016 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0
' @code CSER


Public Class ListadoSemaforos

    Private Sub ListadoSemaforos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        Dim sinSema As String = ""
        Dim where As String
        If Len(SemaforoCombo.Text) = 0 Then
            sSemL.Visible = True
            where = " "
        Else
            where = " AND MES.EducSemaphore = '" + SemaforoCombo.SelectedValue.ToString + "' "
            sSemL.Visible = False
        End If


        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        sql = "SELECT dbo.fn_GEN_regionFamilia(M.Project, M.LastFamilyId) AS 'Región', F.Pueblo, " + _
              "M.LastFamilyId AS Familia, M.MemberId AS Miembro, M.FirstNames + ' ' + M.LastNames AS 'Nombre Completo',  cdES.DescSpanish AS Semáforo, " + _
              "dbo.fn_GEN_FormatDate( MES.StartDate, '" + L + "')  AS Inicio, dbo.fn_GEN_TS(M.Project, M.LastFamilyId) AS TS " + _
              "FROM dbo.Member M LEFT OUTER JOIN dbo.MemberEducationSemaphore MES " + _
              " ON M.Project = MES.Project AND M.MemberId = MES.MemberId AND M.RecordStatus = MES.RecordStatus AND MES.EndDate IS NULL " + _
              " LEFT JOIN dbo.CdEducationSemaphore cdES ON MES.EducSemaphore = cdES.Code " + _
              " INNER JOIN dbo.Family F ON M.Project = F.Project AND M.LastFamilyId = F.FamilyId AND M.RecordStatus = F.RecordStatus " + _
              "WHERE M.RecordStatus = ' '  AND M.Project = '" + S + "' AND M.AffiliationStatus = 'AFIL'" + where + _
              "ORDER BY 'Región', Pueblo, F.FamilyId, M.MemberId "
        bdGrid(sql, ListadoGrid)
        'ListadoGrid.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy "

        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        ListadoGrid.AllowUserToResizeColumns = True

        For f = 0 To ListadoGrid.Rows.Count - 1
            If Len(ListadoGrid.Item(5, f).Value().ToString) = 0 Then
                sinSema = sinSema & "(" & ListadoGrid.Item(3, f).Value().ToString & ")   "
                ListadoGrid.Rows(f).DefaultCellStyle.ForeColor = Color.SandyBrown
            End If
        Next

        totalL.Text = "Total: " + ListadoGrid.RowCount.ToString
        sSemL.Text = "Sin semáforo: " + sinSema
        ListadoGrid.Visible = True
        totalL.Visible = True
    End Sub

    Private Sub generarButton_Click(sender As Object, e As EventArgs) Handles generarButton.Click
        'char(13)
        MsgBox("El reporte puede tardar unos segundos en aparecer." + ChrW(13) + _
              "Procesando...", MsgBoxStyle.Information, My.Resources.versionFamilias2)
        listado()
    End Sub

    Private Sub ListadoGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles ListadoGrid.KeyDown
        If ListadoGrid.RowCount > 0 Then
            If e.Control And (e.KeyCode = Keys.C) Then
                Dim d As DataObject = ListadoGrid.GetClipboardContent()
                Clipboard.SetDataObject(d)
                e.Handled = True
            ElseIf (e.Control And e.KeyCode = Keys.V) Then
                PasteUnboundRecords(ListadoGrid)
            End If
        End If
    End Sub

    Private Sub PasteUnboundRecords(ByVal dgv As DataGridView)
        Try
            Dim rowLines As String() = Clipboard.GetText(TextDataFormat.Text).Split(New String(0) {vbCr & vbLf}, StringSplitOptions.None)
            Dim currentRowIndex As Integer = (If(dgv.CurrentRow IsNot Nothing, dgv.CurrentRow.Index, 0))
            Dim currentColumnIndex As Integer = (If(dgv.CurrentCell IsNot Nothing, dgv.CurrentCell.ColumnIndex, 0))
            Dim currentColumnCount As Integer = dgv.ColumnCount

            For rowLine As Integer = 0 To rowLines.Length - 1
                If rowLine = rowLines.Length - 1 AndAlso String.IsNullOrEmpty(rowLines(rowLine)) Then
                    Exit For
                End If

                Dim columnsData As String() = rowLines(rowLine).Split(New String(0) {vbTab}, StringSplitOptions.None)
                If (currentColumnIndex + columnsData.Length) > dgv.ColumnCount Then
                    For columnCreationCounter As Integer = 0 To ((currentColumnIndex + columnsData.Length) - currentColumnCount) - 1
                        If columnCreationCounter = rowLines.Length - 1 Then
                            Exit For
                        End If
                    Next
                End If
                If dgv.Rows.Count > (currentRowIndex + rowLine) Then
                    For columnsDataIndex As Integer = 0 To columnsData.Length - 1
                        If currentColumnIndex + columnsDataIndex <= dgv.ColumnCount - 1 Then
                            dgv.Rows(currentRowIndex + rowLine).Cells(currentColumnIndex + columnsDataIndex).Value = columnsData(columnsDataIndex)
                        End If
                    Next
                Else
                    Dim pasteCells As String() = New String(dgv.ColumnCount - 1) {}
                    For cellStartCounter As Integer = currentColumnIndex To dgv.ColumnCount - 1
                        If columnsData.Length > (cellStartCounter - currentColumnIndex) Then
                            pasteCells(cellStartCounter) = columnsData(cellStartCounter - currentColumnIndex)
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            'Log Exception
        End Try
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish Color FROM dbo.CdEducationSemaphore"
        bdCombo(sql, SemaforoCombo, "Code", "Color")
    End Sub
End Class