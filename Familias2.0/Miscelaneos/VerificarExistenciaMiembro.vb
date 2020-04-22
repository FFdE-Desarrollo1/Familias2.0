' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Francisco Berganza
' @version 1.0

Public Class VerificarExistenciaMiembro
    Dim cadena As String

    Private Sub VerificarExistenciaMiembro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BannerInfo()
        llenarMesesCombo()
    End Sub

    '---------------------------------------------------------------
    'Private Sub GotfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
    '    'capturamos el texto que tenia
    '    cadena = sender.Text
    '    'borramos el texto del textbox
    '    sender.Text = ""
    '    'ponemos el color de la letra en negro
    '    sender.ForeColor = Color.Black
    'End Sub

    'Private Sub LostfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If sender.Text = "" Then 'si salio del textbox sin poner nada
    '        sender.Text = cadena  'volverle a poner el texto que tenia
    '        sender.ForeColor = Color.LightGray 'y poner la letra en gris
    '    End If

    'End Sub
    '---------------------------------------------------------------

    Private Sub BannerInfo()
        Dim bnn As New mnCH
        bnn.configBanner(bannerPanel)
    End Sub

    Private Sub inicioButton_Click(sender As Object, e As EventArgs) Handles inicioButton.Click
        Dim nxt As New Familias
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub NuevoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoButton.Click
        Dim nxt As New VerificarExistenciaMiembro
        nxt.Show()
        Me.Close()
    End Sub

    Private Sub ListadoPorNombre(ByVal filtroNombre As String, ByVal filtroApellido As String)
        Dim Sql, selectSQL As String
        Dim DiaNac, MesNac, AñoNac As String

        selectSQL = "SELECT M.FirstNames Nombres, M.Lastnames Apellidos, " + _
                "dbo.fn_GEN_FormatDate(M.BirthDate, 'es') AS Nacimiento, M.MemberId Miembro, M.LastFamilyid Familia, F.Pueblo " + _
                "FROM Member M INNER JOIN Family F " + _
                "ON (M.Project=F.Project) and (M.RecordStatus=F.RecordStatus) and (M.LastFamilyId=F.FamilyId) " + _
                "WHERE M.RecordStatus = ' ' and M.Project = '" + S + "' and M.FirstNames like '%" + filtroNombre + "%' and M.LastNames like '%" + ApellidosV.Text + "%' "

        If NombresV.Text = "" And ApellidosV.Text = "" And diaNacV.Text = "" And MesCombo.SelectedValue.ToString = "" And añoNacV.Text = "" Then
            MsgBox("Para realizar la búsqueda debe llenar por lo menos 1 criterio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Familias 2.0")
        Else

            'dia nacimiento
            DiaNac = ""
            If diaNacV.Text <> "" Then
                DiaNac = " and Day(M.BirthDate)=" + diaNacV.Text + " "
            End If

            'mes nacimiento
            MesNac = ""
            If MesCombo.SelectedValue.ToString <> "" Then
                MesNac = " and Month(M.BirthDate)=" + MesCombo.SelectedValue.ToString + " "
            End If

            'año nacimiento
            AñoNac = ""
            If añoNacV.Text <> "" Then
                AñoNac = " and Year(M.BirthDate)=" + añoNacV.Text + " "
            End If

            Sql = selectSQL + DiaNac + MesNac + AñoNac + " ORDER BY M.FirstNames, M.LastNames, M.BirthDate"
            bdGrid(Sql, ListGridMiembros)
            ListGridMiembros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        End If
    End Sub

    Private Sub ListadoPorFecha(ByVal filtroNombre As String, ByVal filtroApellido As String)
        Dim Sql, selectSQL As String
        Dim DiaNac, MesNac, AñoNac As String

        selectSQL = "SELECT dbo.fn_GEN_FormatDate(M.BirthDate, 'es') AS Nacimiento, M.FirstNames Nombres, M.Lastnames Apellidos, " + _
                "M.MemberId Miembro, M.LastFamilyid Familia, F.Pueblo " + _
                "FROM Member M INNER JOIN Family F " + _
                "ON (M.Project=F.Project) and (M.RecordStatus=F.RecordStatus) and (M.LastFamilyId=F.FamilyId) " + _
                "WHERE M.RecordStatus = ' ' and M.Project = '" + S + "' and M.FirstNames like '%" + filtroNombre + "%' and M.LastNames like '%" + ApellidosV.Text + "%' "

        If NombresV.Text = "" And ApellidosV.Text = "" And diaNacV.Text = "" And MesCombo.SelectedValue.ToString = "" And añoNacV.Text = "" Then
            MsgBox("Para realizar la búsqueda debe llenar por lo menos 1 criterio.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Familias 2.0")
        Else

            'dia nacimiento
            DiaNac = ""
            If diaNacV.Text <> "" Then
                DiaNac = " and Day(M.BirthDate)=" + diaNacV.Text + " "
            End If

            'mes nacimiento
            MesNac = ""
            If MesCombo.SelectedValue.ToString <> "" Then
                MesNac = " and Month(M.BirthDate)=" + MesCombo.SelectedValue.ToString + " "
            End If

            'año nacimiento
            AñoNac = ""
            If añoNacV.Text <> "" Then
                AñoNac = " and Year(M.BirthDate)=" + añoNacV.Text + " "
            End If

            Sql = selectSQL + DiaNac + MesNac + AñoNac + " ORDER BY M.BirthDate, M.FirstNames, M.LastNames"
            bdGrid(Sql, ListGridMiembros2)
            ListGridMiembros2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        End If
    End Sub

    'para busqueda dinámica en el grid - por nombre
    Private Sub NombresV_TextChanged(sender As Object, e As EventArgs) Handles NombresV.TextChanged
        If NombresV.Text = "" Then 'Or ApellidosV.Text = "" Then
        Else
            ListadoPorNombre(NombresV.Text, ApellidosV.Text)
            ListadoPorFecha(NombresV.Text, ApellidosV.Text)
        End If
    End Sub

    'para busqueda dinámica en el grid - por apellido
    Private Sub ApellidosV_TextChanged(sender As Object, e As EventArgs) Handles ApellidosV.TextChanged
        If ApellidosV.Text = "" Then 'Or ApellidosV.Text = "" Then
        Else
            ListadoPorNombre(NombresV.Text, ApellidosV.Text)
            ListadoPorFecha(NombresV.Text, ApellidosV.Text)
        End If
    End Sub

    Private Sub busqueda()
        ListadoPorNombre(NombresV.Text, ApellidosV.Text)
        ListadoPorFecha(NombresV.Text, ApellidosV.Text)
        ListGridMiembros.Visible = True
        ListGridMiembros2.Visible = True
    End Sub

    Private Sub buscarButton_Click(sender As Object, e As EventArgs) Handles buscarButton.Click
        busqueda()
    End Sub

    Private Sub llenarMesesCombo()
        Dim dt As New DataTable
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim a() As String = {"", ""}

        dt.Rows.Add(a)
        a = {"1", "Enero"}
        dt.Rows.Add(a)
        a = {"2", "Febrero"}
        dt.Rows.Add(a)
        a = {"3", "Marzo"}
        dt.Rows.Add(a)
        a = {"4", "Abril"}
        dt.Rows.Add(a)
        a = {"5", "Mayo"}
        dt.Rows.Add(a)
        a = {"6", "Junio"}
        dt.Rows.Add(a)
        a = {"7", "Julio"}
        dt.Rows.Add(a)
        a = {"8", "Agosto"}
        dt.Rows.Add(a)
        a = {"9", "Septiembre"}
        dt.Rows.Add(a)
        a = {"10", "Octubre"}
        dt.Rows.Add(a)
        a = {"11", "Noviembre"}
        dt.Rows.Add(a)
        a = {"12", "Diciembre"}
        dt.Rows.Add(a)

        With MesCombo
            .DataSource = dt
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub



End Class