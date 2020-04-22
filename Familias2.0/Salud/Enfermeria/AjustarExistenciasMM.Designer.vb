<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjustarExistenciasMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjustarExistenciasMM))
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Razon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRaz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedsGrid = New System.Windows.Forms.DataGridView()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasMedsBoton = New System.Windows.Forms.Button()
        Me.CantidadV = New System.Windows.Forms.TextBox()
        Me.FechaP = New System.Windows.Forms.DateTimePicker()
        Me.CantidadOL = New System.Windows.Forms.Label()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.RazonL = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MedsCombo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ObservacionesV = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RazonCombo = New System.Windows.Forms.ComboBox()
        Me.MedicinaPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MedicinaPanel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Existencia
        '
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.ReadOnly = True
        Me.Existencia.Width = 94
        '
        'Razon
        '
        Me.Razon.HeaderText = "Razón"
        Me.Razon.Name = "Razon"
        Me.Razon.ReadOnly = True
        Me.Razon.Width = 70
        '
        'IdRaz
        '
        Me.IdRaz.HeaderText = "IdRaz"
        Me.IdRaz.Name = "IdRaz"
        Me.IdRaz.ReadOnly = True
        Me.IdRaz.Visible = False
        Me.IdRaz.Width = 60
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.Cantidad.FillWeight = 10.0!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 2
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 84
        '
        'Medicamento
        '
        Me.Medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Medicamento.HeaderText = "Medicamento"
        Me.Medicamento.Name = "Medicamento"
        Me.Medicamento.ReadOnly = True
        Me.Medicamento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Medicamento.Width = 111
        '
        'Cod
        '
        Me.Cod.HeaderText = "Code"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Visible = False
        Me.Cod.Width = 57
        '
        'MedsGrid
        '
        Me.MedsGrid.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple
        Me.MedsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MedsGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MedsGrid.BackgroundColor = System.Drawing.Color.White
        Me.MedsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MedsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Medicamento, Me.Cantidad, Me.IdRaz, Me.Razon, Me.Observaciones, Me.Existencia})
        Me.MedsGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MedsGrid.Location = New System.Drawing.Point(0, 214)
        Me.MedsGrid.Name = "MedsGrid"
        Me.MedsGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedsGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedsGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MedsGrid.Size = New System.Drawing.Size(984, 544)
        Me.MedsGrid.TabIndex = 11
        '
        'Observaciones
        '
        Me.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 118
        '
        'MasMedsBoton
        '
        Me.MasMedsBoton.BackColor = System.Drawing.Color.Peru
        Me.MasMedsBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasMedsBoton.ForeColor = System.Drawing.Color.White
        Me.MasMedsBoton.Location = New System.Drawing.Point(905, 3)
        Me.MasMedsBoton.Name = "MasMedsBoton"
        Me.MedicinaPanel1.SetRowSpan(Me.MasMedsBoton, 3)
        Me.MasMedsBoton.Size = New System.Drawing.Size(76, 78)
        Me.MasMedsBoton.TabIndex = 6
        Me.MasMedsBoton.Text = "Agregar    al    Listado"
        Me.MasMedsBoton.UseVisualStyleBackColor = False
        '
        'CantidadV
        '
        Me.CantidadV.BackColor = System.Drawing.Color.Snow
        Me.CantidadV.Location = New System.Drawing.Point(548, 31)
        Me.CantidadV.Name = "CantidadV"
        Me.CantidadV.Size = New System.Drawing.Size(35, 22)
        Me.CantidadV.TabIndex = 4
        '
        'FechaP
        '
        Me.FechaP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaP.Location = New System.Drawing.Point(127, 3)
        Me.FechaP.Name = "FechaP"
        Me.FechaP.Size = New System.Drawing.Size(286, 22)
        Me.FechaP.TabIndex = 200
        '
        'CantidadOL
        '
        Me.CantidadOL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CantidadOL.AutoSize = True
        Me.CantidadOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadOL.ForeColor = System.Drawing.Color.Chocolate
        Me.CantidadOL.Location = New System.Drawing.Point(548, 0)
        Me.CantidadOL.Name = "CantidadOL"
        Me.CantidadOL.Size = New System.Drawing.Size(331, 28)
        Me.CantidadOL.TabIndex = 5
        Me.CantidadOL.Text = "Anteponga ""-"" a la cantidad si quiere descontar. Ej. -10"
        Me.CantidadOL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Location = New System.Drawing.Point(60, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(53, 16)
        Me.FechaL.TabIndex = 223
        Me.FechaL.Text = "*Fecha:"
        '
        'RazonL
        '
        Me.RazonL.AutoSize = True
        Me.RazonL.Location = New System.Drawing.Point(60, 58)
        Me.RazonL.Name = "RazonL"
        Me.RazonL.Size = New System.Drawing.Size(54, 16)
        Me.RazonL.TabIndex = 201
        Me.RazonL.Text = "*Razón:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(60, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "*Artículo:"
        '
        'MedsCombo
        '
        Me.MedsCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedsCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedsCombo.BackColor = System.Drawing.Color.Snow
        Me.MedsCombo.FormattingEnabled = True
        Me.MedsCombo.Location = New System.Drawing.Point(127, 31)
        Me.MedsCombo.Name = "MedsCombo"
        Me.MedsCombo.Size = New System.Drawing.Size(286, 24)
        Me.MedsCombo.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(449, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "*Cantidad"
        '
        'ObservacionesV
        '
        Me.ObservacionesV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservacionesV.BackColor = System.Drawing.Color.Snow
        Me.ObservacionesV.Location = New System.Drawing.Point(548, 61)
        Me.ObservacionesV.MaxLength = 79
        Me.ObservacionesV.Name = "ObservacionesV"
        Me.ObservacionesV.Size = New System.Drawing.Size(331, 22)
        Me.ObservacionesV.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(449, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Observaciones"
        '
        'RazonCombo
        '
        Me.RazonCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RazonCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RazonCombo.BackColor = System.Drawing.Color.Snow
        Me.RazonCombo.FormattingEnabled = True
        Me.RazonCombo.Location = New System.Drawing.Point(127, 61)
        Me.RazonCombo.Name = "RazonCombo"
        Me.RazonCombo.Size = New System.Drawing.Size(286, 24)
        Me.RazonCombo.TabIndex = 202
        '
        'MedicinaPanel1
        '
        Me.MedicinaPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedicinaPanel1.ColumnCount = 8
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MedicinaPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaPanel1.Controls.Add(Me.MasMedsBoton, 7, 0)
        Me.MedicinaPanel1.Controls.Add(Me.CantidadV, 5, 1)
        Me.MedicinaPanel1.Controls.Add(Me.FechaP, 2, 0)
        Me.MedicinaPanel1.Controls.Add(Me.CantidadOL, 5, 0)
        Me.MedicinaPanel1.Controls.Add(Me.FechaL, 1, 0)
        Me.MedicinaPanel1.Controls.Add(Me.RazonL, 1, 2)
        Me.MedicinaPanel1.Controls.Add(Me.Label14, 1, 1)
        Me.MedicinaPanel1.Controls.Add(Me.MedsCombo, 2, 1)
        Me.MedicinaPanel1.Controls.Add(Me.Label12, 4, 1)
        Me.MedicinaPanel1.Controls.Add(Me.ObservacionesV, 5, 2)
        Me.MedicinaPanel1.Controls.Add(Me.Label13, 4, 2)
        Me.MedicinaPanel1.Controls.Add(Me.RazonCombo, 2, 2)
        Me.MedicinaPanel1.Location = New System.Drawing.Point(0, 120)
        Me.MedicinaPanel1.Name = "MedicinaPanel1"
        Me.MedicinaPanel1.RowCount = 3
        Me.MedicinaPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaPanel1.Size = New System.Drawing.Size(984, 88)
        Me.MedicinaPanel1.TabIndex = 0
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(984, 118)
        Me.bannerPanel.TabIndex = 256
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
        Me.opcionesTable.Size = New System.Drawing.Size(888, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(782, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(731, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(837, 3)
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
        Me.Title.Size = New System.Drawing.Size(720, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Ajustar Existencias Materiales Médicos"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AjustarExistenciasMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.MedicinaPanel1)
        Me.Controls.Add(Me.MedsGrid)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AjustarExistenciasMM"
        Me.Text = "Ajustar Existencias Materiales Médicos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MedicinaPanel1.ResumeLayout(False)
        Me.MedicinaPanel1.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRaz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasMedsBoton As System.Windows.Forms.Button
    Friend WithEvents MedicinaPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CantidadV As System.Windows.Forms.TextBox
    Friend WithEvents FechaP As System.Windows.Forms.DateTimePicker
    Friend WithEvents CantidadOL As System.Windows.Forms.Label
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents RazonL As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MedsCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ObservacionesV As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RazonCombo As System.Windows.Forms.ComboBox
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
