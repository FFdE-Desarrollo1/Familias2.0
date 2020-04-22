<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReembolsosPorFamilia
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReembolsosPorFamilia))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ReviewGrid = New System.Windows.Forms.DataGridView()
        Me.ChequeL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TotalV = New System.Windows.Forms.Label()
        Me.QL = New System.Windows.Forms.Label()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.ChequeV = New System.Windows.Forms.TextBox()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.ReciboL = New System.Windows.Forms.Label()
        Me.ReciboV = New System.Windows.Forms.TextBox()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.principalTable.SuspendLayout()
        CType(Me.ReviewGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Title.Text = "Reembolsos Por Familia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 2
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.Controls.Add(Me.ReviewGrid, 0, 4)
        Me.principalTable.Controls.Add(Me.ChequeL, 0, 0)
        Me.principalTable.Controls.Add(Me.ListadoGrid, 0, 3)
        Me.principalTable.Controls.Add(Me.Panel2, 1, 2)
        Me.principalTable.Controls.Add(Me.ChequeV, 1, 0)
        Me.principalTable.Controls.Add(Me.TotalButton, 0, 2)
        Me.principalTable.Controls.Add(Me.ReciboL, 0, 1)
        Me.principalTable.Controls.Add(Me.ReciboV, 1, 1)
        Me.principalTable.Location = New System.Drawing.Point(0, 164)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 5
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.principalTable.Size = New System.Drawing.Size(784, 586)
        Me.principalTable.TabIndex = 257
        Me.principalTable.Visible = False
        '
        'ReviewGrid
        '
        Me.ReviewGrid.AllowUserToAddRows = False
        Me.ReviewGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ReviewGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReviewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ReviewGrid.BackgroundColor = System.Drawing.Color.Snow
        Me.ReviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.principalTable.SetColumnSpan(Me.ReviewGrid, 2)
        Me.ReviewGrid.Location = New System.Drawing.Point(3, 517)
        Me.ReviewGrid.Name = "ReviewGrid"
        Me.ReviewGrid.ReadOnly = True
        Me.ReviewGrid.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ReviewGrid.Size = New System.Drawing.Size(778, 66)
        Me.ReviewGrid.TabIndex = 234
        Me.ReviewGrid.Visible = False
        '
        'ChequeL
        '
        Me.ChequeL.AutoSize = True
        Me.ChequeL.BackColor = System.Drawing.Color.Transparent
        Me.ChequeL.Location = New System.Drawing.Point(3, 0)
        Me.ChequeL.Name = "ChequeL"
        Me.ChequeL.Size = New System.Drawing.Size(119, 23)
        Me.ChequeL.TabIndex = 227
        Me.ChequeL.Text = "No. Cheque:"
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListadoGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion})
        Me.principalTable.SetColumnSpan(Me.ListadoGrid, 2)
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 116)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListadoGrid.Size = New System.Drawing.Size(778, 353)
        Me.ListadoGrid.TabIndex = 230
        '
        'Accion
        '
        Me.Accion.HeaderText = "Accion"
        Me.Accion.Name = "Accion"
        Me.Accion.Width = 74
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.TotalV)
        Me.Panel2.Controls.Add(Me.QL)
        Me.Panel2.Controls.Add(Me.TotalL)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(128, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 35)
        Me.Panel2.TabIndex = 233
        '
        'TotalV
        '
        Me.TotalV.AutoSize = True
        Me.TotalV.BackColor = System.Drawing.Color.Transparent
        Me.TotalV.Location = New System.Drawing.Point(144, 12)
        Me.TotalV.Name = "TotalV"
        Me.TotalV.Size = New System.Drawing.Size(58, 29)
        Me.TotalV.TabIndex = 44
        Me.TotalV.Text = "0.00"
        '
        'QL
        '
        Me.QL.AutoSize = True
        Me.QL.BackColor = System.Drawing.Color.Transparent
        Me.QL.Location = New System.Drawing.Point(122, 12)
        Me.QL.Name = "QL"
        Me.QL.Size = New System.Drawing.Size(38, 29)
        Me.QL.TabIndex = 43
        Me.QL.Text = "Q."
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Transparent
        Me.TotalL.Location = New System.Drawing.Point(18, 12)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(163, 29)
        Me.TotalL.TabIndex = 42
        Me.TotalL.Text = "Total a Pagar:"
        '
        'ChequeV
        '
        Me.ChequeV.Location = New System.Drawing.Point(128, 3)
        Me.ChequeV.Name = "ChequeV"
        Me.ChequeV.Size = New System.Drawing.Size(100, 30)
        Me.ChequeV.TabIndex = 226
        '
        'TotalButton
        '
        Me.TotalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalButton.Location = New System.Drawing.Point(3, 75)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(98, 33)
        Me.TotalButton.TabIndex = 232
        Me.TotalButton.Text = "Calcular Total"
        Me.TotalButton.UseVisualStyleBackColor = True
        '
        'ReciboL
        '
        Me.ReciboL.AutoSize = True
        Me.ReciboL.BackColor = System.Drawing.Color.Transparent
        Me.ReciboL.Location = New System.Drawing.Point(3, 36)
        Me.ReciboL.Name = "ReciboL"
        Me.ReciboL.Size = New System.Drawing.Size(113, 23)
        Me.ReciboL.TabIndex = 229
        Me.ReciboL.Text = "No. Recibo:"
        '
        'ReciboV
        '
        Me.ReciboV.Location = New System.Drawing.Point(128, 39)
        Me.ReciboV.Name = "ReciboV"
        Me.ReciboV.Size = New System.Drawing.Size(100, 30)
        Me.ReciboV.TabIndex = 228
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.PrincipalPanel.ColumnCount = 5
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.PrincipalPanel.Controls.Add(Me.MiembroL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 122)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 36)
        Me.PrincipalPanel.TabIndex = 256
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(504, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(157, 36)
        Me.MiembroL.TabIndex = 207
        Me.MiembroL.Text = "No. Afiliación:"
        Me.MiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MiembroV
        '
        Me.MiembroV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(667, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(114, 40)
        Me.MiembroV.TabIndex = 207
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(140, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(149, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 40)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReembolsosPorFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.principalTable)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReembolsosPorFamilia"
        Me.Text = "Reembolsos Por Familia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.principalTable.ResumeLayout(False)
        Me.principalTable.PerformLayout()
        CType(Me.ReviewGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReviewGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ChequeL As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TotalV As System.Windows.Forms.Label
    Friend WithEvents QL As System.Windows.Forms.Label
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents ChequeV As System.Windows.Forms.TextBox
    Friend WithEvents TotalButton As System.Windows.Forms.Button
    Friend WithEvents ReciboL As System.Windows.Forms.Label
    Friend WithEvents ReciboV As System.Windows.Forms.TextBox
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
End Class
