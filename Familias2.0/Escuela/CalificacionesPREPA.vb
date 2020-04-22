Public Class CalificacionesPREPA
    Dim gradoSel, trans As String
    Dim miembro As String = 0
    Dim etiquetas As New DataTable
    Dim nota, minimo, zona, examen, total, filaSel As Integer
    Dim n1, n2, n3, n4, n5, n6, n7 As Integer

    Private Sub NotasPREPA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        ValoresIniciales()
    End Sub

    Private Sub actualizar()
        Dim style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        Dim response = MsgBox("¿Está seguro de actualizar? ", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "INSERT INTO dbo.MemberEducationClassENE " + _
                  "SELECT Project, MemberId, SchoolYear, Grade, ClassSubject, Cycle, GETDATE(), RecordStatus, " + _
                    "'" + U + "', ExpirationDateTime, " + C1V.Text + ", " + C2V.Text + ", " + C3V.Text + ", " + C4V.Text + _
                    ", " + C5V.Text + ", " + C6V.Text + ", 0, " + ZonaV.Text + ", " + ExamenV.Text + ", " + TotalV.Text + " " + _
                  "FROM dbo.MemberEducationClassENE " + _
                  "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + miembro.ToString + " AND SchoolYear = " + AñoV.Text + _
                  " AND Grade = '" + GradoCombo.SelectedValue + "' AND ClassSubject = '" + ClasesCombo.SelectedValue + _
                  "' AND Cycle = '" + CicloCombo.SelectedValue.ToString + "' "
            bdInsertar(sql)
            listado()
            limpiarCampos()
        Else
            MsgBox("No se ha realizado ningún cambio", vbQuestion, My.Resources.versionFamilias2)
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
            'If C1V.Text = 0 Then 'no tiene nota
            'Else
            Integer.TryParse(C1V.Text, n1)
            Integer.TryParse(C1M.Text, minimo)
            If n1 > minimo Then
                MsgBox("No puede ingresar un valor mayor a " + C1M.Text, vbQuestion, My.Resources.versionFamilias2)
                C1V.Text = 0
            End If

            calcularZona()

            'End If
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
            'If C2V.Text = 0 Then 'no tiene nota
            'Else
            Integer.TryParse(C2V.Text, n2)
            Integer.TryParse(C2M.Text, minimo)
            If n2 > minimo Then
                MsgBox("No puede ingresar un valor mayor a " + C2M.Text, vbQuestion, My.Resources.versionFamilias2)
                C2V.Text = 0
            End If
            'Else
            calcularZona()
            'End If
            'End If
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
            'If C3V.Text = 0 Then 'no tiene nota
            'Else
            Integer.TryParse(C3V.Text, n3)
            Integer.TryParse(C3M.Text, minimo)
            If n3 > minimo Then
                MsgBox("No puede ingresar un valor mayor a " + C3M.Text, vbQuestion, My.Resources.versionFamilias2)
                C3V.Text = 0
            End If
            'Else
            calcularZona()
            'End If
            'End If
        End If
    End Sub

    Private Sub C4V_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4V.KeyPress
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
            'If C4V.Text = 0 Then 'no tiene nota
            'Else
            Integer.TryParse(C4V.Text, n4)
            Integer.TryParse(C4M.Text, minimo)
            If n4 > minimo Then
                MsgBox("No puede ingresar un valor mayor a " + C4M.Text, vbQuestion, My.Resources.versionFamilias2)
                C4V.Text = 0
            End If
            'Else
            calcularZona()
            'End If
            'End If
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
            'If C5V.Text = 0 Then 'no tiene nota
            'Else
            Integer.TryParse(C5V.Text, n5)
            Integer.TryParse(C5M.Text, minimo)
            If n5 > minimo Then
                MsgBox("No puede ingresar un valor mayor a " + C5M.Text, vbQuestion, My.Resources.versionFamilias2)
                C5V.Text = 0
            End If
            'Else
            calcularZona()
            'End If
            'End If
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
            'If C6V.Text = 0 Then 'no tiene nota
            'Else
            Integer.TryParse(C6V.Text, n6)
            Integer.TryParse(C6M.Text, minimo)
            If n6 > minimo Then
                MsgBox("No puede ingresar un valor mayor a " + C6M.Text, vbQuestion, My.Resources.versionFamilias2)
                C6V.Text = 0
            End If
            'Else
            calcularZona()
            'End If
            'End If
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
                nomenclaturaNotaFinal()
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
        lzona.Text = zona.ToString
        lexamen.Text = examen.ToString
        ltotal.Text = total.ToString
    End Sub

    Private Sub calificacioneExistentes(ByVal f As Integer)
        'trans = "A"
        n1 = CalificacionesGrid.Item(5, f).Value()
        n2 = CalificacionesGrid.Item(6, f).Value()
        n3 = CalificacionesGrid.Item(7, f).Value()
        n4 = CalificacionesGrid.Item(8, f).Value()
        n5 = CalificacionesGrid.Item(9, f).Value()
        n6 = CalificacionesGrid.Item(10, f).Value()
        zona = CalificacionesGrid.Item(11, f).Value()
        examen = CalificacionesGrid.Item(12, f).Value()
        total = CalificacionesGrid.Item(13, f).Value()

        C1V.Text = n1.ToString
        C2V.Text = n2.ToString
        C3V.Text = n3.ToString
        C4V.Text = n4.ToString
        C5V.Text = n5.ToString
        C6V.Text = n6.ToString
        ZonaV.Text = zona.ToString
        ExamenV.Text = examen.ToString
        TotalV.Text = total.ToString
        variables()
        nomenclaturaNotaFinal()
    End Sub

    Private Sub CalificacionesGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CalificacionesGrid.CellDoubleClick
        limpiarCampos()
        filaSel = CalificacionesGrid.CurrentCellAddress.Y
        miembro = CalificacionesGrid.Item(0, filaSel).Value()
        Alumno.Text = CalificacionesGrid.Item(1, filaSel).Value() + ", " + CalificacionesGrid.Item(2, filaSel).Value()
        If Len(chequearValor(CalificacionesGrid.Item(12, filaSel).Value())) > 0 Then
            trans = "A"
            calificacioneExistentes(filaSel)
        Else
            trans = "N"
        End If

        C1V.Focus()
    End Sub

    Private Function colorNotaFinal(ByVal notaF As String)
        If notaF = "NM" Then
            colorNotaFinal = "Red"
        ElseIf notaF = "B" Then
            colorNotaFinal = "Yellow"
        ElseIf notaF = "MB" Or notaF = "E" Then
            colorNotaFinal = "Green"
        Else
            colorNotaFinal = "White"
        End If
    End Function

    Private Sub etiquetasClase(ByVal clase As String)
        sql = "SELECT EducationLevel Nivel FROM CdGrade WHERE Code = '" + GradoCombo.SelectedValue + "' "
        Dim nivel As String = bdPalabra(sql, "Nivel")

        sql = "SELECT   * " + _
              "FROM CdClassSubjectCategoryENE WHERE ClassSubject = '" + clase + "' AND EducationLevel = '" + nivel + "' "
        bdDataTable(sql, etiquetas)
        If etiquetas.Rows.Count > 0 Then
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C1")), chequearValor(etiquetas.Rows(0)("C1Max")), C1L, C1V, C1M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C2")), chequearValor(etiquetas.Rows(0)("C2Max")), C2L, C2V, C2M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C3")), chequearValor(etiquetas.Rows(0)("C3Max")), C3L, C3V, C3M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C4")), chequearValor(etiquetas.Rows(0)("C4Max")), C4L, C4V, C4M)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C5")), chequearValor(etiquetas.Rows(0)("C5Max")), C5L, C5V, C5M)
            If ClasesCombo.SelectedValue = "EDMU" Then
                llenarEtiqueta(chequearValor(etiquetas.Rows(0)("C6")), chequearValor(etiquetas.Rows(0)("C6Max")), C6L, C6V, C6M)
            End If
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("Zona")), chequearValor(etiquetas.Rows(0)("ZonaMax")), zonaL, ZonaV, zonaM)
            llenarEtiqueta(chequearValor(etiquetas.Rows(0)("Examen")), chequearValor(etiquetas.Rows(0)("ExamenMax")), examenL, ExamenV, examenM)
            llenarEtiqueta("Total", 100, totalL, TotalV, totalM)
            NotasPanel.Visible = True
        End If
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
            'If ExamenV.Text = 0 Then 'no tiene nota
            'Else
            Integer.TryParse(ExamenV.Text, examen)
            Integer.TryParse(examenM.Text, minimo)
            If examen > minimo Then
                MsgBox("No puede ingresar un valor mayor a " + examenM.Text, vbQuestion, My.Resources.versionFamilias2)
                ExamenV.Text = 0
            End If
            'Else
            calcularTotal()
            GuardarButton.Focus()
            'End If
            'End If
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If miembro = 0 Then
            MsgBox("Verifique que haya seleccionado un alumno", vbQuestion, My.Resources.versionFamilias2)
        Else
            calcularZona()
            calcularTotal()
            If trans = "N" Then
                nuevoRegistro()
            ElseIf trans = "A" Then
                actualizar()
            End If
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
        lZona.Text = 0
        lexamen.Text = 0
        lTotal.Text = 0
        C1V.Text = 0
        C2V.Text = 0
        C3V.Text = 0
        C4V.Text = 0
        C5V.Text = 0
        C6V.Text = 0
        ZonaV.Text = 0
        ExamenV.Text = 0
        TotalV.Text = 0
        Alumno.Text = "Seleccionar Alumno"
        NotaFinal.Text = ""
        NotaFinal.BackColor = Color.White
        NotaFinal.ForeColor = Color.Black
    End Sub

    Private Sub listado()
        CalificacionesGrid.DataSource = Nothing
        CalificacionesGrid.Rows.Clear()
        Dim lista As New DataTable
        sql = "SELECT Y.MemberId AS Código, M.LastNames AS Apellidos, M.FirstNames AS Nombres, M.Gender AS 'M/F', M.LastFamilyId AS Familia, " + _
              "C.I1, C.I2, C.I3, C.I4, C.I5, C.I6, C.TotalZone AS Zona, C.Examen, C.Total, CASE WHEN C.Total <= 64 THEN 'NM' ELSE CASE WHEN C.Total <= 79 " + _
              "THEN 'B' ELSE CASE WHEN C.Total <= 89 THEN 'MB' ELSE 'E' END END END AS 'Nota Final' " + _
              "FROM  dbo.MemberEducationYear Y " + _
              "INNER JOIN dbo.Member M ON Y.Project = M.Project AND Y.MemberId = M.MemberId AND Y.RecordStatus = M.RecordStatus " + _
              "LEFT OUTER JOIN dbo.MemberEducationClassENE C ON Y.Project = C.Project AND Y.MemberId = C.MemberId AND Y.SchoolYear = C.SchoolYear AND " + _
              "Y.Grade = C.Grade AND Y.RecordStatus = C.RecordStatus AND C.Cycle = '" + CicloCombo.SelectedValue.ToString + "' AND " + _
              "C.ClassSubject = '" + ClasesCombo.SelectedValue + "' " + _
              "WHERE Y.RecordStatus = ' ' AND Y.Project = 'N' AND  Y.SchoolYear = " + AñoV.Text + " AND Y.Grade = '" + GradoCombo.SelectedValue + "' " + _
              "ORDER BY M.LastNames, M.FirstNames  "
        'InputBox("", "", sql)
        bdGrid(sql, CalificacionesGrid)
        Dim n As Integer = CalificacionesGrid.Columns.Count
        If n > 0 Then
            Dim i As Integer
            With CalificacionesGrid
                .Columns(5).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C1"))
                .Columns(6).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C2"))
                .Columns(7).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C3"))
                .Columns(8).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C4"))
                .Columns(9).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C5"))
                .Columns(10).HeaderCell.Value = chequearValor(etiquetas.Rows(0)("C6"))
                .Columns(0).HeaderCell.Style.Font = New Font("Arial Narrow", 9)
                For i = 0 To 14
                    .Columns(i).HeaderCell.Style.Font = New Font("Arial Narrow", 9)
                Next
                .Columns(1).Frozen = True
                .Columns(2).Frozen = True
            End With

            Dim notaFinal As String
            For i = 0 To CalificacionesGrid.RowCount - 1
                If Len(chequearValor(CalificacionesGrid.Rows(i).Cells(14).Value)) > 0 Then
                    notaFinal = chequearValor(CalificacionesGrid.Rows(i).Cells(14).Value)
                    If colorNotaFinal(notaFinal) = "Red" Then
                        CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.Red
                        CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.White
                    ElseIf colorNotaFinal(notaFinal) = "Yellow" Then
                        CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.Yellow
                        CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.Black
                    ElseIf colorNotaFinal(notaFinal) = "Green" Then
                        CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.Green
                        CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.White
                    Else
                        CalificacionesGrid.Rows(i).Cells(14).Style.BackColor = Color.White
                        CalificacionesGrid.Rows(i).Cells(14).Style.ForeColor = Color.Black
                    End If
                End If
            Next
            CalificacionesGrid.Columns(10).Visible = False

            If ClasesCombo.SelectedValue = "EDMU" Then
                CalificacionesGrid.Columns(10).Visible = True
                C6L.Visible = True
                C6V.Visible = True
                C6M.Visible = True
                l6.Visible = True
            End If
            If ClasesCombo.SelectedValue = "INGL" Then
                CalificacionesGrid.Columns(11).Visible = False
                CalificacionesGrid.Columns(12).Visible = False
                lzona.Visible = False
                lexamen.Visible = False
            End If
            'CalificacionesGrid.Rows(filaSel).Selected = True
        End If
        CalificacionesGrid.Visible = True
        CalificacionesGrid.Columns(3).Visible = False
        CalificacionesGrid.Columns(2).Frozen = True
    End Sub

    Private Sub ListadoButton_Click(sender As Object, e As EventArgs) Handles ListadoButton.Click
        If Len(AñoV.Text) > 0 And GradoCombo.SelectedIndex > -1 And CicloCombo.SelectedIndex > -1 And ClasesCombo.SelectedIndex > -1 Then
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

    Private Sub nomenclaturaNotaFinal()
        If total >= 0 And total <= 64 Then
            NotaFinal.Text = "NM"
        ElseIf total >= 65 And total <= 79 Then
            NotaFinal.Text = "B"
        ElseIf total >= 80 And total <= 89 Then
            NotaFinal.Text = "MB"
        ElseIf total >= 90 And total <= 100 Then
            NotaFinal.Text = "E"
        Else
            NotaFinal.Text = ""
        End If

        If colorNotaFinal(NotaFinal.Text) = "Red" Then
            NotaFinal.BackColor = Color.Red
        ElseIf colorNotaFinal(NotaFinal.Text) = "Yellow" Then
            NotaFinal.BackColor = Color.Yellow
        ElseIf colorNotaFinal(NotaFinal.Text) = "Green" Then
            NotaFinal.BackColor = Color.Green
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New CalificacionesPREPA
        nxt.GradoCombo.SelectedValue = GradoCombo.SelectedValue
        nxt.CicloCombo.SelectedValue = CicloCombo.SelectedValue
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub nuevoRegistro()
        sql = "INSERT INTO MemberEducationClassENE VALUES ('" + S + "', " + miembro.ToString + "," + AñoV.Text + ", '" + _
              GradoCombo.SelectedValue + "', '" + ClasesCombo.SelectedValue.ToString + "', '" + CicloCombo.SelectedValue.ToString + "', " + _
              "GETDATE(), ' ', '" + U + "', NULL, " + C1V.Text + ", " + C2V.Text + ", " + C3V.Text + ", " + C4V.Text + ", " + _
              C5V.Text + ", " + C6V.Text + ", 0, " + ZonaV.Text + ", " + ExamenV.Text + ", " + TotalV.Text + ") "
        bdInsertar(sql)
        listado()
        limpiarCampos()
    End Sub

    Private Sub ValoresIniciales()
        trans = "N"
        AñoV.Text = Now.Year.ToString

        ''Grado
        sql = "SELECT Code, DescSpanish FROM CdGrade WHERE EducationLevel = 'PREP' " + _
                "AND Code NOT IN ('DI', 'ET1', 'ET2', 'ET3', 'ET4', 'ET5', 'ET6') ORDER BY Orden"
        bdCombo(sql, GradoCombo, "Code", "DescSpanish")

        ''grado del usuario
        sql = "SELECT CASE WHEN CustomField3 IS NULL THEN '' ELSE CustomField3 END Grado FROM FwEmployee WHERE EmployeeId = '" + U + "'"
        gradoSel = bdPalabra(sql, "Grado")
        If Len(gradoSel) > 0 Then
            sql = "SELECT EducationLevel L FROM CdGrade WHERE Code = '" + gradoSel + "' "
            If bdPalabra(sql, "L") = "PREP" Then
                GradoCombo.SelectedValue = gradoSel
                GradoCombo.Enabled = False
            Else
                gradoSel = ""
            End If
        Else
            gradoSel = ""
        End If

        ''ciclo
        sql = "SELECT Cycle, DescSpanish D FROM CdCycleENE WHERE Active = 1 "
        bdCombo(sql, CicloCombo, "Cycle", "D")

        ''clases
        sql = "SELECT Code, DescSpanish D FROM cdClassSubjectENE WHERE Active = 1 AND PREP = 1 ORDER BY DescSpanish "
        bdCombo(sql, ClasesCombo, "Code", "D")


    End Sub


End Class