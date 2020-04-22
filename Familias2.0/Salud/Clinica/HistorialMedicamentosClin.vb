' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class HistorialMedicamentosClin
    Public sMember As String

    Dim memberId, familia, fila, idTrans As Integer
    Dim entregado As String

    Private Sub HistorialMedicamentosClin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(PacienteV.Text) > 0 Then
            infoGen()
            GenPanel.Visible = True
            InfoTable.Location = New Point(100, 139)
            InfoTable.Visible = False
        Else
            valoresIniciales()
        End If
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

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) = 0 Then
            Else
                If familiaEsValida(S, FamiliaV.Text) = True Then
                    irMiembrosDeFamilia()
                Else
                    MsgBox("El número de familia no es válido: " + FamiliaV.Text, vbInformation, My.Resources.versionFamilias2)
                    FamiliaV.Text = ""
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub infoGen()
        Dim genInfo As New DataTable
        memberId = Integer.Parse(PacienteV.Text)
        sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, M.LastFamilyId Familia, F.Classification Clasificacion " + _
              "FROM Member M INNER JOIN Family F ON M.RecordStatus = F.RecordStatus AND " + _
              "M.Project = F.Project AND M.LastFamilyId = F.FamilyId WHERE M.RecordStatus = ' '  AND M.Project = '" + S + "' AND M.MemberId = " + memberId.ToString
        bdDataTable(sql, genInfo)
        NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString

        GenInfoTable.Visible = True
        MedsGrid.Visible = True
        FamiliaV.Enabled = False
        PacienteV.Enabled = False
        familia = Integer.Parse(FamiliaV.Text)
        medList()
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
            nxt.transac = "RHMM"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub medList()
        'fill meds history
        sql = "SELECT IdTransac, Prescripción, Entrega, Medicina, Cantidad * -1 Cantidad, Observaciones, Indications Indicaciones, Autorizado, EntregadoPor " + _
              "FROM dbo.fn_HEAL_getItemHistory('" + S + "', " + memberId.ToString + ") " + _
              "WHERE Cantidad < 0 " + _
              "ORDER BY DateT DESC "
        bdGrid(sql, MedsGrid)
        MedsGrid.Columns.Item(1).Visible = False 'IdTransac
        MedsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        MedsGrid.AutoResizeColumns()
    End Sub

    Private Sub MemberList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MemberList.CellContentClick
        fila = MemberList.CurrentCellAddress.Y()
        memberId = MemberList.Item(1, fila).Value
        PacienteV.Text = memberId.ToString
        InfoTable.Visible = False
        InfoTable.Location = New Point(100, 139)
        InfoTable.Visible = False
        GenPanel.Location = New Point(10, 139)
        GenPanel.Visible = True
        infoGen()
    End Sub

    Private Sub NombresV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombresV.TextChanged
        If NombresV.Text = "" Or NombresV.Text = " " Then
        Else
            buscarCandidatos("AND M.FirstNames like '" + NombresV.Text + "%' ")
        End If
    End Sub

    Private Sub NombreUsual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreUsual.TextChanged
        If NombreUsual.Text = "" Or NombreUsual.Text = " " Then
        Else
            buscarCandidatos("AND M.PreferredName like '" + NombreUsual.Text + "%' ")
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New HistorialMedicamentosClin
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PacienteV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PacienteV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(PacienteV.Text) = 0 Then
            Else
                If miembroEsValido(S, PacienteV.Text) = True Then
                    infoGen()
                Else
                    MsgBox("El número de paciente no es válido: " + PacienteV.Text, vbInformation, My.Resources.versionFamilias2)
                    PacienteV.Text = ""
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub valoresIniciales()
        If S = "E" Then
            GenPanel.Location = New Point(100, 139)
            GenPanel.Visible = False

            InfoTable.Location = New Point(0, 130)
            InfoTable.Height = 300
            InfoTable.Visible = True
            NombreUsual.Focus()
        Else
            GenPanel.Location = New Point(0, 130)
            GenPanel.Visible = True
            InfoTable.Location = New Point(100, 139)
            InfoTable.Visible = False
            FamiliaV.Focus()
        End If
    End Sub
End Class