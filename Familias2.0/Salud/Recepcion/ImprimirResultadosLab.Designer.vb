<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirResultadosLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirResultadosLab))
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubExamen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadosGrid = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.No = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.LaboratoriosList = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaLabs = New System.Windows.Forms.DateTimePicker()
        Me.PacienteV = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintDocumentResultados = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogResultados = New System.Windows.Forms.PrintPreviewDialog()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ResultadosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Resultado
        '
        Me.Resultado.HeaderText = "Resultado"
        Me.Resultado.Name = "Resultado"
        '
        'SubExamen
        '
        Me.SubExamen.HeaderText = "SubExamen"
        Me.SubExamen.Name = "SubExamen"
        '
        'Examen
        '
        Me.Examen.HeaderText = "Examen"
        Me.Examen.Name = "Examen"
        '
        'ResultadosGrid
        '
        Me.ResultadosGrid.AllowUserToAddRows = False
        Me.ResultadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultadosGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Examen, Me.SubExamen, Me.Resultado})
        Me.ResultadosGrid.Location = New System.Drawing.Point(12, 731)
        Me.ResultadosGrid.Name = "ResultadosGrid"
        Me.ResultadosGrid.Size = New System.Drawing.Size(413, 25)
        Me.ResultadosGrid.TabIndex = 248
        Me.ResultadosGrid.Visible = False
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar.Width = 80
        '
        'No
        '
        Me.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.No.Frozen = True
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.No.Width = 53
        '
        'LaboratoriosList
        '
        Me.LaboratoriosList.AllowUserToAddRows = False
        Me.LaboratoriosList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoriosList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LaboratoriosList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LaboratoriosList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.LaboratoriosList.BackgroundColor = System.Drawing.Color.White
        Me.LaboratoriosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaboratoriosList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Eliminar, Me.Seleccionar})
        Me.LaboratoriosList.GridColor = System.Drawing.Color.White
        Me.LaboratoriosList.Location = New System.Drawing.Point(0, 161)
        Me.LaboratoriosList.Name = "LaboratoriosList"
        Me.LaboratoriosList.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoriosList.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.LaboratoriosList.Size = New System.Drawing.Size(784, 595)
        Me.LaboratoriosList.TabIndex = 247
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Imprimir"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 60
        '
        'FechaLabs
        '
        Me.FechaLabs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaLabs.Enabled = False
        Me.FechaLabs.Location = New System.Drawing.Point(485, 3)
        Me.FechaLabs.Name = "FechaLabs"
        Me.FechaLabs.Size = New System.Drawing.Size(296, 22)
        Me.FechaLabs.TabIndex = 199
        '
        'PacienteV
        '
        Me.PacienteV.AutoSize = True
        Me.PacienteV.BackColor = System.Drawing.Color.Transparent
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.Color.Black
        Me.PacienteV.Location = New System.Drawing.Point(3, 0)
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(16, 17)
        Me.PacienteV.TabIndex = 57
        Me.PacienteV.Text = "_"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FechaLabs, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PacienteV, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(784, 35)
        Me.TableLayoutPanel2.TabIndex = 246
        '
        'PrintDocumentResultados
        '
        '
        'PrintPreviewDialogResultados
        '
        Me.PrintPreviewDialogResultados.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogResultados.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogResultados.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogResultados.Enabled = True
        Me.PrintPreviewDialogResultados.Icon = CType(resources.GetObject("PrintPreviewDialogResultados.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogResultados.Name = "PrintPreviewDialogResultados"
        Me.PrintPreviewDialogResultados.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 261
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
        Me.ImprimirButton.Size = New System.Drawing.Size(49, 45)
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
        Me.Title.Text = "Imprimir Resultados de Laboratorios"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImprimirResultadosLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ResultadosGrid)
        Me.Controls.Add(Me.LaboratoriosList)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImprimirResultadosLab"
        Me.Text = "Imprimir Resultados Lab - Recepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ResultadosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Resultado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubExamen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Examen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultadosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents No As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents LaboratoriosList As System.Windows.Forms.DataGridView
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FechaLabs As System.Windows.Forms.DateTimePicker
    Friend WithEvents PacienteV As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrintDocumentResultados As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogResultados As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents ImprimirButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
