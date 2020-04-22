<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgendaMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgendaMedico))
        Me.BusquedaPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.totalL = New System.Windows.Forms.Label()
        Me.DateP = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateL = New System.Windows.Forms.Label()
        Me.DoctorC = New System.Windows.Forms.ComboBox()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.AgendaGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.BusquedaPanel.SuspendLayout()
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'BusquedaPanel
        '
        Me.BusquedaPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusquedaPanel.BackColor = System.Drawing.Color.Transparent
        Me.BusquedaPanel.ColumnCount = 7
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaPanel.Controls.Add(Me.totalL, 0, 0)
        Me.BusquedaPanel.Controls.Add(Me.DateP, 2, 0)
        Me.BusquedaPanel.Controls.Add(Me.Label1, 4, 0)
        Me.BusquedaPanel.Controls.Add(Me.DateL, 1, 0)
        Me.BusquedaPanel.Controls.Add(Me.DoctorC, 5, 0)
        Me.BusquedaPanel.Controls.Add(Me.GenerarButton, 6, 0)
        Me.BusquedaPanel.Location = New System.Drawing.Point(0, 120)
        Me.BusquedaPanel.Name = "BusquedaPanel"
        Me.BusquedaPanel.RowCount = 1
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BusquedaPanel.Size = New System.Drawing.Size(784, 32)
        Me.BusquedaPanel.TabIndex = 241
        '
        'totalL
        '
        Me.totalL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalL.AutoSize = True
        Me.totalL.Location = New System.Drawing.Point(3, 0)
        Me.totalL.Name = "totalL"
        Me.totalL.Size = New System.Drawing.Size(54, 32)
        Me.totalL.TabIndex = 197
        Me.totalL.Text = "."
        Me.totalL.Visible = False
        '
        'DateP
        '
        Me.DateP.Location = New System.Drawing.Point(122, 3)
        Me.DateP.Name = "DateP"
        Me.DateP.Size = New System.Drawing.Size(270, 22)
        Me.DateP.TabIndex = 199
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(418, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Médico:"
        '
        'DateL
        '
        Me.DateL.AutoSize = True
        Me.DateL.BackColor = System.Drawing.Color.Transparent
        Me.DateL.Location = New System.Drawing.Point(63, 0)
        Me.DateL.Name = "DateL"
        Me.DateL.Size = New System.Drawing.Size(53, 16)
        Me.DateL.TabIndex = 206
        Me.DateL.Text = "*Fecha:"
        '
        'DoctorC
        '
        Me.DoctorC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DoctorC.Enabled = False
        Me.DoctorC.FormattingEnabled = True
        Me.DoctorC.Location = New System.Drawing.Point(478, 3)
        Me.DoctorC.Name = "DoctorC"
        Me.DoctorC.Size = New System.Drawing.Size(198, 24)
        Me.DoctorC.TabIndex = 208
        '
        'GenerarButton
        '
        Me.GenerarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GenerarButton.Location = New System.Drawing.Point(682, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(99, 26)
        Me.GenerarButton.TabIndex = 209
        Me.GenerarButton.Text = "Ver Agenda"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'AgendaGrid
        '
        Me.AgendaGrid.AllowUserToAddRows = False
        Me.AgendaGrid.AllowUserToDeleteRows = False
        Me.AgendaGrid.AllowUserToResizeColumns = False
        Me.AgendaGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AgendaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgendaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AgendaGrid.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.AgendaGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.AgendaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AgendaGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.AgendaGrid.Location = New System.Drawing.Point(0, 158)
        Me.AgendaGrid.Name = "AgendaGrid"
        Me.AgendaGrid.ReadOnly = True
        Me.AgendaGrid.RowHeadersWidth = 55
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.AgendaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AgendaGrid.Size = New System.Drawing.Size(784, 601)
        Me.AgendaGrid.TabIndex = 242
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
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.Title.Text = "Agenda Médica"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgendaMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.BusquedaPanel)
        Me.Controls.Add(Me.AgendaGrid)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgendaMedico"
        Me.Text = "Agenda por Medico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BusquedaPanel.ResumeLayout(False)
        Me.BusquedaPanel.PerformLayout()
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BusquedaPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents totalL As System.Windows.Forms.Label
    Friend WithEvents DateP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateL As System.Windows.Forms.Label
    Friend WithEvents DoctorC As System.Windows.Forms.ComboBox
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents AgendaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
