' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class HistorialVisitas
    Dim fo, f1, f2, f3, f4, so, s1, s2, s3, eo, e1, e2, e3, e4, lo, l1, l2, l3, l4, l5, l6, vo As String
    Dim f1v, f2v, f3v, f4v, s1v, s2v, s3v, e1v, e2v, e3v, e4v, l1v, l2v, l3v, l4v, l5v, l6v As New CheckBox

    Private Sub HistorialVisitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()

        If Len(FamiliaV.Text) > 0 Then
            valoresIniciales()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Function esEmpleadoValido() As Boolean
        If S = "F" Then
            Dim N As Integer
            sql = "SELECT COUNT(*) AS 'Total' FROM dbo.FwEmployeeRole " + _
                  "WHERE Role IN ('ATS', 'EDTS', 'SUPE') AND Status = 'ACTV' AND Organization = '" + S + "' AND EmployeeId = '" + U + "'"
            N = bdEntero(sql, "Total")
            TS()

            If TS() = U Or N > 0 Then
                esEmpleadoValido = True
            Else
                esEmpleadoValido = False
            End If
        Else
            esEmpleadoValido = True
        End If
    End Function

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                If numeroValido() = True Then
                    If esEmpleadoValido() = True Then
                        FamiliaV.ReadOnly = True
                        valoresIniciales()
                    Else
                        MsgBox("El TS de esta familia es: " + TS() + Chr(13) + _
                        "No tiene acceso a esta familia", vbCritical, My.Resources.versionFamilias2)
                        FamiliaV.Text = ""
                    End If
                Else
                    MsgBox("El número de familia que ingreso no es válido", vbCritical, My.Resources.versionFamilias2)
                    FamiliaV.Text = ""
                    FamiliaV.Focus()
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irEliminar(ByVal familia As Integer, ByVal codigoT As String, _
                           ByVal visitDate As DateTime, ByVal creacion As DateTime, ByVal usuario As String)
        Dim Nv, Na As Integer
        sql = ""
        sql = "SELECT COUNT(*) Total FROM dbo.FamilyVisit2 " + _
              "WHERE  RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + familia.ToString + _
              " AND VisitType = '" + codigoT + "' AND YEAR(VisitDate) = " + visitDate.Year.ToString + _
              " AND MONTH(VisitDate) =" + visitDate.Month.ToString + " AND DAY(VisitDate) =" + visitDate.Day.ToString
        Nv = bdEntero(sql, "Total")

        sql = ""
        sql = "UPDATE dbo.FamilyVisit2 SET RecordStatus = 'H', ExpirationDateTime = GETDATE()  " + _
              "WHERE  RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + familia.ToString + _
              " AND VisitType = '" + codigoT + "' AND YEAR(CreationDateTime) = " + creacion.Year.ToString + _
              " AND MONTH(CreationDateTime) =" + creacion.Month.ToString + " AND DAY(CreationDateTime) =" + creacion.Day.ToString + _
              " AND { fn HOUR(CreationDateTime) } = " + creacion.Hour.ToString + " AND { fn MINUTE(CreationDateTime) } = " + creacion.Minute.ToString + _
              " AND { fn SECOND(CreationDateTime) } = " + creacion.Second.ToString + " AND UserId = '" + usuario + "' "
        bdInsertar(sql)

        sql = ""
        sql = "SELECT COUNT(*) Total FROM dbo.FamilyActivity " + _
              "WHERE  RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + familia.ToString + _
              " AND Type = '" + codigoT + "' AND YEAR(ActivityDateTime) = " + visitDate.Year.ToString + _
              " AND MONTH(ActivityDateTime) =" + visitDate.Month.ToString + " AND DAY(ActivityDateTime) =" + visitDate.Day.ToString
        Na = bdEntero(sql, "Total")

        'Borra la actividad solo si es la ultima visita de la familia
        If Na = 1 And Nv = 1 Then
            sql = "UPDATE dbo.FamilyActivity SET RecordStatus = 'H', ExpirationDateTime = GETDATE()  " + _
                  "WHERE  RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + familia.ToString + _
                  " AND Type = '" + codigoT + "' AND YEAR(CreationDateTime) = " + creacion.Year.ToString + _
                  " AND MONTH(CreationDateTime) =" + creacion.Month.ToString + " AND DAY(CreationDateTime) =" + creacion.Day.ToString + _
                  " AND { fn HOUR(CreationDateTime) } = " + creacion.Hour.ToString + " AND { fn MINUTE(CreationDateTime) } = " + creacion.Minute.ToString + _
                  " AND { fn SECOND(CreationDateTime) } = " + creacion.Second.ToString + " AND UserId = '" + usuario + "' "
            bdInsertar(sql)
        End If
        valoresIniciales()
    End Sub

    Private Sub irModificarVisita(ByVal familia As Integer, ByVal tipo As String, ByVal codigo As String, ByVal fechaVisita As DateTime)
        Dim mv As New ModificarVisita
        mv.FamiliaV.Text = familia.ToString
        mv.TipoVisitaV.Text = tipo
        mv.codeT = codigo
        mv.FechaV.Value = fechaVisita
        mv.HoraV.Value = fechaVisita
        mv.DireccionV.Text = DireccionV.Text

        mv.FamiliaV.ReadOnly = True
        mv.FechaV.Enabled = False
        mv.FechaV.Enabled = False
        mv.HoraV.Enabled = False

        mv.FA1.Text = f1
        mv.FA2.Text = f2
        mv.FA3.Text = f3
        mv.FA4.Text = f4
        mv.FA1.Checked = f1v.Checked
        mv.FA2.Checked = f2v.Checked
        mv.FA3.Checked = f3v.Checked
        mv.FA4.Checked = f4v.Checked
        mv.FO.Text = fo

        mv.SA1.Text = s1
        mv.SA2.Text = s2
        mv.SA3.Text = s3
        mv.SA1.Checked = s1v.Checked
        mv.SA2.Checked = s2v.Checked
        mv.SA3.Checked = s3v.Checked
        mv.SO.Text = so

        mv.ED1.Text = e1
        mv.ED2.Text = e2
        mv.ED3.Text = e3
        mv.ED4.Text = e4
        mv.ED1.Checked = e1v.Checked
        mv.ED2.Checked = e2v.Checked
        mv.ED3.Checked = e3v.Checked
        mv.ED4.Checked = e4v.Checked
        mv.EO.Text = eo

        mv.PL1.Text = l1
        mv.PL2.Text = l2
        mv.PL3.Text = l3
        mv.PL4.Text = l4
        mv.PL5.Text = l5
        mv.PL6.Text = l6
        mv.PL1.Checked = l1v.Checked
        mv.PL2.Checked = l2v.Checked
        mv.PL3.Checked = l3v.Checked
        mv.PL4.Checked = l4v.Checked
        mv.PL5.Checked = l5v.Checked
        mv.PL6.Checked = l6v.Checked
        mv.LO.Text = lo

        mv.VO.Text = vo

        mv.Show()
        Me.Close()
    End Sub

    Private Sub irRevisarVisita(ByVal familia As Integer, ByVal tipo As String, ByVal fechaVisita As DateTime)
        Dim rv As New RevisarVisita
        rv.FamiliaV.Text = familia.ToString
        rv.TipoVisitaV.Text = tipo
        rv.FechaV.Value = fechaVisita
        rv.HoraV.Value = fechaVisita
        rv.DireccionV.Text = DireccionV.Text

        rv.FamiliaV.ReadOnly = True
        rv.FechaV.Enabled = False
        rv.HoraV.Enabled = False

        rv.FA1.Text = f1
        rv.FA2.Text = f2
        rv.FA3.Text = f3
        rv.FA4.Text = f4
        rv.FA1.Checked = f1v.Checked
        rv.FA2.Checked = f2v.Checked
        rv.FA3.Checked = f3v.Checked
        rv.FA4.Checked = f4v.Checked
        rv.FO.Text = fo

        rv.SA1.Text = s1
        rv.SA2.Text = s2
        rv.SA3.Text = s3
        rv.SA1.Checked = s1v.Checked
        rv.SA2.Checked = s2v.Checked
        rv.SA3.Checked = s3v.Checked
        rv.SO.Text = so

        rv.ED1.Text = e1
        rv.ED2.Text = e2
        rv.ED3.Text = e3
        rv.ED4.Text = e4
        rv.ED1.Checked = e1v.Checked
        rv.ED2.Checked = e2v.Checked
        rv.ED3.Checked = e3v.Checked
        rv.ED4.Checked = e4v.Checked
        rv.EO.Text = eo

        rv.PL1.Text = l1
        rv.PL2.Text = l2
        rv.PL3.Text = l3
        rv.PL4.Text = l4
        rv.PL5.Text = l5
        rv.PL6.Text = l6
        rv.PL1.Checked = l1v.Checked
        rv.PL2.Checked = l2v.Checked
        rv.PL3.Checked = l3v.Checked
        rv.PL4.Checked = l4v.Checked
        rv.PL5.Checked = l5v.Checked
        rv.PL6.Checked = l6v.Checked
        rv.LO.Text = lo

        rv.VO.Text = vo

        rv.Show()
        Me.Close()
    End Sub

    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        Dim f, c, familia As Integer
        Dim fechaVisita, fechaCreacion As DateTime

        c = ListadoGrid.CurrentCellAddress.X
        f = ListadoGrid.CurrentCellAddress.Y

        'MsgBox(ListadoGrid.Item(c, f).Value().ToString)
        If ListadoGrid.Item(7, f).Value() = "N" Then
            familia = Integer.Parse(FamiliaV.Text)
            fechaVisita = Convert.ToDateTime(ListadoGrid.Item(9, f).Value)
            fechaCreacion = Convert.ToDateTime(ListadoGrid.Item(11, f).Value)
            fo = ListadoGrid.Item(20, f).Value
            f1 = ListadoGrid.Item(12, f).Value
            f2 = ListadoGrid.Item(14, f).Value
            f3 = ListadoGrid.Item(16, f).Value
            f4 = ListadoGrid.Item(18, f).Value

            so = ListadoGrid.Item(27, f).Value
            s1 = ListadoGrid.Item(21, f).Value
            s2 = ListadoGrid.Item(23, f).Value
            s3 = ListadoGrid.Item(25, f).Value

            eo = ListadoGrid.Item(36, f).Value
            e1 = ListadoGrid.Item(28, f).Value
            e2 = ListadoGrid.Item(30, f).Value
            e3 = ListadoGrid.Item(32, f).Value
            e4 = ListadoGrid.Item(34, f).Value

            vo = ListadoGrid.Item(37, f).Value

            lo = ListadoGrid.Item(50, f).Value
            l1 = ListadoGrid.Item(38, f).Value
            l2 = ListadoGrid.Item(40, f).Value
            l3 = ListadoGrid.Item(42, f).Value
            l4 = ListadoGrid.Item(44, f).Value
            l5 = ListadoGrid.Item(46, f).Value
            l6 = ListadoGrid.Item(48, f).Value

            f1v.Checked = ListadoGrid.Item(13, f).Value
            f2v.Checked = ListadoGrid.Item(15, f).Value
            f3v.Checked = ListadoGrid.Item(17, f).Value
            f4v.Checked = ListadoGrid.Item(19, f).Value

            s1v.Checked = ListadoGrid.Item(22, f).Value
            s2v.Checked = ListadoGrid.Item(24, f).Value
            s3v.Checked = ListadoGrid.Item(26, f).Value

            e1v.Checked = ListadoGrid.Item(29, f).Value
            e2v.Checked = ListadoGrid.Item(31, f).Value
            e3v.Checked = ListadoGrid.Item(33, f).Value
            e4v.Checked = ListadoGrid.Item(35, f).Value

            l1v.Checked = ListadoGrid.Item(39, f).Value
            l2v.Checked = ListadoGrid.Item(41, f).Value
            l3v.Checked = ListadoGrid.Item(43, f).Value
            l4v.Checked = ListadoGrid.Item(45, f).Value
            l5v.Checked = ListadoGrid.Item(47, f).Value
            l6v.Checked = ListadoGrid.Item(49, f).Value

            If c = 1 Then
                'MsgBox("Revisar")
                irRevisarVisita(familia, ListadoGrid.Item(4, f).Value, fechaVisita)
            ElseIf c = 2 Then
                'MsgBox("Actualizar")
                irModificarVisita(familia, ListadoGrid.Item(4, f).Value, ListadoGrid.Item(10, f).Value, fechaVisita)
            ElseIf c = 3 Then
                'MsgBox("Borrar")
                'MsgBox(ListadoGrid.Item(10, f).Value)
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                response = MsgBox("¿Esta seguro de borrar la visita? " + Chr(13) + Chr(13) + _
                                  ListadoGrid.Item(4, f).Value + " (" + fechaVisita.ToShortDateString + " " + fechaVisita.ToShortTimeString + ")", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    irEliminar(familia, ListadoGrid.Item(10, f).Value, fechaVisita, ListadoGrid.Item(11, f).Value, ListadoGrid.Item(8, f).Value)
                End If

            End If
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New HistorialVisitas
        nxt.Show()
        Me.Close()
    End Sub

    Private Function numeroValido() As Boolean
        sql = "SELECT COUNT(*) Total FROM dbo.Family M " + _
              "WHERE RecordStatus = ' '  AND Project = '" + S + "'  AND AffiliationStatus = 'AFIL' AND FamilyId = " + FamiliaV.Text

        If bdEntero(sql, "Total") = 0 Then
            numeroValido = False
        Else
            numeroValido = True
        End If
    End Function

    Private Sub ocultar()
        DireccionL.Visible = False
        DireccionV.Visible = False
        ListadoGrid.Visible = False
        sql = ""
    End Sub

    Private Sub RefMedicasButton_Click(sender As Object, e As EventArgs) Handles RefMedicasButton.Click
        Dim nxt As New ReferenciasSalud
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub referenciaMedica()
        sql = " SELECT COUNT(*)  Ref FROM dbo.fn_HEAL_ReferenciasInternas('TS')  " + _
                 "WHERE  Familia = " + FamiliaV.Text + " AND Sitio = '" + S + "' AND Estado = 'Referencia' "
        Dim refM As Integer = bdEntero(sql, "Ref")
        If refM > 0 Then
            MsgBox("La familia tiene referencia(s) médica(s): " + refM.ToString + vbNewLine + "Puede revisar el listado de referencias médicas", vbExclamation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub referenciaMedicaEnProceso()
        sql = " SELECT COUNT(*)  Ref FROM dbo.fn_HEAL_ReferenciasInternas('TS')  " + _
                 "WHERE  Familia = " + FamiliaV.Text + " AND Sitio = '" + S + "' AND Estado = 'En proceso' "
        Dim refM As Integer = bdEntero(sql, "Ref")
        If refM > 0 Then
            ReferenciaV.Text = "La familia tiene referencia(s) médica(s)  en proceso: " + refM.ToString
            ReferenciaV.Visible = True
        Else
            ReferenciaV.Text = ""
        End If
    End Sub

    Private Function TS() As String
        sql = "SELECT TS FROM  dbo.v_GEN_FamiliasAfiliadas F2 " + _
              "WHERE Sitio = '" + S + "' AND Familia = " + FamiliaV.Text + " "
        TS = bdPalabra(sql, "TS")
        TS = TS
    End Function

    Public Sub valoresIniciales()
        referenciaMedica()
        referenciaMedicaEnProceso()

        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        Dim GenInfo As New DataTable
        sql = "SELECT Address, Pueblo FROM dbo.Family F " + _
              "WHERE RecordStatus = ' '  AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        bdDataTable(sql, GenInfo)
        DireccionV.Text = chequearValor(GenInfo.Rows(0)("Address")) + " - " + chequearValor(GenInfo.Rows(0)("Pueblo"))

        sql = ""
        sql = "SELECT * " + _
                 "FROM dbo.fn_TS_Visitas ('" + S + "', " + FamiliaV.Text + ") " + _
                 "ORDER BY VisitDate DESC "
        bdGrid(sql, ListadoGrid)

        'ListadoGrid.Columns.Item(9).Visible = False
        'ListadoGrid.Columns.Item(10).Visible = False
        'ListadoGrid.Columns.Item(11).Visible = False
        ListadoGrid.Columns.Item(12).Visible = False
        ListadoGrid.Columns.Item(13).Visible = False
        ListadoGrid.Columns.Item(14).Visible = False
        ListadoGrid.Columns.Item(15).Visible = False
        ListadoGrid.Columns.Item(16).Visible = False
        ListadoGrid.Columns.Item(17).Visible = False
        ListadoGrid.Columns.Item(17).Visible = False
        ListadoGrid.Columns.Item(18).Visible = False
        ListadoGrid.Columns.Item(19).Visible = False
        ListadoGrid.Columns.Item(20).Visible = False
        ListadoGrid.Columns.Item(21).Visible = False
        ListadoGrid.Columns.Item(22).Visible = False
        ListadoGrid.Columns.Item(23).Visible = False
        ListadoGrid.Columns.Item(24).Visible = False
        ListadoGrid.Columns.Item(25).Visible = False
        ListadoGrid.Columns.Item(26).Visible = False
        ListadoGrid.Columns.Item(27).Visible = False
        ListadoGrid.Columns.Item(28).Visible = False
        ListadoGrid.Columns.Item(29).Visible = False
        ListadoGrid.Columns.Item(30).Visible = False
        ListadoGrid.Columns.Item(31).Visible = False
        ListadoGrid.Columns.Item(32).Visible = False
        ListadoGrid.Columns.Item(33).Visible = False
        ListadoGrid.Columns.Item(34).Visible = False
        ListadoGrid.Columns.Item(35).Visible = False
        ListadoGrid.Columns.Item(36).Visible = False
        ListadoGrid.Columns.Item(37).Visible = False
        ListadoGrid.Columns.Item(38).Visible = False
        ListadoGrid.Columns.Item(39).Visible = False
        ListadoGrid.Columns.Item(40).Visible = False
        ListadoGrid.Columns.Item(41).Visible = False
        ListadoGrid.Columns.Item(42).Visible = False
        ListadoGrid.Columns.Item(43).Visible = False
        ListadoGrid.Columns.Item(44).Visible = False
        ListadoGrid.Columns.Item(45).Visible = False
        ListadoGrid.Columns.Item(46).Visible = False
        ListadoGrid.Columns.Item(47).Visible = False
        'ListadoGrid.Columns.Item(48).Visible = False
        'ListadoGrid.Columns.Item(49).Visible = False
        'ListadoGrid.Columns.Item(50).Visible = False

        'For f = 0 To ListadoGrid.Rows.Count - 1
        '    ListadoGrid.Rows(f).HeaderCell.Value = (f + 1).ToString

        '    If ListadoGrid.Item(7, f).Value().ToString = "N" Then
        '        ListadoGrid.Item(1, f).Value = "Revisar"
        '        ListadoGrid.Item(2, f).Value = "Actualizar"
        '        ListadoGrid.Item(3, f).Value = "Borrar"
        '    Else
        '    End If
        'Next

        agregarColumnaAccion(1, ListadoGrid)
        agregarColumnaAccion(2, ListadoGrid)
        agregarColumnaAccion(3, ListadoGrid)


        Dim i As Integer
        For i = 9 To i = 50
            ListadoGrid.Columns.Item(i).Visible = False
        Next

        ListadoGrid.Visible = True
        DireccionV.Visible = True
        DireccionL.Visible = True
    End Sub

End Class