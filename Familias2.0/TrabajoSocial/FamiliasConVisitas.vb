' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class FamiliasConVisitas

    Private Sub FamiliasConVisitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        TotalL.Visible = False
        Dim reg, where As String
        Dim dt As New DataTable
        MsgBox("Este reporte puede tardar unos minutos en aparecer", vbExclamation, My.Resources.versionFamilias2)

        If TSlist.Text = "" Or TSlist.Text = " " Then
            where = ""
        Else
            where = "WHERE TS = '" + TSlist.Text + "'"
        End If

        If S = "F" Then
            reg = " Región, "
        Else
            reg = ""
        End If

        If RegionV.Text = "" Or RegionV.Text = " " Then
            where = where + ""
        Else
            If InStr(where, "WHERE ") = 0 Then
                where = where + " WHERE Región = '" + RegionV.Text + "' "
            Else
                where = where + " AND Región = '" + RegionV.Text + "' "
            End If
        End If

        sql = "SELECT '' 'No.', Familia, Clasificacion, TS, " + reg + " Pueblo, Apadrinados, Rojos, Amarillos, Verdes, dbo.fn_GEN_FormatDate (Casa, 'ES') 'Visita Casa', " + _
                 "dbo.fn_GEN_FormatDate (Oficina, 'ES') 'Visita Oficina', dbo.fn_GEN_FormatDate (Coordinacion, 'ES') 'Coordinación', " + _
                 "dbo.fn_GEN_FormatDate (Padrinos, 'ES') 'Visita Padrinos' " + _
                "FROM  dbo.fn_TS_VisitasTS('" + S + "') L " + where + _
                " ORDER BY " + reg + "TS, Rojos DESC, Amarillos DESC, verdes DESC, Pueblo, Familia "
        bdGrid(sql, ListadoGrid)

        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString

        For f = 0 To ListadoGrid.RowCount - 1
            ListadoGrid.Item(0, f).Value = f + 1
            If IsDBNull(ListadoGrid.Item(7, f).Value()) = False Then
                ListadoGrid.Item(7, f).Style.BackColor = Color.Firebrick
                ListadoGrid.Item(7, f).Style.ForeColor = Color.White
            End If
            If IsDBNull(ListadoGrid.Item(8, f).Value()) = False Then
                ListadoGrid.Item(8, f).Style.BackColor = Color.Gold
            End If
            If IsDBNull(ListadoGrid.Item(9, f).Value()) = False Then
                ListadoGrid.Item(9, f).Style.BackColor = Color.DarkGreen
                ListadoGrid.Item(9, f).Style.ForeColor = Color.White
            End If
        Next

        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()
        TotalL.Visible = True
        ListadoGrid.Visible = True
    End Sub

    Private Sub valoresIniciales()
        If S = "F" Then
            RegionL.Visible = True
            RegionV.Visible = True
        End If

        sql = "SELECT EmployeeId AS TS " + _
                 "FROM dbo.FwEmployeeRole " + _
                 "WHERE Role = 'TS' AND Status = 'actv' AND Organization = '" + S + "'"
        bdComboSinCodigo(sql, TSlist)

        sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
                 "WHERE EmployeeId = '" + U + "' AND Status = 'ACTV' AND  Role IN ('TS') AND Organization = '" + S + "'"
        If bdEntero(sql, "Total") > 0 Then
            TSlist.Text = U
        End If

        ListadoGrid.Visible = False

        '  sql = "SELECT EmployeeId AS TS " + _
        '"FROM dbo.FwEmployeeRole " + _
        '"WHERE Role = 'TS' AND Status = 'actv' AND Organization = '" + S + "'"
        '  bdComboSinCodigo(sql, TSlist)

        '  sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
        '        "WHERE EmployeeId = '" + U + "' AND Status = 'ACTV' AND  Role IN ('ASTS', 'EDTS', 'SUPE') AND Organization = '" + S + "'"
        '  If bdEntero(sql, "Total") = 0 Then
        '      TSlist.Text = U
        '      TSL.Visible = False
        '      TSlist.Visible = False
        '      VerListadoButton.Visible = False
        '      listado()
        '  Else
        '      TSL.Visible = True
        '      TSlist.Visible = True
        '      VerListadoButton.Visible = True
        '  End If
    End Sub

    Private Sub VerListadoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerListadoButton.Click
        listado()
    End Sub


End Class