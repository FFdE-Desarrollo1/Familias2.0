<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoAñoEscolarPorGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoAñoEscolarPorGrupo))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.añoEscolarTable = New System.Windows.Forms.TableLayoutPanel()
        Me.indicacionesL = New System.Windows.Forms.Label()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.EscuelaCombo = New System.Windows.Forms.ComboBox()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.EstadoCombo = New System.Windows.Forms.ComboBox()
        Me.SeccionV = New System.Windows.Forms.TextBox()
        Me.EscuelaL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.SeccionL = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.RegistroTable = New System.Windows.Forms.TableLayoutPanel()
        Me.nuevoAñoL = New System.Windows.Forms.Label()
        Me.nAñoV = New System.Windows.Forms.TextBox()
        Me.nSeccionV = New System.Windows.Forms.TextBox()
        Me.nGradoL = New System.Windows.Forms.Label()
        Me.nEstadoL = New System.Windows.Forms.Label()
        Me.nEstadoCombo = New System.Windows.Forms.ComboBox()
        Me.nAñoL = New System.Windows.Forms.Label()
        Me.nSeccionL = New System.Windows.Forms.Label()
        Me.nGradoCombo = New System.Windows.Forms.ComboBox()
        Me.nEscuelaCombo = New System.Windows.Forms.ComboBox()
        Me.nEscuelaL = New System.Windows.Forms.Label()
        Me.SeleccionarCheck = New System.Windows.Forms.CheckBox()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GeneralTable = New System.Windows.Forms.TableLayoutPanel()
        Me.CarreraCombo = New System.Windows.Forms.ComboBox()
        Me.carreraL = New System.Windows.Forms.Label()
        Me.nCarreraCombo = New System.Windows.Forms.ComboBox()
        Me.nCarreraL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.añoEscolarTable.SuspendLayout()
        Me.RegistroTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(978, 118)
        Me.bannerPanel.TabIndex = 260
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
        Me.opcionesTable.Size = New System.Drawing.Size(882, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(776, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(725, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(831, 3)
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
        Me.Title.Size = New System.Drawing.Size(714, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Nuevo Año Escolar Por Grupo"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'añoEscolarTable
        '
        Me.añoEscolarTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.añoEscolarTable.BackColor = System.Drawing.Color.LightBlue
        Me.añoEscolarTable.ColumnCount = 5
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.añoEscolarTable.Controls.Add(Me.carreraL, 0, 5)
        Me.añoEscolarTable.Controls.Add(Me.CarreraCombo, 1, 5)
        Me.añoEscolarTable.Controls.Add(Me.indicacionesL, 0, 0)
        Me.añoEscolarTable.Controls.Add(Me.BuscarButton, 0, 6)
        Me.añoEscolarTable.Controls.Add(Me.EscuelaCombo, 1, 4)
        Me.añoEscolarTable.Controls.Add(Me.GradoCombo, 1, 3)
        Me.añoEscolarTable.Controls.Add(Me.EstadoCombo, 1, 2)
        Me.añoEscolarTable.Controls.Add(Me.SeccionV, 4, 1)
        Me.añoEscolarTable.Controls.Add(Me.EscuelaL, 0, 4)
        Me.añoEscolarTable.Controls.Add(Me.GradoL, 0, 3)
        Me.añoEscolarTable.Controls.Add(Me.EstadoL, 0, 2)
        Me.añoEscolarTable.Controls.Add(Me.SeccionL, 3, 1)
        Me.añoEscolarTable.Controls.Add(Me.AñoL, 0, 1)
        Me.añoEscolarTable.Controls.Add(Me.AñoV, 1, 1)
        Me.añoEscolarTable.Location = New System.Drawing.Point(3, 3)
        Me.añoEscolarTable.Name = "añoEscolarTable"
        Me.añoEscolarTable.RowCount = 7
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.Size = New System.Drawing.Size(494, 238)
        Me.añoEscolarTable.TabIndex = 261
        '
        'indicacionesL
        '
        Me.indicacionesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.indicacionesL.AutoSize = True
        Me.indicacionesL.BackColor = System.Drawing.Color.Transparent
        Me.añoEscolarTable.SetColumnSpan(Me.indicacionesL, 5)
        Me.indicacionesL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicacionesL.ForeColor = System.Drawing.Color.Black
        Me.indicacionesL.Location = New System.Drawing.Point(3, 0)
        Me.indicacionesL.Name = "indicacionesL"
        Me.indicacionesL.Size = New System.Drawing.Size(488, 25)
        Me.indicacionesL.TabIndex = 78
        Me.indicacionesL.Text = "Ingrese los datos necesarios para obtener su listado"
        Me.indicacionesL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BuscarButton
        '
        Me.BuscarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.añoEscolarTable.SetColumnSpan(Me.BuscarButton, 5)
        Me.BuscarButton.Location = New System.Drawing.Point(3, 220)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(488, 37)
        Me.BuscarButton.TabIndex = 264
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'EscuelaCombo
        '
        Me.EscuelaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.añoEscolarTable.SetColumnSpan(Me.EscuelaCombo, 4)
        Me.EscuelaCombo.FormattingEnabled = True
        Me.EscuelaCombo.Location = New System.Drawing.Point(97, 142)
        Me.EscuelaCombo.Name = "EscuelaCombo"
        Me.EscuelaCombo.Size = New System.Drawing.Size(394, 33)
        Me.EscuelaCombo.TabIndex = 263
        '
        'GradoCombo
        '
        Me.GradoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.añoEscolarTable.SetColumnSpan(Me.GradoCombo, 4)
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(97, 103)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(394, 33)
        Me.GradoCombo.TabIndex = 263
        '
        'EstadoCombo
        '
        Me.EstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.añoEscolarTable.SetColumnSpan(Me.EstadoCombo, 4)
        Me.EstadoCombo.FormattingEnabled = True
        Me.EstadoCombo.Location = New System.Drawing.Point(97, 64)
        Me.EstadoCombo.Name = "EstadoCombo"
        Me.EstadoCombo.Size = New System.Drawing.Size(394, 33)
        Me.EstadoCombo.TabIndex = 263
        '
        'SeccionV
        '
        Me.SeccionV.Location = New System.Drawing.Point(441, 28)
        Me.SeccionV.MaxLength = 10
        Me.SeccionV.Name = "SeccionV"
        Me.SeccionV.Size = New System.Drawing.Size(50, 30)
        Me.SeccionV.TabIndex = 263
        Me.SeccionV.Visible = False
        '
        'EscuelaL
        '
        Me.EscuelaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EscuelaL.AutoSize = True
        Me.EscuelaL.Location = New System.Drawing.Point(3, 139)
        Me.EscuelaL.Name = "EscuelaL"
        Me.EscuelaL.Size = New System.Drawing.Size(88, 25)
        Me.EscuelaL.TabIndex = 262
        Me.EscuelaL.Text = "Escuela:"
        Me.EscuelaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.Location = New System.Drawing.Point(3, 100)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(72, 25)
        Me.GradoL.TabIndex = 262
        Me.GradoL.Text = "Grado:"
        Me.GradoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Location = New System.Drawing.Point(3, 61)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(88, 25)
        Me.EstadoL.TabIndex = 262
        Me.EstadoL.Text = "Estado:"
        '
        'SeccionL
        '
        Me.SeccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeccionL.AutoSize = True
        Me.SeccionL.Location = New System.Drawing.Point(346, 25)
        Me.SeccionL.Name = "SeccionL"
        Me.SeccionL.Size = New System.Drawing.Size(89, 25)
        Me.SeccionL.TabIndex = 262
        Me.SeccionL.Text = "Sección:"
        Me.SeccionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.SeccionL.Visible = False
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(97, 28)
        Me.AñoV.MaxLength = 10
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(100, 30)
        Me.AñoV.TabIndex = 263
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoL.Location = New System.Drawing.Point(3, 25)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(88, 25)
        Me.AñoL.TabIndex = 262
        Me.AñoL.Text = "Año:"
        '
        'RegistroTable
        '
        Me.RegistroTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTable.BackColor = System.Drawing.Color.PeachPuff
        Me.RegistroTable.ColumnCount = 5
        Me.RegistroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RegistroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RegistroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RegistroTable.Controls.Add(Me.nCarreraL, 0, 5)
        Me.RegistroTable.Controls.Add(Me.nCarreraCombo, 1, 5)
        Me.RegistroTable.Controls.Add(Me.nuevoAñoL, 0, 0)
        Me.RegistroTable.Controls.Add(Me.nSeccionV, 4, 1)
        Me.RegistroTable.Controls.Add(Me.nGradoL, 0, 3)
        Me.RegistroTable.Controls.Add(Me.nEstadoL, 0, 2)
        Me.RegistroTable.Controls.Add(Me.nEstadoCombo, 1, 2)
        Me.RegistroTable.Controls.Add(Me.nAñoL, 0, 1)
        Me.RegistroTable.Controls.Add(Me.nSeccionL, 3, 1)
        Me.RegistroTable.Controls.Add(Me.nGradoCombo, 1, 3)
        Me.RegistroTable.Controls.Add(Me.nEscuelaCombo, 1, 4)
        Me.RegistroTable.Controls.Add(Me.nEscuelaL, 0, 4)
        Me.RegistroTable.Controls.Add(Me.SeleccionarCheck, 0, 6)
        Me.RegistroTable.Controls.Add(Me.nAñoV, 1, 1)
        Me.RegistroTable.Location = New System.Drawing.Point(3, 267)
        Me.RegistroTable.Name = "RegistroTable"
        Me.RegistroTable.RowCount = 7
        Me.RegistroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.RegistroTable.Size = New System.Drawing.Size(494, 238)
        Me.RegistroTable.TabIndex = 262
        Me.RegistroTable.Visible = False
        '
        'nuevoAñoL
        '
        Me.nuevoAñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nuevoAñoL.AutoSize = True
        Me.nuevoAñoL.BackColor = System.Drawing.Color.Transparent
        Me.RegistroTable.SetColumnSpan(Me.nuevoAñoL, 5)
        Me.nuevoAñoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoAñoL.ForeColor = System.Drawing.Color.Black
        Me.nuevoAñoL.Location = New System.Drawing.Point(3, 0)
        Me.nuevoAñoL.Name = "nuevoAñoL"
        Me.nuevoAñoL.Size = New System.Drawing.Size(488, 50)
        Me.nuevoAñoL.TabIndex = 78
        Me.nuevoAñoL.Text = "Los siguientes datos son necesarios para el nuevo año escolar"
        Me.nuevoAñoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nAñoV
        '
        Me.nAñoV.Location = New System.Drawing.Point(97, 53)
        Me.nAñoV.MaxLength = 10
        Me.nAñoV.Name = "nAñoV"
        Me.nAñoV.Size = New System.Drawing.Size(100, 30)
        Me.nAñoV.TabIndex = 263
        '
        'nSeccionV
        '
        Me.nSeccionV.Location = New System.Drawing.Point(441, 53)
        Me.nSeccionV.MaxLength = 10
        Me.nSeccionV.Name = "nSeccionV"
        Me.nSeccionV.Size = New System.Drawing.Size(50, 30)
        Me.nSeccionV.TabIndex = 263
        Me.nSeccionV.Visible = False
        '
        'nGradoL
        '
        Me.nGradoL.AutoSize = True
        Me.nGradoL.Location = New System.Drawing.Point(3, 125)
        Me.nGradoL.Name = "nGradoL"
        Me.nGradoL.Size = New System.Drawing.Size(72, 25)
        Me.nGradoL.TabIndex = 262
        Me.nGradoL.Text = "Grado:"
        Me.nGradoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nEstadoL
        '
        Me.nEstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEstadoL.AutoSize = True
        Me.nEstadoL.Location = New System.Drawing.Point(3, 86)
        Me.nEstadoL.Name = "nEstadoL"
        Me.nEstadoL.Size = New System.Drawing.Size(88, 25)
        Me.nEstadoL.TabIndex = 262
        Me.nEstadoL.Text = "Estado:"
        '
        'nEstadoCombo
        '
        Me.nEstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTable.SetColumnSpan(Me.nEstadoCombo, 4)
        Me.nEstadoCombo.FormattingEnabled = True
        Me.nEstadoCombo.Location = New System.Drawing.Point(97, 89)
        Me.nEstadoCombo.Name = "nEstadoCombo"
        Me.nEstadoCombo.Size = New System.Drawing.Size(394, 33)
        Me.nEstadoCombo.TabIndex = 263
        '
        'nAñoL
        '
        Me.nAñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nAñoL.AutoSize = True
        Me.nAñoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAñoL.Location = New System.Drawing.Point(3, 50)
        Me.nAñoL.Name = "nAñoL"
        Me.nAñoL.Size = New System.Drawing.Size(88, 25)
        Me.nAñoL.TabIndex = 262
        Me.nAñoL.Text = "Año:"
        '
        'nSeccionL
        '
        Me.nSeccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nSeccionL.AutoSize = True
        Me.nSeccionL.Location = New System.Drawing.Point(346, 50)
        Me.nSeccionL.Name = "nSeccionL"
        Me.nSeccionL.Size = New System.Drawing.Size(89, 25)
        Me.nSeccionL.TabIndex = 262
        Me.nSeccionL.Text = "Sección:"
        Me.nSeccionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nSeccionL.Visible = False
        '
        'nGradoCombo
        '
        Me.nGradoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTable.SetColumnSpan(Me.nGradoCombo, 4)
        Me.nGradoCombo.FormattingEnabled = True
        Me.nGradoCombo.Location = New System.Drawing.Point(97, 128)
        Me.nGradoCombo.Name = "nGradoCombo"
        Me.nGradoCombo.Size = New System.Drawing.Size(394, 33)
        Me.nGradoCombo.TabIndex = 263
        '
        'nEscuelaCombo
        '
        Me.nEscuelaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTable.SetColumnSpan(Me.nEscuelaCombo, 4)
        Me.nEscuelaCombo.FormattingEnabled = True
        Me.nEscuelaCombo.Location = New System.Drawing.Point(97, 167)
        Me.nEscuelaCombo.Name = "nEscuelaCombo"
        Me.nEscuelaCombo.Size = New System.Drawing.Size(394, 33)
        Me.nEscuelaCombo.TabIndex = 263
        '
        'nEscuelaL
        '
        Me.nEscuelaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEscuelaL.AutoSize = True
        Me.nEscuelaL.Location = New System.Drawing.Point(3, 164)
        Me.nEscuelaL.Name = "nEscuelaL"
        Me.nEscuelaL.Size = New System.Drawing.Size(88, 25)
        Me.nEscuelaL.TabIndex = 262
        Me.nEscuelaL.Text = "Escuela:"
        Me.nEscuelaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SeleccionarCheck
        '
        Me.SeleccionarCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeleccionarCheck.AutoSize = True
        Me.SeleccionarCheck.BackColor = System.Drawing.Color.Transparent
        Me.RegistroTable.SetColumnSpan(Me.SeleccionarCheck, 5)
        Me.SeleccionarCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionarCheck.ForeColor = System.Drawing.Color.Firebrick
        Me.SeleccionarCheck.Location = New System.Drawing.Point(3, 245)
        Me.SeleccionarCheck.Name = "SeleccionarCheck"
        Me.SeleccionarCheck.Size = New System.Drawing.Size(488, 28)
        Me.SeleccionarCheck.TabIndex = 264
        Me.SeleccionarCheck.Text = "Seleccionar todos"
        Me.SeleccionarCheck.UseVisualStyleBackColor = False
        Me.SeleccionarCheck.Visible = False
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
        Me.ListadoGrid.Location = New System.Drawing.Point(523, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 55
        Me.GeneralTable.SetRowSpan(Me.ListadoGrid, 3)
        Me.ListadoGrid.Size = New System.Drawing.Size(450, 502)
        Me.ListadoGrid.TabIndex = 275
        Me.ListadoGrid.Visible = False
        '
        'Accion
        '
        Me.Accion.HeaderText = "Seleccionar"
        Me.Accion.Name = "Accion"
        '
        'GeneralTable
        '
        Me.GeneralTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneralTable.ColumnCount = 3
        Me.GeneralTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.GeneralTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GeneralTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GeneralTable.Controls.Add(Me.ListadoGrid, 2, 0)
        Me.GeneralTable.Controls.Add(Me.añoEscolarTable, 0, 0)
        Me.GeneralTable.Controls.Add(Me.RegistroTable, 0, 2)
        Me.GeneralTable.Location = New System.Drawing.Point(0, 124)
        Me.GeneralTable.Name = "GeneralTable"
        Me.GeneralTable.RowCount = 3
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GeneralTable.Size = New System.Drawing.Size(976, 508)
        Me.GeneralTable.TabIndex = 264
        '
        'CarreraCombo
        '
        Me.CarreraCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.añoEscolarTable.SetColumnSpan(Me.CarreraCombo, 4)
        Me.CarreraCombo.FormattingEnabled = True
        Me.CarreraCombo.Location = New System.Drawing.Point(97, 181)
        Me.CarreraCombo.Name = "CarreraCombo"
        Me.CarreraCombo.Size = New System.Drawing.Size(394, 33)
        Me.CarreraCombo.TabIndex = 264
        '
        'carreraL
        '
        Me.carreraL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.carreraL.AutoSize = True
        Me.carreraL.Location = New System.Drawing.Point(3, 178)
        Me.carreraL.Name = "carreraL"
        Me.carreraL.Size = New System.Drawing.Size(88, 25)
        Me.carreraL.TabIndex = 263
        Me.carreraL.Text = "Carrera:"
        '
        'nCarreraCombo
        '
        Me.nCarreraCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroTable.SetColumnSpan(Me.nCarreraCombo, 4)
        Me.nCarreraCombo.FormattingEnabled = True
        Me.nCarreraCombo.Location = New System.Drawing.Point(97, 206)
        Me.nCarreraCombo.Name = "nCarreraCombo"
        Me.nCarreraCombo.Size = New System.Drawing.Size(394, 33)
        Me.nCarreraCombo.TabIndex = 264
        '
        'nCarreraL
        '
        Me.nCarreraL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nCarreraL.AutoSize = True
        Me.nCarreraL.Location = New System.Drawing.Point(3, 203)
        Me.nCarreraL.Name = "nCarreraL"
        Me.nCarreraL.Size = New System.Drawing.Size(88, 25)
        Me.nCarreraL.TabIndex = 263
        Me.nCarreraL.Text = "Carrera"
        '
        'NuevoAñoEscolarPorGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(978, 644)
        Me.Controls.Add(Me.GeneralTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NuevoAñoEscolarPorGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Año Escolar Por Grupo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.añoEscolarTable.ResumeLayout(False)
        Me.añoEscolarTable.PerformLayout()
        Me.RegistroTable.ResumeLayout(False)
        Me.RegistroTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GeneralTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents añoEscolarTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents indicacionesL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents EstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents EscuelaL As System.Windows.Forms.Label
    Friend WithEvents EscuelaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents SeccionV As System.Windows.Forms.TextBox
    Friend WithEvents SeccionL As System.Windows.Forms.Label
    Friend WithEvents RegistroTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nSeccionV As System.Windows.Forms.TextBox
    Friend WithEvents nSeccionL As System.Windows.Forms.Label
    Friend WithEvents nEscuelaL As System.Windows.Forms.Label
    Friend WithEvents nGradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nEscuelaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nGradoL As System.Windows.Forms.Label
    Friend WithEvents nEstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nEstadoL As System.Windows.Forms.Label
    Friend WithEvents nAñoV As System.Windows.Forms.TextBox
    Friend WithEvents nuevoAñoL As System.Windows.Forms.Label
    Friend WithEvents nAñoL As System.Windows.Forms.Label
    Friend WithEvents BuscarButton As System.Windows.Forms.Button
    Friend WithEvents SeleccionarCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GeneralTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents carreraL As System.Windows.Forms.Label
    Friend WithEvents CarreraCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nCarreraL As System.Windows.Forms.Label
    Friend WithEvents nCarreraCombo As System.Windows.Forms.ComboBox
End Class
