' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActividadesDuplicadasEduc

    Private Sub ActividadesDuplicadasEduc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        getLista()
    End Sub

    Private Sub getLista()
        Dim where As String

        If S = "R" Or S = "M" Then
            where = "WHERE Area IN ('EDUC', 'MISC')  AND AÑO > 2012  "
        ElseIf S = "F" Then
            where = "WHERE Area = 'EDUC' AND AÑO > 2013  AND Actividad LIKE '%califica%'  "
        Else
            where = "WHERE Area = 'EDUC' AND AÑO > 2012 "
        End If

        If TipoList.Text = "" Or TipoList.Text = " " Then
        Else
            where = where + " AND  Actividad = '" + TipoList.Text + "' "
        End If

        Dim sql As String
        sql = "SELECT Miembro, Nombre, Familia, Estado_Afil, Actividad, Año " + _
              "FROM dbo.fn_MISC_ActivitiesList('" + S + "')  " + _
              where + _
              "GROUP BY Miembro, Nombre, Familia, Estado_Afil, Actividad, Año " + _
              "HAVING COUNT(*) > 1 " + _
              "ORDER BY Miembro, Año "
        bdGrid(sql, ListGrid)
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListGrid.AutoResizeColumns()

        TotalL.Text = "Total:" + ListGrid.Rows.Count.ToString
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        Dim where As String

        If S = "F" Then
            where = "WHERE Active = 1 AND (Code LIKE 'CAL%') AND Project IN ('*', '" + S + "')  AND FunctionalArea ='EDUC' AND CodeInt IS NULL "
        Else
            where = "WHERE Active = 1 AND  Project IN ('*', '" + S + "')  AND FunctionalArea ='EDUC' AND CodeInt IS NULL "
        End If

        Dim tipoSQL As String = "SELECT Code, DescSpanish FROM dbo.CdMemberActivityType " + _
                                                where + " ORDER BY DescSpanish"
        bdCombo(tipoSQL, TipoList, "Code", "DescSpanish")
    End Sub
End Class