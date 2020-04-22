' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0
' @code RPFT

Public Class Posesiones

    Private Sub Posesiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub


    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub valoresIniciales()
        ''  "' AND FP.FamilyId = " + FamiliaV.Text + " " + _
        'sql = "SELECT cdP.Code, cdP.DescSpanish Tipo, FP.Quantity Cantidad " + _
        '      "FROM dbo.CdPossession cdP LEFT OUTER JOIN " + _
        '      "dbo.FamilyPossession FP ON cdP.Code = FP.Possession AND FP.RecordStatus = ' ' AND FP.Project = '" + S + _
        '      "' AND FP.FamilyId = 1703 " + _
        '      "WHERE cdP.Category = 'ANIM' "

        'sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliares('f', 1703, 'en')"
        FamiliaV.Text = "1703"
        posesiones()
    End Sub

    Private Sub posesiones()
        sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliaresCat('" + S + "', " + FamiliaV.Text + ", 'en', 'ANIM')"
        llenarGrid(animGrid, sql)

        sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliaresCat('" + S + "', " + FamiliaV.Text + ", 'en', 'APEL')"
        llenarGrid(apelGrid, sql)

        sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliaresCat('" + S + "', " + FamiliaV.Text + ", 'en', 'COSE')"
        llenarGrid(coseGrid, sql)

        sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliaresCat('" + S + "', " + FamiliaV.Text + ", 'en', 'ESTU')"
        llenarGrid(estuGrid, sql)

        sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliaresCat('" + S + "', " + FamiliaV.Text + ", 'en', 'MASC')"
        llenarGrid(mascGrid, sql)

        sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliaresCat('" + S + "', " + FamiliaV.Text + ", 'en', 'MUEB')"
        llenarGrid(muebGrid, sql)

        sql = "SELECT * FROM dbo.fn_TS_PosesionesFamiliaresCat('" + S + "', " + FamiliaV.Text + ", 'en', 'TRAN')"
        llenarGrid(tranGrid, sql)
    End Sub

    Private Sub llenarGrid(ByRef catGrid As DataGridView, ByVal lista As String)
        catGrid.DataSource = Nothing
        catGrid.Rows.Clear()
        catGrid.Visible = False
        catGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        bdGrid(lista, catGrid)
        catGrid.Columns.Item(0).Visible = False 'code
        catGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        catGrid.AllowUserToResizeColumns = True
        catGrid.Visible = True
    End Sub

End Class