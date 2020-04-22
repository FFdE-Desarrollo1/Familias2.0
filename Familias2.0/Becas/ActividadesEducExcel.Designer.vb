<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActividadesEducExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActividadesEducExcel))
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ActividadL = New System.Windows.Forms.Label()
        Me.TipoList = New System.Windows.Forms.ComboBox()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.Duplicados = New System.Windows.Forms.Button()
        Me.EjemploPicture = New System.Windows.Forms.PictureBox()
        Me.OpcionesActTable = New System.Windows.Forms.TableLayoutPanel()
        Me.DuplicadosV = New System.Windows.Forms.TextBox()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.FechaV = New System.Windows.Forms.DateTimePicker()
        Me.HoraV = New System.Windows.Forms.DateTimePicker()
        Me.TotalV = New System.Windows.Forms.Label()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.InfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjemploPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpcionesActTable.SuspendLayout()
        Me.InfoTable.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        '
        'ActividadL
        '
        Me.ActividadL.AutoSize = True
        Me.ActividadL.BackColor = System.Drawing.Color.Transparent
        Me.ActividadL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadL.ForeColor = System.Drawing.Color.Black
        Me.ActividadL.Location = New System.Drawing.Point(3, 0)
        Me.ActividadL.Name = "ActividadL"
        Me.ActividadL.Size = New System.Drawing.Size(69, 16)
        Me.ActividadL.TabIndex = 42
        Me.ActividadL.Text = "*Actividad:"
        '
        'TipoList
        '
        Me.InfoTable.SetColumnSpan(Me.TipoList, 2)
        Me.TipoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoList.FormattingEnabled = True
        Me.TipoList.Location = New System.Drawing.Point(78, 3)
        Me.TipoList.Name = "TipoList"
        Me.TipoList.Size = New System.Drawing.Size(330, 24)
        Me.TipoList.TabIndex = 40
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
        Me.ListadoGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 274)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.RowHeadersVisible = False
        Me.ListadoGrid.RowHeadersWidth = 14
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(784, 443)
        Me.ListadoGrid.TabIndex = 240
        Me.ListadoGrid.Visible = False
        '
        'Duplicados
        '
        Me.Duplicados.BackColor = System.Drawing.Color.Khaki
        Me.Duplicados.ForeColor = System.Drawing.Color.Black
        Me.Duplicados.Location = New System.Drawing.Point(3, 75)
        Me.Duplicados.Name = "Duplicados"
        Me.Duplicados.Size = New System.Drawing.Size(75, 23)
        Me.Duplicados.TabIndex = 226
        Me.Duplicados.Text = "Duplicados"
        Me.Duplicados.UseVisualStyleBackColor = False
        '
        'EjemploPicture
        '
        Me.EjemploPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EjemploPicture.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Listado
        Me.EjemploPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EjemploPicture.Location = New System.Drawing.Point(276, 3)
        Me.EjemploPicture.Name = "EjemploPicture"
        Me.InfoTable.SetRowSpan(Me.EjemploPicture, 2)
        Me.EjemploPicture.Size = New System.Drawing.Size(506, 246)
        Me.EjemploPicture.TabIndex = 232
        Me.EjemploPicture.TabStop = False
        '
        'OpcionesActTable
        '
        Me.OpcionesActTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpcionesActTable.BackColor = System.Drawing.Color.Transparent
        Me.OpcionesActTable.ColumnCount = 4
        Me.InfoTable.SetColumnSpan(Me.OpcionesActTable, 2)
        Me.OpcionesActTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesActTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesActTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesActTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesActTable.Controls.Add(Me.Duplicados, 0, 3)
        Me.OpcionesActTable.Controls.Add(Me.DuplicadosV, 1, 3)
        Me.OpcionesActTable.Controls.Add(Me.FechaL, 0, 0)
        Me.OpcionesActTable.Controls.Add(Me.FechaV, 1, 0)
        Me.OpcionesActTable.Controls.Add(Me.HoraV, 2, 0)
        Me.OpcionesActTable.Controls.Add(Me.TotalV, 1, 2)
        Me.OpcionesActTable.Controls.Add(Me.TotalL, 0, 2)
        Me.OpcionesActTable.Controls.Add(Me.NotasL, 0, 1)
        Me.OpcionesActTable.Controls.Add(Me.NotasV, 1, 1)
        Me.OpcionesActTable.Location = New System.Drawing.Point(3, 33)
        Me.OpcionesActTable.Name = "OpcionesActTable"
        Me.OpcionesActTable.RowCount = 4
        Me.OpcionesActTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OpcionesActTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OpcionesActTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OpcionesActTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesActTable.Size = New System.Drawing.Size(543, 216)
        Me.OpcionesActTable.TabIndex = 231
        Me.OpcionesActTable.Visible = False
        '
        'DuplicadosV
        '
        Me.DuplicadosV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpcionesActTable.SetColumnSpan(Me.DuplicadosV, 3)
        Me.DuplicadosV.Location = New System.Drawing.Point(133, 75)
        Me.DuplicadosV.Name = "DuplicadosV"
        Me.DuplicadosV.ReadOnly = True
        Me.DuplicadosV.Size = New System.Drawing.Size(407, 22)
        Me.DuplicadosV.TabIndex = 228
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.ForeColor = System.Drawing.Color.Black
        Me.FechaL.Location = New System.Drawing.Point(3, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(53, 16)
        Me.FechaL.TabIndex = 48
        Me.FechaL.Text = "*Fecha:"
        '
        'FechaV
        '
        Me.FechaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaV.Location = New System.Drawing.Point(133, 3)
        Me.FechaV.Name = "FechaV"
        Me.FechaV.Size = New System.Drawing.Size(275, 22)
        Me.FechaV.TabIndex = 49
        '
        'HoraV
        '
        Me.HoraV.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraV.Location = New System.Drawing.Point(414, 3)
        Me.HoraV.Name = "HoraV"
        Me.HoraV.Size = New System.Drawing.Size(117, 22)
        Me.HoraV.TabIndex = 53
        '
        'TotalV
        '
        Me.TotalV.AutoSize = True
        Me.TotalV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalV.Location = New System.Drawing.Point(133, 56)
        Me.TotalV.Name = "TotalV"
        Me.TotalV.Size = New System.Drawing.Size(15, 16)
        Me.TotalV.TabIndex = 202
        Me.TotalV.Text = "_"
        '
        'TotalL
        '
        Me.TotalL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Transparent
        Me.TotalL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.Location = New System.Drawing.Point(3, 56)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(124, 16)
        Me.TotalL.TabIndex = 227
        Me.TotalL.Text = "Registros cargados:"
        '
        'NotasL
        '
        Me.NotasL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasL.AutoSize = True
        Me.NotasL.BackColor = System.Drawing.Color.Transparent
        Me.NotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasL.ForeColor = System.Drawing.Color.Black
        Me.NotasL.Location = New System.Drawing.Point(3, 28)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(124, 16)
        Me.NotasL.TabIndex = 51
        Me.NotasL.Text = "Notas:"
        '
        'NotasV
        '
        Me.OpcionesActTable.SetColumnSpan(Me.NotasV, 2)
        Me.NotasV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasV.Location = New System.Drawing.Point(133, 31)
        Me.NotasV.MaxLength = 118
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(304, 22)
        Me.NotasV.TabIndex = 229
        '
        'InfoTable
        '
        Me.InfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoTable.BackColor = System.Drawing.Color.Transparent
        Me.InfoTable.ColumnCount = 5
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.InfoTable.Controls.Add(Me.EjemploPicture, 4, 0)
        Me.InfoTable.Controls.Add(Me.OpcionesActTable, 0, 1)
        Me.InfoTable.Controls.Add(Me.ActividadL, 0, 0)
        Me.InfoTable.Controls.Add(Me.TipoList, 1, 0)
        Me.InfoTable.Location = New System.Drawing.Point(0, 120)
        Me.InfoTable.Name = "InfoTable"
        Me.InfoTable.RowCount = 2
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.InfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoTable.Size = New System.Drawing.Size(784, 252)
        Me.InfoTable.TabIndex = 241
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
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.UploadButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'UploadButton
        '
        Me.UploadButton.BackColor = System.Drawing.Color.White
        Me.UploadButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.searchFam
        Me.UploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UploadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadButton.ForeColor = System.Drawing.Color.OrangeRed
        Me.UploadButton.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.UploadButton.Location = New System.Drawing.Point(549, 3)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(82, 46)
        Me.UploadButton.TabIndex = 236
        Me.UploadButton.Text = "Buscar Archivo"
        Me.UploadButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.UploadButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(494, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(443, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 45)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(637, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 236
        Me.GuardarButton.UseVisualStyleBackColor = False
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
        Me.Title.Size = New System.Drawing.Size(432, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Carga de Actividades - Excel"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActividadesEducExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.InfoTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActividadesEducExcel"
        Me.Text = "Actividades Misc desde Excel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjemploPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpcionesActTable.ResumeLayout(False)
        Me.OpcionesActTable.PerformLayout()
        Me.InfoTable.ResumeLayout(False)
        Me.InfoTable.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ActividadL As System.Windows.Forms.Label
    Friend WithEvents TipoList As System.Windows.Forms.ComboBox
    Friend WithEvents InfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EjemploPicture As System.Windows.Forms.PictureBox
    Friend WithEvents OpcionesActTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Duplicados As System.Windows.Forms.Button
    Friend WithEvents DuplicadosV As System.Windows.Forms.TextBox
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents FechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents HoraV As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalV As System.Windows.Forms.Label
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UploadButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
