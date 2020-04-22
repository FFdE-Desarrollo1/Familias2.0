' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class PagoPlanillas
    Dim total As Double
    Dim actual As DateTime

    Private Sub PagoPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub Cronometro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cronometro.Tick
        barraProgreso.Value = barraProgreso.Value + 1
        If barraProgreso.Value = 100 Then
            Cronometro.Stop()
            barraProgreso.Visible = False
            planillaPagada()
        End If
    End Sub

    Private Sub GenerarButton_Click(sender As Object, e As EventArgs) Handles GenerarButton.Click
        planillaPendiente()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(NoChequeV.Text) > 0 Then
            barraProgreso.Visible = True
            Cronometro.Start()
            actual = DateTime.Now
            Dim isCheck As New CheckBox
            If porPagarGrid.RowCount > 0 Then
                For Each r As DataGridViewRow In porPagarGrid.Rows
                    isCheck.Checked = porPagarGrid.Item(0, r.Index).Value()
                    If isCheck.Checked = True Then
                        pagoReembolso(Integer.Parse(porPagarGrid.Item(2, r.Index).Value), porPagarGrid.Item(1, r.Index).Value, _
                              porPagarGrid.Item(4, r.Index).Value, porPagarGrid.Item(6, r.Index).Value)
                    End If
                Next
            End If
        Else
            MsgBox("Necesita ingresar el No. Cheque", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New PagoPlanillas
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub pagoReembolso(ByVal miembro As Integer, ByVal tipo As String, fechaAutorizado As String, ByVal cantidad As String)
        sql = "UPDATE  dbo.MemberReimbursement SET  ReimbursementDateTime = '" + actual.ToString(en.DateTimeFormat) + "', " + _
                    "CheckNumber = '" + NoChequeV.Text + "', ReimbursementBy = '" + U + "' " + _
                    "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND ReimbursementDateTime IS NULL " + _
                    "AND MemberId = " + miembro.ToString + " AND Type = '" + tipo + "' AND CONVERT(varchar, ApprovedDateTime, 21)  = '" + _
                    fechaAutorizado + "' AND CONVERT(money, ApprovedAmount, 1) = " + cantidad.ToString + " "
        bdInsertar(sql)
    End Sub

    Private Sub planillaPagada()
        ' principalTable.GetControlFromPosition(0, 0).Visible = False 'colIndex, rowIndex
        '  principalTable.GetControlFromPosition(1, 0).Visible = False 'colIndex, rowIndex
        principalTable.ColumnStyles(0).Width = 0

        ' principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))

        pagoOpTable.Width = 0
        porPagarGrid.Width = 0
        ' porPagarGrid.Visible = False
        opcionesTable.Visible = False
        ' pagoOpTable.Visible = False

        Dim nCheck As Integer
        sql = "SELECT COUNT(*) AS Total " + _
                   "FROM dbo.MemberReimbursement MR INNER JOIN dbo.Member M ON M.Project = MR.Project AND M.RecordStatus = MR.RecordStatus " + _
                    " AND M.MemberId = MR.MemberId INNER JOIN dbo.MemberEducationYear MEY ON MEY.Project = M.Project AND MEY.MemberId = M.MemberId " + _
                    " AND MEY.RecordStatus = M.RecordStatus AND MEY.SchoolYear = " + AñoV.Text + " INNER JOIN dbo.CdReimbursementType cdT  ON MR.Type = cdT.Code " + _
                    " INNER JOIN dbo.School S ON MEY.RecordStatus = S.RecordStatus AND MEY.Project = S.Project AND MEY.SchoolCode = S.Code " + _
                   "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND MR.ReimbursementDateTime = '" + actual.ToString(en.DateTimeFormat) + "' AND MR.CheckNumber = '" + _
                     NoChequeV.Text + "' AND MR.ReimbursementBy = '" + U + "' "
        nCheck = bdEntero(sql, "Total")
        If nCheck > 0 Then
            porPagarGrid.Visible = False
            NoChequeL.Visible = False
            NoChequeV.Visible = False
            GuardarButton.Visible = False

            sql = "SELECT MR.MemberId AS 'No. Miembro', M.FirstNames + ' ' + M.LastNames AS Nombre, dbo.fn_GEN_FormatDate(MR.ApprovedDateTime, 'ES') 'Fecha Aprobada', cdT.DescSpanish AS Tipo, " + _
                        " CONVERT(money, MR.ApprovedAmount, 1) Aprobado, MR.ApprovedBy AS Aprobó, S.Name AS Establecimiento, dbo.fn_GEN_FormatDate(MR.ReimbursementDateTime, 'ES')  AS Pagado, MR.CheckNumber AS 'No. Cheque' " + _
                       "FROM dbo.MemberReimbursement MR INNER JOIN dbo.Member M ON M.Project = MR.Project AND M.RecordStatus = MR.RecordStatus " + _
                        " AND M.MemberId = MR.MemberId INNER JOIN dbo.MemberEducationYear MEY ON MEY.Project = M.Project AND MEY.MemberId = M.MemberId " + _
                        " AND MEY.RecordStatus = M.RecordStatus AND MEY.SchoolYear = " + AñoV.Text + " INNER JOIN dbo.CdReimbursementType cdT  ON MR.Type = cdT.Code " + _
                        " INNER JOIN dbo.School S ON MEY.RecordStatus = S.RecordStatus AND MEY.Project = S.Project AND MEY.SchoolCode = S.Code " + _
                       "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND MR.ReimbursementDateTime = '" + actual.ToString(en.DateTimeFormat) + "' AND MR.CheckNumber = '" + _
                         NoChequeV.Text + "' AND MR.ReimbursementBy = '" + U + "' "
            bdGrid(sql, pagadosGrid)
            If porPagarGrid.RowCount > 0 Then
                For Each r As DataGridViewRow In pagadosGrid.Rows
                    pagadosGrid.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
                Next
            End If
            pagadosGrid.Columns.Item(6).Visible = False 'amount without money format
            pagadosGrid.Width = principalTable.Width
            pagadosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            pagadosGrid.AutoResizeColumns()
            pagadosGrid.Visible = True
            principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize))
            principalTable.Refresh()
        End If
    End Sub

    Private Sub planillaPendiente()
        Dim chk As New DataGridViewCheckBoxColumn()

        Dim wTipo As String
        If TipoV.Text = "" Or TipoV.Text = " " Then
            wTipo = ""
        Else
            wTipo = " AND  cdT.DescSpanish = '" + TipoV.Text + "' "
        End If

        pagadosGrid.Width = 0
        porPagarGrid.Width = principalTable.Width - 28
        chk.HeaderText = "Pagar"
        chk.Name = "chk"
        porPagarGrid.Columns.Insert(0, chk)
        sql = "SELECT MR.Type, MR.MemberId AS 'No. Miembro', M.FirstNames + ' ' + M.LastNames AS Nombre, CONVERT(varchar, MR.ApprovedDateTime, 21) AS 'Fecha Aprobada', cdT.DescSpanish AS Tipo, " + _
                  "CONVERT(money, MR.ApprovedAmount, 1) Aprobado, MR.ApprovedBy AS Aprobó, S.Name AS Establecimiento, cdG.DescSpanish Grado " + _
                  "FROM dbo.MemberReimbursement MR INNER JOIN dbo.Member M ON M.Project = MR.Project AND M.RecordStatus = MR.RecordStatus " + _
                  " AND M.MemberId = MR.MemberId INNER JOIN dbo.MemberEducationYear MEY ON MEY.Project = M.Project AND MEY.MemberId = M.MemberId " + _
                  " AND MEY.RecordStatus = M.RecordStatus AND MEY.SchoolYear = " + AñoV.Text + " INNER JOIN dbo.CdReimbursementType cdT  ON MR.Type = cdT.Code " + _
                  " INNER JOIN dbo.School S ON MEY.RecordStatus = S.RecordStatus AND MEY.Project = S.Project AND MEY.SchoolCode = S.Code " + _
                  "INNER JOIN dbo.CdGrade cdG ON cdG.Code = MEY.Grade " + _
                  "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND MR.FunctionalArea = 'EDUC' AND MR.ReimbursementDateTime IS NULL  AND " + _
                  " MR.Pay = 'CHEQ'  AND S.Name = '" + EscuelaV.Text + "' " + wTipo + "  " + _
                  "AND YEAR(MR.CreationDateTime) = " + AñoV.Text + " "
        bdGrid(sql, porPagarGrid)
        If porPagarGrid.RowCount > 0 Then
            For Each r As DataGridViewRow In porPagarGrid.Rows
                porPagarGrid.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
            Next
        End If
        'GenerarButton.Visible = False
        porPagarGrid.Columns.Item(1).Visible = False 'type
        porPagarGrid.Visible = True
        GuardarButton.Visible = True
        pagoOpTable.Visible = True
        NoChequeV.Focus()
    End Sub

    Private Sub selTodosCheck_CheckedChanged(sender As Object, e As EventArgs) Handles selTodosCheck.CheckedChanged
        For Each r As DataGridViewRow In porPagarGrid.Rows
            porPagarGrid.Item(0, r.Index).Value = selTodosCheck.Checked
        Next
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT code codigo, DescSpanish tipo " + _
                 "FROM CdReimbursementType " + _
                 "WHERE FunctionalArea = 'EDUC' AND Active = 1 AND Project IN ('*', '" + S + "')"
        bdCombo(sql, TipoV, "codigo", "tipo")

        sql = "SELECT Code codigo, Name escuela " + _
                 "FROM dbo.School " + _
                 "WHERE Project = '" + S + "' AND RecordStatus = ' ' AND Active= 1 " + _
                 "ORDER BY Name"
        bdCombo(sql, EscuelaV, "codigo", "escuela")
        AñoV.Text = Now.Year.ToString
        TipoV.Focus()
    End Sub
End Class