<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportesLab))
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.GroupByCombo = New System.Windows.Forms.ComboBox()
        Me.LaboratorioCombo = New System.Windows.Forms.ComboBox()
        Me.GroupByL = New System.Windows.Forms.Label()
        Me.FromL = New System.Windows.Forms.Label()
        Me.DoctorCombo = New System.Windows.Forms.ComboBox()
        Me.toL = New System.Windows.Forms.Label()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.LabL = New System.Windows.Forms.Label()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.DateL = New System.Windows.Forms.Label()
        Me.DrL = New System.Windows.Forms.Label()
        Me.DetalleCheck = New System.Windows.Forms.RadioButton()
        Me.ResumenCheck = New System.Windows.Forms.RadioButton()
        Me.ResultGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.opcionesTable.SuspendLayout()
        CType(Me.ResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.SteelBlue
        Me.opcionesTable.ColumnCount = 8
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.DisplayButton, 7, 0)
        Me.opcionesTable.Controls.Add(Me.GroupByCombo, 5, 2)
        Me.opcionesTable.Controls.Add(Me.LaboratorioCombo, 5, 1)
        Me.opcionesTable.Controls.Add(Me.GroupByL, 4, 2)
        Me.opcionesTable.Controls.Add(Me.FromL, 0, 1)
        Me.opcionesTable.Controls.Add(Me.DoctorCombo, 5, 0)
        Me.opcionesTable.Controls.Add(Me.toL, 0, 2)
        Me.opcionesTable.Controls.Add(Me.FromDate, 1, 1)
        Me.opcionesTable.Controls.Add(Me.LabL, 4, 1)
        Me.opcionesTable.Controls.Add(Me.ToDate, 1, 2)
        Me.opcionesTable.Controls.Add(Me.DateL, 1, 0)
        Me.opcionesTable.Controls.Add(Me.DrL, 4, 0)
        Me.opcionesTable.Controls.Add(Me.DetalleCheck, 2, 1)
        Me.opcionesTable.Controls.Add(Me.ResumenCheck, 2, 2)
        Me.opcionesTable.Location = New System.Drawing.Point(0, 120)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 3
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.opcionesTable.Size = New System.Drawing.Size(784, 100)
        Me.opcionesTable.TabIndex = 247
        '
        'DisplayButton
        '
        Me.DisplayButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayButton.Location = New System.Drawing.Point(708, 3)
        Me.DisplayButton.Name = "DisplayButton"
        Me.opcionesTable.SetRowSpan(Me.DisplayButton, 3)
        Me.DisplayButton.Size = New System.Drawing.Size(73, 94)
        Me.DisplayButton.TabIndex = 0
        Me.DisplayButton.Text = "Generar listado"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'GroupByCombo
        '
        Me.GroupByCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupByCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupByCombo.FormattingEnabled = True
        Me.GroupByCombo.Items.AddRange(New Object() {"Laboratorio-Total", "Médico-Totales", "Médico-Mes", "Laboratorio-Mes"})
        Me.GroupByCombo.Location = New System.Drawing.Point(496, 69)
        Me.GroupByCombo.Name = "GroupByCombo"
        Me.GroupByCombo.Size = New System.Drawing.Size(186, 24)
        Me.GroupByCombo.TabIndex = 33
        Me.GroupByCombo.Visible = False
        '
        'LaboratorioCombo
        '
        Me.LaboratorioCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratorioCombo.FormattingEnabled = True
        Me.LaboratorioCombo.Location = New System.Drawing.Point(496, 36)
        Me.LaboratorioCombo.Name = "LaboratorioCombo"
        Me.LaboratorioCombo.Size = New System.Drawing.Size(186, 24)
        Me.LaboratorioCombo.TabIndex = 53
        '
        'GroupByL
        '
        Me.GroupByL.AutoSize = True
        Me.GroupByL.BackColor = System.Drawing.Color.Transparent
        Me.GroupByL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupByL.ForeColor = System.Drawing.Color.White
        Me.GroupByL.Location = New System.Drawing.Point(409, 66)
        Me.GroupByL.Name = "GroupByL"
        Me.GroupByL.Size = New System.Drawing.Size(81, 16)
        Me.GroupByL.TabIndex = 54
        Me.GroupByL.Text = "Agrupar Por:"
        Me.GroupByL.Visible = False
        '
        'FromL
        '
        Me.FromL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FromL.AutoSize = True
        Me.FromL.BackColor = System.Drawing.Color.Transparent
        Me.FromL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromL.ForeColor = System.Drawing.Color.White
        Me.FromL.Location = New System.Drawing.Point(3, 33)
        Me.FromL.Name = "FromL"
        Me.FromL.Size = New System.Drawing.Size(1, 17)
        Me.FromL.TabIndex = 6
        Me.FromL.Text = "De"
        Me.FromL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DoctorCombo
        '
        Me.DoctorCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorCombo.FormattingEnabled = True
        Me.DoctorCombo.Location = New System.Drawing.Point(496, 3)
        Me.DoctorCombo.Name = "DoctorCombo"
        Me.DoctorCombo.Size = New System.Drawing.Size(186, 24)
        Me.DoctorCombo.TabIndex = 50
        '
        'toL
        '
        Me.toL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toL.AutoSize = True
        Me.toL.BackColor = System.Drawing.Color.Transparent
        Me.toL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toL.ForeColor = System.Drawing.Color.White
        Me.toL.Location = New System.Drawing.Point(3, 66)
        Me.toL.Name = "toL"
        Me.toL.Size = New System.Drawing.Size(1, 17)
        Me.toL.TabIndex = 32
        Me.toL.Text = "A"
        Me.toL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FromDate
        '
        Me.FromDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDate.Location = New System.Drawing.Point(-12, 36)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(308, 22)
        Me.FromDate.TabIndex = 30
        '
        'LabL
        '
        Me.LabL.AutoSize = True
        Me.LabL.BackColor = System.Drawing.Color.Transparent
        Me.LabL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabL.ForeColor = System.Drawing.Color.White
        Me.LabL.Location = New System.Drawing.Point(409, 33)
        Me.LabL.Name = "LabL"
        Me.LabL.Size = New System.Drawing.Size(76, 16)
        Me.LabL.TabIndex = 52
        Me.LabL.Text = "Laboratorio:"
        '
        'ToDate
        '
        Me.ToDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDate.Location = New System.Drawing.Point(-12, 69)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(308, 22)
        Me.ToDate.TabIndex = 31
        '
        'DateL
        '
        Me.DateL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateL.AutoSize = True
        Me.DateL.BackColor = System.Drawing.Color.Transparent
        Me.DateL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateL.ForeColor = System.Drawing.Color.White
        Me.DateL.Location = New System.Drawing.Point(-12, 0)
        Me.DateL.Name = "DateL"
        Me.DateL.Size = New System.Drawing.Size(308, 16)
        Me.DateL.TabIndex = 51
        Me.DateL.Text = "Fecha"
        Me.DateL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DrL
        '
        Me.DrL.AutoSize = True
        Me.DrL.BackColor = System.Drawing.Color.Transparent
        Me.DrL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrL.ForeColor = System.Drawing.Color.White
        Me.DrL.Location = New System.Drawing.Point(409, 0)
        Me.DrL.Name = "DrL"
        Me.DrL.Size = New System.Drawing.Size(54, 16)
        Me.DrL.TabIndex = 49
        Me.DrL.Text = "Médico:"
        '
        'DetalleCheck
        '
        Me.DetalleCheck.AutoSize = True
        Me.DetalleCheck.Checked = True
        Me.DetalleCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetalleCheck.ForeColor = System.Drawing.Color.White
        Me.DetalleCheck.Location = New System.Drawing.Point(302, 36)
        Me.DetalleCheck.Name = "DetalleCheck"
        Me.DetalleCheck.Size = New System.Drawing.Size(66, 20)
        Me.DetalleCheck.TabIndex = 34
        Me.DetalleCheck.TabStop = True
        Me.DetalleCheck.Text = "Detalle"
        Me.DetalleCheck.UseVisualStyleBackColor = True
        '
        'ResumenCheck
        '
        Me.ResumenCheck.AutoSize = True
        Me.ResumenCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResumenCheck.ForeColor = System.Drawing.Color.White
        Me.ResumenCheck.Location = New System.Drawing.Point(302, 69)
        Me.ResumenCheck.Name = "ResumenCheck"
        Me.ResumenCheck.Size = New System.Drawing.Size(81, 20)
        Me.ResumenCheck.TabIndex = 35
        Me.ResumenCheck.Text = "Resumen"
        Me.ResumenCheck.UseVisualStyleBackColor = True
        '
        'ResultGrid
        '
        Me.ResultGrid.AllowUserToAddRows = False
        Me.ResultGrid.AllowUserToDeleteRows = False
        Me.ResultGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        Me.ResultGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ResultGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ResultGrid.BackgroundColor = System.Drawing.Color.White
        Me.ResultGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultGrid.GridColor = System.Drawing.Color.White
        Me.ResultGrid.Location = New System.Drawing.Point(0, 226)
        Me.ResultGrid.Name = "ResultGrid"
        Me.ResultGrid.ReadOnly = True
        Me.ResultGrid.RowHeadersWidth = 60
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ResultGrid.Size = New System.Drawing.Size(784, 536)
        Me.ResultGrid.TabIndex = 246
        Me.ResultGrid.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 262
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
        Me.Title.Text = "Estadísticas del laboratorio"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportesLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.opcionesTable)
        Me.Controls.Add(Me.ResultGrid)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReportesLab"
        Me.Text = "Estadísticas del laboratorio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        CType(Me.ResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
    Friend WithEvents GroupByCombo As System.Windows.Forms.ComboBox
    Friend WithEvents LaboratorioCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupByL As System.Windows.Forms.Label
    Friend WithEvents FromL As System.Windows.Forms.Label
    Friend WithEvents DoctorCombo As System.Windows.Forms.ComboBox
    Friend WithEvents toL As System.Windows.Forms.Label
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabL As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateL As System.Windows.Forms.Label
    Friend WithEvents DrL As System.Windows.Forms.Label
    Friend WithEvents DetalleCheck As System.Windows.Forms.RadioButton
    Friend WithEvents ResumenCheck As System.Windows.Forms.RadioButton
    Friend WithEvents ResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
