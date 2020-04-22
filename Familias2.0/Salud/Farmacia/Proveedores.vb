Imports System.Text

' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class Proveedores

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub BorrarProvButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarProvButton.Click
        If IdProveedor.Text = "0" Then
        Else
            If activoL.Text = "Si" Then
                sql = "UPDATE dbo.CdProvider SET Active = 0 WHERE Code = '" + IdProveedor.Text + "'"
            Else
                sql = "UPDATE dbo.CdProvider SET Active = 1 WHERE Code = '" + IdProveedor.Text + "'"
            End If
            bdEjecutarSQL(sql)
            proveedores()
            limpiarCampos()
        End If
    End Sub

    Private Function existeProveedor(ByVal desc As String, ByVal campo As String) As Boolean
        sql = "SELECT COUNT(*) Total FROM dbo.CdProvider WHERE " + campo + " = '" + desc + "' "
        Dim n As Integer = bdEntero(sql, "Total")

        If n > 0 Then
            existeProveedor = True
        Else
            existeProveedor = False
        End If
    End Function

    Private Sub guardarProvButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarProvButton.Click
        If IdProveedor.Text = "0" And Len(proveedorV.Text) > 0 Then
            Dim nuevoId As String = cadenaParaCodigo(proveedorV.Text)
            Dim n As Integer = 0

            If existeProveedor(nuevoId, "Code") = True Then
                If Len(nuevoId) < 4 Then
                    n = 4 - Len(nuevoId)
                    nuevoId = nuevoId + letrasRandom(n)
                Else
                    nuevoId = nuevoId.Substring(Len(nuevoId) - 1, 2)
                    nuevoId = nuevoId + letrasRandom(2)
                End If
                ingresarProveedor(Microsoft.VisualBasic.Left(nuevoId, 4))
            Else
                ingresarProveedor(Microsoft.VisualBasic.Left(nuevoId, 4))
            End If
        Else
        End If
    End Sub

    Private Sub ingresarProveedor(ByVal id As String)
        If existeProveedor(id, "Code") = True Then
            Dim n As Integer
            If Len(id) < 4 Then
                n = 4 - Len(id)
                id = id + letrasRandom(n)
            Else
                id = id.Substring(Len(id) - 1, 2)
                id = id + letrasRandom(2)
            End If
            If existeProveedor(id, "Code") = False Then
                sql = "INSERT INTO dbo.CdProvider VALUES ('" + id + "', '" + Replace(Replace(proveedorV.Text, "'", "''"), ",", " ") + "', '" + Replace(Replace(proveedorV.Text, "'", "''"), ",", " ") + "', 1, 'FARM', 'F')"
                bdInsertar(sql)
                proveedores()
                limpiarCampos()
            Else
                MsgBox("Existe un proveedor con el mismo código", vbQuestion, My.Resources.versionFamilias2)
            End If
        Else
            sql = "INSERT INTO dbo.CdProvider VALUES ('" + id + "', '" + Replace(Replace(proveedorV.Text, "'", "''"), ",", " ") + "', '" + Replace(Replace(proveedorV.Text, "'", "''"), ",", " ") + "', 1, 'FARM', 'F')"
            bdInsertar(sql)
            proveedores()
            limpiarCampos()
        End If
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Function letrasRandom(ByVal cantidad As Integer)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To cantidad
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        letrasRandom = sb.ToString()
    End Function

    Private Sub limpiarCampos()
        proveedorV.Text = ""
        IdProveedor.Text = "0"
        activoL.Text = "0"
        'nuevoL.Text = "Nuevo Proveedor"
    End Sub

    Private Sub LimpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarButton.Click
        limpiarCampos()
    End Sub

    Private Sub nuevoL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles nuevoL.LinkClicked
        limpiarCampos()
        proveedorV.ReadOnly = False
        proveedorL.Visible = True
        proveedorV.Visible = True
        LimpiarButton.Visible = True
        guardarProvButton.Visible = True
        BorrarProvButton.Visible = False
    End Sub

    Private Sub proveedores()
        sql = "SELECT Code, DescSpanish Proveedor, CASE WHEN Active = 1 THEN 'Si' ELSE 'No' END Activo " + _
              "FROM dbo.CdProvider  " + _
              "WHERE Project = '" + S + "' AND FunctionalArea = 'FARM' " + _
             "ORDER BY DescSpanish "
        bdGrid(sql, proveedoresGrid)
        proveedoresGrid.Columns.Item(0).Visible = False 'Codigo
    End Sub

    Private Sub proveedoresGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles proveedoresGrid.CellContentClick
        Dim fila, columna As Integer
        fila = proveedoresGrid.CurrentCellAddress.Y()
        columna = proveedoresGrid.CurrentCellAddress.X()

        IdProveedor.Text = proveedoresGrid.Item(0, fila).Value
        activoL.Text = proveedoresGrid.Item(2, fila).Value
        proveedorV.Text = proveedoresGrid.Item(1, fila).Value

        If activoL.Text = "Si" Then
            BorrarProvButton.Text = "Inactivar Proveedor"
        Else
            BorrarProvButton.Text = "Activar Proveedor"
        End If

        proveedorV.ReadOnly = True
        proveedorV.Visible = True
        proveedorL.Visible = True
        LimpiarButton.Visible = True
        BorrarProvButton.Visible = True
        guardarProvButton.Visible = False
        'nuevoL.Text = "Proveedor"
    End Sub

    Private Sub valoresIniciales()
        proveedores()
    End Sub

End Class