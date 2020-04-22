' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class MedicinaEmpleados
    Dim empleado, iMeds As Integer

    Private Sub MedicinaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
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

    Private Sub calculateTotalPrice()
        Dim normalPrice, total As Double
        If MedsGrid.RowCount = 0 Then
            normalTotalV.Text = "0.00"
            PrecioNormalV.Text = "0.00"
        Else
            normalPrice = sumarPreciosMeds()
            total = normalPrice * Double.Parse(normalPercentageV.Text) / 100
            normalTotalV.Text = total.ToString("F", CultureInfo.InvariantCulture) 'normal Price
        End If
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub checkCorrelativeMeds()
        Dim n As Integer = MedsGrid.Rows.Count - 1
        For f = 0 To n
            MedsGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
        Next
        calculateTotalPrice()
    End Sub

    Private Sub CreditoCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditoCheck.CheckedChanged
        Dim n As Integer = MedsGrid.RowCount
        If n > 0 Then
            If CreditoCheck.Checked = True Then
                For f = 0 To MedsGrid.RowCount - 1
                    MedsGrid.Item(0, f).Value = CreditoCheck.Checked
                Next
            End If
        End If
    End Sub

    Private Function esValidaNuevaMedicina() As Boolean
        If MedsCombo.Text = "" Or IsDBNull(MedsCombo.Text) Then
            MsgBox("Necesita seleccionar una medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        ElseIf CantidadV.Text = "" Or IsDBNull(CantidadV.Text) Then
            MsgBox("Necesita ingresar la cantidad de la medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        Else
            esValidaNuevaMedicina = True
        End If
    End Function

    Private Function existeEnListado(ByVal insert As String,
                                 ByVal listGrid As DataGridView,
                                 ByVal col As Integer) As Boolean
        Dim n As Integer = listGrid.Rows.Count - 1
        Dim exist As Integer = 0
        For f = 0 To n
            listGrid.Item(0, f).Value = f
            If listGrid.Item(col, f).Value = insert Then
                exist = exist + 1
            End If
        Next

        If exist > 0 Then
            existeEnListado = True
        Else
            existeEnListado = False
        End If
    End Function

    Private Sub llenarMedsGrid()
        Dim price, totalByMed, apr As Double
        price = getMedPrice(MedsCombo.SelectedValue)
        totalByMed = price * Convert.ToDouble(CantidadV.Text)
        apr = totalByMed * (Double.Parse(normalPercentageV.Text) / 100)
        Dim a() As String = {False, MedsCombo.SelectedValue, MedsCombo.Text, CantidadV.Text, InstrucV.Text, ObservacionesV.Text, price.ToString("F2"), totalByMed.ToString("F2"), apr.ToString("F2")}
        MedsGrid.Rows.Add(a)
        checkCorrelativeMeds()
        calculateTotalPrice()
    End Sub

    Private Function getMedPrice(ByVal code As String) As String
        Dim codeSQL As String
        codeSQL = "SELECT Price FROM dbo.CdHealthInventoryItem WHERE code = '" + code + "' "
        getMedPrice = bdDoble(codeSQL, "Price")
    End Function

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        calculateTotalPrice()
        guardarListadoMeds()
        historial()
    End Sub

    Private Sub guardarListadoMeds()
        If MedsGrid.Rows.Count() >= 1 Then
            Dim actual As DateTime = DateTime.Now
            For i = 0 To MedsGrid.Rows.Count() - 1
                insertarMedicina(actual.ToString(en.DateTimeFormat), MedsGrid.Item(1, i).Value().ToString, MedsGrid.Item(3, i).Value().ToString, MedsGrid.Item(4, i).Value().ToString,
                                 MedsGrid.Item(5, i).Value().ToString, MedsGrid.Item(6, i).Value().ToString, MedsGrid.Item(8, i).Value().ToString, MedsGrid.Item(0, i).Value())
            Next
            If Double.Parse(normalTotalV.Text) > 0 Then
                MsgBox("El total a pagar es: Q" + normalTotalV.Text, vbInformation, My.Resources.versionFamilias2)
            End If

            'historial()
            MasMedsBoton.Visible = False
            GuardarButton.Visible = False
            MedsGrid.Enabled = False
        End If
    End Sub

    Private Sub historial()
        'fill meds history
        sql = "SELECT Prescripción, Entrega, Medicina, Observaciones, Indications Indicaciones " + _
              "FROM dbo.fn_HEAL_getItemHistory('" + S + "', " + empleado.ToString + ") " + _
              "WHERE Cantidad < 0  " + _
              "ORDER BY DateT DESC "
        bdGrid(sql, MedsHistorialGrid)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub insertarMedicina(ByVal fech As String, ByVal codMed As String, ByVal cant As String,
                                 ByVal indi As String, ByVal obse As String, ByVal uPri As String,
                                 ByVal aTpri As String, ByVal alC As Boolean)
        Dim entr As String
        Dim tranId As Integer
        sql = "SELECT MAX(IdTransac) AS Ultimo FROM dbo.HealthInventoryTransactionMedi "
        tranId = bdEntero(sql, "Ultimo") + 1

        If alC = True Or S = "A" Then
            If Double.Parse(aTpri) > 0 Then
                entr = "'" + fech + "', '" + U + "', 1, 0, NULL)"
            Else
                entr = "'" + fech + "', '" + U + "', 0, 0, NULL)"
            End If

        Else
            entr = "NULL, NULL, 0, 0, NULL)"
        End If
        'IdTransac, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea, 
        'MemberProject, MemberId, UnitPrice, TotalApproved, Indications, Notes, IdConsultation, PayDateTime, DeliveryDateTime, DeliveredBy, ByCredit, Exoneration, TypePres
        sql = "INSERT INTO dbo.HealthInventoryTransactionMedi VALUES (" + tranId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, 'F', " + _
         "'" + fech + "',  NULL, '" + codMed + "', " + (cant * -1).ToString + ", 'FARM', '" + S + "', " + empleado.ToString + ", " + uPri + ", " + aTpri + _
         ", '" + indi + "', '" + obse + "', NULL, NULL, " + entr
        bdInsertar(sql)

    End Sub

    Private Sub MasMedsBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasMedsBoton.Click
        If esValidaNuevaMedicina() = True Then
            If existeEnListado(MedsCombo.SelectedValue, MedsGrid, 1) = True Then 'check if the med is not in the list
                MsgBox("La medicina seleccionada ya existe en la receta", vbInformation, My.Resources.versionFamilias2)
            Else
                If suficienteExistencia(MedsCombo.SelectedValue, CantidadV.Text) = True Then 'check actually quantity
                    llenarMedsGrid()
                    iMeds = iMeds + 1
                End If
            End If
            MedsCombo.SelectedIndex = -1
            CantidadV.Text = ""
            InstrucV.Text = ""
            ObservacionesV.Text = ""
            checkCorrelativeMeds()
            MedsCombo.Focus()
        End If
    End Sub

    Private Sub medicinaPanel(ByVal emp As String)
        InfoTable.Location = New Point(100, 139)
        InfoTable.Visible = False
        RecetaPanel.Location = New Point(10, 139)
        RecetaPanel.Visible = True

        Dim genInfo As New DataTable
        sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, M.LastFamilyId Familia, M.PreferredName " + _
              "FROM Member M INNER JOIN Family F ON M.RecordStatus = F.RecordStatus AND " + _
              "M.Project = F.Project AND M.LastFamilyId = F.FamilyId WHERE M.RecordStatus = ' '  AND M.Project = '" + S + "' AND M.MemberId = " + empleado.ToString
        bdDataTable(sql, genInfo)
        NombreV.Text = "    ( " + chequearValor(genInfo.Rows(0)("Nombre")).ToString + " )"
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
        UsualV.Text = chequearValor(genInfo.Rows(0)("PreferredName")).ToString
        PacienteV.Text = emp.ToString
        PacienteV.Enabled = False
        FamiliaV.Enabled = False

        historial()
        sql = "SELECT Code, CASE WHEN DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + '(' + DosageDesc_es + ')') " + _
                         "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END " + _
                         "+ CASE WHEN  dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) IS NULL THEN '' ELSE ' #' + CAST(dbo.fn_HEAL_existenciaConReservas(Code, GETDATE()) AS Varchar(5))  END AS Medicine " + _
                        "FROM dbo.CdHealthInventoryItem WHERE Active = 1 AND ValidSelection = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, MedsCombo, "Code", "Medicine")
        MedsCombo.Focus()
        GuardarButton.Visible = True

        If S = "A" Then
            normalPercentageV.Text = 0
            CreditoCheck.Visible = False
            MedsGrid.Columns.Item(0).Visible = False 'Al crédito
        Else
            normalPercentageV.Text = 100
            CreditoCheck.Visible = True
            MedsGrid.Columns.Item(0).Visible = True 'Al crédito
        End If

        normalPercentageV2.Text = normalPercentageV.Text + "%"
    End Sub

    Private Sub MemberList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MemberList.CellContentClick
        Dim fila As Integer
        fila = MemberList.CurrentCellAddress.Y()
        empleado = MemberList.Item(1, fila).Value
        medicinaPanel(empleado)
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
        Dim nxt As New MedicinaEmpleados
        nxt.Show()
        Me.Close()
    End Sub

    Private Function suficienteExistencia(ByVal medicine As String, ByVal quantity As Integer) As Boolean
        If quantity = 0 Then
            MsgBox("La cantidad de " + medicine.ToUpper + " tiene que ser mayor a 0", vbCritical, My.Resources.versionFamilias2)
            suficienteExistencia = False
        Else
            If medicine = "OTRA" Then
                suficienteExistencia = True
            Else
                'sql = "SELECT Quantity AS Total " + _
                '    "FROM dbo.fn_HEAL_getItemStock ('F', " + medicine + ") "
                sql = "SELECT dbo.fn_HEAL_existenciaConReservas('" + medicine + "', GETDATE()) Total "
                Dim actualQuant As Integer = bdEntero(sql, "Total")

                If actualQuant < quantity Then
                    MsgBox("La existencia es " + actualQuant.ToString, vbCritical, My.Resources.versionFamilias2)
                    suficienteExistencia = False
                Else
                    suficienteExistencia = True
                End If
            End If
        End If
    End Function

    Private Function sumarPreciosMeds() As Double
        Dim n As Integer = MedsGrid.Rows.Count
        If n = 0 Then
            sumarPreciosMeds = 0.0
        Else
            Dim total, precio As Double
            Dim z As Integer
            total = 0
            precio = 0

            Do While z < n
                precio = Convert.ToDouble(MedsGrid.Item(7, z).Value)
                total = total + precio
                z = z + 1
            Loop
            sumarPreciosMeds = total
        End If
    End Function

    Private Sub valoresIniciales()
        RecetaPanel.Location = New Point(100, 139)
        RecetaPanel.Visible = False
        InfoTable.Location = New Point(10, 139)
        InfoTable.Height = 300
        InfoTable.Visible = True
        NombreUsual.Focus()
        NombreUsual.Text = ""
        NombresV.Text = ""
        ApellidosV.Text = ""
        MemberList.DataSource = Nothing
        MemberList.Refresh()
    End Sub
End Class