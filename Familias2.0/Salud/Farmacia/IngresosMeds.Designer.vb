<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresosMeds
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresosMeds))
        Me.VencimientoPicker = New System.Windows.Forms.DateTimePicker()
        Me.ProveedorL = New System.Windows.Forms.Label()
        Me.MedsCombo = New System.Windows.Forms.ComboBox()
        Me.MasMedsBoton = New System.Windows.Forms.Button()
        Me.MedsGrid = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldExp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.VencimientoL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaP = New System.Windows.Forms.DateTimePicker()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.FuenteCombo = New System.Windows.Forms.ComboBox()
        Me.FuenteL = New System.Windows.Forms.Label()
        Me.MedicinaPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrecioV = New System.Windows.Forms.TextBox()
        Me.PrecioL = New System.Windows.Forms.Label()
        Me.ProveedorCombo = New System.Windows.Forms.ComboBox()
        Me.ObservacionesV = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CantidadV = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TratPanel = New System.Windows.Forms.Panel()
        Me.TratamientoPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MedicinaPanel1.SuspendLayout()
        Me.TratPanel.SuspendLayout()
        Me.TratamientoPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'VencimientoPicker
        '
        Me.VencimientoPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VencimientoPicker.Location = New System.Drawing.Point(521, 40)
        Me.VencimientoPicker.Name = "VencimientoPicker"
        Me.VencimientoPicker.Size = New System.Drawing.Size(140, 30)
        Me.VencimientoPicker.TabIndex = 7
        '
        'ProveedorL
        '
        Me.ProveedorL.AutoSize = True
        Me.ProveedorL.Location = New System.Drawing.Point(3, 37)
        Me.ProveedorL.Name = "ProveedorL"
        Me.ProveedorL.Size = New System.Drawing.Size(107, 23)
        Me.ProveedorL.TabIndex = 201
        Me.ProveedorL.Text = "Proveedor:"
        '
        'MedsCombo
        '
        Me.MedsCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.MedsCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedsCombo.BackColor = System.Drawing.Color.Snow
        Me.MedicinaPanel1.SetColumnSpan(Me.MedsCombo, 4)
        Me.MedsCombo.FormattingEnabled = True
        Me.MedsCombo.Location = New System.Drawing.Point(116, 3)
        Me.MedsCombo.Name = "MedsCombo"
        Me.MedsCombo.Size = New System.Drawing.Size(545, 31)
        Me.MedsCombo.TabIndex = 3
        '
        'MasMedsBoton
        '
        Me.MasMedsBoton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasMedsBoton.BackColor = System.Drawing.Color.Peru
        Me.MasMedsBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasMedsBoton.ForeColor = System.Drawing.Color.White
        Me.MasMedsBoton.Location = New System.Drawing.Point(1158, 3)
        Me.MasMedsBoton.Name = "MasMedsBoton"
        Me.MasMedsBoton.Size = New System.Drawing.Size(141, 79)
        Me.MasMedsBoton.TabIndex = 9
        Me.MasMedsBoton.Text = "Agregar    al    Listado"
        Me.MasMedsBoton.UseVisualStyleBackColor = False
        '
        'MedsGrid
        '
        Me.MedsGrid.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.MedsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MedsGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MedsGrid.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.MedsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MedsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Medicamento, Me.Cantidad, Me.IdProv, Me.Proveedor, Me.Observaciones, Me.Presentacion, Me.Dosis, Me.Total, Me.Existencia, Me.Vencimiento, Me.OldExp, Me.Precio})
        Me.MedsGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MedsGrid.Location = New System.Drawing.Point(14, 99)
        Me.MedsGrid.Name = "MedsGrid"
        Me.MedsGrid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedsGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedsGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MedsGrid.Size = New System.Drawing.Size(1300, 368)
        Me.MedsGrid.TabIndex = 11
        '
        'Cod
        '
        Me.Cod.HeaderText = "Codigo"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Width = 97
        '
        'Medicamento
        '
        Me.Medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Medicamento.HeaderText = "Medicamento"
        Me.Medicamento.Name = "Medicamento"
        Me.Medicamento.ReadOnly = True
        Me.Medicamento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Medicamento.Width = 153
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.FillWeight = 10.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 2
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 113
        '
        'IdProv
        '
        Me.IdProv.HeaderText = "IdProv"
        Me.IdProv.Name = "IdProv"
        Me.IdProv.ReadOnly = True
        Me.IdProv.Visible = False
        Me.IdProv.Width = 92
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 126
        '
        'Observaciones
        '
        Me.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 166
        '
        'Presentacion
        '
        Me.Presentacion.HeaderText = "Presentación Usual"
        Me.Presentacion.Name = "Presentacion"
        Me.Presentacion.ReadOnly = True
        Me.Presentacion.Width = 185
        '
        'Dosis
        '
        Me.Dosis.HeaderText = "Cantidad por Presentación seleccionada"
        Me.Dosis.Name = "Dosis"
        Me.Dosis.ReadOnly = True
        Me.Dosis.Width = 351
        '
        'Total
        '
        Me.Total.HeaderText = "Total a Ingresar"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 158
        '
        'Existencia
        '
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.ReadOnly = True
        Me.Existencia.Width = 123
        '
        'Vencimiento
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Vencimiento.DefaultCellStyle = DataGridViewCellStyle3
        Me.Vencimiento.HeaderText = "Vencimiento Ingresado"
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.ReadOnly = True
        Me.Vencimiento.Width = 213
        '
        'OldExp
        '
        Me.OldExp.HeaderText = "En Estante (Más Reciente)"
        Me.OldExp.Name = "OldExp"
        Me.OldExp.ReadOnly = True
        Me.OldExp.Width = 171
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio Unitario"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 149
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 23)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "*Medicina:"
        '
        'VencimientoL
        '
        Me.VencimientoL.AutoSize = True
        Me.VencimientoL.BackColor = System.Drawing.Color.Transparent
        Me.VencimientoL.Location = New System.Drawing.Point(386, 37)
        Me.VencimientoL.Name = "VencimientoL"
        Me.VencimientoL.Size = New System.Drawing.Size(129, 23)
        Me.VencimientoL.TabIndex = 223
        Me.VencimientoL.Text = "*Vencimiento:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FechaP, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FuenteCombo, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FuenteL, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 121)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1332, 44)
        Me.TableLayoutPanel1.TabIndex = 249
        '
        'FechaP
        '
        Me.FechaP.Location = New System.Drawing.Point(706, 3)
        Me.FechaP.Name = "FechaP"
        Me.FechaP.Size = New System.Drawing.Size(266, 30)
        Me.FechaP.TabIndex = 1
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Location = New System.Drawing.Point(622, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(78, 23)
        Me.FechaL.TabIndex = 222
        Me.FechaL.Text = "*Fecha:"
        '
        'FuenteCombo
        '
        Me.FuenteCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FuenteCombo.BackColor = System.Drawing.Color.Snow
        Me.FuenteCombo.FormattingEnabled = True
        Me.FuenteCombo.Location = New System.Drawing.Point(1088, 3)
        Me.FuenteCombo.Name = "FuenteCombo"
        Me.FuenteCombo.Size = New System.Drawing.Size(241, 31)
        Me.FuenteCombo.TabIndex = 2
        '
        'FuenteL
        '
        Me.FuenteL.AutoSize = True
        Me.FuenteL.BackColor = System.Drawing.Color.Transparent
        Me.FuenteL.Location = New System.Drawing.Point(998, 0)
        Me.FuenteL.Name = "FuenteL"
        Me.FuenteL.Size = New System.Drawing.Size(84, 23)
        Me.FuenteL.TabIndex = 224
        Me.FuenteL.Text = "*Fuente:"
        '
        'MedicinaPanel1
        '
        Me.MedicinaPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedicinaPanel1.ColumnCount = 11
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.Controls.Add(Me.PrecioV, 10, 0)
        Me.MedicinaPanel1.Controls.Add(Me.PrecioL, 9, 0)
        Me.MedicinaPanel1.Controls.Add(Me.VencimientoPicker, 4, 1)
        Me.MedicinaPanel1.Controls.Add(Me.ProveedorL, 0, 1)
        Me.MedicinaPanel1.Controls.Add(Me.Label14, 0, 0)
        Me.MedicinaPanel1.Controls.Add(Me.MedsCombo, 1, 0)
        Me.MedicinaPanel1.Controls.Add(Me.VencimientoL, 3, 1)
        Me.MedicinaPanel1.Controls.Add(Me.ProveedorCombo, 1, 1)
        Me.MedicinaPanel1.Controls.Add(Me.ObservacionesV, 7, 1)
        Me.MedicinaPanel1.Controls.Add(Me.Label13, 6, 1)
        Me.MedicinaPanel1.Controls.Add(Me.CantidadV, 7, 0)
        Me.MedicinaPanel1.Controls.Add(Me.Label12, 6, 0)
        Me.MedicinaPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MedicinaPanel1.Name = "MedicinaPanel1"
        Me.MedicinaPanel1.RowCount = 2
        Me.MedicinaPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaPanel1.Size = New System.Drawing.Size(1091, 79)
        Me.MedicinaPanel1.TabIndex = 0
        '
        'PrecioV
        '
        Me.PrecioV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioV.Location = New System.Drawing.Point(1020, 3)
        Me.PrecioV.Name = "PrecioV"
        Me.PrecioV.Size = New System.Drawing.Size(68, 30)
        Me.PrecioV.TabIndex = 5
        Me.PrecioV.Text = "0.00"
        '
        'PrecioL
        '
        Me.PrecioL.AutoSize = True
        Me.PrecioL.BackColor = System.Drawing.Color.Transparent
        Me.PrecioL.Location = New System.Drawing.Point(920, 0)
        Me.PrecioL.Name = "PrecioL"
        Me.PrecioL.Size = New System.Drawing.Size(94, 23)
        Me.PrecioL.TabIndex = 69
        Me.PrecioL.Text = "Precio Q."
        '
        'ProveedorCombo
        '
        Me.ProveedorCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProveedorCombo.BackColor = System.Drawing.Color.Snow
        Me.ProveedorCombo.FormattingEnabled = True
        Me.ProveedorCombo.Location = New System.Drawing.Point(116, 40)
        Me.ProveedorCombo.Name = "ProveedorCombo"
        Me.ProveedorCombo.Size = New System.Drawing.Size(234, 31)
        Me.ProveedorCombo.TabIndex = 6
        '
        'ObservacionesV
        '
        Me.ObservacionesV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesV.BackColor = System.Drawing.Color.Snow
        Me.MedicinaPanel1.SetColumnSpan(Me.ObservacionesV, 4)
        Me.ObservacionesV.Location = New System.Drawing.Point(844, 40)
        Me.ObservacionesV.MaxLength = 79
        Me.ObservacionesV.Name = "ObservacionesV"
        Me.ObservacionesV.Size = New System.Drawing.Size(244, 30)
        Me.ObservacionesV.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(697, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 23)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Observaciones"
        '
        'CantidadV
        '
        Me.CantidadV.BackColor = System.Drawing.Color.Snow
        Me.CantidadV.Location = New System.Drawing.Point(844, 3)
        Me.CantidadV.Name = "CantidadV"
        Me.CantidadV.Size = New System.Drawing.Size(50, 30)
        Me.CantidadV.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(697, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 23)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "*Cantidad"
        '
        'TratPanel
        '
        Me.TratPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TratPanel.AutoScroll = True
        Me.TratPanel.BackColor = System.Drawing.Color.Transparent
        Me.TratPanel.Controls.Add(Me.TratamientoPanel)
        Me.TratPanel.Controls.Add(Me.MedsGrid)
        Me.TratPanel.Location = New System.Drawing.Point(0, 161)
        Me.TratPanel.Name = "TratPanel"
        Me.TratPanel.Size = New System.Drawing.Size(1332, 535)
        Me.TratPanel.TabIndex = 250
        '
        'TratamientoPanel
        '
        Me.TratamientoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TratamientoPanel.ColumnCount = 3
        Me.TratamientoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TratamientoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TratamientoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TratamientoPanel.Controls.Add(Me.MedicinaPanel1, 0, 0)
        Me.TratamientoPanel.Controls.Add(Me.MasMedsBoton, 2, 0)
        Me.TratamientoPanel.Location = New System.Drawing.Point(12, 8)
        Me.TratamientoPanel.Name = "TratamientoPanel"
        Me.TratamientoPanel.RowCount = 1
        Me.TratamientoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TratamientoPanel.Size = New System.Drawing.Size(1302, 85)
        Me.TratamientoPanel.TabIndex = 139
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(1332, 118)
        Me.bannerPanel.TabIndex = 259
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 4
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(1236, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(1130, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(49, 44)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(1079, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 45)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(1185, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 236
        Me.GuardarButton.UseVisualStyleBackColor = False
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
        Me.Title.Size = New System.Drawing.Size(1068, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Ingresar Compras y Donaciones"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IngresosMeds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(1332, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TratPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IngresosMeds"
        Me.Text = "Ingresos de Medicinas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MedicinaPanel1.ResumeLayout(False)
        Me.MedicinaPanel1.PerformLayout()
        Me.TratPanel.ResumeLayout(False)
        Me.TratamientoPanel.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VencimientoPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProveedorL As System.Windows.Forms.Label
    Friend WithEvents MedsCombo As System.Windows.Forms.ComboBox
    Friend WithEvents MedicinaPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents VencimientoL As System.Windows.Forms.Label
    Friend WithEvents ProveedorCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ObservacionesV As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CantidadV As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MasMedsBoton As System.Windows.Forms.Button
    Friend WithEvents MedsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FuenteL As System.Windows.Forms.Label
    Friend WithEvents FuenteCombo As System.Windows.Forms.ComboBox
    Friend WithEvents FechaP As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents TratPanel As System.Windows.Forms.Panel
    Friend WithEvents TratamientoPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PrecioL As System.Windows.Forms.Label
    Friend WithEvents PrecioV As System.Windows.Forms.TextBox
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OldExp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
