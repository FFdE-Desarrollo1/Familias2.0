<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.Panel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.activoL = New System.Windows.Forms.Label()
        Me.proveedoresGrid = New System.Windows.Forms.DataGridView()
        Me.proveedorL = New System.Windows.Forms.Label()
        Me.proveedorV = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LimpiarButton = New System.Windows.Forms.Button()
        Me.guardarProvButton = New System.Windows.Forms.Button()
        Me.BorrarProvButton = New System.Windows.Forms.Button()
        Me.IdProveedor = New System.Windows.Forms.Label()
        Me.nuevoL = New System.Windows.Forms.LinkLabel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.proveedoresGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.ColumnCount = 4
        Me.Panel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel1.Controls.Add(Me.activoL, 2, 2)
        Me.Panel1.Controls.Add(Me.proveedoresGrid, 3, 1)
        Me.Panel1.Controls.Add(Me.proveedorL, 0, 1)
        Me.Panel1.Controls.Add(Me.proveedorV, 1, 1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.Panel1.Controls.Add(Me.IdProveedor, 2, 1)
        Me.Panel1.Controls.Add(Me.nuevoL, 0, 0)
        Me.Panel1.Location = New System.Drawing.Point(0, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RowCount = 4
        Me.Panel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Panel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Panel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Panel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel1.Size = New System.Drawing.Size(784, 638)
        Me.Panel1.TabIndex = 251
        '
        'activoL
        '
        Me.activoL.AutoSize = True
        Me.activoL.Location = New System.Drawing.Point(390, 58)
        Me.activoL.Name = "activoL"
        Me.activoL.Size = New System.Drawing.Size(15, 16)
        Me.activoL.TabIndex = 197
        Me.activoL.Text = "0"
        Me.activoL.Visible = False
        '
        'proveedoresGrid
        '
        Me.proveedoresGrid.AllowUserToAddRows = False
        Me.proveedoresGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proveedoresGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.proveedoresGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proveedoresGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.proveedoresGrid.BackgroundColor = System.Drawing.Color.White
        Me.proveedoresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.proveedoresGrid.Location = New System.Drawing.Point(588, 33)
        Me.proveedoresGrid.Name = "proveedoresGrid"
        Me.proveedoresGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proveedoresGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Panel1.SetRowSpan(Me.proveedoresGrid, 3)
        Me.proveedoresGrid.Size = New System.Drawing.Size(193, 602)
        Me.proveedoresGrid.TabIndex = 0
        '
        'proveedorL
        '
        Me.proveedorL.AutoSize = True
        Me.proveedorL.Location = New System.Drawing.Point(3, 30)
        Me.proveedorL.Name = "proveedorL"
        Me.proveedorL.Size = New System.Drawing.Size(65, 16)
        Me.proveedorL.TabIndex = 1
        Me.proveedorL.Text = "Proveedor"
        Me.proveedorL.Visible = False
        '
        'proveedorV
        '
        Me.proveedorV.Location = New System.Drawing.Point(74, 33)
        Me.proveedorV.MaxLength = 60
        Me.proveedorV.Name = "proveedorV"
        Me.proveedorV.Size = New System.Drawing.Size(300, 22)
        Me.proveedorV.TabIndex = 2
        Me.proveedorV.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.Panel1.SetColumnSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LimpiarButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.guardarProvButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BorrarProvButton, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 81)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(381, 554)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'LimpiarButton
        '
        Me.LimpiarButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LimpiarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LimpiarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimpiarButton.ForeColor = System.Drawing.Color.Black
        Me.LimpiarButton.Location = New System.Drawing.Point(3, 62)
        Me.LimpiarButton.Name = "LimpiarButton"
        Me.LimpiarButton.Size = New System.Drawing.Size(174, 33)
        Me.LimpiarButton.TabIndex = 204
        Me.LimpiarButton.Text = "Limpiar campos"
        Me.LimpiarButton.UseVisualStyleBackColor = False
        Me.LimpiarButton.Visible = False
        '
        'guardarProvButton
        '
        Me.guardarProvButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guardarProvButton.BackColor = System.Drawing.Color.Chocolate
        Me.TableLayoutPanel1.SetColumnSpan(Me.guardarProvButton, 3)
        Me.guardarProvButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarProvButton.ForeColor = System.Drawing.Color.White
        Me.guardarProvButton.Location = New System.Drawing.Point(3, 3)
        Me.guardarProvButton.Name = "guardarProvButton"
        Me.guardarProvButton.Size = New System.Drawing.Size(375, 38)
        Me.guardarProvButton.TabIndex = 105
        Me.guardarProvButton.Text = "Guardar Proveedor"
        Me.guardarProvButton.UseVisualStyleBackColor = False
        Me.guardarProvButton.Visible = False
        '
        'BorrarProvButton
        '
        Me.BorrarProvButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrarProvButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BorrarProvButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarProvButton.ForeColor = System.Drawing.Color.Black
        Me.BorrarProvButton.Location = New System.Drawing.Point(203, 62)
        Me.BorrarProvButton.Name = "BorrarProvButton"
        Me.BorrarProvButton.Size = New System.Drawing.Size(175, 33)
        Me.BorrarProvButton.TabIndex = 205
        Me.BorrarProvButton.Text = "Inactivar Proveedor"
        Me.BorrarProvButton.UseVisualStyleBackColor = False
        Me.BorrarProvButton.Visible = False
        '
        'IdProveedor
        '
        Me.IdProveedor.AutoSize = True
        Me.IdProveedor.Location = New System.Drawing.Point(390, 30)
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.Size = New System.Drawing.Size(15, 16)
        Me.IdProveedor.TabIndex = 4
        Me.IdProveedor.Text = "0"
        Me.IdProveedor.Visible = False
        '
        'nuevoL
        '
        Me.nuevoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nuevoL.AutoSize = True
        Me.Panel1.SetColumnSpan(Me.nuevoL, 2)
        Me.nuevoL.Location = New System.Drawing.Point(3, 0)
        Me.nuevoL.Name = "nuevoL"
        Me.nuevoL.Size = New System.Drawing.Size(381, 16)
        Me.nuevoL.TabIndex = 198
        Me.nuevoL.TabStop = True
        Me.nuevoL.Text = "Agregar Nuevo Proveedor"
        Me.nuevoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 260
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 2
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
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
        Me.inicioButton.Location = New System.Drawing.Point(640, 3)
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
        Me.Title.Size = New System.Drawing.Size(629, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Proveedores"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.proveedoresGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents activoL As System.Windows.Forms.Label
    Friend WithEvents proveedoresGrid As System.Windows.Forms.DataGridView
    Friend WithEvents proveedorL As System.Windows.Forms.Label
    Friend WithEvents proveedorV As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LimpiarButton As System.Windows.Forms.Button
    Friend WithEvents guardarProvButton As System.Windows.Forms.Button
    Friend WithEvents BorrarProvButton As System.Windows.Forms.Button
    Friend WithEvents IdProveedor As System.Windows.Forms.Label
    Friend WithEvents nuevoL As System.Windows.Forms.LinkLabel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
