Imports System.Security.Permissions
Imports System.Threading

' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AgendaLab
    Dim sMember As String

    Private Sub AgendaLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        listado()
    End Sub

    Private Sub listado()
        Dim y, m, d As String
        y = ActualDateP.Value.Year
        m = ActualDateP.Value.Month
        d = ActualDateP.Value.Day

        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es", False)
        sql = "SELECT MHL.Turn AS Turno, M.FirstNames + ' ' + M.LastNames AS Nombre,  M.MemberId AS 'Paciente',  MHL.DrReferred AS Refirió,  " + _
                "CASE WHEN MHL.PendPay = 1 AND MHL.TotalNormalPrice > 0 THEN 'Si' ELSE 'No' END AS 'Pendiente Pago',  MHL.TotalNormalPrice AS Costo, " + _
                "MHL.IdAppLab, M.Project AS Sitio, COUNT(RES.Resultado) AS Resultados " + _
              "FROM dbo.MemberHealthLabAppointment MHL " + _
              "INNER JOIN dbo.Member M ON MHL.Project = M.Project AND MHL.MemberId = M.MemberId AND MHL.RecordStatus = M.RecordStatus  " + _
              "INNER JOIN dbo.MemberHealthLabExam EXA ON MHL.IdAppLab = EXA.IdAppLab AND MHL.RecordStatus = EXA.RecordStatus " + _
              "LEFT JOIN dbo.MemberHealthLabResult RES ON EXA.Examen_ID = RES.Examen_ID AND EXA.RecordStatus = RES.RecordStatus " + _
             "WHERE MHL.RecordStatus = ' ' AND MHL.StatusApp = 'COMP' " + "AND Year(MHL.ReferenceDate) = " + y + " AND MONTH(MHL.ReferenceDate) = " + m + " AND DAY(MHL.ReferenceDate) = " + d + " " + _
             "GROUP BY MHL.Turn, MHL.ReferenceDate, M.FirstNames, M.LastNames, M.MemberId, M.LastFamilyId, MHL.PendPay, MHL.DrReferred, MHL.TotalNormalPrice, MHL.IdAppLab, M.Project " + _
             "ORDER BY MHL.Turn "
        bdGrid(sql, PatientsListG)

        PatientsListG.Columns.Item(5).Visible = False 'pago
        PatientsListG.Columns.Item(6).Visible = False 'costo

        For f = 0 To PatientsListG.RowCount - 1
            PatientsListG.Rows(f).HeaderCell.Value = (f + 1).ToString

            If PatientsListG.Item(9, f).Value = 0 Then
                PatientsListG.Item(0, f).Value = "Agregar Resultados"
            Else
                PatientsListG.Item(0, f).Value = "Revisar Resultados"
            End If
        Next

        PatientsListG.Columns.Item(7).Visible = False
        PatientsListG.Columns.Item(9).Visible = False
    End Sub

    Private Sub llenarLabs(ByVal IdApp As Integer)
        sql = "SELECT TYPE.DescSpanish AS Examen, EXA.Notes AS Observaciones " + _
                  "FROM dbo.MemberHealthLabExam EXA INNER JOIN dbo.CdLabExamen_Type TYPE ON EXA.Examen_Tipo_ID = TYPE.Examen_Tipo_ID " + _
                  "WHERE RecordStatus = ' ' AND  EXA.IdAppLab = " + IdApp.ToString
        bdGrid(sql, RecetaSelGrid)
        Dim f As Integer
        For f = 0 To RecetaSelGrid.Rows.Count - 1
            RecetaSelGrid.Item(0, f).Value = f + 1
        Next
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PatientsListG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PatientsListG.CellContentClick
        Dim fila, columna, IdApp As Integer
        Dim paciente, dr, member As String

        fila = PatientsListG.CurrentCellAddress.Y()
        columna = PatientsListG.CurrentCellAddress.X()
        paciente = PatientsListG.Item(2, fila).Value
        dr = PatientsListG.Item(4, fila).Value
        member = PatientsListG.Item(3, fila).Value
        IdApp = PatientsListG.Item(7, fila).Value
        sMember = PatientsListG.Item(8, fila).Value
        PacienteV.Text = paciente + " (" + member + ") "

        If columna = 0 Then
            Dim mn As New AgregarResultadosLab
            mn.IdApp = IdApp
            mn.memberid = member
            mn.Smember = sMember ' PatientsListG.Item(9, fila).Value
            mn.dateRep = ActualDateP.Value
            mn.PacienteV.Text = paciente + " (" + member + ") "
            mn.DrV.Text = "Refirió: " + dr
            mn.Show()
            Me.Close()
        Else
            llenarLabs(IdApp)
        End If
    End Sub

    Private Sub valoresIniciales()
        listado()
    End Sub
End Class