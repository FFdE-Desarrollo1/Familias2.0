<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActividadesAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActividadesAE))
        Me.ActividadesGrid = New System.Windows.Forms.DataGridView()
        Me.IDL = New System.Windows.Forms.Label()
        Me.ActividadesLink = New System.Windows.Forms.LinkLabel()
        Me.HorMinL = New System.Windows.Forms.Label()
        Me.MinutosV = New System.Windows.Forms.TextBox()
        Me.HoraV = New System.Windows.Forms.TextBox()
        Me.TipoCombo = New System.Windows.Forms.ComboBox()
        Me.NuevaActL = New System.Windows.Forms.LinkLabel()
        Me.NuevaActividadTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.tipoL = New System.Windows.Forms.Label()
        Me.FechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fechaL = New System.Windows.Forms.Label()
        Me.HoraL = New System.Windows.Forms.Label()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.RegionV = New System.Windows.Forms.Label()
        Me.RegionL = New System.Windows.Forms.Label()
        Me.TSL = New System.Windows.Forms.Label()
        Me.TSV = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.EdadV = New System.Windows.Forms.Label()
        Me.añoActualLink = New System.Windows.Forms.LinkLabel()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.ActividadTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ActividadesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NuevaActividadTable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelSecundario.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.ActividadTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActividadesGrid
        '
        Me.ActividadesGrid.AllowUserToAddRows = False
        Me.ActividadesGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadesGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ActividadesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ActividadesGrid.BackgroundColor = System.Drawing.Color.White
        Me.ActividadesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActividadTable.SetColumnSpan(Me.ActividadesGrid, 2)
        Me.ActividadesGrid.Location = New System.Drawing.Point(467, 27)
        Me.ActividadesGrid.Name = "ActividadesGrid"
        Me.ActividadesGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadesGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ActividadesGrid.Size = New System.Drawing.Size(313, 544)
        Me.ActividadesGrid.TabIndex = 219
        Me.ActividadesGrid.Visible = False
        '
        'IDL
        '
        Me.IDL.AutoSize = True
        Me.IDL.Location = New System.Drawing.Point(408, 0)
        Me.IDL.Name = "IDL"
        Me.IDL.Size = New System.Drawing.Size(15, 16)
        Me.IDL.TabIndex = 221
        Me.IDL.Text = "0"
        Me.IDL.Visible = False
        '
        'ActividadesLink
        '
        Me.ActividadesLink.AutoSize = True
        Me.ActividadesLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadesLink.Location = New System.Drawing.Point(626, 0)
        Me.ActividadesLink.Name = "ActividadesLink"
        Me.ActividadesLink.Size = New System.Drawing.Size(137, 17)
        Me.ActividadesLink.TabIndex = 220
        Me.ActividadesLink.TabStop = True
        Me.ActividadesLink.Text = "Historial Actividades"
        '
        'HorMinL
        '
        Me.HorMinL.AutoSize = True
        Me.HorMinL.Location = New System.Drawing.Point(37, 5)
        Me.HorMinL.Name = "HorMinL"
        Me.HorMinL.Size = New System.Drawing.Size(12, 16)
        Me.HorMinL.TabIndex = 209
        Me.HorMinL.Text = ":"
        '
        'MinutosV
        '
        Me.MinutosV.Location = New System.Drawing.Point(54, 3)
        Me.MinutosV.Name = "MinutosV"
        Me.MinutosV.Size = New System.Drawing.Size(31, 22)
        Me.MinutosV.TabIndex = 2
        '
        'HoraV
        '
        Me.HoraV.Location = New System.Drawing.Point(3, 3)
        Me.HoraV.Name = "HoraV"
        Me.HoraV.Size = New System.Drawing.Size(31, 22)
        Me.HoraV.TabIndex = 1
        '
        'TipoCombo
        '
        Me.TipoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TipoCombo.FormattingEnabled = True
        Me.TipoCombo.Location = New System.Drawing.Point(62, 3)
        Me.TipoCombo.Name = "TipoCombo"
        Me.TipoCombo.Size = New System.Drawing.Size(334, 24)
        Me.TipoCombo.TabIndex = 1
        '
        'NuevaActL
        '
        Me.NuevaActL.AutoSize = True
        Me.NuevaActL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaActL.Location = New System.Drawing.Point(3, 0)
        Me.NuevaActL.Name = "NuevaActL"
        Me.NuevaActL.Size = New System.Drawing.Size(110, 17)
        Me.NuevaActL.TabIndex = 221
        Me.NuevaActL.TabStop = True
        Me.NuevaActL.Text = "Nueva Actividad"
        '
        'NuevaActividadTable
        '
        Me.NuevaActividadTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevaActividadTable.BackColor = System.Drawing.Color.PowderBlue
        Me.NuevaActividadTable.ColumnCount = 2
        Me.NuevaActividadTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NuevaActividadTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NuevaActividadTable.Controls.Add(Me.TipoCombo, 1, 0)
        Me.NuevaActividadTable.Controls.Add(Me.NotasV, 1, 3)
        Me.NuevaActividadTable.Controls.Add(Me.NotasL, 0, 3)
        Me.NuevaActividadTable.Controls.Add(Me.tipoL, 0, 0)
        Me.NuevaActividadTable.Controls.Add(Me.FechaPicker, 1, 1)
        Me.NuevaActividadTable.Controls.Add(Me.Panel1, 1, 2)
        Me.NuevaActividadTable.Controls.Add(Me.fechaL, 0, 1)
        Me.NuevaActividadTable.Controls.Add(Me.HoraL, 0, 2)
        Me.NuevaActividadTable.Location = New System.Drawing.Point(3, 27)
        Me.NuevaActividadTable.Name = "NuevaActividadTable"
        Me.NuevaActividadTable.RowCount = 4
        Me.NuevaActividadTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.NuevaActividadTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.NuevaActividadTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.NuevaActividadTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.NuevaActividadTable.Size = New System.Drawing.Size(399, 140)
        Me.NuevaActividadTable.TabIndex = 209
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Location = New System.Drawing.Point(62, 101)
        Me.NotasV.MaxLength = 120
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(334, 22)
        Me.NotasV.TabIndex = 218
        '
        'NotasL
        '
        Me.NotasL.AutoSize = True
        Me.NotasL.Location = New System.Drawing.Point(3, 98)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(46, 16)
        Me.NotasL.TabIndex = 217
        Me.NotasL.Text = "Notas:"
        '
        'tipoL
        '
        Me.tipoL.AutoSize = True
        Me.tipoL.Location = New System.Drawing.Point(3, 0)
        Me.tipoL.Name = "tipoL"
        Me.tipoL.Size = New System.Drawing.Size(41, 16)
        Me.tipoL.TabIndex = 0
        Me.tipoL.Text = "*Tipo:"
        '
        'FechaPicker
        '
        Me.FechaPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaPicker.Location = New System.Drawing.Point(62, 33)
        Me.FechaPicker.Name = "FechaPicker"
        Me.FechaPicker.Size = New System.Drawing.Size(334, 22)
        Me.FechaPicker.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.HorMinL)
        Me.Panel1.Controls.Add(Me.MinutosV)
        Me.Panel1.Controls.Add(Me.HoraV)
        Me.Panel1.Location = New System.Drawing.Point(62, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 34)
        Me.Panel1.TabIndex = 216
        '
        'fechaL
        '
        Me.fechaL.AutoSize = True
        Me.fechaL.Location = New System.Drawing.Point(3, 30)
        Me.fechaL.Name = "fechaL"
        Me.fechaL.Size = New System.Drawing.Size(53, 16)
        Me.fechaL.TabIndex = 214
        Me.fechaL.Text = "*Fecha:"
        '
        'HoraL
        '
        Me.HoraL.AutoSize = True
        Me.HoraL.Location = New System.Drawing.Point(3, 58)
        Me.HoraL.Name = "HoraL"
        Me.HoraL.Size = New System.Drawing.Size(44, 16)
        Me.HoraL.TabIndex = 215
        Me.HoraL.Text = "*Hora:"
        '
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 9
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.Controls.Add(Me.RegionV, 8, 0)
        Me.PanelSecundario.Controls.Add(Me.RegionL, 7, 0)
        Me.PanelSecundario.Controls.Add(Me.TSL, 4, 0)
        Me.PanelSecundario.Controls.Add(Me.TSV, 5, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.EdadV, 2, 0)
        Me.PanelSecundario.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 156)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 1
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.Size = New System.Drawing.Size(783, 25)
        Me.PanelSecundario.TabIndex = 234
        Me.PanelSecundario.Visible = False
        '
        'RegionV
        '
        Me.RegionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegionV.AutoSize = True
        Me.RegionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionV.ForeColor = System.Drawing.Color.Black
        Me.RegionV.Location = New System.Drawing.Point(765, 0)
        Me.RegionV.Name = "RegionV"
        Me.RegionV.Size = New System.Drawing.Size(15, 16)
        Me.RegionV.TabIndex = 209
        Me.RegionV.Text = "_"
        '
        'RegionL
        '
        Me.RegionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegionL.AutoSize = True
        Me.RegionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegionL.Location = New System.Drawing.Point(707, 0)
        Me.RegionL.Name = "RegionL"
        Me.RegionL.Size = New System.Drawing.Size(52, 16)
        Me.RegionL.TabIndex = 210
        Me.RegionL.Text = "Región:"
        Me.RegionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TSL
        '
        Me.TSL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSL.AutoSize = True
        Me.TSL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSL.Location = New System.Drawing.Point(622, 0)
        Me.TSL.Name = "TSL"
        Me.TSL.Size = New System.Drawing.Size(28, 16)
        Me.TSL.TabIndex = 209
        Me.TSL.Text = "TS:"
        Me.TSL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TSV
        '
        Me.TSV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSV.AutoSize = True
        Me.TSV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSV.ForeColor = System.Drawing.Color.Black
        Me.TSV.Location = New System.Drawing.Point(656, 0)
        Me.TSV.Name = "TSV"
        Me.TSV.Size = New System.Drawing.Size(15, 16)
        Me.TSV.TabIndex = 208
        Me.TSV.Text = "_"
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(57, 16)
        Me.NombreL.TabIndex = 1
        Me.NombreL.Text = "Nombre:"
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NombreV.Location = New System.Drawing.Point(66, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(15, 16)
        Me.NombreV.TabIndex = 2
        Me.NombreV.Text = "_"
        '
        'EdadV
        '
        Me.EdadV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdadV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EdadV.Location = New System.Drawing.Point(87, 0)
        Me.EdadV.Name = "EdadV"
        Me.EdadV.Size = New System.Drawing.Size(585, 20)
        Me.EdadV.TabIndex = 198
        '
        'añoActualLink
        '
        Me.añoActualLink.AutoSize = True
        Me.añoActualLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.añoActualLink.Location = New System.Drawing.Point(467, 0)
        Me.añoActualLink.Name = "añoActualLink"
        Me.añoActualLink.Size = New System.Drawing.Size(141, 17)
        Me.añoActualLink.TabIndex = 221
        Me.añoActualLink.TabStop = True
        Me.añoActualLink.Text = "Actividades Actuales"
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.PrincipalPanel.ColumnCount = 5
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(783, 36)
        Me.PrincipalPanel.TabIndex = 233
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(94, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(127, 29)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(649, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(127, 29)
        Me.MiembroV.TabIndex = 204
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Location = New System.Drawing.Point(549, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(94, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Miembro:"
        Me.PacienteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(85, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ActividadTable
        '
        Me.ActividadTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadTable.BackColor = System.Drawing.Color.Transparent
        Me.ActividadTable.ColumnCount = 5
        Me.ActividadTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 405.0!))
        Me.ActividadTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ActividadTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.68304!))
        Me.ActividadTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.15848!))
        Me.ActividadTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.15848!))
        Me.ActividadTable.Controls.Add(Me.añoActualLink, 3, 0)
        Me.ActividadTable.Controls.Add(Me.NuevaActL, 0, 0)
        Me.ActividadTable.Controls.Add(Me.NuevaActividadTable, 0, 1)
        Me.ActividadTable.Controls.Add(Me.ActividadesGrid, 3, 1)
        Me.ActividadTable.Controls.Add(Me.IDL, 2, 0)
        Me.ActividadTable.Controls.Add(Me.ActividadesLink, 4, 0)
        Me.ActividadTable.Location = New System.Drawing.Point(0, 186)
        Me.ActividadTable.Name = "ActividadTable"
        Me.ActividadTable.RowCount = 2
        Me.ActividadTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ActividadTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ActividadTable.Size = New System.Drawing.Size(783, 574)
        Me.ActividadTable.TabIndex = 235
        Me.ActividadTable.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 251
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
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(582, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(531, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(637, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 236
        Me.GuardarButton.UseVisualStyleBackColor = False
        Me.GuardarButton.Visible = False
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
        Me.Title.Size = New System.Drawing.Size(520, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Actividades de Apoyo Educativo"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActividadesAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.ActividadTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActividadesAE"
        Me.Text = "Actividades Apoyo Educativo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ActividadesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NuevaActividadTable.ResumeLayout(False)
        Me.NuevaActividadTable.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.ActividadTable.ResumeLayout(False)
        Me.ActividadTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ActividadesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ActividadTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents añoActualLink As System.Windows.Forms.LinkLabel
    Friend WithEvents NuevaActL As System.Windows.Forms.LinkLabel
    Friend WithEvents NuevaActividadTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TipoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents tipoL As System.Windows.Forms.Label
    Friend WithEvents FechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HorMinL As System.Windows.Forms.Label
    Friend WithEvents MinutosV As System.Windows.Forms.TextBox
    Friend WithEvents HoraV As System.Windows.Forms.TextBox
    Friend WithEvents fechaL As System.Windows.Forms.Label
    Friend WithEvents HoraL As System.Windows.Forms.Label
    Friend WithEvents IDL As System.Windows.Forms.Label
    Friend WithEvents ActividadesLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionV As System.Windows.Forms.Label
    Friend WithEvents RegionL As System.Windows.Forms.Label
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents TSV As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents EdadV As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
