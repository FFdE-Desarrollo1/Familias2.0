<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialMedicamentosClin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistorialMedicamentosClin))
        Me.NombreV = New System.Windows.Forms.Label()
        Me.GenInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.PacienteV = New System.Windows.Forms.TextBox()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Modificar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.MedsGrid = New System.Windows.Forms.DataGridView()
        Me.InstrL = New System.Windows.Forms.Label()
        Me.NombreUsual = New System.Windows.Forms.TextBox()
        Me.UsualL = New System.Windows.Forms.Label()
        Me.ApellidosV = New System.Windows.Forms.TextBox()
        Me.GenPanel = New System.Windows.Forms.Panel()
        Me.ApellidosL = New System.Windows.Forms.Label()
        Me.NombresV = New System.Windows.Forms.TextBox()
        Me.MemberList = New System.Windows.Forms.DataGridView()
        Me.CodigoGeneroL = New System.Windows.Forms.Label()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.GenInfoTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenPanel.SuspendLayout()
        CType(Me.MemberList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatosTable.SuspendLayout()
        Me.InfoTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.Location = New System.Drawing.Point(66, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(15, 16)
        Me.NombreV.TabIndex = 207
        Me.NombreV.Text = "_"
        Me.NombreV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenInfoTable
        '
        Me.GenInfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenInfoTable.BackColor = System.Drawing.Color.AliceBlue
        Me.GenInfoTable.ColumnCount = 3
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GenInfoTable.Controls.Add(Me.NombreL, 0, 0)
        Me.GenInfoTable.Controls.Add(Me.NombreV, 1, 0)
        Me.GenInfoTable.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenInfoTable.Location = New System.Drawing.Point(0, 26)
        Me.GenInfoTable.Name = "GenInfoTable"
        Me.GenInfoTable.RowCount = 1
        Me.GenInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.GenInfoTable.Size = New System.Drawing.Size(776, 25)
        Me.GenInfoTable.TabIndex = 222
        Me.GenInfoTable.Visible = False
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(57, 16)
        Me.NombreL.TabIndex = 0
        Me.NombreL.Text = "Nombre:"
        Me.NombreL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(109, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(530, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(123, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Paciente:"
        Me.PacienteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PacienteV
        '
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PacienteV.Location = New System.Drawing.Point(659, 3)
        Me.PacienteV.MaxLength = 10
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(112, 29)
        Me.PacienteV.TabIndex = 204
        Me.PacienteV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(118, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 29)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, -10)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(776, 36)
        Me.PrincipalPanel.TabIndex = 221
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Acción"
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Modificar.Visible = False
        Me.Modificar.Width = 65
        '
        'MedsGrid
        '
        Me.MedsGrid.AllowUserToAddRows = False
        Me.MedsGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MedsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MedsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MedsGrid.BackgroundColor = System.Drawing.Color.White
        Me.MedsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MedsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modificar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedsGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.MedsGrid.GridColor = System.Drawing.Color.White
        Me.MedsGrid.Location = New System.Drawing.Point(0, 57)
        Me.MedsGrid.Name = "MedsGrid"
        Me.MedsGrid.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedsGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MedsGrid.Size = New System.Drawing.Size(782, 530)
        Me.MedsGrid.TabIndex = 224
        Me.MedsGrid.Visible = False
        '
        'InstrL
        '
        Me.InstrL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstrL.AutoSize = True
        Me.InstrL.BackColor = System.Drawing.Color.Transparent
        Me.InstrL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstrL.Location = New System.Drawing.Point(86, 0)
        Me.InstrL.Name = "InstrL"
        Me.InstrL.Size = New System.Drawing.Size(317, 40)
        Me.InstrL.TabIndex = 231
        Me.InstrL.Text = "Datos para buscar al empleado:"
        Me.InstrL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreUsual
        '
        Me.NombreUsual.Location = New System.Drawing.Point(86, 43)
        Me.NombreUsual.MaxLength = 30
        Me.NombreUsual.Name = "NombreUsual"
        Me.NombreUsual.Size = New System.Drawing.Size(170, 22)
        Me.NombreUsual.TabIndex = 1
        '
        'UsualL
        '
        Me.UsualL.AutoSize = True
        Me.UsualL.BackColor = System.Drawing.Color.Transparent
        Me.UsualL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsualL.Location = New System.Drawing.Point(3, 40)
        Me.UsualL.Name = "UsualL"
        Me.UsualL.Size = New System.Drawing.Size(77, 13)
        Me.UsualL.TabIndex = 230
        Me.UsualL.Text = "Nombre Usual:"
        '
        'ApellidosV
        '
        Me.ApellidosV.Location = New System.Drawing.Point(86, 123)
        Me.ApellidosV.MaxLength = 40
        Me.ApellidosV.Name = "ApellidosV"
        Me.ApellidosV.Size = New System.Drawing.Size(270, 22)
        Me.ApellidosV.TabIndex = 3
        '
        'GenPanel
        '
        Me.GenPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenPanel.BackColor = System.Drawing.Color.Transparent
        Me.GenPanel.Controls.Add(Me.MedsGrid)
        Me.GenPanel.Controls.Add(Me.PrincipalPanel)
        Me.GenPanel.Controls.Add(Me.GenInfoTable)
        Me.GenPanel.Location = New System.Drawing.Point(0, 160)
        Me.GenPanel.Name = "GenPanel"
        Me.GenPanel.Size = New System.Drawing.Size(784, 590)
        Me.GenPanel.TabIndex = 245
        Me.GenPanel.Visible = False
        '
        'ApellidosL
        '
        Me.ApellidosL.AutoSize = True
        Me.ApellidosL.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosL.Location = New System.Drawing.Point(3, 120)
        Me.ApellidosL.Name = "ApellidosL"
        Me.ApellidosL.Size = New System.Drawing.Size(52, 13)
        Me.ApellidosL.TabIndex = 219
        Me.ApellidosL.Text = "Apellidos:"
        '
        'NombresV
        '
        Me.NombresV.Location = New System.Drawing.Point(86, 83)
        Me.NombresV.MaxLength = 40
        Me.NombresV.Name = "NombresV"
        Me.NombresV.Size = New System.Drawing.Size(317, 22)
        Me.NombresV.TabIndex = 2
        '
        'MemberList
        '
        Me.MemberList.AllowUserToAddRows = False
        Me.MemberList.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        Me.MemberList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MemberList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MemberList.BackgroundColor = System.Drawing.Color.White
        Me.MemberList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemberList.Location = New System.Drawing.Point(526, 3)
        Me.MemberList.Name = "MemberList"
        Me.MemberList.ReadOnly = True
        Me.MemberList.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.MemberList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MemberList.Size = New System.Drawing.Size(255, 30)
        Me.MemberList.TabIndex = 229
        '
        'CodigoGeneroL
        '
        Me.CodigoGeneroL.AutoSize = True
        Me.CodigoGeneroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoGeneroL.Location = New System.Drawing.Point(415, 0)
        Me.CodigoGeneroL.Name = "CodigoGeneroL"
        Me.CodigoGeneroL.Size = New System.Drawing.Size(15, 16)
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
        Me.DatosTable.Controls.Add(Me.Label1, 0, 2)
        Me.DatosTable.Location = New System.Drawing.Point(3, 3)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 4
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.Size = New System.Drawing.Size(406, 30)
        Me.DatosTable.TabIndex = 234
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 218
        Me.Label1.Text = "Nombres:"
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
        Me.InfoTable.Location = New System.Drawing.Point(0, 120)
        Me.InfoTable.Name = "InfoTable"
        Me.InfoTable.RowCount = 1
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoTable.Size = New System.Drawing.Size(784, 36)
        Me.InfoTable.TabIndex = 244
        Me.InfoTable.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 254
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 3
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(636, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(585, 3)
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
        Me.Title.Size = New System.Drawing.Size(574, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Historial de Medicamentos"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistorialMedicamentosClin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.GenPanel)
        Me.Controls.Add(Me.InfoTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HistorialMedicamentosClin"
        Me.Text = "Historial Medicamentos Clínica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GenInfoTable.ResumeLayout(False)
        Me.GenInfoTable.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenPanel.ResumeLayout(False)
        CType(Me.MemberList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.InfoTable.ResumeLayout(False)
        Me.InfoTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents GenInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents PacienteV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents MedsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents InstrL As System.Windows.Forms.Label
    Friend WithEvents NombreUsual As System.Windows.Forms.TextBox
    Friend WithEvents UsualL As System.Windows.Forms.Label
    Friend WithEvents ApellidosV As System.Windows.Forms.TextBox
    Friend WithEvents GenPanel As System.Windows.Forms.Panel
    Friend WithEvents ApellidosL As System.Windows.Forms.Label
    Friend WithEvents NombresV As System.Windows.Forms.TextBox
    Friend WithEvents MemberList As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoGeneroL As System.Windows.Forms.Label
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
