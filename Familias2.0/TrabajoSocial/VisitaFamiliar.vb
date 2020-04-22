' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class VisitaFamiliar
    Dim f1, f2, f3, f4, s1, s2, s3, e1, e2, e3, e4, l1, l2, l3, l4, l5, l6 As String

    Private Sub VisitaFamiliar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        FamiliaV.Focus()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub categorias()
        f1 = ", '" + codigoSubCategoria(FA1.Text)
        If FA1.Checked = True Then
            f1 = f1 + "', 1"
        Else
            f1 = f1 + "', 0"
        End If

        f2 = ", '" + codigoSubCategoria(FA2.Text)
        If FA2.Checked = True Then
            f2 = f2 + "', 1"
        Else
            f2 = f2 + "', 0"
        End If

        f3 = ", '" + codigoSubCategoria(FA3.Text)
        If FA3.Checked = True Then
            f3 = f3 + "', 1"
        Else
            f3 = f3 + "', 0"
        End If

        f4 = ", '" + codigoSubCategoria(FA4.Text)
        If FA4.Checked = True Then
            f4 = f4 + "', 1"
        Else
            f4 = f4 + "', 0"
        End If

        s1 = ", '" + codigoSubCategoria(SA1.Text)
        If SA1.Checked = True Then
            s1 = s1 + "', 1"
        Else
            s1 = s1 + "', 0"
        End If

        s2 = ", '" + codigoSubCategoria(SA2.Text)
        If SA2.Checked = True Then
            s2 = s2 + "', 1"
        Else
            s2 = s2 + "', 0"
        End If

        s3 = ", '" + codigoSubCategoria(SA3.Text)
        If SA3.Checked = True Then
            s3 = s3 + "', 1"
        Else
            s3 = s3 + "', 0"
        End If

        e1 = ", '" + codigoSubCategoria(ED1.Text)
        If ED1.Checked = True Then
            e1 = e1 + "', 1"
        Else
            e1 = e1 + "', 0"
        End If

        e2 = ", '" + codigoSubCategoria(ED2.Text)
        If ED2.Checked = True Then
            e2 = e2 + "', 1"
        Else
            e2 = e2 + "', 0"
        End If

        e3 = ", '" + codigoSubCategoria(ED3.Text)
        If ED3.Checked = True Then
            e3 = e3 + "', 1"
        Else
            e3 = e3 + "', 0"
        End If

        e4 = ", '" + codigoSubCategoria(ED4.Text)
        If ED4.Checked = True Then
            e4 = e4 + "', 1"
        Else
            e4 = e4 + "', 0"
        End If

        l1 = ", '" + codigoSubCategoria(PL1.Text)
        If PL1.Checked = True Then
            l1 = l1 + "', 1"
        Else
            l1 = l1 + "', 0"
        End If

        l2 = ", '" + codigoSubCategoria(PL2.Text)
        If PL2.Checked = True Then
            l2 = l2 + "', 1"
        Else
            l2 = l2 + "', 0"
        End If

        l3 = ", '" + codigoSubCategoria(PL3.Text)
        If PL3.Checked = True Then
            l3 = l3 + "', 1"
        Else
            l3 = l3 + "', 0"
        End If

        l4 = ", '" + codigoSubCategoria(PL4.Text)
        If PL4.Checked = True Then
            l4 = l4 + "', 1"
        Else
            l4 = l4 + "', 0"
        End If

        l5 = ", '" + codigoSubCategoria(PL5.Text)
        If PL5.Checked = True Then
            l5 = l5 + "', 1"
        Else
            l5 = l5 + "', 0"
        End If

        l6 = ", '" + codigoSubCategoria(PL6.Text)
        If PL6.Checked = True Then
            l6 = l6 + "', 1"
        Else
            l6 = l6 + "', 0"
        End If
    End Sub

    Private Function codigoSubCategoria(ByVal desc) As String
        sql = ""
        sql = "SELECT Code FROM CdFamilySubCategoryVisit WHERE DescSpanish = '" + desc + "' "
        codigoSubCategoria = bdPalabra(sql, "Code")
    End Function

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

    Private Function existeVisita(ByVal family As String, ByVal type As String, ByVal DateTimeVisit As DateTime) As Boolean
        Dim N As Integer
        sql = ""
        sql = "SELECT COUNT(*) Total FROM FamilyVisit2 WHERE RecordStatus = ' ' AND VisitType = '" + type + _
              "' AND Project = '" + S + "' AND FamilyId = " + family + " AND YEAR(VisitDate) = " + DateTimeVisit.Year.ToString + _
              " AND Month(VisitDate) = " + DateTimeVisit.Month.ToString + " AND Day(VisitDate) = " + DateTimeVisit.Day.ToString
        N = bdEntero(sql, "Total")
        If N = 0 Then
            existeVisita = False
        Else
            existeVisita = True
        End If
    End Function

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) > 0 Then
                If familiaEsAfiliada(S, Integer.Parse(FamiliaV.Text)) = True Then
                    If esEmpleadoValido() = True Then
                        GuardarButton.Visible = True
                        FamiliaV.ReadOnly = True
                        valoresIniciales()
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

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        guardarVisita()
    End Sub

    Private Sub guardarVisita()
        If TipoVisitaV.Text = "" Or TipoVisitaV.Text = " " Or TipoVisitaV.SelectedIndex = -1 Then
            MsgBox("Necesita seleccionar el tipo de Visita", vbCritical, My.Resources.versionFamilias2)
        Else
            Dim yesNo As String = "SI"
            Dim fechaHora As String = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HoraV.Value.ToLongTimeString

            If fechaValida_NoAnteriores(FechaV.Value) = False Then
                MsgBox("La fecha no puede ser mayor a la actual", vbCritical, My.Resources.versionFamilias2)
            Else
                If verificaVisita(FamiliaV.Text, TipoVisitaV.SelectedValue, fechaHora) = False Then
                    MsgBox("No puede ingresar el mismo tipo de visita con la misma fecha y hora", vbCritical, My.Resources.versionFamilias2)
                    limpiarCampos()
                    yesNo = "NO"
                Else
                    If existeVisita(FamiliaV.Text, TipoVisitaV.SelectedValue, fechaHora) = True Then
                        Dim style As MsgBoxStyle
                        Dim response As MsgBoxResult
                        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                        response = MsgBox("Ya existe el mismo tipo de visita en la misma fecha " + Chr(13) + Chr(13) + _
                                          "¿Esta seguro de ingresarla nuevamente?", style, My.Resources.versionFamilias2)
                        If response = MsgBoxResult.No Then
                            yesNo = "NO"
                        End If
                    End If
                End If

                If yesNo = "SI" Then
                    Dim actualDate As DateTime = Now
                    'SELECT     Project, FamilyId, VisitType, VisitDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, F1, F1v, F2, F2v, F3, F3v, F4, F4v, F, S1, 
                    'S1v, S2, S2v, S3, S3v, S, E1, E1v, E2, E2v, E3, E3v, E4, E4v, E, V, L1, L1v, L2, L2v, L3, L3v, L4, L4v, L5, L5v, L6, L6v, L
                    'FROM(dbo.FamilyVisit2)
                    categorias()

                    sql = ""
                    sql = "INSERT INTO dbo.FamilyVisit2 VALUES ('" + S + "', " + FamiliaV.Text + ", '" + TipoVisitaV.SelectedValue + "', '" + Convert.ToDateTime(fechaHora).ToString(en.DateTimeFormat) + _
                          "', '" + actualDate.ToString(en.DateTimeFormat) + "', ' ', '" + _
                          U + "', NULL" + f1 + f2 + f3 + f4 + ", '" + FO.Text + "'" + s1 + s2 + s3 + ", '" + SO.Text + "'" +
                          e1 + e2 + e3 + e4 + ", '" + EO.Text + "', '" + VO.Text + "'" + l1 + l2 + l3 + l4 + l5 + l6 + ", '" + LO.Text + "')"
                    bdInsertar(sql)

                    If ingresoCorrecto(FamiliaV.Text, TipoVisitaV.SelectedValue, actualDate) = True Then
                        MsgBox("Ingresada correctamente", vbInformation, My.Resources.versionFamilias2)
                        FamiliaV.ReadOnly = False
                        FamiliaV.Text = ""
                        ocultar()
                        limpiarCampos()
                        FamiliaV.Focus()
                    Else
                        MsgBox("Error en el ingreso, avise a Sistemas", vbCritical, My.Resources.versionFamilias2)
                    End If
                Else
                End If
            End If
        End If
    End Sub

    Private Function ingresoCorrecto(ByVal family As String, ByVal type As String, ByVal insertDate As DateTime) As Boolean
        Dim N As Integer
        sql = ""
        sql = "SELECT COUNT(*) Total FROM FamilyVisit2 WHERE RecordStatus = ' ' AND VisitType = '" + type + _
              "' AND Project = '" + S + "' AND FamilyId = " + family + " AND YEAR(CreationDateTime) = " + insertDate.Year.ToString + _
              " AND Month(CreationDateTime) = " + insertDate.Month.ToString + " AND Day(CreationDateTime) = " + insertDate.Day.ToString + _
              " AND { fn HOUR(CreationDateTime) } = " + insertDate.Hour.ToString + " AND { fn MINUTE(CreationDateTime) } = " + insertDate.Minute.ToString + " " + _
              " AND UserId = '" + U + "' "
        N = bdEntero(sql, "Total")
        If N = 0 Then
            ingresoCorrecto = False
        Else
            ingresoCorrecto = True
        End If
    End Function

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        sql = ""
        DireccionV.Text = ""
        TipoVisitaV.Text = ""
        FechaV.Value = Now
        HoraV.Value = Now
        VO.Text = ""

        FA1.Checked = False
        FA2.Checked = False
        FA3.Checked = False
        FA4.Checked = False
        FO.Text = ""

        SA1.Checked = False
        SA2.Checked = False
        SA3.Checked = False
        SO.Text = ""

        ED1.Checked = False
        ED2.Checked = False
        ED3.Checked = False
        ED4.Checked = False
        EO.Text = ""

        PL1.Checked = False
        PL2.Checked = False
        PL3.Checked = False
        PL4.Checked = False
        PL5.Checked = False
        PL6.Checked = False
        LO.Text = ""
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New VisitaFamiliar
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ocultar()
        GuardarButton.Visible = False
        DireccionV.Visible = False
        DireccionL.Visible = False
        TipoVisitaL.Visible = False
        TipoVisitaV.Visible = False
        FechaL.Visible = False
        FechaV.Visible = False
        HoraL.Visible = False
        HoraV.Visible = False
        TSTable.Visible = False
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
        Else
            ReferenciaV.Text = ""
        End If
    End Sub

    Private Function TS() As String
        sql = "SELECT TS FROM  dbo.v_GEN_FamiliasAfiliadas F2 " + _
              "WHERE Sitio = '" + S + "' AND Familia = " + FamiliaV.Text + " "
        TS = bdPalabra(sql, "TS")
        TS = TS
    End Function

    Private Sub valoresIniciales()
        sql = "SELECT Address + ' - ' + Pueblo Direccion FROM dbo.Family F WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyId = " + FamiliaV.Text
        DireccionV.Text = bdPalabra(sql, "Direccion")

        referenciaMedica()
        referenciaMedicaEnProceso()

        sql = "SELECT Code,  DescSpanish Type FROM CdFamilyActivityType WHERE Project = '" + S + "' AND FunctionalArea = 'TS' AND Active = 1"
        bdCombo(sql, TipoVisitaV, "Code", "Type")

        Dim dt As New DataTable
        sql = "SELECT DescSpanish SubC FROM CdFamilySubCategoryVisit WHERE Project = '" + S + "' AND Active = 1 AND Category = 'FAMILIA'"
        bdDataTable(sql, dt)
        FA1.Text = chequearValor(dt.Rows(0)("SubC")).ToString
        FA2.Text = chequearValor(dt.Rows(1)("SubC")).ToString
        FA3.Text = chequearValor(dt.Rows(2)("SubC")).ToString
        FA4.Text = chequearValor(dt.Rows(3)("SubC")).ToString

        dt.Clear()
        sql = "SELECT DescSpanish SubC FROM CdFamilySubCategoryVisit WHERE Project = '" + S + "' AND Active = 1 AND Category = 'SALUD'"
        bdDataTable(sql, dt)
        SA1.Text = chequearValor(dt.Rows(0)("SubC")).ToString
        SA2.Text = chequearValor(dt.Rows(1)("SubC")).ToString
        SA3.Text = chequearValor(dt.Rows(2)("SubC")).ToString

        dt.Clear()
        sql = "SELECT DescSpanish SubC FROM CdFamilySubCategoryVisit WHERE Project = '" + S + "' AND Active = 1 AND Category = 'EDUCACIÓN'"
        bdDataTable(sql, dt)
        ED1.Text = chequearValor(dt.Rows(0)("SubC")).ToString
        ED2.Text = chequearValor(dt.Rows(1)("SubC")).ToString
        ED3.Text = chequearValor(dt.Rows(2)("SubC")).ToString
        ED4.Text = chequearValor(dt.Rows(3)("SubC")).ToString

        dt.Clear()
        sql = "SELECT DescSpanish SubC FROM CdFamilySubCategoryVisit WHERE Project = '" + S + "' AND Active = 1 AND Category = 'PROBLEMAS LEGALES'"
        bdDataTable(sql, dt)
        PL1.Text = chequearValor(dt.Rows(0)("SubC")).ToString
        PL2.Text = chequearValor(dt.Rows(1)("SubC")).ToString
        PL3.Text = chequearValor(dt.Rows(2)("SubC")).ToString
        PL4.Text = chequearValor(dt.Rows(3)("SubC")).ToString
        PL5.Text = chequearValor(dt.Rows(4)("SubC")).ToString
        PL6.Text = chequearValor(dt.Rows(5)("SubC")).ToString

        DireccionV.Visible = True
        DireccionL.Visible = True
        TipoVisitaL.Visible = True
        TipoVisitaV.Visible = True
        FechaL.Visible = True
        FechaV.Visible = True
        HoraL.Visible = True
        HoraV.Visible = True
        TSTable.Visible = True


    End Sub

    Private Function verificaVisita(ByVal family As String, ByVal type As String, ByVal DateTimeVisit As DateTime) As Boolean
        Dim N As Integer
        sql = "SELECT COUNT(*) Total FROM FamilyVisit2 WHERE RecordStatus = ' ' AND VisitType = '" + type + _
              "' AND Project = '" + S + "' AND FamilyId = " + family + " AND YEAR(VisitDate) = " + DateTimeVisit.Year.ToString + _
              " AND Month(VisitDate) = " + DateTimeVisit.Month.ToString + " AND Day(VisitDate) = " + DateTimeVisit.Day.ToString + _
              " AND { fn HOUR(VisitDate) } = " + DateTimeVisit.Hour.ToString
        N = bdEntero(sql, "Total")
        If N > 0 Then
            verificaVisita = False
        Else
            verificaVisita = True
        End If
    End Function

End Class