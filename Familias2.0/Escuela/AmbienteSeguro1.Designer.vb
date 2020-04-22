<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmbienteSeguro1
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AmbienteSeguro1))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.CatCodL = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.FechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionesL = New System.Windows.Forms.Label()
        Me.ObservacionesV = New System.Windows.Forms.TextBox()
        Me.CategoriaCombo = New System.Windows.Forms.ComboBox()
        Me.CategoriaL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.DetReporteTable = New System.Windows.Forms.TableLayoutPanel()
        Me.RazonL = New System.Windows.Forms.Label()
        Me.RazonList = New System.Windows.Forms.CheckedListBox()
        Me.MemberInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.AlumnoV = New System.Windows.Forms.Label()
        Me.AlumnoL = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListadoCatGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.DatosTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetReporteTable.SuspendLayout()
        Me.MemberInfoTable.SuspendLayout()
        Me.Table1.SuspendLayout()
        CType(Me.ListadoCatGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(934, 133)
        Me.bannerPanel.TabIndex = 257
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(110, 76)
        Me.opcionesTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(822, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(771, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 47)
        Me.GuardarButton.TabIndex = 69
        Me.GuardarButton.UseVisualStyleBackColor = False
        Me.GuardarButton.Visible = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(708, 4)
        Me.NuevoButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(57, 45)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(650, 4)
        Me.inicioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(52, 45)
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
        Me.Title.Location = New System.Drawing.Point(5, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(637, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Ambiente Seguro - Escuela NE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.OldLace
        Me.DatosTable.ColumnCount = 8
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 423.0!))
        Me.DatosTable.Controls.Add(Me.CatCodL, 7, 0)
        Me.DatosTable.Controls.Add(Me.AñoL, 0, 0)
        Me.DatosTable.Controls.Add(Me.GradoL, 3, 0)
        Me.DatosTable.Controls.Add(Me.GradoCombo, 4, 0)
        Me.DatosTable.Controls.Add(Me.AñoV, 1, 0)
        Me.DatosTable.Controls.Add(Me.ListadoButton, 6, 0)
        Me.DatosTable.Location = New System.Drawing.Point(0, 135)
        Me.DatosTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 1
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.Size = New System.Drawing.Size(934, 37)
        Me.DatosTable.TabIndex = 265
        '
        'CatCodL
        '
        Me.CatCodL.AutoSize = True
        Me.CatCodL.Location = New System.Drawing.Point(563, 0)
        Me.CatCodL.Name = "CatCodL"
        Me.CatCodL.Size = New System.Drawing.Size(21, 23)
        Me.CatCodL.TabIndex = 269
        Me.CatCodL.Text = "0"
        Me.CatCodL.Visible = False
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(45, 23)
        Me.AñoL.TabIndex = 258
        Me.AñoL.Text = "Año"
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.Location = New System.Drawing.Point(136, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(66, 23)
        Me.GradoL.TabIndex = 0
        Me.GradoL.Text = "Grado"
        '
        'GradoCombo
        '
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(208, 4)
        Me.GradoCombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(140, 31)
        Me.GradoCombo.TabIndex = 4
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(54, 4)
        Me.AñoV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.ReadOnly = True
        Me.AñoV.Size = New System.Drawing.Size(53, 30)
        Me.AñoV.TabIndex = 260
        '
        'ListadoButton
        '
        Me.ListadoButton.BackColor = System.Drawing.Color.SandyBrown
        Me.ListadoButton.Location = New System.Drawing.Point(377, 4)
        Me.ListadoButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(180, 28)
        Me.ListadoButton.TabIndex = 259
        Me.ListadoButton.Text = "Ver Listado"
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.Location = New System.Drawing.Point(3, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(72, 23)
        Me.FechaL.TabIndex = 266
        Me.FechaL.Text = "*Fecha"
        Me.FechaL.Visible = False
        '
        'FechaPicker
        '
        Me.FechaPicker.Location = New System.Drawing.Point(82, 4)
        Me.FechaPicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FechaPicker.Name = "FechaPicker"
        Me.FechaPicker.Size = New System.Drawing.Size(273, 30)
        Me.FechaPicker.TabIndex = 267
        Me.FechaPicker.Visible = False
        '
        'ObservacionesL
        '
        Me.ObservacionesL.AutoSize = True
        Me.DetReporteTable.SetColumnSpan(Me.ObservacionesL, 2)
        Me.ObservacionesL.Location = New System.Drawing.Point(3, 218)
        Me.ObservacionesL.Name = "ObservacionesL"
        Me.ObservacionesL.Size = New System.Drawing.Size(141, 23)
        Me.ObservacionesL.TabIndex = 266
        Me.ObservacionesL.Text = "Observaciones"
        Me.ObservacionesL.Visible = False
        '
        'ObservacionesV
        '
        Me.ObservacionesV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetReporteTable.SetColumnSpan(Me.ObservacionesV, 2)
        Me.ObservacionesV.Location = New System.Drawing.Point(3, 245)
        Me.ObservacionesV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ObservacionesV.MaxLength = 100
        Me.ObservacionesV.Name = "ObservacionesV"
        Me.ObservacionesV.Size = New System.Drawing.Size(455, 30)
        Me.ObservacionesV.TabIndex = 268
        Me.ObservacionesV.Visible = False
        '
        'CategoriaCombo
        '
        Me.CategoriaCombo.FormattingEnabled = True
        Me.CategoriaCombo.Location = New System.Drawing.Point(113, 28)
        Me.CategoriaCombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoriaCombo.Name = "CategoriaCombo"
        Me.CategoriaCombo.Size = New System.Drawing.Size(243, 31)
        Me.CategoriaCombo.TabIndex = 258
        '
        'CategoriaL
        '
        Me.CategoriaL.AutoSize = True
        Me.CategoriaL.Location = New System.Drawing.Point(3, 24)
        Me.CategoriaL.Name = "CategoriaL"
        Me.CategoriaL.Size = New System.Drawing.Size(104, 23)
        Me.CategoriaL.TabIndex = 3
        Me.CategoriaL.Text = "*Categoria"
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 4)
        Me.ListadoGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        Me.ListadoGrid.RowHeadersVisible = False
        Me.ListadoGrid.RowHeadersWidth = 10
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Table1.SetRowSpan(Me.ListadoGrid, 3)
        Me.ListadoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoGrid.Size = New System.Drawing.Size(461, 549)
        Me.ListadoGrid.TabIndex = 267
        Me.ListadoGrid.Visible = False
        '
        'DetReporteTable
        '
        Me.DetReporteTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetReporteTable.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.DetReporteTable.ColumnCount = 2
        Me.DetReporteTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DetReporteTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DetReporteTable.Controls.Add(Me.RazonL, 0, 1)
        Me.DetReporteTable.Controls.Add(Me.ObservacionesL, 0, 2)
        Me.DetReporteTable.Controls.Add(Me.FechaL, 0, 0)
        Me.DetReporteTable.Controls.Add(Me.FechaPicker, 1, 0)
        Me.DetReporteTable.Controls.Add(Me.RazonList, 1, 1)
        Me.DetReporteTable.Controls.Add(Me.ObservacionesV, 0, 3)
        Me.DetReporteTable.Location = New System.Drawing.Point(470, 64)
        Me.DetReporteTable.Name = "DetReporteTable"
        Me.DetReporteTable.RowCount = 4
        Me.DetReporteTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DetReporteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.DetReporteTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DetReporteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DetReporteTable.Size = New System.Drawing.Size(461, 260)
        Me.DetReporteTable.TabIndex = 268
        Me.DetReporteTable.Visible = False
        '
        'RazonL
        '
        Me.RazonL.AutoSize = True
        Me.RazonL.Location = New System.Drawing.Point(3, 38)
        Me.RazonL.Name = "RazonL"
        Me.RazonL.Size = New System.Drawing.Size(73, 23)
        Me.RazonL.TabIndex = 269
        Me.RazonL.Text = "*Razón"
        '
        'RazonList
        '
        Me.RazonList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RazonList.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonList.FormattingEnabled = True
        Me.RazonList.Location = New System.Drawing.Point(82, 41)
        Me.RazonList.Name = "RazonList"
        Me.RazonList.Size = New System.Drawing.Size(376, 154)
        Me.RazonList.TabIndex = 270
        '
        'MemberInfoTable
        '
        Me.MemberInfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberInfoTable.BackColor = System.Drawing.Color.Silver
        Me.MemberInfoTable.ColumnCount = 2
        Me.MemberInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MemberInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MemberInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MemberInfoTable.Controls.Add(Me.AlumnoV, 1, 0)
        Me.MemberInfoTable.Controls.Add(Me.AlumnoL, 0, 0)
        Me.MemberInfoTable.Controls.Add(Me.CategoriaCombo, 1, 1)
        Me.MemberInfoTable.Controls.Add(Me.CategoriaL, 0, 1)
        Me.MemberInfoTable.Location = New System.Drawing.Point(470, 3)
        Me.MemberInfoTable.Name = "MemberInfoTable"
        Me.MemberInfoTable.RowCount = 2
        Me.MemberInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MemberInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MemberInfoTable.Size = New System.Drawing.Size(461, 55)
        Me.MemberInfoTable.TabIndex = 269
        Me.MemberInfoTable.Visible = False
        '
        'AlumnoV
        '
        Me.AlumnoV.AutoSize = True
        Me.AlumnoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlumnoV.Location = New System.Drawing.Point(113, 0)
        Me.AlumnoV.Name = "AlumnoV"
        Me.AlumnoV.Size = New System.Drawing.Size(17, 24)
        Me.AlumnoV.TabIndex = 272
        Me.AlumnoV.Text = "-"
        '
        'AlumnoL
        '
        Me.AlumnoL.AutoSize = True
        Me.AlumnoL.Location = New System.Drawing.Point(3, 0)
        Me.AlumnoL.Name = "AlumnoL"
        Me.AlumnoL.Size = New System.Drawing.Size(88, 23)
        Me.AlumnoL.TabIndex = 271
        Me.AlumnoL.Text = "*Alumno:"
        '
        'Table1
        '
        Me.Table1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table1.ColumnCount = 2
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table1.Controls.Add(Me.MemberInfoTable, 1, 0)
        Me.Table1.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.Table1.Controls.Add(Me.DetReporteTable, 1, 1)
        Me.Table1.Controls.Add(Me.ListadoCatGrid, 1, 2)
        Me.Table1.Location = New System.Drawing.Point(0, 180)
        Me.Table1.Name = "Table1"
        Me.Table1.RowCount = 3
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table1.Size = New System.Drawing.Size(934, 557)
        Me.Table1.TabIndex = 270
        '
        'ListadoCatGrid
        '
        Me.ListadoCatGrid.AllowUserToAddRows = False
        Me.ListadoCatGrid.AllowUserToDeleteRows = False
        Me.ListadoCatGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoCatGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.ListadoCatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoCatGrid.GridColor = System.Drawing.Color.Green
        Me.ListadoCatGrid.Location = New System.Drawing.Point(470, 330)
        Me.ListadoCatGrid.Name = "ListadoCatGrid"
        Me.ListadoCatGrid.ReadOnly = True
        Me.ListadoCatGrid.RowHeadersVisible = False
        Me.ListadoCatGrid.Size = New System.Drawing.Size(461, 224)
        Me.ListadoCatGrid.TabIndex = 270
        Me.ListadoCatGrid.Visible = False
        '
        'AmbienteSeguro1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.DatosTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AmbienteSeguro1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AmbienteSeguro1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetReporteTable.ResumeLayout(False)
        Me.DetReporteTable.PerformLayout()
        Me.MemberInfoTable.ResumeLayout(False)
        Me.MemberInfoTable.PerformLayout()
        Me.Table1.ResumeLayout(False)
        CType(Me.ListadoCatGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents CategoriaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriaL As System.Windows.Forms.Label
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents FechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ObservacionesL As System.Windows.Forms.Label
    Friend WithEvents ObservacionesV As System.Windows.Forms.TextBox
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DetReporteTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RazonL As System.Windows.Forms.Label
    Friend WithEvents RazonList As System.Windows.Forms.CheckedListBox
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents CatCodL As System.Windows.Forms.Label
    Friend WithEvents MemberInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AlumnoV As System.Windows.Forms.Label
    Friend WithEvents AlumnoL As System.Windows.Forms.Label
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Table1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListadoCatGrid As System.Windows.Forms.DataGridView
End Class
