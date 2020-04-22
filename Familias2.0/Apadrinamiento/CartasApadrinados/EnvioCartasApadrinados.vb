' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class EnvioCartasApadrinados
    Dim envio As DateTime
    Dim cat As String

    Private Sub EnvioCartasApadrinados_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub actualizarFechaEnvio(ByVal memberId As Integer, ByVal sponsorId As Integer, ByVal dateSent As DateTime)
        sql = "INSERT INTO dbo.MemberSponsorLetter " + _
            "SELECT Project, SponsorId, MemberId, SponsorOrMember, DateTimeWritten, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, '" + dateSent.ToString(en.DateTimeFormat) + "', " + _
            "Category, Notes, Translated, ReceivedInGuatemala " + _
            "FROM dbo.MemberSponsorLetter MSL " + _
            "WHERE MSL.RecordStatus = ' ' AND MSL.Project = '" + S + "' AND MSL.SponsorOrMember = 'M' AND MSL.DateSent IS NULL " + cat + " AND YEAR(MSL.DateTimeWritten) = " + _
            EscritasPicker.Value.Year.ToString + " AND MONTH(MSL.DateTimeWritten) = " + EscritasPicker.Value.Month.ToString + " And Day(MSL.DateTimeWritten) = " + EscritasPicker.Value.Day.ToString + " " + _
            " AND MemberId = " + memberId.ToString + " AND SponsorId = " + sponsorId.ToString
        bdEjecutarSQL(sql)
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim n As Integer = 0
        For f = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid.Item(0, f).Value() = True Then
                n += 1
            End If
        Next

        If n > 0 Then
            GuardarButton.Visible = False
            MsgBox("Este proceso puede tardar unos minutos según la cantidad de cartas que haya seleccionado", vbExclamation, My.Resources.versionFamilias2)
            envio = DateTime.Now

            For f = 0 To ListadoGrid.RowCount - 1
                If ListadoGrid.Item(0, f).Value() = True Then
                    actualizarFechaEnvio(ListadoGrid.Item(1, f).Value(), ListadoGrid.Item(5, f).Value(), envio)
                End If
            Next

            reporte(envio.ToString(en.DateTimeFormat))
        Else
            MsgBox("No ha seleccionado cartas", vbExclamation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub inicioButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ListadoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoButton.Click
        reporte("")
    End Sub

    Private Sub reporte(ByVal conFechaEnvio As String)
        Dim col1 As Boolean
        Dim dEnvio As String

        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        SeleccionarCheck.Checked = False

        If Len(conFechaEnvio) = 0 Then
            dEnvio = " AND MSL.DateSent IS NULL "
            GuardarButton.Visible = True
            SeleccionarCheck.Visible = True
            col1 = True
        Else
            dEnvio = " AND MSL.DateSent = '" + conFechaEnvio + "' "
            GuardarButton.Visible = False
            col1 = False
            SeleccionarCheck.Visible = False
        End If

        If Len(CategoriaCombo.Text) = 0 Then
            cat = " "
        Else
            cat = " AND  MSL.Category = '" + CategoriaCombo.SelectedValue + "' "
        End If

        sql = "SELECT  M.MemberId, M.FirstNames, M.LastNames, M.LastFamilyId AS FamilyId, S.SponsorId, S.SponsorNames, cdLC." + descripcion() + " AS Category, dbo.fn_GEN_FormatDate (MSL.DateTimeWritten, '" + L + "') Written, dbo.fn_GEN_FormatDate (MSL.DateSent, '" + L + "')  Sent " + _
              "FROM dbo.MemberSponsorLetter MSL INNER JOIN dbo.Member M ON MSL.Project = M.Project AND MSL.MemberId = M.MemberId AND MSL.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.Sponsor S ON MSL.SponsorId = S.SponsorId AND MSL.RecordStatus = S.RecordStatus INNER JOIN dbo.CdLetterCategory cdLC ON MSL.Category = cdLC.Code " + _
              "WHERE MSL.RecordStatus = ' ' AND MSL.Project = '" + S + "' AND MSL.SponsorOrMember = 'M'  " + dEnvio + cat + " AND YEAR(MSL.DateTimeWritten) = " + _
              EscritasPicker.Value.Year.ToString + " AND MONTH(MSL.DateTimeWritten) = " + EscritasPicker.Value.Month.ToString + " And Day(MSL.DateTimeWritten) = " + EscritasPicker.Value.Day.ToString + " " + _
              "ORDER BY M.MemberId "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(0).Visible = col1

        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
        For i = 0 To ListadoGrid.RowCount - 1
            ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next

        For i = 1 To 9
            ListadoGrid.Columns(i).ReadOnly = True
        Next
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        ListadoGrid.Visible = True
    End Sub

    Private Sub SeleccionarCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SeleccionarCheck.CheckedChanged
        seleccionarTodos()
    End Sub

    Private Sub seleccionarTodos()
        If SeleccionarCheck.Checked = True Then
            For i = 0 To ListadoGrid.RowCount - 1
                ListadoGrid.Item(0, i).Value() = True
            Next
        Else
            For i = 0 To ListadoGrid.RowCount - 1
                ListadoGrid.Item(0, i).Value() = False
            Next
        End If
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, " + descripcion() + " Categoria FROM dbo.CdLetterCategory WHERE Active = 1 "
        bdCombo(sql, CategoriaCombo, "Code", "Categoria")

        EscritasPicker.Width = 310
        CategoriaCombo.Width = 210
    End Sub


End Class