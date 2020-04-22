<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiembrosNFam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiembrosNFam))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.infoMTable = New System.Windows.Forms.TableLayoutPanel()
        Me.EstadoEducCombo = New System.Windows.Forms.ComboBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.OcupacionCombo = New System.Windows.Forms.ComboBox()
        Me.RelacionL = New System.Windows.Forms.Label()
        Me.RelacionCombo = New System.Windows.Forms.ComboBox()
        Me.NacimientoL = New System.Windows.Forms.Label()
        Me.NombresL = New System.Windows.Forms.Label()
        Me.GeneroCombo = New System.Windows.Forms.ComboBox()
        Me.NombresV = New System.Windows.Forms.TextBox()
        Me.GeneroL = New System.Windows.Forms.Label()
        Me.ApellidosV = New System.Windows.Forms.TextBox()
        Me.NacimientoPicker = New System.Windows.Forms.DateTimePicker()
        Me.ApellidosL = New System.Windows.Forms.Label()
        Me.OcupacionL = New System.Windows.Forms.Label()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.GuardarMiembroButton = New System.Windows.Forms.Button()
        Me.igssCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuetzalesV = New System.Windows.Forms.TextBox()
        Me.HrsV = New System.Windows.Forms.TextBox()
        Me.JornadaCombo = New System.Windows.Forms.ComboBox()
        Me.IgssL = New System.Windows.Forms.Label()
        Me.IngresosL = New System.Windows.Forms.Label()
        Me.HrsL = New System.Windows.Forms.Label()
        Me.JornadaL = New System.Windows.Forms.Label()
        Me.inicioL = New System.Windows.Forms.Label()
        Me.InicioPicker = New System.Windows.Forms.DateTimePicker()
        Me.DPIv = New System.Windows.Forms.TextBox()
        Me.NivelAcCombo = New System.Windows.Forms.ComboBox()
        Me.dpiL = New System.Windows.Forms.Label()
        Me.ultimoGradoL = New System.Windows.Forms.Label()
        Me.MiembroInfoL = New System.Windows.Forms.Label()
        Me.MiembrosGrid = New System.Windows.Forms.DataGridView()
        Me.MiembrosL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.DireccionV = New System.Windows.Forms.Label()
        Me.existeMiembroCheck = New System.Windows.Forms.CheckBox()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.infoMTable.SuspendLayout()
        CType(Me.MiembrosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(934, 104)
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
        Me.opcionesTable.Location = New System.Drawing.Point(118, 52)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(814, 49)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(708, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(49, 43)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(657, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 43)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(763, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 43)
        Me.GuardarButton.TabIndex = 4
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
        Me.Title.Size = New System.Drawing.Size(646, 49)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Miembros de Familia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'infoMTable
        '
        Me.infoMTable.BackColor = System.Drawing.Color.LightBlue
        Me.infoMTable.ColumnCount = 2
        Me.infoMTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.infoMTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.infoMTable.Controls.Add(Me.EstadoEducCombo, 1, 7)
        Me.infoMTable.Controls.Add(Me.MiembroV, 1, 0)
        Me.infoMTable.Controls.Add(Me.OcupacionCombo, 1, 11)
        Me.infoMTable.Controls.Add(Me.RelacionL, 0, 6)
        Me.infoMTable.Controls.Add(Me.RelacionCombo, 1, 6)
        Me.infoMTable.Controls.Add(Me.NacimientoL, 0, 5)
        Me.infoMTable.Controls.Add(Me.NombresL, 0, 1)
        Me.infoMTable.Controls.Add(Me.GeneroCombo, 1, 3)
        Me.infoMTable.Controls.Add(Me.NombresV, 1, 1)
        Me.infoMTable.Controls.Add(Me.GeneroL, 0, 3)
        Me.infoMTable.Controls.Add(Me.ApellidosV, 1, 2)
        Me.infoMTable.Controls.Add(Me.NacimientoPicker, 1, 5)
        Me.infoMTable.Controls.Add(Me.ApellidosL, 0, 2)
        Me.infoMTable.Controls.Add(Me.OcupacionL, 0, 11)
        Me.infoMTable.Controls.Add(Me.MiembroL, 0, 0)
        Me.infoMTable.Controls.Add(Me.GuardarMiembroButton, 0, 17)
        Me.infoMTable.Controls.Add(Me.igssCheckBox, 1, 16)
        Me.infoMTable.Controls.Add(Me.QuetzalesV, 1, 15)
        Me.infoMTable.Controls.Add(Me.HrsV, 1, 14)
        Me.infoMTable.Controls.Add(Me.JornadaCombo, 1, 13)
        Me.infoMTable.Controls.Add(Me.IgssL, 0, 16)
        Me.infoMTable.Controls.Add(Me.IngresosL, 0, 15)
        Me.infoMTable.Controls.Add(Me.HrsL, 0, 14)
        Me.infoMTable.Controls.Add(Me.JornadaL, 0, 13)
        Me.infoMTable.Controls.Add(Me.inicioL, 0, 12)
        Me.infoMTable.Controls.Add(Me.InicioPicker, 1, 12)
        Me.infoMTable.Controls.Add(Me.DPIv, 1, 9)
        Me.infoMTable.Controls.Add(Me.NivelAcCombo, 1, 8)
        Me.infoMTable.Controls.Add(Me.dpiL, 0, 9)
        Me.infoMTable.Controls.Add(Me.ultimoGradoL, 0, 7)
        Me.infoMTable.Location = New System.Drawing.Point(0, 160)
        Me.infoMTable.Name = "infoMTable"
        Me.infoMTable.RowCount = 18
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.infoMTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.infoMTable.Size = New System.Drawing.Size(391, 480)
        Me.infoMTable.TabIndex = 272
        Me.infoMTable.Visible = False
        '
        'EstadoEducCombo
        '
        Me.EstadoEducCombo.FormattingEnabled = True
        Me.EstadoEducCombo.Location = New System.Drawing.Point(103, 267)
        Me.EstadoEducCombo.Name = "EstadoEducCombo"
        Me.EstadoEducCombo.Size = New System.Drawing.Size(285, 31)
        Me.EstadoEducCombo.TabIndex = 7
        '
        'MiembroV
        '
        Me.MiembroV.Location = New System.Drawing.Point(103, 3)
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(105, 30)
        Me.MiembroV.TabIndex = 1
        Me.MiembroV.Visible = False
        '
        'OcupacionCombo
        '
        Me.OcupacionCombo.FormattingEnabled = True
        Me.OcupacionCombo.Location = New System.Drawing.Point(103, 387)
        Me.OcupacionCombo.Name = "OcupacionCombo"
        Me.OcupacionCombo.Size = New System.Drawing.Size(285, 31)
        Me.OcupacionCombo.TabIndex = 10
        '
        'RelacionL
        '
        Me.RelacionL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RelacionL.AutoSize = True
        Me.RelacionL.Location = New System.Drawing.Point(3, 218)
        Me.RelacionL.Name = "RelacionL"
        Me.RelacionL.Size = New System.Drawing.Size(94, 46)
        Me.RelacionL.TabIndex = 266
        Me.RelacionL.Text = "*Relación:"
        Me.RelacionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RelacionCombo
        '
        Me.RelacionCombo.FormattingEnabled = True
        Me.RelacionCombo.Location = New System.Drawing.Point(103, 221)
        Me.RelacionCombo.Name = "RelacionCombo"
        Me.RelacionCombo.Size = New System.Drawing.Size(285, 31)
        Me.RelacionCombo.TabIndex = 6
        '
        'NacimientoL
        '
        Me.NacimientoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NacimientoL.AutoSize = True
        Me.NacimientoL.Location = New System.Drawing.Point(3, 172)
        Me.NacimientoL.Name = "NacimientoL"
        Me.NacimientoL.Size = New System.Drawing.Size(94, 46)
        Me.NacimientoL.TabIndex = 265
        Me.NacimientoL.Text = "*Nacimiento"
        Me.NacimientoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombresL
        '
        Me.NombresL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombresL.AutoSize = True
        Me.NombresL.Location = New System.Drawing.Point(3, 46)
        Me.NombresL.Name = "NombresL"
        Me.NombresL.Size = New System.Drawing.Size(94, 46)
        Me.NombresL.TabIndex = 262
        Me.NombresL.Text = "*Nombres:"
        Me.NombresL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GeneroCombo
        '
        Me.GeneroCombo.FormattingEnabled = True
        Me.GeneroCombo.Location = New System.Drawing.Point(103, 141)
        Me.GeneroCombo.Name = "GeneroCombo"
        Me.GeneroCombo.Size = New System.Drawing.Size(105, 31)
        Me.GeneroCombo.TabIndex = 4
        '
        'NombresV
        '
        Me.NombresV.Location = New System.Drawing.Point(103, 49)
        Me.NombresV.Name = "NombresV"
        Me.NombresV.Size = New System.Drawing.Size(285, 30)
        Me.NombresV.TabIndex = 2
        '
        'GeneroL
        '
        Me.GeneroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneroL.AutoSize = True
        Me.GeneroL.Location = New System.Drawing.Point(3, 138)
        Me.GeneroL.Name = "GeneroL"
        Me.GeneroL.Size = New System.Drawing.Size(94, 34)
        Me.GeneroL.TabIndex = 264
        Me.GeneroL.Text = "*Género"
        Me.GeneroL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ApellidosV
        '
        Me.ApellidosV.Location = New System.Drawing.Point(103, 95)
        Me.ApellidosV.Name = "ApellidosV"
        Me.ApellidosV.Size = New System.Drawing.Size(285, 30)
        Me.ApellidosV.TabIndex = 3
        '
        'NacimientoPicker
        '
        Me.NacimientoPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NacimientoPicker.Location = New System.Drawing.Point(103, 175)
        Me.NacimientoPicker.Name = "NacimientoPicker"
        Me.NacimientoPicker.Size = New System.Drawing.Size(105, 30)
        Me.NacimientoPicker.TabIndex = 5
        '
        'ApellidosL
        '
        Me.ApellidosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApellidosL.AutoSize = True
        Me.ApellidosL.Location = New System.Drawing.Point(3, 92)
        Me.ApellidosL.Name = "ApellidosL"
        Me.ApellidosL.Size = New System.Drawing.Size(94, 46)
        Me.ApellidosL.TabIndex = 263
        Me.ApellidosL.Text = "*Apellidos:"
        Me.ApellidosL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OcupacionL
        '
        Me.OcupacionL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OcupacionL.AutoSize = True
        Me.OcupacionL.Location = New System.Drawing.Point(3, 384)
        Me.OcupacionL.Name = "OcupacionL"
        Me.OcupacionL.Size = New System.Drawing.Size(94, 46)
        Me.OcupacionL.TabIndex = 265
        Me.OcupacionL.Text = "Ocupación"
        Me.OcupacionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiembroL
        '
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Location = New System.Drawing.Point(3, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(93, 46)
        Me.MiembroL.TabIndex = 276
        Me.MiembroL.Text = "No. Miembro:"
        Me.MiembroL.Visible = False
        '
        'GuardarMiembroButton
        '
        Me.GuardarMiembroButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoMTable.SetColumnSpan(Me.GuardarMiembroButton, 2)
        Me.GuardarMiembroButton.Location = New System.Drawing.Point(3, 635)
        Me.GuardarMiembroButton.Name = "GuardarMiembroButton"
        Me.GuardarMiembroButton.Size = New System.Drawing.Size(385, 1)
        Me.GuardarMiembroButton.TabIndex = 15
        Me.GuardarMiembroButton.Text = "Guardar Información Miembro"
        Me.GuardarMiembroButton.UseVisualStyleBackColor = True
        '
        'igssCheckBox
        '
        Me.igssCheckBox.AutoSize = True
        Me.igssCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.igssCheckBox.Location = New System.Drawing.Point(103, 605)
        Me.igssCheckBox.Name = "igssCheckBox"
        Me.igssCheckBox.Size = New System.Drawing.Size(227, 24)
        Me.igssCheckBox.TabIndex = 15
        Me.igssCheckBox.Text = "Marque si tiene IGSS"
        Me.igssCheckBox.UseVisualStyleBackColor = True
        '
        'QuetzalesV
        '
        Me.QuetzalesV.Location = New System.Drawing.Point(103, 559)
        Me.QuetzalesV.Name = "QuetzalesV"
        Me.QuetzalesV.Size = New System.Drawing.Size(285, 30)
        Me.QuetzalesV.TabIndex = 14
        '
        'HrsV
        '
        Me.HrsV.Location = New System.Drawing.Point(103, 513)
        Me.HrsV.Name = "HrsV"
        Me.HrsV.Size = New System.Drawing.Size(41, 30)
        Me.HrsV.TabIndex = 13
        '
        'JornadaCombo
        '
        Me.JornadaCombo.FormattingEnabled = True
        Me.JornadaCombo.Location = New System.Drawing.Point(103, 479)
        Me.JornadaCombo.Name = "JornadaCombo"
        Me.JornadaCombo.Size = New System.Drawing.Size(285, 31)
        Me.JornadaCombo.TabIndex = 12
        '
        'IgssL
        '
        Me.IgssL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IgssL.AutoSize = True
        Me.IgssL.Location = New System.Drawing.Point(3, 602)
        Me.IgssL.Name = "IgssL"
        Me.IgssL.Size = New System.Drawing.Size(94, 30)
        Me.IgssL.TabIndex = 283
        Me.IgssL.Text = "IGSS:"
        '
        'IngresosL
        '
        Me.IngresosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IngresosL.AutoSize = True
        Me.IngresosL.Location = New System.Drawing.Point(3, 556)
        Me.IngresosL.Name = "IngresosL"
        Me.IngresosL.Size = New System.Drawing.Size(94, 46)
        Me.IngresosL.TabIndex = 267
        Me.IngresosL.Text = "*Sueldo en Q."
        Me.IngresosL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HrsL
        '
        Me.HrsL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HrsL.AutoSize = True
        Me.HrsL.Location = New System.Drawing.Point(3, 510)
        Me.HrsL.Name = "HrsL"
        Me.HrsL.Size = New System.Drawing.Size(94, 46)
        Me.HrsL.TabIndex = 268
        Me.HrsL.Text = "Hrs. por semana:"
        '
        'JornadaL
        '
        Me.JornadaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JornadaL.AutoSize = True
        Me.JornadaL.Location = New System.Drawing.Point(3, 476)
        Me.JornadaL.Name = "JornadaL"
        Me.JornadaL.Size = New System.Drawing.Size(94, 34)
        Me.JornadaL.TabIndex = 267
        Me.JornadaL.Text = "Jornada"
        Me.JornadaL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inicioL
        '
        Me.inicioL.AutoSize = True
        Me.inicioL.Location = New System.Drawing.Point(3, 430)
        Me.inicioL.Name = "inicioL"
        Me.inicioL.Size = New System.Drawing.Size(70, 46)
        Me.inicioL.TabIndex = 285
        Me.inicioL.Text = "Fecha Inicio:"
        '
        'InicioPicker
        '
        Me.InicioPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InicioPicker.Location = New System.Drawing.Point(103, 433)
        Me.InicioPicker.Name = "InicioPicker"
        Me.InicioPicker.Size = New System.Drawing.Size(105, 30)
        Me.InicioPicker.TabIndex = 11
        '
        'DPIv
        '
        Me.DPIv.Location = New System.Drawing.Point(103, 336)
        Me.DPIv.MaxLength = 20
        Me.DPIv.Name = "DPIv"
        Me.DPIv.Size = New System.Drawing.Size(285, 30)
        Me.DPIv.TabIndex = 9
        '
        'NivelAcCombo
        '
        Me.NivelAcCombo.FormattingEnabled = True
        Me.NivelAcCombo.Location = New System.Drawing.Point(103, 301)
        Me.NivelAcCombo.Name = "NivelAcCombo"
        Me.NivelAcCombo.Size = New System.Drawing.Size(285, 31)
        Me.NivelAcCombo.TabIndex = 8
        '
        'dpiL
        '
        Me.dpiL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpiL.AutoSize = True
        Me.dpiL.Location = New System.Drawing.Point(3, 333)
        Me.dpiL.Name = "dpiL"
        Me.dpiL.Size = New System.Drawing.Size(94, 36)
        Me.dpiL.TabIndex = 277
        Me.dpiL.Text = "No. DPI:"
        Me.dpiL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ultimoGradoL
        '
        Me.ultimoGradoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ultimoGradoL.AutoSize = True
        Me.ultimoGradoL.Location = New System.Drawing.Point(3, 264)
        Me.ultimoGradoL.Name = "ultimoGradoL"
        Me.infoMTable.SetRowSpan(Me.ultimoGradoL, 2)
        Me.ultimoGradoL.Size = New System.Drawing.Size(94, 69)
        Me.ultimoGradoL.TabIndex = 265
        Me.ultimoGradoL.Text = "Nivel académico:"
        Me.ultimoGradoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MiembroInfoL
        '
        Me.MiembroInfoL.AutoSize = True
        Me.MiembroInfoL.BackColor = System.Drawing.Color.SteelBlue
        Me.MiembroInfoL.ForeColor = System.Drawing.Color.White
        Me.MiembroInfoL.Location = New System.Drawing.Point(1, 143)
        Me.MiembroInfoL.Name = "MiembroInfoL"
        Me.MiembroInfoL.Size = New System.Drawing.Size(146, 23)
        Me.MiembroInfoL.TabIndex = 273
        Me.MiembroInfoL.Text = "Nuevo miembro"
        Me.MiembroInfoL.Visible = False
        '
        'MiembrosGrid
        '
        Me.MiembrosGrid.AllowUserToAddRows = False
        Me.MiembrosGrid.AllowUserToDeleteRows = False
        Me.MiembrosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembrosGrid.BackgroundColor = System.Drawing.Color.White
        Me.MiembrosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MiembrosGrid.Location = New System.Drawing.Point(422, 160)
        Me.MiembrosGrid.Name = "MiembrosGrid"
        Me.MiembrosGrid.ReadOnly = True
        Me.MiembrosGrid.RowHeadersVisible = False
        Me.MiembrosGrid.Size = New System.Drawing.Size(507, 593)
        Me.MiembrosGrid.TabIndex = 274
        Me.MiembrosGrid.Visible = False
        '
        'MiembrosL
        '
        Me.MiembrosL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembrosL.BackColor = System.Drawing.Color.SteelBlue
        Me.MiembrosL.ForeColor = System.Drawing.Color.White
        Me.MiembrosL.Location = New System.Drawing.Point(419, 143)
        Me.MiembrosL.Name = "MiembrosL"
        Me.MiembrosL.Size = New System.Drawing.Size(510, 16)
        Me.MiembrosL.TabIndex = 275
        Me.MiembrosL.Text = "Miembros de Familia"
        Me.MiembrosL.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliaL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliaV, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DireccionV, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 107)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(932, 33)
        Me.TableLayoutPanel1.TabIndex = 276
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Location = New System.Drawing.Point(745, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(78, 33)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "Familia:"
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.Location = New System.Drawing.Point(829, 3)
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(100, 35)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DireccionV
        '
        Me.DireccionV.AutoSize = True
        Me.DireccionV.Location = New System.Drawing.Point(3, 0)
        Me.DireccionV.Name = "DireccionV"
        Me.DireccionV.Size = New System.Drawing.Size(17, 23)
        Me.DireccionV.TabIndex = 2
        Me.DireccionV.Text = "-"
        Me.DireccionV.Visible = False
        '
        'existeMiembroCheck
        '
        Me.existeMiembroCheck.AutoSize = True
        Me.existeMiembroCheck.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.existeMiembroCheck.ForeColor = System.Drawing.Color.DodgerBlue
        Me.existeMiembroCheck.Location = New System.Drawing.Point(102, 139)
        Me.existeMiembroCheck.Name = "existeMiembroCheck"
        Me.existeMiembroCheck.Size = New System.Drawing.Size(392, 28)
        Me.existeMiembroCheck.TabIndex = 282
        Me.existeMiembroCheck.Text = "Marque si existe en Familias e ingrese el número"
        Me.existeMiembroCheck.UseVisualStyleBackColor = True
        Me.existeMiembroCheck.Visible = False
        '
        'MiembrosNFam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.existeMiembroCheck)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MiembrosL)
        Me.Controls.Add(Me.MiembrosGrid)
        Me.Controls.Add(Me.infoMTable)
        Me.Controls.Add(Me.MiembroInfoL)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MiembrosNFam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Miembros Nueva Familia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.infoMTable.ResumeLayout(False)
        Me.infoMTable.PerformLayout()
        CType(Me.MiembrosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents infoMTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents JornadaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents RelacionL As System.Windows.Forms.Label
    Friend WithEvents NacimientoL As System.Windows.Forms.Label
    Friend WithEvents GeneroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents NacimientoPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GeneroL As System.Windows.Forms.Label
    Friend WithEvents NombresL As System.Windows.Forms.Label
    Friend WithEvents NombresV As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosL As System.Windows.Forms.Label
    Friend WithEvents ApellidosV As System.Windows.Forms.TextBox
    Friend WithEvents ultimoGradoL As System.Windows.Forms.Label
    Friend WithEvents OcupacionL As System.Windows.Forms.Label
    Friend WithEvents JornadaL As System.Windows.Forms.Label
    Friend WithEvents HrsL As System.Windows.Forms.Label
    Friend WithEvents IngresosL As System.Windows.Forms.Label
    Friend WithEvents NivelAcCombo As System.Windows.Forms.ComboBox
    Friend WithEvents QuetzalesV As System.Windows.Forms.TextBox
    Friend WithEvents HrsV As System.Windows.Forms.TextBox
    Friend WithEvents GuardarMiembroButton As System.Windows.Forms.Button
    Friend WithEvents MiembroInfoL As System.Windows.Forms.Label
    Friend WithEvents RelacionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents OcupacionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents MiembrosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MiembrosL As System.Windows.Forms.Label
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents dpiL As System.Windows.Forms.Label
    Friend WithEvents DPIv As System.Windows.Forms.TextBox
    Friend WithEvents igssCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IgssL As System.Windows.Forms.Label
    Friend WithEvents inicioL As System.Windows.Forms.Label
    Friend WithEvents InicioPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents existeMiembroCheck As System.Windows.Forms.CheckBox
    Friend WithEvents EstadoEducCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DireccionV As System.Windows.Forms.Label
End Class
