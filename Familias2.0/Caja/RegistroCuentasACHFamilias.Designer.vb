<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroCuentasACHFamilias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroCuentasACHFamilias))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.TextBox()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.InfoGen = New System.Windows.Forms.TableLayoutPanel()
        Me.EstadoFam = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.DireccionV = New System.Windows.Forms.Label()
        Me.DireccionL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.TelefonosL = New System.Windows.Forms.Label()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MiembroRef = New System.Windows.Forms.TextBox()
        Me.MiembroRefL = New System.Windows.Forms.Label()
        Me.BancoL = New System.Windows.Forms.Label()
        Me.BancoCombo = New System.Windows.Forms.ComboBox()
        Me.NoCuentaL = New System.Windows.Forms.Label()
        Me.NoCuentaV = New System.Windows.Forms.TextBox()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.TipoCombo = New System.Windows.Forms.ComboBox()
        Me.TelRefL = New System.Windows.Forms.Label()
        Me.TelReferencia = New System.Windows.Forms.TextBox()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.ActvL = New System.Windows.Forms.Label()
        Me.InacButton = New System.Windows.Forms.Button()
        Me.VerCuentas = New System.Windows.Forms.Label()
        Me.ListadoFamiliaLink = New System.Windows.Forms.Label()
        Me.NuevaButton = New System.Windows.Forms.Button()
        Me.HistorialGrid = New System.Windows.Forms.DataGridView()
        Me.BotonesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.InfoGen.SuspendLayout()
        Me.DatosTable.SuspendLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BotonesTable.SuspendLayout()
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
        Me.bannerPanel.TabIndex = 258
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
        Me.NuevoButton.BackgroundImage = CType(resources.GetObject("NuevoButton.BackgroundImage"), System.Drawing.Image)
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
        Me.inicioButton.BackgroundImage = CType(resources.GetObject("inicioButton.BackgroundImage"), System.Drawing.Image)
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
        Me.GuardarButton.BackgroundImage = CType(resources.GetObject("GuardarButton.BackgroundImage"), System.Drawing.Image)
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(831, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
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
        Me.Title.Size = New System.Drawing.Size(714, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Actualizar Cuenta Bancaria - Familia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.SetColumnSpan(Me.NombreV, 4)
        Me.NombreV.Location = New System.Drawing.Point(320, 3)
        Me.NombreV.MaxLength = 50
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(655, 23)
        Me.NombreV.TabIndex = 1
        '
        'NombreL
        '
        Me.NombreL.AutoSize = True
        Me.NombreL.Location = New System.Drawing.Point(250, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(61, 16)
        Me.NombreL.TabIndex = 0
        Me.NombreL.Text = "Nombre:"
        '
        'InfoGen
        '
        Me.InfoGen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoGen.BackColor = System.Drawing.Color.AliceBlue
        Me.InfoGen.ColumnCount = 9
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoGen.Controls.Add(Me.EstadoFam, 5, 0)
        Me.InfoGen.Controls.Add(Me.FamiliaV, 8, 0)
        Me.InfoGen.Controls.Add(Me.DireccionV, 1, 0)
        Me.InfoGen.Controls.Add(Me.DireccionL, 0, 0)
        Me.InfoGen.Controls.Add(Me.FamiliaL, 7, 0)
        Me.InfoGen.Controls.Add(Me.TelefonosL, 3, 0)
        Me.InfoGen.Location = New System.Drawing.Point(0, 120)
        Me.InfoGen.Name = "InfoGen"
        Me.InfoGen.RowCount = 1
        Me.InfoGen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoGen.Size = New System.Drawing.Size(978, 46)
        Me.InfoGen.TabIndex = 259
        '
        'EstadoFam
        '
        Me.EstadoFam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoFam.AutoSize = True
        Me.EstadoFam.BackColor = System.Drawing.Color.AliceBlue
        Me.EstadoFam.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoFam.ForeColor = System.Drawing.Color.Black
        Me.EstadoFam.Location = New System.Drawing.Point(761, 0)
        Me.EstadoFam.Name = "EstadoFam"
        Me.EstadoFam.Size = New System.Drawing.Size(10, 46)
        Me.EstadoFam.TabIndex = 208
        Me.EstadoFam.Text = "."
        Me.EstadoFam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FamiliaV
        '
        Me.FamiliaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaV.BackColor = System.Drawing.Color.White
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FamiliaV.Location = New System.Drawing.Point(876, 3)
        Me.FamiliaV.MaxLength = 6
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(99, 29)
        Me.FamiliaV.TabIndex = 50
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DireccionV
        '
        Me.DireccionV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DireccionV.AutoSize = True
        Me.DireccionV.BackColor = System.Drawing.Color.Transparent
        Me.DireccionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionV.ForeColor = System.Drawing.Color.Black
        Me.DireccionV.Location = New System.Drawing.Point(72, 0)
        Me.DireccionV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionV.Name = "DireccionV"
        Me.DireccionV.Size = New System.Drawing.Size(320, 46)
        Me.DireccionV.TabIndex = 48
        Me.DireccionV.Text = "_"
        Me.DireccionV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DireccionV.Visible = False
        '
        'DireccionL
        '
        Me.DireccionL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DireccionL.AutoSize = True
        Me.DireccionL.BackColor = System.Drawing.Color.Transparent
        Me.DireccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionL.ForeColor = System.Drawing.Color.Black
        Me.DireccionL.Location = New System.Drawing.Point(2, 0)
        Me.DireccionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionL.Name = "DireccionL"
        Me.DireccionL.Size = New System.Drawing.Size(66, 46)
        Me.DireccionL.TabIndex = 47
        Me.DireccionL.Text = "Dirección:"
        Me.DireccionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DireccionL.Visible = False
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.BackColor = System.Drawing.Color.Transparent
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FamiliaL.Location = New System.Drawing.Point(796, 0)
        Me.FamiliaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(75, 22)
        Me.FamiliaL.TabIndex = 47
        Me.FamiliaL.Text = "Familia:"
        '
        'TelefonosL
        '
        Me.TelefonosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefonosL.AutoSize = True
        Me.TelefonosL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonosL.ForeColor = System.Drawing.Color.Black
        Me.TelefonosL.Location = New System.Drawing.Point(417, 0)
        Me.TelefonosL.Name = "TelefonosL"
        Me.TelefonosL.Size = New System.Drawing.Size(318, 46)
        Me.TelefonosL.TabIndex = 209
        Me.TelefonosL.Text = "-"
        Me.TelefonosL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.Gainsboro
        Me.DatosTable.ColumnCount = 8
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.Controls.Add(Me.MiembroRef, 7, 1)
        Me.DatosTable.Controls.Add(Me.NombreV, 4, 0)
        Me.DatosTable.Controls.Add(Me.MiembroRefL, 6, 1)
        Me.DatosTable.Controls.Add(Me.NombreL, 3, 0)
        Me.DatosTable.Controls.Add(Me.BancoL, 0, 1)
        Me.DatosTable.Controls.Add(Me.BancoCombo, 1, 1)
        Me.DatosTable.Controls.Add(Me.NoCuentaL, 0, 0)
        Me.DatosTable.Controls.Add(Me.NoCuentaV, 1, 0)
        Me.DatosTable.Controls.Add(Me.TipoL, 0, 2)
        Me.DatosTable.Controls.Add(Me.TipoCombo, 1, 2)
        Me.DatosTable.Controls.Add(Me.TelRefL, 3, 1)
        Me.DatosTable.Controls.Add(Me.TelReferencia, 4, 1)
        Me.DatosTable.Controls.Add(Me.NotasL, 3, 2)
        Me.DatosTable.Controls.Add(Me.NotasV, 4, 2)
        Me.DatosTable.Controls.Add(Me.ActvL, 5, 1)
        Me.DatosTable.Location = New System.Drawing.Point(0, 172)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 3
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.Size = New System.Drawing.Size(978, 94)
        Me.DatosTable.TabIndex = 260
        Me.DatosTable.Visible = False
        '
        'MiembroRef
        '
        Me.MiembroRef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroRef.Location = New System.Drawing.Point(649, 32)
        Me.MiembroRef.Name = "MiembroRef"
        Me.MiembroRef.Size = New System.Drawing.Size(326, 23)
        Me.MiembroRef.TabIndex = 262
        '
        'MiembroRefL
        '
        Me.MiembroRefL.AutoSize = True
        Me.MiembroRefL.Location = New System.Drawing.Point(547, 29)
        Me.MiembroRefL.Name = "MiembroRefL"
        Me.MiembroRefL.Size = New System.Drawing.Size(96, 16)
        Me.MiembroRefL.TabIndex = 70
        Me.MiembroRefL.Text = "Miembro Ref.:"
        '
        'BancoL
        '
        Me.BancoL.AutoSize = True
        Me.BancoL.Location = New System.Drawing.Point(3, 29)
        Me.BancoL.Name = "BancoL"
        Me.BancoL.Size = New System.Drawing.Size(52, 16)
        Me.BancoL.TabIndex = 261
        Me.BancoL.Text = "Banco:"
        '
        'BancoCombo
        '
        Me.BancoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BancoCombo.FormattingEnabled = True
        Me.BancoCombo.Location = New System.Drawing.Point(98, 32)
        Me.BancoCombo.Name = "BancoCombo"
        Me.BancoCombo.Size = New System.Drawing.Size(116, 24)
        Me.BancoCombo.TabIndex = 262
        '
        'NoCuentaL
        '
        Me.NoCuentaL.AutoSize = True
        Me.NoCuentaL.Location = New System.Drawing.Point(3, 0)
        Me.NoCuentaL.Name = "NoCuentaL"
        Me.NoCuentaL.Size = New System.Drawing.Size(83, 16)
        Me.NoCuentaL.TabIndex = 263
        Me.NoCuentaL.Text = "No. Cuenta:"
        '
        'NoCuentaV
        '
        Me.NoCuentaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoCuentaV.Location = New System.Drawing.Point(98, 3)
        Me.NoCuentaV.Name = "NoCuentaV"
        Me.NoCuentaV.Size = New System.Drawing.Size(116, 23)
        Me.NoCuentaV.TabIndex = 261
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.Location = New System.Drawing.Point(3, 58)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(89, 16)
        Me.TipoL.TabIndex = 262
        Me.TipoL.Text = "Tipo Cuenta:"
        '
        'TipoCombo
        '
        Me.TipoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoCombo.FormattingEnabled = True
        Me.TipoCombo.Location = New System.Drawing.Point(98, 61)
        Me.TipoCombo.Name = "TipoCombo"
        Me.TipoCombo.Size = New System.Drawing.Size(116, 24)
        Me.TipoCombo.TabIndex = 263
        '
        'TelRefL
        '
        Me.TelRefL.AutoSize = True
        Me.TelRefL.Location = New System.Drawing.Point(250, 29)
        Me.TelRefL.Name = "TelRefL"
        Me.TelRefL.Size = New System.Drawing.Size(64, 16)
        Me.TelRefL.TabIndex = 69
        Me.TelRefL.Text = "Tel. Ref.:"
        '
        'TelReferencia
        '
        Me.TelReferencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelReferencia.Location = New System.Drawing.Point(320, 32)
        Me.TelReferencia.Name = "TelReferencia"
        Me.TelReferencia.Size = New System.Drawing.Size(191, 23)
        Me.TelReferencia.TabIndex = 262
        '
        'NotasL
        '
        Me.NotasL.AutoSize = True
        Me.NotasL.Location = New System.Drawing.Point(250, 58)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(48, 16)
        Me.NotasL.TabIndex = 264
        Me.NotasL.Text = "Notas:"
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.SetColumnSpan(Me.NotasV, 4)
        Me.NotasV.Location = New System.Drawing.Point(320, 61)
        Me.NotasV.MaxLength = 200
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(655, 23)
        Me.NotasV.TabIndex = 264
        '
        'ActvL
        '
        Me.ActvL.AutoSize = True
        Me.ActvL.Location = New System.Drawing.Point(517, 29)
        Me.ActvL.Name = "ActvL"
        Me.ActvL.Size = New System.Drawing.Size(16, 16)
        Me.ActvL.TabIndex = 271
        Me.ActvL.Text = "_"
        Me.ActvL.Visible = False
        '
        'InacButton
        '
        Me.InacButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InacButton.Location = New System.Drawing.Point(564, 3)
        Me.InacButton.Name = "InacButton"
        Me.InacButton.Size = New System.Drawing.Size(141, 30)
        Me.InacButton.TabIndex = 269
        Me.InacButton.Text = "Inactivar Cta."
        Me.InacButton.UseVisualStyleBackColor = True
        '
        'VerCuentas
        '
        Me.VerCuentas.AutoSize = True
        Me.VerCuentas.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerCuentas.ForeColor = System.Drawing.Color.Blue
        Me.VerCuentas.Location = New System.Drawing.Point(243, 0)
        Me.VerCuentas.Name = "VerCuentas"
        Me.VerCuentas.Size = New System.Drawing.Size(112, 16)
        Me.VerCuentas.TabIndex = 266
        Me.VerCuentas.Text = "Historial cuentas"
        '
        'ListadoFamiliaLink
        '
        Me.ListadoFamiliaLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoFamiliaLink.AutoSize = True
        Me.ListadoFamiliaLink.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoFamiliaLink.ForeColor = System.Drawing.Color.Blue
        Me.ListadoFamiliaLink.Location = New System.Drawing.Point(3, 0)
        Me.ListadoFamiliaLink.Name = "ListadoFamiliaLink"
        Me.ListadoFamiliaLink.Size = New System.Drawing.Size(133, 16)
        Me.ListadoFamiliaLink.TabIndex = 267
        Me.ListadoFamiliaLink.Text = "Miembros de familia"
        Me.ListadoFamiliaLink.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NuevaButton
        '
        Me.NuevaButton.Location = New System.Drawing.Point(812, 3)
        Me.NuevaButton.Name = "NuevaButton"
        Me.NuevaButton.Size = New System.Drawing.Size(161, 30)
        Me.NuevaButton.TabIndex = 270
        Me.NuevaButton.Text = "Nueva Cta."
        Me.NuevaButton.UseVisualStyleBackColor = True
        '
        'HistorialGrid
        '
        Me.HistorialGrid.AllowUserToAddRows = False
        Me.HistorialGrid.AllowUserToDeleteRows = False
        Me.HistorialGrid.AllowUserToOrderColumns = True
        Me.HistorialGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialGrid.BackgroundColor = System.Drawing.Color.White
        Me.HistorialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialGrid.Location = New System.Drawing.Point(0, 333)
        Me.HistorialGrid.Name = "HistorialGrid"
        Me.HistorialGrid.ReadOnly = True
        Me.HistorialGrid.RowTemplate.Height = 28
        Me.HistorialGrid.Size = New System.Drawing.Size(973, 399)
        Me.HistorialGrid.TabIndex = 261
        Me.HistorialGrid.Visible = False
        '
        'BotonesTable
        '
        Me.BotonesTable.BackColor = System.Drawing.Color.Transparent
        Me.BotonesTable.ColumnCount = 7
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BotonesTable.Controls.Add(Me.ListadoFamiliaLink, 0, 0)
        Me.BotonesTable.Controls.Add(Me.InacButton, 4, 0)
        Me.BotonesTable.Controls.Add(Me.VerCuentas, 2, 0)
        Me.BotonesTable.Controls.Add(Me.NuevaButton, 6, 0)
        Me.BotonesTable.Location = New System.Drawing.Point(0, 272)
        Me.BotonesTable.Name = "BotonesTable"
        Me.BotonesTable.RowCount = 1
        Me.BotonesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BotonesTable.Size = New System.Drawing.Size(978, 41)
        Me.BotonesTable.TabIndex = 262
        Me.BotonesTable.Visible = False
        '
        'RegistroCuentasACHFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(978, 744)
        Me.Controls.Add(Me.BotonesTable)
        Me.Controls.Add(Me.HistorialGrid)
        Me.Controls.Add(Me.DatosTable)
        Me.Controls.Add(Me.InfoGen)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RegistroCuentasACHFamilias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Cuentas ACH Familias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.InfoGen.ResumeLayout(False)
        Me.InfoGen.PerformLayout()
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BotonesTable.ResumeLayout(False)
        Me.BotonesTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents InfoGen As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EstadoFam As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents DireccionV As System.Windows.Forms.Label
    Friend WithEvents DireccionL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BancoL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.TextBox
    Friend WithEvents BancoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents NoCuentaV As System.Windows.Forms.TextBox
    Friend WithEvents NoCuentaL As System.Windows.Forms.Label
    Friend WithEvents TipoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents HistorialGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TelReferencia As System.Windows.Forms.TextBox
    Friend WithEvents TelRefL As System.Windows.Forms.Label
    Friend WithEvents MiembroRef As System.Windows.Forms.TextBox
    Friend WithEvents VerCuentas As System.Windows.Forms.Label
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents ListadoFamiliaLink As System.Windows.Forms.Label
    Friend WithEvents MiembroRefL As System.Windows.Forms.Label
    Friend WithEvents NuevaButton As System.Windows.Forms.Button
    Friend WithEvents InacButton As System.Windows.Forms.Button
    Friend WithEvents ActvL As System.Windows.Forms.Label
    Friend WithEvents TelefonosL As System.Windows.Forms.Label
    Friend WithEvents BotonesTable As System.Windows.Forms.TableLayoutPanel
End Class
