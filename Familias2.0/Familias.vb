' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class Familias

    Private Sub Busqueda_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                irPefilFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub InfoEducLink_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles InfoEducLink.LinkClicked
        Dim nxt As New BusquedaInfoEduc
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irPefilFamilia()
        If familiaEsValida(S, FamiliaV.Text) = True Then
            Dim nxt As New PerfilFamilia
            nxt.FamiliaV.Text = FamiliaV.Text
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub irPefilMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            Dim nxt As New PerfilMiembro
            nxt.MiembroV.Text = MiembroV.Text
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(MiembroV.Text) > 0 Then
                irPefilMiembro()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub OtraInfo_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles OtraInfoLink.LinkClicked
        Dim nxt As New BusquedaOtraInfo
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub traducir()
        Dim tr As New recursosFamilias
        MiembroL.Text = tr.traduce("MemberId") + ":"
        FamiliaL.Text = tr.traduce("FamilyId") + ":"
        otrasBusquedasL.Text = tr.traduce("OtherSearchs")
        OtraInfoLink.Text = tr.traduce("MemberSearchByOtherInfo")
        InfoEducLink.Text = tr.traduce("SearchByYearOfEducationInformation")
        Title.Text = tr.traduce("SearchById")
    End Sub

    Private Sub valoresIniciales()
        If S = "A" Or S = "E" Then          'Si el sitio es A o E no mostrará el LinkLabel para Búsqueda por Info de Educación
            InfoEducLink.Visible = False
        End If
        If L = "en" Then
            traducir()
        End If
        MiembroV.Focus()
    End Sub
End Class