<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroActividadesEduc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroActividadesEduc))
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borra = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.EdadL = New System.Windows.Forms.Label()
        Me.TipoMiembroL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.verInfoCheck = New System.Windows.Forms.CheckBox()
        Me.HoraV = New System.Windows.Forms.DateTimePicker()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.DuplicadosCheck = New System.Windows.Forms.CheckBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.TipoList = New System.Windows.Forms.ComboBox()
        Me.FechaV = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionesL = New System.Windows.Forms.Label()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.FaroL = New System.Windows.Forms.Label()
        Me.FaroV = New System.Windows.Forms.TextBox()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.principalTable.SuspendLayout()
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
        Me.principalTable.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.principalTable.Controls.Add(Me.NombreL, 2, 0)
        Me.principalTable.Controls.Add(Me.EdadL, 2, 1)
        Me.principalTable.Controls.Add(Me.TipoMiembroL, 2, 2)
        Me.principalTable.Controls.Add(Me.GradoL, 2, 3)
        Me.principalTable.Location = New System.Drawing.Point(0, 215)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 5
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.Size = New System.Drawing.Size(982, 427)
        Me.principalTable.TabIndex = 241
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Borra})
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 28
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.principalTable.SetRowSpan(Me.ListadoGrid, 5)
        Me.ListadoGrid.Size = New System.Drawing.Size(729, 516)
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
        'NombreL
        '
        Me.NombreL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.BackColor = System.Drawing.Color.SandyBrown
        Me.NombreL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(763, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(216, 40)
        Me.NombreL.TabIndex = 225
        Me.NombreL.Text = "nombre"
        Me.NombreL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NombreL.Visible = False
        '
        'EdadL
        '
        Me.EdadL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdadL.AutoSize = True
        Me.EdadL.BackColor = System.Drawing.Color.SandyBrown
        Me.EdadL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadL.Location = New System.Drawing.Point(763, 40)
        Me.EdadL.Name = "EdadL"
        Me.EdadL.Size = New System.Drawing.Size(216, 40)
        Me.EdadL.TabIndex = 228
        Me.EdadL.Text = "edad"
        Me.EdadL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EdadL.Visible = False
        '
        'TipoMiembroL
        '
        Me.TipoMiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMiembroL.AutoSize = True
        Me.TipoMiembroL.BackColor = System.Drawing.Color.SandyBrown
        Me.TipoMiembroL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMiembroL.Location = New System.Drawing.Point(763, 80)
        Me.TipoMiembroL.Name = "TipoMiembroL"
        Me.TipoMiembroL.Size = New System.Drawing.Size(216, 40)
        Me.TipoMiembroL.TabIndex = 227
        Me.TipoMiembroL.Text = "tipo de miembro"
        Me.TipoMiembroL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TipoMiembroL.Visible = False
        '
        'GradoL
        '
        Me.GradoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoL.AutoSize = True
        Me.GradoL.BackColor = System.Drawing.Color.SandyBrown
        Me.GradoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoL.Location = New System.Drawing.Point(763, 120)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(216, 40)
        Me.GradoL.TabIndex = 230
        Me.GradoL.Text = "Educ"
        Me.GradoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GradoL.Visible = False
        '
        'verInfoCheck
        '
        Me.verInfoCheck.AutoSize = True
        Me.verInfoCheck.Location = New System.Drawing.Point(3, 3)
        Me.verInfoCheck.Name = "verInfoCheck"
        Me.verInfoCheck.Size = New System.Drawing.Size(100, 20)
        Me.verInfoCheck.TabIndex = 247
        Me.verInfoCheck.Text = "Info. General"
        Me.verInfoCheck.UseVisualStyleBackColor = True
        '
        'HoraV
        '
        Me.HoraV.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraV.Location = New System.Drawing.Point(790, 31)
        Me.HoraV.Name = "HoraV"
        Me.HoraV.Size = New System.Drawing.Size(14, 22)
        Me.HoraV.TabIndex = 245
        Me.HoraV.Visible = False
        '
        'FamiliaV
        '
        Me.FamiliaV.Location = New System.Drawing.Point(893, 31)
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(88, 22)
        Me.FamiliaV.TabIndex = 235
        '
        'DuplicadosCheck
        '
        Me.DuplicadosCheck.AutoSize = True
        Me.DuplicadosCheck.Location = New System.Drawing.Point(3, 31)
        Me.DuplicadosCheck.Name = "DuplicadosCheck"
        Me.DuplicadosCheck.Size = New System.Drawing.Size(133, 20)
        Me.DuplicadosCheck.TabIndex = 223
        Me.DuplicadosCheck.Text = "Marcar duplicados"
        Me.DuplicadosCheck.UseVisualStyleBackColor = True
        '
        'MiembroV
        '
        Me.MiembroV.Location = New System.Drawing.Point(893, 3)
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(88, 22)
        Me.MiembroV.TabIndex = 234
        '
        'FechaL
        '
        Me.FechaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaL.AutoSize = True
        Me.FechaL.Location = New System.Drawing.Point(387, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(97, 16)
        Me.FechaL.TabIndex = 238
        Me.FechaL.Text = "*Fecha:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MiembroL
        '
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Location = New System.Drawing.Point(820, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(67, 16)
        Me.MiembroL.TabIndex = 237
        Me.MiembroL.Text = "*Miembro:"
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Location = New System.Drawing.Point(820, 28)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(54, 16)
        Me.FamiliaL.TabIndex = 241
        Me.FamiliaL.Text = "Familia:"
        '
        'TipoList
        '
        Me.TipoList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoList.FormattingEnabled = True
        Me.TipoList.Location = New System.Drawing.Point(490, 31)
        Me.TipoList.Name = "TipoList"
        Me.TipoList.Size = New System.Drawing.Size(294, 24)
        Me.TipoList.TabIndex = 242
        '
        'FechaV
        '
        Me.FechaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaV.Location = New System.Drawing.Point(490, 3)
        Me.FechaV.Name = "FechaV"
        Me.FechaV.Size = New System.Drawing.Size(294, 22)
        Me.FechaV.TabIndex = 244
        '
        'ObservacionesL
        '
        Me.ObservacionesL.AutoSize = True
        Me.ObservacionesL.Location = New System.Drawing.Point(387, 56)
        Me.ObservacionesL.Name = "ObservacionesL"
        Me.ObservacionesL.Size = New System.Drawing.Size(97, 16)
        Me.ObservacionesL.TabIndex = 240
        Me.ObservacionesL.Text = "Observaciones:"
        Me.ObservacionesL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Location = New System.Drawing.Point(490, 59)
        Me.NotasV.MaxLength = 120
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(294, 22)
        Me.NotasV.TabIndex = 243
        '
        'FaroL
        '
        Me.FaroL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaroL.AutoSize = True
        Me.FaroL.BackColor = System.Drawing.Color.Transparent
        Me.FaroL.ForeColor = System.Drawing.Color.Black
        Me.FaroL.Location = New System.Drawing.Point(820, 56)
        Me.FaroL.Name = "FaroL"
        Me.FaroL.Size = New System.Drawing.Size(67, 16)
        Me.FaroL.TabIndex = 69
        Me.FaroL.Text = "No. Faro:"
        Me.FaroL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FaroL.Visible = False
        '
        'FaroV
        '
        Me.FaroV.Location = New System.Drawing.Point(893, 59)
        Me.FaroV.Name = "FaroV"
        Me.FaroV.Size = New System.Drawing.Size(74, 22)
        Me.FaroV.TabIndex = 70
        Me.FaroV.Visible = False
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
        Me.opcionesTable.Controls.Add(Me.TipoL, 4, 1)
        Me.opcionesTable.Controls.Add(Me.verInfoCheck, 0, 0)
        Me.opcionesTable.Controls.Add(Me.FamiliaV, 8, 1)
        Me.opcionesTable.Controls.Add(Me.DuplicadosCheck, 0, 1)
        Me.opcionesTable.Controls.Add(Me.MiembroV, 8, 0)
        Me.opcionesTable.Controls.Add(Me.MiembroL, 7, 0)
        Me.opcionesTable.Controls.Add(Me.FamiliaL, 7, 1)
        Me.opcionesTable.Controls.Add(Me.FaroV, 8, 2)
        Me.opcionesTable.Controls.Add(Me.FaroL, 7, 2)
        Me.opcionesTable.Controls.Add(Me.NotasV, 5, 2)
        Me.opcionesTable.Controls.Add(Me.ObservacionesL, 4, 2)
        Me.opcionesTable.Controls.Add(Me.TipoList, 5, 1)
        Me.opcionesTable.Controls.Add(Me.HoraV, 6, 1)
        Me.opcionesTable.Controls.Add(Me.FechaV, 5, 0)
        Me.opcionesTable.Controls.Add(Me.FechaL, 4, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(0, 121)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 3
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(984, 88)
        Me.opcionesTable.TabIndex = 239
        '
        'TipoL
        '
        Me.TipoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoL.AutoSize = True
        Me.TipoL.Location = New System.Drawing.Point(387, 28)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(97, 16)
        Me.TipoL.TabIndex = 241
        Me.TipoL.Text = "Tipo:"
        Me.TipoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(984, 118)
        Me.bannerPanel.TabIndex = 255
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GuardarButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(888, 53)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(786, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(837, 3)
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
        Me.Title.Size = New System.Drawing.Size(775, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Registro de Actividades Educativas"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegistroActividadesEduc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.principalTable)
        Me.Controls.Add(Me.opcionesTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RegistroActividadesEduc"
        Me.Text = "Registro Actividades Miscelaneas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.principalTable.ResumeLayout(False)
        Me.principalTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Borra As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents EdadL As System.Windows.Forms.Label
    Friend WithEvents TipoMiembroL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents verInfoCheck As System.Windows.Forms.CheckBox
    Friend WithEvents HoraV As System.Windows.Forms.DateTimePicker
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents DuplicadosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents TipoList As System.Windows.Forms.ComboBox
    Friend WithEvents FechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents ObservacionesL As System.Windows.Forms.Label
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents FaroL As System.Windows.Forms.Label
    Friend WithEvents FaroV As System.Windows.Forms.TextBox
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents TipoL As System.Windows.Forms.Label
End Class
