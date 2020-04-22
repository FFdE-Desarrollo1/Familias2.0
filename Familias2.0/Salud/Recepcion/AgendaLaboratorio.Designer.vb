<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgendaLaboratorio
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgendaLaboratorio))
        Me.FechaPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.ActualDateP = New System.Windows.Forms.DateTimePicker()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.LaboratoriosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PatientsListG = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DetalleTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PacienteV = New System.Windows.Forms.Label()
        Me.RecetaSelGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.FechaPanel.SuspendLayout()
        Me.LaboratoriosTable.SuspendLayout()
        CType(Me.PatientsListG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetalleTable.SuspendLayout()
        CType(Me.RecetaSelGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'FechaPanel
        '
        Me.FechaPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.FechaPanel.ColumnCount = 4
        Me.FechaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FechaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FechaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FechaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.FechaPanel.Controls.Add(Me.FechaL, 1, 0)
        Me.FechaPanel.Controls.Add(Me.ActualDateP, 2, 0)
        Me.FechaPanel.Controls.Add(Me.GenerarButton, 3, 0)
        Me.FechaPanel.Location = New System.Drawing.Point(0, 120)
        Me.FechaPanel.Name = "FechaPanel"
        Me.FechaPanel.RowCount = 1
        Me.FechaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FechaPanel.Size = New System.Drawing.Size(784, 31)
        Me.FechaPanel.TabIndex = 243
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
        Me.FechaL.Location = New System.Drawing.Point(333, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(48, 31)
        Me.FechaL.TabIndex = 6
        Me.FechaL.Text = "Fecha:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActualDateP
        '
        Me.ActualDateP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualDateP.Location = New System.Drawing.Point(387, 3)
        Me.ActualDateP.Name = "ActualDateP"
        Me.ActualDateP.Size = New System.Drawing.Size(294, 22)
        Me.ActualDateP.TabIndex = 30
        '
        'GenerarButton
        '
        Me.GenerarButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenerarButton.Location = New System.Drawing.Point(687, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(94, 25)
        Me.GenerarButton.TabIndex = 31
        Me.GenerarButton.Text = "Mostrar Agenda"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'LaboratoriosTable
        '
        Me.LaboratoriosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LaboratoriosTable.BackColor = System.Drawing.Color.Transparent
        Me.LaboratoriosTable.ColumnCount = 3
        Me.LaboratoriosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.LaboratoriosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LaboratoriosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.LaboratoriosTable.Controls.Add(Me.PatientsListG, 0, 0)
        Me.LaboratoriosTable.Controls.Add(Me.DetalleTable, 2, 0)
        Me.LaboratoriosTable.Location = New System.Drawing.Point(0, 155)
        Me.LaboratoriosTable.Name = "LaboratoriosTable"
        Me.LaboratoriosTable.RowCount = 1
        Me.LaboratoriosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LaboratoriosTable.Size = New System.Drawing.Size(784, 605)
        Me.LaboratoriosTable.TabIndex = 244
        '
        'PatientsListG
        '
        Me.PatientsListG.AllowUserToAddRows = False
        Me.PatientsListG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientsListG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PatientsListG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PatientsListG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PatientsListG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PatientsListG.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.PatientsListG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientsListG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion, Me.Column1})
        Me.PatientsListG.Location = New System.Drawing.Point(3, 3)
        Me.PatientsListG.Name = "PatientsListG"
        Me.PatientsListG.ReadOnly = True
        Me.PatientsListG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsListG.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.PatientsListG.RowTemplate.ReadOnly = True
        Me.PatientsListG.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientsListG.Size = New System.Drawing.Size(490, 599)
        Me.PatientsListG.TabIndex = 213
        '
        'Accion
        '
        Me.Accion.HeaderText = "_"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        Me.Accion.Width = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "__"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 28
        '
        'DetalleTable
        '
        Me.DetalleTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleTable.ColumnCount = 1
        Me.DetalleTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DetalleTable.Controls.Add(Me.PacienteV, 0, 0)
        Me.DetalleTable.Controls.Add(Me.RecetaSelGrid, 0, 1)
        Me.DetalleTable.Location = New System.Drawing.Point(519, 3)
        Me.DetalleTable.Name = "DetalleTable"
        Me.DetalleTable.RowCount = 2
        Me.DetalleTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DetalleTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DetalleTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DetalleTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DetalleTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DetalleTable.Size = New System.Drawing.Size(262, 599)
        Me.DetalleTable.TabIndex = 214
        '
        'PacienteV
        '
        Me.PacienteV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteV.AutoSize = True
        Me.PacienteV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.Color.Black
        Me.PacienteV.Location = New System.Drawing.Point(3, 0)
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(256, 20)
        Me.PacienteV.TabIndex = 57
        Me.PacienteV.Text = "_"
        '
        'RecetaSelGrid
        '
        Me.RecetaSelGrid.AllowUserToAddRows = False
        Me.RecetaSelGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple
        Me.RecetaSelGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.RecetaSelGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecetaSelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RecetaSelGrid.BackgroundColor = System.Drawing.Color.White
        Me.RecetaSelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecetaSelGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLinkColumn1})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecetaSelGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.RecetaSelGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RecetaSelGrid.Location = New System.Drawing.Point(3, 23)
        Me.RecetaSelGrid.Name = "RecetaSelGrid"
        Me.RecetaSelGrid.ReadOnly = True
        Me.RecetaSelGrid.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetaSelGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.RecetaSelGrid.Size = New System.Drawing.Size(256, 573)
        Me.RecetaSelGrid.TabIndex = 214
        '
        'DataGridViewLinkColumn1
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple
        Me.DataGridViewLinkColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewLinkColumn1.Frozen = True
        Me.DataGridViewLinkColumn1.HeaderText = "No."
        Me.DataGridViewLinkColumn1.Name = "DataGridViewLinkColumn1"
        Me.DataGridViewLinkColumn1.ReadOnly = True
        Me.DataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewLinkColumn1.Width = 34
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 255
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
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
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
        Me.Title.Text = "Agenda Diaria de Laboratorios"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgendaLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.FechaPanel)
        Me.Controls.Add(Me.LaboratoriosTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgendaLaboratorio"
        Me.Text = "Agenda del Laboratorio - Recepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FechaPanel.ResumeLayout(False)
        Me.FechaPanel.PerformLayout()
        Me.LaboratoriosTable.ResumeLayout(False)
        CType(Me.PatientsListG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetalleTable.ResumeLayout(False)
        Me.DetalleTable.PerformLayout()
        CType(Me.RecetaSelGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FechaPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents ActualDateP As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents LaboratoriosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PatientsListG As System.Windows.Forms.DataGridView
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DetalleTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PacienteV As System.Windows.Forms.Label
    Friend WithEvents RecetaSelGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewLinkColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
