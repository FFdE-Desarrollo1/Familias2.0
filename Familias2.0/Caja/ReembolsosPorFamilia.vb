' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReembolsosPorFamilia
    Dim familia As Integer

    Private Sub ReembolsosPorFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        MiembroV.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub buscarNoFamilia(ByVal miembro As Integer)
        Dim sql As String
        sql = "Select LastFamilyId AS FamilyId " + _
              "FROM dbo.Member M " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + miembro.ToString
        familia = bdEntero(sql, "FamilyId")
        FamiliaV.Text = familia.ToString
    End Sub

    Private Sub calcularTotal()
        Dim t, temp As Double
        t = 0
        For f = 0 To ListadoGrid.Rows.Count - 1
            If ListadoGrid.Item(0, f).Value() = True Then
                temp = Double.Parse(ListadoGrid.Item(8, f).Value())
                t = t + temp
            End If
        Next

        TotalV.Text = t.ToString("N", en)
        chequearReembolsos()
        tipoDoc()
    End Sub

    Private Sub chequearReembolsos()
        Dim n As Integer
        For f = 0 To ListadoGrid.Rows.Count - 1
            If ListadoGrid.Item(0, f).Value() = True Then
                n = n + 1
            End If
        Next

        If n > 0 Then
            ChequeV.ReadOnly = False
            ReciboV.ReadOnly = False
        Else
            ChequeV.ReadOnly = True
            ReciboV.ReadOnly = True
            tipoDoc()
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                familia = FamiliaV.Text
                reembolsosPendientes()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim typeDoc As String
        If ChequeV.Text = "" Or ChequeV.Text = " " Then
            typeDoc = "E"
        Else
            typeDoc = "C"
        End If

        For f = 0 To ListadoGrid.Rows.Count - 1
            If ListadoGrid.Item(0, f).Value() = True Then
                guardarReembolsos(ListadoGrid.Item(1, f).Value(), ListadoGrid.Item(12, f).Value(), _
                                  ListadoGrid.Item(14, f).Value(), typeDoc, Double.Parse(ListadoGrid.Item(8, f).Value()), ListadoGrid.Item(10, f).Value())
            End If
        Next
        TotalButton.Visible = False

        revisarReembolsos(typeDoc)
    End Sub

    Private Sub guardarReembolsos(ByVal memberId As Integer, _
                             ByVal type As String, _
                             ByVal aut As String,
                             ByVal doc As String,
                             ByVal amount As Double,
                             ByVal ApprovedBy As String)
        Dim updateSQL, docT As String
        If doc = "C" Then
            docT = ", CheckNumber = '" + ChequeV.Text + "' "
        Else
            docT = ", ReceiptNumber = '" + ReciboV.Text + "' "
        End If
        '" AND Type = '" + type + "' AND dbo.fn_GEN_FormatDate(ApprovedDateTime, 'ES') = '" + aut + "' " + _
        updateSQL = "UPDATE  dbo.MemberReimbursement SET ReimbursementDateTime = GETDATE(), ReimbursementBy = '" + U + "' " + docT + _
                    "WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId = " + memberId.ToString + _
        " AND Type = '" + type + "' AND CONVERT(varchar, CreationDateTime, 20) = CONVERT(varchar, '" + aut + "', 20) " + _
        " AND ApprovedAmount = " + amount.ToString + " AND ApprovedBy = '" + ApprovedBy + "'  "
        'InputBox("", "", updateSQL)

        bdInsertar(updateSQL)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            buscarNoFamilia(Integer.Parse(MiembroV.Text))
            reembolsosPendientes()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ReembolsosPorFamilia
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub reembolsosPendientes()
        Dim wi As Integer = Me.Width
        FamiliaV.Enabled = False
        MiembroV.Enabled = False
        chequearReembolsos()

        Dim listSQL As String
        listSQL = "SELECT M.MemberId AS 'No. Miembro', M.FirstNames AS Nombres, M.LastNames AS Apellidos, M.LastFamilyId AS Familia, " + _
                  "cdR.DescSpanish AS 'Tipo de Pago', dbo.fn_GEN_FormatDate(MR.ApprovedDateTime, 'ES') AS 'Fecha Aprobación', CONVERT(money, MR.Amount) Cantidad, CONVERT(money, MR.ApprovedAmount) Aprobado, " + _
                  "CONVERT(money, MR.ApprovedAmount * 100 / MR.Amount) AS '%', MR.ApprovedBy AS 'Aprobado Por', MR.Notes as Notas, MR.Type, cdAT.DescSpanish AS 'Tipo Afiliación', " + _
                  "CONVERT(varchar, MR.CreationDateTime, 20) 'Ref-Ingreso' " + _
                  "FROM dbo.MemberReimbursement MR INNER JOIN " + _
                  "dbo.Member M ON MR.Project = M.Project AND MR.MemberId = M.MemberId AND MR.RecordStatus = M.RecordStatus INNER JOIN " + _
                  " dbo.CdReimbursementType cdR ON MR.Type = cdR.Code " + _
                  " LEFT JOIN dbo.CdAffiliationStatus cdAT ON cdAT.Code = M.AffiliationStatus " + _
                  "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND MR.ReimbursementDateTime IS NULL AND M.LastFamilyId = " + familia.ToString + " AND " + _
                  "YEAR(MR.ApprovedDateTime) > 2011 "
        bdGrid(listSQL, ListadoGrid)
        ListadoGrid.Columns.Item(12).Visible = False
        ListadoGrid.Visible = True
        ChequeV.Visible = True
        ChequeL.Visible = True
        ReciboV.Visible = True
        ReciboL.Visible = True
        GuardarButton.Visible = True
        principalTable.Visible = True
        ListadoGrid.Height = principalTable.Width - 50
        ReviewGrid.Height = 5
        If ListadoGrid.RowCount = 1 Then
            ListadoGrid.Item(0, 0).Value() = True
            calcularTotal()
        End If

        For f = 1 To ListadoGrid.ColumnCount - 1
            ListadoGrid.Columns(f).ReadOnly = True
        Next

    End Sub

    Private Sub revisarReembolsos(ByVal doc)
        Dim reviewRem, docT As String
        ChequeV.Visible = False
        ChequeL.Visible = False
        ReciboV.Visible = False
        ReciboL.Visible = False
        GuardarButton.Visible = False
        inicioButton.Focus()

        If doc = "C" Then
            docT = " AND CheckNumber = '" + ChequeV.Text + "' "
        Else
            docT = " AND ReceiptNumber = '" + ReciboV.Text + "' "
        End If

        reviewRem = "SELECT M.MemberId AS 'No. Miembro', M.FirstNames AS Nombres, M.LastNames AS Apellidos, M.LastFamilyId AS Familia, " + _
                  "cdR.DescSpanish AS 'Tipo de Pago', dbo.fn_GEN_FormatDate(MR.ApprovedDateTime, 'ES') AS 'Fecha Aprobación', CONVERT(money, MR.Amount) Cantidad, CONVERT(money, MR.ApprovedAmount) Aprobado, " + _
                  "CONVERT(money, MR.ApprovedAmount * 100 / MR.Amount) AS '%', MR.ApprovedBy AS 'Aprobado Por', MR.Notes as Notas, dbo.fn_GEN_FormatDate(MR.ReimbursementDateTime, 'ES') Pagado, MR.ReimbursementBy 'Pagado Por' " + _
                  "FROM dbo.MemberReimbursement MR INNER JOIN " + _
                  "dbo.Member M ON MR.Project = M.Project AND MR.MemberId = M.MemberId AND MR.RecordStatus = M.RecordStatus INNER JOIN " + _
                  " dbo.CdReimbursementType cdR ON MR.Type = cdR.Code " + _
                  "WHERE MR.RecordStatus = ' ' AND MR.Project = '" + S + "' AND M.LastFamilyId = " + familia.ToString + _
                  docT + " AND ReimbursementBy = '" + U + "' "
        bdGrid(reviewRem, ReviewGrid)
        ReviewGrid.Visible = True
        ListadoGrid.Height = 0
        ReviewGrid.Height = principalTable.Height - 50
    End Sub

    Private Sub tipoDoc()
        If Double.Parse(TotalV.Text) >= 100 Then
            ChequeV.Focus()
        Else
            ReciboV.Focus()
        End If
    End Sub

    Private Sub TotalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalButton.Click
        calcularTotal()
    End Sub

    Private Sub valoresIniciales()
        GuardarButton.Visible = False
        ReviewGrid.Visible = False
        MiembroV.Text = ""
        FamiliaV.Text = ""
        ChequeV.Text = ""
        ReciboV.Text = ""
        TotalV.Text = "0"
        MiembroV.Enabled = True
        FamiliaV.Enabled = True
        MiembroV.Focus()
    End Sub

End Class