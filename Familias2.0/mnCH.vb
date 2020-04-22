' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class mnCH
    'Public S, U, L, sName As String
    Public mnuCH As New MenuStrip

    Private Sub mnCH_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        mnuCH = globales.mnuCH
        MenuList.Controls.Add(mnuCH)
        sNombre.Text = globales.sName
        Usuario.Text = globales.U
    End Sub

    Public Sub configBanner(ByRef bPanel As Panel)
        bPanel.Controls.Add(Me)
        Me.bannerTable.Dock = DockStyle.Top
        Me.Dock = DockStyle.Top
        Me.Visible = True
    End Sub

End Class
