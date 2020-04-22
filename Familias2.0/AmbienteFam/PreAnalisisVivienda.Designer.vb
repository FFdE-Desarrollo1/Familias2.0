<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreAnalisisVivienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreAnalisisVivienda))
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
        Me.diagnosisTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ComentarioV = New System.Windows.Forms.TextBox()
        Me.comentarioL = New System.Windows.Forms.Label()
        Me.AplicaCheckBox = New System.Windows.Forms.CheckBox()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.notasL = New System.Windows.Forms.Label()
        Me.codeD = New System.Windows.Forms.Label()
        Me.diagnosticoL = New System.Windows.Forms.Label()
        Me.DiagnosticoCombo = New System.Windows.Forms.ComboBox()
        Me.CondiconesActualesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TamañoV = New System.Windows.Forms.Label()
        Me.TerrenoV = New System.Windows.Forms.Label()
        Me.cuartosL = New System.Windows.Forms.Label()
        Me.terrenoL = New System.Windows.Forms.Label()
        Me.tamañoL = New System.Windows.Forms.Label()
        Me.CuartosV = New System.Windows.Forms.Label()
        Me.condicionesActL = New System.Windows.Forms.Label()
        Me.paredesL = New System.Windows.Forms.Label()
        Me.ParedesV = New System.Windows.Forms.Label()
        Me.pisoL = New System.Windows.Forms.Label()
        Me.PisoV = New System.Windows.Forms.Label()
        Me.cocinaL = New System.Windows.Forms.Label()
        Me.CocinaV = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AvisosGrid = New System.Windows.Forms.DataGridView()
        Me.EducL = New System.Windows.Forms.Label()
        Me.OtrosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.EducGrid = New System.Windows.Forms.DataGridView()
        Me.historialAmbL = New System.Windows.Forms.Label()
        Me.AmbienteGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.diagnosisTable.SuspendLayout()
        Me.CondiconesActualesTable.SuspendLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OtrosTable.SuspendLayout()
        CType(Me.EducGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmbienteGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bannerPanel.TabIndex = 262
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
        Me.ListadoButton.TabIndex = 238
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
        Me.Title.Text = "Análisis Preliminar para Construcción de Vivienda"
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
        Me.TableLayoutPanel7.TabIndex = 263
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
        'diagnosisTable
        '
        Me.diagnosisTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diagnosisTable.BackColor = System.Drawing.Color.LightBlue
        Me.diagnosisTable.ColumnCount = 6
        Me.diagnosisTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.diagnosisTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.diagnosisTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.diagnosisTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.diagnosisTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.diagnosisTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.diagnosisTable.Controls.Add(Me.ComentarioV, 2, 2)
        Me.diagnosisTable.Controls.Add(Me.comentarioL, 1, 2)
        Me.diagnosisTable.Controls.Add(Me.AplicaCheckBox, 0, 2)
        Me.diagnosisTable.Controls.Add(Me.NotasV, 5, 2)
        Me.diagnosisTable.Controls.Add(Me.notasL, 4, 2)
        Me.diagnosisTable.Controls.Add(Me.codeD, 3, 2)
        Me.diagnosisTable.Controls.Add(Me.diagnosticoL, 0, 1)
        Me.diagnosisTable.Controls.Add(Me.DiagnosticoCombo, 1, 1)
        Me.diagnosisTable.Location = New System.Drawing.Point(6, 160)
        Me.diagnosisTable.Name = "diagnosisTable"
        Me.diagnosisTable.RowCount = 4
        Me.diagnosisTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.diagnosisTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.diagnosisTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.diagnosisTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.diagnosisTable.Size = New System.Drawing.Size(973, 77)
        Me.diagnosisTable.TabIndex = 264
        Me.diagnosisTable.Visible = False
        '
        'ComentarioV
        '
        Me.ComentarioV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComentarioV.BackColor = System.Drawing.Color.White
        Me.ComentarioV.Enabled = False
        Me.ComentarioV.Location = New System.Drawing.Point(195, 41)
        Me.ComentarioV.Name = "ComentarioV"
        Me.ComentarioV.ReadOnly = True
        Me.ComentarioV.Size = New System.Drawing.Size(348, 22)
        Me.ComentarioV.TabIndex = 266
        Me.ComentarioV.Visible = False
        '
        'comentarioL
        '
        Me.comentarioL.AutoSize = True
        Me.comentarioL.Location = New System.Drawing.Point(111, 38)
        Me.comentarioL.Name = "comentarioL"
        Me.comentarioL.Size = New System.Drawing.Size(78, 16)
        Me.comentarioL.TabIndex = 265
        Me.comentarioL.Text = "Comentario:"
        Me.comentarioL.Visible = False
        '
        'AplicaCheckBox
        '
        Me.AplicaCheckBox.AutoSize = True
        Me.AplicaCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.AplicaCheckBox.Enabled = False
        Me.AplicaCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AplicaCheckBox.ForeColor = System.Drawing.Color.Black
        Me.AplicaCheckBox.Location = New System.Drawing.Point(3, 41)
        Me.AplicaCheckBox.Name = "AplicaCheckBox"
        Me.AplicaCheckBox.Size = New System.Drawing.Size(75, 20)
        Me.AplicaCheckBox.TabIndex = 0
        Me.AplicaCheckBox.Text = "Aplica -"
        Me.AplicaCheckBox.UseVisualStyleBackColor = False
        Me.AplicaCheckBox.Visible = False
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Location = New System.Drawing.Point(621, 41)
        Me.NotasV.MaxLength = 100
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(349, 22)
        Me.NotasV.TabIndex = 268
        '
        'notasL
        '
        Me.notasL.AutoSize = True
        Me.notasL.Location = New System.Drawing.Point(569, 38)
        Me.notasL.Name = "notasL"
        Me.notasL.Size = New System.Drawing.Size(46, 16)
        Me.notasL.TabIndex = 269
        Me.notasL.Text = "Notas:"
        '
        'codeD
        '
        Me.codeD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.codeD.AutoSize = True
        Me.codeD.Location = New System.Drawing.Point(549, 38)
        Me.codeD.Name = "codeD"
        Me.codeD.Size = New System.Drawing.Size(14, 28)
        Me.codeD.TabIndex = 267
        Me.codeD.Text = "-"
        Me.codeD.Visible = False
        '
        'diagnosticoL
        '
        Me.diagnosticoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.diagnosticoL.AutoSize = True
        Me.diagnosticoL.BackColor = System.Drawing.Color.DodgerBlue
        Me.diagnosticoL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diagnosticoL.ForeColor = System.Drawing.Color.AliceBlue
        Me.diagnosticoL.Location = New System.Drawing.Point(3, 10)
        Me.diagnosticoL.Name = "diagnosticoL"
        Me.diagnosticoL.Size = New System.Drawing.Size(102, 28)
        Me.diagnosticoL.TabIndex = 2
        Me.diagnosticoL.Text = "*Diagnostico:"
        Me.diagnosticoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiagnosticoCombo
        '
        Me.DiagnosticoCombo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diagnosisTable.SetColumnSpan(Me.DiagnosticoCombo, 5)
        Me.DiagnosticoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiagnosticoCombo.FormattingEnabled = True
        Me.DiagnosticoCombo.Location = New System.Drawing.Point(111, 13)
        Me.DiagnosticoCombo.Name = "DiagnosticoCombo"
        Me.DiagnosticoCombo.Size = New System.Drawing.Size(859, 24)
        Me.DiagnosticoCombo.TabIndex = 1
        '
        'CondiconesActualesTable
        '
        Me.CondiconesActualesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CondiconesActualesTable.ColumnCount = 3
        Me.CondiconesActualesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.CondiconesActualesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CondiconesActualesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CondiconesActualesTable.Controls.Add(Me.TamañoV, 1, 3)
        Me.CondiconesActualesTable.Controls.Add(Me.TerrenoV, 1, 2)
        Me.CondiconesActualesTable.Controls.Add(Me.cuartosL, 0, 1)
        Me.CondiconesActualesTable.Controls.Add(Me.terrenoL, 0, 2)
        Me.CondiconesActualesTable.Controls.Add(Me.tamañoL, 0, 3)
        Me.CondiconesActualesTable.Controls.Add(Me.CuartosV, 1, 1)
        Me.CondiconesActualesTable.Controls.Add(Me.condicionesActL, 0, 0)
        Me.CondiconesActualesTable.Controls.Add(Me.paredesL, 0, 4)
        Me.CondiconesActualesTable.Controls.Add(Me.ParedesV, 1, 4)
        Me.CondiconesActualesTable.Controls.Add(Me.pisoL, 0, 5)
        Me.CondiconesActualesTable.Controls.Add(Me.PisoV, 1, 5)
        Me.CondiconesActualesTable.Controls.Add(Me.cocinaL, 0, 6)
        Me.CondiconesActualesTable.Controls.Add(Me.CocinaV, 1, 6)
        Me.CondiconesActualesTable.Controls.Add(Me.Label8, 2, 0)
        Me.CondiconesActualesTable.Controls.Add(Me.AvisosGrid, 2, 1)
        Me.CondiconesActualesTable.Location = New System.Drawing.Point(0, 262)
        Me.CondiconesActualesTable.Name = "CondiconesActualesTable"
        Me.CondiconesActualesTable.RowCount = 7
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CondiconesActualesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CondiconesActualesTable.Size = New System.Drawing.Size(984, 161)
        Me.CondiconesActualesTable.TabIndex = 265
        Me.CondiconesActualesTable.Visible = False
        '
        'TamañoV
        '
        Me.TamañoV.AutoSize = True
        Me.TamañoV.Location = New System.Drawing.Point(94, 52)
        Me.TamañoV.Name = "TamañoV"
        Me.TamañoV.Size = New System.Drawing.Size(12, 16)
        Me.TamañoV.TabIndex = 275
        Me.TamañoV.Text = "-"
        '
        'TerrenoV
        '
        Me.TerrenoV.AutoSize = True
        Me.TerrenoV.Location = New System.Drawing.Point(94, 36)
        Me.TerrenoV.Name = "TerrenoV"
        Me.TerrenoV.Size = New System.Drawing.Size(12, 16)
        Me.TerrenoV.TabIndex = 275
        Me.TerrenoV.Text = "-"
        '
        'cuartosL
        '
        Me.cuartosL.AutoSize = True
        Me.cuartosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuartosL.Location = New System.Drawing.Point(3, 20)
        Me.cuartosL.Name = "cuartosL"
        Me.cuartosL.Size = New System.Drawing.Size(60, 16)
        Me.cuartosL.TabIndex = 267
        Me.cuartosL.Text = "Cuartos:"
        '
        'terrenoL
        '
        Me.terrenoL.AutoSize = True
        Me.terrenoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terrenoL.Location = New System.Drawing.Point(3, 36)
        Me.terrenoL.Name = "terrenoL"
        Me.terrenoL.Size = New System.Drawing.Size(61, 16)
        Me.terrenoL.TabIndex = 269
        Me.terrenoL.Text = "Terreno:"
        '
        'tamañoL
        '
        Me.tamañoL.AutoSize = True
        Me.tamañoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tamañoL.Location = New System.Drawing.Point(3, 52)
        Me.tamañoL.Name = "tamañoL"
        Me.tamañoL.Size = New System.Drawing.Size(63, 16)
        Me.tamañoL.TabIndex = 270
        Me.tamañoL.Text = "Tamaño:"
        '
        'CuartosV
        '
        Me.CuartosV.AutoSize = True
        Me.CuartosV.Location = New System.Drawing.Point(94, 20)
        Me.CuartosV.Name = "CuartosV"
        Me.CuartosV.Size = New System.Drawing.Size(12, 16)
        Me.CuartosV.TabIndex = 274
        Me.CuartosV.Text = "-"
        '
        'condicionesActL
        '
        Me.condicionesActL.AutoSize = True
        Me.CondiconesActualesTable.SetColumnSpan(Me.condicionesActL, 2)
        Me.condicionesActL.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.condicionesActL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.condicionesActL.Location = New System.Drawing.Point(3, 0)
        Me.condicionesActL.Name = "condicionesActL"
        Me.condicionesActL.Size = New System.Drawing.Size(370, 16)
        Me.condicionesActL.TabIndex = 266
        Me.condicionesActL.Text = "Condiciones Actuales Vivienda (Información de Familias)"
        '
        'paredesL
        '
        Me.paredesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.paredesL.AutoSize = True
        Me.paredesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paredesL.Location = New System.Drawing.Point(3, 101)
        Me.paredesL.Name = "paredesL"
        Me.paredesL.Size = New System.Drawing.Size(64, 20)
        Me.paredesL.TabIndex = 268
        Me.paredesL.Text = "Paredes:"
        '
        'ParedesV
        '
        Me.ParedesV.AutoSize = True
        Me.ParedesV.Location = New System.Drawing.Point(94, 101)
        Me.ParedesV.Name = "ParedesV"
        Me.ParedesV.Size = New System.Drawing.Size(12, 16)
        Me.ParedesV.TabIndex = 275
        Me.ParedesV.Text = "-"
        '
        'pisoL
        '
        Me.pisoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pisoL.AutoSize = True
        Me.pisoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pisoL.Location = New System.Drawing.Point(3, 121)
        Me.pisoL.Name = "pisoL"
        Me.pisoL.Size = New System.Drawing.Size(39, 20)
        Me.pisoL.TabIndex = 271
        Me.pisoL.Text = "Piso:"
        '
        'PisoV
        '
        Me.PisoV.AutoSize = True
        Me.PisoV.Location = New System.Drawing.Point(94, 121)
        Me.PisoV.Name = "PisoV"
        Me.PisoV.Size = New System.Drawing.Size(12, 16)
        Me.PisoV.TabIndex = 275
        Me.PisoV.Text = "-"
        '
        'cocinaL
        '
        Me.cocinaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cocinaL.AutoSize = True
        Me.cocinaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cocinaL.Location = New System.Drawing.Point(3, 141)
        Me.cocinaL.Name = "cocinaL"
        Me.cocinaL.Size = New System.Drawing.Size(85, 20)
        Me.cocinaL.TabIndex = 272
        Me.cocinaL.Text = "Cocina Con:"
        '
        'CocinaV
        '
        Me.CocinaV.AutoSize = True
        Me.CocinaV.Location = New System.Drawing.Point(94, 141)
        Me.CocinaV.Name = "CocinaV"
        Me.CocinaV.Size = New System.Drawing.Size(12, 16)
        Me.CocinaV.TabIndex = 275
        Me.CocinaV.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(540, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 16)
        Me.Label8.TabIndex = 273
        Me.Label8.Text = "Avisos Familiares"
        '
        'AvisosGrid
        '
        Me.AvisosGrid.AllowUserToAddRows = False
        Me.AvisosGrid.AllowUserToDeleteRows = False
        Me.AvisosGrid.AllowUserToResizeColumns = False
        Me.AvisosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AvisosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvisosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AvisosGrid.BackgroundColor = System.Drawing.Color.White
        Me.AvisosGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvisosGrid.CausesValidation = False
        Me.AvisosGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.AvisosGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.AvisosGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvisosGrid.ColumnHeadersVisible = False
        Me.AvisosGrid.GridColor = System.Drawing.Color.White
        Me.AvisosGrid.Location = New System.Drawing.Point(541, 24)
        Me.AvisosGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.AvisosGrid.MultiSelect = False
        Me.AvisosGrid.Name = "AvisosGrid"
        Me.AvisosGrid.ReadOnly = True
        Me.AvisosGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AvisosGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.RowHeadersVisible = False
        Me.AvisosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy
        Me.AvisosGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.CondiconesActualesTable.SetRowSpan(Me.AvisosGrid, 6)
        Me.AvisosGrid.RowTemplate.ReadOnly = True
        Me.AvisosGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.AvisosGrid.ShowEditingIcon = False
        Me.AvisosGrid.Size = New System.Drawing.Size(439, 133)
        Me.AvisosGrid.TabIndex = 270
        Me.AvisosGrid.Visible = False
        '
        'EducL
        '
        Me.EducL.AutoSize = True
        Me.EducL.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EducL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.EducL.Location = New System.Drawing.Point(3, 0)
        Me.EducL.Name = "EducL"
        Me.EducL.Size = New System.Drawing.Size(234, 16)
        Me.EducL.TabIndex = 267
        Me.EducL.Text = "Información Educativa Apadrinados"
        '
        'OtrosTable
        '
        Me.OtrosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtrosTable.ColumnCount = 3
        Me.OtrosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.OtrosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OtrosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.OtrosTable.Controls.Add(Me.EducL, 0, 0)
        Me.OtrosTable.Controls.Add(Me.EducGrid, 0, 1)
        Me.OtrosTable.Controls.Add(Me.historialAmbL, 2, 0)
        Me.OtrosTable.Controls.Add(Me.AmbienteGrid, 2, 1)
        Me.OtrosTable.Location = New System.Drawing.Point(0, 427)
        Me.OtrosTable.Name = "OtrosTable"
        Me.OtrosTable.RowCount = 2
        Me.OtrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OtrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OtrosTable.Size = New System.Drawing.Size(984, 231)
        Me.OtrosTable.TabIndex = 269
        Me.OtrosTable.Visible = False
        '
        'EducGrid
        '
        Me.EducGrid.AllowUserToAddRows = False
        Me.EducGrid.AllowUserToDeleteRows = False
        Me.EducGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EducGrid.BackgroundColor = System.Drawing.Color.White
        Me.EducGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EducGrid.Location = New System.Drawing.Point(3, 19)
        Me.EducGrid.Name = "EducGrid"
        Me.EducGrid.ReadOnly = True
        Me.EducGrid.Size = New System.Drawing.Size(572, 209)
        Me.EducGrid.TabIndex = 271
        '
        'historialAmbL
        '
        Me.historialAmbL.AutoSize = True
        Me.historialAmbL.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historialAmbL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.historialAmbL.Location = New System.Drawing.Point(601, 0)
        Me.historialAmbL.Name = "historialAmbL"
        Me.historialAmbL.Size = New System.Drawing.Size(182, 16)
        Me.historialAmbL.TabIndex = 270
        Me.historialAmbL.Text = "Historial Ambiente Familiar"
        '
        'AmbienteGrid
        '
        Me.AmbienteGrid.AllowUserToAddRows = False
        Me.AmbienteGrid.AllowUserToDeleteRows = False
        Me.AmbienteGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmbienteGrid.BackgroundColor = System.Drawing.Color.White
        Me.AmbienteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AmbienteGrid.Location = New System.Drawing.Point(601, 19)
        Me.AmbienteGrid.Name = "AmbienteGrid"
        Me.AmbienteGrid.ReadOnly = True
        Me.AmbienteGrid.Size = New System.Drawing.Size(380, 209)
        Me.AmbienteGrid.TabIndex = 272
        '
        'PreAnalisisVivienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.OtrosTable)
        Me.Controls.Add(Me.CondiconesActualesTable)
        Me.Controls.Add(Me.diagnosisTable)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PreAnalisisVivienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre-análisis Vivienda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.diagnosisTable.ResumeLayout(False)
        Me.diagnosisTable.PerformLayout()
        Me.CondiconesActualesTable.ResumeLayout(False)
        Me.CondiconesActualesTable.PerformLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OtrosTable.ResumeLayout(False)
        Me.OtrosTable.PerformLayout()
        CType(Me.EducGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmbienteGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents diagnosisTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AplicaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DiagnosticoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents diagnosticoL As System.Windows.Forms.Label
    Friend WithEvents ComentarioV As System.Windows.Forms.TextBox
    Friend WithEvents comentarioL As System.Windows.Forms.Label
    Friend WithEvents CondiconesActualesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents codeD As System.Windows.Forms.Label
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents notasL As System.Windows.Forms.Label
    Friend WithEvents condicionesActL As System.Windows.Forms.Label
    Friend WithEvents EducL As System.Windows.Forms.Label
    Friend WithEvents OtrosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents historialAmbL As System.Windows.Forms.Label
    Friend WithEvents cuartosL As System.Windows.Forms.Label
    Friend WithEvents paredesL As System.Windows.Forms.Label
    Friend WithEvents EducGrid As System.Windows.Forms.DataGridView
    Friend WithEvents terrenoL As System.Windows.Forms.Label
    Friend WithEvents tamañoL As System.Windows.Forms.Label
    Friend WithEvents pisoL As System.Windows.Forms.Label
    Friend WithEvents cocinaL As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CocinaV As System.Windows.Forms.Label
    Friend WithEvents PisoV As System.Windows.Forms.Label
    Friend WithEvents ParedesV As System.Windows.Forms.Label
    Friend WithEvents TamañoV As System.Windows.Forms.Label
    Friend WithEvents TerrenoV As System.Windows.Forms.Label
    Friend WithEvents CuartosV As System.Windows.Forms.Label
    Friend WithEvents AvisosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AmbienteGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
End Class
