<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroCDIs
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroCDIs))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.SeleccionadoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.fotoL = New System.Windows.Forms.Label()
        Me.ApadrinadoFoto = New System.Windows.Forms.PictureBox()
        Me.EntradaL = New System.Windows.Forms.Label()
        Me.NombreS = New System.Windows.Forms.Label()
        Me.TipoMiembroS = New System.Windows.Forms.Label()
        Me.HEntradaV = New System.Windows.Forms.DateTimePicker()
        Me.salidaCheckBox = New System.Windows.Forms.CheckBox()
        Me.ObservacionesS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalidaL = New System.Windows.Forms.Label()
        Me.HSalidaV = New System.Windows.Forms.DateTimePicker()
        Me.ImpresionesS = New System.Windows.Forms.Label()
        Me.nImpresionS = New System.Windows.Forms.TextBox()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.GeneralTable = New System.Windows.Forms.TableLayoutPanel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaV = New System.Windows.Forms.DateTimePicker()
        Me.TipoList = New System.Windows.Forms.ComboBox()
        Me.asistenciasAnterioresCheck = New System.Windows.Forms.CheckBox()
        Me.ActividadButton = New System.Windows.Forms.Button()
        Me.FechaButton = New System.Windows.Forms.Button()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Borra = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Salida = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.verFotoCheck = New System.Windows.Forms.CheckBox()
        Me.BuscarCheck = New System.Windows.Forms.CheckBox()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SeleccionadoTable.SuspendLayout()
        CType(Me.ApadrinadoFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralTable.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(1278, 123)
        Me.bannerPanel.TabIndex = 254
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NuevoButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GuardarButton, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(115, 70)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1163, 51)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(1061, 3)
        Me.NuevoButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(45, 45)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(1008, 3)
        Me.inicioButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(1114, 3)
        Me.GuardarButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(45, 45)
        Me.GuardarButton.TabIndex = 236
        Me.GuardarButton.UseVisualStyleBackColor = False
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
        Me.Title.Size = New System.Drawing.Size(994, 51)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Registro de Asistencias"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SeleccionadoTable
        '
        Me.SeleccionadoTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeleccionadoTable.BackColor = System.Drawing.Color.LightBlue
        Me.SeleccionadoTable.ColumnCount = 2
        Me.SeleccionadoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SeleccionadoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SeleccionadoTable.Controls.Add(Me.fotoL, 0, 13)
        Me.SeleccionadoTable.Controls.Add(Me.ApadrinadoFoto, 1, 13)
        Me.SeleccionadoTable.Controls.Add(Me.EntradaL, 0, 5)
        Me.SeleccionadoTable.Controls.Add(Me.NombreS, 0, 3)
        Me.SeleccionadoTable.Controls.Add(Me.TipoMiembroS, 0, 4)
        Me.SeleccionadoTable.Controls.Add(Me.HEntradaV, 1, 5)
        Me.SeleccionadoTable.Controls.Add(Me.salidaCheckBox, 0, 11)
        Me.SeleccionadoTable.Controls.Add(Me.ObservacionesS, 0, 10)
        Me.SeleccionadoTable.Controls.Add(Me.Label1, 0, 9)
        Me.SeleccionadoTable.Controls.Add(Me.SalidaL, 0, 6)
        Me.SeleccionadoTable.Controls.Add(Me.HSalidaV, 1, 6)
        Me.SeleccionadoTable.Controls.Add(Me.ImpresionesS, 0, 7)
        Me.SeleccionadoTable.Controls.Add(Me.nImpresionS, 0, 8)
        Me.SeleccionadoTable.Location = New System.Drawing.Point(1022, 72)
        Me.SeleccionadoTable.Name = "SeleccionadoTable"
        Me.SeleccionadoTable.RowCount = 14
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SeleccionadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SeleccionadoTable.Size = New System.Drawing.Size(244, 507)
        Me.SeleccionadoTable.TabIndex = 255
        '
        'fotoL
        '
        Me.fotoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fotoL.AutoSize = True
        Me.fotoL.BackColor = System.Drawing.Color.Transparent
        Me.fotoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fotoL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.fotoL.Location = New System.Drawing.Point(3, 228)
        Me.fotoL.Name = "fotoL"
        Me.fotoL.Size = New System.Drawing.Size(54, 279)
        Me.fotoL.TabIndex = 229
        Me.fotoL.Text = "_"
        Me.fotoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.fotoL.Visible = False
        '
        'ApadrinadoFoto
        '
        Me.ApadrinadoFoto.Location = New System.Drawing.Point(63, 231)
        Me.ApadrinadoFoto.Name = "ApadrinadoFoto"
        Me.ApadrinadoFoto.Size = New System.Drawing.Size(158, 169)
        Me.ApadrinadoFoto.TabIndex = 237
        Me.ApadrinadoFoto.TabStop = False
        Me.ApadrinadoFoto.Visible = False
        '
        'EntradaL
        '
        Me.EntradaL.AutoSize = True
        Me.EntradaL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntradaL.Location = New System.Drawing.Point(3, 34)
        Me.EntradaL.Name = "EntradaL"
        Me.EntradaL.Size = New System.Drawing.Size(54, 15)
        Me.EntradaL.TabIndex = 256
        Me.EntradaL.Text = "Entrada:"
        Me.EntradaL.Visible = False
        '
        'NombreS
        '
        Me.NombreS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreS.AutoSize = True
        Me.NombreS.BackColor = System.Drawing.Color.Blue
        Me.SeleccionadoTable.SetColumnSpan(Me.NombreS, 2)
        Me.NombreS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreS.ForeColor = System.Drawing.Color.White
        Me.NombreS.Location = New System.Drawing.Point(3, 0)
        Me.NombreS.Name = "NombreS"
        Me.NombreS.Size = New System.Drawing.Size(238, 18)
        Me.NombreS.TabIndex = 225
        Me.NombreS.Text = "Nombre"
        Me.NombreS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TipoMiembroS
        '
        Me.TipoMiembroS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMiembroS.AutoSize = True
        Me.TipoMiembroS.BackColor = System.Drawing.Color.Silver
        Me.SeleccionadoTable.SetColumnSpan(Me.TipoMiembroS, 2)
        Me.TipoMiembroS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMiembroS.Location = New System.Drawing.Point(3, 18)
        Me.TipoMiembroS.Name = "TipoMiembroS"
        Me.TipoMiembroS.Size = New System.Drawing.Size(238, 16)
        Me.TipoMiembroS.TabIndex = 227
        Me.TipoMiembroS.Text = "tipo de miembro"
        Me.TipoMiembroS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HEntradaV
        '
        Me.HEntradaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HEntradaV.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HEntradaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HEntradaV.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HEntradaV.Location = New System.Drawing.Point(63, 37)
        Me.HEntradaV.Name = "HEntradaV"
        Me.HEntradaV.Size = New System.Drawing.Size(178, 22)
        Me.HEntradaV.TabIndex = 245
        Me.HEntradaV.Visible = False
        '
        'salidaCheckBox
        '
        Me.salidaCheckBox.AutoSize = True
        Me.SeleccionadoTable.SetColumnSpan(Me.salidaCheckBox, 2)
        Me.salidaCheckBox.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salidaCheckBox.Location = New System.Drawing.Point(3, 195)
        Me.salidaCheckBox.Name = "salidaCheckBox"
        Me.salidaCheckBox.Size = New System.Drawing.Size(69, 20)
        Me.salidaCheckBox.TabIndex = 235
        Me.salidaCheckBox.Text = "Salida"
        Me.salidaCheckBox.UseVisualStyleBackColor = True
        Me.salidaCheckBox.Visible = False
        '
        'ObservacionesS
        '
        Me.ObservacionesS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeleccionadoTable.SetColumnSpan(Me.ObservacionesS, 2)
        Me.ObservacionesS.Location = New System.Drawing.Point(3, 157)
        Me.ObservacionesS.MaxLength = 120
        Me.ObservacionesS.Multiline = True
        Me.ObservacionesS.Name = "ObservacionesS"
        Me.ObservacionesS.Size = New System.Drawing.Size(238, 32)
        Me.ObservacionesS.TabIndex = 234
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.SeleccionadoTable.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Comentarios:"
        '
        'SalidaL
        '
        Me.SalidaL.AutoSize = True
        Me.SalidaL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalidaL.Location = New System.Drawing.Point(3, 62)
        Me.SalidaL.Name = "SalidaL"
        Me.SalidaL.Size = New System.Drawing.Size(45, 15)
        Me.SalidaL.TabIndex = 256
        Me.SalidaL.Text = "Salida:"
        Me.SalidaL.Visible = False
        '
        'HSalidaV
        '
        Me.HSalidaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HSalidaV.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HSalidaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HSalidaV.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HSalidaV.Location = New System.Drawing.Point(63, 65)
        Me.HSalidaV.Name = "HSalidaV"
        Me.HSalidaV.Size = New System.Drawing.Size(178, 22)
        Me.HSalidaV.TabIndex = 251
        Me.HSalidaV.Visible = False
        '
        'ImpresionesS
        '
        Me.ImpresionesS.AutoSize = True
        Me.SeleccionadoTable.SetColumnSpan(Me.ImpresionesS, 2)
        Me.ImpresionesS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpresionesS.Location = New System.Drawing.Point(3, 90)
        Me.ImpresionesS.Name = "ImpresionesS"
        Me.ImpresionesS.Size = New System.Drawing.Size(91, 15)
        Me.ImpresionesS.TabIndex = 231
        Me.ImpresionesS.Text = "# impresiones:"
        Me.ImpresionesS.Visible = False
        '
        'nImpresionS
        '
        Me.nImpresionS.Location = New System.Drawing.Point(3, 113)
        Me.nImpresionS.Name = "nImpresionS"
        Me.nImpresionS.Size = New System.Drawing.Size(44, 23)
        Me.nImpresionS.TabIndex = 232
        Me.nImpresionS.Text = "0"
        Me.nImpresionS.Visible = False
        '
        'MiembroL
        '
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(3, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(68, 16)
        Me.MiembroL.TabIndex = 237
        Me.MiembroL.Text = "Miembro:"
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.Location = New System.Drawing.Point(77, 3)
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(78, 23)
        Me.MiembroV.TabIndex = 234
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.Location = New System.Drawing.Point(77, 32)
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(78, 23)
        Me.FamiliaV.TabIndex = 235
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 29)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(60, 16)
        Me.FamiliaL.TabIndex = 241
        Me.FamiliaL.Text = "Familia:"
        '
        'GeneralTable
        '
        Me.GeneralTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneralTable.ColumnCount = 3
        Me.GeneralTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GeneralTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.GeneralTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.GeneralTable.Controls.Add(Me.opcionesTable, 0, 0)
        Me.GeneralTable.Controls.Add(Me.NotasV, 1, 0)
        Me.GeneralTable.Controls.Add(Me.ListadoGrid, 0, 1)
        Me.GeneralTable.Controls.Add(Me.SeleccionadoTable, 2, 1)
        Me.GeneralTable.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.GeneralTable.Location = New System.Drawing.Point(3, 124)
        Me.GeneralTable.Name = "GeneralTable"
        Me.GeneralTable.RowCount = 3
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GeneralTable.Size = New System.Drawing.Size(1269, 616)
        Me.GeneralTable.TabIndex = 256
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.SteelBlue
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.Controls.Add(Me.FechaV, 2, 1)
        Me.opcionesTable.Controls.Add(Me.TipoList, 2, 0)
        Me.opcionesTable.Controls.Add(Me.asistenciasAnterioresCheck, 4, 1)
        Me.opcionesTable.Controls.Add(Me.ActividadButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.FechaButton, 1, 1)
        Me.opcionesTable.Location = New System.Drawing.Point(3, 3)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 2
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(983, 63)
        Me.opcionesTable.TabIndex = 257
        '
        'FechaV
        '
        Me.FechaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaV.Location = New System.Drawing.Point(532, 33)
        Me.FechaV.Name = "FechaV"
        Me.FechaV.Size = New System.Drawing.Size(259, 22)
        Me.FechaV.TabIndex = 244
        '
        'TipoList
        '
        Me.TipoList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoList.FormattingEnabled = True
        Me.TipoList.Location = New System.Drawing.Point(532, 3)
        Me.TipoList.Name = "TipoList"
        Me.TipoList.Size = New System.Drawing.Size(259, 24)
        Me.TipoList.TabIndex = 242
        '
        'asistenciasAnterioresCheck
        '
        Me.asistenciasAnterioresCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.asistenciasAnterioresCheck.AutoSize = True
        Me.asistenciasAnterioresCheck.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.asistenciasAnterioresCheck.ForeColor = System.Drawing.Color.White
        Me.asistenciasAnterioresCheck.Location = New System.Drawing.Point(817, 33)
        Me.asistenciasAnterioresCheck.Name = "asistenciasAnterioresCheck"
        Me.asistenciasAnterioresCheck.Size = New System.Drawing.Size(163, 27)
        Me.asistenciasAnterioresCheck.TabIndex = 252
        Me.asistenciasAnterioresCheck.Text = "Asistencias anteriores"
        Me.asistenciasAnterioresCheck.UseVisualStyleBackColor = True
        '
        'ActividadButton
        '
        Me.ActividadButton.Location = New System.Drawing.Point(451, 3)
        Me.ActividadButton.Name = "ActividadButton"
        Me.ActividadButton.Size = New System.Drawing.Size(75, 23)
        Me.ActividadButton.TabIndex = 253
        Me.ActividadButton.Text = "Actividad"
        Me.ActividadButton.UseVisualStyleBackColor = True
        '
        'FechaButton
        '
        Me.FechaButton.Location = New System.Drawing.Point(451, 33)
        Me.FechaButton.Name = "FechaButton"
        Me.FechaButton.Size = New System.Drawing.Size(75, 23)
        Me.FechaButton.TabIndex = 254
        Me.FechaButton.Text = "Fecha"
        Me.FechaButton.UseVisualStyleBackColor = True
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasV.Location = New System.Drawing.Point(992, 3)
        Me.NotasV.MaxLength = 120
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(24, 22)
        Me.NotasV.TabIndex = 243
        Me.NotasV.Visible = False
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Borra, Me.Salida})
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 72)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        Me.ListadoGrid.RowHeadersWidth = 10
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListadoGrid.Size = New System.Drawing.Size(983, 507)
        Me.ListadoGrid.TabIndex = 226
        '
        'No
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        Me.No.DefaultCellStyle = DataGridViewCellStyle2
        Me.No.HeaderText = "#"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 18
        '
        'Borra
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent
        Me.Borra.DefaultCellStyle = DataGridViewCellStyle3
        Me.Borra.HeaderText = "Cambios"
        Me.Borra.Name = "Borra"
        Me.Borra.ReadOnly = True
        Me.Borra.Width = 80
        '
        'Salida
        '
        Me.Salida.HeaderText = "Registrar"
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        Me.Salida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Salida.Width = 70
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.MiembroL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MiembroV, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.verFotoCheck, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BuscarCheck, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FamiliaV, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FamiliaL, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1022, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(244, 62)
        Me.TableLayoutPanel2.TabIndex = 258
        '
        'verFotoCheck
        '
        Me.verFotoCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.verFotoCheck.AutoSize = True
        Me.verFotoCheck.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verFotoCheck.Location = New System.Drawing.Point(161, 3)
        Me.verFotoCheck.Name = "verFotoCheck"
        Me.verFotoCheck.Size = New System.Drawing.Size(59, 23)
        Me.verFotoCheck.TabIndex = 224
        Me.verFotoCheck.Text = "Foto"
        Me.verFotoCheck.UseVisualStyleBackColor = True
        '
        'BuscarCheck
        '
        Me.BuscarCheck.AutoSize = True
        Me.BuscarCheck.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarCheck.ForeColor = System.Drawing.Color.Black
        Me.BuscarCheck.Location = New System.Drawing.Point(161, 32)
        Me.BuscarCheck.Name = "BuscarCheck"
        Me.BuscarCheck.Size = New System.Drawing.Size(67, 21)
        Me.BuscarCheck.TabIndex = 223
        Me.BuscarCheck.Text = "Buscar"
        Me.BuscarCheck.UseVisualStyleBackColor = True
        '
        'RegistroCDIs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(1278, 744)
        Me.Controls.Add(Me.GeneralTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RegistroCDIs"
        Me.Text = "Registro CDIs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SeleccionadoTable.ResumeLayout(False)
        Me.SeleccionadoTable.PerformLayout()
        CType(Me.ApadrinadoFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GeneralTable.ResumeLayout(False)
        Me.GeneralTable.PerformLayout()
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents SeleccionadoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents fotoL As System.Windows.Forms.Label
    Friend WithEvents ImpresionesS As System.Windows.Forms.Label
    Friend WithEvents nImpresionS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ObservacionesS As System.Windows.Forms.TextBox
    Friend WithEvents salidaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GeneralTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents verFotoCheck As System.Windows.Forms.CheckBox
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents TipoList As System.Windows.Forms.ComboBox
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents FechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents HEntradaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents TipoMiembroS As System.Windows.Forms.Label
    Friend WithEvents ApadrinadoFoto As System.Windows.Forms.PictureBox
    Friend WithEvents NombreS As System.Windows.Forms.Label
    Friend WithEvents BuscarCheck As System.Windows.Forms.CheckBox
    Friend WithEvents HSalidaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents asistenciasAnterioresCheck As System.Windows.Forms.CheckBox
    Friend WithEvents EntradaL As System.Windows.Forms.Label
    Friend WithEvents SalidaL As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Borra As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Salida As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents ActividadButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaButton As System.Windows.Forms.Button
End Class
