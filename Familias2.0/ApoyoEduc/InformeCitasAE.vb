' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class InformeCitasAE
    Private Sub InformeCitasAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub


    Private Sub Informe()
        InformeGrid.DataSource = Nothing
        InformeGrid.Rows.Clear()
        InformeGrid.Visible = False
        totalL.Visible = False
        totalV.Visible = False

        Dim whereC As String = ""
        If Len(ClinicaCombo.Text) > 0 Then
            whereC = whereC + " AND cdHC.DescSpanish = '" + ClinicaCombo.Text + "' "
        End If

        If Len(TerapeutaCombo.Text) > 0 Then
            whereC = whereC + " AND MHA.EmployeeId = '" + TerapeutaCombo.Text + "' "
        End If

        If Len(AsistenciaCombo.Text) > 0 Then
            whereC = whereC + " AND cdAA.DescSpanish = '" + AsistenciaCombo.Text + "' "
        End If

        Dim deFecha As String = deFechaPicker.Value.Year.ToString + "/" + deFechaPicker.Value.Month.ToString + "/" + deFechaPicker.Value.Day.ToString
        Dim aFecha As String = aFechaPicker.Value.Year.ToString + "/" + aFechaPicker.Value.Month.ToString + "/" + aFechaPicker.Value.Day.ToString

        sql = "SELECT MHA.MemberId AS Miembro, M.FirstNames + ' ' + M.LastNames AS Nombre, CONVERT(nvarchar(50), MHA.AppointmentDateTime, 21) AS Fecha, " + _
              "cdHC.DescSpanish AS Clínica, MHA.EmployeeId AS Terapeuta, cdHCT.DescSpanish AS Tipo, cdAA.DescSpanish AS Asistencia, MHA.Notes AS Notas, " + _
              "F.FamilyId AS Familia, F.TelephoneNumber AS Celular, M.CellularPhoneNumber AS Tel_Familiar, dbo.fn_GEN_FormatDate(M.BirthDate, 'ES') AS Nacimiento, " + _
              "dbo.fn_GEN_TS(F.Project, F.FamilyId) AS TS " + _
              "FROM dbo.MemberHealthAppointment MHA INNER JOIN dbo.Member M ON MHA.Project = M.Project AND MHA.MemberId = M.MemberId AND MHA.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.Family F ON M.Project = F.Project AND M.LastFamilyId = F.FamilyId AND M.RecordStatus = F.RecordStatus " + _
              "LEFT OUTER JOIN dbo.CdHealthClinic cdHC ON MHA.HealthClinic = cdHC.Code " + _
              "LEFT OUTER JOIN dbo.CdHealthConsultationType cdHCT ON MHA.ConsultationType = cdHCT.Code " + _
              "LEFT OUTER JOIN dbo.CdAppointmentAttendance cdAA ON MHA.Attendance = cdAA.Code " + _
              "WHERE MHA.FunctionalArea = 'PSIC' AND MHA.RecordStatus = ' ' AND MHA.Project = '" + S + "' " + whereC + _
              "AND convert(smalldatetime,convert(nvarchar(30), MHA.AppointmentDateTime, 111))  " + _
              "BETWEEN  convert(smalldatetime,convert(nvarchar(30), '" + deFecha + "', 111)) " + _
              "AND convert(smalldatetime,convert(nvarchar(30), '" + aFecha + "', 111)) " + _
              "ORDER BY MHA.AppointmentDateTime DESC "
        bdGrid(sql, InformeGrid)
        totalV.Text = InformeGrid.Rows.Count.ToString

        InformeGrid.Columns(0).DefaultCellStyle.Font = New Font("Ariel", 9, FontStyle.Underline) 'miembro
        InformeGrid.Columns(0).DefaultCellStyle.ForeColor = Color.Blue
        InformeGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        InformeGrid.Visible = True
        totalL.Visible = True
        totalV.Visible = True
    End Sub

    Private Sub InformeGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InformeGrid.CellContentClick
        Dim f, c As Integer
        c = InformeGrid.CurrentCellAddress.X
        f = InformeGrid.CurrentCellAddress.Y

        If c = 0 Then
            Dim nxt As New ResumenAE
            nxt.MiembroV.Text = InformeGrid.Item(0, f).Value().ToString
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub verInformeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verInformeButton.Click
        Informe()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT EmployeeId FROM dbo.FwEmployeeRole WHERE Role = 'TERA' AND Status = 'ACTV' AND Organization = '" + S + "' "
        bdComboSinCodigo(sql, TerapeutaCombo)

        sql = "SELECT Code, DescSpanish AS Clinica FROM dbo.CdHealthClinic WHERE FunctionalArea = 'PSIC' AND Active = 1 "
        bdCombo(sql, ClinicaCombo, "Code", "Clinica")

        sql = "SELECT Code, DescSpanish 'Asistencia' FROM dbo.CdAppointmentAttendance WHERE ValidSelection = 1 "
        bdCombo(sql, AsistenciaCombo, "Code", "Asistencia")

        deFechaPicker.Size = New Point(219, 20)
        aFechaPicker.Size = New Point(219, 20)
    End Sub
End Class