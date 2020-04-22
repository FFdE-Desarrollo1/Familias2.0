' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class BorrarReembolsoConPago
    Dim fecha As DateTime
    Dim contador As Integer

    Private Sub BorrarReembolsoConPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub AllCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCheck.CheckedChanged
        For f = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Item(0, f).Value = AllCheck.Checked
        Next
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BuscarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarButton.Click
        If Len(TipoV.Text) = 0 Or Len(CantidadV.Text) = 0 Then
            MsgBox("Todos los campos con * necesitan información", vbInformation, My.Resources.versionFamilias2)
        Else
            listado()
        End If
    End Sub

    Private Sub borrarReembolsos(ByVal idMiembro As Integer, ByVal tipo As String, ByVal fechaReem As String, ByVal monto As String)
        sql = "UPDATE dbo.MemberReimbursement SET RecordStatus = 'H', ExpirationDateTime = '" + fecha.ToString(en.DateTimeFormat) + "' " + _
              "WHERE RecordStatus = ' ' AND FunctionalArea = 'EDUC' AND ReimbursementBy IS NULL AND CheckNumber = 'ACH' AND Amount = " + monto + " " + _
              "AND Type = '" + tipo + "' AND CONVERT(nvarchar(30), ApprovedDateTime, 20) = CONVERT(nvarchar(30), '" + fechaReem + "', 20) " + _
              "AND MemberId = " + idMiembro.ToString
        bdEjecutarSQL(sql)
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub guardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If ListadoGrid.RowCount = 0 Then
        Else
            listadoParaBorrar()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado()
        AllCheck.Visible = False
        AllCheck.Checked = False
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()

        Dim gra, esc, car As String

        If Len(GradoV.Text) = 0 Then
            gra = " "
        Else
            gra = " AND MEY.Grade = '" + GradoV.SelectedValue + "' "
        End If

        If Len(EscuelaV.Text) = 0 Then
            esc = " "
        Else
            esc = " AND MEY.SchoolCode = '" + EscuelaV.SelectedValue + "' "
        End If

        If Len(CarreraV.Text) = 0 Then
            car = " "
        Else
            car = " AND MEY.Career = '" + CarreraV.SelectedValue + "' "
        End If

        sql = "SELECT MR.Type, CONVERT(nvarchar(30), MR.ApprovedDateTime, 20) AS F, M.MemberId AS Apadrinado, " + _
              "M.FirstNames + ' ' + M.LastNames AS Nombre, M.LastFamilyId AS Familia, cdG.DescSpanish AS Grado, cdES.DescSpanish AS Estado,  " + _
              "cdEC.DescSpanish AS Carrera, S.Name AS Escuela, dbo.CdReimbursementType.DescSpanish AS Tipo, MR.Amount AS Cantidad, MR.ApprovedAmount Aprobado, " + _
              "(MR.ApprovedAmount * 100.00 / MR.Amount) '%', MR.ApprovedBy AS Aprobó, MR.Notes Observaciones " + _
              "FROM dbo.MemberReimbursement MR " + _
                "INNER JOIN dbo.Member M ON M.Project = MR.Project AND M.MemberId = MR.MemberId AND M.RecordStatus = MR.RecordStatus " + _
                "INNER JOIN dbo.CdReimbursementType ON MR.Type = dbo.CdReimbursementType.Code " + _
                "LEFT OUTER JOIN dbo.MemberEducationYear MEY ON M.Project = MEY.Project AND M.MemberId = MEY.MemberId AND M.RecordStatus = MEY.RecordStatus AND " + _
                "MEY.SchoolYear = YEAR({ fn NOW() }) AND MEY.Grade = dbo.fn_GEN_getActualGrade(MEY.Project, MEY.MemberId, MEY.SchoolYear) " + _
                "LEFT OUTER JOIN dbo.CdGrade cdG ON MEY.Grade = cdG.Code LEFT OUTER JOIN dbo.CdEducationStatus cdES ON cdES.Code = MEY.Status " + _
                "LEFT OUTER JOIN dbo.School S ON S.Project = MEY.Project AND S.RecordStatus = MEY.RecordStatus AND S.Code = MEY.SchoolCode " + _
                "LEFT OUTER JOIN dbo.CdEducationCareer cdEC ON cdEC.Code = MEY.Career " + _
              "WHERE MR.RecordStatus = ' ' AND MR.FunctionalArea = 'EDUC' AND MR.ReimbursementBy IS NULL AND MR.CheckNumber = 'ACH' AND " + _
              "MR.Amount = " + CantidadV.Text + " AND MR.Type = '" + TipoV.SelectedValue + "' " + _
              " AND YEAR(MR.ApprovedDateTime) = " + FechaPicker.Value.Year.ToString + " AND MONTH(MR.ApprovedDateTime) = " + FechaPicker.Value.Month.ToString + _
              " AND DAY(MR.ApprovedDateTime) = " + FechaPicker.Value.Day.ToString + " " + _
               "ORDER BY M.MemberId "
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(1).Visible = False 'IDtipo
        ListadoGrid.Columns.Item(2).Visible = False 'fecha
        ListadoGrid.Columns.Item(3).ReadOnly = True

        For i = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next

        If ListadoGrid.RowCount > 0 Then
            AllCheck.Visible = True
            GuardarButton.Visible = True
        Else
            AllCheck.Visible = False
            GuardarButton.Visible = False
        End If
    End Sub

    Private Sub listadoParaBorrar()
        Dim t, n As Integer
        Dim tempC As New CheckBox
        n = ListadoGrid.Rows.Count - 1

        For i = 0 To n
            tempC.Checked = ListadoGrid.Item(0, i).Value()
            If tempC.Checked = True Then
                t = t + 1
            End If
        Next

        If t = 0 Then
            MsgBox("No ha seleccionado ningun registro", vbInformation, My.Resources.versionFamilias2)
        Else
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            style = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical Or MsgBoxStyle.YesNo

            response = MsgBox("¿Esta seguro de borrar " + t.ToString + " registros? ", style, My.Resources.versionFamilias2)
            If response = MsgBoxResult.Yes Then
                fecha = DateTime.Now

                Dim f As Integer
                contador = 0

                For f = 0 To n
                    tempC.Checked = ListadoGrid.Item(0, f).Value()
                    If tempC.Checked = True Then
                        contador = contador + 1
                        borrarReembolsos(ListadoGrid.Item(3, f).Value, ListadoGrid.Item(1, f).Value, ListadoGrid.Item(2, f).Value, CantidadV.Text)
                    Else
                        contador = contador
                    End If
                Next
                MsgBox("Fueron eliminados " + contador.ToString + " registros", vbInformation, My.Resources.versionFamilias2)

                listado()
            End If
        End If
    End Sub

    Private Sub valoresIniciales()
        sql = "SELECT Code,  DescSpanish 'Tipo' FROM CdReimbursementType " + _
              "WHERE FunctionalArea = 'EDUC' AND Active = 1 AND Project IN ('*', '" + S + "')" + _
              "ORDER BY DescSpanish"
        bdCombo(sql, TipoV, "Code", "Tipo")

        sql = "SELECT Code, DescSpanish Grado FROM dbo.CdGrade " + _
              " WHERE EducationLevel NOT IN ('CEIF', 'NOES', 'TERA', 'UNIV') " + _
              "ORDER BY Orden"
        bdCombo(sql, GradoV, "Code", "Grado")

        sql = "SELECT Code, DescSpanish 'Carrera' FROM dbo.CdEducationCareer " + _
              "WHERE EducationLevel = 'DIVE' " + _
              "ORDER BY DescSpanish"
        bdCombo(sql, CarreraV, "Code", "Carrera")

        If DateTime.Now.Month = 1 Or DateTime.Now.Month = 12 Then
            sql = "SELECT Code, Name 'Escuela' " + _
               "FROM dbo.School " + _
               "WHERE Project = '" + S + "' AND RecordStatus = ' ' AND Active= 1 " + _
               "ORDER BY Name"
        Else
            sql = "SELECT S.Code, S.Name 'Escuela' " + _
                  "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.School S ON MEY.Project = S.Project AND MEY.SchoolCode = S.Code AND MEY.RecordStatus = S.RecordStatus " + _
                  "WHERE MEY.RecordStatus = ' ' AND MEY.SchoolYear = YEAR(GETDATE())  AND MEY.Project = '" + S + "' AND S.Active = 1 " + _
                  "GROUP BY S.Code,  S.Name   HAVING (COUNT(*) > 0) "
        End If
        bdCombo(sql, EscuelaV, "Code", "Escuela")

        TipoV.Size = New Point(212, 21)
        GradoV.Size = New Point(212, 21)
        EscuelaV.Size = New Point(300, 21)
        CarreraV.Size = New Point(320, 21)
    End Sub
End Class