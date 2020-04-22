<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticasSalud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadisticasSalud))
        Me.nutriLink = New System.Windows.Forms.LinkLabel()
        Me.VisitasCasaLink = New System.Windows.Forms.LinkLabel()
        Me.reExtLink = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResultadosTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.OtrosGrid = New System.Windows.Forms.DataGridView()
        Me.dentalLink = New System.Windows.Forms.LinkLabel()
        Me.FarmaciaL = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.IndicacionesL = New System.Windows.Forms.Label()
        Me.MesL = New System.Windows.Forms.Label()
        Me.MesCombo = New System.Windows.Forms.ComboBox()
        Me.refTSLink = New System.Windows.Forms.LinkLabel()
        Me.ReembolsosLink = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PacientesConsultaExtL = New System.Windows.Forms.LinkLabel()
        Me.LabLink = New System.Windows.Forms.LinkLabel()
        Me.OpcionesPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.refAELink = New System.Windows.Forms.LinkLabel()
        Me.refExtLink = New System.Windows.Forms.LinkLabel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ResultadosTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtrosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.OpcionesPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'nutriLink
        '
        Me.nutriLink.AutoSize = True
        Me.nutriLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nutriLink.Location = New System.Drawing.Point(239, 40)
        Me.nutriLink.Name = "nutriLink"
        Me.nutriLink.Size = New System.Drawing.Size(138, 17)
        Me.nutriLink.TabIndex = 198
        Me.nutriLink.TabStop = True
        Me.nutriLink.Text = "NUTRICION (10-13)"
        '
        'VisitasCasaLink
        '
        Me.VisitasCasaLink.AutoSize = True
        Me.VisitasCasaLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitasCasaLink.Location = New System.Drawing.Point(433, 20)
        Me.VisitasCasaLink.Name = "VisitasCasaLink"
        Me.VisitasCasaLink.Size = New System.Drawing.Size(160, 17)
        Me.VisitasCasaLink.TabIndex = 198
        Me.VisitasCasaLink.TabStop = True
        Me.VisitasCasaLink.Text = "14. Visitas domiciliarias"
        '
        'reExtLink
        '
        Me.reExtLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reExtLink.AutoSize = True
        Me.reExtLink.Location = New System.Drawing.Point(366, 20)
        Me.reExtLink.Name = "reExtLink"
        Me.reExtLink.Size = New System.Drawing.Size(155, 16)
        Me.reExtLink.TabIndex = 200
        Me.reExtLink.TabStop = True
        Me.reExtLink.Text = "*Recetas Externas"
        Me.reExtLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.OpcionesPanel.SetColumnSpan(Me.Label1, 3)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 16)
        Me.Label1.TabIndex = 201
        Me.Label1.Text = "ESTADISTICAS POR PROGRAMA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ResultadosTable
        '
        Me.ResultadosTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultadosTable.BackColor = System.Drawing.Color.Transparent
        Me.ResultadosTable.ColumnCount = 3
        Me.ResultadosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ResultadosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.ResultadosTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ResultadosTable.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.ResultadosTable.Controls.Add(Me.OtrosGrid, 2, 0)
        Me.ResultadosTable.Location = New System.Drawing.Point(0, 271)
        Me.ResultadosTable.Name = "ResultadosTable"
        Me.ResultadosTable.RowCount = 2
        Me.ResultadosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ResultadosTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ResultadosTable.Size = New System.Drawing.Size(784, 458)
        Me.ResultadosTable.TabIndex = 248
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        Me.ListadoGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        Me.ListadoGrid.RowHeadersWidth = 15
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(371, 432)
        Me.ListadoGrid.TabIndex = 216
        Me.ListadoGrid.Visible = False
        '
        'OtrosGrid
        '
        Me.OtrosGrid.AllowUserToAddRows = False
        Me.OtrosGrid.AllowUserToDeleteRows = False
        Me.OtrosGrid.AllowUserToResizeColumns = False
        Me.OtrosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtrosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.OtrosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OtrosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.OtrosGrid.BackgroundColor = System.Drawing.Color.Beige
        Me.OtrosGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.OtrosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OtrosGrid.Location = New System.Drawing.Point(410, 3)
        Me.OtrosGrid.Name = "OtrosGrid"
        Me.OtrosGrid.RowHeadersWidth = 15
        Me.OtrosGrid.Size = New System.Drawing.Size(371, 432)
        Me.OtrosGrid.TabIndex = 218
        Me.OtrosGrid.Visible = False
        '
        'dentalLink
        '
        Me.dentalLink.AutoSize = True
        Me.dentalLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dentalLink.Location = New System.Drawing.Point(3, 60)
        Me.dentalLink.Name = "dentalLink"
        Me.dentalLink.Size = New System.Drawing.Size(180, 17)
        Me.dentalLink.TabIndex = 200
        Me.dentalLink.TabStop = True
        Me.dentalLink.Text = "CLINICA DENTAL (15 - 17)"
        '
        'FarmaciaL
        '
        Me.FarmaciaL.AutoSize = True
        Me.FarmaciaL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FarmaciaL.Location = New System.Drawing.Point(239, 20)
        Me.FarmaciaL.Name = "FarmaciaL"
        Me.FarmaciaL.Size = New System.Drawing.Size(100, 17)
        Me.FarmaciaL.TabIndex = 1
        Me.FarmaciaL.TabStop = True
        Me.FarmaciaL.Text = "FARMACIA (8)"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.AñoV, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AñoL, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.IndicacionesL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MesL, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MesCombo, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(784, 29)
        Me.TableLayoutPanel2.TabIndex = 247
        '
        'AñoV
        '
        Me.AñoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoV.Location = New System.Drawing.Point(680, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(100, 22)
        Me.AñoV.TabIndex = 218
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoL.Location = New System.Drawing.Point(639, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(35, 16)
        Me.AñoL.TabIndex = 219
        Me.AñoL.Text = "Año:"
        '
        'IndicacionesL
        '
        Me.IndicacionesL.AutoSize = True
        Me.IndicacionesL.BackColor = System.Drawing.Color.Transparent
        Me.IndicacionesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndicacionesL.ForeColor = System.Drawing.Color.Fuchsia
        Me.IndicacionesL.Location = New System.Drawing.Point(3, 0)
        Me.IndicacionesL.Name = "IndicacionesL"
        Me.IndicacionesL.Size = New System.Drawing.Size(194, 29)
        Me.IndicacionesL.TabIndex = 221
        Me.IndicacionesL.Text = "Cada reporte puede tardar unos minutos."
        '
        'MesL
        '
        Me.MesL.AutoSize = True
        Me.MesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesL.Location = New System.Drawing.Point(419, 0)
        Me.MesL.Name = "MesL"
        Me.MesL.Size = New System.Drawing.Size(37, 16)
        Me.MesL.TabIndex = 222
        Me.MesL.Text = "Mes:"
        '
        'MesCombo
        '
        Me.MesCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesCombo.FormattingEnabled = True
        Me.MesCombo.Location = New System.Drawing.Point(462, 3)
        Me.MesCombo.Name = "MesCombo"
        Me.MesCombo.Size = New System.Drawing.Size(121, 24)
        Me.MesCombo.TabIndex = 220
        '
        'refTSLink
        '
        Me.refTSLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refTSLink.AutoSize = True
        Me.refTSLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refTSLink.Location = New System.Drawing.Point(577, 20)
        Me.refTSLink.Name = "refTSLink"
        Me.refTSLink.Size = New System.Drawing.Size(204, 17)
        Me.refTSLink.TabIndex = 201
        Me.refTSLink.TabStop = True
        Me.refTSLink.Text = "*Referencias a TS"
        Me.refTSLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReembolsosLink
        '
        Me.ReembolsosLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReembolsosLink.AutoSize = True
        Me.ReembolsosLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReembolsosLink.Location = New System.Drawing.Point(366, 60)
        Me.ReembolsosLink.Name = "ReembolsosLink"
        Me.ReembolsosLink.Size = New System.Drawing.Size(155, 17)
        Me.ReembolsosLink.TabIndex = 200
        Me.ReembolsosLink.TabStop = True
        Me.ReembolsosLink.Text = "*Reembolsos"
        Me.ReembolsosLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Purple
        Me.OpcionesPanel.SetColumnSpan(Me.Label3, 3)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(366, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(415, 16)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = " ESTADISTICAS EXTRAS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Purple
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(433, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 16)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "OTRAS ESTADISTICAS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PacientesConsultaExtL
        '
        Me.PacientesConsultaExtL.AutoSize = True
        Me.PacientesConsultaExtL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacientesConsultaExtL.Location = New System.Drawing.Point(3, 20)
        Me.PacientesConsultaExtL.Name = "PacientesConsultaExtL"
        Me.PacientesConsultaExtL.Size = New System.Drawing.Size(155, 17)
        Me.PacientesConsultaExtL.TabIndex = 0
        Me.PacientesConsultaExtL.TabStop = True
        Me.PacientesConsultaExtL.Text = "CLINICA MEDICA (1-7)"
        '
        'LabLink
        '
        Me.LabLink.AutoSize = True
        Me.LabLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLink.Location = New System.Drawing.Point(3, 40)
        Me.LabLink.Name = "LabLink"
        Me.LabLink.Size = New System.Drawing.Size(135, 17)
        Me.LabLink.TabIndex = 199
        Me.LabLink.TabStop = True
        Me.LabLink.Text = "LABORATORIO (9)"
        '
        'OpcionesPanel
        '
        Me.OpcionesPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpcionesPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OpcionesPanel.ColumnCount = 9
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.OpcionesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OpcionesPanel.Controls.Add(Me.refAELink, 8, 2)
        Me.OpcionesPanel.Controls.Add(Me.refTSLink, 8, 1)
        Me.OpcionesPanel.Controls.Add(Me.ReembolsosLink, 6, 3)
        Me.OpcionesPanel.Controls.Add(Me.Label3, 6, 0)
        Me.OpcionesPanel.Controls.Add(Me.Label2, 4, 0)
        Me.OpcionesPanel.Controls.Add(Me.PacientesConsultaExtL, 0, 1)
        Me.OpcionesPanel.Controls.Add(Me.LabLink, 0, 2)
        Me.OpcionesPanel.Controls.Add(Me.dentalLink, 0, 3)
        Me.OpcionesPanel.Controls.Add(Me.FarmaciaL, 2, 1)
        Me.OpcionesPanel.Controls.Add(Me.nutriLink, 2, 2)
        Me.OpcionesPanel.Controls.Add(Me.VisitasCasaLink, 4, 1)
        Me.OpcionesPanel.Controls.Add(Me.reExtLink, 6, 1)
        Me.OpcionesPanel.Controls.Add(Me.refExtLink, 6, 2)
        Me.OpcionesPanel.Controls.Add(Me.Label1, 0, 0)
        Me.OpcionesPanel.Location = New System.Drawing.Point(0, 160)
        Me.OpcionesPanel.Name = "OpcionesPanel"
        Me.OpcionesPanel.RowCount = 5
        Me.OpcionesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.OpcionesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.OpcionesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OpcionesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OpcionesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.OpcionesPanel.Size = New System.Drawing.Size(784, 100)
        Me.OpcionesPanel.TabIndex = 246
        '
        'refAELink
        '
        Me.refAELink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refAELink.AutoSize = True
        Me.refAELink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refAELink.Location = New System.Drawing.Point(577, 40)
        Me.refAELink.Name = "refAELink"
        Me.refAELink.Size = New System.Drawing.Size(204, 17)
        Me.refAELink.TabIndex = 202
        Me.refAELink.TabStop = True
        Me.refAELink.Text = "*Referencias Apoyo Educativo"
        Me.refAELink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'refExtLink
        '
        Me.refExtLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refExtLink.AutoSize = True
        Me.refExtLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refExtLink.Location = New System.Drawing.Point(366, 40)
        Me.refExtLink.Name = "refExtLink"
        Me.refExtLink.Size = New System.Drawing.Size(155, 17)
        Me.refExtLink.TabIndex = 199
        Me.refExtLink.TabStop = True
        Me.refExtLink.Text = "*Referencias Externas"
        Me.refExtLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 261
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
        Me.Title.Text = "Estadísticas Salud"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EstadisticasSalud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ResultadosTable)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.OpcionesPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EstadisticasSalud"
        Me.Text = "Estadisticas Salud"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResultadosTable.ResumeLayout(False)
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtrosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.OpcionesPanel.ResumeLayout(False)
        Me.OpcionesPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nutriLink As System.Windows.Forms.LinkLabel
    Friend WithEvents VisitasCasaLink As System.Windows.Forms.LinkLabel
    Friend WithEvents reExtLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpcionesPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents refAELink As System.Windows.Forms.LinkLabel
    Friend WithEvents refTSLink As System.Windows.Forms.LinkLabel
    Friend WithEvents ReembolsosLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PacientesConsultaExtL As System.Windows.Forms.LinkLabel
    Friend WithEvents LabLink As System.Windows.Forms.LinkLabel
    Friend WithEvents dentalLink As System.Windows.Forms.LinkLabel
    Friend WithEvents FarmaciaL As System.Windows.Forms.LinkLabel
    Friend WithEvents refExtLink As System.Windows.Forms.LinkLabel
    Friend WithEvents ResultadosTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents OtrosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents IndicacionesL As System.Windows.Forms.Label
    Friend WithEvents MesL As System.Windows.Forms.Label
    Friend WithEvents MesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
