' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AgendaEnfermeria

    Private Sub AgendaEnfermeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub AgendaEnfermeria_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        valoresIniciales()
    End Sub

    Private Sub AgendaEnfermeria_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        valoresIniciales()
    End Sub

    Private Sub AgendaGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AgendaGrid.CellContentClick
        Dim f, c, Id, memberId As Integer
        Dim sMember As String

        c = AgendaGrid.CurrentCellAddress.X
        f = AgendaGrid.CurrentCellAddress.Y

        Id = AgendaGrid.Item(0, f).Value()
        memberId = AgendaGrid.Item(2, f).Value()
        sMember = AgendaGrid.Item(1, f).Value()

        If c = 2 Then ' agregar consulta
            If Len(chequearValor(AgendaGrid.Item(8, f).Value())) = 0 Then
                MsgBox("No es una referencia médica, no se puede modificar", vbQuestion, My.Resources.versionFamilias2)
            Else
                irActualizarTratamiento(memberId, sMember, Id, f)
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        valoresIniciales()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irActualizarTratamiento(ByVal member As Integer,
                              ByVal sMember As String, _
                              ByVal app As Integer,
                              ByVal fil As Integer)
        Dim nv As New ActualizarTratamientoEnf
        nv.MiembroV.Text = member.ToString
        nv.FamiliaV.Text = AgendaGrid.Item(5, fil).Value()
        nv.IdTratL.Text = app.ToString
        nv.NombreV.Text = chequearValor(AgendaGrid.Item(3, fil).Value()) & " " & chequearValor(AgendaGrid.Item(4, fil).Value())
        nv.MedicoV.Text = AgendaGrid.Item(7, fil).Value()
        nv.ReferenciaV.Text = AgendaGrid.Item(8, fil).Value()
        nv.TratamientoV.Text = AgendaGrid.Item(9, fil).Value()
        nv.CantidadV.Text = chequearValor(AgendaGrid.Item(10, fil).Value())
        nv.InstrV.Text = chequearValor(AgendaGrid.Item(11, fil).Value())
        If Len(chequearValor(AgendaGrid.Item(13, fil).Value())) = 0 Then
        Else
            nv.TratamientoDate.Value = DateTime.Parse(AgendaGrid.Item(12, fil).Value())
            nv.ObserV.Text = chequearValor(AgendaGrid.Item(14, fil).Value())
            nv.TratamientoDate.Enabled = False
            nv.ObserV.Enabled = False
            nv.GuardarButton.Visible = False
        End If
        nv.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT MNT.IdTreatment, M.Project AS Sitio, M.MemberId AS Paciente, M.FirstNames AS Nombres, M.LastNames AS Apellidos, M.LastFamilyId AS Familia, " + _
               "DATEDIFF(d, M.BirthDate, GETDATE()) / 365 AS Edad, MNT.Physician AS Médico, Convert(nvarchar(30),MNT.RefDateTime, 111) AS Referencia, " + _
               "cdT.DescSpanish AS Tratamiento, MNT.Quantity AS Cantidad, MNT.Instruction AS Instrucciones, Convert(nvarchar(30), MNT.TreatDateTime, 111) " + _
               "AS FechaTratamiento, MNT.TreatBy AS 'Atendido Por', Observations Observaciones " + _
              "FROM dbo.MemberNursTreatment MNT INNER JOIN dbo.Member M ON MNT.Project = M.Project AND MNT.MemberId = M.MemberId AND MNT.RecordStatus = M.RecordStatus " + _
              "INNER JOIN dbo.CdHealthTreatment cdT ON MNT.Treatment = cdT.Code " + _
              "WHERE MNT.RecordStatus = ' ' AND (YEAR(MNT.RefDateTime) = " + DateP.Value.Year.ToString + " AND MONTH(MNT.RefDateTime) = " + DateP.Value.Month.ToString + _
              " AND DAY(MNT.RefDateTime) = " + DateP.Value.Day.ToString + ") OR (MNT.RefDateTime IS NULL AND YEAR(MNT.TreatDateTime) = " + DateP.Value.Year.ToString + " AND MONTH(MNT.TreatDateTime) = " + DateP.Value.Month.ToString + _
              " AND DAY(MNT.TreatDateTime) = " + DateP.Value.Day.ToString + ")"
        bdGrid(sql, AgendaGrid)
        AgendaGrid.Columns.Item(0).Visible = False 'id

        For i = 0 To AgendaGrid.Rows.Count - 1
            AgendaGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
    End Sub
End Class