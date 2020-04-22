<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsistenciaENE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsistenciaENE))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.nAlumnosL = New System.Windows.Forms.Label()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.SemanaCombo = New System.Windows.Forms.ComboBox()
        Me.ClaseL = New System.Windows.Forms.Label()
        Me.GradoCombo = New System.Windows.Forms.ComboBox()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.diasL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.ListadoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.AlumnoSelL = New System.Windows.Forms.Label()
        Me.AlumnoSelV = New System.Windows.Forms.Label()
        Me.AsistenciasL = New System.Windows.Forms.Label()
        Me.AsistenciasV = New System.Windows.Forms.TextBox()
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.DatosTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListadoTable.SuspendLayout()
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
        Me.bannerPanel.TabIndex = 258
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
        Me.Title.Text = "Asistencia a Escuela ENE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.OldLace
        Me.DatosTable.ColumnCount = 11
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable.Controls.Add(Me.nAlumnosL, 9, 0)
        Me.DatosTable.Controls.Add(Me.AñoL, 0, 0)
        Me.DatosTable.Controls.Add(Me.GradoL, 3, 0)
        Me.DatosTable.Controls.Add(Me.SemanaCombo, 7, 0)
        Me.DatosTable.Controls.Add(Me.ClaseL, 6, 0)
        Me.DatosTable.Controls.Add(Me.GradoCombo, 4, 0)
        Me.DatosTable.Controls.Add(Me.ListadoButton, 8, 0)
        Me.DatosTable.Controls.Add(Me.AñoV, 1, 0)
        Me.DatosTable.Controls.Add(Me.diasL, 10, 0)
        Me.DatosTable.Location = New System.Drawing.Point(0, 110)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 1
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DatosTable.Size = New System.Drawing.Size(934, 39)
        Me.DatosTable.TabIndex = 265
        '
        'nAlumnosL
        '
        Me.nAlumnosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nAlumnosL.AutoSize = True
        Me.nAlumnosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nAlumnosL.Location = New System.Drawing.Point(754, 0)
        Me.nAlumnosL.Name = "nAlumnosL"
        Me.nAlumnosL.Size = New System.Drawing.Size(17, 39)
        Me.nAlumnosL.TabIndex = 267
        Me.nAlumnosL.Text = "-"
        Me.nAlumnosL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nAlumnosL.Visible = False
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(45, 23)
        Me.AñoL.TabIndex = 258
        Me.AñoL.Text = "Año"
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.Location = New System.Drawing.Point(126, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(66, 23)
        Me.GradoL.TabIndex = 0
        Me.GradoL.Text = "Grado"
        '
        'SemanaCombo
        '
        Me.SemanaCombo.FormattingEnabled = True
        Me.SemanaCombo.Location = New System.Drawing.Point(433, 3)
        Me.SemanaCombo.Name = "SemanaCombo"
        Me.SemanaCombo.Size = New System.Drawing.Size(210, 31)
        Me.SemanaCombo.TabIndex = 258
        '
        'ClaseL
        '
        Me.ClaseL.AutoSize = True
        Me.ClaseL.Location = New System.Drawing.Point(345, 0)
        Me.ClaseL.Name = "ClaseL"
        Me.ClaseL.Size = New System.Drawing.Size(82, 23)
        Me.ClaseL.TabIndex = 3
        Me.ClaseL.Text = "Semana"
        '
        'GradoCombo
        '
        Me.GradoCombo.FormattingEnabled = True
        Me.GradoCombo.Location = New System.Drawing.Point(198, 3)
        Me.GradoCombo.Name = "GradoCombo"
        Me.GradoCombo.Size = New System.Drawing.Size(121, 31)
        Me.GradoCombo.TabIndex = 4
        '
        'ListadoButton
        '
        Me.ListadoButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoButton.BackColor = System.Drawing.Color.SandyBrown
        Me.ListadoButton.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoButton.Location = New System.Drawing.Point(649, 3)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(99, 33)
        Me.ListadoButton.TabIndex = 259
        Me.ListadoButton.Text = "Ingresar Asistencia"
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(54, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.ReadOnly = True
        Me.AñoV.Size = New System.Drawing.Size(46, 30)
        Me.AñoV.TabIndex = 260
        '
        'diasL
        '
        Me.diasL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diasL.AutoSize = True
        Me.diasL.Location = New System.Drawing.Point(777, 0)
        Me.diasL.Name = "diasL"
        Me.diasL.Size = New System.Drawing.Size(154, 39)
        Me.diasL.TabIndex = 268
        Me.diasL.Text = "0"
        Me.diasL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.diasL.Visible = False
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoTable.SetRowSpan(Me.ListadoGrid, 6)
        Me.ListadoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListadoGrid.Size = New System.Drawing.Size(748, 550)
        Me.ListadoGrid.TabIndex = 266
        Me.ListadoGrid.Visible = False
        '
        'ListadoTable
        '
        Me.ListadoTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoTable.BackColor = System.Drawing.Color.Transparent
        Me.ListadoTable.ColumnCount = 3
        Me.ListadoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ListadoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ListadoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.ListadoTable.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.ListadoTable.Controls.Add(Me.AlumnoSelL, 2, 0)
        Me.ListadoTable.Controls.Add(Me.AlumnoSelV, 2, 1)
        Me.ListadoTable.Controls.Add(Me.AsistenciasL, 2, 3)
        Me.ListadoTable.Controls.Add(Me.AsistenciasV, 2, 4)
        Me.ListadoTable.Controls.Add(Me.ActualizarButton, 2, 5)
        Me.ListadoTable.Location = New System.Drawing.Point(0, 155)
        Me.ListadoTable.Name = "ListadoTable"
        Me.ListadoTable.RowCount = 6
        Me.ListadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ListadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ListadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ListadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ListadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ListadoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ListadoTable.Size = New System.Drawing.Size(934, 556)
        Me.ListadoTable.TabIndex = 267
        '
        'AlumnoSelL
        '
        Me.AlumnoSelL.AutoSize = True
        Me.AlumnoSelL.Location = New System.Drawing.Point(787, 0)
        Me.AlumnoSelL.Name = "AlumnoSelL"
        Me.AlumnoSelL.Size = New System.Drawing.Size(133, 46)
        Me.AlumnoSelL.TabIndex = 267
        Me.AlumnoSelL.Text = "Alumno Seleccionado:"
        Me.AlumnoSelL.Visible = False
        '
        'AlumnoSelV
        '
        Me.AlumnoSelV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlumnoSelV.AutoSize = True
        Me.AlumnoSelV.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlumnoSelV.Location = New System.Drawing.Point(787, 46)
        Me.AlumnoSelV.Name = "AlumnoSelV"
        Me.AlumnoSelV.Size = New System.Drawing.Size(144, 24)
        Me.AlumnoSelV.TabIndex = 268
        Me.AlumnoSelV.Text = "-"
        Me.AlumnoSelV.Visible = False
        '
        'AsistenciasL
        '
        Me.AsistenciasL.AutoSize = True
        Me.AsistenciasL.Location = New System.Drawing.Point(787, 90)
        Me.AsistenciasL.Name = "AsistenciasL"
        Me.AsistenciasL.Size = New System.Drawing.Size(115, 23)
        Me.AsistenciasL.TabIndex = 269
        Me.AsistenciasL.Text = "Asistencias:"
        Me.AsistenciasL.Visible = False
        '
        'AsistenciasV
        '
        Me.AsistenciasV.Location = New System.Drawing.Point(787, 116)
        Me.AsistenciasV.Name = "AsistenciasV"
        Me.AsistenciasV.Size = New System.Drawing.Size(44, 30)
        Me.AsistenciasV.TabIndex = 270
        Me.AsistenciasV.Visible = False
        '
        'ActualizarButton
        '
        Me.ActualizarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarButton.Location = New System.Drawing.Point(787, 152)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.ActualizarButton.Size = New System.Drawing.Size(144, 60)
        Me.ActualizarButton.TabIndex = 271
        Me.ActualizarButton.Text = "Actualizar Asistencia"
        Me.ActualizarButton.UseVisualStyleBackColor = True
        Me.ActualizarButton.Visible = False
        '
        'AsistenciaENE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.ListadoTable)
        Me.Controls.Add(Me.DatosTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AsistenciaENE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia a Escuela"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListadoTable.ResumeLayout(False)
        Me.ListadoTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nAlumnosL As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents SemanaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ClaseL As System.Windows.Forms.Label
    Friend WithEvents GradoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents diasL As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ListadoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AlumnoSelL As System.Windows.Forms.Label
    Friend WithEvents AlumnoSelV As System.Windows.Forms.Label
    Friend WithEvents AsistenciasL As System.Windows.Forms.Label
    Friend WithEvents AsistenciasV As System.Windows.Forms.TextBox
    Friend WithEvents ActualizarButton As System.Windows.Forms.Button
End Class
