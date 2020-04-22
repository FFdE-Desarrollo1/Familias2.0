' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class CambiarPreferencias
    Dim nCambios As Integer = 0

    Private Sub CambiarSitio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub actualizarSitio()
        sql = "UPDATE dbo.FwEmployee SET DefaultOrganization = '" + SitioCombo.SelectedValue + "' " + _
                    "WHERE EmployeeId = '" + U + "'"
        bdInsertar(sql)
        nCambios = nCambios + 1
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub cambiarLenguaje()
        Dim nL As String
        If L = "en" Then
            nL = "es"
        Else
            nL = "en"
        End If
        sql = "UPDATE dbo.FwEmployee SET PreferredLanguage = '" + nL + "' " + _
            "WHERE EmployeeId = '" + U + "'"
        bdInsertar(sql)
        nCambios = nCambios + 1
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(SitioCombo.Text) > 0 Then
            actualizarSitio()
        End If

        If LenguajeCheck.Checked = True Then
            cambiarLenguaje()
        End If

        If nCambios > 0 Then
            Dim mn As New creaMnCH
            mn.preferenciasUsuario(globales.U)

            Dim nxt As New Familias
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub traducir()
        Dim tr As New recursosFamilias
        LenguajeCheck.Text = tr.traduce("ChangeLanguage")
        SitioL.Text = tr.traduce("Site")
        Title.Text = tr.traduce("ChangePreferences")
    End Sub
    Private Sub valoresIniciales()
        traducir()

        sql = "SELECT  code codigo, " + descripcion() + " sitio FROM  dbo.FwCdOrganization F WHERE Code NOT IN('*','" + S + "') ORDER BY " + descripcion() + " "
        bdCombo(sql, SitioCombo, "codigo", "sitio")

    End Sub
End Class