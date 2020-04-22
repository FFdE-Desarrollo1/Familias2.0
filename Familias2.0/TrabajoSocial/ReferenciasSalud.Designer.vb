<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReferenciasSalud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReferenciasSalud))
        Me.FamiliaV = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.DescripcionL = New System.Windows.Forms.Label()
        Me.DescripcionV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsObserV = New System.Windows.Forms.TextBox()
        Me.CategoriaL = New System.Windows.Forms.Label()
        Me.ReferenciaL = New System.Windows.Forms.Label()
        Me.ReferidoPorL = New System.Windows.Forms.Label()
        Me.ReferidoPorV = New System.Windows.Forms.Label()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.EstadoCombo = New System.Windows.Forms.ComboBox()
        Me.ReferenciaV = New System.Windows.Forms.Label()
        Me.CategoriaV = New System.Windows.Forms.Label()
        Me.InfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.PrincipalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RegionV = New System.Windows.Forms.ComboBox()
        Me.TSL = New System.Windows.Forms.Label()
        Me.RegionL = New System.Windows.Forms.Label()
        Me.TSlist = New System.Windows.Forms.ComboBox()
        Me.EstadoSelCombo = New System.Windows.Forms.ComboBox()
        Me.EstadoSelL = New System.Windows.Forms.Label()
        Me.ListadoPorEstadoButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.InfoTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrincipalTable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'FamiliaV
        '
        Me.FamiliaV.AutoSize = True
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.Location = New System.Drawing.Point(672, 0)
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(21, 22)
        Me.FamiliaV.TabIndex = 242
        Me.FamiliaV.Text = "_"
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(591, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(75, 22)
        Me.FamiliaL.TabIndex = 241
        Me.FamiliaL.Text = "Familia:"
        '
        'NombreL
        '
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(57, 16)
        Me.NombreL.TabIndex = 239
        Me.NombreL.Text = "Nombre:"
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.InfoTable.SetColumnSpan(Me.NombreV, 6)
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.Location = New System.Drawing.Point(89, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(392, 16)
        Me.NombreV.TabIndex = 240
        Me.NombreV.Text = "_"
        '
        'DescripcionL
        '
        Me.DescripcionL.AutoSize = True
        Me.DescripcionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionL.Location = New System.Drawing.Point(3, 57)
        Me.DescripcionL.Name = "DescripcionL"
        Me.DescripcionL.Size = New System.Drawing.Size(80, 16)
        Me.DescripcionL.TabIndex = 231
        Me.DescripcionL.Text = "Descripción:"
        '
        'DescripcionV
        '
        Me.DescripcionV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTable.SetColumnSpan(Me.DescripcionV, 5)
        Me.DescripcionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionV.Location = New System.Drawing.Point(89, 60)
        Me.DescripcionV.Multiline = True
        Me.DescripcionV.Name = "DescripcionV"
        Me.DescripcionV.ReadOnly = True
        Me.DescripcionV.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DescripcionV.Size = New System.Drawing.Size(281, 96)
        Me.DescripcionV.TabIndex = 238
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 243
        Me.Label1.Text = "Comentarios TS:"
        '
        'tsObserV
        '
        Me.tsObserV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTable.SetColumnSpan(Me.tsObserV, 4)
        Me.tsObserV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsObserV.Location = New System.Drawing.Point(487, 60)
        Me.tsObserV.MaxLength = 999
        Me.tsObserV.Multiline = True
        Me.tsObserV.Name = "tsObserV"
        Me.tsObserV.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tsObserV.Size = New System.Drawing.Size(280, 96)
        Me.tsObserV.TabIndex = 244
        '
        'CategoriaL
        '
        Me.CategoriaL.AutoSize = True
        Me.CategoriaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaL.Location = New System.Drawing.Point(3, 27)
        Me.CategoriaL.Name = "CategoriaL"
        Me.CategoriaL.Size = New System.Drawing.Size(67, 16)
        Me.CategoriaL.TabIndex = 230
        Me.CategoriaL.Text = "Categoria:"
        '
        'ReferenciaL
        '
        Me.ReferenciaL.AutoSize = True
        Me.ReferenciaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenciaL.Location = New System.Drawing.Point(193, 27)
        Me.ReferenciaL.Name = "ReferenciaL"
        Me.ReferenciaL.Size = New System.Drawing.Size(73, 16)
        Me.ReferenciaL.TabIndex = 229
        Me.ReferenciaL.Text = "Referencia:"
        '
        'ReferidoPorL
        '
        Me.ReferidoPorL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferidoPorL.AutoSize = True
        Me.ReferidoPorL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferidoPorL.Location = New System.Drawing.Point(376, 27)
        Me.ReferidoPorL.Name = "ReferidoPorL"
        Me.ReferidoPorL.Size = New System.Drawing.Size(105, 16)
        Me.ReferidoPorL.TabIndex = 233
        Me.ReferidoPorL.Text = "Referido Por:"
        '
        'ReferidoPorV
        '
        Me.ReferidoPorV.AutoSize = True
        Me.ReferidoPorV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferidoPorV.Location = New System.Drawing.Point(487, 27)
        Me.ReferidoPorV.Name = "ReferidoPorV"
        Me.ReferidoPorV.Size = New System.Drawing.Size(15, 16)
        Me.ReferidoPorV.TabIndex = 235
        Me.ReferidoPorV.Text = "_"
        '
        'EstadoL
        '
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoL.Location = New System.Drawing.Point(591, 27)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(54, 16)
        Me.EstadoL.TabIndex = 232
        Me.EstadoL.Text = "Estado:"
        '
        'EstadoCombo
        '
        Me.EstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoCombo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoCombo.FormattingEnabled = True
        Me.EstadoCombo.Location = New System.Drawing.Point(672, 30)
        Me.EstadoCombo.Name = "EstadoCombo"
        Me.EstadoCombo.Size = New System.Drawing.Size(95, 25)
        Me.EstadoCombo.TabIndex = 237
        '
        'ReferenciaV
        '
        Me.ReferenciaV.AutoSize = True
        Me.ReferenciaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenciaV.Location = New System.Drawing.Point(272, 27)
        Me.ReferenciaV.Name = "ReferenciaV"
        Me.ReferenciaV.Size = New System.Drawing.Size(15, 16)
        Me.ReferenciaV.TabIndex = 234
        Me.ReferenciaV.Text = "_"
        '
        'CategoriaV
        '
        Me.CategoriaV.AutoSize = True
        Me.CategoriaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaV.Location = New System.Drawing.Point(89, 27)
        Me.CategoriaV.Name = "CategoriaV"
        Me.CategoriaV.Size = New System.Drawing.Size(15, 16)
        Me.CategoriaV.TabIndex = 236
        Me.CategoriaV.Text = "_"
        '
        'InfoTable
        '
        Me.InfoTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTable.BackColor = System.Drawing.Color.Transparent
        Me.InfoTable.ColumnCount = 11
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80884!))
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80884!))
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80884!))
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57347!))
        Me.InfoTable.Controls.Add(Me.FamiliaV, 10, 0)
        Me.InfoTable.Controls.Add(Me.FamiliaL, 9, 0)
        Me.InfoTable.Controls.Add(Me.NombreL, 0, 0)
        Me.InfoTable.Controls.Add(Me.NombreV, 1, 0)
        Me.InfoTable.Controls.Add(Me.DescripcionL, 0, 3)
        Me.InfoTable.Controls.Add(Me.DescripcionV, 1, 3)
        Me.InfoTable.Controls.Add(Me.Label1, 6, 3)
        Me.InfoTable.Controls.Add(Me.tsObserV, 7, 3)
        Me.InfoTable.Controls.Add(Me.CategoriaL, 0, 2)
        Me.InfoTable.Controls.Add(Me.ReferenciaL, 3, 2)
        Me.InfoTable.Controls.Add(Me.ReferidoPorL, 6, 2)
        Me.InfoTable.Controls.Add(Me.ReferidoPorV, 7, 2)
        Me.InfoTable.Controls.Add(Me.EstadoL, 9, 2)
        Me.InfoTable.Controls.Add(Me.EstadoCombo, 10, 2)
        Me.InfoTable.Controls.Add(Me.ReferenciaV, 4, 2)
        Me.InfoTable.Controls.Add(Me.CategoriaV, 1, 2)
        Me.InfoTable.Location = New System.Drawing.Point(1, 8)
        Me.InfoTable.Name = "InfoTable"
        Me.InfoTable.RowCount = 4
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoTable.Size = New System.Drawing.Size(770, 159)
        Me.InfoTable.TabIndex = 228
        Me.InfoTable.Visible = False
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
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        Me.ListadoGrid.RowHeadersWidth = 55
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoGrid.Size = New System.Drawing.Size(778, 390)
        Me.ListadoGrid.TabIndex = 228
        '
        'PrincipalTable
        '
        Me.PrincipalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalTable.BackColor = System.Drawing.Color.Transparent
        Me.PrincipalTable.ColumnCount = 1
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalTable.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.PrincipalTable.Controls.Add(Me.Panel1, 0, 2)
        Me.PrincipalTable.Location = New System.Drawing.Point(0, 151)
        Me.PrincipalTable.Name = "PrincipalTable"
        Me.PrincipalTable.RowCount = 3
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.PrincipalTable.Size = New System.Drawing.Size(784, 606)
        Me.PrincipalTable.TabIndex = 247
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.InfoTable)
        Me.Panel1.Location = New System.Drawing.Point(3, 429)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 174)
        Me.Panel1.TabIndex = 229
        Me.Panel1.Visible = False
        '
        'RegionV
        '
        Me.RegionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionV.FormattingEnabled = True
        Me.RegionV.Items.AddRange(New Object() {"", "I", "II"})
        Me.RegionV.Location = New System.Drawing.Point(61, 3)
        Me.RegionV.Name = "RegionV"
        Me.RegionV.Size = New System.Drawing.Size(67, 24)
        Me.RegionV.TabIndex = 251
        Me.RegionV.Visible = False
        '
        'TSL
        '
        Me.TSL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSL.AutoSize = True
        Me.TSL.BackColor = System.Drawing.Color.Transparent
        Me.TSL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSL.Location = New System.Drawing.Point(154, 0)
        Me.TSL.Name = "TSL"
        Me.TSL.Size = New System.Drawing.Size(28, 31)
        Me.TSL.TabIndex = 226
        Me.TSL.Text = "TS:"
        Me.TSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RegionL
        '
        Me.RegionL.AutoSize = True
        Me.RegionL.BackColor = System.Drawing.Color.Transparent
        Me.RegionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionL.Location = New System.Drawing.Point(3, 0)
        Me.RegionL.Name = "RegionL"
        Me.RegionL.Size = New System.Drawing.Size(52, 16)
        Me.RegionL.TabIndex = 252
        Me.RegionL.Text = "Región:"
        Me.RegionL.Visible = False
        '
        'TSlist
        '
        Me.TSlist.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSlist.FormattingEnabled = True
        Me.TSlist.Location = New System.Drawing.Point(188, 3)
        Me.TSlist.Name = "TSlist"
        Me.TSlist.Size = New System.Drawing.Size(121, 24)
        Me.TSlist.TabIndex = 224
        '
        'EstadoSelCombo
        '
        Me.EstadoSelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoSelCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoSelCombo.FormattingEnabled = True
        Me.EstadoSelCombo.Location = New System.Drawing.Point(564, 3)
        Me.EstadoSelCombo.Name = "EstadoSelCombo"
        Me.EstadoSelCombo.Size = New System.Drawing.Size(121, 24)
        Me.EstadoSelCombo.TabIndex = 227
        '
        'EstadoSelL
        '
        Me.EstadoSelL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoSelL.AutoSize = True
        Me.EstadoSelL.BackColor = System.Drawing.Color.Transparent
        Me.EstadoSelL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoSelL.Location = New System.Drawing.Point(446, 0)
        Me.EstadoSelL.Name = "EstadoSelL"
        Me.EstadoSelL.Size = New System.Drawing.Size(112, 31)
        Me.EstadoSelL.TabIndex = 228
        Me.EstadoSelL.Text = "Filtrar por Estado:"
        Me.EstadoSelL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListadoPorEstadoButton
        '
        Me.ListadoPorEstadoButton.AutoSize = True
        Me.ListadoPorEstadoButton.Location = New System.Drawing.Point(691, 3)
        Me.ListadoPorEstadoButton.Name = "ListadoPorEstadoButton"
        Me.ListadoPorEstadoButton.Size = New System.Drawing.Size(90, 25)
        Me.ListadoPorEstadoButton.TabIndex = 229
        Me.ListadoPorEstadoButton.Text = "Ver Listado"
        Me.ListadoPorEstadoButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RegionV, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TSL, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RegionL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TSlist, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoSelCombo, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoSelL, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListadoPorEstadoButton, 8, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 119)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 31)
        Me.TableLayoutPanel1.TabIndex = 246
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 258
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 3
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 2, 0)
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
        Me.inicioButton.Location = New System.Drawing.Point(586, 3)
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
        Me.Title.Size = New System.Drawing.Size(575, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Listado de Miembros con Referencia Médica"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReferenciasSalud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PrincipalTable)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReferenciasSalud"
        Me.Text = "Referencias Salud - TS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.InfoTable.ResumeLayout(False)
        Me.InfoTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrincipalTable.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FamiliaV As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents InfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DescripcionL As System.Windows.Forms.Label
    Friend WithEvents DescripcionV As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsObserV As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaL As System.Windows.Forms.Label
    Friend WithEvents ReferenciaL As System.Windows.Forms.Label
    Friend WithEvents ReferidoPorL As System.Windows.Forms.Label
    Friend WithEvents ReferidoPorV As System.Windows.Forms.Label
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents EstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ReferenciaV As System.Windows.Forms.Label
    Friend WithEvents CategoriaV As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PrincipalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RegionV As System.Windows.Forms.ComboBox
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents RegionL As System.Windows.Forms.Label
    Friend WithEvents TSlist As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoSelCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoSelL As System.Windows.Forms.Label
    Friend WithEvents ListadoPorEstadoButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
