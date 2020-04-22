Public Class NuevaFamilia
    Dim familiaId As Integer = 0
    Dim existeJefe As Boolean = False
    Dim piv As Integer = 0
    Dim pueblo As String = ""
    Dim miembro As Integer
    Dim lee As String = "NULL"
    Dim nivel As String = "NULL"
    Dim inactivarJefe As Boolean = False
    Dim existeMiembro As Boolean = False

    Private Sub NuevaFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub AreaCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AreaCombo.SelectedIndexChanged
        If piv > 0 And AreaCombo.SelectedIndex > -1 Then
            sql = "SELECT Pueblo FROM CdGeographicArea WHERE Code = '" + AreaCombo.SelectedValue + "'"
            pueblo = bdPalabra(sql, "Pueblo")
            PuebloL.Text = "     PUEBLO: " + pueblo
            PuebloL.Visible = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub DPIv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function existeFamilia() As Boolean
        sql = "SELECT COUNT (*) T FROM Family WHERE Project = '" + S + "' AND FamilyId = " + familiaId.ToString
        If bdEntero(sql, "T") = 0 Then
            existeFamilia = False
        Else
            existeFamilia = True
        End If
    End Function

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembros()
        Dim nxt As New MiembrosNFam
        nxt.FamiliaV.Text = familiaId.ToString
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listadoFamiliasSinMiembros()
        sql = "SELECT f.FamilyId Familia, Address Dirección, cdP.DescSpanish Area, f.Pueblo, TelephoneNumber Telefono " + _
              ", (SELECT COUNT(*) FROM FamilyMemberRelation R WHERE R.RecordStatus = ' ' AND R.Project = f.Project " + _
              "AND R.FamilyId = F.FamilyId) MiembrosFamilia, affiliationStatus EstadoAfil, TimeOnPlace TiempoDeVivirAllí, " + _
              "dbo.fn_GEN_FormatDate(F.CreationDateTime, 'es') Ingreso, F.UserId Usuario " + _
              "FROM Family F INNER JOIN CdGeographicArea cdP ON cdP.Code = F.Area " + _
              "WHERE f.Recordstatus = ' ' and f.project = 'f' AND affiliationStatus is null " + _
              "AND (SELECT COUNT(*) FROM FamilyMemberRelation R WHERE R.RecordStatus = ' ' AND R.Project = f.Project AND R.FamilyId = F.FamilyId) = 0 " + _
              "ORDER BY FamilyId DESC "
        bdGrid(sql, FamiliasGrid)
        FamiliasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        FamiliasGrid.AutoResizeColumns()
        FamiliasGrid.Visible = True
        FamiliasL.Visible = True
    End Sub

    Private Sub MiembrosButton_Click(sender As Object, e As EventArgs) Handles MiembrosButton.Click
        Dim nxt As New MiembrosNFam
        nxt.FamiliaV.Text = FamiliaV.Text
        nxt.DireccionV.Text = DireccionV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevaFamButton_Click(sender As Object, e As EventArgs) Handles NuevaFamButton.Click
        If validaDatosFam() = True Then
            NuevaFamButton.Visible = False
            nuevaFamilia()
            'llenarRelCombo(False)
        Else
            MsgBox("Necesita ingresar valores en:" + vbLf + "Direccion, Area y Etnia", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub nuevaFamilia()
        NuevaFamButton.Visible = False

        sql = "SELECT MAX(FamilyId) AS U FROM dbo.Family WHERE Project = '" + S + "'"
        familiaId = bdEntero(sql, "U") + 1

        Dim municipio As String = "NULL"
        If MunicipioCombo.SelectedIndex > -1 Then
            municipio = "'" + MunicipioCombo.SelectedValue + "'"
        End If

        sql = "INSERT INTO Family VALUES ('" + S + "'," + familiaId.ToString + ",GETDATE(), ' ', '" + U + "', NULL, NULL,NULL,NULL,'" + _
              AreaCombo.SelectedValue + "','" + pueblo + "', '" + Replace(DireccionV.Text, "'", "''") + "', '" + TelefonoV.Text + "', '" + _
              EtniaCombo.SelectedValue + "', NULL,NULL, GETDATE(), NULL, GETDATE(), NULL, '" + TiempoV.Text + "', NULL,NULL)"
        bdInsertar(sql)

        If existeFamilia() = True Then
            NoFamilia = familiaId.ToString
            sql = "INSERT INTO dbo.FamilyLivingCondition VALUES ('" + S + "'," + familiaId.ToString + ",GETDATE(),' ', '" + U + "', NULL, " + _
                  "NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)"
            bdInsertar(sql)
            FamiliaV.Text = NoFamilia
            FamiliaV.Visible = True
            FamiliaL.Visible = True
            MiembrosButton.Visible = True
            listadoFamiliasSinMiembros()
        Else
            MsgBox("Hubo un error al ingresar a la familia." + vbLf + "Ingresela nuevamente.", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New NuevaFamilia
        nxt.Show()
        Me.Close()
    End Sub

    Private Function validaDatosFam() As Boolean
        If Len(DireccionV.Text) > 0 And AreaCombo.SelectedIndex > -1 And EtniaCombo.SelectedIndex > -1 Then
            validaDatosFam = True
        Else
            validaDatosFam = False
        End If
    End Function

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish D FROM CdGeographicArea WHERE Active = 1 AND Project = '" + S + "' ORDER BY DescSpanish "
        bdCombo(sql, AreaCombo, "Code", "D")

        sql = "SELECT Code, DescSpanish D FROM CdEthnicity "
        bdCombo(sql, EtniaCombo, "Code", "D")

        sql = "SELECT Code, DescSpanish DescS FROM CdMunicipality "
        bdCombo(sql, MunicipioCombo, "Code", "DescS")
        piv = 1

        listadoFamiliasSinMiembros()
    End Sub


    'Private Function existeJefeN() As Boolean
    '    sql = "SELECT COUNT (*) T FROM Member WHERE Project = '" + S + "' AND MemberId = " + miembro.ToString
    '    If bdEntero(sql, "T") = 0 Then
    '        existeJefeN = False
    '    Else
    '        existeJefeN = True
    '    End If
    'End Function

    'Private Sub existeJefeCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    If existeJefeCheckBox.Checked = True Then
    '        MiembroV.Visible = True
    '        MiembroL.Visible = True
    '        MiembroV.Focus()
    '    Else
    '        MiembroV.Visible = False
    '        MiembroL.Visible = False
    '    End If
    'End Sub

    'Private Sub existeRelJefe()
    '    Dim listTable As New DataTable
    '    sql = "SELECT FMR.FamilyId, cdR.DescSpanish AS Tipo FROM dbo.FamilyMemberRelation " + _
    '      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + miembro.ToString + " AND InactiveDate IS NULL "
    '    bdDataTable(sql, listTable)
    '    If listTable.Rows.Count > 0 Then
    '        Dim style As MsgBoxStyle
    '        Dim response As MsgBoxResult
    '        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
    '        response = MsgBox("El jefe aun tiene relación activa con otra familia: " + vbLf + _
    '                          chequearValor(listTable.Rows(0)("FamilyId")) + "-" + chequearValor(listTable.Rows(0)("Tipo")) + vbLf + _
    '                          "¿Esta seguro de inactivarlo?", style, My.Resources.versionFamilias2)
    '        If response = MsgBoxResult.Yes Then
    '            inactivarJefe = True
    '        Else
    '            inactivarJefe = False

    '        End If

    '    End If

    'End Sub

    'Private Sub GeneroCombo_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If piv = 2 And GeneroCombo.SelectedIndex > -1 Then
    '        llenarRelCombo()
    '    End If
    'End Sub

    'Private Sub guardarMiembroRelacion()
    '    If existeMiembro = True Then 'INACTIVAR RELACION ACTUAL
    '        sql = "UPDATE dbo.FamilyMemberRelation SET INACTIVEDATE = GETDATE(), INACTIVEREASON = 'SEPR' " + _
    '              "WHERE RecordStatus = ' ' AND MemberId = " + MiembroV.Text + " AND InactiveDate IS NULL AND Project = '" + S + "'"
    '        bdEjecutarSQL(sql)
    '        'InputBox("", "", sql)
    '    End If
    '    ''ingresar relacion actual
    '    sql = "INSERT INTO FamilyMemberRelation VALUES ('" + S + "'," + FamiliaV.Text + ", " + MiembroV.Text + ",'" + RelacionCombo.SelectedValue + _
    '          "', GETDATE(), GETDATE(), ' ', '" + U + "',NULL,NULL,NULL)"
    '    bdInsertar(sql)
    '    'InputBox("", "", sql)
    'End Sub

    'Private Sub idNuevoJefe()
    '    ''tabla temporal para emparejar el correlativo de IDs
    '    sql = "SELECT MIN(Id) ID FROM TEMPIDF WHERE Used = 0"
    '    miembro = bdEntero(sql, "ID")

    '    sql = "UPDATE TEMPIDF SET Used = 1 WHERE Id = " + miembro.ToString
    '    bdEjecutarSQL(sql)

    '    'sql = "SELECT MAX(MemberId) Id FROM Member WHERE Project = '" + S + "' "
    '    'miembro = bdEntero(sql, "Id") + 1
    'End Sub

    'Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    '    KeyAscii = CShort(SoloNumeros(KeyAscii))
    '    If KeyAscii = 0 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub MiembroV_Leave(sender As Object, e As EventArgs)
    '    If Len(MiembroV.Text) > 0 Then
    '        sql = "SELECT COUNT(*) T FROM Member WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
    '        If bdEntero(sql, "T") > 0 Then
    '            datosJefeExistente()
    '        Else
    '            MsgBox("El número de miembro ingresado no existe", vbQuestion, My.Resources.versionFamilias2)
    '            MiembroV.Text = ""
    '        End If
    '    End If
    'End Sub
    'Private Sub registroJefeExistente()
    '    sql = "INSERT INTO Member " + _
    '          "SELECT '" + S + "', " + MiembroV.Text + ", GETDATE(), ' ', '" + U + "', NULL, " + FamiliaV.Text + ", '" + Replace(NombresV.Text, "'", "''") + _
    '          "','" + Replace(ApellidosV.Text, "'", "''") + "', PreferredName, '" + NacimientoPicker.Value.ToString(en.DateTimeFormat) + "', '" + GeneroCombo.SelectedValue + _
    '          "', AffiliationType, AffiliationStatus, AffiliationStatusDate, LiveDead, DeathDate, BiologicalMotherMemberId, BiologicalFatherMemberId, " + _
    '          "OtherAffiliation, '" + DPIv.Text + "', HasFaithOfAgeOrOfficialId, CellularPhoneNumber, " + lee + "," + nivel + ", HasHealthCard,  " + _
    '                  "ExceptionInAgePolicy, LastGradePassedYear, LastGradePassedStatus " + _
    '          "FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "'  AND MemberId = " + MiembroV.Text + " "
    '    'InputBox("", "", sql)
    '    bdInsertar(sql)

    '    sql = "SELECT COUNT(*) T FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "'  AND MemberId = " + MiembroV.Text + " "
    '    If bdEntero(sql, "T") > 0 Then
    '        guardarMiembroRelacion()
    '        'guardarOcupacion()
    '        'listadoMiembros()
    '    End If
    'End Sub

    'Private Sub registroJefeNuevo()
    '    idNuevoJefe()

    '    sql = "INSERT INTO Member VALUES ('" + S + "', " + miembro.ToString + ", GETDATE(), ' ', '" + U + "', NULL," + familiaId.ToString + _
    '          ", '" + Replace(NombresV.Text, "'", "''") + "','" + Replace(ApellidosV.Text, "'", "''") + "', '','" + _
    '          NacimientoPicker.Value.ToString(en.DateTimeFormat) + "', '" + GeneroCombo.SelectedValue + "',NULL,NULL,NULL,'V',NULL,NULL,NULL,NULL," + _
    '          "'" + DPIv.Text + "',0,NULL," + lee + "," + nivel + ",NULL,NULL,NULL,NULL)"
    '    InputBox("", "", sql)
    '    bdInsertar(sql)
    'End Sub

    'Private Sub registroRelJefe()
    '    ''Inactivar relaciones actuales
    '    sql = "UPDATE FamilyMemberRelation SET InactiveDate = GETDATE(), InactiveReason = 'SEPR' " + _
    '          "WHERE Project = '" + S + "' AND MemberId = " + miembro.ToString + " AND InactiveDate IS NULL "
    '    bdEjecutarSQL(sql)

    '    ''ingresar relacion actual
    '    sql = "INSERT INTO FamilyMemberRelation VALUES ('" + S + "'," + familiaId.ToString + ", " + miembro.ToString + ",'" + RelacionCombo.SelectedValue + _
    '          "', GETDATE(), GETDATE(), ' ', '" + U + "',NULL,NULL,NULL)"
    '    bdInsertar(sql)
    'End Sub

    'Private Function validarDatosJefe() As Boolean
    '    Dim intervalo As TimeSpan = NacimientoPicker.Value - DateTime.Now

    '    If Len(NombresV.Text) > 0 And Len(ApellidosV.Text) > 0 And GeneroCombo.SelectedIndex > -1 And Len(RelacionCombo.Text) > 0 Then 'And intervalo.Days < -360 Then
    '        validarDatosJefe = True
    '    Else
    '        validarDatosJefe = False
    '    End If
    'End Function



    'Private Sub JefeButton_Click(sender As Object, e As EventArgs)
    '    If validarDatosJefe() = True And inactivarJefe = True Then
    '        JefeButton.Visible = False
    '        If NivelAcCombo.SelectedIndex > -1 Then
    '            lee = "'SI'"
    '            nivel = "'" + NivelAcCombo.SelectedValue + "'"
    '        End If

    '        If existeJefe = True Then
    '            registroJefeExistente()
    '        Else
    '            registroJefeNuevo()

    '        End If
    '        If existeJefeN() = True Then
    '            registroRelJefe()
    '        End If


    '    Else
    '        MsgBox("Necesita ingresar valores en:" + vbLf + "Nombres, Apellidos, Nacimiento (menor a la fecha actual), Género y Relación", vbQuestion, My.Resources.versionFamilias2)
    '    End If
    'End Sub

    'Private Sub datosJefeExistente()
    '    MiembroV.ReadOnly = True
    '    Dim listTable As New DataTable
    '    sql = "SELECT FirstNames Nombres, LastNames Apellidos, birthDate Nac, Gender, LastGradePassed gr, OfficialId dpi " + _
    '          "FROM Member " + _
    '          "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text
    '    bdDataTable(sql, listTable)
    '    NombresV.Text = chequearValor(listTable.Rows(0)("Nombres"))
    '    ApellidosV.Text = chequearValor(listTable.Rows(0)("Apellidos"))
    '    NacimientoPicker.Value = listTable.Rows(0)("Nac")
    '    GeneroCombo.SelectedValue = chequearValor(listTable.Rows(0)("Gender"))
    '    NivelAcCombo.SelectedValue = chequearValor(listTable.Rows(0)("gr"))
    '    DPIv.Text = chequearValor(listTable.Rows(0)("dpi"))
    '    existeJefe = True
    'End Sub

    'Private Sub limpiarDatosJefe()
    '    MiembroL.Visible = False
    '    MiembroV.Visible = False
    '    MiembroV.Text = ""
    '    RelacionCombo.SelectedIndex = -1
    '    NombresV.Text = ""
    '    ApellidosV.Text = ""
    '    NacimientoPicker.Value = Now
    '    NivelAcCombo.SelectedIndex = -1
    '    DPIv.Text = ""
    'End Sub

    'Private Sub llenarRelCombo()
    '    Dim gen As String = ""
    '    If GeneroCombo.SelectedValue.ToString = "F" Then
    '        gen = "JEFE"
    '    Else
    '        gen = "JEFM"
    '    End If
    '    sql = "SELECT Code, DescSPanish DescS FROM CdFamilyMemberRelationType WHERE code = '" + gen + "' "
    '    bdComboSinBlancos(sql, RelacionCombo, "Code", "DescS")
    'End Sub

    'Private Sub llenarCombos()
    '    sql = "SELECT Code, DescSpanish DescS FROM dbo.CdGender WHERE Code not in ('D') "
    '    bdCombo(sql, GeneroCombo, "Code", "DescS")
    '    piv = 2

    '    sql = "SELECT Code, DescSpanish DescS FROM dbo.CdGrade " + _
    '          "WHERE ValidValue = 1 AND EducationLevel NOT IN ('CEIF', 'ESPC', 'ESTI') " + _
    '          "ORDER BY Orden "
    '    bdCombo(sql, NivelAcCombo, "Code", "DescS")
    'End Sub

End Class