<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResumenTS))
        Me.FamiliaresL = New System.Windows.Forms.Label()
        Me.IndividualesL = New System.Windows.Forms.Label()
        Me.FamiliarGrid = New System.Windows.Forms.DataGridView()
        Me.ResumenTable = New System.Windows.Forms.TableLayoutPanel()
        Me.IndividualGrid = New System.Windows.Forms.DataGridView()
        Me.DireccionV = New System.Windows.Forms.Label()
        Me.DireccionL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MesesV = New System.Windows.Forms.TextBox()
        Me.MesesL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.RefMedicasButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ReferenciaV = New System.Windows.Forms.Label()
        CType(Me.FamiliarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResumenTable.SuspendLayout()
        CType(Me.IndividualGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'FamiliaresL
        '
        Me.FamiliaresL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaresL.AutoSize = True
        Me.FamiliaresL.BackColor = System.Drawing.Color.Navy
        Me.FamiliaresL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaresL.ForeColor = System.Drawing.Color.White
        Me.FamiliaresL.Location = New System.Drawing.Point(519, 0)
        Me.FamiliaresL.Name = "FamiliaresL"
        Me.FamiliaresL.Size = New System.Drawing.Size(262, 25)
        Me.FamiliaresL.TabIndex = 1
        Me.FamiliaresL.Text = "ACTIVIDADES FAMILIARES"
        Me.FamiliaresL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IndividualesL
        '
        Me.IndividualesL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndividualesL.AutoSize = True
        Me.IndividualesL.BackColor = System.Drawing.Color.SteelBlue
        Me.IndividualesL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndividualesL.ForeColor = System.Drawing.Color.White
        Me.IndividualesL.Location = New System.Drawing.Point(3, 0)
        Me.IndividualesL.Name = "IndividualesL"
        Me.IndividualesL.Size = New System.Drawing.Size(490, 25)
        Me.IndividualesL.TabIndex = 0
        Me.IndividualesL.Text = "ACTIVIDADES INDIVIDUALES"
        Me.IndividualesL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FamiliarGrid
        '
        Me.FamiliarGrid.AllowUserToAddRows = False
        Me.FamiliarGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliarGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FamiliarGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.FamiliarGrid.BackgroundColor = System.Drawing.Color.White
        Me.FamiliarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FamiliarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamiliarGrid.Location = New System.Drawing.Point(519, 28)
        Me.FamiliarGrid.Name = "FamiliarGrid"
        Me.FamiliarGrid.ReadOnly = True
        Me.FamiliarGrid.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliarGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.FamiliarGrid.Size = New System.Drawing.Size(262, 532)
        Me.FamiliarGrid.TabIndex = 228
        '
        'ResumenTable
        '
        Me.ResumenTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResumenTable.BackColor = System.Drawing.Color.Transparent
        Me.ResumenTable.ColumnCount = 3
        Me.ResumenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.ResumenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ResumenTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.ResumenTable.Controls.Add(Me.FamiliaresL, 2, 0)
        Me.ResumenTable.Controls.Add(Me.IndividualesL, 0, 0)
        Me.ResumenTable.Controls.Add(Me.IndividualGrid, 0, 1)
        Me.ResumenTable.Controls.Add(Me.FamiliarGrid, 2, 1)
        Me.ResumenTable.Location = New System.Drawing.Point(0, 187)
        Me.ResumenTable.Name = "ResumenTable"
        Me.ResumenTable.RowCount = 2
        Me.ResumenTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ResumenTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ResumenTable.Size = New System.Drawing.Size(784, 563)
        Me.ResumenTable.TabIndex = 247
        Me.ResumenTable.Visible = False
        '
        'IndividualGrid
        '
        Me.IndividualGrid.AllowUserToAddRows = False
        Me.IndividualGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndividualGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.IndividualGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndividualGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.IndividualGrid.BackgroundColor = System.Drawing.Color.White
        Me.IndividualGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IndividualGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.IndividualGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IndividualGrid.Location = New System.Drawing.Point(3, 28)
        Me.IndividualGrid.Name = "IndividualGrid"
        Me.IndividualGrid.ReadOnly = True
        Me.IndividualGrid.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndividualGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.IndividualGrid.Size = New System.Drawing.Size(490, 532)
        Me.IndividualGrid.TabIndex = 226
        '
        'DireccionV
        '
        Me.DireccionV.AutoSize = True
        Me.DireccionV.BackColor = System.Drawing.Color.Transparent
        Me.DireccionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DireccionV.Location = New System.Drawing.Point(72, 0)
        Me.DireccionV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionV.Name = "DireccionV"
        Me.DireccionV.Size = New System.Drawing.Size(15, 16)
        Me.DireccionV.TabIndex = 48
        Me.DireccionV.Text = "_"
        Me.DireccionV.Visible = False
        '
        'DireccionL
        '
        Me.DireccionL.AutoSize = True
        Me.DireccionL.BackColor = System.Drawing.Color.Transparent
        Me.DireccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DireccionL.Location = New System.Drawing.Point(2, 0)
        Me.DireccionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionL.Name = "DireccionL"
        Me.DireccionL.Size = New System.Drawing.Size(66, 16)
        Me.DireccionL.TabIndex = 47
        Me.DireccionL.Text = "Dirección:"
        Me.DireccionL.Visible = False
        '
        'FamiliaV
        '
        Me.FamiliaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaV.BackColor = System.Drawing.Color.White
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FamiliaV.Location = New System.Drawing.Point(684, 3)
        Me.FamiliaV.MaxLength = 6
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(97, 29)
        Me.FamiliaV.TabIndex = 49
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(487, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 18)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Familia:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MesesV
        '
        Me.MesesV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesesV.Location = New System.Drawing.Point(684, 38)
        Me.MesesV.Name = "MesesV"
        Me.MesesV.Size = New System.Drawing.Size(43, 22)
        Me.MesesV.TabIndex = 55
        Me.MesesV.Text = "4"
        Me.MesesV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MesesL
        '
        Me.MesesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MesesL.AutoSize = True
        Me.MesesL.BackColor = System.Drawing.Color.Transparent
        Me.MesesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesesL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MesesL.Location = New System.Drawing.Point(487, 35)
        Me.MesesL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MesesL.Name = "MesesL"
        Me.MesesL.Size = New System.Drawing.Size(192, 16)
        Me.MesesL.TabIndex = 42
        Me.MesesL.Text = "Cantidad de meses a mostrar:"
        Me.MesesL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel7.ColumnCount = 5
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.DireccionV, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.DireccionL, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.FamiliaV, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.MesesV, 4, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.MesesL, 3, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.ReferenciaV, 0, 1)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(784, 61)
        Me.TableLayoutPanel7.TabIndex = 246
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 256
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
        Me.opcionesTable.Controls.Add(Me.RefMedicasButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'RefMedicasButton
        '
        Me.RefMedicasButton.BackColor = System.Drawing.Color.AliceBlue
        Me.RefMedicasButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.HEAL
        Me.RefMedicasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefMedicasButton.Location = New System.Drawing.Point(637, 3)
        Me.RefMedicasButton.Name = "RefMedicasButton"
        Me.RefMedicasButton.Size = New System.Drawing.Size(48, 45)
        Me.RefMedicasButton.TabIndex = 239
        Me.RefMedicasButton.UseVisualStyleBackColor = False
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
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(582, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(49, 45)
        Me.NuevoButton.TabIndex = 236
        Me.NuevoButton.UseVisualStyleBackColor = False
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
        Me.Title.Text = "Resumen TS"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReferenciaV
        '
        Me.ReferenciaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferenciaV.AutoSize = True
        Me.TableLayoutPanel7.SetColumnSpan(Me.ReferenciaV, 3)
        Me.ReferenciaV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenciaV.ForeColor = System.Drawing.Color.Red
        Me.ReferenciaV.Location = New System.Drawing.Point(3, 35)
        Me.ReferenciaV.Name = "ReferenciaV"
        Me.ReferenciaV.Size = New System.Drawing.Size(479, 18)
        Me.ReferenciaV.TabIndex = 207
        Me.ReferenciaV.Text = "."
        Me.ReferenciaV.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ResumenTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ResumenTable)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ResumenTS"
        Me.Text = "Resumen TS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FamiliarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumenTable.ResumeLayout(False)
        Me.ResumenTable.PerformLayout()
        CType(Me.IndividualGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FamiliaresL As System.Windows.Forms.Label
    Friend WithEvents IndividualesL As System.Windows.Forms.Label
    Friend WithEvents FamiliarGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ResumenTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents IndividualGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DireccionV As System.Windows.Forms.Label
    Friend WithEvents DireccionL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MesesV As System.Windows.Forms.TextBox
    Friend WithEvents MesesL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents RefMedicasButton As System.Windows.Forms.Button
    Friend WithEvents ReferenciaV As System.Windows.Forms.Label
End Class
