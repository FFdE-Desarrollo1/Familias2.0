' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class NuevoEmpleado
    Dim relJefe As String
    Dim familyId As Integer

    Private Sub NuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub ApellidosV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApellidosV.TextChanged
        If ApellidosV.Text = "" Or ApellidosV.Text = " " Then
        Else
            buscarCandidatos("AND M.LastNames like '" + ApellidosV.Text + "%' ")
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub buscarCandidatos(ByVal campo As String)
        sql = "SELECT FMR.FamilyId Familia, M.MemberId as Miembro, M.PreferredName AS Usual, M.FirstNames + ' ' + M.LastNames AS Nombre,   CdR.DescSpanish Relación, dbo.fn_GEN_FormatDate (M.BirthDate, 'ES') Nacimiento " + _
               "FROM dbo.Member M INNER JOIN dbo.FamilyMemberRelation FMR ON M.Project = FMR.Project AND M.LastFamilyId = FMR.FamilyId " + _
              "AND M.MemberId = FMR.MemberId AND M.RecordStatus = FMR.RecordStatus AND FMR.InactiveDate IS NULL " + _
              "INNER JOIN dbo.CdFamilyMemberRelationType CdR ON FMR.Type = CdR.Code " + _
              "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' " + campo + _
              "ORDER BY M.FirstNames, M.LastNames "
        bdGrid(sql, MemberList)
        MemberList.Visible = True
    End Sub

    Private Function existeEmpleado() As Boolean
        Dim nu, na As Integer
        existeEmpleado = False
        sql = "SELECT COUNT(*) AS Total FROM Member M WHERE RecordStatus = ' '  AND Project = '" + S + "' AND PreferredName = '" + NombreUsual.Text + "' "
        nu = bdEntero(sql, "Total")

        sql = "SELECT COUNT(*) AS Total FROM Member M WHERE RecordStatus = ' '  AND Project = '" + S + "' AND DAY(BirthDate) = " + BirthDatePicker.Value.Day.ToString + " " + _
              "AND Month(BirthDate) = " + BirthDatePicker.Value.Month.ToString + " " + " AND YEAR(BirthDate) = " + BirthDatePicker.Value.Year.ToString
        na = bdEntero(sql, "Total")

        If nu > 0 And na > 0 Then
            existeEmpleado = True
        End If
    End Function

    Private Sub GeneroCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneroCombo.SelectedIndexChanged
        If GeneroCombo.SelectedIndex < 0 Then
        Else
            CodigoGeneroL.Text = GeneroCombo.SelectedValue.ToString
            llenarComboRelFam()
        End If
    End Sub

    Private Sub genInfo()
        sql = "SELECT F.FamilyId Familia, M.MemberId as Miembro, M.PreferredName AS Usual, M.FirstNames + ' ' + M.LastNames AS Nombre,   " + _
              "CdR.DescSpanish Relación, dbo.fn_GEN_FormatDate (M.BirthDate, 'ES') Nacimiento, F.Address " + _
               "FROM dbo.Member M INNER JOIN dbo.FamilyMemberRelation FMR ON M.Project = FMR.Project AND M.LastFamilyId = FMR.FamilyId " + _
              "AND M.MemberId = FMR.MemberId AND M.RecordStatus = FMR.RecordStatus AND FMR.InactiveDate IS NULL " + _
              "INNER JOIN dbo.CdFamilyMemberRelationType CdR ON FMR.Type = CdR.Code " + _
              "INNER JOIN dbo.Family F ON F.RecordStatus = FMR.RecordStatus AND F.FamilyId = FMR.FamilyId AND F.Project = FMR.Project " + _
              "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND FMR.FamilyId = " + familyId.ToString + " " + _
              "ORDER BY M.PreferredName, M.FirstNames, F.FamilyId, M.MemberId "
        bdGrid(sql, MemberList)
        InfoTable.Visible = True
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
            If existeEmpleado() = True Then
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                response = MsgBox("¿Esta seguro de ingresar a este empleado nuevamente?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    guardarNuevoEmpleado()
                End If
            Else
                guardarNuevoEmpleado()
            End If
            DatosTable.Visible = False
        End If
    End Sub

    Private Sub guardarNuevoEmpleado()
        Dim memberId As Integer = 1 + ultimoIdEmpleado()
        familyId = 1 + ultimoIdFamiliaEmpleado()

        sql = "INSERT INTO dbo.Family VALUES ('" + S + "', " + familyId.ToString + ", GETDATE(), ' ', '" + U + _
                      "', NULL, NULL, NULL, NULL, NULL, NULL, '" + CiudadV.Text + "', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)"
        bdInsertar(sql)

        sql = "SELECT COUNT(*) AS Total FROM Family WHERE RecordStatus = ' ' AND Project = '" + S + "' AND FamilyID = " + familyId.ToString
        If bdEntero(sql, "Total") > 0 Then
            'Ingresar Condiciones de Familia
            sql = "INSERT INTO dbo.FamilyLivingCondition (Project,FamilyId,CreationDateTime,RecordStatus,UserId,ExpirationDateTime,Ownership,PropertySizeX,PropertySizeY,NumberOfRooms,WallMaterial,WallMaterialQuality,CeilingMaterial,CeilingMaterialQuality,FloorMaterial,FloorMaterialQuality,KitchenWallMaterial,KitchenWallMaterialQuality,Water,Electricity,Bathroom,Drainage,Hygiene,HygieneNotes,KitchenCeilingMaterial,KitchenCeilingMaterialQuality,CultivatedPropertySizeX,CultivatedPropertySizeY,CeilingNotes,WallNotes,KitchenCeilingNotes,KitchenWallNotes,FloorNotes,Has2ndFloor,HouseDeed) " + _
                  "VALUES ('" + S + "'," + familyId.ToString + ",GETDATE(),' ','" + U + "',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0) "

            'Ingresar Empleado
            sql = "INSERT INTO dbo.Member VALUES ('" + S + "', " + memberId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, " + _
                      familyId.ToString + ", '" + NombresV.Text + "', '" + _
                      ApellidosV.Text + "', '" + NombreUsual.Text + "', '" + BirthDatePicker.Value.ToString(en.DateTimeFormat) + _
                      "', '" + GeneroCombo.Text + "', NULL, NULL, NULL, 'V', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL) "
            bdInsertar(sql)

            'Ingresar Info Miscelanea de Empleado
            sql = "INSERT INTO dbo.MiscMemberInfo VALUES ('" + S + "', " + memberId.ToString + ", GETDATE(), ' ', '" + U + "', NULL, NULL, NULL, NULL, NULL, NULL) "
            bdInsertar(sql)

            'Ingresar Relación Familiar
            sql = "INSERT INTO dbo.FamilyMemberRelation VALUES ('" + S + "', " + familyId.ToString + ", " + memberId.ToString + ", " + _
               "'" + RelFamiliarCombo.SelectedValue.ToString + "', GETDATE(), GETDATE(), " + _
               "' ', '" + U + "', NULL, NULL, NULL)"
            bdInsertar(sql)

            GuardarButton.Visible = False
            genInfo()
        Else
            MsgBox("Error al ingresar la familia del nuevo empleado", vbQuestion, "FAMILIAS 2.0")
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
                     "WHERE Active = 0 AND Gender = '" + CodigoGeneroL.Text + "'  AND Code LIKE '1%' " + _
                     "ORDER BY DescSpanish "
            bdCombo(temp, RelFamiliarCombo, "Codigo", "Descripcion")
            If GeneroCombo.Text = "F" Then
                RelFamiliarCombo.SelectedValue = "JEFE"
            ElseIf GeneroCombo.Text = "M" Then
                RelFamiliarCombo.SelectedValue = "JEFM"
            Else
                RelFamiliarCombo.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub NombresV_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombresV.TextChanged
        If NombresV.Text = "" Or NombresV.Text = " " Then
        Else
            buscarCandidatos("AND M.FirstNames like '" + NombresV.Text + "%' ")
        End If
    End Sub

    Private Sub NombreUsual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreUsual.TextChanged
        If NombreUsual.Text = "" Or NombreUsual.Text = " " Then
        Else
            buscarCandidatos("AND M.PreferredName like '" + NombreUsual.Text + "%' ")
        End If
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New NuevoEmpleado
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub valoresIniciales()
        MemberList.Visible = False

        sql = "SELECT Code Codigo, DescSpanish FROM dbo.CdGender WHERE Code <> 'D'"
        bdCombo(sql, GeneroCombo, "Codigo", "Descripcion")
        GeneroCombo.SelectedIndex = -1

        NombreUsual.Focus()
    End Sub

End Class