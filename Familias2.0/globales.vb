Imports System.Math
Imports System.Text

Module globales
    Public en As New CultureInfo("en-US")
    Public sql As String
    Public U As String
    Public L As String
    Public S As String
    Public NoMiembro, NoFamilia As String
    Public sName As String
    Public mnuCH As New MenuStrip
    Dim cn As New cnSvr

    'agregarle formato a una columna de acción
    Sub agregarColumnaAccion(ByVal columna As Integer, ByRef grid As DataGridView)
        grid.Columns(columna).DefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Underline)
        grid.Columns(columna).DefaultCellStyle.ForeColor = Color.Blue
        grid.Columns(columna).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Sub bdCombo(ByVal sql As String, ByRef combo As ComboBox, ByVal codigo As String, ByVal descripcion As String)
        cn.llenarCombo(sql, combo, codigo, descripcion)
    End Sub

    Sub bdComboSinBlancos(ByVal sql As String, ByRef combo As ComboBox, ByVal codigo As String, ByVal descripcion As String)
        cn.llenarComboSinBlancos(sql, combo, codigo, descripcion)
    End Sub
    'llenar un combo box con Info. de la BD
    Sub bdComboSinCodigo(ByVal sql As String, ByRef combo As ComboBox)
        cn.llenarComboSinCodigo(combo, sql, True)
    End Sub

    'llena un DataTable con Info. de la BD
    Sub bdDataTable(ByVal sql As String, ByRef dt As DataTable)
        cn.llenarDataTable(sql, dt)
    End Sub

    'devuelve un doble con Info. de la BD
    Function bdDoble(ByVal sql As String, ByVal colNombre As String) As Double
        bdDoble = cn.obtieneDoble(sql, colNombre)
    End Function

    'ejecutar sql a la BD
    Sub bdEjecutarSQL(ByVal sql As String)
        cn.ejecutarSQL(sql)
    End Sub

    'devuelve un entero con Info. de la BD
    Function bdEntero(ByVal sql As String, ByVal colNombre As String)
        bdEntero = cn.obtieneEntero(sql, colNombre)
    End Function

    'llena un grid con info. de la BD
    Sub bdGrid(ByVal sql As String, ByRef grid As DataGridView)
        cn.llenarGrid(sql, grid)
    End Sub

    ''Ejecutar Insert a la BD
    Sub bdInsertar(ByVal sql As String)
        cn.ejecutarInsert(sql)
    End Sub

    'devuelve una palabra con Info. de la base de datos
    Function bdPalabra(ByVal sql As String, ByVal colNombre As String)
        bdPalabra = cn.obtienePalabra(sql, colNombre)
    End Function

    Function cadenaParaCodigo(ByVal Nombre As String) As String
        Dim Posicion = 1
        Dim returnValue As New StringBuilder
        Dim Letra = Mid(Nombre, Posicion, 1)
        For i = 0 To Len(Nombre) - 1
            If Asc(Letra) >= 65 And Asc(Letra) <= 90 Then
                returnValue.Append(Letra)
            End If
            Posicion = Posicion + 1
            Letra = Mid(Nombre, Posicion, 1)
        Next

        cadenaParaCodigo = returnValue.ToString
    End Function

    'Calcular Indice de Masa Corporal (IMC)
    Function calcularIMC(ByVal pesoOr As String, ByVal tallaOr As String)
        Dim peso, talla, pesoEnKg, altura2, IMC As Double
        Dim clasificacion As String = ""
        pesoEnKg = 0
        IMC = 0
        altura2 = 0

        If Len(pesoOr) > 0 And Len(tallaOr) > 0 Then
            If (IsNumeric(pesoOr)) = True And (IsNumeric(tallaOr)) = True Then
                peso = Double.Parse(pesoOr)
                talla = Double.Parse(tallaOr)

                If peso > 0 Or talla > 0 Then
                    If Double.Parse(talla) > 3 Then
                        altura2 = (talla / 100) * (talla / 100) 'raiz cuadrada talla
                    Else
                        altura2 = talla * talla 'raiz cuadrada talla
                    End If

                    pesoEnKg = peso / 2.2 '046226  'convierte peso libras a kgs.
                    IMC = Round(pesoEnKg / altura2, 2) 'calcula IMC con 2 digitos
                End If
            End If
        End If

        If IMC <= 0 Then
            clasificacion = " (Sin calcular)"
        ElseIf IMC < 18.5 Then
            clasificacion = " (Bajo peso)"
        ElseIf IMC >= 18.5 And IMC <= 24.99 Then
            clasificacion = " (Normal)"
        ElseIf IMC >= 25 And IMC < 30.0 Then
            clasificacion = " (Sobrepeso)"
        Else
            clasificacion = " (Obesidad)"
        End If

        calcularIMC = "IMC: " + IMC.ToString + clasificacion
    End Function

    'verifica si es nulo devuelve ""
    Function chequearValor(ByVal value) As String
        Dim temp As String

        If IsDBNull(value) Then
            temp = ""
        Else
            temp = value
        End If
        chequearValor = temp
    End Function

    'devuelve la clasificación familiar
    Function clasificacionFamiliar(ByVal sitio As String, ByVal familia As String) As String
        If sitio = "A" Or sitio = "E" Then
            clasificacionFamiliar = ""
        Else
            sql = "SELECT CASE WHEN Classification IS NULL THEN '' ELSE Classification END Clas FROM dbo.Family " + _
                  "WHERE RecordStatus = ' ' AND Project = '" + sitio + "' AND FamilyId = " + familia + " "
            clasificacionFamiliar = chequearValor(cn.obtienePalabra(sql, "Clas"))
        End If
    End Function

    'para campos textbox que permita ingresar apostrofe
    Function conversionValorTextBox(ByVal valor As String) As String
        conversionValorTextBox = Replace(Replace(valor, "'", "''"), Chr(10), vbNewLine)
    End Function

    'verifica si tiene derechos en Salud
    Function derechosSalud(ByVal site As String, _
                                     ByVal memberId As Integer, _
                                     ByVal familyId As Integer)
        derechosSalud = False

        'empleados, apadrinados, miembros activos de familias afiliadas, apoyo especial en salud
        If site = "E" Or _
           esApadrinado(site, memberId) = True Or _
           esApoyoSalud(site, memberId) = True Then
            derechosSalud = True
        ElseIf miembroActivo(site, memberId, familyId) = True Then
            If esGraduado(site, memberId) = True Or esDesafiliado(site, memberId) = True Then
                derechosSalud = False
            Else
                derechosSalud = True
            End If
        End If

    End Function

    'muestra descripcion segun lenguaje
    Function descripcion() As String
        If L = "en" Then
            descripcion = "DescEnglish"
        Else
            descripcion = "DescSpanish"
        End If
    End Function

    'devuelve la edad como entero
    Function edadInt(ByVal miembro As String)
        sql = "SELECT DATEDIFF(d, BirthDate, GETDATE()) /365 Edad FROM dbo.Member WHERE RecordStatus = ' '  AND Project = '" + S + "' AND MemberId =  " + miembro
        edadInt = bdEntero(sql, "Edad")
    End Function

    'identifica si el usuario es administrador BD
    Function esAdmin(ByVal sitio As String, ByVal usuario As String) As Boolean
        sql = "SELECT COUNT(*) T FROM dbo.FwEmployeeRole WHERE EmployeeId = '" + usuario + "' AND Status = 'ACTV' AND Role = 'SUPE' AND Organization = '" + sitio + "'"
        If cn.obtieneEntero(sql, "T") = 0 Then
            esAdmin = False
        Else
            esAdmin = True
        End If
    End Function

    'es apadrinado
    Function esApadrinado(ByVal site As String, _
                         ByVal memberId As Integer) As Boolean
        esApadrinado = False
        sql = "SELECT COUNT(*) AS Total FROM dbo.Member M " + _
                              "WHERE RecordStatus = ' ' AND Project = '" + site + _
                            "' AND Memberid = " + memberId.ToString + " AND AffiliationStatus = 'AFIL'"
        If cn.obtieneEntero(sql, "Total") > 0 Then
            esApadrinado = True
        End If
    End Function

    'es afiliado
    Function esAfiliado(ByVal site As String, _
                         ByVal memberId As Integer) As Boolean
        sql = "SELECT dbo.fn_GEN_esAfiliado('" + site + "', " + memberId.ToString + ") Afil "
        If cn.obtieneEntero(sql, "Afil") = 1 Then
            esAfiliado = True
        Else
            esAfiliado = False
        End If
    End Function

    'es apoyo salud
    Function esApoyoSalud(ByVal site As String, _
                          ByVal memberId As Integer) As Boolean
        sql = "SELECT dbo.fn_GEN_esApoyoEspecialSalud('" + site + "', " + memberId.ToString + ", GETDATE()) Total "
        Dim N As Integer = cn.obtieneEntero(sql, "Total")

        If N = 1 Then
            esApoyoSalud = True
        Else
            esApoyoSalud = False
        End If
    End Function

    'es Desafiliado
    Function esDesafiliado(ByVal site As String, _
                         ByVal memberId As Integer) As Boolean
        esDesafiliado = False
        sql = "SELECT COUNT(*) AS Total FROM dbo.Member M " + _
                              "WHERE RecordStatus = ' ' AND Project = '" + site + _
                            "' AND Memberid = " + memberId.ToString + " AND AffiliationStatus = 'DESA'"
        If cn.obtieneEntero(sql, "Total") > 0 Then
            esDesafiliado = True
        End If
    End Function

    'es Graduado
    Function esGraduado(ByVal site As String, _
                         ByVal memberId As Integer) As Boolean
        esGraduado = False
        sql = "SELECT COUNT(*) AS Total FROM dbo.Member M " + _
                              "WHERE RecordStatus = ' ' AND Project = '" + site + _
                            "' AND Memberid = " + memberId.ToString + " AND AffiliationStatus = 'GRAD'"
        If cn.obtieneEntero(sql, "Total") > 0 Then
            esGraduado = True
        End If
    End Function

    'identifica si el usuario es médico
    Function esMedico(ByVal usuario As String) As Boolean
        sql = "SELECT COUNT(*) AS Total FROM dbo.FwEmployeeRole " + _
              "WHERE Status = 'ACTV' AND Role = 'MEDI' AND EmployeeId = '" + usuario + "'"
        If cn.obtieneEntero(sql, "Total") = 0 Then
            esMedico = False
        Else
            esMedico = True
        End If
    End Function

    'es Proyeccion Social
    Function esProyeccionSocial(ByVal site As String, _
                          ByVal memberId As Integer) As Boolean
        sql = "SELECT dbo.fn_GEN_esProyeccionSocial('" + site + "', " + memberId.ToString + ", GETDATE()) Total "
        Dim N As Integer = cn.obtieneEntero(sql, "Total")

        If N = 1 Then
            esProyeccionSocial = True
        Else
            esProyeccionSocial = False
        End If
    End Function

    'Verificar si la familia es válida
    Function familiaEsAfiliada(ByVal site As String, _
                                      ByVal familyNumber As Integer)
        Dim conn As New cnSvr
        sql = "SELECT COUNT(*) AS Total FROM dbo.Family F " + _
                            "WHERE RecordStatus = ' ' AND Project = '" + site + _
                            "' AND FamilyId = " + familyNumber.ToString + " AND AffiliationStatus = 'AFIL' "
        If cn.obtieneEntero(sql, "Total") > 0 Then
            familiaEsAfiliada = True
        Else
            familiaEsAfiliada = False
        End If

    End Function

    'verifica si la familia es desafiliada o graduada
    Function familiaEsDesafiliadaGraduada(ByVal site As String, _
                                  ByVal familyNumber As Integer)
        Dim conn As New cnSvr
        sql = "SELECT COUNT(*) AS Total FROM dbo.Family F " + _
                            "WHERE RecordStatus = ' ' AND Project = '" + site + _
                            "' AND FamilyId = " + familyNumber.ToString + " AND AffiliationStatus IN ('DESA', 'GRAD') "
        If cn.obtieneEntero(sql, "Total") > 0 Then
            familiaEsDesafiliadaGraduada = True
        Else
            familiaEsDesafiliadaGraduada = False
        End If

    End Function

    'Verificar si la familia es válida
    Function familiaEsValida(ByVal site As String, _
                                    ByVal familyNumber As Integer)
        Dim conn As New cnSvr
        sql = "SELECT COUNT(*) AS Total FROM dbo.Family F " + _
                            "WHERE RecordStatus = ' ' AND Project = '" + site + _
                            "' AND FamilyId = " + familyNumber.ToString + " "
        If cn.obtieneEntero(sql, "Total") > 0 Then
            familiaEsValida = True
        Else
            familiaEsValida = False
        End If

    End Function

    'Verificar si es fecha válida
    Public Function fechaValida_NoAnteriores(ByVal fechaIn As DateTime) As Boolean
        Dim nowDate As DateTime = DateTime.Now
        Dim nDays As Integer

        nDays = DateDiff(DateInterval.Day, Convert.ToDateTime(fechaIn.ToShortDateString), Convert.ToDateTime(nowDate.ToShortDateString))

        If nDays < 0 Then
            fechaValida_NoAnteriores = False
        Else
            fechaValida_NoAnteriores = True
        End If
    End Function

    'importar asistencia desde excel a un grid
    Function importarAsistenciaDesdeExcel(ByVal direccionDoc As String, ByRef grid As DataGridView) As Boolean
        Dim DS As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        Dim MyConnection As System.Data.OleDb.OleDbConnection

        MyConnection = New System.Data.OleDb.OleDbConnection( _
                        "Provider=Microsoft.ACE.OLEDB.12.0; " + _
                        "Data Source=" + direccionDoc + "; " + _
                         "Extended Properties=""Excel 12.0 Xml;HDR=YES""; ")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter( _
              "select * from [Asistencia$]", MyConnection)
        Try
            DS = New System.Data.DataSet()
            MyCommand.Fill(DS)
            grid.DataSource = DS.Tables(0)
            MyConnection.Close()

            importarAsistenciaDesdeExcel = True
        Catch ex As Exception
            MsgBox("Error con el documento de Excel" + vbNewLine + "Verifique la cantidad de columnas, orden y nombre de la hoja", vbInformation, My.Resources.versionFamilias2)
            MsgBox(ex.Message.ToString)
            importarAsistenciaDesdeExcel = False
        End Try
    End Function

    'identifica si la fecha/hora es AM o PM
    Function medi_AMorPM(ByVal fecha As DateTime) As String
        If fecha.Hour < 12 Then
            medi_AMorPM = "AM"
        Else
            medi_AMorPM = "PM"
        End If
    End Function

    'obtener el ultimo turno de clinica médica
    Function medi_ProximoTurno(ByVal estado As String, ByVal fecha As DateTime) As Integer
        Dim proxTurno As Integer
        If estado = "REFE" Or estado = "NOAS" Then
            proxTurno = 0
        Else
            sql = "SELECT CASE WHEN MAX(Turn) IS NULL THEN 0  ELSE MAX(Turn) END   AS Ultimo FROM  dbo.MemberClinicAppointment " + _
                  "WHERE RecordStatus = ' ' AND YEAR(AppointmentDateTime) = " + fecha.Year.ToString + " AND MONTH(AppointmentDateTime) = " + _
                  fecha.Month.ToString + " AND DAY(AppointmentDateTime) = " + fecha.Day.ToString + " " + _
                  " AND Status <> 'NOAS' "
            proxTurno = cn.obtienePalabra(sql, "Ultimo") + 1
        End If
        medi_ProximoTurno = proxTurno
    End Function

    'el miembro esta activo en una familia
    Function miembroActivo(ByVal site As String, _
                           ByVal memberId As Integer, _
                           ByVal familyId As Integer) As Boolean

        sql = "SELECT COUNT(*) AS Total FROM dbo.FamilyMemberRelation FMR INNER JOIN dbo.Family F ON F.RecordStatus = FMR.Recordstatus " + _
              "AND F.Project = FMR.Project AND F.FamilyId = FMR.FamilyId " + _
              "WHERE FMR.RecordStatus = ' ' AND FMR.Project = '" + site + "' AND FMR.MemberId = " + memberId.ToString + _
              " AND FMR.familyId = " + familyId.ToString + " AND FMR.InactiveDate IS NULL AND F.AffiliationStatus = 'AFIL'"
        If cn.obtieneEntero(sql, "Total") = 0 Then
            miembroActivo = False
        Else
            miembroActivo = True
        End If
    End Function

    'Verificar si el miembro es válido
    Function miembroEsValido(ByVal site As String, _
                                ByVal memberNumber As Integer) As Boolean
        Dim conn As New cnSvr
        sql = "SELECT COUNT(*) AS Total FROM dbo.Member F " + _
                            "WHERE RecordStatus = ' ' AND Project = '" + site + _
                            "' AND MemberId = " + memberNumber.ToString + " "
        If cn.obtieneEntero(sql, "Total") > 0 Then
            miembroEsValido = True
        Else
            miembroEsValido = False
        End If
    End Function

    'obtiene el número de mes
    Function numeroMes(ByVal monthN As Integer) As String
        If monthN < 10 Then
            numeroMes = "0" + monthN.ToString
        Else
            numeroMes = monthN.ToString
        End If
    End Function

    'Verifica si es padrino válido
    Function padrinoEsValido(ByVal sponsorId As Integer) As Boolean
        Dim conn As New cnSvr
        sql = "SELECT COUNT(*) AS Total FROM dbo.Sponsor  " + _
                            "WHERE RecordStatus = ' '  AND SponsorId = " + sponsorId.ToString + " "
        If cn.obtieneEntero(sql, "Total") > 0 Then
            padrinoEsValido = True
        Else
            padrinoEsValido = False
        End If
    End Function

    'obtiene el % para facturas en becas
    Function porcentajeReembolsosBecas(ByVal sitio As String, ByVal miembro As Integer) As Double
        sql = "SELECT dbo.fn_BECA_PorcentajeReembolsos('" + sitio + "', " + miembro.ToString + ") Porcentaje"
        Dim porcentaje As Double = Double.Parse(cn.obtieneEntero(sql, "Porcentaje"))
        porcentajeReembolsosBecas = porcentaje
    End Function

    'obtiene el % para facturas en salud
    Function porcentajeReembolsosSalud(ByVal sitio As String, ByVal miembro As Integer) As Double
        sql = "SELECT dbo.fn_SALU_PorcentajeReembolsos('" + sitio + "', " + miembro.ToString + ", GETDATE()) Porcentaje"
        Dim porcentaje As Double = Double.Parse(cn.obtieneEntero(sql, "Porcentaje"))
        porcentajeReembolsosSalud = porcentaje
    End Function

    'devuelve el % a cobrar en salud
    Function porcentajeSalud(ByVal sitio As String, ByVal miembro As String) As String
        sql = "SELECT dbo.fn_SALU_porcentajeCobro('" + sitio + "'," + miembro + ", GETDATE()) HealthPercent "
        porcentajeSalud = chequearValor(cn.obtieneEntero(sql, "HealthPercent"))
    End Function

    'devuelve la región
    Function regionFam(ByVal familia As String) As String
        If S = "A" Or S = "E" Then
            regionFam = ""
        Else
            sql = "SELECT dbo.fn_GEN_regionFamilia('" + S + "', " + familia + ") R "
            regionFam = cn.obtienePalabra(sql, "R")
        End If
    End Function

    'semaforo en un textbox
    Sub semaforo(ByVal color As String, ByRef semaforoV As Label)
        semaforoV.Text = "    "
        If color.ToUpper = "ROJO" Then
            semaforoV.BackColor = Drawing.Color.Red
        ElseIf color.ToUpper = "VERD" Or color = "Verde" Then
            semaforoV.BackColor = Drawing.Color.Green
        ElseIf color.ToUpper = "AMAR" Or color = "Amarillo" Then
            semaforoV.BackColor = Drawing.Color.Yellow
        Else
            semaforoV.BackColor = Drawing.Color.Transparent
        End If
    End Sub

    'para validar ingreso solo de números
    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    'validar ingreso de números con décimales
    Function SoloNumerosConDecimal(ByVal Keyascii As Short) As Short
        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            SoloNumerosConDecimal = 0
        Else
            SoloNumerosConDecimal = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConDecimal = Keyascii
            Case 13
                SoloNumerosConDecimal = Keyascii
        End Select
    End Function

    'valida ingreso de números con diagonal
    Function SoloNumerosConDiagonal(ByVal Keyascii As Short) As Short
        If InStr("1234567890/", Chr(Keyascii)) = 0 Then
            SoloNumerosConDiagonal = 0
        Else
            SoloNumerosConDiagonal = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConDiagonal = Keyascii
            Case 13
                SoloNumerosConDiagonal = Keyascii
        End Select
    End Function

    Function textoMasLargoEnFilasGrid(ByRef grid As DataGridView, ByVal columna As Integer) As String
        Dim ancho As Integer = 0
        Dim masLargo As String = ""

        For f = 0 To grid.RowCount - 1
            If Len(grid.Item(0, f).Value()) > ancho Then
                masLargo = grid.Item(columna, f).Value()
                ancho = Len(grid.Item(columna, f).Value())
            End If
        Next
        textoMasLargoEnFilasGrid = masLargo
    End Function

    'verifica si tiene derechos de Salud
    Function tieneDerechosSalud(ByVal S As String, ByVal miembro As Integer) As Boolean
        sql = "SELECT dbo.fn_SALU_tieneDerechos('" + S + "', " + miembro.ToString + ", GETDATE()) Derechos "
        Dim valor As Integer = cn.obtieneEntero(sql, "Derechos")
        If valor = 1 Then
            tieneDerechosSalud = True
        Else
            tieneDerechosSalud = False
        End If
    End Function

    'devuelve el tipo de miembro
    Function tipo_Miembro(ByVal sitio As String, ByVal miembro As String) As String
        If Len(miembro) = 0 Or Len(sitio) = 0 Or miembroEsValido(sitio, miembro) = False Then
            tipo_Miembro = ""
        Else
            sql = "SELECT dbo.fn_GEN_tipoMiembro('" + sitio + "', " + miembro + ") TM "
            tipo_Miembro = chequearValor(cn.obtienePalabra(sql, "TM"))
        End If
    End Function

    'obtener el ultimo número de sitio apoyos unicos salud
    Function ultimoIdApoyoUnicoSalud()
        sql = "SELECT MAX (MemberId) Miembro FROM Member WHERE Project = 'A'"
        ultimoIdApoyoUnicoSalud = cn.obtieneEntero(sql, "Miembro")
    End Function

    'obtener el ultimo número de sitio empleados
    Function ultimoIdEmpleado()
        sql = "SELECT MAX (MemberId) Miembro FROM Member WHERE Project = 'E' "
        ultimoIdEmpleado = cn.obtieneEntero(sql, "Miembro")
    End Function

    'obtener el ultimo número de sitio empleados
    Function ultimoIdFamiliaApoyoUnicoSalud()
        sql = "SELECT MAX (FamilyId) Familia FROM Family WHERE Project = 'A'"
        ultimoIdFamiliaApoyoUnicoSalud = cn.obtieneEntero(sql, "Familia")
    End Function

    'obtener el ultimo número de sitio empleados
    Function ultimoIdFamiliaEmpleado()
        sql = "SELECT MAX (FamilyId) Familia FROM Family WHERE Project = 'E'"
        ultimoIdFamiliaEmpleado = cn.obtieneEntero(sql, "Familia")
    End Function

    'permite unir fecha con hora en un solo string
    Function unirFechaHoraMinuto(ByVal fecha As DateTime, ByVal hora As String, ByVal minuto As String) As String
        Dim AmPm As String

        If Integer.Parse(hora) < 7 Or Integer.Parse(hora) > 11 Then
            AmPm = "PM"
        Else
            AmPm = "AM"
        End If

        unirFechaHoraMinuto = fecha.Month.ToString + "/" + fecha.Day.ToString + "/" + fecha.Year.ToString + " " + hora + ":" + minuto + ":00 " + AmPm
    End Function
End Module

