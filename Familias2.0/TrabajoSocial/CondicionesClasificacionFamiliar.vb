' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class CondicionesClasificacionFamiliar

    Private Sub CondicionesClasificacionFamiliar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub FamiliasList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FamiliasList.CellContentClick
        Dim f, c, familia, cFamilia As Integer
        c = FamiliasList.CurrentCellAddress.X
        f = FamiliasList.CurrentCellAddress.Y
        cFamilia = 3
        familia = Integer.Parse(FamiliasList.Item(cFamilia, f).Value)
        Dim mes As Integer = Date.Now.Month
        Dim dia As Integer = Date.Now.Day

        If FamiliasList.Item(10, f).Value() = "" Or FamiliasList.Item(10, f).Value() = " " Then
            If c = 1 Then
                If mes > 11 And dia > 15 Then
                    MsgBox("La clasificación solo se puede ingresar solo hasta 15 de diciembre", vbQuestion, My.Resources.versionFamilias2)
                Else
                    goIngreso(familia, FamiliasList.Item(4, f).Value, FamiliasList.Item(5, f).Value, FamiliasList.Item(6, f).Value, FamiliasList.Item(8, f).Value, chequearValor(FamiliasList.Item(9, f).Value))
                End If
            End If
        ElseIf (FamiliasList.Item(1, f).Value() = "" Or FamiliasList.Item(10, f).Value() = " ") And c = 2 Then

            If mes > 11 And dia > 15 Then
                MsgBox("La clasificación solo se puede modificar hasta el 15 de diciembre", vbQuestion, My.Resources.versionFamilias2)
            Else
                goModificar(familia, FamiliasList.Item(4, f).Value, FamiliasList.Item(5, f).Value, FamiliasList.Item(6, f).Value, FamiliasList.Item(8, f).Value, FamiliasList.Item(9, f).Value)
            End If
        End If
    End Sub

    Private Sub goModificar(ByVal familia As Integer, ByVal area As String, ByVal madre As String, _
                      ByVal padre As String, ByVal clasActual As String, ByVal fechaActual As String)
        Dim mccf As New ModificarCondicionesClasFam
        mccf.FamiliaV.Text = familia.ToString
        mccf.AreaV.Text = area
        mccf.MadreV.Text = madre
        mccf.PadreV.Text = padre
        mccf.ClasificaciónActualV.Text = clasActual
        mccf.FechaActualV.Text = fechaActual
        mccf.Show()
        Me.Close()
    End Sub

    Private Sub goIngreso(ByVal familia As Integer, ByVal area As String, ByVal madre As String, _
                          ByVal padre As String, ByVal clasActual As String, ByVal fechaActual As String)
        Dim ing As New IngresarCondicionesClasFam
        ing.FamiliaV.Text = familia.ToString
        ing.AreaV.Text = area
        ing.MadreV.Text = madre
        ing.PadreV.Text = padre
        ing.ClasificaciónActualV.Text = clasActual
        ing.FechaActualV.Text = fechaActual
        ing.Show()
        Me.Close()
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listadoTS()
        sql = "SELECT EmployeeId AS TS " + _
              "FROM dbo.FwEmployeeRole " + _
              "WHERE Role = 'TS' AND Status = 'actv' AND Organization = '" + S + "'"
        bdComboSinCodigo(sql, TSlist)

        sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
              "WHERE EmployeeId = '" + U + "' AND Status = 'ACTV' AND  Role IN ('ASTS', 'EDTS', 'SUPE') AND Organization = '" + S + "'"
        If bdEntero(sql, "Total") = 0 Then
            TSlist.Text = U
            TSL.Visible = False
            TSlist.Visible = False
            VerListadoButton.Visible = False
        Else
            TSL.Visible = True
            TSlist.Visible = True
            VerListadoButton.Visible = True
        End If
    End Sub

    Private Sub listaFamilias()
        FamiliasList.DataSource = Nothing
        FamiliasList.Rows.Clear()
        FamiliasList.Visible = False
        TotalL.Visible = False

        Dim ts, reg, wReg As String
        If TSlist.Text = "" Or TSlist.Text = " " Then
            ts = ""
        Else
            ts = "AND TS = '" + TSlist.Text + "'"
        End If

        If S = "F" Then
            reg = ", Región "
        Else
            reg = ""
        End If

        If RegionV.Text = "" Or RegionV.Text = " " Then
            wReg = ""
        Else
            wReg = " AND Región = '" + RegionV.Text + "' "
        End If

        sql = "SELECT F.FamilyId Familia, Area, CASE WHEN Madre IS NULL THEN ' ' ELSE Madre END Madre, CASE WHEN Padre IS NULL THEN '' ELSE Padre END Padre, " + _
              "CASE WHEN TS IS NULL THEN '' ELSE TS END  AS TS, CASE WHEN F.Classification IS NULL THEN '' ELSE F.Classification END 'Actual', " + _
              "dbo.fn_GEN_FormatDate (ClassificationDate, 'ES') 'Fecha Clas. Actual', CASE WHEN FCH.Classification IS NULL THEN '' ELSE FCH.Classification END  AS 'Próxima', " + _
              "FCH.YearClassification 'Año Próximo', FCH.UserId Usuario  " + reg + " " + _
              "FROM v_GEN_FamiliasList F " + _
                "LEFT OUTER JOIN dbo.FamilyClassificationHistory FCH ON F.Project = FCH.Project AND F.FamilyId = FCH.FamilyId AND FCH.RecordStatus = ' ' " + _
                "AND FCH.Inactive = 0 AND FCH.YearClassification = YEAR(GETDATE()) + 1 " + _
              "WHERE F.Project = '" + S + "' AND AffiliationStatus = 'AFIL' " + ts + wReg + _
              " ORDER BY F.TS, F.Area, F.FamilyId "
        bdGrid(sql, FamiliasList)

        Dim n As Integer = FamiliasList.Rows.Count - 1
        For f = 0 To n
            FamiliasList.Item(0, f).Value = f + 1

            If FamiliasList.Item(10, f).Value() = "" Or FamiliasList.Item(10, f).Value() = " " Then
                FamiliasList.Item(1, f).Value = "Ingresar"
            Else
                FamiliasList.Item(2, f).Value = "Modificar"
                If FamiliasList.Item(10, f).Value() <> FamiliasList.Item(8, f).Value() Then
                    FamiliasList.Rows(f).DefaultCellStyle.BackColor = Color.SandyBrown
                    FamiliasList.Rows(f).DefaultCellStyle.ForeColor = Color.Black
                Else
                    FamiliasList.Rows(f).DefaultCellStyle.BackColor = Color.WhiteSmoke
                End If
            End If
        Next

        TotalL.Text = "Total: " + FamiliasList.RowCount.ToString

        FamiliasList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        FamiliasList.AutoResizeColumns()
        TotalL.Visible = True
        FamiliasList.Visible = True
        FamiliasList.AllowUserToOrderColumns = False
        FamiliasList.AllowUserToResizeColumns = False
    End Sub

    Private Sub VerListadoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerListadoButton.Click
        listaFamilias()
    End Sub

    Private Sub valoresIniciales()
        If S = "F" Then
            RegionL.Visible = True
            RegionV.Visible = True
        End If

        sql = "SELECT EmployeeId AS TS " + _
                 "FROM dbo.FwEmployeeRole " + _
                 "WHERE Role = 'TS' AND Status = 'actv' AND Organization = '" + S + "'"
        bdComboSinCodigo(sql, TSlist)

        sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
                 "WHERE EmployeeId = '" + U + "' AND Status = 'ACTV' AND  Role IN ('TS') AND Organization = '" + S + "'"
        If bdEntero(sql, "Total") > 0 Then
            TSlist.Text = U
        End If

        FamiliasList.Visible = False
        'listadoTS()
        'listaFamilias()
    End Sub
End Class