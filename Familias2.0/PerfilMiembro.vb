' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class PerfilMiembro
    Dim tr As New recursosFamilias
    Dim color, idSpon, nomSpon As String

    Private Sub PerfilMiembro_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BannerInfo()
        If Len(MiembroV.Text) > 0 Then
            valoresIniciales()
        End If
        FamiliaV.Focus()
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

    Private Sub derechos()
        sql = "SELECT dbo.fn_GEN_derechosSalud('" + S + "', " + MiembroV.Text + ", '" + L + "') Derechos "
        Dim sal As String = bdPalabra(sql, "Derechos")

        If tieneDerechosSalud(S, MiembroV.Text) = False Then
            ViviendaR.Text = ""
            EducacionR.Text = ""
            ClinicaR.Text = sal
        Else
            If esAfiliado(S, MiembroV.Text) = True Or esApadrinado(S, MiembroV.Text) = True Then
                ViviendaR.Text = tr.traduce("Construction")
                EducacionR.Text = tr.traduce("Education")
                ClinicaR.Text = tr.traduce("Clinic") + " (" + sal + ")"
            ElseIf esProyeccionSocial(S, MiembroV.Text) = True Then
                ClinicaR.Text = tr.traduce("Clinic") + " (" + sal + ")"
                EducacionR.Text = tr.traduce("Education")
                ViviendaR.Text = ""
            Else
                ClinicaR.Text = tr.traduce("Clinic") + " (" + sal + ")"
                ViviendaR.Text = ""
                EducacionR.Text = ""
            End If
        End If
    End Sub

    Private Sub FamiliaV_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles FamiliaV.LinkClicked
        If Len(FamiliaV.Text) > 0 Then
            irPefilFamilia()
        End If
    End Sub

    Private Sub infoGen()
        Dim educInfo As New DataTable
        Dim actualDate As String = DateTime.Now.Year.ToString + "/" + DateTime.Now.Month.ToString + "/" + DateTime.Now.Day.ToString
        Dim genInfo As New DataTable
        sql = "SELECT   M.FirstNames, M.LastNames, M.PreferredName, M.LiveDead, M.Gender, dbo.fn_GEN_FormatDate(M.BirthDate, 'es') AS BirthDate, " + _
                 "dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad, dbo.fn_AFIL_faseDesafil(M.Project, M.MemberId) AS Fase, dbo.fn_GEN_Semaforo(M.Project,  " + _
                 "M.MemberId) AS Semaforo, M.LastFamilyId FamilyId, cdAT.DescSpanish AS AffiliationType, cdAS.DescSpanish AS AffiliationStatus, " + _
                 "dbo.fn_GEN_FormatDate(M.AffiliationStatusDate, 'es') AS AffiliationStatusDate " + _
                "FROM dbo.Member M LEFT OUTER JOIN  dbo.CdAffiliationStatus cdAS ON M.AffiliationStatus = cdAS.Code " + _
                "LEFT OUTER JOIN dbo.CdAffiliationType cdAT ON M.AffiliationType = cdAT.Code " + _
                "WHERE  M.MemberId = " + MiembroV.Text + " AND M.Project = '" + S + "' AND M.RecordStatus = ' ' "
        bdDataTable(sql, genInfo)

        'general information
        FirstNameV.Text = chequearValor(genInfo.Rows(0)("FirstNames"))
        LastNameV.Text = chequearValor(genInfo.Rows(0)("LastNames"))
        PrefNameV.Text = chequearValor(genInfo.Rows(0)("PreferredName"))
        LiveDeadV.Text = chequearValor(genInfo.Rows(0)("LiveDead"))
        GeneroV.Text = chequearValor(genInfo.Rows(0)("Gender"))
        BirthV.Text = chequearValor(genInfo.Rows(0)("BirthDate"))
        AgeV.Text = chequearValor(genInfo.Rows(0)("Edad"))
        FaseV.Text = chequearValor(genInfo.Rows(0)("Fase"))
        color = chequearValor(genInfo.Rows(0)("Semaforo"))
        'GradeV.Text = chequearValor(genInfo.Rows(0)("Grado"))
        FamiliaV.Text = chequearValor(genInfo.Rows(0)("FamilyId"))
        AfilTypeV.Text = chequearValor(genInfo.Rows(0)("AffiliationType"))

        NoMiembro = MiembroV.Text
        NoFamilia = FamiliaV.Text
        'affiliation information
        If S <> "P" Or S <> "E" Then
            If AfilTypeV.Text = "" Then
                SemaforoL.Visible = False
                FaseL.Visible = False

                sql = "SELECT cdG." + descripcion() + " 'Grado', cdEs." + descripcion() + " 'Estado', m.LastGradePassedYear 'Año' " +
                         "FROM dbo.Member M LEFT JOIN cdGrade cdG ON cdG.Code = M.LastGradePassed LEFT JOIN CdEducationStatus cdES ON cdEs.code = m.LastGradePassedStatus " + _
                         "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND M.Memberid = " + MiembroV.Text

                bdDataTable(sql, educInfo)
                GradeV.Text = chequearValor(educInfo.Rows(0)("Estado")) & " " & chequearValor(educInfo.Rows(0)("Grado")) & " " & chequearValor(educInfo.Rows(0)("Año").ToString)
            Else
                sql = "SELECT COUNT(*) R FROM MemberEducationYear WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId =  " + MiembroV.Text + "  "
                If bdPalabra(sql, "R") > 0 Then 'tiene información educ actual
                    sql = "SELECT MAX(SchoolYear) M FROM MemberEducationYear WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId =  " + MiembroV.Text + " " + _
                          " AND SchoolYear <= YEAR(GETDATE()) "
                    Dim ultimoAño As Integer = bdEntero(sql, "M")
                    sql = "SELECT CASE WHEN cdES.DescSpanish IS NULL THEN '' ELSE cdES.DescSpanish + ' ' + cdG.DescSpanish + CASE WHEN cdEC.DescSpanish IS NULL " + _
                             "THEN '' ELSE '-' + cdEC.DescSpanish END + ' (' + CONVERT(varchar, MEY.SchoolYear) + ')' END AS Educ " + _
                             "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.CdGrade cdG ON MEY.Grade = cdG.Code " + _
                             "INNER JOIN dbo.CdEducationStatus cdES ON MEY.Status = cdES.Code LEFT OUTER JOIN dbo.CdEducationCareer cdEC ON MEY.Career = cdEC.Code " + _
                             "WHERE  MEY.MemberId = " + MiembroV.Text + " AND MEY.Project = '" + S + "'  AND MEY.RecordStatus = ' '  AND  MEY.SchoolYear = " + ultimoAño.ToString + " AND " + _
                             "MEY.Grade = dbo.fn_GEN_getActualGrade(MEY.Project, MEY.MemberId, " + ultimoAño.ToString + ") "
                    'InputBox("SELECT", "", sql)
                    GradeV.Text = bdPalabra(sql, "Educ")
                Else
                    sql = "SELECT cdG." + descripcion() + " 'Grado', cdEs." + descripcion() + " 'Estado', m.LastGradePassedYear 'Año' " +
                          "FROM dbo.Member M LEFT JOIN cdGrade cdG ON cdG.Code = M.LastGradePassed LEFT JOIN CdEducationStatus cdES ON cdEs.code = m.LastGradePassedStatus " + _
                          "WHERE M.RecordStatus = ' ' AND M.Project = '" + S + "' AND M.Memberid = " + MiembroV.Text
                    bdDataTable(sql, educInfo)
                    GradeV.Text = chequearValor(educInfo.Rows(0)("Estado")) & " " & chequearValor(educInfo.Rows(0)("Grado")) & " " & chequearValor(educInfo.Rows(0)("Año").ToString)
                End If

                AfilStatusV.Text = chequearValor(genInfo.Rows(0)("AffiliationStatus"))
                AfilDateV.Text = chequearValor(genInfo.Rows(0)("AffiliationStatusDate"))
                semaforo(color, SemaforoV)
                padrinos()
                AfiliacionPanel.Visible = True
                AffiliationInfoL.Visible = True
                FaseV.Visible = True
            End If
        End If
    End Sub

    Private Sub inicioButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irPefilFamilia()
        If familiaEsValida(S, FamiliaV.Text) = True Then
            Dim nxt As New PerfilFamilia
            nxt.FamiliaV.Text = FamiliaV.Text
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub padrinos()
        sql = "SELECT S.SponsorId '" + idSpon + "', S.SponsorNames '" + nomSpon + "' FROM dbo.SponsorMemberRelation SMR INNER JOIN dbo.Sponsor S ON SMR.SponsorId = S.SponsorId AND SMR.RecordStatus = S.RecordStatus " + _
                 "WHERE SMR.RecordStatus = ' ' AND SMR.Project = '" + S + "' AND SMR.MemberId = " + MiembroV.Text + " AND SMR.EndDate IS NULL "
        bdGrid(sql, PadrinosGrid)
        PadrinosGrid.Visible = True
        PadrinosL.Visible = True
    End Sub

    Private Sub traducir()
        AffiliationInfoL.Text = tr.traduce("Affiliation")
        AfilTypeL.Text = tr.traduce("AffiliationType") & ":"
        AfilStatusL.Text = tr.traduce("AffiliationStatus") & ":"
        AfilDateL.Text = tr.traduce("AffiliationStatusDate") & ":"
        AgeL.Text = tr.traduce("Age") & ":"
        AvisosL.Text = tr.traduce("FamilyWarnings")
        BirthL.Text = tr.traduce("BirthDate") & ":"
        FamiliaL.Text = tr.traduce("FamilyId") + ":"
        FaseL.Text = tr.traduce("Disaffiliation") & ":"
        FirstNameL.Text = tr.traduce("Names") & ":"
        GeneroL.Text = tr.traduce("Gender") & ":"
        GradeL.Text = tr.traduce("Grade") & ":"
        idSpon = tr.traduce("SponsorId")
        LastNameL.Text = tr.traduce("LastNames") & ":"
        LiveDeadL.Text = tr.traduce("LiveDead") & ":"
        MiembroL.Text = tr.traduce("MemberId") + ":"
        nomSpon = tr.traduce("SponsorNames")
        PadrinosL.Text = tr.traduce("Sponsors")
        PrefNameL.Text = tr.traduce("PreferredName") & ":"
        RightsL.Text = tr.traduce("ProjectRight") & ":"
        SemaforoL.Text = tr.traduce("Semaphore") & ":"
        Title.Text = tr.traduce("MemberProfile")
    End Sub

    Private Sub valoresIniciales()
        traducir()
        infoGen()
        derechos()
        avisosFamiliares()
    End Sub
End Class