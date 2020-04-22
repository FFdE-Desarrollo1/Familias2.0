<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoAñoEscolar_PorGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoAñoEscolar_PorGrupo))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.busquetaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.EstadoCombo = New System.Windows.Forms.ComboBox()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.SeccionL = New System.Windows.Forms.Label()
        Me.SeccionV = New System.Windows.Forms.TextBox()
        Me.EscuelaL = New System.Windows.Forms.Label()
        Me.EscuelaCombo = New System.Windows.Forms.ComboBox()
        Me.codigoG = New System.Windows.Forms.Label()
        Me.indicacionesL = New System.Windows.Forms.Label()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.SeleccionarCheck = New System.Windows.Forms.CheckBox()
        Me.nEstadoCombo = New System.Windows.Forms.ComboBox()
        Me.registroTable = New System.Windows.Forms.TableLayoutPanel()
        Me.nSeccionL = New System.Windows.Forms.Label()
        Me.nEscuelaCombo = New System.Windows.Forms.ComboBox()
        Me.nuevoAñoL = New System.Windows.Forms.Label()
        Me.nEscuelaL = New System.Windows.Forms.Label()
        Me.nGradoCombo = New System.Windows.Forms.ComboBox()
        Me.nGradoL = New System.Windows.Forms.Label()
        Me.nAñoV = New System.Windows.Forms.TextBox()
        Me.nAñoL = New System.Windows.Forms.Label()
        Me.nEstadoL = New System.Windows.Forms.Label()
        Me.nSeccionV = New System.Windows.Forms.TextBox()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.proximoAñoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.busquetaTable.SuspendLayout()
        Me.registroTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.proximoAñoTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(1218, 148)
        Me.bannerPanel.TabIndex = 271
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
        Me.opcionesTable.Location = New System.Drawing.Point(125, 76)
        Me.opcionesTable.Margin = New System.Windows.Forms.Padding(4)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(1090, 66)
        Me.opcionesTable.TabIndex = 68
        '
        'ListadoButton
        '
        Me.ListadoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.ListadoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.ListaIcon
        Me.ListadoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ListadoButton.Location = New System.Drawing.Point(1027, 4)
        Me.ListadoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(59, 56)
        Me.ListadoButton.TabIndex = 238
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(882, 4)
        Me.NuevoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(65, 55)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(814, 4)
        Me.inicioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(60, 56)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(955, 4)
        Me.GuardarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(64, 56)
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
        Me.Title.Location = New System.Drawing.Point(5, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(800, 66)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Ingresar Nuevo Año Escolar Por Grupo"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'busquetaTable
        '
        Me.busquetaTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.busquetaTable.BackColor = System.Drawing.Color.LightBlue
        Me.busquetaTable.ColumnCount = 5
        Me.busquetaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.busquetaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.busquetaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.busquetaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.busquetaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.busquetaTable.Controls.Add(Me.AñoV, 1, 1)
        Me.busquetaTable.Controls.Add(Me.AñoL, 0, 1)
        Me.busquetaTable.Controls.Add(Me.EstadoL, 0, 2)
        Me.busquetaTable.Controls.Add(Me.EstadoCombo, 1, 2)
        Me.busquetaTable.Controls.Add(Me.GradoL, 0, 3)
        Me.busquetaTable.Controls.Add(Me.GradoCombo, 1, 3)
        Me.busquetaTable.Controls.Add(Me.SeccionL, 3, 3)
        Me.busquetaTable.Controls.Add(Me.SeccionV, 4, 3)
        Me.busquetaTable.Controls.Add(Me.EscuelaL, 0, 4)
        Me.busquetaTable.Controls.Add(Me.EscuelaCombo, 1, 4)
        Me.busquetaTable.Controls.Add(Me.codigoG, 3, 1)
        Me.busquetaTable.Controls.Add(Me.indicacionesL, 0, 0)
        Me.busquetaTable.Location = New System.Drawing.Point(3, 3)
        Me.busquetaTable.Name = "busquetaTable"
        Me.busquetaTable.RowCount = 5
        Me.busquetaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.busquetaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.busquetaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.busquetaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.busquetaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.busquetaTable.Size = New System.Drawing.Size(578, 176)
        Me.busquetaTable.TabIndex = 272
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(105, 28)
        Me.AñoV.MaxLength = 10
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(95, 30)
        Me.AñoV.TabIndex = 71
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.Location = New System.Drawing.Point(3, 25)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(96, 25)
        Me.AñoL.TabIndex = 70
        Me.AñoL.Text = "*Año:"
        Me.AñoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Location = New System.Drawing.Point(3, 61)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(96, 25)
        Me.EstadoL.TabIndex = 72
        Me.EstadoL.Text = "Estado:"
        Me.EstadoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EstadoCombo
        '
        Me.EstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoCombo.FormattingEnabled = True
        Me.EstadoCombo.Location = New System.Drawing.Point(105, 64)
        Me.EstadoCombo.Name = "EstadoCombo"
        Me.EstadoCombo.Size = New System.Drawing.Size(299, 33)
        Me.EstadoCombo.TabIndex = 73
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.Location = New System.Drawing.Point(3, 100)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(80, 25)
        Me.GradoL.TabIndex = 0
        Me.GradoL.Text = "*Grado:"
        Me.GradoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GradoCombo
        '
        Me.GradoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(105, 103)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(299, 33)
        Me.GradoCombo.TabIndex = 1
        '
        'SeccionL
        '
        Me.SeccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeccionL.AutoSize = True
        Me.SeccionL.Location = New System.Drawing.Point(430, 100)
        Me.SeccionL.Name = "SeccionL"
        Me.SeccionL.Size = New System.Drawing.Size(89, 25)
        Me.SeccionL.TabIndex = 71
        Me.SeccionL.Text = "Sección:"
        Me.SeccionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.SeccionL.Visible = False
        '
        'SeccionV
        '
        Me.SeccionV.Location = New System.Drawing.Point(525, 103)
        Me.SeccionV.MaxLength = 10
        Me.SeccionV.Name = "SeccionV"
        Me.SeccionV.Size = New System.Drawing.Size(50, 30)
        Me.SeccionV.TabIndex = 72
        Me.SeccionV.Visible = False
        '
        'EscuelaL
        '
        Me.EscuelaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EscuelaL.AutoSize = True
        Me.EscuelaL.Location = New System.Drawing.Point(3, 139)
        Me.EscuelaL.Name = "EscuelaL"
        Me.EscuelaL.Size = New System.Drawing.Size(96, 25)
        Me.EscuelaL.TabIndex = 74
        Me.EscuelaL.Text = "*Escuela:"
        Me.EscuelaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EscuelaCombo
        '
        Me.EscuelaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.busquetaTable.SetColumnSpan(Me.EscuelaCombo, 4)
        Me.EscuelaCombo.FormattingEnabled = True
        Me.EscuelaCombo.Location = New System.Drawing.Point(105, 142)
        Me.EscuelaCombo.Name = "EscuelaCombo"
        Me.EscuelaCombo.Size = New System.Drawing.Size(470, 33)
        Me.EscuelaCombo.TabIndex = 75
        '
        'codigoG
        '
        Me.codigoG.AutoSize = True
        Me.codigoG.Location = New System.Drawing.Point(430, 25)
        Me.codigoG.Name = "codigoG"
        Me.codigoG.Size = New System.Drawing.Size(23, 25)
        Me.codigoG.TabIndex = 79
        Me.codigoG.Text = "_"
        '
        'indicacionesL
        '
        Me.indicacionesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.indicacionesL.AutoSize = True
        Me.indicacionesL.BackColor = System.Drawing.Color.Transparent
        Me.busquetaTable.SetColumnSpan(Me.indicacionesL, 5)
        Me.indicacionesL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicacionesL.ForeColor = System.Drawing.Color.Black
        Me.indicacionesL.Location = New System.Drawing.Point(3, 0)
        Me.indicacionesL.Name = "indicacionesL"
        Me.indicacionesL.Size = New System.Drawing.Size(572, 25)
        Me.indicacionesL.TabIndex = 77
        Me.indicacionesL.Text = "Ingrese los datos necesarios para obtener su listado"
        Me.indicacionesL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BuscarButton
        '
        Me.BuscarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarButton.Location = New System.Drawing.Point(3, 193)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(578, 48)
        Me.BuscarButton.TabIndex = 78
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'SeleccionarCheck
        '
        Me.SeleccionarCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeleccionarCheck.AutoSize = True
        Me.SeleccionarCheck.BackColor = System.Drawing.Color.Transparent
        Me.SeleccionarCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionarCheck.ForeColor = System.Drawing.Color.DodgerBlue
        Me.SeleccionarCheck.Location = New System.Drawing.Point(637, 193)
        Me.SeleccionarCheck.Name = "SeleccionarCheck"
        Me.SeleccionarCheck.Size = New System.Drawing.Size(578, 48)
        Me.SeleccionarCheck.TabIndex = 76
        Me.SeleccionarCheck.Text = "Seleccionar todos"
        Me.SeleccionarCheck.UseVisualStyleBackColor = False
        Me.SeleccionarCheck.Visible = False
        '
        'nEstadoCombo
        '
        Me.nEstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEstadoCombo.BackColor = System.Drawing.SystemColors.Window
        Me.nEstadoCombo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nEstadoCombo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.nEstadoCombo.FormattingEnabled = True
        Me.nEstadoCombo.Location = New System.Drawing.Point(105, 64)
        Me.nEstadoCombo.Name = "nEstadoCombo"
        Me.nEstadoCombo.Size = New System.Drawing.Size(299, 34)
        Me.nEstadoCombo.TabIndex = 74
        Me.nEstadoCombo.Visible = False
        '
        'registroTable
        '
        Me.registroTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.registroTable.BackColor = System.Drawing.Color.PeachPuff
        Me.registroTable.ColumnCount = 5
        Me.registroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.registroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.registroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.registroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.registroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.registroTable.Controls.Add(Me.nSeccionL, 3, 3)
        Me.registroTable.Controls.Add(Me.nEscuelaCombo, 1, 4)
        Me.registroTable.Controls.Add(Me.nuevoAñoL, 0, 0)
        Me.registroTable.Controls.Add(Me.nEscuelaL, 0, 4)
        Me.registroTable.Controls.Add(Me.nGradoCombo, 1, 3)
        Me.registroTable.Controls.Add(Me.nGradoL, 0, 3)
        Me.registroTable.Controls.Add(Me.nAñoV, 1, 1)
        Me.registroTable.Controls.Add(Me.nAñoL, 0, 1)
        Me.registroTable.Controls.Add(Me.nEstadoL, 0, 2)
        Me.registroTable.Controls.Add(Me.nEstadoCombo, 1, 2)
        Me.registroTable.Controls.Add(Me.nSeccionV, 4, 3)
        Me.registroTable.Location = New System.Drawing.Point(637, 3)
        Me.registroTable.Name = "registroTable"
        Me.registroTable.RowCount = 5
        Me.registroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.registroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.registroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.registroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.registroTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.registroTable.Size = New System.Drawing.Size(578, 176)
        Me.registroTable.TabIndex = 273
        Me.registroTable.Visible = False
        '
        'nSeccionL
        '
        Me.nSeccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nSeccionL.AutoSize = True
        Me.nSeccionL.Location = New System.Drawing.Point(430, 101)
        Me.nSeccionL.Name = "nSeccionL"
        Me.nSeccionL.Size = New System.Drawing.Size(89, 25)
        Me.nSeccionL.TabIndex = 276
        Me.nSeccionL.Text = "Sección:"
        Me.nSeccionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nSeccionL.Visible = False
        '
        'nEscuelaCombo
        '
        Me.nEscuelaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.registroTable.SetColumnSpan(Me.nEscuelaCombo, 4)
        Me.nEscuelaCombo.FormattingEnabled = True
        Me.nEscuelaCombo.Location = New System.Drawing.Point(105, 143)
        Me.nEscuelaCombo.Name = "nEscuelaCombo"
        Me.nEscuelaCombo.Size = New System.Drawing.Size(470, 33)
        Me.nEscuelaCombo.TabIndex = 279
        '
        'nuevoAñoL
        '
        Me.nuevoAñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nuevoAñoL.AutoSize = True
        Me.registroTable.SetColumnSpan(Me.nuevoAñoL, 5)
        Me.nuevoAñoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoAñoL.ForeColor = System.Drawing.Color.Black
        Me.nuevoAñoL.Location = New System.Drawing.Point(3, 0)
        Me.nuevoAñoL.Name = "nuevoAñoL"
        Me.nuevoAñoL.Size = New System.Drawing.Size(572, 25)
        Me.nuevoAñoL.TabIndex = 275
        Me.nuevoAñoL.Text = "Datos para nuevo año escolar"
        Me.nuevoAñoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nEscuelaL
        '
        Me.nEscuelaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEscuelaL.AutoSize = True
        Me.nEscuelaL.Location = New System.Drawing.Point(3, 140)
        Me.nEscuelaL.Name = "nEscuelaL"
        Me.nEscuelaL.Size = New System.Drawing.Size(96, 25)
        Me.nEscuelaL.TabIndex = 278
        Me.nEscuelaL.Text = "*Escuela:"
        Me.nEscuelaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nGradoCombo
        '
        Me.nGradoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nGradoCombo.FormattingEnabled = True
        Me.nGradoCombo.Location = New System.Drawing.Point(105, 104)
        Me.nGradoCombo.Name = "nGradoCombo"
        Me.nGradoCombo.Size = New System.Drawing.Size(299, 33)
        Me.nGradoCombo.TabIndex = 277
        '
        'nGradoL
        '
        Me.nGradoL.AutoSize = True
        Me.nGradoL.Location = New System.Drawing.Point(3, 101)
        Me.nGradoL.Name = "nGradoL"
        Me.nGradoL.Size = New System.Drawing.Size(80, 25)
        Me.nGradoL.TabIndex = 276
        Me.nGradoL.Text = "*Grado:"
        Me.nGradoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nAñoV
        '
        Me.nAñoV.Location = New System.Drawing.Point(105, 28)
        Me.nAñoV.MaxLength = 10
        Me.nAñoV.Name = "nAñoV"
        Me.nAñoV.Size = New System.Drawing.Size(95, 30)
        Me.nAñoV.TabIndex = 275
        '
        'nAñoL
        '
        Me.nAñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nAñoL.AutoSize = True
        Me.nAñoL.Location = New System.Drawing.Point(3, 25)
        Me.nAñoL.Name = "nAñoL"
        Me.nAñoL.Size = New System.Drawing.Size(96, 25)
        Me.nAñoL.TabIndex = 275
        Me.nAñoL.Text = "*Año:"
        Me.nAñoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nEstadoL
        '
        Me.nEstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEstadoL.AutoSize = True
        Me.nEstadoL.Location = New System.Drawing.Point(3, 61)
        Me.nEstadoL.Name = "nEstadoL"
        Me.nEstadoL.Size = New System.Drawing.Size(96, 25)
        Me.nEstadoL.TabIndex = 275
        Me.nEstadoL.Text = "Estado:"
        Me.nEstadoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nSeccionV
        '
        Me.nSeccionV.Location = New System.Drawing.Point(525, 104)
        Me.nSeccionV.MaxLength = 10
        Me.nSeccionV.Name = "nSeccionV"
        Me.nSeccionV.Size = New System.Drawing.Size(50, 30)
        Me.nSeccionV.TabIndex = 276
        Me.nSeccionV.Visible = False
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion})
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 401)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 55
        Me.ListadoGrid.Size = New System.Drawing.Size(1212, 331)
        Me.ListadoGrid.TabIndex = 274
        Me.ListadoGrid.Visible = False
        '
        'Accion
        '
        Me.Accion.HeaderText = "Seleccionar"
        Me.Accion.Name = "Accion"
        '
        'proximoAñoTable
        '
        Me.proximoAñoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proximoAñoTable.ColumnCount = 3
        Me.proximoAñoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.proximoAñoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.proximoAñoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.proximoAñoTable.Controls.Add(Me.SeleccionarCheck, 2, 1)
        Me.proximoAñoTable.Controls.Add(Me.BuscarButton, 0, 1)
        Me.proximoAñoTable.Controls.Add(Me.busquetaTable, 0, 0)
        Me.proximoAñoTable.Controls.Add(Me.registroTable, 2, 0)
        Me.proximoAñoTable.Location = New System.Drawing.Point(0, 151)
        Me.proximoAñoTable.Name = "proximoAñoTable"
        Me.proximoAñoTable.RowCount = 2
        Me.proximoAñoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.proximoAñoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.proximoAñoTable.Size = New System.Drawing.Size(1218, 244)
        Me.proximoAñoTable.TabIndex = 275
        '
        'NuevoAñoEscolar_PorGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(1218, 744)
        Me.Controls.Add(Me.proximoAñoTable)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NuevoAñoEscolar_PorGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Año Escolar Por Grupo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.busquetaTable.ResumeLayout(False)
        Me.busquetaTable.PerformLayout()
        Me.registroTable.ResumeLayout(False)
        Me.registroTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.proximoAñoTable.ResumeLayout(False)
        Me.proximoAñoTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents busquetaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SeleccionarCheck As System.Windows.Forms.CheckBox
    Friend WithEvents EscuelaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EscuelaL As System.Windows.Forms.Label
    Friend WithEvents nEstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents SeccionV As System.Windows.Forms.TextBox
    Friend WithEvents SeccionL As System.Windows.Forms.Label
    Friend WithEvents EstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents indicacionesL As System.Windows.Forms.Label
    Friend WithEvents registroTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BuscarButton As System.Windows.Forms.Button
    Friend WithEvents codigoG As System.Windows.Forms.Label
    Friend WithEvents nSeccionV As System.Windows.Forms.TextBox
    Friend WithEvents nSeccionL As System.Windows.Forms.Label
    Friend WithEvents nEscuelaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nEscuelaL As System.Windows.Forms.Label
    Friend WithEvents nGradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nGradoL As System.Windows.Forms.Label
    Friend WithEvents nAñoV As System.Windows.Forms.TextBox
    Friend WithEvents nAñoL As System.Windows.Forms.Label
    Friend WithEvents nEstadoL As System.Windows.Forms.Label
    Friend WithEvents nuevoAñoL As System.Windows.Forms.Label
    Friend WithEvents proximoAñoTable As System.Windows.Forms.TableLayoutPanel
End Class
