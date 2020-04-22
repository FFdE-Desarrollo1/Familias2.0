' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class PerfilFamilia
    Dim tr As New recursosFamilias
    Dim desc, miembro, nombre, relFam, tipoAfil, estadoAfilInd, nac, cel, otraAfil, obser, feInac As String

    Private Sub PerfilFamilia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(FamiliaV.Text) > 0 Then
            valoresIniciales()
        End If
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
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamilyR_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles FamilyR.CellContentClick
        Dim c, f As Integer
        c = FamilyR.CurrentCellAddress.X
        f = FamilyR.CurrentCellAddress.Y
        If c = 0 Then
            irPefilMiembro(FamilyR.Item(0, f).Value.ToString)
        End If
    End Sub

    Private Sub irPefilMiembro(ByVal miembro As String)
        If miembroEsValido(S, miembro) = True Then
            Dim nxt As New PerfilMiembro
            nxt.MiembroV.Text = miembro
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub inicioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub miembrosActivos()
        FamilyR.DataSource = Nothing
        FamilyR.Rows.Clear()
        FamilyR.Visible = False

        'miembros de familia
        sql = "SELECT M.MemberId AS '" + miembro + "', M.FirstNames + ' ' + M.LastNames AS '" + nombre + "', " + _
                     "cdMRT." + descripcion() + " AS '" + relFam + "', cdAT." + descripcion() + " AS '" + tipoAfil + "', cdAS." + descripcion() + " AS '" + estadoAfilInd + "', " + _
                     "dbo.fn_GEN_FormatDate (M.BirthDate, '" + L + " ')  AS '" + nac + "', M.CellularPhoneNumber '" + cel + "', cdOA." + descripcion() + " AS '" + otraAfil + "', " + _
                     "CASE WHEN M.LiveDead = 'M' THEN 'Fallecido - ' + dbo.fn_GEN_FormatDate (M.DeathDate, '" + L + " ')  ELSE '' END " + obser + " " + _
                     "FROM dbo.Member M INNER JOIN dbo.FamilyMemberRelation FMR ON M.Project = FMR.Project " + _
                     "AND M.MemberId = FMR.MemberId AND M.LastFamilyId = FMR.FamilyId AND M.RecordStatus = FMR.RecordStatus " + _
                     "AND FMR.InactiveDate IS NULL INNER JOIN dbo.CdFamilyMemberRelationType cdMRT ON FMR.Type = cdMRT.Code " + _
                     "LEFT OUTER JOIN dbo.CdOtherAffiliation cdOA ON M.OtherAffiliation = cdOA.Code LEFT OUTER JOIN " + _
                     "dbo.CdAffiliationStatus cdAS ON M.AffiliationStatus = cdAS.Code LEFT OUTER JOIN dbo.CdAffiliationType cdAT " + _
                     "ON M.AffiliationType = cdAT.Code  " + _
                     "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND FMR.FamilyId = '" + FamiliaV.Text + "' " + _
                     "ORDER BY cdMRT.DisplayOrder "
        bdGrid(sql, FamilyR)
        agregarColumnaAccion(0, FamilyR)
        If FamilyR.RowCount > 0 Then
            For Each r As DataGridViewRow In FamilyR.Rows
                FamilyR.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
            Next
        End If
        FamilyR.ClearSelection()
        FamilyR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        FamilyR.Visible = True
    End Sub

    Private Sub miembrosInactivos()
        FamilyR.DataSource = Nothing
        FamilyR.Rows.Clear()
        FamilyR.Visible = False
        'miembros de familia
        sql = "SELECT M.MemberId AS 'No. Miembro', M.FirstNames + ' ' + M.LastNames AS Nombre, " + _
                     "cdMRT.DescSpanish AS Relacion, cdAT.DescSpanish AS 'Tipo de Afilacion', cdAS.DescSpanish AS 'Estado de Afilacion', " + _
                     "dbo.fn_GEN_FormatDate (M.BirthDate, 'ES')  AS 'Fecha de Nacimiento', cdOA.DescSpanish AS 'Otra Afiliacion', " + _
                     "CASE WHEN M.LiveDead = 'M' THEN 'Fallecido - ' + dbo.fn_GEN_FormatDate (M.DeathDate, 'ES')  ELSE '' END Observaciones, " + _
                     "dbo.fn_GEN_FormatDate (InactiveDate, 'ES') '" + feInac + "' , cdRMRIR." + descripcion() + "  Razon  " + _
                     "FROM dbo.Member M INNER JOIN dbo.FamilyMemberRelation FMR ON M.Project = FMR.Project " + _
                     "AND M.MemberId = FMR.MemberId AND M.LastFamilyId = FMR.FamilyId AND M.RecordStatus = FMR.RecordStatus " + _
                     "INNER JOIN dbo.CdFamilyMemberRelationType cdMRT ON FMR.Type = cdMRT.Code " + _
                     "LEFT OUTER JOIN dbo.CdOtherAffiliation cdOA ON M.OtherAffiliation = cdOA.Code LEFT OUTER JOIN " + _
                     "dbo.CdAffiliationStatus cdAS ON M.AffiliationStatus = cdAS.Code LEFT OUTER JOIN dbo.CdAffiliationType cdAT " + _
                     "ON M.AffiliationType = cdAT.Code  LEFT JOIN CdFamMemRelInactiveReason cdRMRIR ON cdRMRIR.Code = FMR.InactiveReason " + _
                     "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND FMR.FamilyId = '" + FamiliaV.Text + "' " + _
                     "ORDER BY cdMRT.DisplayOrder "
        bdGrid(sql, FamilyR)
        agregarColumnaAccion(0, FamilyR)
        If FamilyR.RowCount > 0 Then
            For Each r As DataGridViewRow In FamilyR.Rows
                FamilyR.Rows(r.Index).HeaderCell.Value = (r.Index + 1).ToString()
            Next
        End If
        FamilyR.ClearSelection()
        FamilyR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        FamilyR.Visible = True
    End Sub

    Private Sub traducir()
        AvisosL.Text = tr.traduce("FamilyWarnings")
        cel = tr.traduce("CellularNumber")
        ClasificacionL.Text = tr.traduce("Classification")
        DireccionL.Text = tr.traduce("Address")
        estadoAfilInd = tr.traduce("AffiliationStatus")
        EstadoAfilL.Text = tr.traduce("AffiliationStatus")
        EtniaL.Text = tr.traduce("Ethnicity")
        FamiliaresActivosL.Text = tr.traduce("MembersOfFamily")
        FamiliaL.Text = tr.traduce("FamilyId")
        FechaClasificacionL.Text = tr.traduce("ClassificationDate")
        FechaEstadoAfilL.Text = tr.traduce("AffiliationStatusDate")
        feInac = tr.traduce("InactiveDate")
        miembro = tr.traduce("MemberId")
        nac = tr.traduce("BirthDate")
        nombre = tr.traduce("Name")
        obser = tr.traduce("Observations")
        otraAfil = tr.traduce("OtherAffiliation")
        PuebloL.Text = tr.traduce("Town")
        RegionL.Text = tr.traduce("Region")
        relFam = tr.traduce("FamilyRelation")
        TelL.Text = tr.traduce("TelephoneNumber")
        tipoAfil = tr.traduce("AffiliationType")
        Title.Text = tr.traduce("FamilyProfile")
        TSL.Text = tr.traduce("SocialWorker")
        verInactivosLink.Text = "(" + tr.traduce("ShowInactives") + ")"
    End Sub

    Private Sub valoresIniciales()
        If L = "en" Then
            traducir()
        Else
            miembro = "Miembro"
            nombre = "Nombre"
            relFam = "Rel. Familiar"
            tipoAfil = "Tipo Afil."
            estadoAfilInd = "Estado Afil."
            nac = "Nacimiento"
            cel = "Celular"
            otraAfil = "Otra Afil."
            obser = "Observaciones"
            feInac = "Fecha Inactiva"
        End If
        'información general de la familia
        Dim GenInfo As New DataTable
        Dim sql As String = "SELECT F.Address AS Direccion, F.Pueblo, F.TelephoneNumber AS 'No. Telefono', " + _
                                   "dbo.CdEthnicity." + descripcion() + " AS Etnia, dbo.CdGeographicArea." + descripcion() + " AS Area " + _
                                   "FROM dbo.Family F LEFT OUTER JOIN dbo.CdEthnicity ON F.Ethnicity = dbo.CdEthnicity.Code " + _
                                   "LEFT OUTER JOIN dbo.CdGeographicArea ON F.Project = dbo.CdGeographicArea.Project AND " + _
                                   "F.Area = dbo.CdGeographicArea.Code " + _
                                   "WHERE F.RecordStatus = ' ' AND F.FamilyId = " + FamiliaV.Text + " AND F.Project = '" + S + "'"
        bdDataTable(sql, GenInfo)
        AddressV.Text = chequearValor(GenInfo.Rows(0)("Direccion"))
        PuebloV.Text = chequearValor(GenInfo.Rows(0)("Pueblo"))
        TelV.Text = chequearValor(GenInfo.Rows(0)("No. Telefono"))
        AreaV.Text = chequearValor(GenInfo.Rows(0)("Area"))
        EtnV.Text = chequearValor(GenInfo.Rows(0)("Etnia"))

        If S = "E" Then
            Panel2.Visible = False
        Else
            If familiaEsAfiliada(S, FamiliaV.Text) = True Or familiaEsDesafiliadaGraduada(S, FamiliaV.Text) = True Then
                'Info Afiliación
                Dim GenInfo2 As New DataTable
                sql = "SELECT F.FamilyId, cdAL." + descripcion() + " AS Nivel, cdAS." + descripcion() + " AS 'Estado', " + _
                       "dbo.fn_GEN_FormatDate (F.AffiliationStatusDate, '" + L + " ') AS 'Fecha Afiliacion', F.Classification AS Clasificacion, " + _
                       "dbo.fn_GEN_FormatDate (F.ClassificationDate, '" + L + " ') AS 'Fecha Clasificacion',FER.EmployeeId AS TS " + _
                      "FROM dbo.Family F INNER JOIN dbo.CdAffiliationLevel cdAL ON F.AffiliationLevel = cdAL.Code INNER JOIN " + _
                       "dbo.CdAffiliationStatus cdAS ON F.AffiliationStatus = cdAS.Code LEFT JOIN dbo.FamilyEmployeeRelation FER ON " + _
                       "F.Project = FER.Project AND F.FamilyId = FER.FamilyId AND F.RecordStatus = FER.RecordStatus AND FER.EndDate IS NULL " + _
                      "WHERE F.RecordStatus = ' ' AND F.Project = '" + S + "' AND F.FamilyId = " + FamiliaV.Text
                bdDataTable(sql, GenInfo2)

                TSocialV.Text = chequearValor(GenInfo2.Rows(0)("TS"))
                ClasificacionV.Text = chequearValor(GenInfo2.Rows(0)("Clasificacion"))
                EstadoAV.Text = chequearValor(GenInfo2.Rows(0)("Estado"))
                FechaEAV.Text = chequearValor(GenInfo2.Rows(0)("Fecha Afiliacion"))
                FechaCV.Text = chequearValor(GenInfo2.Rows(0)("Fecha Clasificacion"))
                RegionV.Text = regionFam(FamiliaV.Text)
            End If
        End If

        miembrosActivos()
        avisosFamiliares()
    End Sub

    Private Sub verInactivosLink_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles verInactivosLink.LinkClicked
        If verInactivosLink.Text = "(Ver Inactivos)" Or verInactivosLink.Text = "(Show Inactives)" Then
            miembrosInactivos()
            verInactivosLink.Text = "(" + tr.traduce("Actives") + ")"
        Else
            miembrosActivos()
            verInactivosLink.Text = "(" + tr.traduce("ShowInactives") + ")"
        End If
    End Sub

End Class