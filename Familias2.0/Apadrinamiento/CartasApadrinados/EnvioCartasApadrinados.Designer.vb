<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnvioCartasApadrinados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnvioCartasApadrinados))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.EscritasPicker = New System.Windows.Forms.DateTimePicker()
        Me.CategoriaL = New System.Windows.Forms.Label()
        Me.EscritaL = New System.Windows.Forms.Label()
        Me.CategoriaCombo = New System.Windows.Forms.ComboBox()
        Me.SeleccionarCheck = New System.Windows.Forms.CheckBox()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.Chequeo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TotalL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListadoButton, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EscritasPicker, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CategoriaL, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EscritaL, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CategoriaCombo, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SeleccionarCheck, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 34)
        Me.TableLayoutPanel1.TabIndex = 239
        '
        'TotalL
        '
        Me.TotalL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalL.AutoSize = True
        Me.TotalL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.Location = New System.Drawing.Point(3, 0)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(50, 34)
        Me.TotalL.TabIndex = 213
        Me.TotalL.Text = "Total:"
        Me.TotalL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListadoButton
        '
        Me.ListadoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoButton.Location = New System.Drawing.Point(666, 3)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(115, 28)
        Me.ListadoButton.TabIndex = 216
        Me.ListadoButton.Text = "Mostrar Listado"
        Me.ListadoButton.UseVisualStyleBackColor = True
        '
        'EscritasPicker
        '
        Me.EscritasPicker.Location = New System.Drawing.Point(499, 3)
        Me.EscritasPicker.Name = "EscritasPicker"
        Me.EscritasPicker.Size = New System.Drawing.Size(141, 22)
        Me.EscritasPicker.TabIndex = 214
        '
        'CategoriaL
        '
        Me.CategoriaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CategoriaL.AutoSize = True
        Me.CategoriaL.Location = New System.Drawing.Point(231, 0)
        Me.CategoriaL.Name = "CategoriaL"
        Me.CategoriaL.Size = New System.Drawing.Size(67, 34)
        Me.CategoriaL.TabIndex = 217
        Me.CategoriaL.Text = "Categoría:"
        Me.CategoriaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EscritaL
        '
        Me.EscritaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EscritaL.AutoSize = True
        Me.EscritaL.Location = New System.Drawing.Point(433, 0)
        Me.EscritaL.Name = "EscritaL"
        Me.EscritaL.Size = New System.Drawing.Size(60, 34)
        Me.EscritaL.TabIndex = 215
        Me.EscritaL.Text = "Escritas:"
        Me.EscritaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CategoriaCombo
        '
        Me.CategoriaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoriaCombo.FormattingEnabled = True
        Me.CategoriaCombo.Location = New System.Drawing.Point(304, 3)
        Me.CategoriaCombo.Name = "CategoriaCombo"
        Me.CategoriaCombo.Size = New System.Drawing.Size(103, 24)
        Me.CategoriaCombo.TabIndex = 218
        '
        'SeleccionarCheck
        '
        Me.SeleccionarCheck.AutoSize = True
        Me.SeleccionarCheck.Location = New System.Drawing.Point(117, 3)
        Me.SeleccionarCheck.Name = "SeleccionarCheck"
        Me.SeleccionarCheck.Size = New System.Drawing.Size(108, 20)
        Me.SeleccionarCheck.TabIndex = 219
        Me.SeleccionarCheck.Text = "Seleccionar todos"
        Me.SeleccionarCheck.UseVisualStyleBackColor = True
        Me.SeleccionarCheck.Visible = False
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chequeo})
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 160)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersWidth = 55
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(784, 578)
        Me.ListadoGrid.TabIndex = 240
        Me.ListadoGrid.Visible = False
        '
        'Chequeo
        '
        Me.Chequeo.Frozen = True
        Me.Chequeo.HeaderText = "Send"
        Me.Chequeo.Name = "Chequeo"
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 250
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
        Me.Title.Text = "Agregar Fecha de Envío Cartas de Apadrinados"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnvioCartasApadrinados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 750)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EnvioCartasApadrinados"
        Me.Text = "Envio Cartas de Apadrinados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents EscritasPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CategoriaL As System.Windows.Forms.Label
    Friend WithEvents EscritaL As System.Windows.Forms.Label
    Friend WithEvents CategoriaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents SeleccionarCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Chequeo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
