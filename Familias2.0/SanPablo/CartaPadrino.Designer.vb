<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartaPadrino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CartaPadrino))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDocumentBoleta = New System.Drawing.Printing.PrintDocument()
        Me.NombreSV = New System.Windows.Forms.TextBox()
        Me.NombreSL = New System.Windows.Forms.Label()
        Me.PadrinoL = New System.Windows.Forms.Label()
        Me.PadrinoV = New System.Windows.Forms.TextBox()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialogBoleta = New System.Windows.Forms.PrintPreviewDialog()
        Me.opcionesBusquedaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.indicacionesL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.CandidatosGrid = New System.Windows.Forms.DataGridView()
        Me.ahijadosPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.fechaEnvioL = New System.Windows.Forms.Label()
        Me.FechaEnvioPicker = New System.Windows.Forms.DateTimePicker()
        Me.ListaGrid = New System.Windows.Forms.DataGridView()
        Me.Seleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MiembrosL = New System.Windows.Forms.Label()
        Me.pImprimirGrid = New System.Windows.Forms.DataGridView()
        Me._etiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opcionesBusquedaTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.principalTable.SuspendLayout()
        CType(Me.CandidatosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ahijadosPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ListaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pImprimirGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocumentBoleta
        '
        '
        'NombreSV
        '
        Me.opcionesBusquedaTable.SetColumnSpan(Me.NombreSV, 4)
        Me.NombreSV.Location = New System.Drawing.Point(122, 31)
        Me.NombreSV.MaxLength = 80
        Me.NombreSV.Name = "NombreSV"
        Me.NombreSV.Size = New System.Drawing.Size(400, 22)
        Me.NombreSV.TabIndex = 247
        '
        'NombreSL
        '
        Me.NombreSL.AutoSize = True
        Me.NombreSL.Location = New System.Drawing.Point(3, 28)
        Me.NombreSL.Name = "NombreSL"
        Me.NombreSL.Size = New System.Drawing.Size(113, 16)
        Me.NombreSL.TabIndex = 245
        Me.NombreSL.Text = "  Sponsor Names:"
        '
        'PadrinoL
        '
        Me.PadrinoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PadrinoL.AutoSize = True
        Me.PadrinoL.Location = New System.Drawing.Point(3, 0)
        Me.PadrinoL.Name = "PadrinoL"
        Me.PadrinoL.Size = New System.Drawing.Size(82, 28)
        Me.PadrinoL.TabIndex = 0
        Me.PadrinoL.Text = "  Sponsor Id:"
        Me.PadrinoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PadrinoV
        '
        Me.PadrinoV.Location = New System.Drawing.Point(122, 3)
        Me.PadrinoV.Name = "PadrinoV"
        Me.PadrinoV.Size = New System.Drawing.Size(100, 22)
        Me.PadrinoV.TabIndex = 1
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Location = New System.Drawing.Point(263, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(201, 28)
        Me.MiembroL.TabIndex = 247
        Me.MiembroL.Text = "Site + Member Id: (Example F14)"
        Me.MiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiembroV
        '
        Me.MiembroV.Location = New System.Drawing.Point(470, 3)
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(100, 22)
        Me.MiembroV.TabIndex = 248
        '
        'L1
        '
        Me.L1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(228, 0)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(23, 28)
        Me.L1.TabIndex = 249
        Me.L1.Text = "or"
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintPreviewDialogBoleta
        '
        Me.PrintPreviewDialogBoleta.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogBoleta.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogBoleta.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogBoleta.Enabled = True
        Me.PrintPreviewDialogBoleta.Icon = CType(resources.GetObject("PrintPreviewDialogBoleta.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogBoleta.Name = "PrintPreviewDialogReceta"
        Me.PrintPreviewDialogBoleta.Visible = False
        '
        'opcionesBusquedaTable
        '
        Me.opcionesBusquedaTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesBusquedaTable.BackColor = System.Drawing.Color.AliceBlue
        Me.opcionesBusquedaTable.ColumnCount = 6
        Me.opcionesBusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesBusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesBusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.opcionesBusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesBusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesBusquedaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281.0!))
        Me.opcionesBusquedaTable.Controls.Add(Me.NombreSV, 1, 1)
        Me.opcionesBusquedaTable.Controls.Add(Me.NombreSL, 0, 1)
        Me.opcionesBusquedaTable.Controls.Add(Me.PadrinoL, 0, 0)
        Me.opcionesBusquedaTable.Controls.Add(Me.PadrinoV, 1, 0)
        Me.opcionesBusquedaTable.Controls.Add(Me.MiembroL, 3, 0)
        Me.opcionesBusquedaTable.Controls.Add(Me.MiembroV, 4, 0)
        Me.opcionesBusquedaTable.Controls.Add(Me.L1, 2, 0)
        Me.opcionesBusquedaTable.Controls.Add(Me.indicacionesL, 5, 0)
        Me.opcionesBusquedaTable.Location = New System.Drawing.Point(0, 124)
        Me.opcionesBusquedaTable.Name = "opcionesBusquedaTable"
        Me.opcionesBusquedaTable.RowCount = 2
        Me.opcionesBusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.opcionesBusquedaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.opcionesBusquedaTable.Size = New System.Drawing.Size(784, 67)
        Me.opcionesBusquedaTable.TabIndex = 248
        '
        'indicacionesL
        '
        Me.indicacionesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicacionesL.AutoSize = True
        Me.indicacionesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicacionesL.ForeColor = System.Drawing.Color.OrangeRed
        Me.indicacionesL.Location = New System.Drawing.Point(576, 0)
        Me.indicacionesL.Name = "indicacionesL"
        Me.indicacionesL.Size = New System.Drawing.Size(151, 28)
        Me.indicacionesL.TabIndex = 250
        Me.indicacionesL.Text = "You need enter only one!"
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.White
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
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GuardarButton.Location = New System.Drawing.Point(636, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(49, 44)
        Me.GuardarButton.TabIndex = 71
        Me.GuardarButton.UseVisualStyleBackColor = False
        Me.GuardarButton.Visible = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(530, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 45)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(581, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(49, 44)
        Me.NuevoButton.TabIndex = 236
        Me.NuevoButton.UseVisualStyleBackColor = False
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
        Me.Title.Size = New System.Drawing.Size(519, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Letters Written by Sponsors"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 2
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.principalTable.Controls.Add(Me.CandidatosGrid, 0, 0)
        Me.principalTable.Controls.Add(Me.ahijadosPanel, 0, 0)
        Me.principalTable.Controls.Add(Me.pImprimirGrid, 0, 1)
        Me.principalTable.Location = New System.Drawing.Point(0, 197)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 2
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.principalTable.Size = New System.Drawing.Size(784, 536)
        Me.principalTable.TabIndex = 252
        '
        'CandidatosGrid
        '
        Me.CandidatosGrid.AllowUserToAddRows = False
        Me.CandidatosGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.CandidatosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CandidatosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CandidatosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CandidatosGrid.BackgroundColor = System.Drawing.Color.White
        Me.CandidatosGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CandidatosGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.CandidatosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CandidatosGrid.Location = New System.Drawing.Point(551, 3)
        Me.CandidatosGrid.Name = "CandidatosGrid"
        Me.CandidatosGrid.ReadOnly = True
        Me.CandidatosGrid.RowHeadersWidth = 60
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.CandidatosGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.principalTable.SetRowSpan(Me.CandidatosGrid, 2)
        Me.CandidatosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CandidatosGrid.Size = New System.Drawing.Size(230, 530)
        Me.CandidatosGrid.TabIndex = 245
        Me.CandidatosGrid.Visible = False
        '
        'ahijadosPanel
        '
        Me.ahijadosPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ahijadosPanel.BackColor = System.Drawing.Color.White
        Me.ahijadosPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ahijadosPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ahijadosPanel.Controls.Add(Me.ListaGrid)
        Me.ahijadosPanel.Controls.Add(Me.MiembrosL)
        Me.ahijadosPanel.Location = New System.Drawing.Point(3, 3)
        Me.ahijadosPanel.Name = "ahijadosPanel"
        Me.ahijadosPanel.Size = New System.Drawing.Size(542, 245)
        Me.ahijadosPanel.TabIndex = 244
        Me.ahijadosPanel.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.fechaEnvioL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaEnvioPicker, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(528, 32)
        Me.TableLayoutPanel1.TabIndex = 246
        '
        'fechaEnvioL
        '
        Me.fechaEnvioL.AutoSize = True
        Me.fechaEnvioL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaEnvioL.Location = New System.Drawing.Point(3, 0)
        Me.fechaEnvioL.Name = "fechaEnvioL"
        Me.fechaEnvioL.Size = New System.Drawing.Size(95, 19)
        Me.fechaEnvioL.TabIndex = 0
        Me.fechaEnvioL.Text = "*Date Sent:"
        '
        'FechaEnvioPicker
        '
        Me.FechaEnvioPicker.Location = New System.Drawing.Point(104, 3)
        Me.FechaEnvioPicker.Name = "FechaEnvioPicker"
        Me.FechaEnvioPicker.Size = New System.Drawing.Size(343, 22)
        Me.FechaEnvioPicker.TabIndex = 1
        '
        'ListaGrid
        '
        Me.ListaGrid.AllowUserToAddRows = False
        Me.ListaGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple
        Me.ListaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListaGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionado})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListaGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.ListaGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListaGrid.Location = New System.Drawing.Point(6, 79)
        Me.ListaGrid.Name = "ListaGrid"
        Me.ListaGrid.Size = New System.Drawing.Size(529, 148)
        Me.ListaGrid.TabIndex = 245
        '
        'Seleccionado
        '
        Me.Seleccionado.HeaderText = "Add"
        Me.Seleccionado.Name = "Seleccionado"
        Me.Seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Seleccionado.Width = 56
        '
        'MiembrosL
        '
        Me.MiembrosL.AutoSize = True
        Me.MiembrosL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembrosL.Location = New System.Drawing.Point(3, 58)
        Me.MiembrosL.Name = "MiembrosL"
        Me.MiembrosL.Size = New System.Drawing.Size(91, 19)
        Me.MiembrosL.TabIndex = 245
        Me.MiembrosL.Text = "*Members:"
        '
        'pImprimirGrid
        '
        Me.pImprimirGrid.AllowUserToAddRows = False
        Me.pImprimirGrid.AllowUserToDeleteRows = False
        Me.pImprimirGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pImprimirGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.pImprimirGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pImprimirGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._etiqueta, Me._descripcion})
        Me.pImprimirGrid.Location = New System.Drawing.Point(3, 271)
        Me.pImprimirGrid.Name = "pImprimirGrid"
        Me.pImprimirGrid.ReadOnly = True
        Me.pImprimirGrid.Size = New System.Drawing.Size(542, 262)
        Me.pImprimirGrid.TabIndex = 247
        Me.pImprimirGrid.Visible = False
        '
        '_etiqueta
        '
        Me._etiqueta.HeaderText = "Etiqueta"
        Me._etiqueta.Name = "_etiqueta"
        Me._etiqueta.ReadOnly = True
        Me._etiqueta.Width = 81
        '
        '_descripcion
        '
        Me._descripcion.HeaderText = "Descripcion"
        Me._descripcion.Name = "_descripcion"
        Me._descripcion.ReadOnly = True
        Me._descripcion.Width = 101
        '
        'CartaPadrino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 741)
        Me.Controls.Add(Me.principalTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.opcionesBusquedaTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CartaPadrino"
        Me.Text = "Carta de Padrino"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.opcionesBusquedaTable.ResumeLayout(False)
        Me.opcionesBusquedaTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.principalTable.ResumeLayout(False)
        CType(Me.CandidatosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ahijadosPanel.ResumeLayout(False)
        Me.ahijadosPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ListaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pImprimirGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocumentBoleta As System.Drawing.Printing.PrintDocument
    Friend WithEvents NombreSV As System.Windows.Forms.TextBox
    Friend WithEvents opcionesBusquedaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NombreSL As System.Windows.Forms.Label
    Friend WithEvents PadrinoL As System.Windows.Forms.Label
    Friend WithEvents PadrinoV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialogBoleta As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents indicacionesL As System.Windows.Forms.Label
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CandidatosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ahijadosPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents fechaEnvioL As System.Windows.Forms.Label
    Friend WithEvents FechaEnvioPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Seleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MiembrosL As System.Windows.Forms.Label
    Friend WithEvents pImprimirGrid As System.Windows.Forms.DataGridView
    Friend WithEvents _etiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
