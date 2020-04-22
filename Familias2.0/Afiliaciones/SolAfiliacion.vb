Public Class SolAfiliacion
    Dim op As String = ""
    Dim id, visitaD, grado, nivel, estadoAfilM, estadoAfilF As String
    Dim tip As String = ""
    Dim nSol As Integer = 0
    Dim tipoAfilOr, estadoAfilOr As String


    Private Sub SolAfiliacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()

        'If Len(MiembroV.Text) > 0 And op = "M" Then
        '    valoresIniciales()
        'End If
    End Sub

    Private Sub actualizarEstado()
        'MsgBox(Len(estadoAfilF).ToString)
        If Len(estadoAfilF) = 0 Then 'no tiene estado familiar
            actualizarEstadoFamiliar()
            sql = "SELECT cdS.DescSpanish Estado FROM Family F INNER JOIN cdAffiliationStatus cdS ON cdS.Code = F.AffiliationStatus  WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
            EstadoFamV.Text = "Estado afiliación familiar: " + bdPalabra(sql, "Estado")
            EstadoFamV.Visible = True
        End If
        'MsgBox(Len(estadoAfilM).ToString)
        If Len(estadoAfilM) = 0 Then 'no tiene estado miembro
            actualizarEstadoMiembro()
            sql = "SELECT cdS.DescSpanish Estado FROM Member M INNER JOIN cdAffiliationStatus cdS ON cdS.Code = M.AffiliationStatus  WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
            EstadoAfilMembV.Text = "Estado afiliación: " + bdPalabra(sql, "Estado")
            EstadoAfilMembV.Visible = True
        End If
    End Sub

    Private Sub actualizarEstadoFamiliar()
        sql = "INSERT INTO dbo.Family " + _
              "SELECT Project, FamilyId, GETDATE() CreationDateTime, RecordStatus, '" + U + "' UserId, ExpirationDateTime, 'F' AffiliationLevel, " + _
              "'AFIl' AffiliationStatus, GETDATE() AffiliationStatusDate, Area, Pueblo, Address, TelephoneNumber, Ethnicity, AffiliationLevelOverrideStartDate, " + _
              "AffiliationLevelOverrideEndDate, LastUpdateDate, Classification, ClassificationDate, Municipality, TimeOnPlace, NextClassification, RFaroNumber " + _
              "FROM dbo.Family WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        'InputBox("", "EstadoFamiliar", sql)
        bdInsertar(sql)
    End Sub

    Private Sub actualizarEstadoMiembro()
        sql = "INSERT INTO dbo.Member " + _
              "SELECT Project, MemberId, GETDATE() CreationDateTime, RecordStatus, '" + U + "' UserId, ExpirationDateTime, LastFamilyId, FirstNames, LastNames," + _
              "PreferredName, BirthDate, Gender, '" + TipoCombo.SelectedValue + "' AffiliationType, 'AFIL' AffiliationStatus, GETDATE() AffiliationStatusDate, " + _
              "LiveDead, DeathDate, BiologicalMotherMemberId, BiologicalFatherMemberId, OtherAffiliation, OfficialId, HasFaithOfAgeOrOfficialId, CellularPhoneNumber, " + _
              "Literacy, LastGradePassed, HasHealthCard, ExceptionInAgePolicy, LastGradePassedYear, LastGradePassedStatus " + _
              "FROM Member WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
        'InputBox("", "EstadoIndividual", sql)
        bdInsertar(sql)
    End Sub

    Private Sub actualizarSolicitud()
        Dim estadoSel As String
        If EstadoCombo.SelectedValue = "APRO" Then
            estadoSel = "Status"
        Else
            estadoSel = "'" + EstadoCombo.SelectedValue + "'"
        End If
        sql = "INSERT  dbo.MemberAffiliationSolicitude " + _
              "SELECT Project, MemberId, SolicitudeDate, GETDATE() CreationDateTime, RecordStatus, '" + U + "' UserId, ExpirationDateTime, " + _
              "'" + TipoCombo.SelectedValue + "' AffiliationType,  " + estadoSel + ", " + _
              "StatusDate, AttendedBy, " + visitaD + " VisitDate, Classification, Comments, RejectionReason1, Notes1, RejectionReason2, " + _
              "Notes2, RejectionReason3, Notes3, RejectionReason4, Notes4, MedicalExamDate, AffiliationMeetingDate, TourDate, PlanPPDate " + _
              "FROM dbo.MemberAffiliationSolicitude " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND " + _
              "CONVERT(varchar, SolicitudeDate) + '-' + CONVERT(varchar, CreationDateTime) = '" + id + "'"
        'InputBox("", "", sql)
        bdInsertar(sql)

        If EstadoCombo.Text = estadoAfilOr Then 'sin cambios en el estado
        Else
            If EstadoCombo.SelectedValue = "APRO" Then 'aprobada
                actualizarEstado()
            End If
        End If

        If TipoCombo.Text = tipoAfilOr Then 'sin cambios en el tipo afiliacion
        Else 'cambio en el tipo de afiliación
            sql = "UPDATE dbo.Member SET AffiliationType = '" + TipoCombo.SelectedValue + "' WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
            bdEjecutarSQL(sql)
        End If
        ' 
        historialSolicitudes()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            'If Len(FamiliaV.Text) > 0 Then
            miembrosFamilia()
            'End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If validaDatos() = True Then
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult

            GuardarButton.Visible = False
            If tip = "N" Then
                response = MsgBox("¿El tipo de afiliación es el correcto? ", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    If esApadrinado(S, MiembroV.Text) = False Then
                        nuevaSolicitud()

                        NoMiembro = 0

                    Else
                        MsgBox("No puede ingresar otra solicitud de afiliación a un apadrinado.", vbInformation, My.Resources.versionFamilias2)
                    End If
                End If
            ElseIf tip = "A" Then
                actualizarSolicitud()
                NoMiembro = 0
            End If
            GuardarButton.Visible = True
        End If
    End Sub

    Private Sub historialSolicitudes()
        op = "S"
        InfoGrid.DataSource = Nothing
        InfoGrid.Rows.Clear()
        InfoGrid.Visible = False
        sql = "SELECT CONVERT(varchar, S.SolicitudeDate) + '-' + CONVERT(varchar, S.CreationDateTime) AS ID,'Actualizar' AS '_', 'Borrar' '__', " + _
              "S.SolicitudeDate AS 'Fecha Solicitud', cdT.DescSpanish AS 'Tipo Afiliación', " + _
              "cdS.DescSpanish AS Estado, S.StatusDate AS ' Fecha Estado', S.VisitDate AS 'Fecha Visita',  " + _
              "S.UserId AS 'Ultimos Cambios' " + _
              "FROM dbo.MemberAffiliationSolicitude S " + _
              "INNER JOIN dbo.CdAffiliationSolicitudeStatus cdS ON S.Status = cdS.Code " + _
              "INNER JOIN dbo.CdAffiliationType cdT ON S.AffiliationType = cdT.Code " + _
              "WHERE S.RecordStatus = ' ' AND S.Project = '" + S + "' AND MemberId = " + MiembroV.Text
        'InputBox("", "", sql)
        bdGrid(sql, InfoGrid)
        nSol = InfoGrid.RowCount
        InfoGrid.Columns.Item(0).Visible = False 'idFechas
        InfoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        InfoGrid.Columns(1).CellTemplate.Style.ForeColor = Drawing.Color.Blue
        InfoGrid.Columns(2).CellTemplate.Style.ForeColor = Drawing.Color.Orange
        InfoGrid.Visible = True
    End Sub

    Private Sub InfoGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles InfoGrid.CellDoubleClick
        Dim columna, fila As Integer
        columna = InfoGrid.CurrentCellAddress.X
        fila = InfoGrid.CurrentCellAddress.Y

        'If esApadrinado(S, MiembroV.Text) = True Then
        '    EstadoCombo.Enabled = False
        'End If

        If op = "M" Then 'seleccionar miembro
            MiembroV.Text = InfoGrid.Item(0, fila).Value.ToString
            valoresIniciales()
        ElseIf op = "S" Then 'Actualizar solicitudes
            id = InfoGrid.Item(0, fila).Value.ToString
            If columna = 1 Then ' actualizar
                tip = "A"
                FechaPicker.Value = InfoGrid.Item(3, fila).Value
                tipoAfilOr = InfoGrid.Item(4, fila).Value
                TipoCombo.Text = tipoAfilOr
                estadoAfilOr = InfoGrid.Item(5, fila).Value
                EstadoCombo.Text = estadoAfilOr

                If Len(InfoGrid.Item(7, fila).Value.ToString) > 0 Then
                    VisitaV.Text = InfoGrid.Item(7, fila).Value
                End If
                VisitaV.Focus()
            ElseIf columna = 2 Then 'borrar

            Else

            End If
        Else
            MsgBox("Opción no válida.", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub miembrosFamilia()
        op = "M"
        InfoGrid.DataSource = Nothing
        InfoGrid.Rows.Clear()
        InfoGrid.Visible = False

        sql = "SELECT FMR.MemberId AS Miembro, M.FirstNames AS Nombres, M.LastNames AS Apellidos, dbo.fn_GEN_FormatDate(M.BirthDate, 'ES') AS Nacimiento, " + _
          "dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad, cdFMR.DescSpanish AS Relación_Familiar, cdAS.DescSpanish AS Estado_Afil, " + _
          "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro, HeadOfHouse " + _
          "FROM dbo.FamilyMemberRelation FMR INNER JOIN " + _
          "dbo.CdFamilyMemberRelationType cdFMR ON FMR.Type = cdFMR.Code INNER JOIN " + _
          "dbo.Member M ON FMR.Project = M.Project AND FMR.MemberId = M.MemberId AND FMR.RecordStatus = M.RecordStatus " + _
          "LEFT JOIN dbo.CdAffiliationStatus cdAS ON cdAS.Code = M.AffiliationStatus " + _
          "WHERE FMR.RecordStatus = ' ' AND FMR.Project = '" + S + "' AND FMR.FamilyId = " + FamiliaV.Text + " AND FMR.InactiveDate IS NULL " + _
          "ORDER BY cdFMR.DisplayOrder "
        bdGrid(sql, InfoGrid)
        InfoGrid.Columns.Item(8).Visible = False 'es jefe
        InfoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        InfoGrid.Visible = True

    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            'If Len(FamiliaV.Text) > 0 Then
            valoresIniciales()
            'End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub nuevaSolicitud()
        sql = "INSERT INTO dbo.MemberAffiliationSolicitude VALUES ('" + S + "', " + MiembroV.Text + ", '" + FechaPicker.Value.ToString(en.DateTimeFormat) + _
              "', GETDATE(), ' ', '" + U + "', NULL, '" + TipoCombo.SelectedValue + "', '" + EstadoCombo.SelectedValue + "', '" + FechaPicker.Value.ToString(en.DateTimeFormat) + _
              "', '" + U + "', " + visitaD + ",NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)"
        'InputBox("", "Solicitud", sql)
        bdInsertar(sql)
        If EstadoCombo.SelectedValue = "APRO" Then
            actualizarEstado()
            registroMiscMember()
        End If

        historialSolicitudes()

    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        NoMiembro = 0
        Dim nxt As New SolAfiliacion
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub registroMiscMember()
        sql = "INSERT INTO MiscMemberSponsorInfo VALUES ('" + S + "', " + MiembroV.Text + ", GETDATE(), ' ', '" + U + "', " + _
              "NULL,NULL,NULL,NULL,NULL,NULL,'NING','NING',NULL,NULL,NULL)"
        InputBox("", "Solicitud", sql)
        bdInsertar(sql)
    End Sub

    Private Function tieneSolicitudAprobada() As Boolean
        sql = "SELECT COUNT(*) T FROM dbo.MemberAffiliationSolicitude " + _
            "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND Status = 'APRO' "
        If bdEntero(sql, "T") = 0 Then
            tieneSolicitudAprobada = False
        Else
            tieneSolicitudAprobada = True
        End If


    End Function

    Private Function validaDatos() As Boolean
        If TipoCombo.SelectedIndex = -1 Or EstadoCombo.SelectedIndex = -1 Then
            MsgBox("Necesita seleccionar un valor en:" + vbLf + vbLf + "Tipo de Afiliación" + vbLf + "Estado", vbInformation, My.Resources.versionFamilias2)
            validaDatos = False
        Else
            'InputBox("", "", VisitaV.Text)
            If VisitaV.Text = "00/00/0000" Or VisitaV.Text = "  /  /" Then
                visitaD = "NULL"
                validaDatos = True
            Else
                Dim dt As DateTime
                If Not DateTime.TryParse(VisitaV.Text, dt) Then
                    MsgBox(VisitaV.Text & " no es válida" + vbLf + "día/mes/año", vbInformation, My.Resources.versionFamilias2)
                    validaDatos = False
                Else
                    visitaD = "'" + dt.ToString(en.DateTimeFormat) + "'"
                    validaDatos = True
                End If
            End If
        End If
    End Function

    Private Sub valoresIniciales()
        InfoGrid.Visible = False

        Dim listTable As New DataTable
        Table1.Visible = True

        sql = "SELECT Code, descSpanish Descripcion FROM dbo.CdAffiliationType WHERE ValidValue = 1 "
        bdCombo(sql, TipoCombo, "Code", "Descripcion")

        sql = "SELECT Code, descSpanish Descripcion FROM   dbo.CdAffiliationSolicitudeStatus "
        bdCombo(sql, EstadoCombo, "Code", "Descripcion")

        FechaPicker.Value = Today
        FechaPicker.Enabled = False

        ''vacia la fecha de visita
        'VisitaPicker.Format = DateTimePickerFormat.Custom
        'VisitaPicker.CustomFormat = " "

        VisitaV.Mask = "00/00/0000" ' String.Format("{0:dd/MM/yyyy}", DateTime.Now)



        'información general
        sql = "SELECT M.FirstNames + ' ' + M.LastNames AS Nombre, M.LastFamilyId AS Familia, cdG.DescSpanish Grado, CdG2.EducationLevel Nivel, " + _
              "cdAM.DescSpanish AfilM, cdAF.DescSpanish AfilF " + _
              "FROM Member M INNER JOIN Family F ON M.RecordStatus = F.RecordStatus AND M.Project = F.Project AND M.LastFamilyId = F.FamilyID " + _
              "LEFT JOIN cdGrade cdG ON cdG.Code = M.LastGradePassed LEFT OUTER JOIN dbo.CdGrade CdG2 ON cdG.NextGrade = CdG2.Code " + _
              "LEFT JOIN cdAffiliationStatus cdAM ON cdAM.Code = M.AffiliationStatus " + _
              "LEFT JOIN cdAffiliationStatus cdAF ON cdAF.Code = F.AffiliationStatus " + _
              "WHERE M.RecordStatus = ' '  AND M.Project = '" + S + "' AND M.MemberId = " + MiembroV.Text
        bdDataTable(sql, listTable)
        If listTable.Rows.Count > 0 Then
            NombreV.Text = listTable.Rows(0)("Nombre")
            FamiliaV.Text = listTable.Rows(0)("Familia")
            grado = chequearValor(listTable.Rows(0)("Grado"))
            nivel = chequearValor(listTable.Rows(0)("Nivel"))
            estadoAfilM = chequearValor(listTable.Rows(0)("AfilM"))
            estadoAfilF = chequearValor(listTable.Rows(0)("AfilF"))


            historialSolicitudes()

            If Len(grado) > 0 Then
                NombreV.Text = NombreV.Text + " (" + grado + ")"
                If nSol = 0 Then
                    If Len(nivel) > 0 Then
                        If nivel = "BASI" Or nivel = "DIVE" Or nivel = "VOCA" Then
                            TipoCombo.SelectedValue = "BECA"
                        Else
                            TipoCombo.SelectedValue = "NORM"
                        End If
                    End If
                Else
                    TipoCombo.SelectedIndex = -1
                End If
            End If

            tip = "N"
            FamiliaV.ReadOnly = True
            MiembroV.ReadOnly = True
            GuardarButton.Visible = True
        End If
    End Sub

    ''Private Sub VisitaPicker_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles VisitaPicker.MouseHover
    ''    Dim dateTimePicker As DateTimePicker = CType(sender, DateTimePicker)
    ''    If VisitaPicker.Text = "  " Then
    ''        VisitaPicker.Text = Format(DateTime.Now, "dd/MM/yyyy")
    ''    End If
    ''End Sub

    ''Private Sub VisitaPicker_ValueChanged(sender As Object, e As EventArgs) Handles VisitaPicker.ValueChanged
    ''    VisitaPicker.Format = DateTimePickerFormat.Short
    ''End Sub

    ''Private Sub validaMiembro(ByVal miembroSel As String)

    ''    valoresIniciales()

    ''    If esApadrinado(S, miembroSel) = True Then
    ''        EstadoCombo.Enabled = False
    ''        '    MsgBox("No puede ingresar otra solicitud de afiliación a un apadrinado.", vbInformation, My.Resources.versionFamilias2)
    ''        '    
    ''    Else
    ''        '    MiembroV.Text = miembroSel
    ''        '    valoresIniciales()
    ''    End If



    ''End Sub

End Class