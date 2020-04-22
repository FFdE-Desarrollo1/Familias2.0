<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarSemaforo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresarSemaforo))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.semaforoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.semaforoL = New System.Windows.Forms.Label()
        Me.SemaforoCombo = New System.Windows.Forms.ComboBox()
        Me.fInicioL = New System.Windows.Forms.Label()
        Me.InicioPicker = New System.Windows.Forms.DateTimePicker()
        Me.FinPicher = New System.Windows.Forms.DateTimePicker()
        Me.fFinL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.nuevoSemButton = New System.Windows.Forms.Button()
        Me.infoGenTable = New System.Windows.Forms.TableLayoutPanel()
        Me.RegionL = New System.Windows.Forms.Label()
        Me.GradoV = New System.Windows.Forms.Label()
        Me.RegionV = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.EdadV = New System.Windows.Forms.Label()
        Me.FaseV = New System.Windows.Forms.Label()
        Me.FaseL = New System.Windows.Forms.Label()
        Me.semaforoV = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TSV = New System.Windows.Forms.Label()
        Me.TSL = New System.Windows.Forms.Label()
        Me.ClasificacionL = New System.Windows.Forms.Label()
        Me.ClasificacionV = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.TipoMiembroL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.principalTable.SuspendLayout()
        Me.semaforoTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.infoGenTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(984, 118)
        Me.bannerPanel.TabIndex = 261
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
        Me.opcionesTable.Size = New System.Drawing.Size(888, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(782, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(731, 3)
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
        Me.Title.Size = New System.Drawing.Size(720, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Ingresar Semáforo"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 2
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.principalTable.Controls.Add(Me.semaforoTable, 1, 1)
        Me.principalTable.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.principalTable.Controls.Add(Me.nuevoSemButton, 1, 0)
        Me.principalTable.Location = New System.Drawing.Point(1, 208)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 2
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.Size = New System.Drawing.Size(982, 442)
        Me.principalTable.TabIndex = 262
        '
        'semaforoTable
        '
        Me.semaforoTable.BackColor = System.Drawing.Color.Gainsboro
        Me.semaforoTable.ColumnCount = 2
        Me.semaforoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.semaforoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.semaforoTable.Controls.Add(Me.semaforoL, 0, 0)
        Me.semaforoTable.Controls.Add(Me.SemaforoCombo, 1, 0)
        Me.semaforoTable.Controls.Add(Me.fInicioL, 0, 1)
        Me.semaforoTable.Controls.Add(Me.InicioPicker, 1, 1)
        Me.semaforoTable.Controls.Add(Me.FinPicher, 1, 2)
        Me.semaforoTable.Controls.Add(Me.fFinL, 0, 2)
        Me.semaforoTable.Location = New System.Drawing.Point(554, 43)
        Me.semaforoTable.Name = "semaforoTable"
        Me.semaforoTable.RowCount = 3
        Me.semaforoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.semaforoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.semaforoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.semaforoTable.Size = New System.Drawing.Size(425, 93)
        Me.semaforoTable.TabIndex = 1
        Me.semaforoTable.Visible = False
        '
        'semaforoL
        '
        Me.semaforoL.AutoSize = True
        Me.semaforoL.Location = New System.Drawing.Point(3, 0)
        Me.semaforoL.Name = "semaforoL"
        Me.semaforoL.Size = New System.Drawing.Size(72, 16)
        Me.semaforoL.TabIndex = 0
        Me.semaforoL.Text = "*Semáforo:"
        '
        'SemaforoCombo
        '
        Me.SemaforoCombo.FormattingEnabled = True
        Me.SemaforoCombo.Location = New System.Drawing.Point(91, 3)
        Me.SemaforoCombo.Name = "SemaforoCombo"
        Me.SemaforoCombo.Size = New System.Drawing.Size(121, 24)
        Me.SemaforoCombo.TabIndex = 1
        '
        'fInicioL
        '
        Me.fInicioL.AutoSize = True
        Me.fInicioL.Location = New System.Drawing.Point(3, 30)
        Me.fInicioL.Name = "fInicioL"
        Me.fInicioL.Size = New System.Drawing.Size(82, 16)
        Me.fInicioL.TabIndex = 2
        Me.fInicioL.Text = "Fecha Inicio:"
        '
        'InicioPicker
        '
        Me.InicioPicker.Location = New System.Drawing.Point(91, 33)
        Me.InicioPicker.Name = "InicioPicker"
        Me.InicioPicker.Size = New System.Drawing.Size(330, 22)
        Me.InicioPicker.TabIndex = 3
        '
        'FinPicher
        '
        Me.FinPicher.Location = New System.Drawing.Point(91, 61)
        Me.FinPicher.Name = "FinPicher"
        Me.FinPicher.Size = New System.Drawing.Size(330, 22)
        Me.FinPicher.TabIndex = 4
        '
        'fFinL
        '
        Me.fFinL.AutoSize = True
        Me.fFinL.Location = New System.Drawing.Point(3, 58)
        Me.fFinL.Name = "fFinL"
        Me.fFinL.Size = New System.Drawing.Size(70, 16)
        Me.fFinL.TabIndex = 5
        Me.fFinL.Text = "Fecha Fin:"
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        Me.principalTable.SetRowSpan(Me.ListadoGrid, 2)
        Me.ListadoGrid.Size = New System.Drawing.Size(545, 436)
        Me.ListadoGrid.TabIndex = 0
        Me.ListadoGrid.Visible = False
        '
        'nuevoSemButton
        '
        Me.nuevoSemButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nuevoSemButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.nuevoSemButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoSemButton.ForeColor = System.Drawing.Color.White
        Me.nuevoSemButton.Location = New System.Drawing.Point(554, 3)
        Me.nuevoSemButton.Name = "nuevoSemButton"
        Me.nuevoSemButton.Size = New System.Drawing.Size(425, 34)
        Me.nuevoSemButton.TabIndex = 2
        Me.nuevoSemButton.Text = "Agregar Semáforo"
        Me.nuevoSemButton.UseVisualStyleBackColor = False
        Me.nuevoSemButton.Visible = False
        '
        'infoGenTable
        '
        Me.infoGenTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoGenTable.BackColor = System.Drawing.Color.AliceBlue
        Me.infoGenTable.ColumnCount = 12
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoGenTable.Controls.Add(Me.RegionL, 10, 1)
        Me.infoGenTable.Controls.Add(Me.GradoV, 1, 1)
        Me.infoGenTable.Controls.Add(Me.RegionV, 11, 1)
        Me.infoGenTable.Controls.Add(Me.GradoL, 0, 1)
        Me.infoGenTable.Controls.Add(Me.NombreL, 0, 0)
        Me.infoGenTable.Controls.Add(Me.NombreV, 1, 0)
        Me.infoGenTable.Controls.Add(Me.EdadV, 2, 0)
        Me.infoGenTable.Controls.Add(Me.FaseV, 11, 0)
        Me.infoGenTable.Controls.Add(Me.FaseL, 10, 0)
        Me.infoGenTable.Controls.Add(Me.semaforoV, 8, 0)
        Me.infoGenTable.Controls.Add(Me.Label1, 7, 0)
        Me.infoGenTable.Controls.Add(Me.TSV, 8, 1)
        Me.infoGenTable.Controls.Add(Me.TSL, 7, 1)
        Me.infoGenTable.Controls.Add(Me.ClasificacionL, 4, 1)
        Me.infoGenTable.Controls.Add(Me.ClasificacionV, 5, 1)
        Me.infoGenTable.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoGenTable.Location = New System.Drawing.Point(0, 157)
        Me.infoGenTable.Name = "infoGenTable"
        Me.infoGenTable.RowCount = 2
        Me.infoGenTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoGenTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.infoGenTable.Size = New System.Drawing.Size(976, 41)
        Me.infoGenTable.TabIndex = 246
        Me.infoGenTable.Visible = False
        '
        'RegionL
        '
        Me.RegionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegionL.AutoSize = True
        Me.RegionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegionL.Location = New System.Drawing.Point(900, 17)
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
        Me.RegionV.Location = New System.Drawing.Point(958, 17)
        Me.RegionV.Name = "RegionV"
        Me.RegionV.Size = New System.Drawing.Size(15, 16)
        Me.RegionV.TabIndex = 211
        Me.RegionV.Text = "_"
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
        Me.FaseV.Location = New System.Drawing.Point(958, 0)
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
        Me.FaseL.Location = New System.Drawing.Point(900, 0)
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
        Me.semaforoV.Location = New System.Drawing.Point(859, 0)
        Me.semaforoV.Name = "semaforoV"
        Me.semaforoV.Size = New System.Drawing.Size(15, 16)
        Me.semaforoV.TabIndex = 202
        Me.semaforoV.Text = "_"
        Me.semaforoV.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(786, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Semáforo:"
        Me.Label1.Visible = False
        '
        'TSV
        '
        Me.TSV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSV.AutoSize = True
        Me.TSV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSV.ForeColor = System.Drawing.Color.Black
        Me.TSV.Location = New System.Drawing.Point(859, 17)
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
        Me.TSL.Location = New System.Drawing.Point(786, 17)
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
        Me.ClasificacionL.Location = New System.Drawing.Point(654, 17)
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
        Me.ClasificacionV.Location = New System.Drawing.Point(745, 17)
        Me.ClasificacionV.Name = "ClasificacionV"
        Me.ClasificacionV.Size = New System.Drawing.Size(15, 16)
        Me.ClasificacionV.TabIndex = 209
        Me.ClasificacionV.Text = "_"
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.PrincipalPanel.Controls.Add(Me.MiembroL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.TipoMiembroL, 2, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(982, 36)
        Me.PrincipalPanel.TabIndex = 245
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
        Me.MiembroV.Location = New System.Drawing.Point(865, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(112, 29)
        Me.MiembroV.TabIndex = 204
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(757, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(102, 36)
        Me.MiembroL.TabIndex = 204
        Me.MiembroL.Text = "No. Miembro:"
        Me.MiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'TipoMiembroL
        '
        Me.TipoMiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMiembroL.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMiembroL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipoMiembroL.Location = New System.Drawing.Point(221, 0)
        Me.TipoMiembroL.Name = "TipoMiembroL"
        Me.TipoMiembroL.Size = New System.Drawing.Size(530, 36)
        Me.TipoMiembroL.TabIndex = 200
        Me.TipoMiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IngresarSemaforo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.infoGenTable)
        Me.Controls.Add(Me.principalTable)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IngresarSemaforo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Semaforo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.principalTable.ResumeLayout(False)
        Me.semaforoTable.ResumeLayout(False)
        Me.semaforoTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.infoGenTable.ResumeLayout(False)
        Me.infoGenTable.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents semaforoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents semaforoL As System.Windows.Forms.Label
    Friend WithEvents SemaforoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents fInicioL As System.Windows.Forms.Label
    Friend WithEvents InicioPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FinPicher As System.Windows.Forms.DateTimePicker
    Friend WithEvents fFinL As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents TipoMiembroL As System.Windows.Forms.Label
    Friend WithEvents infoGenTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionL As System.Windows.Forms.Label
    Friend WithEvents GradoV As System.Windows.Forms.Label
    Friend WithEvents RegionV As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents EdadV As System.Windows.Forms.Label
    Friend WithEvents FaseV As System.Windows.Forms.Label
    Friend WithEvents FaseL As System.Windows.Forms.Label
    Friend WithEvents semaforoV As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TSV As System.Windows.Forms.Label
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents ClasificacionL As System.Windows.Forms.Label
    Friend WithEvents ClasificacionV As System.Windows.Forms.Label
    Friend WithEvents nuevoSemButton As System.Windows.Forms.Button
End Class
