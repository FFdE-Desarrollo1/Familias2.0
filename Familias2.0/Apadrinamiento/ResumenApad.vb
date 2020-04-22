' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ResumenApad
    Dim ahora As DateTime = DateTime.Now
    Dim g As System.Drawing.Graphics = Me.CreateGraphics
    Dim fotoDire, fotoF, cartaF, carnF, regaloF, ts, reg, idSpon, nomSpon, inic, fin, espa, gen, hablaEs, tipo, grado, fase, categoria As String
    Private imgOriginal As Image
    Dim nDias As String = 365
    Dim largoL As Integer = 20
    Dim listTable As New DataTable

    Private Sub ResumenApad_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(MiembroV.Text) > 0 Then
            valoresIniciales()
        End If
        MiembroV.Focus()
    End Sub

    Private Sub avisosFamiliares()
        Dim avisoLargo As String = ""
        limpiarHistorialGrid(AvisosGrid)
        sql = "SELECT Aviso FROM dbo.fn_WARN_avisosES('" + S + "', " + FamiliaV.Text + ") "
        bdGrid(sql, AvisosGrid)
        avisoLargo = textoMasLargoEnFilasGrid(AvisosGrid, 0)
        AvisosGrid.Height = (AvisosGrid.RowCount + 1) * largoL
        AvisosGrid.Width = g.MeasureString(avisoLargo, AvisosGrid.Font).Width + 10
        AvisosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        AvisosGrid.AutoResizeColumns()
        AvisosGrid.Visible = True
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fotoMiembro()
        Try
            If Len(fotoDire) > 0 Then
                fotoDire = fotoDire.Remove(0, 3)
            End If
            fotoDire = "\\" + My.Resources.svr + "\FamilyFotos\" + fotoDire
            imgOriginal = Image.FromFile(fotoDire)
        Catch ex As Exception
            imgOriginal = My.Resources.Resources.CH_Heart
        Finally
        End Try
        ApadrinadoPic.Image = imgOriginal
        ApadrinadoPic.SizeMode = PictureBoxSizeMode.StretchImage
        ApadrinadoPic.Size = New Point(200, 220)
        ApadrinadoPic.Visible = True
    End Sub

    Private Sub guardarCarta(ByVal padrino As String)
        'Project, SponsorId, MemberId, SponsorOrMember, DateTimeWritten, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, DateSent,
        'Category, Notes, Translated, ReceivedInGuatemala
        sql = "INSERT INTO dbo.MemberSponsorLetter VALUES('" + S + "', " + padrino + ", " + MiembroV.Text + ", 'M', '" + FechaCartaV.Value.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, NULL, " + _
                 "'" + CategoriaCombo.SelectedValue + "', '" + conversionValorTextBox(NotasCartaV.Text) + "', NULL, NULL)"
        bdInsertar(sql)
    End Sub

    Private Sub GuardarCartaButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GuardarCartaButton.Click
        Dim isCheck As New CheckBox
        If verificaCarta() = True Then
            For Each r As DataGridViewRow In ActivosGrid.Rows
                isCheck.Checked = ActivosGrid.Item(0, r.Index).Value()
                If isCheck.Checked = True Then
                    guardarCarta(ActivosGrid.Item(1, r.Index).Value())
                End If
            Next
            ultimasFechas()
            avisosFamiliares()
            limpiarCartaApadrinado()
            HistorialCartasCheck.Checked = True
            historialCartas()
        End If
    End Sub

    Private Sub GuardarRegaloButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GuardarRegaloButton.Click
        If verificaRegalo() = True Then
            Dim tipoSel As String
            If Len(TipoRegCombo.SelectedValue) > 0 Then
                tipoSel = "'" + TipoRegCombo.SelectedValue + "'"
            Else
                tipoSel = "NULL"
            End If
            'Project, MemberId, Category, SelectionDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Type, Notes, DeliveryDateTime,SizeGift
            sql = "INSERT INTO dbo.MemberGift VALUES('" + S + "', " + MiembroV.Text + ", '" + CategoriaRegCombo.SelectedValue + "','" + _
                     SeleccionV.Value.ToString(en.DateTimeFormat) + "', GETDATE(), ' ', '" + U + "', NULL, " + tipoSel + ",'" + conversionValorTextBox(NotasRegV.Text) + "', NULL, NULL)"
            bdInsertar(sql)
            ultimasFechas()
            avisosFamiliares()
            limpiarRegalo()
            HistorialRegCheck.Checked = True
            historialRegalos()
        End If
    End Sub

    Private Sub historialCartas()
        limpiarHistorialGrid(HistorialGrid)
        sql = "SELECT  dbo.fn_GEN_FormatDate(MSL.DateTimeWritten, 'es') AS Escrita, S.SponsorNames,  " + _
                 "dbo.fn_GEN_FormatDate(MSL.DateSent, 'es') AS Envio, cdC." + descripcion() + "  '" + categoria + "', MSL.Notes, MSL.UserId AS Usuario " + _
                 "FROM dbo.MemberSponsorLetter MSL INNER JOIN dbo.Sponsor S ON MSL.SponsorId = S.SponsorId AND MSL.RecordStatus = S.RecordStatus " + _
                 "LEFT OUTER JOIN dbo.CdLetterCategory cdC ON cdC.Code = MSL.Category " + _
                 "WHERE MSL.RecordStatus = ' ' AND MSL.Project = '" + S + "' AND MSL.MemberId = " + MiembroV.Text + " AND MSL.SponsorOrMember = 'M' " + _
                 "AND DATEDIFF(d, MSL.DateTimeWritten, GETDATE()) <=  " + nDias.ToString + " " + _
                 "ORDER BY MSL.DateTimeWritten DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialCartasCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles HistorialCartasCheck.CheckedChanged
        If HistorialCartasCheck.Checked = True Then
            HistorialRegCheck.Checked = False
            InfoGenCheck.Checked = False
            historialCartas()
        Else
            limpiarHistorialGrid(HistorialGrid)
        End If
    End Sub

    Private Sub historialRegalos()
        limpiarHistorialGrid(HistorialGrid)
        sql = "SELECT  dbo.fn_GEN_FormatDate(MG.SelectionDateTime, 'es') AS Selección, dbo.fn_GEN_FormatDate(MG.DeliveryDateTime, 'es') " + _
                 "AS Entrega, cdGC." + descripcion() + " '" + categoria + "', cdGT." + descripcion() + " '" + tipo + "', MG.Notes AS Notas, MG.UserId AS Usuario " + _
                 "FROM dbo.MemberGift MG INNER JOIN dbo.CdGiftCategory cdGC ON MG.Project = cdGC.Project AND MG.Category = cdGC.Code " + _
                 "LEFT OUTER JOIN dbo.CdGiftType cdGT ON MG.Project = cdGT.Project AND MG.Type = cdGT.Code " + _
                 "WHERE MG.RecordStatus = ' ' AND MG.Project = '" + S + "' AND MG.MemberId = " + MiembroV.Text + _
                 " AND DATEDIFF(d, MG.SelectionDateTime, GETDATE()) <= " + nDias.ToString + " " + _
                 "ORDER BY MG.SelectionDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialRegCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles HistorialRegCheck.CheckedChanged
        If HistorialRegCheck.Checked = True Then
            HistorialCartasCheck.Checked = False
            InfoGenCheck.Checked = False
            historialRegalos()
        Else
            limpiarHistorialGrid(HistorialGrid)
        End If
    End Sub

    Private Sub infoGen()
        limpiarHistorialGrid(HistorialGrid)
        Dim col As New DataGridViewTextBoxColumn
        col.HeaderText = "Categoria"
        HistorialGrid.Columns.Add(col)

        Dim col2 As New DataGridViewTextBoxColumn
        col2.HeaderText = "Descripción"
        HistorialGrid.Columns.Add(col2)

        llenarGrid(grado, chequearValor(listTable.Rows(0)("estado_Educ")) + " " + chequearValor(listTable.Rows(0)("grado")), HistorialGrid)
        llenarGrid(fase, chequearValor(listTable.Rows(0)("Fase")), HistorialGrid)
        llenarGrid(ts, chequearValor(listTable.Rows(0)("TS")), HistorialGrid)
        llenarGrid(reg, chequearValor(listTable.Rows(0)("Region")), HistorialGrid)
        llenarGrid("Pueblo", chequearValor(listTable.Rows(0)("Pueblo")), HistorialGrid)

        'InfoGenGrid.Width = g.MeasureString(textoMasLargoEnFilasGrid(InfoGenGrid, 0), InfoGenGrid.Font).Width + g.MeasureString(textoMasLargoEnFilasGrid(InfoGenGrid, 1), InfoGenGrid.Font).Width
        'InfoGenGrid.Height = (InfoGenGrid.RowCount + 1) * largoL + 15
        HistorialGrid.ClearSelection()
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub inicioButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "RIAM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarCartaApadrinado()
        FechaCartaV.Value = Today
        CategoriaCombo.SelectedIndex = -1
        NotasCartaV.Text = ""
        ActivosGrid.DataSource = Nothing
        ActivosGrid.Rows.Clear()
        NuevaCartaCheck.Checked = False
    End Sub

    Private Sub limpiarHistorialGrid(ByRef grid As DataGridView)
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        grid.DataSource = Nothing
        grid.Rows.Clear()
        grid.Columns.Clear()
        grid.Visible = False
    End Sub

    Private Sub limpiarRegalo()
        SeleccionV.Value = Today
        CategoriaRegCombo.SelectedIndex = -1
        TipoRegCombo.SelectedIndex = -1
        NotasRegV.Text = ""
        NuevoRegaloCheck.Checked = False
    End Sub

    Private Sub llenarGrid(ByVal etiqueta As String, ByVal fecha As String, ByRef grid As DataGridView)
        Dim a() As String = {etiqueta, fecha}
        grid.Rows.Add(a)
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If esApadrinado(S, MiembroV.Text) = True Or esDesafiliado(S, MiembroV.Text) = True Or esGraduado(S, MiembroV.Text) = True Then
                valoresIniciales()
            Else
                MsgBox("Para realizar esta transacción el miembro necesita ser un afiliado, desafiliado o graduado.", vbCritical, My.Resources.versionFamilias2)
                MiembroV.Text = ""
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevaCartaCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NuevaCartaCheck.CheckedChanged
        If NuevaCartaCheck.Checked = True Then
            'Categorias de cartas
            sql = "SELECT Code, " + descripcion() + " Descripcion FROM CdLetterCategory WHERE Active = 1 "
            bdCombo(sql, CategoriaCombo, "Code", "Descripcion")
            If Now.Month <= 6 Then
                CategoriaCombo.SelectedValue = "PRIM"
            Else
                CategoriaCombo.SelectedValue = "SEGU"
            End If
            CategoriaCombo.Focus()

            'Padrinos Activos
            ActivosGrid.DataSource = Nothing
            ActivosGrid.Rows.Clear()
            sql = "SELECT S.SponsorId '" + idSpon + "', S.SponsorNames '" + nomSpon + "' FROM dbo.SponsorMemberRelation SMR INNER JOIN dbo.Sponsor S ON SMR.SponsorId = S.SponsorId AND SMR.RecordStatus = S.RecordStatus " + _
                     "WHERE SMR.RecordStatus = ' ' AND SMR.Project = '" + S + "' AND SMR.MemberId = " + MiembroV.Text + " AND SMR.EndDate IS NULL "
            bdGrid(sql, ActivosGrid)
            If ActivosGrid.RowCount > 0 Then
                ActivosGrid.Columns(1).ReadOnly = True
                ActivosGrid.Columns(2).ReadOnly = True
                If ActivosGrid.RowCount = 1 Then
                    ActivosGrid.Item(0, 0).Value() = True
                End If
                NuevaCartaPanel.Width = 430
                NuevaCartaPanel.Visible = True
            Else
                MsgBox("No tiene padrinos activos.", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
                NuevaCartaCheck.Checked = False
            End If
        Else
            NuevaCartaPanel.Visible = False
            HistorialGrid.Visible = False
            limpiarCartaApadrinado()
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ResumenApad
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoRegaloCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NuevoRegaloCheck.CheckedChanged
        If NuevoRegaloCheck.Checked = True Then
            'Categorias de regalos
            sql = "SELECT Code, " + descripcion() + " Descripcion FROM CdGiftCategory WHERE Active = 1 AND Project = '" + S + "' ORDER BY " + descripcion() + " "
            bdCombo(sql, CategoriaRegCombo, "Code", "Descripcion")
            CategoriaRegCombo.Focus()

            'Tipo de regalos
            sql = "SELECT Code, " + descripcion() + " Descripcion FROM CdGiftType WHERE Active = 1 AND Project = '" + S + "' ORDER BY " + descripcion() + " "
            bdCombo(sql, TipoRegCombo, "Code", "Descripcion")

            NuevoRegaloPanel.Width = 398
            NuevoRegaloPanel.Visible = True
        Else
            NuevoRegaloPanel.Visible = False
            HistorialGrid.Visible = False
            limpiarRegalo()
        End If
    End Sub

    Private Sub padrinos()
        PadrinosGrid.DataSource = Nothing
        PadrinosGrid.Rows.Clear()
        sql = "SELECT S.SponsorId, S.SponsorNames, dbo.fn_GEN_FormatDate(SMR.StartDate, 'en') AS Inicio, dbo.fn_GEN_FormatDate(SMR.EndDate, 'en') AS Fin, " + _
                 "cdSMRT." + descripcion() + ", dbo.CdGender." + descripcion() + " , CASE WHEN S.SpeaksSpanish = 1 THEN '" + espa + "' ELSE 'No' END sSpanish  " + _
                 "FROM dbo.SponsorMemberRelation SMR INNER JOIN dbo.Sponsor S ON SMR.SponsorId = S.SponsorId AND SMR.RecordStatus = S.RecordStatus " + _
                 "INNER JOIN dbo.CdSponsorMemberRelationType cdSMRT ON SMR.Type = cdSMRT.Code " + _
                 "INNER JOIN dbo.CdGender ON S.Gender = dbo.CdGender.Code " + _
                 "WHERE SMR.RecordStatus = ' ' AND SMR.Project = '" + S + "' AND SMR.MemberId = " + MiembroV.Text + "  " + _
                 "ORDER BY SMR.EndDate  "
        bdGrid(sql, PadrinosGrid)
        PadrinosGrid.Columns(0).HeaderText = idSpon
        PadrinosGrid.Columns(1).HeaderText = nomSpon
        PadrinosGrid.Columns(2).HeaderText = inic
        PadrinosGrid.Columns(3).HeaderText = fin
        PadrinosGrid.Columns(4).HeaderText = tipo
        PadrinosGrid.Columns(5).HeaderText = gen
        PadrinosGrid.Columns(6).HeaderText = hablaEs

        If PadrinosGrid.RowCount > 1 Then
            PadrinosGrid.Height = PadrinosGrid.Height + 30
        End If
        'PadrinosGrid.Height = (PadrinosGrid.RowCount + 1) * 25
        PadrinosGrid.ClearSelection()
        PadrinosGrid.CurrentCell = Nothing
    End Sub

    Private Sub traducir()
        Dim tr As New recursosFamilias
        carnF = tr.traduce("CarnetPrinted")
        cartaF = tr.traduce("LetterWritten")
        categoria = tr.traduce("Category")
        fin = tr.traduce("EndDate")
        fotoF = tr.traduce("PhotoDate")
        espa = tr.traduce("Yes")
        fase = tr.traduce("Disaffiliation")
        gen = tr.traduce("Gender")
        grado = tr.traduce("Grade")
        hablaEs = tr.traduce("SpeaksSpanish")
        idSpon = tr.traduce("Sponsor")
        inic = tr.traduce("StartDate")
        nomSpon = tr.traduce("SponsorNames")
        reg = tr.traduce("Region")
        regaloF = tr.traduce("BirthdayGift")
        tipo = tr.traduce("Type")
        ts = tr.traduce("SocialWorker")




    End Sub

    Private Sub ultimasFechas()
        UltimasFechasGrid.DataSource = Nothing
        UltimasFechasGrid.Rows.Clear()
        Dim listTable As New DataTable
        sql = "SELECT dbo.fn_GEN_FormatDate(SMR.PhotoDate, 'en') AS foto, dbo.fn_GEN_FormatDate(SMR.LastCarnetPrintDate, 'en') AS Carné, " + _
                 "cdR.DescSpanish AS Restriccion, cdST.DescSpanish AS SponTipo " + _
                 "FROM dbo.MiscMemberSponsorInfo SMR LEFT OUTER JOIN dbo.CdSponsorMemberRelationType cdST ON SMR.SponsorshipType = cdST.Code " + _
                 "LEFT OUTER JOIN dbo.CdSponsorshipRestriction cdR ON SMR.Restriction = cdR.Code " + _
                 "WHERE SMR.RecordStatus = ' ' AND SMR.MemberId = " + MiembroV.Text + " AND SMR.Project = '" + S + "'"
        bdDataTable(sql, listTable)

        'foto
        llenarGrid(fotoF, chequearValor(listTable.Rows(0)("foto")), UltimasFechasGrid)

        'ultima carta
        sql = "SELECT   CASE WHEN MAX(DateTimeWritten) IS NULL THEN '' ELSE dbo.fn_GEN_FormatDate(MAX(DateTimeWritten), 'en') END AS Fecha FROM dbo.MemberSponsorLetter " + _
                 "WHERE RecordStatus = ' ' AND SponsorOrMember = 'M' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
        llenarGrid(cartaF, chequearValor(bdPalabra(sql, "Fecha")), UltimasFechasGrid)

        'carné
        llenarGrid(carnF, chequearValor(listTable.Rows(0)("Carné")), UltimasFechasGrid)

        'ultimo regalo
        sql = "SELECT  CASE WHEN MAX(SelectionDateTime) IS NULL THEN '' ELSE   dbo.fn_GEN_FormatDate(MAX(SelectionDateTime), 'en') END AS Fecha FROM dbo.MemberGift " + _
                "WHERE     (RecordStatus = ' ') AND (Category IN ('CUMM', 'CUMN', 'CUMP', 'CUMR')) AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
        llenarGrid(regaloF, chequearValor(bdPalabra(sql, "Fecha")), UltimasFechasGrid)
        UltimasFechasGrid.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

        UltimasFechasGrid.Height = (UltimasFechasGrid.RowCount + 1) * largoL
        UltimasFechasGrid.Width = 280
        UltimasFechasGrid.ClearSelection()
    End Sub

    Private Function validaCategoriaTipoReg() As Boolean
        If Len(CategoriaRegCombo.Text) > 0 Then
            sql = "SELECT  CONVERT(varchar, RequiresType) Resultado FROM  CdGiftCategory  WHERE " + descripcion() + " = '" + CategoriaRegCombo.Text + "'"
            If bdEntero(sql, "Resultado") = "1" Then
                If Len(TipoRegCombo.SelectedValue) = 0 Then
                    MsgBox("Necesita seleccionar el tipo del regalo.", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
                    validaCategoriaTipoReg = False
                Else
                    validaCategoriaTipoReg = True
                End If
            Else
                validaCategoriaTipoReg = True
            End If
        Else
            MsgBox("Necesita seleccionar la categoria del regalo.", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
            validaCategoriaTipoReg = False
        End If
    End Function

    Private Function validaPadrinos() As Boolean
        Dim n As Integer = 0
        For f = 0 To ActivosGrid.RowCount - 1
            If ActivosGrid.Item(0, f).Value() = True Then
                n += 1
            End If
        Next

        If n > 0 Then
            validaPadrinos = True
        Else
            validaPadrinos = False
            MsgBox("Necesita seleccionar por lo menos 1 padrino.", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
        End If
    End Function

    Private Function validarFecha(ByVal fechaIn As DateTime) As Boolean
        Dim nowDate As DateTime = DateTime.Now
        Dim nDays As Integer = DateDiff(DateInterval.Day, Convert.ToDateTime(fechaIn.ToShortDateString), Convert.ToDateTime(nowDate.ToShortDateString))

        If nDays < 0 Then
            validarFecha = False
            MsgBox("La fecha no puede ser a futuro.", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
        Else
            validarFecha = True
        End If
    End Function

    Private Sub valoresIniciales()
        InfoGenGrid.DataSource = Nothing
        InfoGenGrid.Rows.Clear()

        sql = "SELECT Nombres, Apellidos, Familia, Nacimiento, grado,  estado_Educ, Semaforo, Fase, Region, Pueblo, Foto, TS, Restricción, TipoApadrinamiento " + _
                 "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + ahora.Year.ToString + ") L "
        bdDataTable(sql, listTable)

        If listTable.Rows.Count > 0 Then
            traducir()
            NombreV.Text = chequearValor(listTable.Rows(0)("Nombres")) + " " + chequearValor(listTable.Rows(0)("Apellidos"))
            NacimientoV.Text = chequearValor(listTable.Rows(0)("Nacimiento"))
            FamiliaV.Text = chequearValor(listTable.Rows(0)("Familia"))
            RestriccionV.Text = chequearValor(listTable.Rows(0)("Restricción"))
            TipoApadrinamientoV.Text = chequearValor(listTable.Rows(0)("TipoApadrinamiento"))

            fotoDire = chequearValor(listTable.Rows(0)("Foto"))
            TipoMiembroL.Text = tipo_Miembro(S, MiembroV.Text)



            ultimasFechas()
            padrinos()
            verfoto()
            avisosFamiliares()

            Dim largo As Integer = 0
            If AvisosGrid.RowCount > UltimasFechasGrid.RowCount Then
                largo = AvisosGrid.Height
            Else
                largo = UltimasFechasGrid.Height
            End If

            PanelSecundario.Height = PadrinosGrid.Height + 20 + largoL + largo
            PrincipalTable.RowStyles(0).Height = PanelSecundario.Height

            MiembroV.ReadOnly = True
            FamiliaV.ReadOnly = True
            infoGenTable.Visible = True
            PrincipalTable.Visible = True
        Else
            MsgBox("El miembro no existe", vbExclamation, My.Resources.versionFamilias2)
            MiembroV.Text = ""
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub verfoto()
        'sql = "SELECT CustomField1 D FROM dbo.FwEmployee WHERE EmployeeId = '" + U + "' AND (CustomField1 LIKE '%MemberInformationSummary.jsp?%') "
        'Dim resumen As String = bdPalabra(sql, "D")
        'Dim resultado As String = ""
        'If Len(resumen) > 0 Then
        '    If resumen = "sponsorship/MemberInformationSummary.jsp?ShowPhoto=YES" Then
        '        fotoMiembro()
        '    End If
        'End If
        fotoMiembro()
    End Sub

    Private Function verificaCarta() As Boolean
        If validarFecha(FechaCartaV.Text) = True And Len(CategoriaCombo.SelectedValue) > 0 And validaPadrinos() = True Then
            verificaCarta = True
        Else
            verificaCarta = False
            If Len(CategoriaCombo.SelectedValue) = 0 Then
                MsgBox("Necesita seleccionar la categoria de la carta.", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
            End If
        End If
    End Function

    Private Function verificaRegalo() As Boolean
        If validaCategoriaTipoReg() = True And validarFecha(SeleccionV.Value) = True Then
            verificaRegalo = True
        Else
            verificaRegalo = False
        End If
    End Function

    Private Sub InfoGenL_CheckedChanged(sender As Object, e As EventArgs) Handles InfoGenCheck.CheckedChanged
        If InfoGenCheck.Checked = True Then
            HistorialRegCheck.Checked = False
            HistorialCartasCheck.Checked = False
            infoGen()
        Else
            limpiarHistorialGrid(HistorialGrid)
        End If
    End Sub
End Class