Public Class ActualizarDatosPadrinos
    Dim nombreO, contactoO, idRec As String

    Private Sub ActualizarDatosPadrinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        IdPadrinoV.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        buscarPadrino()
    End Sub

    Private Sub buscarPadrino()
        Dim genInfo As New DataTable
        sql = "SELECT SponsorNames, OrganizationContactNames, SpeaksSpanish, CONVERT(varchar, SponsorId) + CONVERT(varchar, CreationDateTime, 112) AS IdRecord  " + _
              "FROM dbo.Sponsor " + _
              "WHERE RecordStatus = ' ' AND SponsorId = " + IdPadrinoV.Text
        bdDataTable(sql, genInfo)

        If genInfo.Rows.Count > 0 Then
            BuscarButton.Visible = False
            GuardarButton.Visible = True
            IdPadrinoV.ReadOnly = True

            NombreV.Text = chequearValor(genInfo.Rows(0)("SponsorNames"))
            ContactoV.Text = chequearValor(genInfo.Rows(0)("OrganizationContactNames"))
            EspañolCheck.Checked = genInfo.Rows(0)("SpeaksSpanish")
            idRec = genInfo.Rows(0)("IdRecord")

            NombreV.Visible = True
            nombresPadrinosL.Visible = True
            ContactoV.Visible = True
            contactoL.Visible = True
            EspañolCheck.Visible = True

        Else
            MsgBox("Sponsor Id is not correct or not exist", vbQuestion, My.Resources.versionFamilias2)
        End If


    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(NombreV.Text) > 0 Then
            GuardarButton.Visible = False
            Dim actual As DateTime = Now
            'sql = "UPDATE dbo.Sponsor SET RecordStatus = 'H', ExpirationDateTime = '" + actual.ToString(en.DateTimeFormat) + "' " + _
            '      "WHERE  Recordstatus = ' ' and CONVERT(varchar, SponsorId) + CONVERT(varchar, CreationDateTime, 112) = '" + idRec + "' "
            'bdEjecutarSQL(sql)
            'sql = "SELECT COUNT(*) T FROM dbo.Sponsor " + _
            '      "WHERE  Recordstatus = ' ' and CONVERT(varchar, SponsorId) + CONVERT(varchar, CreationDateTime, 112) = '" + idRec + "' "

            Dim span As String
            If EspañolCheck.Checked = True Then
                span = "1"
            Else
                span = "0"
            End If

            sql = "INSERT INTO  dbo.Sponsor " + _
                  "SELECT SponsorId, '" + actual.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, '" + U + "' UserId, ExpirationDateTime, " + _
                  "'" + Replace(NombreV.Text, "'", "''") + "' SponsorNames, Gender, '" + Replace(ContactoV.Text, "'", "''") + "' OrganizationContactNames, " + _
                  "StateOrProvince, Country, " + span + " SpeaksSpanish " + _
                  "FROM dbo.Sponsor " + _
                  "WHERE  Recordstatus = ' ' and CONVERT(varchar, SponsorId) + CONVERT(varchar, CreationDateTime, 112) = '" + idRec + "' "
            'InputBox("", "", sql)
            bdEjecutarSQL(sql)
            MsgBox("Information updated correctly!", vbQuestion, My.Resources.versionFamilias2)

            sql = "SELECT SponsorId, SponsorNames, Gender, OrganizationContactNames ContactNames, CASE WHEN SpeaksSpanish = 1 THEN 'Yes' Else 'No' END SpeaksSpanish " + _
                  "FROM dbo.Sponsor " + _
                  "WHERE  Recordstatus = ' ' and SponsorId = " + IdPadrinoV.Text + " "
            bdGrid(sql, InfoPadrinoGrid)
            InfoPadrinoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            InfoPadrinoGrid.Visible = True
            PrincipalPanel.Visible = False
        End If
    End Sub

    Private Sub IdPadrinoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdPadrinoV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            buscarPadrino()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New ActualizarDatosPadrinos
        nxt.Show()
        Me.Close()
    End Sub

End Class