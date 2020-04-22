<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeriaUtilesFamiliar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeriaUtilesFamiliar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintPreviewDialogVale = New System.Windows.Forms.PrintPreviewDialog()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me._filas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._ancho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paquete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apadrinado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvitacionGrid = New System.Windows.Forms.DataGridView()
        Me.ApadrinadoV = New System.Windows.Forms.TextBox()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.ApadrinadoL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintDocumentVale = New System.Drawing.Printing.PrintDocument()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvitacionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrincipalPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewDialogVale
        '
        Me.PrintPreviewDialogVale.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogVale.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogVale.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogVale.Enabled = True
        Me.PrintPreviewDialogVale.Icon = CType(resources.GetObject("PrintPreviewDialogVale.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogVale.Name = "PrintPreviewDialogVale"
        Me.PrintPreviewDialogVale.Visible = False
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
        Me.ListadoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 159)
        Me.ListadoGrid.Name = "ListadoGrid"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(784, 322)
        Me.ListadoGrid.TabIndex = 245
        '
        '_filas
        '
        Me._filas.HeaderText = "nFilas"
        Me._filas.Name = "_filas"
        '
        '_ancho
        '
        Me._ancho.HeaderText = "Ancho"
        Me._ancho.Name = "_ancho"
        '
        'Paquete
        '
        Me.Paquete.HeaderText = "Paquete"
        Me.Paquete.Name = "Paquete"
        '
        'Apadrinado
        '
        Me.Apadrinado.HeaderText = "Apadrinado"
        Me.Apadrinado.Name = "Apadrinado"
        '
        'InvitacionGrid
        '
        Me.InvitacionGrid.AllowUserToAddRows = False
        Me.InvitacionGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvitacionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvitacionGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apadrinado, Me.Paquete, Me._ancho, Me._filas})
        Me.InvitacionGrid.Location = New System.Drawing.Point(0, 618)
        Me.InvitacionGrid.Name = "InvitacionGrid"
        Me.InvitacionGrid.Size = New System.Drawing.Size(784, 132)
        Me.InvitacionGrid.TabIndex = 246
        Me.InvitacionGrid.Visible = False
        '
        'ApadrinadoV
        '
        Me.ApadrinadoV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApadrinadoV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ApadrinadoV.Location = New System.Drawing.Point(667, 3)
        Me.ApadrinadoV.MaxLength = 10
        Me.ApadrinadoV.Name = "ApadrinadoV"
        Me.ApadrinadoV.Size = New System.Drawing.Size(112, 40)
        Me.ApadrinadoV.TabIndex = 0
        Me.ApadrinadoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(141, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 40)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApadrinadoL
        '
        Me.ApadrinadoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApadrinadoL.AutoSize = True
        Me.ApadrinadoL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApadrinadoL.Location = New System.Drawing.Point(528, 0)
        Me.ApadrinadoL.Name = "ApadrinadoL"
        Me.ApadrinadoL.Size = New System.Drawing.Size(133, 36)
        Me.ApadrinadoL.TabIndex = 204
        Me.ApadrinadoL.Text = "Apadrinado:"
        Me.ApadrinadoL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(132, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.PrincipalPanel.Controls.Add(Me.ApadrinadoV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.ApadrinadoL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 36)
        Me.PrincipalPanel.TabIndex = 244
        '
        'PrintDocumentVale
        '
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 253
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
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.ImprimirButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(581, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(530, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 45)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'ImprimirButton
        '
        Me.ImprimirButton.BackColor = System.Drawing.Color.AliceBlue
        Me.ImprimirButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Print
        Me.ImprimirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImprimirButton.Location = New System.Drawing.Point(636, 3)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(49, 44)
        Me.ImprimirButton.TabIndex = 236
        Me.ImprimirButton.UseVisualStyleBackColor = False
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
        Me.Title.Size = New System.Drawing.Size(519, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Actualizar Información Feria Utiles"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FeriaUtilesFamiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.InvitacionGrid)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FeriaUtilesFamiliar"
        Me.Text = "Feria Utiles Familiar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvitacionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewDialogVale As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents _filas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _ancho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Paquete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apadrinado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvitacionGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ApadrinadoV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents ApadrinadoL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrintDocumentVale As System.Drawing.Printing.PrintDocument
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents ImprimirButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
