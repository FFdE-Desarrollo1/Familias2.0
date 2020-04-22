<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoEmpleado))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombresV = New System.Windows.Forms.TextBox()
        Me.NombreUsual = New System.Windows.Forms.TextBox()
        Me.RelFamL = New System.Windows.Forms.Label()
        Me.UsualL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NacimientoL = New System.Windows.Forms.Label()
        Me.RelFamiliarCombo = New System.Windows.Forms.ComboBox()
        Me.Aas = New System.Windows.Forms.Label()
        Me.GeneroCombo = New System.Windows.Forms.ComboBox()
        Me.ApellidosV = New System.Windows.Forms.TextBox()
        Me.GeneroL = New System.Windows.Forms.Label()
        Me.BirthDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Gas = New System.Windows.Forms.Label()
        Me.Nas = New System.Windows.Forms.Label()
        Me.Naas = New System.Windows.Forms.Label()
        Me.CiudadV = New System.Windows.Forms.TextBox()
        Me.ApellidosL = New System.Windows.Forms.Label()
        Me.CiudadL = New System.Windows.Forms.Label()
        Me.MemberList = New System.Windows.Forms.DataGridView()
        Me.CodigoGeneroL = New System.Windows.Forms.Label()
        Me.InfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ObsL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.MemberList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoTable.SuspendLayout()
        Me.DatosTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(3, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "*"
        '
        'NombreL
        '
        Me.NombreL.AutoSize = True
        Me.NombreL.BackColor = System.Drawing.Color.Transparent
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(22, 40)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(64, 16)
        Me.NombreL.TabIndex = 218
        Me.NombreL.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "*"
        '
        'NombresV
        '
        Me.NombresV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresV.Location = New System.Drawing.Point(145, 43)
        Me.NombresV.MaxLength = 40
        Me.NombresV.Name = "NombresV"
        Me.NombresV.Size = New System.Drawing.Size(270, 22)
        Me.NombresV.TabIndex = 1
        '
        'NombreUsual
        '
        Me.NombreUsual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreUsual.Location = New System.Drawing.Point(145, 3)
        Me.NombreUsual.MaxLength = 30
        Me.NombreUsual.Name = "NombreUsual"
        Me.NombreUsual.Size = New System.Drawing.Size(170, 22)
        Me.NombreUsual.TabIndex = 0
        '
        'RelFamL
        '
        Me.RelFamL.AutoSize = True
        Me.RelFamL.BackColor = System.Drawing.Color.Transparent
        Me.RelFamL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RelFamL.Location = New System.Drawing.Point(22, 200)
        Me.RelFamL.Name = "RelFamL"
        Me.RelFamL.Size = New System.Drawing.Size(112, 16)
        Me.RelFamL.TabIndex = 232
        Me.RelFamL.Text = "Relación Familiar:"
        '
        'UsualL
        '
        Me.UsualL.AutoSize = True
        Me.UsualL.BackColor = System.Drawing.Color.Transparent
        Me.UsualL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsualL.Location = New System.Drawing.Point(22, 0)
        Me.UsualL.Name = "UsualL"
        Me.UsualL.Size = New System.Drawing.Size(94, 16)
        Me.UsualL.TabIndex = 230
        Me.UsualL.Text = "Nombre Usual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "*"
        '
        'NacimientoL
        '
        Me.NacimientoL.AutoSize = True
        Me.NacimientoL.BackColor = System.Drawing.Color.Transparent
        Me.NacimientoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NacimientoL.Location = New System.Drawing.Point(22, 120)
        Me.NacimientoL.Name = "NacimientoL"
        Me.NacimientoL.Size = New System.Drawing.Size(117, 16)
        Me.NacimientoL.TabIndex = 231
        Me.NacimientoL.Text = "Fecha Nacimiento:"
        '
        'RelFamiliarCombo
        '
        Me.RelFamiliarCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RelFamiliarCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RelFamiliarCombo.FormattingEnabled = True
        Me.RelFamiliarCombo.Location = New System.Drawing.Point(145, 203)
        Me.RelFamiliarCombo.Name = "RelFamiliarCombo"
        Me.RelFamiliarCombo.Size = New System.Drawing.Size(270, 24)
        Me.RelFamiliarCombo.TabIndex = 5
        '
        'Aas
        '
        Me.Aas.AutoSize = True
        Me.Aas.BackColor = System.Drawing.Color.Transparent
        Me.Aas.ForeColor = System.Drawing.Color.Red
        Me.Aas.Location = New System.Drawing.Point(3, 40)
        Me.Aas.Name = "Aas"
        Me.Aas.Size = New System.Drawing.Size(13, 16)
        Me.Aas.TabIndex = 221
        Me.Aas.Text = "*"
        '
        'GeneroCombo
        '
        Me.GeneroCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GeneroCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneroCombo.FormattingEnabled = True
        Me.GeneroCombo.Location = New System.Drawing.Point(145, 163)
        Me.GeneroCombo.Name = "GeneroCombo"
        Me.GeneroCombo.Size = New System.Drawing.Size(46, 24)
        Me.GeneroCombo.TabIndex = 4
        '
        'ApellidosV
        '
        Me.ApellidosV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosV.Location = New System.Drawing.Point(145, 83)
        Me.ApellidosV.MaxLength = 40
        Me.ApellidosV.Name = "ApellidosV"
        Me.ApellidosV.Size = New System.Drawing.Size(270, 22)
        Me.ApellidosV.TabIndex = 2
        '
        'GeneroL
        '
        Me.GeneroL.AutoSize = True
        Me.GeneroL.BackColor = System.Drawing.Color.Transparent
        Me.GeneroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneroL.Location = New System.Drawing.Point(22, 160)
        Me.GeneroL.Name = "GeneroL"
        Me.GeneroL.Size = New System.Drawing.Size(54, 16)
        Me.GeneroL.TabIndex = 225
        Me.GeneroL.Text = "Género:"
        '
        'BirthDatePicker
        '
        Me.BirthDatePicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthDatePicker.Location = New System.Drawing.Point(145, 123)
        Me.BirthDatePicker.Name = "BirthDatePicker"
        Me.BirthDatePicker.Size = New System.Drawing.Size(111, 22)
        Me.BirthDatePicker.TabIndex = 3
        '
        'Gas
        '
        Me.Gas.AutoSize = True
        Me.Gas.BackColor = System.Drawing.Color.Transparent
        Me.Gas.ForeColor = System.Drawing.Color.Red
        Me.Gas.Location = New System.Drawing.Point(3, 160)
        Me.Gas.Name = "Gas"
        Me.Gas.Size = New System.Drawing.Size(13, 16)
        Me.Gas.TabIndex = 222
        Me.Gas.Text = "*"
        '
        'Nas
        '
        Me.Nas.AutoSize = True
        Me.Nas.BackColor = System.Drawing.Color.Transparent
        Me.Nas.ForeColor = System.Drawing.Color.Red
        Me.Nas.Location = New System.Drawing.Point(3, 0)
        Me.Nas.Name = "Nas"
        Me.Nas.Size = New System.Drawing.Size(13, 16)
        Me.Nas.TabIndex = 220
        Me.Nas.Text = "*"
        '
        'Naas
        '
        Me.Naas.AutoSize = True
        Me.Naas.BackColor = System.Drawing.Color.Transparent
        Me.Naas.ForeColor = System.Drawing.Color.Red
        Me.Naas.Location = New System.Drawing.Point(3, 120)
        Me.Naas.Name = "Naas"
        Me.Naas.Size = New System.Drawing.Size(13, 16)
        Me.Naas.TabIndex = 223
        Me.Naas.Text = "*"
        '
        'CiudadV
        '
        Me.CiudadV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadV.Location = New System.Drawing.Point(145, 243)
        Me.CiudadV.Name = "CiudadV"
        Me.CiudadV.Size = New System.Drawing.Size(272, 22)
        Me.CiudadV.TabIndex = 235
        '
        'ApellidosL
        '
        Me.ApellidosL.AutoSize = True
        Me.ApellidosL.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosL.Location = New System.Drawing.Point(22, 80)
        Me.ApellidosL.Name = "ApellidosL"
        Me.ApellidosL.Size = New System.Drawing.Size(65, 16)
        Me.ApellidosL.TabIndex = 219
        Me.ApellidosL.Text = "Apellidos:"
        '
        'CiudadL
        '
        Me.CiudadL.AutoSize = True
        Me.CiudadL.BackColor = System.Drawing.Color.Transparent
        Me.CiudadL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadL.Location = New System.Drawing.Point(22, 240)
        Me.CiudadL.Name = "CiudadL"
        Me.CiudadL.Size = New System.Drawing.Size(52, 16)
        Me.CiudadL.TabIndex = 236
        Me.CiudadL.Text = "Ciudad:"
        '
        'MemberList
        '
        Me.MemberList.AllowUserToAddRows = False
        Me.MemberList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.MemberList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MemberList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MemberList.BackgroundColor = System.Drawing.Color.White
        Me.MemberList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemberList.Location = New System.Drawing.Point(536, 3)
        Me.MemberList.Name = "MemberList"
        Me.MemberList.ReadOnly = True
        Me.MemberList.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.MemberList.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MemberList.Size = New System.Drawing.Size(245, 614)
        Me.MemberList.TabIndex = 229
        '
        'CodigoGeneroL
        '
        Me.CodigoGeneroL.AutoSize = True
        Me.CodigoGeneroL.Location = New System.Drawing.Point(429, 0)
        Me.CodigoGeneroL.Name = "CodigoGeneroL"
        Me.CodigoGeneroL.Size = New System.Drawing.Size(15, 16)
        Me.CodigoGeneroL.TabIndex = 229
        Me.CodigoGeneroL.Text = "_"
        Me.CodigoGeneroL.Visible = False
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
        Me.InfoTable.Location = New System.Drawing.Point(0, 139)
        Me.InfoTable.Name = "InfoTable"
        Me.InfoTable.RowCount = 1
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoTable.Size = New System.Drawing.Size(784, 620)
        Me.InfoTable.TabIndex = 244
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.AutoSize = True
        Me.DatosTable.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DatosTable.ColumnCount = 3
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.Controls.Add(Me.Label3, 0, 2)
        Me.DatosTable.Controls.Add(Me.NombreL, 1, 1)
        Me.DatosTable.Controls.Add(Me.Label1, 0, 6)
        Me.DatosTable.Controls.Add(Me.NombresV, 2, 1)
        Me.DatosTable.Controls.Add(Me.NombreUsual, 2, 0)
        Me.DatosTable.Controls.Add(Me.RelFamL, 1, 5)
        Me.DatosTable.Controls.Add(Me.UsualL, 1, 0)
        Me.DatosTable.Controls.Add(Me.Label2, 0, 5)
        Me.DatosTable.Controls.Add(Me.NacimientoL, 1, 3)
        Me.DatosTable.Controls.Add(Me.RelFamiliarCombo, 2, 5)
        Me.DatosTable.Controls.Add(Me.Aas, 0, 1)
        Me.DatosTable.Controls.Add(Me.GeneroCombo, 2, 4)
        Me.DatosTable.Controls.Add(Me.ApellidosV, 2, 2)
        Me.DatosTable.Controls.Add(Me.GeneroL, 1, 4)
        Me.DatosTable.Controls.Add(Me.BirthDatePicker, 2, 3)
        Me.DatosTable.Controls.Add(Me.Gas, 0, 4)
        Me.DatosTable.Controls.Add(Me.Nas, 0, 0)
        Me.DatosTable.Controls.Add(Me.Naas, 0, 3)
        Me.DatosTable.Controls.Add(Me.CiudadV, 2, 6)
        Me.DatosTable.Controls.Add(Me.ApellidosL, 1, 2)
        Me.DatosTable.Controls.Add(Me.CiudadL, 1, 6)
        Me.DatosTable.Location = New System.Drawing.Point(3, 3)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 7
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable.Size = New System.Drawing.Size(420, 614)
        Me.DatosTable.TabIndex = 234
        '
        'ObsL
        '
        Me.ObsL.AutoSize = True
        Me.ObsL.BackColor = System.Drawing.Color.AliceBlue
        Me.ObsL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObsL.ForeColor = System.Drawing.Color.Navy
        Me.ObsL.Location = New System.Drawing.Point(2, 120)
        Me.ObsL.Name = "ObsL"
        Me.ObsL.Size = New System.Drawing.Size(453, 16)
        Me.ObsL.TabIndex = 243
        Me.ObsL.Text = "*Solo para empleados que no pertenezcan a una  familia actualmente afiliada"
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 255
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
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
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
        Me.Title.Text = "Ingresar Nuevo Empleado"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NuevoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.InfoTable)
        Me.Controls.Add(Me.ObsL)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NuevoEmpleado"
        Me.Text = "Nuevo Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MemberList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoTable.ResumeLayout(False)
        Me.InfoTable.PerformLayout()
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NombresV As System.Windows.Forms.TextBox
    Friend WithEvents NombreUsual As System.Windows.Forms.TextBox
    Friend WithEvents RelFamL As System.Windows.Forms.Label
    Friend WithEvents UsualL As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NacimientoL As System.Windows.Forms.Label
    Friend WithEvents RelFamiliarCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Aas As System.Windows.Forms.Label
    Friend WithEvents GeneroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ApellidosV As System.Windows.Forms.TextBox
    Friend WithEvents GeneroL As System.Windows.Forms.Label
    Friend WithEvents BirthDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Gas As System.Windows.Forms.Label
    Friend WithEvents Nas As System.Windows.Forms.Label
    Friend WithEvents Naas As System.Windows.Forms.Label
    Friend WithEvents CiudadV As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosL As System.Windows.Forms.Label
    Friend WithEvents CiudadL As System.Windows.Forms.Label
    Friend WithEvents MemberList As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoGeneroL As System.Windows.Forms.Label
    Friend WithEvents InfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ObsL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
