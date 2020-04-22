' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class EstadisticasSalud
    Dim wMes, nMes As String

    Private Sub EstadisticasSalud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub dentalLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles dentalLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual - " + AñoV.Text
                wMes = " "
            Else
                nMes = MesCombo.Text + " - " + AñoV.Text
                wMes = " WHERE Mes = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT Descripcion 'CLINICA DENTAL', Total '" + nMes.ToUpper + "' " + _
                  "FROM dbo.fn_HEAL_ESTA_ClinicaDental(" + AñoV.Text + ", " + MesCombo.SelectedValue.ToString + ") "
            bdGrid(sql, ListadoGrid)

            sql = "SELECT TOP 25 Diagnostico 'Morbilidad Mensual (Top 25)', COUNT(*) AS '" + nMes.ToUpper + "' " + _
                  "FROM dbo.fn_HEAL_ESTA_ConsultasDentales(" + AñoV.Text + ") L " + wMes + _
                  "GROUP BY Diagnostico " + _
                  "ORDER BY COUNT(*) DESC, Diagnostico "
            bdGrid(sql, OtrosGrid)
            ListadoGrid.Visible = True
            OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub FarmaciaL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FarmaciaL.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            Dim de, a As String
            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual"
                wMes = " "
                de = AñoV.Text + "/01/01"
                a = AñoV.Text + "/12/31"
            Else
                nMes = MesCombo.Text.ToString
                wMes = "WHERE Mes = " + MesCombo.SelectedValue.ToString + " "
                de = AñoV.Text + "/" + MesCombo.SelectedValue.ToString + "/01"
                a = AñoV.Text + "/" + MesCombo.SelectedValue.ToString + "/" + _
                System.DateTime.DaysInMonth(Integer.Parse(AñoV.Text), Integer.Parse(MesCombo.SelectedValue)).ToString
            End If

            sql = "SELECT  Descripcion '8. Farmacia', total '" + nMes.ToUpper + "' " + _
                  "FROM dbo.fn_HEAL_ESTA_Farmacia_('" + de + "', '" + a + "') L"
            bdGrid(sql, ListadoGrid)
            ListadoGrid.Visible = True

            sql = "SELECT TOP 25 Med 'Medicamentos con mayor rotación al mes (Top 25)', SUM(Total) '" + nMes.ToUpper + "'  " + _
                  "FROM dbo.fn_HEAL_FARM_HistorialRotacionMedsMesAño(" + AñoV.Text + ") " + _
                  wMes + _
                  "GROUP BY Med " + _
                  "ORDER BY SUM(Total) desc "
            bdGrid(sql, OtrosGrid)
            OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub llenarMesesCombo()
        Dim dt As New DataTable
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim a() As String = {"1", "Enero"}
        dt.Rows.Add(a)
        a = {"2", "Febrero"}
        dt.Rows.Add(a)
        a = {"3", "Marzo"}
        dt.Rows.Add(a)
        a = {"4", "Abril"}
        dt.Rows.Add(a)
        a = {"5", "Mayo"}
        dt.Rows.Add(a)
        a = {"6", "Junio"}
        dt.Rows.Add(a)
        a = {"7", "Julio"}
        dt.Rows.Add(a)
        a = {"8", "Agosto"}
        dt.Rows.Add(a)
        a = {"9", "Septiembre"}
        dt.Rows.Add(a)
        a = {"10", "Octubre"}
        dt.Rows.Add(a)
        a = {"11", "Noviembre"}
        dt.Rows.Add(a)
        a = {"12", "Diciembre"}
        dt.Rows.Add(a)

        With MesCombo
            .DataSource = dt
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With

        llenarMesSeleccionado()
    End Sub

    Private Sub llenarMesSeleccionado()
        Dim mesActual = Now.Month
        If mesActual = 1 Then
            MesCombo.SelectedValue = mesActual
        Else
            MesCombo.SelectedValue = mesActual - 1
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub nutriLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles nutriLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            Dim actual As DateTime = Now
            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual - " + AñoV.Text
                wMes = " "
            Else
                nMes = MesCombo.Text + " - " + AñoV.Text
                wMes = " WHERE Mes = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT Descripcion '10. NUTRICION (Consulta en clínica)' , Total '" + nMes.ToUpper + "' " + _
                  "FROM dbo.fn_HEAL_ESTA_Nutricion(" + AñoV.Text + ", " + MesCombo.SelectedValue.ToString + ") "
            bdGrid(sql, ListadoGrid)

            sql = "SELECT Familia, Miembro, Nombre, Edad, Articulo, Cantidad " + _
                  "FROM dbo.fn_HEAL_ESTA_ApNutriListado(" + AñoV.Text + ", '" + actual.Year.ToString + "/" + actual.Month.ToString + "/" + actual.Day.ToString + "') " + wMes + _
                  "GROUP BY Familia, Miembro, Nombre, Edad, Articulo, Cantidad " + _
                  "ORDER BY Familia, Miembro, Articulo "
            bdGrid(sql, OtrosGrid)
            ListadoGrid.Visible = True
            OtrosGrid.Visible = True
            'falta cuadrar
        End If
    End Sub

    Private Sub PacientesConsultaExtL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PacientesConsultaExtL.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing

            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual"
                wMes = " "
            Else
                nMes = MesCombo.Text
                wMes = " WHERE Mes = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT Descripcion 'CLINICA MEDICA', Total " + MesCombo.Text.ToUpper + "  " + _
                  "FROM dbo.fn_HEAL_ESTA_ClinicaMedica(" + AñoV.Text + ", " + MesCombo.SelectedValue.ToString + ")"
            bdGrid(sql, ListadoGrid)
            'InputBox("sql", "sql", sql)

            sql = "SELECT TOP 25 Diagnostico 'Morbilidad Mensual (Top 25)', COUNT(*) AS '" + nMes.ToUpper + "' " + _
                  "FROM dbo.fn_HEAL_ESTA_ConsultasMedicas(" + AñoV.Text + ") L " + wMes + _
                  "GROUP BY Diagnostico " + _
                  "ORDER BY COUNT(*) DESC, Diagnostico "
            bdGrid(sql, OtrosGrid)
            ListadoGrid.Visible = True
            OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub reExtLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles reExtLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual - " + AñoV.Text
                wMes = " "
            Else
                nMes = MesCombo.Text + " - " + AñoV.Text
                wMes = " AND Mes = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT *  FROM dbo.fn_HEAL_ESTA_RecetasExternas_(" + AñoV.Text + ", " + MesCombo.SelectedValue.ToString + ") "
            bdGrid(sql, ListadoGrid)

            sql = "SELECT Medicina, COUNT(*) 'Total - " + nMes + "' FROM dbo.fn_HEAL_ESTA_recetasExternas() " + _
                  "WHERE Año = " + AñoV.Text + wMes + " GROUP BY Medicina "
            bdGrid(sql, OtrosGrid)
            ListadoGrid.Visible = True
            OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub refExtLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles refExtLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual - " + AñoV.Text
                wMes = " "
            Else
                nMes = MesCombo.Text + " - " + AñoV.Text
                wMes = " AND Mes = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT * FROM dbo.fn_HEAL_ESTA_referenciasExternas_(" + AñoV.Text + ", " + MesCombo.SelectedValue + ") "
            bdGrid(sql, ListadoGrid)

            sql = "SELECT ReferidoA, Razon, COUNT(*) 'Total - " + nMes + "' FROM dbo.fn_HEAL_ESTA_referenciasExternas() " + _
                  "WHERE Año = " + AñoV.Text + wMes + " GROUP BY ReferidoA, Razon "
            bdGrid(sql, OtrosGrid)
            ListadoGrid.Visible = True
            OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub ReembolsosLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ReembolsosLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual - " + AñoV.Text
                wMes = " "
            Else
                nMes = MesCombo.Text + " - " + AñoV.Text
                wMes = " AND Mes = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT * FROM dbo.fn_HEAL_ESTA_Reembolsos_(" + AñoV.Text + ", " + MesCombo.SelectedValue.ToString + ") "
            bdGrid(sql, ListadoGrid)

            sql = "SELECT Sitio, Miembro, Nombre, TipoMiembro, COUNT(*) Reembolsos, SUM(Q_Aprobado) 'Q_Aprobado - " + nMes + "' FROM dbo.fn_HEAL_ESTA_Reembolsos(" + AñoV.Text + ") " + _
                   "WHERE Sitio NOT IN ('E', 'A', 'N') " + wMes + " GROUP BY Sitio, Miembro, Nombre, TipoMiembro  ORDER BY Sitio, Miembro "
            bdGrid(sql, OtrosGrid)
            ListadoGrid.Visible = True
            OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub refTSLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles refTSLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            sql = "SELECT ReferidoPor, Categoria, COUNT(*) Total FROM dbo.fn_HEAL_ESTA_ReferenciasInternas() " + _
                  "WHERE Program = 'TS' AND Año = " + AñoV.Text + " And Mes = " + MesCombo.SelectedValue.ToString + " GROUP BY ReferidoPor, Categoria"
            bdGrid(sql, ListadoGrid)

            ListadoGrid.Visible = True
            'OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub refAELink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles refAELink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            sql = "SELECT ReferidoPor, Categoria, COUNT(*) Total FROM dbo.fn_HEAL_ESTA_ReferenciasInternas() " + _
                  "WHERE Program = 'PSIC' AND Año = " + AñoV.Text + " And Mes = " + MesCombo.SelectedValue.ToString + " GROUP BY ReferidoPor, Categoria"
            bdGrid(sql, ListadoGrid)
            ListadoGrid.Visible = True
        End If
    End Sub

    Private Sub TratPrevLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LabLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual - " + AñoV.Text
                wMes = " "
            Else
                nMes = MesCombo.Text + " - " + AñoV.Text
                wMes = " WHERE Mes = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT Descripcion '9. LABORATORIO', Total '" + nMes.ToUpper + "' " + _
                  "FROM dbo.fn_HEAL_ESTA_Laboratorio(" + AñoV.Text + ", " + MesCombo.SelectedValue.ToString + " ) "
            bdGrid(sql, ListadoGrid)

            sql = "SELECT Top 15 Laboratorio 'LABORATORIOS CON MAYOR ROTACION (Top 15)', COUNT(*) Total FROM dbo.fn_HEAL_ESTA_Laboratorios(" + AñoV.Text + ")  " + _
                  wMes + "GROUP BY Laboratorio ORDER BY COUNT(*) DESC, Laboratorio "
            bdGrid(sql, OtrosGrid)

            sql = "SELECT '' Laboratorio, NULL Total " + _
                  "UNION ALL SELECT 'CULTIVOS CON MAYOR ROTACION', NULL " + _
                  "UNION ALL " + _
                  "SELECT Laboratorio, COUNT(*) Total FROM dbo.fn_HEAL_ESTA_Laboratorios(" + AñoV.Text + ")  " + _
                  "WHERE MEs = 2 and laboratorio like '%cultivo%' GROUP BY Laboratorio"
            bdGrid(sql, OtrosGrid)
            ListadoGrid.Visible = True
            OtrosGrid.Visible = True
        End If
    End Sub

    Private Sub valoresIniciales()
        AñoV.Text = Now.Year.ToString
        llenarMesesCombo()
    End Sub

    Private Sub VisitasCasaLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles VisitasCasaLink.LinkClicked
        If Len(AñoV.Text) > 0 Then
            ListadoGrid.Visible = False
            OtrosGrid.Visible = False
            ListadoGrid.DataSource = Nothing
            ListadoGrid.Rows.Clear()
            OtrosGrid.DataSource = Nothing
            OtrosGrid.Rows.Clear()

            If Len(MesCombo.SelectedValue) = 0 Then
                nMes = " anual"
                wMes = " "
            Else
                nMes = MesCombo.Text
                wMes = " AND MONTH(ActivityDateTime) = " + MesCombo.SelectedValue + "  "
            End If

            sql = "SELECT cdMAT.DescSpanish '14. Visitas domiciliarias', COUNT(*) AS '" + nMes.ToUpper + "' " + _
                  "FROM dbo.MemberActivity MA INNER JOIN dbo.CdMemberActivityType cdMAT ON MA.Type = cdMAT.Code " + _
                  "WHERE MA.RecordStatus = ' ' AND MA.Type = 'VCCL' AND YEAR(ActivityDateTime) = " + AñoV.Text + " " + wMes + " GROUP BY cdMAT.DescSpanish "
            bdGrid(sql, ListadoGrid)
            ListadoGrid.Visible = True
        End If
    End Sub
End Class