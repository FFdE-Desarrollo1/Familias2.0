Public Class AgregarPadrino
    Dim nivel As String

    Private Sub AgregarPadrino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        SitioCombo.Focus()
        sql = "SELECT Code FROM dbo.FwCdOrganization WHERE Code NOT IN ('A', 'E', '*') "
        bdComboSinCodigo(sql, SitioCombo)
    End Sub

    Private Sub agregarGuiding()
        Dim nuevoNivel As String

        If nivel = "PARC" Then
            nuevoNivel = "COMP"
        ElseIf nivel = "NING" Then
            nuevoNivel = "PARC"
        Else
            nuevoNivel = "0"
        End If

        If nuevoNivel = "0" Then
            MsgBox("Error in new sponsorship level", vbQuestion, My.Resources.versionFamilias2)
        Else
            Dim actual As DateTime = Date.Now
            Dim actualCorta As String = actual.Year.ToString + "/" + actual.Month.ToString + "/" + actual.Day.ToString

            ' actual.TimeOfDay

            sql = "INSERT INTO dbo.SponsorMemberRelation VALUES('" + SitioCombo.Text + "', " + IdPadrinoV.Text + ", " + MiembroV.Text + ", " + _
                  "'" + actual.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, '" + TipoCombo.SelectedValue + "', NULL, NULL, '" + actualCorta + "', NULL)"
            'InputBox("", "", sql)
            bdEjecutarSQL(sql)

            sql = "SELECT COUNT(*) T FROM dbo.SponsorMemberRelation " + _
                  "WHERE RecordStatus = ' ' AND SponsorId = " + IdPadrinoV.Text + "  AND MemberId = " + _
                  MiembroV.Text + " AND Project = '" + SitioCombo.Text + "' AND Type = '" + TipoCombo.SelectedValue + "' AND StartDate = '" + actualCorta + "'"
            'InputBox("", "", sql)

            If bdEntero(sql, "T") = 1 Then
                sql = "INSERT INTO dbo.MiscMemberSponsorInfo " + _
                      "SELECT Project, MemberId, '" + actual.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, '" + U + "' UserId, " + _
                      "ExpirationDateTime, Photo, PhotoDate, RetakePhotoDate, RetakePhotoUserId, LastCarnetPrintDate, " + _
                      "'" + nuevoNivel + "' SponsorshipLevel, SponsorshipType, Restriction, RestrictionDate, ExceptionPhotoDate " + _
                      "FROM dbo.MiscMemberSponsorInfo WHERE RecordStatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + MiembroV.Text + " "
                'InputBox("", "", sql)
                bdEjecutarSQL(sql)
                nivelApadrinamiento()

                NivelCombo.SelectedValue = nuevoNivel
                NivelCombo.ForeColor = Color.Blue
                GuardarButton.Visible = False
                TipoCombo.Enabled = False
                historialPadrinos()
            End If
        End If
    End Sub

    Private Sub agregarLead()
        Dim nuevoNivel As String = "COMP"

        Dim actual As DateTime = Date.Now
        Dim actualCorta As String = actual.Year.ToString + "/" + actual.Month.ToString + "/" + actual.Day.ToString

        sql = "INSERT INTO dbo.SponsorMemberRelation VALUES('" + SitioCombo.Text + "', " + IdPadrinoV.Text + ", " + MiembroV.Text + ", " + _
                "'" + actual.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, '" + TipoCombo.SelectedValue + "', NULL, NULL, '" + actualCorta + "', NULL)"
        'InputBox("", "", sql)
        bdEjecutarSQL(sql)
        sql = "SELECT COUNT(*) T FROM dbo.SponsorMemberRelation " + _
              "WHERE RecordStatus = ' ' AND SponsorId = " + IdPadrinoV.Text + "  AND MemberId = " + _
              MiembroV.Text + " AND Project = '" + SitioCombo.Text + "' AND Type = '" + TipoCombo.SelectedValue + "' AND StartDate = '" + actualCorta + "'"
        'InputBox("", "", sql)

        If bdEntero(sql, "T") = 1 Then
            sql = "INSERT INTO dbo.MiscMemberSponsorInfo " + _
                    "SELECT Project, MemberId, '" + actual.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, '" + U + "' UserId, " + _
                    "ExpirationDateTime, Photo, PhotoDate, RetakePhotoDate, RetakePhotoUserId, LastCarnetPrintDate, " + _
                    "'" + nuevoNivel + "' SponsorshipLevel, SponsorshipType, Restriction, RestrictionDate, ExceptionPhotoDate " + _
                    "FROM dbo.MiscMemberSponsorInfo WHERE RecordStatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + MiembroV.Text + " "
            'InputBox("", "", sql)
            bdEjecutarSQL(sql)
            nivelApadrinamiento()

            NivelCombo.SelectedValue = nuevoNivel
            NivelCombo.ForeColor = Color.Blue
            GuardarButton.Visible = False
            TipoCombo.Enabled = False
            historialPadrinos()
        End If

    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        If Len(IdPadrinoV.Text) > 0 And Len(MiembroV.Text) > 0 And Len(SitioCombo.Text) > 0 Then
            SitioCombo.Text = SitioCombo.Text.ToLower()
            sql = "SELECT COUNT(*) Total FROM dbo.Sponsor WHERE RecordStatus = ' ' AND SponsorId = " + IdPadrinoV.Text
            If bdEntero(sql, "Total") = 0 Then 'No existe el padrino
                MsgBox("Sponsor not exist in Familias. You need enter first", vbQuestion, My.Resources.versionFamilias2)
            Else
                sql = "SELECT COUNT(*) Total FROM dbo.Member WHERE RecordStatus = ' ' AND AffiliationStatus = 'AFIL' AND MemberId = " + MiembroV.Text + " AND Project = '" + SitioCombo.Text + "'"

                If bdEntero(sql, "Total") = 0 Then 'no existe el miembro
                    MsgBox("Member not exist in Familias or not affiliated. Please check Member Id and Site", vbQuestion, My.Resources.versionFamilias2)
                Else
                    ''cantidad de padrinos
                    'sql = "SELECT dbo.fn_GEN_Npadrinos('" + SitioCombo.Text + "', " + MiembroV.Text + ") AS Padrinos"
                    'nPadrinos = bdPalabra(sql, "Padrinos")

                    nivelApadrinamiento()

                    If nivel = "COMP" Then
                        MsgBox("Member has complete the sponsorship", vbQuestion, My.Resources.versionFamilias2)
                        historialPadrinos()
                    Else
                        'nombre del padrino
                        sql = "SELECT SponsorNames Name FROM dbo.Sponsor WHERE RecordStatus = ' ' AND SponsorId = " + IdPadrinoV.Text
                        nombrePadrinoV.Text = bdPalabra(sql, "Name")
                        nombrePadrinoV.Visible = True
                        nombresPadrinosL.Visible = True

                        'nombre del miembro
                        sql = "SELECT FirstNames + ' ' + LastNames Name FROM dbo.Member WHERE RecordStatus = ' ' AND MemberId = " + MiembroV.Text + " AND Project = '" + SitioCombo.Text + "'"
                        NombreMiembroV.Text = bdPalabra(sql, "Name")
                        NombreMiembroV.Visible = True
                        nombreMiembroL.Visible = True

                        'llenar combo tipos de padrino
                        sql = "SELECT Code C, DescEnglish D FROM CdSponsorMemberRelationType WHERE CODE NOT IN ('OLD', 'NING') "
                        bdCombo(sql, TipoCombo, "C", "D")
                        TipoCombo.Visible = True
                        tipoL.Visible = True

                        'llenar combo tipos de padrino
                        sql = "SELECT Code C, DescEnglish D FROM CdSponsorshipLevel "
                        bdCombo(sql, NivelCombo, "C", "D")
                        NivelCombo.SelectedValue = nivel

                        NivelCombo.Visible = True
                        nivelL.Visible = True
                        TipoCombo.Visible = True
                        tipoL.Visible = True
                        GuardarButton.Visible = True

                        historialPadrinos()


                    End If
                    BuscarButton.Visible = False
                    SitioCombo.Enabled = False
                    MiembroV.ReadOnly = True
                    IdPadrinoV.ReadOnly = True
                End If

            End If
        Else
            MsgBox("Need enter SponsorId and MemberId and Site", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        'response = MsgBox("¿Esta seguro de cambiar el grado? ", style, My.Resources.versionFamilias2)
        'If response = MsgBoxResult.Yes Then
        '    snGrado = True
        '    nGrado = "'" + gradoCombo.SelectedValue + "'"
        'End If

        If (nivel = "PARC" Or nivel = "NING") And TipoCombo.SelectedValue = "GUID" Then
            agregarGuiding()
        ElseIf nivel = "NING" And TipoCombo.SelectedValue = "LEAD" Then
            agregarLead()
        Else
            If Len(TipoCombo.Text) = 0 Then
                MsgBox("You need to select type.", vbQuestion, My.Resources.versionFamilias2)
            Else
                MsgBox("Please check sponsors list...You cann't add:" + vbNewLine + "a) 2 sponsors LEAD " + vbNewLine + "b) 3 or more GUIDING " + vbNewLine + "c) to combine LEAD and GUIDING", vbQuestion, My.Resources.versionFamilias2)
            End If
        End If
    End Sub

    Private Sub historialPadrinos()
        PadrinosGrid.DataSource = Nothing
        PadrinosGrid.Rows.Clear()
        PadrinosGrid.Visible = False
        sponsorsL.Visible = False
        sql = "SELECT SMR.Project + CONVERT(varchar, SMR.MemberId) AS Member, M.FirstNames + ' ' + M.LastNames AS Name, M.LastFamilyId AS FamilyId, SMR.SponsorId, " + _
              "S.SponsorNames, dbo.CdSponsorMemberRelationType.DescEnglish AS Type, CONVERT(varchar, StartDate, 107) StartDate, CONVERT(varchar,EndDate, 107) EndDate " + _
              "FROM dbo.SponsorMemberRelation SMR " + _
              "INNER JOIN dbo.Member M ON SMR.Project = M.Project AND SMR.MemberId = M.MemberId AND SMR.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.Sponsor S ON SMR.SponsorId = S.SponsorId AND SMR.RecordStatus = S.RecordStatus " + _
              "INNER JOIN dbo.CdSponsorMemberRelationType ON SMR.Type = dbo.CdSponsorMemberRelationType.Code " + _
              "WHERE SMR.RecordStatus = ' ' AND SMR.MemberId = " + MiembroV.Text + " AND SMR.Project = '" + SitioCombo.Text + "' " + _
              "ORDER BY EndDate "
        bdGrid(sql, PadrinosGrid)
        PadrinosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        PadrinosGrid.Visible = True
        sponsorsL.Visible = True
    End Sub

    Private Sub IdPadrinoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdPadrinoV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub nivelApadrinamiento()
        'nivel de apadrinamiento
        sql = "SELECT SponsorshipLevel Nivel FROM dbo.MiscMemberSponsorInfo WHERE RecordStatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + MiembroV.Text + " "
        nivel = chequearValor(bdPalabra(sql, "Nivel"))
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New AgregarPadrino
        nxt.Show()
        Me.Close()
    End Sub

End Class