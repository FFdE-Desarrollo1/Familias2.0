' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class MiembrosFamilia
    Public familyId As Integer
    Public transac, idSel, estFam As String

    Private Sub MiembrosFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
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

    Private Sub valoresIniciales()
        FamiliaL.Text = FamiliaL.Text + " (" + familyId.ToString + ")"

        sql = "SELECT cdAS.DescSpanish Estado FROM Family F LEFT JOIN cdAffiliationStatus cdAS ON cdAS.Code = F.AffiliationStatus " + _
                "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND F.FamilyId = " + familyId.ToString
        estFam = chequearValor(bdPalabra(sql, "Estado")).ToUpper
        EstadoFamiliarL.Text = "Estado Familiar: " + estFam


        sql = "SELECT FMR.MemberId AS Miembro, M.FirstNames AS Nombres, M.LastNames AS Apellidos, dbo.fn_GEN_FormatDate(M.BirthDate, 'ES') AS Nacimiento, " + _
          "dbo.fn_GEN_CalcularEdad(M.BirthDate) AS Edad, cdFMR.DescSpanish AS Relación_Familiar, cdAS.DescSpanish AS Estado_Afil, " + _
          "dbo.fn_GEN_tipoMiembro(M.Project, M.MemberId) TipoMiembro, HeadOfHouse " + _
          "FROM dbo.FamilyMemberRelation FMR INNER JOIN " + _
          "dbo.CdFamilyMemberRelationType cdFMR ON FMR.Type = cdFMR.Code INNER JOIN " + _
          "dbo.Member M ON FMR.Project = M.Project AND FMR.MemberId = M.MemberId AND FMR.RecordStatus = M.RecordStatus " + _
          "LEFT JOIN dbo.CdAffiliationStatus cdAS ON cdAS.Code = M.AffiliationStatus " + _
          "WHERE FMR.RecordStatus = ' ' AND FMR.Project = '" + S + "' AND FMR.FamilyId = " + familyId.ToString + " AND FMR.InactiveDate IS NULL " + _
          "ORDER BY cdFMR.DisplayOrder "
        'InputBox("", "", sql)
        bdGrid(sql, FamilyR)
        FamilyR.Columns.Item(8).Visible = False 'es jefe
        FamilyR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub FamilyR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FamilyR.CellContentClick
        Dim c, miembro, f As Integer
        Dim estado As String
        Dim jefe As Boolean
        c = FamilyR.CurrentCellAddress.X
        f = FamilyR.CurrentCellAddress.Y
        If c = 0 Then
            miembro = FamilyR.Item(0, f).Value.ToString
            estado = chequearValor(FamilyR.Item(6, f).Value)
            jefe = chequearValor(FamilyR.Item(8, f).Value)
            'para revisar
            If transac = "ACCH" Then
                irRegistroCuentasACHFamilias(miembro)
            ElseIf transac = "ASIN" Then
                irResumenAJ(miembro)
            ElseIf transac = "COAS" Then
                irRegistroAsistencia(miembro)
            ElseIf transac = "ITRE" Then
                irIngresarTratamientoEnf(miembro)
            ElseIf transac = "NCIP" Then
                irResumenAE(miembro)
            ElseIf transac = "RAEM" Then
                irActividadesEduc(miembro)
            ElseIf transac = "RCIM" Then
                irRevisarPreconsultas(miembro)
            ElseIf transac = "REHC" Then
                irHistorialConsultasMedicas(miembro)
            ElseIf transac = "RHEM" Then
                irHistorialEducativo(miembro)
            ElseIf transac = "RHMF" Then
                irHistorialMedicinasMiembroFarm(miembro)
            ElseIf transac = "RHMM" Then
                irHistorialMedicamentosClin(miembro)
            ElseIf transac = "RIAE" Then
                irResumenBecas(miembro)
            ElseIf transac = "RREM" Then
                irReembolsosEduc(miembro)
            ElseIf transac = "RIAM" Then
                If estado = "Desafiliado" Or estado = "Graduado" Or estado = "Afiliado" Then
                    irResumenApad(miembro)
                Else
                    MsgBox("Para realizar esta transacción el miembro necesita ser un afiliado, desafiliado o graduado.", vbQuestion, My.Resources.versionFamilias2)
                End If
            Else
                If (estado = "Desafiliado" Or estado = "Graduado") And jefe = False Then
                    MsgBox("El miembro no tiene derechos, es " + estado, vbQuestion, My.Resources.versionFamilias2)
                    'solo con derechos
                Else
                    If transac = "RAAE" Then
                        irActividadesAE(miembro)
                    ElseIf transac = "IREM" Then
                        irAutorizarReembolsoEduc(miembro)
                    ElseIf transac = "CRM" Then
                        irReembolsosPorFamilia(miembro)
                    ElseIf transac = "IAMS" Then
                        irRegistroActividadesGenSalud(miembro)
                    ElseIf transac = "IMAM" Then
                        irRegistroActividadesMisc(miembro)
                    ElseIf transac = "IACM" Then
                        irActividadesSalud(miembro)
                    ElseIf transac = "IRCR" Then
                        irAutorizarReembolsoRece(miembro)
                    ElseIf transac = "CL" Then
                        irCitaLaboratorio(miembro)
                    ElseIf transac = "NCM" Then
                        irPreconsulta(miembro, chequearValor(FamilyR.Item(7, f).Value))
                    ElseIf transac = "RRCM" Then
                        irReembolsosSalud(miembro)
                    ElseIf transac = "IRCM" Then
                        irAutorizarReembolsoClin(miembro)
                    ElseIf transac = "ARE" Then
                        irRecetaExternaClin(miembro)
                    ElseIf transac = "ECM" Then
                        irExonerarMedicina(miembro)
                    ElseIf transac = "ERE" Then
                        irRecetaExternaFarm(miembro)
                    ElseIf transac = "VALI" Then
                        irValeLibros(miembro)
                    ElseIf transac = "IIAE" Then
                        irNuevoAñoEscolar(miembro)
                    ElseIf transac = "IAEM" Then
                        irRegistroActividadesEduc(miembro)
                    ElseIf transac = "IRGS" Then
                        irAutorizarReembolsosGenSalud(miembro)
                    Else

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub irActividadesAE(ByVal miembro As String)
        Dim nxt As New ActividadesAE
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irActividadesEduc(ByVal miembro As String)
        Dim nxt As New ActividadesEduc
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irActividadesSalud(ByVal miembro As String)
        Dim nxt As New ActividadesSalud
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irAutorizarReembolsoClin(ByVal miembro As String)
        Dim nxt As New AutorizarReembolsoClin
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irAutorizarReembolsoEduc(ByVal miembro As String)
        Dim nxt As New AutorizarReembolsoEduc
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irAutorizarReembolsoRece(ByVal miembro As String)
        Dim nxt As New AutorizarReembolsosRece
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irAutorizarReembolsosGenSalud(ByVal miembro As String)
        Dim nxt As New AutorizarReembolsosGenSalud
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irCitaLaboratorio(ByVal miembro As String)
        Dim nxt As New CitaLaboratorio
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irExonerarMedicina(ByVal miembro As String)
        Dim nxt As New ExonerarMedicina
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub


    Private Sub irHistorialEducativo(ByVal miembro As String)
        Dim nxt As New HistorialEducativo
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irHistorialConsultasMedicas(ByVal miembro As String)
        Dim nxt As New HistorialConsultasMedicas
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irHistorialMedicamentosClin(ByVal miembro As String)
        Dim nxt As New HistorialMedicamentosClin
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irHistorialMedicinasMiembroFarm(ByVal miembro As String)
        Dim nxt As New HistorialMedicinasMiembroFarm
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irIngresarTratamientoEnf(ByVal miembro As String)
        Dim nxt As New IngresarTratamientoEnf
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irValeLibros(ByVal miembro As String)
        Dim nxt As New ValeLibros
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irPreconsulta(ByVal miembro As String, ByVal tipoMiembro As String)
        If tieneDerechosSalud(S, miembro) = False Then
            MsgBox("El miembro no tiene derechos, es " + tipoMiembro, vbQuestion, My.Resources.versionFamilias2)
        Else
            Dim nxt As New Preconsulta
            nxt.TipoMiembroL.Text = "(" + tipoMiembro + ")"
            nxt.PacienteV.Text = miembro
            nxt.Show()
            Me.Close()
        End If


    End Sub

    Private Sub irNuevoAñoEscolar(ByVal miembro As String)
        Dim nxt As New NuevoAñoEscolar
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRecetaExternaClin(ByVal miembro As String)
        Dim nxt As New RecetaExternaClin
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRecetaExternaFarm(ByVal miembro As String)
        Dim nxt As New RecetasExternasFarm
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irReembolsosEduc(ByVal miembro As String)
        Dim nxt As New ReembolsosEduc
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irReembolsosPorFamilia(ByVal miembro As String)
        Dim nxt As New ReembolsosPorFamilia
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irReembolsosSalud(ByVal miembro As String)
        Dim nxt As New ReembolsosSalud
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRegistroCuentasACHFamilias(ByVal miembro As String)
        Dim nxt As New RegistroCuentasACHFamilias
        nxt.FamiliaV.Text =
        nxt.MiembroRef.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRegistroActividadesEduc(ByVal miembro As String)
        Dim nxt As New RegistroActividadesIndividuales
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRegistroActividadesGenSalud(ByVal miembro As String)
        Dim nxt As New RegistroActividadesGenSalud
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRegistroActividadesMisc(ByVal miembro As String)
        Dim nxt As New RegistroActividadesEduc
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRegistroAsistencia(ByVal miembro As String)
        Dim nxt As New RegistroCDIs
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irResumenAE(ByVal miembro As String)
        Dim nxt As New ResumenAE
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irResumenAJ(ByVal miembro As String)
        Dim nxt As New ResumenAJ
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irResumenApad(ByVal miembro As String)
        Dim nxt As New ResumenApad
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irResumenBecas(ByVal miembro As String)
        Dim nxt As New ResumenBecas
        nxt.MiembroV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irRevisarPreconsultas(ByVal miembro As String)
        Dim nxt As New RevisarPreconsultas
        nxt.PacienteV.Text = miembro
        nxt.Show()
        Me.Close()
    End Sub

End Class