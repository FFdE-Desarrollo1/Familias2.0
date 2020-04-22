' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActualizarTratamientoEnf

    Private Sub ActualizarTratamientoEnf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        TratamientoDate.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        sql = "INSERT INTO dbo.MemberNursTreatment " +
              "SELECT IdTreatment, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, MemberId, Physician, RefDateTime, " + _
                "Treatment, Quantity, Instruction, IdConsultation, '" + TratamientoDate.Value.ToString(en.DateTimeFormat) + "', '" + U + "','" + ObserV.Text + "' " + _
              "FROM dbo.MemberNursTreatment " + _
              "WHERE RecordStatus = ' ' AND IdTreatment = " + IdTratL.Text
        bdInsertar(sql)
        regresarAgenda()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        regresarAgenda()
    End Sub

    Private Sub regresarAgenda()
        Dim nxt As New AgendaEnfermeria
        nxt.DateP.Value = DateTime.Parse(ReferenciaV.Text())
        nxt.Show()
        Me.Close()
    End Sub
End Class