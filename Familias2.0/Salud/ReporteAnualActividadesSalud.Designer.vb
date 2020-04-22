<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteAnualActividadesSalud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteAnualActividadesSalud))
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.mesCheck = New System.Windows.Forms.CheckBox()
        Me.semanaCheck = New System.Windows.Forms.CheckBox()
        Me.verDetalle = New System.Windows.Forms.CheckBox()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.TipoList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ListGrid = New System.Windows.Forms.DataGridView()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.opcionesTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.LightBlue
        Me.opcionesTable.ColumnCount = 7
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.opcionesTable.Controls.Add(Me.mesCheck, 5, 0)
        Me.opcionesTable.Controls.Add(Me.semanaCheck, 5, 1)
        Me.opcionesTable.Controls.Add(Me.verDetalle, 0, 1)
        Me.opcionesTable.Controls.Add(Me.GenerarButton, 6, 0)
        Me.opcionesTable.Controls.Add(Me.TipoList, 4, 0)
        Me.opcionesTable.Controls.Add(Me.Label2, 3, 0)
        Me.opcionesTable.Controls.Add(Me.AñoV, 2, 0)
        Me.opcionesTable.Controls.Add(Me.FamiliaL, 1, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(0, 122)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 2
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.opcionesTable.Size = New System.Drawing.Size(984, 62)
        Me.opcionesTable.TabIndex = 255
        '
        'mesCheck
        '
        Me.mesCheck.AutoSize = True
        Me.mesCheck.Checked = True
        Me.mesCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mesCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mesCheck.Location = New System.Drawing.Point(762, 3)
        Me.mesCheck.Name = "mesCheck"
        Me.mesCheck.Size = New System.Drawing.Size(76, 20)
        Me.mesCheck.TabIndex = 198
        Me.mesCheck.Text = "Por Mes"
        Me.mesCheck.UseVisualStyleBackColor = True
        '
        'semanaCheck
        '
        Me.semanaCheck.AutoSize = True
        Me.semanaCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semanaCheck.Location = New System.Drawing.Point(762, 33)
        Me.semanaCheck.Name = "semanaCheck"
        Me.semanaCheck.Size = New System.Drawing.Size(99, 20)
        Me.semanaCheck.TabIndex = 199
        Me.semanaCheck.Text = "Por Semana"
        Me.semanaCheck.UseVisualStyleBackColor = True
        '
        'verDetalle
        '
        Me.verDetalle.AutoSize = True
        Me.verDetalle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verDetalle.Location = New System.Drawing.Point(3, 33)
        Me.verDetalle.Name = "verDetalle"
        Me.verDetalle.Size = New System.Drawing.Size(88, 20)
        Me.verDetalle.TabIndex = 47
        Me.verDetalle.Text = "Ver detalle"
        Me.verDetalle.UseVisualStyleBackColor = True
        '
        'GenerarButton
        '
        Me.GenerarButton.Location = New System.Drawing.Point(867, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.opcionesTable.SetRowSpan(Me.GenerarButton, 2)
        Me.GenerarButton.Size = New System.Drawing.Size(114, 23)
        Me.GenerarButton.TabIndex = 45
        Me.GenerarButton.Text = "Generar Listado"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'TipoList
        '
        Me.TipoList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoList.FormattingEnabled = True
        Me.TipoList.Location = New System.Drawing.Point(527, 3)
        Me.TipoList.Name = "TipoList"
        Me.TipoList.Size = New System.Drawing.Size(229, 24)
        Me.TipoList.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(461, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Actividad"
        '
        'AñoV
        '
        Me.AñoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoV.Location = New System.Drawing.Point(381, 3)
        Me.AñoV.MaxLength = 6
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(48, 22)
        Me.AñoV.TabIndex = 46
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.BackColor = System.Drawing.Color.Transparent
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.ForeColor = System.Drawing.Color.Black
        Me.FamiliaL.Location = New System.Drawing.Point(340, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(35, 16)
        Me.FamiliaL.TabIndex = 44
        Me.FamiliaL.Text = "Año:"
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(984, 118)
        Me.bannerPanel.TabIndex = 258
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.inicioButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(94, 61)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(888, 53)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(840, 3)
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
        Me.Title.Size = New System.Drawing.Size(829, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Reporte Anual de Actividades de Salud"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListGrid
        '
        Me.ListGrid.AllowUserToAddRows = False
        Me.ListGrid.AllowUserToDeleteRows = False
        Me.ListGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListGrid.Location = New System.Drawing.Point(0, 207)
        Me.ListGrid.Name = "ListGrid"
        Me.ListGrid.ReadOnly = True
        Me.ListGrid.RowHeadersWidth = 28
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListGrid.Size = New System.Drawing.Size(984, 454)
        Me.ListGrid.TabIndex = 257
        Me.ListGrid.Visible = False
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Navy
        Me.TotalL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.ForeColor = System.Drawing.Color.White
        Me.TotalL.Location = New System.Drawing.Point(6, 187)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(16, 17)
        Me.TotalL.TabIndex = 256
        Me.TotalL.Text = "_"
        Me.TotalL.Visible = False
        '
        'ReporteAnualActividadesSalud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.opcionesTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ListGrid)
        Me.Controls.Add(Me.TotalL)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReporteAnualActividadesSalud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Anual Actividades Salud"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.opcionesTable.ResumeLayout(False)
        Me.opcionesTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mesCheck As System.Windows.Forms.CheckBox
    Friend WithEvents semanaCheck As System.Windows.Forms.CheckBox
    Friend WithEvents verDetalle As System.Windows.Forms.CheckBox
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents TipoList As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents ListGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TotalL As System.Windows.Forms.Label
End Class
