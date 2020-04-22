' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class ReferenciasSalud
    Dim estadoOr As String
    Dim id As Integer
    Dim n As Integer = 0

    Private Sub ReferenciasSalud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub EstadoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        listado()
    End Sub

    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        If verificaCambios() = True Then
            Dim ahora As DateTime = DateTime.Now

            sql = "INSERT INTO dbo.MemberInternalReference " + _
                  "SELECT IdInternalRef, '" + ahora.ToString(en.DateTimeFormat) + "', RecordStatus, Project, MemberId, Program, Category, ReferenceDateTime, '" + U + "', ExpirationDateTime, " + _
                  "'" + EstadoCombo.SelectedValue + "', GETDATE(), ReferredBy, Description, '" + tsObserV.Text + "', IdConsultation " + _
                  "FROM dbo.MemberInternalReference WHERE RecordStatus = ' ' AND IdInternalRef = " + id.ToString
            bdInsertar(sql)
            GuardarButton.Visible = False
            Panel1.Visible = False
            listado()
        End If
    End Sub

    Private Sub listado()
        ListadoGrid.DataSource = Nothing
        ListadoGrid.Rows.Clear()
        ListadoGrid.Visible = False
        InfoTable.Visible = False
        Dim ts, estado, where, reg As String

        If S = "F" Then
            reg = " , dbo.fn_GEN_regionFamilia(refTS.Sitio, refTS.Familia) Región "
        Else
            reg = ""
        End If

        If Len(EstadoSelCombo.Text) = 0 Then
            estado = ""
        Else
            estado = " AND Estado = '" + EstadoSelCombo.Text + "' "
        End If

        If TSlist.Text = "" Or TSlist.Text = " " Then
            ts = ""
        Else
            ts = " AND TS = '" + TSlist.Text + "' "
        End If
        where = ts + estado

        If RegionV.Text = "" Or RegionV.Text = " " Then
            where = where + ""
        Else
            where = where + " AND dbo.fn_GEN_regionFamilia(refTS.Sitio, refTS.Familia) = '" + RegionV.Text + "' "
        End If

        sql = "SELECT *, DATEDIFF(d, ReferenceDateTime, GETDATE()) Dias " + reg + _
              "FROM dbo.fn_HEAL_ReferenciasInternas('TS') refTS WHERE Sitio = '" + S + "' AND  Estado_Afil_Familiar = 'Afiliado' " + where + _
              " ORDER BY TS, Familia, Miembro"
        bdGrid(sql, ListadoGrid)
        ListadoGrid.Columns.Item(0).Visible = False 'Id
        ListadoGrid.Columns.Item(13).Visible = False 'medico
        ListadoGrid.Columns.Item(14).Visible = False 'estado
        ListadoGrid.Columns.Item(15).Visible = False 'fechaEstado
        ListadoGrid.Columns.Item(16).Visible = False 'categoria
        ListadoGrid.Columns.Item(17).Visible = False 'descripcion
        ListadoGrid.Columns.Item(18).Visible = False 'seguimiento
        ListadoGrid.Columns.Item(19).Visible = False 'fecha
        ListadoGrid.Columns.Item(21).Visible = False 'fecha

        If EstadoSelCombo.Text = "Referencia" Then
            ListadoGrid.Columns.Item(21).Visible = True 'dias
        Else
            ListadoGrid.Columns.Item(21).Visible = False 'dias
        End If

        '20

        For f = 0 To ListadoGrid.Rows.Count - 1
            ListadoGrid.Rows(f).HeaderCell.Value = (f + 1).ToString
            If EstadoSelCombo.Text = "Referencia" Then
                n = ListadoGrid.Item(21, f).Value()
                If n > 7 And n <= 15 Then
                    ListadoGrid.Item(12, f).Style.BackColor = Color.DarkOrange
                ElseIf n > 15 Then
                    ListadoGrid.Item(12, f).Style.BackColor = Color.Red
                End If
            End If
        Next
        ListadoGrid.Visible = True
    End Sub

    Private Sub ListadoPorEstadoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoPorEstadoButton.Click
        listado()
    End Sub

    'Private Sub listadoTS()
    '    sql = "SELECT EmployeeId AS TS " + _
    '          "FROM dbo.FwEmployeeRole " + _
    '          "WHERE Role = 'TS' AND Status = 'actv' AND Organization = '" + S + "'"
    '    bdComboSinCodigo(sql, TSlist)

    '    sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
    '          "WHERE EmployeeId = '" + U + "' AND Status = 'ACTV' AND  Role IN ('ASTS', 'EDTS', 'SUPE') AND Organization = '" + S + "'"
    '    If bdEntero(sql, "Total") = 0 Then
    '        TSlist.Text = U
    '        TSL.Visible = False
    '        TSlist.Visible = False
    '        VerListadoButton.Visible = False
    '    Else
    '        TSL.Visible = True
    '        TSlist.Visible = True
    '        VerListadoButton.Visible = True
    '    End If
    'End Sub

    Private Sub ListadoGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListadoGrid.CellContentClick
        id = 0
        estadoOr = ""
        NombreV.Text = ""
        ReferenciaV.Text = ""
        ReferidoPorV.Text = ""
        EstadoCombo.Text = ""
        CategoriaV.Text = ""
        DescripcionV.Text = ""
        tsObserV.Text = ""

        Dim f As Integer
        f = ListadoGrid.CurrentCellAddress.Y
        id = ListadoGrid.Item(0, f).Value()
        estadoOr = ListadoGrid.Item(14, f).Value()
        NombreV.Text = ListadoGrid.Item(3, f).Value() + " " + ListadoGrid.Item(4, f).Value() + " (" + ListadoGrid.Item(2, f).Value().ToString + ")"
        FamiliaV.Text = ListadoGrid.Item(9, f).Value()
        ReferenciaV.Text = ListadoGrid.Item(12, f).Value()
        ReferidoPorV.Text = ListadoGrid.Item(13, f).Value()
        EstadoCombo.Text = estadoOr
        CategoriaV.Text = ListadoGrid.Item(16, f).Value()
        DescripcionV.Text = ListadoGrid.Item(17, f).Value()
        tsObserV.Text = chequearValor(ListadoGrid.Item(18, f).Value())

        If estadoOr = "Referencia" Then
            n = ListadoGrid.Item(21, f).Value()
            If n > 7 And n <= 15 Then
                ReferenciaV.BackColor = Color.DarkOrange
            ElseIf n > 15 Then
                ReferenciaV.BackColor = Color.Red
            End If
        End If

        If estadoOr = "Concluido" Then
            tsObserV.ReadOnly = True
            EstadoCombo.Enabled = False
            GuardarButton.Visible = False
        Else
            GuardarButton.Visible = True
            tsObserV.ReadOnly = False
            EstadoCombo.Enabled = True
        End If

        InfoTable.Visible = True
        Panel1.Visible = True
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
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
        ListadoGrid.Visible = False

        sql = "SELECT Code, DescSpanish 'Estado' from dbo.CdInternalReferenceStatus "
        bdCombo(sql, EstadoCombo, "Code", "Estado")
        bdCombo(sql, EstadoSelCombo, "Code", "Estado")

        EstadoSelCombo.Text = "Referencia"
        'listadoTS()
        'listado()
    End Sub

    Private Function verificaCambios() As Boolean
        verificaCambios = True
        If Len(EstadoCombo.Text) = 0 Then
            MsgBox("El estado de la referencia no puede estar vacio", vbQuestion, My.Resources.versionFamilias2)
            verificaCambios = False
        ElseIf EstadoCombo.SelectedValue = "REFE" And Len(tsObserV.Text) > 0 Then
            MsgBox("Necesita actualizar el estado", vbQuestion, My.Resources.versionFamilias2)
            verificaCambios = False
        ElseIf EstadoCombo.SelectedValue = "REFE" And Len(tsObserV.Text) = 0 Then
            MsgBox("No esta realizando ningun cambio", vbQuestion, My.Resources.versionFamilias2)
            verificaCambios = False
        End If
    End Function

End Class