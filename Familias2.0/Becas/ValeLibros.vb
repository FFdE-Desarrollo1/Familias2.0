' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ValeLibros
    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
    Dim response As MsgBoxResult
    Dim codProv, codLibro, nuevoPrecio As String
    'Dim mediaCarta As New Printing.PaperSize("MediaCarta", 850, 550) ' width, height
    Dim idV As Integer = 0
    Dim reimpresionNota As String = ""
    Dim idVoucher As Integer = 0
    Dim añosHistorial As String = ""
    Dim i As Integer = 0

    Private Sub ValeLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        MiembroV.Focus()

        If Len(MiembroV.Text) > 0 Then
            validaMiembro()
        Else
            PrincipalPanel.Visible = True
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub borrar(ByVal fila As Integer)
        Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
        Dim response As MsgBoxResult
        response = MsgBox("¿Está seguro de borrar el vale de " + HistorialGrid.Item(5, fila).Value + " (" + HistorialGrid.Item(6, fila).Value + ")?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "UPDATE MemberBookVoucher SET RecordStatus = 'H' , ExpirationDateTime = GETDATE(), UserId = '" + U + "'" + _
                     "WHERE RecordStatus = ' ' AND IdVoucher = " + HistorialGrid.Item(0, fila).Value.ToString
            bdEjecutarSQL(sql)
            historialValesLibrosActuales()
        Else
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 And familiaEsValida(S, FamiliaV.Text) = True Then
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        GuardarButton.Visible = False
        If revisarProveedor() = True Then
            If TipoTransV.Text = "0" Then
                'guardar vale
                sql = "SELECT MAX(IdVoucher) Max FROM MemberBookVoucher "
                idV = bdEntero(sql, "Max") + 1
                Dim MyChar() As Char = {"Q", "$"}
                PrecioV.Text = PrecioV.Text.Trim(MyChar)
                ''Replace(Replace(LibroV.Text, "'", "''"), Chr(10), vbNewLine)
                'IdVoucher,CreationDateTime, Project,MemberId,RecordStatus,UserId,ExpirationDateTime,RegisteredDateTime, Provider,BookDescription,Price,PrintDate, DeliveryDate, BookCode
                sql = "INSERT INTO MemberBookVoucher VALUES (" + idV.ToString + ", GETDATE(), '" + S + "', " + MiembroV.Text + ", ' ', '" + U + "', NULL, '" + RegistroPicker.Value.ToString(en.DateTimeFormat) + "', '" + codProv + _
                         "', '#', '" + PrecioV.Text + "', '" + ImpresionPicker.Value.ToString(en.DateTimeFormat) + "', NULL, " + LibroCombo.SelectedValue.ToString + ") "
                bdInsertar(sql)
                'MsgBox(sql)
                sql = "SELECT COUNT(*) Total FROM MemberBookVoucher WHERE IdVoucher = " + idVoucher.ToString
                If bdEntero(sql, "Total") > 0 Then 'nuevo
                    historialValesLibrosActuales()
                    imprimir()
                    listadoLibros()
                    listadoProveedores()
                    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
                    Dim response As MsgBoxResult
                    response = MsgBox("¿Necesita ingresar otro libro para el mismo miembro?", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        limpiarInfoLibro()
                    Else
                        nuevo()
                    End If
                Else
                    MsgBox("Hubo un error al guardarlo", vbInformation, My.Resources.versionFamilias2)
                End If
            ElseIf TipoTransV.Text = "1" Then 'actualizar
                ImpresionPicker.Value = DateTime.Now
                VigenciaPicker.Value = ImpresionPicker.Value.AddDays(7)
                ''"'" + Replace(Replace(LibroV.Text, "'", "''"), Chr(10), vbNewLine) + "'"
                sql = "INSERT INTO MemberBookVoucher " + _
                         "SELECT IdVoucher, GETDATE() CreationDateTime, Project, MemberId, RecordStatus, '" + U + "' UserId, ExpirationDateTime, RegisteredDateTime, " + _
                        "'" + codProv + "' Provider,  '#' BookDescription, Price, '" + ImpresionPicker.Value.ToString(en.DateTimeFormat) + "' PrintDate, DeliveryDate, BookCode " + _
                        "FROM MemberBookVoucher " + _
                        "WHERE RecordStatus = ' ' AND IdVoucher = " + idV.ToString
                bdInsertar(sql)

                sql = "SELECT COUNT(*) Total FROM MemberBookVoucher WHERE IdVoucher = " + idVoucher.ToString
                If bdEntero(sql, "Total") > 0 Then
                    historialValesLibrosActuales()
                    'imprimir()

                    Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
                    Dim response As MsgBoxResult
                    response = MsgBox("¿Necesita ingresar otro libro para el mismo miembro?", style, My.Resources.versionFamilias2)
                    If response = MsgBoxResult.Yes Then
                        limpiarInfoLibro()
                    Else
                        nuevo()
                    End If
                Else

                End If
            End If
        End If
    End Sub

    Private Sub HistorialActividades()
        limpiarGrid()
        sql = "SELECT cdMAT.DescSpanish AS ACTIVIDAD, dbo.fn_GEN_FormatDate(MA.ActivityDateTime, 'ES') AS Fecha, MA.Notes AS Observaciones, MA.UserId AS Usuario " + _
              "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdMAT ON MA.Type = cdMAT.Code " + _
              "WHERE MA.RecordStatus = ' ' AND cdMAT.FunctionalArea = 'EDUC' AND Type = 'LIBR' AND MA.Project = '" + S + "' AND YEAR(MA.ActivityDateTime) IN " + añosHistorial + " AND MA.MemberId = " + MiembroV.Text + _
              " ORDER BY MA.ActivityDateTime DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialActividadesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialActividadesCheck.CheckedChanged
        If HistorialActividadesCheck.Checked = True Then
            HistorialActividades()
            ValesActualesCheckBox.Checked = False
            HistorialValeLibrosCheck.Checked = False
            HistorialReembolsosCheck.Checked = False
        End If
    End Sub

    Private Sub HistorialGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialGrid.CellContentClick
        Dim fila As Integer = HistorialGrid.CurrentCellAddress.Y()
        Dim columna As Integer = HistorialGrid.CurrentCellAddress.X()
        If Len(chequearValor(HistorialGrid.Item(9, fila).Value)) = 0 Then 'Verifica si tiene fecha entrega
            If columna = 3 Then
                borrar(fila)
            ElseIf columna = 4 Then
                reimprimir(fila)
            ElseIf columna = 5 Then
                valeSeleccionado(fila)
            Else

            End If
        Else
            MsgBox("Este libro ya fue entregado" + vbNewLine + _
                          "No se puede hacer cambios, borrar o reimprimir", vbInformation, My.Resources.versionFamilias2)
        End If


    End Sub

    Private Sub HistorialReembolsos()
        limpiarGrid()
        sql = "SELECT Tipo, Autorizado, Pagado, Cantidad Total, [Cantidad Aprobada] Aprobado, Porcentaje, AprobadoPor, Observaciones " + _
              "FROM dbo.fn_GEN_HistorialPagos('" + S + "', " + MiembroV.Text + ") " + _
              "WHERE Tipo IN ('Libros', 'Otro (Educación)')  AND  YEAR(FechaA) IN " + añosHistorial + "  AND Area = 'EDUC' " + _
              "ORDER BY Tipo, FechaA DESC "
        bdGrid(sql, HistorialGrid)
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub HistorialReembolsosCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialReembolsosCheck.CheckedChanged
        If HistorialReembolsosCheck.Checked = True Then
            HistorialReembolsos()
            ValesActualesCheckBox.Checked = False
            HistorialValeLibrosCheck.Checked = False
            HistorialActividadesCheck.Checked = False
        End If
    End Sub

    Private Sub historialValesLibrosActuales()
        limpiarGrid()
        sql = "SELECT IdVoucher 'No.Vale', CONVERT(varchar, RegisteredDateTime, 20) R, CONVERT(varchar, PrintDate, 20) P, 'Borrar' ' ', 'Reimprimir' '  ', " + _
                 "CASE WHEN MBV.BookDescription = '#' THEN dbo.CdBook.BookName ELSE MBV.BookDescription END Libro, " + _
                 "cdP.DescSpanish  Proveedor, dbo.fn_GEN_FormatDate(RegisteredDateTime, 'es') + ' ' + " + _
                 "CONVERT(varchar, RegisteredDateTime, 108) Registro,  dbo.fn_GEN_FormatDate(PrintDate, 'es') + ' ' + " + _
                 "CONVERT(varchar, PrintDate, 108) Impresión, dbo.fn_GEN_FormatDate(DeliveryDate, 'es') + ' ' + " + _
                 "CONVERT(varchar, DeliveryDate, 108) Entrega, ROUND(MBV.Price, 2) Precio,  MBV.UserId Usuario, " + _
                 "CASE WHEN CONVERT(varchar, RegisteredDateTime, 20) = CONVERT(varchar, PrintDate, 20) THEN '' ELSE 'Tiene Reimpresión'  END  '   ' " + _
                 "FROM MemberBookVoucher MBV INNER JOIN CdProvider cdP ON MBV.Provider = cdP.Code " + _
                 "LEFT OUTER JOIN dbo.CdBook ON MBV.BookCode = dbo.CdBook.Code " + _
                 "WHERE MBV.Memberid = " + MiembroV.Text + " AND MBV.RecordStatus = ' ' AND MBV.Project = '" + S + "' AND YEAR(RegisteredDateTime) = " + Now.Year.ToString + _
                 "ORDER BY IdVoucher DESC "
        bdGrid(sql, HistorialGrid)
        'InputBox("", "", sql)
        'HistorialGrid.Columns.Item(0).Visible = False
        HistorialGrid.Columns.Item(1).Visible = False
        HistorialGrid.Columns.Item(2).Visible = False
        agregarColumnaAccion(3, HistorialGrid)
        agregarColumnaAccion(4, HistorialGrid)
        HistorialGrid.Columns(10).DefaultCellStyle.Format = "c"
        HistorialGrid.ClearSelection()
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub historialValesLibros()
        limpiarGrid()
        sql = "SELECT IdVoucher 'No.Vale', CONVERT(varchar, RegisteredDateTime, 20) R, CONVERT(varchar, PrintDate, 20) P, 'Borrar' ' ', 'Reimprimir' '  ', " + _
                 "CASE WHEN MBV.BookDescription = '#' THEN dbo.CdBook.BookName ELSE MBV.BookDescription END Libro, " + _
                 "cdP.DescSpanish  Proveedor, dbo.fn_GEN_FormatDate(RegisteredDateTime, 'es') + ' ' + " + _
                 "CONVERT(varchar, RegisteredDateTime, 108) Registro,  dbo.fn_GEN_FormatDate(PrintDate, 'es') + ' ' + " + _
                 "CONVERT(varchar, PrintDate, 108) Impresión, dbo.fn_GEN_FormatDate(DeliveryDate, 'es') + ' ' + " + _
                 "CONVERT(varchar, DeliveryDate, 108) Entrega, ROUND(MBV.Price, 2) Precio,  MBV.UserId Usuario, " + _
                 "CASE WHEN CONVERT(varchar, RegisteredDateTime, 20) = CONVERT(varchar, PrintDate, 20) THEN '' ELSE 'Tiene Reimpresión'  END  '   ' " + _
                 "FROM MemberBookVoucher MBV INNER JOIN CdProvider cdP ON MBV.Provider = cdP.Code " + _
                 "LEFT OUTER JOIN dbo.CdBook ON MBV.BookCode = dbo.CdBook.Code " + _
                 "WHERE MBV.Memberid = " + MiembroV.Text + " AND MBV.RecordStatus = ' ' AND MBV.Project = '" + S + "' " + _
                 "ORDER BY IdVoucher DESC "
        bdGrid(sql, HistorialGrid)
        'InputBox("", "", sql)
        'HistorialGrid.Columns.Item(0).Visible = False
        HistorialGrid.Columns.Item(1).Visible = False
        HistorialGrid.Columns.Item(2).Visible = False
        agregarColumnaAccion(3, HistorialGrid)
        agregarColumnaAccion(4, HistorialGrid)
        HistorialGrid.Columns(10).DefaultCellStyle.Format = "c"
        HistorialGrid.ClearSelection()
        HistorialGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        HistorialGrid.AutoResizeColumns()
        HistorialGrid.Visible = True
    End Sub

    Private Sub ValesActualesCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ValesActualesCheckBox.CheckedChanged
        If ValesActualesCheckBox.Checked = True Then
            historialValesLibrosActuales()
            HistorialValeLibrosCheck.Checked = False
            HistorialActividadesCheck.Checked = False
            HistorialReembolsosCheck.Checked = False
        End If
    End Sub

    Private Sub HistorialValeLibrosCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialValeLibrosCheck.CheckedChanged
        If HistorialValeLibrosCheck.Checked = True Then
            historialValesLibros()
            ValesActualesCheckBox.Checked = False
            HistorialActividadesCheck.Checked = False
            HistorialReembolsosCheck.Checked = False
        End If
    End Sub

    Private Sub imprimir()
        If Len(ProveedorCombo.Text) > 0 And Len(LibroCombo.Text) > 0 Then
            Dim PrintDialog1 As New PrintDialog()
            PrintDialog1.Document = PrintDocumentVale
            'Dim result As DialogResult = PrintDialog1.ShowDialog()

            PrintPreviewDialogVale.Document = PrintDocumentVale
            'PrintDocumentVale.DefaultPageSettings.PaperSize = mediaCarta
            PrintPreviewDialogVale.ShowDialog() 'open the print preview
        Else
            MsgBox("Error", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub infoGen()
        Dim listTable As New DataTable
        Dim secc As String = ""
        sql = "SELECT * " + _
                 "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + AñoV.Text + ") L "
        bdDataTable(sql, listTable)
        i = 1
        For f = 0 To listTable.Rows.Count - 1
            'Info General
            NombreV.Text = listTable.Rows(f)("Nombres") + " " + listTable.Rows(f)("Apellidos")
            EdadV.Text = " - " + chequearValor(listTable.Rows(f)("Edad"))
            FamiliaV.Text = listTable.Rows(f)("Familia")
            FamiliaV.ReadOnly = True
            TSV.Text = chequearValor(listTable.Rows(0)("TS"))

            If esApadrinado(S, MiembroV.Text) = True Then
                ' Info Educ
                Dim carrera = chequearValor(listTable.Rows(0)("Carrera"))
                Dim complemento As String = ""

                If Len(carrera) > 1 Then
                    complemento = complemento + " (" + carrera + ")"
                End If
                GradoV.Text = chequearValor(listTable.Rows(0)("Estado_Educ")) + " " + chequearValor(listTable.Rows(0)("Grado")) + complemento
                EscuelaV.Text = chequearValor(listTable.Rows(0)("Escuela"))

            End If
        Next

        MiembroV.Enabled = False
        PanelSecundario.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, FamiliaV.Text) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "VALI"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbInformation, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub LibroCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LibroCombo.SelectedIndexChanged
        If LibroCombo.Items.Count > 0 Then
            If LibroCombo.SelectedIndex = -1 Then
            Else
                If Len(LibroCombo.SelectedValue.ToString) > 0 And Len(LibroCombo.SelectedValue.ToString) < 10 Then
                    sql = "SELECT CASE WHEN Price IS NULL THEN 0 ELSE Price END Precio FROM CdBook WHERE Code = " + LibroCombo.SelectedValue.ToString + ""
                    Dim precio = bdDoble(sql, "Precio")
                    PrecioV.Text = FormatCurrency(precio.ToString)
                End If
            End If
        End If
    End Sub

    Private Sub LimpiarButton_Click(sender As Object, e As EventArgs) Handles LimpiarButton.Click
        limpiarInfoLibro()
    End Sub

    Private Sub limpiarGrid()
        HistorialGrid.DataSource = Nothing
        HistorialGrid.Rows.Clear()
        HistorialGrid.Visible = False
    End Sub

    Private Sub limpiarInfoLibro()
        ProveedorCombo.Text = ""
        'LibroV.Text = ""
        LibroCombo.Text = ""
        PrecioV.Text = ""
        RegistroPicker.Value = DateTime.Now
        ImpresionPicker.Value = DateTime.Now
        VigenciaPicker.Value = ImpresionPicker.Value.AddDays(7)
        TipoTransV.Text = "0"
        GuardarButton.Visible = True
        EtiquetaL.Text = "Nuevo Vale - Libro"
        reimpresionNota = ""
    End Sub

    Private Sub listadoLibros()
        LibroCombo.DataSource = Nothing
        sql = "SELECT Code, BookName Libro " + _
         "FROM dbo.cdBook  " + _
         "WHERE Project = '" + S + "' AND Active = 1 AND YearBook = " + Now.Year.ToString + " " + _
         "ORDER BY BookName "
        bdCombo(sql, LibroCombo, "Code", "Libro")

    End Sub

    Private Sub listadoProveedores()
        ProveedorCombo.DataSource = Nothing
        sql = "SELECT Code, DescSpanish Proveedor " + _
         "FROM dbo.CdProvider  " + _
         "WHERE Project = '" + S + "' AND FunctionalArea = 'EDUC' AND Active = 1 " + _
         "ORDER BY DescSpanish "
        bdCombo(sql, ProveedorCombo, "Code", "Proveedor")
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            validaMiembro()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub nuevo()
        Dim nxt As New ValeLibros
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        nuevo()
    End Sub

    Private Sub PrintDocumentVale_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentVale.PrintPage
        Dim type As String = "Arial"
        Dim typeT As String = "Arial Narrow"
        Dim normal As New Font(type, 11, FontStyle.Regular)
        Dim cursiva As New Font(type, 11, FontStyle.Italic)
        Dim titulo As New Font(type, 12, FontStyle.Bold)
        Dim titulo2 As New Font(type, 11, FontStyle.Bold)
        Dim subtitulo As New Font(type, 12, FontStyle.Italic)
        Dim imp As New Font(typeT, 8, FontStyle.Italic)
        Dim yPos As Single = normal.GetHeight(e.Graphics)
        Dim yNew As Integer
        Dim mIzq As Integer = 50

        'Dim margenIzq As Single = e.MarginBounds.Left
        'Dim margenDer As Single = e.MarginBounds.Right
        Dim ancho As Single = e.PageBounds.Width - (mIzq * 2) 'margenDer - margenIzq
        Dim centro As Single = e.PageBounds.Width / 2

        Dim centradoFormat As New StringFormat
        centradoFormat.Alignment = StringAlignment.Center

        Dim izqFormat As New StringFormat
        izqFormat.Alignment = StringAlignment.Near

        Dim derFormat As New StringFormat
        derFormat.Alignment = StringAlignment.Far

        'Encabezado
        Dim recuadro
        Dim logo As Image = My.Resources.CH_Heart_CMYK  'logo
        Dim centroImagen As Single = centro - logo.Width
        e.Graphics.DrawImage(logo, 200, 10) 'logo
        recuadro = New Rectangle(mIzq, 20, ancho, 22)
        e.Graphics.DrawString("FUNDACION FAMILIAS DE ESPERANZA", titulo, Brushes.Black, recuadro, centradoFormat)
        recuadro = New Rectangle(mIzq, 35, ancho, 20)
        e.Graphics.DrawString("Administración de Becas", subtitulo, Brushes.Black, recuadro, centradoFormat)
        recuadro = New Rectangle(mIzq, 50, ancho, 18)
        e.Graphics.DrawString("Km. 2 Carretera a San Juan del Obispo", normal, Brushes.Black, recuadro, centradoFormat)
        recuadro = New Rectangle(mIzq, 65, ancho, 18)
        e.Graphics.DrawString("Antigua Guatemala, Sacatepéquez", normal, Brushes.Black, recuadro, centradoFormat)
        recuadro = New Rectangle(mIzq, 80, ancho, 18)
        e.Graphics.DrawString("Tel. 7922-6600          NIT 755686-1", normal, Brushes.Black, recuadro, centradoFormat)
        recuadro = New Rectangle(mIzq, 110, ancho, 20)
        e.Graphics.DrawString("Vale para libros No." + idV.ToString, titulo, Brushes.Black, recuadro, derFormat)
        recuadro = New Rectangle(mIzq, 125, ancho, 22)
        e.Graphics.DrawString(reimpresionNota, cursiva, Brushes.Black, recuadro, derFormat)

        'Info. general
        recuadro = New Rectangle(mIzq, 150, ancho, 18)
        e.Graphics.DrawString(S + " " + FamiliaV.Text, normal, Brushes.Black, recuadro, derFormat)
        e.Graphics.DrawString("Nombre: ", cursiva, Brushes.Black, mIzq, yPos + 150)
        e.Graphics.DrawString("               " + NombreV.Text + " (" + MiembroV.Text + ")", normal, Brushes.Black, mIzq, yPos + 150)
        e.Graphics.DrawString("Grado: ", cursiva, Brushes.Black, mIzq, yPos + 165)
        recuadro = New Rectangle(mIzq + 60, yPos + 165, ancho, 70)
        e.Graphics.DrawString(GradoV.Text + " - " + EscuelaV.Text, normal, Brushes.Black, recuadro, izqFormat)
        'Detalle
        yNew = 200
        e.Graphics.DrawString("Proveedor: ", cursiva, Brushes.Black, mIzq, yPos + yNew)
        e.Graphics.DrawString("                 " + ProveedorCombo.Text, titulo, Brushes.Black, mIzq, yPos + yNew)
        e.Graphics.DrawString("Precio", cursiva, Brushes.Black, 600, yPos + yNew)
        e.Graphics.DrawString("          Q." + PrecioV.Text, titulo, Brushes.Black, 600, yPos + yNew)

        yNew = yNew + 20
        e.Graphics.DrawString("Libro: ", cursiva, Brushes.Black, mIzq, yPos + yNew)
        recuadro = New Rectangle(mIzq + 45, yPos + yNew, ancho - 40, 100)
        e.Graphics.DrawString(LibroCombo.Text, titulo, Brushes.Black, recuadro, izqFormat)

        yNew = yNew + 160
        recuadro = New Rectangle(mIzq, yPos + yNew, ancho, 80)
        e.Graphics.DrawString("Firma de recibido", cursiva, Brushes.Black, recuadro, centradoFormat)

        yNew = yNew + 15
        recuadro = New Rectangle(mIzq, yPos + yNew, ancho, 80)
        e.Graphics.DrawString("Válido hasta " + VigenciaPicker.Text, titulo, Brushes.Black, recuadro, centradoFormat)

        e.Graphics.DrawString(U + " -  " + ImpresionPicker.Value.ToShortDateString + " " + ImpresionPicker.Value.ToShortTimeString, imp, Brushes.Black, mIzq, 460)



        e.Graphics.PageUnit = GraphicsUnit.Inch
    End Sub

    Private Sub PrecioV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub reimprimir(ByVal fila As Integer)
        valeSeleccionado(fila)
        EtiquetaL.Text = "Reimpresión Vale - Libro"
        ImpresionPicker.Value = DateTime.Now
        VigenciaPicker.Value = ImpresionPicker.Value.AddDays(7)

        sql = "INSERT INTO MemberBookVoucher " + _
                 "SELECT IdVoucher, GETDATE() CreationDateTime, Project, MemberId, RecordStatus, '" + U + "' UserId, ExpirationDateTime, RegisteredDateTime, " + _
                "Provider, BookDescription, Price, '" + ImpresionPicker.Value.ToString(en.DateTimeFormat) + "' PrintDate, DeliveryDate, BookCode " + _
                "FROM MemberBookVoucher " + _
                "WHERE RecordStatus = ' ' AND IdVoucher = " + idV.ToString
        bdInsertar(sql)
        reimpresionNota = "REIMPRESIÓN POR PÉRDIDA"
        historialValesLibrosActuales()
        imprimir()
        limpiarInfoLibro()
    End Sub

    Private Function revisarLibro() As Boolean
        'codLibro = LibroCombo.SelectedValue
        If Len(codLibro) = 0 Then
            sql = "SELECT COUNT(*) Total FROM CdBook WHERE BookName = '" + LibroCombo.Text + "' AND YearBook = " + Now.Year.ToString
            Dim n = bdEntero(sql, "Total")
            If n = 0 Then
                response = MsgBox("El libro no existe." + vbNewLine + "¿Quiere guardarlo?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    revisarLibro = True
                    Dim año = Now.Year.ToString
                    Dim codigo As String
                    sql = "SELECT  MAX(CONVERT(int, Code)) AS Code FROM dbo.CdBook"
                    codigo = (bdEntero(sql, "Code") + 1).ToString
                    nuevoPrecio = InputBox("Nuevo libro" + vbCrLf + "   (presione ACEPTAR al ingresar el precio)", My.Resources.versionFamilias2, "0.00")

                    sql = "INSERT INTO CdBook VALUES ('" + codigo + "'," + año + ", '" + LibroCombo.Text + "'," + nuevoPrecio.ToString + ", 1, '" + S + "')"
                    bdInsertar(sql)
                    'InputBox("", "", sql)
                    listadoLibros()
                    LibroCombo.SelectedValue = codigo
                Else
                    revisarLibro = False
                End If
            Else
                MsgBox("El libro ya existe" + vbCrLf + "Revise el listado :)", MsgBoxStyle.Information, My.Resources.versionFamilias2)
                LibroCombo.Text = ""
                revisarLibro = True
            End If
        Else
            revisarLibro = True
        End If
    End Function

    Private Function revisarProveedor() As Boolean
        codProv = ProveedorCombo.SelectedValue
        If Len(codProv) = 0 Then
            sql = "SELECT COUNT(*) Total FROM CdProvider WHERE DescSpanish = '" + ProveedorCombo.Text + "'"
            Dim n = bdEntero(sql, "Total")

            If n = 0 Then
                response = MsgBox("El proveedor no existe." + vbNewLine + "¿Quiere guardarlo?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    revisarProveedor = True
                    sql = " SELECT MAX(CONVERT(int, REPLACE(Code,'P','')))  Id " + _
                                      "FROM dbo.CdProvider WHERE FunctionalArea = 'EDUC' and project = '" + S + "'"
                    codProv = "P" + (bdEntero(sql, "Id") + 1).ToString

                    sql = "INSERT INTO CdProvider VALUES ('" + codProv + "', '" + ProveedorCombo.Text + "', '" + ProveedorCombo.Text + "', 1, 'EDUC', '" + S + "')"
                    bdInsertar(sql)
                Else
                    revisarProveedor = False
                End If
            Else
                revisarProveedor = True
            End If
        Else
            revisarProveedor = True
        End If
    End Function

    Private Sub valeSeleccionado(ByVal fila As Integer)
        limpiarInfoLibro()
        EtiquetaL.Text = "Actualización Vale - Libro"
        idV = HistorialGrid.Item(0, fila).Value
        ProveedorCombo.Text = HistorialGrid.Item(6, fila).Value
        LibroCombo.Text = HistorialGrid.Item(5, fila).Value
        RegistroPicker.Value = HistorialGrid.Item(1, fila).Value
        ImpresionPicker.Value = HistorialGrid.Item(2, fila).Value
        VigenciaPicker.Value = ImpresionPicker.Value.AddDays(7)
        PrecioV.Text = chequearValor(HistorialGrid.Item(10, fila).Value) '.Remove(0, 1)
        TipoTransV.Text = "1"
    End Sub

    Private Sub validaMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            If esApadrinado(S, MiembroV.Text) = True Then
                valoresIniciales()
            Else
                MsgBox("Esta pantalla es solo para apadrinados", vbQuestion, My.Resources.versionFamilias2)
                MiembroV.Text = ""
                FamiliaV.Text = ""
            End If
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        listadoLibros()
        listadoProveedores()

        sql = "SELECT dbo.fn_BECA_añoFeriaUtiles() AS Año "
        Dim año = bdEntero(sql, "Año")
        AñoV.Text = año.ToString
        añosHistorial = "(" + año.ToString + ", " + (año - 1).ToString + ", " + (año - 2).ToString + ") "

        'información general
        infoGen()

        'If Len(GradoV.Text) > 0 Then
        ValesActualesCheckBox.Checked = True
        LibrosTable.Visible = True
        GuardarButton.Visible = True
        LibroCombo.Focus()
        VigenciaPicker.Value = ImpresionPicker.Value.AddDays(7)
        EtiquetaL.Text = "Nuevo Vale - Libro"
        'Else
        '    MsgBox("El apadrinado no tiene nuevo año escolar " + AñoV.Text, vbInformation, My.Resources.versionFamilias2)
        'End If
    End Sub

    Private Sub VerificaLibroL_Click(sender As Object, e As EventArgs) Handles VerificaLibroL.Click
        revisarLibro()
    End Sub
End Class