<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesAsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportesAsistencia))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.CatCodL = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.CategoriaCombo = New System.Windows.Forms.ComboBox()
        Me.CategoriaL = New System.Windows.Forms.Label()
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
        Me.bannerPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(934, 133)
        Me.bannerPanel.TabIndex = 258
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
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(110, 76)
        Me.opcionesTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(822, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(771, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 47)
        Me.GuardarButton.TabIndex = 69
        Me.GuardarButton.UseVisualStyleBackColor = False
        Me.GuardarButton.Visible = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(708, 4)
        Me.NuevoButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(57, 45)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(650, 4)
        Me.inicioButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(52, 45)
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
        Me.Title.Location = New System.Drawing.Point(5, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(637, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Reportes Ambiente Seguro - Escuela NE"
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
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 176)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoGrid.Size = New System.Drawing.Size(934, 592)
        Me.ListadoGrid.TabIndex = 263
        Me.ListadoGrid.Visible = False
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.OldLace
        Me.DatosTable.ColumnCount = 11
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 423.0!))
        Me.DatosTable.Controls.Add(Me.CategoriaL, 6, 0)
        Me.DatosTable.Controls.Add(Me.CategoriaCombo, 7, 0)
        Me.DatosTable.Controls.Add(Me.CatCodL, 10, 0)
        Me.DatosTable.Controls.Add(Me.AñoL, 0, 0)
        Me.DatosTable.Controls.Add(Me.GradoL, 3, 0)
        Me.DatosTable.Controls.Add(Me.GradoCombo, 4, 0)
        Me.DatosTable.Controls.Add(Me.AñoV, 1, 0)
        Me.DatosTable.Controls.Add(Me.ListadoButton, 9, 0)
        Me.DatosTable.Location = New System.Drawing.Point(0, 137)
        Me.DatosTable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 1
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.Size = New System.Drawing.Size(934, 37)
        Me.DatosTable.TabIndex = 266
        '
        'CatCodL
        '
        Me.CatCodL.AutoSize = True
        Me.CatCodL.Location = New System.Drawing.Point(872, 0)
        Me.CatCodL.Name = "CatCodL"
        Me.CatCodL.Size = New System.Drawing.Size(15, 16)
        Me.CatCodL.TabIndex = 269
        Me.CatCodL.Text = "0"
        Me.CatCodL.Visible = False
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
        Me.GradoL.Location = New System.Drawing.Point(122, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(43, 16)
        Me.GradoL.TabIndex = 0
        Me.GradoL.Text = "Grado"
        '
        'GradoCombo
        '
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(171, 4)
        Me.GradoCombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(140, 24)
        Me.GradoCombo.TabIndex = 4
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(40, 4)
        Me.AñoV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(53, 22)
        Me.AñoV.TabIndex = 260
        '
        'ListadoButton
        '
        Me.ListadoButton.BackColor = System.Drawing.Color.SandyBrown
        Me.ListadoButton.Location = New System.Drawing.Point(686, 4)
        Me.ListadoButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(180, 28)
        Me.ListadoButton.TabIndex = 259
        Me.ListadoButton.Text = "Ver Listado"
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'CategoriaCombo
        '
        Me.CategoriaCombo.FormattingEnabled = True
        Me.CategoriaCombo.Location = New System.Drawing.Point(414, 4)
        Me.CategoriaCombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoriaCombo.Name = "CategoriaCombo"
        Me.CategoriaCombo.Size = New System.Drawing.Size(243, 24)
        Me.CategoriaCombo.TabIndex = 272
        '
        'CategoriaL
        '
        Me.CategoriaL.AutoSize = True
        Me.CategoriaL.Location = New System.Drawing.Point(340, 0)
        Me.CategoriaL.Name = "CategoriaL"
        Me.CategoriaL.Size = New System.Drawing.Size(68, 16)
        Me.CategoriaL.TabIndex = 267
        Me.CategoriaL.Text = "*Categoria"
        '
        'ReportesAmbienteSeg
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
        Me.Name = "ReportesAmbienteSeg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes Ambiente Seguro"
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
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CatCodL As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents CategoriaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriaL As System.Windows.Forms.Label
End Class
