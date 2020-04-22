' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AsistenciaApadrinadosAJ

    Private Sub AsistenciaApadrinadosAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
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

    Private Sub valoresIniciales()
        TotalL.Visible = False
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        MsgBox("Este reporte puede tardar unos minutos", vbQuestion, My.Resources.versionFamilias2)
        Dim año As Integer = Today.Year

        If S = "F" Then
            sql = "SELECT * FROM dbo.fn_GJOV_GrupoJovenesF(" + año.ToString + ") L "
        ElseIf S = "N" Then
            sql = "SELECT * FROM dbo.fn_GJOV_GrupoJovenesN(" + año.ToString + ") L "
        End If
        bdGrid(sql, ListGrid)
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        TotalL.Text = "Total: " + ListGrid.Rows.Count.ToString
        TotalL.Visible = True
        ListGrid.Visible = True
    End Sub

End Class