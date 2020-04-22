Public Class Calificaciones

    Dim unidad As Integer = 0
    Dim nivel As String = ""
    Dim carrera As String = " "
    Dim matesDesc As String = ""
    Dim otrasDesc As String = ""

    Private Sub Calificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        AñoV.Text = Now.Year.ToString
        If Len(MiembroV.Text) = 0 Then
            MiembroV.Focus()
        Else
            validarMiembro()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub llenarCampos()
        Dim genInfo As New DataTable
        'sql = "SELECT FirstNames + ' ' + LastNames Nombre, LastFamilyId Familia FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId = " + MiembroV.Text

        sql = "SELECT * " + _
           "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + AñoV.Text + ") L "
        bdDataTable(sql, genInfo)
        NombreV.Text = chequearValor(genInfo.Rows(0)("Nombres")).ToString + " " + chequearValor(genInfo.Rows(0)("Apellidos")).ToString
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString

        nivel = chequearValor(genInfo.Rows(0)("Nivel_Educ")).ToString
        carrera = chequearValor(genInfo.Rows(0)("Carrera")).ToString
        If Len(carrera) > 0 Then
            carrera = " - " + carrera
        End If

        EducInfoL.Text = chequearValor(genInfo.Rows(0)("Estado_Educ")).ToString + " " + chequearValor(genInfo.Rows(0)("Grado")).ToString + " " + _
             carrera + " - " + chequearValor(genInfo.Rows(0)("Escuela")).ToString
        MiembroV.Enabled = False
        FamiliaV.Enabled = False
        AñoV.Enabled = False
        GenInfoTable.Visible = True
        InfoTable.Visible = True

        detalleClasesTable.Visible = True
        padresICheck.Focus()
    End Sub

    'Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
    '    Dim nxt As New Calificaciones
    '    nxt.Show()
    '    Me.Close()
    'End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If (MiembroV.Text) = 0 Then
            Else
                validarMiembro()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub validarMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            llenarCampos()
            Dim familia As Integer = Integer.Parse(FamiliaV.Text)
            FamiliaV.Enabled = False
        Else
        MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
        MiembroV.Text = ""
        End If
    End Sub

    Private Sub semaforoVerde(ByVal gano As CheckBox, ByVal perdidas As TextBox, ByVal unidad As Label)
        If gano.Checked = True Then
            perdidas.ReadOnly = True
            unidad.BackColor = Color.Green
        Else
            perdidas.ReadOnly = False
            unidad.BackColor = Color.Transparent
        End If

    End Sub

    Private Sub ganoICheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoICheck.CheckedChanged
        semaforoVerde(ganoICheck, PerdidasI, IL)
    End Sub

    Private Sub ganoIICheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoIICheck.CheckedChanged
        semaforoVerde(ganoIICheck, PerdidasII, IIL)
    End Sub

    Private Sub ganoIIICheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoIIICheck.CheckedChanged
        semaforoVerde(ganoIIICheck, PerdidasIII, IIIL)
    End Sub

    Private Sub ganoIVCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoIVCheck.CheckedChanged
        semaforoVerde(ganoIVCheck, PerdidasIV, IVL)
    End Sub

    Private Sub ganoVCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoVCheck.CheckedChanged
        semaforoVerde(ganoVCheck, PerdidasV, VL)
    End Sub

    Private Sub ganoVICheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoVICheck.CheckedChanged
        semaforoVerde(ganoVICheck, PerdidasVI, VIL)
    End Sub

    Private Sub ganoVIICheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoVIICheck.CheckedChanged
        semaforoVerde(ganoVIICheck, PerdidasVII, VIIL)
    End Sub

    Private Sub ganoVIIICheck_CheckedChanged(sender As Object, e As EventArgs) Handles ganoVIIICheck.CheckedChanged
        semaforoVerde(ganoVIIICheck, PerdidasVIII, VIIIL)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()

    End Sub

    Private Sub semaforo(ByVal perdidas As TextBox, ByVal unidad As Label)
        If Len(perdidas.Text) > 0 And Len(nivel) > 0 Then
            Dim cantidad = Integer.Parse(perdidas.Text)

            If nivel = "Básico" Or nivel = "Diversificado" Or nivel = "Vocacional" Then
                If cantidad > 0 And cantidad < 5 Then
                    unidad.BackColor = Color.Yellow
                ElseIf cantidad > 4 Then
                    unidad.BackColor = Color.Red
                Else
                    unidad.BackColor = Color.Transparent
                End If
            ElseIf nivel = "Preprimaria" Or nivel = "Primaria" Or nivel = "Escuela Especial" Then
                If cantidad > 0 And cantidad < 3 Then
                    unidad.BackColor = Color.Yellow
                ElseIf cantidad > 2 Then
                    unidad.BackColor = Color.Red
                Else
                    unidad.BackColor = Color.Transparent
                End If
            Else
                unidad.BackColor = Color.Transparent
            End If
        Else
            unidad.BackColor = Color.Transparent
        End If
    End Sub




    Private Sub PerdidasI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasI.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasII_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasII.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasIII_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasIII.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasIV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasIV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasVI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasVI.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasVII_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasVII.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasVIII_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PerdidasVIII.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PerdidasI_TextChanged(sender As Object, e As EventArgs) Handles PerdidasI.TextChanged
        semaforo(PerdidasI, IL)
        'If Len(PerdidasI.Text) > 0 And Len(nivel) > 0 Then
        '    Dim cantidad = Integer.Parse(PerdidasI.Text)

        '    If nivel = "Básico" Or nivel = "Diversificado" Or nivel = "Vocacional" Then
        '        If cantidad > 0 And cantidad < 5 Then
        '            IL.BackColor = Color.Yellow
        '        ElseIf cantidad > 4 Then
        '            IL.BackColor = Color.Red
        '        Else
        '            IL.BackColor = Color.Transparent
        '        End If
        '    ElseIf nivel = "Preprimaria" Or nivel = "Primaria" Or nivel = "Escuela Especial" Then
        '        If cantidad > 0 And cantidad < 3 Then
        '            IL.BackColor = Color.Yellow
        '        ElseIf cantidad > 2 Then
        '            IL.BackColor = Color.Red
        '        Else
        '            IL.BackColor = Color.Transparent
        '        End If
        '    Else
        '        IL.BackColor = Color.Transparent
        '    End If
        'Else
        '    IL.BackColor = Color.Transparent
        'End If
    End Sub

    Private Sub PerdidasII_TextChanged(sender As Object, e As EventArgs) Handles PerdidasII.TextChanged
        semaforo(PerdidasII, IIL)
    End Sub

    Private Sub PerdidasIII_TextChanged(sender As Object, e As EventArgs) Handles PerdidasIII.TextChanged
        semaforo(PerdidasIII, IIIL)
    End Sub

    Private Sub PerdidasIV_TextChanged(sender As Object, e As EventArgs) Handles PerdidasIV.TextChanged
        semaforo(PerdidasIV, IVL)
    End Sub

    Private Sub PerdidasV_TextChanged(sender As Object, e As EventArgs) Handles PerdidasV.TextChanged
        semaforo(PerdidasV, VL)
    End Sub

    Private Sub PerdidasVI_TextChanged(sender As Object, e As EventArgs) Handles PerdidasVI.TextChanged
        semaforo(PerdidasVI, VIL)
    End Sub

    Private Sub PerdidasVII_TextChanged(sender As Object, e As EventArgs) Handles PerdidasVII.TextChanged
        semaforo(PerdidasVII, VIIL)
    End Sub

    Private Sub PerdidasVIII_TextChanged(sender As Object, e As EventArgs) Handles PerdidasVIII.TextChanged
        semaforo(PerdidasVIII, VIIIL)
    End Sub


    Private Sub ClasesButton_Click(sender As Object, e As EventArgs) Handles ClasesButton.Click
        mates()
        Otras()
    End Sub

    Private Sub mates()
        matesDesc = ""
        If Mates1Combo.SelectedIndex = -1 Then
            matesDesc = matesDesc
        Else
            matesDesc = matesDesc + Mates1Combo.Text
        End If

        If Mates2Combo.SelectedIndex = -1 Then
            matesDesc = matesDesc
        Else
            matesDesc = matesDesc + ", " + Mates2Combo.Text
        End If

        If Mates3Combo.SelectedIndex = -1 Then
            matesDesc = matesDesc
        Else
            matesDesc = matesDesc + ", " + Mates3Combo.Text
        End If

        If UnidadCombo.Text = "I" Then
            NumericasI.Text = matesDesc
        ElseIf UnidadCombo.Text = "II" Then
            NumericasII.Text = matesDesc
        ElseIf UnidadCombo.Text = "III" Then
            NumericasIII.Text = matesDesc
        End If
    End Sub

    Private Sub Otras()
        otrasDesc = ""
        If Otras1Combo.SelectedIndex = -1 Then
            otrasDesc = otrasDesc
        Else
            otrasDesc = otrasDesc + Otras1Combo.Text
        End If

        If Otras2Combo.SelectedIndex = -1 Then
            otrasDesc = otrasDesc
        Else
            otrasDesc = otrasDesc + ", " + Otras2Combo.Text
        End If

        If Otras3Combo.SelectedIndex = -1 Then
            otrasDesc = otrasDesc
        Else
            otrasDesc = otrasDesc + ", " + Otras3Combo.Text
        End If

        If UnidadCombo.Text = "I" Then
            OtrasI.Text = otrasDesc
        ElseIf UnidadCombo.Text = "II" Then
            OtrasII.Text = otrasDesc
        ElseIf UnidadCombo.Text = "III" Then
            OtrasIII.Text = otrasDesc
        End If
    End Sub
End Class