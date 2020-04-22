<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenAJ
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResumenAJ))
        Me.AvisosGrid = New System.Windows.Forms.DataGridView()
        Me.GridsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.AvisosL = New System.Windows.Forms.Label()
        Me.ListGrid = New System.Windows.Forms.DataGridView()
        Me.verDetalle = New System.Windows.Forms.CheckBox()
        Me.RegionL = New System.Windows.Forms.Label()
        Me.GradoV = New System.Windows.Forms.Label()
        Me.RegionV = New System.Windows.Forms.Label()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.EdadV = New System.Windows.Forms.Label()
        Me.FaseV = New System.Windows.Forms.Label()
        Me.FaseL = New System.Windows.Forms.Label()
        Me.semaforoV = New System.Windows.Forms.Label()
        Me.semaforoL = New System.Windows.Forms.Label()
        Me.TSV = New System.Windows.Forms.Label()
        Me.TSL = New System.Windows.Forms.Label()
        Me.ClasificacionL = New System.Windows.Forms.Label()
        Me.ClasificacionV = New System.Windows.Forms.Label()
        Me.TipoMiembroL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridsTable.SuspendLayout()
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSecundario.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AvisosGrid
        '
        Me.AvisosGrid.AllowUserToAddRows = False
        Me.AvisosGrid.AllowUserToDeleteRows = False
        Me.AvisosGrid.AllowUserToResizeColumns = False
        Me.AvisosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AvisosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvisosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AvisosGrid.BackgroundColor = System.Drawing.Color.White
        Me.AvisosGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvisosGrid.CausesValidation = False
        Me.AvisosGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.AvisosGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.AvisosGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvisosGrid.ColumnHeadersVisible = False
        Me.AvisosGrid.GridColor = System.Drawing.Color.White
        Me.AvisosGrid.Location = New System.Drawing.Point(498, 30)
        Me.AvisosGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.AvisosGrid.MultiSelect = False
        Me.AvisosGrid.Name = "AvisosGrid"
        Me.AvisosGrid.ReadOnly = True
        Me.AvisosGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AvisosGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.RowHeadersVisible = False
        Me.AvisosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy
        Me.AvisosGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.AvisosGrid.RowTemplate.ReadOnly = True
        Me.AvisosGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.AvisosGrid.ShowEditingIcon = False
        Me.AvisosGrid.Size = New System.Drawing.Size(282, 522)
        Me.AvisosGrid.TabIndex = 242
        Me.AvisosGrid.Visible = False
        '
        'GridsTable
        '
        Me.GridsTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridsTable.BackColor = System.Drawing.Color.Transparent
        Me.GridsTable.ColumnCount = 3
        Me.GridsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GridsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GridsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GridsTable.Controls.Add(Me.AvisosL, 2, 0)
        Me.GridsTable.Controls.Add(Me.ListGrid, 0, 1)
        Me.GridsTable.Controls.Add(Me.verDetalle, 0, 0)
        Me.GridsTable.Controls.Add(Me.AvisosGrid, 2, 1)
        Me.GridsTable.Location = New System.Drawing.Point(0, 203)
        Me.GridsTable.Name = "GridsTable"
        Me.GridsTable.RowCount = 2
        Me.GridsTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GridsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GridsTable.Size = New System.Drawing.Size(784, 556)
        Me.GridsTable.TabIndex = 246
        '
        'AvisosL
        '
        Me.AvisosL.AutoSize = True
        Me.AvisosL.BackColor = System.Drawing.Color.MediumBlue
        Me.AvisosL.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvisosL.ForeColor = System.Drawing.Color.White
        Me.AvisosL.Location = New System.Drawing.Point(498, 0)
        Me.AvisosL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AvisosL.Name = "AvisosL"
        Me.AvisosL.Size = New System.Drawing.Size(105, 20)
        Me.AvisosL.TabIndex = 243
        Me.AvisosL.Text = "Avisos Familiares"
        Me.AvisosL.Visible = False
        '
        'ListGrid
        '
        Me.ListGrid.AllowUserToAddRows = False
        Me.ListGrid.AllowUserToDeleteRows = False
        Me.ListGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListGrid.Location = New System.Drawing.Point(3, 29)
        Me.ListGrid.Name = "ListGrid"
        Me.ListGrid.ReadOnly = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListGrid.Size = New System.Drawing.Size(468, 524)
        Me.ListGrid.TabIndex = 241
        Me.ListGrid.Visible = False
        '
        'verDetalle
        '
        Me.verDetalle.AutoSize = True
        Me.verDetalle.Location = New System.Drawing.Point(3, 3)
        Me.verDetalle.Name = "verDetalle"
        Me.verDetalle.Size = New System.Drawing.Size(88, 20)
        Me.verDetalle.TabIndex = 240
        Me.verDetalle.Text = "Ver detalle"
        Me.verDetalle.UseVisualStyleBackColor = True
        Me.verDetalle.Visible = False
        '
        'RegionL
        '
        Me.RegionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegionL.AutoSize = True
        Me.RegionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegionL.Location = New System.Drawing.Point(708, 17)
        Me.RegionL.Name = "RegionL"
        Me.RegionL.Size = New System.Drawing.Size(52, 16)
        Me.RegionL.TabIndex = 212
        Me.RegionL.Text = "Region:"
        Me.RegionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GradoV
        '
        Me.GradoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoV.AutoSize = True
        Me.GradoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoV.ForeColor = System.Drawing.Color.Black
        Me.GradoV.Location = New System.Drawing.Point(66, 17)
        Me.GradoV.Name = "GradoV"
        Me.GradoV.Size = New System.Drawing.Size(15, 16)
        Me.GradoV.TabIndex = 212
        Me.GradoV.Text = "_"
        Me.GradoV.Visible = False
        '
        'RegionV
        '
        Me.RegionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegionV.AutoSize = True
        Me.RegionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionV.ForeColor = System.Drawing.Color.Black
        Me.RegionV.Location = New System.Drawing.Point(766, 17)
        Me.RegionV.Name = "RegionV"
        Me.RegionV.Size = New System.Drawing.Size(15, 16)
        Me.RegionV.TabIndex = 211
        Me.RegionV.Text = "_"
        '
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 12
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.Controls.Add(Me.RegionL, 10, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoV, 1, 1)
        Me.PanelSecundario.Controls.Add(Me.RegionV, 11, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoL, 0, 1)
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.EdadV, 2, 0)
        Me.PanelSecundario.Controls.Add(Me.FaseV, 11, 0)
        Me.PanelSecundario.Controls.Add(Me.FaseL, 10, 0)
        Me.PanelSecundario.Controls.Add(Me.semaforoV, 8, 0)
        Me.PanelSecundario.Controls.Add(Me.semaforoL, 7, 0)
        Me.PanelSecundario.Controls.Add(Me.TSV, 8, 1)
        Me.PanelSecundario.Controls.Add(Me.TSL, 7, 1)
        Me.PanelSecundario.Controls.Add(Me.ClasificacionL, 4, 1)
        Me.PanelSecundario.Controls.Add(Me.ClasificacionV, 5, 1)
        Me.PanelSecundario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 156)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 2
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.Size = New System.Drawing.Size(784, 41)
        Me.PanelSecundario.TabIndex = 245
        Me.PanelSecundario.Visible = False
        '
        'GradoL
        '
        Me.GradoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoL.AutoSize = True
        Me.GradoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GradoL.Location = New System.Drawing.Point(3, 17)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(57, 16)
        Me.GradoL.TabIndex = 211
        Me.GradoL.Text = "Grado:"
        Me.GradoL.Visible = False
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
        Me.EdadV.AutoSize = True
        Me.EdadV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EdadV.Location = New System.Drawing.Point(87, 0)
        Me.EdadV.Name = "EdadV"
        Me.EdadV.Size = New System.Drawing.Size(1, 17)
        Me.EdadV.TabIndex = 198
        '
        'FaseV
        '
        Me.FaseV.AutoSize = True
        Me.FaseV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaseV.ForeColor = System.Drawing.Color.Black
        Me.FaseV.Location = New System.Drawing.Point(766, 0)
        Me.FaseV.Name = "FaseV"
        Me.FaseV.Size = New System.Drawing.Size(15, 16)
        Me.FaseV.TabIndex = 210
        Me.FaseV.Text = "_"
        '
        'FaseL
        '
        Me.FaseL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaseL.AutoSize = True
        Me.FaseL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaseL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FaseL.Location = New System.Drawing.Point(708, 0)
        Me.FaseL.Name = "FaseL"
        Me.FaseL.Size = New System.Drawing.Size(52, 16)
        Me.FaseL.TabIndex = 209
        Me.FaseL.Text = "Fase:"
        '
        'semaforoV
        '
        Me.semaforoV.AutoSize = True
        Me.semaforoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semaforoV.ForeColor = System.Drawing.Color.Black
        Me.semaforoV.Location = New System.Drawing.Point(667, 0)
        Me.semaforoV.Name = "semaforoV"
        Me.semaforoV.Size = New System.Drawing.Size(15, 16)
        Me.semaforoV.TabIndex = 202
        Me.semaforoV.Text = "_"
        '
        'semaforoL
        '
        Me.semaforoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.semaforoL.AutoSize = True
        Me.semaforoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semaforoL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.semaforoL.Location = New System.Drawing.Point(594, 0)
        Me.semaforoL.Name = "semaforoL"
        Me.semaforoL.Size = New System.Drawing.Size(67, 17)
        Me.semaforoL.TabIndex = 203
        Me.semaforoL.Text = "Semáforo:"
        '
        'TSV
        '
        Me.TSV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSV.AutoSize = True
        Me.TSV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSV.ForeColor = System.Drawing.Color.Black
        Me.TSV.Location = New System.Drawing.Point(667, 17)
        Me.TSV.Name = "TSV"
        Me.TSV.Size = New System.Drawing.Size(15, 16)
        Me.TSV.TabIndex = 208
        Me.TSV.Text = "_"
        '
        'TSL
        '
        Me.TSL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSL.AutoSize = True
        Me.TSL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TSL.Location = New System.Drawing.Point(594, 17)
        Me.TSL.Name = "TSL"
        Me.TSL.Size = New System.Drawing.Size(67, 16)
        Me.TSL.TabIndex = 209
        Me.TSL.Text = "TS:"
        Me.TSL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ClasificacionL
        '
        Me.ClasificacionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionL.AutoSize = True
        Me.ClasificacionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClasificacionL.Location = New System.Drawing.Point(462, 17)
        Me.ClasificacionL.Name = "ClasificacionL"
        Me.ClasificacionL.Size = New System.Drawing.Size(85, 16)
        Me.ClasificacionL.TabIndex = 208
        Me.ClasificacionL.Text = "Clasificación:"
        '
        'ClasificacionV
        '
        Me.ClasificacionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionV.AutoSize = True
        Me.ClasificacionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionV.ForeColor = System.Drawing.Color.Black
        Me.ClasificacionV.Location = New System.Drawing.Point(553, 17)
        Me.ClasificacionV.Name = "ClasificacionV"
        Me.ClasificacionV.Size = New System.Drawing.Size(15, 16)
        Me.ClasificacionV.TabIndex = 209
        Me.ClasificacionV.Text = "_"
        '
        'TipoMiembroL
        '
        Me.TipoMiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMiembroL.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMiembroL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipoMiembroL.Location = New System.Drawing.Point(221, 0)
        Me.TipoMiembroL.Name = "TipoMiembroL"
        Me.TipoMiembroL.Size = New System.Drawing.Size(332, 36)
        Me.TipoMiembroL.TabIndex = 200
        Me.TipoMiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(92, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.LightBlue
        Me.PrincipalPanel.ColumnCount = 5
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.TipoMiembroL, 2, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 36)
        Me.PrincipalPanel.TabIndex = 244
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(101, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 29)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(667, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(112, 29)
        Me.MiembroV.TabIndex = 204
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(559, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(102, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Miembro:"
        Me.PacienteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 254
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
        Me.TableLayoutPanel1.Controls.Add(Me.NuevoButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 53)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(636, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(585, 3)
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
        Me.Title.Size = New System.Drawing.Size(574, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Resumen Apoyo a Jóvenes"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResumenAJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.GridsTable)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ResumenAJ"
        Me.Text = "Resumen AJ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridsTable.ResumeLayout(False)
        Me.GridsTable.PerformLayout()
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AvisosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GridsTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AvisosL As System.Windows.Forms.Label
    Friend WithEvents ListGrid As System.Windows.Forms.DataGridView
    Friend WithEvents verDetalle As System.Windows.Forms.CheckBox
    Friend WithEvents RegionL As System.Windows.Forms.Label
    Friend WithEvents GradoV As System.Windows.Forms.Label
    Friend WithEvents RegionV As System.Windows.Forms.Label
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents EdadV As System.Windows.Forms.Label
    Friend WithEvents FaseV As System.Windows.Forms.Label
    Friend WithEvents FaseL As System.Windows.Forms.Label
    Friend WithEvents semaforoV As System.Windows.Forms.Label
    Friend WithEvents semaforoL As System.Windows.Forms.Label
    Friend WithEvents TSV As System.Windows.Forms.Label
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents ClasificacionL As System.Windows.Forms.Label
    Friend WithEvents ClasificacionV As System.Windows.Forms.Label
    Friend WithEvents TipoMiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
