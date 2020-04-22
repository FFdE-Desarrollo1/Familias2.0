<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActividadesEduc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActividadesEduc))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.GradoV = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EscuelaV = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.Label()
        Me.EstadoV = New System.Windows.Forms.Label()
        Me.ActividadesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ActividadTL = New System.Windows.Forms.Label()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.ActividadL = New System.Windows.Forms.Label()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.FechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.ActividadesCombo = New System.Windows.Forms.ComboBox()
        Me.ObservacionesV = New System.Windows.Forms.TextBox()
        Me.HistorialL = New System.Windows.Forms.Label()
        Me.HistorialGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.PanelSecundario.SuspendLayout()
        Me.ActividadesTable.SuspendLayout()
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
        Me.bannerPanel.TabIndex = 260
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
        Me.GuardarButton.TabIndex = 8
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
        Me.Title.Text = "Actividades Educativas"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(984, 36)
        Me.PrincipalPanel.TabIndex = 262
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(101, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 29)
        Me.FamiliaV.TabIndex = 101
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
        Me.MiembroV.TabIndex = 100
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
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 8
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.Controls.Add(Me.EstadoL, 3, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoV, 1, 1)
        Me.PanelSecundario.Controls.Add(Me.GradoL, 0, 1)
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.Label2, 6, 1)
        Me.PanelSecundario.Controls.Add(Me.EscuelaV, 7, 1)
        Me.PanelSecundario.Controls.Add(Me.AñoL, 6, 0)
        Me.PanelSecundario.Controls.Add(Me.AñoV, 7, 0)
        Me.PanelSecundario.Controls.Add(Me.EstadoV, 4, 1)
        Me.PanelSecundario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 156)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 2
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelSecundario.Size = New System.Drawing.Size(984, 43)
        Me.PanelSecundario.TabIndex = 263
        Me.PanelSecundario.Visible = False
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoL.Location = New System.Drawing.Point(454, 16)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(53, 27)
        Me.EstadoL.TabIndex = 261
        Me.EstadoL.Text = "Estado:"
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
        Me.GradoL.Size = New System.Drawing.Size(57, 27)
        Me.GradoL.TabIndex = 69
        Me.GradoL.Text = "Grado:"
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
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(901, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 27)
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
        Me.EscuelaV.Location = New System.Drawing.Point(966, 16)
        Me.EscuelaV.Name = "EscuelaV"
        Me.EscuelaV.Size = New System.Drawing.Size(15, 16)
        Me.EscuelaV.TabIndex = 202
        Me.EscuelaV.Text = "_"
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoL.Location = New System.Drawing.Point(901, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(59, 16)
        Me.AñoL.TabIndex = 202
        Me.AñoL.Text = "Año:"
        '
        'AñoV
        '
        Me.AñoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoV.AutoSize = True
        Me.AñoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AñoV.Location = New System.Drawing.Point(966, 0)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(15, 16)
        Me.AñoV.TabIndex = 202
        Me.AñoV.Text = "_"
        '
        'EstadoV
        '
        Me.EstadoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoV.AutoSize = True
        Me.EstadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EstadoV.Location = New System.Drawing.Point(513, 16)
        Me.EstadoV.Name = "EstadoV"
        Me.EstadoV.Size = New System.Drawing.Size(15, 16)
        Me.EstadoV.TabIndex = 261
        Me.EstadoV.Text = "_"
        '
        'ActividadesTable
        '
        Me.ActividadesTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadesTable.BackColor = System.Drawing.Color.Transparent
        Me.ActividadesTable.ColumnCount = 4
        Me.ActividadesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ActividadesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ActividadesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ActividadesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ActividadesTable.Controls.Add(Me.ActividadTL, 0, 0)
        Me.ActividadesTable.Controls.Add(Me.FechaL, 0, 1)
        Me.ActividadesTable.Controls.Add(Me.ActividadL, 0, 2)
        Me.ActividadesTable.Controls.Add(Me.NotasL, 0, 3)
        Me.ActividadesTable.Controls.Add(Me.FechaPicker, 1, 1)
        Me.ActividadesTable.Controls.Add(Me.ActividadesCombo, 1, 2)
        Me.ActividadesTable.Controls.Add(Me.ObservacionesV, 1, 3)
        Me.ActividadesTable.Controls.Add(Me.HistorialL, 3, 0)
        Me.ActividadesTable.Controls.Add(Me.HistorialGrid, 3, 1)
        Me.ActividadesTable.Location = New System.Drawing.Point(0, 220)
        Me.ActividadesTable.Name = "ActividadesTable"
        Me.ActividadesTable.RowCount = 5
        Me.ActividadesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ActividadesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ActividadesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ActividadesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ActividadesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ActividadesTable.Size = New System.Drawing.Size(984, 441)
        Me.ActividadesTable.TabIndex = 264
        Me.ActividadesTable.Visible = False
        '
        'ActividadTL
        '
        Me.ActividadTL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadTL.AutoSize = True
        Me.ActividadTL.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ActividadesTable.SetColumnSpan(Me.ActividadTL, 2)
        Me.ActividadTL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadTL.Location = New System.Drawing.Point(3, 0)
        Me.ActividadTL.Name = "ActividadTL"
        Me.ActividadTL.Size = New System.Drawing.Size(422, 20)
        Me.ActividadTL.TabIndex = 69
        Me.ActividadTL.Text = "Actividad"
        Me.ActividadTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.Location = New System.Drawing.Point(3, 20)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(48, 16)
        Me.FechaL.TabIndex = 0
        Me.FechaL.Text = "Fecha:"
        '
        'ActividadL
        '
        Me.ActividadL.AutoSize = True
        Me.ActividadL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadL.Location = New System.Drawing.Point(3, 48)
        Me.ActividadL.Name = "ActividadL"
        Me.ActividadL.Size = New System.Drawing.Size(64, 16)
        Me.ActividadL.TabIndex = 1
        Me.ActividadL.Text = "Actividad:"
        '
        'NotasL
        '
        Me.NotasL.AutoSize = True
        Me.NotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasL.Location = New System.Drawing.Point(3, 76)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(97, 16)
        Me.NotasL.TabIndex = 2
        Me.NotasL.Text = "Observaciones:"
        '
        'FechaPicker
        '
        Me.FechaPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaPicker.Location = New System.Drawing.Point(106, 23)
        Me.FechaPicker.Name = "FechaPicker"
        Me.FechaPicker.Size = New System.Drawing.Size(319, 22)
        Me.FechaPicker.TabIndex = 3
        '
        'ActividadesCombo
        '
        Me.ActividadesCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActividadesCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadesCombo.FormattingEnabled = True
        Me.ActividadesCombo.Location = New System.Drawing.Point(106, 51)
        Me.ActividadesCombo.Name = "ActividadesCombo"
        Me.ActividadesCombo.Size = New System.Drawing.Size(319, 24)
        Me.ActividadesCombo.TabIndex = 5
        '
        'ObservacionesV
        '
        Me.ObservacionesV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionesV.Location = New System.Drawing.Point(106, 79)
        Me.ObservacionesV.MaxLength = 120
        Me.ObservacionesV.Multiline = True
        Me.ObservacionesV.Name = "ObservacionesV"
        Me.ActividadesTable.SetRowSpan(Me.ObservacionesV, 2)
        Me.ObservacionesV.Size = New System.Drawing.Size(319, 37)
        Me.ObservacionesV.TabIndex = 6
        '
        'HistorialL
        '
        Me.HistorialL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialL.AutoSize = True
        Me.HistorialL.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HistorialL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialL.Location = New System.Drawing.Point(451, 0)
        Me.HistorialL.Name = "HistorialL"
        Me.HistorialL.Size = New System.Drawing.Size(530, 20)
        Me.HistorialL.TabIndex = 7
        Me.HistorialL.Text = "Historial Actividades"
        Me.HistorialL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistorialGrid
        '
        Me.HistorialGrid.AllowUserToAddRows = False
        Me.HistorialGrid.AllowUserToDeleteRows = False
        Me.HistorialGrid.AllowUserToResizeColumns = False
        Me.HistorialGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistorialGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialGrid.BackgroundColor = System.Drawing.Color.White
        Me.HistorialGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.HistorialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.HistorialGrid.Location = New System.Drawing.Point(451, 23)
        Me.HistorialGrid.Name = "HistorialGrid"
        Me.HistorialGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ActividadesTable.SetRowSpan(Me.HistorialGrid, 4)
        Me.HistorialGrid.Size = New System.Drawing.Size(530, 415)
        Me.HistorialGrid.TabIndex = 4
        '
        'ActividadesEduc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.ActividadesTable)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActividadesEduc"
        Me.Text = "Actividades Educ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.ActividadesTable.ResumeLayout(False)
        Me.ActividadesTable.PerformLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents GradoV As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EscuelaV As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.Label
    Friend WithEvents EstadoV As System.Windows.Forms.Label
    Friend WithEvents ActividadesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ActividadTL As System.Windows.Forms.Label
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents ActividadL As System.Windows.Forms.Label
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents FechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ActividadesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ObservacionesV As System.Windows.Forms.TextBox
    Friend WithEvents HistorialL As System.Windows.Forms.Label
    Friend WithEvents HistorialGrid As System.Windows.Forms.DataGridView
End Class
