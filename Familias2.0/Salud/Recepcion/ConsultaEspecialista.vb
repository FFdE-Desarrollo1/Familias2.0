Public Class ConsultaEspecialista

    Private Sub ConsultaEspecialista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Medicinas_CheckedChanged(sender As Object, e As EventArgs) Handles Medicinas.CheckedChanged
        If Medicinas.Checked = True Then
            FarmaciaPanel.Visible = True
        Else
            FarmaciaPanel.Visible = False
        End If
    End Sub


End Class