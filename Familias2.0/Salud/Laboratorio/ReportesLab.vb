Imports System.Security.Permissions
Imports System.Threading

' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReportesLab
    Dim columnIndex As Char
    Dim Total As Integer = 0

    Private Sub ReportesLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ActualDateP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        listado()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub checking()
        If DetalleCheck.Checked = True Then
            ResumenCheck.Checked = False
            GroupByCombo.Visible = False
            GroupByL.Visible = False
        Else
            ResumenCheck.Checked = True
            GroupByCombo.Visible = True
            GroupByL.Visible = True
        End If
    End Sub

    Private Sub DetalleCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalleCheck.CheckedChanged
        checking()
    End Sub

    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        listado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs)
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        MsgBox("Este reporte puede tomar unos minutos en aparecer", vbInformation, My.Resources.versionFamilias2)
        ResultGrid.DataSource = Nothing
        ResultGrid.Rows.Clear()
        ResultGrid.Visible = False

        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en", False)
        Dim fromD, toD, sql, where, wDr, wLab As String
        fromD = FromDate.Value.Year.ToString + "-" + numeroMes(FromDate.Value.Month) + "-" + numeroMes(FromDate.Value.Day) + " 00:00:00.000"
        toD = ToDate.Value.Year.ToString + "-" + numeroMes(ToDate.Value.Month) + "-" + numeroMes(ToDate.Value.Day) + " 24:00:00.000"
        columnIndex = "G"

        sql = ""
        where = "WHERE Fecha >= '" + fromD + "' and Fecha <= '" + toD + "' "

        If DoctorCombo.Text <> "" Then
            wDr = " AND Dr = '" + DoctorCombo.Text + "' "
        Else
            wDr = " "
        End If

        If LaboratorioCombo.Text <> "" Then
            wLab = " AND Laboratorio = '" + LaboratorioCombo.Text + "' "
        Else
            wLab = " "
        End If

        If DetalleCheck.Checked = True Then
            sql = "SELECT Sitio, Miembro, Familia, Paciente, Laboratorio, convert(nvarchar(30),Fecha,13) as Fecha, Dr " + _
                  "FROM dbo.v_LABO_LaboratoriesList " + _
                 where + wDr + wLab + "ORDER BY Fecha "
            bdGrid(sql, ResultGrid)
            mostrarListado()
        Else
            If GroupByCombo.Text = "Laboratorio-Total" Then
                sql = "SELECT Laboratorio, Count(*) AS Total, '' AS Porcentaje " + _
                      "FROM dbo.v_LABO_LaboratoriesList " + _
                      where + wDr + wLab + "GROUP BY Laboratorio ORDER BY Laboratorio "
                columnIndex = "C"
                bdGrid(sql, ResultGrid)
                For i = 0 To ResultGrid.RowCount - 1
                    Total = Total + Integer.Parse(ResultGrid.Item(1, i).Value)
                Next
                Dim t As Double = 0
                For i = 0 To ResultGrid.RowCount - 1
                    t = Integer.Parse(ResultGrid.Item(1, i).Value) * 100 / Total
                    ResultGrid.Item(2, i).Value = (Math.Round(t, 3)).ToString + "%"
                Next
                mostrarListado()
            ElseIf GroupByCombo.Text = "Laboratorio-Mes" Then
                sql = "SELECT Laboratorio, SUM(CASE WHEN Mes = 1 THEN 1 ELSE NULL END)  AS 'Enero', " + _
                         "SUM(CASE WHEN Mes = 2 THEN 1 ELSE NULL END)  AS 'Febrero', " + _
                         "SUM(CASE WHEN Mes = 3 THEN 1 ELSE NULL END)  AS 'Marzo', " + _
                         "SUM(CASE WHEN Mes = 4 THEN 1 ELSE NULL END)  AS 'Abril', " + _
                         "SUM(CASE WHEN Mes = 5 THEN 1 ELSE NULL END)  AS 'Mayo', " + _
                         "SUM(CASE WHEN Mes = 6 THEN 1 ELSE NULL END)  AS 'Junio', " + _
                         "SUM(CASE WHEN Mes = 7 THEN 1 ELSE NULL END)  AS 'Julio', " + _
                         "SUM(CASE WHEN Mes = 8 THEN 1 ELSE NULL END)  AS 'Agosto', " + _
                         "SUM(CASE WHEN Mes = 9 THEN 1 ELSE NULL END)  AS 'Septiembre', " + _
                         "SUM(CASE WHEN Mes = 10 THEN 1 ELSE NULL END)  AS 'Octubre', " + _
                         "SUM(CASE WHEN Mes = 11 THEN 1 ELSE NULL END)  AS 'Noviembre', " + _
                         "SUM(CASE WHEN Mes = 12 THEN 1 ELSE NULL END)  AS 'Diciembre', " + _
                         "COUNT (*) AS Total " + _
                      "FROM dbo.v_LABO_LaboratoriesList " + _
                      where + wDr + wLab + "GROUP BY Laboratorio "
                columnIndex = "N"
                bdGrid(sql, ResultGrid)
                mostrarListado()
            ElseIf GroupByCombo.Text = "Médico-Totales" Then
                sql = "SELECT Dr, COUNT (*) AS Total " + _
                      "FROM dbo.v_LABO_LaboratoriesList " + _
                      where + wDr + wLab + "GROUP BY Dr "
                columnIndex = "B"
                bdGrid(sql, ResultGrid)
                mostrarListado()
            ElseIf GroupByCombo.Text = "Médico-Mes" Then
                sql = "SELECT Dr, SUM(CASE WHEN Mes = 1 THEN 1 ELSE NULL END)  AS 'Enero', " + _
                        "SUM(CASE WHEN Mes = 2 THEN 1 ELSE NULL END)  AS 'Febrero', " + _
                        "SUM(CASE WHEN Mes = 3 THEN 1 ELSE NULL END)  AS 'Marzo', " + _
                        "SUM(CASE WHEN Mes = 4 THEN 1 ELSE NULL END)  AS 'Abril', " + _
                        "SUM(CASE WHEN Mes = 5 THEN 1 ELSE NULL END)  AS 'Mayo', " + _
                        "SUM(CASE WHEN Mes = 6 THEN 1 ELSE NULL END)  AS 'Junio', " + _
                        "SUM(CASE WHEN Mes = 7 THEN 1 ELSE NULL END)  AS 'Julio', " + _
                        "SUM(CASE WHEN Mes = 8 THEN 1 ELSE NULL END)  AS 'Agosto', " + _
                        "SUM(CASE WHEN Mes = 9 THEN 1 ELSE NULL END)  AS 'Septiembre', " + _
                        "SUM(CASE WHEN Mes = 10 THEN 1 ELSE NULL END)  AS 'Octubre', " + _
                        "SUM(CASE WHEN Mes = 11 THEN 1 ELSE NULL END)  AS 'Noviembre', " + _
                        "SUM(CASE WHEN Mes = 12 THEN 1 ELSE NULL END)  AS 'Diciembre', " + _
                        "COUNT (*) AS Total " + _
                        "FROM dbo.v_LABO_LaboratoriesList " + _
                        where + wDr + wLab + "GROUP BY Dr "
                columnIndex = "N"
                bdGrid(sql, ResultGrid)
                mostrarListado()
            Else
                MsgBox("Necesita seleccionar una opción en: Agrupar Por", vbInformation, My.Resources.versionFamilias2)
                ResultGrid.Visible = False
            End If
        End If
    End Sub

    Private Sub mostrarListado()
        For f = 0 To ResultGrid.RowCount - 1
            ResultGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
        Next
        ResultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ResultGrid.AutoResizeColumns()
        ResultGrid.Visible = True
    End Sub

    Private Sub ResumenCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenCheck.CheckedChanged
        checking()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT DescSpanish FROM dbo.CdLabExamen_Type WHERE Active = 1 ORDER BY DescSpanish"
        bdComboSinCodigo(sql, LaboratorioCombo)

        sql = "SELECT EmployeeId FROM FwEmployeeRole WHERE Status = 'ACTV' AND Role = 'MEDI' AND Organization IN('" + S + "', 'F') "
        bdComboSinCodigo(sql, DoctorCombo)

        Dim from As DateTime = Convert.ToDateTime(FromDate.Value.Year.ToString + "/" + FromDate.Value.Month.ToString + "/01")
        FromDate.Value = from
    End Sub
End Class