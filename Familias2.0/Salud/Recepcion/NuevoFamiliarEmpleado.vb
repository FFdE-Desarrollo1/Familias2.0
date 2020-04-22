' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class NuevoFamiliarEmpleado
    Dim relJefe As String

    Private Sub NuevoFamiliarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(FamiliaV.Text) = 0 Then
            Dim mn As New BusquedaEmpleado
            mn.TransL.Text = "NFE"
            mn.Show()
            Me.Close()
        Else
            valoresIniciales()
            genInfo()
        End If

    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliaV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FamiliaV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If S = "E" Then
                genInfo()
            Else
                MsgBox("Necesita estar en el sitio de Empleados", vbQuestion, My.Resources.versionFamilias2)
            End If
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GeneroCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneroCombo.SelectedIndexChanged
        If GeneroCombo.SelectedIndex < 0 Then
        Else
            CodigoGeneroL.Text = GeneroCombo.SelectedValue.ToString
            llenarComboRelFam()
        End If
    End Sub

    Private Sub genInfo()
        sql = "SELECT COUNT(*) AS Total FROM Family WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyID = " + FamiliaV.Text
        If bdEntero(sql, "Total") > 0 Then
            sql = "SELECT  M.MemberId as Miembro, M.PreferredName AS Usual, M.FirstNames + ' ' + M.LastNames AS Nombre,   CdR.DescSpanish Relación, dbo.fn_GEN_FormatDate (M.BirthDate, 'ES') Nacimiento " + _
                   "FROM dbo.Member M INNER JOIN dbo.FamilyMemberRelation FMR ON M.Project = FMR.Project AND M.LastFamilyId = FMR.FamilyId " + _
                  "AND M.MemberId = FMR.MemberId AND M.RecordStatus = FMR.RecordStatus AND FMR.InactiveDate IS NULL " + _
                  "INNER JOIN dbo.CdFamilyMemberRelationType CdR ON FMR.Type = CdR.Code " + _
                  "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND FMR.FamilyId = " + FamiliaV.Text + " " + _
                  "ORDER BY CdR.DisplayOrder "
            bdGrid(sql, MemberList)
            InfoTable.Visible = True
            FamiliaV.Enabled = False
            NombresV.Focus()
        Else
            MsgBox("No existe la familia en este sitio", vbQuestion, My.Resources.versionFamilias2)
            FamiliaV.Text = ""
        End If
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Dim birS As String = BirthDatePicker.Value.ToShortDateString()
        Dim actS As String = DateTime.Now.ToShortDateString

        If NombresV.Text = "" Or ApellidosV.Text = "" Or GeneroCombo.Text = "" _
           Or RelFamiliarCombo.Text = "" Then
            MsgBox("Nombres, Apellidos y Género necesitan un valor", vbQuestion, My.Resources.versionFamilias2)
        ElseIf birS = actS Or BirthDatePicker.Value.Year > DateTime.Now.Year Then
            MsgBox("Fecha de nacimiento necesita ser menor a la fecha actual ", vbQuestion, My.Resources.versionFamilias2)
        Else
            guardarNuevoMiembro()
            DatosTable.Visible = False
            genInfo()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub llenarComboRelFam()
        If GeneroCombo.Text = " " Or GeneroCombo.Text = "" Then
        Else
            Dim temp
            temp = "SELECT Code Codigo, DescSpanish AS Descripcion " + _
                     "FROM dbo.CdFamilyMemberRelationType " + _
                     "WHERE Active = 0 AND Gender = '" + CodigoGeneroL.Text + "'  AND Code LIKE '2%' " + _
                     "ORDER BY DescSpanish "
            bdCombo(temp, RelFamiliarCombo, "Codigo", "Descripcion")
            RelFamiliarCombo.SelectedIndex = -1
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New NuevoFamiliarEmpleado
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub guardarNuevoMiembro()
        Dim memberId As Integer = 1 + ultimoIdEmpleado()

        'Ingresar Empleado
        sql = "INSERT INTO dbo.Member VALUES ('" + S + "', " + memberId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, " + _
                  FamiliaV.Text + ", '" + NombresV.Text + "', '" + _
                  ApellidosV.Text + "', '" + NombreUsual.Text + "', '" + BirthDatePicker.Value.ToString(en.DateTimeFormat) + _
                  "', '" + GeneroCombo.Text + "', NULL, NULL, NULL, 'V', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL) "
        bdInsertar(sql)

        'Ingresar Info Miscelanea de Empleado
        sql = "INSERT INTO dbo.MiscMemberInfo VALUES ('" + S + "', " + memberId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, NULL, NULL, NULL, NULL, NULL) "
        bdInsertar(sql)

        'Ingresar Relación Familiar
        sql = "INSERT INTO dbo.FamilyMemberRelation VALUES ('" + S + "', " + FamiliaV.Text + ", " + memberId.ToString + ", " + _
           "'" + RelFamiliarCombo.SelectedValue.ToString + "', GETDATE(), GETDATE(), " + _
           "' ', '" + U + "', NULL, NULL, NULL)"
        bdInsertar(sql)

        GuardarButton.Visible = False
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code Codigo, DescSpanish FROM dbo.CdGender WHERE Code <> 'D'"
        bdCombo(sql, GeneroCombo, "Codigo", "Descripcion")
        GeneroCombo.SelectedIndex = -1

        InfoTable.Visible = False
        FamiliaV.Enabled = True
        NombreUsual.Focus()
        BirthDatePicker.Value = DateTime.Today
        RelFamiliarCombo.Text = ""
    End Sub
End Class