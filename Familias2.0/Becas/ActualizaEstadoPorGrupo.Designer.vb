<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizaEstadoPorGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizaEstadoPorGrupo))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SeleccionarCheck = New System.Windows.Forms.CheckBox()
        Me.EscuelaCombo = New System.Windows.Forms.ComboBox()
        Me.EscuelaL = New System.Windows.Forms.Label()
        Me.nEstadoCombo = New System.Windows.Forms.ComboBox()
        Me.nEstadoL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.SeccionV = New System.Windows.Forms.TextBox()
        Me.SeccionL = New System.Windows.Forms.Label()
        Me.EstadoCombo = New System.Windows.Forms.ComboBox()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bannerPanel.TabIndex = 261
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
        Me.opcionesTable.Controls.Add(Me.BuscarButton, 4, 0)
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
        'BuscarButton
        '
        Me.BuscarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.BuscarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.searchFam
        Me.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BuscarButton.Location = New System.Drawing.Point(837, 3)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(48, 45)
        Me.BuscarButton.TabIndex = 69
        Me.BuscarButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(728, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(677, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(783, 3)
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
        Me.Title.Size = New System.Drawing.Size(666, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Actualizar Estado Educativo por Grupo"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionarCheck, 11, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EscuelaCombo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EscuelaL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nEstadoCombo, 10, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nEstadoL, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GradoCombo, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GradoL, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoV, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SeccionV, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SeccionL, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoCombo, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoL, 9, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(984, 70)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SeleccionarCheck
        '
        Me.SeleccionarCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeleccionarCheck.AutoSize = True
        Me.SeleccionarCheck.BackColor = System.Drawing.Color.Transparent
        Me.SeleccionarCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionarCheck.ForeColor = System.Drawing.Color.DodgerBlue
        Me.SeleccionarCheck.Location = New System.Drawing.Point(951, 3)
        Me.SeleccionarCheck.Name = "SeleccionarCheck"
        Me.TableLayoutPanel1.SetRowSpan(Me.SeleccionarCheck, 2)
        Me.SeleccionarCheck.Size = New System.Drawing.Size(30, 64)
        Me.SeleccionarCheck.TabIndex = 76
        Me.SeleccionarCheck.Text = "Seleccionar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "todos"
        Me.SeleccionarCheck.UseVisualStyleBackColor = False
        Me.SeleccionarCheck.Visible = False
        '
        'EscuelaCombo
        '
        Me.EscuelaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.EscuelaCombo, 7)
        Me.EscuelaCombo.FormattingEnabled = True
        Me.EscuelaCombo.Location = New System.Drawing.Point(73, 31)
        Me.EscuelaCombo.Name = "EscuelaCombo"
        Me.EscuelaCombo.Size = New System.Drawing.Size(541, 24)
        Me.EscuelaCombo.TabIndex = 75
        '
        'EscuelaL
        '
        Me.EscuelaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EscuelaL.AutoSize = True
        Me.EscuelaL.Location = New System.Drawing.Point(3, 28)
        Me.EscuelaL.Name = "EscuelaL"
        Me.EscuelaL.Size = New System.Drawing.Size(64, 16)
        Me.EscuelaL.TabIndex = 74
        Me.EscuelaL.Text = "*Escuela:"
        Me.EscuelaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nEstadoCombo
        '
        Me.nEstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nEstadoCombo.BackColor = System.Drawing.SystemColors.Window
        Me.nEstadoCombo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nEstadoCombo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.nEstadoCombo.FormattingEnabled = True
        Me.nEstadoCombo.Location = New System.Drawing.Point(711, 31)
        Me.nEstadoCombo.Name = "nEstadoCombo"
        Me.nEstadoCombo.Size = New System.Drawing.Size(234, 25)
        Me.nEstadoCombo.TabIndex = 74
        Me.nEstadoCombo.Visible = False
        '
        'nEstadoL
        '
        Me.nEstadoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nEstadoL.AutoSize = True
        Me.nEstadoL.BackColor = System.Drawing.Color.DodgerBlue
        Me.nEstadoL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nEstadoL.ForeColor = System.Drawing.Color.White
        Me.nEstadoL.Location = New System.Drawing.Point(640, 28)
        Me.nEstadoL.Name = "nEstadoL"
        Me.nEstadoL.Size = New System.Drawing.Size(65, 42)
        Me.nEstadoL.TabIndex = 75
        Me.nEstadoL.Text = "*Nuevo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Estado:"
        Me.nEstadoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nEstadoL.Visible = False
        '
        'GradoCombo
        '
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(207, 3)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(236, 24)
        Me.GradoCombo.TabIndex = 1
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.Location = New System.Drawing.Point(149, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(52, 16)
        Me.GradoL.TabIndex = 0
        Me.GradoL.Text = "*Grado:"
        Me.GradoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(64, 16)
        Me.AñoL.TabIndex = 70
        Me.AñoL.Text = "*Año:"
        Me.AñoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(73, 3)
        Me.AñoV.MaxLength = 10
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(50, 22)
        Me.AñoV.TabIndex = 71
        '
        'SeccionV
        '
        Me.SeccionV.Location = New System.Drawing.Point(534, 3)
        Me.SeccionV.MaxLength = 10
        Me.SeccionV.Name = "SeccionV"
        Me.SeccionV.Size = New System.Drawing.Size(26, 22)
        Me.SeccionV.TabIndex = 72
        Me.SeccionV.Visible = False
        '
        'SeccionL
        '
        Me.SeccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeccionL.AutoSize = True
        Me.SeccionL.Location = New System.Drawing.Point(469, 0)
        Me.SeccionL.Name = "SeccionL"
        Me.SeccionL.Size = New System.Drawing.Size(59, 16)
        Me.SeccionL.TabIndex = 71
        Me.SeccionL.Text = "Sección:"
        Me.SeccionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.SeccionL.Visible = False
        '
        'EstadoCombo
        '
        Me.EstadoCombo.FormattingEnabled = True
        Me.EstadoCombo.Location = New System.Drawing.Point(711, 3)
        Me.EstadoCombo.Name = "EstadoCombo"
        Me.EstadoCombo.Size = New System.Drawing.Size(182, 24)
        Me.EstadoCombo.TabIndex = 73
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Location = New System.Drawing.Point(640, 0)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(65, 16)
        Me.EstadoL.TabIndex = 72
        Me.EstadoL.Text = "Estado:"
        Me.EstadoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion})
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 196)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 55
        Me.ListadoGrid.Size = New System.Drawing.Size(984, 454)
        Me.ListadoGrid.TabIndex = 262
        Me.ListadoGrid.Visible = False
        '
        'Accion
        '
        Me.Accion.HeaderText = "Seleccionar"
        Me.Accion.Name = "Accion"
        '
        'ActualizaEstadoPorGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActualizaEstadoPorGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Estado Educativo Por Grupo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents EstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents EscuelaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EscuelaL As System.Windows.Forms.Label
    Friend WithEvents nEstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents nEstadoL As System.Windows.Forms.Label
    Friend WithEvents SeleccionarCheck As System.Windows.Forms.CheckBox
    Friend WithEvents BuscarButton As System.Windows.Forms.Button
    Friend WithEvents SeccionL As System.Windows.Forms.Label
    Friend WithEvents SeccionV As System.Windows.Forms.TextBox
End Class
