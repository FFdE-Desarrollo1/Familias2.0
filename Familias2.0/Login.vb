' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class Login
    Dim cn As New cnSvr
    '    Dim i

    Private Sub Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        valoresIniciales()
        UsuarioV.Focus()
    End Sub

    Private Sub ContraseñaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContraseñaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            validarCredenciales()
        End If
    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        validarCredenciales()
    End Sub

    Private Sub UsuarioV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsuarioV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            validarCredenciales()
        End If
    End Sub

    Private Sub validarCredenciales()
        sql = "SELECT dbo.fn_GEN_verificarCredenciales('" + UsuarioV.Text + "','" + ContraseñaV.Text + "') R"
        Dim valida As String = cn.obtieneEntero(sql, "R")

        If valida = 1 Then
            Dim mn As New creaMnCH
            mn.preferenciasUsuario(UsuarioV.Text)

            Dim nxt As New Familias
            nxt.Show()
            Me.Close()
        ElseIf valida = 2 Then
            ErrorV.Visible = True
            ErrorV.Text = "Contraseña Incorrecta / Invalid Password"
            ContraseñaV.Text = ""
            ContraseñaV.Focus()
        Else
            ErrorV.Visible = True
            ErrorV.Text = "Usuario no válido / Invalid User"
            UsuarioV.Text = ""
            UsuarioV.Focus()
        End If
    End Sub

    Private Sub valoresIniciales()
        FamiliasName.Text = My.Resources.db + " " + My.Resources.versionFamilias2
    End Sub
End Class
