' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReporteAnualAsistencias
    ' Dim año As Integer = Today.Year

    Private Sub ReporteAnualAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub DetalleMes()
        TotalL.Visible = False
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Dim where As String

        If TipoList.Text = "" Or TipoList.Text = " " Then
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = ""
            Else
                where = " WHERE AÑO = " + AñoV.Text + " "
            End If
        Else
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = " WHERE Actividad = '" + TipoList.Text + "' "
            Else
                where = " WHERE Actividad = '" + TipoList.Text + "' AND AÑO = " + AñoV.Text + " "
            End If
        End If

        sql = "SELECT Miembro, Nombre, Edad,  Familia, TipoMiembro, Semaforo Semáforo, Grado, EstadoEduc, Escuela, NivelEduc, Actividad, Año, " + _
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
                  "FROM dbo.fn_GJOV_AsistenciaPorMiembro('" + S + "', " + AñoV.Text + ") " + where + _
                  "GROUP BY Miembro, Nombre, Edad, Familia, TipoMiembro, Semaforo, Grado, EstadoEduc, Escuela, NivelEduc, Actividad, Año " + _
                  "ORDER BY Nombre, Edad, Familia, TipoMiembro, Actividad, Año "
        bdGrid(sql, ListGrid)
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        TotalL.Text = "Total: " + ListGrid.Rows.Count.ToString
        TotalL.Visible = True
        ListGrid.Visible = True
    End Sub

    Private Sub DetalleSemana()
        TotalL.Visible = False
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Dim where As String

        If TipoList.Text = "" Or TipoList.Text = " " Then
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = ""
            Else
                where = " WHERE AÑO = " + AñoV.Text + " "
            End If
        Else
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = " WHERE Actividad = '" + TipoList.Text + "' "
            Else
                where = " WHERE Actividad = '" + TipoList.Text + "' AND AÑO = " + AñoV.Text + " "
            End If
        End If

        sql = "SELECT Miembro, Nombre, Edad, Familia, TipoMiembro, Semaforo Semáforo, Grado, EstadoEduc, Escuela, NivelEduc, Actividad, Año, " + _
              "nMes + ' - ' + 'semana' + convert(varchar, semanaMes) Fecha, COUNT(*) Total " + _
              "FROM dbo.fn_GJOV_AttendanceList('" + S + "', " + AñoV.Text + ") " + where + _
              "GROUP BY Miembro, Nombre, Edad, Familia, TipoMiembro, Semaforo, Grado, EstadoEduc, Escuela, NivelEduc, Actividad, Año, Mes, nMes + ' - ' + 'semana' + convert(varchar, semanaMes) " + _
              "ORDER BY Nombre, Familia, Edad, TipoMiembro, Actividad, Año, Mes, nMes + ' - ' + 'semana' + convert(varchar, semanaMes) "
        bdGrid(sql, ListGrid)
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        TotalL.Text = "Total: " + ListGrid.Rows.Count.ToString
        TotalL.Visible = True
        ListGrid.Visible = True
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click
        MsgBox("Este reporte puede tardar unos minutos", vbQuestion, My.Resources.versionFamilias2)
        If verDetalle.Checked = True Then
            If mesCheck.Checked = True Then
                DetalleMes()
            Else
                DetalleSemana()
            End If
        Else
            If mesCheck.Checked = True Then
                ListadoMes()
            Else
                ListadoSemana()
            End If
        End If
    End Sub

    Private Sub ListadoMes()
        TotalL.Visible = False
        TotalL.Text = ""
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Dim where As String

        If TipoList.Text = "" Or TipoList.Text = " " Then
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = ""
            Else
                where = " WHERE AÑO = " + AñoV.Text + " "
            End If
        Else
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = " WHERE Actividad = '" + TipoList.Text + "' "
            Else
                where = " WHERE Actividad = '" + TipoList.Text + "' AND AÑO = " + AñoV.Text + " "
            End If
        End If

        Dim by As String
        If S = "N" Then
            by = "GROUP BY Actividad, CodeInt, Año " + _
                 "ORDER BY CodeInt, Año"

        Else
            by = "GROUP BY Actividad, Año " + _
                 "ORDER BY Actividad, Año"
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
                  "FROM dbo.fn_GJOV_AsistenciaPorMiembro('" + S + "', " + AñoV.Text + ") " + where + by
        bdGrid(sql, ListGrid)
        'InputBox("", "", sql)
        Dim total As Integer = 0
        Dim n As String = ListGrid.Rows.Count
        For f = 0 To ListGrid.Rows.Count - 1
            total = total + ListGrid.Item(14, f).Value
        Next

        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        TotalL.Text = "Total: " + total.ToString
        TotalL.Visible = True
        ListGrid.Visible = True
    End Sub

    Private Sub ListadoSemana()
        TotalL.Visible = False
        TotalL.Text = ""
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Dim where As String

        If TipoList.Text = "" Or TipoList.Text = " " Then
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = ""
            Else
                where = " WHERE L.AÑO = " + AñoV.Text + " "
            End If
        Else
            If AñoV.Text = "" Or AñoV.Text = " " Then
                where = " WHERE L.Actividad = '" + TipoList.Text + "' "
            Else
                where = " WHERE L.Actividad = '" + TipoList.Text + "' AND L.AÑO = " + AñoV.Text + " "
            End If
        End If

        Dim by As String
        If S = "N" Then
            by = "GROUP BY CodeInt, Actividad, Año, Mes, nMes + ' - ' + 'semana ' + convert(varchar, semanaMes) " + _
                 "ORDER BY CodeInt, Año, Mes, nMes + ' - ' + 'semana ' + convert(varchar, semanaMes) "

        Else
            by = "GROUP BY Actividad, Año, Mes, nMes + ' - ' + 'semana ' + convert(varchar, semanaMes) " + _
                  "ORDER BY Actividad, Año, Mes, nMes + ' - ' + 'semana ' + convert(varchar, semanaMes) "
        End If

        sql = "SELECT Actividad, Año, nMes + ' - ' + 'semana ' + convert(varchar, semanaMes) Fecha, count(*) Total " + _
              "FROM dbo.fn_GJOV_AttendanceList('" + S + "', " + AñoV.Text + ") L " + where + by
        bdGrid(sql, ListGrid)

        Dim total As Integer = 0
        Dim n As String = ListGrid.Rows.Count
        For f = 0 To ListGrid.Rows.Count - 1
            total = total + ListGrid.Item(3, f).Value
        Next

        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        TotalL.Text = "Total: " + total.ToString
        TotalL.Visible = True
        ListGrid.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub mesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles mesCheck.CheckedChanged
        If mesCheck.Checked = True Then
            semanaCheck.Checked = False
        Else
            semanaCheck.Checked = True
        End If
    End Sub

    Private Sub semanaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles semanaCheck.CheckedChanged
        If semanaCheck.Checked = True Then
            mesCheck.Checked = False
        Else
            mesCheck.Checked = True
        End If
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT DescSpanish FROM dbo.CdMemberActivityType " + _
                                "WHERE Active = 1 AND Project IN ('*', '" + S + "')  AND FunctionalArea = 'APJO' AND CodeInt IS NOT NULL " + _
                                "ORDER BY DescSpanish"
        bdComboSinCodigo(sql, TipoList)

        Dim codeAct As String
        sql = "SELECT CASE WHEN CustomField4 IS NULL THEN 'NO' ELSE CustomField4 END AS PreAct " + _
                                   " FROM dbo.FwEmployee WHERE EmployeeId = '" + U + "' "
        codeAct = bdPalabra(sql, "PreAct")

        If codeAct = "NO" Then
            TipoList.Text = ""
        Else
            sql = "SELECT  DescSpanish  " + _
                         "FROM dbo.CdMemberActivityType " + _
                         "WHERE  CodeInt = " + codeAct + " "
            codeAct = bdPalabra(sql, "DescSpanish")
            TipoList.Text = codeAct
        End If

        AñoV.Text = Now.Year.ToString
    End Sub

End Class