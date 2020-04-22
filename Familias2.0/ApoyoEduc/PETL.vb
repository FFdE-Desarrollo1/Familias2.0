' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class PETL

    Private Sub PETL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        AñoV.Focus()
    End Sub

    Private Sub AñoV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AñoV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
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


    Private Sub candidatosPETL()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False

        Dim where As String = ""

        If Len(AñoV.Text) > 0 Then
            where = where + " AND PETL = " + AñoV.Text
        End If

        If Len(participantesCombo.Text) > 0 Then
            If participantesCombo.Text = "SI" Then
                where = where + " AND PETL IS NOT NULL"
            ElseIf participantesCombo.Text = "NO" Then
                where = " AND PETL IS NULL"
                AñoV.Text = ""
            End If

        End If

        sql = "SELECT * FROM v_AEDU_CandidatosPETL WHERE Sitio = '" + S + "'" + where + _
              " ORDER BY PETL DESC, TS "
        bdGrid(sql, ListadoGrid)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
        ListadoGrid.Visible = True
        TotalL.Visible = True

        participantesCombo.Visible = True
        participantesL.Visible = True
    End Sub

    Private Sub CandidatosLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CandidatosLink.LinkClicked
        candidatosPETL()
    End Sub

    Private Sub FamiliasPETLLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FamiliasPETLLink.LinkClicked
        participantesPETL()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub participantesPETL()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False

        Dim where As String = ""

        If Len(AñoV.Text) > 0 Then
            where = where + " AND AñoPETL = " + AñoV.Text
        End If

        sql = "SELECT *  FROM v_AEDU_FamiliasPETL WHERE Sitio = '" + S + "'" + where + _
              " ORDER BY AñoPETL DESC, TS, Familia "
        bdGrid(sql, ListadoGrid)
        TotalL.Text = "Total: " + ListadoGrid.RowCount.ToString
        ListadoGrid.Visible = True
        TotalL.Visible = True
        participantesCombo.Visible = False
        participantesL.Visible = False
        participantesCombo.Text = ""
    End Sub

End Class