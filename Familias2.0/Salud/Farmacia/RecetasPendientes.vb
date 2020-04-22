' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class RecetasPendientes
    Dim presDateTime, deliveredDateTime, conDateTime As String
    Dim paciente, dr, member, sMember As String
    Dim check As Integer

    Private Sub RecetasPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub entregada(ByVal idTrans As String, _
                            ByVal cant As String)
        Dim fechaIng As String

        If cant = "0" Then
            fechaIng = "NULL"
        Else
            fechaIng = "GETDATE()"
        End If
        '"SELECT  IdTransac, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Item, " + cant + ", FunctionalArea, " + _
        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi " + _
              "SELECT  IdTransac, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea, " + _
              "MemberProject, MemberId, UnitPrice,  ApprovedTotalPrice, Indications, Notes, IdConsultation, PayDateTime, " + fechaIng + ", '" + U + "', ByCredit, Exoneration, TypePres " + _
              "FROM dbo.HealthInventoryTransactionMedi WHERE IdTransac = " + idTrans + " AND RecordStatus = ' ' "
        bdInsertar(sql)
        listaRecetasPendientes()
        RecetaSelGrid.Refresh()
    End Sub

    Private Sub entregarReceta()
        Dim isCheck As New CheckBox
        Dim idtrans, cant As String
        For f = 0 To RecetaSelGrid.Rows.Count - 1
            isCheck.Checked = RecetaSelGrid.Item(0, f).Value()
            idtrans = RecetaSelGrid.Item(1, f).Value()
            cant = RecetaSelGrid.Item(3, f).Value()

            If isCheck.Checked = True Then
                entregada(idtrans, cant)
            End If
        Next
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub llenarRecetaSeleccionada(ByVal paciente As String, ByVal dr As String, ByVal memberId As String, ByVal sMem As String)
        ' Aprobado,
        sql = "SELECT IdTransac, Medicina, Cantidad, Indicaciones, Notas, Exoneración " + _
                     "FROM dbo.fn_HEAL_FARM_PendingPrescriptionByMember('" + ActualDateP.Value.ToString(en.DateTimeFormat) + "') " + _
                     "WHERE memberId = " + memberId.ToString + " AND Sitio = '" + sMem + "'"
        bdGrid(sql, RecetaSelGrid)
        RecetaSelGrid.Columns.Item(1).Visible = False 'IdTransac

        'Values for No. column
        Dim AllCheck As New CheckBox
        AllCheck.Checked = True
        Dim n As Integer = RecetaSelGrid.Rows.Count - 1
        For f = 0 To n
            RecetaSelGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
            RecetaSelGrid.Item(0, f).Value = AllCheck.Checked
        Next

        PacienteV.Text = paciente + " (" + memberId + ")"
        DrV.Text = "Prescribió: " + dr

        SelectPresPanel.Visible = True
        RecetaSelGrid.Visible = True
    End Sub

    Private Sub listaRecetasPendientes()
        sql = "SELECT COUNT(*) as Total FROM dbo.fn_HEAL_FARM_PendingPrescriptionByMember('" + ActualDateP.Value.ToString(en.DateTimeFormat) + "')"
        check = bdEntero(sql, "Total")

        If check = 0 Then
            MsgBox("No hay recetas pendientes", vbQuestion, My.Resources.versionFamilias2)
            RecetasGrid.Visible = False
            RecetaSelGrid.Visible = False
            PacienteV.Visible = False
            DrV.Visible = False
        Else
            RecetasGrid.Visible = True
            RecetaSelGrid.Visible = True
            PacienteV.Visible = True
            DrV.Visible = True
            RecetasGrid.DataSource = Nothing
            RecetasGrid.Refresh()

            sql = "SELECT  IdConsultation, Paciente, MemberId AS Miembro, Sitio, Familia, Médico AS Prescribió, Hora, COUNT(Medicina) Medicinas   " + _
                      "FROM dbo.fn_HEAL_FARM_PendingPrescriptionByMember('" + ActualDateP.Value.ToString(en.DateTimeFormat) + "') " + _
                      "GROUP BY IdConsultation, Paciente, MemberId, Sitio, Familia, Médico, Hora " + _
                      "ORDER BY Hora, IdConsultation "
            bdGrid(sql, RecetasGrid)
            getStyleColumns()
            RecetasGrid.Columns.Item(0).Visible = False 'id consultation
        End If
        SelectPresPanel.Visible = False
        RecetaSelGrid.Visible = False
    End Sub

    Private Sub getStyleColumns()
        For i = 0 To RecetasGrid.Rows.Count - 1
            RecetasGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        entregarReceta()
    End Sub

    Private Sub MostrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarButton.Click
        listaRecetasPendientes()
    End Sub

    Private Sub RecetasGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecetasGrid.CellContentClick
        Dim fila As Integer
        fila = RecetasGrid.CurrentCellAddress.Y()
        paciente = RecetasGrid.Item(1, fila).Value
        dr = chequearValor(RecetasGrid.Item(5, fila).Value)
        member = RecetasGrid.Item(2, fila).Value
        sMember = RecetasGrid.Item(3, fila).Value
        llenarRecetaSeleccionada(paciente, dr, member, sMember)
    End Sub

    Private Sub valoresIniciales()
        listaRecetasPendientes()
    End Sub
End Class