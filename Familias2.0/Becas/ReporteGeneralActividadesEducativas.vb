' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReporteGeneralActividadesEducativas
    Dim año As Integer = Today.Year

    Private Sub ReporteGeneralActividadesEducativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GenerarButton_Click(sender As Object, e As EventArgs) Handles GenerarButton.Click
        MsgBox("Este reporte puede tardar unos minutos", vbQuestion, My.Resources.versionFamilias2)
        listado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        TotalL.Visible = False
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        Dim de As String = "CONVERT(datetime, CONVERT(varchar, '" + deFecha.Value.Year.ToString + "/" + deFecha.Value.Month.ToString + "/" + deFecha.Value.Day.ToString + "', 111)) "
        Dim a As String = "CONVERT(datetime, CONVERT(varchar, '" + aFecha.Value.Year.ToString + "/" + aFecha.Value.Month.ToString + "/" + aFecha.Value.Day.ToString + "', 111))"

        Dim where As String = "WHERE _fecha BETWEEN  " + de + " AND " + a + " "

        If TipoList.Text = "" Or TipoList.Text = " " Then
            where = where + " AND FunctionalArea = 'EDUC' "
        Else
            where = where + "AND Actividad = '" + TipoList.Text + "' "
        End If

        sql = "SELECT '' 'No.', Miembro, Nombre, Familia, TipoMiembro, Edad, Semaforo Semáforo, Grado, EstadoEduc, Escuela, NivelEduc, Actividad, Fecha_Asistencia, " + _
              "convert(nvarchar(20), HORA) + ':' + convert(nvarchar(20), MINUTO) Horario, " + _
              "Notes Observaciones, Usuario, Año, nMes, semanaMes " + _
              "FROM dbo.fn_GEN_ActividadesList('" + S + "', " + año.ToString + ") " + _
              where + " ORDER BY Actividad, Año , Mes , dia , semanaMes "
        bdGrid(sql, ListGrid)
        'InputBox("", "", sql)
        For i = 0 To ListGrid.Rows.Count - 1
            ListGrid.Item(0, i).Value = i + 1
        Next

        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        TotalL.Text = "Total: " + ListGrid.Rows.Count.ToString
        TotalL.Visible = True
        ListGrid.Visible = True
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish FROM dbo.CdMemberActivityType " + _
              "WHERE Active = 1 AND Project IN ('*', '" + S + "')  AND FunctionalArea = 'EDUC' " + _
              "ORDER BY DescSpanish "
        bdCombo(sql, TipoList, "Code", "DescSpanish")
        'bdComboSinCodigo(sql, TipoList)
        deFecha.Value = Today
        aFecha.Value = Today
    End Sub
End Class