﻿' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class InformesFormularioMM
    Public wH, opcion As String

    Dim presDateTime, deliveredDateTime As String
    Dim BoldRow As New DataGridViewCellStyle With {.Font = New System.Drawing.Font("Arial", 11.0!, FontStyle.Bold)}

    Private Sub InformesFormularioMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub entregados()
        Dim t, p As Integer
        ListadoGrid.Columns.Item(0).Visible = False 'Code
        ListadoGrid.Columns(1).Frozen = True 'congelar columna articulo
        ListadoGrid.Columns(15).DefaultCellStyle = BoldRow 'negrilla columna promedio mensual
        ListadoGrid.Columns(17).DefaultCellStyle = BoldRow 'negrilla columna para un mes

        For i = 0 To ListadoGrid.RowCount - 1
            p = 0
            t = 0
            t = t + ListadoGrid.Item(2, i).Value() + ListadoGrid.Item(3, i).Value() + ListadoGrid.Item(4, i).Value() +
                ListadoGrid.Item(5, i).Value() + ListadoGrid.Item(6, i).Value() + ListadoGrid.Item(7, i).Value() +
                ListadoGrid.Item(8, i).Value() + ListadoGrid.Item(9, i).Value() + ListadoGrid.Item(10, i).Value() +
                ListadoGrid.Item(11, i).Value() + ListadoGrid.Item(12, i).Value() + ListadoGrid.Item(13, i).Value()
            ListadoGrid.Item(14, i).Value() = t

            If ListadoGrid.Item(2, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(3, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(4, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(5, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(6, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(7, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(8, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(9, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(10, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(11, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(12, i).Value() > 0 Then
                p = p + 1
            End If
            If ListadoGrid.Item(13, i).Value() > 0 Then
                p = p + 1
            End If
            ListadoGrid.Item(15, i).Value() = t / p

            If ListadoGrid.Item(15, i).Value() > ListadoGrid.Item(17, i).Value() Then
                ListadoGrid.Item(15, i).Style.ForeColor = Color.Chocolate
                ListadoGrid.Item(17, i).Style.ForeColor = Color.Chocolate
            End If
        Next
    End Sub

    Private Sub existencias()
        ListadoGrid.Columns.Item(0).Visible = False 'ValidSelection
        ListadoGrid.Columns.Item(1).Visible = False 'code

        ListadoGrid.Columns(4).DefaultCellStyle.ForeColor = Color.Green

        Dim ex, mes As Integer
        For i = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid.Item(0, i).Value() = False Then
                ListadoGrid.Rows(i).DefaultCellStyle = BoldRow
                ListadoGrid.Item(3, i).Style.ForeColor = Color.Gainsboro
                ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
            Else
                ex = Integer.Parse(ListadoGrid.Item(3, i).Value())
                mes = Integer.Parse(ListadoGrid.Item(4, i).Value())

                If ex <= mes Then
                    If ex < 0 Then
                        ListadoGrid.Item(3, i).Style.ForeColor = Color.Black
                        ListadoGrid.Item(3, i).Style.BackColor = Color.Yellow
                    ElseIf ex = 0 Then
                        ListadoGrid.Item(3, i).Style.ForeColor = Color.Red
                    Else
                        ListadoGrid.Item(3, i).Style.ForeColor = Color.Green
                    End If
                End If
            End If
        Next
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub listado(ByVal precio As Integer)
        If precio = 0 Then
            ListadoGrid.Columns.Item(3).Visible = False 'Precio
        End If

        ListadoGrid.Columns.Item(4).Visible = False 'ValidSelection
        For i = 0 To ListadoGrid.RowCount - 1
            If ListadoGrid.Item(4, i).Value() = False Then
                ListadoGrid.Rows(i).DefaultCellStyle = BoldRow
                ListadoGrid.Rows(i).DefaultCellStyle.BackColor = Color.Gainsboro
            End If
        Next
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New InformesFormularioMM1
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub transacciones()
        ListadoGrid.Columns.Item(0).Visible = False 'IdTrans
        ListadoGrid.Columns.Item(1).Visible = False 'Code
        ListadoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub valoresIniciales()
        Title.Text = "Informes de Materiales Médicos (" + Title.Text + ")"
        sql = wH
        bdGrid(sql, ListadoGrid)

        If opcion = "Existencias" Then
            existencias()
        ElseIf opcion = "Entregados" Then
            entregados()
        ElseIf opcion = "Transacciones" Then
            transacciones()
        Else
            ListadoGrid.Visible = False
        End If
    End Sub

End Class