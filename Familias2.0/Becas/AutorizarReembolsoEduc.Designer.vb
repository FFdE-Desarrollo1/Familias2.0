<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutorizarReembolsoEduc
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutorizarReembolsoEduc))
        Me.ChequeCheckBox = New System.Windows.Forms.CheckBox()
        Me.DatosTable = New System.Windows.Forms.TableLayoutPanel()
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
        Me.ActividadesL = New System.Windows.Forms.Label()
        Me.HistorialPagosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.OpcionesPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.reembolsosTipoL = New System.Windows.Forms.Label()
        Me.HistorialPagosL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.EfectivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.GenInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.EducGrid = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FormaPagoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ACHCheckBox = New System.Windows.Forms.CheckBox()
        Me.PagoInfoPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FacturaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.AvisosGrid = New System.Windows.Forms.DataGridView()
        Me.AvisosLink = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FormaPagoL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ResumenBecaButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.DatosTable.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.HistorialPagosTable.SuspendLayout()
        Me.OpcionesPanel.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenInfoTable.SuspendLayout()
        CType(Me.EducGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.FormaPagoTable.SuspendLayout()
        Me.PagoInfoPanel.SuspendLayout()
        Me.FacturaTable.SuspendLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChequeCheckBox
        '
        Me.ChequeCheckBox.AutoSize = True
        Me.ChequeCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.ChequeCheckBox.Name = "ChequeCheckBox"
        Me.ChequeCheckBox.Size = New System.Drawing.Size(103, 26)
        Me.ChequeCheckBox.TabIndex = 0
        Me.ChequeCheckBox.Text = "Cheque"
        Me.ChequeCheckBox.UseVisualStyleBackColor = True
        '
        'DatosTable
        '
        Me.DatosTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTable.BackColor = System.Drawing.Color.Transparent
        Me.DatosTable.ColumnCount = 2
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DatosTable.Controls.Add(Me.FechaAutoV, 1, 1)
        Me.DatosTable.Controls.Add(Me.FechaAutoL, 0, 1)
        Me.DatosTable.Controls.Add(Me.TipoV, 1, 3)
        Me.DatosTable.Controls.Add(Me.TipoL, 0, 3)
        Me.DatosTable.Controls.Add(Me.AprobadoPorL, 0, 2)
        Me.DatosTable.Controls.Add(Me.AprobadoPorV, 1, 2)
        Me.DatosTable.Controls.Add(Me.ValorL, 0, 4)
        Me.DatosTable.Controls.Add(Me.ValorV, 1, 4)
        Me.DatosTable.Controls.Add(Me.PorcentajeL, 0, 5)
        Me.DatosTable.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.DatosTable.Controls.Add(Me.AprobadoV, 1, 6)
        Me.DatosTable.Controls.Add(Me.AprobadoL, 0, 6)
        Me.DatosTable.Controls.Add(Me.NotasL, 0, 7)
        Me.DatosTable.Controls.Add(Me.NotasV, 1, 7)
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
        Me.DatosTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.DatosTable.Size = New System.Drawing.Size(500, 255)
        Me.DatosTable.TabIndex = 215
        '
        'FechaAutoV
        '
        Me.FechaAutoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAutoV.Location = New System.Drawing.Point(210, 3)
        Me.FechaAutoV.Name = "FechaAutoV"
        Me.FechaAutoV.Size = New System.Drawing.Size(310, 30)
        Me.FechaAutoV.TabIndex = 32
        '
        'FechaAutoL
        '
        Me.FechaAutoL.AutoSize = True
        Me.FechaAutoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAutoL.Location = New System.Drawing.Point(3, 0)
        Me.FechaAutoL.Name = "FechaAutoL"
        Me.FechaAutoL.Size = New System.Drawing.Size(189, 23)
        Me.FechaAutoL.TabIndex = 209
        Me.FechaAutoL.Text = "*Fecha Autorización:"
        '
        'TipoV
        '
        Me.TipoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TipoV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoV.FormattingEnabled = True
        Me.TipoV.Location = New System.Drawing.Point(210, 76)
        Me.TipoV.Name = "TipoV"
        Me.TipoV.Size = New System.Drawing.Size(310, 31)
        Me.TipoV.TabIndex = 208
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoL.Location = New System.Drawing.Point(3, 73)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(61, 23)
        Me.TipoL.TabIndex = 205
        Me.TipoL.Text = "*Tipo:"
        '
        'AprobadoPorL
        '
        Me.AprobadoPorL.AutoSize = True
        Me.AprobadoPorL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoPorL.Location = New System.Drawing.Point(3, 36)
        Me.AprobadoPorL.Name = "AprobadoPorL"
        Me.AprobadoPorL.Size = New System.Drawing.Size(145, 23)
        Me.AprobadoPorL.TabIndex = 214
        Me.AprobadoPorL.Text = "*Aprobado por:"
        '
        'AprobadoPorV
        '
        Me.AprobadoPorV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AprobadoPorV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoPorV.FormattingEnabled = True
        Me.AprobadoPorV.Location = New System.Drawing.Point(210, 39)
        Me.AprobadoPorV.Name = "AprobadoPorV"
        Me.AprobadoPorV.Size = New System.Drawing.Size(310, 31)
        Me.AprobadoPorV.TabIndex = 215
        '
        'ValorL
        '
        Me.ValorL.AutoSize = True
        Me.ValorL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorL.Location = New System.Drawing.Point(3, 110)
        Me.ValorL.Name = "ValorL"
        Me.ValorL.Size = New System.Drawing.Size(123, 23)
        Me.ValorL.TabIndex = 212
        Me.ValorL.Text = "*Valor Total :"
        '
        'ValorV
        '
        Me.ValorV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorV.Location = New System.Drawing.Point(210, 113)
        Me.ValorV.Name = "ValorV"
        Me.ValorV.Size = New System.Drawing.Size(100, 30)
        Me.ValorV.TabIndex = 213
        '
        'PorcentajeL
        '
        Me.PorcentajeL.AutoSize = True
        Me.PorcentajeL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeL.Location = New System.Drawing.Point(3, 146)
        Me.PorcentajeL.Name = "PorcentajeL"
        Me.PorcentajeL.Size = New System.Drawing.Size(201, 23)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(210, 149)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(359, 35)
        Me.TableLayoutPanel2.TabIndex = 220
        '
        'PorcentajeV
        '
        Me.PorcentajeV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PorcentajeV.AutoSize = True
        Me.PorcentajeV.BackColor = System.Drawing.Color.DodgerBlue
        Me.PorcentajeV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorcentajeV.ForeColor = System.Drawing.Color.White
        Me.PorcentajeV.Location = New System.Drawing.Point(3, 0)
        Me.PorcentajeV.Name = "PorcentajeV"
        Me.PorcentajeV.Size = New System.Drawing.Size(21, 35)
        Me.PorcentajeV.TabIndex = 211
        Me.PorcentajeV.Text = "_"
        '
        'TotalDifCheck
        '
        Me.TotalDifCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalDifCheck.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDifCheck.Location = New System.Drawing.Point(130, 3)
        Me.TotalDifCheck.Name = "TotalDifCheck"
        Me.TotalDifCheck.Size = New System.Drawing.Size(226, 29)
        Me.TotalDifCheck.TabIndex = 219
        Me.TotalDifCheck.Text = "¿Necesita cambiar el % aprobado?"
        Me.TotalDifCheck.UseVisualStyleBackColor = True
        Me.TotalDifCheck.Visible = False
        '
        'CodigoTipo
        '
        Me.CodigoTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoTipo.Location = New System.Drawing.Point(30, 3)
        Me.CodigoTipo.Name = "CodigoTipo"
        Me.CodigoTipo.Size = New System.Drawing.Size(26, 30)
        Me.CodigoTipo.TabIndex = 218
        Me.CodigoTipo.Visible = False
        '
        'AprobadoV
        '
        Me.AprobadoV.Enabled = False
        Me.AprobadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoV.Location = New System.Drawing.Point(210, 190)
        Me.AprobadoV.Name = "AprobadoV"
        Me.AprobadoV.Size = New System.Drawing.Size(100, 30)
        Me.AprobadoV.TabIndex = 217
        '
        'AprobadoL
        '
        Me.AprobadoL.AutoSize = True
        Me.AprobadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprobadoL.Location = New System.Drawing.Point(3, 187)
        Me.AprobadoL.Name = "AprobadoL"
        Me.AprobadoL.Size = New System.Drawing.Size(149, 23)
        Me.AprobadoL.TabIndex = 216
        Me.AprobadoL.Text = "Total Aprobado:"
        '
        'NotasL
        '
        Me.NotasL.AutoSize = True
        Me.NotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasL.Location = New System.Drawing.Point(3, 223)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(147, 23)
        Me.NotasL.TabIndex = 1
        Me.NotasL.Text = "Observaciones:"
        '
        'NotasV
        '
        Me.NotasV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasV.Location = New System.Drawing.Point(210, 226)
        Me.NotasV.MaxLength = 38
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(310, 30)
        Me.NotasV.TabIndex = 0
        '
        'ActividadesL
        '
        Me.ActividadesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActividadesL.AutoSize = True
        Me.ActividadesL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActividadesL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ActividadesL.Location = New System.Drawing.Point(69, 0)
        Me.ActividadesL.Name = "ActividadesL"
        Me.ActividadesL.Size = New System.Drawing.Size(128, 24)
        Me.ActividadesL.TabIndex = 219
        Me.ActividadesL.Text = "Actividades"
        Me.ActividadesL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HistorialPagosTable
        '
        Me.HistorialPagosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialPagosTable.ColumnCount = 1
        Me.HistorialPagosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HistorialPagosTable.Controls.Add(Me.OpcionesPanel, 0, 0)
        Me.HistorialPagosTable.Controls.Add(Me.ListadoGrid, 0, 1)
        Me.HistorialPagosTable.Location = New System.Drawing.Point(575, 3)
        Me.HistorialPagosTable.Name = "HistorialPagosTable"
        Me.HistorialPagosTable.RowCount = 2
        Me.HistorialPagosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.HistorialPagosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HistorialPagosTable.Size = New System.Drawing.Size(206, 513)
        Me.HistorialPagosTable.TabIndex = 228
        '
        'OpcionesPanel
        '
        Me.OpcionesPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpcionesPanel.ColumnCount = 3
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesPanel.Controls.Add(Me.reembolsosTipoL, 1, 0)
        Me.OpcionesPanel.Controls.Add(Me.HistorialPagosL, 0, 0)
        Me.OpcionesPanel.Controls.Add(Me.ActividadesL, 2, 0)
        Me.OpcionesPanel.Location = New System.Drawing.Point(3, 3)
        Me.OpcionesPanel.Name = "OpcionesPanel"
        Me.OpcionesPanel.RowCount = 1
        Me.OpcionesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesPanel.Size = New System.Drawing.Size(200, 24)
        Me.OpcionesPanel.TabIndex = 218
        '
        'reembolsosTipoL
        '
        Me.reembolsosTipoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reembolsosTipoL.AutoSize = True
        Me.reembolsosTipoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reembolsosTipoL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.reembolsosTipoL.Location = New System.Drawing.Point(148, 0)
        Me.reembolsosTipoL.Name = "reembolsosTipoL"
        Me.reembolsosTipoL.Size = New System.Drawing.Size(1, 24)
        Me.reembolsosTipoL.TabIndex = 218
        Me.reembolsosTipoL.Text = "Reembolsos por Tipo"
        Me.reembolsosTipoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HistorialPagosL
        '
        Me.HistorialPagosL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistorialPagosL.AutoSize = True
        Me.HistorialPagosL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistorialPagosL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HistorialPagosL.Location = New System.Drawing.Point(3, 0)
        Me.HistorialPagosL.Name = "HistorialPagosL"
        Me.HistorialPagosL.Size = New System.Drawing.Size(139, 24)
        Me.HistorialPagosL.TabIndex = 217
        Me.HistorialPagosL.Text = "Reembolsos"
        Me.HistorialPagosL.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 33)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListadoGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListadoGrid.Size = New System.Drawing.Size(200, 477)
        Me.ListadoGrid.TabIndex = 216
        '
        'EfectivoCheckBox
        '
        Me.EfectivoCheckBox.AutoSize = True
        Me.EfectivoCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EfectivoCheckBox.Location = New System.Drawing.Point(335, 3)
        Me.EfectivoCheckBox.Name = "EfectivoCheckBox"
        Me.EfectivoCheckBox.Size = New System.Drawing.Size(106, 26)
        Me.EfectivoCheckBox.TabIndex = 208
        Me.EfectivoCheckBox.Text = "Efectivo"
        Me.EfectivoCheckBox.UseVisualStyleBackColor = True
        Me.EfectivoCheckBox.Visible = False
        '
        'GenInfoTable
        '
        Me.GenInfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenInfoTable.BackColor = System.Drawing.Color.AliceBlue
        Me.GenInfoTable.ColumnCount = 3
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GenInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GenInfoTable.Controls.Add(Me.EducGrid, 0, 0)
        Me.GenInfoTable.Controls.Add(Me.TableLayoutPanel3, 2, 0)
        Me.GenInfoTable.Location = New System.Drawing.Point(0, 120)
        Me.GenInfoTable.Name = "GenInfoTable"
        Me.GenInfoTable.RowCount = 1
        Me.GenInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.GenInfoTable.Size = New System.Drawing.Size(784, 116)
        Me.GenInfoTable.TabIndex = 243
        '
        'EducGrid
        '
        Me.EducGrid.AllowUserToAddRows = False
        Me.EducGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EducGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.EducGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EducGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.EducGrid.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.EducGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EducGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EducGrid.Location = New System.Drawing.Point(3, 3)
        Me.EducGrid.Name = "EducGrid"
        Me.EducGrid.ReadOnly = True
        Me.EducGrid.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EducGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.EducGrid.Size = New System.Drawing.Size(313, 110)
        Me.EducGrid.TabIndex = 222
        Me.EducGrid.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.PrincipalPanel, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(342, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(439, 110)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.NombreV, 1, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 80)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(433, 27)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.NombreV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.Location = New System.Drawing.Point(407, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(23, 27)
        Me.NombreV.TabIndex = 207
        Me.NombreV.Text = "_"
        Me.NombreV.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.NombreV.Visible = False
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.PrincipalPanel.ColumnCount = 3
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 1, 1)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 2, 1)
        Me.PrincipalPanel.Controls.Add(Me.MiembroL, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 2, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(3, 3)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 2
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.Size = New System.Drawing.Size(433, 71)
        Me.PrincipalPanel.TabIndex = 219
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(188, 46)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(142, 46)
        Me.FamiliaL.TabIndex = 208
        Me.FamiliaL.Text = "Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(336, 49)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(94, 40)
        Me.FamiliaV.TabIndex = 207
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroL
        '
        Me.MiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroL.AutoSize = True
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(188, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(142, 46)
        Me.MiembroL.TabIndex = 207
        Me.MiembroL.Text = "Apadrinado:"
        Me.MiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MiembroV
        '
        Me.MiembroV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(336, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(94, 40)
        Me.MiembroV.TabIndex = 207
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormaPagoTable
        '
        Me.FormaPagoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormaPagoTable.ColumnCount = 3
        Me.FormaPagoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.FormaPagoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.FormaPagoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.FormaPagoTable.Controls.Add(Me.ChequeCheckBox, 0, 0)
        Me.FormaPagoTable.Controls.Add(Me.EfectivoCheckBox, 2, 0)
        Me.FormaPagoTable.Controls.Add(Me.ACHCheckBox, 1, 0)
        Me.FormaPagoTable.Location = New System.Drawing.Point(3, 284)
        Me.FormaPagoTable.Name = "FormaPagoTable"
        Me.FormaPagoTable.RowCount = 1
        Me.FormaPagoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FormaPagoTable.Size = New System.Drawing.Size(500, 32)
        Me.FormaPagoTable.TabIndex = 207
        '
        'ACHCheckBox
        '
        Me.ACHCheckBox.AutoSize = True
        Me.ACHCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACHCheckBox.Location = New System.Drawing.Point(169, 3)
        Me.ACHCheckBox.Name = "ACHCheckBox"
        Me.ACHCheckBox.Size = New System.Drawing.Size(135, 26)
        Me.ACHCheckBox.TabIndex = 208
        Me.ACHCheckBox.Text = "Guate ACH"
        Me.ACHCheckBox.UseVisualStyleBackColor = True
        '
        'PagoInfoPanel
        '
        Me.PagoInfoPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PagoInfoPanel.BackColor = System.Drawing.Color.Transparent
        Me.PagoInfoPanel.ColumnCount = 3
        Me.PagoInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 520.0!))
        Me.PagoInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PagoInfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.PagoInfoPanel.Controls.Add(Me.FacturaTable, 0, 0)
        Me.PagoInfoPanel.Controls.Add(Me.HistorialPagosTable, 2, 0)
        Me.PagoInfoPanel.Location = New System.Drawing.Point(0, 239)
        Me.PagoInfoPanel.Name = "PagoInfoPanel"
        Me.PagoInfoPanel.RowCount = 1
        Me.PagoInfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PagoInfoPanel.Size = New System.Drawing.Size(784, 519)
        Me.PagoInfoPanel.TabIndex = 244
        Me.PagoInfoPanel.Visible = False
        '
        'FacturaTable
        '
        Me.FacturaTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturaTable.ColumnCount = 1
        Me.FacturaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 594.0!))
        Me.FacturaTable.Controls.Add(Me.AvisosGrid, 0, 2)
        Me.FacturaTable.Controls.Add(Me.AvisosLink, 0, 1)
        Me.FacturaTable.Controls.Add(Me.Panel1, 0, 0)
        Me.FacturaTable.Location = New System.Drawing.Point(3, 3)
        Me.FacturaTable.Name = "FacturaTable"
        Me.FacturaTable.RowCount = 3
        Me.FacturaTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FacturaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.FacturaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FacturaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.FacturaTable.Size = New System.Drawing.Size(514, 513)
        Me.FacturaTable.TabIndex = 227
        '
        'AvisosGrid
        '
        Me.AvisosGrid.AllowUserToAddRows = False
        Me.AvisosGrid.AllowUserToDeleteRows = False
        Me.AvisosGrid.AllowUserToResizeColumns = False
        Me.AvisosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AvisosGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.AvisosGrid.GridColor = System.Drawing.Color.White
        Me.AvisosGrid.Location = New System.Drawing.Point(3, 354)
        Me.AvisosGrid.MultiSelect = False
        Me.AvisosGrid.Name = "AvisosGrid"
        Me.AvisosGrid.ReadOnly = True
        Me.AvisosGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AvisosGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.RowHeadersVisible = False
        Me.AvisosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Navy
        Me.AvisosGrid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.AvisosGrid.RowTemplate.ReadOnly = True
        Me.AvisosGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.AvisosGrid.ShowEditingIcon = False
        Me.AvisosGrid.Size = New System.Drawing.Size(588, 156)
        Me.AvisosGrid.TabIndex = 207
        Me.AvisosGrid.Visible = False
        '
        'AvisosLink
        '
        Me.AvisosLink.AutoSize = True
        Me.AvisosLink.BackColor = System.Drawing.Color.Chocolate
        Me.AvisosLink.DisabledLinkColor = System.Drawing.Color.White
        Me.AvisosLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvisosLink.ForeColor = System.Drawing.Color.White
        Me.AvisosLink.LinkColor = System.Drawing.Color.White
        Me.AvisosLink.Location = New System.Drawing.Point(3, 331)
        Me.AvisosLink.Name = "AvisosLink"
        Me.AvisosLink.Size = New System.Drawing.Size(80, 20)
        Me.AvisosLink.TabIndex = 208
        Me.AvisosLink.TabStop = True
        Me.AvisosLink.Text = "Avisos"
        Me.AvisosLink.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.FormaPagoL)
        Me.Panel1.Controls.Add(Me.FormaPagoTable)
        Me.Panel1.Controls.Add(Me.DatosTable)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 325)
        Me.Panel1.TabIndex = 0
        '
        'FormaPagoL
        '
        Me.FormaPagoL.AutoSize = True
        Me.FormaPagoL.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaPagoL.ForeColor = System.Drawing.Color.Navy
        Me.FormaPagoL.Location = New System.Drawing.Point(3, 265)
        Me.FormaPagoL.Name = "FormaPagoL"
        Me.FormaPagoL.Size = New System.Drawing.Size(187, 28)
        Me.FormaPagoL.TabIndex = 216
        Me.FormaPagoL.Text = "*Forma de Pago:"
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
        Me.opcionesTable.Controls.Add(Me.ResumenBecaButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 3, 0)
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
        'ResumenBecaButton
        '
        Me.ResumenBecaButton.BackColor = System.Drawing.Color.AliceBlue
        Me.ResumenBecaButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.BECA
        Me.ResumenBecaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ResumenBecaButton.Location = New System.Drawing.Point(527, 3)
        Me.ResumenBecaButton.Name = "ResumenBecaButton"
        Me.ResumenBecaButton.Size = New System.Drawing.Size(49, 44)
        Me.ResumenBecaButton.TabIndex = 209
        Me.ResumenBecaButton.UseVisualStyleBackColor = False
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
        Me.inicioButton.Location = New System.Drawing.Point(476, 3)
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
        Me.Title.Size = New System.Drawing.Size(465, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Autorización de Reembolsos"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutorizarReembolsoEduc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.GenInfoTable)
        Me.Controls.Add(Me.PagoInfoPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AutorizarReembolsoEduc"
        Me.Text = "Autorizar Reembolso Educ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.DatosTable.ResumeLayout(False)
        Me.DatosTable.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.HistorialPagosTable.ResumeLayout(False)
        Me.OpcionesPanel.ResumeLayout(False)
        Me.OpcionesPanel.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenInfoTable.ResumeLayout(False)
        CType(Me.EducGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.FormaPagoTable.ResumeLayout(False)
        Me.FormaPagoTable.PerformLayout()
        Me.PagoInfoPanel.ResumeLayout(False)
        Me.FacturaTable.ResumeLayout(False)
        Me.FacturaTable.PerformLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChequeCheckBox As System.Windows.Forms.CheckBox
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
    Friend WithEvents ActividadesL As System.Windows.Forms.Label
    Friend WithEvents HistorialPagosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OpcionesPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents reembolsosTipoL As System.Windows.Forms.Label
    Friend WithEvents HistorialPagosL As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EfectivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GenInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EducGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FormaPagoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ACHCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PagoInfoPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FacturaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AvisosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AvisosLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FormaPagoL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ResumenBecaButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
