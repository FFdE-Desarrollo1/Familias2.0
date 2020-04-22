<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitaLaboratorio
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CitaLaboratorio))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabPan1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NewExamButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotesV = New System.Windows.Forms.TextBox()
        Me.NotesL = New System.Windows.Forms.Label()
        Me.TipoExamenL = New System.Windows.Forms.Label()
        Me.ExamenesCombo = New System.Windows.Forms.ComboBox()
        Me.StatusC = New System.Windows.Forms.ComboBox()
        Me.ExamenesGrid = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HasSubEx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvisosL = New System.Windows.Forms.Label()
        Me.InfoCitaL = New System.Windows.Forms.Label()
        Me.AgendaGrid = New System.Windows.Forms.DataGridView()
        Me.AgendaCheck = New System.Windows.Forms.LinkLabel()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.PacienteV = New System.Windows.Forms.TextBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.EdadV = New System.Windows.Forms.Label()
        Me.CitaPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.RefInterPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.AvisosGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.LabPan1.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.ExamenesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrincipalPanel.SuspendLayout()
        Me.PanelSecundario.SuspendLayout()
        Me.CitaPanel.SuspendLayout()
        Me.RefInterPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(9, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(419, 22)
        Me.Label7.TabIndex = 416
        Me.Label7.Text = "Nuevo Laboratorio"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 35)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "*Estado:"
        Me.Label1.Visible = False
        '
        'LabPan1
        '
        Me.LabPan1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabPan1.ColumnCount = 2
        Me.LabPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LabPan1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.LabPan1.Controls.Add(Me.NewExamButton, 1, 0)
        Me.LabPan1.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.LabPan1.Location = New System.Drawing.Point(3, 99)
        Me.LabPan1.Name = "LabPan1"
        Me.LabPan1.RowCount = 1
        Me.LabPan1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LabPan1.Size = New System.Drawing.Size(434, 77)
        Me.LabPan1.TabIndex = 154
        '
        'NewExamButton
        '
        Me.NewExamButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewExamButton.BackColor = System.Drawing.Color.Chocolate
        Me.NewExamButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewExamButton.ForeColor = System.Drawing.Color.White
        Me.NewExamButton.Location = New System.Drawing.Point(357, 3)
        Me.NewExamButton.Name = "NewExamButton"
        Me.NewExamButton.Size = New System.Drawing.Size(74, 71)
        Me.NewExamButton.TabIndex = 104
        Me.NewExamButton.Text = "Agregar al Listado"
        Me.NewExamButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.NotesV, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.NotesL, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.TipoExamenL, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.ExamenesCombo, 1, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(348, 71)
        Me.TableLayoutPanel8.TabIndex = 13
        '
        'NotesV
        '
        Me.NotesV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesV.Location = New System.Drawing.Point(93, 38)
        Me.NotesV.Name = "NotesV"
        Me.NotesV.Size = New System.Drawing.Size(237, 30)
        Me.NotesV.TabIndex = 103
        '
        'NotesL
        '
        Me.NotesL.AutoSize = True
        Me.NotesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesL.ForeColor = System.Drawing.Color.Black
        Me.NotesL.Location = New System.Drawing.Point(3, 35)
        Me.NotesL.Name = "NotesL"
        Me.NotesL.Size = New System.Drawing.Size(83, 36)
        Me.NotesL.TabIndex = 162
        Me.NotesL.Text = "Observaciones:"
        '
        'TipoExamenL
        '
        Me.TipoExamenL.AutoSize = True
        Me.TipoExamenL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoExamenL.ForeColor = System.Drawing.Color.Black
        Me.TipoExamenL.Location = New System.Drawing.Point(3, 0)
        Me.TipoExamenL.Name = "TipoExamenL"
        Me.TipoExamenL.Size = New System.Drawing.Size(78, 35)
        Me.TipoExamenL.TabIndex = 161
        Me.TipoExamenL.Text = "*Examen:"
        '
        'ExamenesCombo
        '
        Me.ExamenesCombo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExamenesCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ExamenesCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ExamenesCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamenesCombo.FormattingEnabled = True
        Me.ExamenesCombo.Location = New System.Drawing.Point(93, 3)
        Me.ExamenesCombo.Name = "ExamenesCombo"
        Me.ExamenesCombo.Size = New System.Drawing.Size(237, 31)
        Me.ExamenesCombo.TabIndex = 102
        '
        'StatusC
        '
        Me.StatusC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusC.BackColor = System.Drawing.SystemColors.Window
        Me.StatusC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusC.ForeColor = System.Drawing.Color.DodgerBlue
        Me.StatusC.FormattingEnabled = True
        Me.StatusC.Location = New System.Drawing.Point(93, 37)
        Me.StatusC.Name = "StatusC"
        Me.StatusC.Size = New System.Drawing.Size(240, 31)
        Me.StatusC.TabIndex = 202
        Me.StatusC.Visible = False
        '
        'ExamenesGrid
        '
        Me.ExamenesGrid.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.ExamenesGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ExamenesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExamenesGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.ExamenesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExamenesGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Codigo, Me.Examen, Me.Notas, Me.HasSubEx, Me.Costo})
        Me.ExamenesGrid.Location = New System.Drawing.Point(3, 182)
        Me.ExamenesGrid.Name = "ExamenesGrid"
        Me.ExamenesGrid.ReadOnly = True
        Me.ExamenesGrid.RowHeadersWidth = 20
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamenesGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ExamenesGrid.Size = New System.Drawing.Size(434, 361)
        Me.ExamenesGrid.TabIndex = 11
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Examen
        '
        Me.Examen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Examen.HeaderText = "Laboratorio"
        Me.Examen.Name = "Examen"
        Me.Examen.ReadOnly = True
        Me.Examen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Examen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Examen.Width = 117
        '
        'Notas
        '
        Me.Notas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Notas.HeaderText = "Notas"
        Me.Notas.Name = "Notas"
        Me.Notas.ReadOnly = True
        Me.Notas.Width = 86
        '
        'HasSubEx
        '
        Me.HasSubEx.HeaderText = "HasSubEx"
        Me.HasSubEx.Name = "HasSubEx"
        Me.HasSubEx.ReadOnly = True
        Me.HasSubEx.Visible = False
        '
        'Costo
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle2
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Visible = False
        '
        'AvisosL
        '
        Me.AvisosL.AutoSize = True
        Me.AvisosL.BackColor = System.Drawing.Color.Chocolate
        Me.AvisosL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvisosL.ForeColor = System.Drawing.Color.White
        Me.AvisosL.Location = New System.Drawing.Point(713, 0)
        Me.AvisosL.Name = "AvisosL"
        Me.AvisosL.Size = New System.Drawing.Size(61, 15)
        Me.AvisosL.TabIndex = 33
        Me.AvisosL.Text = "Avisos"
        '
        'InfoCitaL
        '
        Me.InfoCitaL.AutoSize = True
        Me.InfoCitaL.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoCitaL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoCitaL.ForeColor = System.Drawing.Color.Navy
        Me.InfoCitaL.Location = New System.Drawing.Point(3, 0)
        Me.InfoCitaL.Name = "InfoCitaL"
        Me.InfoCitaL.Size = New System.Drawing.Size(254, 15)
        Me.InfoCitaL.TabIndex = 33
        Me.InfoCitaL.Text = "Información de la Cita"
        '
        'AgendaGrid
        '
        Me.AgendaGrid.AllowUserToAddRows = False
        Me.AgendaGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.AgendaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgendaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AgendaGrid.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.AgendaGrid.Location = New System.Drawing.Point(482, 18)
        Me.AgendaGrid.Name = "AgendaGrid"
        Me.AgendaGrid.ReadOnly = True
        Me.AgendaGrid.RowHeadersWidth = 55
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.AgendaGrid.Size = New System.Drawing.Size(185, 550)
        Me.AgendaGrid.TabIndex = 1
        Me.AgendaGrid.Tag = ""
        '
        'AgendaCheck
        '
        Me.AgendaCheck.AutoSize = True
        Me.AgendaCheck.BackColor = System.Drawing.Color.SkyBlue
        Me.AgendaCheck.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaCheck.Location = New System.Drawing.Point(482, 0)
        Me.AgendaCheck.Name = "AgendaCheck"
        Me.AgendaCheck.Size = New System.Drawing.Size(179, 15)
        Me.AgendaCheck.TabIndex = 34
        Me.AgendaCheck.TabStop = True
        Me.AgendaCheck.Text = "Revisar Agenda Laboratorio"
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.ForeColor = System.Drawing.Color.Black
        Me.FechaL.Location = New System.Drawing.Point(3, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(78, 23)
        Me.FechaL.TabIndex = 166
        Me.FechaL.Text = "*Fecha:"
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
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 36)
        Me.PrincipalPanel.TabIndex = 242
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(181, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 40)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PacienteV
        '
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PacienteV.Location = New System.Drawing.Point(667, 3)
        Me.PacienteV.MaxLength = 10
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(112, 40)
        Me.PacienteV.TabIndex = 204
        Me.PacienteV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(472, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(189, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Paciente:"
        Me.PacienteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.FamiliaL.Size = New System.Drawing.Size(172, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 3
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.EdadV, 2, 0)
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 156)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 2
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PanelSecundario.Size = New System.Drawing.Size(784, 25)
        Me.PanelSecundario.TabIndex = 243
        Me.PanelSecundario.Visible = False
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(85, 23)
        Me.NombreL.TabIndex = 1
        Me.NombreL.Text = "Nombre:"
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NombreV.Location = New System.Drawing.Point(94, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(21, 23)
        Me.NombreV.TabIndex = 2
        Me.NombreV.Text = "_"
        '
        'EdadV
        '
        Me.EdadV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdadV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EdadV.Location = New System.Drawing.Point(121, 0)
        Me.EdadV.Name = "EdadV"
        Me.EdadV.Size = New System.Drawing.Size(660, 23)
        Me.EdadV.TabIndex = 198
        '
        'CitaPanel
        '
        Me.CitaPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CitaPanel.AutoSize = True
        Me.CitaPanel.BackColor = System.Drawing.Color.Transparent
        Me.CitaPanel.ColumnCount = 5
        Me.CitaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.CitaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.CitaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.CitaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.CitaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CitaPanel.Controls.Add(Me.RefInterPanel, 0, 1)
        Me.CitaPanel.Controls.Add(Me.AvisosL, 4, 0)
        Me.CitaPanel.Controls.Add(Me.InfoCitaL, 0, 0)
        Me.CitaPanel.Controls.Add(Me.AgendaGrid, 2, 1)
        Me.CitaPanel.Controls.Add(Me.AvisosGrid, 4, 1)
        Me.CitaPanel.Controls.Add(Me.AgendaCheck, 2, 0)
        Me.CitaPanel.Location = New System.Drawing.Point(0, 186)
        Me.CitaPanel.Name = "CitaPanel"
        Me.CitaPanel.RowCount = 2
        Me.CitaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.CitaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CitaPanel.Size = New System.Drawing.Size(784, 571)
        Me.CitaPanel.TabIndex = 244
        Me.CitaPanel.Visible = False
        '
        'RefInterPanel
        '
        Me.RefInterPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefInterPanel.BackColor = System.Drawing.Color.Transparent
        Me.RefInterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RefInterPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.RefInterPanel.Controls.Add(Me.Label7)
        Me.RefInterPanel.Controls.Add(Me.LabPan1)
        Me.RefInterPanel.Controls.Add(Me.ExamenesGrid)
        Me.RefInterPanel.Location = New System.Drawing.Point(3, 18)
        Me.RefInterPanel.Name = "RefInterPanel"
        Me.RefInterPanel.Size = New System.Drawing.Size(444, 550)
        Me.RefInterPanel.TabIndex = 35
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.StatusC, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaPicker, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(434, 69)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'FechaPicker
        '
        Me.FechaPicker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaPicker.CalendarForeColor = System.Drawing.Color.Navy
        Me.FechaPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaPicker.Location = New System.Drawing.Point(93, 3)
        Me.FechaPicker.Name = "FechaPicker"
        Me.FechaPicker.Size = New System.Drawing.Size(338, 30)
        Me.FechaPicker.TabIndex = 101
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
        Me.AvisosGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvisosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AvisosGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
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
        Me.AvisosGrid.Location = New System.Drawing.Point(713, 18)
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
        Me.AvisosGrid.Size = New System.Drawing.Size(68, 477)
        Me.AvisosGrid.TabIndex = 31
        Me.AvisosGrid.Visible = False
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
        Me.Title.Text = "Nueva Cita al Laboratorio"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CitaLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.CitaPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CitaLaboratorio"
        Me.Text = "Cita Laboratorio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LabPan1.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.ExamenesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.CitaPanel.ResumeLayout(False)
        Me.CitaPanel.PerformLayout()
        Me.RefInterPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabPan1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NewExamButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NotesV As System.Windows.Forms.TextBox
    Friend WithEvents NotesL As System.Windows.Forms.Label
    Friend WithEvents TipoExamenL As System.Windows.Forms.Label
    Friend WithEvents ExamenesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents StatusC As System.Windows.Forms.ComboBox
    Friend WithEvents ExamenesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Examen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HasSubEx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvisosL As System.Windows.Forms.Label
    Friend WithEvents InfoCitaL As System.Windows.Forms.Label
    Friend WithEvents AgendaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AgendaCheck As System.Windows.Forms.LinkLabel
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents EdadV As System.Windows.Forms.Label
    Friend WithEvents CitaPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RefInterPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AvisosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
