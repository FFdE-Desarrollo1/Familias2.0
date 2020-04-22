<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirRefExternas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirRefExternas))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.PrintDocumentLabs = New System.Drawing.Printing.PrintDocument()
        Me.RecetaInternaGrid = New System.Windows.Forms.DataGridView()
        Me.PlanesGrid = New System.Windows.Forms.DataGridView()
        Me.printRefExtButton = New System.Windows.Forms.Button()
        Me.RecetasExtGrid = New System.Windows.Forms.DataGridView()
        Me.ReferenciaExtGrid = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.printRecetaButton = New System.Windows.Forms.Button()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintPreviewDialogRefe = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPreviewDialogReceta = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentRefe = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentReceta = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogLabs = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPreviewDialogPlanes = New System.Windows.Forms.PrintPreviewDialog()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocumentPlanes = New System.Drawing.Printing.PrintDocument()
        Me.printLabsButton = New System.Windows.Forms.Button()
        Me.FechaPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.ActualDateP = New System.Windows.Forms.DateTimePicker()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.printPlanesButton = New System.Windows.Forms.Button()
        Me.DrL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.PacientesGrid = New System.Windows.Forms.DataGridView()
        Me.planRichTextB = New System.Windows.Forms.RichTextBox()
        Me.tempGrid = New System.Windows.Forms.DataGridView()
        Me.ReferenciasTable = New System.Windows.Forms.TableLayoutPanel()
        Me.LabsGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.RecetaInternaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetasExtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenciaExtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FechaPanel.SuspendLayout()
        CType(Me.PacientesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReferenciasTable.SuspendLayout()
        CType(Me.LabsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.BackColor = System.Drawing.Color.PeachPuff
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(3, 262)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(175, 28)
        Me.PacienteL.TabIndex = 411
        Me.PacienteL.Text = "Paciente"
        '
        'PrintDocumentLabs
        '
        '
        'RecetaInternaGrid
        '
        Me.RecetaInternaGrid.AllowUserToAddRows = False
        Me.RecetaInternaGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.RecetaInternaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RecetaInternaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecetaInternaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RecetaInternaGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.RecetaInternaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecetaInternaGrid.Location = New System.Drawing.Point(606, 447)
        Me.RecetaInternaGrid.Name = "RecetaInternaGrid"
        Me.RecetaInternaGrid.ReadOnly = True
        Me.RecetaInternaGrid.RowHeadersWidth = 20
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetaInternaGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.RecetaInternaGrid.Size = New System.Drawing.Size(175, 152)
        Me.RecetaInternaGrid.TabIndex = 416
        Me.RecetaInternaGrid.Visible = False
        '
        'PlanesGrid
        '
        Me.PlanesGrid.AllowUserToAddRows = False
        Me.PlanesGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple
        Me.PlanesGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.PlanesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlanesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PlanesGrid.BackgroundColor = System.Drawing.Color.Lavender
        Me.PlanesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanesGrid.Location = New System.Drawing.Point(606, 343)
        Me.PlanesGrid.Name = "PlanesGrid"
        Me.PlanesGrid.ReadOnly = True
        Me.PlanesGrid.RowHeadersWidth = 20
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlanesGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.PlanesGrid.Size = New System.Drawing.Size(175, 98)
        Me.PlanesGrid.TabIndex = 416
        Me.PlanesGrid.Visible = False
        '
        'printRefExtButton
        '
        Me.printRefExtButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printRefExtButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printRefExtButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.printRefExtButton.Location = New System.Drawing.Point(204, 293)
        Me.printRefExtButton.Name = "printRefExtButton"
        Me.printRefExtButton.Size = New System.Drawing.Size(175, 44)
        Me.printRefExtButton.TabIndex = 198
        Me.printRefExtButton.Text = "Referencias"
        Me.printRefExtButton.UseVisualStyleBackColor = True
        Me.printRefExtButton.Visible = False
        '
        'RecetasExtGrid
        '
        Me.RecetasExtGrid.AllowUserToAddRows = False
        Me.RecetasExtGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Purple
        Me.RecetasExtGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.RecetasExtGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecetasExtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RecetasExtGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.RecetasExtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecetasExtGrid.Location = New System.Drawing.Point(3, 343)
        Me.RecetasExtGrid.Name = "RecetasExtGrid"
        Me.RecetasExtGrid.ReadOnly = True
        Me.RecetasExtGrid.RowHeadersWidth = 20
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetasExtGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.ReferenciasTable.SetRowSpan(Me.RecetasExtGrid, 2)
        Me.RecetasExtGrid.Size = New System.Drawing.Size(175, 256)
        Me.RecetasExtGrid.TabIndex = 409
        Me.RecetasExtGrid.Visible = False
        '
        'ReferenciaExtGrid
        '
        Me.ReferenciaExtGrid.AllowUserToAddRows = False
        Me.ReferenciaExtGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Purple
        Me.ReferenciaExtGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.ReferenciaExtGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferenciaExtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ReferenciaExtGrid.BackgroundColor = System.Drawing.Color.Lavender
        Me.ReferenciaExtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReferenciaExtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.ReferenciaExtGrid.Location = New System.Drawing.Point(204, 343)
        Me.ReferenciaExtGrid.Name = "ReferenciaExtGrid"
        Me.ReferenciaExtGrid.RowHeadersWidth = 20
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenciaExtGrid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.ReferenciasTable.SetRowSpan(Me.ReferenciaExtGrid, 2)
        Me.ReferenciaExtGrid.Size = New System.Drawing.Size(175, 256)
        Me.ReferenciaExtGrid.TabIndex = 408
        Me.ReferenciaExtGrid.Visible = False
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 82
        '
        'printRecetaButton
        '
        Me.printRecetaButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printRecetaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printRecetaButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.printRecetaButton.Location = New System.Drawing.Point(3, 293)
        Me.printRecetaButton.Name = "printRecetaButton"
        Me.printRecetaButton.Size = New System.Drawing.Size(175, 44)
        Me.printRecetaButton.TabIndex = 410
        Me.printRecetaButton.Text = "Receta Externa"
        Me.printRecetaButton.UseVisualStyleBackColor = True
        Me.printRecetaButton.Visible = False
        '
        'desc
        '
        Me.desc.HeaderText = "desc"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'PrintPreviewDialogRefe
        '
        Me.PrintPreviewDialogRefe.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogRefe.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogRefe.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogRefe.Enabled = True
        Me.PrintPreviewDialogRefe.Icon = CType(resources.GetObject("PrintPreviewDialogRefe.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogRefe.Name = "PrintPreviewDialogRefe"
        Me.PrintPreviewDialogRefe.Visible = False
        '
        'PrintPreviewDialogReceta
        '
        Me.PrintPreviewDialogReceta.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogReceta.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogReceta.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogReceta.Enabled = True
        Me.PrintPreviewDialogReceta.Icon = CType(resources.GetObject("PrintPreviewDialogReceta.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogReceta.Name = "PrintPreviewDialogReceta"
        Me.PrintPreviewDialogReceta.Visible = False
        '
        'PrintDocumentRefe
        '
        '
        'PrintDocumentReceta
        '
        '
        'PrintPreviewDialogLabs
        '
        Me.PrintPreviewDialogLabs.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogLabs.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogLabs.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogLabs.Enabled = True
        Me.PrintPreviewDialogLabs.Icon = CType(resources.GetObject("PrintPreviewDialogLabs.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogLabs.Name = "PrintPreviewDialogRefe"
        Me.PrintPreviewDialogLabs.Visible = False
        '
        'PrintPreviewDialogPlanes
        '
        Me.PrintPreviewDialogPlanes.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogPlanes.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogPlanes.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogPlanes.Enabled = True
        Me.PrintPreviewDialogPlanes.Icon = CType(resources.GetObject("PrintPreviewDialogPlanes.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogPlanes.Name = "PrintPreviewDialogRefe"
        Me.PrintPreviewDialogPlanes.Visible = False
        '
        'tipo
        '
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'PrintDocumentPlanes
        '
        '
        'printLabsButton
        '
        Me.printLabsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printLabsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printLabsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.printLabsButton.Location = New System.Drawing.Point(405, 293)
        Me.printLabsButton.Name = "printLabsButton"
        Me.printLabsButton.Size = New System.Drawing.Size(175, 44)
        Me.printLabsButton.TabIndex = 414
        Me.printLabsButton.Text = "Orden Laboratorios"
        Me.printLabsButton.UseVisualStyleBackColor = True
        Me.printLabsButton.Visible = False
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
        Me.FechaPanel.Size = New System.Drawing.Size(784, 34)
        Me.FechaPanel.TabIndex = 244
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
        Me.FechaL.Location = New System.Drawing.Point(293, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(48, 34)
        Me.FechaL.TabIndex = 6
        Me.FechaL.Text = "Fecha:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActualDateP
        '
        Me.ActualDateP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualDateP.Location = New System.Drawing.Point(347, 3)
        Me.ActualDateP.Name = "ActualDateP"
        Me.ActualDateP.Size = New System.Drawing.Size(334, 22)
        Me.ActualDateP.TabIndex = 30
        '
        'GenerarButton
        '
        Me.GenerarButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenerarButton.Location = New System.Drawing.Point(687, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(94, 28)
        Me.GenerarButton.TabIndex = 31
        Me.GenerarButton.Text = "Mostrar Listado"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'printPlanesButton
        '
        Me.printPlanesButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printPlanesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printPlanesButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.printPlanesButton.Location = New System.Drawing.Point(606, 293)
        Me.printPlanesButton.Name = "printPlanesButton"
        Me.printPlanesButton.Size = New System.Drawing.Size(175, 44)
        Me.printPlanesButton.TabIndex = 416
        Me.printPlanesButton.Text = "Plan Educacional y Receta Interna"
        Me.printPlanesButton.UseVisualStyleBackColor = True
        Me.printPlanesButton.Visible = False
        '
        'DrL
        '
        Me.DrL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrL.AutoSize = True
        Me.DrL.BackColor = System.Drawing.Color.PeachPuff
        Me.DrL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrL.Location = New System.Drawing.Point(606, 262)
        Me.DrL.Name = "DrL"
        Me.DrL.Size = New System.Drawing.Size(175, 28)
        Me.DrL.TabIndex = 412
        Me.DrL.Text = "Dr"
        Me.DrL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.BackColor = System.Drawing.Color.PeachPuff
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(204, 262)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(175, 28)
        Me.FamiliaL.TabIndex = 413
        Me.FamiliaL.Text = "Familia"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FamiliaL.Visible = False
        '
        'PacientesGrid
        '
        Me.PacientesGrid.AllowUserToAddRows = False
        Me.PacientesGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacientesGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.PacientesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacientesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PacientesGrid.BackgroundColor = System.Drawing.Color.White
        Me.PacientesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PacientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReferenciasTable.SetColumnSpan(Me.PacientesGrid, 7)
        Me.PacientesGrid.Location = New System.Drawing.Point(3, 3)
        Me.PacientesGrid.Name = "PacientesGrid"
        Me.PacientesGrid.ReadOnly = True
        Me.PacientesGrid.RowHeadersWidth = 10
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacientesGrid.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.PacientesGrid.Size = New System.Drawing.Size(778, 256)
        Me.PacientesGrid.TabIndex = 205
        '
        'planRichTextB
        '
        Me.planRichTextB.Location = New System.Drawing.Point(586, 343)
        Me.planRichTextB.Name = "planRichTextB"
        Me.planRichTextB.Size = New System.Drawing.Size(14, 88)
        Me.planRichTextB.TabIndex = 417
        Me.planRichTextB.Text = ""
        Me.planRichTextB.Visible = False
        '
        'tempGrid
        '
        Me.tempGrid.AllowUserToAddRows = False
        Me.tempGrid.AllowUserToDeleteRows = False
        Me.tempGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tempGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desc, Me.tipo})
        Me.tempGrid.Location = New System.Drawing.Point(586, 447)
        Me.tempGrid.Name = "tempGrid"
        Me.tempGrid.ReadOnly = True
        Me.tempGrid.Size = New System.Drawing.Size(14, 135)
        Me.tempGrid.TabIndex = 418
        Me.tempGrid.Visible = False
        '
        'ReferenciasTable
        '
        Me.ReferenciasTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferenciasTable.BackColor = System.Drawing.Color.Transparent
        Me.ReferenciasTable.ColumnCount = 7
        Me.ReferenciasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ReferenciasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ReferenciasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ReferenciasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ReferenciasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ReferenciasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ReferenciasTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ReferenciasTable.Controls.Add(Me.RecetaInternaGrid, 6, 4)
        Me.ReferenciasTable.Controls.Add(Me.PlanesGrid, 6, 3)
        Me.ReferenciasTable.Controls.Add(Me.printRefExtButton, 2, 2)
        Me.ReferenciasTable.Controls.Add(Me.RecetasExtGrid, 0, 3)
        Me.ReferenciasTable.Controls.Add(Me.ReferenciaExtGrid, 2, 3)
        Me.ReferenciasTable.Controls.Add(Me.printRecetaButton, 0, 2)
        Me.ReferenciasTable.Controls.Add(Me.PacienteL, 0, 1)
        Me.ReferenciasTable.Controls.Add(Me.printLabsButton, 4, 2)
        Me.ReferenciasTable.Controls.Add(Me.LabsGrid, 4, 3)
        Me.ReferenciasTable.Controls.Add(Me.printPlanesButton, 6, 2)
        Me.ReferenciasTable.Controls.Add(Me.DrL, 6, 1)
        Me.ReferenciasTable.Controls.Add(Me.FamiliaL, 2, 1)
        Me.ReferenciasTable.Controls.Add(Me.PacientesGrid, 0, 0)
        Me.ReferenciasTable.Controls.Add(Me.planRichTextB, 5, 3)
        Me.ReferenciasTable.Controls.Add(Me.tempGrid, 5, 4)
        Me.ReferenciasTable.Location = New System.Drawing.Point(0, 156)
        Me.ReferenciasTable.Name = "ReferenciasTable"
        Me.ReferenciasTable.RowCount = 5
        Me.ReferenciasTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ReferenciasTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.ReferenciasTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.ReferenciasTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ReferenciasTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.ReferenciasTable.Size = New System.Drawing.Size(784, 602)
        Me.ReferenciasTable.TabIndex = 245
        '
        'LabsGrid
        '
        Me.LabsGrid.AllowUserToAddRows = False
        Me.LabsGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Purple
        Me.LabsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.LabsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.LabsGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.LabsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LabsGrid.Location = New System.Drawing.Point(405, 343)
        Me.LabsGrid.Name = "LabsGrid"
        Me.LabsGrid.ReadOnly = True
        Me.LabsGrid.RowHeadersWidth = 20
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabsGrid.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.ReferenciasTable.SetRowSpan(Me.LabsGrid, 2)
        Me.LabsGrid.Size = New System.Drawing.Size(175, 256)
        Me.LabsGrid.TabIndex = 415
        Me.LabsGrid.Visible = False
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
        Me.Title.Text = "Imprimir Referencias"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImprimirRefExternas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.FechaPanel)
        Me.Controls.Add(Me.ReferenciasTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImprimirRefExternas"
        Me.Text = "Imprimir Ref. Externas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RecetaInternaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetasExtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenciaExtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FechaPanel.ResumeLayout(False)
        Me.FechaPanel.PerformLayout()
        CType(Me.PacientesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReferenciasTable.ResumeLayout(False)
        Me.ReferenciasTable.PerformLayout()
        CType(Me.LabsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents PrintDocumentLabs As System.Drawing.Printing.PrintDocument
    Friend WithEvents RecetaInternaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PlanesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents printRefExtButton As System.Windows.Forms.Button
    Friend WithEvents RecetasExtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ReferenciasTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReferenciaExtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents printRecetaButton As System.Windows.Forms.Button
    Friend WithEvents printLabsButton As System.Windows.Forms.Button
    Friend WithEvents LabsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents printPlanesButton As System.Windows.Forms.Button
    Friend WithEvents DrL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents PacientesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents planRichTextB As System.Windows.Forms.RichTextBox
    Friend WithEvents tempGrid As System.Windows.Forms.DataGridView
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewDialogRefe As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintPreviewDialogReceta As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocumentRefe As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocumentReceta As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogLabs As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintPreviewDialogPlanes As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocumentPlanes As System.Drawing.Printing.PrintDocument
    Friend WithEvents FechaPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents ActualDateP As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
