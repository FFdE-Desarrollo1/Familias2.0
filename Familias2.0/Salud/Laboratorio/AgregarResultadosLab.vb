' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AgregarResultadosLab
    Public Smember As String
    Public examId, nSub, IdApp, memberid As Integer
    Public dateRep As DateTime

    Dim desc, code, orResultado, labsIDlist As String
    Dim anchoNombreLab As Integer
    Dim subEx As Boolean

    Private Sub AddExamResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Function checkDelete() As Boolean
        Dim msg As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "¿Esta seguro de borrar el laboratorio?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        response = MsgBox(msg, style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.
            checkDelete = True
        Else
            checkDelete = False
        End If
    End Function

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim examId, result, subExamId As String
        Dim n As Integer = 0

        For i = 0 To ResultGrid.Rows.Count() - 1
            examId = ResultGrid.Item(3, i).Value()
            result = ResultGrid.Item(2, i).Value()
            If result = "" Then
                n = n + 1
            End If
        Next

        If n = 0 Then
            For i = 0 To ResultGrid.Rows.Count() - 1
                examId = ResultGrid.Item(3, i).Value()
                result = ResultGrid.Item(2, i).Value()
                subExamId = ResultGrid.Item(4, i).Value()
                saveLabResult(examId, result, subExamId)
            Next
            MsgBox("Actualización correcta", vbInformation, My.Resources.versionFamilias2)
            llenarLabs(IdApp)
            GuardarButton.Visible = False
            ResultGrid.Visible = False
        Else
            MsgBox("La casilla o casillas de resultado deben tener un valor", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub ImprimirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirButton.Click
        ResultadosGrid.DataSource = Nothing
        ResultadosGrid.Rows.Clear()
        Dim isCheck As New CheckBox
        For Each r As DataGridViewRow In LaboratoriosList.Rows
            isCheck.Checked = LaboratoriosList.Item(2, r.Index).Value()
            If isCheck.Checked = True And LaboratoriosList.Item(5, r.Index).Value() = "SI" Then
                results(LaboratoriosList.Item(6, r.Index).Value().ToString, LaboratoriosList.Item(7, r.Index).Value().ToString, LaboratoriosList.Item(8, r.Index).Value().ToString)
            End If
        Next
        calculaAnchoLab()
        PrintPreviewDialogResultados.Document = PrintDocumentResultados 'PrintPreviewDialog associate with PrintDocument.
        PrintPreviewDialogResultados.ShowDialog() 'open the print preview
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub LaboratoriosList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LaboratoriosList.CellContentClick
        Dim f, c As Integer
        Dim descExamen, IDexamen, TypeId, withSub, withResult As String
        f = LaboratoriosList.CurrentCellAddress.Y()
        c = LaboratoriosList.CurrentCellAddress.X()
        descExamen = LaboratoriosList.Item(3, f).Value
        withResult = LaboratoriosList.Item(5, f).Value.ToString
        IDexamen = LaboratoriosList.Item(6, f).Value
        TypeId = LaboratoriosList.Item(7, f).Value
        withSub = LaboratoriosList.Item(8, f).Value.ToString

        ResultGrid.DataSource = Nothing
        ResultGrid.Rows.Clear()

        If c = 0 Then
            If withResult = "SI" Then
                GuardarButton.Visible = False
                ResultGrid.Visible = True
                llenarResultadoGridMod(descExamen, IDexamen, withSub, TypeId)
            Else
                Dim listSQL As String = "SELECT Count(*) AS Total FROM dbo.fn_GEN_TransAccess('" + S + "', '" + U + "')  WHERE Trans = 'AGRE'"
                Dim listTSQL As String = "SELECT Count(*) AS Total FROM dbo.FwEmployeeRole WHERE Role = 'SUPE' AND Status = 'ACTV' AND EmployeeId = '" + U + "'"
                If (bdEntero(listSQL, "Total") > 0) Or (bdEntero(listTSQL, "Total") > 0) Then
                    ResultGrid.Rows.Clear()

                    ResultGrid.Visible = True
                    GuardarButton.Visible = True
                    llenarResultadoGrid(descExamen, IDexamen, withSub, TypeId)
                Else
                    MsgBox("No tiene acceso para continuar", vbInformation, My.Resources.versionFamilias2)
                End If
            End If
        ElseIf c = 1 Then
            If withResult = "NO" Then
                If checkDelete() = True Then
                    sql = "UPDATE dbo.MemberHealthLabExam SET  ExpirationDateTime = GETDATE(), RecordStatus = 'H' " + _
                                  "WHERE Examen_ID = " + IDexamen.ToString
                    bdInsertar(sql)
                    MsgBox("Laboratorio Eliminado correctamente", vbInformation, My.Resources.versionFamilias2)
                    llenarLabs(IdApp)
                    ResultGrid.Visible = False
                    GuardarButton.Visible = False
                End If
            End If
        Else

        End If
    End Sub

    Private Sub llenarLabs(ByVal IdApp As Integer)
        sql = "SELECT TYPE.DescSpanish AS Examen, EXA.Notes Observaciones, CASE WHEN RES.Examen_ID IS NULL " + _
                   "THEN 'NO' ELSE 'SI' END AS Resultados, EXA.Examen_ID AS ID, EXA.Examen_Tipo_ID, " + _
                   "CASE WHEN TYPE.HasSubExam = 1 THEN 'SI' ELSE 'NO' END AS HasSubExam " + _
                  "FROM dbo.MemberHealthLabExam EXA INNER JOIN " + _
                    "dbo.CdLabExamen_Type TYPE ON EXA.Examen_Tipo_ID = TYPE.Examen_Tipo_ID LEFT JOIN " + _
                    "dbo.MemberHealthLabResult RES ON EXA.Examen_ID = RES.Examen_ID AND EXA.RecordStatus = RES.RecordStatus " + _
                  "WHERE EXA.IdAppLab = " + IdApp.ToString + " AND EXA.RecordStatus = ' ' " + _
                  "GROUP BY TYPE.DescSpanish, EXA.Notes, EXA.Examen_ID, EXA.Examen_Tipo_ID, TYPE.HasSubExam, RES.Examen_ID "
        bdGrid(sql, LaboratoriosList)

        Dim f, n As Integer 'f = fila, n = total de  filas
        n = LaboratoriosList.Rows.Count - 1
        For f = 0 To n
            LaboratoriosList.Item(0, f).Value = f + 1
            LaboratoriosList.Item(1, f).Value = "Eliminar Examen"
            If LaboratoriosList.Item(5, f).Value = "SI" Then
                LaboratoriosList.Item(2, f).Value = True
            Else
                LaboratoriosList.Item(2, f).Value = False
            End If
        Next

        LaboratoriosList.Columns.Item(6).Visible = False 'codlab
        LaboratoriosList.Columns.Item(7).Visible = False 'CodTipo
        LaboratoriosList.Columns.Item(8).Visible = False 'Has Sub
    End Sub

    Private Sub llenarResultadosLab(ByVal sql As String)
        Dim temp, dt, genInfo, respInfo As New DataTable

        sql = "SELECT cdT.DescSpanish AS Lab, cdST.DescSpanish AS SubLab, convert(nvarchar(80), R.Resultado) Result, cdT.HasSubExam, " + _
                    "dbo.fn_GEN_FormatDate(R.CreationDateTime, 'ES')   as DateResult " + sql
        bdDataTable(sql, temp)

        sql = "SELECT MemberId AS ID, FirstNames + ' ' + LastNames AS CompleteName, LastFamilyId AS Family, Gender,  dbo.fn_GEN_FormatDate(BirthDate, 'ES') AS Nac, DATEDIFF(d, BirthDate, { fn NOW() }) / 365 AS Age " + _
                    "FROM dbo.Member " + _
                    "WHERE RecordStatus = ' ' AND Project = '" + Smember + "' AND MemberId = " + memberid.ToString
        bdDataTable(sql, genInfo)

        sql = "SELECT PropertyValue AS V FROM FwApplicationProperty " + _
                    "WHERE Category = 'LABO' AND Organization = 'F' AND Name IN ('AResponsible', 'ColResponsible', 'BTitResponsible')  ORDER BY Name "
        bdDataTable(sql, respInfo)

        For f = 0 To temp.Rows.Count - 1
            llenarResultadoGrid(temp.Rows(0)("Lab").ToString, temp.Rows(0)("SubLab").ToString, temp.Rows(0)("Result").ToString, 1)
        Next
    End Sub

    Private Function llenarResultadoCombo(ByVal subExamenID As String) As DataGridViewComboBoxCell
        Dim comboBoxCell As New DataGridViewComboBoxCell
        Dim ds As New DataTable
        Dim i As Integer

        sql = "SELECT TypeResult + ' ' + CASE WHEN Description IS NULL THEN '' ELSE Description END Result  " + _
                "FROM dbo.CdLabResultType WHERE SubExamen_ID = " + subExamenID
        bdDataTable(sql, ds)

        For i = 0 To ds.Rows.Count - 1
            comboBoxCell.Items.Add(ds.Rows(i)("Result").ToString)
        Next i
        llenarResultadoCombo = comboBoxCell
    End Function

    Private Sub llenarResultadoGridMod(ByVal exam As String, _
                                  ByVal IDexamen As String, _
                                  ByVal hasSubExams As String, _
                                  ByVal examenTypeId As String)

        ResultGrid.DataSource = Nothing
        ResultGrid.Rows.Clear()
        ResultGrid.Columns.Item(0).Visible = True
        ResultGrid.Columns.Item(1).Visible = True

        Dim HasRes As Boolean
        Dim idResults As Integer

        If hasSubExams = "SI" Then
            Me.Size = New Point(758, 760)

            ResultGrid.Size = New Point(714, 380)
            Me.StartPosition = FormStartPosition.CenterScreen

            '*get subExams list
            Dim subExList As New DataTable

            sql = "SELECT RES.Resultado_ID, cdSET.DescSpanish AS Descrip, RES.Resultado, RES.SubExamen_ID AS Code, cdSET.HasResultOptions " + _
                      "FROM dbo.MemberHealthLabResult RES INNER JOIN dbo.CdLabSubExamen_Type cdSET ON RES.SubExamen_ID = cdSET.SubExamen_ID " + _
                      "WHERE RES.Examen_ID = " + IDexamen + " AND RES.RecordStatus = ' ' " + _
                      "Order by RES.SubExamen_ID "
            bdDataTable(sql, subExList)

            For i = 0 To subExList.Rows.Count() - 1
                idResults = chequearValor(subExList.Rows(i)("Resultado_ID"))
                desc = Trim$(chequearValor(subExList.Rows(i)("Descrip")))
                orResultado = chequearValor(subExList.Rows(i)("Resultado"))
                code = chequearValor(subExList.Rows(i)("Code"))
                HasRes = subExList.Rows(i)("HasResultOptions")
                Dim a() As String = {desc, exam, orResultado, IDexamen, code, "", "", idResults}
                ResultGrid.Rows.Add(a)
                If HasRes = True Then
                    ResultGrid(5, i) = llenarResultadoCombo(code.ToString)
                    'ResultGrid.Item(2, i).t = orResultado
                End If
                ResultGrid.Item(6, i).Value() = "Guardar"


            Next

            ' ResultGrid.Columns.Item(0).Visible = False
            ResultGrid.Columns.Item(1).Visible = False
        Else
            'MsgBox("ingresar resultado")

            '*resize
            Me.Size = New Point(761, 584)
            Me.StartPosition = FormStartPosition.CenterScreen
            ' UpdateResultGrid.Size = New Point(718, 76)
            ResultGrid.Size = New Point(716, 76)

            Dim exList As New DataTable

            sql = "SELECT RES.Resultado_ID, cdLET.DescSpanish Descrip, RES.Resultado, 0 AS Code " + _
                      "FROM dbo.MemberHealthLabResult RES INNER JOIN dbo.MemberHealthLabExam MHLE ON RES.Examen_ID = MHLE.Examen_ID AND RES.RecordStatus = MHLE.RecordStatus INNER JOIN " + _
                        "dbo.CdLabExamen_Type cdLET ON MHLE.Examen_Tipo_ID = cdLET.Examen_Tipo_ID " + _
                      "WHERE RES.Examen_ID = " + IDexamen + " AND RES.RecordStatus = ' ' " + _
                      "Order by RES.SubExamen_ID "
            bdDataTable(sql, exList)

            '*UpdateResultGrid.Rows.Add(a)
            For i = 0 To exList.Rows.Count() - 1
                idResults = chequearValor(exList.Rows(i)("Resultado_ID"))
                desc = Trim$(chequearValor(exList.Rows(i)("Descrip")))
                orResultado = chequearValor(exList.Rows(i)("Resultado"))
                code = chequearValor(exList.Rows(i)("Code"))

                Dim a() As String = {desc, exam, orResultado, IDexamen, code, "", "", idResults}
                ResultGrid.Rows.Add(a)
                ResultGrid.Item(6, i).Value() = "Guardar"
            Next



            ResultGrid.Columns.Item(0).Visible = False
            ResultGrid.Columns.Item(3).Visible = False
            ResultGrid.Columns.Item(4).Visible = False
        End If

        ResultGrid.Columns("NuevoRes").ReadOnly = False

        ResultGrid.Columns.Item(3).Visible = False
        ResultGrid.Columns.Item(4).Visible = False
        'ResultGrid.Item(2, 0).Selected = True
    End Sub

    Private Sub llenarResultadoGrid(ByVal exam As String, _
                           ByVal examId As String, _
                           ByVal hasSubExams As String, _
                           ByVal examenTypeId As String)

        ResultGrid.DataSource = Nothing
        ResultGrid.Rows.Clear()
        ResultGrid.Columns.Item(0).Visible = True
        ResultGrid.Columns.Item(1).Visible = True

        Dim HasRes As Boolean

        If hasSubExams = "SI" Then
            '*resize
            Me.Size = New Point(758, 760)
            ResultGrid.Size = New Point(714, 380)
            Me.StartPosition = FormStartPosition.CenterScreen

            '*get subExams list
            Dim subExList As New DataTable
            sql = "SELECT DescSpanish AS Descrip, SubExamen_ID AS Code, HasResultOptions FROM dbo.CdLabSubExamen_Type " + _
                      "WHERE Examen_Tipo_ID = " + examenTypeId + " " + _
                      "Order by SubExamen_ID "
            bdDataTable(sql, subExList)

            For i = 0 To subExList.Rows.Count() - 1
                desc = Trim$(chequearValor(subExList.Rows(i)("Descrip")))
                code = chequearValor(subExList.Rows(i)("Code"))
                HasRes = subExList.Rows(i)("HasResultOptions")
                Dim a() As String = {desc, exam, "", examId, code, "", "", ""}
                ResultGrid.Rows.Add(a)
                If HasRes = True Then
                    ResultGrid(2, i) = llenarResultadoCombo(code.ToString)
                End If
            Next

            ResultGrid.Columns.Item(0).Visible = True
            ResultGrid.Columns.Item(1).Visible = False
            ResultGrid.Columns.Item(2).Visible = True
            ResultGrid.Columns.Item(5).Visible = False
            ResultGrid.Columns.Item(6).Visible = False
        Else
            '*resize
            Me.Size = New Point(761, 584)
            Me.StartPosition = FormStartPosition.CenterScreen
            ResultGrid.Size = New Point(716, 76)

            '*UpdateResultGrid.Rows.Add(a)
            Dim a() As String = {"", exam, "", examId, "", "", "", ""}
            ResultGrid.Rows.Add(a)
            ResultGrid.Columns.Item(0).Visible = False
            ResultGrid.Columns.Item(1).Visible = True
            ResultGrid.Columns.Item(2).Visible = True
            ResultGrid.Columns.Item(5).Visible = False
            ResultGrid.Columns.Item(6).Visible = False
        End If

        ResultGrid.Columns("Resultado").ReadOnly = False
        ResultGrid.Columns.Item(3).Visible = False
        ResultGrid.Columns.Item(4).Visible = False
        ResultGrid.Item(2, 0).Selected = True
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
        Dim nxt As New AgendaLab
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
        e.Graphics.DrawString(dateRep.ToLongDateString, normal, Brushes.Black, centro + 130, 130)
        e.Graphics.DrawString("Impresión: " + DateTime.Now.ToShortDateString + " " + DateTime.Now.ToShortTimeString + " (" + U + ")", impres, Brushes.Black, centro + 80, 150)
        e.Graphics.DrawString("EXAMEN(ES) ", normalU, Brushes.Black, mIzq, y)

        Dim examen As String
        y = y + varY
        For f = 0 To ResultadosGrid.Rows.Count - 1
            examen = ResultadosGrid.Item(0, f).Value()
            e.Graphics.DrawString(examen, normalB, Brushes.Black, mIzq, y)

            If ResultadosGrid.Item(1, f).Value() = "" Then
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

    Private Sub ResultGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ResultGrid.CellContentClick
        Dim fila, columna, ID As Integer
        Dim newRes, newSubExamen_ID, examenId As String

        fila = ResultGrid.CurrentCellAddress.Y()
        columna = ResultGrid.CurrentCellAddress.X()
        ID = ResultGrid.Item(7, fila).Value
        newRes = ResultGrid.Item(5, fila).Value
        examenId = ResultGrid.Item(3, fila).Value.ToString

        If columna = 6 Then 'MsgBox("modificar")
            If ResultGrid.Item(4, fila).Value = 0 Then
                newSubExamen_ID = "NULL"
            Else
                newSubExamen_ID = ResultGrid.Item(4, fila).Value.ToString
            End If
            sql = "INSERT INTO dbo.MemberHealthLabResult " + _
                "SELECT  Resultado_ID, '" + Now.ToString(en.DateTimeFormat) + "', Examen_ID, '" + newRes + "', " + newSubExamen_ID + ", RecordStatus, '" + U + "', ExpirationDateTime " + _
                "FROM dbo.MemberHealthLabResult WHERE RecordStatus = ' ' AND Resultado_ID = " + ID.ToString
            bdInsertar(sql)
            MsgBox("Actualización correcta", vbInformation, My.Resources.versionFamilias2)
        End If

    End Sub

    Private Sub results(ByVal code As String, ByVal Lab As String, ByVal subs As String)

        Dim dt As New DataTable
        sql = "SELECT cdT.DescSpanish AS Lab, cdST.DescSpanish AS SubLab, convert(nvarchar(80), R.Resultado) Result " +
              "FROM dbo.MemberHealthLabResult R INNER JOIN dbo.MemberHealthLabExam E ON R.Examen_ID = E.Examen_ID AND R.RecordStatus = E.RecordStatus " + _
                    "INNER JOIN dbo.CdLabExamen_Type cdT ON E.Examen_Tipo_ID = cdT.Examen_Tipo_ID " + _
                    "LEFT OUTER JOIN dbo.CdLabSubExamen_Type cdST ON R.SubExamen_ID = cdST.SubExamen_ID " + _
              "WHERE E.RecordStatus = ' ' AND E.Examen_ID = " + code
        bdDataTable(sql, dt)
        llenarResultadoGrid(dt.Rows(0)("Lab").ToString, dt.Rows(0)("SubLab").ToString, dt.Rows(0)("Result").ToString, 1)

        If subs = "SI" Then
            For f = 1 To dt.Rows.Count - 1
                llenarResultadoGrid("", dt.Rows(f)("SubLab").ToString, dt.Rows(f)("Result").ToString, 0)
            Next
        End If
        llenarResultadoGrid("", "", "", 0)
    End Sub

    Private Sub saveLabResult(ByVal examId As String, _
                          ByVal result As String, _
                          ByVal subExamId As String)
        Dim ID As Integer
        sql = "SELECT MAX(Resultado_ID) AS ID FROM MemberHealthLabResult "
        ID = bdEntero(sql, "ID") + 1

        If subExamId = "" Or IsDBNull(subExamId) Then
            subExamId = "NULL"
        Else
            subExamId = "'" + subExamId + "'"
        End If

        Dim nowDate As DateTime = Date.Now
        sql = "INSERT INTO dbo.MemberHealthLabResult (Resultado_ID, CreationDateTime, Examen_ID,  Resultado, SubExamen_ID,  " + _
                  "RecordStatus, UserId, ExpirationDateTime) VALUES (" + _
                   ID.ToString + ", '" + nowDate.ToString(en.DateTimeFormat) + "', " + examId + ", '" + result + "', " + subExamId + ",  " + _
                  "' ', '" + U + "', NULL)"
        bdInsertar(sql)
    End Sub

    Private Sub valoresIniciales()
        llenarLabs(IdApp)
        nSub = 0
        ResultGrid.Visible = False
        GuardarButton.Visible = False
    End Sub


End Class