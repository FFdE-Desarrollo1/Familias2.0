<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesPRIM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportesPRIM))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TipoCombo = New System.Windows.Forms.ComboBox()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.CicloCombo = New System.Windows.Forms.ComboBox()
        Me.CicloL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.nAlumnosL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DatosTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(934, 104)
        Me.bannerPanel.TabIndex = 260
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
        Me.opcionesTable.Location = New System.Drawing.Point(94, 52)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(838, 49)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(786, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(49, 43)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(735, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 43)
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
        Me.Title.Size = New System.Drawing.Size(724, 49)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Notas Primaria - Escuela ENE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 145)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoGrid.Size = New System.Drawing.Size(934, 592)
        Me.ListadoGrid.TabIndex = 262
        Me.ListadoGrid.Visible = False
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.OldLace
        Me.DatosTable.ColumnCount = 14
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable.Controls.Add(Me.TipoCombo, 10, 0)
        Me.DatosTable.Controls.Add(Me.TipoL, 9, 0)
        Me.DatosTable.Controls.Add(Me.AñoL, 0, 0)
        Me.DatosTable.Controls.Add(Me.GradoL, 3, 0)
        Me.DatosTable.Controls.Add(Me.CicloCombo, 7, 0)
        Me.DatosTable.Controls.Add(Me.CicloL, 6, 0)
        Me.DatosTable.Controls.Add(Me.GradoCombo, 4, 0)
        Me.DatosTable.Controls.Add(Me.ListadoButton, 12, 0)
        Me.DatosTable.Controls.Add(Me.AñoV, 1, 0)
        Me.DatosTable.Controls.Add(Me.nAlumnosL, 13, 0)
        Me.DatosTable.Location = New System.Drawing.Point(0, 108)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 1
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable.Size = New System.Drawing.Size(934, 34)
        Me.DatosTable.TabIndex = 263
        '
        'TipoCombo
        '
        Me.TipoCombo.FormattingEnabled = True
        Me.TipoCombo.Items.AddRange(New Object() {"Para Maestros", "Cuadros ***", "Alumnos Por M/F ***", "Promedio Por Grado ***", "Calificaciones"})
        Me.TipoCombo.Location = New System.Drawing.Point(505, 3)
        Me.TipoCombo.Name = "TipoCombo"
        Me.TipoCombo.Size = New System.Drawing.Size(176, 24)
        Me.TipoCombo.TabIndex = 262
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.Location = New System.Drawing.Point(467, 0)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(32, 16)
        Me.TipoL.TabIndex = 262
        Me.TipoL.Text = "Tipo"
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(31, 16)
        Me.AñoL.TabIndex = 258
        Me.AñoL.Text = "Año"
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.Location = New System.Drawing.Point(112, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(43, 16)
        Me.GradoL.TabIndex = 0
        Me.GradoL.Text = "Grado"
        '
        'CicloCombo
        '
        Me.CicloCombo.FormattingEnabled = True
        Me.CicloCombo.Location = New System.Drawing.Point(351, 3)
        Me.CicloCombo.Name = "CicloCombo"
        Me.CicloCombo.Size = New System.Drawing.Size(90, 24)
        Me.CicloCombo.TabIndex = 1
        '
        'CicloL
        '
        Me.CicloL.AutoSize = True
        Me.CicloL.Location = New System.Drawing.Point(308, 0)
        Me.CicloL.Name = "CicloL"
        Me.CicloL.Size = New System.Drawing.Size(37, 16)
        Me.CicloL.TabIndex = 2
        Me.CicloL.Text = "Ciclo"
        '
        'GradoCombo
        '
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(161, 3)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(121, 24)
        Me.GradoCombo.TabIndex = 4
        '
        'ListadoButton
        '
        Me.ListadoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoButton.BackColor = System.Drawing.Color.SandyBrown
        Me.ListadoButton.Location = New System.Drawing.Point(707, 3)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(100, 23)
        Me.ListadoButton.TabIndex = 259
        Me.ListadoButton.Text = "Ver Listado"
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(40, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(46, 22)
        Me.AñoV.TabIndex = 260
        '
        'nAlumnosL
        '
        Me.nAlumnosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nAlumnosL.AutoSize = True
        Me.nAlumnosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAlumnosL.Location = New System.Drawing.Point(813, 0)
        Me.nAlumnosL.Name = "nAlumnosL"
        Me.nAlumnosL.Size = New System.Drawing.Size(118, 34)
        Me.nAlumnosL.TabIndex = 261
        Me.nAlumnosL.Text = "-"
        Me.nAlumnosL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nAlumnosL.Visible = False
        '
        'ReportesPRIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.DatosTable)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReportesPRIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Notas PRIMARIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TipoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents CicloCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CicloL As System.Windows.Forms.Label
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents nAlumnosL As System.Windows.Forms.Label
End Class
