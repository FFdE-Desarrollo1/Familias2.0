' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class CobrosFarmacia
    Dim miembro As Integer
    Dim tempTable As New DataTable

    Private Sub CobrosFarmacia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub calcularTotal()
        Dim isCheck As New CheckBox
        Dim total As Double = 0.0
        For f = 0 To RecetasGrid.Rows.Count - 1
            isCheck.Checked = RecetasGrid.Item(0, f).Value()
            If isCheck.Checked = True Then
                total = total + Double.Parse(RecetasGrid.Item(7, f).Value())
            End If
        Next

        TotalL.Text = "TOTAL: " + total.ToString
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If familiaEsValida(S, FamiliaV.Text) = True Then
                recetasPendientes()
                FamiliaV.Enabled = False
                FamiliaV.Visible = True
                FamiliaL.Visible = True
                MiembroV.Visible = False
                MiembroL.Visible = False
            Else
                MsgBox("Número no válido", vbInformation, My.Resources.versionFamilias2)
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub guardarRecetaConConsulta(ByVal IdCon As String)
        Dim fechaAct As String = DateTime.Now.ToString(en.DateTimeFormat)
        Dim idTrans As Integer
        sql = "INSERT INTO dbo.MemberClinicConsultation " + _
              "SELECT IdConsultation, '" + fechaAct.ToString(en.DateTimeFormat) + "', RecordStatus, '" + U + "', ExpirationDateTime, ConsultationDateTime, PrimaryDiagnosis, " + _
                      "SecondaryDiagnosis1, SecondaryDiagnosis2, ProblemData, SubjetiveData, ObjetiveData, NewData, Others, EducationalPlan, TotalNormalPrice, ApprovedPrice, Exoneration, ApprovedBy, " + _
                      "'" + fechaAct.ToString(en.DateTimeFormat) + "', '" + U + "', AppId  FROM dbo.MemberClinicConsultation " + _
                      "WHERE RecordStatus = ' ' AND IdConsultation = " + IdCon
        bdEjecutarSQL(sql)

        tempTable.Clear()
        sql = "SELECT IdTransac FROM dbo.fn_CAJA_presPendPagoXFam('" + S + "', " + FamiliaV.Text + ") L " + _
               "WHERE IdConsultation = " + IdCon
        bdDataTable(sql, tempTable)

        For i = 0 To tempTable.Rows.Count - 1
            idTrans = tempTable.Rows(i)("IdTransac")
            sql = "INSERT INTO dbo.HealthInventoryTransactionMedi " + _
                  "SELECT IdTransac, '" + fechaAct.ToString(en.DateTimeFormat) + "', RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea, " + _
                    "MemberProject, MemberId, UnitPrice, ApprovedTotalPrice, Indications, Notes, IdConsultation, '" + fechaAct.ToString(en.DateTimeFormat) + "', DeliveryDateTime, DeliveredBy, ByCredit, Exoneration, TypePres " + _
                  "FROM dbo.HealthInventoryTransactionMedi WHERE RecordStatus = ' ' AND IdTransac = " + idTrans.ToString + " "
            bdInsertar(sql)
        Next
    End Sub

    Private Sub guardarRecetaSinConsulta(ByVal memberId As String, ByVal pres As String, ByVal dr As String)
        Dim fechaAct As String = DateTime.Now.ToString(en.DateTimeFormat)
        Dim idTrans As Integer

        tempTable.Clear()
        sql = "SELECT IdTransac, Medicina, Cantidad, Unidad, Total, Aprobado FROM dbo.fn_CAJA_presPendPagoXFam('" + S + "', " + FamiliaV.Text + ") L " + _
               "WHERE Prescripción = '" + pres + "' AND Miembro = " + memberId + " AND PrescritoPor = '" + dr + "' "
        bdDataTable(sql, tempTable)
        'MsgBox(sql)
        For i = 0 To tempTable.Rows.Count - 1
            idTrans = tempTable.Rows(i)("IdTransac")

            sql = "INSERT INTO dbo.HealthInventoryTransactionMedi " + _
                  "SELECT IdTransac, '" + fechaAct.ToString(en.DateTimeFormat) + "', RecordStatus, '" + U + "', ExpirationDateTime, Project, PrescriptionDateTime, Physician, Item, Quantity, FunctionalArea, " + _
                    "MemberProject, MemberId, UnitPrice, ApprovedTotalPrice, Indications, Notes, IdConsultation, '" + fechaAct.ToString(en.DateTimeFormat) + "', DeliveryDateTime, DeliveredBy, ByCredit, Exoneration, TypePres " + _
                  "FROM dbo.HealthInventoryTransactionMedi WHERE RecordStatus = ' ' AND IdTransac = " + idTrans.ToString + " "
            bdInsertar(sql)
        Next
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim isCheck As New CheckBox
        Dim idConsul As String
        For f = 0 To RecetasGrid.Rows.Count - 1
            isCheck.Checked = RecetasGrid.Item(0, f).Value()
            idConsul = chequearValor(RecetasGrid.Item(1, f).Value())

            If isCheck.Checked = True Then
                If idConsul = "" Or idConsul = " " Or idConsul = "0" Then
                    Dim idmember, pres, doc As String
                    idmember = chequearValor(RecetasGrid.Item(3, f).Value())
                    pres = RecetasGrid.Item(6, f).Value
                    doc = chequearValor(RecetasGrid.Item(8, f).Value)
                    guardarRecetaSinConsulta(idmember, pres, doc)
                Else
                    guardarRecetaConConsulta(idConsul)
                End If
            End If
        Next
        GuardarButton.Visible = False
        recetasPendientes()
        FamiliaV.Enabled = False
        FamiliaV.Visible = False
        RecetaSelGrid.Visible = False
    End Sub

    Private Sub InfoFamilia()
        sql = "SELECT LastFamilyId as Familia FROM Member WHERE RecordStatus = ' ' AND MemberId = " + MiembroV.Text + " AND Project = '" + S + "'"
        Dim fam As Integer = bdEntero(sql, "Familia")
        FamiliaV.Text = fam.ToString
        recetasPendientes()
        FamiliaV.Enabled = False
        FamiliaV.Visible = True
        FamiliaL.Visible = True
        MiembroV.Visible = False
        MiembroL.Visible = False
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub llenarRecetaSeleccionada(ByVal idCon As String)
        RecetaSelGrid.DataSource = Nothing
        RecetaSelGrid.Rows.Clear()
        sql = "SELECT Medicina, Cantidad, Unidad, Total, Aprobado FROM dbo.fn_CAJA_presPendPagoXFam('" + S + "', " + FamiliaV.Text + ") L " + _
              "WHERE IdConsultation = " + idCon
        bdGrid(sql, RecetaSelGrid)
        SelectPresTable.Visible = True
        RecetaSelGrid.Visible = True
    End Sub

    Private Sub llenarRecetaSeleccionadaSinConsulta(ByVal memberId As String, ByVal pres As String, ByVal dr As String)
        RecetaSelGrid.DataSource = Nothing
        RecetaSelGrid.Rows.Clear()
        sql = "SELECT IdTransac,  Medicina, Cantidad, Unidad, Total, Aprobado FROM dbo.fn_CAJA_presPendPagoXFam('" + S + "', " + FamiliaV.Text + ") L " + _
              "WHERE Prescripción = '" + pres + "' AND Miembro = " + memberId + " AND PrescritoPor = '" + dr + "' "
        bdGrid(sql, RecetaSelGrid)
        RecetaSelGrid.Columns.Item(0).Visible = False 'IdTransac
        SelectPresTable.Visible = True
        RecetaSelGrid.Visible = True
    End Sub

    Private Sub MemberList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MemberList.CellContentClick
        Dim fila As Integer
        fila = MemberList.CurrentCellAddress.Y()
        miembro = MemberList.Item(1, fila).Value
        MiembroV.Text = miembro.ToString
        InfoTable.Visible = False
        InfoTable.Height = 0

        infoFamilia()
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim temp As Integer
            sql = "SELECT COUNT(*) T FROM Member WHERE RecordStatus = ' ' AND MemberId = " + MiembroV.Text + " AND Project = '" + S + "'"
            temp = bdEntero(sql, "T")

            If miembroEsValido(S, MiembroV.Text) = True Then
                InfoFamilia()
            Else
                MsgBox("Número no válido", vbInformation, My.Resources.versionFamilias2)
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
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
        Dim nxt As New CobrosFarmacia
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub RecetasGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecetasGrid.CellContentClick
        Dim fila As Integer
        Dim paciente, dr, member, sMember, idCon, clas, pres As String
        fila = RecetasGrid.CurrentCellAddress.Y()
        idCon = RecetasGrid.Item(1, fila).Value
        paciente = RecetasGrid.Item(4, fila).Value
        dr = chequearValor(RecetasGrid.Item(8, fila).Value)
        member = RecetasGrid.Item(3, fila).Value
        sMember = RecetasGrid.Item(2, fila).Value
        'perc = RecetasGrid.Item(10, fila).Value
        clas = chequearValor(RecetasGrid.Item(8, fila).Value)
        pres = RecetasGrid.Item(6, fila).Value

        'If idCon = 0 Then 'sin consulta
        '    llenarRecetaSeleccionadaSinConsulta(member, pres, dr)
        'Else
        '    llenarRecetaSeleccionada(idCon)
        'End If

        PacienteV.Text = paciente + " (" + member.ToString + ")"
        DrV.Text = "Aprobado Por: " + dr
        fechaRecetaL.Text = "Fecha: " + RecetasGrid.Item(6, fila).Value.ToString
    End Sub

    Private Sub recetasPendientes()
        ', ROUND(SUM(Aprobado) * 100.0 / SUM(Total), 0) '%', ROUND(SUM(Aprobado), 4) 'Total Aprobado', 
        sql = "SELECT Idconsultation, Project, Miembro, Nombre, Familia, Prescripción, PrescritoPor, " + _
              "Clasificación FROM dbo.fn_CAJA_presPendPagoXFam('" + S + "', " + FamiliaV.Text + ") L  " + _
              "GROUP BY Idconsultation, Project, Miembro, Nombre, Familia, Prescripción,  PrescritoPor, Clasificación "
        bdGrid(sql, RecetasGrid)

        If RecetasGrid.RowCount > 0 Then
            For Each r As DataGridViewRow In RecetasGrid.Rows
                r.HeaderCell.Value = (r.Index + 1).ToString()
            Next
            GuardarButton.Visible = True
        Else
            NuevoButton.Focus()
        End If

        For i = 1 To 8 '10
            RecetasGrid.Columns.Item(i).ReadOnly = True
        Next

        RecetasGrid.Columns.Item(1).Visible = False 'IdConsul
        RecetasGrid.Columns.Item(2).Visible = False 'sitio
        RecetasGrid.Visible = True
        TotalTable.Visible = True

    End Sub

    Private Sub valoresIniciales()
        If S = "E" Then
            InfoTable.Height = principalTable.Width
            InfoTable.Visible = True
            NombreUsual.Focus()
            NombreUsual.Text = ""
            NombresV.Text = ""
            ApellidosV.Text = ""
            MemberList.DataSource = Nothing
            MemberList.Refresh()
        Else
            InfoTable.Visible = False
            '   InfoTable.Height = 0
            verListadoTable()
            MiembroV.Focus()
        End If
    End Sub

    Private Sub verListadoTable()
        MiembroV.Enabled = True
        MiembroV.Visible = True
        MiembroL.Visible = True
        MiembroV.Text = ""
        FamiliaV.Text = ""
        MiembroV.Focus()
        RecetasGrid.Visible = False
        SelectPresTable.Visible = False
        RecetaSelGrid.Visible = False
        TotalTable.Visible = False
        principalTable.Visible = True
    End Sub

    Private Sub VerTotalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerTotalButton.Click
        calcularTotal()
    End Sub
End Class
