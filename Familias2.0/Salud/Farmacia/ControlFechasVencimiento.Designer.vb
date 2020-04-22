<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlFechasVencimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlFechasVencimiento))
        Me.Accion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ExistenciaV = New System.Windows.Forms.Label()
        Me.ExistenciaL = New System.Windows.Forms.Label()
        Me.DeFechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.PrincipalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.tDeFechaV = New System.Windows.Forms.Label()
        Me.tAFechaV = New System.Windows.Forms.Label()
        Me.AFechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MedsCombo = New System.Windows.Forms.ComboBox()
        Me.PrecioActualL = New System.Windows.Forms.Label()
        Me.PrecioActualV = New System.Windows.Forms.Label()
        Me.UltimaFechaL = New System.Windows.Forms.Label()
        Me.UltimaFechaV = New System.Windows.Forms.Label()
        Me.HistorialGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.PrincipalTable.SuspendLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Accion
        '
        Me.Accion.HeaderText = "Cambiar a Finalizado"
        Me.Accion.Name = "Accion"
        '
        'ExistenciaV
        '
        Me.ExistenciaV.AutoSize = True
        Me.ExistenciaV.Location = New System.Drawing.Point(140, 28)
        Me.ExistenciaV.Name = "ExistenciaV"
        Me.ExistenciaV.Size = New System.Drawing.Size(1, 23)
        Me.ExistenciaV.TabIndex = 204
        Me.ExistenciaV.Text = "_"
        Me.ExistenciaV.Visible = False
        '
        'ExistenciaL
        '
        Me.ExistenciaL.AutoSize = True
        Me.ExistenciaL.Location = New System.Drawing.Point(3, 28)
        Me.ExistenciaL.Name = "ExistenciaL"
        Me.ExistenciaL.Size = New System.Drawing.Size(104, 23)
        Me.ExistenciaL.TabIndex = 205
        Me.ExistenciaL.Text = "Existencia:"
        Me.ExistenciaL.Visible = False
        '
        'DeFechaPicker
        '
        Me.DeFechaPicker.Location = New System.Drawing.Point(144, 3)
        Me.DeFechaPicker.Name = "DeFechaPicker"
        Me.DeFechaPicker.Size = New System.Drawing.Size(201, 30)
        Me.DeFechaPicker.TabIndex = 200
        '
        'PrincipalTable
        '
        Me.PrincipalTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalTable.BackColor = System.Drawing.Color.Transparent
        Me.PrincipalTable.ColumnCount = 8
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalTable.Controls.Add(Me.ExistenciaV, 1, 1)
        Me.PrincipalTable.Controls.Add(Me.ExistenciaL, 0, 1)
        Me.PrincipalTable.Controls.Add(Me.DeFechaPicker, 3, 0)
        Me.PrincipalTable.Controls.Add(Me.tDeFechaV, 2, 0)
        Me.PrincipalTable.Controls.Add(Me.tAFechaV, 5, 0)
        Me.PrincipalTable.Controls.Add(Me.AFechaPicker, 6, 0)
        Me.PrincipalTable.Controls.Add(Me.GenerarButton, 7, 0)
        Me.PrincipalTable.Controls.Add(Me.Label14, 2, 1)
        Me.PrincipalTable.Controls.Add(Me.MedsCombo, 3, 1)
        Me.PrincipalTable.Controls.Add(Me.PrecioActualL, 0, 0)
        Me.PrincipalTable.Controls.Add(Me.PrecioActualV, 1, 0)
        Me.PrincipalTable.Controls.Add(Me.UltimaFechaL, 2, 2)
        Me.PrincipalTable.Controls.Add(Me.UltimaFechaV, 3, 2)
        Me.PrincipalTable.Controls.Add(Me.HistorialGrid, 0, 3)
        Me.PrincipalTable.Location = New System.Drawing.Point(0, 124)
        Me.PrincipalTable.Name = "PrincipalTable"
        Me.PrincipalTable.RowCount = 4
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.PrincipalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalTable.Size = New System.Drawing.Size(784, 634)
        Me.PrincipalTable.TabIndex = 248
        '
        'tDeFechaV
        '
        Me.tDeFechaV.AutoSize = True
        Me.tDeFechaV.Location = New System.Drawing.Point(-34, 0)
        Me.tDeFechaV.Name = "tDeFechaV"
        Me.tDeFechaV.Size = New System.Drawing.Size(109, 23)
        Me.tDeFechaV.TabIndex = 198
        Me.tDeFechaV.Text = "*De Fecha:"
        '
        'tAFechaV
        '
        Me.tAFechaV.AutoSize = True
        Me.tAFechaV.Location = New System.Drawing.Point(371, 0)
        Me.tAFechaV.Name = "tAFechaV"
        Me.tAFechaV.Size = New System.Drawing.Size(96, 23)
        Me.tAFechaV.TabIndex = 199
        Me.tAFechaV.Text = "*A Fecha:"
        '
        'AFechaPicker
        '
        Me.AFechaPicker.Location = New System.Drawing.Point(473, 3)
        Me.AFechaPicker.Name = "AFechaPicker"
        Me.AFechaPicker.Size = New System.Drawing.Size(194, 30)
        Me.AFechaPicker.TabIndex = 201
        '
        'GenerarButton
        '
        Me.GenerarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GenerarButton.Location = New System.Drawing.Point(706, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.PrincipalTable.SetRowSpan(Me.GenerarButton, 2)
        Me.GenerarButton.Size = New System.Drawing.Size(75, 50)
        Me.GenerarButton.TabIndex = 202
        Me.GenerarButton.Text = "Ver Historial"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-34, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 23)
        Me.Label14.TabIndex = 198
        Me.Label14.Text = "*Medicina:"
        '
        'MedsCombo
        '
        Me.MedsCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedsCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedsCombo.BackColor = System.Drawing.Color.Snow
        Me.PrincipalTable.SetColumnSpan(Me.MedsCombo, 4)
        Me.MedsCombo.FormattingEnabled = True
        Me.MedsCombo.Location = New System.Drawing.Point(144, 31)
        Me.MedsCombo.Name = "MedsCombo"
        Me.MedsCombo.Size = New System.Drawing.Size(556, 31)
        Me.MedsCombo.TabIndex = 197
        '
        'PrecioActualL
        '
        Me.PrecioActualL.AutoSize = True
        Me.PrecioActualL.Location = New System.Drawing.Point(3, 0)
        Me.PrecioActualL.Name = "PrecioActualL"
        Me.PrecioActualL.Size = New System.Drawing.Size(131, 23)
        Me.PrecioActualL.TabIndex = 204
        Me.PrecioActualL.Text = "Precio Actual:"
        Me.PrecioActualL.Visible = False
        '
        'PrecioActualV
        '
        Me.PrecioActualV.AutoSize = True
        Me.PrecioActualV.Location = New System.Drawing.Point(140, 0)
        Me.PrecioActualV.Name = "PrecioActualV"
        Me.PrecioActualV.Size = New System.Drawing.Size(1, 23)
        Me.PrecioActualV.TabIndex = 203
        Me.PrecioActualV.Text = "_"
        Me.PrecioActualV.Visible = False
        '
        'UltimaFechaL
        '
        Me.UltimaFechaL.AutoSize = True
        Me.UltimaFechaL.Location = New System.Drawing.Point(-34, 56)
        Me.UltimaFechaL.Name = "UltimaFechaL"
        Me.UltimaFechaL.Size = New System.Drawing.Size(172, 23)
        Me.UltimaFechaL.TabIndex = 204
        Me.UltimaFechaL.Text = "Fecha En Estante:"
        Me.UltimaFechaL.Visible = False
        '
        'UltimaFechaV
        '
        Me.UltimaFechaV.AutoSize = True
        Me.UltimaFechaV.Location = New System.Drawing.Point(144, 56)
        Me.UltimaFechaV.Name = "UltimaFechaV"
        Me.UltimaFechaV.Size = New System.Drawing.Size(21, 23)
        Me.UltimaFechaV.TabIndex = 204
        Me.UltimaFechaV.Text = "_"
        Me.UltimaFechaV.Visible = False
        '
        'HistorialGrid
        '
        Me.HistorialGrid.AllowUserToAddRows = False
        Me.HistorialGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistorialGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialGrid.BackgroundColor = System.Drawing.Color.White
        Me.HistorialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion})
        Me.PrincipalTable.SetColumnSpan(Me.HistorialGrid, 8)
        Me.HistorialGrid.Location = New System.Drawing.Point(3, 87)
        Me.HistorialGrid.Name = "HistorialGrid"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.HistorialGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HistorialGrid.Size = New System.Drawing.Size(778, 544)
        Me.HistorialGrid.TabIndex = 199
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 259
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
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 3, 0)
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
        Me.NuevoButton.Location = New System.Drawing.Point(582, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(531, 3)
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
        Me.Title.Size = New System.Drawing.Size(520, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Control de Fechas de Vencimiento de Medicamentos"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlFechasVencimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PrincipalTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ControlFechasVencimiento"
        Me.Text = "Control Fechas de Vencimiento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PrincipalTable.ResumeLayout(False)
        Me.PrincipalTable.PerformLayout()
        CType(Me.HistorialGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ExistenciaV As System.Windows.Forms.Label
    Friend WithEvents ExistenciaL As System.Windows.Forms.Label
    Friend WithEvents DeFechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrincipalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tDeFechaV As System.Windows.Forms.Label
    Friend WithEvents tAFechaV As System.Windows.Forms.Label
    Friend WithEvents AFechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MedsCombo As System.Windows.Forms.ComboBox
    Friend WithEvents PrecioActualL As System.Windows.Forms.Label
    Friend WithEvents PrecioActualV As System.Windows.Forms.Label
    Friend WithEvents UltimaFechaL As System.Windows.Forms.Label
    Friend WithEvents UltimaFechaV As System.Windows.Forms.Label
    Friend WithEvents HistorialGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
