Public Class ViviendaNFam

    Private Sub ViviendaNFam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        animales()

    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub animales()
        AnimalesGrid.DataSource = Nothing
        AnimalesGrid.Rows.Clear()
        'Dim listTable As New DataTable
        sql = "SELECT Code, DescSpanish AS Animales, 0 Cantidad " + _
          "FROM dbo.CdPossession  WHERE Category = 'ANIM'"
        bdGrid(sql, AnimalesGrid)
        AnimalesGrid.Columns.Item(0).Visible = False 'code
        AnimalesGrid.Columns.Item(0).ReadOnly = True

        'Dim colX As New DataGridViewTextBoxColumn
        'colX.HeaderText = "Cantidad"
        'colX.Name = "Cantidad"
        'AnimalesGrid.Columns.Add(colX)
        AnimalesGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        AnimalesGrid.Visible = True
    End Sub

    Private Sub valoresIniciales()

    End Sub
End Class