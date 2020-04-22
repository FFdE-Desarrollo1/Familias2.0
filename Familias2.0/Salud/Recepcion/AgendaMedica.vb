' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AgendaMedica
    Dim memberId, familyId, turno As Integer

    Private Sub AgendaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub AgendaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AgendaGrid.CellContentClick
        Dim f, c, idConsult, Id As Integer
        c = AgendaGrid.CurrentCellAddress.X
        f = AgendaGrid.CurrentCellAddress.Y
        Id = AgendaGrid.Item(2, f).Value()
        idConsult = AgendaGrid.Item(3, f).Value()

        If c = 0 Then ' modificar
            irModificarCita(Id)
        ElseIf c = 1 Then 'borrar
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            response = MsgBox("¿Esta seguro de querer borrar la cita? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                If idConsult = 0 Then
                    borrarCita(Id)
                Else
                    MsgBox("No se puede borrar una cita que ya tenga información de la consulta", vbQuestion, My.Resources.versionFamilias2)
                End If
            End If
        Else
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrarCita(ByVal idapp As Integer)
        sql = "UPDATE dbo.MemberClinicAppointment SET RecordStatus = 'H', ExpirationDateTime = GETDATE() " + _
            "WHERE Project = '" + S + "' AND RecordStatus = ' ' AND AppId = " + idapp.ToString
        bdEjecutarSQL(sql)
        MsgBox("La cita ya ha sido borrada", vbQuestion, My.Resources.versionFamilias2)
        llenarAgenda()
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        If StatusC.Text <> "" And StatusC.SelectedIndex = -1 Then
            MsgBox("El estado no es válido", vbQuestion, My.Resources.versionFamilias2)
        Else
            llenarAgenda()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irModificarCita(ByVal idapp As Integer)
        Dim modCita As New ModificarPreconsulta
        modCita.IDApp = idapp
        modCita.Show()
        Me.Close()
    End Sub

    Private Sub llenarAgenda()
        Dim sitioW, estadoW, drW As String
        If S = "F" Or S = "S" Or S = "E" Or S = "A" Then
            sitioW = "IN('E', 'F', 'S', 'A')"
        Else
            sitioW = " = '" + S + "'"
        End If

        If Len(DoctorC.Text) = 0 Then
            drW = ""
        Else
            drW = " AND MHA.EmployeeId = '" + DoctorC.Text + "' "
        End If

        If Len(StatusC.Text) = 0 Then
            estadoW = ""
        Else
            estadoW = " AND cdAS.DescSpanish = '" + StatusC.Text + "' "
        End If

        sql = "SELECT MHA.AppId, CASE WHEN MCC.IdConsultation IS NULL THEN 0 ELSE MCC.IdConsultation END IdConsultation, MHA.AMorPM AM_PM, MHA.Turn AS Turno, M.MemberId AS Paciente, " + _
              "M.FirstNames + ' ' + M.LastNames AS Nombre, M.LastFamilyId AS Familia, cdAS.DescSpanish AS Estado, cdHCT.DescSpanish AS Tipo, cdHC.DescSpanish AS Clínica, " + _
              "MHA.Temperature AS Temperatura, MHA.Weight AS 'Peso (lb)', MHA.Stature AS 'Estatura (m)', MHA.BloodPressure AS Presión, MHA.HeartRate fCardiaca, MHA.RespiratoryRate fRespiratoria, " + _
              "MHA.Notes AS Observaciones, MHA.EmployeeId AS Médico, MHA.AppointmentDateTime  Fecha " + _
              "FROM dbo.MemberClinicAppointment MHA INNER JOIN " + _
              "dbo.Member M ON MHA.Project = M.Project AND MHA.MemberId = M.MemberId AND MHA.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.CdAppointmentStatus cdAS ON MHA.Status = cdAS.Code " + _
              "LEFT OUTER JOIN dbo.CdHealthClinic cdHC ON MHA.HealthClinic = cdHC.Code " + _
              "LEFT OUTER JOIN dbo.CdHealthConsultationType cdHCT ON MHA.ConsultationType = cdHCT.Code  " + _
              "LEFT OUTER JOIN dbo.MemberClinicConsultation MCC ON  MHA.AppId = MCC.AppId AND MHA.RecordStatus = MCC.RecordStatus " + _
              "WHERE MHA.Project " + sitioW + " AND MHA.RecordStatus = ' '  " + _
              "AND YEAR(AppointmentDateTime) = " + DateP.Value.Year.ToString + " AND MONTH(AppointmentDateTime) = " + DateP.Value.Month.ToString + _
              " AND DAY(AppointmentDateTime) = " + DateP.Value.Day.ToString + drW + " " + estadoW + _
              " ORDER BY MHA.AMorPM DESC, MHA.Turn, MHA.AppointmentDateTime"
        bdGrid(sql, AgendaGrid)
        'InputBox("", "", sql)
        AgendaGrid.Columns.Item(2).Visible = False 'AppId
        AgendaGrid.Columns.Item(3).Visible = False 'IdConsultation

        For i = 0 To AgendaGrid.Rows.Count - 1
            AgendaGrid.Rows(i).HeaderCell.Value = (i + 1).ToString

            If AgendaGrid.Item(3, i).Value() = "0" Then
                AgendaGrid.Item(0, i).Value = "Modificar"
            End If

            AgendaGrid.Item(1, i).Value = "Borrar"
        Next
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization ='F' "
        bdComboSinCodigo(sql, DoctorC)

        sql = "SELECT DescSpanish FROM CdAppointmentStatus WHERE Active = 1 "
        bdComboSinCodigo(sql, StatusC)

        StatusC.Text = "Pendiente datos Pre-consulta"
        DoctorC.Focus()
        llenarAgenda()
    End Sub
End Class