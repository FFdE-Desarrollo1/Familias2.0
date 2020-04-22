' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ImprimirResultadosLab
    Public Smember As String
    Public examId, nSub, IdApp, memberid As Integer
    Public dateRep As DateTime

    Dim anchoNombreLab As Integer

    Private Sub ImprimirResultadosLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub calculaAnchoLab()
        Dim temp As String
        anchoNombreLab = 0
        For i = 0 To ResultadosGrid.RowCount - 1
            temp = ResultadosGrid.Item(0, i).Value
            If anchoNombreLab < Len(temp) Then
                anchoNombreLab = Len(temp)
            End If
        Next
        anchoNombreLab = anchoNombreLab * 6 + 28
    End Sub

    Private Sub ImprimirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirButton.Click
        ResultadosGrid.DataSource = Nothing
        ResultadosGrid.Rows.Clear()

        If LaboratoriosList.Rows.Count > 0 Then
            Dim n As Integer = LaboratoriosList.Rows.Count - 1
            For f = 0 To n
                If LaboratoriosList.Item(2, f).Value = True And LaboratoriosList.Item(5, f).Value.ToString = "SI" Then
                    results(LaboratoriosList.Item(6, f).Value.ToString, LaboratoriosList.Item(3, f).Value.ToString, LaboratoriosList.Item(8, f).Value.ToString)
                Else
                End If
            Next
        End If
        calculaAnchoLab()
        PrintPreviewDialogResultados.Document = PrintDocumentResultados 'PrintPreviewDialog associate with PrintDocument.
        PrintPreviewDialogResultados.ShowDialog() 'open the print preview
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub llenarLabs(ByVal IdApp As Integer)
        Dim listSQL As String

        listSQL = "SELECT TYPE.DescSpanish AS Examen, EXA.Notes Observaciones, CASE WHEN RES.Examen_ID IS NULL " + _
                   "THEN 'NO' ELSE 'SI' END AS Resultados, EXA.Examen_ID AS ID, EXA.Examen_Tipo_ID, " + _
                   "CASE WHEN TYPE.HasSubExam = 1 THEN 'SI' ELSE 'NO' END AS HasSubExam " + _
                  "FROM dbo.MemberHealthLabExam EXA INNER JOIN " + _
                    "dbo.CdLabExamen_Type TYPE ON EXA.Examen_Tipo_ID = TYPE.Examen_Tipo_ID LEFT JOIN " + _
                    "dbo.MemberHealthLabResult RES ON EXA.Examen_ID = RES.Examen_ID AND EXA.RecordStatus = RES.RecordStatus " + _
                  "WHERE EXA.IdAppLab = " + IdApp.ToString + " AND EXA.RecordStatus = ' ' " + _
                  "GROUP BY TYPE.DescSpanish, EXA.Notes, EXA.Examen_ID, EXA.Examen_Tipo_ID, TYPE.HasSubExam, RES.Examen_ID "
        bdGrid(listSQL, LaboratoriosList)

        Dim f, n As Integer 'f = fila, n = total de  filas
        n = LaboratoriosList.Rows.Count - 1
        For f = 0 To n
            LaboratoriosList.Item(0, f).Value = f + 1

            If LaboratoriosList.Item(5, f).Value = "SI" Then
                LaboratoriosList.Item(2, f).Value = True
            Else
                LaboratoriosList.Item(2, f).Value = False
                LaboratoriosList.Item(1, f).Value = "Eliminar Examen"
            End If
        Next

        LaboratoriosList.Columns.Item(6).Visible = False 'codigo del lab
        LaboratoriosList.Columns.Item(7).Visible = False ' tiene sub exam
        LaboratoriosList.Columns.Item(8).Visible = False 'codigo tipo
    End Sub

    Private Sub llenarLabsResult(ByVal sql As String)
        Dim sqlQuery, sqlQuery2, sqlQuery3 As String
        Dim temp, dt, genInfo, respInfo As New DataTable

        sqlQuery = "SELECT cdT.DescSpanish AS Lab, cdST.DescSpanish AS SubLab, convert(nvarchar(80), R.Resultado) Result, cdT.HasSubExam, " + _
                    "dbo.fn_GEN_FormatDate(R.CreationDateTime, 'ES')   as DateResult " + sql

        sqlQuery2 = "SELECT MemberId AS ID, FirstNames + ' ' + LastNames AS CompleteName, LastFamilyId AS Family, Gender,  dbo.fn_GEN_FormatDate(BirthDate, 'ES') AS Nac, DATEDIFF(d, BirthDate, { fn NOW() }) / 365 AS Age " + _
                    "FROM dbo.Member " + _
                    "WHERE RecordStatus = ' ' AND Project = '" + Smember + "' AND MemberId = " + memberid.ToString

        sqlQuery3 = "SELECT PropertyValue AS V FROM FwApplicationProperty " + _
                    "WHERE Category = 'LABO' AND Organization = 'F' AND Name IN ('AResponsible', 'ColResponsible', 'BTitResponsible')  ORDER BY Name "

        bdDataTable(sqlQuery, temp)
        bdDataTable(sqlQuery2, genInfo)
        bdDataTable(sqlQuery3, respInfo)

        For f = 0 To temp.Rows.Count - 1
            llenarResultadoGrid(temp.Rows(0)("Lab").ToString, temp.Rows(0)("SubLab").ToString, temp.Rows(0)("Result").ToString, 1)
        Next
    End Sub

    Private Sub llenarResultadoGrid(ByVal Examen As String, ByVal subE As String, ByVal resultado As String, ByVal tit As Integer)
        If tit = 1 Then
            Dim a() As String = {Examen, subE, resultado}
            ResultadosGrid.Rows.Add(a)
        Else
            Dim a() As String = {"", subE, resultado}
            ResultadosGrid.Rows.Add(a)
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New AgendaLaboratorio
        nxt.ActualDateP.Value = FechaLabs.Value
        nxt.listaPendientes()
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocumentResultados_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentResultados.PrintPage
        Dim mIzq As Integer = 30
        Dim y As Integer = 160
        Dim varY As Integer = 15
        Dim centro As Integer = 425
        Dim temp As Integer
        Dim logo As Image = My.Resources.FamiliasdeEsperanza_Logo_RGB

        Dim impres As New Font("Calibri", 8, FontStyle.Italic)
        Dim normal As New Font("Calibri", 10)
        Dim normalI As New Font("Calibri", 10, FontStyle.Italic)
        Dim normalB As New Font("Calibri", 10, FontStyle.Bold)
        Dim normalU As New Font("Calibri", 10, FontStyle.Underline)
        Dim titulo As New Font("Calibri", 12, FontStyle.Italic)

        'info general
        Dim genInfo, respInfo As New DataTable

        sql = "SELECT MemberId AS ID, FirstNames + ' ' + LastNames AS CompleteName, LastFamilyId AS Family, Gender,  dbo.fn_GEN_FormatDate(BirthDate, 'ES') AS Nac, DATEDIFF(d, BirthDate, { fn NOW() }) / 365 AS Age " + _
                    "FROM dbo.Member " + _
                    "WHERE RecordStatus = ' ' AND Project = '" + Smember + "' AND MemberId = " + memberid.ToString
        bdDataTable(sql, genInfo)

        sql = "SELECT PropertyValue AS V FROM FwApplicationProperty " + _
                    "WHERE Category = 'LABO' AND Organization = 'F' AND Name IN ('AResponsible', 'ColResponsible', 'BTitResponsible')  ORDER BY Name "
        bdDataTable(sql, respInfo)

        'encabezado
        temp = 65
        Dim rect1 As New Rectangle(10, 45, 850, 15)
        Dim rect2 As New Rectangle(10, 60, 850, 15)
        Dim rect3 As New Rectangle(10, 75, 850, 15)
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        e.Graphics.DrawImage(logo, centro - 130, 10)
        e.Graphics.DrawString("LABORATORIO", titulo, Brushes.Black, rect1, stringFormat)
        e.Graphics.DrawString("Km. 2 Carretera a San Juan del Obispo", titulo, Brushes.Black, rect2, stringFormat)
        e.Graphics.DrawString("Tel. 7922-6600", titulo, Brushes.Black, rect3, stringFormat)

        e.Graphics.DrawString("Paciente: ", normalI, Brushes.Black, mIzq, 115)
        e.Graphics.DrawString(genInfo.Rows(0)("CompleteName").ToString.ToUpper, normal, Brushes.Black, mIzq + temp, 115)
        e.Graphics.DrawString("Familia: ", normalI, Brushes.Black, centro + 80, 115)
        e.Graphics.DrawString(genInfo.Rows(0)("Family").ToString, normal, Brushes.Black, centro + 140, 115)

        e.Graphics.DrawString("Fecha Nac.: ", normalI, Brushes.Black, mIzq, 130)
        e.Graphics.DrawString(genInfo.Rows(0)("Nac") & " (" & genInfo.Rows(0)("Age") & " años)", normal, Brushes.Black, mIzq + temp, 130)
        e.Graphics.DrawString("Sexo: ", normalI, Brushes.Black, centro - 80, 130)
        e.Graphics.DrawString(genInfo.Rows(0)("Gender").ToString, normal, Brushes.Black, centro - 45, 130)
        e.Graphics.DrawString("Fecha: ", normalI, Brushes.Black, centro + 80, 130)
        e.Graphics.DrawString(FechaLabs.Value.ToLongDateString, normal, Brushes.Black, centro + 130, 130)
        e.Graphics.DrawString("Impresión: " + DateTime.Now.ToShortDateString + " " + DateTime.Now.ToShortTimeString + " (" + U + ")", impres, Brushes.Black, centro + 80, 150)
        e.Graphics.DrawString("EXAMEN(ES) ", normalU, Brushes.Black, mIzq, y)

        Dim examen As String
        y = y + varY
        For f = 0 To ResultadosGrid.Rows.Count - 1
            examen = ResultadosGrid.Item(0, f).Value()
            e.Graphics.DrawString(examen, normalB, Brushes.Black, mIzq, y)

            If ResultadosGrid.Item(1, f).Value() = "" Then 'si no tiene sublabs
                e.Graphics.DrawString(ResultadosGrid.Item(2, f).Value(), normal, Brushes.Black, mIzq + anchoNombreLab, y)
            Else
                e.Graphics.DrawString(ResultadosGrid.Item(1, f).Value(), normal, Brushes.Black, mIzq + anchoNombreLab, y)
                e.Graphics.DrawString(ResultadosGrid.Item(2, f).Value(), normal, Brushes.Black, mIzq + anchoNombreLab + 200, y)
            End If
            y = y + varY
        Next

        'responsable
        y = y + (varY * 6)
        Dim rect4 As New Rectangle(10, y, 850, 15)
        e.Graphics.DrawString(respInfo.Rows(0)("V").ToString, normal, Brushes.Black, rect4, stringFormat)
        y = y + varY
        Dim rect5 As New Rectangle(10, y, 850, 15)
        e.Graphics.DrawString(respInfo.Rows(1)("V").ToString, normal, Brushes.Black, rect5, stringFormat)
        y = y + varY
        Dim rect6 As New Rectangle(10, y, 850, 15)
        e.Graphics.DrawString(respInfo.Rows(2)("V").ToString, normal, Brushes.Black, rect6, stringFormat)
    End Sub

    Private Sub results(ByVal code As String, ByVal Lab As String, ByVal subs As String)
        Dim dt As New DataTable
        sql = "SELECT cdT.DescSpanish AS Lab, cdST.DescSpanish AS SubLab, convert(nvarchar(80), R.Resultado) Result " +
              "FROM dbo.MemberHealthLabResult R INNER JOIN dbo.MemberHealthLabExam E ON R.Examen_ID = E.Examen_ID AND R.RecordStatus = E.RecordStatus " + _
                    "INNER JOIN dbo.CdLabExamen_Type cdT ON E.Examen_Tipo_ID = cdT.Examen_Tipo_ID " + _
                    "LEFT OUTER JOIN dbo.CdLabSubExamen_Type cdST ON R.SubExamen_ID = cdST.SubExamen_ID " + _
              "WHERE E.RecordStatus = ' ' AND E.Examen_ID = " + code
        bdDataTable(sql, dt)

        llenarResultadoGrid(Lab, dt.Rows(0)("SubLab").ToString, dt.Rows(0)("Result").ToString, 1)

        If subs = "SI" Then
            For f = 1 To dt.Rows.Count - 1
                llenarResultadoGrid("", dt.Rows(f)("SubLab").ToString, dt.Rows(f)("Result").ToString, 0)
            Next
        End If
        llenarResultadoGrid("", "", "", 0)
    End Sub

    Private Sub valoresIniciales()
        llenarLabs(IdApp)
        nSub = 0
    End Sub
End Class