' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ModificarVisita
    Public codeT As String
    Dim f1, f2, f3, f4, s1, s2, s3, e1, e2, e3, e4, l1, l2, l3, l4, l5, l6 As String

    Private Sub ModificarVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub categorias()
        If FA1.Checked = True Then
            f1 = ", '" + codigoSubCat(FA1.Text) + "', 1"
        Else
            f1 = ", '" + codigoSubCat(FA1.Text) + "', 0"
        End If

        If FA2.Checked = True Then
            f2 = ", '" + codigoSubCat(FA2.Text) + "', 1"
        Else
            f2 = ", '" + codigoSubCat(FA2.Text) + "', 0"
        End If

        If FA3.Checked = True Then
            f3 = ", '" + codigoSubCat(FA3.Text) + "', 1"
        Else
            f3 = ", '" + codigoSubCat(FA3.Text) + "', 0"
        End If

        If FA4.Checked = True Then
            f4 = ", '" + codigoSubCat(FA4.Text) + "', 1"
        Else
            f4 = ", '" + codigoSubCat(FA4.Text) + "', 0"
        End If

        If SA1.Checked = True Then
            s1 = ", '" + codigoSubCat(SA1.Text) + "', 1"
        Else
            s1 = ", '" + codigoSubCat(SA1.Text) + "', 0"
        End If

        If SA2.Checked = True Then
            s2 = ", '" + codigoSubCat(SA2.Text) + "', 1"
        Else
            s2 = ", '" + codigoSubCat(SA2.Text) + "', 0"
        End If

        If SA3.Checked = True Then
            s3 = ", '" + codigoSubCat(SA3.Text) + "', 1"
        Else
            s3 = ", '" + codigoSubCat(SA3.Text) + "', 0"
        End If

        If ED1.Checked = True Then
            e1 = ", '" + codigoSubCat(ED1.Text) + "', 1"
        Else
            e1 = ", '" + codigoSubCat(ED1.Text) + "', 0"
        End If

        If ED2.Checked = True Then
            e2 = ", '" + codigoSubCat(ED2.Text) + "', 1"
        Else
            e2 = ", '" + codigoSubCat(ED2.Text) + "', 0"
        End If

        If ED3.Checked = True Then
            e3 = ", '" + codigoSubCat(ED3.Text) + "', 1"
        Else
            e3 = ", '" + codigoSubCat(ED3.Text) + "', 0"
        End If

        If ED4.Checked = True Then
            e4 = ", '" + codigoSubCat(ED4.Text) + "', 1"
        Else
            e4 = ", '" + codigoSubCat(ED4.Text) + "', 0"
        End If

        If PL1.Checked = True Then
            l1 = ", '" + codigoSubCat(PL1.Text) + "', 1"
        Else
            l1 = ", '" + codigoSubCat(PL1.Text) + "', 0"
        End If

        If PL2.Checked = True Then
            l2 = ", '" + codigoSubCat(PL2.Text) + "', 1"
        Else
            l2 = ", '" + codigoSubCat(PL2.Text) + "', 0"
        End If

        If PL3.Checked = True Then
            l3 = ", '" + codigoSubCat(PL3.Text) + "', 1"
        Else
            l3 = ", '" + codigoSubCat(PL3.Text) + "', 0"
        End If

        If PL4.Checked = True Then
            l4 = ", '" + codigoSubCat(PL4.Text) + "', 1"
        Else
            l4 = ", '" + codigoSubCat(PL4.Text) + "', 0"
        End If

        If PL5.Checked = True Then
            l5 = ", '" + codigoSubCat(PL5.Text) + "', 1"
        Else
            l5 = ", '" + codigoSubCat(PL5.Text) + "', 0"
        End If

        If PL6.Checked = True Then
            l6 = ", '" + codigoSubCat(PL6.Text) + "', 1"
        Else
            l6 = ", '" + codigoSubCat(PL6.Text) + "', 0"
        End If
    End Sub

    Private Function codigoSubCat(ByVal desc) As String
        sql = "SELECT Code FROM CdFamilySubCategoryVisit WHERE DescSpanish = '" + desc + "' "
        codigoSubCat = bdPalabra(sql, "Code")
    End Function

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        guardarVisita()
    End Sub

    Private Sub guardarVisita()
        Dim fechaHora As String = FechaV.Value.Year.ToString + "/" + FechaV.Value.Month.ToString + "/" + FechaV.Value.Day.ToString + " " + HoraV.Value.ToLongTimeString

        Dim actualDate As DateTime = Now
        'SELECT     Project, FamilyId, VisitType, VisitDateTime, CreationDateTime, RecordStatus, UserId, ExpirationDateTime, F1, F1v, F2, F2v, F3, F3v, F4, F4v, F, S1, 
        'S1v, S2, S2v, S3, S3v, S, E1, E1v, E2, E2v, E3, E3v, E4, E4v, E, V, L1, L1v, L2, L2v, L3, L3v, L4, L4v, L5, L5v, L6, L6v, L
        categorias()

        sql = ""
        sql = "INSERT INTO dbo.FamilyVisit2 VALUES ('" + S + "', " + FamiliaV.Text + ", '" + TipoVisitaV.SelectedValue + "', '" + Convert.ToDateTime(fechaHora).ToString(en.DateTimeFormat) + _
              "', '" + actualDate.ToString(en.DateTimeFormat) + "', ' ', '" + _
              U + "', NULL" + f1 + f2 + f3 + f4 + ", '" + FO.Text + "'" + s1 + s2 + s3 + ", '" + SO.Text + "'" +
              e1 + e2 + e3 + e4 + ", '" + EO.Text + "', '" + VO.Text + "'" + l1 + l2 + l3 + l4 + l5 + l6 + ", '" + LO.Text + "')"
        bdInsertar(sql)
        If visitaIngresada(FamiliaV.Text, TipoVisitaV.SelectedValue, actualDate) = True Then
            MsgBox("Actualización correcta", vbInformation, My.Resources.versionFamilias2)
            FamiliaV.ReadOnly = False
            nueva()
        Else
            MsgBox("Error en el ingreso, avise a Sistemas", vbCritical, My.Resources.versionFamilias2)
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub


    Private Sub nueva()
        Dim nxt As New HistorialVisitas
        nxt.FamiliaV.Text = FamiliaV.Text
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        nueva()
    End Sub

    Private Sub valoresIniciales()
        TSTable.Visible = True
        sql = "SELECT   Code Codigo, DescSpanish Descripcion FROM dbo.CdFamilyActivityType WHERE FunctionalArea = 'TS' AND Active = 1 ORDER BY DescSpanish "
        bdCombo(sql, TipoVisitaV, "Codigo", "Descripcion")

        TipoVisitaV.SelectedValue = codeT
    End Sub

    Private Function visitaIngresada(ByVal family As String, ByVal type As String, ByVal insertDate As DateTime) As Boolean
        Dim N As Integer
        sql = ""
        sql = "SELECT COUNT(*) Total FROM FamilyVisit2 WHERE RecordStatus = ' ' AND VisitType = '" + type + _
              "' AND Project = '" + S + "' AND FamilyId = " + family + " AND YEAR(CreationDateTime) = " + insertDate.Year.ToString + _
              " AND Month(CreationDateTime) = " + insertDate.Month.ToString + " AND Day(CreationDateTime) = " + insertDate.Day.ToString + _
              " AND { fn HOUR(CreationDateTime) } = " + insertDate.Hour.ToString + " AND { fn MINUTE(CreationDateTime) } = " + insertDate.Minute.ToString + " " + _
              " AND UserId = '" + U + "' "
        N = bdEntero(sql, "Total")
        If N = 0 Then
            visitaIngresada = False
        Else
            visitaIngresada = True
        End If
    End Function


End Class