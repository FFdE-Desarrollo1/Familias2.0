' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActividadesAE
    'Public familyId As Integer
    Dim ahora As DateTime = DateTime.Now
    Dim creat As String

    Private Sub ActividadesAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(MiembroV.Text) > 0 Then
            valoresIniciales()
        Else
            PrincipalPanel.Visible = True
            MiembroV.Focus()
        End If
    End Sub

    Private Sub ActividadesGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ActividadesGrid.CellContentClick
        Dim f, c As Integer
        c = ActividadesGrid.CurrentCellAddress.X
        f = ActividadesGrid.CurrentCellAddress.Y

        Dim tipo As String = ActividadesGrid.Item(3, f).Value()
        creat = ActividadesGrid.Item(2, f).Value()

        If c = 0 Then
            Dim msg As String = "¿Esta seguro de borrar la actividad?"
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            response = MsgBox(msg, style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                sql = "UPDATE dbo.MemberActivity SET RecordStatus = 'H', ExpirationDateTime = GETDATE(), Notes = Notes + '" + U + "' " + _
                      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
                      "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + tipo + "'"
                bdEjecutarSQL(sql)
                historialActividades()

            End If
        ElseIf c = 1 Then
            IDL.Text = "1"
            NuevaActL.Text = "Modificar Actividad"
            Dim fechaAct As DateTime = ActividadesGrid.Item(4, f).Value()
            FechaPicker.Value = fechaAct
            HoraV.Text = fechaAct.Hour.ToString
            MinutosV.Text = fechaAct.Minute.ToString
            TipoCombo.SelectedValue = tipo
            NotasV.Text = ActividadesGrid.Item(6, f).Value()

            TipoCombo.Enabled = False
            FechaPicker.Enabled = False
            HoraV.ReadOnly = True
            MinutosV.ReadOnly = True
        Else
        End If
    End Sub

    Private Sub ActividadesLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ActividadesLink.LinkClicked
        historialActividades()
    End Sub

    Private Sub añoActualLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles añoActualLink.LinkClicked
        historialActividadesActuales()
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

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If Len(TipoCombo.Text) = 0 Or Len(HoraV.Text) = 0 Or Len(MinutosV.Text) = 0 Then
            MsgBox("Necesita llenar todos los campos con *", vbExclamation, My.Resources.versionFamilias2)
        Else
            If IDL.Text = "0" Then 'nueva
                Dim fecha As String = unirFechaHoraMinuto(FechaPicker.Value, HoraV.Text, MinutosV.Text)
                sql = "INSERT INTO dbo.MemberActivity VALUES('" + S + "', " + MiembroV.Text + ", '" + TipoCombo.SelectedValue + "', " + _
                      "'" + fecha + "', GETDATE(), ' ', '" + U + "', NULL, '" + NotasV.Text + "')"
                bdInsertar(sql)
                historialActividadesActuales()
                limpiarCampos()
            Else 'modifica
                sql = "INSERT INTO dbo.MemberActivity " + _
                      "SELECT Project, MemberId, Type, ActivityDateTime, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, '" + NotasV.Text + "' " + _
                      "FROM dbo.MemberActivity " + _
                      "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + MiembroV.Text + " " + _
                      "AND Convert(nvarchar(30), CreationDateTime, 21) = '" + creat + "' AND Type = '" + TipoCombo.SelectedValue + "'"
                bdEjecutarSQL(sql)
                historialActividadesActuales()
                limpiarCampos()
            End If
        End If
    End Sub

    Private Sub historialActividades()
        ActividadesGrid.DataSource = Nothing
        ActividadesGrid.Rows.Clear()
        ActividadesGrid.Visible = False
        sql = "SELECT 'Borrar' Borrar, 'Modificar' Modificar, CONVERT(nvarchar(30), MA.CreationDateTime, 21) Crea, MA.Type, " + _
              "CONVERT(nvarchar(30), MA.ActivityDateTime, 20) AS Fecha, cdMAT.DescSpanish AS Actividad, MA.Notes AS Notas " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdMAT ON MA.Type = cdMAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND cdMat.FunctionalArea = 'PSIC' AND MA.Project = '" + S + "' AND MA.MemberId = " + MiembroV.Text + " " + _
              "ORDER BY  MA.ActivityDateTime DESC "
        bdGrid(sql, ActividadesGrid)
        ActividadesGrid.Columns.Item(2).Visible = False 'creat
        ActividadesGrid.Columns.Item(3).Visible = False 'tipo
        agregarColumnaAccion(0, ActividadesGrid)
        agregarColumnaAccion(1, ActividadesGrid)
        ActividadesGrid.Visible = True
    End Sub

    Private Sub historialActividadesActuales()
        ActividadesGrid.DataSource = Nothing
        ActividadesGrid.Rows.Clear()
        ActividadesGrid.Visible = False
        sql = "SELECT 'Borrar' Borrar, 'Modificar' Modificar, CONVERT(nvarchar(30), MA.CreationDateTime, 21) Crea, MA.Type, " + _
              "CONVERT(nvarchar(30), MA.ActivityDateTime, 20) AS Fecha, cdMAT.DescSpanish AS Actividad, MA.Notes AS Notas " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdMAT ON MA.Type = cdMAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND cdMat.FunctionalArea = 'PSIC' AND MA.Project = '" + S + "' AND MA.MemberId = " + MiembroV.Text + "  AND YEAR(MA.ActivityDateTime) = " + Today.Year.ToString + " " + _
              "ORDER BY  MA.ActivityDateTime DESC "
        bdGrid(sql, ActividadesGrid)
        ActividadesGrid.Columns.Item(2).Visible = False 'creat
        ActividadesGrid.Columns.Item(3).Visible = False 'tipo
        agregarColumnaAccion(0, ActividadesGrid)
        agregarColumnaAccion(1, ActividadesGrid)
        ActividadesGrid.Visible = True
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
            nxt.transac = "RAAE"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiarCampos()
        ahora = Now
        IDL.Text = "0"
        TipoCombo.SelectedIndex = -1
        FechaPicker.Value = ahora
        HoraV.Text = ahora.Hour.ToString
        MinutosV.Text = ahora.Minute.ToString
        NotasV.Text = ""
        TipoCombo.Enabled = True
        FechaPicker.Enabled = True
        HoraV.ReadOnly = False
        MinutosV.ReadOnly = False
        NuevaActL.Text = "Nueva Actividad"
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            valoresIniciales()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevaActL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NuevaActL.LinkClicked
        limpiarCampos()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ActividadesAE
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        Dim listTable As New DataTable
        sql = "SELECT Nombres, Apellidos, Edad, EstadoAfil, semaforo, Estado_Educ, Grado, Año, Familia, clasificación, TS, dbo.fn_GEN_regionFamilia('" + S + "', Familia) as Region " + _
              "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + ahora.Year.ToString + ") L "
        bdDataTable(sql, listTable)

        If listTable.Rows.Count > 0 Then
            NombreV.Text = chequearValor(listTable.Rows(0)("Nombres")) + " " + chequearValor(listTable.Rows(0)("Apellidos"))
            EdadV.Text = " - " + chequearValor(listTable.Rows(0)("Edad"))
            FamiliaV.Text = chequearValor(listTable.Rows(0)("Familia"))
            TSV.Text = chequearValor(listTable.Rows(0)("TS"))
            RegionV.Text = chequearValor(listTable.Rows(0)("Region"))
            HoraV.Text = ahora.Hour.ToString
            MinutosV.Text = ahora.Minute.ToString

            sql = "SELECT Code, DescSpanish Actividad FROM dbo.CdMemberActivityType WHERE FunctionalArea = 'PSIC' AND Project = '" + S + "' AND Active = 1"
            bdCombo(sql, TipoCombo, "Code", "Actividad")

            historialActividadesActuales()
            MiembroV.ReadOnly = True
            FamiliaV.ReadOnly = True
            ActividadTable.Visible = True
            PanelSecundario.Visible = True
            GuardarButton.Visible = True
        Else
            MsgBox("El miembro no existe", vbExclamation, My.Resources.versionFamilias2)
            MiembroV.Text = ""
            FamiliaV.Text = ""
        End If
    End Sub


End Class