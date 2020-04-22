<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarResultadosLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarResultadosLab))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentResultados = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogResultados = New System.Windows.Forms.PrintPreviewDialog()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubExamen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadosGrid = New System.Windows.Forms.DataGridView()
        Me.IdResultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guarda = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NuevoRes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codeSub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.examenId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamenI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultGrid = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.No = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.LaboratoriosList = New System.Windows.Forms.DataGridView()
        Me.PrincipalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.DrV = New System.Windows.Forms.TextBox()
        Me.PacienteV = New System.Windows.Forms.Label()
        Me.SelectPresPanel = New System.Windows.Forms.Panel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ResultadosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrincipalTable.SuspendLayout()
        Me.SelectPresPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Resultado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SubExamen
        '
        Me.SubExamen.HeaderText = "SubExamen"
        Me.SubExamen.Name = "SubExamen"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Examen"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ResultadosGrid
        '
        Me.ResultadosGrid.AllowUserToAddRows = False
        Me.ResultadosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultadosGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.SubExamen, Me.DataGridViewTextBoxColumn2})
        Me.ResultadosGrid.Location = New System.Drawing.Point(3, 449)
        Me.ResultadosGrid.Name = "ResultadosGrid"
        Me.ResultadosGrid.Size = New System.Drawing.Size(299, 136)
        Me.ResultadosGrid.TabIndex = 215
        Me.ResultadosGrid.Visible = False
        '
        'IdResultado
        '
        Me.IdResultado.HeaderText = "ID"
        Me.IdResultado.Name = "IdResultado"
        Me.IdResultado.Visible = False
        '
        'Guarda
        '
        Me.Guarda.HeaderText = "Opción"
        Me.Guarda.Name = "Guarda"
        Me.Guarda.ReadOnly = True
        Me.Guarda.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guarda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'NuevoRes
        '
        Me.NuevoRes.HeaderText = "Cambiar A"
        Me.NuevoRes.Name = "NuevoRes"
        '
        'codeSub
        '
        Me.codeSub.FillWeight = 100.2972!
        Me.codeSub.HeaderText = "codeSub"
        Me.codeSub.Name = "codeSub"
        Me.codeSub.ReadOnly = True
        '
        'examenId
        '
        Me.examenId.FillWeight = 102.3523!
        Me.examenId.HeaderText = "examenId"
        Me.examenId.Name = "examenId"
        Me.examenId.ReadOnly = True
        '
        'Resultado
        '
        Me.Resultado.FillWeight = 103.5736!
        Me.Resultado.HeaderText = "Resultado"
        Me.Resultado.Name = "Resultado"
        Me.Resultado.ReadOnly = True
        '
        'Examen
        '
        Me.Examen.FillWeight = 100.3115!
        Me.Examen.HeaderText = "Examen"
        Me.Examen.Name = "Examen"
        Me.Examen.ReadOnly = True
        '
        'ExamenI
        '
        Me.ExamenI.FillWeight = 93.46537!
        Me.ExamenI.HeaderText = "_Examen"
        Me.ExamenI.Name = "ExamenI"
        Me.ExamenI.ReadOnly = True
        '
        'ResultGrid
        '
        Me.ResultGrid.AllowUserToAddRows = False
        Me.ResultGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ResultGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExamenI, Me.Examen, Me.Resultado, Me.examenId, Me.codeSub, Me.NuevoRes, Me.Guarda, Me.IdResultado})
        Me.ResultGrid.Location = New System.Drawing.Point(328, 3)
        Me.ResultGrid.Name = "ResultGrid"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PrincipalTable.SetRowSpan(Me.ResultGrid, 3)
        Me.ResultGrid.Size = New System.Drawing.Size(453, 582)
        Me.ResultGrid.TabIndex = 214
        Me.ResultGrid.Visible = False
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Imprimir"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 60
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoriosList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.LaboratoriosList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LaboratoriosList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.LaboratoriosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaboratoriosList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Eliminar, Me.Seleccionar})
        Me.LaboratoriosList.GridColor = System.Drawing.Color.LightGray
        Me.LaboratoriosList.Location = New System.Drawing.Point(3, 3)
        Me.LaboratoriosList.Name = "LaboratoriosList"
        Me.LaboratoriosList.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoriosList.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.LaboratoriosList.Size = New System.Drawing.Size(299, 420)
        Me.LaboratoriosList.TabIndex = 212
        '
        'PrincipalTable
        '
        Me.PrincipalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalTable.BackColor = System.Drawing.Color.Transparent
        Me.PrincipalTable.ColumnCount = 3
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.PrincipalTable.Controls.Add(Me.LaboratoriosList, 0, 0)
        Me.PrincipalTable.Controls.Add(Me.ResultGrid, 2, 0)
        Me.PrincipalTable.Controls.Add(Me.ResultadosGrid, 0, 2)
        Me.PrincipalTable.Location = New System.Drawing.Point(0, 162)
        Me.PrincipalTable.Name = "PrincipalTable"
        Me.PrincipalTable.RowCount = 3
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.PrincipalTable.Size = New System.Drawing.Size(784, 588)
        Me.PrincipalTable.TabIndex = 248
        '
        'DrV
        '
        Me.DrV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrV.BackColor = System.Drawing.Color.SteelBlue
        Me.DrV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DrV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrV.ForeColor = System.Drawing.Color.White
        Me.DrV.Location = New System.Drawing.Point(484, 4)
        Me.DrV.Name = "DrV"
        Me.DrV.ReadOnly = True
        Me.DrV.Size = New System.Drawing.Size(297, 18)
        Me.DrV.TabIndex = 60
        Me.DrV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PacienteV
        '
        Me.PacienteV.AutoSize = True
        Me.PacienteV.BackColor = System.Drawing.Color.Transparent
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.Color.White
        Me.PacienteV.Location = New System.Drawing.Point(3, 4)
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(15, 16)
        Me.PacienteV.TabIndex = 57
        Me.PacienteV.Text = "_"
        '
        'SelectPresPanel
        '
        Me.SelectPresPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectPresPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.SelectPresPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectPresPanel.Controls.Add(Me.DrV)
        Me.SelectPresPanel.Controls.Add(Me.PacienteV)
        Me.SelectPresPanel.ForeColor = System.Drawing.Color.White
        Me.SelectPresPanel.Location = New System.Drawing.Point(0, 122)
        Me.SelectPresPanel.Name = "SelectPresPanel"
        Me.SelectPresPanel.Size = New System.Drawing.Size(784, 29)
        Me.SelectPresPanel.TabIndex = 247
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
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.ImprimirButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GuardarButton.Location = New System.Drawing.Point(582, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 69
        Me.GuardarButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(527, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(476, 3)
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
        Me.Title.Size = New System.Drawing.Size(465, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Resultados de Laboratorios"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgregarResultadosLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PrincipalTable)
        Me.Controls.Add(Me.SelectPresPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgregarResultadosLab"
        Me.Text = "Resultados de Laboratorios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ResultadosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrincipalTable.ResumeLayout(False)
        Me.SelectPresPanel.ResumeLayout(False)
        Me.SelectPresPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocumentResultados As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogResultados As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubExamen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultadosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents IdResultado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Guarda As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents NuevoRes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codeSub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents examenId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Resultado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Examen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExamenI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PrincipalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LaboratoriosList As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DrV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteV As System.Windows.Forms.Label
    Friend WithEvents SelectPresPanel As System.Windows.Forms.Panel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents ImprimirButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
End Class
