' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class RevisarVisita

    Private Sub RevisarVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New HistorialVisitas
        nxt.FamiliaV.Text = FamiliaV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        FA1.Enabled = False
        FA2.Enabled = False
        FA3.Enabled = False
        FA4.Enabled = False

        SA1.Enabled = False
        SA2.Enabled = False
        SA3.Enabled = False

        ED1.Enabled = False
        ED2.Enabled = False
        ED3.Enabled = False
        ED4.Enabled = False

        PL1.Enabled = False
        PL2.Enabled = False
        PL3.Enabled = False
        PL4.Enabled = False
        PL5.Enabled = False
        PL6.Enabled = False


        TipoVisitaL.Visible = True
        TipoVisitaV.Visible = True
        FechaL.Visible = True
        FechaV.Visible = True
        HoraL.Visible = True
        HoraV.Visible = True

        TSTable.Visible = True
    End Sub


End Class