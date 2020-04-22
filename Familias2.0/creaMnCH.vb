Public Class creaMnCH
    Dim mnuCH As New MenuStrip

    Dim cn As New cnSvr
    Dim sql, area As String
    Dim adm, admArea, admSitio, report As Boolean
    Dim mnuOpcion As ToolStripMenuItem
    Dim subOpcion As ToolStripMenuItem
    Dim folder As New ToolStripMenuItem
    Dim separador As ToolStripSeparator
    Dim codigo, nFuncion As String
    Dim formsAbiertas As Integer

    Dim programas As New ArrayList
    Dim roles As New ArrayList
    Dim funciones As New ArrayList

    Private Sub accesos()
        permisos()

        Dim dsAreas As New DataSet
        Dim aDrFilas As DataRow()
        Dim areasNV As String = "('UNIV', '****', 'FARM', 'LABO', 'DENT', 'SA', 'APJO', 'APAD', 'PSIC')"
        If adm = True Then
            sql = "SELECT Code, " + descripcion() + " Area FROM dbo.FwCdFunctionalArea WHERE Code NOT IN " + areasNV + " ORDER BY " + descripcion() + "  "
        Else
            sql = "SELECT Code, Area FROM dbo.fn_GEN_AreasAccess('" + globales.S + "', '" + globales.U + "', '" + globales.L + "')  WHERE CODE NOT IN " + areasNV + " GROUP BY Code, Area ORDER BY Code, Area  "
        End If

        'InputBox("", "", sql)
        cn.llenarDataSet(sql, dsAreas)
        aDrFilas = dsAreas.Tables(0).Select()

        Dim INDI As New ToolStripMenuItem
        INDI.Text = " "

        mnuCH.BackColor = Color.Transparent
        mnuCH.Font = New Font("Arial", 10, FontStyle.Regular)
        mnuCH.ForeColor = Color.DeepSkyBlue
        mnuCH.Items.Add(INDI)

        ' recorrer las filas e ir creando la estructura de menú
        For Each drFila As DataRow In aDrFilas
            mnuOpcion = New ToolStripMenuItem(drFila("Area").ToString())
            mnuOpcion.Tag = drFila("Code").ToString()
            mnuOpcion.Image = My.Resources.HeartSmall
            Dim area = drFila("Code").ToString()
            INDI.DropDownItems.Add(mnuOpcion)
            AddHandler mnuOpcion.Click, AddressOf xMnuItem_Clicked

            If area = "AFIL" Then
                If S = "E" Or S = "A" Then
                Else
                    opcionesAfiliaciones()
                End If
            ElseIf area = "AMBF" Then
                If S = "E" Or S = "A" Then
                Else
                    opcionesAmbienteFam()
                End If
                'ElseIf area = "APAD" Then
                '    If S = "E" Or S = "A" Then
                '    Else
                '        opcionesApadrinamiento()
                '    End If

            ElseIf area = "PROE" Or area = "APJO" Or area = "PSIC" Then '  Or
                If S = "E" Or S = "A" Then
                Else
                    opcionesProgramasEduc()
                End If
                'ElseIf area = "PSIC" Then
                '    If S = "E" Or S = "A" Then
                '    Else
                '        opcionesApoyoEducativo()
                '    End If
                'ElseIf area = "APJO" Then
                '    If S = "E" Or S = "A" Then
                '    Else
                '        opcionesApoyoJovenes()
                '    End If
            ElseIf area = "EDUC" Then
                If S = "E" Or S = "A" Then
                Else
                    opcionesBecas()
                End If
            ElseIf area = "CONT" Then
                opcionesCaja()
            ElseIf area = "ENE" Then
                If S = "N" Then
                    opcionesEscuela()
                End If
            ElseIf area = "MISC" Then
                opcionesMiscelaneas()
            ElseIf area = "CLIN" Then
                'Or area = "LABO" Or area = "FARM" Or funciones.Contains("IRGS") Then
                opcionesSalud()
            ElseIf area = "STPA" Then
                If S = "E" Or S = "A" Then
                Else
                    opcionesSanPablo()
                End If
            ElseIf area = "TS" Then
                If S = "E" Or S = "A" Then
                Else
                    opcionesTS()
                End If
            End If
        Next

        separador = New ToolStripSeparator
        INDI.DropDownItems.Add(separador)

        ''Salir de Familias 2.0
        Dim EXI As New ToolStripMenuItem
        EXI.Text = "CERRAR FAMILIAS 2.0"
        If L = "en" Then
            EXI.Text = "CLOSE FAMILIAS 2.0"
        End If

        EXI.Tag = "CERR"
        EXI.Image = My.Resources.HeartSmall
        INDI.DropDownItems.Add(EXI)
        AddHandler EXI.Click, AddressOf xMnuItem_Clicked

        separador = New ToolStripSeparator
        INDI.DropDownItems.Add(separador)

        ''Versión de Familias 2.0
        Dim VER As New ToolStripMenuItem
        VER.Text = My.Resources.versionFamilias2
        VER.Image = My.Resources.Menu
        INDI.DropDownItems.Add(VER)
    End Sub

    Private Sub CrearSubOpciones(ByVal area As String)
        Dim sbAreas As New DataSet
        Dim mnuSubOpcion As ToolStripMenuItem
        Dim sbFilas As DataRow()

        If esAdmin(S, U) = True Then
            sql = "SELECT Code Codigo, DescSpanish Funcion FROM dbo.FwCdTransaction " + _
                     "WHERE Inactive = 0 AND Code NOT IN ('****')  AND FunctionalArea = '" + area + "' " + _
                     "ORDER BY Grouping, OutlookBarOrder "
        Else
            sql = "SELECT Codigo, Funcion FROM dbo.fn_GEN_TransAccess('" + S + "', '" + U + "') WHERE Area = '" + area + "' GROUP BY Codigo, Funcion"
        End If
        MsgBox(sql)
        cn.llenarDataSet(sql, sbAreas)
        sbFilas = sbAreas.Tables(0).Select()

        For Each sFila As DataRow In sbFilas
            mnuSubOpcion = New ToolStripMenuItem(sFila("Funcion").ToString())
            mnuSubOpcion.Tag = sFila("Codigo").ToString()
            mnuOpcion.DropDownItems.Add(mnuSubOpcion)
            AddHandler mnuSubOpcion.Click, AddressOf xMnuItem_Clicked
        Next
    End Sub

    Private Sub esAdminArea(ByVal codigoArea As String)
        If adm = True Or admSitio = True Then
            admArea = True
        Else
            If funciones.Contains("**** " + codigoArea) Then
                admArea = True
            Else
                admArea = False
            End If
        End If
    End Sub

    Private Sub opcionesAfiliaciones()
        esAdminArea("AFIL")

        codigo = "AF"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Nueva Familia")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "MM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Miembros de Familia")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ASAM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Solicitud Afiliación")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If


        codigo = "MCVT"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Vivienda")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub

    Private Sub opcionesAmbienteFam()
        esAdminArea("AMBF")

        If admArea = True Or funciones.Contains("IAPF") = True Or funciones.Contains("RAPV") = True Then
            folder = New ToolStripMenuItem("Fase I - Análisis Preliminar")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "RAPV"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Listado de Familias - Análisis Preliminar")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "IAPF"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ingresar Análisis Preliminar")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        If admArea = True Or funciones.Contains("IPF") = True Or funciones.Contains("MPF") = True Then
            folder = New ToolStripMenuItem("Fase II - Solicitudes")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "CDHR"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Listado de Solicitudes")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "IPF"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ingresar Nueva Solicitud")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "MPF"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Actualizar Solicitud")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        If admArea = True Or funciones.Contains("IHRS") = True Then
            folder = New ToolStripMenuItem("Fase III - Control de Hrs.")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "RFTH"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Familias trabajando Hrs.")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "IHRS"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ingresar Horas")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

    End Sub


    Private Sub opcionesApadrinamiento()
        esAdminArea("APAD")


        codigo = "RIAM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Resumen Apadrinamiento")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ECMP"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Envío de Cartas de Apadrinados")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If


        'If admArea = True Or funciones.Contains("ACPM") = True Then
        '    folder = New ToolStripMenuItem("Cartas de Padrinos")
        '    mnuOpcion.DropDownItems.Add(folder)


        'End If

    End Sub

    Private Sub opcionesApoyoEducativo()
        'Dim subfolder As New ToolStripMenuItem
        folder = New ToolStripMenuItem("APOYO EDUCATIVO")
        mnuOpcion.DropDownItems.Add(folder)

        esAdminArea("PSIC")
        codigo = "NCIP"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Resumen Apoyo Educativo")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "CIP"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Informes de Citas")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RSAE"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Listado de Referencias Médicas")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or funciones.Contains("RAAE") Or funciones.Contains("PETL") Then
            separador = New ToolStripSeparator
            folder.DropDownItems.Add(separador)

            codigo = "RAAE"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Actividades Individuales")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "PETL"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("PETL")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If
    End Sub



    Private Sub opcionesApoyoJovenes()
        Dim subfolder As New ToolStripMenuItem
        folder = New ToolStripMenuItem("APOYO JOVENES")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "COAS"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Registro de Asistencia")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
        'mnuOpcion
        codigo = "ASIN"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Resumen Apoyo a Jóvenes")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or funciones.Contains("UPAC") = True Or funciones.Contains("ASEX") = True Then
            subfolder = New ToolStripMenuItem("Carga de Asistencia")
            folder.DropDownItems.Add(subfolder)

            codigo = "UPAC"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("RECOLECTOR")
                subOpcion.Tag = codigo
                subfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "ASEX"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("EXCEL")
                subOpcion.Tag = codigo
                subfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        If admArea = True Or funciones.Contains("CONA") = True Or funciones.Contains("REAS") = True Or funciones.Contains("RAGJ") = True Or funciones.Contains("DUOA") = True Then
            subfolder = New ToolStripMenuItem("Reportes")
            folder.DropDownItems.Add(subfolder)

            codigo = "CONA"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Anual de Asistencias")
                subOpcion.Tag = codigo
                subfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "REAS"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("General de Asistencias")
                subOpcion.Tag = codigo
                subfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "RAGJ"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Listado Apadrinados con Asistencia")
                subOpcion.Tag = codigo
                subfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "DUOA"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Asistencias duplicadas")
                subOpcion.Tag = codigo
                subfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If


    End Sub

    Private Sub opcionesBecas()
        esAdminArea("EDUC")
        codigo = "RIAE"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Resumen Becas")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "IREM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Autorizar Factura")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        'codigo = "CALI"
        'If admArea = True Or funciones.Contains(codigo) = True Then
        '    subOpcion = New ToolStripMenuItem("Registro Calificaciones")
        '    subOpcion.Tag = codigo
        '    mnuOpcion.DropDownItems.Add(subOpcion)
        '    AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        'End If

        codigo = "RHEM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Historial Educativo")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "CALI"
        If admArea = True Or funciones.Contains(codigo) = True Or roles.Contains("ADED") Then
            subOpcion = New ToolStripMenuItem("Calificaciones")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or funciones.Contains("APLA") = True Or funciones.Contains("RREM") = True Or funciones.Contains("PAPE") = True Or funciones.Contains("BRCP") = True Then
            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)

            folder = New ToolStripMenuItem("Pagos")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "APLA"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ingresar pagos con Planilla")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "RREM"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Historial de Pagos")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "PAPE"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Reembolsos Pendientes de Pago")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "BRCP"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Borrar Reembolsos de Guate ACH")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)
        End If

        If admArea = True Or funciones.Contains("IAEM") = True Or funciones.Contains("IMAM") = True Or funciones.Contains("EDAD") = True Or funciones.Contains("RAPA") = True Then
            folder = New ToolStripMenuItem("Actividades")
            mnuOpcion.DropDownItems.Add(folder)

            'codigo = "IAEM"
            'If admArea = True Or funciones.Contains(codigo) = True Then
            '    subOpcion = New ToolStripMenuItem("Registro Actividades Individuales")
            '    subOpcion.Tag = codigo
            '    folder.DropDownItems.Add(subOpcion)
            '    AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            'End If

            codigo = "IMAM"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Registro de Actividades")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "RAEM"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Historial Actividades")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "CAAA"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Carga Actividades - EXCEL")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "EDAD"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Actividades duplicadas")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "RAPA"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Reporte Anual Actividades")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "RGAE"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Reporte General Actividades")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)
        End If


        If admArea = True Or funciones.Contains("IIAE") = True Or funciones.Contains("AIUT") = True Or funciones.Contains("AEEG") = True Then
            folder = New ToolStripMenuItem("Actualizaciones")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "IIAE"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Nuevo Año Escolar")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "AEEG"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Actualizar Estado Por Grupo")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "AIUT"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Actualizar Info. Feria Utiles")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "NAEG"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Nuevo Año Escolar Por Grupo")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)
        End If


        If admArea = True Or funciones.Contains("VALI") = True Or funciones.Contains("ENLI") = True Then
            folder = New ToolStripMenuItem("Libros")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "VALI"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Vale Libros")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "ENLI"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Entrega Libros")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If


    End Sub

    Private Sub opcionesCaja()
        esAdminArea("CONT")
        codigo = "CRM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Reembolsos por Familia")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "PAFA"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Donación por servicios médicos")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "PPED"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Pago Planillas Becas")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        separador = New ToolStripSeparator
        mnuOpcion.DropDownItems.Add(separador)

        codigo = "PAPG"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Reembolsos Pendientes")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "CFP"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Cobros de Farmacia Pendientes")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "IR"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Reporte de Reembolsos")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
        separador = New ToolStripSeparator
        mnuOpcion.DropDownItems.Add(separador)

        codigo = "ACCH"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Actualizar No. Cuenta Familia")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub

    Private Sub opcionesCDI()
        folder = New ToolStripMenuItem("CDI")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "COAS"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Registro de Asistencia")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub

    Private Sub opcionesClinica()
        folder = New ToolStripMenuItem("CLINICA")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "NCMS"
        If admArea = True Or funciones.Contains(codigo) = True Or roles.Contains("MEDI") Then
            subOpcion = New ToolStripMenuItem("Agenda por Médico")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RCOM"
        If admArea = True Or funciones.Contains(codigo) = True Or roles.Contains("MEDI") Then
            subOpcion = New ToolStripMenuItem("Historial Consulta Médica")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RHMM"
        If admArea = True Or funciones.Contains(codigo) = True Or roles.Contains("MEDI") Then
            subOpcion = New ToolStripMenuItem("Historial Medicamentos")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "IRCM"

        If admArea = True Or funciones.Contains(codigo) = True Or roles.Contains("MEDI") Then
            If S = "E" Or S = "A" Then
            Else
                subOpcion = New ToolStripMenuItem("Autorizar Factura")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        codigo = "ARE"
        If admArea = True Or funciones.Contains(codigo) = True Or roles.Contains("MEDI") Then
            subOpcion = New ToolStripMenuItem("Autorizar Receta Externa")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "CAME"
        If admArea = True Or funciones.Contains(codigo) = True Or roles.Contains("MEDI") Then
            subOpcion = New ToolStripMenuItem("Cambiar Médico")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

    End Sub

    Private Sub opcionesEnfermeria()
        folder = New ToolStripMenuItem("ENFERMERIA")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "AENF"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Agenda Enfermería")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ITRE"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Ingresar Tratamiento Sin Referencia Médica")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If roles.Contains("EMM") Or admArea = True Then
            codigo = "AIM"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ajustar Existencias")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "IISM"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Informes Formulario MM")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        codigo = "ESEN"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Estadísticas Enfermería")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub

    Private Sub opcionesFarmacia()
        folder = New ToolStripMenuItem("FARMACIA")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "PRPE"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Recetas Pendientes")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ERE"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Receta Externa")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ICD"
        If admArea = True Or funciones.Contains(codigo) = True Or funciones.Contains("IISF") = True Then
            Dim sbfolder As New ToolStripMenuItem
            sbfolder = New ToolStripMenuItem("Formulario")
            folder.DropDownItems.Add(sbfolder)

            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ingresar Compras y Donaciones")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "AIF"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ajustar Existencias")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "CFVE"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Control de Fechas de Vencimiento")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "UPMP"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Actualizar Precios de medicamentos")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "UPRO"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Proveedores")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "IISF"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Informes de Formulario")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        codigo = "RHMF"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Historial de Medicina")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "MEEM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            If (S = "E" Or S = "A") Then
                subOpcion = New ToolStripMenuItem("Medicina Sin Receta Médica")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        codigo = "MECR"
        If (admArea = True Or funciones.Contains(codigo) = True) And S = "E" Then
            subOpcion = New ToolStripMenuItem("Medicina de Consulta de Empleado Al Crédito")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ICID"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Informe de Consultas Diarias")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ESFA"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Estadisticas de Farmacia")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub

    Private Sub opcionesGerenciaSalud()
        folder = New ToolStripMenuItem("GERENCIA SALUD")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "ESSA"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Estadística Salud")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "ECM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Exonerar Medicina")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub

    Private Sub opcionesLaboratorio()
        folder = New ToolStripMenuItem("LABORATORIO")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "ALAB"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Agenda Laboratorio")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RELA"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Reportes de laboratorios")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub

    Private Sub opcionesEscuela()
        esAdminArea("ENE")

        ''PRIMARIA
        If admArea = True Or roles.Contains("MPRE") = True Or roles.Contains("MENE") = True Then
            'folder = New ToolStripMenuItem("PRE PRIMARIA")
            'mnuOpcion.DropDownItems.Add(folder)

            codigo = "CAPP"
            subOpcion = New ToolStripMenuItem("Notas Pre-Primaria")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked

            codigo = "RNPP"
            subOpcion = New ToolStripMenuItem("Reportes Notas Pre-Primaria")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or roles.Contains("MPRI") = True Then
            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)

            codigo = "CALE"
            subOpcion = New ToolStripMenuItem("Notas Primaria")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked

            codigo = "RNPR"
            subOpcion = New ToolStripMenuItem("Reportes Notas Primaria")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or roles.Contains("MPRI") = True Or roles.Contains("MPRE") = True Then

            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)

            codigo = "ASIS"
            subOpcion = New ToolStripMenuItem("Asistencia")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked

            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)

            codigo = "AMSE"
            subOpcion = New ToolStripMenuItem("Ambiente Seguro")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked

            separador = New ToolStripSeparator
            mnuOpcion.DropDownItems.Add(separador)

            folder = New ToolStripMenuItem("ADMINISTRATIVOS")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "ASEM"
            subOpcion = New ToolStripMenuItem("Actualizar Semáforos")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked

            'codigo = "CAAS"
            'subOpcion = New ToolStripMenuItem("Calendario Asistencias")
            'subOpcion.Tag = codigo
            'folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked


        End If
    End Sub

    Private Sub opcionesMiscelaneas()
        esAdminArea("MISC")

        codigo = "MPP"
        Dim n As String
        If L = "en" Then
            n = "Change Preferences"
        Else
            n = "Cambiar Preferencias"
        End If
        subOpcion = New ToolStripMenuItem(n)
        subOpcion.Tag = codigo
        mnuOpcion.DropDownItems.Add(subOpcion)
        AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked

        separador = New ToolStripSeparator
        mnuOpcion.DropDownItems.Add(separador)

        codigo = "VEM"
        subOpcion = New ToolStripMenuItem("Verificar Existencia Miembro")
        subOpcion.Tag = codigo
        mnuOpcion.DropDownItems.Add(subOpcion)
        AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked

    End Sub

    Private Sub opcionesProgramasEduc()
        esAdminArea("PROE")

        If S = "E" Or S = "A" Then
        Else
            If roles.Contains("GJOV") = True Or admArea = True Or funciones.Contains("COAS") Or funciones.Contains("ASIN") Then
                opcionesApoyoJovenes()
                'opcionesCDI()
            End If

            If roles.Contains("APED") = True Or admArea = True Then
                opcionesApoyoEducativo()
            End If



        End If


    End Sub


    Private Sub opcionesRecepcion()
        folder = New ToolStripMenuItem("RECEPCION")
        mnuOpcion.DropDownItems.Add(folder)

        codigo = "NCM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Pre-Consulta")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "CICM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Agenda Médica")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "LRRE"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Impresión Referencias")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "IRCR"
        If admArea = True Or funciones.Contains(codigo) = True Then
            If S = "E" Or S = "A" Then
            Else
                subOpcion = New ToolStripMenuItem("Autorizar Factura")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        separador = New ToolStripSeparator
        folder.DropDownItems.Add(separador)

        codigo = "NELA"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Nueva Cita al Laboratorio (Referencia Externa)")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "AGLA"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Agenda del Laboratorio")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        separador = New ToolStripSeparator
        folder.DropDownItems.Add(separador)

        codigo = "IACM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Nueva Actividad Médica")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RCIM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Historial Pre-Consultas")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RRCM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            If S = "E" Or S = "A" Then
            Else
                subOpcion = New ToolStripMenuItem("Historial Reembolsos Miembro")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        codigo = "ANEM"
        If (admArea = True Or funciones.Contains(codigo) = True) And S = "E" Then
            separador = New ToolStripSeparator
            folder.DropDownItems.Add(separador)

            subOpcion = New ToolStripMenuItem("Nuevo Empleado")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "AFEM"
        If (admArea = True Or funciones.Contains(codigo) = True) And S = "E" Then
            subOpcion = New ToolStripMenuItem("Nuevo Familiar de Empleado")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "NPAE"
        If (admArea = True Or funciones.Contains(codigo) = True) And S = "A" Then
            separador = New ToolStripSeparator
            folder.DropDownItems.Add(separador)

            subOpcion = New ToolStripMenuItem("Nuevo Paciente - Unica Consulta")
            subOpcion.Tag = codigo
            folder.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If


    End Sub

    Private Sub opcionesSalud()
        'If S = "F" Or S = "S" Or S = "E" Or S = "A" Then
        esAdminArea("CLIN")
        If roles.Contains("DS") = True Then
            admArea = True
        End If
        'Or roles.Contains("AFAC") = True
        If roles.Contains("REC") = True Or roles.Contains("LENT") = True Or admArea = True Then
            opcionesRecepcion()
        End If

        If roles.Contains("MEDI") Or admArea = True Then
            opcionesClinica()
        End If

        If roles.Contains("ENFE") Or admArea = True Then
            opcionesEnfermeria()
        End If

        If roles.Contains("FARM") Or programas.Contains("FARM") Or admArea = True Then
            opcionesFarmacia()
        End If

        If roles.Contains("LABO") = True Or admArea = True Then
            opcionesLaboratorio()
        End If

        If admArea = True Then
            opcionesGerenciaSalud()
        End If

        'Else 'N y sucursales
        codigo = "IRGS"
        If funciones.Contains("IRGS") Or adm = True Then
            subOpcion = New ToolStripMenuItem("Autorizar Reembolso Salud")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "IAMS"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Nueva Actividad Médica")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or funciones.Contains(codigo) = True Then
            Dim sbfolder As New ToolStripMenuItem
            sbfolder = New ToolStripMenuItem("Reportes")
            mnuOpcion.DropDownItems.Add(sbfolder)

            codigo = "RAAM"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Reporte Anual Actividades")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "RGAM"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Reporte General Actividades")
                subOpcion.Tag = codigo
                sbfolder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
            'End If

        End If

    End Sub

    Private Sub opcionesSanPablo()
        esAdminArea("STPA")

        codigo = "ACPM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Add Sponsor Letters")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "NPAD"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("New Sponsor")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "FPAD"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("End Sponsorship")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "MSPI"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Update Sponsor Information")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If
    End Sub


    Private Sub opcionesTS()
        esAdminArea("TS")
        codigo = "RITS"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Resumen de Información")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or funciones.Contains("RFV") = True Or funciones.Contains("AFVI") = True Then
            folder = New ToolStripMenuItem("Visitas")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "AFVI"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Ingresar Visita Familiar")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "RFV"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Historial Visitas")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If

        codigo = "ASEM"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Revisar Semáforo Educativo")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "CSER"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Lista Semáforos Educativos")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RVS"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Listado de Familias con Semáforos y Visitas")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RSTS"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Listado de Referencias Médicas")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "COCF"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Condiciones para Clasificar Familia")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "MCVT"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Condiciones de Vivienda")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        codigo = "RPFT"
        If admArea = True Or funciones.Contains(codigo) = True Then
            subOpcion = New ToolStripMenuItem("Posesiones Familiares")
            subOpcion.Tag = codigo
            mnuOpcion.DropDownItems.Add(subOpcion)
            AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
        End If

        If admArea = True Or funciones.Contains("AAGS") = True Or funciones.Contains("AACF") = True Then
            folder = New ToolStripMenuItem("Actualizaciones Generales")
            mnuOpcion.DropDownItems.Add(folder)

            codigo = "AAGS"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Cambio a Semáforos Verdes (Inicio Año)")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If

            codigo = "AACF"
            If admArea = True Or funciones.Contains(codigo) = True Then
                subOpcion = New ToolStripMenuItem("Cambio de Clasificaciones Familiares (Inicio Año)")
                subOpcion.Tag = codigo
                folder.DropDownItems.Add(subOpcion)
                AddHandler subOpcion.Click, AddressOf xMnuItem_Clicked
            End If
        End If
    End Sub

    Private Sub permisos()
        Dim a As DataTable
        'Roles
        a = New DataTable
        sql = "SELECT Role FROM dbo.FwEmployeeRole WHERE EmployeeId = '" + globales.U + "' AND Status = 'ACTV' AND Organization = '" + globales.S + "'"
        cn.llenarDataTable(sql, a)
        For i = 0 To a.Rows.Count - 1
            roles.Add(a.Rows(i)(0))
        Next
        a.Clear()

        'programas
        a = New DataTable
        sql = "SELECT Programa FROM dbo.fn_GEN_ProgramsAccess('" + globales.S + "', '" + globales.U + "') "
        cn.llenarDataTable(sql, a)
        For i = 0 To a.Rows.Count - 1
            programas.Add(a.Rows(i)(0))
        Next
        a.Clear()

        'programas
        a = New DataTable
        sql = "SELECT Trans FROM dbo.fn_GEN_TransAccess('" + globales.S + "', '" + globales.U + "') "
        cn.llenarDataTable(sql, a)
        For i = 0 To a.Rows.Count - 1
            funciones.Add(a.Rows(i)(0))
        Next
        a.Clear()

        If roles.Contains("DIPO") Then
            admSitio = True
        Else
            admSitio = False
        End If

        If roles.Contains("ACRE") Then
            report = True
        Else
            report = False
        End If
    End Sub

    Public Sub preferenciasUsuario(ByVal usuario As String)
        Dim GenInfo As New DataTable
        sql = "SELECT L.DefaultOrganization S, L.PreferredLanguage L, CASE WHEN L.PreferredLanguage = 'en' THEN O.DescEnglish ELSE O.DescSpanish END  sN " + _
                 "FROM FwEmployee L INNER JOIN FwCdOrganization O ON O.Code = L.DefaultOrganization WHERE EmployeeId = '" + usuario + "' "
        cn.llenarDataTable(sql, GenInfo)
        globales.U = usuario
        globales.L = chequearValor(GenInfo.Rows(0)("L"))
        globales.S = chequearValor(GenInfo.Rows(0)("S"))
        globales.sName = chequearValor(GenInfo.Rows(0)("sN"))
        adm = esAdmin(globales.S, globales.U)
        accesos()
        globales.mnuCH = mnuCH
    End Sub

    Public Sub preferenciasUsuario1(ByVal usuario As String, ByRef Lenguaje As String, ByRef Sitio As String, ByRef nSitio As String, ByRef menu As MenuStrip)
        Dim GenInfo As New DataTable
        sql = "SELECT L.DefaultOrganization S, L.PreferredLanguage L, CASE WHEN L.PreferredLanguage = 'en' THEN O.DescEnglish ELSE O.DescSpanish END  sN " + _
                 "FROM FwEmployee L INNER JOIN FwCdOrganization O ON O.Code = L.DefaultOrganization WHERE EmployeeId = '" + usuario + "' "
        cn.llenarDataTable(sql, GenInfo)
        S = chequearValor(GenInfo.Rows(0)("S"))
        L = chequearValor(GenInfo.Rows(0)("L"))
        sName = chequearValor(GenInfo.Rows(0)("sN"))

        U = usuario
        Lenguaje = L
        Sitio = S
        nSitio = sName
        adm = esAdmin(S, usuario)
        accesos()
        menu = mnuCH
    End Sub

    Private Sub ventanasExtrasAbiertas(ByVal utilizada As String)
        Dim formTitles As New Collection
        formsAbiertas = My.Application.OpenForms.Count

        If formsAbiertas > 1 Then
            Try
                For Each f As Form In My.Application.OpenForms
                    If Not f.InvokeRequired Then
                        If f.Name <> "utilizada" Then
                            f.Close()
                        End If
                    End If
                Next
            Catch ex As Exception
                formTitles.Add("Error: " & ex.Message)
            End Try
        End If
    End Sub

    '/* Opciones de menú */
    Private Sub xMnuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Select Case item.Tag.ToString
            Case "CERR"
                Application.Exit()

                '/*Afiliaciones*/
            Case "AF"
                yNuevaFamilia()
            Case "ASAM"
                ySolicitudAFiliacion()
            Case "MM"
                yMiembrosFamilia()
            Case "MCVT"
                yViviendaFamilia()

                '/*Ambiente Fam*/
            Case "IAPF"
                yAnalisisPreliminar()
            Case "RAPV"
                yListadoAnalisisPreliminar()
            Case "IPF"
                yNuevaSolicitud()
            Case "MPF"
                yActualizarSolicitud()
            Case "IHRS"
                yIngresarHoras()
            Case "CDHR"
                ySolicitudesVivienda()
            Case "RFTH"
                yFamiliasTrabajandoHrs()

                '/*Apadrinamiento*/
            Case "RIAM"
                yResumenApad()
            Case "ECMP"
                yEnvioCartasApadrinados()

                '/*Apoyo Educativo*/
            Case "RAAE"
                yActividadesAE()
            Case "CIP"
                yInformeCitasAE()
            Case "NCIP"
                yResumenAE()
            Case "PETL"
                yPETL()
            Case "RSAE"
                yReferenciasMedicasAE()

                '/*Apoyo a Jóvenes*/
            Case "ASEX"
                yAsistenciaExcel()
            Case "DUOA"
                yAsistenciasDuplicadasAJ()
            Case "RAGJ"
                yAsistenciaApadrinados()
            Case "UPAC"
                yAsistenciaRecolector()
            Case "COAS"
                '    yRegistroAsistencia()
                'Case "ACDI"
                yRegistroCDIs()
            Case "CONA"
                yReporteAnualAsistencias()
            Case "ASIN"
                yResumenAJ()
            Case "REAS"
                yReporteGeneralAsistencia()

                '/*Becas*/
            Case "CALI"
                yCalificaciones()
            Case "RIAE"
                yResumenBecas()
            Case "IREM"
                yAutorizarReembolsoEduc()
            Case "APLA"
                yPlanilla()
            Case "RREM"
                yReembolsosEduc()
            Case "PAPE"
                yReembolsosPendientes()
            Case "BRCP"
                yBorrarReembolsoConPago()
            Case "AIUT"
                yFeriaUtilesFamiliar()
            Case "EDAD"
                yActividadesDuplicadasEduc()
            Case "RHEM"
                yHistorialEducativo()
            Case "VALI"
                yValeLibros()
            Case "ENLI"
                yEntregaLibros()
            Case "IIAE"
                yNuevoAñoEscolar()
            Case "RAEM"
                yActividadesEduc()
                'Case "IAEM"
                '    yRegistroActividadesIndividuales()
            Case "AEEG"
                yActualizarEstadoPorGrupo()
            Case "IMAM"
                yRegistroActividadesEduc()
            Case "CAAA"
                yActividadesEducExcel()
            Case "RAPA"
                yReporteAnualActividadesEduc()
            Case "RGAE"
                yReporteGeneralActividadesEducativas()
            Case "NAEG"
                yNuevoAñoEscolarPorGrupo()


                '/*Caja*/
            Case "CRM"
                yReembolsosPorFamilia()
            Case "PAFA"
                yCobrosFarmacia()
            Case "PAPG"
                yPagosPendientes()
            Case "PPED"
                yPagoPlanillas()
            Case "CFP"
                yCobrosFarmaciaPendientes()
            Case "IR"
                yReporteReembolsos()
            Case "ACCH"
                yActualizarCuentaFamilia()


                '/*ESCUELA*/
            Case "ASEM"
                yActualizarSemaforos()
            Case "ASIS"
                yAsistenciaENE()
            Case "CAAS"
                yCalendarioENE()
            Case "CAPP"
                yCalificacionesENEpre()
            Case "CALE"
                yCalificacionesENEpri()
            Case "RNPP"
                yNotasPorGradoPREPA()
            Case "RNPR"
                yNotasPorGradoPRIM()
            Case "RAS"
                yReportesAmbienteSeguro()

                '/*MISCELANEOS*/
            Case "MPP"
                yCambiarSitio()

            Case "VEM"
                yVerificarExistenciaMiembro()
            Case "AMSE"
                yAmbienteSeguro1()

                '/*SALUD*/
                '/*Generales*/
            Case "IRGS"
                yAutorizarReembolsosGenSalud()
            Case "IAMS"
                yRegistroActividadesGenSalud()
            Case "RAAM"
                yReporteAnualActividadesSalud()
            Case "RGAM"
                yReporteGeneralActividadesSalud()

                '/*Recepción*/
            Case "NCM"
                yPreconsulta()
            Case "CICM"
                yAgendaMedica()
            Case "NELA"
                yCitaLaboratorio()
            Case "AGLA"
                yAgendaLaboratorio()
            Case "LRRE"
                yImprimirRefExternas()
            Case "IRCR"
                yAutorizarReembolsosRece()
            Case "RRCM"
                yReembolsosSalud()
            Case "ANEM"
                yNuevoEmpleado()
            Case "AFEM"
                yNuevoFamiliarEmpleado()
            Case "NPAE"
                yNuevoApoyoSalud()
            Case "IACM"
                yActividadesSalud()
            Case "LRRE"
                yImprimirRefExternas()
            Case "RCIM"
                yRevisarPreconsultas()

                '/*Clinica*/
            Case "NCMS"
                yAgendaMedico()
            Case "RCOM"
                yHistorialConsultasMedicas()
            Case "RHMM"
                yHistorialMedicamentosClin()
            Case "IRCM"
                yAutorizarReembolsoClin()
            Case "ARE"
                yRecetaExternaClin()
            Case "CAME"
                yCambiarMedico()

                '/*Enfermería*/
            Case "AENF"
                yAgendaEnfermeria()
            Case "ITRE"
                yIngresarTratamientoEnf()
            Case "AIM"
                yAjustarExistenciasMM()
            Case "IISM"
                yInformesFormularioMM1()
            Case "ESEN"
                yEstadisticasEnfermeria()

                '/*Farmacia*/
            Case "PRPE"
                yRecetasPendientes()
            Case "ERE"
                yRecetasExternasFarm()
            Case "ICD"
                yIngresosMeds()
            Case "AIF"
                yAjustarExistencias()
            Case "CFVE"
                yControlFechasVencimiento()
            Case "UPMP"
                yActualizarPreciosMeds()
            Case "UPRO"
                yProveedores()
            Case "IISF"
                yInformesFarmacia1()
            Case "RHMF"
                yHistorialMedicinasMiembroFarm()
            Case "MEEM"
                yMedicinaEmpleados()
            Case "MECR"
                yMedicinaConsultaAlCredito()
            Case "ICID"
                yReporteConsultasDiarias()
            Case "ESFA"
                yEstadisticasFarmacia()

                '/*Laboratorio*/
            Case "ALAB"
                yAgendaLab()
            Case "RELA"
                yReportesLab()

                '/*Gerencia Salud*/
            Case "ESSA"
                yEstadisticasSalud()
            Case "ECM"
                yExonerarMedicina()

                '/*SAN PABLO*/
            Case "ACPM"
                yCartaPadrino()
            Case "NPAD"
                yAgregarPadrino()
            Case "FPAD"
                yFinalizarApadrinamiento()
            Case "MSPI"
                yActualizarDatosPadrinos()

                '/*TS*/
            Case "RITS"
                yResumenTS()
            Case "AFVI"
                yVisitaFamiliar()
            Case "RFV"
                yHistorialVisitas()
            Case "RVS"
                yFamiliasConVisitas()
            Case "RSTS"
                yReferenciasSalud()
            Case "AAGS"
                yActualizarSemaforoGeneral()
            Case "COCF"
                yCondicionesClasificacionFamiliar()
            Case "AACF"
                yActualizarClasificacionGeneral()
            Case "ASEM"
                yIngresarSemaforo()
            Case "CSER"
                yListadoSemaforos()
            Case "RPFT"
                yPosesiones()
            Case "MCVT"
                'yMantenerViviendas()
            Case Else
                ' MsgBox("You've clicked " & item.Name)
        End Select
    End Sub



    Private Sub yActualizarSolicitud()
        Dim nxt As New ActualizarSolicitud
        nxt.Show()
        ventanasExtrasAbiertas("ActualizarSolicitud")
    End Sub

    Private Sub yAnalisisPreliminar()
        Dim nxt As New PreAnalisisVivienda
        nxt.Show()
        ventanasExtrasAbiertas("PreAnalisisVivienda")
    End Sub

    Private Sub yActividadesAE()
        Dim nxt As New ActividadesAE
        nxt.Show()
        ventanasExtrasAbiertas("ActividadesAE")
    End Sub

    Private Sub yActividadesDuplicadasEduc()
        Dim nxt As New ActividadesDuplicadasEduc
        nxt.Show()
        ventanasExtrasAbiertas("ActividadesDuplicadasEduc")
    End Sub

    Private Sub yActividadesEduc()
        Dim nxt As New ActividadesEduc
        nxt.Show()
        ventanasExtrasAbiertas("ActividadesEduc")
    End Sub

    Private Sub yActividadesEducExcel()
        Dim nxt As New ActividadesEducExcel
        nxt.Show()
        ventanasExtrasAbiertas("ActividadesEducExcel")
    End Sub

    Private Sub yActividadesSalud()
        Dim nxt As New ActividadesSalud
        nxt.Show()
        ventanasExtrasAbiertas("ActividadesSalud")
    End Sub

    Private Sub yActualizarClasificacionGeneral()
        Dim nxt As New ActualizarClasificacionGeneral
        nxt.Show()
        ventanasExtrasAbiertas("ActualizarClasificacionGeneral")
    End Sub

    Private Sub yActualizarCuentaFamilia()
        Dim nxt As New RegistroCuentasACHFamilias
        nxt.Show()
        ventanasExtrasAbiertas("RegistroCuentasACHFamilias")
    End Sub

    Private Sub yActualizarDatosPadrinos()
        Dim nxt As New ActualizarDatosPadrinos
        nxt.Show()
        ventanasExtrasAbiertas("ActualizarDatosPadrinos")
    End Sub

    Private Sub yActualizarEstadoPorGrupo()
        Dim nxt As New ActualizaEstadoPorGrupo
        nxt.Show()
        ventanasExtrasAbiertas("ActualizaEstadoPorGrupo")
    End Sub

    Private Sub yActualizarPreciosMeds()
        Dim nxt As New ActualizarPreciosMeds
        nxt.Show()
        ventanasExtrasAbiertas("ActualizarPreciosMeds")
    End Sub

    Private Sub yActualizarSemaforos()
        Dim nxt As New ActualizarSemaforoENE
        nxt.Show()
        ventanasExtrasAbiertas("ActualizarSemaforoENE")
    End Sub

    Private Sub yActualizarSemaforoGeneral()
        Dim nxt As New ActualizarSemaforoGeneral
        nxt.Show()
        ventanasExtrasAbiertas("ActualizarSemaforoGeneral")
    End Sub

    Private Sub yAgendaEnfermeria()
        Dim nxt As New AgendaEnfermeria
        nxt.Show()
        ventanasExtrasAbiertas("AgendaEnfermeria")
    End Sub

    Private Sub yAgendaLab()
        Dim nxt As New AgendaLab
        nxt.Show()
        ventanasExtrasAbiertas("AgendaLab")
    End Sub

    Private Sub yAgendaLaboratorio()
        Dim nxt As New AgendaLaboratorio
        nxt.Show()
        ventanasExtrasAbiertas("AgendaLaboratorio")
    End Sub

    Private Sub yAgendaMedica()
        Dim nxt As New AgendaMedica
        nxt.Show()
        ventanasExtrasAbiertas("AgendaMedica")
    End Sub

    Private Sub yAgendaMedico()
        Dim nxt As New AgendaMedico
        nxt.Show()
        ventanasExtrasAbiertas("AgendaMedico")
    End Sub

    Private Sub yAgregarPadrino()
        Dim nxt As New AgregarPadrino
        nxt.Show()
        ventanasExtrasAbiertas("AgregarPadrino")
    End Sub

    Private Sub yAjustarExistencias()
        Dim nxt As New AjustarExistencias
        nxt.Show()
        ventanasExtrasAbiertas("AjustarExistencias")
    End Sub

    Private Sub yAjustarExistenciasMM()
        Dim nxt As New AjustarExistenciasMM
        nxt.Show()
        ventanasExtrasAbiertas("AjustarExistenciasMM")
    End Sub


    Private Sub yAmbienteSeguro1()
        Dim nxt As New AmbienteSeguro1
        nxt.Show()
        ventanasExtrasAbiertas("AmbienteSeguro1")
    End Sub

    Private Sub yAsistenciaApadrinados()
        Dim nxt As New AsistenciaApadrinadosAJ
        nxt.Show()
        ventanasExtrasAbiertas("AsistenciaApadrinadosAJ")
    End Sub

    Private Sub yAsistenciaENE()
        Dim nxt As New AsistenciaENE
        nxt.Show()
        ventanasExtrasAbiertas("AsistenciaENE")
    End Sub

    Private Sub yAsistenciaExcel()
        Dim nxt As New AsistenciaExcel
        nxt.Show()
        ventanasExtrasAbiertas("AsistenciaExcel")
    End Sub

    Private Sub yAsistenciaRecolector()
        Dim nxt As New Recolector
        nxt.Show()
        ventanasExtrasAbiertas("Recolector")
    End Sub

    Private Sub yAsistenciasDuplicadasAJ()
        Dim nxt As New AsistenciasAJduplicadas
        nxt.Show()
        ventanasExtrasAbiertas("AsistenciasAJduplicadas")
    End Sub

    Private Sub yAutorizarReembolsoClin()
        Dim nxt As New AutorizarReembolsoClin
        nxt.Show()
        ventanasExtrasAbiertas("AutorizarReembolsoClin")
    End Sub

    Private Sub yAutorizarReembolsoEduc()
        Dim nxt As New AutorizarReembolsoEduc
        nxt.Show()
        ventanasExtrasAbiertas("AutorizarReembolsoEduc")
    End Sub

    Private Sub yAutorizarReembolsosGenSalud()
        Dim nxt As New AutorizarReembolsosGenSalud
        nxt.Show()
        ventanasExtrasAbiertas("AutorizarReembolsosGenSalud")
    End Sub

    Private Sub yAutorizarReembolsosRece()
        Dim nxt As New AutorizarReembolsosRece
        nxt.Show()
        ventanasExtrasAbiertas("AutorizarReembolsosRece")
    End Sub

    Private Sub yBorrarReembolsoConPago()
        Dim nxt As New BorrarReembolsoConPago
        nxt.Show()
        ventanasExtrasAbiertas("BorrarReembolsoConPago")
    End Sub

    Private Sub yCalificaciones()
        Dim nxt As New RegistroCalificaciones
        nxt.Show()
        ventanasExtrasAbiertas("RegistroCalificaciones")
    End Sub

    Private Sub yCalendarioENE()
        Dim nxt As New CalendarioENE
        nxt.Show()
        ventanasExtrasAbiertas("CalendarioENE")
    End Sub

    Private Sub yCalificacionesENEpre()
        Dim nxt As New CalificacionesPREPA
        nxt.Show()
        ventanasExtrasAbiertas("NotasPREPA")
    End Sub

    Private Sub yCalificacionesENEpri()
        Dim nxt As New CalificacionesPRIM
        nxt.Show()
        ventanasExtrasAbiertas("CalificacionesEscuela")
    End Sub

    Private Sub yCambiarMedico()
        Dim nxt As New CambiarMedico
        nxt.Show()
        ventanasExtrasAbiertas("CambiarMedico")
    End Sub

    Private Sub yCambiarSitio()
        Dim nxt As New CambiarPreferencias
        nxt.Show()
        ventanasExtrasAbiertas("CambiarSitio")
    End Sub

    Private Sub yCartaPadrino()
        Dim nxt As New CartaPadrino
        nxt.Show()
        ventanasExtrasAbiertas("CartaPadrino")
    End Sub

    Private Sub yCitaLaboratorio()
        Dim nxt As New CitaLaboratorio
        nxt.Show()
        ventanasExtrasAbiertas("CitaLaboratorio")
    End Sub

    Private Sub yCobrosFarmacia()
        Dim nxt As New CobrosFarmacia
        nxt.Show()
        ventanasExtrasAbiertas("CobrosFarmacia")
    End Sub

    Private Sub yCobrosFarmaciaPendientes()
        Dim nxt As New CobrosFarmaciaPendientes
        nxt.Show()
        ventanasExtrasAbiertas("CobrosFarmaciaPendientes")
    End Sub

    Private Sub yCondicionesClasificacionFamiliar()
        Dim nxt As New CondicionesClasificacionFamiliar
        nxt.Show()
        ventanasExtrasAbiertas("CondicionesClasificacionFamiliar")
    End Sub

    Private Sub yControlFechasVencimiento()
        Dim nxt As New ControlFechasVencimiento
        nxt.Show()
        ventanasExtrasAbiertas("ControlFechasVencimiento")
    End Sub

    Private Sub yEntregaLibros()
        Dim nxt As New EntregaLibros
        nxt.Show()
        ventanasExtrasAbiertas("EntregaLibros")
    End Sub

    Private Sub yEnvioCartasApadrinados()
        Dim nxt As New EnvioCartasApadrinados
        nxt.Show()
        ventanasExtrasAbiertas("EnvioCartasApadrinados")
    End Sub

    Private Sub yEstadisticasEnfermeria()
        Dim nxt As New EstadisticasEnfermeria
        nxt.Show()
        ventanasExtrasAbiertas("EstadisticasEnfermeria")
    End Sub

    Private Sub yEstadisticasFarmacia()
        Dim nxt As New EstadisticasFarmacia
        nxt.Show()
        ventanasExtrasAbiertas("EstadisticasFarmacia")
    End Sub

    Private Sub yEstadisticasSalud()
        Dim nxt As New EstadisticasSalud
        nxt.Show()
        ventanasExtrasAbiertas("EstadisticasSalud")
    End Sub

    Private Sub yExonerarMedicina()
        Dim nxt As New ExonerarMedicina
        nxt.Show()
        ventanasExtrasAbiertas("ExonerarMedicina")
    End Sub

    Private Sub yFamiliasConVisitas()
        Dim nxt As New FamiliasConVisitas
        nxt.Show()
        ventanasExtrasAbiertas("FamiliasConVisitas")
    End Sub


    Private Sub yFamiliasTrabajandoHrs()
        Dim nxt As New FamiliasTrabajandoHrs
        nxt.Show()
        ventanasExtrasAbiertas("FamiliasTrabajandoHrs")
    End Sub

    Private Sub yFeriaUtilesFamiliar()
        Dim nxt As New FeriaUtilesFamiliar
        nxt.Show()
        ventanasExtrasAbiertas("FeriaUtilesFamiliar")
    End Sub


    Private Sub yFinalizarApadrinamiento()
        Dim nxt As New FinalizarApadrinamiento
        nxt.Show()
        ventanasExtrasAbiertas("FinalizarApadrinamiento")
    End Sub

    Private Sub yHistorialEducativo()
        Dim nxt As New HistorialEducativo
        nxt.Show()
        ventanasExtrasAbiertas("HistorialEducativo")
    End Sub

    Private Sub yHistorialConsultasMedicas()
        Dim nxt As New HistorialConsultasMedicas
        nxt.Show()
        ventanasExtrasAbiertas("HistorialConsultasMedicas")
    End Sub

    Private Sub yHistorialMedicamentosClin()
        Dim nxt As New HistorialMedicamentosClin
        nxt.Show()
        ventanasExtrasAbiertas("HistorialMedicamentosClin")
    End Sub

    Private Sub yHistorialMedicinasMiembroFarm()
        Dim nxt As New HistorialMedicinasMiembroFarm
        nxt.Show()
        ventanasExtrasAbiertas("HistorialMedicinasMiembroFarm")
    End Sub

    Private Sub yHistorialVisitas()
        Dim nxt As New HistorialVisitas
        nxt.Show()
        ventanasExtrasAbiertas("HistorialVisitas")
    End Sub

    Private Sub yImprimirRefExternas()
        Dim nxt As New ImprimirRefExternas
        nxt.Show()
        ventanasExtrasAbiertas("ImprimirRefExternas")
    End Sub

    Private Sub yInformeCitasAE()
        Dim nxt As New InformeCitasAE
        nxt.Show()
        ventanasExtrasAbiertas("InformeCitasAE")
    End Sub

    Private Sub yInformesFarmacia1()
        Dim nxt As New InformesFarmacia1
        nxt.Show()
        ventanasExtrasAbiertas("InformesFarmacia1")
    End Sub

    Private Sub yInformesFormularioMM1()
        Dim nxt As New InformesFormularioMM1
        nxt.Show()
        ventanasExtrasAbiertas("InformesFormularioMM1")
    End Sub

    Private Sub yIngresarHoras()
        Dim nxt As New IngresarHoras
        nxt.Show()
        ventanasExtrasAbiertas("IngresarHoras")
    End Sub

    Private Sub yIngresarTratamientoEnf()
        Dim nxt As New IngresarTratamientoEnf
        nxt.Show()
        ventanasExtrasAbiertas("IngresarTratamientoEnf")
    End Sub

    Private Sub yIngresarSemaforo()
        Dim nxt As New IngresarSemaforo
        nxt.Show()
        ventanasExtrasAbiertas("IngresarSemaforo")
    End Sub

    Private Sub yIngresosMeds()
        Dim nxt As New IngresosMeds
        nxt.Show()
        ventanasExtrasAbiertas("IngresosMeds")
    End Sub

    Private Sub yListadoAnalisisPreliminar()
        Dim nxt As New ListadoGeneralFamiliasAP
        nxt.Show()
        ventanasExtrasAbiertas("ListadoGeneralFamiliasAP")
    End Sub

    Private Sub yListadoSemaforos()
        Dim nxt As New ListadoSemaforos
        nxt.Show()
        ventanasExtrasAbiertas("ListadoSemaforos")
    End Sub

    Private Sub yMantenerViviendas()
        Dim nxt As New MantenerViviendas
        nxt.Show()
        ventanasExtrasAbiertas("MantenerViviendas")
    End Sub

    Private Sub yMedicinaConsultaAlCredito()
        Dim nxt As New MedicinaConsultaAlCredito
        nxt.Show()
        ventanasExtrasAbiertas("MedicinaConsultaAlCredito")
    End Sub

    Private Sub yMedicinaEmpleados()
        Dim nxt As New MedicinaEmpleados
        nxt.Show()
        ventanasExtrasAbiertas("MedicinaEmpleados")
    End Sub

    Private Sub yMiembrosFamilia()
        Dim nxt As New MiembrosNFam
        nxt.Show()
        ventanasExtrasAbiertas("MiembrosNFam")
    End Sub

    Private Sub yNotasPorGradoPREPA()
        Dim nxt As New ReportesPREPA
        nxt.Show()
        ventanasExtrasAbiertas("NotasPorGradoPREPA")

    End Sub
    Private Sub yNotasPorGradoPRIM()
        Dim nxt As New ReportesPRIM
        nxt.Show()
        ventanasExtrasAbiertas("NotasPorGradoPRIM")
    End Sub

    Private Sub yNuevaFamilia()
        Dim nxt As New NuevaFamilia
        nxt.Show()
        ventanasExtrasAbiertas("NuevaFamilia")
    End Sub

    Private Sub yNuevaSolicitud()
        Dim nxt As New NuevaSolicitud
        nxt.Show()
        ventanasExtrasAbiertas("NuevaSolicitud")
    End Sub

    Private Sub yNuevoAñoEscolar()
        Dim nxt As New NuevoAñoEscolar
        nxt.Show()
        ventanasExtrasAbiertas("NuevoAñoEscolar")
    End Sub

    Private Sub yNuevoAñoEscolarPorGrupo()
        Dim nxt As New NuevoAñoEscolarPorGrupo
        nxt.Show()
        ventanasExtrasAbiertas("NuevoAñoEscolarPorGrupo")
    End Sub

    Private Sub yNuevoApoyoSalud()
        Dim nxt As New NuevoApoyoSalud
        nxt.Show()
        ventanasExtrasAbiertas("NuevoApoyoSalud")
    End Sub

    Private Sub yNuevoEmpleado()
        Dim nxt As New NuevoEmpleado
        nxt.Show()
        ventanasExtrasAbiertas("NuevoEmpleado")
    End Sub

    Private Sub yNuevoFamiliarEmpleado()
        Dim nxt As New NuevoFamiliarEmpleado
        nxt.Show()
        ventanasExtrasAbiertas("NuevoFamiliarEmpleado")
    End Sub

    Private Sub yPagoPlanillas()
        Dim nxt As New PagoPlanillas
        nxt.Show()
        ventanasExtrasAbiertas("PagoPlanillas")
    End Sub

    Private Sub yPagosPendientes()
        Dim nxt As New PagosPendientes
        nxt.Show()
        ventanasExtrasAbiertas("PagosPendientes")
    End Sub

    Private Sub yPETL()
        Dim nxt As New PETL
        nxt.Show()
        ventanasExtrasAbiertas("PETL")
    End Sub

    Private Sub yPlanilla()
        Dim nxt As New Planilla
        nxt.Show()
        ventanasExtrasAbiertas("Planilla")
    End Sub

    Private Sub yPosesiones()
        Dim nxt As New Posesiones
        nxt.Show()
        ventanasExtrasAbiertas("Posesiones")
    End Sub

    Private Sub yPreconsulta()
        Dim nxt As New Preconsulta
        nxt.Show()
        ventanasExtrasAbiertas("Preconsulta")
    End Sub

    Private Sub yProveedores()
        Dim nxt As New Proveedores
        nxt.Show()
        ventanasExtrasAbiertas("Proveedores")
    End Sub

    Private Sub yRecetaExternaClin()
        Dim nxt As New RecetaExternaClin
        nxt.Show()
        ventanasExtrasAbiertas("RecetaExternaClin")
    End Sub

    Private Sub yRecetasExternasFarm()
        Dim nxt As New RecetasExternasFarm
        nxt.Show()
        ventanasExtrasAbiertas("RecetasExternasFarm")
    End Sub

    Private Sub yRecetasPendientes()
        Dim nxt As New RecetasPendientes
        nxt.Show()
        ventanasExtrasAbiertas("RecetasPendientes")
    End Sub

    Private Sub yReembolsosEduc()
        Dim nxt As New ReembolsosEduc
        nxt.Show()
        ventanasExtrasAbiertas("ReembolsosEduc")
    End Sub

    Private Sub yReembolsosPendientes()
        Dim nxt As New ReembolsosPendientes
        nxt.Show()
        ventanasExtrasAbiertas("ReembolsosPendientes")
    End Sub

    Private Sub yReembolsosPorFamilia()
        Dim nxt As New ReembolsosPorFamilia
        nxt.Show()
        ventanasExtrasAbiertas("ReembolsosPorFamilia")
    End Sub

    Private Sub yReembolsosSalud()
        Dim nxt As New ReembolsosSalud
        nxt.Show()
        ventanasExtrasAbiertas("ReembolsosSalud")
    End Sub

    Private Sub yReferenciasMedicasAE()
        Dim nxt As New ReferenciasMedicasAE
        nxt.Show()
        ventanasExtrasAbiertas("ReferenciasMedicasAE")
    End Sub

    Private Sub yReferenciasSalud()
        Dim nxt As New ReferenciasSalud
        nxt.Show()
        ventanasExtrasAbiertas("ReferenciasSalud")
    End Sub

    'Private Sub yRegistroActividadesIndividuales()
    '    Dim nxt As New RegistroActividadesIndividuales
    '    nxt.Show()
    '    ventanasExtrasAbiertas("RegistroActividadesIndividuales")
    'End Sub

    Private Sub yRegistroActividadesGenSalud()
        Dim nxt As New RegistroActividadesGenSalud
        nxt.Show()
        ventanasExtrasAbiertas("RegistroActividadesGenSalud")
    End Sub

    Private Sub yReporteAnualActividadesSalud()
        Dim nxt As New ReporteAnualActividadesSalud
        nxt.Show()
        ventanasExtrasAbiertas("ReporteAnualActividadesSalud")
    End Sub

    Private Sub yReporteGeneralActividadesSalud()
        Dim nxt As New ReporteGeneralActividadesEduc
        nxt.Show()
        ventanasExtrasAbiertas("ReporteGeneralActividadesSalud")
    End Sub

    Private Sub yRegistroActividadesEduc()
        Dim nxt As New RegistroActividadesEduc
        nxt.Show()
        ventanasExtrasAbiertas("RegistroActividadesEduc")
    End Sub

    Private Sub yReportesAmbienteSeguro()
        Dim nxt As New ReportesAmbienteSeg
        nxt.Show()
        ventanasExtrasAbiertas("ReportesAmbienteSeg")
    End Sub

    Private Sub yRegistroAsistencia()
        Dim nxt As New RegistroCDIs
        nxt.Show()
        ventanasExtrasAbiertas("RegistroCDIs")
    End Sub

    Private Sub yRegistroCDIs()
        Dim nxt As New RegistroCDIs
        nxt.Show()
        ventanasExtrasAbiertas("RegistroCDIs")
    End Sub

    Private Sub yReporteAnualActividadesEduc()
        Dim nxt As New ReporteAnualActividadesEduc
        nxt.Show()
        ventanasExtrasAbiertas("ReporteAnualActividadesEduc")
    End Sub

    Private Sub yReporteAnualAsistencias()
        Dim nxt As New ReporteAnualAsistencias
        nxt.Show()
        ventanasExtrasAbiertas("ReporteAnualAsistencias")
    End Sub

    Private Sub yReporteConsultasDiarias()
        Dim nxt As New ReporteConsultasDiarias
        nxt.Show()
        ventanasExtrasAbiertas("ReporteConsultasDiarias")
    End Sub

    Private Sub yReporteGeneralActividadesEducativas()
        Dim nxt As New ReporteGeneralActividadesEducativas
        nxt.Show()
        ventanasExtrasAbiertas("ReporteGeneralActividadesEducativas")
    End Sub

    Private Sub yReporteGeneralAsistencia()
        Dim nxt As New ReporteGeneralAsistencia
        nxt.Show()
        ventanasExtrasAbiertas("ReporteGeneralAsistencia")
    End Sub

    Private Sub yReporteReembolsos()
        Dim nxt As New ReporteReembolsos
        nxt.Show()
        ventanasExtrasAbiertas("ReporteReembolsos")
    End Sub

    Private Sub yReportesLab()
        Dim nxt As New ReportesLab
        nxt.Show()
        ventanasExtrasAbiertas("ReportesLab")
    End Sub

    Private Sub yResumenAE()
        Dim nxt As New ResumenAE
        nxt.Show()
        ventanasExtrasAbiertas("ResumenAE")
    End Sub

    Private Sub yResumenAJ()
        Dim nxt As New ResumenAJ
        nxt.Show()
        ventanasExtrasAbiertas("ResumenAJ")
    End Sub

    Private Sub yResumenApad()
        Dim nxt As New ResumenApad
        nxt.Show()
        ventanasExtrasAbiertas("ResumenApad")
    End Sub

    Private Sub yResumenBecas()
        Dim nxt As New ResumenBecas
        nxt.Show()
        ventanasExtrasAbiertas("ResumenBecas")
    End Sub

    Private Sub yResumenTS()
        Dim nxt As New ResumenTS
        nxt.Show()
        ventanasExtrasAbiertas("ResumenTS")
    End Sub

    Private Sub yRevisarPreconsultas()
        Dim nxt As New RevisarPreconsultas
        nxt.Show()
        ventanasExtrasAbiertas("RevisarPreconsultas")
    End Sub

    Private Sub ySolicitudAFiliacion()
        Dim nxt As New SolAfiliacion
        nxt.Show()
        ventanasExtrasAbiertas("SolAfiliacion")
    End Sub

    Private Sub ySolicitudesVivienda()
        Dim nxt As New SolicitudesVivienda
        nxt.Show()
        ventanasExtrasAbiertas("SolicitudesVivienda")
    End Sub

    Private Sub yValeLibros()
        Dim nxt As New ValeLibros
        nxt.Show()
        ventanasExtrasAbiertas("ValeLibros")
    End Sub

    Private Sub yVerificarExistenciaMiembro()
        Dim nxt As New VerificarExistenciaMiembro
        nxt.Show()
        ventanasExtrasAbiertas("VerificarExistenciaMiembro")
    End Sub

    Private Sub yVisitaFamiliar()
        Dim nxt As New VisitaFamiliar
        nxt.Show()
        ventanasExtrasAbiertas("VisitaFamiliar")
    End Sub

    Private Sub yViviendaFamilia()
        Dim nxt As New ViviendaNFam
        nxt.Show()
        ventanasExtrasAbiertas("ViviendaNFam")
    End Sub
End Class
