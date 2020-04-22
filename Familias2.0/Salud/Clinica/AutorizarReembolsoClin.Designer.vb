<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutorizarReembolsoClin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutorizarReembolsoClin))
        Me.ReembolsoInfoPanel = New System.Windows.Forms.Panel()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.formaCombo = New System.Windows.Forms.ComboBox()
        Me.FormaPagoL = New System.Windows.Forms.Label()
        Me.CtaL = New System.Windows.Forms.Label()
        Me.FechaAutoV = New System.Windows.Forms.DateTimePicker()
        Me.FechaAutoL = New System.Windows.Forms.Label()
        Me.TipoV = New System.Windows.Forms.ComboBox()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.AprobadoPorL = New System.Windows.Forms.Label()
        Me.AprobadoPorV = New System.Windows.Forms.ComboBox()
        Me.ValorL = New System.Windows.Forms.Label()
        Me.ValorV = New System.Windows.Forms.TextBox()
        Me.PorcentajeL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PorcentajeV = New System.Windows.Forms.Label()
        Me.TotalDifCheck = New System.Windows.Forms.CheckBox()
        Me.CodigoTipo = New System.Windows.Forms.TextBox()
        Me.AprobadoV = New System.Windows.Forms.TextBox()
        Me.AprobadoL = New System.Windows.Forms.Label()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.GenInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ClasificacionV = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.RecetasExt = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FacturaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Medicina = New System.Windows.Forms.LinkLabel()
        Me.ReferenciasExt = New System.Windows.Forms.LinkLabel()
        Me.Consultas = New System.Windows.Forms.LinkLabel()
        Me.Reembolsos = New System.Windows.Forms.LinkLabel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ReembolsoInfoPanel.SuspendLayout()
        Me.DatosTable.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenInfoTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FacturaTable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReembolsoInfoPanel
        '
        Me.ReembolsoInfoPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReembolsoInfoPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ReembolsoInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReembolsoInfoPanel.Controls.Add(Me.DatosTable)
        Me.ReembolsoInfoPanel.Location = New System.Drawing.Point(3, 3)
        Me.ReembolsoInfoPanel.Name = "ReembolsoInfoPanel"
        Me.ReembolsoInfoPanel.Size = New System.Drawing.Size(538, 269)
        Me.ReembolsoInfoPanel.TabIndex = 225
        Me.ReembolsoInfoPanel.Visible = False
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.Transparent
        Me.DatosTable.ColumnCount = 2
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.Controls.Add(Me.formaCombo, 1, 7)
        Me.DatosTable.Controls.Add(Me.FormaPagoL, 0, 7)
        Me.DatosTable.Controls.Add(Me.CtaL, 1, 8)
        Me.DatosTable.Controls.Add(Me.FechaAutoV, 1, 0)
        Me.DatosTable.Controls.Add(Me.FechaAutoL, 0, 0)
        Me.DatosTable.Controls.Add(Me.TipoV, 1, 2)
        Me.DatosTable.Controls.Add(Me.TipoL, 0, 2)
        Me.DatosTable.Controls.Add(Me.AprobadoPorL, 0, 1)
        Me.DatosTable.Controls.Add(Me.AprobadoPorV, 1, 1)
        Me.DatosTable.Controls.Add(Me.ValorL, 0, 3)
        Me.DatosTable.Controls.Add(Me.ValorV, 1, 3)
        Me.DatosTable.Controls.Add(Me.PorcentajeL, 0, 4)
        Me.DatosTable.Controls.Add(Me.TableLayoutPanel2, 1, 4)
        Me.DatosTable.Controls.Add(Me.AprobadoV, 1, 5)
        Me.DatosTable.Controls.Add(Me.AprobadoL, 0, 5)
        Me.DatosTable.Controls.Add(Me.NotasL, 0, 6)
        Me.DatosTable.Controls.Add(Me.NotasV, 1, 6)
        Me.DatosTable.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosTable.Location = New System.Drawing.Point(3, 3)
        Me.DatosTable.Name = "DatosTable"
        Me.DatosTable.RowCount = 9
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DatosTable.Size = New System.Drawing.Size(528, 264)
        Me.DatosTable.TabIndex = 215
        Me.DatosTable.Visible = False
        '
        'formaCombo
        '
        Me.formaCombo.FormattingEnabled = True
        Me.formaCombo.Location = New System.Drawing.Point(141, 214)
        Me.formaCombo.Name = "formaCombo"
        Me.formaCombo.Size = New System.Drawing.Size(163, 24)
        Me.formaCombo.TabIndex = 228
        '
        'FormaPagoL
        '
        Me.FormaPagoL.AutoSize = True
        Me.FormaPagoL.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaPagoL.ForeColor = System.Drawing.Color.Navy
        Me.FormaPagoL.Location = New System.Drawing.Point(3, 211)
        Me.FormaPagoL.Name = "FormaPagoL"
        Me.FormaPagoL.Size = New System.Drawing.Size(119, 17)
        Me.FormaPagoL.TabIndex = 218
        Me.FormaPagoL.Text = "*Forma de Pago:"
        '
        'CtaL
        '
        Me.CtaL.AutoSize = True
        Me.CtaL.Location = New System.Drawing.Point(141, 241)
        Me.CtaL.Name = "CtaL"
        Me.CtaL.Size = New System.Drawing.Size(12, 16)
        Me.CtaL.TabIndex = 228
        Me.CtaL.Text = "-"
        Me.CtaL.Visible = False
        '
        'FechaAutoV
        '
        Me.FechaAutoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaAutoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAutoV.Location = New System.Drawing.Point(141, 3)
        Me.FechaAutoV.Name = "FechaAutoV"
        Me.FechaAutoV.Size = New System.Drawing.Size(384, 22)
        Me.FechaAutoV.TabIndex = 32
        '
        'FechaAutoL
        '
        Me.FechaAutoL.AutoSize = True
        Me.FechaAutoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAutoL.Location = New System.Drawing.Point(3, 0)
        Me.FechaAutoL.Name = "FechaAutoL"
        Me.FechaAutoL.Size = New System.Drawing.Size(116, 16)
        Me.FechaAutoL.TabIndex = 209
        Me.FechaAutoL.Text = "Fecha Aprobación:"
        '
        'TipoV
        '
        Me.TipoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipoV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoV.FormattingEnabled = True
        Me.TipoV.Location = New System.Drawing.Point(141, 61)
        Me.TipoV.Name = "TipoV"
        Me.TipoV.Size = New System.Drawing.Size(249, 24)
        Me.TipoV.TabIndex = 208
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoL.Location = New System.Drawing.Point(3, 58)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(36, 16)
        Me.TipoL.TabIndex = 205
        Me.TipoL.Text = "Tipo:"
        '
        'AprobadoPorL
        '
        Me.AprobadoPorL.AutoSize = True
        Me.AprobadoPorL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoPorL.Location = New System.Drawing.Point(3, 28)
        Me.AprobadoPorL.Name = "AprobadoPorL"
        Me.AprobadoPorL.Size = New System.Drawing.Size(89, 16)
        Me.AprobadoPorL.TabIndex = 214
        Me.AprobadoPorL.Text = "Aprobado por:"
        '
        'AprobadoPorV
        '
        Me.AprobadoPorV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AprobadoPorV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AprobadoPorV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoPorV.FormattingEnabled = True
        Me.AprobadoPorV.Location = New System.Drawing.Point(141, 31)
        Me.AprobadoPorV.Name = "AprobadoPorV"
        Me.AprobadoPorV.Size = New System.Drawing.Size(249, 24)
        Me.AprobadoPorV.TabIndex = 215
        '
        'ValorL
        '
        Me.ValorL.AutoSize = True
        Me.ValorL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorL.Location = New System.Drawing.Point(3, 88)
        Me.ValorL.Name = "ValorL"
        Me.ValorL.Size = New System.Drawing.Size(76, 16)
        Me.ValorL.TabIndex = 212
        Me.ValorL.Text = "Valor Total :"
        '
        'ValorV
        '
        Me.ValorV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorV.Location = New System.Drawing.Point(141, 91)
        Me.ValorV.Name = "ValorV"
        Me.ValorV.Size = New System.Drawing.Size(100, 22)
        Me.ValorV.TabIndex = 213
        '
        'PorcentajeL
        '
        Me.PorcentajeL.AutoSize = True
        Me.PorcentajeL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeL.Location = New System.Drawing.Point(3, 116)
        Me.PorcentajeL.Name = "PorcentajeL"
        Me.PorcentajeL.Size = New System.Drawing.Size(132, 16)
        Me.PorcentajeL.TabIndex = 210
        Me.PorcentajeL.Text = "Porcentaje Aprobado:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PorcentajeV, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TotalDifCheck, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CodigoTipo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(141, 119)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(384, 33)
        Me.TableLayoutPanel2.TabIndex = 220
        '
        'PorcentajeV
        '
        Me.PorcentajeV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PorcentajeV.AutoSize = True
        Me.PorcentajeV.BackColor = System.Drawing.Color.Silver
        Me.PorcentajeV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeV.Location = New System.Drawing.Point(3, 0)
        Me.PorcentajeV.Name = "PorcentajeV"
        Me.PorcentajeV.Size = New System.Drawing.Size(15, 33)
        Me.PorcentajeV.TabIndex = 211
        Me.PorcentajeV.Text = "_"
        '
        'TotalDifCheck
        '
        Me.TotalDifCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalDifCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDifCheck.Location = New System.Drawing.Point(124, 3)
        Me.TotalDifCheck.Name = "TotalDifCheck"
        Me.TotalDifCheck.Size = New System.Drawing.Size(257, 25)
        Me.TotalDifCheck.TabIndex = 219
        Me.TotalDifCheck.Text = "¿Necesita cambiar el % aprobado?"
        Me.TotalDifCheck.UseVisualStyleBackColor = True
        Me.TotalDifCheck.Visible = False
        '
        'CodigoTipo
        '
        Me.CodigoTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoTipo.Location = New System.Drawing.Point(24, 3)
        Me.CodigoTipo.Name = "CodigoTipo"
        Me.CodigoTipo.Size = New System.Drawing.Size(26, 22)
        Me.CodigoTipo.TabIndex = 218
        Me.CodigoTipo.Visible = False
        '
        'AprobadoV
        '
        Me.AprobadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoV.Location = New System.Drawing.Point(141, 158)
        Me.AprobadoV.Name = "AprobadoV"
        Me.AprobadoV.Size = New System.Drawing.Size(100, 22)
        Me.AprobadoV.TabIndex = 214
        '
        'AprobadoL
        '
        Me.AprobadoL.AutoSize = True
        Me.AprobadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoL.Location = New System.Drawing.Point(3, 155)
        Me.AprobadoL.Name = "AprobadoL"
        Me.AprobadoL.Size = New System.Drawing.Size(97, 16)
        Me.AprobadoL.TabIndex = 216
        Me.AprobadoL.Text = "Total Aprobado:"
        '
        'NotasL
        '
        Me.NotasL.AutoSize = True
        Me.NotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasL.Location = New System.Drawing.Point(3, 183)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(97, 16)
        Me.NotasL.TabIndex = 1
        Me.NotasL.Text = "Observaciones:"
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasV.Location = New System.Drawing.Point(141, 186)
        Me.NotasV.MaxLength = 38
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(384, 22)
        Me.NotasV.TabIndex = 0
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        Me.ListadoGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListadoGrid.Location = New System.Drawing.Point(623, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListadoGrid.Size = New System.Drawing.Size(158, 565)
        Me.ListadoGrid.TabIndex = 216
        Me.ListadoGrid.Visible = False
        '
        'GenInfoTable
        '
        Me.GenInfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenInfoTable.BackColor = System.Drawing.Color.AliceBlue
        Me.GenInfoTable.ColumnCount = 3
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GenInfoTable.Controls.Add(Me.ClasificacionV, 2, 0)
        Me.GenInfoTable.Controls.Add(Me.NombreL, 0, 0)
        Me.GenInfoTable.Controls.Add(Me.NombreV, 1, 0)
        Me.GenInfoTable.Location = New System.Drawing.Point(0, 155)
        Me.GenInfoTable.Name = "GenInfoTable"
        Me.GenInfoTable.RowCount = 1
        Me.GenInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.GenInfoTable.Size = New System.Drawing.Size(784, 27)
        Me.GenInfoTable.TabIndex = 243
        '
        'ClasificacionV
        '
        Me.ClasificacionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionV.AutoSize = True
        Me.ClasificacionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionV.Location = New System.Drawing.Point(87, 0)
        Me.ClasificacionV.Name = "ClasificacionV"
        Me.ClasificacionV.Size = New System.Drawing.Size(694, 16)
        Me.ClasificacionV.TabIndex = 208
        Me.ClasificacionV.Text = "_"
        Me.ClasificacionV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(57, 16)
        Me.NombreL.TabIndex = 0
        Me.NombreL.Text = "Nombre:"
        Me.NombreL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.Location = New System.Drawing.Point(66, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(15, 16)
        Me.NombreV.TabIndex = 207
        Me.NombreV.Text = "_"
        Me.NombreV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.PrincipalPanel.ColumnCount = 5
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.PrincipalPanel.Controls.Add(Me.MiembroL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 36)
        Me.PrincipalPanel.TabIndex = 242
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(537, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(124, 36)
        Me.MiembroL.TabIndex = 207
        Me.MiembroL.Text = "No. Afiliación:"
        Me.MiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MiembroV
        '
        Me.MiembroV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(667, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(114, 29)
        Me.MiembroV.TabIndex = 207
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(109, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(118, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 29)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RecetasExt
        '
        Me.RecetasExt.AutoSize = True
        Me.RecetasExt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetasExt.Location = New System.Drawing.Point(128, 2)
        Me.RecetasExt.Name = "RecetasExt"
        Me.RecetasExt.Size = New System.Drawing.Size(125, 17)
        Me.RecetasExt.TabIndex = 222
        Me.RecetasExt.TabStop = True
        Me.RecetasExt.Text = "Recetas Externas"
        Me.RecetasExt.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FacturaTable, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListadoGrid, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 188)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 571)
        Me.TableLayoutPanel1.TabIndex = 244
        '
        'FacturaTable
        '
        Me.FacturaTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturaTable.ColumnCount = 1
        Me.FacturaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 544.0!))
        Me.FacturaTable.Controls.Add(Me.Panel1, 0, 1)
        Me.FacturaTable.Controls.Add(Me.ReembolsoInfoPanel, 0, 0)
        Me.FacturaTable.Location = New System.Drawing.Point(3, 3)
        Me.FacturaTable.Name = "FacturaTable"
        Me.FacturaTable.RowCount = 2
        Me.FacturaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FacturaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FacturaTable.Size = New System.Drawing.Size(544, 565)
        Me.FacturaTable.TabIndex = 227
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Medicina)
        Me.Panel1.Controls.Add(Me.ReferenciasExt)
        Me.Panel1.Controls.Add(Me.Consultas)
        Me.Panel1.Controls.Add(Me.Reembolsos)
        Me.Panel1.Controls.Add(Me.RecetasExt)
        Me.Panel1.Location = New System.Drawing.Point(3, 278)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 79)
        Me.Panel1.TabIndex = 224
        '
        'Medicina
        '
        Me.Medicina.AutoSize = True
        Me.Medicina.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medicina.Location = New System.Drawing.Point(128, 28)
        Me.Medicina.Name = "Medicina"
        Me.Medicina.Size = New System.Drawing.Size(73, 17)
        Me.Medicina.TabIndex = 222
        Me.Medicina.TabStop = True
        Me.Medicina.Text = "Medicinas"
        Me.Medicina.Visible = False
        '
        'ReferenciasExt
        '
        Me.ReferenciasExt.AutoSize = True
        Me.ReferenciasExt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReferenciasExt.Location = New System.Drawing.Point(280, 2)
        Me.ReferenciasExt.Name = "ReferenciasExt"
        Me.ReferenciasExt.Size = New System.Drawing.Size(149, 17)
        Me.ReferenciasExt.TabIndex = 221
        Me.ReferenciasExt.TabStop = True
        Me.ReferenciasExt.Text = "Referencias Externas"
        Me.ReferenciasExt.Visible = False
        '
        'Consultas
        '
        Me.Consultas.AutoSize = True
        Me.Consultas.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consultas.Location = New System.Drawing.Point(2, 28)
        Me.Consultas.Name = "Consultas"
        Me.Consultas.Size = New System.Drawing.Size(74, 17)
        Me.Consultas.TabIndex = 223
        Me.Consultas.TabStop = True
        Me.Consultas.Text = "Consultas"
        Me.Consultas.Visible = False
        '
        'Reembolsos
        '
        Me.Reembolsos.AutoSize = True
        Me.Reembolsos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reembolsos.Location = New System.Drawing.Point(2, 2)
        Me.Reembolsos.Name = "Reembolsos"
        Me.Reembolsos.Size = New System.Drawing.Size(91, 17)
        Me.Reembolsos.TabIndex = 221
        Me.Reembolsos.TabStop = True
        Me.Reembolsos.Text = "Reembolsos"
        Me.Reembolsos.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 252
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
        Me.GuardarButton.Visible = False
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
        Me.Title.Text = "Autorización de Facturas"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutorizarReembolsoClin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 749)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.GenInfoTable)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AutorizarReembolsoClin"
        Me.Text = "Autorizar Reembolso - Clínica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ReembolsoInfoPanel.ResumeLayout(False)
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenInfoTable.ResumeLayout(False)
        Me.GenInfoTable.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FacturaTable.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReembolsoInfoPanel As System.Windows.Forms.Panel
    Friend WithEvents FormaPagoL As System.Windows.Forms.Label
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaAutoV As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaAutoL As System.Windows.Forms.Label
    Friend WithEvents TipoV As System.Windows.Forms.ComboBox
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents AprobadoPorL As System.Windows.Forms.Label
    Friend WithEvents AprobadoPorV As System.Windows.Forms.ComboBox
    Friend WithEvents ValorL As System.Windows.Forms.Label
    Friend WithEvents ValorV As System.Windows.Forms.TextBox
    Friend WithEvents PorcentajeL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PorcentajeV As System.Windows.Forms.Label
    Friend WithEvents TotalDifCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CodigoTipo As System.Windows.Forms.TextBox
    Friend WithEvents AprobadoV As System.Windows.Forms.TextBox
    Friend WithEvents AprobadoL As System.Windows.Forms.Label
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GenInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ClasificacionV As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents RecetasExt As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FacturaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Medicina As System.Windows.Forms.LinkLabel
    Friend WithEvents ReferenciasExt As System.Windows.Forms.LinkLabel
    Friend WithEvents Consultas As System.Windows.Forms.LinkLabel
    Friend WithEvents Reembolsos As System.Windows.Forms.LinkLabel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents formaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CtaL As System.Windows.Forms.Label
End Class
