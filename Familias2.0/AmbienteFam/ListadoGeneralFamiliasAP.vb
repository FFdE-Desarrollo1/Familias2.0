Public Class ListadoGeneralFamiliasAP

    Private Sub ListadoGeneralFamiliasAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliasList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FamiliasList.CellContentClick
        Dim c = FamiliasList.CurrentCellAddress.X
        Dim f = FamiliasList.CurrentCellAddress.Y
        Dim accion = FamiliasList.Item(0, f).Value()
        Dim familia = FamiliasList.Item(1, f).Value()

        If accion = "INGRESAR" Then
            Dim nxt As New PreAnalisisVivienda
            nxt.FamiliaV.Text = familia
            nxt.Show()
            Me.Close()
        ElseIf accion = "Actualizar" Then
            Dim nxt As New ActualizarPreAnalisis
            nxt.FamiliaV.Text = familia
            nxt.idSolicitud = FamiliasList.Item(12, f).Value()
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        FamiliasList.DataSource = Nothing
        FamiliasList.Rows.Clear()
        FamiliasList.Visible = False

        Dim ts As String = ""
        If Len(TSlist.Text) > 0 Then
            ts = " AND TS = '" + TSlist.Text + "' "
        End If

        Dim region As String = ""
        If Len(RegionV.Text) > 0 Then
            region = " AND Región = '" + RegionV.Text + "' "
        End If

        Dim aplica As String = ""
        If Len(AplicaCombo.Text) > 0 Then
            aplica = " AND Aplica = '" + AplicaCombo.Text + "' "
        End If

        sql = "SELECT CASE WHEN Aplica = '' THEN 'INGRESAR' ELSE CASE WHEN IdSolicitude IS NULL THEN 'Actualizar' ELSE '' END END AS 'Analisis', Familia, Pueblo, " + _
              "Clasificación, TS, Región, Fecha, Aplica,  Diagnostico, Comentarios, Notas, Usuario, IdAnalysis, IdSolicitude " + _
              "FROM dbo.v_AMBF_AnalisisPreliminar " + _
              "WHERE Project = '" + S + "' AND EstadoAfil = 'AFIL' " + ts + region + aplica
        bdGrid(sql, FamiliasList)
        'InputBox("", "", sql)

        TotalL.Text = "Total: " + FamiliasList.RowCount.ToString
        TotalL.Visible = True
        FamiliasList.Visible = True
        FamiliasList.Columns.Item(12).Visible = False 'IdAnalisis
        FamiliasList.Columns.Item(13).Visible = False 'IdSolicitud
        FamiliasList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        agregarColumnaAccion(0, FamiliasList)

        For i = 0 To FamiliasList.RowCount - 1
            If FamiliasList.Item(0, i).Value() = "INGRESAR" Then
                FamiliasList.Rows(i).Cells(1).Style.BackColor = Color.Navy
                FamiliasList.Rows(i).Cells(1).Style.ForeColor = Color.White
                FamiliasList.Rows(i).Cells(0).Style.BackColor = Color.Navy
                FamiliasList.Rows(i).Cells(0).Style.ForeColor = Color.White
                'FamiliasList.Rows(i).Cells(1).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            End If
        Next
        'FamiliasList.AllowUserToOrderColumns = False
        ' FamiliasList.AllowUserToResizeColumns = False
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs)
        Dim nxt As New ListadoGeneralFamiliasAP
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT EmployeeId AS TS FROM dbo.FwEmployeeRole WHERE Role = 'TS' AND Status = 'actv' AND Organization = '" + S + "'"
        bdComboSinCodigo(sql, TSlist)
        VerListadoButton.Focus()
        listado()
    End Sub

    Private Sub VerListadoButton_Click(sender As Object, e As EventArgs) Handles VerListadoButton.Click
        listado()
    End Sub

End Class