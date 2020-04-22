' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class CartaPadrino
    Dim ahora As DateTime
    'Dim fecha As String

    Private Sub CartaPadrino_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        PadrinoV.Focus()

    End Sub

    Private Sub ahijados()
        sql = "SELECT   SMR.Project Site, SMR.MemberId, M.FirstNames + ' ' + M.LastNames AS 'Member Name' , F.Address AS Address, cdA.DescEnglish AS Area, dbo.fn_GEN_TS(F.Project, F.FamilyId) AS TS,  E1.Grade " + _
                 "FROM  dbo.SponsorMemberRelation SMR INNER JOIN dbo.Member M ON SMR.Project = M.Project AND SMR.MemberId = M.MemberId AND SMR.RecordStatus = M.RecordStatus " + _
                 "INNER JOIN dbo.Family F ON M.Project = F.Project AND M.LastFamilyId = F.FamilyId AND M.RecordStatus = F.RecordStatus " + _
                 "INNER JOIN dbo.CdGeographicArea cdA ON F.Project = cdA.Project AND F.Area = cdA.Code LEFT OUTER JOIN dbo.fn_FACT_EducInfomation() E1 ON E1.Project = M.Project AND E1.MemberId = M.MemberId " + _
                 "WHERE SMR.RecordStatus = ' ' AND SMR.SponsorId = " + PadrinoV.Text + " AND SMR.EndDate IS NULL "
        bdGrid(sql, ListaGrid)
        ListaGrid.Columns(1).ReadOnly = True
        ListaGrid.Columns(2).ReadOnly = True
        ListaGrid.Columns(4).Visible = False
        ListaGrid.Columns(5).Visible = False
        ListaGrid.Columns(6).Visible = False
        ListaGrid.Columns(7).Visible = False

        ahijadosPanel.Visible = True
        If ListaGrid.RowCount > 0 Then
            GuardarButton.Visible = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub buscarCandidatos(ByVal sql As String)
        CandidatosGrid.DataSource = Nothing
        CandidatosGrid.Rows.Clear()
        CandidatosGrid.Visible = False
        bdGrid(sql, CandidatosGrid)
        If CandidatosGrid.RowCount > 0 Then
            For Each r As DataGridViewRow In CandidatosGrid.Rows
                CandidatosGrid.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
            Next
        End If
        CandidatosGrid.Visible = True
        CandidatosGrid.Width = principalTable.Width
    End Sub

    Private Sub CandidatosGrid_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles CandidatosGrid.CellContentClick
        If CandidatosGrid.RowCount > 0 Then
            Dim fila As Integer
            fila = CandidatosGrid.CurrentCellAddress.Y()
            PadrinoV.Text = CandidatosGrid.Item(0, fila).Value
            CandidatosGrid.Visible = False
            CandidatosGrid.Height = 0
            infoSponsor()
        End If
    End Sub

    Private Sub CartasIngresadas()
        CandidatosGrid.DataSource = Nothing
        CandidatosGrid.Rows.Clear()
        CandidatosGrid.Visible = False
        sql = "SELECT  MSL.Project AS Site, MSL.MemberId, M.FirstNames + ' ' + M.LastNames AS [Names], CONVERT(varchar, MSL.DateTimeWritten, 107)   AS 'Date Sent' " + _
                 "FROM   dbo.MemberSponsorLetter MSL INNER JOIN  dbo.Member M ON MSL.Project = M.Project AND MSL.MemberId = M.MemberId AND MSL.RecordStatus = M.RecordStatus " + _
                 "WHERE MSL.RecordStatus = ' ' AND MSL.SponsorId = " + PadrinoV.Text + " AND MSL.CreationDateTime = '" + ahora.ToString(en.DateTimeFormat) + "' "
        bdGrid(sql, CandidatosGrid)
        CandidatosGrid.Visible = True
        CandidatosGrid.Width = principalTable.Width
        ahijadosPanel.Visible = False
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GuardarButton.Click
        If ListaGrid.RowCount > 0 Then
            If marcados() = 0 Then
                MsgBox("You need check some godchild", vbInformation, My.Resources.versionFamilias2)
            Else
                GuardarButton.Visible = False

                Dim n As Integer = 0
                Dim nombres As String = ""
                ahora = Now
                'fecha = ahora.ToShortDateString
                Dim isCheck As New CheckBox
                For Each r As DataGridViewRow In ListaGrid.Rows
                    isCheck.Checked = ListaGrid.Item(0, r.Index).Value()
                    If isCheck.Checked = True Then
                        guardarCartaPadrino(ListaGrid.Item(1, r.Index).Value(), ListaGrid.Item(2, r.Index).Value())
                        n = n + 1
                        nombres = nombres + ListaGrid.Item(3, r.Index).Value() + vbNewLine
                    End If
                Next
                If n > 0 Then
                    imprimeBoletas()
                    CartasIngresadas()
                    MsgBox("You save " + n.ToString + " letters: " + vbNewLine + vbNewLine + nombres, vbInformation, My.Resources.versionFamilias2)
                End If
            End If
        End If
    End Sub

    Private Function marcados() As Integer
        Dim n As Integer = 0
        Dim isCheck As New CheckBox
        For Each r As DataGridViewRow In ListaGrid.Rows
            isCheck.Checked = ListaGrid.Item(0, r.Index).Value()
            If isCheck.Checked = True Then
                n = n + 1
            End If
        Next
        Return n
    End Function

    Private Sub guardarCartaPadrino(ByVal sitio As String, ByVal miembro As Integer)
        '(Project,SponsorId,MemberId,SponsorOrMember,
        'DateTimeWritten,CreationDateTime,RecordStatus,UserId,ExpirationDateTime,DateSent,Category,Notes,Translated,ReceivedInGuatemala) 
        sql = "INSERT INTO dbo.MemberSponsorLetter VALUES ('" + sitio + "'," + PadrinoV.Text + "," + miembro.ToString + ",'S','" + _
                FechaEnvioPicker.Value.ToString(en.DateTimeFormat) + "','" + ahora.ToString(en.DateTimeFormat) + "',' ','" + U + "',NULL,NULL,NULL,NULL,NULL,NULL) "
        bdInsertar(sql)
    End Sub

    Private Sub imprimirBoleta()
        PrintPreviewDialogBoleta.Document = PrintDocumentBoleta 'PrintPreviewDialog associate with PrintDocument.
        PrintPreviewDialogBoleta.ShowDialog() 'open the print preview
    End Sub

    Private Sub infoSponsor()
        If padrinoEsValido(PadrinoV.Text) = True Then
            sql = "SELECT SponsorNames nombre FROM Sponsor WHERE RecordStatus = ' '  AND SponsorId = " + PadrinoV.Text
            NombreSV.Text = bdPalabra(sql, "nombre")
            NombreSV.Width = Len(NombreSV.Text) * 10
            MiembroV.Visible = False
            MiembroL.Visible = False
            L1.Visible = False
            indicacionesL.Visible = False
            PadrinoV.ReadOnly = True
            NombreSV.ReadOnly = True
            CandidatosGrid.Visible = False
            CandidatosGrid.DataSource = Nothing
            ahijados()
        Else
            MsgBox("Incorrect Sponsor Id", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub inicioButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And Len(MiembroV.Text) > 0 Then
            'If miembroEsValido(S, MiembroV.Text) = True Then
            buscarCandidatos("SELECT  SMR.SponsorId, S.SponsorNames, S.OrganizationContactNames " + _
                     "FROM  dbo.SponsorMemberRelation SMR " + _
                     "INNER JOIN dbo.Member M ON SMR.Project = M.Project AND SMR.MemberId = M.MemberId AND SMR.RecordStatus = M.RecordStatus " + _
                     "INNER JOIN dbo.Sponsor S ON SMR.SponsorId = S.SponsorId AND SMR.RecordStatus = S.RecordStatus " + _
                     "WHERE SMR.RecordStatus = ' ' AND SMR.Project + CONVERT(varchar,SMR.MemberId) = '" + MiembroV.Text + "' AND SMR.EndDate IS NULL ")
            ' PadrinoV.Text = bdEntero(sql, "Id").ToString
            'infoSponsor()
            'Else
            '    MsgBox("Incorrect Member Id", vbInformation, My.Resources.versionFamilias2)
            'End If
        End If

        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SoloNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub NombreSV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreSV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And Len(NombreSV.Text) > 0 Then
            buscarCandidatos("SELECT  SponsorId, SponsorNames, OrganizationContactNames " + _
                             "FROM  dbo.Sponsor " + _
                             "WHERE RecordStatus = ' '  AND SponsorNames like '%" + NombreSV.Text + "%' " + _
                             "ORDER BY SponsorNames ")
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New CartaPadrino
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PadrinoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PadrinoV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And Len(PadrinoV.Text) > 0 Then
            infoSponsor()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PrintDocumentBoleta_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentBoleta.PrintPage
        Dim letra As String = "Arial"
        Dim normalL As New Font(letra, 14, FontStyle.Regular)
        Dim tituloL As New Font(letra, 14, FontStyle.Bold)
        Dim centrado As New StringFormat
        Dim izq As New StringFormat
        Dim xPos, yPos, tab, intervalo As Integer

        centrado.Alignment = StringAlignment.Center
        izq.Alignment = StringAlignment.Near
        xPos = 20
        yPos = 40
        tab = 150
        intervalo = 25 '30

        'Dim rectTit As New Rectangle(xPos, yPos, 850, 18)
        'e.Graphics.DrawString("Add Sponsor to Member Letters (" + PadrinoV.Text + ")", tituloL, Brushes.Black, rectTit, centrado)

        Dim alto, extra As String
        alto = intervalo
        extra = 0
        For fila = 0 To pImprimirGrid.RowCount - 1
            yPos = yPos + intervalo + extra
            e.Graphics.DrawString(pImprimirGrid.Item(0, fila).Value(), normalL, Brushes.Black, xPos, yPos)

            If Len(pImprimirGrid.Item(1, fila).Value()) > 65 Then
                alto = alto * 2
                extra = intervalo
            Else
                extra = 0
            End If

            Dim rectDetalle As New Rectangle(xPos + tab, yPos, 850 - tab, alto)
            e.Graphics.DrawString(pImprimirGrid.Item(1, fila).Value(), normalL, Brushes.Black, rectDetalle, izq)
            'e.Graphics.DrawString(pImprimirGrid.Item(1, fila).Value(), normalL, Brushes.Black, xPos + tab, yPos)
        Next

    End Sub

    Private Sub llenarImprimirGrid(ByVal sitio As String, ByVal numeroApadrinado As String, ByVal apadrinado As String, ByVal direccion As String, _
                                                      ByVal area As String, ByVal ts As String, ByVal grado As String)
        Dim a() As String
        a = {"No. Padrino: ", PadrinoV.Text}
        pImprimirGrid.Rows.Add(a)
        a = {"Padrino: ", NombreSV.Text}
        pImprimirGrid.Rows.Add(a)
        a = {"No. Afiliación: ", sitio & numeroApadrinado}
        pImprimirGrid.Rows.Add(a)
        a = {"Apadrinado: ", apadrinado}
        pImprimirGrid.Rows.Add(a)
        a = {"Dirección: ", direccion}
        pImprimirGrid.Rows.Add(a)
        a = {"Area: ", area}
        pImprimirGrid.Rows.Add(a)
        a = {"TS: ", ts}
        pImprimirGrid.Rows.Add(a)
        a = {"Grado: ", grado}
        pImprimirGrid.Rows.Add(a)
        a = {"Inicia", U & " (" & Format(FechaEnvioPicker.Value, "MMM d yyyy") & ")"} '"dddd, MMM d yyyy"
        pImprimirGrid.Rows.Add(a)
        a = {"", ""}
        pImprimirGrid.Rows.Add(a)
        a = {"Traductor", "__________________________________________ (nombre y fecha)"}
        pImprimirGrid.Rows.Add(a)
        a = {"Hay Foto", "( si / no )"}
        pImprimirGrid.Rows.Add(a)
        a = {"", ""}
        pImprimirGrid.Rows.Add(a)
        a = {"", ""}
        pImprimirGrid.Rows.Add(a)
        a = {"", ""}
        pImprimirGrid.Rows.Add(a)
    End Sub

    Private Sub imprimeBoletas()
        'fecha = bdPalabra("SELECT CONVERT(varchar, GETDATE(), 107)  'Fecha' ", "Fecha")
        pImprimirGrid.DataSource = Nothing
        pImprimirGrid.Rows.Clear()

        For fila = 0 To ListaGrid.RowCount - 1
            If ListaGrid.Item(0, fila).Value() = True Then
                llenarImprimirGrid(ListaGrid.Item(1, fila).Value().ToString, ListaGrid.Item(2, fila).Value().ToString, ListaGrid.Item(3, fila).Value().ToString, ListaGrid.Item(4, fila).Value().ToString, _
                              ListaGrid.Item(5, fila).Value().ToString, ListaGrid.Item(6, fila).Value().ToString, ListaGrid.Item(7, fila).Value().ToString)
            End If
        Next

        imprimirBoleta()
    End Sub

End Class