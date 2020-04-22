' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class Planilla
    Dim desc As String
    Dim t As Integer

    Private Sub Planilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        valoresIniciales()
    End Sub

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub CantidadV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadV.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            irReportePlanilla()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosConDecimal(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function carrera() As String
        If CarreraV.Text = "" Or IsDBNull(CarreraV) Then
            carrera = " "
        Else
            carrera = " AND Carrera = '" + CarreraV.Text + "'"
        End If
    End Function

    Private Sub description()
        If L = "es" Then
            desc = "DescSpanish"
        Else
            desc = "DescEnglish"
        End If
    End Sub

    Private Function estado() As String
        Dim temporal As String = EstadoV.Text
        If temporal = "" Or temporal = " " Or IsDBNull(temporal) Then
            estado = " "
        ElseIf temporal = "Estudiando, Repitiendo o Condicional" Then
            estado = " AND Estado IN ('Estudiando','Repitiendo') "
        ElseIf temporal = "_Graduandos (Estudiando y Repitiendo Ultimo Año, Graduado)" Then
            estado = "AND Estado IN ('_Estudiando (Ultimo Año)','_Repitiendo (Ultimo año)')"
        Else
            estado = "AND Estado = '" + temporal + "'"
        End If
    End Function

    Private Function grado() As String
        If GradoV.Text = "" Or IsDBNull(GradoV) Then
            grado = " "
        Else
            grado = " AND Grado = '" + GradoV.Text + "'"
        End If
    End Function

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub irReportePlanilla()
        If verificaDatos() = True Then
            Dim nxt As New Planilla2
            nxt.año = AñoV.Text
            nxt.grado = grado()
            nxt.estado = estado() 'EstadoV.Text
            nxt.escuela = EscuelaV.Text
            nxt.nivel = nivel()
            nxt.carrera = carrera()
            nxt.cantidad = Convert.ToDouble(CantidadV.Text)
            nxt.CantidadV.Text = Convert.ToDouble(CantidadV.Text)
            nxt.tipo = TipoV.SelectedValue
            nxt.tipoOpL.Text = TipoV.Text
            'nxt.TipoV.Text = TipoV.SelectedText

            If pago() = "0" Then
                If S = "R" Then
                    nxt.Efectivock.Visible = True
                    nxt.Efectivock.Checked = True
                Else
                    nxt.ACHch.Checked = False
                    nxt.ACHch.Enabled = True
                    nxt.Efectivock.Visible = False
                    nxt.CHEQUEck.Enabled = True
                    nxt.CHEQUEck.Checked = True
                End If
            Else
                nxt.ACHch.Checked = True
                nxt.ACHch.Enabled = False
                nxt.CHEQUEck.Enabled = False
                nxt.CHEQUEck.Checked = False
                nxt.Efectivock.Enabled = False
            End If
            nxt.Show()
            Me.Close()
        End If
    End Sub

    Private Sub llenarListaCarreras()
        If EscuelaV.Text = " " Or EscuelaV.Text = "" Then
        Else
            Dim codes As New DataTable
            Dim n As Integer
            Dim codeList As String
            sql = "SELECT Career " + _
                  "FROM dbo.MemberEducationYear " + _
                  "WHERE RecordStatus = ' ' AND Project = '" + S + "' AND SchoolCode = 'CISA' AND SchoolYear = " + AñoV.Text + "  AND Career IS NOT NULL " + _
                  "GROUP BY Career"
            bdDataTable(sql, codes)

            n = codes.Rows.Count - 1
            codeList = "'" + chequearValor(codes.Rows(0)("Career")) + "' "
            For i = 1 To n
                codeList = ", '" + chequearValor(codes.Rows(i)("Career")) + "' "
            Next
        End If
    End Sub

    Private Function nivel() As String
        If NivelV.Text = "" Or IsDBNull(NivelV.Text) Then
            nivel = " "
        Else
            nivel = " AND    Nivel = '" + NivelV.Text + "' "
        End If
    End Function

    Private Function pago() As String
        sql = "SELECT dbo.fn_BECA_getPayTypePlanilla('" + S + "', '" + EscuelaV.Text + "') AS Pay "
        pago = bdPalabra(sql, "Pay")
    End Function

    Private Sub SeguirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguirButton.Click
        irReportePlanilla()
    End Sub

    Private Sub valoresIniciales()
        t = 0
        sql = "SELECT code codigo, DescSpanish tipo " + _
                             "FROM CdReimbursementType " + _
                             "WHERE FunctionalArea = 'EDUC' AND Active = 1 AND Project IN ('*', '" + S + "')" + _
                             "ORDER BY DescSpanish"
        bdCombo(sql, TipoV, "codigo", "tipo")

        sql = "SELECT DescSpanish " + _
                                 "FROM dbo.CdGrade " + _
                                 " WHERE EducationLevel NOT IN ('CEIF', 'NOES', 'TERA', 'UNIV') " + _
                                 "ORDER BY Orden"
        bdComboSinCodigo(sql, GradoV)

        sql = "SELECT DescSpanish " + _
                         "FROM dbo.CdEducationLevel " + _
                         "WHERE Code not in('ALFA', 'CEIF', 'MADU', 'NOES', 'TERA', 'UNIV') " + _
                         "ORDER BY DescSpanish "
        bdComboSinCodigo(sql, NivelV)

        sql = "SELECT DescSpanish " + _
                                  "FROM dbo.CdEducationStatus " + _
                                  "WHERE Code NOT IN ('BECO', 'NESP', 'BAGE', 'RECI', 'NOEX', 'NOSI', 'PINS', 'GANO', 'PERD', 'GRAD', 'COND') " + _
                                  "ORDER BY DescSpanish "
        bdComboSinCodigo(sql, EstadoV)

        sql = "SELECT DescSpanish " + _
                                   "FROM dbo.CdEducationCareer WHERE EducationLevel = 'DIVE' " + _
                                   "ORDER BY DescSpanish"
        bdComboSinCodigo(sql, CarreraV)

        EstadoV.Text = "Estudiando, Repitiendo o Condicional"
        AñoV.Text = DateTime.Now.Year.ToString

        If DateTime.Now.Month = 1 Or DateTime.Now.Month = 12 Then
            sql = "SELECT Name " + _
               "FROM dbo.School " + _
               "WHERE Project = '" + S + "' AND RecordStatus = ' ' AND Active= 1 " + _
               "ORDER BY Name"
        Else
            sql = "SELECT S.Name " + _
                  "FROM dbo.MemberEducationYear MEY INNER JOIN dbo.School S ON MEY.Project = S.Project AND MEY.SchoolCode = S.Code AND MEY.RecordStatus = S.RecordStatus " + _
                  "WHERE MEY.RecordStatus = ' ' AND MEY.SchoolYear = " + AñoV.Text + " AND MEY.Project = '" + S + "' AND S.Active = 1 " + _
                  "GROUP BY S.Name HAVING      (COUNT(*) > 0) "
        End If

        bdComboSinCodigo(sql, EscuelaV)
        GradoV.Focus()
    End Sub

    Private Function verificaDatos() As Boolean
        verificaDatos = True
        If NivelV.Text <> "" And GradoV.Text <> "" Then
            MsgBox("Solo se puede seleccionar Nivel o Grado, no ambos", vbInformation, My.Resources.versionFamilias2)
            verificaDatos = False
        ElseIf (IsDBNull(EscuelaV) Or EscuelaV.Text = "") Or (IsDBNull(TipoV) Or TipoV.Text = "") _
            Or (IsDBNull(CantidadV) Or CantidadV.Text = "") Then
            MsgBox("Debe seleccionar un dato en cada lista", vbInformation, My.Resources.versionFamilias2)
            verificaDatos = False
        Else
            verificaDatos = True
        End If
    End Function

End Class