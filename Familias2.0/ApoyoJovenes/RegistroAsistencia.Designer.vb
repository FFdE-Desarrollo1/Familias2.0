<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAsistencia
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroAsistencia))
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.EdadL = New System.Windows.Forms.Label()
        Me.ApadrinadoPic = New System.Windows.Forms.PictureBox()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borra = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Actualiza = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.TipoMiembroL = New System.Windows.Forms.Label()
        Me.fotoL = New System.Windows.Forms.Label()
        Me.ActividadButton = New System.Windows.Forms.Button()
        Me.verFotoCheck = New System.Windows.Forms.CheckBox()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.DuplicadosCheck = New System.Windows.Forms.CheckBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.ObservacionesL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.TipoList = New System.Windows.Forms.ComboBox()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.FechaV = New System.Windows.Forms.DateTimePicker()
        Me.HoraV = New System.Windows.Forms.DateTimePicker()
        Me.horaButton = New System.Windows.Forms.Button()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.principalTable.SuspendLayout()
        CType(Me.ApadrinadoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.opcionesTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 3
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.principalTable.Controls.Add(Me.EdadL, 2, 2)
        Me.principalTable.Controls.Add(Me.ApadrinadoPic, 2, 0)
        Me.principalTable.Controls.Add(Me.NombreL, 2, 1)
        Me.principalTable.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.principalTable.Controls.Add(Me.TipoMiembroL, 2, 3)
        Me.principalTable.Controls.Add(Me.fotoL, 2, 4)
        Me.principalTable.Location = New System.Drawing.Point(0, 186)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 5
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.Size = New System.Drawing.Size(1276, 572)
        Me.principalTable.TabIndex = 240
        '
        'EdadL
        '
        Me.EdadL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdadL.AutoSize = True
        Me.EdadL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadL.Location = New System.Drawing.Point(1057, 245)
        Me.EdadL.Name = "EdadL"
        Me.EdadL.Size = New System.Drawing.Size(216, 16)
        Me.EdadL.TabIndex = 228
        Me.EdadL.Text = "edad"
        Me.EdadL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EdadL.Visible = False
        '
        'ApadrinadoPic
        '
        Me.ApadrinadoPic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApadrinadoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ApadrinadoPic.Location = New System.Drawing.Point(1057, 3)
        Me.ApadrinadoPic.Name = "ApadrinadoPic"
        Me.ApadrinadoPic.Size = New System.Drawing.Size(216, 214)
        Me.ApadrinadoPic.TabIndex = 34
        Me.ApadrinadoPic.TabStop = False
        Me.ApadrinadoPic.Visible = False
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(1057, 220)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(216, 16)
        Me.NombreL.TabIndex = 225
        Me.NombreL.Text = "nombre"
        Me.NombreL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NombreL.Visible = False
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Borra, Me.Actualiza})
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 28
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.principalTable.SetRowSpan(Me.ListadoGrid, 5)
        Me.ListadoGrid.Size = New System.Drawing.Size(1023, 566)
        Me.ListadoGrid.TabIndex = 226
        '
        'No
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        Me.No.DefaultCellStyle = DataGridViewCellStyle2
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        '
        'Borra
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent
        Me.Borra.DefaultCellStyle = DataGridViewCellStyle3
        Me.Borra.HeaderText = "Borrar"
        Me.Borra.Name = "Borra"
        '
        'Actualiza
        '
        Me.Actualiza.HeaderText = "Impresiones"
        Me.Actualiza.Name = "Actualiza"
        Me.Actualiza.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Actualiza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TipoMiembroL
        '
        Me.TipoMiembroL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMiembroL.AutoSize = True
        Me.TipoMiembroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMiembroL.Location = New System.Drawing.Point(1057, 270)
        Me.TipoMiembroL.Name = "TipoMiembroL"
        Me.TipoMiembroL.Size = New System.Drawing.Size(216, 16)
        Me.TipoMiembroL.TabIndex = 227
        Me.TipoMiembroL.Text = "tipo de miembro"
        Me.TipoMiembroL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TipoMiembroL.Visible = False
        '
        'fotoL
        '
        Me.fotoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fotoL.AutoSize = True
        Me.fotoL.BackColor = System.Drawing.Color.Chocolate
        Me.fotoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fotoL.ForeColor = System.Drawing.Color.White
        Me.fotoL.Location = New System.Drawing.Point(1057, 290)
        Me.fotoL.Name = "fotoL"
        Me.fotoL.Size = New System.Drawing.Size(216, 16)
        Me.fotoL.TabIndex = 229
        Me.fotoL.Text = "_"
        Me.fotoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.fotoL.Visible = False
        '
        'ActividadButton
        '
        Me.ActividadButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.ActividadButton.FlatAppearance.BorderSize = 2
        Me.ActividadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.ActividadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActividadButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadButton.Location = New System.Drawing.Point(682, 3)
        Me.ActividadButton.Name = "ActividadButton"
        Me.ActividadButton.Size = New System.Drawing.Size(147, 26)
        Me.ActividadButton.TabIndex = 247
        Me.ActividadButton.Text = "*Actividad:"
        Me.ActividadButton.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ActividadButton.UseVisualStyleBackColor = True
        '
        'verFotoCheck
        '
        Me.verFotoCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.verFotoCheck.AutoSize = True
        Me.verFotoCheck.Location = New System.Drawing.Point(3, 3)
        Me.verFotoCheck.Name = "verFotoCheck"
        Me.verFotoCheck.Size = New System.Drawing.Size(71, 26)
        Me.verFotoCheck.TabIndex = 224
        Me.verFotoCheck.Text = "Ver foto"
        Me.verFotoCheck.UseVisualStyleBackColor = True
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.Location = New System.Drawing.Point(1198, 35)
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(78, 29)
        Me.FamiliaV.TabIndex = 235
        '
        'DuplicadosCheck
        '
        Me.DuplicadosCheck.AutoSize = True
        Me.DuplicadosCheck.Location = New System.Drawing.Point(3, 35)
        Me.DuplicadosCheck.Name = "DuplicadosCheck"
        Me.DuplicadosCheck.Size = New System.Drawing.Size(133, 20)
        Me.DuplicadosCheck.TabIndex = 223
        Me.DuplicadosCheck.Text = "Marcar duplicados"
        Me.DuplicadosCheck.UseVisualStyleBackColor = True
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.Location = New System.Drawing.Point(1198, 3)
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(78, 29)
        Me.MiembroV.TabIndex = 234
        '
        'FechaL
        '
        Me.FechaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaL.AutoSize = True
        Me.FechaL.Location = New System.Drawing.Point(267, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(78, 16)
        Me.FechaL.TabIndex = 238
        Me.FechaL.Text = "*Fecha:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MiembroL
        '
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(1118, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(74, 17)
        Me.MiembroL.TabIndex = 237
        Me.MiembroL.Text = "*Miembro:"
        '
        'ObservacionesL
        '
        Me.ObservacionesL.AutoSize = True
        Me.ObservacionesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionesL.Location = New System.Drawing.Point(682, 32)
        Me.ObservacionesL.Name = "ObservacionesL"
        Me.ObservacionesL.Size = New System.Drawing.Size(97, 16)
        Me.ObservacionesL.TabIndex = 240
        Me.ObservacionesL.Text = "Observaciones:"
        Me.ObservacionesL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(1118, 32)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(59, 17)
        Me.FamiliaL.TabIndex = 241
        Me.FamiliaL.Text = "Familia:"
        '
        'TipoList
        '
        Me.TipoList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoList.FormattingEnabled = True
        Me.TipoList.Location = New System.Drawing.Point(835, 3)
        Me.TipoList.Name = "TipoList"
        Me.TipoList.Size = New System.Drawing.Size(247, 24)
        Me.TipoList.TabIndex = 242
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasV.Location = New System.Drawing.Point(835, 35)
        Me.NotasV.MaxLength = 120
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(247, 22)
        Me.NotasV.TabIndex = 243
        '
        'FechaV
        '
        Me.FechaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaV.Location = New System.Drawing.Point(351, 3)
        Me.FechaV.Name = "FechaV"
        Me.FechaV.Size = New System.Drawing.Size(295, 22)
        Me.FechaV.TabIndex = 244
        '
        'HoraV
        '
        Me.HoraV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraV.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraV.Location = New System.Drawing.Point(351, 35)
        Me.HoraV.Name = "HoraV"
        Me.HoraV.Size = New System.Drawing.Size(105, 22)
        Me.HoraV.TabIndex = 245
        '
        'horaButton
        '
        Me.horaButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.horaButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.horaButton.FlatAppearance.BorderSize = 2
        Me.horaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.horaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.horaButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaButton.Location = New System.Drawing.Point(267, 35)
        Me.horaButton.Name = "horaButton"
        Me.horaButton.Size = New System.Drawing.Size(78, 27)
        Me.horaButton.TabIndex = 246
        Me.horaButton.Text = "*Hora:"
        Me.horaButton.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.horaButton.UseVisualStyleBackColor = True
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.LightBlue
        Me.opcionesTable.ColumnCount = 9
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.ActividadButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.verFotoCheck, 0, 0)
        Me.opcionesTable.Controls.Add(Me.FamiliaV, 8, 1)
        Me.opcionesTable.Controls.Add(Me.DuplicadosCheck, 0, 1)
        Me.opcionesTable.Controls.Add(Me.MiembroV, 8, 0)
        Me.opcionesTable.Controls.Add(Me.FechaL, 1, 0)
        Me.opcionesTable.Controls.Add(Me.MiembroL, 7, 0)
        Me.opcionesTable.Controls.Add(Me.ObservacionesL, 4, 1)
        Me.opcionesTable.Controls.Add(Me.FamiliaL, 7, 1)
        Me.opcionesTable.Controls.Add(Me.TipoList, 5, 0)
        Me.opcionesTable.Controls.Add(Me.NotasV, 5, 1)
        Me.opcionesTable.Controls.Add(Me.FechaV, 2, 0)
        Me.opcionesTable.Controls.Add(Me.HoraV, 2, 1)
        Me.opcionesTable.Controls.Add(Me.horaButton, 1, 1)
        Me.opcionesTable.Location = New System.Drawing.Point(0, 120)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 2
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(1279, 65)
        Me.opcionesTable.TabIndex = 238
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(1278, 118)
        Me.bannerPanel.TabIndex = 253
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NuevoButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GuardarButton, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1182, 53)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(1076, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(1025, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(1131, 3)
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
        Me.Title.Size = New System.Drawing.Size(1014, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Registro de Asistencia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegistroAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(1278, 701)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.principalTable)
        Me.Controls.Add(Me.opcionesTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RegistroAsistencia"
        Me.Text = "Registro de Asistencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.principalTable.ResumeLayout(False)
        Me.principalTable.PerformLayout()
        CType(Me.ApadrinadoPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EdadL As System.Windows.Forms.Label
    Friend WithEvents ApadrinadoPic As System.Windows.Forms.PictureBox
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TipoMiembroL As System.Windows.Forms.Label
    Friend WithEvents fotoL As System.Windows.Forms.Label
    Friend WithEvents ActividadButton As System.Windows.Forms.Button
    Friend WithEvents verFotoCheck As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents DuplicadosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents ObservacionesL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents TipoList As System.Windows.Forms.ComboBox
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents FechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents HoraV As System.Windows.Forms.DateTimePicker
    Friend WithEvents horaButton As System.Windows.Forms.Button
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Borra As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Actualiza As System.Windows.Forms.DataGridViewLinkColumn
End Class
