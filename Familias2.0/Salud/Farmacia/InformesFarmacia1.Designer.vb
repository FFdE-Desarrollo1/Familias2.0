<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformesFarmacia1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformesFarmacia1))
        Me.ProveedorL = New System.Windows.Forms.Label()
        Me.ArticuloCombo = New System.Windows.Forms.ComboBox()
        Me.DeAñoV = New System.Windows.Forms.TextBox()
        Me.tDeFechaV = New System.Windows.Forms.Label()
        Me.tAFechaV = New System.Windows.Forms.Label()
        Me.tArticuloCombo = New System.Windows.Forms.ComboBox()
        Me.tArticuloL = New System.Windows.Forms.Label()
        Me.tDeFechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.tAFechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.ProveedorCombo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.ExistenciasButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.EntregadosButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TransButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.precioCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeL = New System.Windows.Forms.Label()
        Me.MedsSinButton = New System.Windows.Forms.Button()
        Me.ArticuloL = New System.Windows.Forms.Label()
        Me.BusquedaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ParametrosL = New System.Windows.Forms.Label()
        Me.TipoInfL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.addCheckBox = New System.Windows.Forms.CheckBox()
        Me.mesesCheckBox = New System.Windows.Forms.CheckBox()
        Me.mesCheckBox = New System.Windows.Forms.CheckBox()
        Me.TratCheckBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FuenteL = New System.Windows.Forms.Label()
        Me.FuenteCombo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.BusquedaTable.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProveedorL
        '
        Me.ProveedorL.AutoSize = True
        Me.ProveedorL.Location = New System.Drawing.Point(3, 106)
        Me.ProveedorL.Name = "ProveedorL"
        Me.ProveedorL.Size = New System.Drawing.Size(107, 23)
        Me.ProveedorL.TabIndex = 10
        Me.ProveedorL.Text = "Proveedor:"
        '
        'ArticuloCombo
        '
        Me.ArticuloCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ArticuloCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArticuloCombo.FormattingEnabled = True
        Me.ArticuloCombo.Location = New System.Drawing.Point(92, 39)
        Me.ArticuloCombo.Name = "ArticuloCombo"
        Me.ArticuloCombo.Size = New System.Drawing.Size(389, 31)
        Me.ArticuloCombo.TabIndex = 5
        '
        'DeAñoV
        '
        Me.DeAñoV.Location = New System.Drawing.Point(92, 3)
        Me.DeAñoV.Name = "DeAñoV"
        Me.DeAñoV.Size = New System.Drawing.Size(94, 30)
        Me.DeAñoV.TabIndex = 3
        '
        'tDeFechaV
        '
        Me.tDeFechaV.AutoSize = True
        Me.tDeFechaV.Location = New System.Drawing.Point(3, 0)
        Me.tDeFechaV.Name = "tDeFechaV"
        Me.tDeFechaV.Size = New System.Drawing.Size(101, 23)
        Me.tDeFechaV.TabIndex = 1
        Me.tDeFechaV.Text = "De Fecha:"
        '
        'tAFechaV
        '
        Me.tAFechaV.AutoSize = True
        Me.tAFechaV.Location = New System.Drawing.Point(3, 36)
        Me.tAFechaV.Name = "tAFechaV"
        Me.tAFechaV.Size = New System.Drawing.Size(88, 23)
        Me.tAFechaV.TabIndex = 2
        Me.tAFechaV.Text = "A Fecha:"
        '
        'tArticuloCombo
        '
        Me.tArticuloCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tArticuloCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tArticuloCombo.FormattingEnabled = True
        Me.tArticuloCombo.Location = New System.Drawing.Point(116, 75)
        Me.tArticuloCombo.Name = "tArticuloCombo"
        Me.tArticuloCombo.Size = New System.Drawing.Size(389, 31)
        Me.tArticuloCombo.TabIndex = 6
        '
        'tArticuloL
        '
        Me.tArticuloL.AutoSize = True
        Me.tArticuloL.Location = New System.Drawing.Point(3, 72)
        Me.tArticuloL.Name = "tArticuloL"
        Me.tArticuloL.Size = New System.Drawing.Size(83, 23)
        Me.tArticuloL.TabIndex = 3
        Me.tArticuloL.Text = "Artículo:"
        '
        'tDeFechaPicker
        '
        Me.tDeFechaPicker.Location = New System.Drawing.Point(116, 3)
        Me.tDeFechaPicker.Name = "tDeFechaPicker"
        Me.tDeFechaPicker.Size = New System.Drawing.Size(276, 30)
        Me.tDeFechaPicker.TabIndex = 7
        '
        'tAFechaPicker
        '
        Me.tAFechaPicker.Location = New System.Drawing.Point(116, 39)
        Me.tAFechaPicker.Name = "tAFechaPicker"
        Me.tAFechaPicker.Size = New System.Drawing.Size(276, 30)
        Me.tAFechaPicker.TabIndex = 8
        '
        'ProveedorCombo
        '
        Me.ProveedorCombo.FormattingEnabled = True
        Me.ProveedorCombo.Location = New System.Drawing.Point(116, 109)
        Me.ProveedorCombo.Name = "ProveedorCombo"
        Me.ProveedorCombo.Size = New System.Drawing.Size(389, 31)
        Me.ProveedorCombo.TabIndex = 9
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.ExistenciasButton, 0, 1)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(17, 33)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(200, 161)
        Me.TableLayoutPanel7.TabIndex = 8
        '
        'ExistenciasButton
        '
        Me.ExistenciasButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExistenciasButton.Location = New System.Drawing.Point(3, 67)
        Me.ExistenciasButton.Name = "ExistenciasButton"
        Me.ExistenciasButton.Size = New System.Drawing.Size(194, 26)
        Me.ExistenciasButton.TabIndex = 2
        Me.ExistenciasButton.Text = "Existencias"
        Me.ExistenciasButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.Lavender
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.EntregadosButton, 0, 1)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(17, 220)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(200, 65)
        Me.TableLayoutPanel8.TabIndex = 9
        '
        'EntregadosButton
        '
        Me.EntregadosButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntregadosButton.Location = New System.Drawing.Point(3, 16)
        Me.EntregadosButton.Name = "EntregadosButton"
        Me.EntregadosButton.Size = New System.Drawing.Size(194, 32)
        Me.EntregadosButton.TabIndex = 4
        Me.EntregadosButton.Text = "Artículos Entregados "
        Me.EntregadosButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TransButton, 0, 1)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(17, 311)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(200, 131)
        Me.TableLayoutPanel9.TabIndex = 10
        '
        'TransButton
        '
        Me.TransButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransButton.BackColor = System.Drawing.Color.Transparent
        Me.TransButton.Location = New System.Drawing.Point(3, 42)
        Me.TransButton.Name = "TransButton"
        Me.TransButton.Size = New System.Drawing.Size(194, 46)
        Me.TransButton.TabIndex = 6
        Me.TransButton.Text = "Ingresos y Egresos"
        Me.TransButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.precioCheckBox, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(223, 468)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(543, 37)
        Me.TableLayoutPanel4.TabIndex = 206
        '
        'precioCheckBox
        '
        Me.precioCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.precioCheckBox.AutoSize = True
        Me.precioCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.precioCheckBox.Name = "precioCheckBox"
        Me.precioCheckBox.Size = New System.Drawing.Size(133, 31)
        Me.precioCheckBox.TabIndex = 205
        Me.precioCheckBox.Text = "Con Precio"
        Me.precioCheckBox.UseVisualStyleBackColor = True
        '
        'DeL
        '
        Me.DeL.AutoSize = True
        Me.DeL.Location = New System.Drawing.Point(3, 0)
        Me.DeL.Name = "DeL"
        Me.DeL.Size = New System.Drawing.Size(51, 23)
        Me.DeL.TabIndex = 0
        Me.DeL.Text = "Año:"
        '
        'MedsSinButton
        '
        Me.MedsSinButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsSinButton.BackColor = System.Drawing.Color.Transparent
        Me.MedsSinButton.Location = New System.Drawing.Point(3, 3)
        Me.MedsSinButton.Name = "MedsSinButton"
        Me.MedsSinButton.Size = New System.Drawing.Size(194, 31)
        Me.MedsSinButton.TabIndex = 204
        Me.MedsSinButton.Text = "Lista de Artículos"
        Me.MedsSinButton.UseVisualStyleBackColor = False
        '
        'ArticuloL
        '
        Me.ArticuloL.AutoSize = True
        Me.ArticuloL.Location = New System.Drawing.Point(3, 36)
        Me.ArticuloL.Name = "ArticuloL"
        Me.ArticuloL.Size = New System.Drawing.Size(83, 23)
        Me.ArticuloL.TabIndex = 2
        Me.ArticuloL.Text = "Artículo:"
        '
        'BusquedaTable
        '
        Me.BusquedaTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusquedaTable.BackColor = System.Drawing.Color.Transparent
        Me.BusquedaTable.ColumnCount = 4
        Me.BusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaTable.Controls.Add(Me.ParametrosL, 2, 0)
        Me.BusquedaTable.Controls.Add(Me.TipoInfL, 1, 0)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel1, 2, 1)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel3, 2, 3)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel6, 2, 5)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel7, 1, 1)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel8, 1, 3)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel9, 1, 5)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel4, 2, 7)
        Me.BusquedaTable.Controls.Add(Me.TableLayoutPanel5, 1, 7)
        Me.BusquedaTable.Location = New System.Drawing.Point(0, 124)
        Me.BusquedaTable.Name = "BusquedaTable"
        Me.BusquedaTable.RowCount = 9
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaTable.Size = New System.Drawing.Size(784, 618)
        Me.BusquedaTable.TabIndex = 249
        '
        'ParametrosL
        '
        Me.ParametrosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParametrosL.AutoSize = True
        Me.ParametrosL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParametrosL.Location = New System.Drawing.Point(223, 0)
        Me.ParametrosL.Name = "ParametrosL"
        Me.ParametrosL.Size = New System.Drawing.Size(543, 30)
        Me.ParametrosL.TabIndex = 204
        Me.ParametrosL.Text = "PARAMETROS"
        Me.ParametrosL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TipoInfL
        '
        Me.TipoInfL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoInfL.AutoSize = True
        Me.TipoInfL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoInfL.Location = New System.Drawing.Point(17, 0)
        Me.TipoInfL.Name = "TipoInfL"
        Me.TipoInfL.Size = New System.Drawing.Size(200, 30)
        Me.TipoInfL.TabIndex = 1
        Me.TipoInfL.Text = "TIPO DE INFORME"
        Me.TipoInfL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.addCheckBox, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.mesesCheckBox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.mesCheckBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TratCheckBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(223, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(543, 161)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'addCheckBox
        '
        Me.addCheckBox.AutoSize = True
        Me.addCheckBox.Checked = True
        Me.addCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.addCheckBox.Location = New System.Drawing.Point(3, 102)
        Me.addCheckBox.Name = "addCheckBox"
        Me.addCheckBox.Size = New System.Drawing.Size(406, 27)
        Me.addCheckBox.TabIndex = 3
        Me.addCheckBox.Text = "Mayor a la cantidad mínima para 3 meses"
        Me.addCheckBox.UseVisualStyleBackColor = True
        '
        'mesesCheckBox
        '
        Me.mesesCheckBox.AutoSize = True
        Me.mesesCheckBox.Checked = True
        Me.mesesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mesesCheckBox.Location = New System.Drawing.Point(3, 69)
        Me.mesesCheckBox.Name = "mesesCheckBox"
        Me.mesesCheckBox.Size = New System.Drawing.Size(469, 27)
        Me.mesesCheckBox.TabIndex = 2
        Me.mesesCheckBox.Text = "Menor o igual a la cantidad mínima para 3 meses"
        Me.mesesCheckBox.UseVisualStyleBackColor = True
        '
        'mesCheckBox
        '
        Me.mesCheckBox.AutoSize = True
        Me.mesCheckBox.Checked = True
        Me.mesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mesCheckBox.Location = New System.Drawing.Point(3, 36)
        Me.mesCheckBox.Name = "mesCheckBox"
        Me.mesCheckBox.Size = New System.Drawing.Size(448, 27)
        Me.mesCheckBox.TabIndex = 1
        Me.mesCheckBox.Text = "Menor o igual a la cantidad mínima para 1 mes"
        Me.mesCheckBox.UseVisualStyleBackColor = True
        '
        'TratCheckBox
        '
        Me.TratCheckBox.AutoSize = True
        Me.TratCheckBox.Checked = True
        Me.TratCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TratCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.TratCheckBox.Name = "TratCheckBox"
        Me.TratCheckBox.Size = New System.Drawing.Size(432, 27)
        Me.TratCheckBox.TabIndex = 0
        Me.TratCheckBox.Text = "Menor o igual a la cantidad de un tratamiento"
        Me.TratCheckBox.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FuenteL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FuenteCombo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 143)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(537, 37)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'FuenteL
        '
        Me.FuenteL.Location = New System.Drawing.Point(3, 0)
        Me.FuenteL.Name = "FuenteL"
        Me.FuenteL.Size = New System.Drawing.Size(73, 24)
        Me.FuenteL.TabIndex = 0
        Me.FuenteL.Text = "Comprado en:"
        Me.FuenteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FuenteCombo
        '
        Me.FuenteCombo.FormattingEnabled = True
        Me.FuenteCombo.Location = New System.Drawing.Point(82, 3)
        Me.FuenteCombo.Name = "FuenteCombo"
        Me.FuenteCombo.Size = New System.Drawing.Size(257, 31)
        Me.FuenteCombo.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Lavender
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ArticuloCombo, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.DeAñoV, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DeL, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ArticuloL, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(223, 220)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(543, 65)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.ProveedorL, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.tDeFechaV, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tAFechaV, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.tArticuloCombo, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.tArticuloL, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.tDeFechaPicker, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.tAFechaPicker, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.ProveedorCombo, 1, 3)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(223, 311)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(543, 131)
        Me.TableLayoutPanel6.TabIndex = 7
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.MedsSinButton, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(17, 468)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(200, 37)
        Me.TableLayoutPanel5.TabIndex = 207
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 260
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 2
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(640, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 45)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Title.Location = New System.Drawing.Point(4, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(629, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Informes de Farmacia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InformesFarmacia1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.BusquedaTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "InformesFarmacia1"
        Me.Text = "Informes Farmacia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.BusquedaTable.ResumeLayout(False)
        Me.BusquedaTable.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProveedorL As System.Windows.Forms.Label
    Friend WithEvents ArticuloCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DeAñoV As System.Windows.Forms.TextBox
    Friend WithEvents tDeFechaV As System.Windows.Forms.Label
    Friend WithEvents tAFechaV As System.Windows.Forms.Label
    Friend WithEvents tArticuloCombo As System.Windows.Forms.ComboBox
    Friend WithEvents tArticuloL As System.Windows.Forms.Label
    Friend WithEvents tDeFechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents tAFechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProveedorCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ExistenciasButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EntregadosButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TransButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents precioCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DeL As System.Windows.Forms.Label
    Friend WithEvents MedsSinButton As System.Windows.Forms.Button
    Friend WithEvents ArticuloL As System.Windows.Forms.Label
    Friend WithEvents BusquedaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ParametrosL As System.Windows.Forms.Label
    Friend WithEvents TipoInfL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents addCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents mesesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents mesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TratCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FuenteL As System.Windows.Forms.Label
    Friend WithEvents FuenteCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
