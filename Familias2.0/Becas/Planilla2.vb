' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class Planilla2
    Public año, grado, estado, escuela, tipo, nivel, carrera As String
    Public cantidad As Double

    Dim desc, appDate As String
    Dim total, contador As Integer
    Dim Idmember(300), cantidadAprobada(300) As String
    Dim ahora As DateTime
    Dim difDias As Integer = bdEntero("SELECT PropertyValue N FROM FwApplicationProperty WHERE Organization = '*' AND Category = 'REEM' AND  Name = 'DaysOfLateReimbursement'", "N")

    Private Sub Planilla2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ACHch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACHch.CheckedChanged
        If ACHch.Checked = True Then
            CHEQUEck.Checked = False
        Else
            CHEQUEck.Checked = True
        End If
    End Sub

    Private Sub AllCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCheck.CheckedChanged
        For f = 0 To PlanillaR.Rows.Count - 1
            PlanillaR.Item(1, f).Value = AllCheck.Checked
        Next
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub calcularTotal()
        Dim tempC As New CheckBox
        Dim c, f, n As Integer 'c = columna, f = fila, n = total de filas
        c = 11 'columna cantidad aprobada 
        total = 0
        contador = 0
        n = PlanillaR.Rows.Count - 1
        For f = 0 To n
            tempC.Checked = PlanillaR.Item(1, f).Value()
            If tempC.Checked = True Then
                total = total + PlanillaR.Item(c, f).Value
                Idmember(f) = PlanillaR.Item(2, f).Value
                cantidadAprobada(f) = PlanillaR.Item(c, f).Value
                contador = contador + 1
                insertar(Idmember(f), cantidadAprobada(f))
            Else
                total = total
                contador = contador
            End If
        Next
    End Sub

    Private Sub CHEQUEck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHEQUEck.CheckedChanged
        If CHEQUEck.Checked = True Then
            ACHch.Checked = False
        Else
            ACHch.Checked = True
        End If
    End Sub

    Private Sub description()
        If L = "es" Then
            desc = "DescSpanish"
        Else
            desc = "DescEnglish"
        End If
    End Sub

    Private Sub DuplicadosCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicadosCheck.CheckedChanged
        If DuplicadosCheck.Checked = True Then
            Dim cFecha As Integer = 0
            'buscar ultima fecha
            For f = 0 To PlanillaR.Rows.Count - 1
                PlanillaR.Item(13, f).Value = ultimaFecha(PlanillaR.Item(2, f).Value) 'PlanillaR.Item(2, f).Value '
            Next
            'marcar los que tengan menos de 31 días
            For f = 0 To PlanillaR.Rows.Count - 1
                If PlanillaR.Item(13, f).Value = "" Then
                Else
                    PlanillaR.Rows(f).DefaultCellStyle.BackColor = Color.SandyBrown 'LightSteelBlue  'Honeydew                '.Cornsilk
                    cFecha = +1
                End If
            Next
            'mostrar mensaje si existen
            If cFecha > 0 Then
                MsgBox("Los que aparecen en naranja tiene un reembolso con menos de 35 días de aprobado (podrían ser duplicados)", vbQuestion, My.Resources.versionFamilias2)
            End If
        Else
        End If
    End Sub

    Private Sub estilo()
        Dim f, n, i As Integer 'f = fila, n = total de filas, i = inicio
        Dim isCheck As New CheckBox
        n = PlanillaR.Rows.Count - 1
        i = 12

        For f = 0 To n
            PlanillaR.Item(0, f).Value = f + 1
            PlanillaR.Item(1, f).Value = AllCheck.Checked
            PlanillaR.Item(2, f).Value = PlanillaR.Item(i, f).Value '#miembro
            PlanillaR.Item(3, f).Value = PlanillaR.Item(i + 1, f).Value 'nombres
            PlanillaR.Item(4, f).Value = PlanillaR.Item(i + 2, f).Value 'apellidos
            PlanillaR.Item(5, f).Value = PlanillaR.Item(i + 3, f).Value 'familia
            PlanillaR.Item(6, f).Value = PlanillaR.Item(i + 4, f).Value 'clasificación
            PlanillaR.Item(7, f).Value = PlanillaR.Item(i + 5, f).Value 'grado
            PlanillaR.Item(8, f).Value = PlanillaR.Item(i + 6, f).Value 'estado
            PlanillaR.Item(9, f).Value = PlanillaR.Item(i + 8, f).Value 'carrera
            PlanillaR.Item(10, f).Value = PlanillaR.Item(i + 9, f).Value '%
            PlanillaR.Item(11, f).Value = PlanillaR.Item(i + 10, f).Value 'Aprobada
        Next
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        ahora = DateTime.Now
        If verificarDiferenciaFechas() = True Then
            calcularTotal()
        End If

        If contador > 0 Then
            valoresPagados()
            GuardarButton.Visible = False
        Else
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub insertar(ByVal miembro As String, _
                    ByVal aprobado As String)
        Dim fecha As DateTime = FechaV.Value
        Dim pay, formaPago As String


        If Efectivock.Checked = True Then
            appDate = "'" + fecha.ToString(en.DateTimeFormat) + "'"
            pay = "', '" + fecha.ToString(en.DateTimeFormat) + "' , 'c/fondos', NULL, '"
            formaPago = "'EFEC'"
        ElseIf ACHch.Checked = True Then
            appDate = "'" + fecha.ToString(en.DateTimeFormat) + "'"
            pay = "', '" + fecha.ToString(en.DateTimeFormat) + "' , NULL, 'ACH', '"
            formaPago = "'ACH'"
        Else
            appDate = "'" + ahora.ToString(en.DateTimeFormat) + "'"
            pay = "', NULL, NULL, NULL, '"
            formaPago = "'CHEQ'"
        End If

        ' "VALUES(" + miembro + ",'" + addTipo + "', '" + fecha.Year.ToString + "/" + fecha.Month.ToString + "/" + fecha.Day.ToString + " " + fecha.Hour.ToString + ":" + fecha.Minute.ToString + "', " + _
        Dim insertSQL As String = "INSERT INTO dbo.MemberReimbursement (MemberId, Type, ApprovedDateTime, " + _
                                  "Amount, ApprovedAmount, Project, FunctionalArea, CreationDateTime, " + _
                                  "RecordStatus, UserId, ExpirationDateTime,  ApprovedBy, ReimbursementDateTime, " + _
                                  "ReceiptNumber, CheckNumber, Notes, Pay) " + _
                                  "VALUES(" + miembro + ",'" + tipo + "', " + appDate + ", " + _
                                  "" + cantidad.ToString + ", " + aprobado + " , '" + S + "', 'EDUC', " + _
                                  "'" + ahora.ToString(en.DateTimeFormat) + "' , ' ', '" + U + "', NULL, " + _
                                  "'" + U + pay + NotasV.Text + "', " + formaPago + ")"
        bdInsertar(insertSQL)
    End Sub

    Private Sub llenarLista(ByVal ord As String)
        Dim temp As String = ""
        Dim a() As String = {ord}
        PlanillaR.Rows.Add(a)
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New Planilla
        nxt.Show()
        Me.Close()
    End Sub

    Private Function ultimaFecha(ByVal memberId As String) As String
        Dim sql As String
        sql = "SELECT dbo.fn_GEN_getUltimoReembolso('" + S + "', " + memberId + ", " + año + ", '" + tipo + "', GETDATE()) AS Fecha "
        ultimaFecha = bdPalabra(sql, "Fecha")
    End Function

    Private Sub valoresIniciales()
        EscuelaV.Text = escuela

        Dim f As Integer 'f = fila, n = total de filas, i = inicio
        Dim listTable As New DataTable
        Dim reporteSQL As String = "SELECT * " + _
                    "FROM dbo.fn_EDUC_ToApprovedEducPlanillaList ('" + S + "', " + cantidad.ToString + ", " + año + _
                          ", '" + escuela + "') " + _
                    "WHERE Escuela = '" + escuela + "'" + estado + nivel + carrera + grado + " " + _
                    "ORDER BY Grado, Miembro "
        bdDataTable(reporteSQL, listTable)
        'TextBox1.Text = reporteSQL
        For f = 0 To listTable.Rows.Count - 1
            llenarLista("")
        Next

        For f = 0 To PlanillaR.Rows.Count - 1
            PlanillaR.Item(1, f).Value = AllCheck.Checked
            PlanillaR.Item(2, f).Value = chequearValor(listTable.Rows(f)("Miembro")) '#miembro
            PlanillaR.Item(3, f).Value = chequearValor(listTable.Rows(f)("Nombres")) 'nombres
            PlanillaR.Item(4, f).Value = chequearValor(listTable.Rows(f)("Apellidos")) 'apellidos
            PlanillaR.Item(5, f).Value = chequearValor(listTable.Rows(f)("Familia")) 'familia
            PlanillaR.Item(6, f).Value = chequearValor(listTable.Rows(f)("Clasificación")) 'clasificación
            PlanillaR.Item(7, f).Value = chequearValor(listTable.Rows(f)("Grado")) 'grado
            PlanillaR.Item(8, f).Value = chequearValor(listTable.Rows(f)("Estado")) 'estado
            PlanillaR.Item(9, f).Value = chequearValor(listTable.Rows(f)("Carrera")) 'carrera
            PlanillaR.Item(10, f).Value = chequearValor(listTable.Rows(f)("Porcentaje")) '%
            PlanillaR.Item(11, f).Value = chequearValor(listTable.Rows(f)("Cantidad Aprobada")) 'Aprobada
            PlanillaR.Item(12, f).Value = chequearValor(listTable.Rows(f)("Nivel")) 'Nivel
        Next

        'enumerar grid las filas del DataGridViewInfo
        For i = 0 To PlanillaR.Rows.Count - 1
            PlanillaR.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
        PlanillaR.Width = infoTable.Width - 5
        AppGrid.Width = 5
    End Sub

    Private Sub valoresPagados()
        Dim en As New CultureInfo("en-US")

        PlanillaR.Visible = False

        sql = "SELECT M.MemberId AS Miembro, M.FirstNames AS Nombres, M.LastNames AS Apellidos, " + _
                                "M.LastFamilyId AS Familia, F.Classification AS Clasificación, cdG.DescSpanish AS Grado, " + _
                                "cdS.DescSpanish AS Estado, S.Name AS Escuela, CASE WHEN F.Classification = 'A' THEN '95%' " + _
                                "ELSE '80%' END AS '% Asignado', MR.ApprovedAmount *100 / MR.Amount AS Porcentaje, MR.Amount Cantidad, MR.ApprovedAmount AS 'Cantidad Aprobada', MR.ApprovedBy AS 'Aprobado Por', " + _
                                "dbo.fn_GEN_FormatDate(MR.ApprovedDateTime, 'ES') AS 'Fecha Aprobado', MR.Notes AS Notas, " + _
                                "dbo.fn_GEN_FormatDate(MR.ReimbursementDateTime, 'ES')  AS 'Fecha Pago' " + _
                                "FROM dbo.MemberReimbursement MR INNER JOIN dbo.Member M ON M.Project = MR.Project AND " + _
                                "M.MemberId = MR.MemberId AND M.RecordStatus = MR.RecordStatus INNER JOIN dbo.Family F " + _
                                "ON M.Project = F.Project AND M.LastFamilyId = F.FamilyId AND M.RecordStatus = F.RecordStatus " + _
                                "LEFT OUTER JOIN dbo.MemberEducationYear MEY ON MEY.Project = M.Project AND MEY.MemberId = M.MemberId " + _
                                "AND MEY.RecordStatus = M.RecordStatus AND MEY.SchoolYear = " + año + " INNER JOIN dbo.CdGrade cdG ON " + _
                                "MEY.Grade = cdG.Code INNER JOIN dbo.CdEducationStatus cdS ON MEY.Status = cdS.Code INNER JOIN " + _
                                "dbo.School S ON MEY.Project = S.Project AND MEY.SchoolCode = S.Code AND MEY.RecordStatus = S.RecordStatus " + _
                                "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' " + _
                                "AND MR.UserId = '" + U + "' AND MR.CreationDateTime = '" + ahora.ToString(en.DateTimeFormat) + "' " + _
                                "AND MR.Type = '" + tipo + "'"
        bdGrid(sql, AppGrid)

        MsgBox("Fueron ingresados " + AppGrid.Rows.Count.ToString + " pago(s)", vbQuestion, My.Resources.versionFamilias2)
        AppGrid.Visible = True

        'enumerar grid las filas del DataGridViewInfo
        For i = 0 To AppGrid.Rows.Count - 1
            AppGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next

        PlanillaR.Width = 5
        AppGrid.Width = infoTable.Width - 5
    End Sub

    Private Function verificarDiferenciaFechas() As Boolean
        Dim dif As Integer = DateDiff(DateInterval.Day, FechaV.Value, DateTime.Now)
        If dif < 0 Then
            If FechaV.Value.Month = DateTime.Now.Month Then
                verificarDiferenciaFechas = True
            Else
                verificarDiferenciaFechas = False
                MsgBox("Si es un reembolso a futuro solo lo puede hacer en el mes actual", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
            End If
        ElseIf dif > difDias Then
            verificarDiferenciaFechas = False
            MsgBox("La fecha de autorización no puede exceder a los " + difDias.ToString + " dias. La diferencia es: " + dif.ToString + " días", MsgBoxStyle.Exclamation, My.Resources.versionFamilias2)
        Else
            verificarDiferenciaFechas = True
        End If
    End Function


End Class