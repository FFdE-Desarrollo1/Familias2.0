Public Class RegistroCuentasACHFamilias
    Dim historialGrinN As Integer = 0
    Dim ctaActiva As String = ""
    Dim id As String = ""
    Dim razonInac As String = ""
    Dim mRef As Integer = 0
    Dim mId As String = ""
    Dim transac As String = ""

    Private Sub RegistroCuentasACHFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()

    End Sub

    Private Sub actualizarCta()
        'Project, FamilyId, Bank, AccountNumber, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Type, 
        'AccountName, PhoneRef, MemberIdRef, ExcepcionRel,  (ELIMINADO FamilyRel,)
        'RegistrationDateTime, Active, InactiveDateTime, ReasonInactive
        sql = "INSERT INTO dbo.FamilyACHAccount " + _
              "SELECT Project, FamilyId, Bank, AccountNumber, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, '" + _
              TipoCombo.SelectedValue.ToString + "', '" + NombreV.Text + "', '" + TelReferencia.Text + "', " + _
              mId + " MemberIdRef, '" + NotasV.Text + "' Notes, RegistrationDateTime, Active, InactiveDateTime, ReasonInactive " + _
              "FROM dbo.FamilyACHAccount " + _
              "WHERE RecordStatus = ' ' AND  Project + CONVERT(varchar, FamilyId) + CONVERT(varchar, Bank)  + AccountNumber + CONVERT(varchar, CONVERT(int, CreationDateTime)) = '" + id + "'"
        'InputBox("", "", sql)
        bdInsertar(sql)
        listadoCuentas()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 And familiaEsValida(S, FamiliaV.Text) = True Then
                valoresIniciales()
            Else
                MsgBox("Verifique que es una familia afiliada", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If mRef = 0 Then
            mId = "NULL"
        Else
            mId = mRef.ToString
        End If
        'MsgBox(mRef.ToString)

        If id = "" Then
            If ctaActiva = "SI" Then
                MsgBox("La familia aun tiene cuenta activa" + vbCrLf + "   No podra agregar una nueva hasta que inactive", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
            Else
                If Len(NoCuentaV.Text) > 0 And Len(NombreV.Text) > 0 And Len(BancoCombo.Text) > 0 And Len(TipoCombo.Text) > 0 Then
                    nuevaCta()
                Else
                    MsgBox("Verifique que tenga llenos los datos principales de una nueva cuenta:" + _
                           vbCrLf + "   Número" + _
                           vbCrLf + "   Nombre" + _
                           vbCrLf + "   Banco" + _
                           vbCrLf + "   Tipo", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
                End If
            End If
        Else
            actualizarCta()
        End If
            GuardarButton.Visible = False
    End Sub

    Private Sub HistorialGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        If historialGrinN = 2 Then
            Dim f As Integer = HistorialGrid.CurrentCellAddress.Y
            mRef = HistorialGrid.Item(0, f).Value()
            MiembroRef.Text = mRef.ToString + " - " + HistorialGrid.Item(5, f).Value()
        End If
    End Sub

    Private Sub InacButton_Click(sender As Object, e As EventArgs) Handles InacButton.Click
        If id = "" Then
            MsgBox("Necesita seleccionar una cuenta activa", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
        Else
            If ActvL.Text = "NO" Then
                MsgBox("La cuenta seleccionada ya esta Inactiva", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            Else
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult = MsgBox("¿Esta seguro de inactivar la cuenta? ", MsgBoxStyle.YesNo, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    razonInac = InputBox("Describa brevemente la razón por la que esta inactivando la cuenta" + vbCrLf + "   (presione ACEPTAR al finalizar)", My.Resources.versionFamilias2, "...")
                    inactivarCta()
                End If
            End If
        End If

    End Sub

    Private Sub inactivarCta()
        sql = "INSERT INTO dbo.FamilyACHAccount " + _
              "SELECT Project, FamilyId, Bank, AccountNumber, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Type, " + _
              "AccountName, PhoneRef, MemberIdRef, Notes, RegistrationDateTime, 0, GETDATE(), '" + razonInac + "' " + _
              "FROM dbo.FamilyACHAccount " + _
              "WHERE RecordStatus = ' ' AND  Project + CONVERT(varchar, FamilyId) + CONVERT(varchar, Bank)  + AccountNumber + CONVERT(varchar, CONVERT(int, CreationDateTime)) = '" + id + "'"
        'InputBox("", "", sql)
        bdInsertar(sql)
        tieneCtaActiva()
        limpiarCampos()
        listadoCuentas()
    End Sub

    Private Sub infoCuenta()
        Dim InfoActiva As New DataTable
        sql = "SELECT FAA.Project + CONVERT(varchar, FAA.FamilyId) + CONVERT(varchar, FAA.Bank)  + FAA.AccountNumber + CONVERT(varchar, CONVERT(int, FAA.CreationDateTime)) AS ID, " + _
               "FAA.Bank, FAA.Type, FAA.AccountNumber, FAA.AccountName, FAA.MemberIdRef, cdFMR.DescSpanish Relacion, FAA.PhoneRef, FAA.Notes  " + _
               "FROM dbo.FamilyACHAccount FAA " + _
               "LEFT JOIN dbo.FamilyMemberRelation FMR ON FAA.Project = FMR.Project AND FAA.RecordStatus = FMR.RecordStatus AND FAA.MemberIdRef = FMR.MemberId AND FMR.InactiveDate IS NULL " + _
               "LEFT JOIN dbo.CdFamilyMemberRelationType cdFMR ON FMR.Type = cdFMR.Code  " + _
               "WHERE FAA.RecordStatus = ' ' AND FAA.Project = '" + S + "' AND FAA.FamilyId = " + FamiliaV.Text + " AND FAA.Active = 1 " + _
               " ORDER BY FAA.Active DESC, FAA.CreationDateTime DESC "
        bdDataTable(sql, InfoActiva)
        id = InfoActiva.Rows(0)("ID")
        BancoCombo.SelectedValue = InfoActiva.Rows(0)("Bank")
        TipoCombo.SelectedValue = InfoActiva.Rows(0)("Type")
        NoCuentaV.Text = InfoActiva.Rows(0)("AccountNumber")
        NombreV.Text = InfoActiva.Rows(0)("AccountName")
        TelReferencia.Text = chequearValor(InfoActiva.Rows(0)("PhoneRef"))
        NotasV.Text = chequearValor(InfoActiva.Rows(0)("Notes"))

        BancoCombo.Enabled = False
        NoCuentaV.ReadOnly = True
        NombreV.Focus()

    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "ACCH"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarCampos()
        NoCuentaV.Text = ""
        NombreV.Text = ""
        BancoCombo.SelectedIndex = -1
        TipoCombo.SelectedIndex = -1
        TelReferencia.Text = ""
        MiembroRef.Text = ""
        NotasV.Text = ""
        ActvL.Text = ""
        id = ""

        BancoCombo.Enabled = True
        NoCuentaV.ReadOnly = False
        NoCuentaV.Focus()
    End Sub

    Private Sub listadoCuentas()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        historialGrinN = 1
        sql = "SELECT FAA.Project + CONVERT(varchar, FAA.FamilyId) + CONVERT(varchar, FAA.Bank)  + FAA.AccountNumber + CONVERT(varchar, CONVERT(int, FAA.CreationDateTime)) AS ID, " + _
              "CASE WHEN FAA.Active = 1 THEN 'SI' ELSE 'NO' END Activa, cdB.BankName AS Banco, CdBT.DescriptionType AS Tipo, FAA.AccountNumber AS No_Cuenta, FAA.AccountName AS NombreCuenta, " + _
              "FAA.MemberIdRef AS 'Miembro Referencia', cdFMR.DescSpanish Relacion, FAA.PhoneRef AS TelReferencia, FAA.Notes Notas,  " + _
              "CONVERT(varchar,FAA.RegistrationDateTime, 105) AS Registro, CONVERT(varchar, FAA.CreationDateTime,105) Actualización, FAA.UserId AS Usuario, " + _
              "CONVERT(varchar, InactiveDateTime ,105) FechaInactiva, ReasonInactive Razon " + _
              "FROM dbo.FamilyACHAccount FAA " + _
              "INNER JOIN dbo.CdBankAccountType CdBT ON FAA.Type = CdBT.Code " + _
              "INNER JOIN dbo.CdBankACH cdB ON FAA.Bank = cdB.NoBank " + _
              "LEFT JOIN dbo.Member M ON M.Project = FAA.Project AND M.RecordStatus = FAA.RecordStatus AND M.MemberId = FAA.MemberIdRef " + _
              "LEFT JOIN dbo.FamilyMemberRelation FMR ON M.Project = FMR.Project AND M.RecordStatus = FMR.RecordStatus AND M.MemberId = FMR.MemberId AND FMR.InactiveDate IS NULL " + _
              "LEFT JOIN dbo.CdFamilyMemberRelationType cdFMR ON FMR.Type = cdFMR.Code  " + _
              "WHERE FAA.RecordStatus = ' ' AND FAA.Project = '" + S + "' AND FAA.FamilyId = " + FamiliaV.Text + _
              " ORDER BY FAA.Active DESC, FAA.CreationDateTime DESC "
        bdGrid(sql, HistorialGrid)
        'InputBox("", "", sql)
        HistorialGrid.Columns.Item(0).Visible = False 'ID
        HistorialGrid.Visible = True

        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        HistorialGrid.AutoResizeColumns()
    End Sub

    Private Sub ListadoFamiliaLink_Click(sender As Object, e As EventArgs) Handles ListadoFamiliaLink.Click
        listadoMiembroFamilia()
    End Sub

    Private Sub listadoMiembroFamilia()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
        historialGrinN = 2
        sql = "SELECT FMR.MemberId AS Miembro, M.FirstNames AS Nombres, M.LastNames AS Apellidos, dbo.fn_GEN_FormatDate(M.BirthDate, 'ES') AS Nacimiento, " + _
              "dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad, cdFMR.DescSpanish AS Relación_Familiar, cdAS.DescSpanish AS Estado_Afil, " + _
              "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro " + _
          "FROM dbo.FamilyMemberRelation FMR INNER JOIN " + _
          "dbo.CdFamilyMemberRelationType cdFMR ON FMR.Type = cdFMR.Code INNER JOIN " + _
          "dbo.Member M ON FMR.Project = M.Project AND FMR.MemberId = M.MemberId AND FMR.RecordStatus = M.RecordStatus " + _
          "LEFT JOIN dbo.CdAffiliationStatus cdAS ON cdAS.Code = M.AffiliationStatus " + _
          "WHERE FMR.RecordStatus = ' ' AND FMR.Project = '" + S + "' AND FMR.FamilyId = " + FamiliaV.Text + " AND FMR.InactiveDate IS NULL " + _
          "ORDER BY cdFMR.DisplayOrder "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.Visible = True
    End Sub

    Private Sub nuevaCta()
        Dim Registro = Now.ToString(en.DateTimeFormat)
        'Project, FamilyId, Bank, AccountNumber, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Type, 
        'AccountName, PhoneRef, MemberIdRef, ExcepcionRel,  (ELIMINADO FamilyRel,)
        'RegistrationDateTime, Active, InactiveDateTime, ReasonInactive
        sql = "INSERT INTO  dbo.FamilyACHAccount VALUES ('" + S + "', " + FamiliaV.Text + ", " + BancoCombo.SelectedValue.ToString + ", '" + _
              NoCuentaV.Text + "', GETDATE(), ' ', '" + U + "', NULL, '" + TipoCombo.SelectedValue.ToString + "', '" + _
              NombreV.Text + "', '" + TelReferencia.Text + "', " + mId + ", '" + NotasV.Text + "', '" + _
              Registro + "', 1, NULL, NULL)"
        'InputBox("", "", sql)
        bdInsertar(sql)
        tieneCtaActiva()
        listadoCuentas()

    End Sub

    Private Sub NuevaButton_Click(sender As Object, e As EventArgs) Handles NuevaButton.Click
        If ctaActiva = "SI" Then
            MsgBox("La familia aun tiene cuenta activa" + vbCrLf + "   No podra agregar una nueva hasta que inactive", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
        Else
            limpiarCampos()
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New RegistroCuentasACHFamilias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub tieneCtaActiva()
        sql = "SELECT COUNT(*) N FROM dbo.FamilyACHAccount " + _
              "WHERE RecordStatus = ' '  AND  Project = '" + S + "' AND FamilyID = " + FamiliaV.Text + " AND Active = 1"
        Dim N As Integer = bdEntero(sql, "N")

        If N > 0 Then
            ctaActiva = "SI"
            infoCuenta()
        Else
            ctaActiva = "NO"
            NoCuentaV.Focus()
        End If
    End Sub

    Private Sub valoresIniciales()
        Dim GenInfo As New DataTable
        sql = "SELECT Address, Pueblo, dbo.fn_GEN_telefonos(Project, FamilyId) Tel, DescSpanish Estado " + _
              "FROM dbo.Family F INNER JOIN CdAffiliationStatus ON Code = AffiliationStatus " + _
              "WHERE RecordStatus = ' '  AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        bdDataTable(sql, GenInfo)
        DireccionV.Text = chequearValor(GenInfo.Rows(0)("Address")) + " - " + chequearValor(GenInfo.Rows(0)("Pueblo"))
        TelefonosL.Text = "Telefonos registrados: " + chequearValor(GenInfo.Rows(0)("Tel"))
        Dim estadoF As String = chequearValor(GenInfo.Rows(0)("Estado"))
        EstadoFam.Text = "Estado Familiar: " + estadoF

        If estadoF = "Graduado" Or estadoF = "Desafiliado" Then
            EstadoFam.ForeColor = Color.Red
        End If

        DireccionL.Visible = True
        DireccionV.Visible = True
        TelefonosL.Visible = True
        EstadoFam.Visible = True

        sql = "SELECT NoBank, CONVERT(varchar, NoBank) + ' - ' + BankName B FROM dbo.CdBankACH"
        bdCombo(sql, BancoCombo, "NoBank", "B")

        sql = "SELECT Code,  DescriptionType  T FROM CdBankAccountType "
        bdCombo(sql, TipoCombo, "Code", "T")

        tieneCtaActiva()
        listadoCuentas()
        DatosTable.Visible = True
        BotonesTable.Visible = True
        GuardarButton.Visible = True
    End Sub

    Private Sub VerCuentas_Click(sender As Object, e As EventArgs) Handles VerCuentas.Click
        listadoCuentas()
    End Sub

End Class