<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticasFarmacia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadisticasFarmacia))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.aFecha = New System.Windows.Forms.DateTimePicker()
        Me.DeFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.detalleCheck = New System.Windows.Forms.CheckBox()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.pendientesLink = New System.Windows.Forms.LinkLabel()
        Me.recetasLink = New System.Windows.Forms.LinkLabel()
        Me.TotalesL = New System.Windows.Forms.Label()
        Me.AlCreditoLink = New System.Windows.Forms.LinkLabel()
        Me.listadoGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.listadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.aFecha, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DeFecha, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaL, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.detalleCheck, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 121)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(784, 34)
        Me.TableLayoutPanel2.TabIndex = 249
        '
        'aFecha
        '
        Me.aFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aFecha.Location = New System.Drawing.Point(496, 3)
        Me.aFecha.Name = "aFecha"
        Me.aFecha.Size = New System.Drawing.Size(285, 22)
        Me.aFecha.TabIndex = 66
        '
        'DeFecha
        '
        Me.DeFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeFecha.Location = New System.Drawing.Point(101, 3)
        Me.DeFecha.Name = "DeFecha"
        Me.DeFecha.Size = New System.Drawing.Size(303, 22)
        Me.DeFecha.TabIndex = 201
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 34)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "De Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FechaL
        '
        Me.FechaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaL.AutoSize = True
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.ForeColor = System.Drawing.Color.Black
        Me.FechaL.Location = New System.Drawing.Point(430, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(60, 34)
        Me.FechaL.TabIndex = 64
        Me.FechaL.Text = "A Fecha:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'detalleCheck
        '
        Me.detalleCheck.AutoSize = True
        Me.detalleCheck.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detalleCheck.ForeColor = System.Drawing.Color.Black
        Me.detalleCheck.Location = New System.Drawing.Point(3, 3)
        Me.detalleCheck.Name = "detalleCheck"
        Me.detalleCheck.Size = New System.Drawing.Size(1, 21)
        Me.detalleCheck.TabIndex = 203
        Me.detalleCheck.Text = "Ver detalle"
        Me.detalleCheck.UseVisualStyleBackColor = True
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.pendientesLink, 2, 0)
        Me.opcionesTable.Controls.Add(Me.recetasLink, 0, 0)
        Me.opcionesTable.Controls.Add(Me.TotalesL, 0, 1)
        Me.opcionesTable.Controls.Add(Me.AlCreditoLink, 4, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(0, 161)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 2
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(784, 59)
        Me.opcionesTable.TabIndex = 250
        '
        'pendientesLink
        '
        Me.pendientesLink.AutoSize = True
        Me.pendientesLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pendientesLink.Location = New System.Drawing.Point(324, 0)
        Me.pendientesLink.Name = "pendientesLink"
        Me.pendientesLink.Size = New System.Drawing.Size(156, 17)
        Me.pendientesLink.TabIndex = 198
        Me.pendientesLink.TabStop = True
        Me.pendientesLink.Text = "Pendientes de Entrega"
        '
        'recetasLink
        '
        Me.recetasLink.AutoSize = True
        Me.recetasLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recetasLink.Location = New System.Drawing.Point(3, 0)
        Me.recetasLink.Name = "recetasLink"
        Me.recetasLink.Size = New System.Drawing.Size(160, 17)
        Me.recetasLink.TabIndex = 1
        Me.recetasLink.TabStop = True
        Me.recetasLink.Text = "Total recetas/Medicinas"
        '
        'TotalesL
        '
        Me.TotalesL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalesL.AutoSize = True
        Me.TotalesL.BackColor = System.Drawing.Color.SteelBlue
        Me.opcionesTable.SetColumnSpan(Me.TotalesL, 5)
        Me.TotalesL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalesL.ForeColor = System.Drawing.Color.White
        Me.TotalesL.Location = New System.Drawing.Point(3, 29)
        Me.TotalesL.Name = "TotalesL"
        Me.TotalesL.Size = New System.Drawing.Size(778, 30)
        Me.TotalesL.TabIndex = 198
        Me.TotalesL.Text = "_"
        Me.TotalesL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TotalesL.Visible = False
        '
        'AlCreditoLink
        '
        Me.AlCreditoLink.AutoSize = True
        Me.AlCreditoLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlCreditoLink.Location = New System.Drawing.Point(641, 0)
        Me.AlCreditoLink.Name = "AlCreditoLink"
        Me.AlCreditoLink.Size = New System.Drawing.Size(139, 17)
        Me.AlCreditoLink.TabIndex = 197
        Me.AlCreditoLink.TabStop = True
        Me.AlCreditoLink.Text = "Medicinas al Crédito"
        '
        'listadoGrid
        '
        Me.listadoGrid.AllowUserToAddRows = False
        Me.listadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.listadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.listadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.listadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.listadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listadoGrid.Location = New System.Drawing.Point(0, 236)
        Me.listadoGrid.Name = "listadoGrid"
        Me.listadoGrid.ReadOnly = True
        Me.listadoGrid.RowHeadersWidth = 60
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.listadoGrid.Size = New System.Drawing.Size(784, 514)
        Me.listadoGrid.TabIndex = 251
        Me.listadoGrid.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 259
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 53)
        Me.TableLayoutPanel1.TabIndex = 68
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
        Me.Title.Text = "Estadísticas Farmacia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EstadisticasFarmacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.opcionesTable)
        Me.Controls.Add(Me.listadoGrid)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstadisticasFarmacia"
        Me.Text = "Estadisticas Farmacia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        CType(Me.listadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents aFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DeFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents detalleCheck As System.Windows.Forms.CheckBox
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pendientesLink As System.Windows.Forms.LinkLabel
    Friend WithEvents recetasLink As System.Windows.Forms.LinkLabel
    Friend WithEvents TotalesL As System.Windows.Forms.Label
    Friend WithEvents AlCreditoLink As System.Windows.Forms.LinkLabel
    Friend WithEvents listadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
