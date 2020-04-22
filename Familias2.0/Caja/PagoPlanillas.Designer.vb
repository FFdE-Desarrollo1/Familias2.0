<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoPlanillas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoPlanillas))
        Me.Cronometro = New System.Windows.Forms.Timer(Me.components)
        Me.EscuelaV = New System.Windows.Forms.ComboBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.EscuelaL = New System.Windows.Forms.Label()
        Me.TipoV = New System.Windows.Forms.ComboBox()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.pagadosGrid = New System.Windows.Forms.DataGridView()
        Me.NoChequeL = New System.Windows.Forms.Label()
        Me.NoChequeV = New System.Windows.Forms.TextBox()
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.selTodosCheck = New System.Windows.Forms.CheckBox()
        Me.porPagarGrid = New System.Windows.Forms.DataGridView()
        Me.pagoOpTable = New System.Windows.Forms.TableLayoutPanel()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.opcionesTable.SuspendLayout()
        CType(Me.pagadosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.porPagarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagoOpTable.SuspendLayout()
        Me.principalTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cronometro
        '
        '
        'EscuelaV
        '
        Me.EscuelaV.FormattingEnabled = True
        Me.EscuelaV.Location = New System.Drawing.Point(393, 3)
        Me.EscuelaV.Name = "EscuelaV"
        Me.EscuelaV.Size = New System.Drawing.Size(300, 24)
        Me.EscuelaV.TabIndex = 69
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.BackColor = System.Drawing.Color.Transparent
        Me.AñoL.Location = New System.Drawing.Point(-75, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(35, 16)
        Me.AñoL.TabIndex = 72
        Me.AñoL.Text = "Año:"
        '
        'EscuelaL
        '
        Me.EscuelaL.AutoSize = True
        Me.EscuelaL.BackColor = System.Drawing.Color.Transparent
        Me.EscuelaL.Location = New System.Drawing.Point(323, 0)
        Me.EscuelaL.Name = "EscuelaL"
        Me.EscuelaL.Size = New System.Drawing.Size(64, 16)
        Me.EscuelaL.TabIndex = 71
        Me.EscuelaL.Text = "*Escuela:"
        '
        'TipoV
        '
        Me.TipoV.FormattingEnabled = True
        Me.TipoV.Location = New System.Drawing.Point(87, 3)
        Me.TipoV.Name = "TipoV"
        Me.TipoV.Size = New System.Drawing.Size(210, 24)
        Me.TipoV.TabIndex = 73
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(-34, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(53, 22)
        Me.AñoV.TabIndex = 70
        Me.AñoV.Text = "2011"
        Me.AñoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.BackColor = System.Drawing.Color.Transparent
        Me.TipoL.Location = New System.Drawing.Point(45, 0)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(36, 16)
        Me.TipoL.TabIndex = 74
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
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.EscuelaV, 8, 0)
        Me.opcionesTable.Controls.Add(Me.AñoL, 1, 0)
        Me.opcionesTable.Controls.Add(Me.EscuelaL, 7, 0)
        Me.opcionesTable.Controls.Add(Me.TipoV, 5, 0)
        Me.opcionesTable.Controls.Add(Me.AñoV, 2, 0)
        Me.opcionesTable.Controls.Add(Me.TipoL, 4, 0)
        Me.opcionesTable.Controls.Add(Me.GenerarButton, 9, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(0, 124)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(778, 32)
        Me.opcionesTable.TabIndex = 244
        '
        'GenerarButton
        '
        Me.GenerarButton.Location = New System.Drawing.Point(699, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(76, 25)
        Me.GenerarButton.TabIndex = 75
        Me.GenerarButton.Text = "Generar"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'pagadosGrid
        '
        Me.pagadosGrid.AllowUserToAddRows = False
        Me.pagadosGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.pagadosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.pagadosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.pagadosGrid.BackgroundColor = System.Drawing.Color.White
        Me.pagadosGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.pagadosGrid.Location = New System.Drawing.Point(767, 3)
        Me.pagadosGrid.Name = "pagadosGrid"
        Me.pagadosGrid.RowHeadersWidth = 60
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagadosGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.principalTable.SetRowSpan(Me.pagadosGrid, 2)
        Me.pagadosGrid.Size = New System.Drawing.Size(14, 573)
        Me.pagadosGrid.TabIndex = 167
        Me.pagadosGrid.Visible = False
        '
        'NoChequeL
        '
        Me.NoChequeL.AutoSize = True
        Me.NoChequeL.BackColor = System.Drawing.Color.Transparent
        Me.NoChequeL.Location = New System.Drawing.Point(553, 0)
        Me.NoChequeL.Name = "NoChequeL"
        Me.NoChequeL.Size = New System.Drawing.Size(76, 16)
        Me.NoChequeL.TabIndex = 171
        Me.NoChequeL.Text = "No. Cheque"
        '
        'NoChequeV
        '
        Me.NoChequeV.Location = New System.Drawing.Point(635, 3)
        Me.NoChequeV.Name = "NoChequeV"
        Me.NoChequeV.Size = New System.Drawing.Size(100, 22)
        Me.NoChequeV.TabIndex = 170
        '
        'barraProgreso
        '
        Me.barraProgreso.Location = New System.Drawing.Point(3, 3)
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(100, 19)
        Me.barraProgreso.TabIndex = 172
        Me.barraProgreso.Visible = False
        '
        'selTodosCheck
        '
        Me.selTodosCheck.AutoSize = True
        Me.selTodosCheck.BackColor = System.Drawing.Color.Transparent
        Me.selTodosCheck.ForeColor = System.Drawing.Color.Black
        Me.selTodosCheck.Location = New System.Drawing.Point(399, 3)
        Me.selTodosCheck.Name = "selTodosCheck"
        Me.selTodosCheck.Size = New System.Drawing.Size(118, 20)
        Me.selTodosCheck.TabIndex = 69
        Me.selTodosCheck.Text = "Chequear todos"
        Me.selTodosCheck.UseVisualStyleBackColor = False
        '
        'porPagarGrid
        '
        Me.porPagarGrid.AllowUserToAddRows = False
        Me.porPagarGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple
        Me.porPagarGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.porPagarGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.porPagarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.porPagarGrid.BackgroundColor = System.Drawing.Color.White
        Me.porPagarGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.porPagarGrid.Location = New System.Drawing.Point(3, 47)
        Me.porPagarGrid.Name = "porPagarGrid"
        Me.porPagarGrid.RowHeadersWidth = 60
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.porPagarGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.porPagarGrid.Size = New System.Drawing.Size(738, 529)
        Me.porPagarGrid.TabIndex = 166
        Me.porPagarGrid.Visible = False
        '
        'pagoOpTable
        '
        Me.pagoOpTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagoOpTable.ColumnCount = 6
        Me.pagoOpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pagoOpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pagoOpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pagoOpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.pagoOpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pagoOpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.pagoOpTable.Controls.Add(Me.NoChequeL, 4, 0)
        Me.pagoOpTable.Controls.Add(Me.NoChequeV, 5, 0)
        Me.pagoOpTable.Controls.Add(Me.barraProgreso, 0, 0)
        Me.pagoOpTable.Controls.Add(Me.selTodosCheck, 2, 0)
        Me.pagoOpTable.Location = New System.Drawing.Point(3, 3)
        Me.pagoOpTable.Name = "pagoOpTable"
        Me.pagoOpTable.RowCount = 1
        Me.pagoOpTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pagoOpTable.Size = New System.Drawing.Size(738, 38)
        Me.pagoOpTable.TabIndex = 1
        Me.pagoOpTable.Visible = False
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 3
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.Controls.Add(Me.porPagarGrid, 0, 1)
        Me.principalTable.Controls.Add(Me.pagoOpTable, 0, 0)
        Me.principalTable.Controls.Add(Me.pagadosGrid, 2, 0)
        Me.principalTable.Location = New System.Drawing.Point(0, 162)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 2
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.Size = New System.Drawing.Size(784, 579)
        Me.principalTable.TabIndex = 246
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 255
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NuevoButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GuardarButton, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 53)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(582, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(531, 3)
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
        Me.Title.Size = New System.Drawing.Size(520, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Pago Planillas"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PagoPlanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.opcionesTable)
        Me.Controls.Add(Me.principalTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PagoPlanillas"
        Me.Text = "Pago Planillas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        CType(Me.pagadosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.porPagarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagoOpTable.ResumeLayout(False)
        Me.pagoOpTable.PerformLayout()
        Me.principalTable.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cronometro As System.Windows.Forms.Timer
    Friend WithEvents EscuelaV As System.Windows.Forms.ComboBox
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents EscuelaL As System.Windows.Forms.Label
    Friend WithEvents TipoV As System.Windows.Forms.ComboBox
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents pagadosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents porPagarGrid As System.Windows.Forms.DataGridView
    Friend WithEvents pagoOpTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NoChequeL As System.Windows.Forms.Label
    Friend WithEvents NoChequeV As System.Windows.Forms.TextBox
    Friend WithEvents barraProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents selTodosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
