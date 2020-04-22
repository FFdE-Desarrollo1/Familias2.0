' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class cnSvr
    Dim connec As String = conexion()

    Private Function conexion() As String
        conexion = "data source = " & My.Resources.svr & "; initial catalog = " & My.Resources.db & "; " & svrUP()
    End Function

    Public Sub ejecutarInsert(ByVal stringSQL As String)
        Dim cn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        cn = New SqlConnection(connec)
        cmd = New SqlCommand(stringSQL, cn)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'ex.Message.ToString & " - " & 
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.StackTrace & vbCrLf & vbCrLf & "IT: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub ejecutarSQL(ByVal stringSQL As String)
        Dim cn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        cn = New SqlConnection(connec)
        cmd = New SqlCommand(stringSQL, cn)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub llenarGrid(ByVal stringSQL As String, _
                        ByRef grid As DataGridView)
        Dim cn As New SqlConnection(connec)
        Dim daUser As SqlDataAdapter
        Dim dtUser As New DataTable
        Dim adap As DataTableReader
        Try
            cn.Open()
            daUser = New SqlDataAdapter(stringSQL, connec)
            daUser.Fill(dtUser)
            adap = New DataTableReader(dtUser)
            grid.DataSource = dtUser
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            'InputBox("error", "error", stringSQL)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub llenarDataSet(ByVal stringSQL As String, _
                    ByRef dataSetO As DataSet)
        Dim cn As New SqlConnection(connec) ' nueva conexión indicando al SqlConnection la cadena de conexión   
        Try
            cn.Open()            ' Abrir la conexión a Sql   
            Dim cmd As New SqlCommand(stringSQL, cn) ' Pasar la consulta sql y la conexión al Sql Command    
            Dim da As New SqlDataAdapter(cmd) ' Inicializar un nuevo SqlDataAdapter 
            da.Fill(dataSetO)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub llenarDataTable(ByVal stringSQL As String, _
                        ByRef tableData As DataTable)
        Dim cn As New SqlConnection(connec)
        Dim daUser As SqlDataAdapter
        Dim adap As DataTableReader

        Try
            cn.Open()
            daUser = New SqlDataAdapter(stringSQL, connec)
            daUser.Fill(tableData)
            adap = New DataTableReader(tableData)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Public Sub llenarCombo(ByVal sql As String, _
                         ByVal ComboBox As ComboBox, _
                            ByVal codigo As String, ByVal Descripcion As String)
        Dim cn As New SqlConnection(connec)

        Try
            cn.Open()            ' Abrir la conexión a Sql   
            Dim cmd As New SqlCommand(sql, cn) ' Pasar la consulta sql y la conexión al Sql Command    
            Dim da As New SqlDataAdapter(cmd) ' Inicializar un nuevo SqlDataAdapter 
            Dim ds As New DataSet 'Crear y Llenar un Dataset 

            da.Fill(ds)

            With ComboBox
                ComboBox.DataSource = ds.Tables(0)
                ComboBox.DisplayMember = Descripcion
                ComboBox.ValueMember = codigo
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & sql, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        ComboBox.SelectedIndex = ComboBox.FindStringExact("") 'blank row
    End Sub

    Public Sub llenarComboSinBlancos(ByVal sql As String, _
                     ByVal ComboBox As ComboBox, _
                        ByVal codigo As String, ByVal Descripcion As String)
        Dim cn As New SqlConnection(connec)

        Try
            cn.Open()            ' Abrir la conexión a Sql   
            Dim cmd As New SqlCommand(sql, cn) ' Pasar la consulta sql y la conexión al Sql Command    
            Dim da As New SqlDataAdapter(cmd) ' Inicializar un nuevo SqlDataAdapter 
            Dim ds As New DataSet 'Crear y Llenar un Dataset 

            da.Fill(ds)

            With ComboBox
                ComboBox.DataSource = ds.Tables(0)
                ComboBox.DisplayMember = Descripcion
                ComboBox.ValueMember = codigo
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & sql, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        'ComboBox.SelectedIndex = ComboBox.FindStringExact("") 'blank row
    End Sub

    Public Sub llenarComboSinCodigo(ByVal ComboBox As ComboBox, _
                    ByVal sql As String, _
                    ByVal blankRow As Boolean)
        Dim cn As New SqlConnection(connec)
        Try
            cn.Open()            ' Abrir la conexión a Sql   
            Dim cmd As New SqlCommand(sql, cn) ' Pasar la consulta sql y la conexión al Sql Command    
            Dim da As New SqlDataAdapter(cmd) ' Inicializar un nuevo SqlDataAdapter 
            Dim ds As New DataSet 'Crear y Llenar un Dataset 

            da.Fill(ds)
            ComboBox.DataSource = ds.Tables(0)          ' asignar el DataSource al combobox 
            ComboBox.DisplayMember = ds.Tables(0).Columns(0).ColumnName ' Asignar el campo a la propiedad DisplayMember del combo 
            If blankRow = True Then
                ComboBox.SelectedIndex = ComboBox.FindStringExact("")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & sql, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Function obtieneDoble(ByVal stringSQL As String, _
          ByVal title As String) As Double
        Dim cn As New SqlConnection(connec)
        Dim daUser As SqlDataAdapter
        Dim adap As DataTableReader
        Dim tableData As New DataTable
        Dim temp As Double

        Try
            cn.Open()
            daUser = New SqlDataAdapter(stringSQL, connec)
            daUser.Fill(tableData)
            adap = New DataTableReader(tableData)
            cn.Close()
            temp = tableData.Rows(0)(title)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        obtieneDoble = temp
    End Function

    Function obtieneEntero(ByVal stringSQL As String, ByVal title As String) As Integer
        Dim cn As New SqlConnection(connec)
        Dim daUser As SqlDataAdapter
        Dim adap As DataTableReader
        Dim tableData As New DataTable
        Dim temp As Integer

        Try
            cn.Open()
            daUser = New SqlDataAdapter(stringSQL, connec)
            daUser.Fill(tableData)
            adap = New DataTableReader(tableData)
            cn.Close()
            temp = tableData.Rows(0)(title)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        obtieneEntero = temp
    End Function

    Function obtienePalabra(ByVal stringSQL As String, _
           ByVal title As String) As String
        Dim cn As New SqlConnection(connec)
        Dim daUser As SqlDataAdapter
        Dim adap As DataTableReader
        Dim tableData As New DataTable
        Dim temp As String = ""

        Try
            cn.Open()
            daUser = New SqlDataAdapter(stringSQL, connec)
            daUser.Fill(tableData)
            adap = New DataTableReader(tableData)
            cn.Close()
            temp = tableData.Rows(0)(title)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Por favor envíe esta información a Sistemas: " & vbCrLf & vbCrLf & ex.Message.ToString & " - " & vbCrLf & ex.StackTrace & vbCrLf & "ref: " & stringSQL, _
                            "ERROR", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        obtienePalabra = temp
    End Function

    Private Function svrUP() As String
        svrUP = "user id = saApps; password = AppsC0mm0nH0p3"

    End Function

End Class

