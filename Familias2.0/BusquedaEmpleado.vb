' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class BusquedaEmpleado
    Public familyId As Integer

    Dim transac As String
    Dim memberId As Integer

    Private Sub BusquedaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        NombreUsual.Focus()
    End Sub

    Private Sub ApellidosV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApellidosV.TextChanged
        If ApellidosV.Text = "" Or ApellidosV.Text = " " Then
        Else
            buscarCandidatos("AND M.LastNames like '" + ApellidosV.Text + "%' ")
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub buscarCandidatos(ByVal campo As String)
        sql = "SELECT FMR.FamilyId Familia, M.MemberId as Miembro, M.PreferredName AS Usual, M.FirstNames + ' ' + M.LastNames AS Nombre,   CdR.DescSpanish Relación, dbo.fn_GEN_FormatDate (M.BirthDate, 'ES') Nacimiento " + _
               "FROM dbo.Member M INNER JOIN dbo.FamilyMemberRelation FMR ON M.Project = FMR.Project AND M.LastFamilyId = FMR.FamilyId " + _
              "AND M.MemberId = FMR.MemberId AND M.RecordStatus = FMR.RecordStatus AND FMR.InactiveDate IS NULL " + _
              "INNER JOIN dbo.CdFamilyMemberRelationType CdR ON FMR.Type = CdR.Code " + _
              "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' " + campo + _
              "ORDER BY M.FirstNames, M.LastNames "
        bdGrid(sql, MemberList)
        MemberList.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irExonerarMedicina(ByVal id As String)
        Dim nxt As New ExonerarMedicina
        nxt.PacienteV.Text = id
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMedicinaConsultaAlCredito(ByVal id As String)
        Dim nxt As New MedicinaConsultaAlCredito
        nxt.MiembroV.Text = id
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irNuevoFamiliarEmpleado(ByVal id As String)
        Dim nxt As New NuevoFamiliarEmpleado
        nxt.FamiliaV.Text = id
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irCitaLab(ByVal id As String)
        Dim nxt As New CitaLaboratorio
        nxt.PacienteV.Text = id
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irHistorialMedicinasMiembroFarm(ByVal id As String)
        Dim nxt As New HistorialMedicinasMiembroFarm
        nxt.PacienteV.Text = id
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irPreconsulta(ByVal id As String)
        Dim nxt As New Preconsulta
        nxt.PacienteV.Text = id
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRevisarPreconsultas(ByVal id As String)
        Dim nxt As New RevisarPreconsultas
        nxt.PacienteV.Text = id
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub MemberList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MemberList.CellContentClick
        Dim fila As Integer
        Dim id As String
        fila = MemberList.CurrentCellAddress.Y()

        InfoTable.Location = New Point(100, 139)
        InfoTable.Visible = False
        id = MemberList.Item(1, fila).Value.ToString

        If TransL.Text = "CM" Then
            irPreconsulta(id)
        ElseIf TransL.Text = "NFE" Then
            id = MemberList.Item(0, fila).Value.ToString
            irNuevoFamiliarEmpleado(id)
        ElseIf TransL.Text = "CL" Then
            irCitaLab(id)
        ElseIf TransL.Text = "ECM" Then
            irExonerarMedicina(id)
        ElseIf TransL.Text = "MECR" Then
            irMedicinaConsultaAlCredito(id)
        ElseIf TransL.Text = "RCIM" Then
            irRevisarPreconsultas(id)
        ElseIf TransL.Text = "RHMF" Then
            irHistorialMedicinasMiembroFarm(id)
        Else
        End If
    End Sub

    Private Sub NombreUsual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreUsual.TextChanged
        If NombreUsual.Text = "" Or NombreUsual.Text = " " Then
        Else
            buscarCandidatos("AND M.PreferredName like '" + NombreUsual.Text + "%' ")
        End If
    End Sub

    Private Sub NombresV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombresV.TextChanged
        If NombresV.Text = "" Or NombresV.Text = " " Then
        Else
            buscarCandidatos("AND M.FirstNames like '" + NombresV.Text + "%' ")
        End If
    End Sub
End Class