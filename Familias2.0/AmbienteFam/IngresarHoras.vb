Public Class IngresarHoras
    Public idSolicitud As String
    Dim nA, nDe As Integer
    Dim msError = "El número de familia que ingresó no es válido" + Chr(13) + _
       "Verifique que sea una familia afiliada"
    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

    Private Sub IngresarHoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(FamiliaV.Text) = 0 Then
            FamiliaV.Focus()
        Else
            valoresIniciales()
        End If
    End Sub

    Private Sub APicker_ValueChanged(sender As Object, e As EventArgs) Handles APicker.ValueChanged
        nA = 1
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BorrarHoras(ByVal ID As String)
        sql = "UPDATE dbo.FamilyHoursWorked SET RecordSTatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + '...' + '" + U + "'+'-'+CONVERT(varchar,GETDATE(),111) " + _
              "WHERE IdSolicitude +'-'+ CONVERT(varchar, FromDate, 112) + '-' + CONVERT(varchar, ToDate, 112) = '" + ID + "'"
        bdEjecutarSQL(sql)
        HorasTrabajadas()
        solicitud()

        If FaltantesV.Text > 0 Then
            sql = "UPDATE FamilyAmbFamSolicitude SET Status = 'TRAB', StatusDate = GETDATE() WHERE RecordStatus = ' ' AND IdSolicitude = '" + idSolicitud + "' "
            bdEjecutarSQL(sql)
            solicitud()
        End If

    End Sub

    Private Sub DePicker_ValueChanged(sender As Object, e As EventArgs) Handles DePicker.ValueChanged
        nDe = 1
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            verificarDatos()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        Dim hrs As Double
        If Double.TryParse(HorasV.Text, hrs) = True Then
            If Len(HorasV.Text) = 0 Then
                msError = "La cantidad de horas no debe estar vacia"
                MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
            ElseIf Double.Parse(HorasV.Text) <= 0 Then
                msError = "La cantidad de horas debe ser mayor a 0"
                MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
            Else
                If nA = 0 Or nDe = 0 Then
                    msError = "Necesita ingresar las 2 fechas: De: y A:"
                    MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
                Else
                    Dim result As Integer = DateTime.Compare(DePicker.Value.ToShortDateString, APicker.Value.ToShortDateString)
                    If result <= 0 Then
                        IngresarHoras()
                    Else
                        msError = "La 2a. fecha no puede ser menor a la 1a."
                        MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
                    End If
                End If
            End If
        Else
            msError = "La cantidad de horas un número entero o decimal"
            MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub HorasTrabajadas()
        HorasTrabajadasGrid.DataSource = Nothing
        HorasTrabajadasGrid.Rows.Clear()
        sql = "SELECT 'Borrar' '_', IdSolicitude +'-'+ CONVERT(varchar, FromDate, 112) + '-' + CONVERT(varchar, ToDate, 112) AS ID, CONVERT(varchar, FromDate, 103) AS De, " + _
              "CONVERT(varchar, ToDate, 103) AS A, Hours AS Horas, UserId AS Usuario, Notes AS Notas " + _
              "FROM dbo.FamilyHoursWorked WHERE RecordStatus = ' ' AND IdSolicitude = '" + idSolicitud + "'"
        bdGrid(sql, HorasTrabajadasGrid)
        HorasTrabajadasGrid.Visible = True
        HorasTrabajadasGrid.Columns.Item(1).Visible = False
        agregarColumnaAccion(0, HorasTrabajadasGrid)

    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub IngresarHoras()
        Dim msg As String
        Try
            sql = "INSERT INTO dbo.FamilyHoursWorked VALUES('" + idSolicitud + "', '" + DePicker.Value.ToString(en.DateTimeFormat) + "', '" + APicker.Value.ToString(en.DateTimeFormat) + "'" + _
                          ", GETDATE(), ' ', '" + U + "', NULL, " + HorasV.Text + ", '" + NotasV.Text + "')"
            bdInsertar(sql)
            msg = ""
        Catch ex As Exception
            msg = ex.Message
        End Try

        If msg = "" Then
            If TotalHrsV.Text - THrsTrabV.Text - HorasV.Text <= 0 Then
                sql = "UPDATE FamilyAmbFamSolicitude SET Status = 'TERH', StatusDate = GETDATE() WHERE RecordStatus = ' ' AND IdSolicitude = '" + idSolicitud + "' "
                bdEjecutarSQL(sql)
            End If
            HorasTrabajadas()
            solicitud()
            limpiarCampos()
            MsgBox("Ingreso correcto!", vbExclamation, My.Resources.versionFamilias2)
        Else

        End If


    End Sub

    Private Sub HorasTrabajadasGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HorasTrabajadasGrid.CellContentClick
        Dim c = HorasTrabajadasGrid.CurrentCellAddress.X
        Dim f = HorasTrabajadasGrid.CurrentCellAddress.Y
        Dim id = HorasTrabajadasGrid.Item(1, f).Value()
        ' Dim cantidad = HorasTrabajadasGrid.Item(4, f).Value()

        msError = "¿Esta seguro de borrar las horas registradas?"
        Dim response As MsgBoxResult = MsgBox(msError, style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            BorrarHoras(id)
        End If

    End Sub

    Private Sub HorasV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HorasV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub limpiarCampos()
        DePicker.Value = Today
        APicker.Value = Today
        HorasV.Text = ""
        NotasV.Text = ""
    End Sub

    Private Sub nuevo()
        Dim nxt As New IngresarHoras
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        nuevo()
    End Sub

    Private Sub solicitud()
        Dim solicitudInfo As New DataTable
        sql = "SELECT cdFPS.DescSpanish Status, CONVERT(varchar, FAFS.StatusDate,103) StatusDate, FAFS.TotalHours, FAFS.HoursWorked, FAFS.Notes " + _
              "FROM dbo.FamilyAmbFamSolicitude FAFS INNER JOIN dbo.CdFamilyProgramStatus cdFPS ON FAFS.Status = cdFPS.Code " + _
              "WHERE FAFS.RecordStatus = ' ' AND FAFS.Project = '" + S + "' AND FAFS.FamilyId = " + FamiliaV.Text + " "
        bdDataTable(sql, solicitudInfo)
        EstadoV.Text = solicitudInfo.Rows(0)("Status")
        FechaEstadoV.Value = solicitudInfo.Rows(0)("StatusDate")
        TotalHrsV.Text = solicitudInfo.Rows(0)("TotalHours")
        THrsTrabV.Text = solicitudInfo.Rows(0)("HoursWorked")
        ObservV.Text = solicitudInfo.Rows(0)("Notes")
        FaltantesV.Text = solicitudInfo.Rows(0)("TotalHours") - solicitudInfo.Rows(0)("HoursWorked")
    End Sub

    Private Function tieneSolicitud()
        sql = "SELECT COUNT(*) T FROM dbo.FamilyAmbFamSolicitude WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
        If bdEntero(sql, "T") = 0 Then
            tieneSolicitud = False
            msError = "La familia no cuenta con solicitudes"
        Else
            sql = "SELECT MAX(IdSolicitude) IdSol FROM dbo.FamilyAmbFamSolicitude WHERE Project = '" + S + "' AND FamilyId = " + FamiliaV.Text + " "
            idSolicitud = bdPalabra(sql, "IdSol")
            tieneSolicitud = True
        End If
    End Function

    Private Sub valoresIniciales()
        'INFORMACION GENERAL
        sql = "SELECT Address + ' - ' + Pueblo Direccion, dbo.fn_GEN_regionFamilia(F.Project, F.FamilyId) AS Region FROM dbo.Family F WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        DireccionV.Text = bdPalabra(sql, "Direccion")
        RegionV.Text = bdPalabra(sql, "Region")

        FamiliaV.ReadOnly = True
        DireccionV.Visible = True
        DireccionL.Visible = True
        regionL.Visible = True
        RegionV.Visible = True
        InfoSolTable.Visible = True
        HorasTable.Visible = True
        GuardarButton.Visible = True
        HorasTrabajadas()
        limpiarCampos()
        solicitud()
        nDe = nA = 0
        DePicker.Format = DateTimePickerFormat.Custom
        DePicker.CustomFormat = " "
        APicker.Format = DateTimePickerFormat.Custom
        APicker.CustomFormat = " "
    End Sub

    Private Sub verificarDatos()
        If Len(FamiliaV.Text) > 0 Then
            If familiaEsAfiliada(S, Integer.Parse(FamiliaV.Text)) = True Then
                If tieneSolicitud() = True Then
                    valoresIniciales()
                Else
                    MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
                    nuevo()
                End If
            Else
                MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
                FamiliaV.Text = ""
            End If
        Else
            MsgBox(msError, vbCritical, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
            FamiliaV.Focus()
        End If
    End Sub


    Private Sub DePicker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DePicker.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                DePicker.Format = DateTimePickerFormat.Short
                DePicker.Value = Date.Today
                nDe = 1
        End Select
    End Sub

    Private Sub APicker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles APicker.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                APicker.Format = DateTimePickerFormat.Short
                APicker.Value = Date.Today
                nA = 1
        End Select
    End Sub
End Class