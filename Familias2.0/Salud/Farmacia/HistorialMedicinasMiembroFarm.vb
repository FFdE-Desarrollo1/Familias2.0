' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class HistorialMedicinasMiembroFarm
    Dim memberId, familia, fila, idTrans As Integer
    Dim entregado, entregada, obs, alCreditoOr As String
    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
    Dim response As MsgBoxResult

    Private Sub HistorialMedicinasMiembro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(PacienteV.Text) > 0 Then
            PacienteV.Focus()
            limpiar()
            infoGen()
        ElseIf (S = "E" Or S = "A") And Len(PacienteV.Text) = 0 Then
            Dim emp As New BusquedaEmpleado
            emp.TransL.Text = "RHMF" ' "ERE"
            emp.Show()
            Me.Close()
        End If
    End Sub

    Private Sub actualizar(ByVal tran As String)
        Dim cantidad As String
        If tran = "0" Then
            If Len(obs) > 0 Then
                obs = "ELIMINADO: " + obs
            End If
            cantidad = "0"
        Else
            If Len(obs) > 0 Then
                obs = "MODIFICADO AL CREDITO: " + obs
            End If
            cantidad = "Quantity"
        End If

        Dim alCred As String = "0"
        If AlCreditoCheckBox.Checked = True Then
            alCred = "1"
        End If

        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi " + _
                 "SELECT IdTransac, GETDATE(), RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, " + cantidad + ", FunctionalArea, " + _
                 "MemberProject, memberId, UnitPrice, ApprovedTotalPrice, Indications, Notes + '" + obs + "', IdConsultation, PayDateTime, DeliveryDateTime, DeliveredBy, " + alCred + ", Exoneration, TypePres " + _
                 "FROM dbo.HealthInventoryTransactionMedi WHERE RecordStatus = ' ' AND IdTransac = " + idTransV.Text
        bdInsertar(sql)
        limpiar()
        medList()
    End Sub

    Private Sub ActualizarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarButton.Click
        If idTransV.Text = "0" Then
            MsgBox("La medicina que seleccionó es solo historial, no puede actualizarla", vbInformation, My.Resources.versionFamilias2)
        Else
            If S = "E" Then
                If (alCreditoOr = 1 And AlCreditoCheckBox.Checked = False) Or (alCreditoOr = 0 And AlCreditoCheckBox.Checked = True) Then
                    If entregada = "si" Then
                        response = MsgBox("El medicamento tiene fecha de entrega" + vbNewLine + _
                                      "¿Esta seguro de guardar el cambio?", style, My.Resources.versionFamilias2)
                        If response = MsgBoxResult.Yes Then
                            obs = " c/entrega"
                            sql = "SELECT COUNT(*) AS total  FROM dbo.HealthInventoryTransactionMedi WHERE  RecordStatus = ' ' AND ApprovedTotalPrice > 0  AND PayDateTime IS NOT NULL  AND IdTransac =  " + idTransV.Text
                            If bdEntero(sql, "total") > 0 Then
                                response = MsgBox("El medicamento ya fue pagado. Esto afecta el total cobrado en caja" + vbNewLine + _
                                                                  "¿Esta seguro de guardar el cambio?", style, My.Resources.versionFamilias2)
                                If response = MsgBoxResult.Yes Then
                                    obs = obs + " c/pago"

                                    actualizar("AlCredito")
                                Else

                                End If
                            Else
                                actualizar("AlCredito")
                            End If
                        Else

                        End If
                    Else
                        actualizar("AlCredito")
                    End If

                Else

                End If
            Else


                If CantidadV.Text = "0" Then
                    If entregada = "si" Then
                        response = MsgBox("El medicamento tiene fecha de entrega" + vbNewLine + _
                                      "¿Esta seguro de guardar el cambio?", style, My.Resources.versionFamilias2)
                        If response = MsgBoxResult.Yes Then
                            obs = " c/entrega"
                            sql = "SELECT COUNT(*) AS total  FROM dbo.HealthInventoryTransactionMedi WHERE  RecordStatus = ' ' AND ApprovedTotalPrice > 0  AND PayDateTime IS NOT NULL  AND IdTransac =  " + idTransV.Text
                            If bdEntero(sql, "total") > 0 Then
                                response = MsgBox("El medicamento ya fue pagado. Esto afecta el total cobrado en caja" + vbNewLine + _
                                                                  "¿Esta seguro de guardar el cambio?", style, My.Resources.versionFamilias2)
                                If response = MsgBoxResult.Yes Then
                                    obs = obs + " c/pago"
                                    actualizar("0")
                                Else

                                End If
                            Else
                                actualizar("0")
                            End If
                        Else

                        End If
                    Else
                        actualizar("0")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        limpiar()
        MedsGrid.Refresh()
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
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
            nxt.transac = "RHMF"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub limpiar()
        idTransV.Text = ""
        CantidadV.Text = ""
        MedicinaV.Text = ""
        MedicinaModTabla.Visible = False
        MedsTable.ColumnStyles(1).Width = 0
        MedsTable.ColumnStyles(2).Width = 0
    End Sub

    Private Sub MedsGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MedsGrid.CellContentClick
        Dim col As Integer = MedsGrid.CurrentCellAddress.X()
        If col = 0 Then
            fila = MedsGrid.CurrentCellAddress.Y()
            idTrans = MedsGrid.Item(1, fila).Value
            idTransV.Text = idTrans.ToString
            MedicinaV.Text = MedsGrid.Item(4, fila).Value
            CantidadV.Text = MedsGrid.Item(5, fila).Value
            entregado = chequearValor(MedsGrid.Item(3, fila).Value)

            If Len(entregado) > 1 Then
                entregada = "si"
                response = MsgBox("Ha seleccionado un medicamento que ya fue entregado" + vbNewLine + _
                                  "¿Esta seguro modificarlo?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    MedicinaModTabla.Visible = True
                    MedsTable.ColumnStyles(1).Width = 10
                    MedsTable.ColumnStyles(2).Width = 430
                    CantidadV.Focus()
                Else
                End If
            Else
                entregada = "no"
                MedicinaModTabla.Visible = True
                MedsTable.ColumnStyles(1).Width = 10
                MedsTable.ColumnStyles(2).Width = 430
                CantidadV.Focus()
            End If

            If S = "E" Then
                AlCreditoCheckBox.Visible = True

                If MedsGrid.Item(11, fila).Value = "Si" Then
                    alCreditoOr = 1
                    AlCreditoCheckBox.Checked = True
                Else
                    alCreditoOr = 0
                    AlCreditoCheckBox.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub medList()
        MedsGrid.DataSource = Nothing
        MedsGrid.Rows.Clear()
        MedsGrid.Visible = False

        Dim col As String
        If S = "E" Then
            col = "AlCredito "
        Else
            col = "Exonerado "
        End If

        'fill meds history
        sql = "SELECT CASE WHEN IdTransac > 0 AND Cantidad < 0 THEN 'Modificar'  ELSE '' END Accion, IdTransac, Prescripción, " + _
               "Entrega, Medicina, Cantidad * -1 Cantidad, Observaciones, Indications Indicaciones, Autorizado, EntregadoPor, ApprovedTotalPrice aPagar, " + col + ", Pago " + _
              "FROM dbo.fn_HEAL_getItemHistory('" + S + "', " + memberId.ToString + ") " + _
              "ORDER BY DateT DESC "
        bdGrid(sql, MedsGrid)
        MedsGrid.Columns.Item(1).Visible = False 'IdTransac

        For f = 0 To MedsGrid.RowCount - 1
            'If Integer.Parse(MedsGrid.Item(1, f).Value) > 0 And Integer.Parse(MedsGrid.Item(5, f).Value) > 0 Then
            '    MedsGrid.Item(0, f).Value = "Modificar"
            'End If

            If Integer.Parse(MedsGrid.Item(5, f).Value) = 0 Then
                MedsGrid.Item(5, f).Style.BackColor = Color.Gold
                MedsGrid.Item(6, f).Style.BackColor = Color.Gold
            End If
        Next

        For i = 2 To 11
            MedsGrid.Columns(i).ReadOnly = True
        Next

        agregarColumnaAccion(0, MedsGrid)
        MedsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        MedsGrid.AutoResizeColumns()

        MedsGrid.Visible = True
        MedsTable.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New HistorialMedicinasMiembroFarm
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

End Class