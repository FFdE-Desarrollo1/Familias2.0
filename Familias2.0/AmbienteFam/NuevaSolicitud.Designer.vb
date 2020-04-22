<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaSolicitud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaSolicitud))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.RegionV = New System.Windows.Forms.Label()
        Me.regionL = New System.Windows.Forms.Label()
        Me.DireccionV = New System.Windows.Forms.Label()
        Me.DireccionL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.FechaV = New System.Windows.Forms.DateTimePicker()
        Me.EstadoV = New System.Windows.Forms.ComboBox()
        Me.SolTable1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalHorasV = New System.Windows.Forms.TextBox()
        Me.horasTL = New System.Windows.Forms.Label()
        Me.EstadoPicker = New System.Windows.Forms.DateTimePicker()
        Me.fEstadoL = New System.Windows.Forms.Label()
        Me.ExoneradaCheck = New System.Windows.Forms.CheckBox()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.HorasV = New System.Windows.Forms.TextBox()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.HorasL = New System.Windows.Forms.Label()
        Me.SolicitaL = New System.Windows.Forms.Label()
        Me.CantidadL = New System.Windows.Forms.Label()
        Me.PisoL = New System.Windows.Forms.Label()
        Me.SolPanel = New System.Windows.Forms.Panel()
        Me.SolicitudL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TechoCombo = New System.Windows.Forms.ComboBox()
        Me.ParedCombo = New System.Windows.Forms.ComboBox()
        Me.ParedL = New System.Windows.Forms.Label()
        Me.techoL = New System.Windows.Forms.Label()
        Me.SolicitaCombo = New System.Windows.Forms.ComboBox()
        Me.CantidadV = New System.Windows.Forms.TextBox()
        Me.DimensionXV = New System.Windows.Forms.TextBox()
        Me.xL = New System.Windows.Forms.Label()
        Me.DimensionYV = New System.Windows.Forms.TextBox()
        Me.DimensionL = New System.Windows.Forms.Label()
        Me.PisoCombo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.EntregaPicker = New System.Windows.Forms.DateTimePicker()
        Me.EntregaL = New System.Windows.Forms.Label()
        Me.BrigadaV = New System.Windows.Forms.TextBox()
        Me.ConstruccionPicker = New System.Windows.Forms.DateTimePicker()
        Me.VisitaPicker = New System.Windows.Forms.DateTimePicker()
        Me.VisitaL = New System.Windows.Forms.Label()
        Me.ConstruccionL = New System.Windows.Forms.Label()
        Me.BrigadaL = New System.Windows.Forms.Label()
        Me.DirectorioV = New System.Windows.Forms.TextBox()
        Me.VerCarpetaButton = New System.Windows.Forms.Button()
        Me.FotoInicialButton = New System.Windows.Forms.Button()
        Me.FotoFinalButton = New System.Windows.Forms.Button()
        Me.complementoInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotasPAV = New System.Windows.Forms.Label()
        Me.FechaPAV = New System.Windows.Forms.Label()
        Me.AplicaPAV = New System.Windows.Forms.Label()
        Me.aplicaPAL = New System.Windows.Forms.Label()
        Me.fechaPAL = New System.Windows.Forms.Label()
        Me.notasPAL = New System.Windows.Forms.Label()
        Me.miembrosGrid = New System.Windows.Forms.DataGridView()
        Me.PreAnalisisL = New System.Windows.Forms.Label()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SolTable1.SuspendLayout()
        Me.SolPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.complementoInfoTable.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.miembrosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.ListadoButton, 4, 0)
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
        'ListadoButton
        '
        Me.ListadoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.ListadoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.ListaIcon
        Me.ListadoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ListadoButton.Location = New System.Drawing.Point(841, 3)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(44, 45)
        Me.ListadoButton.TabIndex = 237
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(732, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(681, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(787, 3)
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
        Me.Title.Size = New System.Drawing.Size(670, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Nueva solicitud de Viviendas"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel7.ColumnCount = 8
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.RegionV, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.regionL, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.DireccionV, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.DireccionL, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.FamiliaV, 7, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 6, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 120)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(973, 38)
        Me.TableLayoutPanel7.TabIndex = 262
        '
        'RegionV
        '
        Me.RegionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RegionV.AutoSize = True
        Me.RegionV.BackColor = System.Drawing.Color.Transparent
        Me.RegionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegionV.Location = New System.Drawing.Point(452, 0)
        Me.RegionV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RegionV.Name = "RegionV"
        Me.RegionV.Size = New System.Drawing.Size(15, 38)
        Me.RegionV.TabIndex = 264
        Me.RegionV.Text = "_"
        Me.RegionV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RegionV.Visible = False
        '
        'regionL
        '
        Me.regionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.regionL.AutoSize = True
        Me.regionL.BackColor = System.Drawing.Color.Transparent
        Me.regionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.regionL.Location = New System.Drawing.Point(396, 0)
        Me.regionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.regionL.Name = "regionL"
        Me.regionL.Size = New System.Drawing.Size(52, 38)
        Me.regionL.TabIndex = 264
        Me.regionL.Text = "Región:"
        Me.regionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.regionL.Visible = False
        '
        'DireccionV
        '
        Me.DireccionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DireccionV.AutoSize = True
        Me.DireccionV.BackColor = System.Drawing.Color.Transparent
        Me.DireccionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DireccionV.Location = New System.Drawing.Point(72, 0)
        Me.DireccionV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionV.Name = "DireccionV"
        Me.DireccionV.Size = New System.Drawing.Size(15, 38)
        Me.DireccionV.TabIndex = 48
        Me.DireccionV.Text = "_"
        Me.DireccionV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DireccionV.Visible = False
        '
        'DireccionL
        '
        Me.DireccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DireccionL.AutoSize = True
        Me.DireccionL.BackColor = System.Drawing.Color.Transparent
        Me.DireccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DireccionL.Location = New System.Drawing.Point(2, 0)
        Me.DireccionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionL.Name = "DireccionL"
        Me.DireccionL.Size = New System.Drawing.Size(66, 38)
        Me.DireccionL.TabIndex = 47
        Me.DireccionL.Text = "Dirección:"
        Me.DireccionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DireccionL.Visible = False
        '
        'FamiliaV
        '
        Me.FamiliaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaV.BackColor = System.Drawing.Color.White
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FamiliaV.Location = New System.Drawing.Point(856, 3)
        Me.FamiliaV.MaxLength = 6
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(114, 29)
        Me.FamiliaV.TabIndex = 49
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(776, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 22)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Familia:"
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.BackColor = System.Drawing.Color.Transparent
        Me.EstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoL.ForeColor = System.Drawing.Color.Black
        Me.EstadoL.Location = New System.Drawing.Point(293, 0)
        Me.EstadoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(58, 16)
        Me.EstadoL.TabIndex = 41
        Me.EstadoL.Text = "*Estado:"
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.ForeColor = System.Drawing.Color.Black
        Me.FechaL.Location = New System.Drawing.Point(2, 0)
        Me.FechaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(107, 16)
        Me.FechaL.TabIndex = 42
        Me.FechaL.Text = "*Fecha Solicitud:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FechaV
        '
        Me.FechaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolTable1.SetColumnSpan(Me.FechaV, 2)
        Me.FechaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaV.Location = New System.Drawing.Point(116, 3)
        Me.FechaV.Name = "FechaV"
        Me.FechaV.Size = New System.Drawing.Size(139, 22)
        Me.FechaV.TabIndex = 0
        '
        'EstadoV
        '
        Me.EstadoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoV.FormattingEnabled = True
        Me.EstadoV.Location = New System.Drawing.Point(356, 3)
        Me.EstadoV.Name = "EstadoV"
        Me.EstadoV.Size = New System.Drawing.Size(318, 24)
        Me.EstadoV.TabIndex = 1
        '
        'SolTable1
        '
        Me.SolTable1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolTable1.BackColor = System.Drawing.Color.Transparent
        Me.SolTable1.ColumnCount = 9
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667!))
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.SolTable1.Controls.Add(Me.TotalHorasV, 8, 1)
        Me.SolTable1.Controls.Add(Me.horasTL, 7, 1)
        Me.SolTable1.Controls.Add(Me.EstadoPicker, 8, 0)
        Me.SolTable1.Controls.Add(Me.fEstadoL, 7, 0)
        Me.SolTable1.Controls.Add(Me.FechaV, 1, 0)
        Me.SolTable1.Controls.Add(Me.FechaL, 0, 0)
        Me.SolTable1.Controls.Add(Me.ExoneradaCheck, 2, 1)
        Me.SolTable1.Controls.Add(Me.NotasV, 5, 1)
        Me.SolTable1.Controls.Add(Me.HorasV, 1, 1)
        Me.SolTable1.Controls.Add(Me.NotasL, 4, 1)
        Me.SolTable1.Controls.Add(Me.HorasL, 0, 1)
        Me.SolTable1.Controls.Add(Me.EstadoV, 5, 0)
        Me.SolTable1.Controls.Add(Me.EstadoL, 4, 0)
        Me.SolTable1.Location = New System.Drawing.Point(4, 7)
        Me.SolTable1.Name = "SolTable1"
        Me.SolTable1.RowCount = 2
        Me.SolTable1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SolTable1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SolTable1.Size = New System.Drawing.Size(961, 62)
        Me.SolTable1.TabIndex = 263
        '
        'TotalHorasV
        '
        Me.TotalHorasV.Location = New System.Drawing.Point(850, 33)
        Me.TotalHorasV.Name = "TotalHorasV"
        Me.TotalHorasV.Size = New System.Drawing.Size(38, 22)
        Me.TotalHorasV.TabIndex = 267
        Me.TotalHorasV.Visible = False
        '
        'horasTL
        '
        Me.horasTL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.horasTL.AutoSize = True
        Me.horasTL.BackColor = System.Drawing.Color.Transparent
        Me.horasTL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horasTL.ForeColor = System.Drawing.Color.Black
        Me.horasTL.Location = New System.Drawing.Point(745, 30)
        Me.horasTL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.horasTL.Name = "horasTL"
        Me.horasTL.Size = New System.Drawing.Size(100, 16)
        Me.horasTL.TabIndex = 270
        Me.horasTL.Text = "Hrs. trabajadas:"
        Me.horasTL.Visible = False
        '
        'EstadoPicker
        '
        Me.EstadoPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EstadoPicker.Location = New System.Drawing.Point(850, 3)
        Me.EstadoPicker.Name = "EstadoPicker"
        Me.EstadoPicker.Size = New System.Drawing.Size(108, 22)
        Me.EstadoPicker.TabIndex = 2
        '
        'fEstadoL
        '
        Me.fEstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fEstadoL.AutoSize = True
        Me.fEstadoL.BackColor = System.Drawing.Color.Transparent
        Me.fEstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fEstadoL.ForeColor = System.Drawing.Color.Black
        Me.fEstadoL.Location = New System.Drawing.Point(745, 0)
        Me.fEstadoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fEstadoL.Name = "fEstadoL"
        Me.fEstadoL.Size = New System.Drawing.Size(100, 16)
        Me.fEstadoL.TabIndex = 270
        Me.fEstadoL.Text = "*Fecha Estado:"
        '
        'ExoneradaCheck
        '
        Me.ExoneradaCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExoneradaCheck.AutoSize = True
        Me.ExoneradaCheck.Location = New System.Drawing.Point(166, 33)
        Me.ExoneradaCheck.Name = "ExoneradaCheck"
        Me.ExoneradaCheck.Size = New System.Drawing.Size(89, 20)
        Me.ExoneradaCheck.TabIndex = 4
        Me.ExoneradaCheck.Text = "Exonerada"
        Me.ExoneradaCheck.UseVisualStyleBackColor = True
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Location = New System.Drawing.Point(356, 33)
        Me.NotasV.MaxLength = 100
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(318, 22)
        Me.NotasV.TabIndex = 5
        '
        'HorasV
        '
        Me.HorasV.Location = New System.Drawing.Point(116, 33)
        Me.HorasV.Name = "HorasV"
        Me.HorasV.Size = New System.Drawing.Size(38, 22)
        Me.HorasV.TabIndex = 3
        '
        'NotasL
        '
        Me.NotasL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasL.AutoSize = True
        Me.NotasL.BackColor = System.Drawing.Color.Transparent
        Me.NotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasL.ForeColor = System.Drawing.Color.Black
        Me.NotasL.Location = New System.Drawing.Point(293, 30)
        Me.NotasL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(58, 16)
        Me.NotasL.TabIndex = 264
        Me.NotasL.Text = "Notas:"
        Me.NotasL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HorasL
        '
        Me.HorasL.AutoSize = True
        Me.HorasL.BackColor = System.Drawing.Color.Transparent
        Me.HorasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorasL.ForeColor = System.Drawing.Color.Black
        Me.HorasL.Location = New System.Drawing.Point(2, 30)
        Me.HorasL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HorasL.Name = "HorasL"
        Me.HorasL.Size = New System.Drawing.Size(109, 16)
        Me.HorasL.TabIndex = 265
        Me.HorasL.Text = "*Asignación Hrs.:"
        Me.HorasL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SolicitaL
        '
        Me.SolicitaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolicitaL.AutoSize = True
        Me.SolicitaL.BackColor = System.Drawing.Color.Transparent
        Me.SolicitaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitaL.ForeColor = System.Drawing.Color.Black
        Me.SolicitaL.Location = New System.Drawing.Point(2, 0)
        Me.SolicitaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SolicitaL.Name = "SolicitaL"
        Me.SolicitaL.Size = New System.Drawing.Size(182, 16)
        Me.SolicitaL.TabIndex = 266
        Me.SolicitaL.Text = "*Descripción"
        Me.SolicitaL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CantidadL
        '
        Me.CantidadL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CantidadL.AutoSize = True
        Me.CantidadL.BackColor = System.Drawing.Color.Transparent
        Me.CantidadL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadL.ForeColor = System.Drawing.Color.Black
        Me.CantidadL.Location = New System.Drawing.Point(188, 0)
        Me.CantidadL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CantidadL.Name = "CantidadL"
        Me.CantidadL.Size = New System.Drawing.Size(71, 16)
        Me.CantidadL.TabIndex = 267
        Me.CantidadL.Text = "*Cantidad"
        Me.CantidadL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PisoL
        '
        Me.PisoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PisoL.AutoSize = True
        Me.PisoL.BackColor = System.Drawing.Color.Transparent
        Me.PisoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PisoL.ForeColor = System.Drawing.Color.Black
        Me.PisoL.Location = New System.Drawing.Point(406, 0)
        Me.PisoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PisoL.Name = "PisoL"
        Me.PisoL.Size = New System.Drawing.Size(182, 16)
        Me.PisoL.TabIndex = 268
        Me.PisoL.Text = "Piso"
        Me.PisoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SolPanel
        '
        Me.SolPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolPanel.BackColor = System.Drawing.Color.LightBlue
        Me.SolPanel.Controls.Add(Me.SolicitudL)
        Me.SolPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.SolPanel.Controls.Add(Me.SolTable1)
        Me.SolPanel.Location = New System.Drawing.Point(6, 164)
        Me.SolPanel.Name = "SolPanel"
        Me.SolPanel.Size = New System.Drawing.Size(970, 153)
        Me.SolPanel.TabIndex = 269
        Me.SolPanel.Visible = False
        '
        'SolicitudL
        '
        Me.SolicitudL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolicitudL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitudL.Location = New System.Drawing.Point(6, 72)
        Me.SolicitudL.Name = "SolicitudL"
        Me.SolicitudL.Size = New System.Drawing.Size(959, 18)
        Me.SolicitudL.TabIndex = 265
        Me.SolicitudL.Text = "FAMILIA SOLICITA:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TechoCombo, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ParedCombo, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ParedL, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.techoL, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SolicitaCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SolicitaL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DimensionXV, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.xL, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DimensionYV, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DimensionL, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PisoL, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PisoCombo, 5, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 92)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(962, 51)
        Me.TableLayoutPanel1.TabIndex = 264
        '
        'TechoCombo
        '
        Me.TechoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TechoCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechoCombo.FormattingEnabled = True
        Me.TechoCombo.Location = New System.Drawing.Point(779, 19)
        Me.TechoCombo.Name = "TechoCombo"
        Me.TechoCombo.Size = New System.Drawing.Size(180, 24)
        Me.TechoCombo.TabIndex = 6
        '
        'ParedCombo
        '
        Me.ParedCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParedCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParedCombo.FormattingEnabled = True
        Me.ParedCombo.Location = New System.Drawing.Point(593, 19)
        Me.ParedCombo.Name = "ParedCombo"
        Me.ParedCombo.Size = New System.Drawing.Size(180, 24)
        Me.ParedCombo.TabIndex = 5
        '
        'ParedL
        '
        Me.ParedL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParedL.AutoSize = True
        Me.ParedL.BackColor = System.Drawing.Color.Transparent
        Me.ParedL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParedL.ForeColor = System.Drawing.Color.Black
        Me.ParedL.Location = New System.Drawing.Point(592, 0)
        Me.ParedL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ParedL.Name = "ParedL"
        Me.ParedL.Size = New System.Drawing.Size(182, 16)
        Me.ParedL.TabIndex = 270
        Me.ParedL.Text = "Pared"
        Me.ParedL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'techoL
        '
        Me.techoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.techoL.AutoSize = True
        Me.techoL.BackColor = System.Drawing.Color.Transparent
        Me.techoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.techoL.ForeColor = System.Drawing.Color.Black
        Me.techoL.Location = New System.Drawing.Point(778, 0)
        Me.techoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.techoL.Name = "techoL"
        Me.techoL.Size = New System.Drawing.Size(182, 16)
        Me.techoL.TabIndex = 270
        Me.techoL.Text = "Techo"
        Me.techoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SolicitaCombo
        '
        Me.SolicitaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolicitaCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitaCombo.FormattingEnabled = True
        Me.SolicitaCombo.Location = New System.Drawing.Point(3, 19)
        Me.SolicitaCombo.Name = "SolicitaCombo"
        Me.SolicitaCombo.Size = New System.Drawing.Size(180, 24)
        Me.SolicitaCombo.TabIndex = 0
        '
        'CantidadV
        '
        Me.CantidadV.Location = New System.Drawing.Point(189, 19)
        Me.CantidadV.Name = "CantidadV"
        Me.CantidadV.Size = New System.Drawing.Size(69, 22)
        Me.CantidadV.TabIndex = 1
        '
        'DimensionXV
        '
        Me.DimensionXV.Location = New System.Drawing.Point(264, 19)
        Me.DimensionXV.Name = "DimensionXV"
        Me.DimensionXV.Size = New System.Drawing.Size(56, 22)
        Me.DimensionXV.TabIndex = 2
        '
        'xL
        '
        Me.xL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xL.AutoSize = True
        Me.xL.BackColor = System.Drawing.Color.Transparent
        Me.xL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xL.ForeColor = System.Drawing.Color.Black
        Me.xL.Location = New System.Drawing.Point(325, 16)
        Me.xL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.xL.Name = "xL"
        Me.xL.Size = New System.Drawing.Size(15, 16)
        Me.xL.TabIndex = 271
        Me.xL.Text = "x"
        Me.xL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DimensionYV
        '
        Me.DimensionYV.Location = New System.Drawing.Point(345, 19)
        Me.DimensionYV.Name = "DimensionYV"
        Me.DimensionYV.Size = New System.Drawing.Size(56, 22)
        Me.DimensionYV.TabIndex = 3
        '
        'DimensionL
        '
        Me.DimensionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DimensionL.AutoSize = True
        Me.DimensionL.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.DimensionL, 3)
        Me.DimensionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DimensionL.ForeColor = System.Drawing.Color.Black
        Me.DimensionL.Location = New System.Drawing.Point(263, 0)
        Me.DimensionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DimensionL.Name = "DimensionL"
        Me.DimensionL.Size = New System.Drawing.Size(139, 16)
        Me.DimensionL.TabIndex = 272
        Me.DimensionL.Text = "Dimensión p/construir"
        Me.DimensionL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PisoCombo
        '
        Me.PisoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PisoCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PisoCombo.FormattingEnabled = True
        Me.PisoCombo.Location = New System.Drawing.Point(407, 19)
        Me.PisoCombo.Name = "PisoCombo"
        Me.PisoCombo.Size = New System.Drawing.Size(180, 24)
        Me.PisoCombo.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.EntregaPicker, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.EntregaL, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BrigadaV, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ConstruccionPicker, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.VisitaPicker, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.VisitaL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ConstruccionL, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BrigadaL, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DirectorioV, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.VerCarpetaButton, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FotoInicialButton, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FotoFinalButton, 2, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 323)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(970, 59)
        Me.TableLayoutPanel2.TabIndex = 266
        Me.TableLayoutPanel2.Visible = False
        '
        'EntregaPicker
        '
        Me.EntregaPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntregaPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntregaPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EntregaPicker.Location = New System.Drawing.Point(821, 3)
        Me.EntregaPicker.Name = "EntregaPicker"
        Me.EntregaPicker.Size = New System.Drawing.Size(146, 22)
        Me.EntregaPicker.TabIndex = 271
        Me.EntregaPicker.Visible = False
        '
        'EntregaL
        '
        Me.EntregaL.AutoSize = True
        Me.EntregaL.BackColor = System.Drawing.Color.Transparent
        Me.EntregaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntregaL.ForeColor = System.Drawing.Color.Black
        Me.EntregaL.Location = New System.Drawing.Point(719, 0)
        Me.EntregaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EntregaL.Name = "EntregaL"
        Me.EntregaL.Size = New System.Drawing.Size(97, 16)
        Me.EntregaL.TabIndex = 271
        Me.EntregaL.Text = "Fecha Entrega:"
        Me.EntregaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.EntregaL.Visible = False
        '
        'BrigadaV
        '
        Me.BrigadaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrigadaV.Location = New System.Drawing.Point(553, 31)
        Me.BrigadaV.MaxLength = 100
        Me.BrigadaV.Name = "BrigadaV"
        Me.BrigadaV.Size = New System.Drawing.Size(94, 22)
        Me.BrigadaV.TabIndex = 271
        Me.BrigadaV.Visible = False
        '
        'ConstruccionPicker
        '
        Me.ConstruccionPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConstruccionPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConstruccionPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ConstruccionPicker.Location = New System.Drawing.Point(553, 3)
        Me.ConstruccionPicker.Name = "ConstruccionPicker"
        Me.ConstruccionPicker.Size = New System.Drawing.Size(94, 22)
        Me.ConstruccionPicker.TabIndex = 270
        Me.ConstruccionPicker.Visible = False
        '
        'VisitaPicker
        '
        Me.VisitaPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitaPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VisitaPicker.Location = New System.Drawing.Point(132, 3)
        Me.VisitaPicker.Name = "VisitaPicker"
        Me.VisitaPicker.Size = New System.Drawing.Size(129, 22)
        Me.VisitaPicker.TabIndex = 0
        '
        'VisitaL
        '
        Me.VisitaL.AutoSize = True
        Me.VisitaL.BackColor = System.Drawing.Color.Transparent
        Me.VisitaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitaL.ForeColor = System.Drawing.Color.Black
        Me.VisitaL.Location = New System.Drawing.Point(2, 0)
        Me.VisitaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VisitaL.Name = "VisitaL"
        Me.VisitaL.Size = New System.Drawing.Size(103, 16)
        Me.VisitaL.TabIndex = 266
        Me.VisitaL.Text = "Visita Ambiente:"
        Me.VisitaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ConstruccionL
        '
        Me.ConstruccionL.AutoSize = True
        Me.ConstruccionL.BackColor = System.Drawing.Color.Transparent
        Me.ConstruccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConstruccionL.ForeColor = System.Drawing.Color.Black
        Me.ConstruccionL.Location = New System.Drawing.Point(420, 0)
        Me.ConstruccionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ConstruccionL.Name = "ConstruccionL"
        Me.ConstruccionL.Size = New System.Drawing.Size(128, 16)
        Me.ConstruccionL.TabIndex = 270
        Me.ConstruccionL.Text = "Fecha Construcción:"
        Me.ConstruccionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ConstruccionL.Visible = False
        '
        'BrigadaL
        '
        Me.BrigadaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrigadaL.AutoSize = True
        Me.BrigadaL.BackColor = System.Drawing.Color.Transparent
        Me.BrigadaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrigadaL.ForeColor = System.Drawing.Color.Black
        Me.BrigadaL.Location = New System.Drawing.Point(420, 28)
        Me.BrigadaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BrigadaL.Name = "BrigadaL"
        Me.BrigadaL.Size = New System.Drawing.Size(128, 16)
        Me.BrigadaL.TabIndex = 270
        Me.BrigadaL.Text = "Brigada:"
        Me.BrigadaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BrigadaL.Visible = False
        '
        'DirectorioV
        '
        Me.DirectorioV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.DirectorioV, 2)
        Me.DirectorioV.Location = New System.Drawing.Point(720, 31)
        Me.DirectorioV.MaxLength = 100
        Me.DirectorioV.Name = "DirectorioV"
        Me.DirectorioV.Size = New System.Drawing.Size(247, 22)
        Me.DirectorioV.TabIndex = 270
        '
        'VerCarpetaButton
        '
        Me.VerCarpetaButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerCarpetaButton.Location = New System.Drawing.Point(3, 31)
        Me.VerCarpetaButton.Name = "VerCarpetaButton"
        Me.VerCarpetaButton.Size = New System.Drawing.Size(123, 23)
        Me.VerCarpetaButton.TabIndex = 272
        Me.VerCarpetaButton.Text = "Ver Carpeta Fotos"
        Me.VerCarpetaButton.UseVisualStyleBackColor = True
        Me.VerCarpetaButton.Visible = False
        '
        'FotoInicialButton
        '
        Me.FotoInicialButton.Location = New System.Drawing.Point(132, 31)
        Me.FotoInicialButton.Name = "FotoInicialButton"
        Me.FotoInicialButton.Size = New System.Drawing.Size(126, 23)
        Me.FotoInicialButton.TabIndex = 273
        Me.FotoInicialButton.Text = "Foto Inicial"
        Me.FotoInicialButton.UseVisualStyleBackColor = True
        '
        'FotoFinalButton
        '
        Me.FotoFinalButton.Location = New System.Drawing.Point(267, 31)
        Me.FotoFinalButton.Name = "FotoFinalButton"
        Me.FotoFinalButton.Size = New System.Drawing.Size(81, 23)
        Me.FotoFinalButton.TabIndex = 274
        Me.FotoFinalButton.Text = "Foto Final"
        Me.FotoFinalButton.UseVisualStyleBackColor = True
        Me.FotoFinalButton.Visible = False
        '
        'complementoInfoTable
        '
        Me.complementoInfoTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.complementoInfoTable.ColumnCount = 3
        Me.complementoInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.complementoInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.complementoInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.complementoInfoTable.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.complementoInfoTable.Controls.Add(Me.miembrosGrid, 2, 1)
        Me.complementoInfoTable.Controls.Add(Me.PreAnalisisL, 0, 0)
        Me.complementoInfoTable.Controls.Add(Me.MiembroL, 2, 0)
        Me.complementoInfoTable.Location = New System.Drawing.Point(6, 388)
        Me.complementoInfoTable.Name = "complementoInfoTable"
        Me.complementoInfoTable.RowCount = 2
        Me.complementoInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.complementoInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.complementoInfoTable.Size = New System.Drawing.Size(970, 262)
        Me.complementoInfoTable.TabIndex = 270
        Me.complementoInfoTable.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.NotasPAV, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.FechaPAV, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.AplicaPAV, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.aplicaPAL, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.fechaPAL, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.notasPAL, 0, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(362, 155)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'NotasPAV
        '
        Me.NotasPAV.AutoSize = True
        Me.NotasPAV.Location = New System.Drawing.Point(57, 56)
        Me.NotasPAV.Name = "NotasPAV"
        Me.NotasPAV.Size = New System.Drawing.Size(12, 16)
        Me.NotasPAV.TabIndex = 5
        Me.NotasPAV.Text = "."
        '
        'FechaPAV
        '
        Me.FechaPAV.AutoSize = True
        Me.FechaPAV.Location = New System.Drawing.Point(57, 26)
        Me.FechaPAV.Name = "FechaPAV"
        Me.FechaPAV.Size = New System.Drawing.Size(12, 16)
        Me.FechaPAV.TabIndex = 4
        Me.FechaPAV.Text = "."
        '
        'AplicaPAV
        '
        Me.AplicaPAV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AplicaPAV.AutoSize = True
        Me.AplicaPAV.Location = New System.Drawing.Point(57, 0)
        Me.AplicaPAV.Name = "AplicaPAV"
        Me.AplicaPAV.Size = New System.Drawing.Size(302, 16)
        Me.AplicaPAV.TabIndex = 3
        Me.AplicaPAV.Text = "."
        '
        'aplicaPAL
        '
        Me.aplicaPAL.AutoSize = True
        Me.aplicaPAL.Location = New System.Drawing.Point(3, 0)
        Me.aplicaPAL.Name = "aplicaPAL"
        Me.aplicaPAL.Size = New System.Drawing.Size(48, 16)
        Me.aplicaPAL.TabIndex = 0
        Me.aplicaPAL.Text = "Aplica:"
        '
        'fechaPAL
        '
        Me.fechaPAL.AutoSize = True
        Me.fechaPAL.Location = New System.Drawing.Point(3, 26)
        Me.fechaPAL.Name = "fechaPAL"
        Me.fechaPAL.Size = New System.Drawing.Size(48, 16)
        Me.fechaPAL.TabIndex = 1
        Me.fechaPAL.Text = "Fecha:"
        '
        'notasPAL
        '
        Me.notasPAL.AutoSize = True
        Me.notasPAL.Location = New System.Drawing.Point(3, 56)
        Me.notasPAL.Name = "notasPAL"
        Me.notasPAL.Size = New System.Drawing.Size(46, 16)
        Me.notasPAL.TabIndex = 2
        Me.notasPAL.Text = "Notas:"
        '
        'miembrosGrid
        '
        Me.miembrosGrid.AllowUserToAddRows = False
        Me.miembrosGrid.AllowUserToDeleteRows = False
        Me.miembrosGrid.AllowUserToResizeColumns = False
        Me.miembrosGrid.AllowUserToResizeRows = False
        Me.miembrosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.miembrosGrid.BackgroundColor = System.Drawing.Color.White
        Me.miembrosGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.miembrosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.miembrosGrid.Location = New System.Drawing.Point(421, 23)
        Me.miembrosGrid.Name = "miembrosGrid"
        Me.miembrosGrid.ReadOnly = True
        Me.miembrosGrid.RowHeadersVisible = False
        Me.miembrosGrid.Size = New System.Drawing.Size(546, 236)
        Me.miembrosGrid.TabIndex = 1
        '
        'PreAnalisisL
        '
        Me.PreAnalisisL.AutoSize = True
        Me.PreAnalisisL.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreAnalisisL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PreAnalisisL.Location = New System.Drawing.Point(3, 0)
        Me.PreAnalisisL.Name = "PreAnalisisL"
        Me.PreAnalisisL.Size = New System.Drawing.Size(99, 16)
        Me.PreAnalisisL.TabIndex = 2
        Me.PreAnalisisL.Text = "PRE-ANALISIS"
        '
        'MiembroL
        '
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MiembroL.Location = New System.Drawing.Point(421, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(218, 16)
        Me.MiembroL.TabIndex = 3
        Me.MiembroL.Text = "MIEMBROS MAYORES A 17 AÑOS"
        '
        'NuevaSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.complementoInfoTable)
        Me.Controls.Add(Me.SolPanel)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NuevaSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud - Viviendas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.SolTable1.ResumeLayout(False)
        Me.SolTable1.PerformLayout()
        Me.SolPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.complementoInfoTable.ResumeLayout(False)
        Me.complementoInfoTable.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.miembrosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DireccionV As System.Windows.Forms.Label
    Friend WithEvents DireccionL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents FechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents EstadoV As System.Windows.Forms.ComboBox
    Friend WithEvents SolTable1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionV As System.Windows.Forms.Label
    Friend WithEvents regionL As System.Windows.Forms.Label
    Friend WithEvents PisoL As System.Windows.Forms.Label
    Friend WithEvents CantidadL As System.Windows.Forms.Label
    Friend WithEvents SolicitaL As System.Windows.Forms.Label
    Friend WithEvents SolPanel As System.Windows.Forms.Panel
    Friend WithEvents DimensionL As System.Windows.Forms.Label
    Friend WithEvents xL As System.Windows.Forms.Label
    Friend WithEvents SolicitaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CantidadV As System.Windows.Forms.TextBox
    Friend WithEvents PisoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DimensionYV As System.Windows.Forms.TextBox
    Friend WithEvents DimensionXV As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents ExoneradaCheck As System.Windows.Forms.CheckBox
    Friend WithEvents HorasV As System.Windows.Forms.TextBox
    Friend WithEvents HorasL As System.Windows.Forms.Label
    Friend WithEvents SolicitudL As System.Windows.Forms.Label
    Friend WithEvents TechoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ParedCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ParedL As System.Windows.Forms.Label
    Friend WithEvents techoL As System.Windows.Forms.Label
    Friend WithEvents VisitaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VisitaL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TotalHorasV As System.Windows.Forms.TextBox
    Friend WithEvents horasTL As System.Windows.Forms.Label
    Friend WithEvents EstadoPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents fEstadoL As System.Windows.Forms.Label
    Friend WithEvents BrigadaL As System.Windows.Forms.Label
    Friend WithEvents ConstruccionL As System.Windows.Forms.Label
    Friend WithEvents EntregaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EntregaL As System.Windows.Forms.Label
    Friend WithEvents BrigadaV As System.Windows.Forms.TextBox
    Friend WithEvents ConstruccionPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents complementoInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NotasPAV As System.Windows.Forms.Label
    Friend WithEvents FechaPAV As System.Windows.Forms.Label
    Friend WithEvents aplicaPAL As System.Windows.Forms.Label
    Friend WithEvents fechaPAL As System.Windows.Forms.Label
    Friend WithEvents notasPAL As System.Windows.Forms.Label
    Friend WithEvents miembrosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PreAnalisisL As System.Windows.Forms.Label
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents VerCarpetaButton As System.Windows.Forms.Button
    Friend WithEvents FotoInicialButton As System.Windows.Forms.Button
    Friend WithEvents DirectorioV As System.Windows.Forms.TextBox
    Friend WithEvents FotoFinalButton As System.Windows.Forms.Button
    Friend WithEvents AplicaPAV As System.Windows.Forms.Label
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
End Class
