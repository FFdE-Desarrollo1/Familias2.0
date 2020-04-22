' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class IngresosMeds
    Dim iMeds, col As Integer

    Private Sub IngresosMeds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FechaP.Focus()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
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
        Else
            esValidaNuevaMedicina = True
        End If
    End Function

    Private Function existeEnListado(ByVal insert As String,
                                 ByVal listGrid As DataGridView,
                                 ByVal col As Integer) As Boolean
        Dim n As Integer = listGrid.Rows.Count - 1
        Dim exist As Integer = 0
        For f = 0 To n
            listGrid.Item(0, f).Value = f
            If listGrid.Item(col, f).Value = insert Then
                exist = exist + 1
            End If
        Next

        If exist > 0 Then
            existeEnListado = True
        Else
            existeEnListado = False
        End If
    End Function

    Private Sub guardarListadoMeds()
        If MedsGrid.Rows.Count() >= 1 Then
            Dim medsAct As String = ""
            Dim actual As DateTime = DateTime.Now

            For i = 0 To MedsGrid.Rows.Count() - 1
                insertarMedicina(actual.ToString(en.DateTimeFormat), MedsGrid.Item(0, i).Value().ToString, MedsGrid.Item(8, i).Value().ToString, _
                                 MedsGrid.Item(3, i).Value().ToString, MedsGrid.Item(5, i).Value().ToString, DateTime.Parse(MedsGrid.Item(10, i).Value()), MedsGrid.Item(12, i).Value().ToString)
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
                                 ByVal cant As String, ByVal prov As String,
                                 ByVal obse As String, ByVal expira As DateTime,
                                 ByVal prec As String)
        Dim pro As String
        If Len(prov) > 0 Then
            pro = "'" + prov + "'"
        Else
            pro = "NULL"
        End If

        'Project, TransactionDateTime, Category, Item, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, FunctionalArea, MemberProject,
        'MemberId, ConsultationDateTime, Quantity, Physician, UnitPrice, Source, Provider, InventoryAdjustmentReason, Notes, ExpirationDateMed, FinishedMed
        sql = "INSERT INTO dbo.HealthInventoryTransaction VALUES ('F', '" + FechaP.Value.ToString(en.DateTimeFormat) + "', 'MEDI', '" + codMed + "', GETDATE(), " + _
              "' ', '" + U + "', NULL, 'FARM', NULL, NULL, NULL, " + cant + ", NULL, " + prec + ", '" + FuenteCombo.SelectedValue + "', " + pro + ", NULL, '" + obse + "', '" + expira.ToString(en.DateTimeFormat) + "', 0)"
        bdInsertar(sql)
        'InputBox("", "", sql)

        sql = "SELECT CASE WHEN  DosageDesc_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + ' (' +  DosageDesc_es + ') ') " + _
                         "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END + ' EXISTENCIA ACTUALIZADA: ' + CAST(CurrentQuantity AS nvarchar(10)) AS Medicine " + _
                        "FROM dbo.CdHealthInventoryItem WHERE Code = '" + codMed + "' "
        MsgBox(bdPalabra(sql, "Medicine"), vbInformation, My.Resources.versionFamilias2)
    End Sub

    Private Sub llenarMedsGrid()
        Dim pro As String
        Dim nueva, anterior As Integer
        If Len(ProveedorCombo.Text) > 0 Then
            pro = ProveedorCombo.SelectedValue
        Else
            pro = ""
        End If

        sql = "SELECT Item FROM  dbo.CdHealthInventoryPresentation WHERE Code = '" + MedsCombo.SelectedValue + "'"
        Dim item As String = bdPalabra(sql, "Item")

        sql = "SELECT DosageDesc_es 'Presentacion' FROM  dbo.CdHealthInventoryItem WHERE Code = '" + item + "'"
        Dim pres As String = bdPalabra(sql, "Presentacion")

        sql = "SELECT NumberOfDosages 'Dosis' FROM  dbo.CdHealthInventoryPresentation WHERE Code = '" + MedsCombo.SelectedValue + "'"
        Dim cant As Integer = bdEntero(sql, "Dosis")
        Dim tot As Integer = cant * Integer.Parse(CantidadV.Text)

        sql = "SELECT CurrentQuantity FROM dbo.CdHealthInventoryItem WHERE Code = '" + item + "' "
        Dim existencia As Integer = bdEntero(sql, "CurrentQuantity")

        sql = "select dbo.fn_HEAL_FARM_VencimientoMasReciente('" + item + "') Fecha"
        Dim expRec = bdPalabra(sql, "Fecha")

        sql = "SELECT dbo.fn_GEN_FormatDate('" + VencimientoPicker.Value.Year.ToString + "/" + VencimientoPicker.Value.Month.ToString + "/" + VencimientoPicker.Value.Day.ToString + " ', 'ES') Ven "

        If Len(VencimientoPicker.Value) > 0 Then
            nueva = DateDiff(DateInterval.Day, DateTime.Today, DateTime.Parse(VencimientoPicker.Value.ToShortDateString))
        Else
            nueva = 0
        End If

        If nueva < 0 Then
            MsgBox("No puede ingresar fechas de vencimiento anteriores a la actual", vbInformation, My.Resources.versionFamilias2)
        Else
            If Len(expRec) > 0 Then
                anterior = DateDiff(DateInterval.Day, DateTime.Today, DateTime.Parse(expRec))

                If nueva < anterior Then
                    MsgBox("Verifique la medicina en estante, la que esta ingresando vence antes", vbInformation, My.Resources.versionFamilias2)
                    col = 10
                Else
                    col = 11
                End If
            Else
                MsgBox("MEDICAMENTO SIN FECHA DE VENCIMIENTO REGISTRADA ANTES", vbInformation, My.Resources.versionFamilias2)
                col = 10
            End If

            Dim a() As String = {item, MedsCombo.Text, CantidadV.Text, pro, ProveedorCombo.Text, ObservacionesV.Text, pres, cant.ToString, tot.ToString, existencia.ToString, VencimientoPicker.Value.ToShortDateString, expRec, PrecioV.Text}
            MedsGrid.Rows.Add(a)

            MedsGrid.Item(col, MedsGrid.RowCount - 1).Style.BackColor = Color.DodgerBlue
            MedsGrid.Item(col, MedsGrid.RowCount - 1).Style.ForeColor = Color.White
            checkCorrelativeMeds()
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New IngresosMeds
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub MasMedsBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasMedsBoton.Click
        If esValidaNuevaMedicina() = True Then
            llenarMedsGrid()
            iMeds = iMeds + 1
            MedsCombo.Text = ""
            CantidadV.Text = ""
            PrecioV.Text = "0.00"
            ObservacionesV.Text = ""
            ProveedorCombo.Text = ""
            VencimientoPicker.Value = DateTime.Today
            checkCorrelativeMeds()
            FuenteCombo.Focus()
        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If Len(FuenteCombo.Text) > 0 Then
            guardarListadoMeds()
        Else
            MsgBox("Necesita seleccionar la fuente", vbInformation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub valoresIniciales()
        'fill medList
        sql = "SELECT Code, CASE WHEN Presentation_es IS NOT NULL THEN (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish + '(' + Presentation_es + ')') " + _
                         "ELSE (CAST(Code AS nvarchar(7)) + ' - ' + DescSpanish) END AS Medicine " + _
                        "FROM dbo.CdHealthInventoryPresentation WHERE Active = 1 AND ValidSelection = 1  AND Category = 'MEDI' AND (Code < '2900'  or Code = 'OTRA') "
        bdCombo(sql, MedsCombo, "Code", "Medicine")

        sql = "SELECT Code, DescSpanish Descripcion FROM dbo.CdHealthInventorySource "
        bdCombo(sql, FuenteCombo, "Code", "Descripcion")
        FuenteCombo.Text = "Comprados en Guatemala"

        sql = "SELECT Code, DescSpanish Descripcion FROM dbo.CdProvider WHERE Active = 1  AND Project = '" + S + "' AND FunctionalArea = 'FARM' "
        bdCombo(sql, ProveedorCombo, "Code", "Descripcion")

        FuenteCombo.Focus()
    End Sub

End Class
