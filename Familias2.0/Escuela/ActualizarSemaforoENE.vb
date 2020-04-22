Public Class ActualizarSemaforoENE
    'Dim test As String
    Dim nActualizados As Integer = 0
    Dim sinSemaforo As String = ""
    Dim sel As String

    Private Sub ActualizarSemaforoENE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub actualizarSemaforo(ByVal apadrinado As String, ByVal semaforo As String)
        Dim razon As String
        If semaforo = "VERD" Then
            razon = "'GANO'"
        Else
            razon = "'PERD'"
        End If
        '"SELECT     Project, MemberId, EducSemaphore, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, StartDate, EndDate"
        sql = "UPDATE MemberEducationSemaphore SET EndDate = GETDATE() " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + apadrinado + " AND EndDate IS NULL"
        'InputBox("", "", sql)
        bdEjecutarSQL(sql)

        sql = "INSERT INTO MemberEducationSemaphore VALUES ('" + S + "'," + apadrinado + ", '" + semaforo.ToUpper + "', " + _
              "GETDATE(), ' ', '" + U + "',NULL,GETDATE(),NULL,'" + UnidadCombo.SelectedValue + "'," + razon + ") "
        bdInsertar(sql)
        nActualizados = nActualizados + 1
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub listado()
        If GradoCombo.SelectedIndex > -1 Then 'Or NivelCombo.SelectedIndex > -1
            listadoParaActualizar()
        Else
            MsgBox("Necesita seleccionar el nivel educativo o grado" + vbCrLf + "Intentelo de nuevo", vbQuestion, My.Resources.versionFamilias2)
        End If

    End Sub

    Private Sub listadoActualizado()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        sql = "SELECT M.MemberId AS Miembro, M.LastNames AS Apellidos, M.FirstNames AS Nombres, " + _
              "cdES.DescSpanish AS [Estado Educativo],  cdG.DescSpanish AS Grado, " + _
              "dbo.fn_EDUC_semaforoEsp(MEY.Project, MEY.MemberId, MEY.SchoolYear, '" + UnidadCombo.SelectedValue + "') AS 'Semaforo', " + _
              " cdS.DescSpanish 'Ingresado' " + _
              "FROM dbo.Member AS M " + _
              "INNER JOIN dbo.MemberEducationYear AS MEY ON M.Project = MEY.Project AND M.MemberId = MEY.MemberId AND MEY.SchoolYear = " + AñoV.Text + " AND M.RecordStatus = MEY.RecordStatus  " + _
              "INNER JOIN  dbo.CdGrade AS cdG ON MEY.Grade = cdG.Code " + _
              "INNER JOIN dbo.CdEducationStatus AS cdES ON MEY.Status = cdES.Code  " + _
              "INNER JOIN dbo.MemberEducationSemaphore MES ON MES.RecordStatus = M.RecordStatus AND MES.Project = M.Project AND MES.MemberId = M.MemberId AND MES.EndDate IS NULL " + _
              "INNER JOIN dbo.CdEducationSemaphore cdS ON cdS.Code = MES.EducSemaphore " + _
              "WHERE M.RecordStatus = ' ' AND M.AffiliationStatus = 'AFIL' AND M.Project = 'N' " + sel + _
              "ORDER BY MEY.Grade, M.LastNames "
        bdGrid(sql, ListadoGrid)

        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.Visible = True

        TotalL.Text = "Actualizados: " + ListadoGrid.RowCount.ToString
        TotalL.Visible = True

        GuardarButton.Visible = False
    End Sub

    Private Sub listadoParaActualizar()
        'If NivelCombo.SelectedIndex > -1 Then
        '    sel = " AND cdG.EducationLevel = '" + NivelCombo.SelectedValue + "' "
        'Else
        sel = " AND cdG.Code = '" + GradoCombo.SelectedValue + "' "
        'End If

        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()

        sql = "SELECT '' color, dbo.fn_EDUC_semaforoEsp(MEY.Project, MEY.MemberId, MEY.SchoolYear, '" + UnidadCombo.SelectedValue + "') AS 'Semaforo' " + _
              ", M.MemberId AS Miembro, M.LastNames AS Apellidos, M.FirstNames AS Nombres, 'Escuela' AS 'Fuente', 4 AS 'TotalClases' " + _
              ", CASE WHEN dbo.fn_ENE_clasesPerdidas(MEY.MemberId, MEY.SchoolYear, MEY.Grade, '" + UnidadCombo.SelectedValue + "') = 0 THEN 'Si' ELSE '' END AS 'GanoTodas' " + _
              ", CASE WHEN dbo.fn_ENE_promedioUnidad(MEY.MemberId, MEY.SchoolYear, MEY.Grade, '" + UnidadCombo.SelectedValue + "') > 80 " + _
               "THEN dbo.fn_ENE_promedioUnidad(MEY.MemberId, MEY.SchoolYear, MEY.Grade, '" + UnidadCombo.SelectedValue + "') " + _
               "ELSE '' END AS 'CuadroHonor' " + _
              ", dbo.fn_ENE_clasesPerdidas(MEY.MemberId, MEY.SchoolYear, MEY.Grade, '" + UnidadCombo.SelectedValue + "') AS 'Perdidas' " + _
              ", cdS.DescSpanish 'Ultimo Ingresado' , MES.Unit 'Unidad' " + _
              "FROM dbo.Member AS M " + _
              "INNER JOIN dbo.MemberEducationYear AS MEY ON M.Project = MEY.Project AND M.MemberId = MEY.MemberId  AND M.RecordStatus = MEY.RecordStatus  " + _
              "INNER JOIN  dbo.CdGrade AS cdG ON MEY.Grade = cdG.Code " + _
              "INNER JOIN dbo.CdEducationStatus AS cdES ON MEY.Status = cdES.Code  " + _
              "INNER JOIN dbo.MemberEducationSemaphore MES ON MES.RecordStatus = M.RecordStatus AND MES.Project = M.Project AND MES.MemberId = M.MemberId AND MES.EndDate IS NULL " + _
              "INNER JOIN dbo.CdEducationSemaphore cdS ON cdS.Code = MES.EducSemaphore " + _
              "WHERE M.RecordStatus = ' ' AND M.AffiliationStatus = 'AFIL' AND M.Project = 'N' AND MEY.SchoolYear = " + AñoV.Text + " " + sel + _
              "ORDER BY MEY.Grade, M.LastNames "
        bdGrid(sql, ListadoGrid)
        'InputBox("", "", sql)
        For f = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid.Item(1, f).Value = "Rojo" Then
                ListadoGrid.Item(1, f).Style.BackColor = Color.Red
                ListadoGrid.Item(0, f).Value = "ROJO"
            ElseIf ListadoGrid.Item(1, f).Value = "Amarillo" Then
                ListadoGrid.Item(1, f).Style.BackColor = Color.Yellow
                ListadoGrid.Item(0, f).Value = "AMAR"
            ElseIf ListadoGrid.Item(1, f).Value = "Verde" Then
                ListadoGrid.Item(1, f).Style.BackColor = Color.LawnGreen
                ListadoGrid.Item(0, f).Value = "VERD"
            End If
        Next

        For i = 1 To ListadoGrid.ColumnCount - 1
            ListadoGrid.Columns.Item(i).ReadOnly = True
            If Len(ListadoGrid.Item(1, i).Value) = 0 Then
                sinSemaforo = sinSemaforo + " - " + ListadoGrid.Item(2, i).Value.ToString
            End If
        Next

        ListadoGrid.Columns.Item(0).Visible = False 'Codigo del semaforo
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.Visible = True
        'ListadoGrid.Columns(1).Frozen = True
        TotalL.Visible = True
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString

        GuardarButton.Visible = True
    End Sub

    Private Sub GenerarButton_Click(sender As Object, e As EventArgs) Handles GenerarButton.Click
        listado()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(sinSemaforo) = 0 Then
            If ListadoGrid.Item(11, 0).Value.ToString = UnidadCombo.SelectedValue Then
                MsgBox("Ya se ha hecho registro del semáforo de la unidad " + UnidadCombo.Text, MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            Else
                Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                Dim response As MsgBoxResult = MsgBox("¿Esta seguro de actualizar el semáforo? " + vbLf + "Recuerde que necesita tener actualizadas todas las notas", style, My.Resources.versionFamilias2)

                If response = MsgBoxResult.Yes Then
                    MsgBox("Este proceso puede tardar unos minutos" + vbCrLf + "Espere hasta que actualice nuevamente la lista" + vbCrLf + "Verifique la fecha del ultimo semaforo", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
                    semaforos()
                    listadoActualizado()
                    MsgBox("Actualización completa", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
                End If
            End If
        Else
            InputBox("No podrá actualizar semáforos hasta que no este completo el grado" + vbCrLf + vbCrLf + "Necesita revisar los siguientes casos: ", "Existen niños sin calificaciones registradas", sinSemaforo)
        End If

    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Dim nxt As New ActualizarSemaforoENE
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub semaforos()
        For f = 0 To ListadoGrid.RowCount - 1
            'MsgBox(ListadoGrid.Item(3, f).Value.ToString + ": " + ListadoGrid.Item(1, f).Value.ToString)
            actualizarSemaforo(ListadoGrid.Item(2, f).Value, ListadoGrid.Item(0, f).Value)
        Next
    End Sub

    Private Sub valoresIniciales()
        AñoV.Text = Now.Year.ToString
        'sql = "SELECT Code, DescSpanish FROM dbo.CdEducationLevel WHERE Code IN ('PREP', 'PRIM') "
        'bdCombo(sql, NivelCombo, "Code", "DescSpanish")

        sql = "SELECT Code, DescSpanish FROM dbo.CdGrade " + _
              "WHERE EducationLevel IN ('PREP', 'PRIM')  AND Code like 'P%' or code iN ('GA', 'PA', 'PR') " + _
              "ORDER BY Orden "
        bdCombo(sql, GradoCombo, "Code", "DescSpanish")

        sql = "SELECT Cycle, DescSpanish D FROM CdCycleENE WHERE Active = 1 "
        bdCombo(sql, UnidadCombo, "Cycle", "D")
    End Sub


End Class