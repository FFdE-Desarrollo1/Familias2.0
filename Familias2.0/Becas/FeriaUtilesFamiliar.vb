' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class FeriaUtilesFamiliar
    Dim margenDerecho As Single = 540
    Dim normal As New Font("Arial", 10)
    Dim miscL, col As String
    Dim altoFila

    Private Sub FeriaUtilesFamiliar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If FamiliaV.Text = "" Then
            ApadrinadoV.Visible = True
            ApadrinadoL.Visible = True
            ApadrinadoV.Focus()
        Else
            valoresIniciales()
        End If

        If S = "F" Then
            miscL = "Pantalón"
        Else
            miscL = "Corbata"
        End If
    End Sub

    Private Sub ApadrinadoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ApadrinadoV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If ApadrinadoV.Text = "" Then
            Else
                If miembroEsValido(S, ApadrinadoV.Text) = True Then
                    sql = "SELECT LastFamilyId Familia FROM Member WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + ApadrinadoV.Text
                    FamiliaV.Text = bdEntero(sql, "Familia").ToString
                    valoresIniciales()
                Else
                    ApadrinadoV.Text = ""
                End If
            End If
        End If

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

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            'If Len(FamiliaV.Text) = 0 Then
            valoresIniciales()
            'End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function fecha() As String
        sql = "SELECT PropertyValue Entrega FROM FwApplicationProperty WHERE Organization = '" + S + "' AND Category = 'UTIL' AND Name = 'DeliveryDate' "
        fecha = bdPalabra(sql, "Entrega")
    End Function

    Private Sub fillGrid(ByVal apadrinado As String, ByVal escuela As String, ByVal Paquete As String, ByVal carrera As String)
        Dim g As System.Drawing.Graphics = Me.CreateGraphics
        Dim detalle, car As String
        If Len(carrera) > 0 Then
            car = " (" + carrera + ")"
        Else
            car = ""
        End If
        If Len(Paquete) > 0 Then
            detalle = escuela.ToUpper + car + ": " + Paquete
        Else
            detalle = escuela.ToUpper + car
        End If
        Dim ancho = g.MeasureString(detalle, normal).Width
        altoFila = g.MeasureString(detalle, normal).Height.ToString
        Dim filas As Integer = Math.Truncate(Double.Parse(((ancho / margenDerecho) + 1).ToString))
        Dim a() As String = {apadrinado, detalle, ancho, filas}
        InvitacionGrid.Rows.Add(a)
    End Sub

    Private Function horario(ByVal familia As Integer) As String
        Dim inicial As Integer = Microsoft.VisualBasic.Left(Integer.Parse(familia), 1)
        horario = "8:00 Hrs."

        If S = "F" Then
            If inicial = 1 Then
                horario = "(7:00 Hrs.)"
            ElseIf inicial = 2 Then
                horario = "(8:00 Hrs.)"
            Else
                horario = "(9:30 Hrs.)"
            End If
        End If
    End Function

    Private Sub ImprimirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirButton.Click
        Dim Nbolsas As Integer
        Dim temp As String

        For i = 0 To ListadoGrid.Rows.Count - 1
            temp = chequearValor(ListadoGrid.Item(7, i).Value)
            If temp = "" Then
            Else
                Nbolsas = Nbolsas + 1
            End If
        Next

        If Nbolsas <> ListadoGrid.Rows.Count Then
            MsgBox("Aun faltan tipo de bolsa para algunos apadrinados", vbQuestion, My.Resources.versionFamilias2)
        End If
        PrintPreviewDialogVale.Document = PrintDocumentVale 'PrintPreviewDialog associate with PrintDocument.
        PrintPreviewDialogVale.ShowDialog() 'open the print preview
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irActualizarInfo(ByVal seleccionado As String, ByVal fila As Integer)
        Dim nxt As New ActualizacionFestivalUtiles
        nxt.ApadrinadoV.Text = seleccionado
        nxt.NombreV.Text = ListadoGrid.Item(3, fila).Value
        nxt.FamiliaV.Text = FamiliaV.Text
        nxt.AñoV.Text = chequearValor(ListadoGrid.Item(26, fila).Value)
        nxt.GradoV.Text = chequearValor(ListadoGrid.Item(5, fila).Value) + " - " + chequearValor(ListadoGrid.Item(4, fila).Value)
        'nxt.EstadoV.Text = chequearValor(ListadoGrid.Item(5, fila).Value)
        nxt.EscuelaActualV.Text = chequearValor(ListadoGrid.Item(6, fila).Value)
        nxt.pEst = chequearValor(ListadoGrid.Item(8, fila).Value)
        nxt.proxC = chequearValor(ListadoGrid.Item(29, fila).Value)
        nxt.TB = chequearValor(ListadoGrid.Item(7, fila).Value)
        nxt.ZapatosNCheck.Checked = ListadoGrid.Item(9, fila).Value
        nxt.TenisCheck.Checked = ListadoGrid.Item(10, fila).Value
        nxt.UniformeCheck.Checked = ListadoGrid.Item(11, fila).Value
        nxt.Extra1oBCheckBox.Checked = ListadoGrid.Item(30, fila).Value
        nxt.actuN = chequearValor(ListadoGrid.Item(27, fila).Value)
        nxt.proxN = chequearValor(ListadoGrid.Item(28, fila).Value)
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub llenarGrid()
        InvitacionGrid.Rows.Clear()                          'para limpiarlo
        InvitacionGrid.DataSource = Nothing
        Dim zap, ten, cam, pol, tel, sue, pla, chu, pan, cha, corb As String
        Dim paq As String = ""
        For f = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid.Item(0, f).Value() = True Then
                If ListadoGrid.Item(7, f).Value() = "NO RECIBE" Then
                Else
                    If Len(ListadoGrid.Item(12, f).Value().ToString) > 0 Then
                        zap = "Zap. Cuero: " + ListadoGrid.Item(12, f).Value().ToString + ".  "
                    Else
                        zap = ""
                    End If

                    If Len(ListadoGrid.Item(13, f).Value().ToString) > 0 Then
                        ten = "Tenis: " + ListadoGrid.Item(13, f).Value().ToString + ".  "
                    Else
                        ten = ""
                    End If

                    If Len(ListadoGrid.Item(14, f).Value().ToString) > 0 Then
                        cam = "Camisa: " + ListadoGrid.Item(14, f).Value().ToString + ". "
                    Else
                        cam = ""
                    End If

                    If Len(ListadoGrid.Item(15, f).Value().ToString) > 0 Then
                        pol = "Polo: " + ListadoGrid.Item(15, f).Value().ToString + ". "
                    Else
                        pol = ""
                    End If

                    If Len(ListadoGrid.Item(16, f).Value().ToString) > 0 Then
                        tel = "Tela: " + ListadoGrid.Item(16, f).Value().ToString + ". "
                    Else
                        tel = ""
                    End If
                    If Len(ListadoGrid.Item(17, f).Value().ToString) > 0 Then
                        sue = "Sueter: " + ListadoGrid.Item(17, f).Value().ToString + ". "
                    Else
                        sue = ""
                    End If

                    If Len(ListadoGrid.Item(18, f).Value().ToString) > 0 Then
                        pla = "Playera: " + ListadoGrid.Item(18, f).Value().ToString + ". "
                    Else
                        pla = ""
                    End If

                    If Len(ListadoGrid.Item(19, f).Value().ToString) > 0 Then
                        chu = "Chumpa: " + ListadoGrid.Item(19, f).Value().ToString + ". "
                    Else
                        chu = ""
                    End If

                    If Len(ListadoGrid.Item(20, f).Value().ToString) > 0 Then
                        pan = "Pants: " + ListadoGrid.Item(20, f).Value().ToString + ". "
                    Else
                        pan = ""
                    End If

                    If Len(ListadoGrid.Item(21, f).Value().ToString) > 0 Then
                        cha = "Chaleco: " + ListadoGrid.Item(21, f).Value().ToString + "."
                    Else
                        cha = ""
                    End If

                    If Len(ListadoGrid.Item(22, f).Value().ToString) > 0 Then
                        If S = "F" Then
                            corb = "Pantalón: " + ListadoGrid.Item(22, f).Value().ToString + "."
                        Else
                            corb = "Corbata: " + ListadoGrid.Item(22, f).Value().ToString + "."
                        End If
                    Else
                        corb = ""
                    End If

                    paq = zap + ten + cam + pol + tel + sue + pla + chu + pan + cha + corb

                    fillGrid(ListadoGrid.Item(2, f).Value().ToString + " - " + ListadoGrid.Item(3, f).Value().ToString, _
                                      ListadoGrid.Item(8, f).Value().ToString, paq, ListadoGrid.Item(29, f).Value().ToString)
                    paq = ""
                End If
            End If
        Next
    End Sub

    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        If ListadoGrid.RowCount = 0 Then
        Else
            Dim f, c, memberId As Integer
            c = ListadoGrid.CurrentCellAddress.X
            f = ListadoGrid.CurrentCellAddress.Y
            If c = 1 Then
                memberId = ListadoGrid.Item(2, f).Value()
                irActualizarInfo(memberId.ToString, f)
            End If
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New FeriaUtilesFamiliar
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocumentVale_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentVale.PrintPage
        Dim mIzq As Integer = 30
        Dim y As Integer = 220
        Dim varY As Integer = altoFila
        Dim centro As Integer = 380
        Dim logo As Image = My.Resources.lFU
        Dim famLogo As Image = My.Resources.noFam 'utilesNoFam

        'fonts
        Dim medium As New Font("Calibri", 12, FontStyle.Italic)
        Dim subtit As New Font("Calibri", 10, FontStyle.Underline)
        Dim subtit2 As New Font("Calibri", 6, FontStyle.Underline)
        Dim pieFont As New Font("Calibri", 6)
        Dim grande As New Font("Arial", 20, FontStyle.Bold)

        'Zapatos Negros y Tenis
        Dim za As Integer = 0
        Dim te As Integer = 0
        Dim un As Integer = 0

        Dim blackPen As New Pen(Color.Black, 1) ' contorno.
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Near
        stringFormat.LineAlignment = StringAlignment.Near
        Dim drawFormat As New StringFormat
        drawFormat.Alignment = StringAlignment.Near
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        'encabezado
        e.Graphics.DrawImage(logo, mIzq, 15) 'logo
        e.Graphics.DrawImage(famLogo, mIzq + 638, 20) 'p #Fam
        e.Graphics.DrawString("familia", FamiliaL.Font, Brushes.Black, mIzq + 688, 50)  '+ 678, 40)
        e.Graphics.DrawString(FamiliaV.Text, grande, Brushes.Black, mIzq + 680, 65) '+ 670, 55) 'y - 5)

        Dim rect7 As New Rectangle(centro, 115, 380, 44) 'para centrar Fecha
        Dim rect8 As New Rectangle(centro, 150, 380, 44) 'para centrar Fecha '

        e.Graphics.DrawString(fecha(), medium, Brushes.Black, rect7, stringFormat) ' mIzq, y)
        e.Graphics.DrawString("¡¡¡ No olvide traer su(s) carné(s) cuando visite la Fundación !!! ", medium, Brushes.Black, rect8, stringFormat)

        'Apadrinados
        e.Graphics.DrawString("Apadrinado(s)", subtit, Brushes.Black, mIzq, y)
        y = y + varY

        'Dim n As Integer = 15
        For f = 0 To InvitacionGrid.RowCount - 1
            e.Graphics.DrawString(InvitacionGrid.Item(0, f).Value(), normal, Brushes.Black, mIzq, y) 'apadrinado - nombre
            varY = (altoFila * InvitacionGrid.Item(3, f).Value()) '+ altoFila

            Dim rect5 As New Rectangle(mIzq + 250, y, margenDerecho, varY) 'mIzq + 180
            e.Graphics.DrawString(InvitacionGrid.Item(1, f).Value(), normal, Brushes.Black, rect5, drawFormat) 'paquete

            y = y + varY + 8
        Next

        Dim impres As String = "Impresión: " + U + " (" + DateAndTime.Now.ToLongDateString + ", " + DateAndTime.Now.ToLongTimeString + ")"
        e.Graphics.DrawString(impres, pieFont, Brushes.Black, mIzq, y) 'datos de impresión


        e.Graphics.DrawRectangle(blackPen, 10, 508, 3, 1) 'indica centro hoja
        e.Graphics.PageUnit = GraphicsUnit.Inch
    End Sub

    Private Sub valoresIniciales()
        If FamiliaL.Text = "" Then
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                If S = "M" Then
                    col = "Corbata"
                Else
                    col = "Pantalon"
                End If

                Dim colA As New DataGridViewCheckBoxColumn  'DataGridViewComboBoxColumn
                colA.HeaderText = ""
                colA.Name = "Seleccionar"
                colA.ReadOnly = True
                ListadoGrid.Columns.Add(colA)

                Dim colB As New DataGridViewLinkColumn 'DataGridViewComboBoxColumn
                colB.HeaderText = "Acción"
                colB.Name = "Ingreso"
                ListadoGrid.Columns.Add(colB)

                sql = "SELECT Apadrinado, Nombres, Grado, Estado, Escuela, TipoBolsa, ProximaEscuela, CASE WHEN ZNegros IS NULL THEN 0 ELSE ZNegros END  ZN, " + _
                     "CASE WHEN Tenis IS NULL THEN 0 ELSE Tenis END T, CASE WHEN Uniforme IS NULL THEN 0 ELSE Uniforme END U, CONVERT(NVARCHAR, TallaZN) + '-' + EstiloZN  AS ZapatosNegros, " + _
                        "CONVERT(NVARCHAR, TallaT) + '-' + EstiloT  AS Tenis, TallaBC AS 'Blusa/Camisa', Polo, Tela, Sueter, Playera, Chumpa, Pants, Chaleco, Corbata AS '" + col + "', " + _
                        "Registered Registrado, RegisteredBy 'Usuario', Printed 'Actualizado', Año, NivelActual, ProximoNivel, ProxCarrera, Extra1B " + _
                      "FROM dbo.v_BECA_ActualizaInfoFeriaUtiles " + _
                      "WHERE Project = '" + S + "' AND Familia = " + FamiliaV.Text
                bdGrid(sql, ListadoGrid)
                ListadoGrid.Columns.Item(9).Visible = False 'recibe Znegros
                ListadoGrid.Columns.Item(10).Visible = False 'recibe tenis
                ListadoGrid.Columns.Item(11).Visible = False 'recibe Uniforme
                ''ListadoGrid.Columns.Item(25).Visible = False 'Actualizado
                ''ListadoGrid.Columns.Item(26).Visible = False 'año escolar
                ListadoGrid.Columns.Item(27).Visible = False 'nivel actual
                ListadoGrid.Columns.Item(28).Visible = False 'proximo nivel
                'ListadoGrid.Columns.Item(3).Frozen = True 'columnas congeladas hasta la de nombre

                Dim temp As String
                For i = 0 To ListadoGrid.Rows.Count - 1
                    ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
                    ListadoGrid.Item(1, i).Value = "Actualizar"
                    temp = chequearValor(ListadoGrid.Item(7, i).Value)
                    If temp = "" Then
                    Else
                        ListadoGrid.Item(0, i).Value = True
                    End If
                Next
                ListadoGrid.Visible = True
                ImprimirButton.Visible = True
                FamiliaV.ReadOnly = True
                ApadrinadoV.Visible = False
                ApadrinadoL.Visible = False
                llenarGrid()
            Else
                MsgBox("La familia no es válida", vbQuestion, My.Resources.versionFamilias2)
                FamiliaV.Text = ""
                ApadrinadoV.Text = ""
            End If
        End If
    End Sub
End Class