<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregaLibros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntregaLibros))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.BusquedaPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ProveedorCombo = New System.Windows.Forms.ComboBox()
        Me.ProveedorL = New System.Windows.Forms.Label()
        Me.EntregaPicker = New System.Windows.Forms.DateTimePicker()
        Me.SelTodosCheck = New System.Windows.Forms.CheckBox()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.deFechaL = New System.Windows.Forms.Label()
        Me.DeFecha = New System.Windows.Forms.DateTimePicker()
        Me.AFecha = New System.Windows.Forms.DateTimePicker()
        Me.DateL = New System.Windows.Forms.Label()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.BusquedaPanel.SuspendLayout()
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
        Me.bannerPanel.TabIndex = 258
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
        Me.opcionesTable.Size = New System.Drawing.Size(888, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(786, 3)
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
        Me.Title.Size = New System.Drawing.Size(775, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Entrega de libros"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BusquedaPanel
        '
        Me.BusquedaPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusquedaPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.BusquedaPanel.ColumnCount = 8
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.Controls.Add(Me.ProveedorCombo, 5, 1)
        Me.BusquedaPanel.Controls.Add(Me.ProveedorL, 4, 1)
        Me.BusquedaPanel.Controls.Add(Me.EntregaPicker, 1, 1)
        Me.BusquedaPanel.Controls.Add(Me.SelTodosCheck, 0, 0)
        Me.BusquedaPanel.Controls.Add(Me.TotalL, 0, 1)
        Me.BusquedaPanel.Controls.Add(Me.deFechaL, 1, 0)
        Me.BusquedaPanel.Controls.Add(Me.DeFecha, 2, 0)
        Me.BusquedaPanel.Controls.Add(Me.AFecha, 5, 0)
        Me.BusquedaPanel.Controls.Add(Me.DateL, 4, 0)
        Me.BusquedaPanel.Controls.Add(Me.GenerarButton, 7, 0)
        Me.BusquedaPanel.Location = New System.Drawing.Point(0, 120)
        Me.BusquedaPanel.Name = "BusquedaPanel"
        Me.BusquedaPanel.RowCount = 2
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaPanel.Size = New System.Drawing.Size(984, 67)
        Me.BusquedaPanel.TabIndex = 259
        '
        'ProveedorCombo
        '
        Me.ProveedorCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedorCombo.FormattingEnabled = True
        Me.ProveedorCombo.Location = New System.Drawing.Point(582, 36)
        Me.ProveedorCombo.Name = "ProveedorCombo"
        Me.ProveedorCombo.Size = New System.Drawing.Size(313, 31)
        Me.ProveedorCombo.TabIndex = 270
        '
        'ProveedorL
        '
        Me.ProveedorL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProveedorL.AutoSize = True
        Me.ProveedorL.BackColor = System.Drawing.Color.Transparent
        Me.ProveedorL.Location = New System.Drawing.Point(469, 33)
        Me.ProveedorL.Name = "ProveedorL"
        Me.ProveedorL.Size = New System.Drawing.Size(107, 34)
        Me.ProveedorL.TabIndex = 207
        Me.ProveedorL.Text = "Proveedor:"
        Me.ProveedorL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EntregaPicker
        '
        Me.EntregaPicker.Location = New System.Drawing.Point(50, 36)
        Me.EntregaPicker.Name = "EntregaPicker"
        Me.EntregaPicker.Size = New System.Drawing.Size(119, 30)
        Me.EntregaPicker.TabIndex = 200
        Me.EntregaPicker.Visible = False
        '
        'SelTodosCheck
        '
        Me.SelTodosCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelTodosCheck.AutoSize = True
        Me.SelTodosCheck.BackColor = System.Drawing.Color.Transparent
        Me.SelTodosCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelTodosCheck.ForeColor = System.Drawing.Color.Black
        Me.SelTodosCheck.Location = New System.Drawing.Point(3, 3)
        Me.SelTodosCheck.Name = "SelTodosCheck"
        Me.SelTodosCheck.Size = New System.Drawing.Size(41, 27)
        Me.SelTodosCheck.TabIndex = 69
        Me.SelTodosCheck.Text = "Chequear todos"
        Me.SelTodosCheck.UseVisualStyleBackColor = False
        Me.SelTodosCheck.Visible = False
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.Location = New System.Drawing.Point(3, 33)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(25, 27)
        Me.TotalL.TabIndex = 261
        Me.TotalL.Text = "_"
        Me.TotalL.Visible = False
        '
        'deFechaL
        '
        Me.deFechaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deFechaL.AutoSize = True
        Me.deFechaL.Location = New System.Drawing.Point(50, 0)
        Me.deFechaL.Name = "deFechaL"
        Me.deFechaL.Size = New System.Drawing.Size(119, 33)
        Me.deFechaL.TabIndex = 217
        Me.deFechaL.Text = "De Fecha:"
        Me.deFechaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DeFecha
        '
        Me.DeFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeFecha.Location = New System.Drawing.Point(175, 3)
        Me.DeFecha.Name = "DeFecha"
        Me.DeFecha.Size = New System.Drawing.Size(268, 30)
        Me.DeFecha.TabIndex = 216
        '
        'AFecha
        '
        Me.AFecha.Location = New System.Drawing.Point(582, 3)
        Me.AFecha.Name = "AFecha"
        Me.AFecha.Size = New System.Drawing.Size(299, 30)
        Me.AFecha.TabIndex = 199
        '
        'DateL
        '
        Me.DateL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateL.AutoSize = True
        Me.DateL.BackColor = System.Drawing.Color.Transparent
        Me.DateL.Location = New System.Drawing.Point(469, 0)
        Me.DateL.Name = "DateL"
        Me.DateL.Size = New System.Drawing.Size(107, 33)
        Me.DateL.TabIndex = 206
        Me.DateL.Text = "A Fecha:"
        Me.DateL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GenerarButton
        '
        Me.GenerarButton.Location = New System.Drawing.Point(921, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.BusquedaPanel.SetRowSpan(Me.GenerarButton, 2)
        Me.GenerarButton.Size = New System.Drawing.Size(60, 61)
        Me.GenerarButton.TabIndex = 209
        Me.GenerarButton.Text = "Ver Listado"
        Me.GenerarButton.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 193)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 28
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(984, 468)
        Me.ListadoGrid.TabIndex = 260
        Me.ListadoGrid.Visible = False
        '
        'EntregaLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.BusquedaPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EntregaLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrega Libros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.BusquedaPanel.ResumeLayout(False)
        Me.BusquedaPanel.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents BusquedaPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateL As System.Windows.Forms.Label
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents deFechaL As System.Windows.Forms.Label
    Friend WithEvents DeFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents SelTodosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents EntregaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProveedorL As System.Windows.Forms.Label
    Friend WithEvents ProveedorCombo As System.Windows.Forms.ComboBox
End Class
