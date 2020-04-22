Public Class SolicitudesVivienda

    Private Sub SolicitudesVivienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim accion = FamiliasList.Item(2, f).Value()
        Dim familia = FamiliasList.Item(3, f).Value()

        If accion = "INGRESAR" Then
            Dim nxt As New NuevaSolicitud
            nxt.FamiliaV.Text = familia
            nxt.idAnalisis = FamiliasList.Item(0, f).Value() 'IdAnalysis
            nxt.Show()
            Me.Close()
        ElseIf accion = "Actualizar" Then
            Dim nxt As New ActualizarSolicitud
            nxt.FamiliaV.Text = familia
            nxt.idSolicitud = FamiliasList.Item(1, f).Value() 'IdSolicitude
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

        Dim estadoS As String = ""
        If Len(EstadoCombo.Text) > 0 Then
            estadoS = "AND EstadoSolicitud = '" + EstadoCombo.Text + "' "
        End If

        sql = "SELECT IdAnalysis, IdSolicitude, CASE WHEN IdSolicitude IS NULL THEN 'INGRESAR' ELSE 'Actualizar' END '_', " + _
              "Familia, FechaAnalisis, Aplica, EstadoSolicitud, FechaEstadoSolicitud, NotasAnalisis, TotalHrs 'Total Hrs.', " + _
              "HrsTrabajadas 'Hrs. Trabajadas', Exoneracion, Solicitud, Cantidad, Tamaño, Piso, Paredes, Techo, NotasSolicitud, Visita, " + _
              "Construccion, Brigada, Entrega, FotoInicial, FotoFinal " + _
              "FROM dbo.v_AMBF_SolicitudesVivienda WHERE Project = '" + S + "'" + estadoS
        bdGrid(sql, FamiliasList)
        'InputBox("", "", sql)
        TotalL.Text = "Total: " + FamiliasList.RowCount.ToString
        TotalL.Visible = True
        FamiliasList.Columns.Item(0).Visible = False 'IdAnalysis
        FamiliasList.Columns.Item(1).Visible = False 'IdSolicitude 
        FamiliasList.Visible = True

        FamiliasList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        agregarColumnaAccion(2, FamiliasList)
        For i = 0 To FamiliasList.RowCount - 1
            If FamiliasList.Item(2, i).Value() = "INGRESAR" Then
                FamiliasList.Rows(i).Cells(2).Style.BackColor = Color.Navy
                FamiliasList.Rows(i).Cells(2).Style.ForeColor = Color.White
                FamiliasList.Rows(i).Cells(3).Style.BackColor = Color.Navy
                FamiliasList.Rows(i).Cells(3).Style.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code,  DescSpanish Type FROM CdFamilyProgramStatus WHERE Active = 1 ORDER BY Orden "
        bdCombo(sql, EstadoCombo, "Code", "Type")

        VerListadoButton.Focus()
        listado()
    End Sub

    Private Sub VerListadoButton_Click(sender As Object, e As EventArgs) Handles VerListadoButton.Click
        listado()
    End Sub


End Class