' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReporteAnualActividadesEduc
    Dim año As Integer = Today.Year
    Dim where As String

    Private Sub ReporteAnualActividadesMisc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub DetalleMes()
        TotalL.Visible = False
        ListaGrid.DataSource = Nothing
        ListaGrid.Rows.Clear()
        ListaGrid.Visible = False
        ListaGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        where = " WHERE Area = 'EDUC' "

        If Len(AñoV.Text) > 0 Then
            where = where + " AND AÑO = " + AñoV.Text + " "
        End If

        If Len(TipoList.Text) > 0 Then
            where = where + " AND  Actividad = '" + TipoList.Text + "' "
        End If

        sql = "SELECT Miembro, Nombre, Familia, dbo.fn_GEN_tipoMiembro('" + S + "', Miembro) TipoMiembro, Actividad, Año, " + _
                  "SUM(CASE WHEN Mes = 1 THEN Total ELSE 0 END) AS Ene, " + _
                  "SUM(CASE WHEN Mes = 2 THEN Total ELSE 0 END) AS Feb, " + _
                  "SUM(CASE WHEN Mes = 3 THEN Total ELSE 0 END) AS Mar, " + _
                  "SUM(CASE WHEN Mes = 4 THEN Total ELSE 0 END) AS Abr, " + _
                  "SUM(CASE WHEN Mes = 5 THEN Total ELSE 0 END) AS May, " + _
                  "SUM(CASE WHEN Mes = 6 THEN Total ELSE 0 END) AS Jun, " + _
                  "SUM(CASE WHEN Mes = 7 THEN Total ELSE 0 END) AS Jul, " + _
                  "SUM(CASE WHEN Mes = 8 THEN Total ELSE 0 END) AS Ago, " + _
                  "SUM(CASE WHEN Mes = 9 THEN Total ELSE 0 END) AS Sep, " + _
                  "SUM(CASE WHEN Mes = 10 THEN Total ELSE 0 END) AS Oct, " + _
                  "SUM(CASE WHEN Mes = 11 THEN Total ELSE 0 END) AS Nov, " + _
                  "SUM(CASE WHEN Mes = 12 THEN Total ELSE 0 END) AS Dic, " + _
                  "SUM(Total) AS Total " + _
                 "FROM dbo.fn_MISC_ActividadesPorMiembro('" + S + "') " + where + _
                  "GROUP BY Miembro, Nombre, Familia,  dbo.fn_GEN_tipoMiembro('" + S + "', Miembro), Actividad, Año " + _
                  "ORDER BY Nombre, Familia,  Actividad, Año "
        bdGrid(sql, ListaGrid)

        ListaGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        If ListaGrid.RowCount > 0 Then
            For Each r As DataGridViewRow In ListaGrid.Rows
                ListaGrid.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
            Next
        End If

        TotalL.Text = "Total: " + ListaGrid.Rows.Count.ToString
        TotalL.Visible = True
        ListaGrid.Visible = True
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        MsgBox("Este reporte puede tardar unos minutos", vbQuestion, My.Resources.versionFamilias2)
        If verDetalle.Checked = True Then
            If mesCheck.Checked = True Then
                DetalleMes()
            End If
        Else
            If mesCheck.Checked = True Then
                ListadoMes()
            End If
        End If
    End Sub

    Private Sub ListadoMes()
        TotalL.Visible = False
        TotalL.Text = ""
        ListaGrid.DataSource = Nothing
        ListaGrid.Rows.Clear()
        ListaGrid.Visible = False
        ListaGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        where = " WHERE Area = 'EDUC' "

        If Len(AñoV.Text) > 0 Then
            where = where + " AND AÑO = " + AñoV.Text + " "
        End If

        If Len(TipoList.Text) > 0 Then
            where = where + " AND  Actividad = '" + TipoList.Text + "' "
        End If

        sql = "SELECT Actividad, Año, SUM(CASE WHEN Mes = 1 THEN Total ELSE 0 END) AS Ene, " + _
                  "SUM(CASE WHEN Mes = 2 THEN Total ELSE 0 END) AS Feb, " + _
                  "SUM(CASE WHEN Mes = 3 THEN Total ELSE 0 END) AS Mar, " + _
                  "SUM(CASE WHEN Mes = 4 THEN Total ELSE 0 END) AS Abr, " + _
                  "SUM(CASE WHEN Mes = 5 THEN Total ELSE 0 END) AS May, " + _
                  "SUM(CASE WHEN Mes = 6 THEN Total ELSE 0 END) AS Jun, " + _
                  "SUM(CASE WHEN Mes = 7 THEN Total ELSE 0 END) AS Jul, " + _
                  "SUM(CASE WHEN Mes = 8 THEN Total ELSE 0 END) AS Ago, " + _
                  "SUM(CASE WHEN Mes = 9 THEN Total ELSE 0 END) AS Sep, " + _
                  "SUM(CASE WHEN Mes = 10 THEN Total ELSE 0 END) AS Oct, " + _
                  "SUM(CASE WHEN Mes = 11 THEN Total ELSE 0 END) AS Nov, " + _
                  "SUM(CASE WHEN Mes = 12 THEN Total ELSE 0 END) AS Dic, " + _
                  "SUM(Total) AS Total " + _
                  "FROM dbo.fn_MISC_ActividadesPorMiembro('" + S + "') " + where + _
                  "GROUP BY Actividad, Año "
        bdGrid(sql, ListaGrid)
        Dim total As Integer = 0
        Dim n As String = ListaGrid.Rows.Count
        For f = 0 To ListaGrid.Rows.Count - 1
            total = total + ListaGrid.Item(14, f).Value
        Next

        ListaGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        TotalL.Text = "Total: " + total.ToString
        TotalL.Visible = True
        ListaGrid.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish FROM dbo.CdMemberActivityType " + _
              "WHERE Active = 1 AND Project IN ('*', '" + S + "')  AND FunctionalArea = 'EDUC' " + _
              "ORDER BY DescSpanish "
        bdCombo(sql, TipoList, "Code", "DescSpanish")

        AñoV.Text = Now.Year.ToString
    End Sub

End Class