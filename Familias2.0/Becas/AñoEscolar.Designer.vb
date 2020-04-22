<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñoEscolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AñoEscolar))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.RegresarButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.GridsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ObservacionesCheck = New System.Windows.Forms.CheckBox()
        Me.ActividadesCheck = New System.Windows.Forms.CheckBox()
        Me.HistorialGrid = New System.Windows.Forms.DataGridView()
        Me.ReembolsosCheck = New System.Windows.Forms.CheckBox()
        Me.añoEscolarTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ClasificacionL = New System.Windows.Forms.Label()
        Me.RazonL = New System.Windows.Forms.Label()
        Me.RazonNoContinuarCombo = New System.Windows.Forms.ComboBox()
        Me.escuelaCombo = New System.Windows.Forms.ComboBox()
        Me.escuelaL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.gradoCombo = New System.Windows.Forms.ComboBox()
        Me.CertificadoV = New System.Windows.Forms.CheckBox()
        Me.EstadoV = New System.Windows.Forms.ComboBox()
        Me.CreationDateL = New System.Windows.Forms.Label()
        Me.FaseV = New System.Windows.Forms.Label()
        Me.FaseL = New System.Windows.Forms.Label()
        Me.AfiliacionV = New System.Windows.Forms.Label()
        Me.AfiliacionL = New System.Windows.Forms.Label()
        Me.EstadoAfilV = New System.Windows.Forms.Label()
        Me.EstadoAfilL = New System.Windows.Forms.Label()
        Me.SemaforoV = New System.Windows.Forms.Label()
        Me.SemaforoL = New System.Windows.Forms.Label()
        Me.ClasificacionV = New System.Windows.Forms.Label()
        Me.SeccionV = New System.Windows.Forms.Label()
        Me.MaestroV = New System.Windows.Forms.Label()
        Me.carreraCombo = New System.Windows.Forms.ComboBox()
        Me.SeccionL = New System.Windows.Forms.Label()
        Me.MaestroL = New System.Windows.Forms.Label()
        Me.carreraL = New System.Windows.Forms.Label()
        Me.AvisosLink = New System.Windows.Forms.LinkLabel()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.Label()
        Me.AvisosGrid = New System.Windows.Forms.DataGridView()
        Me.ApadrinadoPic = New System.Windows.Forms.PictureBox()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.TSL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.EdadV = New System.Windows.Forms.Label()
        Me.TSV = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.GridsTable.SuspendLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.añoEscolarTable.SuspendLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApadrinadoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSecundario.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.bannerPanel.TabIndex = 255
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
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.RegresarButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 4, 0)
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
        Me.NuevoButton.TabIndex = 236
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'RegresarButton
        '
        Me.RegresarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.RegresarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.retorno
        Me.RegresarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegresarButton.Location = New System.Drawing.Point(727, 3)
        Me.RegresarButton.Name = "RegresarButton"
        Me.RegresarButton.Size = New System.Drawing.Size(49, 44)
        Me.RegresarButton.TabIndex = 235
        Me.RegresarButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(676, 3)
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
        Me.Title.Size = New System.Drawing.Size(665, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Año Escolar"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'GridsTable
        '
        Me.GridsTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridsTable.BackColor = System.Drawing.Color.Transparent
        Me.GridsTable.ColumnCount = 3
        Me.GridsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GridsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.GridsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GridsTable.Controls.Add(Me.ObservacionesCheck, 2, 2)
        Me.GridsTable.Controls.Add(Me.ActividadesCheck, 2, 1)
        Me.GridsTable.Controls.Add(Me.HistorialGrid, 0, 0)
        Me.GridsTable.Controls.Add(Me.ReembolsosCheck, 2, 0)
        Me.GridsTable.Location = New System.Drawing.Point(0, 403)
        Me.GridsTable.Name = "GridsTable"
        Me.GridsTable.RowCount = 4
        Me.GridsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.GridsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.GridsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.GridsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GridsTable.Size = New System.Drawing.Size(984, 258)
        Me.GridsTable.TabIndex = 256
        '
        'ObservacionesCheck
        '
        Me.ObservacionesCheck.AutoSize = True
        Me.ObservacionesCheck.Location = New System.Drawing.Point(869, 63)
        Me.ObservacionesCheck.Name = "ObservacionesCheck"
        Me.ObservacionesCheck.Size = New System.Drawing.Size(112, 20)
        Me.ObservacionesCheck.TabIndex = 260
        Me.ObservacionesCheck.Text = "Observaciones"
        Me.ObservacionesCheck.UseVisualStyleBackColor = True
        '
        'ActividadesCheck
        '
        Me.ActividadesCheck.AutoSize = True
        Me.ActividadesCheck.Location = New System.Drawing.Point(869, 33)
        Me.ActividadesCheck.Name = "ActividadesCheck"
        Me.ActividadesCheck.Size = New System.Drawing.Size(93, 20)
        Me.ActividadesCheck.TabIndex = 259
        Me.ActividadesCheck.Text = "Actividades"
        Me.ActividadesCheck.UseVisualStyleBackColor = True
        '
        'HistorialGrid
        '
        Me.HistorialGrid.AllowUserToAddRows = False
        Me.HistorialGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.HistorialGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistorialGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.HistorialGrid.BackgroundColor = System.Drawing.Color.White
        Me.HistorialGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistorialGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.HistorialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HistorialGrid.Location = New System.Drawing.Point(3, 3)
        Me.HistorialGrid.Name = "HistorialGrid"
        Me.HistorialGrid.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HistorialGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.HistorialGrid.RowHeadersVisible = False
        Me.HistorialGrid.RowHeadersWidth = 28
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GridsTable.SetRowSpan(Me.HistorialGrid, 4)
        Me.HistorialGrid.Size = New System.Drawing.Size(830, 252)
        Me.HistorialGrid.TabIndex = 257
        Me.HistorialGrid.Visible = False
        '
        'ReembolsosCheck
        '
        Me.ReembolsosCheck.AutoSize = True
        Me.ReembolsosCheck.Location = New System.Drawing.Point(869, 3)
        Me.ReembolsosCheck.Name = "ReembolsosCheck"
        Me.ReembolsosCheck.Size = New System.Drawing.Size(99, 20)
        Me.ReembolsosCheck.TabIndex = 258
        Me.ReembolsosCheck.Text = "Reembolsos"
        Me.ReembolsosCheck.UseVisualStyleBackColor = True
        '
        'añoEscolarTable
        '
        Me.añoEscolarTable.BackColor = System.Drawing.Color.Transparent
        Me.añoEscolarTable.ColumnCount = 5
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.añoEscolarTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.añoEscolarTable.Controls.Add(Me.ClasificacionL, 3, 4)
        Me.añoEscolarTable.Controls.Add(Me.RazonL, 0, 3)
        Me.añoEscolarTable.Controls.Add(Me.RazonNoContinuarCombo, 1, 3)
        Me.añoEscolarTable.Controls.Add(Me.escuelaCombo, 1, 1)
        Me.añoEscolarTable.Controls.Add(Me.escuelaL, 0, 1)
        Me.añoEscolarTable.Controls.Add(Me.GradoL, 0, 0)
        Me.añoEscolarTable.Controls.Add(Me.EstadoL, 0, 2)
        Me.añoEscolarTable.Controls.Add(Me.gradoCombo, 1, 0)
        Me.añoEscolarTable.Controls.Add(Me.CertificadoV, 3, 5)
        Me.añoEscolarTable.Controls.Add(Me.EstadoV, 1, 2)
        Me.añoEscolarTable.Controls.Add(Me.CreationDateL, 2, 0)
        Me.añoEscolarTable.Controls.Add(Me.FaseV, 4, 0)
        Me.añoEscolarTable.Controls.Add(Me.FaseL, 3, 0)
        Me.añoEscolarTable.Controls.Add(Me.AfiliacionV, 4, 3)
        Me.añoEscolarTable.Controls.Add(Me.AfiliacionL, 3, 3)
        Me.añoEscolarTable.Controls.Add(Me.EstadoAfilV, 4, 2)
        Me.añoEscolarTable.Controls.Add(Me.EstadoAfilL, 3, 2)
        Me.añoEscolarTable.Controls.Add(Me.SemaforoV, 4, 1)
        Me.añoEscolarTable.Controls.Add(Me.SemaforoL, 3, 1)
        Me.añoEscolarTable.Controls.Add(Me.ClasificacionV, 4, 4)
        Me.añoEscolarTable.Controls.Add(Me.SeccionV, 1, 6)
        Me.añoEscolarTable.Controls.Add(Me.MaestroV, 1, 5)
        Me.añoEscolarTable.Controls.Add(Me.carreraCombo, 1, 4)
        Me.añoEscolarTable.Controls.Add(Me.SeccionL, 0, 6)
        Me.añoEscolarTable.Controls.Add(Me.MaestroL, 0, 5)
        Me.añoEscolarTable.Controls.Add(Me.carreraL, 0, 4)
        Me.añoEscolarTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.añoEscolarTable.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.añoEscolarTable.Location = New System.Drawing.Point(0, 0)
        Me.añoEscolarTable.Name = "añoEscolarTable"
        Me.añoEscolarTable.RowCount = 7
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.añoEscolarTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.añoEscolarTable.Size = New System.Drawing.Size(625, 187)
        Me.añoEscolarTable.TabIndex = 257
        '
        'ClasificacionL
        '
        Me.ClasificacionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionL.AutoSize = True
        Me.ClasificacionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionL.ForeColor = System.Drawing.Color.Black
        Me.ClasificacionL.Location = New System.Drawing.Point(412, 120)
        Me.ClasificacionL.Name = "ClasificacionL"
        Me.ClasificacionL.Size = New System.Drawing.Size(91, 16)
        Me.ClasificacionL.TabIndex = 12
        Me.ClasificacionL.Text = "Clasificación:"
        '
        'RazonL
        '
        Me.RazonL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RazonL.AutoSize = True
        Me.RazonL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonL.ForeColor = System.Drawing.Color.Black
        Me.RazonL.Location = New System.Drawing.Point(3, 90)
        Me.RazonL.Name = "RazonL"
        Me.RazonL.Size = New System.Drawing.Size(118, 16)
        Me.RazonL.TabIndex = 8
        Me.RazonL.Text = "Excepción Estado:"
        '
        'RazonNoContinuarCombo
        '
        Me.RazonNoContinuarCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RazonNoContinuarCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RazonNoContinuarCombo.BackColor = System.Drawing.Color.White
        Me.RazonNoContinuarCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonNoContinuarCombo.ForeColor = System.Drawing.Color.Black
        Me.RazonNoContinuarCombo.FormattingEnabled = True
        Me.RazonNoContinuarCombo.Location = New System.Drawing.Point(127, 93)
        Me.RazonNoContinuarCombo.Name = "RazonNoContinuarCombo"
        Me.RazonNoContinuarCombo.Size = New System.Drawing.Size(239, 24)
        Me.RazonNoContinuarCombo.TabIndex = 205
        '
        'escuelaCombo
        '
        Me.escuelaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.escuelaCombo.BackColor = System.Drawing.Color.White
        Me.escuelaCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.escuelaCombo.ForeColor = System.Drawing.Color.Black
        Me.escuelaCombo.FormattingEnabled = True
        Me.escuelaCombo.Location = New System.Drawing.Point(127, 33)
        Me.escuelaCombo.Name = "escuelaCombo"
        Me.escuelaCombo.Size = New System.Drawing.Size(75, 24)
        Me.escuelaCombo.TabIndex = 205
        '
        'escuelaL
        '
        Me.escuelaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.escuelaL.AutoSize = True
        Me.escuelaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.escuelaL.ForeColor = System.Drawing.Color.Black
        Me.escuelaL.Location = New System.Drawing.Point(3, 30)
        Me.escuelaL.Name = "escuelaL"
        Me.escuelaL.Size = New System.Drawing.Size(118, 16)
        Me.escuelaL.TabIndex = 201
        Me.escuelaL.Text = "Escuela:"
        '
        'GradoL
        '
        Me.GradoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradoL.AutoSize = True
        Me.GradoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradoL.ForeColor = System.Drawing.Color.Black
        Me.GradoL.Location = New System.Drawing.Point(3, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(118, 16)
        Me.GradoL.TabIndex = 2
        Me.GradoL.Text = "Grado:"
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoL.ForeColor = System.Drawing.Color.Black
        Me.EstadoL.Location = New System.Drawing.Point(3, 60)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(118, 16)
        Me.EstadoL.TabIndex = 6
        Me.EstadoL.Text = "Estado:"
        '
        'gradoCombo
        '
        Me.gradoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gradoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.gradoCombo.BackColor = System.Drawing.Color.White
        Me.gradoCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradoCombo.ForeColor = System.Drawing.Color.Black
        Me.gradoCombo.FormattingEnabled = True
        Me.gradoCombo.Location = New System.Drawing.Point(127, 3)
        Me.gradoCombo.Name = "gradoCombo"
        Me.gradoCombo.Size = New System.Drawing.Size(239, 24)
        Me.gradoCombo.TabIndex = 204
        '
        'CertificadoV
        '
        Me.CertificadoV.AutoSize = True
        Me.añoEscolarTable.SetColumnSpan(Me.CertificadoV, 2)
        Me.CertificadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CertificadoV.ForeColor = System.Drawing.Color.Black
        Me.CertificadoV.Location = New System.Drawing.Point(412, 153)
        Me.CertificadoV.Name = "CertificadoV"
        Me.añoEscolarTable.SetRowSpan(Me.CertificadoV, 2)
        Me.CertificadoV.Size = New System.Drawing.Size(138, 20)
        Me.CertificadoV.TabIndex = 26
        Me.CertificadoV.Text = "¿Tiene Certificado?"
        Me.CertificadoV.UseVisualStyleBackColor = True
        '
        'EstadoV
        '
        Me.EstadoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EstadoV.BackColor = System.Drawing.Color.White
        Me.EstadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoV.ForeColor = System.Drawing.Color.Black
        Me.EstadoV.FormattingEnabled = True
        Me.EstadoV.Location = New System.Drawing.Point(127, 63)
        Me.EstadoV.Name = "EstadoV"
        Me.EstadoV.Size = New System.Drawing.Size(239, 24)
        Me.EstadoV.TabIndex = 207
        '
        'CreationDateL
        '
        Me.CreationDateL.AutoSize = True
        Me.CreationDateL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreationDateL.Location = New System.Drawing.Point(372, 0)
        Me.CreationDateL.Name = "CreationDateL"
        Me.CreationDateL.Size = New System.Drawing.Size(15, 16)
        Me.CreationDateL.TabIndex = 207
        Me.CreationDateL.Text = "_"
        Me.CreationDateL.Visible = False
        '
        'FaseV
        '
        Me.FaseV.AutoSize = True
        Me.FaseV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaseV.ForeColor = System.Drawing.Color.Black
        Me.FaseV.Location = New System.Drawing.Point(509, 0)
        Me.FaseV.Name = "FaseV"
        Me.FaseV.Size = New System.Drawing.Size(15, 16)
        Me.FaseV.TabIndex = 200
        Me.FaseV.Text = "_"
        '
        'FaseL
        '
        Me.FaseL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaseL.AutoSize = True
        Me.FaseL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaseL.ForeColor = System.Drawing.Color.Black
        Me.FaseL.Location = New System.Drawing.Point(412, 0)
        Me.FaseL.Name = "FaseL"
        Me.FaseL.Size = New System.Drawing.Size(91, 16)
        Me.FaseL.TabIndex = 200
        Me.FaseL.Text = "Desafiliación:"
        '
        'AfiliacionV
        '
        Me.AfiliacionV.AutoSize = True
        Me.AfiliacionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfiliacionV.ForeColor = System.Drawing.Color.Black
        Me.AfiliacionV.Location = New System.Drawing.Point(509, 90)
        Me.AfiliacionV.Name = "AfiliacionV"
        Me.AfiliacionV.Size = New System.Drawing.Size(15, 16)
        Me.AfiliacionV.TabIndex = 19
        Me.AfiliacionV.Text = "_"
        '
        'AfiliacionL
        '
        Me.AfiliacionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AfiliacionL.AutoSize = True
        Me.AfiliacionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfiliacionL.ForeColor = System.Drawing.Color.Black
        Me.AfiliacionL.Location = New System.Drawing.Point(412, 90)
        Me.AfiliacionL.Name = "AfiliacionL"
        Me.AfiliacionL.Size = New System.Drawing.Size(91, 16)
        Me.AfiliacionL.TabIndex = 18
        Me.AfiliacionL.Text = "Tipo Afiliación:"
        '
        'EstadoAfilV
        '
        Me.EstadoAfilV.AutoSize = True
        Me.EstadoAfilV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoAfilV.ForeColor = System.Drawing.Color.Black
        Me.EstadoAfilV.Location = New System.Drawing.Point(509, 60)
        Me.EstadoAfilV.Name = "EstadoAfilV"
        Me.EstadoAfilV.Size = New System.Drawing.Size(15, 16)
        Me.EstadoAfilV.TabIndex = 21
        Me.EstadoAfilV.Text = "_"
        '
        'EstadoAfilL
        '
        Me.EstadoAfilL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoAfilL.AutoSize = True
        Me.EstadoAfilL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoAfilL.ForeColor = System.Drawing.Color.Black
        Me.EstadoAfilL.Location = New System.Drawing.Point(412, 60)
        Me.EstadoAfilL.Name = "EstadoAfilL"
        Me.EstadoAfilL.Size = New System.Drawing.Size(91, 16)
        Me.EstadoAfilL.TabIndex = 20
        Me.EstadoAfilL.Text = "Estado Afil.:"
        '
        'SemaforoV
        '
        Me.SemaforoV.AutoSize = True
        Me.SemaforoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemaforoV.ForeColor = System.Drawing.Color.Black
        Me.SemaforoV.Location = New System.Drawing.Point(509, 30)
        Me.SemaforoV.Name = "SemaforoV"
        Me.SemaforoV.Size = New System.Drawing.Size(15, 16)
        Me.SemaforoV.TabIndex = 201
        Me.SemaforoV.Text = "_"
        '
        'SemaforoL
        '
        Me.SemaforoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SemaforoL.AutoSize = True
        Me.SemaforoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemaforoL.ForeColor = System.Drawing.Color.Black
        Me.SemaforoL.Location = New System.Drawing.Point(412, 30)
        Me.SemaforoL.Name = "SemaforoL"
        Me.SemaforoL.Size = New System.Drawing.Size(91, 16)
        Me.SemaforoL.TabIndex = 200
        Me.SemaforoL.Text = "Semáforo:"
        '
        'ClasificacionV
        '
        Me.ClasificacionV.AutoSize = True
        Me.ClasificacionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionV.ForeColor = System.Drawing.Color.Black
        Me.ClasificacionV.Location = New System.Drawing.Point(509, 120)
        Me.ClasificacionV.Name = "ClasificacionV"
        Me.ClasificacionV.Size = New System.Drawing.Size(15, 16)
        Me.ClasificacionV.TabIndex = 13
        Me.ClasificacionV.Text = "_"
        '
        'SeccionV
        '
        Me.SeccionV.AutoSize = True
        Me.SeccionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeccionV.ForeColor = System.Drawing.Color.Black
        Me.SeccionV.Location = New System.Drawing.Point(127, 166)
        Me.SeccionV.Name = "SeccionV"
        Me.SeccionV.Size = New System.Drawing.Size(15, 16)
        Me.SeccionV.TabIndex = 5
        Me.SeccionV.Text = "_"
        Me.SeccionV.Visible = False
        '
        'MaestroV
        '
        Me.MaestroV.AutoSize = True
        Me.MaestroV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaestroV.ForeColor = System.Drawing.Color.Black
        Me.MaestroV.Location = New System.Drawing.Point(127, 150)
        Me.MaestroV.Name = "MaestroV"
        Me.MaestroV.Size = New System.Drawing.Size(12, 16)
        Me.MaestroV.TabIndex = 11
        Me.MaestroV.Text = "."
        '
        'carreraCombo
        '
        Me.carreraCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.carreraCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.carreraCombo.BackColor = System.Drawing.Color.White
        Me.carreraCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carreraCombo.ForeColor = System.Drawing.Color.Black
        Me.carreraCombo.FormattingEnabled = True
        Me.carreraCombo.Location = New System.Drawing.Point(127, 123)
        Me.carreraCombo.Name = "carreraCombo"
        Me.carreraCombo.Size = New System.Drawing.Size(239, 24)
        Me.carreraCombo.TabIndex = 206
        '
        'SeccionL
        '
        Me.SeccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeccionL.AutoSize = True
        Me.SeccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeccionL.ForeColor = System.Drawing.Color.Black
        Me.SeccionL.Location = New System.Drawing.Point(3, 166)
        Me.SeccionL.Name = "SeccionL"
        Me.SeccionL.Size = New System.Drawing.Size(118, 16)
        Me.SeccionL.TabIndex = 4
        Me.SeccionL.Text = "_"
        Me.SeccionL.Visible = False
        '
        'MaestroL
        '
        Me.MaestroL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaestroL.AutoSize = True
        Me.MaestroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaestroL.ForeColor = System.Drawing.Color.Black
        Me.MaestroL.Location = New System.Drawing.Point(3, 150)
        Me.MaestroL.Name = "MaestroL"
        Me.MaestroL.Size = New System.Drawing.Size(118, 16)
        Me.MaestroL.TabIndex = 10
        Me.MaestroL.Text = "."
        '
        'carreraL
        '
        Me.carreraL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.carreraL.AutoSize = True
        Me.carreraL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carreraL.ForeColor = System.Drawing.Color.Black
        Me.carreraL.Location = New System.Drawing.Point(3, 120)
        Me.carreraL.Name = "carreraL"
        Me.carreraL.Size = New System.Drawing.Size(118, 16)
        Me.carreraL.TabIndex = 201
        Me.carreraL.Text = "Carrera:"
        '
        'AvisosLink
        '
        Me.AvisosLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvisosLink.AutoSize = True
        Me.AvisosLink.BackColor = System.Drawing.Color.DodgerBlue
        Me.AvisosLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvisosLink.ForeColor = System.Drawing.Color.White
        Me.AvisosLink.LinkColor = System.Drawing.Color.White
        Me.AvisosLink.Location = New System.Drawing.Point(658, 0)
        Me.AvisosLink.Name = "AvisosLink"
        Me.AvisosLink.Size = New System.Drawing.Size(303, 18)
        Me.AvisosLink.TabIndex = 202
        Me.AvisosLink.TabStop = True
        Me.AvisosLink.Text = "Avisos"
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.BackColor = System.Drawing.Color.SteelBlue
        Me.AñoL.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoL.ForeColor = System.Drawing.Color.White
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(629, 18)
        Me.AñoL.TabIndex = 0
        Me.AñoL.Text = "AÑO ESCOLAR: "
        Me.AñoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AñoV
        '
        Me.AñoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoV.AutoSize = True
        Me.AñoV.BackColor = System.Drawing.Color.Navy
        Me.AñoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoV.ForeColor = System.Drawing.Color.White
        Me.AñoV.Location = New System.Drawing.Point(638, 0)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(14, 16)
        Me.AñoV.TabIndex = 1
        Me.AñoV.Text = "_"
        Me.AñoV.Visible = False
        '
        'AvisosGrid
        '
        Me.AvisosGrid.AllowUserToAddRows = False
        Me.AvisosGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AvisosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.AvisosGrid.BackgroundColor = System.Drawing.Color.White
        Me.AvisosGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvisosGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.AvisosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvisosGrid.ColumnHeadersVisible = False
        Me.AvisosGrid.GridColor = System.Drawing.Color.White
        Me.AvisosGrid.Location = New System.Drawing.Point(658, 21)
        Me.AvisosGrid.Name = "AvisosGrid"
        Me.AvisosGrid.ReadOnly = True
        Me.AvisosGrid.RowHeadersVisible = False
        Me.AvisosGrid.Size = New System.Drawing.Size(303, 174)
        Me.AvisosGrid.TabIndex = 201
        Me.AvisosGrid.Visible = False
        '
        'ApadrinadoPic
        '
        Me.ApadrinadoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ApadrinadoPic.Location = New System.Drawing.Point(967, 21)
        Me.ApadrinadoPic.Name = "ApadrinadoPic"
        Me.ApadrinadoPic.Size = New System.Drawing.Size(14, 68)
        Me.ApadrinadoPic.TabIndex = 33
        Me.ApadrinadoPic.TabStop = False
        Me.ApadrinadoPic.Visible = False
        '
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 6
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.Controls.Add(Me.TSL, 4, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.EdadV, 2, 0)
        Me.PanelSecundario.Controls.Add(Me.TSV, 5, 0)
        Me.PanelSecundario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 155)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 2
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PanelSecundario.Size = New System.Drawing.Size(984, 25)
        Me.PanelSecundario.TabIndex = 259
        '
        'TSL
        '
        Me.TSL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSL.AutoSize = True
        Me.TSL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSL.Location = New System.Drawing.Point(932, 0)
        Me.TSL.Name = "TSL"
        Me.TSL.Size = New System.Drawing.Size(28, 35)
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
        Me.NombreL.Size = New System.Drawing.Size(57, 35)
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
        'EdadV
        '
        Me.EdadV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdadV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EdadV.Location = New System.Drawing.Point(87, 0)
        Me.EdadV.Name = "EdadV"
        Me.EdadV.Size = New System.Drawing.Size(819, 23)
        Me.EdadV.TabIndex = 198
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
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(984, 36)
        Me.PrincipalPanel.TabIndex = 258
        '
        'FamiliaV
        '
        Me.FamiliaV.BackColor = System.Drawing.Color.AliceBlue
        Me.FamiliaV.Enabled = False
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
        Me.MiembroV.BackColor = System.Drawing.Color.AliceBlue
        Me.MiembroV.Enabled = False
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(867, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(112, 29)
        Me.MiembroV.TabIndex = 204
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(759, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(102, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Miembro:"
        Me.PacienteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AvisosLink, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AvisosGrid, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ApadrinadoPic, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoV, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 185)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(984, 215)
        Me.TableLayoutPanel1.TabIndex = 260
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.añoEscolarTable)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 191)
        Me.Panel1.TabIndex = 203
        '
        'AñoEscolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.GridsTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AñoEscolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Año Escolar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.GridsTable.ResumeLayout(False)
        Me.GridsTable.PerformLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.añoEscolarTable.ResumeLayout(False)
        Me.añoEscolarTable.PerformLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApadrinadoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegresarButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents GridsTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HistorialGrid As System.Windows.Forms.DataGridView
    Friend WithEvents añoEscolarTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SemaforoV As System.Windows.Forms.Label
    Friend WithEvents carreraCombo As System.Windows.Forms.ComboBox
    Friend WithEvents carreraL As System.Windows.Forms.Label
    Friend WithEvents escuelaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents escuelaL As System.Windows.Forms.Label
    Friend WithEvents AvisosLink As System.Windows.Forms.LinkLabel
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents gradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CreationDateL As System.Windows.Forms.Label
    Friend WithEvents SemaforoL As System.Windows.Forms.Label
    Friend WithEvents FaseL As System.Windows.Forms.Label
    Friend WithEvents FaseV As System.Windows.Forms.Label
    Friend WithEvents EstadoAfilL As System.Windows.Forms.Label
    Friend WithEvents EstadoAfilV As System.Windows.Forms.Label
    Friend WithEvents AfiliacionL As System.Windows.Forms.Label
    Friend WithEvents AfiliacionV As System.Windows.Forms.Label
    Friend WithEvents CertificadoV As System.Windows.Forms.CheckBox
    Friend WithEvents ClasificacionL As System.Windows.Forms.Label
    Friend WithEvents ClasificacionV As System.Windows.Forms.Label
    Friend WithEvents RazonL As System.Windows.Forms.Label
    Friend WithEvents SeccionL As System.Windows.Forms.Label
    Friend WithEvents SeccionV As System.Windows.Forms.Label
    Friend WithEvents MaestroL As System.Windows.Forms.Label
    Friend WithEvents MaestroV As System.Windows.Forms.Label
    Friend WithEvents AvisosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EstadoV As System.Windows.Forms.ComboBox
    Friend WithEvents ApadrinadoPic As System.Windows.Forms.PictureBox
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents EdadV As System.Windows.Forms.Label
    Friend WithEvents TSV As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RazonNoContinuarCombo As System.Windows.Forms.ComboBox
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents ObservacionesCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ActividadesCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ReembolsosCheck As System.Windows.Forms.CheckBox
End Class
