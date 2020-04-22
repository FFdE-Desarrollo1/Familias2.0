<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValeLibros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValeLibros))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.LimpiarButton = New System.Windows.Forms.Button()
        Me.HistorialActividadesCheck = New System.Windows.Forms.CheckBox()
        Me.HistorialReembolsosCheck = New System.Windows.Forms.CheckBox()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.AñoV = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GradoV = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.TSL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.TSV = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EscuelaV = New System.Windows.Forms.Label()
        Me.EdadV = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.LibrosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TipoTransV = New System.Windows.Forms.Label()
        Me.LibroCombo = New System.Windows.Forms.ComboBox()
        Me.VigenciaPicker = New System.Windows.Forms.DateTimePicker()
        Me.VigenciaL = New System.Windows.Forms.Label()
        Me.ImpresionPicker = New System.Windows.Forms.DateTimePicker()
        Me.RegistroPicker = New System.Windows.Forms.DateTimePicker()
        Me.ImpresionL = New System.Windows.Forms.Label()
        Me.RegistroL = New System.Windows.Forms.Label()
        Me.ProveedorCombo = New System.Windows.Forms.ComboBox()
        Me.PrecioL = New System.Windows.Forms.Label()
        Me.PrecioV = New System.Windows.Forms.TextBox()
        Me.ProveedorL = New System.Windows.Forms.Label()
        Me.LibroL = New System.Windows.Forms.Label()
        Me.VerificaLibroL = New System.Windows.Forms.Label()
        Me.HistorialGrid = New System.Windows.Forms.DataGridView()
        Me.EtiquetaL = New System.Windows.Forms.Label()
        Me.ValesActualesCheckBox = New System.Windows.Forms.CheckBox()
        Me.HistorialValeLibrosCheck = New System.Windows.Forms.CheckBox()
        Me.PrintDocumentVale = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogVale = New System.Windows.Forms.PrintPreviewDialog()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.PanelSecundario.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.LibrosTable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.bannerPanel.Size = New System.Drawing.Size(984, 118)
        Me.bannerPanel.TabIndex = 257
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
        Me.Title.Size = New System.Drawing.Size(720, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Vales para Libros"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LimpiarButton
        '
        Me.LimpiarButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LimpiarButton.Location = New System.Drawing.Point(897, 3)
        Me.LimpiarButton.Name = "LimpiarButton"
        Me.TableLayoutPanel1.SetRowSpan(Me.LimpiarButton, 3)
        Me.LimpiarButton.Size = New System.Drawing.Size(64, 93)
        Me.LimpiarButton.TabIndex = 5
        Me.LimpiarButton.Text = "Limpiar campos"
        Me.LimpiarButton.UseVisualStyleBackColor = True
        '
        'HistorialActividadesCheck
        '
        Me.HistorialActividadesCheck.AutoSize = True
        Me.HistorialActividadesCheck.BackColor = System.Drawing.Color.PaleTurquoise
        Me.HistorialActividadesCheck.Location = New System.Drawing.Point(495, 156)
        Me.HistorialActividadesCheck.Name = "HistorialActividadesCheck"
        Me.HistorialActividadesCheck.Size = New System.Drawing.Size(93, 20)
        Me.HistorialActividadesCheck.TabIndex = 69
        Me.HistorialActividadesCheck.Text = "Actividades"
        Me.HistorialActividadesCheck.UseVisualStyleBackColor = False
        '
        'HistorialReembolsosCheck
        '
        Me.HistorialReembolsosCheck.AutoSize = True
        Me.HistorialReembolsosCheck.BackColor = System.Drawing.Color.PaleTurquoise
        Me.HistorialReembolsosCheck.Location = New System.Drawing.Point(741, 156)
        Me.HistorialReembolsosCheck.Name = "HistorialReembolsosCheck"
        Me.HistorialReembolsosCheck.Size = New System.Drawing.Size(99, 20)
        Me.HistorialReembolsosCheck.TabIndex = 69
        Me.HistorialReembolsosCheck.Text = "Reembolsos"
        Me.HistorialReembolsosCheck.UseVisualStyleBackColor = False
        '
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 9
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.Controls.Add(Me.AñoV, 8, 1)
        Me.PanelSecundario.Controls.Add(Me.AñoL, 7, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoV, 1, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoL, 0, 1)
        Me.PanelSecundario.Controls.Add(Me.TSL, 7, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.TSV, 8, 0)
        Me.PanelSecundario.Controls.Add(Me.Label2, 3, 1)
        Me.PanelSecundario.Controls.Add(Me.EscuelaV, 4, 1)
        Me.PanelSecundario.Controls.Add(Me.EdadV, 3, 0)
        Me.PanelSecundario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 154)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 2
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.Size = New System.Drawing.Size(984, 40)
        Me.PanelSecundario.TabIndex = 256
        Me.PanelSecundario.Visible = False
        '
        'AñoV
        '
        Me.AñoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoV.AutoSize = True
        Me.AñoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AñoV.Location = New System.Drawing.Point(966, 16)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(15, 16)
        Me.AñoV.TabIndex = 202
        Me.AñoV.Text = "_"
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoL.Location = New System.Drawing.Point(925, 16)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(35, 24)
        Me.AñoL.TabIndex = 202
        Me.AñoL.Text = "Año:"
        '
        'GradoV
        '
        Me.GradoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoV.AutoSize = True
        Me.GradoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GradoV.Location = New System.Drawing.Point(66, 16)
        Me.GradoV.Name = "GradoV"
        Me.GradoV.Size = New System.Drawing.Size(15, 16)
        Me.GradoV.TabIndex = 202
        Me.GradoV.Text = "_"
        '
        'GradoL
        '
        Me.GradoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoL.AutoSize = True
        Me.GradoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoL.Location = New System.Drawing.Point(3, 16)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(57, 24)
        Me.GradoL.TabIndex = 69
        Me.GradoL.Text = "Grado:"
        '
        'TSL
        '
        Me.TSL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSL.AutoSize = True
        Me.TSL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSL.Location = New System.Drawing.Point(925, 0)
        Me.TSL.Name = "TSL"
        Me.TSL.Size = New System.Drawing.Size(35, 16)
        Me.TSL.TabIndex = 201
        Me.TSL.Text = "TS:"
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(57, 16)
        Me.NombreL.TabIndex = 1
        Me.NombreL.Text = "Nombre:"
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NombreV.Location = New System.Drawing.Point(66, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(15, 16)
        Me.NombreV.TabIndex = 2
        Me.NombreV.Text = "_"
        '
        'TSV
        '
        Me.TSV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSV.AutoSize = True
        Me.TSV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TSV.Location = New System.Drawing.Point(966, 0)
        Me.TSV.Name = "TSV"
        Me.TSV.Size = New System.Drawing.Size(15, 16)
        Me.TSV.TabIndex = 201
        Me.TSV.Text = "_"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Escuela:"
        '
        'EscuelaV
        '
        Me.EscuelaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EscuelaV.AutoSize = True
        Me.EscuelaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EscuelaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EscuelaV.Location = New System.Drawing.Point(172, 16)
        Me.EscuelaV.Name = "EscuelaV"
        Me.EscuelaV.Size = New System.Drawing.Size(15, 16)
        Me.EscuelaV.TabIndex = 202
        Me.EscuelaV.Text = "_"
        '
        'EdadV
        '
        Me.EdadV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdadV.AutoSize = True
        Me.EdadV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EdadV.Location = New System.Drawing.Point(107, 0)
        Me.EdadV.Name = "EdadV"
        Me.EdadV.Size = New System.Drawing.Size(59, 16)
        Me.EdadV.TabIndex = 198
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
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 119)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(984, 36)
        Me.PrincipalPanel.TabIndex = 255
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(101, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 29)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(867, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(112, 29)
        Me.MiembroV.TabIndex = 0
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(759, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(102, 36)
        Me.MiembroL.TabIndex = 204
        Me.MiembroL.Text = "No. Miembro:"
        Me.MiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(92, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LibrosTable
        '
        Me.LibrosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibrosTable.BackColor = System.Drawing.Color.Transparent
        Me.LibrosTable.ColumnCount = 4
        Me.LibrosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LibrosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LibrosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LibrosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LibrosTable.Controls.Add(Me.Panel1, 0, 1)
        Me.LibrosTable.Controls.Add(Me.HistorialGrid, 0, 4)
        Me.LibrosTable.Controls.Add(Me.EtiquetaL, 0, 0)
        Me.LibrosTable.Controls.Add(Me.HistorialReembolsosCheck, 3, 3)
        Me.LibrosTable.Controls.Add(Me.HistorialActividadesCheck, 2, 3)
        Me.LibrosTable.Controls.Add(Me.ValesActualesCheckBox, 0, 3)
        Me.LibrosTable.Controls.Add(Me.HistorialValeLibrosCheck, 1, 3)
        Me.LibrosTable.Location = New System.Drawing.Point(0, 200)
        Me.LibrosTable.Name = "LibrosTable"
        Me.LibrosTable.RowCount = 5
        Me.LibrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LibrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.LibrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LibrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LibrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LibrosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LibrosTable.Size = New System.Drawing.Size(984, 458)
        Me.LibrosTable.TabIndex = 258
        Me.LibrosTable.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LibrosTable.SetColumnSpan(Me.Panel1, 4)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(3, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 109)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TipoTransV, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LibroCombo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LimpiarButton, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.VigenciaPicker, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.VigenciaL, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ImpresionPicker, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RegistroPicker, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ImpresionL, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RegistroL, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProveedorCombo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PrecioL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PrecioV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ProveedorL, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LibroL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.VerificaLibroL, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(964, 99)
        Me.TableLayoutPanel1.TabIndex = 74
        '
        'TipoTransV
        '
        Me.TipoTransV.AutoSize = True
        Me.TipoTransV.Location = New System.Drawing.Point(523, 0)
        Me.TipoTransV.Name = "TipoTransV"
        Me.TipoTransV.Size = New System.Drawing.Size(15, 16)
        Me.TipoTransV.TabIndex = 70
        Me.TipoTransV.Text = "0"
        Me.TipoTransV.Visible = False
        '
        'LibroCombo
        '
        Me.LibroCombo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.LibroCombo, 3)
        Me.LibroCombo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibroCombo.FormattingEnabled = True
        Me.LibroCombo.Location = New System.Drawing.Point(88, 3)
        Me.LibroCombo.Name = "LibroCombo"
        Me.LibroCombo.Size = New System.Drawing.Size(429, 25)
        Me.LibroCombo.TabIndex = 1
        '
        'VigenciaPicker
        '
        Me.VigenciaPicker.Enabled = False
        Me.VigenciaPicker.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VigenciaPicker.Location = New System.Drawing.Point(628, 69)
        Me.VigenciaPicker.Name = "VigenciaPicker"
        Me.VigenciaPicker.Size = New System.Drawing.Size(263, 20)
        Me.VigenciaPicker.TabIndex = 72
        '
        'VigenciaL
        '
        Me.VigenciaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VigenciaL.AutoSize = True
        Me.VigenciaL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VigenciaL.Location = New System.Drawing.Point(563, 66)
        Me.VigenciaL.Name = "VigenciaL"
        Me.VigenciaL.Size = New System.Drawing.Size(59, 33)
        Me.VigenciaL.TabIndex = 71
        Me.VigenciaL.Text = "Vigencia:"
        Me.VigenciaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImpresionPicker
        '
        Me.ImpresionPicker.Enabled = False
        Me.ImpresionPicker.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpresionPicker.Location = New System.Drawing.Point(628, 36)
        Me.ImpresionPicker.Name = "ImpresionPicker"
        Me.ImpresionPicker.Size = New System.Drawing.Size(263, 20)
        Me.ImpresionPicker.TabIndex = 5
        '
        'RegistroPicker
        '
        Me.RegistroPicker.Enabled = False
        Me.RegistroPicker.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroPicker.Location = New System.Drawing.Point(628, 3)
        Me.RegistroPicker.Name = "RegistroPicker"
        Me.RegistroPicker.Size = New System.Drawing.Size(263, 20)
        Me.RegistroPicker.TabIndex = 7
        '
        'ImpresionL
        '
        Me.ImpresionL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImpresionL.AutoSize = True
        Me.ImpresionL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpresionL.Location = New System.Drawing.Point(563, 33)
        Me.ImpresionL.Name = "ImpresionL"
        Me.ImpresionL.Size = New System.Drawing.Size(59, 33)
        Me.ImpresionL.TabIndex = 4
        Me.ImpresionL.Text = "Impresión:"
        Me.ImpresionL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RegistroL
        '
        Me.RegistroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegistroL.AutoSize = True
        Me.RegistroL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroL.Location = New System.Drawing.Point(563, 0)
        Me.RegistroL.Name = "RegistroL"
        Me.RegistroL.Size = New System.Drawing.Size(59, 33)
        Me.RegistroL.TabIndex = 6
        Me.RegistroL.Text = "Registro:"
        Me.RegistroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProveedorCombo
        '
        Me.ProveedorCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TableLayoutPanel1.SetColumnSpan(Me.ProveedorCombo, 3)
        Me.ProveedorCombo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedorCombo.FormattingEnabled = True
        Me.ProveedorCombo.Location = New System.Drawing.Point(88, 69)
        Me.ProveedorCombo.Name = "ProveedorCombo"
        Me.ProveedorCombo.Size = New System.Drawing.Size(429, 25)
        Me.ProveedorCombo.TabIndex = 3
        '
        'PrecioL
        '
        Me.PrecioL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrecioL.AutoSize = True
        Me.PrecioL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrecioL.Location = New System.Drawing.Point(3, 33)
        Me.PrecioL.Name = "PrecioL"
        Me.PrecioL.Size = New System.Drawing.Size(79, 33)
        Me.PrecioL.TabIndex = 69
        Me.PrecioL.Text = "Precio: Q."
        Me.PrecioL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrecioV
        '
        Me.PrecioV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioV.Location = New System.Drawing.Point(88, 36)
        Me.PrecioV.Name = "PrecioV"
        Me.PrecioV.ReadOnly = True
        Me.PrecioV.Size = New System.Drawing.Size(85, 25)
        Me.PrecioV.TabIndex = 2
        '
        'ProveedorL
        '
        Me.ProveedorL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedorL.AutoSize = True
        Me.ProveedorL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedorL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProveedorL.Location = New System.Drawing.Point(3, 66)
        Me.ProveedorL.Name = "ProveedorL"
        Me.ProveedorL.Size = New System.Drawing.Size(79, 33)
        Me.ProveedorL.TabIndex = 0
        Me.ProveedorL.Text = "Proveedor:"
        Me.ProveedorL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LibroL
        '
        Me.LibroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibroL.AutoSize = True
        Me.LibroL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibroL.Location = New System.Drawing.Point(3, 0)
        Me.LibroL.Name = "LibroL"
        Me.LibroL.Size = New System.Drawing.Size(79, 33)
        Me.LibroL.TabIndex = 3
        Me.LibroL.Text = "Libro:"
        Me.LibroL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VerificaLibroL
        '
        Me.VerificaLibroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerificaLibroL.AutoSize = True
        Me.VerificaLibroL.BackColor = System.Drawing.Color.Transparent
        Me.VerificaLibroL.ForeColor = System.Drawing.Color.Blue
        Me.VerificaLibroL.Location = New System.Drawing.Point(426, 33)
        Me.VerificaLibroL.Name = "VerificaLibroL"
        Me.VerificaLibroL.Size = New System.Drawing.Size(91, 33)
        Me.VerificaLibroL.TabIndex = 4
        Me.VerificaLibroL.Text = "*Ingresar Libro"
        Me.VerificaLibroL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HistorialGrid
        '
        Me.HistorialGrid.AllowUserToAddRows = False
        Me.HistorialGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistorialGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialGrid.BackgroundColor = System.Drawing.Color.White
        Me.HistorialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LibrosTable.SetColumnSpan(Me.HistorialGrid, 4)
        Me.HistorialGrid.Location = New System.Drawing.Point(3, 182)
        Me.HistorialGrid.Name = "HistorialGrid"
        Me.HistorialGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.HistorialGrid.Size = New System.Drawing.Size(978, 273)
        Me.HistorialGrid.TabIndex = 1
        '
        'EtiquetaL
        '
        Me.EtiquetaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EtiquetaL.AutoSize = True
        Me.EtiquetaL.BackColor = System.Drawing.Color.LightBlue
        Me.EtiquetaL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaL.Location = New System.Drawing.Point(3, 0)
        Me.EtiquetaL.Name = "EtiquetaL"
        Me.EtiquetaL.Size = New System.Drawing.Size(16, 18)
        Me.EtiquetaL.TabIndex = 69
        Me.EtiquetaL.Text = "_"
        Me.EtiquetaL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ValesActualesCheckBox
        '
        Me.ValesActualesCheckBox.AutoSize = True
        Me.ValesActualesCheckBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ValesActualesCheckBox.Location = New System.Drawing.Point(3, 156)
        Me.ValesActualesCheckBox.Name = "ValesActualesCheckBox"
        Me.ValesActualesCheckBox.Size = New System.Drawing.Size(152, 20)
        Me.ValesActualesCheckBox.TabIndex = 69
        Me.ValesActualesCheckBox.Text = "Vales Libros Actuales"
        Me.ValesActualesCheckBox.UseVisualStyleBackColor = False
        '
        'HistorialValeLibrosCheck
        '
        Me.HistorialValeLibrosCheck.AutoSize = True
        Me.HistorialValeLibrosCheck.BackColor = System.Drawing.Color.PaleTurquoise
        Me.HistorialValeLibrosCheck.Location = New System.Drawing.Point(249, 156)
        Me.HistorialValeLibrosCheck.Name = "HistorialValeLibrosCheck"
        Me.HistorialValeLibrosCheck.Size = New System.Drawing.Size(149, 20)
        Me.HistorialValeLibrosCheck.TabIndex = 2
        Me.HistorialValeLibrosCheck.Text = "Historial Vales Libros"
        Me.HistorialValeLibrosCheck.UseVisualStyleBackColor = False
        '
        'PrintDocumentVale
        '
        '
        'PrintPreviewDialogVale
        '
        Me.PrintPreviewDialogVale.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogVale.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogVale.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogVale.Enabled = True
        Me.PrintPreviewDialogVale.Icon = CType(resources.GetObject("PrintPreviewDialogVale.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogVale.Name = "PrintPreviewDialogVale"
        Me.PrintPreviewDialogVale.Visible = False
        '
        'ValeLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.LibrosTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ValeLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vale - Libros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.LibrosTable.ResumeLayout(False)
        Me.LibrosTable.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents EdadV As System.Windows.Forms.Label
    Friend WithEvents TSV As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents LibrosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LibroL As System.Windows.Forms.Label
    Friend WithEvents ProveedorL As System.Windows.Forms.Label
    Friend WithEvents ImpresionPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImpresionL As System.Windows.Forms.Label
    Friend WithEvents HistorialGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GradoV As System.Windows.Forms.Label
    Friend WithEvents EscuelaV As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.Label
    Friend WithEvents HistorialValeLibrosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents RegistroPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDocumentVale As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogVale As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents HistorialActividadesCheck As System.Windows.Forms.CheckBox
    Friend WithEvents HistorialReembolsosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents TipoTransV As System.Windows.Forms.Label
    Friend WithEvents PrecioL As System.Windows.Forms.Label
    Friend WithEvents PrecioV As System.Windows.Forms.TextBox
    Friend WithEvents VigenciaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VigenciaL As System.Windows.Forms.Label
    Friend WithEvents LimpiarButton As System.Windows.Forms.Button
    Friend WithEvents EtiquetaL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegistroL As System.Windows.Forms.Label
    Friend WithEvents ProveedorCombo As System.Windows.Forms.ComboBox
    Friend WithEvents LibroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents VerificaLibroL As System.Windows.Forms.Label
    Friend WithEvents ValesActualesCheckBox As System.Windows.Forms.CheckBox
End Class
