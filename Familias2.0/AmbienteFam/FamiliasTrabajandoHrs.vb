Public Class FamiliasTrabajandoHrs

    Private Sub FamiliasTrabajandoHrs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        listado()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
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

        sql = "SELECT IdSolicitude, 'Ingresar Horas' '_',  Familia, AñoAnalisis, TotalHrs AS 'Total Hrs.', HrsTrabajadas AS 'Hrs. Trabajadas', TotalHrs - HrsTrabajadas AS 'Hrs. Faltantes' " + _
              "FROM dbo.v_AMBF_SolicitudesVivienda WHERE Project = '" + S + "' AND (HrsTrabajadas < TotalHrs) "
        bdGrid(sql, FamiliasList)
        TotalL.Text = "Total: " + FamiliasList.RowCount.ToString
        TotalL.Visible = True
        FamiliasList.Columns.Item(0).Visible = False 'IdSolicitude 
        FamiliasList.Visible = True

        FamiliasList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        agregarColumnaAccion(2, FamiliasList)
    End Sub

    Private Sub FamiliasList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FamiliasList.CellContentClick
        Dim c = FamiliasList.CurrentCellAddress.X
        Dim f = FamiliasList.CurrentCellAddress.Y

        If c = 1 Then
            Dim nxt As New IngresarHoras
            nxt.FamiliaV.Text = FamiliasList.Item(2, f).Value()
            nxt.idSolicitud = FamiliasList.Item(0, f).Value() 'IdSolicitud
            nxt.Show()
            Me.Close()
        End If
    End Sub
End Class