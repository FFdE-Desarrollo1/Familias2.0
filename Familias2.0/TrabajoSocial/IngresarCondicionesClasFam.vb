' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class IngresarCondicionesClasFam
    Dim n As Integer = 0
    Dim total, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12 As Integer

    Private Sub IngresarCondicionesClasFam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub calcularNuevaClasificacion()
        Dim total As Integer = sumarCondiciones()
        If total <= 2 Then
            ClasificacionV.Text = "C"
        ElseIf total > 2 And total < 5 Then
            ClasificacionV.Text = "B"
        Else
            ClasificacionV.Text = "A"
        End If
    End Sub

    Private Sub Cond1V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond1V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub Cond2V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond2V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub Cond3V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond3V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub Cond4V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond4V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub Cond5V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond5V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub Cond6V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond6V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub Cond7V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond7V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub Cond8V_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cond8V.CheckedChanged
        calcularNuevaClasificacion()
    End Sub

    Private Sub guardar()
        If ClasificacionV.Text = "A" Or ClasificacionV.Text = "B" Or ClasificacionV.Text = "C" Then
            Dim code1, code2, code3, code4, code5, code6, code7, code8, extraCond As String

            sql = "SELECT Code Condicion FROM dbo.CdFamilyClassificationCondition " + _
                  "WHERE Active = 1 AND Project = '" + S + "' "
            code1 = bdPalabra(sql + "AND Orden = 1 ", "Condicion")
            code2 = bdPalabra(sql + "AND Orden = 2 ", "Condicion")
            code3 = bdPalabra(sql + "AND Orden = 3 ", "Condicion")
            code4 = bdPalabra(sql + "AND Orden = 4 ", "Condicion")
            code5 = bdPalabra(sql + "AND Orden = 5 ", "Condicion")
            code6 = bdPalabra(sql + "AND Orden = 6 ", "Condicion")
            code7 = bdPalabra(sql + "AND Orden = 7 ", "Condicion")
            code8 = bdPalabra(sql + "AND Orden = 8 ", "Condicion")

            extraCond = "NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '')"

            'Project, FamilyId, Classification, YearClassification, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, RegisteredDate, Inactive, 
            'Condition1, PointsC1, Condition2, PointsC2, Condition3, PointsC3, Condition4, PointsC4, Condition5, PointsC5, Condition6, PointsC6, Condition7,
            ' PointsC7, Condition8, PointsC8, Comments
            sql = "INSERT INTO dbo.FamilyClassificationHistory VALUES ('" + S + "', " + FamiliaV.Text + ", '" + ClasificacionV.Text + "', " + AñoClasV.Text + _
                ", GETDATE(), ' ', '" + U + "', NULL, GETDATE(), 0, '" + _
                code1 + "', " + c1.ToString + ", '" + code2 + "', " + c2.ToString + ", '" + code3 + "', " + c3.ToString + ", '" + code4 + "', " + c4.ToString + ", '" + _
                code5 + "', " + c5.ToString + ", '" + code6 + "', " + c6.ToString + ", '" + code7 + "', " + c7.ToString + ", '" + code8 + "', " + c8.ToString + ", " + _
                extraCond
            bdInsertar(sql)

            MsgBox("Se ha ingresado correctamente la nueva clasificación", vbQuestion, My.Resources.versionFamilias2)
            regresarListado()
        Else
            MsgBox("No ha seleccionado ninguna opción", vbQuestion, My.Resources.versionFamilias2)
        End If

    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        guardar()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub llenarCondiciones()
        sql = "SELECT CASE WHEN DescSpanish IS NULL THEN '' ELSE DescSpanish END  Condicion FROM dbo.CdFamilyClassificationCondition " + _
              "WHERE Active = 1 AND Project = 'F' "
        '"WHERE Active = 1 AND Project = '" + S + "' "

        Cond1V.Text = bdPalabra(sql + "AND Orden = 1 ", "Condicion")
        Cond2V.Text = bdPalabra(sql + "AND Orden = 2 ", "Condicion")
        Cond3V.Text = bdPalabra(sql + "AND Orden = 3 ", "Condicion")
        Cond4V.Text = bdPalabra(sql + "AND Orden = 4 ", "Condicion")
        Cond5V.Text = bdPalabra(sql + "AND Orden = 5 ", "Condicion")
        Cond6V.Text = bdPalabra(sql + "AND Orden = 6 ", "Condicion")
        Cond7V.Text = bdPalabra(sql + "AND Orden = 7 ", "Condicion")
        Cond8V.Text = bdPalabra(sql + "AND Orden = 8 ", "Condicion")

        sql = "SELECT CASE WHEN Comments IS NULL THEN '' ELSE Comments END  AS Condicion FROM dbo.CdFamilyClassificationCondition " + _
              "WHERE Active = 1 AND Project = 'F' "
        '"WHERE Active = 1 AND Project = '" + S + "' "

        Cond1L.Text = bdPalabra(sql + "AND Orden = 1 ", "Condicion")
        Cond2L.Text = bdPalabra(sql + "AND Orden = 2 ", "Condicion")
        Cond3L.Text = bdPalabra(sql + "AND Orden = 3 ", "Condicion")
        Cond4L.Text = bdPalabra(sql + "AND Orden = 4 ", "Condicion")
        Cond5L.Text = bdPalabra(sql + "AND Orden = 5 ", "Condicion")
        Cond6L.Text = bdPalabra(sql + "AND Orden = 6 ", "Condicion")
        Cond7L.Text = bdPalabra(sql + "AND Orden = 7 ", "Condicion")
        Cond8L.Text = bdPalabra(sql + "AND Orden = 8 ", "Condicion")
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        regresarListado()
    End Sub

    Private Sub regresarListado()
        Dim list As New CondicionesClasificacionFamiliar
        list.Show()
        Me.Close()
    End Sub

    Private Function sumarCondiciones() As Integer
        total = 0

        If Cond1V.Checked = True Then
            c1 = 1
        Else
            c1 = 0
        End If

        If Cond2V.Checked = True Then
            c2 = 1
        Else
            c2 = 0
        End If

        If Cond3V.Checked = True Then
            c3 = 1
        Else
            c3 = 0
        End If

        If Cond4V.Checked = True Then
            c4 = 1
        Else
            c4 = 0
        End If

        If Cond5V.Checked = True Then
            c5 = 1
        Else
            c5 = 0
        End If

        If Cond6V.Checked = True Then
            c6 = 1
        Else
            c6 = 0
        End If

        If Cond7V.Checked = True Then
            c7 = 1
        Else
            c7 = 0
        End If

        If Cond8V.Checked = True Then
            c8 = 1
        Else
            c8 = 0
        End If

        sumarCondiciones = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8
    End Function

    Private Sub valoresIniciales()
        llenarCondiciones()
        AñoClasV.Text = (Today.Year + 1).ToString
    End Sub
End Class
