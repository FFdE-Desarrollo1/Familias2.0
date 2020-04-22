Public Class AgregarClaseCombo
    Dim codClase, catClase As String

    Private Sub AgregarClaseCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarTipoCombo()
        ClaseEspV.Focus()
    End Sub

    Private Sub llenarTipoCombo()
        sql = "SELECT Code, DescSpanish FROM  CdClassSubjectFailedType "
        bdCombo(sql, TipoCombo, "Code", "DescSpanish")
    End Sub

    Private Sub ab()
        Dim formTitles As New Collection
        Dim formsAbiertas As Integer = My.Application.OpenForms.Count

        If formsAbiertas > 1 Then
            Try
                For Each f As Form In My.Application.OpenForms
                    If Not f.InvokeRequired Then
                        If f.Name = "RegistroCalificaciones" Then
                            'f.p()
                            'f.comboClases()
                        End If
                    End If
                Next
            Catch ex As Exception
                formTitles.Add("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub guardarClase()
        Dim codigo As String
        sql = "SELECT  MAX(CONVERT(int, Code)) AS Code FROM dbo.CdClassSubjectFailed "
        codigo = (bdEntero(sql, "Code") + 1).ToString
        sql = "INSERT INTO CdClassSubjectFailed VALUES ('" + codigo + "', '" + ClaseIngV.Text + "','" + ClaseEspV.Text + "', 1, '" + _
              TipoCombo.SelectedValue + "','" + U + "', GETDATE())"
        bdInsertar(sql)



        Me.Close()
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click
        If Len(ClaseEspV.Text) > 0 And Len(ClaseIngV.Text) > 0 And Len(TipoCombo.Text) > 0 Then
            Dim style As MsgBoxStyle = MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information Or MsgBoxStyle.YesNo
            Dim response As MsgBoxResult
            sql = "SELECT COUNT(*) Total FROM dbo.CdClassSubjectFailed WHERE DescSpanish = '" + ClaseEspV.Text + "' "
            Dim n = bdEntero(sql, "Total")
            If n = 0 Then
                guardarClase()
            Else
                response = MsgBox("La clase ya existe." + vbNewLine + "¿Quiere guardarla?", style, My.Resources.versionFamilias2)
                If response = MsgBoxResult.Yes Then
                    guardarClase()
                Else
                    Me.Close()
                End If
            End If
        Else
            MsgBox("Necesita llenar todos los campos", MsgBoxStyle.Critical, My.Resources.versionFamilias2)
        End If

    End Sub
End Class