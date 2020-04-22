' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ResumenTS

    Private Sub ResumenTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Function esEmpleadoValido() As Boolean
        Dim N As Integer
        sql = "SELECT COUNT(*) AS 'Total' FROM dbo.FwEmployeeRole " + _
              "WHERE Role IN ('ATS', 'EDTS', 'SUPE') AND Status = 'ACTV' AND Organization = '" + S + "' AND EmployeeId = '" + U + "'"
        N = bdEntero(sql, "Total")
        TS()

        If TS() = U Or N > 0 Then
            esEmpleadoValido = True
        Else
            esEmpleadoValido = False
        End If
    End Function

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                If familiaEsAfiliada(S, Integer.Parse(FamiliaV.Text)) = True Then
                    If esEmpleadoValido() = True Then
                        FamiliaV.ReadOnly = True
                        valoresIniciales()
                        resumen()
                    Else
                        MsgBox("El TS de esta familia es: " + TS() + Chr(13) + _
                               "No tiene acceso a esta familia", vbCritical, My.Resources.versionFamilias2)
                        FamiliaV.Text = ""
                    End If
                Else
                    MsgBox("El número de familia que ingreso no es válido", vbCritical, My.Resources.versionFamilias2)
                    FamiliaV.Text = ""
                    FamiliaV.Focus()
                End If
            End If
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub MesesV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MesesV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New ResumenTS
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub RefMedicasButton_Click(sender As Object, e As EventArgs) Handles RefMedicasButton.Click
        Dim nxt As New ReferenciasSalud
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub referenciaMedica()
        sql = " SELECT COUNT(*)  Ref FROM dbo.fn_HEAL_ReferenciasInternas('TS')  " + _
                 "WHERE  Familia = " + FamiliaV.Text + " AND Sitio = '" + S + "' AND Estado = 'Referencia' "
        Dim refM As Integer = bdEntero(sql, "Ref")
        If refM > 0 Then
            MsgBox("La familia tiene referencia(s) médica(s): " + refM.ToString + vbNewLine + "Puede revisar el listado de referencias médicas", vbExclamation, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub referenciaMedicaEnProceso()
        sql = " SELECT COUNT(*)  Ref FROM dbo.fn_HEAL_ReferenciasInternas('TS')  " + _
                 "WHERE  Familia = " + FamiliaV.Text + " AND Sitio = '" + S + "' AND Estado = 'En proceso' "
        Dim refM As Integer = bdEntero(sql, "Ref")
        If refM > 0 Then
            ReferenciaV.Text = "La familia tiene referencia(s) médica(s)  en proceso: " + refM.ToString
            ReferenciaV.Visible = True
        Else
            ReferenciaV.Text = ""
        End If
    End Sub

    Private Sub resumen()
        IndividualGrid.DataSource = Nothing
        IndividualGrid.Rows.Clear()

        FamiliarGrid.DataSource = Nothing
        FamiliarGrid.Rows.Clear()

        Dim tiempo As Integer = Integer.Parse(MesesV.Text) * 30
        Dim actual As String = DateTime.Now.ToString(en.DateTimeFormat)
        Dim dt, dt2 As New DataTable

        sql = "SELECT Address + ' - ' + Pueblo Direccion FROM dbo.Family F WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        DireccionV.Text = bdPalabra(sql, "Direccion")

        sql = "SELECT Actividad, Fecha, Area " + _
              "FROM dbo.fn_TS_ResumenActividadIndividualA('" + S + "', " + FamiliaV.Text + ", " + tiempo.ToString + ", '" + actual + "' ) Ind " + _
              "ORDER BY Area, rFecha, Actividad "
        bdDataTable(sql, dt)

        'ACTIVIDADES INDIVIDUALES
        dt2.Columns.Add(New DataColumn("Actividad", GetType(String)))
        dt2.Columns.Add(New DataColumn("Fecha", GetType(String)))

        dt2.Rows.Add("ACTIVIDADES DE SALUD", "")
        Dim cl() As DataRow = dt.Select("Area = 'CLIN'")
        For Each row As DataRow In cl
            dt2.Rows.Add(row(0), row(1))
        Next

        dt2.Rows.Add("", "")
        dt2.Rows.Add("ACTIVIDADES DE EDUCACIÓN", "")
        Dim ed() As DataRow = dt.Select("Area = 'EDUC'")
        For Each row As DataRow In ed
            dt2.Rows.Add(row(0), row(1))
        Next

        dt2.Rows.Add("", "")
        dt2.Rows.Add("ACTIVIDADES DE APADRINAMIENTO", "")
        Dim apad() As DataRow = dt.Select("Area = 'APAD'")
        For Each row As DataRow In apad
            dt2.Rows.Add(row(0), row(1))
        Next

        dt2.Rows.Add("", "")
        dt2.Rows.Add(" ACTIVIDADES DE APOYO EDUCATIVO", "")
        Dim psic() As DataRow = dt.Select("Area = 'PSIC'")
        For Each row As DataRow In psic
            dt2.Rows.Add(row(0), row(1))
        Next

        dt2.Rows.Add("", "")
        dt2.Rows.Add("ACTIVIDADES MISCELÁNEAS", "")
        Dim misc() As DataRow = dt.Select("Area = 'MISC'")
        For Each row As DataRow In misc
            dt2.Rows.Add(row(0), row(1))
        Next

        IndividualGrid.DataSource = dt2
        sql = "SELECT * FROM dbo.fn_TS_ResumenActividadesFam('" + S + "', " + FamiliaV.Text + ", " + tiempo.ToString + ", '" + actual + "' ) Fam "
        bdGrid(sql, FamiliarGrid)

        DireccionV.Visible = True
        DireccionL.Visible = True
        MesesV.Enabled = False
    End Sub

    Private Function TS() As String
        sql = "SELECT TS FROM  dbo.v_GEN_FamiliasAfiliadas F2 " + _
              "WHERE sitio = '" + S + "' AND Familia = " + FamiliaV.Text + " "
        TS = bdPalabra(sql, "TS")
        TS = TS
    End Function

    Private Sub valoresIniciales()
        referenciaMedica()
        referenciaMedicaEnProceso()

        MsgBox("Este reporte puede tardar unos minutos en aparecer", vbExclamation, My.Resources.versionFamilias2)
        resumen()
        ResumenTable.Visible = True
    End Sub
End Class