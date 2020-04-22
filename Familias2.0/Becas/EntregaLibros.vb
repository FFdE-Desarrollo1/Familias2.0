' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class EntregaLibros
    Dim entrega, createDT As DateTime

    Private Sub EntregaLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub actualizar(ByVal id As Integer, ByVal miembro As Integer)
        createDT = DateTime.Now
        'Ingresar fecha entrega
        sql = "INSERT INTO MemberBookVoucher " + _
                 "SELECT IdVoucher, '" + createDT.ToString(en.DateTimeFormat) + "' CreationDateTime, Project, MemberId, RecordStatus, '" + U + "' UserId, ExpirationDateTime, RegisteredDateTime, " + _
                 "Provider, BookDescription, Price, PrintDate, '" + entrega.ToString(en.DateTimeFormat) + "' DeliveryDate, BookCode " + _
                 "FROM MemberBookVoucher " + _
                 "WHERE RecordStatus = ' ' AND IdVoucher = " + id.ToString
        bdInsertar(sql)

        'Ingresar Actividad
        sql = "SELECT COUNT(*) Total FROM MemberActivity WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + miembro.ToString + " AND Type = 'LIBR' " + _
                 " AND YEAR(ActivityDateTime) = " + entrega.Year.ToString() + " AND MONTH(ActivityDateTime) = " + entrega.Month.ToString + " AND DAY(ActivityDateTime) = " + entrega.Day.ToString + " "

        If bdEntero(sql, "Total") = 0 Then
            sql = "INSERT INTO MemberActivity VALUES('" + S + "', " + miembro.ToString + ", 'LIBR', '" + entrega.ToString(en.DateTimeFormat) + "' , '" + entrega.ToString(en.DateTimeFormat) + "', " + _
                     "' ', '" + U + "', NULL, '')"
            bdInsertar(sql)
        End If

    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub GenerarButton_Click(sender As Object, e As EventArgs) Handles GenerarButton.Click
        limpiarGrid()
        Dim col As New DataGridViewCheckBoxColumn
        col.HeaderText = "Seleccionar"
        ListadoGrid.Columns.Add(col)

        Dim prov As String
        If Len(ProveedorCombo.Text) > 1 Then
            prov = " AND MBV.Provider  =  '" + ProveedorCombo.SelectedValue + "'"
        Else
            prov = ""
        End If

        sql = "SELECT IdVoucher 'No.Vale',  MBV.MemberId Apadrinado, M.FirstNames + ' ' + M.LastNames Nombres, " + _
                 "CASE WHEN MBV.BookDescription = '#' THEN dbo.CdBook.BookName ELSE MBV.BookDescription END Libro, " + _
                 "cdP.DescSpanish  Proveedor, dbo.fn_GEN_FormatDate(RegisteredDateTime, 'es') + ' ' + CONVERT(varchar, RegisteredDateTime, 108) Registro,  " + _
                 "dbo.fn_GEN_FormatDate(PrintDate, 'es') + ' ' + CONVERT(varchar, PrintDate, 108) Impresión, " + _
                 "dbo.fn_GEN_FormatDate(DeliveryDate, 'es') + ' ' + CONVERT(varchar, DeliveryDate, 108) Entrega, ROUND(MBV.Price, 2) 'Precio Q',  MBV.UserId Usuario " + _
                 "FROM MemberBookVoucher MBV INNER JOIN CdProvider cdP ON MBV.Provider = cdP.Code " + _
                 "INNER JOIN Member M  ON M.Project = MBV.Project AND MBV.MemberId = M.MemberId AND MBV.RecordStatus = M.RecordStatus " + _
                 "LEFT OUTER JOIN dbo.CdBook ON MBV.BookCode = dbo.CdBook.Code " + _
                 "WHERE MBV.DeliveryDate IS NULL AND MBV.RecordStatus = ' ' AND MBV.Project = '" + S + "' AND (CAST(CONVERT(NVARCHAR, RegisteredDateTime, 112) AS smallDateTime) " + _
                 "BETWEEN CAST(CONVERT(NVARCHAR, '" + DeFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime) AND " + _
                 "CAST(CONVERT(NVARCHAR, '" + AFecha.Value.ToString(en.DateTimeFormat) + "', 112) AS smallDateTime)) " + prov + " " + _
                 "ORDER BY IdVoucher "
        bdGrid(sql, ListadoGrid)
        'ListadoGrid.Columns.Item(1).Visible = False
        ListadoGrid.Columns(9).DefaultCellStyle.Format = "N2" '"c"
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()
        For i = 1 To ListadoGrid.ColumnCount - 1
            ListadoGrid.Columns(i).ReadOnly = True
        Next
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
        ListadoGrid.Visible = True
        TotalL.Visible = True
        GuardarButton.Visible = True
        SelTodosCheck.Visible = True
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        entrega = DateTime.Now
        For f = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid.Item(0, f).Value = True Then
                actualizar(ListadoGrid.Item(1, f).Value, ListadoGrid.Item(2, f).Value)
            End If
        Next
        revisarlistado()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiarGrid()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Columns.Clear()
        ListadoGrid.Visible = False
        TotalL.Visible = False
        SelTodosCheck.Visible = False
        TotalL.Text = ""
    End Sub

    Private Sub revisarlistado()
        limpiarGrid()
        sql = "SELECT  MBV.MemberId Apadrinado, M.FirstNames Nombres, " + _
                 "CASE WHEN MBV.BookDescription = '#' THEN dbo.CdBook.BookName ELSE MBV.BookDescription END Libro, " + _
                 "cdP.DescSpanish  Proveedor, dbo.fn_GEN_FormatDate(RegisteredDateTime, 'es') + ' ' + CONVERT(varchar, RegisteredDateTime, 108) Registro,  " + _
                 "dbo.fn_GEN_FormatDate(PrintDate, 'es') + ' ' + CONVERT(varchar, PrintDate, 108) Impresión, " + _
                 "dbo.fn_GEN_FormatDate(DeliveryDate, 'es') + ' ' + CONVERT(varchar, DeliveryDate, 108) Entrega, ROUND(MBV.Price, 2) Precio,  MBV.UserId Usuario, IDVoucher 'No. Vale' " + _
                 "FROM MemberBookVoucher MBV INNER JOIN CdProvider cdP ON MBV.Provider = cdP.Code " + _
                 "INNER JOIN Member M  ON M.Project = MBV.Project AND MBV.MemberId = M.MemberId AND MBV.RecordStatus = M.RecordStatus " + _
                 "LEFT OUTER JOIN dbo.CdBook ON MBV.BookCode = dbo.CdBook.Code " + _
                 "WHERE MBV.RecordStatus = ' ' AND MBV.Project = '" + S + "' AND CONVERT(DateTime, MBV.DeliveryDate) " + _
                 "= CAST(CONVERT(NVARCHAR, '" + entrega.ToString(en.DateTimeFormat) + "', 112) AS DateTime)  " + _
                 "ORDER BY IDVoucher "

        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns(8).DefaultCellStyle.Format = "c"
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListadoGrid.AutoResizeColumns()
        For i = 0 To ListadoGrid.ColumnCount - 1
            ListadoGrid.Columns(i).ReadOnly = True
        Next
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
        ListadoGrid.Visible = True
        TotalL.Visible = True
    End Sub

    Private Sub SelTodosCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelTodosCheck.CheckedChanged
        For f = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Item(0, f).Value = SelTodosCheck.Checked
        Next
    End Sub

    Private Sub valoresIniciales()
        DeFecha.Value = Today
        AFecha.Value = Today

        sql = "SELECT Code, DescSpanish Proveedor FROM dbo.CdProvider  " + _
                 "WHERE Project = '" + S + "' AND FunctionalArea = 'EDUC' AND Active = 1 " + _
                 "ORDER BY DescSpanish "
        bdCombo(sql, ProveedorCombo, "Code", "Proveedor")
    End Sub


End Class