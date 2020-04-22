Public Class CalificacionesPRIM
    Public gSel, cSel As String
    Dim gradoSel, trans As String
    Dim miembro As String = 0
    Dim etiquetas As New DataTable
    Dim nota, minimo, zona, examen, total As Integer
    Dim n1, n2, n3, n4, n5, n6, n7 As Integer

    Private Sub CalificacionesEscuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        ValoresIniciales()
    End Sub

    Private Sub actualizar()
        Dim style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        Dim response = MsgBox("¿Esta seguro de actualizar? ", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "INSERT INTO dbo.MemberEducationClassENE " + _
                  "SELECT Project, MemberId, SchoolYear, Grade, ClassSubject, Cycle, GETDATE(), RecordStatus, " + _
                    "'" + U + "', ExpirationDateTime, " + C1V.Text + ", " + C2V.Text + ", " + C3V.Text + ", " + C4V.Text + _
                    ", " + C5V.Text + ", " + C6V.Text + ", " + C7V.Text + ", " + ZonaV.Text + ", " + ExamenV.Text + ", " + TotalV.Text + " " + _
                  "FROM dbo.MemberEducationClassENE " + _
                  "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + miembro.ToString + " AND SchoolYear = " + AñoV.Text + _
                  " AND Grade = '" + GradoCombo.SelectedValue + "' AND ClassSubject = '" + ClasesCombo.SelectedValue + _
                  "' AND Cycle = '" + CicloCombo.SelectedValue.ToString + "' "
            'InputBox("", "", sql)
            bdInsertar(sql)
            listado()
            limpiarCampos()
        Else
            MsgBox("No se ha realizado ningun cambio", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub C1V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1V.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C1V_Leave(sender As Object, e As EventArgs) Handles C1V.Leave
        minimo = 0

        If C1M.Text = 0 Then 'no tiene mínimo
        Else
            If C1V.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(C1V.Text, n1)
                Integer.TryParse(C1M.Text, minimo)
                If n1 > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + C1M.Text, vbQuestion, My.Resources.versionFamilias2)
                    C1V.Text = 0
                End If
                'Else
                calcularZona()
                'End If
            End If
        End If
    End Sub

    Private Sub C2V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C2V.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C2V_Leave(sender As Object, e As EventArgs) Handles C2V.Leave
        minimo = 0

        If C2M.Text = 0 Then 'no tiene mínimo
        Else
            If C2V.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(C2V.Text, n2)
                Integer.TryParse(C2M.Text, minimo)
                If n2 > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + C2M.Text, vbQuestion, My.Resources.versionFamilias2)
                    C2V.Text = 0
                End If
                'Else
                calcularZona()
                'End If
            End If
        End If
    End Sub

    Private Sub C3V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C3V.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C3V_Leave(sender As Object, e As EventArgs) Handles C3V.Leave
        minimo = 0

        If C3M.Text = 0 Then 'no tiene mínimo
        Else
            If C3V.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(C3V.Text, n3)
                Integer.TryParse(C3M.Text, minimo)
                If n3 > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + C3M.Text, vbQuestion, My.Resources.versionFamilias2)
                    C3V.Text = 0
                End If
                'Else
                calcularZona()
                'End If
            End If
        End If
    End Sub

    Private Sub C41V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4V.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C4V_Leave(sender As Object, e As EventArgs) Handles C4V.Leave
        minimo = 0

        If C4M.Text = 0 Then 'no tiene mínimo
        Else
            If C4V.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(C4V.Text, n4)
                Integer.TryParse(C4M.Text, minimo)
                If n4 > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + C4M.Text, vbQuestion, My.Resources.versionFamilias2)
                    C4V.Text = 0
                End If
                'Else
                calcularZona()
                'End If
            End If
        End If
    End Sub

    Private Sub C5V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C5V.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C5V_Leave(sender As Object, e As EventArgs) Handles C5V.Leave
        minimo = 0

        If C5M.Text = 0 Then 'no tiene mínimo
        Else
            If C5V.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(C5V.Text, n5)
                Integer.TryParse(C5M.Text, minimo)
                If n5 > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + C5M.Text, vbQuestion, My.Resources.versionFamilias2)
                    C5V.Text = 0
                End If
                'Else
                calcularZona()
                'End If
            End If
        End If
    End Sub

    Private Sub C6V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C6V.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C6V_Leave(sender As Object, e As EventArgs) Handles C6V.Leave
        minimo = 0

        If C6M.Text = 0 Then 'no tiene mínimo
        Else
            If C6V.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(C6V.Text, n6)
                Integer.TryParse(C6M.Text, minimo)
                If n6 > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + C6M.Text, vbQuestion, My.Resources.versionFamilias2)
                    C6V.Text = 0
                End If
                'Else
                calcularZona()
                'End If
            End If
        End If
    End Sub

    Private Sub C7V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C7V.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C7V_Leave(sender As Object, e As EventArgs) Handles C7V.Leave
        minimo = 0

        If C7M.Text = 0 Then 'no tiene mínimo
        Else
            If C7V.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(C7V.Text, n7)
                Integer.TryParse(C7M.Text, minimo)
                If n7 > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + C7M.Text, vbQuestion, My.Resources.versionFamilias2)
                    C7V.Text = 0
                End If
                'Else
                calcularZona()
                'End If
            End If
        End If
    End Sub

    Private Sub calcularTotal()
        If miembro = 0 Then

        Else
            total = zona + examen
            If total > 100 Then
                total = 0
            Else
                TotalV.Text = total.ToString
                Dim color = colorTotal(total)
                If color = "Red" Then
                    TotalV.BackColor = Drawing.Color.Red
                    TotalV.ForeColor = Drawing.Color.White
                ElseIf color = "Yellow" Then
                    TotalV.BackColor = Drawing.Color.Yellow
                    TotalV.ForeColor = Drawing.Color.Black
                ElseIf color = "Green" Then
                    TotalV.BackColor = Drawing.Color.Green
                    TotalV.ForeColor = Drawing.Color.White
                Else
                    TotalV.BackColor = Drawing.Color.White
                    TotalV.ForeColor = Drawing.Color.Black
                End If
            End If
        End If
    End Sub

    Private Sub calcularZona()
        If miembro = 0 Then

        Else
            zona = n1 + n2 + n3 + n4 + n5 + n6 + n7
            ZonaV.Text = zona.ToString
            calcularTotal()
        End If
    End Sub

    Private Sub variables()
        l1.Text = n1.ToString
        l2.Text = n2.ToString
        l3.Text = n3.ToString
        l4.Text = n4.ToString
        l5.Text = n5.ToString
        l6.Text = n6.ToString
        l7.Text = n7.ToString
        lzona.Text = zona.ToString
        lexamen.Text = examen.ToString
        ltotal.Text = total.ToString
    End Sub

    Private Sub calificacioneExistentes(ByVal f As Integer)
        n1 = CalificacionesGrid.Item(5, f).Value()
        n2 = CalificacionesGrid.Item(6, f).Value()
        n3 = CalificacionesGrid.Item(7, f).Value()
        n4 = CalificacionesGrid.Item(8, f).Value()
        n5 = CalificacionesGrid.Item(9, f).Value()
        n6 = CalificacionesGrid.Item(10, f).Value()
        n7 = CalificacionesGrid.Item(11, f).Value()
        zona = CalificacionesGrid.Item(12, f).Value()
        examen = CalificacionesGrid.Item(13, f).Value()
        total = CalificacionesGrid.Item(14, f).Value()

        C1V.Text = n1.ToString
        C2V.Text = n2.ToString
        C3V.Text = n3.ToString
        C4V.Text = n4.ToString
        C5V.Text = n5.ToString
        C6V.Text = n6.ToString
        C7V.Text = n7.ToString
        ZonaV.Text = zona.ToString
        ExamenV.Text = examen.ToString
        TotalV.Text = total.ToString
        variables()
    End Sub

    Private Sub CalificacionesGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CalificacionesGrid.CellDoubleClick
        limpiarCampos()
        Dim f = CalificacionesGrid.CurrentCellAddress.Y
        miembro = CalificacionesGrid.Item(0, f).Value()
        Alumno.Text = CalificacionesGrid.Item(1, f).Value() + ", " + CalificacionesGrid.Item(2, f).Value()
        If Len(chequearValor(CalificacionesGrid.Item(12, f).Value())) > 0 Then
            trans = "A"
            calificacioneExistentes(f)
        Else
            trans = "N"
        End If
        C1V.Focus()
    End Sub

    Private Function colorTotal(ByVal total As Integer)
        If total < 60 Then
            colorTotal = "Red"
        ElseIf total >= 60 And total <= 70 Then
            colorTotal = "Yellow"
        ElseIf total > 70 Then
            colorTotal = "Green"
        Else
            colorTotal = "White"
        End If
    End Function

    Private Sub etiquetasClase(ByVal clase As String)
        sql = "SELECT EducationLevel Nivel FROM CdGrade WHERE Code = '" + GradoCombo.SelectedValue + "' "
        Dim nivel As String = bdPalabra(sql, "Nivel")

        Dim from As String = "FROM CdClassSubjectCategoryENE WHERE ClassSubject = '" + clase + "'"

        sql = "SELECT   * " + _
              "FROM CdClassSubjectCategoryENE WHERE ClassSubject = '" + clase + "' AND EducationLevel = '" + nivel + "' "

        bdDataTable(sql, etiquetas)
        If etiquetas.Rows.Count > 0 Then
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C1")), chequearValor(etiquetas.Rows(0)("C1Max")), C1L, C1V, C1M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C2")), chequearValor(etiquetas.Rows(0)("C2Max")), C2L, C2V, C2M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C3")), chequearValor(etiquetas.Rows(0)("C3Max")), C3L, C3V, C3M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C4")), chequearValor(etiquetas.Rows(0)("C4Max")), C4L, C4V, C4M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C5")), chequearValor(etiquetas.Rows(0)("C5Max")), C5L, C5V, C5M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C6")), chequearValor(etiquetas.Rows(0)("C6Max")), C6L, C6V, C6M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C7")), chequearValor(etiquetas.Rows(0)("C7Max")), C7L, C7V, C7M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("Zona")), chequearValor(etiquetas.Rows(0)("ZonaMax")), zonaL, ZonaV, zonaM)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("Examen")), chequearValor(etiquetas.Rows(0)("ExamenMax")), examenL, ExamenV, examenM)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("Total")), chequearValor(etiquetas.Rows(0)("TotalMax")), totalL, TotalV, totalM)
            NotasPanel.Visible = True
        End If
        CalificacionesGrid.DataSource = etiquetas
        CalificacionesGrid.Visible = True
    End Sub

    Private Sub ExamenV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ExamenV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ExamenV_Leave(sender As Object, e As EventArgs) Handles ExamenV.Leave
        minimo = 0

        If examenM.Text = 0 Then 'no tiene mínimo
        Else
            If ExamenV.Text = 0 Then 'no tiene nota
            Else
                Integer.TryParse(ExamenV.Text, examen)
                Integer.TryParse(examenM.Text, minimo)
                If examen > minimo Then
                    MsgBox("No puede ingresar un valor mayor a " + examenM.Text, vbQuestion, My.Resources.versionFamilias2)
                    ExamenV.Text = 0
                End If
                'Else
                calcularTotal()
                'End If
            End If
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If miembro = 0 Then
            MsgBox("Verifique que haya seleccionado un alumno", vbQuestion, My.Resources.versionFamilias2)
        Else
            calcularZona()
            calcularTotal()
            'If validarValores() = True Then
            If trans = "N" Then
                NuevoRegistro()
            ElseIf trans = "A" Then
                actualizar()
            End If
            '    Else
            '    MsgBox("Necesita ingresar valores mayores o igual a 0", vbQuestion, My.Resources.versionFamilias2)
            'End If
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        miembro = 0
        n1 = 0
        n2 = 0
        n3 = 0
        n4 = 0
        n5 = 0
        n6 = 0
        n7 = 0
        nota = 0
        minimo = 0
        zona = 0
        examen = 0
        total = 0
        l1.Text = 0
        l2.Text = 0
        l3.Text = 0
        l4.Text = 0
        l5.Text = 0
        l6.Text = 0
        l7.Text = 0
        lzona.Text = 0
        lexamen.Text = 0
        ltotal.Text = 0
        C1V.Text = 0
        C2V.Text = 0
        C3V.Text = 0
        C4V.Text = 0
        C5V.Text = 0
        C6V.Text = 0
        C7V.Text = 0
        ZonaV.Text = 0
        ExamenV.Text = 0
        TotalV.Text = 0
        Alumno.Text = "Seleccionar Alumno"
        TotalV.BackColor = Color.White
        TotalV.ForeColor = Color.Black
    End Sub

    Private Sub listado()
        CalificacionesGrid.DataSource = Nothing
        CalificacionesGrid.Rows.Clear()
        'CalificacionesGrid.Visible = False
        Dim lista As New DataTable
        'sql = "SELECT Afiliación, Apellidos, Nombres, [M/F], Familia, I1, I2, I3, I4, I5, I6, I7, Zona, Examen, Total " + _
        '      "FROM dbo.fn_ENE_CalificacionesPRIM('" + GradoCombo.SelectedValue + "', " + AñoV.Text + ", '" + CicloCombo.SelectedValue.ToString + "', '" + ClasesCombo.SelectedValue + "') L " + _
        '      "ORDER BY Apellidos "

        sql = "SELECT Y.MemberId AS Código, M.LastNames AS Apellidos, M.FirstNames AS Nombres, M.Gender AS 'M/F', M.LastFamilyId AS Familia, " + _
              "C.I1, C.I2, C.I3, C.I4, C.I5, C.I6, C.I7, C.TotalZone AS Zona, C.Examen, C.Total " + _
              "FROM  dbo.MemberEducationYear Y " + _
              "INNER JOIN dbo.Member M ON Y.Project = M.Project AND Y.MemberId = M.MemberId AND Y.RecordStatus = M.RecordStatus " + _
              "LEFT OUTER JOIN dbo.MemberEducationClassENE C ON Y.Project = C.Project AND Y.MemberId = C.MemberId AND Y.SchoolYear = C.SchoolYear AND " + _
              "Y.Grade = C.Grade AND Y.RecordStatus = C.RecordStatus AND C.Cycle = '" + CicloCombo.SelectedValue.ToString + "' AND " + _
              "C.ClassSubject = '" + ClasesCombo.SelectedValue + "' " + _
              "WHERE Y.RecordStatus = ' ' AND Y.Project = 'N' AND  Y.SchoolYear = " + AñoV.Text + " AND Y.Grade = '" + GradoCombo.SelectedValue + "' " + _
              "ORDER BY M.LastNames, M.FirstNames  "
        'InputBox("", "", sql)
        ''bdDataTable(sql, lista)

        'CalificacionesGrid.DataSource = lista
        bdGrid(sql, CalificacionesGrid)
        Dim n As Integer = CalificacionesGrid.Columns.Count
        If n > 0 Then
            With CalificacionesGrid
                ''etiquetas del listado
                .Columns(5).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C1"))
                .Columns(6).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C2"))
                .Columns(7).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C3"))
                .Columns(8).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C4"))
                .Columns(9).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C5"))
                .Columns(10).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C6"))
                .Columns(11).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C7"))
                For i = 0 To 14
                    .Columns(i).HeaderCell.Style.Font = New Font("Arial Narrow", 9)
                Next
                .Columns(1).Frozen = True
                .Columns(2).Frozen = True

                ''color del total
                Dim notaFinal As Integer
                For i = 0 To CalificacionesGrid.RowCount - 1
                    If Len(chequearValor(CalificacionesGrid.Rows(i).Cells(14).Value)) > 0 Then
                        notaFinal = CalificacionesGrid.Rows(i).Cells(14).Value
                        If colorTotal(notaFinal) = "Red" Then
                            CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.Red
                            CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.White
                        ElseIf colorTotal(notaFinal) = "Yellow" Then
                            CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.Yellow
                            CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.Black
                        ElseIf colorTotal(notaFinal) = "Green" Then
                            CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.Green
                            CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.White
                        Else
                            CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.White
                            CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.Black
                        End If
                    End If
                Next

                If ClasesCombo.SelectedValue = "EDFI" Then
                    CalificacionesGrid.Columns(10).Visible = False
                    CalificacionesGrid.Columns(11).Visible = False
                    C6L.Visible = False
                    C6V.Visible = False
                    C6M.Visible = False
                    l6.Visible = False
                    C7L.Visible = False
                    C7V.Visible = False
                    C7M.Visible = False
                    l7.Visible = False
                End If
                If ClasesCombo.SelectedValue = "POQO" Or ClasesCombo.SelectedValue = "INGL" Then
                    CalificacionesGrid.Columns(11).Visible = False
                    C7L.Visible = False
                    C7V.Visible = False
                    C7M.Visible = False
                    l7.Visible = False
                End If

            End With
            CalificacionesGrid.Visible = True
            CalificacionesGrid.Columns(3).Visible = False
            CalificacionesGrid.Columns(2).Frozen = True
        End If
    End Sub

    Private Sub ListadoButton_Click(sender As Object, e As EventArgs) Handles ListadoButton.Click
        If Len(AñoV.Text) > 0 And GradoCombo.SelectedIndex > -1 And CicloCombo.SelectedIndex > -1 And ClasesCombo.SelectedIndex > -1 Then
            sql = "SELECT dbo.fn_ENE_excepcionClase('" + GradoCombo.SelectedValue + "', '" + ClasesCombo.SelectedValue + "') V"
            If bdPalabra(sql, "V") = "SI" Then
                AñoV.Enabled = False
                GradoCombo.Enabled = False
                CicloCombo.Enabled = False
                ClasesCombo.Enabled = False
                ListadoButton.Visible = False
                GuardarButton.Visible = True
                etiquetasClase(ClasesCombo.SelectedValue)
                listado()
                nAlumnosL.Text = "Alumnos: " + CalificacionesGrid.RowCount.ToString
                nAlumnosL.Visible = True
            Else
                MsgBox(ClasesCombo.Text + " no se le puede hacer registro de notas para " + GradoCombo.Text, vbQuestion, My.Resources.versionFamilias2)
            End If
        Else
            MsgBox("Tiene que llenar todos los campos ", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub llenarEtiqueta(ByVal descripcion As String, ByVal maxVal As String, ByVal etiquetaL As Label, ByVal cal As TextBox, ByVal max As Label)
        If Len(descripcion) > 0 Then
            etiquetaL.Text = descripcion
            max.Text = maxVal
            etiquetaL.Visible = True
            cal.Visible = True
            max.Visible = True
        Else
            etiquetaL.Visible = False
            cal.Visible = False
            max.Visible = False
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        'gSel = GradoCombo.SelectedValue
        'cSel = CicloCombo.SelectedValue
        Dim nxt As New CalificacionesPRIM
        'nxt.gSel = gSel
        'nxt.cSel = cSel
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoRegistro()
        sql = "INSERT INTO MemberEducationClassENE VALUES ('" + S + "', " + miembro.ToString + "," + AñoV.Text + ", '" + _
              GradoCombo.SelectedValue + "', '" + ClasesCombo.SelectedValue.ToString + "', '" + CicloCombo.SelectedValue.ToString + "', " + _
              "GETDATE(), ' ', '" + U + "', NULL, " + C1V.Text + ", " + C2V.Text + ", " + C3V.Text + ", " + C4V.Text + ", " + _
              C5V.Text + ", " + C6V.Text + ", " + C7V.Text + ", " + ZonaV.Text + ", " + ExamenV.Text + ", " + TotalV.Text + ") "
        bdInsertar(sql)
        listado()
        limpiarCampos()
    End Sub

    'Private Function validarValores1() As Boolean
    '    If Len(C1V.Text) > 0 And Len(C2V.Text) > 0 And Len(C3V.Text) > 0 And Len(C4V.Text) > 0 And Len(C5V.Text) > 0 And Len(C6V.Text) > 0 And Len(C7V.Text) > 0 And + _
    '        Len(ExamenV.Text) > 0 Then
    '        validarValores = True
    '    Else
    '        validarValores = False
    '    End If
    'End Function


    Private Sub ValoresIniciales()
        trans = "N"
        AñoV.Text = Now.Year.ToString

        ''Grado
        sql = "SELECT Code, DescSpanish FROM CdGrade WHERE EducationLevel = 'PRIM' " + _
                "AND Code NOT IN ('DI', 'ET1', 'ET2', 'ET3', 'ET4', 'ET5', 'ET6') ORDER BY Orden"
        bdCombo(sql, GradoCombo, "Code", "DescSpanish")

        ''grado del usuario
        'If Len(gSel) > 0 Then
        '    GradoCombo.SelectedValue = gSel
        '    GradoCombo.Enabled = False
        'Else
        sql = "SELECT CASE WHEN CustomField3 IS NULL THEN '' ELSE CustomField3 END Grado FROM FwEmployee WHERE EmployeeId = '" + U + "'"
        gradoSel = bdPalabra(sql, "Grado")
        If Len(gradoSel) > 0 Then
            sql = "SELECT EducationLevel L FROM CdGrade WHERE Code = '" + gradoSel + "' "
            If bdPalabra(sql, "L") = "PRIM" Then
                GradoCombo.SelectedValue = gradoSel
                'GradoCombo.Enabled = False
            Else
                gradoSel = ""
            End If
        Else
            gradoSel = ""
        End If
        'End If

        ''ciclo
        sql = "SELECT Cycle, DescSpanish D FROM CdCycleENE WHERE Active = 1 "
        bdCombo(sql, CicloCombo, "Cycle", "D")
        'If Len(cSel) > 0 Then
        '    GradoCombo.SelectedValue = cSel
        '    GradoCombo.Enabled = False
        'End If

        ''clases
        sql = "SELECT Code, DescSpanish D FROM cdClassSubjectENE WHERE Active = 1 AND PRIM = 1 ORDER BY DescSpanish "
        bdCombo(sql, ClasesCombo, "Code", "D")
    End Sub

    'For x = 0 To CalificacionesGrid.Columns.Count - 1
    '    CalificacionesGrid.Columns(x).Frozen = True
    '    CalificacionesGrid.Columns(x).ReadOnly = True
    '    CalificacionesGrid.Columns(x).SortMode = DataGridViewColumnSortMode.NotSortable
    '    CalificacionesGrid.Columns(x).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
    'Next

End Class