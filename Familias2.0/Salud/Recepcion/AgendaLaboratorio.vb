Imports System.Security.Permissions
Imports System.Threading

' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AgendaLaboratorio

    Private Sub AgendaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        listaPendientes()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irModificarCita(ByVal paciente, ByVal nombre, ByVal familia, ByVal appId, ByVal sMember)
        Dim nxt As New ModificarCitaLab
        nxt.PacienteV.Text = paciente
        nxt.NombreV.Text = nombre
        nxt.FamiliaV.Text = familia
        nxt.IDApp = appId
        nxt.sMember = sMember
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRevisarResultados(ByVal paciente, ByVal nombre, ByVal familia, ByVal appId, ByVal sMember)
        Dim nxt As New ImprimirResultadosLab
        nxt.PacienteV.Text = nombre + " (" + paciente + ") "
        nxt.FechaLabs.Value = ActualDateP.Value
        nxt.IdApp = appId
        nxt.Smember = sMember
        nxt.memberid = paciente
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub llenarLabs(ByVal IdApp As Integer)
        Dim listSQL As String
        listSQL = "SELECT TYPE.DescSpanish AS Examen, EXA.Notes AS Observaciones " + _
                  "FROM dbo.MemberHealthLabExam EXA INNER JOIN dbo.CdLabExamen_Type TYPE ON EXA.Examen_Tipo_ID = TYPE.Examen_Tipo_ID " + _
                  "WHERE RecordStatus = ' '  AND EXA.IdAppLab = " + IdApp.ToString
        bdGrid(listSQL, RecetaSelGrid)
        Dim f As Integer
        For f = 0 To RecetaSelGrid.Rows.Count - 1
            RecetaSelGrid.Item(0, f).Value = f + 1
        Next
    End Sub

    Sub listaPendientes()
        Dim y, m, d As String
        y = ActualDateP.Value.Year
        m = ActualDateP.Value.Month
        d = ActualDateP.Value.Day

        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es", False)

        sql = "SELECT MHL.IdAppLab, COUNT(RES.Resultado) AS Resultados, MHL.Turn AS Turno, M.FirstNames + ' ' + M.LastNames AS Nombre, M.MemberId AS 'Paciente', MHL.DrReferred AS Refirió, " + _
                     "M.Project AS Sitio, cdAS.DescSpanish Estado, M.LastFamilyId Familia " + _
              "FROM dbo.MemberHealthLabAppointment MHL INNER JOIN dbo.Member M ON MHL.Project = M.Project AND MHL.MemberId = M.MemberId AND MHL.RecordStatus = M.RecordStatus " + _
                    "INNER JOIN dbo.MemberHealthLabExam EXA ON MHL.IdAppLab = EXA.IdAppLab AND MHL.RecordStatus = EXA.RecordStatus " + _
                    "LEFT JOIN dbo.MemberHealthLabResult RES ON EXA.Examen_ID = RES.Examen_ID AND EXA.RecordStatus = RES.RecordStatus " + _
                    "INNER JOIN dbo.CdAppointmentStatus cdAS ON MHL.StatusApp = cdAS.Code " + _
            "WHERE MHL.RecordStatus = ' ' And Year(MHL.ReferenceDate) = " + y + " And Month(MHL.ReferenceDate) = " + m + _
                " And Day(MHL.ReferenceDate) = " + d + " " + _
            "GROUP BY MHL.Turn, MHL.ReferenceDate, M.FirstNames, M.LastNames, M.MemberId, M.LastFamilyId, MHL.PendPay, MHL.DrReferred, " + _
                      "MHL.TotalNormalPrice, MHL.IdAppLab, M.Project, cdAS.DescSpanish " + _
            "ORDER BY MHL.Turn "
        bdGrid(sql, PatientsListG)

        For f = 0 To PatientsListG.RowCount - 1
            PatientsListG.Rows(f).HeaderCell.Value = (f + 1).ToString

            If PatientsListG.Item(3, f).Value > 0 Then ' Tiene Resultados
                PatientsListG.Item(1, f).Value = "Revisar Resultados"
            Else
                PatientsListG.Item(0, f).Value = "Actualizar Cita"
                PatientsListG.Item(1, f).Value = "Pendiente Resultados"
            End If
        Next

        PatientsListG.Columns.Item(2).Visible = False
        PatientsListG.Columns.Item(3).Visible = False
    End Sub

    Private Sub PatientsListG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PatientsListG.CellContentClick
        Dim fila, columna, IdApp As Integer
        Dim paciente, dr, member, familia, sMember As String

        fila = PatientsListG.CurrentCellAddress.Y()
        columna = PatientsListG.CurrentCellAddress.X()

        paciente = PatientsListG.Item(5, fila).Value
        dr = PatientsListG.Item(7, fila).Value
        member = PatientsListG.Item(6, fila).Value
        familia = PatientsListG.Item(10, fila).Value
        IdApp = PatientsListG.Item(2, fila).Value
        sMember = PatientsListG.Item(8, fila).Value
        PacienteV.Text = paciente + " (" + member + ") "

        If columna = 0 Then
            If PatientsListG.Item(0, fila).Value = "Actualizar Cita" Then
                irModificarCita(member, paciente, familia, IdApp, sMember)
            End If
        ElseIf columna = 1 Then
            If PatientsListG.Item(1, fila).Value = "Revisar Resultados" Then
                irRevisarResultados(member, paciente, familia, IdApp, sMember)
            End If
        Else
            llenarLabs(IdApp)
        End If
    End Sub

    Private Sub valoresIniciales()
        listaPendientes()
    End Sub
End Class