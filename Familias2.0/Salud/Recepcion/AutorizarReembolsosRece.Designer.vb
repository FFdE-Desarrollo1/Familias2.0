<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutorizarReembolsosRece
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutorizarReembolsosRece))
        Me.ValorL = New System.Windows.Forms.Label()
        Me.AprobadoV = New System.Windows.Forms.TextBox()
        Me.AprobadoL = New System.Windows.Forms.Label()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.FechaAutoV = New System.Windows.Forms.DateTimePicker()
        Me.FechaAutoL = New System.Windows.Forms.Label()
        Me.TipoV = New System.Windows.Forms.ComboBox()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.AprobadoPorL = New System.Windows.Forms.Label()
        Me.AprobadoPorV = New System.Windows.Forms.ComboBox()
        Me.ValorV = New System.Windows.Forms.TextBox()
        Me.PorcentajeL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PorcentajeV = New System.Windows.Forms.Label()
        Me.TotalDifCheck = New System.Windows.Forms.CheckBox()
        Me.CodigoTipo = New System.Windows.Forms.TextBox()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.FormaPagoL = New System.Windows.Forms.Label()
        Me.GenInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ClasificacionV = New System.Windows.Forms.Label()
        Me.TipoMiembroL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.TipoMiembroV = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FacturaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AvisosGrid = New System.Windows.Forms.DataGridView()
        Me.AvisosL = New System.Windows.Forms.Label()
        Me.ReembolsoInfoPanel = New System.Windows.Forms.Panel()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.formaCombo = New System.Windows.Forms.ComboBox()
        Me.CtaL = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenInfoTable.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FacturaTable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReembolsoInfoPanel.SuspendLayout()
        Me.DatosTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
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
        'AprobadoV
        '
        Me.AprobadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoV.Location = New System.Drawing.Point(130, 156)
        Me.AprobadoV.Name = "AprobadoV"
        Me.AprobadoV.Size = New System.Drawing.Size(100, 22)
        Me.AprobadoV.TabIndex = 217
        '
        'AprobadoL
        '
        Me.AprobadoL.AutoSize = True
        Me.AprobadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoL.Location = New System.Drawing.Point(3, 153)
        Me.AprobadoL.Name = "AprobadoL"
        Me.AprobadoL.Size = New System.Drawing.Size(97, 16)
        Me.AprobadoL.TabIndex = 216
        Me.AprobadoL.Text = "Total Aprobado:"
        '
        'NotasL
        '
        Me.NotasL.AutoSize = True
        Me.NotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasL.Location = New System.Drawing.Point(3, 181)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(97, 16)
        Me.NotasL.TabIndex = 1
        Me.NotasL.Text = "Observaciones:"
        '
        'FechaAutoV
        '
        Me.FechaAutoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAutoV.Location = New System.Drawing.Point(130, 3)
        Me.FechaAutoV.Name = "FechaAutoV"
        Me.FechaAutoV.Size = New System.Drawing.Size(388, 22)
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
        Me.TipoV.Location = New System.Drawing.Point(130, 61)
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
        Me.AprobadoPorV.Location = New System.Drawing.Point(130, 31)
        Me.AprobadoPorV.Name = "AprobadoPorV"
        Me.AprobadoPorV.Size = New System.Drawing.Size(249, 24)
        Me.AprobadoPorV.TabIndex = 215
        '
        'ValorV
        '
        Me.ValorV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorV.Location = New System.Drawing.Point(130, 91)
        Me.ValorV.Name = "ValorV"
        Me.ValorV.Size = New System.Drawing.Size(100, 22)
        Me.ValorV.TabIndex = 213
        '
        'PorcentajeL
        '
        Me.PorcentajeL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PorcentajeL.AutoSize = True
        Me.PorcentajeL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeL.Location = New System.Drawing.Point(3, 116)
        Me.PorcentajeL.Name = "PorcentajeL"
        Me.PorcentajeL.Size = New System.Drawing.Size(70, 37)
        Me.PorcentajeL.TabIndex = 210
        Me.PorcentajeL.Text = "Porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aprobado:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PorcentajeV, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TotalDifCheck, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CodigoTipo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(130, 119)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(375, 31)
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
        Me.PorcentajeV.Size = New System.Drawing.Size(15, 31)
        Me.PorcentajeV.TabIndex = 211
        Me.PorcentajeV.Text = "_"
        '
        'TotalDifCheck
        '
        Me.TotalDifCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDifCheck.Location = New System.Drawing.Point(124, 3)
        Me.TotalDifCheck.Name = "TotalDifCheck"
        Me.TotalDifCheck.Size = New System.Drawing.Size(232, 25)
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
        'NotasV
        '
        Me.NotasV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasV.Location = New System.Drawing.Point(130, 184)
        Me.NotasV.MaxLength = 99
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(388, 22)
        Me.NotasV.TabIndex = 214
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
        Me.ListadoGrid.Location = New System.Drawing.Point(583, 3)
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
        Me.ListadoGrid.Size = New System.Drawing.Size(198, 566)
        Me.ListadoGrid.TabIndex = 216
        Me.ListadoGrid.Visible = False
        '
        'FormaPagoL
        '
        Me.FormaPagoL.AutoSize = True
        Me.FormaPagoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaPagoL.ForeColor = System.Drawing.Color.Navy
        Me.FormaPagoL.Location = New System.Drawing.Point(3, 209)
        Me.FormaPagoL.Name = "FormaPagoL"
        Me.FormaPagoL.Size = New System.Drawing.Size(121, 18)
        Me.FormaPagoL.TabIndex = 218
        Me.FormaPagoL.Text = "*Forma de Pago:"
        '
        'GenInfoTable
        '
        Me.GenInfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenInfoTable.BackColor = System.Drawing.Color.AliceBlue
        Me.GenInfoTable.ColumnCount = 6
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.Controls.Add(Me.ClasificacionV, 5, 0)
        Me.GenInfoTable.Controls.Add(Me.TipoMiembroL, 2, 0)
        Me.GenInfoTable.Controls.Add(Me.NombreL, 0, 0)
        Me.GenInfoTable.Controls.Add(Me.NombreV, 1, 0)
        Me.GenInfoTable.Controls.Add(Me.TipoMiembroV, 3, 0)
        Me.GenInfoTable.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenInfoTable.Location = New System.Drawing.Point(0, 156)
        Me.GenInfoTable.Name = "GenInfoTable"
        Me.GenInfoTable.RowCount = 1
        Me.GenInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.GenInfoTable.Size = New System.Drawing.Size(784, 25)
        Me.GenInfoTable.TabIndex = 243
        '
        'ClasificacionV
        '
        Me.ClasificacionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClasificacionV.AutoSize = True
        Me.ClasificacionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClasificacionV.Location = New System.Drawing.Point(766, 0)
        Me.ClasificacionV.Name = "ClasificacionV"
        Me.ClasificacionV.Size = New System.Drawing.Size(15, 16)
        Me.ClasificacionV.TabIndex = 209
        Me.ClasificacionV.Text = "_"
        Me.ClasificacionV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TipoMiembroL
        '
        Me.TipoMiembroL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMiembroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMiembroL.ForeColor = System.Drawing.Color.Black
        Me.TipoMiembroL.Location = New System.Drawing.Point(87, 0)
        Me.TipoMiembroL.Name = "TipoMiembroL"
        Me.TipoMiembroL.Size = New System.Drawing.Size(503, 26)
        Me.TipoMiembroL.TabIndex = 209
        Me.TipoMiembroL.Text = "Tipo Miembro:"
        Me.TipoMiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'TipoMiembroV
        '
        Me.TipoMiembroV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMiembroV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoMiembroV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipoMiembroV.Location = New System.Drawing.Point(596, 0)
        Me.TipoMiembroV.Name = "TipoMiembroV"
        Me.TipoMiembroV.Size = New System.Drawing.Size(144, 26)
        Me.TipoMiembroV.TabIndex = 205
        Me.TipoMiembroV.Text = "_"
        Me.TipoMiembroV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FacturaTable, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListadoGrid, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 186)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 572)
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
        Me.FacturaTable.Size = New System.Drawing.Size(544, 566)
        Me.FacturaTable.TabIndex = 227
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.AvisosGrid)
        Me.Panel1.Controls.Add(Me.AvisosL)
        Me.Panel1.Location = New System.Drawing.Point(3, 277)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 286)
        Me.Panel1.TabIndex = 224
        '
        'AvisosGrid
        '
        Me.AvisosGrid.AllowUserToAddRows = False
        Me.AvisosGrid.AllowUserToDeleteRows = False
        Me.AvisosGrid.AllowUserToResizeColumns = False
        Me.AvisosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.AvisosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvisosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AvisosGrid.BackgroundColor = System.Drawing.Color.White
        Me.AvisosGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AvisosGrid.CausesValidation = False
        Me.AvisosGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.AvisosGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.AvisosGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvisosGrid.ColumnHeadersVisible = False
        Me.AvisosGrid.GridColor = System.Drawing.Color.White
        Me.AvisosGrid.Location = New System.Drawing.Point(4, 24)
        Me.AvisosGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.AvisosGrid.MultiSelect = False
        Me.AvisosGrid.Name = "AvisosGrid"
        Me.AvisosGrid.ReadOnly = True
        Me.AvisosGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AvisosGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.RowHeadersVisible = False
        Me.AvisosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        Me.AvisosGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.AvisosGrid.RowTemplate.ReadOnly = True
        Me.AvisosGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.AvisosGrid.ShowEditingIcon = False
        Me.AvisosGrid.Size = New System.Drawing.Size(529, 254)
        Me.AvisosGrid.TabIndex = 200
        Me.AvisosGrid.Visible = False
        '
        'AvisosL
        '
        Me.AvisosL.AutoSize = True
        Me.AvisosL.BackColor = System.Drawing.Color.Chocolate
        Me.AvisosL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvisosL.ForeColor = System.Drawing.Color.White
        Me.AvisosL.Location = New System.Drawing.Point(1, 0)
        Me.AvisosL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AvisosL.Name = "AvisosL"
        Me.AvisosL.Size = New System.Drawing.Size(123, 17)
        Me.AvisosL.TabIndex = 199
        Me.AvisosL.Text = "Avisos Familiares"
        Me.AvisosL.Visible = False
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
        Me.ReembolsoInfoPanel.Size = New System.Drawing.Size(538, 268)
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
        Me.DatosTable.Controls.Add(Me.FormaPagoL, 0, 7)
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
        Me.DatosTable.Controls.Add(Me.formaCombo, 1, 7)
        Me.DatosTable.Controls.Add(Me.CtaL, 1, 8)
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
        Me.DatosTable.Size = New System.Drawing.Size(525, 263)
        Me.DatosTable.TabIndex = 215
        Me.DatosTable.Visible = False
        '
        'formaCombo
        '
        Me.formaCombo.FormattingEnabled = True
        Me.formaCombo.Location = New System.Drawing.Point(130, 212)
        Me.formaCombo.Name = "formaCombo"
        Me.formaCombo.Size = New System.Drawing.Size(163, 24)
        Me.formaCombo.TabIndex = 221
        '
        'CtaL
        '
        Me.CtaL.AutoSize = True
        Me.CtaL.Location = New System.Drawing.Point(130, 239)
        Me.CtaL.Name = "CtaL"
        Me.CtaL.Size = New System.Drawing.Size(12, 16)
        Me.CtaL.TabIndex = 222
        Me.CtaL.Text = "-"
        Me.CtaL.Visible = False
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
        Me.MiembroL.Location = New System.Drawing.Point(572, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(89, 36)
        Me.MiembroL.TabIndex = 207
        Me.MiembroL.Text = "Paciente:"
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
        'AutorizarReembolsosRece
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 749)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.GenInfoTable)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AutorizarReembolsosRece"
        Me.Text = "Autorizar Reembolsos Recepción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenInfoTable.ResumeLayout(False)
        Me.GenInfoTable.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FacturaTable.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReembolsoInfoPanel.ResumeLayout(False)
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ValorL As System.Windows.Forms.Label
    Friend WithEvents AprobadoV As System.Windows.Forms.TextBox
    Friend WithEvents AprobadoL As System.Windows.Forms.Label
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents FechaAutoV As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaAutoL As System.Windows.Forms.Label
    Friend WithEvents TipoV As System.Windows.Forms.ComboBox
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents AprobadoPorL As System.Windows.Forms.Label
    Friend WithEvents AprobadoPorV As System.Windows.Forms.ComboBox
    Friend WithEvents ValorV As System.Windows.Forms.TextBox
    Friend WithEvents PorcentajeL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PorcentajeV As System.Windows.Forms.Label
    Friend WithEvents TotalDifCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CodigoTipo As System.Windows.Forms.TextBox
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents FormaPagoL As System.Windows.Forms.Label
    Friend WithEvents GenInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ClasificacionV As System.Windows.Forms.Label
    Friend WithEvents TipoMiembroL As System.Windows.Forms.Label
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents TipoMiembroV As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FacturaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AvisosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AvisosL As System.Windows.Forms.Label
    Friend WithEvents ReembolsoInfoPanel As System.Windows.Forms.Panel
    Friend WithEvents DatosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents formaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CtaL As System.Windows.Forms.Label
End Class
