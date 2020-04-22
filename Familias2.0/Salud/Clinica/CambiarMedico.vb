' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class CambiarMedico
    Dim medicoOr As String
    Dim IdApp As Integer

    Private Sub CambiarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub CambiarMedico_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        llenarAgenda()
    End Sub

    Private Sub ActualizarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarButton.Click
        If medicoOr = nuevoMedico.Text Then
            MsgBox("Ha seleccionado el mismo médico que tiene asignado el paciente", vbInformation, My.Resources.versionFamilias2)
        ElseIf nuevoMedico.SelectedIndex = -1 Then
            MsgBox("Necesita seleccionar un médico del listado ""Cambiar a"" ", vbInformation, My.Resources.versionFamilias2)
        Else
            If Len(medicoOr) = 0 Then
                sql = "INSERT INTO dbo.MemberClinicAppointment " + _
                        "SELECT AppId, GETDATE(), Project, MemberId, AppointmentDateTime, RecordStatus, '" + U + "', ExpirationDateTime, HealthClinic, '" + nuevoMedico.Text + "', " + _
                        " ConsultationType, Status, Turn, AMorPM, Temperature, Weight, Stature, BloodPressure, HeartRate, RespiratoryRate, Notes, IdConsultationReference " + _
                        "FROM dbo.MemberClinicAppointment WHERE RecordStatus = ' ' AND AppId = " + IdApp.ToString
                bdInsertar(sql)
                MsgBox("Los cambios se han guardado correctamente", vbInformation, My.Resources.versionFamilias2)
                llenarAgenda()
            Else
                Dim newMedic As String = nuevoMedico.Text
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                response = MsgBox("Este paciente ya tiene un médico asignado" + vbNewLine + _
                                   "(verifique que no haya sido atendido por otro médico)" + vbNewLine + vbNewLine + _
                                   "¿Esta seguro de cambiar el médico?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    sql = "INSERT INTO dbo.MemberClinicAppointment " + _
                            "SELECT AppId, GETDATE(), Project, MemberId, AppointmentDateTime, RecordStatus, '" + U + "', ExpirationDateTime, HealthClinic, '" + newMedic + "', " + _
                            " ConsultationType, Status, Turn, AMorPM, Temperature, Weight, Stature, BloodPressure, HeartRate, RespiratoryRate, Notes + '(cambio médico)', IdConsultationReference " + _
                            "FROM dbo.MemberClinicAppointment WHERE RecordStatus = ' ' AND AppId = " + IdApp.ToString
                    bdInsertar(sql)
                    MsgBox("Los cambios se han guardado correctamente", vbInformation, My.Resources.versionFamilias2)
                    llenarAgenda()
                End If
            End If
        End If
    End Sub

    Private Sub AgendaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AgendaGrid.CellContentClick
        Dim f, c, memberId As Integer
        Dim paciente As String

        c = AgendaGrid.CurrentCellAddress.X
        f = AgendaGrid.CurrentCellAddress.Y

        If c = 5 Then
            IdApp = AgendaGrid.Item(0, f).Value()
            memberId = AgendaGrid.Item(4, f).Value()
            paciente = AgendaGrid.Item(5, f).Value()
            medicoOr = chequearValor(AgendaGrid.Item(14, f).Value())

            memberIdV.Text = memberId.ToString
            PacienteV.Text = paciente
            MedicoV.Text = medicoOr
            CitaInfoTable.Visible = True
        End If
    End Sub

    Private Sub AgendaMedico_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        llenarAgenda()
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

    Private Sub llenarAgenda()
        Dim sitioW As String

        If S = "F" Or S = "S" Or S = "E" Or S = "A" Then
            sitioW = "IN('E', 'F', 'S', 'A')"
        Else
            sitioW = " = '" + S + "'"
        End If

        Dim actualDate As DateTime = Now

        sql = "SELECT MHA.AppId, CASE WHEN MCC.IdConsultation IS NULL THEN 0 ELSE MCC.IdConsultation END IdConsultation, MHA.AMorPM AM_PM, MHA.Turn AS Turno, M.MemberId AS Paciente, " + _
              "M.FirstNames + ' ' + M.LastNames AS Nombre, M.LastFamilyId AS Familia, cdAS.DescSpanish AS Estado, cdHCT.DescSpanish AS Tipo, cdHC.DescSpanish AS Clínica, " + _
              "MHA.Temperature AS Temperatura, MHA.Weight AS Peso, MHA.Stature AS Estatura, MHA.BloodPressure AS Presión, MHA.EmployeeId AS Médico, " + _
              "MHA.AppointmentDateTime  Fecha, MHA.Notes Observaciones " + _
              "FROM dbo.MemberClinicAppointment MHA LEFT JOIN " + _
              "dbo.MemberClinicConsultation MCC ON MCC.AppId = MHA.AppId AND MCC.RecordStatus = MHA.RecordStatus INNER JOIN " + _
              "dbo.Member M ON MHA.Project = M.Project AND MHA.MemberId = M.MemberId AND MHA.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.CdAppointmentStatus cdAS ON MHA.Status = cdAS.Code " + _
              "LEFT OUTER JOIN dbo.CdHealthClinic cdHC ON MHA.HealthClinic = cdHC.Code " + _
              "LEFT OUTER JOIN dbo.CdHealthConsultationType cdHCT ON MHA.ConsultationType = cdHCT.Code  " + _
              "WHERE MCC.IdConsultation IS NULL AND MHA.RecordStatus = ' '  AND  MHA.Status = 'COMP' " + _
              " AND YEAR(AppointmentDateTime) = " + actualDate.Year.ToString + " AND MONTH(AppointmentDateTime) = " + actualDate.Month.ToString + _
              " AND DAY(AppointmentDateTime) = " + actualDate.Day.ToString + _
              " ORDER BY MHA.Turn, MHA.AppointmentDateTime, MHA.EmployeeId"
        bdGrid(sql, AgendaGrid)
        AgendaGrid.Columns.Item(0).Visible = False 'AppId
        AgendaGrid.Columns.Item(1).Visible = False 'IdConsultation
        AgendaGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        AgendaGrid.AutoResizeColumns()

        sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization ='F' "
        bdComboSinCodigo(sql, nuevoMedico)

        CitaInfoTable.Visible = False
    End Sub

    Private Sub RetornoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetornoButton.Click
        Dim amed As New AgendaMedico
        amed.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        llenarAgenda()
    End Sub

End Class