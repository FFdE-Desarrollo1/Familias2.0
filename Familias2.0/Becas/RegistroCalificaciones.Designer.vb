<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroCalificaciones))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ApadrinadoV = New System.Windows.Forms.TextBox()
        Me.ApadrinadoL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.SitioL = New System.Windows.Forms.Label()
        Me.SitioCombo = New System.Windows.Forms.ComboBox()
        Me.Table2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DatosTable1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalClasesL = New System.Windows.Forms.Label()
        Me.TotalClasesV = New System.Windows.Forms.TextBox()
        Me.UnidadL = New System.Windows.Forms.Label()
        Me.PadresL = New System.Windows.Forms.Label()
        Me.UnidadCombo = New System.Windows.Forms.ComboBox()
        Me.FuenteCombo = New System.Windows.Forms.ComboBox()
        Me.DatosTable2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ganoL = New System.Windows.Forms.Label()
        Me.todasCheck = New System.Windows.Forms.CheckBox()
        Me.promedioL = New System.Windows.Forms.Label()
        Me.PromedioV = New System.Windows.Forms.TextBox()
        Me.datosTable3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PerdidasV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ObservacionesV = New System.Windows.Forms.TextBox()
        Me.nuevaClaseLink = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClaseCombo = New System.Windows.Forms.ComboBox()
        Me.ObservacionesL = New System.Windows.Forms.Label()
        Me.ClaseListadoL = New System.Windows.Forms.LinkLabel()
        Me.ClasesGrid = New System.Windows.Forms.DataGridView()
        Me.Table3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CalificacionesLink = New System.Windows.Forms.LinkLabel()
        Me.HistorialGrid = New System.Windows.Forms.DataGridView()
        Me.ListadoClasesPL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.Table1.SuspendLayout()
        Me.Table2.SuspendLayout()
        Me.DatosTable1.SuspendLayout()
        Me.DatosTable2.SuspendLayout()
        Me.datosTable3.SuspendLayout()
        CType(Me.ClasesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table3.SuspendLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(1178, 118)
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
        Me.opcionesTable.Size = New System.Drawing.Size(1082, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(976, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(925, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(1031, 3)
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
        Me.Title.Size = New System.Drawing.Size(914, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Registro Calificaciones"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table1
        '
        Me.Table1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table1.BackColor = System.Drawing.Color.Transparent
        Me.Table1.ColumnCount = 5
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.Controls.Add(Me.ApadrinadoV, 2, 0)
        Me.Table1.Controls.Add(Me.ApadrinadoL, 1, 0)
        Me.Table1.Controls.Add(Me.NombreL, 4, 0)
        Me.Table1.Controls.Add(Me.FamiliaL, 1, 1)
        Me.Table1.Controls.Add(Me.FamiliaV, 2, 1)
        Me.Table1.Controls.Add(Me.GradoL, 4, 1)
        Me.Table1.Controls.Add(Me.SitioL, 0, 0)
        Me.Table1.Controls.Add(Me.SitioCombo, 0, 1)
        Me.Table1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Table1.Location = New System.Drawing.Point(0, 121)
        Me.Table1.Name = "Table1"
        Me.Table1.RowCount = 2
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table1.Size = New System.Drawing.Size(1173, 76)
        Me.Table1.TabIndex = 256
        '
        'ApadrinadoV
        '
        Me.ApadrinadoV.Location = New System.Drawing.Point(145, 3)
        Me.ApadrinadoV.Name = "ApadrinadoV"
        Me.ApadrinadoV.Size = New System.Drawing.Size(100, 22)
        Me.ApadrinadoV.TabIndex = 0
        '
        'ApadrinadoL
        '
        Me.ApadrinadoL.AutoSize = True
        Me.ApadrinadoL.Location = New System.Drawing.Point(57, 0)
        Me.ApadrinadoL.Name = "ApadrinadoL"
        Me.ApadrinadoL.Size = New System.Drawing.Size(82, 16)
        Me.ApadrinadoL.TabIndex = 1
        Me.ApadrinadoL.Text = "Apadrinado:"
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(281, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(889, 28)
        Me.NombreL.TabIndex = 2
        Me.NombreL.Text = "Nombre"
        Me.NombreL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NombreL.Visible = False
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Location = New System.Drawing.Point(57, 28)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(55, 16)
        Me.FamiliaL.TabIndex = 4
        Me.FamiliaL.Text = "Familia:"
        '
        'FamiliaV
        '
        Me.FamiliaV.Location = New System.Drawing.Point(145, 31)
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(100, 22)
        Me.FamiliaV.TabIndex = 5
        '
        'GradoL
        '
        Me.GradoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoL.AutoSize = True
        Me.GradoL.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoL.Location = New System.Drawing.Point(281, 28)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(889, 48)
        Me.GradoL.TabIndex = 3
        Me.GradoL.Text = "Grado"
        Me.GradoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GradoL.Visible = False
        '
        'SitioL
        '
        Me.SitioL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SitioL.AutoSize = True
        Me.SitioL.BackColor = System.Drawing.Color.LightBlue
        Me.SitioL.Location = New System.Drawing.Point(3, 0)
        Me.SitioL.Name = "SitioL"
        Me.SitioL.Size = New System.Drawing.Size(48, 28)
        Me.SitioL.TabIndex = 261
        Me.SitioL.Text = "Sitio"
        Me.SitioL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SitioCombo
        '
        Me.SitioCombo.BackColor = System.Drawing.Color.LightBlue
        Me.SitioCombo.Enabled = False
        Me.SitioCombo.FormattingEnabled = True
        Me.SitioCombo.Location = New System.Drawing.Point(3, 31)
        Me.SitioCombo.Name = "SitioCombo"
        Me.SitioCombo.Size = New System.Drawing.Size(48, 24)
        Me.SitioCombo.TabIndex = 262
        '
        'Table2
        '
        Me.Table2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table2.BackColor = System.Drawing.Color.Transparent
        Me.Table2.ColumnCount = 5
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.Controls.Add(Me.DatosTable1, 0, 0)
        Me.Table2.Controls.Add(Me.DatosTable2, 1, 0)
        Me.Table2.Controls.Add(Me.datosTable3, 2, 0)
        Me.Table2.Controls.Add(Me.ClaseListadoL, 4, 0)
        Me.Table2.Location = New System.Drawing.Point(0, 204)
        Me.Table2.Name = "Table2"
        Me.Table2.RowCount = 1
        Me.Table2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table2.Size = New System.Drawing.Size(1176, 92)
        Me.Table2.TabIndex = 260
        Me.Table2.Visible = False
        '
        'DatosTable1
        '
        Me.DatosTable1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DatosTable1.BackColor = System.Drawing.Color.AliceBlue
        Me.DatosTable1.ColumnCount = 3
        Me.DatosTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable1.Controls.Add(Me.TotalClasesL, 2, 0)
        Me.DatosTable1.Controls.Add(Me.TotalClasesV, 2, 1)
        Me.DatosTable1.Controls.Add(Me.UnidadL, 0, 0)
        Me.DatosTable1.Controls.Add(Me.PadresL, 1, 0)
        Me.DatosTable1.Controls.Add(Me.UnidadCombo, 0, 1)
        Me.DatosTable1.Controls.Add(Me.FuenteCombo, 1, 1)
        Me.DatosTable1.Location = New System.Drawing.Point(3, 3)
        Me.DatosTable1.Name = "DatosTable1"
        Me.DatosTable1.RowCount = 2
        Me.DatosTable1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.DatosTable1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable1.Size = New System.Drawing.Size(264, 86)
        Me.DatosTable1.TabIndex = 261
        '
        'TotalClasesL
        '
        Me.TotalClasesL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalClasesL.AutoSize = True
        Me.TotalClasesL.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalClasesL.Location = New System.Drawing.Point(219, 0)
        Me.TotalClasesL.Name = "TotalClasesL"
        Me.TotalClasesL.Size = New System.Drawing.Size(42, 50)
        Me.TotalClasesL.TabIndex = 259
        Me.TotalClasesL.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clases"
        Me.TotalClasesL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalClasesV
        '
        Me.TotalClasesV.Location = New System.Drawing.Point(219, 53)
        Me.TotalClasesV.Name = "TotalClasesV"
        Me.TotalClasesV.Size = New System.Drawing.Size(40, 23)
        Me.TotalClasesV.TabIndex = 266
        Me.TotalClasesV.Text = "0"
        Me.TotalClasesV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UnidadL
        '
        Me.UnidadL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnidadL.AutoSize = True
        Me.UnidadL.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnidadL.Location = New System.Drawing.Point(3, 0)
        Me.UnidadL.Name = "UnidadL"
        Me.UnidadL.Size = New System.Drawing.Size(68, 50)
        Me.UnidadL.TabIndex = 0
        Me.UnidadL.Text = "Unidad"
        Me.UnidadL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PadresL
        '
        Me.PadresL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PadresL.AutoSize = True
        Me.PadresL.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PadresL.Location = New System.Drawing.Point(77, 0)
        Me.PadresL.Name = "PadresL"
        Me.PadresL.Size = New System.Drawing.Size(136, 50)
        Me.PadresL.TabIndex = 258
        Me.PadresL.Text = "Fuente"
        Me.PadresL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnidadCombo
        '
        Me.UnidadCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnidadCombo.FormattingEnabled = True
        Me.UnidadCombo.Location = New System.Drawing.Point(3, 53)
        Me.UnidadCombo.Name = "UnidadCombo"
        Me.UnidadCombo.Size = New System.Drawing.Size(68, 24)
        Me.UnidadCombo.TabIndex = 0
        '
        'FuenteCombo
        '
        Me.FuenteCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FuenteCombo.FormattingEnabled = True
        Me.FuenteCombo.Location = New System.Drawing.Point(77, 53)
        Me.FuenteCombo.Name = "FuenteCombo"
        Me.FuenteCombo.Size = New System.Drawing.Size(136, 24)
        Me.FuenteCombo.TabIndex = 1
        '
        'DatosTable2
        '
        Me.DatosTable2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DatosTable2.BackColor = System.Drawing.Color.SkyBlue
        Me.DatosTable2.ColumnCount = 2
        Me.DatosTable2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable2.Controls.Add(Me.ganoL, 0, 0)
        Me.DatosTable2.Controls.Add(Me.todasCheck, 0, 1)
        Me.DatosTable2.Controls.Add(Me.promedioL, 1, 0)
        Me.DatosTable2.Controls.Add(Me.PromedioV, 1, 1)
        Me.DatosTable2.Location = New System.Drawing.Point(273, 3)
        Me.DatosTable2.Name = "DatosTable2"
        Me.DatosTable2.RowCount = 2
        Me.DatosTable2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.DatosTable2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable2.Size = New System.Drawing.Size(138, 86)
        Me.DatosTable2.TabIndex = 257
        '
        'ganoL
        '
        Me.ganoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ganoL.AutoSize = True
        Me.ganoL.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ganoL.Location = New System.Drawing.Point(3, 0)
        Me.ganoL.Name = "ganoL"
        Me.ganoL.Size = New System.Drawing.Size(35, 50)
        Me.ganoL.TabIndex = 258
        Me.ganoL.Text = "Ganó" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "todas"
        Me.ganoL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'todasCheck
        '
        Me.todasCheck.AutoSize = True
        Me.todasCheck.Location = New System.Drawing.Point(3, 53)
        Me.todasCheck.Name = "todasCheck"
        Me.todasCheck.Size = New System.Drawing.Size(31, 20)
        Me.todasCheck.TabIndex = 2
        Me.todasCheck.Text = " "
        Me.todasCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.todasCheck.UseVisualStyleBackColor = True
        '
        'promedioL
        '
        Me.promedioL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.promedioL.AutoSize = True
        Me.promedioL.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.promedioL.Location = New System.Drawing.Point(44, 0)
        Me.promedioL.Name = "promedioL"
        Me.promedioL.Size = New System.Drawing.Size(56, 50)
        Me.promedioL.TabIndex = 258
        Me.promedioL.Text = "Promedio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(>80%)"
        Me.promedioL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PromedioV
        '
        Me.PromedioV.Location = New System.Drawing.Point(44, 53)
        Me.PromedioV.Name = "PromedioV"
        Me.PromedioV.Size = New System.Drawing.Size(66, 23)
        Me.PromedioV.TabIndex = 3
        Me.PromedioV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datosTable3
        '
        Me.datosTable3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datosTable3.BackColor = System.Drawing.Color.LightGray
        Me.datosTable3.ColumnCount = 4
        Me.datosTable3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.datosTable3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.datosTable3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304.0!))
        Me.datosTable3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.datosTable3.Controls.Add(Me.PerdidasV, 0, 1)
        Me.datosTable3.Controls.Add(Me.Label4, 2, 0)
        Me.datosTable3.Controls.Add(Me.ObservacionesV, 1, 1)
        Me.datosTable3.Controls.Add(Me.nuevaClaseLink, 3, 0)
        Me.datosTable3.Controls.Add(Me.Label1, 0, 0)
        Me.datosTable3.Controls.Add(Me.ClaseCombo, 2, 1)
        Me.datosTable3.Controls.Add(Me.ObservacionesL, 1, 0)
        Me.datosTable3.Location = New System.Drawing.Point(417, 3)
        Me.datosTable3.Name = "datosTable3"
        Me.datosTable3.RowCount = 2
        Me.datosTable3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.datosTable3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.datosTable3.Size = New System.Drawing.Size(640, 86)
        Me.datosTable3.TabIndex = 259
        '
        'PerdidasV
        '
        Me.PerdidasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PerdidasV.Location = New System.Drawing.Point(3, 53)
        Me.PerdidasV.Name = "PerdidasV"
        Me.PerdidasV.Size = New System.Drawing.Size(75, 23)
        Me.PerdidasV.TabIndex = 4
        Me.PerdidasV.Text = "0"
        Me.PerdidasV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 50)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "Clase"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ObservacionesV
        '
        Me.ObservacionesV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesV.Location = New System.Drawing.Point(84, 53)
        Me.ObservacionesV.MaxLength = 100
        Me.ObservacionesV.Name = "ObservacionesV"
        Me.ObservacionesV.Size = New System.Drawing.Size(154, 23)
        Me.ObservacionesV.TabIndex = 267
        '
        'nuevaClaseLink
        '
        Me.nuevaClaseLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nuevaClaseLink.AutoSize = True
        Me.nuevaClaseLink.BackColor = System.Drawing.Color.DarkGray
        Me.nuevaClaseLink.Location = New System.Drawing.Point(548, 0)
        Me.nuevaClaseLink.Name = "nuevaClaseLink"
        Me.datosTable3.SetRowSpan(Me.nuevaClaseLink, 2)
        Me.nuevaClaseLink.Size = New System.Drawing.Size(61, 86)
        Me.nuevaClaseLink.TabIndex = 260
        Me.nuevaClaseLink.TabStop = True
        Me.nuevaClaseLink.Text = "Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pérdida"
        Me.nuevaClaseLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nuevaClaseLink.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 50)
        Me.Label1.TabIndex = 258
        Me.Label1.Text = "Cantidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pérdidas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ClaseCombo
        '
        Me.ClaseCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClaseCombo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaseCombo.FormattingEnabled = True
        Me.ClaseCombo.Location = New System.Drawing.Point(244, 53)
        Me.ClaseCombo.Name = "ClaseCombo"
        Me.ClaseCombo.Size = New System.Drawing.Size(298, 24)
        Me.ClaseCombo.TabIndex = 5
        '
        'ObservacionesL
        '
        Me.ObservacionesL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesL.AutoSize = True
        Me.ObservacionesL.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionesL.Location = New System.Drawing.Point(84, 0)
        Me.ObservacionesL.Name = "ObservacionesL"
        Me.ObservacionesL.Size = New System.Drawing.Size(154, 50)
        Me.ObservacionesL.TabIndex = 266
        Me.ObservacionesL.Text = "Observaciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(de la unidad)"
        Me.ObservacionesL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClaseListadoL
        '
        Me.ClaseListadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClaseListadoL.AutoSize = True
        Me.ClaseListadoL.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClaseListadoL.Location = New System.Drawing.Point(1063, 0)
        Me.ClaseListadoL.Name = "ClaseListadoL"
        Me.ClaseListadoL.Size = New System.Drawing.Size(99, 92)
        Me.ClaseListadoL.TabIndex = 262
        Me.ClaseListadoL.TabStop = True
        Me.ClaseListadoL.Text = "Agregar Clase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al Listado"
        Me.ClaseListadoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClaseListadoL.Visible = False
        '
        'ClasesGrid
        '
        Me.ClasesGrid.AllowUserToAddRows = False
        Me.ClasesGrid.AllowUserToDeleteRows = False
        Me.ClasesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasesGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.ClasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClasesGrid.Location = New System.Drawing.Point(833, 33)
        Me.ClasesGrid.Name = "ClasesGrid"
        Me.ClasesGrid.ReadOnly = True
        Me.ClasesGrid.RowHeadersVisible = False
        Me.ClasesGrid.RowTemplate.Height = 28
        Me.ClasesGrid.Size = New System.Drawing.Size(342, 372)
        Me.ClasesGrid.TabIndex = 258
        Me.ClasesGrid.Visible = False
        '
        'Table3
        '
        Me.Table3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table3.BackColor = System.Drawing.Color.Transparent
        Me.Table3.ColumnCount = 3
        Me.Table3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.Table3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.Table3.Controls.Add(Me.ClasesGrid, 2, 1)
        Me.Table3.Controls.Add(Me.CalificacionesLink, 0, 0)
        Me.Table3.Controls.Add(Me.HistorialGrid, 0, 1)
        Me.Table3.Controls.Add(Me.ListadoClasesPL, 2, 0)
        Me.Table3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Table3.Location = New System.Drawing.Point(0, 304)
        Me.Table3.Name = "Table3"
        Me.Table3.RowCount = 2
        Me.Table3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Table3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table3.Size = New System.Drawing.Size(1178, 408)
        Me.Table3.TabIndex = 261
        Me.Table3.Visible = False
        '
        'CalificacionesLink
        '
        Me.CalificacionesLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CalificacionesLink.AutoSize = True
        Me.CalificacionesLink.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalificacionesLink.Location = New System.Drawing.Point(3, 0)
        Me.CalificacionesLink.Name = "CalificacionesLink"
        Me.CalificacionesLink.Size = New System.Drawing.Size(95, 30)
        Me.CalificacionesLink.TabIndex = 265
        Me.CalificacionesLink.TabStop = True
        Me.CalificacionesLink.Text = "Calificaciones"
        Me.CalificacionesLink.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'HistorialGrid
        '
        Me.HistorialGrid.AllowUserToAddRows = False
        Me.HistorialGrid.AllowUserToDeleteRows = False
        Me.HistorialGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistorialGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.HistorialGrid.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.HistorialGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.HistorialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialGrid.Location = New System.Drawing.Point(3, 33)
        Me.HistorialGrid.Name = "HistorialGrid"
        Me.HistorialGrid.ReadOnly = True
        Me.HistorialGrid.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.HistorialGrid.RowTemplate.Height = 28
        Me.HistorialGrid.Size = New System.Drawing.Size(804, 372)
        Me.HistorialGrid.TabIndex = 262
        '
        'ListadoClasesPL
        '
        Me.ListadoClasesPL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListadoClasesPL.AutoSize = True
        Me.ListadoClasesPL.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoClasesPL.ForeColor = System.Drawing.Color.DarkGreen
        Me.ListadoClasesPL.Location = New System.Drawing.Point(833, 0)
        Me.ListadoClasesPL.Name = "ListadoClasesPL"
        Me.ListadoClasesPL.Size = New System.Drawing.Size(161, 30)
        Me.ListadoClasesPL.TabIndex = 266
        Me.ListadoClasesPL.Text = "Listado Clases Pérdidas"
        Me.ListadoClasesPL.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ListadoClasesPL.Visible = False
        '
        'RegistroCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(1178, 744)
        Me.Controls.Add(Me.Table3)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RegistroCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Calificaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.Table1.ResumeLayout(False)
        Me.Table1.PerformLayout()
        Me.Table2.ResumeLayout(False)
        Me.Table2.PerformLayout()
        Me.DatosTable1.ResumeLayout(False)
        Me.DatosTable1.PerformLayout()
        Me.DatosTable2.ResumeLayout(False)
        Me.DatosTable2.PerformLayout()
        Me.datosTable3.ResumeLayout(False)
        Me.datosTable3.PerformLayout()
        CType(Me.ClasesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table3.ResumeLayout(False)
        Me.Table3.PerformLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ApadrinadoV As System.Windows.Forms.TextBox
    Friend WithEvents ApadrinadoL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents DatosTable2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UnidadL As System.Windows.Forms.Label
    Friend WithEvents FuenteCombo As System.Windows.Forms.ComboBox
    Friend WithEvents PadresL As System.Windows.Forms.Label
    Friend WithEvents ganoL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UnidadCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClaseCombo As System.Windows.Forms.ComboBox
    Friend WithEvents todasCheck As System.Windows.Forms.CheckBox
    Friend WithEvents PerdidasV As System.Windows.Forms.TextBox
    Friend WithEvents ClasesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents nuevaClaseLink As System.Windows.Forms.LinkLabel
    Friend WithEvents datosTable3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents promedioL As System.Windows.Forms.Label
    Friend WithEvents PromedioV As System.Windows.Forms.TextBox
    Friend WithEvents Table2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DatosTable1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Table3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HistorialGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CalificacionesLink As System.Windows.Forms.LinkLabel
    Friend WithEvents TotalClasesL As System.Windows.Forms.Label
    Friend WithEvents TotalClasesV As System.Windows.Forms.TextBox
    Friend WithEvents ObservacionesL As System.Windows.Forms.Label
    Friend WithEvents ObservacionesV As System.Windows.Forms.TextBox
    Friend WithEvents ClaseListadoL As System.Windows.Forms.LinkLabel
    Friend WithEvents SitioL As System.Windows.Forms.Label
    Friend WithEvents SitioCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ListadoClasesPL As System.Windows.Forms.Label
End Class
