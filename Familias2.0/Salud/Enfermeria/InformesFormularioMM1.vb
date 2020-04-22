' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class InformesFormularioMM1
    Dim wh, op, presDateTime, deliveredDateTime, existenciasSQL As String

    Private Sub InformesFormularioMM1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub AAñoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub DeAñoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DeAñoV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function Entregados() As String
        Dim w As String = ""
        If Len(ArticuloCombo.Text) > 0 Then
            w = " WHERE Code = '" + ArticuloCombo.SelectedValue + "' "
        End If

        sql = "SELECT * FROM  dbo.fn_HEAL_MEDI_Entregados('F', " + DeAñoV.Text + ") " + w + "  ORDER BY Artículo "
        Entregados = sql
    End Function

    Private Sub EntregadosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntregadosButton.Click
        op = "Entregados"
        irAInforme(op, Entregados(), op + " - " + DeAñoV.Text)
    End Sub

    Private Sub Existencias()
        Dim wh1, wh2 As String
        sql = "SELECT * FROM dbo.fn_HEAL_MEDI_Existencias() E "

        If FuenteCombo.SelectedIndex < 0 Then
            wh1 = " "
        Else
            wh1 = " WHERE  [Comprado en] = '" + FuenteCombo.Text + "'"
        End If

        If ArticuloExistCombo.SelectedIndex < 0 Then
            wh1 = wh1 + " "
        Else
            If InStr(wh1, "WHERE ") = 0 Then
                wh1 = wh1 + " WHERE Code = '" + ArticuloExistCombo.SelectedValue + "'"

                wh1 = wh1 + " AND Code = '" + ArticuloExistCombo.SelectedValue + "'"
            End If
        End If


        If mesCheckBox.Checked = True And addCheckBox.Checked = False Then
            If InStr(wh1, "WHERE ") = 0 Then
                wh2 = " WHERE Existencia <= [Cantidad Mínima para 1 Mes] "
            Else
                wh2 = " AND Existencia <= [Cantidad Mínima para 1 Mes] "
            End If
        ElseIf mesCheckBox.Checked = False And addCheckBox.Checked = True Then
            If InStr(wh1, "WHERE ") = 0 Then
                wh2 = " WHERE Existencia > [Cantidad Mínima para 1 Mes] "
            Else
                wh2 = " AND Existencia > [Cantidad Mínima para 1 Mes] "
            End If
        Else
            wh2 = ""
        End If

        existenciasSQL = sql + wh1 + wh2 + " ORDER BY Code "

    End Sub

    Private Sub ExistenciasButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasButton.Click
        op = "Existencias"
        Existencias()
        If existenciasSQL = "" Then
            MsgBox("Necesita seleccionar alguna de las opciones", vbInformation, My.Resources.versionFamilias2)
        Else
            irAInforme(op, existenciasSQL, op)
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irAInforme(ByVal op As String, ByVal wh As String, ByVal tit As String)
        Dim nv As New InformesFormularioMM
        nv.wH = wh
        nv.opcion = op
        nv.Title.Text = tit
        nv.Show()
        Me.Close()
    End Sub

    Private Function Transac() As String
        Dim w As String
        If Len(tArticuloCombo.Text) > 0 Then
            w = " WHERE Code = '" + tArticuloCombo.SelectedValue + "' "
        Else
            w = ""
        End If

        sql = "SELECT * FROM dbo.fn_HEAL_MEDI_TransaccionesInv('F', '" + tDeFechaPicker.Value.ToString(en.DateTimeFormat) + "', '" + tAFechaPicker.Value.ToString(en.DateTimeFormat) + "') " + w +
              " ORDER BY [Fecha y Hora de Transacción] "
        Transac = sql
    End Function

    Private Sub TransButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransButton.Click
        op = "Transacciones"
        irAInforme(op, Transac(), op + " - " + tDeFechaPicker.Value.ToShortDateString + " al " + tAFechaPicker.Value.ToShortDateString)
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish Descripcion FROM dbo.CdWhereToBuyItems "
        bdCombo(sql, FuenteCombo, "Code", "Descripcion")

        DeAñoV.Text = DateTime.Now.Year.ToString

        sql = "SELECT Code, CAST(CdI.Code AS nvarchar(7)) + ' - ' + CASE WHEN CdI.DosageDesc_es IS NOT NULL THEN CdI.DescSpanish " + _
                 "+ ' (' + DosageDesc_es + ')' ELSE CdI.DescSpanish END AS Medicine " + _
              "FROM dbo.CdHealthInventoryItem CdI WHERE Active = 1 AND ValidSelection = 1  AND Category = 'MATM' "
        bdCombo(sql, ArticuloCombo, "Code", "Medicine")
        tArticuloCombo.DisplayMember = ArticuloCombo.DisplayMember
        tArticuloCombo.ValueMember = ArticuloCombo.ValueMember
        tArticuloCombo.DataSource = ArticuloCombo.DataSource
        tArticuloCombo.SelectedIndex = -1
        ArticuloExistCombo.DisplayMember = ArticuloCombo.DisplayMember
        ArticuloExistCombo.ValueMember = ArticuloCombo.ValueMember
        ArticuloExistCombo.DataSource = ArticuloCombo.DataSource
        ArticuloExistCombo.SelectedIndex = -1
        tDeFechaPicker.Value = DateTime.Parse(DateTime.Now.Year.ToString + "/" + DateTime.Now.Month.ToString + "/01")
        tAFechaPicker.Value = DateTime.Parse(DateTime.Now.Year.ToString + "/" + DateTime.Now.Month.ToString + "/" + DateTime.Now.Day.ToString)
        ExistenciasButton.Focus()
    End Sub
End Class