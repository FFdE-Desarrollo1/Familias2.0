' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReporteGeneralAsistencia
    Dim año As Integer = Today.Year

    Private Sub ReporteGeneralAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim unidad, wUnidad, clases As String

        If Len(UnidadCombo.Text) = 0 Then
            unidad = ""
            wUnidad = ""
            clases = ""
        Else
            unidad = ", I.Unit Unidad, I.FailedClasses AS [Clases Pérdidas], dbo.fn_EDUC_semaforoEsp(I.Project, " + _
                     " I.MemberId, I.SchoolYear, I.Unit) AS Semáforo "

            clases = ", (SELECT CASE WHEN COUNT(*) > 0  THEN 'Perdió' ELSE '' END FROM dbo.MemberEducationClassFailed AS MECF WHERE Class = 1 AND RecordStatus = ' ' AND MECF.Ref = I.Ref) AS 'Mate' " + _
                     ", (SELECT CASE WHEN COUNT(*) > 0  THEN 'Perdió' ELSE '' END FROM dbo.MemberEducationClassFailed AS MECF WHERE Class = 14 AND RecordStatus = ' ' AND MECF.Ref = I.Ref) AS 'Conta' " + _
                     ", (SELECT CASE WHEN COUNT(*) > 0  THEN 'Perdió' ELSE '' END FROM dbo.MemberEducationClassFailed AS MECF WHERE Class = 3 AND RecordStatus = ' ' AND MECF.Ref = I.Ref) AS 'Inglés' "

            wUnidad = " LEFT OUTER JOIN dbo.MemberEducationClassGrade AS I " + _
                      "ON I.MemberId = M.Miembro AND I.Project = M.Sitio AND I.RecordStatus = ' ' " + _
                      "AND I.SchoolYear = Año AND I.Unit = '" + UnidadCombo.Text + "' "
        End If

        'Dim de As String = "CONVERT(smalldatetime, '" + deFecha.Value.Year.ToString + "/" + deFecha.Value.Month.ToString + "/" + deFecha.Value.Day.ToString + "') "
        'Dim a As String = "CONVERT(smalldatetime, '" + aFecha.Value.Year.ToString + "/" + aFecha.Value.Month.ToString + "/" + aFecha.Value.Day.ToString + "')"

        Dim de As String = "CONVERT(datetime, '" + deFecha.Value.Year.ToString + "/" + deFecha.Value.Month.ToString + "/" + deFecha.Value.Day.ToString + " 00:00:00 AM') "
        Dim a As String = "CONVERT(datetime, '" + aFecha.Value.Year.ToString + "/" + aFecha.Value.Month.ToString + "/" + aFecha.Value.Day.ToString + " 12:00:00 PM')"

        'Dim where As String = "WHERE _fecha BETWEEN  " + de + " AND " + a + " "
        Dim where As String = "WHERE CONVERT(datetime,DATEDIFF(d,0,_fecha),102) BETWEEN  " + de + " AND " + a + " "

        If TipoList.Text = "" Or TipoList.Text = " " Then
        Else
            where = where + "AND Actividad = '" + TipoList.Text + "' "
        End If

        sql = "SELECT '' 'No.', Miembro, Nombre, Familia, TipoMiembro, Edad, Grado, EstadoEduc, Escuela, NivelEduc, Actividad, Fecha_Asistencia, " + _
              "convert(nvarchar(20), HORA) + ':' + convert(nvarchar(20), MINUTO) Horario, " + _
              "Notas Observaciones, Usuario, Año, nMes, semanaMes, Fase, TS " + unidad + clases + _
              "FROM dbo.fn_GJOV_AttendanceList('" + S + "', " + año.ToString + ") M " + wUnidad + _
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
        sql = "SELECT DescSpanish FROM dbo.CdMemberActivityType " + _
                                "WHERE Active = 1 AND Project IN ('*', '" + S + "')  AND FunctionalArea = 'APJO' AND CodeInt IS NOT NULL " + _
                                "ORDER BY DescSpanish"
        bdComboSinCodigo(sql, TipoList)

        Dim codeAct As String
        Dim prinActSQL As String = "SELECT CASE WHEN CustomField4 IS NULL THEN 'NO' ELSE CustomField4 END AS PreAct " + _
                           " FROM dbo.FwEmployee WHERE EmployeeId = '" + U + "' "
        codeAct = bdPalabra(prinActSQL, "PreAct")

        If codeAct = "NO" Then
            TipoList.Text = ""
        Else
            prinActSQL = "SELECT  DescSpanish  " + _
                         "FROM dbo.CdMemberActivityType " + _
                         "WHERE  CodeInt = " + codeAct + " "
            codeAct = bdPalabra(prinActSQL, "DescSpanish")
            TipoList.Text = codeAct
        End If

        sql = "SELECT Code, DescSpanish FROM dbo.CdSchoolGradeUnit "
        bdCombo(sql, UnidadCombo, "Code", "DescSpanish")

        deFecha.Value = Today
        aFecha.Value = Today
    End Sub
End Class