<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteReembolsos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteReembolsos))
        Me.TotalGenL = New System.Windows.Forms.Label()
        Me.TotalGenV = New System.Windows.Forms.Label()
        Me.totalesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.AFechaV = New System.Windows.Forms.DateTimePicker()
        Me.TipoV = New System.Windows.Forms.ComboBox()
        Me.DFechaL = New System.Windows.Forms.Label()
        Me.DeFechaV = New System.Windows.Forms.DateTimePicker()
        Me.AFechaL = New System.Windows.Forms.Label()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.ListaGrid = New System.Windows.Forms.DataGridView()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.totalesTable.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.ListaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.principalTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalGenL
        '
        Me.TotalGenL.AutoSize = True
        Me.TotalGenL.ForeColor = System.Drawing.Color.Blue
        Me.TotalGenL.Location = New System.Drawing.Point(666, 0)
        Me.TotalGenL.Name = "TotalGenL"
        Me.TotalGenL.Size = New System.Drawing.Size(88, 16)
        Me.TotalGenL.TabIndex = 251
        Me.TotalGenL.Text = "Total General:"
        '
        'TotalGenV
        '
        Me.TotalGenV.AutoSize = True
        Me.TotalGenV.ForeColor = System.Drawing.Color.Blue
        Me.TotalGenV.Location = New System.Drawing.Point(760, 0)
        Me.TotalGenV.Name = "TotalGenV"
        Me.TotalGenV.Size = New System.Drawing.Size(15, 16)
        Me.TotalGenV.TabIndex = 252
        Me.TotalGenV.Text = "_"
        '
        'totalesTable
        '
        Me.totalesTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalesTable.ColumnCount = 3
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.totalesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.totalesTable.Controls.Add(Me.TotalGenL, 1, 0)
        Me.totalesTable.Controls.Add(Me.TotalL, 0, 0)
        Me.totalesTable.Controls.Add(Me.TotalGenV, 2, 0)
        Me.totalesTable.Location = New System.Drawing.Point(3, 53)
        Me.totalesTable.Name = "totalesTable"
        Me.totalesTable.RowCount = 1
        Me.totalesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.totalesTable.Size = New System.Drawing.Size(778, 24)
        Me.totalesTable.TabIndex = 249
        Me.totalesTable.Visible = False
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.ForeColor = System.Drawing.Color.Blue
        Me.TotalL.Location = New System.Drawing.Point(3, 0)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(92, 16)
        Me.TotalL.TabIndex = 249
        Me.TotalL.Text = "Reembolsos:  "
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.Location = New System.Drawing.Point(429, 0)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(36, 16)
        Me.TipoL.TabIndex = 254
        Me.TipoL.Text = "Tipo:"
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.AliceBlue
        Me.opcionesTable.ColumnCount = 10
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.TipoL, 7, 0)
        Me.opcionesTable.Controls.Add(Me.AFechaV, 5, 0)
        Me.opcionesTable.Controls.Add(Me.TipoV, 8, 0)
        Me.opcionesTable.Controls.Add(Me.DFechaL, 1, 0)
        Me.opcionesTable.Controls.Add(Me.DeFechaV, 2, 0)
        Me.opcionesTable.Controls.Add(Me.AFechaL, 4, 0)
        Me.opcionesTable.Controls.Add(Me.GenerarButton, 9, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(3, 3)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(778, 33)
        Me.opcionesTable.TabIndex = 247
        '
        'AFechaV
        '
        Me.AFechaV.Location = New System.Drawing.Point(117, 3)
        Me.AFechaV.Name = "AFechaV"
        Me.AFechaV.Size = New System.Drawing.Size(276, 22)
        Me.AFechaV.TabIndex = 255
        '
        'TipoV
        '
        Me.TipoV.FormattingEnabled = True
        Me.TipoV.Location = New System.Drawing.Point(471, 3)
        Me.TipoV.Name = "TipoV"
        Me.TipoV.Size = New System.Drawing.Size(223, 24)
        Me.TipoV.TabIndex = 253
        '
        'DFechaL
        '
        Me.DFechaL.AutoSize = True
        Me.DFechaL.Location = New System.Drawing.Point(-327, 0)
        Me.DFechaL.Name = "DFechaL"
        Me.DFechaL.Size = New System.Drawing.Size(68, 16)
        Me.DFechaL.TabIndex = 250
        Me.DFechaL.Text = "De Fecha:"
        '
        'DeFechaV
        '
        Me.DeFechaV.Location = New System.Drawing.Point(-253, 3)
        Me.DeFechaV.Name = "DeFechaV"
        Me.DeFechaV.Size = New System.Drawing.Size(268, 22)
        Me.DeFechaV.TabIndex = 252
        '
        'AFechaL
        '
        Me.AFechaL.AutoSize = True
        Me.AFechaL.Location = New System.Drawing.Point(51, 0)
        Me.AFechaL.Name = "AFechaL"
        Me.AFechaL.Size = New System.Drawing.Size(60, 16)
        Me.AFechaL.TabIndex = 251
        Me.AFechaL.Text = "A Fecha:"
        '
        'GenerarButton
        '
        Me.GenerarButton.Location = New System.Drawing.Point(700, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarButton.TabIndex = 256
        Me.GenerarButton.Text = "Generar"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'ListaGrid
        '
        Me.ListaGrid.AllowUserToAddRows = False
        Me.ListaGrid.AllowUserToDeleteRows = False
        Me.ListaGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        Me.ListaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListaGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListaGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListaGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ListaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaGrid.Location = New System.Drawing.Point(3, 83)
        Me.ListaGrid.Name = "ListaGrid"
        Me.ListaGrid.ReadOnly = True
        Me.ListaGrid.RowHeadersWidth = 70
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListaGrid.Size = New System.Drawing.Size(778, 552)
        Me.ListaGrid.TabIndex = 248
        Me.ListaGrid.Visible = False
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 1
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.Controls.Add(Me.opcionesTable, 0, 0)
        Me.principalTable.Controls.Add(Me.ListaGrid, 0, 2)
        Me.principalTable.Controls.Add(Me.totalesTable, 0, 1)
        Me.principalTable.Location = New System.Drawing.Point(0, 123)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 3
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.Size = New System.Drawing.Size(784, 638)
        Me.principalTable.TabIndex = 251
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 256
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.Title.Text = "Reporte de Reembolsos"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReporteReembolsos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.principalTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReporteReembolsos"
        Me.Text = "Reporte Reembolsos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.totalesTable.ResumeLayout(False)
        Me.totalesTable.PerformLayout()
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        CType(Me.ListaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.principalTable.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TotalGenL As System.Windows.Forms.Label
    Friend WithEvents TotalGenV As System.Windows.Forms.Label
    Friend WithEvents totalesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AFechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents TipoV As System.Windows.Forms.ComboBox
    Friend WithEvents DFechaL As System.Windows.Forms.Label
    Friend WithEvents DeFechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents AFechaL As System.Windows.Forms.Label
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents ListaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
