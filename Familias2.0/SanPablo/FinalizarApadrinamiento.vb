Public Class FinalizarApadrinamiento
    Dim nivel, IdRel As String

    Private Sub EndSponsorship_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        SitioCombo.Focus()
        sql = "SELECT Code FROM dbo.FwCdOrganization WHERE Code NOT IN ('A', 'E', '*') "
        bdComboSinCodigo(sql, SitioCombo)
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        If Len(MiembroV.Text) > 0 And Len(SitioCombo.Text) > 0 Then
            SitioCombo.Text = SitioCombo.Text.ToLower()
            sql = "SELECT COUNT(*) Total FROM dbo.Member WHERE RecordStatus = ' ' AND AffiliationStatus IS NOT NULL AND MemberId = " + MiembroV.Text + " AND Project = '" + SitioCombo.Text + "'"

            If bdEntero(sql, "Total") = 0 Then 'no existe el miembro
                MsgBox("Member not exist in Familias or not affiliated, dissaffiliated o graduated. Please check Member Id and Site", vbQuestion, My.Resources.versionFamilias2)
            Else
                nivelApadrinamiento()

                If nivel = "NING" Then
                    MsgBox("Member hasn't active sponsor", vbQuestion, My.Resources.versionFamilias2)
                Else
                    'nombre del miembro
                    sql = "SELECT FirstNames + ' ' + LastNames + CASE WHEN M.AffiliationStatus = 'AFIL' THEN '' ELSE ' (' + cdAS.DescEnglish + ')' END Name " + _
                          "FROM dbo.Member M INNER JOIN cdAffiliationStatus cdAS ON M.AffiliationStatus = cdAS.Code  " + _
                          "WHERE RecordStatus = ' ' AND MemberId = " + MiembroV.Text + " AND Project = '" + SitioCombo.Text + "'"
                    NombreMiembroV.Text = bdPalabra(sql, "Name")

                    'llenar combo tipos de padrino
                    sql = "SELECT Code C, DescEnglish D FROM CdSponsorMemberRelationType WHERE CODE NOT IN ('OLD', 'NING') "
                    bdCombo(sql, TipoCombo, "C", "D")

                    'llenar combo tipos de padrino
                    sql = "SELECT Code C, DescEnglish D FROM CdSponsorshipLevel "
                    bdCombo(sql, NivelCombo, "C", "D")
                    NivelCombo.SelectedValue = nivel

                    ''llenar combo razon finalización
                    sql = "SELECT Code C, DescEnglish D FROM   CdSponsorMemberRelationInactiveReason "
                    bdCombo(sql, RazonCombo, "C", "D")

                    NombreMiembroV.Visible = True
                    nombreMiembroL.Visible = True
                    nivelL.Visible = True
                    NivelCombo.Visible = True
                    GuardarButton.Visible = True
                    historialPadrinos()
                End If
                BuscarButton.Visible = False
                SitioCombo.Enabled = False
                MiembroV.ReadOnly = True
            End If
        Else
            MsgBox("Need enter MemberId and Site", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(IdPadrinoV.Text) = 0 Then
            MsgBox("Need selected a sponsor", vbQuestion, My.Resources.versionFamilias2)
        Else
            Dim nuevoNivel, errorM As String

            'If nivel = "PARC" Then
            '    nuevoNivel = "NING"
            'ElseIf nivel = "COMP" Then
            '    If TipoCombo.SelectedValue = "LEAD" Then
            '        nuevoNivel = "NING"
            '    Else
            '        nuevoNivel = "PARC"
            '    End If
            'Else
            '    nuevoNivel = "0"
            'End If

            'If nuevoNivel = "0" Then
            '    MsgBox("Error in new sponsorship level", vbQuestion, My.Resources.versionFamilias2)
            'Else
            Dim actual As DateTime = Date.Now
            Dim razon As String
            If Len(RazonCombo.Text) = 0 Then
                razon = "NULL"
            Else
                razon = "'" + RazonCombo.SelectedValue + "'"
            End If

            'actualizar fecha
            sql = "INSERT INTO dbo.SponsorMemberRelation " + _
                  "SELECT Project, SponsorId, MemberId, '" + actual.ToString(en.DateTimeFormat) + "' CreationDateTime, RecordStatus, " + _
                  "'" + U + "' UserId, ExpirationDateTime, Type, Notes, " + razon + " InactiveReason, StartDate, '" + FechaFinPicker.Value.ToString(en.DateTimeFormat) + "' EndDate " + _
                  "FROM dbo.SponsorMemberRelation WHERE RecordStatus = ' ' AND " + _
                  "CONVERT(varchar,SponsorId) + '-'+ CONVERT(varchar,MemberId) + '-' +CONVERT(varchar,Creationdatetime, 112) = '" + IdRel + "' "
            'InputBox("", "", sql)
            bdEjecutarSQL(sql)

            ''borrar la fila original
            'sql = "UPDATE dbo.SponsorMemberRelation SET Recordstatus = 'H', ExpirationDateTime = GETDATE() " + _
            '      "FROM dbo.SponsorMemberRelation WHERE RecordStatus = ' ' AND " + _
            '      "CONVERT(varchar,SponsorId) + '-'+ CONVERT(varchar,MemberId) + '-'  +CONVERT(varchar,Creationdatetime, 112) = '" + IdRel + "' "
            'bdEjecutarSQL(sql)

            sql = "SELECT COUNT(*) T FROM dbo.SponsorMemberRelation WHERE Recordstatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + MiembroV.Text + " AND EndDate IS NULL "
            'InputBox("", "", sql)
            Dim n As Integer = bdEntero(sql, "T")

            Dim tipN As String

            nuevoNivel = ""
            If n = 0 Then
                nuevoNivel = "NING"
                errorM = "0"
            Else
                sql = "SELECT Type T FROM dbo.SponsorMemberRelation WHERE Recordstatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + MiembroV.Text + " AND EndDate IS NULL GROUP BY Type "
                'InputBox("", "", sql)
                tipN = bdPalabra(sql, "T")

                If n = 1 Then
                    If tipN = "GUID" Then
                        nuevoNivel = "PARC"
                        errorM = "0"
                    ElseIf tipN = "LEAD" Then
                        nuevoNivel = "COMP"
                        errorM = "0"
                    Else
                        MsgBox("Error in new sponsorship level (Incorrect type)", vbQuestion, My.Resources.versionFamilias2)
                        errorM = "1"
                    End If
                ElseIf n = 2 Then
                    If tipN = "GUID" Then
                        nuevoNivel = "COMP"
                        errorM = "0"
                    Else
                        MsgBox("Error in new sponsorship level (more of 1 lead)", vbQuestion, My.Resources.versionFamilias2)
                        errorM = "1"
                    End If
                Else
                    MsgBox("Error in new sponsorship level (more of 2 sponsors)", vbQuestion, My.Resources.versionFamilias2)
                    errorM = "1"
                End If
            End If

                If errorM = "0" Then
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
                    historialPadrinos()
                    limpiar()
                End If
            End If
    End Sub

    Private Sub historialPadrinos()
        PadrinosGrid.DataSource = Nothing
        PadrinosGrid.Rows.Clear()
        PadrinosGrid.Visible = False
        PadrinosGrid.Visible = False
        sponsorsL.Visible = False
        sql = "SELECT CONVERT(varchar,SMR.SponsorId) + '-' + CONVERT(varchar,SMR.MemberId) + '-' + CONVERT(varchar,SMR.Creationdatetime, 112) ID, " + _
              "SMR.SponsorId, S.SponsorNames, dbo.CdSponsorMemberRelationType.DescEnglish AS Type, CONVERT(varchar, StartDate, 107) StartDate, " + _
              "CONVERT(varchar,EndDate, 107) EndDate, CASE WHEN EndDate IS NOT NULL THEN 'NO' ELSE 'YES' END Active " + _
              "FROM dbo.SponsorMemberRelation SMR " + _
              "INNER JOIN dbo.Member M ON SMR.Project = M.Project AND SMR.MemberId = M.MemberId AND SMR.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.Sponsor S ON SMR.SponsorId = S.SponsorId AND SMR.RecordStatus = S.RecordStatus " + _
              "INNER JOIN dbo.CdSponsorMemberRelationType ON SMR.Type = dbo.CdSponsorMemberRelationType.Code " + _
              "WHERE SMR.RecordStatus = ' ' AND SMR.MemberId = " + MiembroV.Text + " AND SMR.Project = '" + SitioCombo.Text + "' " 'AND EndDate IS NULL "
        bdGrid(sql, PadrinosGrid)
        PadrinosGrid.Columns.Item(0).Visible = False 'ID
        PadrinosGrid.Columns.Item(6).Visible = False 'Activo
        PadrinosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        PadrinosGrid.Visible = True
        sponsorsL.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiar()
        IdRel = 0
        IdPadrinoV.Text = ""
        nombrePadrinoV.Text = ""
        TipoCombo.Text = ""
        RazonCombo.Text = ""
        padrinoTable.Visible = False
    End Sub

    Private Sub nivelApadrinamiento()
        'nivel de apadrinamiento
        sql = "SELECT SponsorshipLevel Nivel FROM dbo.MiscMemberSponsorInfo WHERE RecordStatus = ' ' AND Project = '" + SitioCombo.Text + "' AND MemberId = " + MiembroV.Text + " "

        nivel = chequearValor(bdPalabra(sql, "Nivel"))
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New FinalizarApadrinamiento
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PadrinosGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PadrinosGrid.CellContentClick
        If PadrinosGrid.RowCount > 0 Then
            Dim f As Integer = PadrinosGrid.CurrentCellAddress.Y
            'MsgBox(PadrinosGrid.Item(5, f).Value().ToString)
            If PadrinosGrid.Item(6, f).Value() = "NO" Then
                MsgBox("You selected a finish sponsorship", vbQuestion, My.Resources.versionFamilias2)
                limpiar()
            Else
                IdRel = PadrinosGrid.Item(0, f).Value()
                IdPadrinoV.Text = PadrinosGrid.Item(1, f).Value()
                nombrePadrinoV.Text = PadrinosGrid.Item(2, f).Value()
                TipoCombo.Text = PadrinosGrid.Item(3, f).Value()

                padrinoTable.Visible = True
            End If

        End If
    End Sub



End Class