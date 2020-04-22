<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CobrosFarmacia
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CobrosFarmacia))
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.InstrL = New System.Windows.Forms.Label()
        Me.NombreUsual = New System.Windows.Forms.TextBox()
        Me.UsualL = New System.Windows.Forms.Label()
        Me.ApellidosV = New System.Windows.Forms.TextBox()
        Me.ApellidosL = New System.Windows.Forms.Label()
        Me.NombresV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.TotalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.VerTotalButton = New System.Windows.Forms.Button()
        Me.SelectPresTable = New System.Windows.Forms.TableLayoutPanel()
        Me.DrV = New System.Windows.Forms.Label()
        Me.fechaRecetaL = New System.Windows.Forms.Label()
        Me.PacienteV = New System.Windows.Forms.Label()
        Me.RecetaSelGrid = New System.Windows.Forms.DataGridView()
        Me.Seleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.InfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MemberList = New System.Windows.Forms.DataGridView()
        Me.CodigoGeneroL = New System.Windows.Forms.Label()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.RecetasGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TotalTable.SuspendLayout()
        Me.SelectPresTable.SuspendLayout()
        CType(Me.RecetaSelGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.principalTable.SuspendLayout()
        Me.InfoTable.SuspendLayout()
        CType(Me.MemberList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatosTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        CType(Me.RecetasGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Location = New System.Drawing.Point(527, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(128, 36)
        Me.MiembroL.TabIndex = 207
        Me.MiembroL.Text = "No. Afiliación:"
        Me.MiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(114, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InstrL
        '
        Me.InstrL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstrL.AutoSize = True
        Me.InstrL.BackColor = System.Drawing.Color.Transparent
        Me.InstrL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstrL.Location = New System.Drawing.Point(148, 0)
        Me.InstrL.Name = "InstrL"
        Me.InstrL.Size = New System.Drawing.Size(317, 40)
        Me.InstrL.TabIndex = 231
        Me.InstrL.Text = "Datos para buscar al empleado:"
        Me.InstrL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreUsual
        '
        Me.NombreUsual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreUsual.Location = New System.Drawing.Point(148, 43)
        Me.NombreUsual.MaxLength = 30
        Me.NombreUsual.Name = "NombreUsual"
        Me.NombreUsual.Size = New System.Drawing.Size(170, 30)
        Me.NombreUsual.TabIndex = 1
        '
        'UsualL
        '
        Me.UsualL.AutoSize = True
        Me.UsualL.BackColor = System.Drawing.Color.Transparent
        Me.UsualL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsualL.Location = New System.Drawing.Point(3, 40)
        Me.UsualL.Name = "UsualL"
        Me.UsualL.Size = New System.Drawing.Size(139, 23)
        Me.UsualL.TabIndex = 230
        Me.UsualL.Text = "Nombre Usual:"
        '
        'ApellidosV
        '
        Me.ApellidosV.Location = New System.Drawing.Point(148, 123)
        Me.ApellidosV.MaxLength = 40
        Me.ApellidosV.Name = "ApellidosV"
        Me.ApellidosV.Size = New System.Drawing.Size(270, 30)
        Me.ApellidosV.TabIndex = 3
        '
        'ApellidosL
        '
        Me.ApellidosL.AutoSize = True
        Me.ApellidosL.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosL.Location = New System.Drawing.Point(3, 120)
        Me.ApellidosL.Name = "ApellidosL"
        Me.ApellidosL.Size = New System.Drawing.Size(82, 20)
        Me.ApellidosL.TabIndex = 219
        Me.ApellidosL.Text = "Apellidos:"
        '
        'NombresV
        '
        Me.NombresV.Location = New System.Drawing.Point(148, 83)
        Me.NombresV.MaxLength = 40
        Me.NombresV.Name = "NombresV"
        Me.NombresV.Size = New System.Drawing.Size(317, 30)
        Me.NombresV.TabIndex = 2
        '
        'MiembroV
        '
        Me.MiembroV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(661, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(114, 40)
        Me.MiembroV.TabIndex = 207
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(123, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 40)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalTable
        '
        Me.TotalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalTable.ColumnCount = 2
        Me.TotalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TotalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TotalTable.Controls.Add(Me.TotalL, 1, 0)
        Me.TotalTable.Controls.Add(Me.VerTotalButton, 0, 0)
        Me.TotalTable.Location = New System.Drawing.Point(3, 377)
        Me.TotalTable.Name = "TotalTable"
        Me.TotalTable.RowCount = 1
        Me.TotalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TotalTable.Size = New System.Drawing.Size(778, 34)
        Me.TotalTable.TabIndex = 218
        '
        'TotalL
        '
        Me.TotalL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TotalL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.ForeColor = System.Drawing.Color.Black
        Me.TotalL.Location = New System.Drawing.Point(111, 0)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(25, 34)
        Me.TotalL.TabIndex = 218
        Me.TotalL.Text = "_"
        Me.TotalL.Visible = False
        '
        'VerTotalButton
        '
        Me.VerTotalButton.Location = New System.Drawing.Point(3, 3)
        Me.VerTotalButton.Name = "VerTotalButton"
        Me.VerTotalButton.Size = New System.Drawing.Size(102, 28)
        Me.VerTotalButton.TabIndex = 219
        Me.VerTotalButton.Text = "Calcular Total"
        Me.VerTotalButton.UseVisualStyleBackColor = True
        Me.VerTotalButton.Visible = False
        '
        'SelectPresTable
        '
        Me.SelectPresTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectPresTable.BackColor = System.Drawing.Color.Navy
        Me.SelectPresTable.ColumnCount = 3
        Me.SelectPresTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.SelectPresTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.SelectPresTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.SelectPresTable.Controls.Add(Me.DrV, 1, 0)
        Me.SelectPresTable.Controls.Add(Me.fechaRecetaL, 2, 0)
        Me.SelectPresTable.Controls.Add(Me.PacienteV, 0, 0)
        Me.SelectPresTable.Location = New System.Drawing.Point(3, 437)
        Me.SelectPresTable.Name = "SelectPresTable"
        Me.SelectPresTable.RowCount = 1
        Me.SelectPresTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SelectPresTable.Size = New System.Drawing.Size(778, 24)
        Me.SelectPresTable.TabIndex = 219
        '
        'DrV
        '
        Me.DrV.AutoSize = True
        Me.DrV.BackColor = System.Drawing.Color.Transparent
        Me.DrV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrV.ForeColor = System.Drawing.Color.White
        Me.DrV.Location = New System.Drawing.Point(262, 0)
        Me.DrV.Name = "DrV"
        Me.DrV.Size = New System.Drawing.Size(21, 23)
        Me.DrV.TabIndex = 206
        Me.DrV.Text = "_"
        '
        'fechaRecetaL
        '
        Me.fechaRecetaL.AutoSize = True
        Me.fechaRecetaL.BackColor = System.Drawing.Color.Transparent
        Me.fechaRecetaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaRecetaL.ForeColor = System.Drawing.Color.White
        Me.fechaRecetaL.Location = New System.Drawing.Point(521, 0)
        Me.fechaRecetaL.Name = "fechaRecetaL"
        Me.fechaRecetaL.Size = New System.Drawing.Size(21, 23)
        Me.fechaRecetaL.TabIndex = 205
        Me.fechaRecetaL.Text = "_"
        '
        'PacienteV
        '
        Me.PacienteV.AutoSize = True
        Me.PacienteV.BackColor = System.Drawing.Color.Transparent
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.Color.White
        Me.PacienteV.Location = New System.Drawing.Point(3, 0)
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(21, 23)
        Me.PacienteV.TabIndex = 57
        Me.PacienteV.Text = "_"
        '
        'RecetaSelGrid
        '
        Me.RecetaSelGrid.AllowUserToAddRows = False
        Me.RecetaSelGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.RecetaSelGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RecetaSelGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecetaSelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RecetaSelGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.RecetaSelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecetaSelGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.RecetaSelGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RecetaSelGrid.Location = New System.Drawing.Point(3, 467)
        Me.RecetaSelGrid.Name = "RecetaSelGrid"
        Me.RecetaSelGrid.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetaSelGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.RecetaSelGrid.Size = New System.Drawing.Size(778, 147)
        Me.RecetaSelGrid.TabIndex = 213
        Me.RecetaSelGrid.Visible = False
        '
        'Seleccionado
        '
        Me.Seleccionado.HeaderText = "Seleccionado"
        Me.Seleccionado.Name = "Seleccionado"
        Me.Seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Seleccionado.Width = 152
        '
        'NombreL
        '
        Me.NombreL.AutoSize = True
        Me.NombreL.BackColor = System.Drawing.Color.Transparent
        Me.NombreL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 80)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(82, 20)
        Me.NombreL.TabIndex = 218
        Me.NombreL.Text = "Nombres:"
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 1
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.Controls.Add(Me.InfoTable, 0, 0)
        Me.principalTable.Controls.Add(Me.PrincipalPanel, 0, 1)
        Me.principalTable.Controls.Add(Me.RecetaSelGrid, 0, 7)
        Me.principalTable.Controls.Add(Me.TotalTable, 0, 4)
        Me.principalTable.Controls.Add(Me.SelectPresTable, 0, 6)
        Me.principalTable.Controls.Add(Me.RecetasGrid, 0, 3)
        Me.principalTable.Location = New System.Drawing.Point(0, 124)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 8
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.principalTable.Size = New System.Drawing.Size(784, 617)
        Me.principalTable.TabIndex = 244
        '
        'InfoTable
        '
        Me.InfoTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTable.BackColor = System.Drawing.Color.Transparent
        Me.InfoTable.ColumnCount = 3
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.InfoTable.Controls.Add(Me.MemberList, 2, 0)
        Me.InfoTable.Controls.Add(Me.CodigoGeneroL, 1, 0)
        Me.InfoTable.Controls.Add(Me.DatosTable, 0, 0)
        Me.InfoTable.Location = New System.Drawing.Point(3, 3)
        Me.InfoTable.Name = "InfoTable"
        Me.InfoTable.RowCount = 1
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoTable.Size = New System.Drawing.Size(778, 87)
        Me.InfoTable.TabIndex = 243
        Me.InfoTable.Visible = False
        '
        'MemberList
        '
        Me.MemberList.AllowUserToAddRows = False
        Me.MemberList.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        Me.MemberList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MemberList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MemberList.BackgroundColor = System.Drawing.Color.White
        Me.MemberList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemberList.Location = New System.Drawing.Point(568, 3)
        Me.MemberList.Name = "MemberList"
        Me.MemberList.ReadOnly = True
        Me.MemberList.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.MemberList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MemberList.Size = New System.Drawing.Size(207, 81)
        Me.MemberList.TabIndex = 229
        '
        'CodigoGeneroL
        '
        Me.CodigoGeneroL.AutoSize = True
        Me.CodigoGeneroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoGeneroL.Location = New System.Drawing.Point(477, 0)
        Me.CodigoGeneroL.Name = "CodigoGeneroL"
        Me.CodigoGeneroL.Size = New System.Drawing.Size(21, 23)
        Me.CodigoGeneroL.TabIndex = 229
        Me.CodigoGeneroL.Text = "_"
        Me.CodigoGeneroL.Visible = False
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.AutoSize = True
        Me.DatosTable.BackColor = System.Drawing.Color.AliceBlue
        Me.DatosTable.ColumnCount = 2
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.Controls.Add(Me.InstrL, 1, 0)
        Me.DatosTable.Controls.Add(Me.NombreUsual, 1, 1)
        Me.DatosTable.Controls.Add(Me.UsualL, 0, 1)
        Me.DatosTable.Controls.Add(Me.ApellidosV, 1, 3)
        Me.DatosTable.Controls.Add(Me.ApellidosL, 0, 3)
        Me.DatosTable.Controls.Add(Me.NombresV, 1, 2)
        Me.DatosTable.Controls.Add(Me.NombreL, 0, 2)
        Me.DatosTable.Location = New System.Drawing.Point(3, 3)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 4
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.Size = New System.Drawing.Size(468, 81)
        Me.DatosTable.TabIndex = 234
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
        Me.PrincipalPanel.Controls.Add(Me.MiembroL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(3, 96)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(778, 36)
        Me.PrincipalPanel.TabIndex = 214
        '
        'RecetasGrid
        '
        Me.RecetasGrid.AllowUserToAddRows = False
        Me.RecetasGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Purple
        Me.RecetasGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.RecetasGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecetasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RecetasGrid.BackgroundColor = System.Drawing.Color.White
        Me.RecetasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecetasGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionado})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecetasGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.RecetasGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RecetasGrid.Location = New System.Drawing.Point(3, 148)
        Me.RecetasGrid.Name = "RecetasGrid"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetasGrid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.RecetasGrid.Size = New System.Drawing.Size(778, 223)
        Me.RecetasGrid.TabIndex = 217
        Me.RecetasGrid.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NuevoButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GuardarButton, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 53)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(582, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(531, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(637, 3)
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
        Me.Title.Size = New System.Drawing.Size(520, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Pendientes de Colaboración Salud"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CobrosFarmacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.principalTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CobrosFarmacia"
        Me.Text = "Colaboración Servicios Médicos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TotalTable.ResumeLayout(False)
        Me.TotalTable.PerformLayout()
        Me.SelectPresTable.ResumeLayout(False)
        Me.SelectPresTable.PerformLayout()
        CType(Me.RecetaSelGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.principalTable.ResumeLayout(False)
        Me.InfoTable.ResumeLayout(False)
        Me.InfoTable.PerformLayout()
        CType(Me.MemberList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        CType(Me.RecetasGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents InstrL As System.Windows.Forms.Label
    Friend WithEvents NombreUsual As System.Windows.Forms.TextBox
    Friend WithEvents UsualL As System.Windows.Forms.Label
    Friend WithEvents ApellidosV As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosL As System.Windows.Forms.Label
    Friend WithEvents NombresV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents TotalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents VerTotalButton As System.Windows.Forms.Button
    Friend WithEvents SelectPresTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DrV As System.Windows.Forms.Label
    Friend WithEvents fechaRecetaL As System.Windows.Forms.Label
    Friend WithEvents PacienteV As System.Windows.Forms.Label
    Friend WithEvents RecetaSelGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Seleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MemberList As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoGeneroL As System.Windows.Forms.Label
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RecetasGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
