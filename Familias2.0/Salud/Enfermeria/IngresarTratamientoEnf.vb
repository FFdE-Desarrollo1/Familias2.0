' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class IngresarTratamientoEnf
    Dim memberId As Integer
    Dim añoHist As DateTime = DateTime.Now.AddYears(-1)

    Private Sub IngresarTratamientoEnf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
        If Len(MiembroV.Text) = 0 Then
            FamiliaV.Focus()
        Else
            infoGen()
            TratamientoDate.Focus()
        End If
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

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(FamiliaV.Text) = 0 Then
            Else
                irMiembrosDeFamilia()
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub irMiembrosDeFamilia()
        If familiaEsValida(S, Integer.Parse(FamiliaV.Text)) = True Then
            Dim nxt As New MiembrosFamilia
            nxt.familyId = FamiliaV.Text
            nxt.transac = "ITRE"
            nxt.Show()
            Me.Close()
        Else
            MsgBox("El número de familia no existe", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim cant As String
        If Len(CantidadV.Text) = 0 Then
            cant = "NULL"
        Else
            cant = CantidadV.Text
        End If
        'IdTreatment, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, Project, MemberId, Physician, RefDateTime, Treatment, Quantity, 
        'Instruction, IdConsultation, TreatDateTime, TreatBy, Observations
        sql = "SELECT MAX(IdTreatment) AS Ultimo FROM dbo.MemberNursTreatment "
        Dim id As Integer = bdEntero(sql, "Ultimo") + 1
        sql = "INSERT INTO dbo.MemberNursTreatment VALUES(" + id.ToString + ", GETDATE(), ' ', '" + U + "', NULL, '" + S + "', " + MiembroV.Text + ", NULL, NULL, " + _
              "'" + TratamientoV.SelectedValue + "', " + cant + ", '" + InstrV.Text + "', NULL, '" + TratamientoDate.Value.ToString(en.DateTimeFormat) + "', '" + U + "','" + ObserV.Text + "')"
        bdInsertar(sql)

        TratamientoV.SelectedIndex = -1
        CantidadV.Text = ""
        InstrV.Text = ""
        TratamientoDate.Value = DateTime.Now
        ObserV.Text = ""
        verHistorialTratamientos()
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code, DescSpanish FROM CdHealthTreatment WHERE FunctionalArea = 'CLIN' AND Active = 1 "
        bdCombo(sql, TratamientoV, "Code", "DescSpanish")
    End Sub

    Private Sub infoGen()
        If miembroEsValido(S, MiembroV.Text) = True Then
            If (S = "E" Or S = "A") Or tieneDerechosSalud(S, MiembroV.Text) = True Then
                Dim genInfo As New DataTable
                sql = "SELECT M.FirstNames + ' ' + M.LastNames Nombre, M.LastFamilyId Familia, F.Classification Clasificacion " + _
                      "FROM Member M INNER JOIN Family F ON M.RecordStatus = F.RecordStatus AND " + _
                      "M.Project = F.Project AND M.LastFamilyId = F.FamilyId WHERE M.RecordStatus = ' '  AND M.Project = '" + S + "' AND M.MemberId = " + MiembroV.Text
                bdDataTable(sql, genInfo)
                NombreV.Text = chequearValor(genInfo.Rows(0)("Nombre")).ToString
                FamiliaV.Text = chequearValor(genInfo.Rows(0)("Familia")).ToString
                Dim familia As Integer = Integer.Parse(FamiliaV.Text)
                GenInfoTable.Visible = True
                MiembroV.ReadOnly = True
                FamiliaV.ReadOnly = True
                PrincipalTable.Visible = True
                TratamientoV.Focus()
                GuardarButton.Visible = True
            Else
                MiembroV.Text = ""
                FamiliaV.Text = ""
                NuevoButton.Focus()
                MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
            End If
        Else
            MsgBox("El número de paciente no existe", vbQuestion, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub MiembroV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MiembroV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If Len(MiembroV.Text) = 0 Then
            Else
                If miembroEsValido(S, MiembroV.Text) = True Then
                    memberId = Integer.Parse(MiembroV.Text)
                    infoGen()
                Else
                    MsgBox("El paciente no tiene derechos de Salud", vbQuestion, My.Resources.versionFamilias2)
                End If
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New IngresarTratamientoEnf
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub HistorialEnfeL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialEnfeL.Click
        verHistorialTratamientos()
    End Sub

    Private Function turnoDisponible() As Boolean
        Dim actual As DateTime = DateTime.Now
        Dim N, turnos As Integer
        sql = "SELECT PropertyValue FROM dbo.FwApplicationProperty WHERE Category = 'ENFE' AND Name = 'TurnsByDay'"
        turnos = Integer.Parse(bdPalabra(sql, "PropertyValue"))

        sql = "SELECT COUNT(*) AS Total FROM dbo.MemberNursTreatment T " + _
              "WHERE RecordStatus = ' ' AND YEAR(RefDateTime) = " + TratamientoDate.Value.Year.ToString + " AND MONTH(RefDateTime) = " + TratamientoDate.Value.Month.ToString + " AND Day(RefDateTime) = " + TratamientoDate.Value.Day.ToString
        N = bdEntero(sql, "Total")
        sql = "SELECT COUNT(*) AS Total FROM dbo.MemberNursTreatment T " + _
              "WHERE RecordStatus = ' ' AND RefDateTime IS NULL AND  YEAR(TreatDateTime) = " + TratamientoDate.Value.Year.ToString + " AND MONTH(TreatDateTime) = " + TratamientoDate.Value.Month.ToString + " AND Day(TreatDateTime) = " + TratamientoDate.Value.Day.ToString
        N = N + bdEntero(sql, "Total")

        If N < turnos Then
            turnoDisponible = True
        Else
            turnoDisponible = False
        End If
    End Function

    Private Sub verHistorialTratamientos()
        'fill treatments
        sql = "SELECT dbo.fn_GEN_FormatDate(T.RefDateTime, 'ES') AS Referido, CdT.DescSpanish AS Tratamiento, T.Quantity AS Cantidad, " + _
                "T.Instruction AS Instrucciones, T.Physician AS 'Referido Por', dbo.fn_GEN_FormatDate(T.TreatDateTime, 'ES') AS Atendido, " + _
                "T.TreatBy AS 'Atendido Por', Observations Observaciones " + _
              "FROM dbo.MemberNursTreatment T INNER JOIN dbo.CdHealthTreatment CdT ON T.Treatment = CdT.Code " + _
              "WHERE T.RecordStatus = ' ' AND T.Project = '" + S + "' AND T.MemberId = " + MiembroV.Text + " " + _
              "AND CONVERT(VARCHAR(10), T.CreationDateTime, 103) >= CONVERT(VARCHAR(10), '" + añoHist + "', 103) " + _
              "ORDER BY T.CreationDateTime DESC"
        bdGrid(sql, EnferHistory)
    End Sub
End Class