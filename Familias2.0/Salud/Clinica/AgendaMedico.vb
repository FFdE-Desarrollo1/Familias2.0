' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AgendaMedico
    Public IDApp As Integer

    Dim dt As New DataTable
    Dim desc, clinic As String
    Dim turno, con, admin As Integer

    Private Sub AgendaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        DoctorC.Focus()
        chequearUsuario()
        If Len(DoctorC.Text) > 0 Then
            infoGen()
        End If
    End Sub

    Private Sub AgendaMedico_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        infoGen()
    End Sub

    Private Sub AgendaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AgendaGrid.CellContentClick
        Dim f, c, idConsult, IdApp, memberId As Integer
        Dim nombre, edad, fam, medico, notas, clinica As String
        Dim sMember As String

        c = AgendaGrid.CurrentCellAddress.X
        f = AgendaGrid.CurrentCellAddress.Y

        If AgendaGrid.RowCount > 0 Then

            IdApp = AgendaGrid.Item(0, f).Value()
            idConsult = AgendaGrid.Item(1, f).Value()
            memberId = AgendaGrid.Item(6, f).Value()
            sMember = AgendaGrid.Item(5, f).Value()
            nombre = AgendaGrid.Item(7, f).Value()
            edad = AgendaGrid.Item(8, f).Value()
            fam = AgendaGrid.Item(9, f).Value()
            notas = AgendaGrid.Item(10, f).Value()
            clinica = AgendaGrid.Item(11, f).Value()
            medico = chequearValor(AgendaGrid.Item(12, f).Value())

            If c = 2 Then
                If idConsult = 0 Then
                    irAgregarConsulta(memberId, sMember, IdApp, nombre, edad, fam, notas, clinica, medico) ' agregar consulta
                ElseIf idConsult > 0 Then
                    irModificarConsulta(memberId, sMember, IdApp, idConsult, nombre, edad, fam, notas, clinica, medico) 'modificar consulta
                Else
                End If
            ElseIf c = 3 Then
                If idConsult > 0 Then
                    irRevisarConsulta(memberId, sMember, IdApp, idConsult) ' revisar consulta
                Else
                End If
            Else
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub chequearUsuario()
        sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
              "WHERE Status = 'ACTV' AND Role = 'SUPE' AND EmployeeId = '" + U + "' AND ORGANIZATION NOT IN('N', 'R', 'M')"
        admin = bdEntero(sql, "Total")

        sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
              "WHERE Status = 'ACTV' AND Role = 'DS' AND EmployeeId = '" + U + "'"
        Dim ds As Integer = bdEntero(sql, "Total")

        sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
              "WHERE Status = 'ACTV' AND Role = 'MEDI' AND EmployeeId = '" + U + "'"

        If bdEntero(sql, "Total") = 0 Or ds > 0 Then
            If S = "F" Or S = "S" Or S = "E" Or S = "A" Then
                sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization ='F' "
            Else
                sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization = '" + S + "' "
            End If

            bdComboSinCodigo(sql, DoctorC)
            DoctorC.Enabled = True
        Else
            DoctorC.Text = U
        End If
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        infoGen()
    End Sub

    Private Sub infoGen()
        AgendaGrid.DataSource = Nothing
        AgendaGrid.Rows.Clear()
        totalL.Visible = False
        Dim drW As String

        If (DoctorC.Text = "" Or DoctorC.Text = " ") And DoctorC.SelectedIndex = -1 Then
            drW = " "
        Else
            drW = " AND (MCA.EmployeeId IS NULL OR MCA.EmployeeId = '" + DoctorC.Text + "') "
        End If


        sql = "SELECT MCA.AppId, CASE WHEN MCC.IdConsultation IS NULL THEN 0 ELSE MCC.IdConsultation END IdConsultation, " + _
              "CASE WHEN MCC.IdConsultation IS NOT NULL THEN 'Modificar' ELSE 'Nueva' END Actualizar, CASE WHEN MCC.IdConsultation IS NOT NULL " + _
              "THEN 'Revisar' ELSE '' END Revisar, MCA.Turn Turno, M.Project Sitio, M.MemberId Paciente, M.FirstNames + ' ' + M.LastNames Nombre, " + _
              "dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad, M.LastFamilyId Familia, MCA.Notes AS Observaciones, cdT.DescSpanish Clínica, MCA.EmployeeId AS Médico " + _
              "FROM dbo.MemberClinicAppointment MCA " + _
              "INNER JOIN dbo.Member M ON MCA.Project = M.Project AND MCA.MemberId = M.MemberId AND MCA.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.CdHealthClinic cdC ON MCA.HealthClinic = cdC.Code " + _
              "INNER JOIN dbo.CdAppointmentStatus cdS ON MCA.Status = cdS.Code " + _
              "INNER JOIN dbo.CdHealthConsultationType cdT ON MCA.ConsultationType = cdT.Code " + _
              "LEFT OUTER JOIN dbo.MemberClinicConsultation MCC ON MCC.AppId = MCA.AppId AND MCC.RecordStatus = MCA.RecordStatus " + _
              "WHERE MCA.RecordStatus = ' ' AND MCA.Status = 'COMP' " + drW + _
              " AND YEAR(AppointmentDateTime) = " + DateP.Value.Year.ToString + " AND MONTH(AppointmentDateTime) = " + DateP.Value.Month.ToString + _
              " AND DAY(AppointmentDateTime) = " + DateP.Value.Day.ToString + _
              " ORDER BY MCC.IdConsultation, MCA.Turn "
        bdGrid(sql, AgendaGrid)
        'InputBox("", "", sql)

        agregarColumnaAccion(2, AgendaGrid)
        agregarColumnaAccion(3, AgendaGrid)

        If admin = 0 Then
            AgendaGrid.Columns.Item(0).Visible = False 'idApp
            AgendaGrid.Columns.Item(1).Visible = False 'idConsul
        Else
            AgendaGrid.Columns.Item(0).Visible = True 'idApp
            AgendaGrid.Columns.Item(1).Visible = True 'idConsul
        End If

        dt.Clear()
        AgendaGrid.ClearSelection()
        For i = 0 To dt.Rows.Count - 1
            AgendaGrid.Rows(i).HeaderCell.Value = i '(i + 1).ToString
        Next

        totalL.Text = "Total: " + AgendaGrid.RowCount.ToString
        totalL.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irAgregarConsulta(ByVal member As Integer,
                                  ByVal sMember As String, _
                                  ByVal app As Integer, _
                                  ByVal nombre As String, _
                                  ByVal edad As String, _
                                  ByVal fam As String, _
                                  ByVal notas As String, _
                                  ByVal clinica As String, _
                                  ByVal medico As String)
        Dim consu As New ConsultaMedica
        consu.memberId = member
        consu.sMember = sMember
        consu.PacienteV.Text = member.ToString
        consu.NombreV.Text = nombre
        consu.EdadV.Text = "(" + edad + ")"
        consu.FamiliaV.Text = fam
        consu.obsV.Text = chequearValor(notas)
        consu.DrL.Text = medico
        consu.ClinicaL.Text = "Clínica: " + clinica
        consu.appid = app
        consu.Show()
        Me.Close()
    End Sub

    Private Sub irModificarConsulta(ByVal member As Integer,
                              ByVal sMember As String, _
                              ByVal app As Integer, _
                              ByVal idCon As Integer, _
                              ByVal nombre As String, _
                              ByVal edad As String, _
                              ByVal fam As String, _
                              ByVal notas As String, _
                              ByVal clinica As String, _
                              ByVal medico As String)
        Dim consu As New ModificarConsultaMedica

        consu.memberId = member
        consu.sMember = sMember
        consu.appid = app
        consu.consId = idCon
        consu.preTrans = "NCMS"
        consu.PacienteV.Text = member.ToString
        consu.NombreV.Text = nombre
        consu.EdadV.Text = "(" + edad + ")"
        consu.FamiliaV.Text = fam
        consu.obsV.Text = chequearValor(notas)
        consu.DrL.Text = medico
        consu.Show()
        Me.Close()
    End Sub

    Private Sub irRevisarConsulta(ByVal member As Integer,
                                  ByVal sMember As String, _
                                  ByVal app As Integer, _
                                  ByVal cons As Integer)
        Dim consu As New RevisarConsultaMedica
        consu.memberId = member
        consu.sMember = sMember
        consu.appid = app
        consu.consid = cons
        consu.preTrans = "NCMS"
        consu.Show()
        Me.Close()
    End Sub

End Class