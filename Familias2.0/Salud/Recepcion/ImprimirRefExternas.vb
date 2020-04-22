' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ImprimirRefExternas
    Dim sMember, colaboracion As String
    Dim TamañoPersonal As New Printing.PaperSize("MediaCarta", 550, 850)
    Dim pl, memberId, IdCons As Integer

    Private Sub ImprimirRefExternas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        Listado()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GenerarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarButton.Click

        LabsGrid.DataSource = Nothing
        LabsGrid.Rows.Clear()

        PlanesGrid.DataSource = Nothing
        PlanesGrid.Rows.Clear()

        RecetasExtGrid.DataSource = Nothing
        RecetasExtGrid.Rows.Clear()

        RecetaInternaGrid.DataSource = Nothing
        RecetaInternaGrid.Rows.Clear()

        ReferenciaExtGrid.DataSource = Nothing
        ReferenciaExtGrid.Rows.Clear()

        printRecetaButton.Visible = False
        RecetasExtGrid.Visible = False
        printRefExtButton.Visible = False
        ReferenciaExtGrid.Visible = False
        printLabsButton.Visible = False
        LabsGrid.Visible = False
        printPlanesButton.Visible = False
        PlanesGrid.Visible = False
        RecetaInternaGrid.Visible = False
        PacienteL.Visible = False
        FamiliaL.Visible = False
        DrL.Visible = False

        Listado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub labsInfo(ByVal consid As Integer)
        LabsGrid.DataSource = Nothing
        LabsGrid.Rows.Clear()
        sql = "SELECT dbo.fn_GEN_FormatDate(A.ReferenceDate, 'ES') AS Fecha, cdT.DescSpanish AS Laboratorios, CASE WHEN cdT.Recommendations IS NULL " + _
              "THEN '' ELSE '(' + cdT.Recommendations + ')' END AS Recomendaciones " + _
              "FROM dbo.MemberHealthLabAppointment A INNER JOIN dbo.MemberHealthLabExam E ON A.RecordStatus = E.RecordStatus AND A.IdAppLab = E.IdAppLab " + _
              "INNER JOIN dbo.CdLabExamen_Type cdT ON E.Examen_Tipo_ID = cdT.Examen_Tipo_ID " + _
              "WHERE A.RecordStatus = ' ' AND A.IdConsultation = " + consid.ToString
        bdGrid(sql, LabsGrid)
    End Sub

    Private Sub Listado()
        PacienteL.Visible = False
        FamiliaL.Visible = False
        DrL.Visible = False
        PacientesGrid.DataSource = Nothing
        PacientesGrid.Rows.Clear() ''Plan Educ.'
        sql = "SELECT IdConsultation,Sitio, [No.Paciente], Paciente, Familia, SUM(Receta) 'Recetas', SUM(Ref) 'Referencias', SUM(Lab) 'Laboratorios', SUM(PlanEduc) 'Plan/Farmacia' " + _
              "FROM dbo.fn_HEAL_ReferenciasExternas() " + _
              "WHERE YEAR(DateRef) = " + ActualDateP.Value.Year.ToString + " AND MONTH(DateRef) = " + ActualDateP.Value.Month.ToString + " AND DAY(DateRef) = " + ActualDateP.Value.Day.ToString + " " + _
              "GROUP BY IdConsultation, Sitio, [No.Paciente], Paciente, Familia " + _
              "ORDER BY IdConsultation DESC "
        bdGrid(sql, PacientesGrid)
        'InputBox("", "", sql)


        PacientesGrid.Columns.Item(0).Visible = False

    End Sub

    Private Sub llenarMedsList(ByVal valor As String, ByVal tipo As String)
        Dim a() As String = {valor, tipo}
        tempGrid.Rows.Add(a)
    End Sub

    Private Sub medico(ByVal idCon As Integer)
        sql = "SELECT EmployeeId Dr " + _
              "FROM dbo.MemberClinicAppointment MCA " + _
              "INNER JOIN MemberClinicConsultation MCC ON MCA.AppId = MCC.AppId AND MCA.RecordStatus = MCC.RecordStatus " + _
              "WHERE MCC.RecordStatus = ' ' AND MCC.IdConsultation = " + idCon.ToString
        DrL.Text = chequearValor(bdPalabra(sql, "Dr"))
    End Sub

    Private Sub PacientesGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PacientesGrid.CellContentClick
        Dim fila, columna, rec, ref, labs As Integer
        fila = PacientesGrid.CurrentCellAddress.Y()
        columna = PacientesGrid.CurrentCellAddress.X()
        IdCons = PacientesGrid.Item(0, fila).Value
        sMember = PacientesGrid.Item(1, fila).Value
        memberId = PacientesGrid.Item(2, fila).Value.ToString
        PacienteL.Text = PacientesGrid.Item(3, fila).Value
        FamiliaL.Text = sMember + PacientesGrid.Item(4, fila).Value.ToString
        rec = PacientesGrid.Item(5, fila).Value
        ref = PacientesGrid.Item(6, fila).Value
        labs = PacientesGrid.Item(7, fila).Value
        pl = PacientesGrid.Item(8, fila).Value

        PacienteL.Visible = True
        FamiliaL.Visible = True
        DrL.Visible = True

        If rec > 0 Then
            RecetasExtGrid.Visible = True
            printRecetaButton.Visible = True
        Else
            RecetasExtGrid.Visible = False
            printRecetaButton.Visible = False
        End If

        If ref > 0 Then
            ReferenciaExtGrid.Visible = True
            printRefExtButton.Visible = True
        Else
            ReferenciaExtGrid.Visible = False
            printRefExtButton.Visible = False
        End If

        If labs > 0 Then
            LabsGrid.Visible = True
            printLabsButton.Visible = True
        Else
            LabsGrid.Visible = False
            printLabsButton.Visible = False
        End If

        If pl > 0 Then
            PlanesGrid.Visible = True
            printPlanesButton.Visible = True
        Else
            PlanesGrid.Visible = False
            printPlanesButton.Visible = False
        End If

        medico(IdCons)
        planInfo(IdCons)
        labsInfo(IdCons)
        recetasExtInfo(IdCons)
        recetasIntInfo(IdCons)
        referenciasExtInfo(IdCons)

        If RecetaInternaGrid.RowCount > 0 Then
            printPlanesButton.Visible = True
            RecetaInternaGrid.Visible = True
        Else
            RecetaInternaGrid.Visible = False
        End If
    End Sub

    Private Sub planInfo(ByVal consid As Integer)
        PlanesGrid.DataSource = Nothing
        PlanesGrid.Rows.Clear()
        sql = "SELECT  dbo.fn_GEN_FormatDate (MHC.ConsultationDateTime, 'ES') 'Fecha',   MHC.EducationalPlan AS 'Plan', CASE WHEN Exoneration = 1 THEN 0 ELSE ApprovedPrice END Total, Len(MHC.EducationalPlan) N " + _
              "FROM  dbo.MemberClinicConsultation MHC " + _
              "WHERE MHC.RecordStatus = ' ' AND MHC.EducationalPlan IS NOT NULL AND  MHC.IdConsultation = " + consid.ToString
        bdGrid(sql, PlanesGrid)

        Dim col As String = bdPalabra("SELECT dbo.fn_SALU_ColaboracionPorServicios('" + sMember + "', " + memberId.ToString + ") C ", "C")
        Dim ex As Integer = bdEntero("SELECT COUNT(*) Total FROM MemberClinicConsultation WHERE RecordStatus = ' ' AND IdConsultation = " + IdCons.tostring + " AND Exoneration = 1 ", "Total")

        If col = "0.00" Or ex = 1 Then
            colaboracion = ""
        Else
            sql = "SELECT cdHCT.Price " + _
                     "FROM  dbo.MemberClinicAppointment MCA INNER JOIN dbo.CdHealthConsultationType cdHCT ON MCA.ConsultationType = cdHCT.Code " + _
                     "INNER JOIN dbo.MemberClinicConsultation MCC ON MCA.AppId = MCC.AppId AND MCA.RecordStatus = MCC.RecordStatus " + _
                     "WHERE MCA.RecordStatus = ' ' AND MCC.IdConsultation = " + consid.ToString
            Dim dona As Integer = bdEntero(sql, "Price")
            If dona = 0 Then
                colaboracion = ""
            Else
                colaboracion = "Colaboración por servicios médicos: Q" + col
            End If
        End If
        PlanesGrid.Columns.Item(3).Visible = False
    End Sub

    Private Sub PrintDocumentLabs_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentLabs.PrintPage
        'https://stackoverflow.com/questions/33622110/vb-net-printing-multiple-pages
        'https://www.oreilly.com/library/view/programming-visual-basic/0596000936/ch04s07.html

        Dim type As String = "Arial"
        Dim typeT As String = "Arial Narrow"
        Dim norFont As New Font(type, 12, FontStyle.Regular)
        Dim smaFont As New Font(type, 10, FontStyle.Regular)
        Dim xsmaFont As New Font(type, 8, FontStyle.Regular)
        Dim titFont As New Font(typeT, 12, FontStyle.Bold)
        Dim yPos As Single = norFont.GetHeight(e.Graphics)
        Dim yNew As Integer
        Dim mIzq As Integer = 20
        Dim N As Integer = ReferenciaExtGrid.RowCount
        Dim tempC As New CheckBox

        Dim logo As Image = My.Resources.FamiliasdeEsperanza_Logo_RGB 'logo
        Dim drawFormat As New StringFormat
        drawFormat.Alignment = StringAlignment.Center

        'Encabezado
        e.Graphics.DrawImage(logo, mIzq + 78 + 50, 10) 'logo
        Dim rect1 As New Rectangle(mIzq + 50, 40, 420, 18)
        e.Graphics.DrawString("CLINICA MEDICA", titFont, Brushes.Black, rect1, drawFormat)
        Dim rect2 As New Rectangle(mIzq + 50, 55, 420, 18)
        e.Graphics.DrawString("Km. 2 Carretera a San Juan del Obispo", smaFont, Brushes.Black, rect2, drawFormat)
        Dim rect3 As New Rectangle(mIzq + 50, 70, 420, 18)
        e.Graphics.DrawString("Antigua Guatemala, Sacatepéquez", smaFont, Brushes.Black, rect3, drawFormat)
        Dim rect4 As New Rectangle(mIzq + 50, 85, 420, 18)
        e.Graphics.DrawString("Tel. 7922-6600", smaFont, Brushes.Black, rect4, drawFormat)
        Dim rect5 As New Rectangle(mIzq + 50, 100, 420, 18)
        e.Graphics.DrawString("NIT 755686-1", smaFont, Brushes.Black, rect5, drawFormat)

        'Info. general
        e.Graphics.DrawString(FamiliaL.Text, xsmaFont, Brushes.Black, 480, yPos + 130) '+40
        e.Graphics.DrawString("Paciente: " + PacienteL.Text.ToUpper, norFont, Brushes.Black, mIzq, yPos + 140) '+40

        'Laboratorios
        yNew = 200 ' +30
        Dim drawFormatLab As New StringFormat
        drawFormat.Alignment = StringAlignment.Center
        Dim rect6 As New Rectangle(mIzq + 50, yPos + 180, 420, 18)
        e.Graphics.DrawString("ORDEN DE LABORATORIOS", New Font(type, 10, FontStyle.Italic), Brushes.Black, rect6, drawFormat) '+40
        yNew = 230
        'yNew = 280
        For f = 0 To LabsGrid.RowCount - 1
            e.Graphics.DrawString(LabsGrid.Item(1, f).Value() + "     " + LabsGrid.Item(0, f).Value(), titFont, Brushes.Black, mIzq + 30, yPos + yNew)
            yNew = yNew + 20
            If Len(LabsGrid.Item(2, f).Value()) > 0 Then
                Dim rect7 As New Rectangle(mIzq + 30, yPos + yNew, 420, 40)
                e.Graphics.DrawString("-" + LabsGrid.Item(2, f).Value(), norFont, Brushes.Black, rect7, drawFormatLab)
                yNew = yNew + 40
            End If
        Next

        'nombre médico
        sql = "Select ShortName Nombre FROM  dbo.FwEmployee E WHERE EmployeeId = '" + DrL.Text + "'"
        e.Graphics.DrawString(bdPalabra(sql, "Nombre"), norFont, Brushes.Black, 250, 700)

        Dim impres As String = "Impresión: " + U + " (" + DateAndTime.Now.ToLongDateString + ", " + DateAndTime.Now.ToLongTimeString + ")"
        e.Graphics.DrawString(impres, New Font(type, 6, FontStyle.Italic), Brushes.Black, mIzq, 800) 'datos de impresión

        e.Graphics.PageUnit = GraphicsUnit.Inch

    End Sub

    Private Sub PrintDocumentPlanes_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentPlanes.PrintPage
        Dim letra As String = "Arial Narrow"
        Dim titFont As New Font(letra, 12, FontStyle.Bold)
        Dim smaFont As New Font(letra, 10, FontStyle.Regular)
        Dim xsmaFont As New Font(letra, 8, FontStyle.Regular)
        Dim norFont As New Font(letra, 11, FontStyle.Regular)
        Dim tipoSel
        Dim mIzq As Integer = 20
        Dim y As Integer
        Dim alineacion As New StringFormat
        alineacion.Alignment = StringAlignment.Near

        Dim medico As String = bdPalabra("Select ShortName Nombre FROM  dbo.FwEmployee E WHERE EmployeeId = '" + DrL.Text + "'", "Nombre")
        Dim impres As String = "Impresión: " + U + " (" + DateAndTime.Now.ToLongDateString + ", " + DateAndTime.Now.ToLongTimeString + ")"

        'Encabezado
        Dim logo As Image = My.Resources.FamiliasdeEsperanza_Logo_RGB 'logo
        Dim centrado As New StringFormat
        centrado.Alignment = StringAlignment.Center

        Dim derecho As New StringFormat
        derecho.Alignment = StringAlignment.Far

        e.Graphics.DrawImage(logo, mIzq + 78 + 50, 10) 'logo
        Dim rect1 As New Rectangle(mIzq + 50, 40, 420, 18)
        e.Graphics.DrawString("CLINICA MEDICA", titFont, Brushes.Black, rect1, centrado)
        Dim rect2 As New Rectangle(mIzq + 50, 55, 420, 18)
        e.Graphics.DrawString("Km. 2 Carretera a San Juan del Obispo, Antigua Guatemala, Sacatepéquez", smaFont, Brushes.Black, rect2, centrado)
        Dim rect4 As New Rectangle(mIzq + 50, 70, 420, 18)
        e.Graphics.DrawString("Tel. 7922-6600   |   NIT 755686-1", smaFont, Brushes.Black, rect4, centrado)

        'Info. general
        e.Graphics.DrawString(FamiliaL.Text, xsmaFont, Brushes.Black, 480, 90)
        y = 100
        e.Graphics.DrawString("Paciente: " + PacienteL.Text.ToUpper, norFont, Brushes.Black, mIzq, y)
        y = y + 18
        e.Graphics.DrawString("Fecha: " + PlanesGrid.Item(0, 0).Value().ToString, norFont, Brushes.Black, mIzq, y)
        e.Graphics.DrawString("Médico: " + medico, norFont, Brushes.Black, 280, y)
        y = y + 15
        e.Graphics.DrawString(impres, New Font(letra, 6, FontStyle.Italic), Brushes.Black, 280, y)
        y = y + 25

        Dim rect5 As New Rectangle(mIzq + 50, y, 430, 18)

        'Dim colaboracion As String = bdPalabra("SELECT dbo.fn_SALU_ColaboracionPorServicios('" + sMember + "', " + memberId.ToString + ") C ", "C")
        If Len(colaboracion) = 0 Then
        Else
            e.Graphics.DrawString(colaboracion, New Font("Arial", 11, FontStyle.Underline), Brushes.Black, rect5, derecho)
        End If


        'RECETA INTERNA
        If tempGrid.RowCount > 0 Then
            Dim tipo, descripcion As String
            Dim anchoMax As Integer = 480
            Dim tamaño As New SizeF
            Dim lineas As Integer
            Dim alto As Double

            'Encabezado Receta
            'y = y + 35
            y = y + 15
            For f = 0 To tempGrid.RowCount - 1
                tipo = tempGrid.Item(1, f).Value()
                descripcion = tempGrid.Item(0, f).Value()

                If tipo = "TM" Then
                    tipoSel = titFont
                ElseIf tipo = "M" Then
                    tipoSel = smaFont
                ElseIf tipo = "TP" Then
                    tipoSel = titFont
                ElseIf tipo = "DP" Then
                    tipoSel = smaFont
                Else
                    tipoSel = New Font(letra, 4, FontStyle.Italic)
                End If

                tamaño = e.Graphics.MeasureString(descripcion, tipoSel)

                If tamaño.Width < anchoMax Then
                    lineas = 1
                ElseIf tamaño.Width >= anchoMax And tamaño.Width < (anchoMax * 2) Then
                    lineas = 2
                Else
                    lineas = tamaño.Width / anchoMax
                End If

                alto = tamaño.Height * lineas
                'TextBox1.Text = TextBox1.Text + alto.ToString + vbCrLf
                Dim rectMed As New Rectangle(mIzq, y, anchoMax, alto)
                e.Graphics.DrawString(tempGrid.Item(0, f).Value(), tipoSel, Brushes.Black, rectMed, alineacion)
                y = y + alto
            Next
        End If
    End Sub

    Private Sub PrintDocumentReceta_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentReceta.PrintPage
        Dim type As String = "Arial Narrow"
        Dim norFont As New Font(type, 12, FontStyle.Regular)
        Dim smaFont As New Font(type, 10, FontStyle.Regular)
        Dim xsmaFont As New Font(type, 8, FontStyle.Regular)
        Dim titFont As New Font(type, 12, FontStyle.Bold)
        Dim xPos As Single = 50 'e.MarginBounds.Left
        Dim yPos As Single = norFont.GetHeight(e.Graphics)
        Dim yNew As Integer

        Dim middle As Integer = 420 'centro
        Dim middleOfMid1 As Integer = 180
        Dim middleOfMid2 As Integer = middle + 200

        Dim logo As Image = My.Resources.FamiliasdeEsperanza_Logo_RGB 'logo
        Dim drawFormat As New StringFormat
        drawFormat.Alignment = StringAlignment.Center

        'Encabezado
        e.Graphics.DrawImage(logo, xPos + 78, 10) 'logo
        Dim rect1 As New Rectangle(xPos, 40, 420, 18)
        e.Graphics.DrawString("CLINICA MEDICA", titFont, Brushes.Black, rect1, drawFormat)
        Dim rect2 As New Rectangle(xPos, 55, 420, 18)
        e.Graphics.DrawString("Km. 2 Carretera a San Juan del Obispo", smaFont, Brushes.Black, rect2, drawFormat)
        Dim rect3 As New Rectangle(xPos, 70, 420, 18)
        e.Graphics.DrawString("Antigua Guatemala, Sacatepéquez", smaFont, Brushes.Black, rect3, drawFormat)
        Dim rect4 As New Rectangle(xPos, 85, 420, 18)
        e.Graphics.DrawString("Tel. 7922-6600", smaFont, Brushes.Black, rect4, drawFormat)
        Dim rect5 As New Rectangle(xPos, 100, 420, 18)
        e.Graphics.DrawString("NIT 755686-1", smaFont, Brushes.Black, rect5, drawFormat)

        'Info. general
        e.Graphics.DrawString(FamiliaL.Text, xsmaFont, Brushes.Black, 480, yPos + 130) '+40
        e.Graphics.DrawString("Paciente: " + PacienteL.Text.ToUpper, norFont, Brushes.Black, xPos, yPos + 140) '+40
        e.Graphics.DrawString("Fecha: " + RecetasExtGrid.Item(0, 0).Value(), norFont, Brushes.Black, xPos, yPos + 160) '+20

        'recetas
        e.Graphics.DrawString("Rp. ", New Font(type, 10, FontStyle.Italic), Brushes.Black, xPos, yPos + 200) '+40
        yNew = 230 ' +30
        Dim drawFormat2 As New StringFormat
        drawFormat2.Alignment = StringAlignment.Near

        For f = 0 To RecetasExtGrid.RowCount - 1
            e.Graphics.DrawString(RecetasExtGrid.Item(1, f).Value() + "                 #" + RecetasExtGrid.Item(2, f).Value(), titFont, Brushes.Black, xPos, yPos + yNew)
            yNew = yNew + 20
            Dim rect6 As New Rectangle(xPos, yPos + yNew, 420, 40)
            e.Graphics.DrawString(RecetasExtGrid.Item(3, f).Value(), norFont, Brushes.Black, rect6, drawFormat2)
            yNew = yNew + 60
        Next

        'nombre médico
        sql = "Select ShortName Nombre FROM  dbo.FwEmployee E WHERE EmployeeId = '" + DrL.Text + "'"
        e.Graphics.DrawString(bdPalabra(sql, "Nombre"), norFont, Brushes.Black, 250, 750)

        e.Graphics.PageUnit = GraphicsUnit.Inch
    End Sub

    Private Sub PrintDocumentRefe_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentRefe.PrintPage
        Dim type As String = "Arial"
        Dim typeT As String = "Arial Narrow"
        Dim norFont As New Font(type, 12, FontStyle.Regular)
        Dim smaFont As New Font(type, 10, FontStyle.Regular)
        Dim xsmaFont As New Font(type, 8, FontStyle.Regular)
        Dim titFont As New Font(typeT, 12, FontStyle.Bold)
        Dim yPos As Single = norFont.GetHeight(e.Graphics)
        Dim yNew As Integer
        Dim mIzq As Integer = 20
        Dim N As Integer = ReferenciaExtGrid.RowCount
        Dim tempC As New CheckBox

        For f = 0 To N - 1
            tempC.Checked = ReferenciaExtGrid.Item(0, f).Value()
            If tempC.Checked = True Then

                Dim logo As Image = My.Resources.FamiliasdeEsperanza_Logo_RGB 'logo
                Dim drawFormat As New StringFormat
                drawFormat.Alignment = StringAlignment.Center

                'Encabezado
                e.Graphics.DrawImage(logo, mIzq + 78 + 50, 10) 'logo
                Dim rect1 As New Rectangle(mIzq + 50, 40, 420, 18)
                e.Graphics.DrawString("CLINICA MEDICA", titFont, Brushes.Black, rect1, drawFormat)
                Dim rect2 As New Rectangle(mIzq + 50, 55, 420, 18)
                e.Graphics.DrawString("Km. 2 Carretera a San Juan del Obispo", smaFont, Brushes.Black, rect2, drawFormat)
                Dim rect3 As New Rectangle(mIzq + 50, 70, 420, 18)
                e.Graphics.DrawString("Antigua Guatemala, Sacatepéquez", smaFont, Brushes.Black, rect3, drawFormat)
                Dim rect4 As New Rectangle(mIzq + 50, 85, 420, 18)
                e.Graphics.DrawString("Tel. 7922-6600", smaFont, Brushes.Black, rect4, drawFormat)
                Dim rect5 As New Rectangle(mIzq + 50, 100, 420, 18)
                e.Graphics.DrawString("NIT 755686-1", smaFont, Brushes.Black, rect5, drawFormat)

                'Info. general
                e.Graphics.DrawString(FamiliaL.Text, xsmaFont, Brushes.Black, 480, yPos + 130) '+40
                e.Graphics.DrawString("Paciente: " + PacienteL.Text.ToUpper, norFont, Brushes.Black, mIzq, yPos + 140) '+40
                e.Graphics.DrawString("Fecha: " + ReferenciaExtGrid.Item(1, f).Value().ToString, norFont, Brushes.Black, mIzq, yPos + 160)

                'recetas
                yNew = 200 ' +30
                e.Graphics.DrawString("Referido a: " + ReferenciaExtGrid.Item(2, f).Value(), titFont, Brushes.Black, mIzq, yPos + yNew)
                yNew = yNew + 20
                e.Graphics.DrawString("Motivo: " + ReferenciaExtGrid.Item(3, f).Value(), New Font(type, 12, FontStyle.Italic), Brushes.Black, mIzq, yPos + yNew)
                yNew = yNew + 40

                e.Graphics.DrawString("Rp. ", New Font(type, 10, FontStyle.Italic), Brushes.Black, mIzq, yPos + yNew)
                yNew = yNew + 20

                'Rp
                Dim width As Single = 500 '200.0F
                Dim height As Single = 700 '50.0F
                Dim drawRect As New RectangleF(mIzq, yPos + yNew, width, height)
                Dim drawFormat2 As New StringFormat
                drawFormat2.Alignment = StringAlignment.Center  'Near

                e.Graphics.DrawString(ReferenciaExtGrid.Item(4, f).Value(), smaFont, Brushes.Black, drawRect, drawFormat2)

                'nombre médico
                sql = "Select ShortName Nombre FROM  dbo.FwEmployee E WHERE EmployeeId = '" + DrL.Text + "'"
                e.Graphics.DrawString(bdPalabra(sql, "Nombre"), norFont, Brushes.Black, 250, 800)
                e.Graphics.PageUnit = GraphicsUnit.Inch
            End If
        Next
    End Sub

    Private Sub printRecetaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printRecetaButton.Click
        If RecetasExtGrid.RowCount > 0 Then
            PrintPreviewDialogReceta.Document = PrintDocumentReceta 'PrintPreviewDialog associate with PrintDocument.
            PrintDocumentReceta.DefaultPageSettings.PaperSize = TamañoPersonal
            PrintPreviewDialogReceta.ShowDialog() 'open the print preview
        Else
            MsgBox("No hay recetas a imprimir", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub printRefExtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printRefExtButton.Click
        If ReferenciaExtGrid.RowCount > 0 Then
            PrintPreviewDialogRefe.Document = PrintDocumentRefe 'PrintPreviewDialog associate with PrintDocument.
            PrintDocumentRefe.DefaultPageSettings.PaperSize = TamañoPersonal
            PrintPreviewDialogRefe.ShowDialog() 'open the print preview
        Else
            MsgBox("No hay referencias a imprimir", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub printLabsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printLabsButton.Click
        If LabsGrid.RowCount > 0 Then
            PrintPreviewDialogLabs.Document = PrintDocumentLabs 'PrintPreviewDialog associate with PrintDocument.
            PrintDocumentLabs.DefaultPageSettings.PaperSize = TamañoPersonal
            PrintPreviewDialogLabs.ShowDialog() 'open the print preview
        Else
            MsgBox("No hay referencias a Laboratorio para imprimir", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub printPlanesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printPlanesButton.Click
        recetaPlanGrid()
        PrintPreviewDialogPlanes.Document = PrintDocumentPlanes 'PrintPreviewDialog associate with PrintDocument.
        PrintDocumentPlanes.DefaultPageSettings.PaperSize = TamañoPersonal
        PrintPreviewDialogPlanes.ShowDialog() 'open the print preview
    End Sub

    Private Sub recetaPlanGrid()
        tempGrid.DataSource = Nothing
        tempGrid.Rows.Clear()
        Dim fila As Integer = 0

        If RecetaInternaGrid.RowCount > 0 Then
            llenarMedsList("MEDICINA ", "TM")
            For f = 0 To RecetaInternaGrid.RowCount - 1
                'llenarMedsList(RecetaInternaGrid.Item(0, f).Value() + "  #" + RecetaInternaGrid.Item(1, f).Value().ToString + _
                '               "  (Q." + RecetaInternaGrid.Item(3, f).Value().ToString + ")" + vbCrLf + "-" + RecetaInternaGrid.Item(2, f).Value(), "M")
                llenarMedsList(RecetaInternaGrid.Item(0, f).Value() + "  #" + RecetaInternaGrid.Item(1, f).Value().ToString + _
               vbCrLf + "-" + RecetaInternaGrid.Item(2, f).Value(), "M")
                llenarMedsList(" ", "E")
            Next
        End If

        If PlanesGrid.Item(3, 0).Value() > 0 Then
            llenarMedsList(" ", "E")
            llenarMedsList("PLAN EDUCACIONAL", "TP")
            llenarMedsList(PlanesGrid.Item(1, 0).Value(), "DP")
        End If
    End Sub

    'Private Sub recetaPlanGrid()
    '    tempGrid.DataSource = Nothing
    '    tempGrid.Rows.Clear()
    '    Dim fila As Integer = 0

    '    If RecetaInternaGrid.RowCount > 0 Then
    '        llenarMedsList("MEDICINA                                        Q." + PlanesGrid.Item(2, 0).Value().ToString, "TM")
    '        For f = 0 To RecetaInternaGrid.RowCount - 1
    '            llenarMedsList(RecetaInternaGrid.Item(0, f).Value() + "  #" + RecetaInternaGrid.Item(1, f).Value().ToString + _
    '                           "  (Q." + RecetaInternaGrid.Item(3, f).Value().ToString + ")" + vbCrLf + "-" + RecetaInternaGrid.Item(2, f).Value(), "M")
    '            llenarMedsList(" ", "E")
    '        Next
    '    End If

    '    If PlanesGrid.Item(3, 0).Value() > 0 Then
    '        llenarMedsList(" ", "E")
    '        llenarMedsList("PLAN EDUCACIONAL", "TP")
    '        llenarMedsList(PlanesGrid.Item(1, 0).Value(), "DP")
    '    End If
    'End Sub

    Private Sub recetasExtInfo(ByVal consid As Integer)
        RecetasExtGrid.DataSource = Nothing
        RecetasExtGrid.Rows.Clear()
        'fill recetasExternas
        sql = "SELECT dbo.fn_GEN_FormatDate(PresDateTime, 'ES') AS Fecha, Medicine AS Medicina, Quantity AS Cantidad, Instruction AS Rp " + _
              "FROM  dbo.MemberClinicExternalPrescription MCEP " + _
              "WHERE RecordStatus = ' ' AND IdConsultation = " + consid.ToString
        bdGrid(sql, RecetasExtGrid)
    End Sub

    Private Sub recetasIntInfo(ByVal consid As Integer)
        RecetaInternaGrid.DataSource = Nothing
        RecetaInternaGrid.Rows.Clear()
        'fill recetaInterna
        sql = "SELECT CASE WHEN Code = 'OTRA' THEN Code  + ' - ' + HITM.notes ELSE  Code + ' - ' + CASE WHEN DosageDesc_es IS NULL THEN cdII.DescSpanish ELSE cdII.DescSpanish + ' (' + DosageDesc_es + ') ' END  END  Medicina, " + _
              "HITM.Quantity * - 1 AS Cantidad, HITM.Indications Indicaciones, HITM.ApprovedTotalPrice Precio, LEN(HITM.Indications) anchoIndi " + _
              "FROM dbo.HealthInventoryTransactionMedi HITM INNER JOIN dbo.CdHealthInventoryItem cdII ON HITM.Item = cdII.Code " + _
              "WHERE HITM.RecordStatus = ' ' AND HITM.Quantity < 0 AND IdConsultation = " + consid.ToString + " "
        bdGrid(sql, RecetaInternaGrid)
    End Sub

    Private Sub referenciasExtInfo(ByVal consid As Integer)
        ReferenciaExtGrid.DataSource = Nothing
        ReferenciaExtGrid.Rows.Clear()
        sql = "SELECT dbo.fn_GEN_FormatDate(MCER.ReferenceDateTime, 'ES') AS Fecha, cdP.DescSpanish AS [Referido A], cdR.DescSpanish AS Motivo, MCER.Rp " + _
              "FROM dbo.MemberClinicExternalReference MCER INNER JOIN dbo.CdHealthExternalReferencePlace cdP ON MCER.Place = cdP.Code " + _
              "INNER JOIN dbo.CdHealthExternalReferenceReason cdR ON MCER.Reason = cdR.Code " + _
              "WHERE MCER.RecordStatus = ' ' AND MCER.IdConsultation = " + consid.ToString + " " + _
              "UNION ALL " + _
              "SELECT dbo.fn_GEN_FormatDate(MIR.ReferenceDateTime, 'ES') AS Fecha, 'Apoyo Educativo' AS L, cdC.DescSpanish AS Categoría, MIR.Description AS Descripción " + _
              "FROM dbo.MemberInternalReference MIR INNER JOIN dbo.CdInternalReferenceCategory cdC ON MIR.Category = cdC.Code INNER JOIN dbo.CdInternalReferenceStatus cdS ON MIR.Status = cdS.Code " + _
              "WHERE MIR.RecordStatus = ' ' AND MIR.Program = 'PSIC' AND MIR.IdConsultation = " + consid.ToString + " "
        bdGrid(sql, ReferenciaExtGrid)
        If ReferenciaExtGrid.Rows.Count > 0 Then
            ReferenciaExtGrid.Item(0, 0).Value() = True
        End If
    End Sub

    Private Sub valoresIniciales()
        Listado()
    End Sub
End Class