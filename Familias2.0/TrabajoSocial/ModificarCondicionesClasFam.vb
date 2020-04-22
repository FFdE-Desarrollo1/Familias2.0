' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ModificarCondicionesClasFam
    Dim n As Integer = 0
    Dim total, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12 As Integer

    Private Sub ModificarCondicionesClasFam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New CondicionesClasificacionFamiliar
        nxt.Show()
        Me.Close()
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
        Dim GenInfo As New DataTable
        sql = "SELECT FCH.Project, FCH.FamilyId, FCH.Classification, FCH.YearClassification, " + _
                "C1.DescSpanish AS C1, C1.Comments AS C1a, FCH.PointsC1, " + _
                "C2.DescSpanish AS C2, C2.Comments AS C2a, FCH.PointsC2, " + _
                "C3.DescSpanish AS C3, C3.Comments AS C3a, FCH.PointsC3, " + _
                "C4.DescSpanish AS C4, C4.Comments AS C4a, FCH.PointsC4, " + _
                "C5.DescSpanish AS C5, C5.Comments AS C5a, FCH.PointsC5, " + _
                "C6.DescSpanish AS C6, C6.Comments AS C6a, FCH.PointsC6, " + _
                "C7.DescSpanish AS C7, C7.Comments AS C7a, FCH.PointsC7, " + _
                "C8.DescSpanish AS C8, C8.Comments AS C8a, FCH.PointsC8 " + _
               "FROM dbo.FamilyClassificationHistory FCH " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C1 ON FCH.Condition1 = C1.Code " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C2 ON FCH.Condition2 = C2.Code " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C3 ON FCH.Condition3 = C3.Code " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C4 ON FCH.Condition4 = C4.Code " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C5 ON FCH.Condition5 = C5.Code " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C6 ON FCH.Condition6 = C6.Code " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C7 ON FCH.Condition7 = C7.Code " + _
                "LEFT OUTER JOIN dbo.CdFamilyClassificationCondition C8 ON FCH.Condition8 = C8.Code " + _
              "WHERE FCH.RecordStatus = ' ' AND FCH.YearClassification = YEAR({ fn NOW() }) + 1 AND " + _
                "FCH.Project = '" + S + "' AND FCH.FamilyId = " + FamiliaV.Text + "  AND Inactive = 0 "
        bdDataTable(sql, GenInfo)
        ClasificacionV.Text = chequearValor(GenInfo.Rows(0)("Classification"))
        AñoClasV.Text = chequearValor(GenInfo.Rows(0)("YearClassification"))
        Cond1V.Text = chequearValor(GenInfo.Rows(0)("C1"))
        Cond2V.Text = chequearValor(GenInfo.Rows(0)("C2"))
        Cond3V.Text = chequearValor(GenInfo.Rows(0)("C3"))
        Cond4V.Text = chequearValor(GenInfo.Rows(0)("C4"))
        Cond5V.Text = chequearValor(GenInfo.Rows(0)("C5"))
        Cond6V.Text = chequearValor(GenInfo.Rows(0)("C6"))
        Cond7V.Text = chequearValor(GenInfo.Rows(0)("C7"))
        Cond8V.Text = chequearValor(GenInfo.Rows(0)("C8"))

        Cond1L.Text = chequearValor(GenInfo.Rows(0)("C1a"))
        Cond2L.Text = chequearValor(GenInfo.Rows(0)("C2a"))
        Cond3L.Text = chequearValor(GenInfo.Rows(0)("C3a"))
        Cond4L.Text = chequearValor(GenInfo.Rows(0)("C4a"))
        Cond5L.Text = chequearValor(GenInfo.Rows(0)("C5a"))
        Cond6L.Text = chequearValor(GenInfo.Rows(0)("C6a"))
        Cond7L.Text = chequearValor(GenInfo.Rows(0)("C7a"))
        Cond8L.Text = chequearValor(GenInfo.Rows(0)("C8a"))

        Cond1V.Checked = chequearValor(GenInfo.Rows(0)("PointsC1"))
        Cond2V.Checked = chequearValor(GenInfo.Rows(0)("PointsC2"))
        Cond3V.Checked = chequearValor(GenInfo.Rows(0)("PointsC3"))
        Cond4V.Checked = chequearValor(GenInfo.Rows(0)("PointsC4"))
        Cond5V.Checked = chequearValor(GenInfo.Rows(0)("PointsC5"))
        Cond6V.Checked = chequearValor(GenInfo.Rows(0)("PointsC6"))
        Cond7V.Checked = chequearValor(GenInfo.Rows(0)("PointsC7"))
        Cond8V.Checked = chequearValor(GenInfo.Rows(0)("PointsC8"))
    End Sub

End Class