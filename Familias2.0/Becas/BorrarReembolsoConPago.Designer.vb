<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrarReembolsoConPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrarReembolsoConPago))
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.AllCheck = New System.Windows.Forms.CheckBox()
        Me.GradoV = New System.Windows.Forms.ComboBox()
        Me.CarreraL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.FechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.EscuelaL = New System.Windows.Forms.Label()
        Me.EscuelaV = New System.Windows.Forms.ComboBox()
        Me.CantidadV = New System.Windows.Forms.TextBox()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.TipoV = New System.Windows.Forms.ComboBox()
        Me.CantidadL = New System.Windows.Forms.Label()
        Me.fechaL = New System.Windows.Forms.Label()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.CarreraV = New System.Windows.Forms.ComboBox()
        Me.PrincipalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrincipalTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 82
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 191)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 55
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(784, 567)
        Me.ListadoGrid.TabIndex = 245
        '
        'AllCheck
        '
        Me.AllCheck.AutoSize = True
        Me.AllCheck.BackColor = System.Drawing.Color.Transparent
        Me.AllCheck.ForeColor = System.Drawing.Color.Black
        Me.AllCheck.Location = New System.Drawing.Point(3, 33)
        Me.AllCheck.Name = "AllCheck"
        Me.AllCheck.Size = New System.Drawing.Size(11, 20)
        Me.AllCheck.TabIndex = 202
        Me.AllCheck.Text = "Chequear todos"
        Me.AllCheck.UseVisualStyleBackColor = False
        Me.AllCheck.Visible = False
        '
        'GradoV
        '
        Me.GradoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.GradoV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GradoV.FormattingEnabled = True
        Me.GradoV.Location = New System.Drawing.Point(73, 33)
        Me.GradoV.Name = "GradoV"
        Me.GradoV.Size = New System.Drawing.Size(95, 24)
        Me.GradoV.TabIndex = 223
        '
        'CarreraL
        '
        Me.CarreraL.AutoSize = True
        Me.CarreraL.BackColor = System.Drawing.Color.Transparent
        Me.CarreraL.Location = New System.Drawing.Point(420, 30)
        Me.CarreraL.Name = "CarreraL"
        Me.CarreraL.Size = New System.Drawing.Size(54, 16)
        Me.CarreraL.TabIndex = 203
        Me.CarreraL.Text = "Carrera:"
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.BackColor = System.Drawing.Color.Transparent
        Me.GradoL.Location = New System.Drawing.Point(20, 30)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(47, 16)
        Me.GradoL.TabIndex = 224
        Me.GradoL.Text = "Grado:"
        '
        'FechaPicker
        '
        Me.FechaPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaPicker.Location = New System.Drawing.Point(480, 3)
        Me.FechaPicker.Name = "FechaPicker"
        Me.FechaPicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaPicker.TabIndex = 222
        '
        'EscuelaL
        '
        Me.EscuelaL.AutoSize = True
        Me.EscuelaL.BackColor = System.Drawing.Color.Transparent
        Me.EscuelaL.Location = New System.Drawing.Point(222, 30)
        Me.EscuelaL.Name = "EscuelaL"
        Me.EscuelaL.Size = New System.Drawing.Size(59, 16)
        Me.EscuelaL.TabIndex = 203
        Me.EscuelaL.Text = "Escuela:"
        '
        'EscuelaV
        '
        Me.EscuelaV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.EscuelaV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EscuelaV.FormattingEnabled = True
        Me.EscuelaV.Location = New System.Drawing.Point(296, 33)
        Me.EscuelaV.Name = "EscuelaV"
        Me.EscuelaV.Size = New System.Drawing.Size(75, 24)
        Me.EscuelaV.TabIndex = 202
        '
        'CantidadV
        '
        Me.CantidadV.Location = New System.Drawing.Point(296, 3)
        Me.CantidadV.Name = "CantidadV"
        Me.CantidadV.Size = New System.Drawing.Size(88, 22)
        Me.CantidadV.TabIndex = 219
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.BackColor = System.Drawing.Color.Transparent
        Me.TipoL.Location = New System.Drawing.Point(20, 0)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(41, 16)
        Me.TipoL.TabIndex = 220
        Me.TipoL.Text = "*Tipo:"
        '
        'TipoV
        '
        Me.TipoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TipoV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoV.FormattingEnabled = True
        Me.TipoV.Location = New System.Drawing.Point(73, 3)
        Me.TipoV.Name = "TipoV"
        Me.TipoV.Size = New System.Drawing.Size(113, 24)
        Me.TipoV.TabIndex = 218
        '
        'CantidadL
        '
        Me.CantidadL.AutoSize = True
        Me.CantidadL.BackColor = System.Drawing.Color.Transparent
        Me.CantidadL.Location = New System.Drawing.Point(222, 0)
        Me.CantidadL.Name = "CantidadL"
        Me.CantidadL.Size = New System.Drawing.Size(68, 16)
        Me.CantidadL.TabIndex = 221
        Me.CantidadL.Text = "*Cantidad:"
        '
        'fechaL
        '
        Me.fechaL.AutoSize = True
        Me.fechaL.BackColor = System.Drawing.Color.Transparent
        Me.fechaL.Location = New System.Drawing.Point(420, 0)
        Me.fechaL.Name = "fechaL"
        Me.fechaL.Size = New System.Drawing.Size(53, 16)
        Me.fechaL.TabIndex = 222
        Me.fechaL.Text = "*Fecha:"
        '
        'BuscarButton
        '
        Me.BuscarButton.Location = New System.Drawing.Point(706, 3)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarButton.TabIndex = 223
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'CarreraV
        '
        Me.CarreraV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CarreraV.FormattingEnabled = True
        Me.CarreraV.Location = New System.Drawing.Point(480, 33)
        Me.CarreraV.Name = "CarreraV"
        Me.CarreraV.Size = New System.Drawing.Size(200, 24)
        Me.CarreraV.TabIndex = 202
        '
        'PrincipalTable
        '
        Me.PrincipalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalTable.BackColor = System.Drawing.Color.AliceBlue
        Me.PrincipalTable.ColumnCount = 11
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.Controls.Add(Me.AllCheck, 0, 1)
        Me.PrincipalTable.Controls.Add(Me.GradoV, 2, 1)
        Me.PrincipalTable.Controls.Add(Me.CarreraL, 7, 1)
        Me.PrincipalTable.Controls.Add(Me.GradoL, 1, 1)
        Me.PrincipalTable.Controls.Add(Me.FechaPicker, 8, 0)
        Me.PrincipalTable.Controls.Add(Me.EscuelaL, 4, 1)
        Me.PrincipalTable.Controls.Add(Me.EscuelaV, 5, 1)
        Me.PrincipalTable.Controls.Add(Me.CantidadV, 5, 0)
        Me.PrincipalTable.Controls.Add(Me.TipoL, 1, 0)
        Me.PrincipalTable.Controls.Add(Me.TipoV, 2, 0)
        Me.PrincipalTable.Controls.Add(Me.CantidadL, 4, 0)
        Me.PrincipalTable.Controls.Add(Me.fechaL, 7, 0)
        Me.PrincipalTable.Controls.Add(Me.BuscarButton, 10, 0)
        Me.PrincipalTable.Controls.Add(Me.CarreraV, 8, 1)
        Me.PrincipalTable.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalTable.Name = "PrincipalTable"
        Me.PrincipalTable.RowCount = 2
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.PrincipalTable.Size = New System.Drawing.Size(784, 65)
        Me.PrincipalTable.TabIndex = 244
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 252
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
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(586, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(637, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 236
        Me.GuardarButton.UseVisualStyleBackColor = False
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
        Me.Title.Size = New System.Drawing.Size(575, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Borrar Reembolsos con Pago (solo Guate ACH)"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BorrarReembolsoConPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.PrincipalTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BorrarReembolsoConPago"
        Me.Text = "Borrar Reembolsos con Pago (ACH)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrincipalTable.ResumeLayout(False)
        Me.PrincipalTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AllCheck As System.Windows.Forms.CheckBox
    Friend WithEvents GradoV As System.Windows.Forms.ComboBox
    Friend WithEvents CarreraL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents FechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EscuelaL As System.Windows.Forms.Label
    Friend WithEvents EscuelaV As System.Windows.Forms.ComboBox
    Friend WithEvents CantidadV As System.Windows.Forms.TextBox
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents TipoV As System.Windows.Forms.ComboBox
    Friend WithEvents CantidadL As System.Windows.Forms.Label
    Friend WithEvents fechaL As System.Windows.Forms.Label
    Friend WithEvents BuscarButton As System.Windows.Forms.Button
    Friend WithEvents CarreraV As System.Windows.Forms.ComboBox
    Friend WithEvents PrincipalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
