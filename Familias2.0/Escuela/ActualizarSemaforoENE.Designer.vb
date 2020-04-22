<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarSemaforoENE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarSemaforoENE))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UnidadCombo = New System.Windows.Forms.ComboBox()
        Me.Table1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.White
        Me.bannerPanel.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(976, 98)
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
        Me.opcionesTable.Location = New System.Drawing.Point(131, 43)
        Me.opcionesTable.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(845, 50)
        Me.opcionesTable.TabIndex = 68
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(792, 4)
        Me.GuardarButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(50, 42)
        Me.GuardarButton.TabIndex = 69
        Me.GuardarButton.UseVisualStyleBackColor = False
        Me.GuardarButton.Visible = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(736, 5)
        Me.NuevoButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(50, 40)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(680, 5)
        Me.inicioButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(50, 40)
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
        Me.Title.Location = New System.Drawing.Point(6, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(665, 50)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Actualizar Semáforos - Escuela NE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.GridColor = System.Drawing.Color.White
        Me.ListadoGrid.Location = New System.Drawing.Point(1, 149)
        Me.ListadoGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersVisible = False
        Me.ListadoGrid.RowHeadersWidth = 38
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(973, 571)
        Me.ListadoGrid.TabIndex = 260
        Me.ListadoGrid.Visible = False
        '
        'GenerarButton
        '
        Me.GenerarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GenerarButton.Location = New System.Drawing.Point(530, 4)
        Me.GenerarButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(87, 37)
        Me.GenerarButton.TabIndex = 3
        Me.GenerarButton.Text = "Ver Listado"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ciclo:"
        '
        'UnidadCombo
        '
        Me.UnidadCombo.FormattingEnabled = True
        Me.UnidadCombo.Location = New System.Drawing.Point(448, 4)
        Me.UnidadCombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UnidadCombo.Name = "UnidadCombo"
        Me.UnidadCombo.Size = New System.Drawing.Size(76, 31)
        Me.UnidadCombo.TabIndex = 1
        '
        'Table1
        '
        Me.Table1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table1.BackColor = System.Drawing.Color.AliceBlue
        Me.Table1.ColumnCount = 11
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table1.Controls.Add(Me.TotalL, 10, 0)
        Me.Table1.Controls.Add(Me.GradoL, 3, 0)
        Me.Table1.Controls.Add(Me.GradoCombo, 4, 0)
        Me.Table1.Controls.Add(Me.GenerarButton, 8, 0)
        Me.Table1.Controls.Add(Me.UnidadCombo, 7, 0)
        Me.Table1.Controls.Add(Me.Label1, 6, 0)
        Me.Table1.Controls.Add(Me.AñoL, 0, 0)
        Me.Table1.Controls.Add(Me.AñoV, 1, 0)
        Me.Table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Table1.Location = New System.Drawing.Point(0, 100)
        Me.Table1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Table1.Name = "Table1"
        Me.Table1.RowCount = 1
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table1.Size = New System.Drawing.Size(976, 45)
        Me.Table1.TabIndex = 261
        '
        'TotalL
        '
        Me.TotalL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Transparent
        Me.TotalL.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.ForeColor = System.Drawing.Color.Blue
        Me.TotalL.Location = New System.Drawing.Point(623, 0)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(350, 45)
        Me.TotalL.TabIndex = 262
        Me.TotalL.Text = "Total"
        Me.TotalL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TotalL.Visible = False
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.ForeColor = System.Drawing.Color.Blue
        Me.GradoL.Location = New System.Drawing.Point(143, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(72, 23)
        Me.GradoL.TabIndex = 69
        Me.GradoL.Text = "Grado:"
        '
        'GradoCombo
        '
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(221, 4)
        Me.GradoCombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(133, 31)
        Me.GradoCombo.TabIndex = 69
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(51, 23)
        Me.AñoL.TabIndex = 6
        Me.AñoL.Text = "Año:"
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(60, 4)
        Me.AñoV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(54, 30)
        Me.AñoV.TabIndex = 7
        Me.AñoV.Text = "2019"
        '
        'ActualizarSemaforoENE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(976, 749)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActualizarSemaforoENE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActualizarSemaforoENE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1.ResumeLayout(False)
        Me.Table1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UnidadCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Table1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
End Class
