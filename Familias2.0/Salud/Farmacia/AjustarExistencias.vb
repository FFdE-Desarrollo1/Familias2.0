' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class AjustarExistencias
    Dim iMeds As Integer

    Private Sub AjustarExistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub checkCorrelativeMeds()
        Dim n As Integer = MedsGrid.Rows.Count - 1
        For f = 0 To n
            MedsGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
        Next
    End Sub

    Private Function esValidaNuevaMedicina() As Boolean
        If MedsCombo.Text = "" Or IsDBNull(MedsCombo.Text) Then
            MsgBox("Necesita seleccionar una medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        ElseIf CantidadV.Text = "" Or IsDBNull(CantidadV.Text) Then
            MsgBox("Necesita ingresar la cantidad de la medicina", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        ElseIf RazonCombo.Text = "" Or IsDBNull(RazonCombo.Text) Then
            MsgBox("Necesita seleccionar la razón", vbInformation, My.Resources.versionFamilias2)
            esValidaNuevaMedicina = False
        Else
            esValidaNuevaMedicina = True
        End If
    End Function

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        guardarListadoMeds()
    End Sub

    Private Sub guardarListadoMeds()
        If MedsGrid.Rows.Count() >= 1 Then
            Dim actual As DateTime = DateTime.Now
            For i = 0 To MedsGrid.Rows.Count() - 1
                insertarMedicina(actual.ToString(en.DateTimeFormat), MedsGrid.Item(0, i).Value().ToString, MedsGrid.Item(2, i).Value().ToString, _
                                 MedsGrid.Item(3, i).Value().ToString, MedsGrid.Item(5, i).Value().ToString)
            Next

            MasMedsBoton.Visible = False
            GuardarButton.Visible = False
            MedsGrid.Enabled = False
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub insertarMedicina(ByVal fech As String, ByVal codMed As String,
                                ByVal cant As String, ByVal raz As String, ByVal obse As String)

        'Project, TransactionDateTime, Category, Item, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, FunctionalArea, MemberProject,
        'MemberId, ConsultationDateTime, Quantity, Physician, UnitPrice, Source, Provider, InventoryAdjustmentReason, Notes, ExpirationDateMed, FinishedMed
        sql = "INSERT INTO dbo.HealthInventoryTransaction VALUES ('F', '" + FechaP.Value.ToString(en.DateTimeFormat) + "', 'MEDI', '" + codMed + "', GETDATE(), " + _
              "' ', '" + U + "', NULL, 'FARM', NULL, NULL, NULL, " + cant + ", NULL, 0, NULL, NULL, '" + raz + "', '" + obse + "', NULL, 0)"
        bdInsertar(sql)
        sql = "SELECT CASE WHEN  DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + ' (' +  DosageDesc_es + ') ') " + _
                 "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END + ' EXISTENCIA ACTUALIZADA: ' + CAST(CurrentQuantity AS nvarchar(10)) AS Medicine " + _
                "FROM dbo.CdHealthInventoryItem WHERE Code = '" + codMed + "' "
        MsgBox(bdPalabra(sql, "Medicine"), vbInformation, My.Resources.versionFamilias2)
    End Sub

    Private Sub llenarMedsGrid()
        sql = "SELECT CurrentQuantity Existencia FROM dbo.CdHealthInventoryItem WHERE Code = '" + MedsCombo.SelectedValue + "'"
        Dim existencia As Integer = bdEntero(sql, "Existencia")
        Dim a() As String = {MedsCombo.SelectedValue, MedsCombo.Text, CantidadV.Text, RazonCombo.SelectedValue, RazonCombo.Text, ObservacionesV.Text, existencia.ToString}
        MedsGrid.Rows.Add(a)
        checkCorrelativeMeds()
    End Sub

    Private Sub MasMedsBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasMedsBoton.Click
        If esValidaNuevaMedicina() = True Then
            llenarMedsGrid()
            iMeds = iMeds + 1
            MedsCombo.Text = ""
            CantidadV.Text = ""
            ObservacionesV.Text = ""
            RazonCombo.Text = ""
            checkCorrelativeMeds()
            MedsCombo.Focus()
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New AjustarExistencias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, CASE WHEN DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + '(' + DosageDesc_es + ')') " + _
                         "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END + ' #' + CONVERT(varchar, CurrentQuantity) AS Medicine " + _
                        "FROM dbo.CdHealthInventoryItem WHERE Active = 1 AND ValidSelection = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, MedsCombo, "Code", "Medicine")

        sql = "SELECT Code, DescSpanish Descripcion FROM dbo.CdInventoryAdjustmentReason WHERE Active = 1 AND Program IN ('***', 'FARM') ORDER BY DescSpanish "
        bdCombo(sql, RazonCombo, "Code", "Descripcion")
    End Sub

End Class