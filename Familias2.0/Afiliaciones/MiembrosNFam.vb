Public Class MiembrosNFam
    Dim existeMiembro As Boolean = False
    Dim existeOcupacion As Boolean = False
    Dim piv As Integer = 0
    Dim lee As String = "NULL"
    Dim nivel As String = "NULL"
    Dim estadoEduc As String
    Dim tieneJefe As Boolean = False

    Private Sub MiembrosNFam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(FamiliaV.Text) = 0 Then 'no hay familia seleccionada
            'valoresIniciales()
            FamiliaV.Focus()
        Else
            FamiliaV.ReadOnly = True
            infoMTable.Focus()
            valoresIniciales()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub datosMiembroExistente()
        MiembroV.ReadOnly = True
        Dim listTable As New DataTable
        sql = "SELECT FirstNames Nombres, LastNames Apellidos, birthDate Nac, Gender, LastGradePassed gr, OfficialId dpi, R.Type Tipo " + _
              "FROM Member M INNER JOIN FamilyMemberRelation R ON M.Project = R.Project AND M.MemberId = R.MemberId " + _
              "AND M.RecordStatus = R.RecordStatus AND M.LastFamilyId = R.FamilyId AND R.InactiveDate IS NULL " + _
              "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND M.MemberId = " + MiembroV.Text
        'InputBox("", "", sql)
        bdDataTable(sql, listTable)
        If listTable.Rows.Count > 0 Then
            NombresV.Text = chequearValor(listTable.Rows(0)("Nombres"))
            ApellidosV.Text = chequearValor(listTable.Rows(0)("Apellidos"))
            NacimientoPicker.Value = listTable.Rows(0)("Nac")
            GeneroCombo.SelectedValue = chequearValor(listTable.Rows(0)("Gender"))
            NivelAcCombo.SelectedValue = chequearValor(listTable.Rows(0)("gr"))
            DPIv.Text = chequearValor(listTable.Rows(0)("dpi"))
            RelacionCombo.SelectedValue = " " 'chequearValor(listTable.Rows(0)("Tipo"))
            ocupacionExistente()
            existeMiembro = True
        End If
    End Sub

    Private Sub dpiV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DPIv.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub existeMiembroCheck_CheckedChanged(sender As Object, e As EventArgs) Handles existeMiembroCheck.CheckedChanged
        If existeMiembroCheck.Checked = True Then
            MiembroV.Visible = True
            MiembroL.Visible = True
            MiembroV.ReadOnly = False
            MiembroV.Focus()
        Else
            MiembroV.Visible = False
            MiembroL.Visible = False
            limpiarCampos()
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            FamiliaV.ReadOnly = True
            infoMTable.Focus()
            valoresIniciales()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GeneroCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GeneroCombo.SelectedIndexChanged
        If piv > 0 And GeneroCombo.SelectedIndex > -1 Then
            llenarRelCombo()
        End If
    End Sub

    Private Sub GuardarMiembroButton_Click(sender As Object, e As EventArgs) Handles GuardarMiembroButton.Click
        If validarDatosMiembro() = True And validarDatosOcupacion() = True And validaRelacionFam() = True Then

            If NivelAcCombo.SelectedIndex > -1 Then
                lee = "'SI'"
                nivel = "'" + NivelAcCombo.SelectedValue + "'"
            End If

            If EstadoEducCombo.SelectedIndex > -1 Then
                estadoEduc = "'" + EstadoEducCombo.SelectedValue + "'"
            Else
                estadoEduc = "NULL"
            End If

            If existeMiembro = True Then
                guardarMiembroExistente()
            Else
                guardarMiembroNuevo()
            End If


        End If
    End Sub

    Private Sub guardarMiembroExistente()
        sql = "INSERT INTO Member " + _
              "SELECT '" + S + "', " + MiembroV.Text + ", GETDATE(), ' ', '" + U + "', NULL, " + FamiliaV.Text + ", '" + Replace(NombresV.Text, "'", "''") + _
              "','" + Replace(ApellidosV.Text, "'", "''") + "', PreferredName, '" + NacimientoPicker.Value.ToString(en.DateTimeFormat) + "', '" + GeneroCombo.SelectedValue + _
              "', AffiliationType, AffiliationStatus, AffiliationStatusDate, LiveDead, DeathDate, BiologicalMotherMemberId, BiologicalFatherMemberId, " + _
              "OtherAffiliation, '" + DPIv.Text + "', HasFaithOfAgeOrOfficialId, CellularPhoneNumber, " + lee + "," + nivel + ", HasHealthCard,  " + _
                      "ExceptionInAgePolicy, LastGradePassedYear, " + estadoEduc + " " + _
              "FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "'  AND MemberId = " + MiembroV.Text + " "
        'InputBox("", "", sql)
        bdInsertar(sql)

        sql = "SELECT COUNT(*) T FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "'  AND MemberId = " + MiembroV.Text + " "
        If bdEntero(sql, "T") > 0 Then
            GuardarMiembroButton.Visible = False
            guardarMiembroRelacion()
            guardarOcupacion()
            listadoMiembros()
            limpiarCampos()
        End If

    End Sub

    Private Sub guardarMiembroNuevo()
        MiembroV.Text = idNuevoMiembro().ToString
        If Len(MiembroV.Text) > 0 Then

            'MiembroV.Visible = True
            sql = "INSERT INTO Member VALUES('" + S + "', " + MiembroV.Text + ", GETDATE(), ' ', '" + U + "', NULL, " + FamiliaV.Text + ", '" + Replace(NombresV.Text, "'", "''") + _
                    "','" + Replace(ApellidosV.Text, "'", "''") + "', '', '" + NacimientoPicker.Value.ToString(en.DateTimeFormat) + "', '" + GeneroCombo.SelectedValue + _
                    "', NULL, NULL, NULL, 'V', NULL, NULL, NULL, NULL, '" + DPIv.Text + "', 0, NULL, " + lee + "," + nivel + ", NULL, NULL, NULL, " + estadoEduc + ") "
            'InputBox("", "", sql)
            bdInsertar(sql)

            sql = "SELECT COUNT(*) T FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "'  AND MemberId = " + MiembroV.Text + " "
            If bdEntero(sql, "T") > 0 Then
                GuardarMiembroButton.Visible = False
                sql = "INSERT INTO MiscMemberInfo VALUES('" + S + "', " + MiembroV.Text + ", GETDATE(), ' ', '" + U + "', NULL,NULL,NULL,NULL,NULL,NULL)"
                bdInsertar(sql)

                guardarMiembroRelacion()
                guardarOcupacion()
                listadoMiembros()
                limpiarCampos()
            End If
        Else
            MsgBox("Hubo un problema al generar el nuevo número de miembro" + vbCrLf + "Intentelo de nuevo", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub guardarMiembroRelacion()
        If existeMiembro = True Then 'INACTIVAR RELACION ACTUAL
            sql = "UPDATE dbo.FamilyMemberRelation SET INACTIVEDATE = GETDATE(), InactiveReason = 'SEPR' " + _
                  "WHERE RecordStatus = ' ' AND MemberId = " + MiembroV.Text + " AND InactiveDate IS NULL AND Project = '" + S + "'"
            bdEjecutarSQL(sql)
            'InputBox("", "", sql)
        End If
        ''ingresar relacion actual
        sql = "INSERT INTO FamilyMemberRelation VALUES ('" + S + "'," + FamiliaV.Text + ", " + MiembroV.Text + ",'" + RelacionCombo.SelectedValue + _
              "', GETDATE(), GETDATE(), ' ', '" + U + "',NULL,NULL,NULL)"
        bdInsertar(sql)
        'InputBox("", "", sql)

        If RelacionCombo.SelectedValue = "JEFE" Or RelacionCombo.SelectedValue = "JEFM" Then
            tieneJefe = True
        End If

    End Sub

    Private Sub guardarOcupacion()
        If OcupacionCombo.SelectedIndex > -1 Then
            Dim igss As String = "0"

            If igssCheckBox.Checked = True Then
                igss = "1"
            End If

            Dim hrs As String = "NULL"
            If Len(HrsV.Text) > 0 Then
                hrs = HrsV.Text
            End If

            If existeOcupacion = True Then
                sql = "UPDATE MemberOccupation SET EndDate = GETDATE() " + _
                      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND EndDate IS NULL "
                'InputBox("", "", sql)
                bdInsertar(sql)
            End If


            sql = "INSERT INTO MemberOccupation VALUES ('" + S + "', " + MiembroV.Text + ", '" + OcupacionCombo.SelectedValue + "', GETDATE(), " + _
                  "'" + InicioPicker.Value.ToString(en.DateTimeFormat) + "', ' ', '" + U + "', NULL, NULL, " + hrs + ", NULL, " + _
                  QuetzalesV.Text + ", '" + JornadaCombo.SelectedValue + "', NULL, NULL, NULL, " + igss + ") "
            'InputBox("", "", sql)
            bdInsertar(sql)
        End If
    End Sub

    Private Sub HrsV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HrsV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function idNuevoMiembro() As Integer
        Dim miembro As Integer
        If S = "F" Then
            ''tabla temporal para emparejar el correlativo de IDs
            sql = "SELECT MIN(Id) ID FROM TEMPIDF WHERE Used = 0"
            miembro = bdEntero(sql, "ID")

            sql = "UPDATE TEMPIDF SET Used = 1 WHERE Id = " + miembro.ToString
            bdEjecutarSQL(sql)
        Else
            sql = "SELECT MAX(MemberId) Id FROM Member WHERE Project = '" + S + "' "
            miembro = bdEntero(sql, "Id") + 1
        End If
        idNuevoMiembro = miembro
    End Function

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listadoMiembros()
        MiembrosGrid.DataSource = Nothing
        MiembrosGrid.Rows.Clear()
        MiembrosGrid.Visible = False
        sql = "SELECT FMR.MemberId AS Miembro, M.FirstNames AS Nombres, M.LastNames AS Apellidos, M.Gender AS Género, " + _
              "dbo.fn_GEN_FormatDate(M.BirthDate, 'es') AS Nacimiento, dbo.fn_GEN_CalcularEdad(M.BirthDate) Edad, cdG.DescSpanish AS NivelAcad, M.OfficialId AS DPI, " + _
              "cdR.DescSpanish AS Relación, (SELECT COUNT(*) FROM dbo.MemberOccupation O " + _
              "WHERE FMR.Project = O.Project AND FMR.MemberId = O.MemberId AND FMR.RecordStatus = O.RecordStatus AND O.EndDate IS NULL) AS Ocupaciones " + _
              "FROM dbo.FamilyMemberRelation FMR INNER JOIN dbo.Member M ON FMR.Project = M.Project AND FMR.MemberId = M.MemberId " + _
              "AND FMR.FamilyId = M.LastFamilyId AND FMR.RecordStatus = M.RecordStatus INNER JOIN dbo.CdFamilyMemberRelationType cdR " + _
              "ON FMR.Type = cdR.Code LEFT OUTER JOIN dbo.CdGrade cdG ON M.LastGradePassed = cdG.Code " + _
              "WHERE FMR.RecordStatus = ' ' AND FMR.InactiveDate IS NULL AND FMR.Project = '" + S + "' AND FMR.FamilyId = " + FamiliaV.Text + " " + _
              "ORDER BY cdR.DisplayOrder "
        bdGrid(sql, MiembrosGrid)
        MiembrosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        MiembrosGrid.AutoResizeColumns()
        MiembrosGrid.Visible = True
        MiembrosL.Visible = True
    End Sub

    Private Sub llenarCombos()
        sql = "SELECT Code, DescSpanish DescS FROM dbo.CdGender WHERE Code not in ('D') "
        bdCombo(sql, GeneroCombo, "Code", "DescS")
        piv = 1

        sql = "SELECT Code, DescSpanish DescS FROM dbo.CdGrade " + _
              "WHERE ValidValue = 1 AND EducationLevel NOT IN ('CEIF', 'ESPC', 'ESTI') " + _
              "ORDER BY Orden "
        bdCombo(sql, NivelAcCombo, "Code", "DescS")

        sql = "SELECT Code, DescSpanish DescS FROM  dbo.CdOccupation "
        bdCombo(sql, OcupacionCombo, "Code", "DescS")

        sql = "SELECT Code, DescSpanish DescS  FROM CdEducationStatus WHERE CODE IN ('ESTU', 'REPI', 'GANO', 'PERD') "
        bdCombo(sql, EstadoEducCombo, "Code", "DescS")

        sql = "SELECT Code, DescSpanish DescS  FROM dbo.CdWorkDay "
        bdCombo(sql, JornadaCombo, "Code", "DescS")

        familiaTieneJefe()
        If tieneJefe = False Then
            MsgBox("La familia no tiene jefe de casa" + vbCrLf + "Necesita ingresarlo primero", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub familiaTieneJefe()
        sql = "SELECT count(*) T FROM FamilyMemberRelation WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + _
              " AND Type IN ('JEFE', 'JEFM') "
        If bdEntero(sql, "T") = 0 Then
            tieneJefe = False
        Else
            tieneJefe = True
        End If
    End Sub

    Private Sub limpiarCampos() '
        existeMiembroCheck.Checked = False
        existeMiembro = False
        MiembroV.Text = ""
        MiembroV.Visible = False
        NombresV.Text = ""
        'ApellidosV.Text = ""
        GeneroCombo.SelectedValue = -1
        NacimientoPicker.Value = Today
        NivelAcCombo.SelectedValue = -1
        EstadoEducCombo.SelectedValue = -1
        DPIv.Text = ""
        RelacionCombo.SelectedValue = -1
        OcupacionCombo.SelectedValue = -1
        InicioPicker.Value = Today
        JornadaCombo.SelectedValue = -1
        HrsV.Text = ""
        QuetzalesV.Text = ""
        igssCheckBox.Checked = False
        NombresV.Focus()
        GuardarMiembroButton.Visible = True
        existeOcupacion = False
        lee = "NULL"
        nivel = "NULL"
        Dim estadoEduc = ""
        Dim tieneJefe As Boolean = False

    End Sub

    Private Sub llenarRelCombo()
        Dim filtro As String

        If tieneJefe = False Then
            filtro = " AND Code IN ('JEFE', 'JEFM') "
        Else
            filtro = " AND Code NOT IN ('JEFE', 'JEFM') "
        End If

        sql = "SELECT Code, DescSPanish DescS FROM CdFamilyMemberRelationType " + _
              "WHERE Gender = '" + GeneroCombo.SelectedValue + "' AND Active = 1 " + filtro
        bdCombo(sql, RelacionCombo, "Code", "DescS")

    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(MiembroV.Text) > 0 Then
                sql = "SELECT COUNT(*) T FROM Member WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
                If bdEntero(sql, "T") > 0 Then
                    datosMiembroExistente()
                Else
                    MsgBox("El número de miembro ingresado no existe", vbQuestion, My.Resources.versionFamilias2)
                    MiembroV.Text = ""
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New MiembrosNFam
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ocupacionExistente()
        sql = "SELECT COUNT(*) T FROM dbo.MemberOccupation " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND EndDate IS NULL "
        If bdEntero(sql, "T") = 0 Then
            existeOcupacion = False
        Else
            existeOcupacion = True
        End If
        'Dim listTable As New DataTable
        'sql = "SELECT Occupation, StartDate, WorkDay, WeeklyHours, MonthlyIncome, HasIGSSAfil " + _
        '      "FROM dbo.MemberOccupation " + _
        '      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " AND EndDate IS NULL " + _
        '      "ORDER BY Creationdatetime DESC "
        'bdDataTable(sql, listTable)
        'If listTable.Rows.Count > 0 Then
        '    existeOcupacion = True
        '    OcupacionCombo.SelectedValue = listTable.Rows(0)("Occupation")
        '    ocupaOr = listTable.Rows(0)("Occupation")
        '    InicioPicker.Value = listTable.Rows(0)("StartDate")
        '    JornadaCombo.SelectedValue = chequearValor(listTable.Rows(0)("WorkDay"))
        '    HrsV.Text = chequearValor(listTable.Rows(0)("WeeklyHours"))
        '    QuetzalesV.Text = chequearValor(listTable.Rows(0)("MonthlyIncome"))
        '    If listTable.Rows(0)("MonthlyIncome") = 1 Then
        '        igssCheckBox.Checked = True
        '    End If
        'End If
    End Sub

    Private Sub QuetzalesV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QuetzalesV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Function validarDatosMiembro() As Boolean
        Dim intervalo As TimeSpan = NacimientoPicker.Value - DateTime.Now

        If Len(NombresV.Text) > 0 And Len(ApellidosV.Text) > 0 And GeneroCombo.SelectedIndex > -1 And Len(RelacionCombo.Text) > 0 Then ' And intervalo.Days < -360 Then
            validarDatosMiembro = True
        Else
            validarDatosMiembro = False
        End If
    End Function

    Private Function validarDatosOcupacion() As Boolean
        Dim intervalo As TimeSpan = InicioPicker.Value - DateTime.Now
        If OcupacionCombo.SelectedIndex > -1 Then
            Dim ingresos As Double
            If Double.TryParse(QuetzalesV.Text, ingresos) = True Then
                validarDatosOcupacion = True
            Else
                validarDatosOcupacion = False
                MsgBox("Verifique los valores en:" + vbLf + "Sueldo en Q.", vbQuestion, My.Resources.versionFamilias2)
            End If
        Else
            validarDatosOcupacion = True
        End If

    End Function

    Private Function validaRelacionFam() As Boolean
        If existeMiembro = True Then
            sql = "SELECT COUNT(*) T FROM    dbo.FamilyMemberRelation " + _
                  "WHERE RecordStatus = ' ' AND MemberId = " + MiembroV.Text + " AND InactiveDate IS NULL AND Project = '" + S + "' AND Type IN ('JEFE', 'JEFM')"
            Dim T As Integer = bdEntero(sql, "T")

            If T = 0 Then
                validaRelacionFam = True
            Else
                validaRelacionFam = False
                MsgBox("El miembro seleccionado es jefe de una familia, necesita inactivarlo", vbQuestion, My.Resources.versionFamilias2)
            End If
        Else
            validaRelacionFam = True
        End If
    End Function

    Private Sub valoresIniciales()
        sql = "SELECT Address + ' - ' + Pueblo D FROM Family WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        DireccionV.Text = "Dirección: " + bdPalabra(sql, "D")
        DireccionV.Visible = True
        llenarCombos()
        listadoMiembros()
        infoMTable.Visible = True
        MiembroInfoL.Visible = True
        existeMiembroCheck.Visible = True
        NombresV.Focus()
    End Sub






End Class