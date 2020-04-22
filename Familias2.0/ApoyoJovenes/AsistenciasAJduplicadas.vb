' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AsistenciasAJduplicadas
    Dim año As Integer = Today.Year

    Private Sub AsistenciasAJduplicadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub AñoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AñoV.KeyPress
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

    Private Sub GenerarButton_Click(sender As Object, e As EventArgs) Handles GenerarButton.Click
        listado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        TotalL.Visible = False
        MsgBox("Este reporte puede tardar unos minutos", vbQuestion, My.Resources.versionFamilias2)

        Dim where As String

        If Len(AñoV.Text) > 0 Then
            where = "WHERE AÑO = " + AñoV.Text + " "
        Else
            where = "WHERE AÑO > 2012 "
        End If

        If Len(TipoList.Text) > 0 Then
            where = where + " AND  Actividad = '" + TipoList.Text + "' "
        End If

        If S = "N" Then
            where = where + " AND Miembro <> 50 "
        End If

        Dim sql As String
        sql = "SELECT Miembro, Nombre, Familia, TipoMiembro, Actividad, Fecha_Asistencia, HORA " + _
              "FROM dbo.fn_GJOV_AttendanceList('" + S + "', " + año.ToString + ")  " + _
              where + _
              "GROUP BY Miembro, Nombre, Familia, TipoMiembro, Actividad, Fecha_Asistencia, HORA " + _
              "HAVING COUNT(*) > 1 " + _
              "ORDER BY Fecha_Asistencia "
        bdGrid(sql, ListGrid)
        TotalL.Text = "Total:" + ListGrid.Rows.Count.ToString
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListGrid.Visible = True
        TotalL.Visible = True
    End Sub

    Private Sub ListGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListGrid.CellContentClick
        Dim f, c, member As Integer
        c = ListGrid.CurrentCellAddress.X
        f = ListGrid.CurrentCellAddress.Y

        If c = 0 Then
            member = Integer.Parse(ListGrid.Item(0, f).Value)
            Dim nxt As New RegistroAsistencia
            nxt.TipoList.Text = ListGrid.Item(4, f).Value
            nxt.FechaV.Value = ListGrid.Item(5, f).Value
            nxt.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New AsistenciasAJduplicadas
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT DescSpanish " + _
                        "FROM dbo.CdMemberActivityType " + _
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

        AñoV.Text = Today.Year.ToString
        GenerarButton.Focus()
    End Sub

End Class