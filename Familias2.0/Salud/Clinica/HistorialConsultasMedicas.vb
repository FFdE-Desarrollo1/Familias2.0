' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class HistorialConsultasMedicas
    Public sMember As String
    Public memberId, appid As Integer

    Dim desc, dosage As String

    Private Sub HistorialConsultasMedicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()
        If Len(PacienteV.Text) = 0 Then
        Else
            historial()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub PacienteV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PacienteV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(PacienteV.Text) = 0 Then
            Else
                historial()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) = 0 Then
            Else
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub historial()
        If miembroEsValido(S, PacienteV.Text) Then

            Dim listTable As New DataTable
            sql = "SELECT  M.LastFamilyId AS Familia, M.FirstNames + ' ' + M.LastNames AS Nombre, DATEDIFF(M, M.BirthDate, GETDATE()) / 12 AS Edad " + _
                    "FROM  dbo.Member M INNER JOIN dbo.Family F ON F.Project = M.Project AND F.FamilyId = M.LastFamilyId AND F.RecordStatus = M.RecordStatus " + _
                    "LEFT JOIN dbo.CdFamilyClassification cdCl ON cdCl.Code = F.Classification " + _
                    "WHERE M.RecordStatus = ' ' AND M.MemberId = " + PacienteV.Text + " AND M.Project = '" + S + "' "
            bdDataTable(sql, listTable)

            NombreV.Text = listTable.Rows(0)("Nombre")
            EdadV.Text = " - " + listTable.Rows(0)("Edad").ToString + " año(s)"
            FamiliaV.Text = listTable.Rows(0)("Familia").ToString

            PacienteV.ReadOnly = False
            FamiliaV.ReadOnly = False

            sql = "SELECT MCA.AppId, CASE WHEN MCC.IdConsultation IS NULL THEN 0 ELSE MCC.IdConsultation END IdConsultation, M.Project, MCA.Turn AS Turno,  CONVERT(varchar(20), " + _
                  "MCA.AppointmentDateTime, 13) AS Cita, cdC.DescSpanish AS Clínica, cdT.DescSpanish AS Tipo, MCA.Notes AS Observaciones, " + _
                  "MCA.EmployeeId AS Médico, CONVERT(varchar(20), MCC.ConsultationDateTime, 13) AS Consulta, cdD1.DescSpanish AS 'Diagnostico Principal' " + _
                  "FROM dbo.MemberClinicAppointment MCA INNER JOIN dbo.Member M ON MCA.Project = M.Project AND MCA.MemberId = M.MemberId AND MCA.RecordStatus = M.RecordStatus " + _
                  "INNER JOIN dbo.CdHealthClinic cdC ON MCA.HealthClinic = cdC.Code INNER JOIN dbo.CdHealthConsultationType cdT ON MCA.ConsultationType = cdT.Code " + _
                  "LEFT OUTER JOIN dbo.MemberClinicConsultation MCC ON MCA.AppId = MCC.AppId AND MCA.RecordStatus = MCC.RecordStatus " + _
                  "LEFT OUTER JOIN dbo.CdDiagnosis cdD1 ON MCC.PrimaryDiagnosis = cdD1.Code " + _
                  "WHERE MCA.RecordStatus = ' ' AND MCA.Project = '" + S + "' AND MCA.MemberId = " + PacienteV.Text + _
                  " ORDER BY MCA.AppointmentDateTime "
            sql = "SELECT CASE WHEN IdConsultation = 0 THEN '' ELSE 'Modificar Consulta' END '_', CASE WHEN IdConsultation = 0 THEN '' ELSE 'Revisar Consulta' END '-', " + _
                  "AppId, IdConsultation, Fecha, Clinica, TipoConsulta, Observaciones, Médico, Diagnostico1 'Diagnostico Principal'   " + _
                  "FROM   dbo.fn_HEAL_CLIN_HistorialConsultas('" + S + "', " + PacienteV.Text + ")  " + _
                  "ORDER BY ConsultationDateTime DESC "
            bdGrid(sql, HistorialGrid)
            PacienteV.ReadOnly = True
            FamiliaV.ReadOnly = True
            agregarColumnaAccion(0, HistorialGrid)
            agregarColumnaAccion(1, HistorialGrid)
            HistorialGrid.Columns.Item(2).Visible = False 'idAPP
            HistorialGrid.Columns.Item(3).Visible = False 'IdConsul
            PanelSecundario.Visible = True
            HistorialGrid.Visible = True
        Else
            PacienteV.Text = ""
        End If
    End Sub

    Private Sub HistorialGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        Dim f, c, idConsult, Id As Integer

        c = HistorialGrid.CurrentCellAddress.X
        f = HistorialGrid.CurrentCellAddress.Y
        Id = HistorialGrid.Item(2, f).Value()
        idConsult = HistorialGrid.Item(3, f).Value()

        If idConsult = 0 Then
            MsgBox("Aun no tiene información de la consulta", vbQuestion, My.Resources.versionFamilias2)
        Else
            If c = 0 Then ' modificar consulta
                Dim medico, notas As String
                medico = HistorialGrid.Item(8, f).Value()
                notas = HistorialGrid.Item(7, f).Value()
                irModificarConsulta(PacienteV.Text, S, Id, idConsult, NombreV.Text, EdadV.Text, FamiliaV.Text, notas, medico)
            ElseIf c = 1 Then 'revisar detalle
                irRevisarConsulta(PacienteV.Text, S, Id, idConsult)
            End If
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "REHC"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub irRevisarConsulta(ByVal member As Integer,
                              ByVal sMember As String, _
                              ByVal app As Integer, _
                              ByVal cons As Integer)
        Dim consu As New RevisarConsultaMedica
        consu.memberId = member
        consu.sMember = sMember
        consu.appid = app
        consu.preTrans = "RCOM"
        consu.consid = cons
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
                          ByVal medico As String)
        Dim consu As New ModificarConsultaMedica
        consu.memberId = member
        consu.sMember = sMember
        consu.appid = app
        consu.consId = idCon
        consu.preTrans = "RCOM"
        consu.PacienteV.Text = member.ToString
        consu.NombreV.Text = nombre
        consu.EdadV.Text = edad
        consu.FamiliaV.Text = fam
        consu.obsV.Text = chequearValor(notas)
        consu.DrL.Text = medico

        consu.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New HistorialConsultasMedicas
        nxt.Show()
        Me.Close()
    End Sub

End Class