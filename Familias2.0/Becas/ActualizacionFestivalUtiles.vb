' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ActualizacionFestivalUtiles
    Public TB, pEst, proxN, actuN, proxC As String

    Dim GenInfo As New DataTable
    Dim printed, registered, actual As DateTime
    Dim nivelT, registeredBy, codigoTB, codigoEscuelaN, trans, User, nivelActual As String
    Dim codigoTipoZN, codigoTipoT As String
    Dim tZap, eZap, tT, eT, blu, pol, tel, sue, pla, chu, pan, cha, cor, col As String
    Dim printNumber As Integer

    Private Sub ActualizacionFestivalUtiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
        If ApadrinadoV.Text = "" Then
        Else
            InfoGeneral()
        End If
    End Sub

    Private Sub actualizando()
        Dim upZN, upT, upU, school, career, extra As String
        If cambiosZap() = True Then
            If ZapatosNCheck.Checked = True Then
                upZN = ", 1, " + NoZNegrosV.Text + ", '" + EstiloZNegrosV.SelectedValue + "'"
            Else
                upZN = ", 0, NULL, NULL"
            End If
        Else
            upZN = ", LeatherS, LeatherSS, LeatherSD"
        End If

        If cambiosTen() = True Then
            If TenisCheck.Checked = True Then
                upT = ", 1, " + NoTenisV.Text + ", '" + EstiloTenisV.SelectedValue + "'"
            Else
                upT = ", 0, NULL, NULL"
            End If
        Else
            upT = ", Tennis, TennisSS, TennisSD"
        End If

        If ProximaEscuelaV.Text = pEst Then
            school = ", NextSchool"
        Else
            If Len(ProximaEscuelaV.Text) = 0 Then
                school = ", NULL"
            Else
                school = ", '" + ProximaEscuelaV.SelectedValue + "'"
            End If
        End If

        If CarreraCombo.SelectedIndex < 0 Or CarreraCombo.Text = "" Then 'codigoEscuelaN = "0" Or codigoEscuelaN = "" Or codigoEscuelaN = " " Then
            career = "NULL"
        Else
            career = "'" + CarreraCombo.SelectedValue + "'"
        End If

        If cambiosUnif() = True Then
            If UniformeCheck.Checked = True Then
                Dim blu, pol, tel, sue, pla, chu, pan, cha, cor As String

                If BlusaTallaV.Text = "" Or BlusaTallaV.Text = " " Then
                    blu = "NULL"
                Else
                    blu = "'" + BlusaTallaV.Text + "'"
                End If

                If PoloTallaV.Text = "" Or PoloTallaV.Text = " " Then
                    pol = "NULL"
                Else
                    pol = "'" + PoloTallaV.Text + "'"
                End If

                If TelaTallaV.Text = "" Or TelaTallaV.Text = " " Then
                    tel = "NULL"
                Else
                    tel = "'" + TelaTallaV.Text + "'"
                End If

                If SueterTallaV.Text = "" Or SueterTallaV.Text = " " Then
                    sue = "NULL"
                Else
                    sue = "'" + SueterTallaV.Text + "'"
                End If

                If PlayeraTallaV.Text = "" Or PlayeraTallaV.Text = " " Then
                    pla = "NULL"
                Else
                    pla = "'" + PlayeraTallaV.Text + "'"
                End If

                If ChumpaTallaV.Text = "" Or ChumpaTallaV.Text = " " Then
                    chu = "NULL"
                Else
                    chu = "'" + ChumpaTallaV.Text + "'"
                End If

                If PantsTallaV.Text = "" Or PantsTallaV.Text = " " Then
                    pan = "NULL"
                Else
                    pan = "'" + PantsTallaV.Text + "'"
                End If

                If ChalecoTallaV.Text = "" Or ChalecoTallaV.Text = " " Then
                    cha = "NULL"
                Else
                    cha = "'" + ChalecoTallaV.Text + "'"
                End If

                If CorbataTallaV.Text = "" Or CorbataTallaV.Text = " " Then
                    cor = "NULL"
                Else
                    cor = "'" + CorbataTallaV.Text + "'"
                End If

                upU = ", 1, " + blu + " Shirt, " + pol + " Polo, " + tel + " Cloth, " + sue + " Sweater, " + pla + " Tshirt, " + chu + " Jacket, " + pan + " Pants, " + _
                      cha + " Vest , " + cor + " Tie "
            Else
                upU = ", 0, NULL Shirt, NULL Polo, NULL Cloth, NULL Sweater, NULL Tshirt, NULL Jacket, NULL Pants, NULL Vest, NULL Tie "
            End If
        Else
            upU = ", Uniform, BlouseShirt, Polo, Cloth, Sweater, Tshirt, Jacket, Pants, Vest, Tie"
        End If

        If Extra1oBCheckBox.Checked = True Then
            extra = "'PB1F'"
        Else
            extra = "NULL"
        End If

        Dim pañ As String = (Integer.Parse(ProximoAñoV.Text) - 1).ToString
        'Project, MemberId, SchoolYear, CreationDateTime, RecordStatus,UserId, ExpirationDateTime, SSVoucher, ShoesVoucher, UVoucher, 
        'SchoolSuppliesTypeBag, AdditionalPackage, NextSchool, LeatherS, LeatherSS, LeatherSD, 
        'Tennis, TennisSS, TennisSD, Uniform, BlouseShirt, Polo, Cloth, Sweater, Tshirt, Jacket, Pants, Vest, Tie, 
        'registered, registeredBy, printed, printNumber, NextCareer
        sql = "INSERT INTO dbo.MemberEducationFair " + _
              "SELECT Project, MemberId, SchoolYear, GETDATE(), RecordStatus, '" + U + "' UserId, ExpirationDateTime, SSVoucher, ShoesVoucher, UVoucher, '" + _
              TipoBolsaV.SelectedValue + "' SchoolSuppliesTypeBag, " + extra + school + upZN + _
              upT + upU + _
              ", registered, '" + U + "', GETDATE(), 0, " + career + "  " + _
              "FROM dbo.MemberEducationFair " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND MemberId = " + ApadrinadoV.Text + " AND SchoolYear = " + pañ
        bdInsertar(sql)
        regresar()
    End Sub

    Private Sub actualizar(ByVal bolsa As String)
        trans = "A"
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

        response = MsgBox("¿Necesita actualizar la información de " + Chr(13) + Chr(13) + _
                          NombreV.Text.ToUpper + "?", style, My.Resources.versionFamilias2)
        If response = MsgBoxResult.Yes Then
            sql = "SELECT  TallaZN, EstiloZN, TallaT, EstiloT, TallaBC, Polo, Tela, Sueter, Playera, Chumpa, Pants, Chaleco, Corbata, " + _
                         "Registered, RegisteredBy, Printed " + _
                  "FROM dbo.v_BECA_ActualizaInfoFeriaUtiles WHERE Project = '" + S + "' AND Apadrinado = " + ApadrinadoV.Text
            bdDataTable(sql, GenInfo)
            TipoBolsaV.Text = bolsa
            ProximaEscuelaV.Text = pEst
            CarreraCombo.Text = proxC

            If ZapatosNCheck.Checked = True Then
                tZap = chequearValor(GenInfo.Rows(0)("TallaZN"))
                eZap = chequearValor(GenInfo.Rows(0)("EstiloZN"))

                NoZNegrosV.Text = tZap
                EstiloZNegrosV.Text = eZap
                ZapatosNegrosPanel.Visible = True
            End If

            If TenisCheck.Checked = True Then
                tT = chequearValor(GenInfo.Rows(0)("TallaT"))
                eT = chequearValor(GenInfo.Rows(0)("EstiloT"))

                NoTenisV.Text = tT
                EstiloTenisV.Text = eT
                TenisPanel.Visible = True
            End If

            If UniformeCheck.Checked = True Then
                blu = chequearValor(GenInfo.Rows(0)("TallaBC"))
                pol = chequearValor(GenInfo.Rows(0)("Polo"))
                tel = chequearValor(GenInfo.Rows(0)("Tela"))
                sue = chequearValor(GenInfo.Rows(0)("Sueter"))
                pla = chequearValor(GenInfo.Rows(0)("Playera"))
                chu = chequearValor(GenInfo.Rows(0)("Chumpa"))
                pan = chequearValor(GenInfo.Rows(0)("Pants"))
                cha = chequearValor(GenInfo.Rows(0)("Chaleco"))
                cor = chequearValor(GenInfo.Rows(0)("Corbata"))

                BlusaTallaV.Text = blu
                PoloTallaV.Text = pol
                TelaTallaV.Text = tel
                SueterTallaV.Text = sue
                PlayeraTallaV.Text = pla
                ChumpaTallaV.Text = chu
                PantsTallaV.Text = pan
                ChalecoTallaV.Text = cha
                CorbataTallaV.Text = cor
                UniformePanel.Visible = True
            End If


            registered = chequearValor(GenInfo.Rows(0)("Registered"))
            User = chequearValor(GenInfo.Rows(0)("RegisteredBy"))
            EducPanel.Visible = True
        Else
            regresar()
        End If
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Function cambiosTen() As Boolean
        If NoTenisV.Text = tT And EstiloTenisV.Text = eT Then
            cambiosTen = False
        Else
            cambiosTen = True
        End If
    End Function

    Private Function cambiosUnif() As Boolean
        If BlusaTallaV.Text = blu And PoloTallaV.Text = pol And TelaTallaV.Text = tel And SueterTallaV.Text = sue And PlayeraTallaV.Text = pla And _
           ChumpaTallaV.Text = chu And PantsTallaV.Text = pan And ChalecoTallaV.Text = cha And CorbataTallaV.Text = cor Then
            cambiosUnif = False
        Else
            cambiosUnif = True
        End If

    End Function

    Private Function cambiosZap() As Boolean
        If NoZNegrosV.Text = tZap And EstiloZNegrosV.Text = eZap Then
            cambiosZap = False
        Else
            cambiosZap = True
        End If
    End Function

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If TipoBolsaV.SelectedValue = "NORE" Then
            ingresarNoRecibe()
        Else
            If validarZapatosNegros() = True And validarTenis() = True And validarUniforme() = True And validacionGeneral() = 0 Then

                If trans = "N" Then
                    ingresando()
                Else
                    actualizando()
                End If
            End If
        End If
    End Sub

    Private Sub HistorialEduc_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialEduc.CheckedChanged
        If HistorialEduc.Checked = True Then
            EducGrid.DataSource = Nothing
            EducGrid.Rows.Clear()
            EducGrid.Visible = False
            sql = "SELECT MEY.SchoolYear AS Año, S.Name AS Escuela, CdG.DescSpanish AS Grado, cdES.DescSpanish AS Estado, MEY.Notes, cdEC.DescSpanish Carrera " + _
                    "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.School S ON MEY.Project = S.Project AND MEY.SchoolCode = S.Code AND MEY.RecordStatus = S.RecordStatus " + _
                     "INNER JOIN dbo.CdGrade CdG ON MEY.Grade = CdG.Code INNER JOIN dbo.CdEducationStatus cdES ON MEY.Status = cdES.Code " + _
                     "LEFT JOIN dbo.CdEducationCareer cdEC ON cdEC.Code = MEY.Career " + _
                     "WHERE MEY.RecordStatus = ' ' AND MEY.Project = '" + S + "' AND MEY.MemberId = " + ApadrinadoV.Text + " " + _
                    "ORDER BY MEY.SchoolYear DESC "
            bdGrid(sql, EducGrid)
            EducGrid.Visible = True
        Else
            EducGrid.Visible = False
        End If
    End Sub

    Private Sub HistorialFeriaUtiles_CheckedChanged(sender As Object, e As EventArgs) Handles HistorialFeriaUtiles.CheckedChanged
        If HistorialFeriaUtiles.Checked = True Then
            FeriasGrid.DataSource = Nothing
            FeriasGrid.Rows.Clear()
            FeriasGrid.Visible = False
            sql = "SELECT MEF.SchoolYear AS Año, cdTB.DescSpanish AS [Tipo Bolsa], CONVERT(NVARCHAR, MEF.LeatherSS)  + ' - ' + cdSS.DescSpanish AS [Zap.], " + _
                    "CONVERT(NVARCHAR, MEF.TennisSS) + ' - ' + cdST.DescSpanish AS Tenis, MEF.BlouseShirt AS BlusaCamisa, MEF.Polo, MEF.Cloth AS Tela, MEF.Sweater AS Sueter, " + _
                     "MEF.Tshirt AS Playera, MEF.Jacket AS Chumpa, MEF.Pants, MEF.Vest AS Chaleco, MEF.Tie AS " + col + ", S.Name ProxEscuela, cdEC.DescSpanish ProxCarrera " + _
                      "FROM dbo.MemberEducationFair MEF LEFT OUTER JOIN dbo.CdSchoolSuppliesTypeBag cdTB ON MEF.SchoolSuppliesTypeBag = cdTB.Code LEFT OUTER JOIN " + _
                      "dbo.CdShoeStyle cdSS ON MEF.LeatherSD = cdSS.Code LEFT OUTER JOIN dbo.CdShoeStyle cdST ON MEF.TennisSD = cdST.Code " + _
                      "LEFT JOIN dbo.CdEducationCareer cdEC ON cdEC.Code = MEF.NextCareer  " +
                      "LEFT JOIN dbo.School S ON S.Code = MEF.NextSchool AND S.Project = MEF.Project AND S.RecordStatus = MEF.RecordStatus " + _
                      "WHERE MEF.RecordStatus = ' ' AND MEF.Project = '" + S + "' AND MEF.MemberId = " + ApadrinadoV.Text + " AND SchoolYear < " + (Integer.Parse(ProximoAñoV.Text) - 1).ToString + " " + _
                      "ORDER BY MEF.SchoolYear DESC "
            bdGrid(sql, FeriasGrid)
            FeriasGrid.Visible = True
        Else
            FeriasGrid.Visible = False
        End If
    End Sub


    Private Sub InfoGeneral()
        If TB = "" Or Len(TB) = 0 Then
            nuevo()
        Else
            actualizar(TB)
        End If

        If AñoV.Text = "_" Or AñoV.Text = "" Then
            Dim fecha As DateTime = DateTime.Now
            If fecha.Month = 1 Then
                ProximoAñoV.Text = (fecha.Year - 1).ToString
            Else
                ProximoAñoV.Text = fecha.Year.ToString
            End If
        Else
            ProximoAñoV.Text = (Integer.Parse(AñoV.Text) + 1).ToString
        End If

        If TipoBolsaV.Text = "Básico" Then
            ZapatosNCheck.Checked = True
            TenisCheck.Checked = True
        End If

        TipoBolsaV.Focus()
        ApadrinadoV.ReadOnly = True
        CorbataTallaL.Text = col
    End Sub

    Private Sub ingresando()
        Dim upZN, upT, upU, school, career, extra As String
        If ZapatosNCheck.Checked = True Then
            upZN = ", 1, " + NoZNegrosV.Text + ", '" + EstiloZNegrosV.SelectedValue + "'"
        Else
            upZN = ", 0, NULL, NULL"
        End If

        If TenisCheck.Checked = True Then
            upT = ", 1, " + NoTenisV.Text + ", '" + EstiloTenisV.SelectedValue + "'"
        Else
            upT = ", 0, NULL, NULL"
        End If

        If ProximaEscuelaV.SelectedIndex < 0 Or ProximaEscuelaV.Text = "" Then 'codigoEscuelaN = "0" Or codigoEscuelaN = "" Or codigoEscuelaN = " " Then
            school = "NULL"
        Else
            school = "'" + ProximaEscuelaV.SelectedValue + "'"
        End If

        If CarreraCombo.SelectedIndex < 0 Or CarreraCombo.Text = "" Then 'codigoEscuelaN = "0" Or codigoEscuelaN = "" Or codigoEscuelaN = " " Then
            career = "NULL"
        Else
            career = "'" + CarreraCombo.SelectedValue + "'"
        End If


        If UniformeCheck.Checked = True Then
            Dim blu, pol, tel, sue, pla, chu, pan, cha, cor As String

            If BlusaTallaV.Text = "" Or BlusaTallaV.Text = " " Then
                blu = "NULL"
            Else
                blu = "'" + BlusaTallaV.Text + "'"
            End If

            If PoloTallaV.Text = "" Or PoloTallaV.Text = " " Then
                pol = "NULL"
            Else
                pol = "'" + PoloTallaV.Text + "'"
            End If

            If TelaTallaV.Text = "" Or TelaTallaV.Text = " " Then
                tel = "NULL"
            Else
                tel = "'" + TelaTallaV.Text + "'"
            End If

            If SueterTallaV.Text = "" Or SueterTallaV.Text = " " Then
                sue = "NULL"
            Else
                sue = "'" + SueterTallaV.Text + "'"
            End If

            If PlayeraTallaV.Text = "" Or PlayeraTallaV.Text = " " Then
                pla = "NULL"
            Else
                pla = "'" + PlayeraTallaV.Text + "'"
            End If

            If ChumpaTallaV.Text = "" Or ChumpaTallaV.Text = " " Then
                chu = "NULL"
            Else
                chu = "'" + ChumpaTallaV.Text + "'"
            End If

            If PantsTallaV.Text = "" Or PantsTallaV.Text = " " Then
                pan = "NULL"
            Else
                pan = "'" + PantsTallaV.Text + "'"
            End If

            If ChalecoTallaV.Text = "" Or ChalecoTallaV.Text = " " Then
                cha = "NULL"
            Else
                cha = "'" + ChalecoTallaV.Text + "'"
            End If

            If CorbataTallaV.Text = "" Or CorbataTallaV.Text = " " Then
                cor = "NULL"
            Else
                cor = "'" + CorbataTallaV.Text + "'"
            End If

            upU = ", 1, " + blu + ", " + pol + ", " + tel + ", " + sue + ", " + pla + ", " + chu + ", " + pan + ", " + _
                    cha + ", " + cor
        Else
            'upU = ", 0, NULL Shirt, NULL Polo, NULL Cloth, NULL Sweater, NULL Tshirt, NULL Jacket, NULL Pants, NULL Vest, NULL Tie "
            upU = ", 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL "
            'upU = ", 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL"
        End If

        If Extra1oBCheckBox.Checked = True Then
            extra = "'PB1F'"
        Else
            extra = "NULL"
        End If

        'Project, MemberId, SchoolYear, CreationDateTime, RecordStatus,UserId, ExpirationDateTime, SSVoucher, ShoesVoucher, UVoucher, 
        'SchoolSuppliesTypeBag, AdditionalPackage, NextSchool, LeatherS, LeatherSS, LeatherSD, 
        'Tennis, TennisSS, TennisSD, Uniform, BlouseShirt, Polo, Cloth, Sweater, Tshirt, Jacket, Pants, Vest, Tie, 
        'registered, registeredBy,printed, printNumber, NextCareer
        sql = "INSERT INTO dbo.MemberEducationFair VALUES (" + _
                "'" + S + "', " + ApadrinadoV.Text + ", " + (Integer.Parse(ProximoAñoV.Text) - 1).ToString + ", GETDATE(), ' ', '" + U + "', NULL, NULL, NULL, NULL, " + _
                "'" + TipoBolsaV.SelectedValue + "', " + extra + "," + school + upZN + _
                upT + upU + _
                ", GETDATE(), '" + U + "', NULL, 0, " + career + " ) "
        'InputBox("sql", "F", sql)
        bdInsertar(sql)
        regresar()
    End Sub

    Private Sub ingresarNoRecibe()
        'Project, MemberId, SchoolYear, CreationDateTime, RecordStatus,UserId, ExpirationDateTime, SSVoucher, ShoesVoucher, UVoucher, 
        'SchoolSuppliesTypeBag, AdditionalPackage, NextSchool, LeatherS, LeatherSS, LeatherSD, 
        'Tennis, TennisSS, TennisSD, Uniform, BlouseShirt, Polo Cloth, Sweater, Tshirt, Jacket, Pants, Vest, Tie, 
        'registered, registeredBy,printed, printNumber
        sql = "INSERT INTO dbo.MemberEducationFair " + _
                "VALUES ('" + S + "', " + ApadrinadoV.Text + ", " + (Integer.Parse(ProximoAñoV.Text) - 1).ToString + ", GETDATE(), ' ', '" + U + "', NULL, NULL, NULL, NULL, '" + _
                TipoBolsaV.SelectedValue + "', NULL, NULL, 0, NULL, NULL, " + _
                "0, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, " + _
                " GETDATE(), '" + U + "', NULL, 0)"
        bdInsertar(sql)
        regresar()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub nuevo()
        trans = "N"
        If Len(proxN) > 0 Then
            If proxN = "Vocacional" Then
                TipoBolsaV.Text = "Diversificado"
            ElseIf proxN = "Escuela Especial" Then
                TipoBolsaV.Text = "Preprimaria"
            ElseIf proxN = "Universidad" Then
                TipoBolsaV.Text = ""
            Else
                TipoBolsaV.Text = proxN
            End If
        Else
            TipoBolsaV.Text = ""
        End If


        If proxN = actuN Then
            ProximaEscuelaV.Text = EscuelaActualV.Text
        End If
        EducPanel.Visible = True
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        regresar()
    End Sub

    Private Sub regresar()
        Dim nxt As New FeriaUtilesFamiliar
        nxt.FamiliaV.Text = FamiliaV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub tenis()
        If TenisCheck.Checked = True Then
            TenisPanel.Visible = True
        Else
            TenisPanel.Visible = False
        End If
    End Sub

    Private Sub TenisCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TenisCheck.CheckedChanged
        tenis()
    End Sub

    Private Sub uniforme()
        If UniformeCheck.Checked = True Then
            UniformePanel.Visible = True
        Else
            UniformePanel.Visible = False
        End If
    End Sub

    Private Sub UniformeCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UniformeCheck.CheckedChanged
        uniforme()
    End Sub

    Private Function validarZapatosNegros() As Boolean
        validarZapatosNegros = True
        If ZapatosNCheck.Checked = True Then
            Dim recibeZNegros As Boolean
            If TipoBolsaV.SelectedValue = "BASI" Then
                recibeZNegros = True
            ElseIf TipoBolsaV.SelectedValue = "DIVE" Then
                recibeZNegros = True
            Else
                recibeZNegros = False
            End If

            If Len(NoZNegrosV.Text) = 0 Or Len(EstiloZNegrosV.Text) = 0 Then
                MsgBox("Debe seleccionar el Número y estilo de los zapatos negros", vbCritical, My.Resources.versionFamilias2)
                validarZapatosNegros = False
            ElseIf recibeZNegros = False Then
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                response = MsgBox("¿Esta seguro de agregar zapatos negros?" + Chr(13) + _
                                  "Verifique el nivel educativo", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    validarZapatosNegros = True
                Else
                    validarZapatosNegros = False
                    EstiloZNegrosV.Text = ""
                    NoZNegrosV.Text = ""
                    ZapatosNCheck.Checked = False
                End If
            End If
        Else
            If NoZNegrosV.Text <> "" Then
                MsgBox("La talla de zapatos negros tiene que estar vacía", vbCritical, My.Resources.versionFamilias2)
                validarZapatosNegros = False
            ElseIf EstiloZNegrosV.Text <> "" Then
                MsgBox("El estilo de zapatos negros tiene que estar vacío", vbCritical, My.Resources.versionFamilias2)
                validarZapatosNegros = False
            End If
        End If
    End Function

    Private Function validarTenis() As Boolean
        validarTenis = True

        Dim recibeTenis As Boolean
        If TipoBolsaV.SelectedValue = "BASI" Then
            recibeTenis = True
        ElseIf TipoBolsaV.SelectedValue = "DIVE" Then
            recibeTenis = True
        Else
            recibeTenis = False
        End If

        If TenisCheck.Checked = True Then
            If Len(NoTenisV.Text) = 0 Or Len(EstiloTenisV.Text) = 0 Then
                MsgBox("Debe seleccionar el número y estilo de tenis", vbCritical, My.Resources.versionFamilias2)
                validarTenis = False
            ElseIf recibeTenis = False Then
                Dim style As MsgBoxStyle
                Dim response As MsgBoxResult
                style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

                response = MsgBox("¿Esta seguro de agregarle tenis?" + Chr(13) + _
                                  "Verifique el nivel educativo", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    validarTenis = True
                Else
                    validarTenis = False
                    NoTenisV.Text = ""
                    EstiloTenisV.Text = ""
                    TenisCheck.Checked = False
                End If
            End If
        Else
            If NoTenisV.Text <> "" Then
                MsgBox("La talla de tenis tiene que estar vacía", vbCritical, My.Resources.versionFamilias2)
                validarTenis = False
            ElseIf EstiloTenisV.Text <> "" Then
                MsgBox("El estilo de tenis tiene que estar vacío", vbCritical, My.Resources.versionFamilias2)
                validarTenis = False
            End If
        End If
    End Function

    Private Function validarUniforme() As Boolean
        validarUniforme = True

        If UniformeCheck.Checked = True Then
            If BlusaTallaV.SelectedIndex = -1 And BlusaTallaV.Text <> "" Then
                MsgBox("Verifique la talla de la blusa", vbCritical, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf TelaTallaV.SelectedIndex = -1 And TelaTallaV.Text <> "" Then
                MsgBox("Verifique la talla de la tela", vbCritical, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf SueterTallaV.SelectedIndex = -1 And SueterTallaV.Text <> "" Then
                MsgBox("Verifique la talla del suéter", vbCritical, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf PlayeraTallaV.SelectedIndex = -1 And PlayeraTallaV.Text <> "" Then
                MsgBox("Verifique la talla de la playera", vbCritical, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf ChumpaTallaV.SelectedIndex = -1 And ChumpaTallaV.Text <> "" Then
                MsgBox("Verifique la talla de la chumpa", vbCritical, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf PantsTallaV.SelectedIndex = -1 And PantsTallaV.Text <> "" Then
                MsgBox("Verifique la talla del pants", vbCritical, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf ChalecoTallaV.SelectedIndex = -1 And ChalecoTallaV.Text <> "" Then
                MsgBox("Verifique la talla del chaleco", vbCritical, My.Resources.versionFamilias2)
                validarUniforme = False
            End If
        Else
            If BlusaTallaV.Text <> "" Then
                MsgBox("La talla de la blusa tiene que estar vacía", vbQuestion, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf TelaTallaV.Text <> "" Then
                MsgBox("La talla de la tela tiene que estar vacía", vbQuestion, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf SueterTallaV.Text <> "" Then
                MsgBox("La talla del suéter tiene que estar vacía", vbQuestion, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf PlayeraTallaV.Text <> "" Then
                MsgBox("La talla de la playera tiene que estar vacía", vbQuestion, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf ChumpaTallaV.Text <> "" Then
                MsgBox("La talla de la chumpa tiene que estar vacía", vbQuestion, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf PantsTallaV.Text <> "" Then
                MsgBox("La talla del pants tiene que estar vacía", vbQuestion, My.Resources.versionFamilias2)
                validarUniforme = False
            ElseIf ChalecoTallaV.Text <> "" Then
                MsgBox("La talla del chaleco tiene que estar vacía", vbQuestion, My.Resources.versionFamilias2)
                validarUniforme = False
            End If
        End If
    End Function

    Private Function validacionGeneral() As Integer
        Dim n As Integer = 0
        If Len(TipoBolsaV.Text) = 0 Then
            n = n + 1
            MsgBox("Necesita ingresar el tipo de bolsa", vbCritical, My.Resources.versionFamilias2)
        End If

        If Len(ProximaEscuelaV.Text) = 0 Then
            n = n + 1
            MsgBox("Verifique el establecimiento donde estudiará el próximo año", vbCritical, My.Resources.versionFamilias2)
        End If

        validacionGeneral = n
    End Function

    Private Sub valoresIniciales()
        ApadrinadoV.Focus()

        If S = "M" Then
            col = "Corbata"
        Else
            col = "Pantalon"
        End If

        sql = "SELECT Gender FROM Member WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId = " + ApadrinadoV.Text
        Dim genero As String = bdPalabra(sql, "Gender")

        sql = "SELECT Code, Name Establecimiento FROM dbo.School " + _
              "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND Code NOT IN ('NEST', 'DESC') AND Active = 1  ORDER BY Name "
        bdCombo(sql, ProximaEscuelaV, "Code", "Establecimiento")

        If S = "N" Then
            sql = "SELECT Code, DescSpanish AS Tipo FROM dbo.CdSchoolSuppliesTypeBag WHERE Active = 1 AND Code <> 'PRIM' AND Project IN ('" + S + "', '*')  ORDER BY Orden"
        Else
            sql = "SELECT Code, DescSpanish AS Tipo FROM dbo.CdSchoolSuppliesTypeBag WHERE Active = 1 AND Project IN ('" + S + "', '*')  ORDER BY Orden"
        End If
        bdCombo(sql, TipoBolsaV, "Code", "Tipo")

        sql = "SELECT Code,  DescSpanish AS Estilo FROM dbo.CdShoeStyle WHERE TypeShoe = 'N' AND Activo = 1 AND Project = '" + S + "'  AND Gender = '" + genero + "'"
        bdCombo(sql, EstiloZNegrosV, "Code", "Estilo")

        sql = "SELECT Code,  DescSpanish AS Estilo FROM dbo.CdShoeStyle WHERE TypeShoe = 'T' AND Activo = 1 AND Project = '" + S + "' "
        bdCombo(sql, EstiloTenisV, "Code", "Estilo")

        sql = "Select Code FROM  dbo.CdShoeSize WHERE Active = 1 "
        bdComboSinCodigo(sql, NoZNegrosV)
        bdComboSinCodigo(sql, NoTenisV)

        sql = "SELECT Code, DescSpanish Carrera FROM CdEducationCareer WHERE EducationLevel = 'DIVE' ORDER BY DescSpanish "
        bdCombo(sql, CarreraCombo, "Code", "Carrera")

        sql = "SELECT Code Talla FROM dbo.CdClothSize WHERE Active = 1 ORDER BY Orden "
        bdComboSinCodigo(sql, BlusaTallaV)
        bdComboSinCodigo(sql, PoloTallaV)
        bdComboSinCodigo(sql, SueterTallaV)
        bdComboSinCodigo(sql, PlayeraTallaV)
        bdComboSinCodigo(sql, ChumpaTallaV)
        bdComboSinCodigo(sql, PantsTallaV)
        bdComboSinCodigo(sql, ChalecoTallaV)
        bdComboSinCodigo(sql, CorbataTallaV)

        If Len(AñoV.Text) <= 1 Then
            sql = "SELECT dbo.fn_BECA_añoFeriaUtiles() Año "
            Dim proxA = bdEntero(sql, "Año")
            ProximoAñoV.Text = proxA.ToString
            AñoV.Text = (proxA - 1).ToString
        End If


        zapatosN()
        tenis()
        uniforme()
    End Sub

    Private Sub zapatosN()
        If ZapatosNCheck.Checked = True Then
            ZapatosNegrosPanel.Visible = True
        Else
            ZapatosNegrosPanel.Visible = False
        End If
    End Sub

    Private Sub ZapatosNCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZapatosNCheck.CheckedChanged
        zapatosN()
    End Sub



End Class