<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarHoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresarHoras))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
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
        Me.horasL = New System.Windows.Forms.Label()
        Me.HorasV = New System.Windows.Forms.TextBox()
        Me.notasL = New System.Windows.Forms.Label()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.HorasTable = New System.Windows.Forms.TableLayoutPanel()
        Me.deL = New System.Windows.Forms.Label()
        Me.DePicker = New System.Windows.Forms.DateTimePicker()
        Me.ControlHorasL = New System.Windows.Forms.Label()
        Me.APicker = New System.Windows.Forms.DateTimePicker()
        Me.aL = New System.Windows.Forms.Label()
        Me.InfoSolTable = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaEstadoV = New System.Windows.Forms.DateTimePicker()
        Me.FaltantesV = New System.Windows.Forms.Label()
        Me.totalHrsL = New System.Windows.Forms.Label()
        Me.EstadoV = New System.Windows.Forms.Label()
        Me.estadoL = New System.Windows.Forms.Label()
        Me.fechaSolL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalHrsV = New System.Windows.Forms.Label()
        Me.THrsTrabV = New System.Windows.Forms.Label()
        Me.ObservV = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.faltantesL = New System.Windows.Forms.Label()
        Me.HorasTrabajadasGrid = New System.Windows.Forms.DataGridView()
        Me.PrincipalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.HorasTable.SuspendLayout()
        Me.InfoSolTable.SuspendLayout()
        CType(Me.HorasTrabajadasGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrincipalTable.SuspendLayout()
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
        Me.bannerPanel.TabIndex = 272
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
        Me.Title.Text = "Control de Horas"
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
        Me.TableLayoutPanel7.TabIndex = 273
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
        'horasL
        '
        Me.horasL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.horasL.AutoSize = True
        Me.horasL.Location = New System.Drawing.Point(13, 96)
        Me.horasL.Name = "horasL"
        Me.horasL.Size = New System.Drawing.Size(51, 28)
        Me.horasL.TabIndex = 277
        Me.horasL.Text = "*Horas:"
        Me.horasL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HorasV
        '
        Me.HorasV.Location = New System.Drawing.Point(70, 99)
        Me.HorasV.Name = "HorasV"
        Me.HorasV.Size = New System.Drawing.Size(59, 22)
        Me.HorasV.TabIndex = 3
        '
        'notasL
        '
        Me.notasL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.notasL.AutoSize = True
        Me.notasL.Location = New System.Drawing.Point(13, 124)
        Me.notasL.Name = "notasL"
        Me.notasL.Size = New System.Drawing.Size(51, 36)
        Me.notasL.TabIndex = 279
        Me.notasL.Text = "Notas:"
        Me.notasL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Location = New System.Drawing.Point(70, 127)
        Me.NotasV.MaxLength = 100
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(336, 22)
        Me.NotasV.TabIndex = 4
        '
        'HorasTable
        '
        Me.HorasTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HorasTable.BackColor = System.Drawing.Color.LightBlue
        Me.HorasTable.ColumnCount = 4
        Me.HorasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.HorasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.HorasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.HorasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.HorasTable.Controls.Add(Me.deL, 1, 2)
        Me.HorasTable.Controls.Add(Me.DePicker, 2, 2)
        Me.HorasTable.Controls.Add(Me.ControlHorasL, 1, 1)
        Me.HorasTable.Controls.Add(Me.APicker, 2, 3)
        Me.HorasTable.Controls.Add(Me.aL, 1, 3)
        Me.HorasTable.Controls.Add(Me.HorasV, 2, 4)
        Me.HorasTable.Controls.Add(Me.horasL, 1, 4)
        Me.HorasTable.Controls.Add(Me.NotasV, 2, 5)
        Me.HorasTable.Controls.Add(Me.notasL, 1, 5)
        Me.HorasTable.Location = New System.Drawing.Point(3, 3)
        Me.HorasTable.Name = "HorasTable"
        Me.HorasTable.RowCount = 6
        Me.HorasTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.HorasTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.HorasTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HorasTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HorasTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HorasTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.HorasTable.Size = New System.Drawing.Size(414, 160)
        Me.HorasTable.TabIndex = 281
        Me.HorasTable.Visible = False
        '
        'deL
        '
        Me.deL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deL.AutoSize = True
        Me.deL.Location = New System.Drawing.Point(13, 40)
        Me.deL.Name = "deL"
        Me.deL.Size = New System.Drawing.Size(51, 28)
        Me.deL.TabIndex = 0
        Me.deL.Text = "*De:"
        Me.deL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DePicker
        '
        Me.DePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DePicker.Location = New System.Drawing.Point(70, 43)
        Me.DePicker.Name = "DePicker"
        Me.DePicker.Size = New System.Drawing.Size(336, 22)
        Me.DePicker.TabIndex = 1
        '
        'ControlHorasL
        '
        Me.ControlHorasL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlHorasL.AutoSize = True
        Me.HorasTable.SetColumnSpan(Me.ControlHorasL, 2)
        Me.ControlHorasL.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlHorasL.Location = New System.Drawing.Point(13, 10)
        Me.ControlHorasL.Name = "ControlHorasL"
        Me.ControlHorasL.Size = New System.Drawing.Size(393, 16)
        Me.ControlHorasL.TabIndex = 280
        Me.ControlHorasL.Text = "Ingreso Horas"
        Me.ControlHorasL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'APicker
        '
        Me.APicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.APicker.Location = New System.Drawing.Point(70, 71)
        Me.APicker.Name = "APicker"
        Me.APicker.Size = New System.Drawing.Size(336, 22)
        Me.APicker.TabIndex = 2
        '
        'aL
        '
        Me.aL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aL.AutoSize = True
        Me.aL.Location = New System.Drawing.Point(13, 68)
        Me.aL.Name = "aL"
        Me.aL.Size = New System.Drawing.Size(51, 28)
        Me.aL.TabIndex = 275
        Me.aL.Text = "*A:"
        Me.aL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InfoSolTable
        '
        Me.InfoSolTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoSolTable.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InfoSolTable.ColumnCount = 8
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoSolTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoSolTable.Controls.Add(Me.FechaEstadoV, 4, 0)
        Me.InfoSolTable.Controls.Add(Me.FaltantesV, 7, 1)
        Me.InfoSolTable.Controls.Add(Me.totalHrsL, 0, 1)
        Me.InfoSolTable.Controls.Add(Me.EstadoV, 1, 0)
        Me.InfoSolTable.Controls.Add(Me.estadoL, 0, 0)
        Me.InfoSolTable.Controls.Add(Me.fechaSolL, 3, 0)
        Me.InfoSolTable.Controls.Add(Me.Label1, 3, 1)
        Me.InfoSolTable.Controls.Add(Me.TotalHrsV, 1, 1)
        Me.InfoSolTable.Controls.Add(Me.THrsTrabV, 4, 1)
        Me.InfoSolTable.Controls.Add(Me.ObservV, 7, 0)
        Me.InfoSolTable.Controls.Add(Me.Label3, 6, 0)
        Me.InfoSolTable.Controls.Add(Me.faltantesL, 6, 1)
        Me.InfoSolTable.Location = New System.Drawing.Point(6, 158)
        Me.InfoSolTable.Name = "InfoSolTable"
        Me.InfoSolTable.RowCount = 2
        Me.InfoSolTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoSolTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoSolTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InfoSolTable.Size = New System.Drawing.Size(973, 65)
        Me.InfoSolTable.TabIndex = 282
        Me.InfoSolTable.Visible = False
        '
        'FechaEstadoV
        '
        Me.FechaEstadoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaEstadoV.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.FechaEstadoV.Enabled = False
        Me.FechaEstadoV.Location = New System.Drawing.Point(420, 3)
        Me.FechaEstadoV.Name = "FechaEstadoV"
        Me.FechaEstadoV.Size = New System.Drawing.Size(253, 22)
        Me.FechaEstadoV.TabIndex = 287
        '
        'FaltantesV
        '
        Me.FaltantesV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaltantesV.AutoSize = True
        Me.FaltantesV.BackColor = System.Drawing.Color.DodgerBlue
        Me.FaltantesV.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaltantesV.ForeColor = System.Drawing.Color.White
        Me.FaltantesV.Location = New System.Drawing.Point(953, 32)
        Me.FaltantesV.Name = "FaltantesV"
        Me.FaltantesV.Size = New System.Drawing.Size(17, 33)
        Me.FaltantesV.TabIndex = 291
        Me.FaltantesV.Text = "_"
        Me.FaltantesV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalHrsL
        '
        Me.totalHrsL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalHrsL.AutoSize = True
        Me.totalHrsL.Location = New System.Drawing.Point(3, 32)
        Me.totalHrsL.Name = "totalHrsL"
        Me.totalHrsL.Size = New System.Drawing.Size(93, 33)
        Me.totalHrsL.TabIndex = 283
        Me.totalHrsL.Text = "Total de horas:"
        Me.totalHrsL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstadoV
        '
        Me.EstadoV.AutoSize = True
        Me.EstadoV.Location = New System.Drawing.Point(116, 0)
        Me.EstadoV.Name = "EstadoV"
        Me.EstadoV.Size = New System.Drawing.Size(15, 16)
        Me.EstadoV.TabIndex = 283
        Me.EstadoV.Text = "_"
        '
        'estadoL
        '
        Me.estadoL.AutoSize = True
        Me.estadoL.Location = New System.Drawing.Point(3, 0)
        Me.estadoL.Name = "estadoL"
        Me.estadoL.Size = New System.Drawing.Size(107, 16)
        Me.estadoL.TabIndex = 0
        Me.estadoL.Text = "Estado Solicitud:"
        '
        'fechaSolL
        '
        Me.fechaSolL.AutoSize = True
        Me.fechaSolL.Location = New System.Drawing.Point(311, 0)
        Me.fechaSolL.Name = "fechaSolL"
        Me.fechaSolL.Size = New System.Drawing.Size(93, 16)
        Me.fechaSolL.TabIndex = 284
        Me.fechaSolL.Text = "Fecha Estado:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 33)
        Me.Label1.TabIndex = 285
        Me.Label1.Text = "Hrs. Trabajadas:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalHrsV
        '
        Me.TotalHrsV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalHrsV.AutoSize = True
        Me.TotalHrsV.BackColor = System.Drawing.Color.SkyBlue
        Me.TotalHrsV.Location = New System.Drawing.Point(116, 32)
        Me.TotalHrsV.Name = "TotalHrsV"
        Me.TotalHrsV.Size = New System.Drawing.Size(15, 33)
        Me.TotalHrsV.TabIndex = 288
        Me.TotalHrsV.Text = "_"
        Me.TotalHrsV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'THrsTrabV
        '
        Me.THrsTrabV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.THrsTrabV.AutoSize = True
        Me.THrsTrabV.BackColor = System.Drawing.Color.SkyBlue
        Me.THrsTrabV.Location = New System.Drawing.Point(420, 32)
        Me.THrsTrabV.Name = "THrsTrabV"
        Me.THrsTrabV.Size = New System.Drawing.Size(253, 33)
        Me.THrsTrabV.TabIndex = 290
        Me.THrsTrabV.Text = "_"
        Me.THrsTrabV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ObservV
        '
        Me.ObservV.AutoSize = True
        Me.ObservV.Location = New System.Drawing.Point(953, 0)
        Me.ObservV.Name = "ObservV"
        Me.ObservV.Size = New System.Drawing.Size(15, 16)
        Me.ObservV.TabIndex = 289
        Me.ObservV.Text = "_"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(853, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 287
        Me.Label3.Text = "Notas:"
        '
        'faltantesL
        '
        Me.faltantesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.faltantesL.AutoSize = True
        Me.faltantesL.Location = New System.Drawing.Point(853, 32)
        Me.faltantesL.Name = "faltantesL"
        Me.faltantesL.Size = New System.Drawing.Size(94, 33)
        Me.faltantesL.TabIndex = 291
        Me.faltantesL.Text = "Hrs. Faltantes:"
        Me.faltantesL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HorasTrabajadasGrid
        '
        Me.HorasTrabajadasGrid.AllowUserToAddRows = False
        Me.HorasTrabajadasGrid.AllowUserToDeleteRows = False
        Me.HorasTrabajadasGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HorasTrabajadasGrid.BackgroundColor = System.Drawing.Color.White
        Me.HorasTrabajadasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HorasTrabajadasGrid.Location = New System.Drawing.Point(473, 3)
        Me.HorasTrabajadasGrid.Name = "HorasTrabajadasGrid"
        Me.HorasTrabajadasGrid.ReadOnly = True
        Me.HorasTrabajadasGrid.RowHeadersVisible = False
        Me.HorasTrabajadasGrid.Size = New System.Drawing.Size(497, 395)
        Me.HorasTrabajadasGrid.TabIndex = 283
        Me.HorasTrabajadasGrid.Visible = False
        '
        'PrincipalTable
        '
        Me.PrincipalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalTable.ColumnCount = 3
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalTable.Controls.Add(Me.HorasTable, 0, 0)
        Me.PrincipalTable.Controls.Add(Me.HorasTrabajadasGrid, 2, 0)
        Me.PrincipalTable.Location = New System.Drawing.Point(3, 248)
        Me.PrincipalTable.Name = "PrincipalTable"
        Me.PrincipalTable.RowCount = 1
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalTable.Size = New System.Drawing.Size(973, 401)
        Me.PrincipalTable.TabIndex = 284
        '
        'IngresarHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PrincipalTable)
        Me.Controls.Add(Me.InfoSolTable)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IngresarHoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Horas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.HorasTable.ResumeLayout(False)
        Me.HorasTable.PerformLayout()
        Me.InfoSolTable.ResumeLayout(False)
        Me.InfoSolTable.PerformLayout()
        CType(Me.HorasTrabajadasGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrincipalTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionV As System.Windows.Forms.Label
    Friend WithEvents regionL As System.Windows.Forms.Label
    Friend WithEvents DireccionV As System.Windows.Forms.Label
    Friend WithEvents DireccionL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents horasL As System.Windows.Forms.Label
    Friend WithEvents HorasV As System.Windows.Forms.TextBox
    Friend WithEvents notasL As System.Windows.Forms.Label
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents HorasTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InfoSolTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents totalHrsL As System.Windows.Forms.Label
    Friend WithEvents EstadoV As System.Windows.Forms.Label
    Friend WithEvents estadoL As System.Windows.Forms.Label
    Friend WithEvents fechaSolL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TotalHrsV As System.Windows.Forms.Label
    Friend WithEvents THrsTrabV As System.Windows.Forms.Label
    Friend WithEvents ObservV As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents APicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HorasTrabajadasGrid As System.Windows.Forms.DataGridView
    Friend WithEvents deL As System.Windows.Forms.Label
    Friend WithEvents ControlHorasL As System.Windows.Forms.Label
    Friend WithEvents aL As System.Windows.Forms.Label
    Friend WithEvents PrincipalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FaltantesV As System.Windows.Forms.Label
    Friend WithEvents faltantesL As System.Windows.Forms.Label
    Friend WithEvents FechaEstadoV As System.Windows.Forms.DateTimePicker
End Class
