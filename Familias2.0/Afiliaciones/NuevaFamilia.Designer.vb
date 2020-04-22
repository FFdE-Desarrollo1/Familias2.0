<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaFamilia))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.Label()
        Me.NuevaFamButton = New System.Windows.Forms.Button()
        Me.EtniaL = New System.Windows.Forms.Label()
        Me.EtniaCombo = New System.Windows.Forms.ComboBox()
        Me.TelefonoV = New System.Windows.Forms.TextBox()
        Me.DireccionL = New System.Windows.Forms.Label()
        Me.DireccionV = New System.Windows.Forms.TextBox()
        Me.AreaL = New System.Windows.Forms.Label()
        Me.AreaCombo = New System.Windows.Forms.ComboBox()
        Me.TelefonoL = New System.Windows.Forms.Label()
        Me.MunicipioL = New System.Windows.Forms.Label()
        Me.MunicipioCombo = New System.Windows.Forms.ComboBox()
        Me.familiaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PuebloL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.TiempoV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MiembrosButton = New System.Windows.Forms.Button()
        Me.FamiliasGrid = New System.Windows.Forms.DataGridView()
        Me.FamiliasL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.familiaTable.SuspendLayout()
        CType(Me.FamiliasGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bannerPanel.TabIndex = 259
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
        Me.NuevoButton.Location = New System.Drawing.Point(732, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(681, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 43)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(787, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 43)
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
        Me.Title.Size = New System.Drawing.Size(670, 49)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Ingresar Nueva Familia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FamiliaV
        '
        Me.FamiliaV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaV.AutoSize = True
        Me.FamiliaV.BackColor = System.Drawing.Color.Transparent
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.Location = New System.Drawing.Point(212, 0)
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(344, 20)
        Me.FamiliaV.TabIndex = 263
        Me.FamiliaV.Text = "-"
        Me.FamiliaV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FamiliaV.Visible = False
        '
        'NuevaFamButton
        '
        Me.NuevaFamButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevaFamButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaFamButton.Location = New System.Drawing.Point(212, 197)
        Me.NuevaFamButton.Name = "NuevaFamButton"
        Me.NuevaFamButton.Size = New System.Drawing.Size(344, 24)
        Me.NuevaFamButton.TabIndex = 264
        Me.NuevaFamButton.Text = "Crear Nueva Familia"
        Me.NuevaFamButton.UseVisualStyleBackColor = True
        '
        'EtniaL
        '
        Me.EtniaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EtniaL.AutoSize = True
        Me.EtniaL.Location = New System.Drawing.Point(3, 78)
        Me.EtniaL.Name = "EtniaL"
        Me.EtniaL.Size = New System.Drawing.Size(203, 16)
        Me.EtniaL.TabIndex = 262
        Me.EtniaL.Text = "*Etnia:"
        '
        'EtniaCombo
        '
        Me.EtniaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EtniaCombo.FormattingEnabled = True
        Me.EtniaCombo.Location = New System.Drawing.Point(212, 81)
        Me.EtniaCombo.Name = "EtniaCombo"
        Me.EtniaCombo.Size = New System.Drawing.Size(344, 24)
        Me.EtniaCombo.TabIndex = 261
        '
        'TelefonoV
        '
        Me.TelefonoV.Location = New System.Drawing.Point(212, 111)
        Me.TelefonoV.Name = "TelefonoV"
        Me.TelefonoV.Size = New System.Drawing.Size(84, 22)
        Me.TelefonoV.TabIndex = 261
        '
        'DireccionL
        '
        Me.DireccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DireccionL.AutoSize = True
        Me.DireccionL.Location = New System.Drawing.Point(3, 20)
        Me.DireccionL.Name = "DireccionL"
        Me.DireccionL.Size = New System.Drawing.Size(203, 16)
        Me.DireccionL.TabIndex = 0
        Me.DireccionL.Text = "*Dirección:"
        '
        'DireccionV
        '
        Me.DireccionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.familiaTable.SetColumnSpan(Me.DireccionV, 2)
        Me.DireccionV.Location = New System.Drawing.Point(212, 23)
        Me.DireccionV.Name = "DireccionV"
        Me.DireccionV.Size = New System.Drawing.Size(713, 22)
        Me.DireccionV.TabIndex = 1
        '
        'AreaL
        '
        Me.AreaL.AutoSize = True
        Me.AreaL.Location = New System.Drawing.Point(3, 48)
        Me.AreaL.Name = "AreaL"
        Me.AreaL.Size = New System.Drawing.Size(44, 16)
        Me.AreaL.TabIndex = 2
        Me.AreaL.Text = "*Area:"
        '
        'AreaCombo
        '
        Me.AreaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AreaCombo.FormattingEnabled = True
        Me.AreaCombo.Location = New System.Drawing.Point(212, 51)
        Me.AreaCombo.Name = "AreaCombo"
        Me.AreaCombo.Size = New System.Drawing.Size(344, 24)
        Me.AreaCombo.TabIndex = 3
        '
        'TelefonoL
        '
        Me.TelefonoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefonoL.AutoSize = True
        Me.TelefonoL.Location = New System.Drawing.Point(3, 108)
        Me.TelefonoL.Name = "TelefonoL"
        Me.TelefonoL.Size = New System.Drawing.Size(203, 16)
        Me.TelefonoL.TabIndex = 261
        Me.TelefonoL.Text = "Teléfono:"
        '
        'MunicipioL
        '
        Me.MunicipioL.AutoSize = True
        Me.MunicipioL.Location = New System.Drawing.Point(3, 136)
        Me.MunicipioL.Name = "MunicipioL"
        Me.MunicipioL.Size = New System.Drawing.Size(67, 16)
        Me.MunicipioL.TabIndex = 273
        Me.MunicipioL.Text = "Municipio:"
        Me.MunicipioL.Visible = False
        '
        'MunicipioCombo
        '
        Me.MunicipioCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MunicipioCombo.FormattingEnabled = True
        Me.MunicipioCombo.Location = New System.Drawing.Point(212, 139)
        Me.MunicipioCombo.Name = "MunicipioCombo"
        Me.MunicipioCombo.Size = New System.Drawing.Size(344, 24)
        Me.MunicipioCombo.TabIndex = 272
        Me.MunicipioCombo.Visible = False
        '
        'familiaTable
        '
        Me.familiaTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.familiaTable.BackColor = System.Drawing.Color.LightBlue
        Me.familiaTable.ColumnCount = 3
        Me.familiaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.familiaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.familiaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.familiaTable.Controls.Add(Me.DireccionL, 0, 1)
        Me.familiaTable.Controls.Add(Me.AreaL, 0, 2)
        Me.familiaTable.Controls.Add(Me.DireccionV, 1, 1)
        Me.familiaTable.Controls.Add(Me.AreaCombo, 1, 2)
        Me.familiaTable.Controls.Add(Me.PuebloL, 2, 2)
        Me.familiaTable.Controls.Add(Me.FamiliaV, 1, 0)
        Me.familiaTable.Controls.Add(Me.FamiliaL, 0, 0)
        Me.familiaTable.Controls.Add(Me.TiempoV, 1, 6)
        Me.familiaTable.Controls.Add(Me.EtniaCombo, 1, 3)
        Me.familiaTable.Controls.Add(Me.Label1, 0, 6)
        Me.familiaTable.Controls.Add(Me.MunicipioL, 0, 5)
        Me.familiaTable.Controls.Add(Me.EtniaL, 0, 3)
        Me.familiaTable.Controls.Add(Me.TelefonoL, 0, 4)
        Me.familiaTable.Controls.Add(Me.MunicipioCombo, 1, 5)
        Me.familiaTable.Controls.Add(Me.TelefonoV, 1, 4)
        Me.familiaTable.Controls.Add(Me.MiembrosButton, 1, 9)
        Me.familiaTable.Controls.Add(Me.NuevaFamButton, 1, 8)
        Me.familiaTable.Location = New System.Drawing.Point(0, 107)
        Me.familiaTable.Name = "familiaTable"
        Me.familiaTable.RowCount = 10
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.familiaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.familiaTable.Size = New System.Drawing.Size(928, 263)
        Me.familiaTable.TabIndex = 0
        '
        'PuebloL
        '
        Me.PuebloL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PuebloL.AutoSize = True
        Me.PuebloL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PuebloL.Location = New System.Drawing.Point(562, 48)
        Me.PuebloL.Name = "PuebloL"
        Me.PuebloL.Size = New System.Drawing.Size(363, 30)
        Me.PuebloL.TabIndex = 275
        Me.PuebloL.Text = "-"
        Me.PuebloL.Visible = False
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(78, 16)
        Me.FamiliaL.TabIndex = 276
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.Visible = False
        '
        'TiempoV
        '
        Me.TiempoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiempoV.Location = New System.Drawing.Point(212, 169)
        Me.TiempoV.Name = "TiempoV"
        Me.TiempoV.Size = New System.Drawing.Size(344, 22)
        Me.TiempoV.TabIndex = 274
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 28)
        Me.Label1.TabIndex = 274
        Me.Label1.Text = "Tiempo de vivir en el mismo lugar:"
        '
        'MiembrosButton
        '
        Me.MiembrosButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembrosButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembrosButton.Location = New System.Drawing.Point(212, 227)
        Me.MiembrosButton.Name = "MiembrosButton"
        Me.MiembrosButton.Size = New System.Drawing.Size(344, 28)
        Me.MiembrosButton.TabIndex = 277
        Me.MiembrosButton.Text = "Agregar miembros de la familia"
        Me.MiembrosButton.UseVisualStyleBackColor = True
        Me.MiembrosButton.Visible = False
        '
        'FamiliasGrid
        '
        Me.FamiliasGrid.AllowUserToAddRows = False
        Me.FamiliasGrid.AllowUserToDeleteRows = False
        Me.FamiliasGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliasGrid.BackgroundColor = System.Drawing.Color.White
        Me.FamiliasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliasGrid.Location = New System.Drawing.Point(6, 419)
        Me.FamiliasGrid.Name = "FamiliasGrid"
        Me.FamiliasGrid.ReadOnly = True
        Me.FamiliasGrid.Size = New System.Drawing.Size(923, 318)
        Me.FamiliasGrid.TabIndex = 260
        Me.FamiliasGrid.Visible = False
        '
        'FamiliasL
        '
        Me.FamiliasL.AutoSize = True
        Me.FamiliasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliasL.Location = New System.Drawing.Point(3, 400)
        Me.FamiliasL.Name = "FamiliasL"
        Me.FamiliasL.Size = New System.Drawing.Size(151, 16)
        Me.FamiliasL.TabIndex = 261
        Me.FamiliasL.Text = "Familias sin miembros"
        Me.FamiliasL.Visible = False
        '
        'NuevaFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.FamiliasL)
        Me.Controls.Add(Me.FamiliasGrid)
        Me.Controls.Add(Me.familiaTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NuevaFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Familia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.familiaTable.ResumeLayout(False)
        Me.familiaTable.PerformLayout()
        CType(Me.FamiliasGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents EtniaL As System.Windows.Forms.Label
    Friend WithEvents EtniaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TelefonoV As System.Windows.Forms.TextBox
    Friend WithEvents DireccionL As System.Windows.Forms.Label
    Friend WithEvents DireccionV As System.Windows.Forms.TextBox
    Friend WithEvents AreaL As System.Windows.Forms.Label
    Friend WithEvents AreaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TelefonoL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.Label
    Friend WithEvents NuevaFamButton As System.Windows.Forms.Button
    Friend WithEvents MunicipioCombo As System.Windows.Forms.ComboBox
    Friend WithEvents MunicipioL As System.Windows.Forms.Label
    Friend WithEvents familiaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TiempoV As System.Windows.Forms.TextBox
    Friend WithEvents PuebloL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents MiembrosButton As System.Windows.Forms.Button
    Friend WithEvents FamiliasGrid As System.Windows.Forms.DataGridView
    Friend WithEvents FamiliasL As System.Windows.Forms.Label
End Class
