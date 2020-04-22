<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoAñoEscolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoAñoEscolar))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.ClasificacionV = New System.Windows.Forms.Label()
        Me.ClasificacionL = New System.Windows.Forms.Label()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.GradoV = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EscuelaV = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.Label()
        Me.EstadoCombo = New System.Windows.Forms.ComboBox()
        Me.EstadoV = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.nAñoPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ExcepcionEL = New System.Windows.Forms.Label()
        Me.CreationDateL = New System.Windows.Forms.Label()
        Me.nNotasV = New System.Windows.Forms.TextBox()
        Me.nNotasL = New System.Windows.Forms.Label()
        Me.PorcentajeV = New System.Windows.Forms.TextBox()
        Me.ExcepcionECombo = New System.Windows.Forms.ComboBox()
        Me.PorcentajeL = New System.Windows.Forms.Label()
        Me.nMaestroL = New System.Windows.Forms.Label()
        Me.nMaestroCombo = New System.Windows.Forms.ComboBox()
        Me.nGradoId = New System.Windows.Forms.Label()
        Me.nSeccionV = New System.Windows.Forms.TextBox()
        Me.nSeccionL = New System.Windows.Forms.Label()
        Me.nEstadoL = New System.Windows.Forms.Label()
        Me.nAñoL = New System.Windows.Forms.Label()
        Me.nAñoV = New System.Windows.Forms.TextBox()
        Me.nEstadoCombo = New System.Windows.Forms.ComboBox()
        Me.nCarreraCombo = New System.Windows.Forms.ComboBox()
        Me.nCarreraL = New System.Windows.Forms.Label()
        Me.nEscuelaCombo = New System.Windows.Forms.ComboBox()
        Me.nEscuelaL = New System.Windows.Forms.Label()
        Me.nGradoCombo = New System.Windows.Forms.ComboBox()
        Me.nGradoL = New System.Windows.Forms.Label()
        Me.HistorialTable = New System.Windows.Forms.TableLayoutPanel()
        Me.HistorialActividadesCheck = New System.Windows.Forms.CheckBox()
        Me.HistorialObserCheck = New System.Windows.Forms.CheckBox()
        Me.HistorialEducCheck = New System.Windows.Forms.CheckBox()
        Me.HistorialGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.PanelSecundario.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.nAñoPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.HistorialTable.SuspendLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bannerPanel.TabIndex = 259
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
        Me.GuardarButton.TabIndex = 8
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
        Me.Title.Text = "Nuevo Año Escolar"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 8
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.Controls.Add(Me.ClasificacionV, 1, 2)
        Me.PanelSecundario.Controls.Add(Me.ClasificacionL, 0, 2)
        Me.PanelSecundario.Controls.Add(Me.EstadoL, 3, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoV, 1, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoL, 0, 1)
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.Label2, 6, 1)
        Me.PanelSecundario.Controls.Add(Me.EscuelaV, 7, 1)
        Me.PanelSecundario.Controls.Add(Me.AñoL, 6, 0)
        Me.PanelSecundario.Controls.Add(Me.AñoV, 7, 0)
        Me.PanelSecundario.Controls.Add(Me.EstadoCombo, 4, 2)
        Me.PanelSecundario.Controls.Add(Me.EstadoV, 4, 1)
        Me.PanelSecundario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 155)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 3
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.Size = New System.Drawing.Size(984, 68)
        Me.PanelSecundario.TabIndex = 262
        Me.PanelSecundario.Visible = False
        '
        'ClasificacionV
        '
        Me.ClasificacionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionV.AutoSize = True
        Me.ClasificacionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClasificacionV.Location = New System.Drawing.Point(134, 46)
        Me.ClasificacionV.Name = "ClasificacionV"
        Me.ClasificacionV.Size = New System.Drawing.Size(21, 22)
        Me.ClasificacionV.TabIndex = 203
        Me.ClasificacionV.Text = "_"
        '
        'ClasificacionL
        '
        Me.ClasificacionL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionL.AutoSize = True
        Me.ClasificacionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionL.Location = New System.Drawing.Point(3, 46)
        Me.ClasificacionL.Name = "ClasificacionL"
        Me.ClasificacionL.Size = New System.Drawing.Size(125, 22)
        Me.ClasificacionL.TabIndex = 70
        Me.ClasificacionL.Text = "Clasificación:"
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoL.Location = New System.Drawing.Point(246, 23)
        Me.EstadoL.Name = "EstadoL"
        Me.PanelSecundario.SetRowSpan(Me.EstadoL, 2)
        Me.EstadoL.Size = New System.Drawing.Size(78, 45)
        Me.EstadoL.TabIndex = 261
        Me.EstadoL.Text = "Estado:"
        '
        'GradoV
        '
        Me.GradoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoV.AutoSize = True
        Me.GradoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GradoV.Location = New System.Drawing.Point(134, 23)
        Me.GradoV.Name = "GradoV"
        Me.GradoV.Size = New System.Drawing.Size(21, 23)
        Me.GradoV.TabIndex = 202
        Me.GradoV.Text = "_"
        '
        'GradoL
        '
        Me.GradoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoL.AutoSize = True
        Me.GradoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoL.Location = New System.Drawing.Point(3, 23)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(125, 23)
        Me.GradoL.TabIndex = 69
        Me.GradoL.Text = "Grado:"
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(125, 23)
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
        Me.NombreV.Location = New System.Drawing.Point(134, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(21, 23)
        Me.NombreV.TabIndex = 2
        Me.NombreV.Text = "_"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(869, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 23)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Escuela:"
        '
        'EscuelaV
        '
        Me.EscuelaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EscuelaV.AutoSize = True
        Me.EscuelaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EscuelaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EscuelaV.Location = New System.Drawing.Point(960, 23)
        Me.EscuelaV.Name = "EscuelaV"
        Me.EscuelaV.Size = New System.Drawing.Size(21, 23)
        Me.EscuelaV.TabIndex = 202
        Me.EscuelaV.Text = "_"
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoL.Location = New System.Drawing.Point(869, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(85, 23)
        Me.AñoL.TabIndex = 202
        Me.AñoL.Text = "Año:"
        '
        'AñoV
        '
        Me.AñoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoV.AutoSize = True
        Me.AñoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AñoV.Location = New System.Drawing.Point(960, 0)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(21, 23)
        Me.AñoV.TabIndex = 202
        Me.AñoV.Text = "_"
        '
        'EstadoCombo
        '
        Me.EstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoCombo.FormattingEnabled = True
        Me.EstadoCombo.Location = New System.Drawing.Point(330, 49)
        Me.EstadoCombo.Name = "EstadoCombo"
        Me.EstadoCombo.Size = New System.Drawing.Size(448, 31)
        Me.EstadoCombo.TabIndex = 69
        '
        'EstadoV
        '
        Me.EstadoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoV.AutoSize = True
        Me.EstadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EstadoV.Location = New System.Drawing.Point(330, 23)
        Me.EstadoV.Name = "EstadoV"
        Me.EstadoV.Size = New System.Drawing.Size(448, 23)
        Me.EstadoV.TabIndex = 261
        Me.EstadoV.Text = "_"
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.AliceBlue
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
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(984, 36)
        Me.PrincipalPanel.TabIndex = 261
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(149, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 40)
        Me.FamiliaV.TabIndex = 101
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(867, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(112, 40)
        Me.MiembroV.TabIndex = 100
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(706, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(155, 36)
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
        Me.FamiliaL.Size = New System.Drawing.Size(140, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nAñoPanel
        '
        Me.nAñoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nAñoPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.nAñoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nAñoPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.nAñoPanel.Location = New System.Drawing.Point(0, 230)
        Me.nAñoPanel.Name = "nAñoPanel"
        Me.nAñoPanel.Size = New System.Drawing.Size(984, 186)
        Me.nAñoPanel.TabIndex = 0
        Me.nAñoPanel.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ExcepcionEL, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CreationDateL, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nNotasV, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nNotasL, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PorcentajeV, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ExcepcionECombo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PorcentajeL, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nMaestroL, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nMaestroCombo, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nGradoId, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nSeccionV, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nSeccionL, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nEstadoL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nAñoL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nAñoV, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nEstadoCombo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nCarreraCombo, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nCarreraL, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nEscuelaCombo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nEscuelaL, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nGradoCombo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nGradoL, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(980, 175)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ExcepcionEL
        '
        Me.ExcepcionEL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExcepcionEL.AutoSize = True
        Me.ExcepcionEL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcepcionEL.Location = New System.Drawing.Point(3, 58)
        Me.ExcepcionEL.Name = "ExcepcionEL"
        Me.ExcepcionEL.Size = New System.Drawing.Size(187, 28)
        Me.ExcepcionEL.TabIndex = 264
        Me.ExcepcionEL.Text = "Excepción Estado:"
        Me.ExcepcionEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CreationDateL
        '
        Me.CreationDateL.AutoSize = True
        Me.CreationDateL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreationDateL.Location = New System.Drawing.Point(595, 0)
        Me.CreationDateL.Name = "CreationDateL"
        Me.CreationDateL.Size = New System.Drawing.Size(14, 23)
        Me.CreationDateL.TabIndex = 209
        Me.CreationDateL.Text = "_"
        Me.CreationDateL.Visible = False
        '
        'nNotasV
        '
        Me.nNotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nNotasV.Location = New System.Drawing.Point(717, 117)
        Me.nNotasV.MaxLength = 100
        Me.nNotasV.Name = "nNotasV"
        Me.nNotasV.Size = New System.Drawing.Size(260, 30)
        Me.nNotasV.TabIndex = 10
        '
        'nNotasL
        '
        Me.nNotasL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nNotasL.AutoSize = True
        Me.nNotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nNotasL.Location = New System.Drawing.Point(615, 114)
        Me.nNotasL.Name = "nNotasL"
        Me.nNotasL.Size = New System.Drawing.Size(96, 28)
        Me.nNotasL.TabIndex = 276
        Me.nNotasL.Text = "Notas:"
        Me.nNotasL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PorcentajeV
        '
        Me.PorcentajeV.Location = New System.Drawing.Point(717, 89)
        Me.PorcentajeV.MaxLength = 10
        Me.PorcentajeV.Name = "PorcentajeV"
        Me.PorcentajeV.Size = New System.Drawing.Size(100, 30)
        Me.PorcentajeV.TabIndex = 9
        '
        'ExcepcionECombo
        '
        Me.ExcepcionECombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExcepcionECombo.FormattingEnabled = True
        Me.ExcepcionECombo.Location = New System.Drawing.Point(196, 61)
        Me.ExcepcionECombo.Name = "ExcepcionECombo"
        Me.ExcepcionECombo.Size = New System.Drawing.Size(393, 31)
        Me.ExcepcionECombo.TabIndex = 3
        '
        'PorcentajeL
        '
        Me.PorcentajeL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorcentajeL.AutoSize = True
        Me.PorcentajeL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeL.Location = New System.Drawing.Point(615, 86)
        Me.PorcentajeL.Name = "PorcentajeL"
        Me.PorcentajeL.Size = New System.Drawing.Size(96, 28)
        Me.PorcentajeL.TabIndex = 277
        Me.PorcentajeL.Text = "% Pagos:"
        Me.PorcentajeL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nMaestroL
        '
        Me.nMaestroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nMaestroL.AutoSize = True
        Me.nMaestroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nMaestroL.Location = New System.Drawing.Point(615, 30)
        Me.nMaestroL.Name = "nMaestroL"
        Me.nMaestroL.Size = New System.Drawing.Size(96, 28)
        Me.nMaestroL.TabIndex = 270
        Me.nMaestroL.Text = "Maestro:"
        Me.nMaestroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nMaestroCombo
        '
        Me.nMaestroCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nMaestroCombo.FormattingEnabled = True
        Me.nMaestroCombo.Location = New System.Drawing.Point(717, 33)
        Me.nMaestroCombo.Name = "nMaestroCombo"
        Me.nMaestroCombo.Size = New System.Drawing.Size(260, 31)
        Me.nMaestroCombo.TabIndex = 7
        '
        'nGradoId
        '
        Me.nGradoId.AutoSize = True
        Me.nGradoId.Location = New System.Drawing.Point(595, 58)
        Me.nGradoId.Name = "nGradoId"
        Me.nGradoId.Size = New System.Drawing.Size(14, 23)
        Me.nGradoId.TabIndex = 272
        Me.nGradoId.Text = "."
        Me.nGradoId.Visible = False
        '
        'nSeccionV
        '
        Me.nSeccionV.Location = New System.Drawing.Point(717, 61)
        Me.nSeccionV.MaxLength = 1
        Me.nSeccionV.Name = "nSeccionV"
        Me.nSeccionV.Size = New System.Drawing.Size(31, 30)
        Me.nSeccionV.TabIndex = 8
        Me.nSeccionV.Visible = False
        '
        'nSeccionL
        '
        Me.nSeccionL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nSeccionL.AutoSize = True
        Me.nSeccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSeccionL.Location = New System.Drawing.Point(615, 58)
        Me.nSeccionL.Name = "nSeccionL"
        Me.nSeccionL.Size = New System.Drawing.Size(96, 28)
        Me.nSeccionL.TabIndex = 275
        Me.nSeccionL.Text = "Sección:"
        Me.nSeccionL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nSeccionL.Visible = False
        '
        'nEstadoL
        '
        Me.nEstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nEstadoL.AutoSize = True
        Me.nEstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nEstadoL.Location = New System.Drawing.Point(3, 30)
        Me.nEstadoL.Name = "nEstadoL"
        Me.nEstadoL.Size = New System.Drawing.Size(91, 28)
        Me.nEstadoL.TabIndex = 69
        Me.nEstadoL.Text = "*Estado:"
        Me.nEstadoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nAñoL
        '
        Me.nAñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nAñoL.AutoSize = True
        Me.nAñoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAñoL.Location = New System.Drawing.Point(3, 0)
        Me.nAñoL.Name = "nAñoL"
        Me.nAñoL.Size = New System.Drawing.Size(127, 30)
        Me.nAñoL.TabIndex = 0
        Me.nAñoL.Text = "*Nuevo Año:"
        Me.nAñoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nAñoV
        '
        Me.nAñoV.Location = New System.Drawing.Point(196, 3)
        Me.nAñoV.Name = "nAñoV"
        Me.nAñoV.Size = New System.Drawing.Size(100, 30)
        Me.nAñoV.TabIndex = 1
        '
        'nEstadoCombo
        '
        Me.nEstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEstadoCombo.FormattingEnabled = True
        Me.nEstadoCombo.Location = New System.Drawing.Point(196, 33)
        Me.nEstadoCombo.Name = "nEstadoCombo"
        Me.nEstadoCombo.Size = New System.Drawing.Size(393, 31)
        Me.nEstadoCombo.TabIndex = 2
        '
        'nCarreraCombo
        '
        Me.nCarreraCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nCarreraCombo.FormattingEnabled = True
        Me.nCarreraCombo.Location = New System.Drawing.Point(196, 145)
        Me.nCarreraCombo.Name = "nCarreraCombo"
        Me.nCarreraCombo.Size = New System.Drawing.Size(393, 31)
        Me.nCarreraCombo.TabIndex = 6
        Me.nCarreraCombo.Visible = False
        '
        'nCarreraL
        '
        Me.nCarreraL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nCarreraL.AutoSize = True
        Me.nCarreraL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nCarreraL.Location = New System.Drawing.Point(3, 142)
        Me.nCarreraL.Name = "nCarreraL"
        Me.nCarreraL.Size = New System.Drawing.Size(96, 33)
        Me.nCarreraL.TabIndex = 71
        Me.nCarreraL.Text = "*Carrera:"
        Me.nCarreraL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nCarreraL.Visible = False
        '
        'nEscuelaCombo
        '
        Me.nEscuelaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEscuelaCombo.FormattingEnabled = True
        Me.nEscuelaCombo.Location = New System.Drawing.Point(196, 117)
        Me.nEscuelaCombo.Name = "nEscuelaCombo"
        Me.nEscuelaCombo.Size = New System.Drawing.Size(393, 31)
        Me.nEscuelaCombo.TabIndex = 5
        '
        'nEscuelaL
        '
        Me.nEscuelaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nEscuelaL.AutoSize = True
        Me.nEscuelaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nEscuelaL.Location = New System.Drawing.Point(3, 114)
        Me.nEscuelaL.Name = "nEscuelaL"
        Me.nEscuelaL.Size = New System.Drawing.Size(99, 28)
        Me.nEscuelaL.TabIndex = 70
        Me.nEscuelaL.Text = "*Escuela:"
        Me.nEscuelaL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nGradoCombo
        '
        Me.nGradoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nGradoCombo.FormattingEnabled = True
        Me.nGradoCombo.Location = New System.Drawing.Point(196, 89)
        Me.nGradoCombo.Name = "nGradoCombo"
        Me.nGradoCombo.Size = New System.Drawing.Size(393, 31)
        Me.nGradoCombo.TabIndex = 4
        '
        'nGradoL
        '
        Me.nGradoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nGradoL.AutoSize = True
        Me.nGradoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nGradoL.Location = New System.Drawing.Point(3, 86)
        Me.nGradoL.Name = "nGradoL"
        Me.nGradoL.Size = New System.Drawing.Size(84, 28)
        Me.nGradoL.TabIndex = 70
        Me.nGradoL.Text = "*Grado:"
        Me.nGradoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HistorialTable
        '
        Me.HistorialTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialTable.BackColor = System.Drawing.Color.Transparent
        Me.HistorialTable.ColumnCount = 3
        Me.HistorialTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.HistorialTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.HistorialTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.HistorialTable.Controls.Add(Me.HistorialActividadesCheck, 2, 0)
        Me.HistorialTable.Controls.Add(Me.HistorialObserCheck, 1, 0)
        Me.HistorialTable.Controls.Add(Me.HistorialEducCheck, 0, 0)
        Me.HistorialTable.Controls.Add(Me.HistorialGrid, 0, 1)
        Me.HistorialTable.Location = New System.Drawing.Point(0, 447)
        Me.HistorialTable.Name = "HistorialTable"
        Me.HistorialTable.RowCount = 2
        Me.HistorialTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HistorialTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HistorialTable.Size = New System.Drawing.Size(984, 214)
        Me.HistorialTable.TabIndex = 263
        Me.HistorialTable.Visible = False
        '
        'HistorialActividadesCheck
        '
        Me.HistorialActividadesCheck.AutoSize = True
        Me.HistorialActividadesCheck.Location = New System.Drawing.Point(659, 3)
        Me.HistorialActividadesCheck.Name = "HistorialActividadesCheck"
        Me.HistorialActividadesCheck.Size = New System.Drawing.Size(211, 27)
        Me.HistorialActividadesCheck.TabIndex = 70
        Me.HistorialActividadesCheck.Text = "Historial Actividades"
        Me.HistorialActividadesCheck.UseVisualStyleBackColor = True
        '
        'HistorialObserCheck
        '
        Me.HistorialObserCheck.AutoSize = True
        Me.HistorialObserCheck.Location = New System.Drawing.Point(331, 3)
        Me.HistorialObserCheck.Name = "HistorialObserCheck"
        Me.HistorialObserCheck.Size = New System.Drawing.Size(243, 27)
        Me.HistorialObserCheck.TabIndex = 69
        Me.HistorialObserCheck.Text = "Historial Observaciones"
        Me.HistorialObserCheck.UseVisualStyleBackColor = True
        '
        'HistorialEducCheck
        '
        Me.HistorialEducCheck.AutoSize = True
        Me.HistorialEducCheck.Location = New System.Drawing.Point(3, 3)
        Me.HistorialEducCheck.Name = "HistorialEducCheck"
        Me.HistorialEducCheck.Size = New System.Drawing.Size(197, 27)
        Me.HistorialEducCheck.TabIndex = 0
        Me.HistorialEducCheck.Text = "Historial Educativo"
        Me.HistorialEducCheck.UseVisualStyleBackColor = True
        '
        'HistorialGrid
        '
        Me.HistorialGrid.AllowUserToAddRows = False
        Me.HistorialGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistorialGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialGrid.BackgroundColor = System.Drawing.Color.White
        Me.HistorialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialTable.SetColumnSpan(Me.HistorialGrid, 3)
        Me.HistorialGrid.Location = New System.Drawing.Point(3, 36)
        Me.HistorialGrid.Name = "HistorialGrid"
        Me.HistorialGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.HistorialGrid.Size = New System.Drawing.Size(978, 175)
        Me.HistorialGrid.TabIndex = 255
        Me.HistorialGrid.Visible = False
        '
        'NuevoAñoEscolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.HistorialTable)
        Me.Controls.Add(Me.nAñoPanel)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NuevoAñoEscolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Año Escolar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.nAñoPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.HistorialTable.ResumeLayout(False)
        Me.HistorialTable.PerformLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents GradoV As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EscuelaV As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.Label
    Friend WithEvents EstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoV As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents nAñoPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nAñoL As System.Windows.Forms.Label
    Friend WithEvents nAñoV As System.Windows.Forms.TextBox
    Friend WithEvents nEstadoL As System.Windows.Forms.Label
    Friend WithEvents nCarreraL As System.Windows.Forms.Label
    Friend WithEvents nEscuelaL As System.Windows.Forms.Label
    Friend WithEvents nGradoL As System.Windows.Forms.Label
    Friend WithEvents nCarreraCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nEscuelaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nGradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nEstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nGradoId As System.Windows.Forms.Label
    Friend WithEvents nMaestroL As System.Windows.Forms.Label
    Friend WithEvents nMaestroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nNotasV As System.Windows.Forms.TextBox
    Friend WithEvents nNotasL As System.Windows.Forms.Label
    Friend WithEvents PorcentajeV As System.Windows.Forms.TextBox
    Friend WithEvents PorcentajeL As System.Windows.Forms.Label
    Friend WithEvents nSeccionV As System.Windows.Forms.TextBox
    Friend WithEvents nSeccionL As System.Windows.Forms.Label
    Friend WithEvents HistorialTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HistorialActividadesCheck As System.Windows.Forms.CheckBox
    Friend WithEvents HistorialObserCheck As System.Windows.Forms.CheckBox
    Friend WithEvents HistorialEducCheck As System.Windows.Forms.CheckBox
    Friend WithEvents HistorialGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CreationDateL As System.Windows.Forms.Label
    Friend WithEvents ClasificacionV As System.Windows.Forms.Label
    Friend WithEvents ClasificacionL As System.Windows.Forms.Label
    Friend WithEvents ExcepcionEL As System.Windows.Forms.Label
    Friend WithEvents ExcepcionECombo As System.Windows.Forms.ComboBox
End Class
