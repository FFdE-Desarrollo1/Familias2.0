' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class InformesFarmacia1
    Dim wh, op, presDateTime, deliveredDateTime As String

    Private Sub InformesFarmacia1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        sql = "SELECT * FROM  dbo.fn_HEAL_FARM_Entregados('F', " + DeAñoV.Text + ") " + w
        Entregados = sql
    End Function

    Private Sub EntregadosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntregadosButton.Click
        op = "Entregados"
        irAInforme(op, Entregados(), op + " - " + DeAñoV.Text)
    End Sub

    Private Function Existencias() As String
        Dim wh1 As String = ""
        Dim wh2 As String = ""
        Dim st, om, tm, m As String
        st = "Existencia <= [Cantidad de un Tratamiento] "
        om = "Existencia <= [Cantidad Mínima para 1 Mes] "
        tm = "Existencia <= [Cantidad Mínima para 3 Meses] "
        m = "Existencia > [Cantidad Mínima para 3 Meses] "
        sql = "SELECT * FROM dbo.fn_HEAL_FARM_Existencias() E " + _
              "WHERE Code <> 'OTRA' "

        If FuenteCombo.SelectedIndex < 0 Then
            wh1 = " "
        Else
            wh1 = " AND [Comprado en] = '" + FuenteCombo.Text + "'"
        End If

        If TratCheckBox.Checked = True And mesCheckBox.Checked = True And mesesCheckBox.Checked = True And addCheckBox.Checked = True Then
            Existencias = sql + wh1
        ElseIf TratCheckBox.Checked = True Or mesCheckBox.Checked = True Or mesesCheckBox.Checked = True Or addCheckBox.Checked = True Then
            If TratCheckBox.Checked = True Then
                wh2 = " AND " + st
            End If
            If mesCheckBox.Checked = True Then
                wh2 = " AND " + om
            End If
            If mesesCheckBox.Checked = True Then
                wh2 = " AND " + tm
            End If
            If addCheckBox.Checked = True Then
                wh2 = " AND " + m
            End If
            Existencias = sql + wh1 + wh2 + " ORDER BY Code "
        Else
            Existencias = ""
        End If
    End Function

    Private Sub ExistenciasButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasButton.Click
        op = "Existencias"
        If Existencias() = "" Then
            MsgBox("Necesita seleccionar alguna de las opciones", vbInformation, My.Resources.versionFamilias2)
        Else
            irAInforme(op, Existencias(), op)
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irAInforme(ByVal op As String, ByVal wh As String, ByVal tit As String)
        Dim nv As New InformesFarmacia
        nv.wH = wh
        nv.opcion = op
        nv.Title.Text = tit
        nv.Show()
        Me.Close()
    End Sub

    Private Function lista()
        sql = "SELECT Code AS Código, DescSpanish AS Artículo, DosageDesc_es AS Descripción, ROUND(Price, 2) AS Precio, ValidSelection " + _
                 "FROM  dbo.CdHealthInventoryItem CdI   WHERE Category = 'MEDI' AND Code < '2900' AND Active = 1 "
        lista = sql
    End Function

    Private Sub MedsSinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedsSinButton.Click
        If precioCheckBox.Checked = True Then
            op = "Artículos Con Precios"
        Else
            op = "Artículos Sin Precios"
        End If
        irAInforme(op, lista(), "Listado de " + op)
    End Sub

    Private Function Transac() As String
        Dim w As String
        If Len(ProveedorCombo.Text) > 0 And Len(tArticuloCombo.Text) > 0 Then
            w = "WHERE Code = '" + tArticuloCombo.SelectedValue + "' AND Proveedor = '" + ProveedorCombo.Text + "' "
        ElseIf Len(ProveedorCombo.Text) > 0 Or Len(tArticuloCombo.Text) > 0 Then
            If Len(tArticuloCombo.Text) > 0 Then
                w = " WHERE Code = '" + tArticuloCombo.SelectedValue + "' "
            Else
                w = " WHERE Proveedor = '" + ProveedorCombo.Text + "' "
            End If
        Else
            w = ""
        End If

        sql = "SELECT * FROM dbo.fn_HEAL_FARM_TransaccionesInv('F', '" + tDeFechaPicker.Value.ToString(en.DateTimeFormat) + "', '" + tAFechaPicker.Value.ToString(en.DateTimeFormat) + "') " + w +
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

        sql = "SELECT Code, DescSpanish Descripcion FROM dbo.CdProvider WHERE Active = 1 AND Project = '" + S + "' AND FunctionalArea = 'FARM' "
        bdCombo(sql, ProveedorCombo, "Code", "Descripcion")

        DeAñoV.Text = DateTime.Now.Year.ToString

        sql = "SELECT Code, CAST(CdI.Code AS nvarchar(7)) + ' - ' + CASE WHEN CdI.DosageDesc_es IS NOT NULL THEN CdI.DescSpanish " + _
                 "+ ' (' + DosageDesc_es + ')' ELSE CdI.DescSpanish END AS Medicine " + _
              "FROM dbo.CdHealthInventoryItem CdI WHERE Active = 1 AND ValidSelection = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, ArticuloCombo, "Code", "Medicine")
        bdCombo(sql, tArticuloCombo, "Code", "Medicine")

        tDeFechaPicker.Value = DateTime.Parse(DateTime.Now.Year.ToString + "/" + DateTime.Now.Month.ToString + "/01")
        tAFechaPicker.Value = DateTime.Parse(DateTime.Now.Year.ToString + "/" + DateTime.Now.Month.ToString + "/" + DateTime.Now.Day.ToString)

        ExistenciasButton.Focus()
    End Sub
End Class

