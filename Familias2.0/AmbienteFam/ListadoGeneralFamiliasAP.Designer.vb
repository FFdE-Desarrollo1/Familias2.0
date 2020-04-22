<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoGeneralFamiliasAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoGeneralFamiliasAP))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.FamiliasList = New System.Windows.Forms.DataGridView()
        Me.OpTable = New System.Windows.Forms.TableLayoutPanel()
        Me.aplicaL = New System.Windows.Forms.Label()
        Me.RegionV = New System.Windows.Forms.ComboBox()
        Me.RegionL = New System.Windows.Forms.Label()
        Me.VerListadoButton = New System.Windows.Forms.Button()
        Me.TSlist = New System.Windows.Forms.ComboBox()
        Me.TSL = New System.Windows.Forms.Label()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.AplicaCombo = New System.Windows.Forms.ComboBox()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.FamiliasList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpTable.SuspendLayout()
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
        Me.bannerPanel.TabIndex = 263
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
        Me.opcionesTable.Size = New System.Drawing.Size(888, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(840, 3)
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
        Me.Title.Size = New System.Drawing.Size(829, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Listado de Familias - Análisis Preliminar para Construcción de Vivienda"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FamiliasList
        '
        Me.FamiliasList.AllowUserToAddRows = False
        Me.FamiliasList.AllowUserToDeleteRows = False
        Me.FamiliasList.AllowUserToResizeColumns = False
        Me.FamiliasList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliasList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FamiliasList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliasList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.FamiliasList.BackgroundColor = System.Drawing.Color.White
        Me.FamiliasList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.FamiliasList.Location = New System.Drawing.Point(0, 162)
        Me.FamiliasList.Name = "FamiliasList"
        Me.FamiliasList.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliasList.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.FamiliasList.Size = New System.Drawing.Size(984, 487)
        Me.FamiliasList.TabIndex = 264
        Me.FamiliasList.Visible = False
        '
        'OpTable
        '
        Me.OpTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpTable.BackColor = System.Drawing.Color.AliceBlue
        Me.OpTable.ColumnCount = 11
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpTable.Controls.Add(Me.aplicaL, 2, 0)
        Me.OpTable.Controls.Add(Me.RegionV, 6, 0)
        Me.OpTable.Controls.Add(Me.RegionL, 5, 0)
        Me.OpTable.Controls.Add(Me.VerListadoButton, 10, 0)
        Me.OpTable.Controls.Add(Me.TSlist, 9, 0)
        Me.OpTable.Controls.Add(Me.TSL, 8, 0)
        Me.OpTable.Controls.Add(Me.TotalL, 0, 0)
        Me.OpTable.Controls.Add(Me.AplicaCombo, 3, 0)
        Me.OpTable.Location = New System.Drawing.Point(0, 124)
        Me.OpTable.Name = "OpTable"
        Me.OpTable.RowCount = 1
        Me.OpTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpTable.Size = New System.Drawing.Size(984, 34)
        Me.OpTable.TabIndex = 265
        '
        'aplicaL
        '
        Me.aplicaL.AutoSize = True
        Me.aplicaL.BackColor = System.Drawing.Color.Transparent
        Me.aplicaL.Location = New System.Drawing.Point(414, 0)
        Me.aplicaL.Name = "aplicaL"
        Me.aplicaL.Size = New System.Drawing.Size(48, 16)
        Me.aplicaL.TabIndex = 251
        Me.aplicaL.Text = "Aplica:"
        '
        'RegionV
        '
        Me.RegionV.FormattingEnabled = True
        Me.RegionV.Items.AddRange(New Object() {"", "I", "II"})
        Me.RegionV.Location = New System.Drawing.Point(619, 3)
        Me.RegionV.Name = "RegionV"
        Me.RegionV.Size = New System.Drawing.Size(67, 24)
        Me.RegionV.TabIndex = 248
        '
        'RegionL
        '
        Me.RegionL.AutoSize = True
        Me.RegionL.BackColor = System.Drawing.Color.Transparent
        Me.RegionL.Location = New System.Drawing.Point(561, 0)
        Me.RegionL.Name = "RegionL"
        Me.RegionL.Size = New System.Drawing.Size(52, 16)
        Me.RegionL.TabIndex = 250
        Me.RegionL.Text = "Región:"
        '
        'VerListadoButton
        '
        Me.VerListadoButton.Location = New System.Drawing.Point(873, 3)
        Me.VerListadoButton.Name = "VerListadoButton"
        Me.VerListadoButton.Size = New System.Drawing.Size(108, 28)
        Me.VerListadoButton.TabIndex = 248
        Me.VerListadoButton.Text = "Ver Listado"
        Me.VerListadoButton.UseVisualStyleBackColor = True
        '
        'TSlist
        '
        Me.TSlist.FormattingEnabled = True
        Me.TSlist.Location = New System.Drawing.Point(746, 3)
        Me.TSlist.Name = "TSlist"
        Me.TSlist.Size = New System.Drawing.Size(121, 24)
        Me.TSlist.TabIndex = 247
        '
        'TSL
        '
        Me.TSL.AutoSize = True
        Me.TSL.BackColor = System.Drawing.Color.Transparent
        Me.TSL.Location = New System.Drawing.Point(712, 0)
        Me.TSL.Name = "TSL"
        Me.TSL.Size = New System.Drawing.Size(28, 16)
        Me.TSL.TabIndex = 249
        Me.TSL.Text = "TS:"
        '
        'TotalL
        '
        Me.TotalL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalL.AutoSize = True
        Me.TotalL.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TotalL.Location = New System.Drawing.Point(3, 0)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(16, 34)
        Me.TotalL.TabIndex = 253
        Me.TotalL.Text = "_"
        Me.TotalL.Visible = False
        '
        'AplicaCombo
        '
        Me.AplicaCombo.FormattingEnabled = True
        Me.AplicaCombo.Items.AddRange(New Object() {"", "SI", "NO"})
        Me.AplicaCombo.Location = New System.Drawing.Point(468, 3)
        Me.AplicaCombo.Name = "AplicaCombo"
        Me.AplicaCombo.Size = New System.Drawing.Size(67, 24)
        Me.AplicaCombo.TabIndex = 252
        '
        'ListadoGeneralFamiliasAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.FamiliasList)
        Me.Controls.Add(Me.OpTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ListadoGeneralFamiliasAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado General Familias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        CType(Me.FamiliasList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpTable.ResumeLayout(False)
        Me.OpTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents FamiliasList As System.Windows.Forms.DataGridView
    Friend WithEvents OpTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionV As System.Windows.Forms.ComboBox
    Friend WithEvents RegionL As System.Windows.Forms.Label
    Friend WithEvents VerListadoButton As System.Windows.Forms.Button
    Friend WithEvents TSlist As System.Windows.Forms.ComboBox
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents AplicaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents aplicaL As System.Windows.Forms.Label
    Friend WithEvents TotalL As System.Windows.Forms.Label
End Class
