<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalificacionesPRIM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalificacionesPRIM))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.CalificacionesGrid = New System.Windows.Forms.DataGridView()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.ClasesCombo = New System.Windows.Forms.ComboBox()
        Me.ClaseL = New System.Windows.Forms.Label()
        Me.CicloCombo = New System.Windows.Forms.ComboBox()
        Me.CicloL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.nAlumnosL = New System.Windows.Forms.Label()
        Me.NotasPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.totalM = New System.Windows.Forms.Label()
        Me.zonaM = New System.Windows.Forms.Label()
        Me.examenM = New System.Windows.Forms.Label()
        Me.C7M = New System.Windows.Forms.Label()
        Me.C6M = New System.Windows.Forms.Label()
        Me.C5M = New System.Windows.Forms.Label()
        Me.C4M = New System.Windows.Forms.Label()
        Me.C3M = New System.Windows.Forms.Label()
        Me.C2M = New System.Windows.Forms.Label()
        Me.C1M = New System.Windows.Forms.Label()
        Me.C6V = New System.Windows.Forms.TextBox()
        Me.C7V = New System.Windows.Forms.TextBox()
        Me.C2V = New System.Windows.Forms.TextBox()
        Me.ZonaV = New System.Windows.Forms.TextBox()
        Me.C3V = New System.Windows.Forms.TextBox()
        Me.ExamenV = New System.Windows.Forms.TextBox()
        Me.C4V = New System.Windows.Forms.TextBox()
        Me.TotalV = New System.Windows.Forms.TextBox()
        Me.C5V = New System.Windows.Forms.TextBox()
        Me.C1V = New System.Windows.Forms.TextBox()
        Me.totalL = New System.Windows.Forms.Label()
        Me.zonaL = New System.Windows.Forms.Label()
        Me.examenL = New System.Windows.Forms.Label()
        Me.C6L = New System.Windows.Forms.Label()
        Me.C3L = New System.Windows.Forms.Label()
        Me.C5L = New System.Windows.Forms.Label()
        Me.C7L = New System.Windows.Forms.Label()
        Me.C4L = New System.Windows.Forms.Label()
        Me.C1L = New System.Windows.Forms.Label()
        Me.C2L = New System.Windows.Forms.Label()
        Me.Alumno = New System.Windows.Forms.Label()
        Me.MaximoL = New System.Windows.Forms.Label()
        Me.semaforo = New System.Windows.Forms.Label()
        Me.ltotal = New System.Windows.Forms.Label()
        Me.lexamen = New System.Windows.Forms.Label()
        Me.lzona = New System.Windows.Forms.Label()
        Me.l7 = New System.Windows.Forms.Label()
        Me.l6 = New System.Windows.Forms.Label()
        Me.l5 = New System.Windows.Forms.Label()
        Me.l4 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.CalificacionesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatosTable.SuspendLayout()
        Me.NotasPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(934, 108)
        Me.bannerPanel.TabIndex = 255
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
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(838, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(786, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(735, 3)
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
        Me.Title.Size = New System.Drawing.Size(724, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Registro Notas Primaria - Escuela NE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(706, 4)
        Me.GuardarButton.Name = "GuardarButton"
        Me.NotasPanel.SetRowSpan(Me.GuardarButton, 3)
        Me.GuardarButton.Size = New System.Drawing.Size(49, 45)
        Me.GuardarButton.TabIndex = 236
        Me.GuardarButton.UseVisualStyleBackColor = False
        Me.GuardarButton.Visible = False
        '
        'CalificacionesGrid
        '
        Me.CalificacionesGrid.AllowUserToAddRows = False
        Me.CalificacionesGrid.AllowUserToDeleteRows = False
        Me.CalificacionesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalificacionesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CalificacionesGrid.BackgroundColor = System.Drawing.Color.White
        Me.CalificacionesGrid.Location = New System.Drawing.Point(0, 219)
        Me.CalificacionesGrid.Name = "CalificacionesGrid"
        Me.CalificacionesGrid.ReadOnly = True
        Me.CalificacionesGrid.RowHeadersWidth = 10
        Me.CalificacionesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CalificacionesGrid.Size = New System.Drawing.Size(934, 527)
        Me.CalificacionesGrid.TabIndex = 256
        Me.CalificacionesGrid.Visible = False
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.OldLace
        Me.DatosTable.ColumnCount = 13
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.Controls.Add(Me.AñoL, 0, 0)
        Me.DatosTable.Controls.Add(Me.GradoL, 3, 0)
        Me.DatosTable.Controls.Add(Me.ClasesCombo, 10, 0)
        Me.DatosTable.Controls.Add(Me.ClaseL, 9, 0)
        Me.DatosTable.Controls.Add(Me.CicloCombo, 7, 0)
        Me.DatosTable.Controls.Add(Me.CicloL, 6, 0)
        Me.DatosTable.Controls.Add(Me.GradoCombo, 4, 0)
        Me.DatosTable.Controls.Add(Me.ListadoButton, 11, 0)
        Me.DatosTable.Controls.Add(Me.AñoV, 1, 0)
        Me.DatosTable.Controls.Add(Me.nAlumnosL, 12, 0)
        Me.DatosTable.Location = New System.Drawing.Point(0, 112)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 1
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable.Size = New System.Drawing.Size(934, 34)
        Me.DatosTable.TabIndex = 257
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
        Me.GradoL.Location = New System.Drawing.Point(126, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(66, 23)
        Me.GradoL.TabIndex = 0
        Me.GradoL.Text = "Grado"
        '
        'ClasesCombo
        '
        Me.ClasesCombo.FormattingEnabled = True
        Me.ClasesCombo.Location = New System.Drawing.Point(586, 3)
        Me.ClasesCombo.Name = "ClasesCombo"
        Me.ClasesCombo.Size = New System.Drawing.Size(258, 31)
        Me.ClasesCombo.TabIndex = 258
        '
        'ClaseL
        '
        Me.ClaseL.AutoSize = True
        Me.ClaseL.Location = New System.Drawing.Point(520, 0)
        Me.ClaseL.Name = "ClaseL"
        Me.ClaseL.Size = New System.Drawing.Size(60, 23)
        Me.ClaseL.TabIndex = 3
        Me.ClaseL.Text = "Clase"
        '
        'CicloCombo
        '
        Me.CicloCombo.FormattingEnabled = True
        Me.CicloCombo.Location = New System.Drawing.Point(404, 3)
        Me.CicloCombo.Name = "CicloCombo"
        Me.CicloCombo.Size = New System.Drawing.Size(90, 31)
        Me.CicloCombo.TabIndex = 1
        '
        'CicloL
        '
        Me.CicloL.AutoSize = True
        Me.CicloL.Location = New System.Drawing.Point(345, 0)
        Me.CicloL.Name = "CicloL"
        Me.CicloL.Size = New System.Drawing.Size(53, 23)
        Me.CicloL.TabIndex = 2
        Me.CicloL.Text = "Ciclo"
        '
        'GradoCombo
        '
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(198, 3)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(121, 31)
        Me.GradoCombo.TabIndex = 4
        '
        'ListadoButton
        '
        Me.ListadoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoButton.BackColor = System.Drawing.Color.SandyBrown
        Me.ListadoButton.Location = New System.Drawing.Point(850, 3)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(100, 23)
        Me.ListadoButton.TabIndex = 259
        Me.ListadoButton.Text = "Ver Listado"
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(54, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(46, 30)
        Me.AñoV.TabIndex = 260
        '
        'nAlumnosL
        '
        Me.nAlumnosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nAlumnosL.AutoSize = True
        Me.nAlumnosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAlumnosL.Location = New System.Drawing.Point(956, 0)
        Me.nAlumnosL.Name = "nAlumnosL"
        Me.nAlumnosL.Size = New System.Drawing.Size(1, 34)
        Me.nAlumnosL.TabIndex = 261
        Me.nAlumnosL.Text = "-"
        Me.nAlumnosL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nAlumnosL.Visible = False
        '
        'NotasPanel
        '
        Me.NotasPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasPanel.BackColor = System.Drawing.Color.Silver
        Me.NotasPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.NotasPanel.ColumnCount = 14
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.NotasPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NotasPanel.Controls.Add(Me.totalM, 10, 2)
        Me.NotasPanel.Controls.Add(Me.zonaM, 8, 2)
        Me.NotasPanel.Controls.Add(Me.examenM, 9, 2)
        Me.NotasPanel.Controls.Add(Me.C7M, 7, 2)
        Me.NotasPanel.Controls.Add(Me.C6M, 6, 2)
        Me.NotasPanel.Controls.Add(Me.C5M, 5, 2)
        Me.NotasPanel.Controls.Add(Me.C4M, 4, 2)
        Me.NotasPanel.Controls.Add(Me.C3M, 3, 2)
        Me.NotasPanel.Controls.Add(Me.C2M, 2, 2)
        Me.NotasPanel.Controls.Add(Me.C1M, 1, 2)
        Me.NotasPanel.Controls.Add(Me.C6V, 6, 1)
        Me.NotasPanel.Controls.Add(Me.C7V, 7, 1)
        Me.NotasPanel.Controls.Add(Me.C2V, 2, 1)
        Me.NotasPanel.Controls.Add(Me.ZonaV, 8, 1)
        Me.NotasPanel.Controls.Add(Me.C3V, 3, 1)
        Me.NotasPanel.Controls.Add(Me.ExamenV, 9, 1)
        Me.NotasPanel.Controls.Add(Me.C4V, 4, 1)
        Me.NotasPanel.Controls.Add(Me.TotalV, 10, 1)
        Me.NotasPanel.Controls.Add(Me.C5V, 5, 1)
        Me.NotasPanel.Controls.Add(Me.C1V, 1, 1)
        Me.NotasPanel.Controls.Add(Me.totalL, 10, 0)
        Me.NotasPanel.Controls.Add(Me.zonaL, 8, 0)
        Me.NotasPanel.Controls.Add(Me.examenL, 9, 0)
        Me.NotasPanel.Controls.Add(Me.C6L, 6, 0)
        Me.NotasPanel.Controls.Add(Me.C3L, 3, 0)
        Me.NotasPanel.Controls.Add(Me.C5L, 5, 0)
        Me.NotasPanel.Controls.Add(Me.C7L, 7, 0)
        Me.NotasPanel.Controls.Add(Me.C4L, 4, 0)
        Me.NotasPanel.Controls.Add(Me.C1L, 1, 0)
        Me.NotasPanel.Controls.Add(Me.C2L, 2, 0)
        Me.NotasPanel.Controls.Add(Me.Alumno, 0, 1)
        Me.NotasPanel.Controls.Add(Me.GuardarButton, 12, 0)
        Me.NotasPanel.Controls.Add(Me.MaximoL, 0, 2)
        Me.NotasPanel.Controls.Add(Me.semaforo, 11, 1)
        Me.NotasPanel.Controls.Add(Me.ltotal, 10, 3)
        Me.NotasPanel.Controls.Add(Me.lexamen, 9, 3)
        Me.NotasPanel.Controls.Add(Me.lzona, 8, 3)
        Me.NotasPanel.Controls.Add(Me.l7, 7, 3)
        Me.NotasPanel.Controls.Add(Me.l6, 6, 3)
        Me.NotasPanel.Controls.Add(Me.l5, 5, 3)
        Me.NotasPanel.Controls.Add(Me.l4, 4, 3)
        Me.NotasPanel.Controls.Add(Me.l3, 3, 3)
        Me.NotasPanel.Controls.Add(Me.l2, 2, 3)
        Me.NotasPanel.Controls.Add(Me.l1, 1, 3)
        Me.NotasPanel.Location = New System.Drawing.Point(0, 150)
        Me.NotasPanel.Name = "NotasPanel"
        Me.NotasPanel.RowCount = 4
        Me.NotasPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.NotasPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.NotasPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.NotasPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.NotasPanel.Size = New System.Drawing.Size(934, 63)
        Me.NotasPanel.TabIndex = 263
        Me.NotasPanel.Visible = False
        '
        'totalM
        '
        Me.totalM.AutoSize = True
        Me.totalM.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalM.Location = New System.Drawing.Point(633, 61)
        Me.totalM.Name = "totalM"
        Me.totalM.Size = New System.Drawing.Size(16, 20)
        Me.totalM.TabIndex = 270
        Me.totalM.Text = "0"
        '
        'zonaM
        '
        Me.zonaM.AutoSize = True
        Me.zonaM.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zonaM.Location = New System.Drawing.Point(549, 61)
        Me.zonaM.Name = "zonaM"
        Me.zonaM.Size = New System.Drawing.Size(16, 20)
        Me.zonaM.TabIndex = 270
        Me.zonaM.Text = "0"
        '
        'examenM
        '
        Me.examenM.AutoSize = True
        Me.examenM.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examenM.Location = New System.Drawing.Point(591, 61)
        Me.examenM.Name = "examenM"
        Me.examenM.Size = New System.Drawing.Size(16, 20)
        Me.examenM.TabIndex = 269
        Me.examenM.Text = "0"
        '
        'C7M
        '
        Me.C7M.AutoSize = True
        Me.C7M.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C7M.Location = New System.Drawing.Point(507, 61)
        Me.C7M.Name = "C7M"
        Me.C7M.Size = New System.Drawing.Size(16, 20)
        Me.C7M.TabIndex = 269
        Me.C7M.Text = "0"
        '
        'C6M
        '
        Me.C6M.AutoSize = True
        Me.C6M.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C6M.Location = New System.Drawing.Point(465, 61)
        Me.C6M.Name = "C6M"
        Me.C6M.Size = New System.Drawing.Size(16, 20)
        Me.C6M.TabIndex = 269
        Me.C6M.Text = "0"
        '
        'C5M
        '
        Me.C5M.AutoSize = True
        Me.C5M.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5M.Location = New System.Drawing.Point(423, 61)
        Me.C5M.Name = "C5M"
        Me.C5M.Size = New System.Drawing.Size(16, 20)
        Me.C5M.TabIndex = 269
        Me.C5M.Text = "0"
        '
        'C4M
        '
        Me.C4M.AutoSize = True
        Me.C4M.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4M.Location = New System.Drawing.Point(381, 61)
        Me.C4M.Name = "C4M"
        Me.C4M.Size = New System.Drawing.Size(16, 20)
        Me.C4M.TabIndex = 269
        Me.C4M.Text = "0"
        '
        'C3M
        '
        Me.C3M.AutoSize = True
        Me.C3M.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3M.Location = New System.Drawing.Point(339, 61)
        Me.C3M.Name = "C3M"
        Me.C3M.Size = New System.Drawing.Size(16, 20)
        Me.C3M.TabIndex = 269
        Me.C3M.Text = "0"
        '
        'C2M
        '
        Me.C2M.AutoSize = True
        Me.C2M.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2M.Location = New System.Drawing.Point(297, 61)
        Me.C2M.Name = "C2M"
        Me.C2M.Size = New System.Drawing.Size(16, 20)
        Me.C2M.TabIndex = 269
        Me.C2M.Text = "0"
        '
        'C1M
        '
        Me.C1M.AutoSize = True
        Me.C1M.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1M.Location = New System.Drawing.Point(255, 61)
        Me.C1M.Name = "C1M"
        Me.C1M.Size = New System.Drawing.Size(16, 20)
        Me.C1M.TabIndex = 268
        Me.C1M.Text = "0"
        '
        'C6V
        '
        Me.C6V.Location = New System.Drawing.Point(465, 27)
        Me.C6V.Name = "C6V"
        Me.C6V.Size = New System.Drawing.Size(35, 30)
        Me.C6V.TabIndex = 268
        Me.C6V.Text = "0"
        '
        'C7V
        '
        Me.C7V.Location = New System.Drawing.Point(507, 27)
        Me.C7V.Name = "C7V"
        Me.C7V.Size = New System.Drawing.Size(35, 30)
        Me.C7V.TabIndex = 269
        Me.C7V.Text = "0"
        '
        'C2V
        '
        Me.C2V.Location = New System.Drawing.Point(297, 27)
        Me.C2V.Name = "C2V"
        Me.C2V.Size = New System.Drawing.Size(35, 30)
        Me.C2V.TabIndex = 264
        Me.C2V.Text = "0"
        '
        'ZonaV
        '
        Me.ZonaV.Location = New System.Drawing.Point(549, 27)
        Me.ZonaV.Name = "ZonaV"
        Me.ZonaV.ReadOnly = True
        Me.ZonaV.Size = New System.Drawing.Size(35, 30)
        Me.ZonaV.TabIndex = 270
        Me.ZonaV.Text = "0"
        '
        'C3V
        '
        Me.C3V.Location = New System.Drawing.Point(339, 27)
        Me.C3V.Name = "C3V"
        Me.C3V.Size = New System.Drawing.Size(35, 30)
        Me.C3V.TabIndex = 265
        Me.C3V.Text = "0"
        '
        'ExamenV
        '
        Me.ExamenV.Location = New System.Drawing.Point(591, 27)
        Me.ExamenV.Name = "ExamenV"
        Me.ExamenV.Size = New System.Drawing.Size(35, 30)
        Me.ExamenV.TabIndex = 271
        Me.ExamenV.Text = "0"
        '
        'C4V
        '
        Me.C4V.Location = New System.Drawing.Point(381, 27)
        Me.C4V.Name = "C4V"
        Me.C4V.Size = New System.Drawing.Size(35, 30)
        Me.C4V.TabIndex = 266
        Me.C4V.Text = "0"
        '
        'TotalV
        '
        Me.TotalV.Location = New System.Drawing.Point(633, 27)
        Me.TotalV.Name = "TotalV"
        Me.TotalV.ReadOnly = True
        Me.TotalV.Size = New System.Drawing.Size(35, 30)
        Me.TotalV.TabIndex = 272
        Me.TotalV.Text = "0"
        '
        'C5V
        '
        Me.C5V.Location = New System.Drawing.Point(423, 27)
        Me.C5V.Name = "C5V"
        Me.C5V.Size = New System.Drawing.Size(35, 30)
        Me.C5V.TabIndex = 267
        Me.C5V.Text = "0"
        '
        'C1V
        '
        Me.C1V.Location = New System.Drawing.Point(255, 27)
        Me.C1V.Name = "C1V"
        Me.C1V.Size = New System.Drawing.Size(35, 30)
        Me.C1V.TabIndex = 263
        Me.C1V.Text = "0"
        '
        'totalL
        '
        Me.totalL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalL.AutoSize = True
        Me.totalL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalL.Location = New System.Drawing.Point(633, 1)
        Me.totalL.Name = "totalL"
        Me.totalL.Size = New System.Drawing.Size(35, 22)
        Me.totalL.TabIndex = 276
        Me.totalL.Text = "-"
        '
        'zonaL
        '
        Me.zonaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zonaL.AutoSize = True
        Me.zonaL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zonaL.Location = New System.Drawing.Point(549, 1)
        Me.zonaL.Name = "zonaL"
        Me.zonaL.Size = New System.Drawing.Size(35, 22)
        Me.zonaL.TabIndex = 272
        Me.zonaL.Text = "-"
        '
        'examenL
        '
        Me.examenL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.examenL.AutoSize = True
        Me.examenL.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examenL.Location = New System.Drawing.Point(591, 1)
        Me.examenL.Name = "examenL"
        Me.examenL.Size = New System.Drawing.Size(35, 22)
        Me.examenL.TabIndex = 274
        Me.examenL.Text = "-"
        '
        'C6L
        '
        Me.C6L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C6L.AutoSize = True
        Me.C6L.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C6L.Location = New System.Drawing.Point(465, 1)
        Me.C6L.Name = "C6L"
        Me.C6L.Size = New System.Drawing.Size(35, 22)
        Me.C6L.TabIndex = 270
        Me.C6L.Text = "-"
        '
        'C3L
        '
        Me.C3L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C3L.AutoSize = True
        Me.C3L.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3L.Location = New System.Drawing.Point(339, 1)
        Me.C3L.Name = "C3L"
        Me.C3L.Size = New System.Drawing.Size(35, 22)
        Me.C3L.TabIndex = 268
        Me.C3L.Text = "-"
        '
        'C5L
        '
        Me.C5L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C5L.AutoSize = True
        Me.C5L.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C5L.Location = New System.Drawing.Point(423, 1)
        Me.C5L.Name = "C5L"
        Me.C5L.Size = New System.Drawing.Size(35, 22)
        Me.C5L.TabIndex = 271
        Me.C5L.Text = "-"
        '
        'C7L
        '
        Me.C7L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C7L.AutoSize = True
        Me.C7L.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C7L.Location = New System.Drawing.Point(507, 1)
        Me.C7L.Name = "C7L"
        Me.C7L.Size = New System.Drawing.Size(35, 22)
        Me.C7L.TabIndex = 273
        Me.C7L.Text = "-"
        '
        'C4L
        '
        Me.C4L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C4L.AutoSize = True
        Me.C4L.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4L.Location = New System.Drawing.Point(381, 1)
        Me.C4L.Name = "C4L"
        Me.C4L.Size = New System.Drawing.Size(35, 22)
        Me.C4L.TabIndex = 269
        Me.C4L.Text = "-"
        '
        'C1L
        '
        Me.C1L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1L.AutoSize = True
        Me.C1L.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1L.Location = New System.Drawing.Point(255, 1)
        Me.C1L.Name = "C1L"
        Me.C1L.Size = New System.Drawing.Size(35, 22)
        Me.C1L.TabIndex = 267
        Me.C1L.Text = "-"
        '
        'C2L
        '
        Me.C2L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C2L.AutoSize = True
        Me.C2L.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2L.Location = New System.Drawing.Point(297, 1)
        Me.C2L.Name = "C2L"
        Me.C2L.Size = New System.Drawing.Size(35, 22)
        Me.C2L.TabIndex = 268
        Me.C2L.Text = "-"
        '
        'Alumno
        '
        Me.Alumno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Alumno.AutoSize = True
        Me.Alumno.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Alumno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alumno.Location = New System.Drawing.Point(4, 24)
        Me.Alumno.Name = "Alumno"
        Me.Alumno.Size = New System.Drawing.Size(244, 36)
        Me.Alumno.TabIndex = 277
        Me.Alumno.Text = "Seleccionar Alumno"
        Me.Alumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaximoL
        '
        Me.MaximoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximoL.AutoSize = True
        Me.MaximoL.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximoL.Location = New System.Drawing.Point(4, 61)
        Me.MaximoL.Name = "MaximoL"
        Me.MaximoL.Size = New System.Drawing.Size(244, 20)
        Me.MaximoL.TabIndex = 269
        Me.MaximoL.Text = "Max"
        Me.MaximoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'semaforo
        '
        Me.semaforo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.semaforo.AutoSize = True
        Me.semaforo.Location = New System.Drawing.Point(675, 24)
        Me.semaforo.Name = "semaforo"
        Me.semaforo.Size = New System.Drawing.Size(24, 23)
        Me.semaforo.TabIndex = 278
        Me.semaforo.Text = " "
        '
        'ltotal
        '
        Me.ltotal.AutoSize = True
        Me.ltotal.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltotal.Location = New System.Drawing.Point(633, 82)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.Size = New System.Drawing.Size(16, 20)
        Me.ltotal.TabIndex = 286
        Me.ltotal.Text = "0"
        '
        'lexamen
        '
        Me.lexamen.AutoSize = True
        Me.lexamen.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lexamen.Location = New System.Drawing.Point(591, 82)
        Me.lexamen.Name = "lexamen"
        Me.lexamen.Size = New System.Drawing.Size(16, 20)
        Me.lexamen.TabIndex = 284
        Me.lexamen.Text = "0"
        '
        'lzona
        '
        Me.lzona.AutoSize = True
        Me.lzona.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lzona.Location = New System.Drawing.Point(549, 82)
        Me.lzona.Name = "lzona"
        Me.lzona.Size = New System.Drawing.Size(16, 20)
        Me.lzona.TabIndex = 281
        Me.lzona.Text = "0"
        '
        'l7
        '
        Me.l7.AutoSize = True
        Me.l7.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l7.Location = New System.Drawing.Point(507, 82)
        Me.l7.Name = "l7"
        Me.l7.Size = New System.Drawing.Size(16, 20)
        Me.l7.TabIndex = 280
        Me.l7.Text = "0"
        '
        'l6
        '
        Me.l6.AutoSize = True
        Me.l6.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l6.Location = New System.Drawing.Point(465, 82)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(16, 20)
        Me.l6.TabIndex = 282
        Me.l6.Text = "0"
        '
        'l5
        '
        Me.l5.AutoSize = True
        Me.l5.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5.Location = New System.Drawing.Point(423, 82)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(16, 20)
        Me.l5.TabIndex = 279
        Me.l5.Text = "0"
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.Location = New System.Drawing.Point(381, 82)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(16, 20)
        Me.l4.TabIndex = 285
        Me.l4.Text = "0"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.Location = New System.Drawing.Point(339, 82)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(16, 20)
        Me.l3.TabIndex = 288
        Me.l3.Text = "0"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(297, 82)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(16, 20)
        Me.l2.TabIndex = 287
        Me.l2.Text = "0"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(255, 82)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(16, 20)
        Me.l1.TabIndex = 283
        Me.l1.Text = "0"
        '
        'CalificacionesPRIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.NotasPanel)
        Me.Controls.Add(Me.DatosTable)
        Me.Controls.Add(Me.CalificacionesGrid)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CalificacionesPRIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalificacionesPrimaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        CType(Me.CalificacionesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.NotasPanel.ResumeLayout(False)
        Me.NotasPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents CalificacionesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ClasesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents CicloL As System.Windows.Forms.Label
    Friend WithEvents CicloCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ClaseL As System.Windows.Forms.Label
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents NotasPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents totalM As System.Windows.Forms.Label
    Friend WithEvents zonaM As System.Windows.Forms.Label
    Friend WithEvents examenM As System.Windows.Forms.Label
    Friend WithEvents C7M As System.Windows.Forms.Label
    Friend WithEvents C6M As System.Windows.Forms.Label
    Friend WithEvents C5M As System.Windows.Forms.Label
    Friend WithEvents C4M As System.Windows.Forms.Label
    Friend WithEvents C3M As System.Windows.Forms.Label
    Friend WithEvents C2M As System.Windows.Forms.Label
    Friend WithEvents C1M As System.Windows.Forms.Label
    Friend WithEvents C6V As System.Windows.Forms.TextBox
    Friend WithEvents C7V As System.Windows.Forms.TextBox
    Friend WithEvents C2V As System.Windows.Forms.TextBox
    Friend WithEvents ZonaV As System.Windows.Forms.TextBox
    Friend WithEvents C3V As System.Windows.Forms.TextBox
    Friend WithEvents ExamenV As System.Windows.Forms.TextBox
    Friend WithEvents C4V As System.Windows.Forms.TextBox
    Friend WithEvents TotalV As System.Windows.Forms.TextBox
    Friend WithEvents C5V As System.Windows.Forms.TextBox
    Friend WithEvents C1V As System.Windows.Forms.TextBox
    Friend WithEvents totalL As System.Windows.Forms.Label
    Friend WithEvents zonaL As System.Windows.Forms.Label
    Friend WithEvents examenL As System.Windows.Forms.Label
    Friend WithEvents C6L As System.Windows.Forms.Label
    Friend WithEvents C3L As System.Windows.Forms.Label
    Friend WithEvents C5L As System.Windows.Forms.Label
    Friend WithEvents C7L As System.Windows.Forms.Label
    Friend WithEvents C4L As System.Windows.Forms.Label
    Friend WithEvents C1L As System.Windows.Forms.Label
    Friend WithEvents C2L As System.Windows.Forms.Label
    Friend WithEvents MaximoL As System.Windows.Forms.Label
    Friend WithEvents Alumno As System.Windows.Forms.Label
    Friend WithEvents semaforo As System.Windows.Forms.Label
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents lexamen As System.Windows.Forms.Label
    Friend WithEvents lzona As System.Windows.Forms.Label
    Friend WithEvents l7 As System.Windows.Forms.Label
    Friend WithEvents l6 As System.Windows.Forms.Label
    Friend WithEvents l5 As System.Windows.Forms.Label
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents nAlumnosL As System.Windows.Forms.Label
End Class
