<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeCitasAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeCitasAE))
        Me.InformeGrid = New System.Windows.Forms.DataGridView()
        Me.deFechaL = New System.Windows.Forms.Label()
        Me.deFechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.aFechaL = New System.Windows.Forms.Label()
        Me.TerapeutaCombo = New System.Windows.Forms.ComboBox()
        Me.aFechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.ClinicaCombo = New System.Windows.Forms.ComboBox()
        Me.AttendanceL = New System.Windows.Forms.Label()
        Me.AsistenciaCombo = New System.Windows.Forms.ComboBox()
        Me.verInformeButton = New System.Windows.Forms.Button()
        Me.totalL = New System.Windows.Forms.Label()
        Me.totalV = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.InformeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrincipalPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'InformeGrid
        '
        Me.InformeGrid.AllowUserToAddRows = False
        Me.InformeGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.InformeGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InformeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.InformeGrid.BackgroundColor = System.Drawing.Color.White
        Me.InformeGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.InformeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InformeGrid.Location = New System.Drawing.Point(0, 190)
        Me.InformeGrid.Name = "InformeGrid"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.InformeGrid.Size = New System.Drawing.Size(784, 570)
        Me.InformeGrid.TabIndex = 237
        Me.InformeGrid.Visible = False
        '
        'deFechaL
        '
        Me.deFechaL.AutoSize = True
        Me.deFechaL.Location = New System.Drawing.Point(-76, 0)
        Me.deFechaL.Name = "deFechaL"
        Me.deFechaL.Size = New System.Drawing.Size(68, 16)
        Me.deFechaL.TabIndex = 0
        Me.deFechaL.Text = "De Fecha:"
        '
        'deFechaPicker
        '
        Me.deFechaPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deFechaPicker.Location = New System.Drawing.Point(-2, 3)
        Me.deFechaPicker.Name = "deFechaPicker"
        Me.deFechaPicker.Size = New System.Drawing.Size(294, 22)
        Me.deFechaPicker.TabIndex = 1
        '
        'aFechaL
        '
        Me.aFechaL.AutoSize = True
        Me.aFechaL.Location = New System.Drawing.Point(-76, 30)
        Me.aFechaL.Name = "aFechaL"
        Me.aFechaL.Size = New System.Drawing.Size(60, 16)
        Me.aFechaL.TabIndex = 201
        Me.aFechaL.Text = "A Fecha:"
        '
        'TerapeutaCombo
        '
        Me.TerapeutaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TerapeutaCombo.FormattingEnabled = True
        Me.TerapeutaCombo.Location = New System.Drawing.Point(318, 3)
        Me.TerapeutaCombo.Name = "TerapeutaCombo"
        Me.TerapeutaCombo.Size = New System.Drawing.Size(214, 24)
        Me.TerapeutaCombo.TabIndex = 201
        '
        'aFechaPicker
        '
        Me.aFechaPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aFechaPicker.Location = New System.Drawing.Point(-2, 33)
        Me.aFechaPicker.Name = "aFechaPicker"
        Me.aFechaPicker.Size = New System.Drawing.Size(294, 22)
        Me.aFechaPicker.TabIndex = 201
        '
        'ClinicaCombo
        '
        Me.ClinicaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClinicaCombo.BackColor = System.Drawing.Color.White
        Me.ClinicaCombo.FormattingEnabled = True
        Me.ClinicaCombo.Location = New System.Drawing.Point(318, 33)
        Me.ClinicaCombo.Name = "ClinicaCombo"
        Me.ClinicaCombo.Size = New System.Drawing.Size(214, 24)
        Me.ClinicaCombo.TabIndex = 202
        '
        'AttendanceL
        '
        Me.AttendanceL.AutoSize = True
        Me.AttendanceL.BackColor = System.Drawing.Color.Transparent
        Me.AttendanceL.Location = New System.Drawing.Point(558, 0)
        Me.AttendanceL.Name = "AttendanceL"
        Me.AttendanceL.Size = New System.Drawing.Size(73, 16)
        Me.AttendanceL.TabIndex = 206
        Me.AttendanceL.Text = "Asistencia:"
        '
        'AsistenciaCombo
        '
        Me.AsistenciaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AsistenciaCombo.BackColor = System.Drawing.Color.White
        Me.AsistenciaCombo.FormattingEnabled = True
        Me.AsistenciaCombo.Location = New System.Drawing.Point(637, 3)
        Me.AsistenciaCombo.Name = "AsistenciaCombo"
        Me.AsistenciaCombo.Size = New System.Drawing.Size(44, 24)
        Me.AsistenciaCombo.TabIndex = 203
        '
        'verInformeButton
        '
        Me.verInformeButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.verInformeButton.BackColor = System.Drawing.Color.Chocolate
        Me.verInformeButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verInformeButton.ForeColor = System.Drawing.Color.White
        Me.verInformeButton.Location = New System.Drawing.Point(707, 3)
        Me.verInformeButton.Name = "verInformeButton"
        Me.PrincipalPanel.SetRowSpan(Me.verInformeButton, 2)
        Me.verInformeButton.Size = New System.Drawing.Size(74, 59)
        Me.verInformeButton.TabIndex = 207
        Me.verInformeButton.Text = "Ver Informe"
        Me.verInformeButton.UseVisualStyleBackColor = False
        '
        'totalL
        '
        Me.totalL.AutoSize = True
        Me.totalL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.totalL.Location = New System.Drawing.Point(3, 30)
        Me.totalL.Name = "totalL"
        Me.totalL.Size = New System.Drawing.Size(44, 17)
        Me.totalL.TabIndex = 208
        Me.totalL.Text = "Total:"
        Me.totalL.Visible = False
        '
        'totalV
        '
        Me.totalV.AutoSize = True
        Me.totalV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalV.Location = New System.Drawing.Point(53, 30)
        Me.totalV.Name = "totalV"
        Me.totalV.Size = New System.Drawing.Size(1, 17)
        Me.totalV.TabIndex = 209
        Me.totalV.Text = "_"
        Me.totalV.Visible = False
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.PrincipalPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PrincipalPanel.ColumnCount = 11
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.PrincipalPanel.Controls.Add(Me.deFechaL, 2, 0)
        Me.PrincipalPanel.Controls.Add(Me.deFechaPicker, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.aFechaL, 2, 1)
        Me.PrincipalPanel.Controls.Add(Me.TerapeutaCombo, 5, 0)
        Me.PrincipalPanel.Controls.Add(Me.aFechaPicker, 3, 1)
        Me.PrincipalPanel.Controls.Add(Me.ClinicaCombo, 5, 1)
        Me.PrincipalPanel.Controls.Add(Me.AttendanceL, 7, 0)
        Me.PrincipalPanel.Controls.Add(Me.AsistenciaCombo, 8, 0)
        Me.PrincipalPanel.Controls.Add(Me.verInformeButton, 10, 0)
        Me.PrincipalPanel.Controls.Add(Me.totalL, 0, 1)
        Me.PrincipalPanel.Controls.Add(Me.totalV, 1, 1)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 2
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 65)
        Me.PrincipalPanel.TabIndex = 235
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 241
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
        Me.inicioButton.TabIndex = 236
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
        Me.Title.Text = "Informe de Citas"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InformeCitasAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.InformeGrid)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "InformeCitasAE"
        Me.Text = "Informe Citas Apoyo Educativo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.InformeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InformeGrid As System.Windows.Forms.DataGridView
    Friend WithEvents deFechaL As System.Windows.Forms.Label
    Friend WithEvents deFechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents aFechaL As System.Windows.Forms.Label
    Friend WithEvents TerapeutaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents aFechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ClinicaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents AttendanceL As System.Windows.Forms.Label
    Friend WithEvents AsistenciaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents verInformeButton As System.Windows.Forms.Button
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents totalL As System.Windows.Forms.Label
    Friend WithEvents totalV As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
