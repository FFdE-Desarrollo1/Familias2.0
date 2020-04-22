' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ResumenAJ
    Dim Año As Integer = DateTime.Now.Year
    Dim famDir As Integer = 0

    Private Sub ResumenAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(MiembroV.Text) > 0 Then
            validaMiembro()
        Else
            PrincipalPanel.Visible = True
        End If
        MiembroV.Focus()
    End Sub

    Private Sub avisosFamiliares()
        If S = "E" Or S = "A" Then
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Then
                Dim g As System.Drawing.Graphics = Me.CreateGraphics
                Dim ancho As Integer = 0
                Dim avisoLargo As String = ""

                sql = "SELECT Aviso FROM dbo.fn_WARN_avisosES('" + S + "', " + FamiliaV.Text + ") "
                bdGrid(sql, AvisosGrid)

                If AvisosGrid.RowCount > 0 Then
                    For f = 0 To AvisosGrid.RowCount - 1
                        If Len(AvisosGrid.Item(0, f).Value()) > ancho Then
                            avisoLargo = AvisosGrid.Item(0, f).Value()
                        End If
                    Next

                    AvisosGrid.Height = AvisosGrid.RowCount * 25
                    AvisosGrid.Width = g.MeasureString(avisoLargo, AvisosGrid.Font).Width
                    AvisosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                    AvisosGrid.AutoResizeColumns()
                    AvisosGrid.Visible = True
                    AvisosL.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub Detalle()
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        sql = "SELECT Actividad, Fecha_Asistencia, convert(nvarchar(20), HORA) + ':' + convert(nvarchar(20), MINUTO) Horario, Notas Observaciones, Usuario " + _
                  "FROM dbo.fn_GJOV_AttendanceList ('" + S + "', " + Año.ToString + ") L " + _
                  "where L.Miembro = " + MiembroV.Text + " AND Año = " + Año.ToString + _
                  "ORDER BY Mes DESC , dia DESC, hora DESC, minuto DESC "
        bdGrid(sql, ListGrid)
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ListGrid.Visible = True
    End Sub

    Private Sub FamiliaV_Click(sender As Object, e As EventArgs) Handles FamiliaV.Click
        If Len(FamiliaV.Text) > 0 Then
            If famDir = 1 Then
                irPefilFamilia()
            Else
                irMiembrosDeFamilia()
            End If
        End If
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                If famDir = 1 Then
                    irPefilFamilia()
                Else
                    irMiembrosDeFamilia()
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub genInfo()
        Dim ahora As DateTime = DateTime.Now
        Dim listTable As New DataTable
        sql = "SELECT Nombres, Apellidos, Edad, EstadoAfil, Fase, semaforo, Estado_Educ, Grado, Año, Familia, clasificación, TS,  Region, dbo.fn_GEN_tipoMiembro('" + S + "', " + MiembroV.Text + ") TipoMiembro " + _
                 "FROM dbo.fn_GEN_InfoGenMiembro('" + S + "', " + MiembroV.Text + ", " + ahora.Year.ToString + ") L "
        bdDataTable(sql, listTable)

        If listTable.Rows.Count > 0 Then
            NombreV.Text = chequearValor(listTable.Rows(0)("Nombres")) + " " + chequearValor(listTable.Rows(0)("Apellidos"))
            EdadV.Text = " - " + chequearValor(listTable.Rows(0)("Edad"))
            FamiliaV.Text = chequearValor(listTable.Rows(0)("Familia"))
            ClasificacionV.Text = chequearValor(listTable.Rows(0)("clasificación"))
            TSV.Text = chequearValor(listTable.Rows(0)("TS"))
            RegionV.Text = chequearValor(listTable.Rows(0)("Region"))
            TipoMiembroL.Text = chequearValor(listTable.Rows(0)("TipoMiembro"))
            FaseV.Text = chequearValor(listTable.Rows(0)("Fase"))
            Dim color As String = chequearValor(listTable.Rows(0)("semaforo"))

            If Len(color) > 0 Then
                semaforo(color, semaforoV)
                semaforoL.Text = "Semáforo:"
                semaforoL.Visible = True
            End If

            If Len(chequearValor(listTable.Rows(0)("Grado"))) > 0 Then
                GradoV.Text = chequearValor(listTable.Rows(0)("Estado_Educ")) + " " + chequearValor(listTable.Rows(0)("Grado")) + " (" + chequearValor(listTable.Rows(0)("Año")) + ")"
                GradoV.Visible = True
                GradoL.Visible = True
            End If

            MiembroV.ReadOnly = True
            FamiliaV.ReadOnly = True
            PanelSecundario.Visible = True
            verDetalle.Visible = True
            Listado()
            avisosFamiliares()
            FamiliaV.Focus()
        End If
    End Sub

    Private Sub irMiembrosDeFamilia()
        Dim nxt As New MiembrosFamilia
        nxt.familyId = FamiliaV.Text
        nxt.transac = "ASIN"
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irPefilFamilia()
        Dim nxt As New PerfilFamilia
        nxt.FamiliaV.Text = FamiliaV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub Listado()
        ListGrid.DataSource = Nothing
        ListGrid.Rows.Clear()
        ListGrid.Visible = False
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        sql = "SELECT Actividad,  " + _
                  "SUM(CASE WHEN Mes = 1 THEN Total ELSE 0 END) AS Ene, " + _
                  "SUM(CASE WHEN Mes = 2 THEN Total ELSE 0 END) AS Feb, " + _
                  "SUM(CASE WHEN Mes = 3 THEN Total ELSE 0 END) AS Mar, " + _
                  "SUM(CASE WHEN Mes = 4 THEN Total ELSE 0 END) AS Abr, " + _
                  "SUM(CASE WHEN Mes = 5 THEN Total ELSE 0 END) AS May, " + _
                  "SUM(CASE WHEN Mes = 6 THEN Total ELSE 0 END) AS Jun, " + _
                  "SUM(CASE WHEN Mes = 7 THEN Total ELSE 0 END) AS Jul, " + _
                  "SUM(CASE WHEN Mes = 8 THEN Total ELSE 0 END) AS Ago, " + _
                  "SUM(CASE WHEN Mes = 9 THEN Total ELSE 0 END) AS Sep, " + _
                  "SUM(CASE WHEN Mes = 10 THEN Total ELSE 0 END) AS Oct, " + _
                  "SUM(CASE WHEN Mes = 11 THEN Total ELSE 0 END) AS Nov, " + _
                  "SUM(CASE WHEN Mes = 12 THEN Total ELSE 0 END) AS Dic, " + _
                  "SUM(Total) AS Total " + _
                  "FROM dbo.fn_GJOV_AsistenciaPorMiembro('" + S + "', " + Año.ToString + ") " + _
                  "WHERE Miembro = " + MiembroV.Text + " AND Año = " + Año.ToString + " " + _
                  "GROUP BY Actividad  " + _
                  "ORDER BY Actividad "
        'InputBox("", "", sql)
        bdGrid(sql, ListGrid)
        ListGrid.Visible = True
        ListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
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

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ResumenAJ
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub validaMiembro()
        If miembroEsValido(S, MiembroV.Text) = True Then
            valoresIniciales()
        Else
            MsgBox("No es un número válido", vbQuestion, My.Resources.versionFamilias2)
            MiembroV.Text = ""
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub valoresIniciales()
        famDir = 1
        PrincipalPanel.Visible = True
        genInfo()
    End Sub

    Private Sub verDetalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verDetalle.CheckedChanged
        If verDetalle.Checked = True Then
            Detalle()
        Else
            Listado()
        End If
    End Sub


End Class