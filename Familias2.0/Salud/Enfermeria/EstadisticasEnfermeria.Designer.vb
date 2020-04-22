<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticasEnfermeria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadisticasEnfermeria))
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.aFechaL = New System.Windows.Forms.Label()
        Me.AFecha = New System.Windows.Forms.DateTimePicker()
        Me.DeFecha = New System.Windows.Forms.DateTimePicker()
        Me.deFechaL = New System.Windows.Forms.Label()
        Me.AtendidosButton = New System.Windows.Forms.Button()
        Me.TratamientosDiaButton = New System.Windows.Forms.Button()
        Me.PorTratamientosButton = New System.Windows.Forms.Button()
        Me.OpcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.porMedicoButton = New System.Windows.Forms.Button()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.BotonesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PendientesButton = New System.Windows.Forms.Button()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpcionesTable.SuspendLayout()
        Me.BotonesTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 238)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(784, 522)
        Me.ListadoGrid.TabIndex = 251
        '
        'aFechaL
        '
        Me.aFechaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aFechaL.AutoSize = True
        Me.aFechaL.Location = New System.Drawing.Point(450, 0)
        Me.aFechaL.Name = "aFechaL"
        Me.aFechaL.Size = New System.Drawing.Size(60, 16)
        Me.aFechaL.TabIndex = 216
        Me.aFechaL.Text = "A Fecha:"
        Me.aFechaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AFecha
        '
        Me.AFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AFecha.Location = New System.Drawing.Point(516, 3)
        Me.AFecha.Name = "AFecha"
        Me.AFecha.Size = New System.Drawing.Size(265, 22)
        Me.AFecha.TabIndex = 214
        '
        'DeFecha
        '
        Me.DeFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeFecha.Location = New System.Drawing.Point(176, 3)
        Me.DeFecha.Name = "DeFecha"
        Me.DeFecha.Size = New System.Drawing.Size(268, 22)
        Me.DeFecha.TabIndex = 202
        '
        'deFechaL
        '
        Me.deFechaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deFechaL.AutoSize = True
        Me.deFechaL.Location = New System.Drawing.Point(3, 0)
        Me.deFechaL.Name = "deFechaL"
        Me.deFechaL.Size = New System.Drawing.Size(167, 16)
        Me.deFechaL.TabIndex = 215
        Me.deFechaL.Text = "De Fecha:"
        Me.deFechaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AtendidosButton
        '
        Me.AtendidosButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AtendidosButton.Location = New System.Drawing.Point(402, 3)
        Me.AtendidosButton.Name = "AtendidosButton"
        Me.AtendidosButton.Size = New System.Drawing.Size(107, 53)
        Me.AtendidosButton.TabIndex = 220
        Me.AtendidosButton.Text = "Tratamientos Atendidos Por"
        Me.AtendidosButton.UseVisualStyleBackColor = True
        '
        'TratamientosDiaButton
        '
        Me.TratamientosDiaButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TratamientosDiaButton.Location = New System.Drawing.Point(269, 3)
        Me.TratamientosDiaButton.Name = "TratamientosDiaButton"
        Me.TratamientosDiaButton.Size = New System.Drawing.Size(107, 53)
        Me.TratamientosDiaButton.TabIndex = 219
        Me.TratamientosDiaButton.Text = "Tratamientos Realizados Por Fecha"
        Me.TratamientosDiaButton.UseVisualStyleBackColor = True
        '
        'PorTratamientosButton
        '
        Me.PorTratamientosButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorTratamientosButton.Location = New System.Drawing.Point(136, 3)
        Me.PorTratamientosButton.Name = "PorTratamientosButton"
        Me.PorTratamientosButton.Size = New System.Drawing.Size(107, 53)
        Me.PorTratamientosButton.TabIndex = 220
        Me.PorTratamientosButton.Text = "Tratamientos Realizados"
        Me.PorTratamientosButton.UseVisualStyleBackColor = True
        '
        'OpcionesTable
        '
        Me.OpcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpcionesTable.BackColor = System.Drawing.Color.AliceBlue
        Me.OpcionesTable.ColumnCount = 4
        Me.OpcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesTable.Controls.Add(Me.aFechaL, 2, 0)
        Me.OpcionesTable.Controls.Add(Me.AFecha, 3, 0)
        Me.OpcionesTable.Controls.Add(Me.DeFecha, 1, 0)
        Me.OpcionesTable.Controls.Add(Me.deFechaL, 0, 0)
        Me.OpcionesTable.Location = New System.Drawing.Point(0, 120)
        Me.OpcionesTable.Name = "OpcionesTable"
        Me.OpcionesTable.RowCount = 1
        Me.OpcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OpcionesTable.Size = New System.Drawing.Size(784, 33)
        Me.OpcionesTable.TabIndex = 249
        '
        'porMedicoButton
        '
        Me.porMedicoButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.porMedicoButton.Location = New System.Drawing.Point(3, 3)
        Me.porMedicoButton.Name = "porMedicoButton"
        Me.porMedicoButton.Size = New System.Drawing.Size(107, 53)
        Me.porMedicoButton.TabIndex = 0
        Me.porMedicoButton.Text = "Tratamientos Referidos Por Médico"
        Me.porMedicoButton.UseVisualStyleBackColor = True
        '
        'ListadoButton
        '
        Me.ListadoButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoButton.Location = New System.Drawing.Point(668, 3)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(113, 53)
        Me.ListadoButton.TabIndex = 222
        Me.ListadoButton.Text = "Listado General"
        Me.ListadoButton.UseVisualStyleBackColor = True
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.SandyBrown
        Me.TotalL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.Location = New System.Drawing.Point(3, 218)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(55, 17)
        Me.TotalL.TabIndex = 252
        Me.TotalL.Text = "Total: "
        '
        'BotonesTable
        '
        Me.BotonesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonesTable.BackColor = System.Drawing.Color.AliceBlue
        Me.BotonesTable.ColumnCount = 11
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BotonesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.BotonesTable.Controls.Add(Me.AtendidosButton, 6, 0)
        Me.BotonesTable.Controls.Add(Me.TratamientosDiaButton, 4, 0)
        Me.BotonesTable.Controls.Add(Me.PorTratamientosButton, 2, 0)
        Me.BotonesTable.Controls.Add(Me.porMedicoButton, 0, 0)
        Me.BotonesTable.Controls.Add(Me.PendientesButton, 8, 0)
        Me.BotonesTable.Controls.Add(Me.ListadoButton, 10, 0)
        Me.BotonesTable.Location = New System.Drawing.Point(0, 156)
        Me.BotonesTable.Name = "BotonesTable"
        Me.BotonesTable.RowCount = 1
        Me.BotonesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BotonesTable.Size = New System.Drawing.Size(784, 59)
        Me.BotonesTable.TabIndex = 250
        '
        'PendientesButton
        '
        Me.PendientesButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PendientesButton.Location = New System.Drawing.Point(535, 3)
        Me.PendientesButton.Name = "PendientesButton"
        Me.PendientesButton.Size = New System.Drawing.Size(107, 53)
        Me.PendientesButton.TabIndex = 221
        Me.PendientesButton.Text = "Tratamientos Pendientes"
        Me.PendientesButton.UseVisualStyleBackColor = True
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 257
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 53)
        Me.TableLayoutPanel1.TabIndex = 68
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
        Me.Title.Text = "Estadísticas Enfermería"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EstadisticasEnfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.OpcionesTable)
        Me.Controls.Add(Me.TotalL)
        Me.Controls.Add(Me.BotonesTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstadisticasEnfermeria"
        Me.Text = "Estadisticas Enfermeria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpcionesTable.ResumeLayout(False)
        Me.OpcionesTable.PerformLayout()
        Me.BotonesTable.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents aFechaL As System.Windows.Forms.Label
    Friend WithEvents AFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DeFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents deFechaL As System.Windows.Forms.Label
    Friend WithEvents AtendidosButton As System.Windows.Forms.Button
    Friend WithEvents TratamientosDiaButton As System.Windows.Forms.Button
    Friend WithEvents PorTratamientosButton As System.Windows.Forms.Button
    Friend WithEvents OpcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents porMedicoButton As System.Windows.Forms.Button
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents BotonesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PendientesButton As System.Windows.Forms.Button
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
