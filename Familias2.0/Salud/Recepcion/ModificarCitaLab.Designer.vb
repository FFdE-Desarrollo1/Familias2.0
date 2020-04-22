<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCitaLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarCitaLab))
        Me.AvisosL = New System.Windows.Forms.Label()
        Me.InfoCitaL = New System.Windows.Forms.Label()
        Me.AgendaGrid = New System.Windows.Forms.DataGridView()
        Me.AgendaCheck = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusC = New System.Windows.Forms.ComboBox()
        Me.DoctorC = New System.Windows.Forms.ComboBox()
        Me.DateP = New System.Windows.Forms.DateTimePicker()
        Me.DateL = New System.Windows.Forms.Label()
        Me.DoctorL = New System.Windows.Forms.Label()
        Me.AvisosGrid = New System.Windows.Forms.DataGridView()
        Me.NotesV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotesL = New System.Windows.Forms.Label()
        Me.ExamenesCombo = New System.Windows.Forms.ComboBox()
        Me.TipoExamenL = New System.Windows.Forms.Label()
        Me.ExamenesGrid = New System.Windows.Forms.DataGridView()
        Me.BorrarCitaLabButton = New System.Windows.Forms.Button()
        Me.LimpiarLabsButton = New System.Windows.Forms.Button()
        Me.BorrarLabButton = New System.Windows.Forms.Button()
        Me.NuevoLabButton = New System.Windows.Forms.Button()
        Me.IdCitaLabL = New System.Windows.Forms.Label()
        Me.IdLabL = New System.Windows.Forms.Label()
        Me.ResultadoLabL = New System.Windows.Forms.Label()
        Me.RefInterPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelSecundario = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.EdadV = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.PacienteV = New System.Windows.Forms.TextBox()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.ExamenesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RefInterPanel.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.PanelSecundario.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'AvisosL
        '
        Me.AvisosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AvisosL.AutoSize = True
        Me.AvisosL.BackColor = System.Drawing.Color.Chocolate
        Me.AvisosL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvisosL.ForeColor = System.Drawing.Color.White
        Me.AvisosL.Location = New System.Drawing.Point(655, 0)
        Me.AvisosL.Name = "AvisosL"
        Me.AvisosL.Size = New System.Drawing.Size(126, 36)
        Me.AvisosL.TabIndex = 33
        Me.AvisosL.Text = "Avisos"
        Me.AvisosL.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'InfoCitaL
        '
        Me.InfoCitaL.AutoSize = True
        Me.InfoCitaL.BackColor = System.Drawing.Color.Silver
        Me.InfoCitaL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoCitaL.ForeColor = System.Drawing.Color.SteelBlue
        Me.InfoCitaL.Location = New System.Drawing.Point(3, 0)
        Me.InfoCitaL.Name = "InfoCitaL"
        Me.InfoCitaL.Size = New System.Drawing.Size(161, 18)
        Me.InfoCitaL.TabIndex = 33
        Me.InfoCitaL.Text = "Información de la Cita"
        '
        'AgendaGrid
        '
        Me.AgendaGrid.AllowUserToAddRows = False
        Me.AgendaGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AgendaGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgendaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AgendaGrid.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.AgendaGrid.Location = New System.Drawing.Point(438, 39)
        Me.AgendaGrid.Name = "AgendaGrid"
        Me.AgendaGrid.ReadOnly = True
        Me.AgendaGrid.RowHeadersWidth = 55
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.AgendaGrid.Size = New System.Drawing.Size(191, 426)
        Me.AgendaGrid.TabIndex = 1
        Me.AgendaGrid.Tag = ""
        '
        'AgendaCheck
        '
        Me.AgendaCheck.AutoSize = True
        Me.AgendaCheck.BackColor = System.Drawing.Color.SkyBlue
        Me.AgendaCheck.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaCheck.Location = New System.Drawing.Point(438, 0)
        Me.AgendaCheck.Name = "AgendaCheck"
        Me.AgendaCheck.Size = New System.Drawing.Size(123, 36)
        Me.AgendaCheck.TabIndex = 34
        Me.AgendaCheck.TabStop = True
        Me.AgendaCheck.Text = "Revisar Agenda Laboratorio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "*Estado:"
        '
        'StatusC
        '
        Me.StatusC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusC.BackColor = System.Drawing.SystemColors.Window
        Me.StatusC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusC.ForeColor = System.Drawing.Color.DodgerBlue
        Me.StatusC.FormattingEnabled = True
        Me.StatusC.Location = New System.Drawing.Point(67, 61)
        Me.StatusC.Name = "StatusC"
        Me.StatusC.Size = New System.Drawing.Size(309, 24)
        Me.StatusC.TabIndex = 57
        '
        'DoctorC
        '
        Me.DoctorC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DoctorC.Enabled = False
        Me.DoctorC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorC.FormattingEnabled = True
        Me.DoctorC.Location = New System.Drawing.Point(67, 31)
        Me.DoctorC.Name = "DoctorC"
        Me.DoctorC.Size = New System.Drawing.Size(309, 24)
        Me.DoctorC.TabIndex = 57
        '
        'DateP
        '
        Me.DateP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateP.Location = New System.Drawing.Point(67, 3)
        Me.DateP.Name = "DateP"
        Me.DateP.Size = New System.Drawing.Size(309, 22)
        Me.DateP.TabIndex = 47
        '
        'DateL
        '
        Me.DateL.AutoSize = True
        Me.DateL.BackColor = System.Drawing.Color.Transparent
        Me.DateL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateL.Location = New System.Drawing.Point(3, 0)
        Me.DateL.Name = "DateL"
        Me.DateL.Size = New System.Drawing.Size(53, 16)
        Me.DateL.TabIndex = 48
        Me.DateL.Text = "*Fecha:"
        '
        'DoctorL
        '
        Me.DoctorL.AutoSize = True
        Me.DoctorL.BackColor = System.Drawing.Color.Transparent
        Me.DoctorL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorL.Location = New System.Drawing.Point(3, 28)
        Me.DoctorL.Name = "DoctorL"
        Me.DoctorL.Size = New System.Drawing.Size(53, 16)
        Me.DoctorL.TabIndex = 61
        Me.DoctorL.Text = "*Refirió:"
        '
        'AvisosGrid
        '
        Me.AvisosGrid.AllowUserToAddRows = False
        Me.AvisosGrid.AllowUserToDeleteRows = False
        Me.AvisosGrid.AllowUserToResizeColumns = False
        Me.AvisosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.AvisosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AvisosGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.AvisosGrid.GridColor = System.Drawing.Color.White
        Me.AvisosGrid.Location = New System.Drawing.Point(655, 39)
        Me.AvisosGrid.MultiSelect = False
        Me.AvisosGrid.Name = "AvisosGrid"
        Me.AvisosGrid.ReadOnly = True
        Me.AvisosGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AvisosGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AvisosGrid.RowHeadersVisible = False
        Me.AvisosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        Me.AvisosGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.AvisosGrid.RowTemplate.ReadOnly = True
        Me.AvisosGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AvisosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.AvisosGrid.ShowEditingIcon = False
        Me.AvisosGrid.Size = New System.Drawing.Size(126, 532)
        Me.AvisosGrid.TabIndex = 31
        Me.AvisosGrid.Visible = False
        '
        'NotesV
        '
        Me.NotesV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesV.Location = New System.Drawing.Point(123, 33)
        Me.NotesV.MaxLength = 300
        Me.NotesV.Name = "NotesV"
        Me.NotesV.Size = New System.Drawing.Size(102, 22)
        Me.NotesV.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(3, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(348, 22)
        Me.Label7.TabIndex = 416
        Me.Label7.Text = "Laboratorios"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 4
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.NotesV, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.NotesL, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.ExamenesCombo, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TipoExamenL, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.ExamenesGrid, 0, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.BorrarCitaLabButton, 3, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.LimpiarLabsButton, 0, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.BorrarLabButton, 1, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.NuevoLabButton, 3, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.IdCitaLabL, 0, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.IdLabL, 1, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.ResultadoLabL, 2, 3)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 30)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 5
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(363, 370)
        Me.TableLayoutPanel9.TabIndex = 13
        '
        'NotesL
        '
        Me.NotesL.AutoSize = True
        Me.NotesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesL.ForeColor = System.Drawing.Color.Navy
        Me.NotesL.Location = New System.Drawing.Point(3, 30)
        Me.NotesL.Name = "NotesL"
        Me.NotesL.Size = New System.Drawing.Size(97, 16)
        Me.NotesL.TabIndex = 162
        Me.NotesL.Text = "Observaciones:"
        '
        'ExamenesCombo
        '
        Me.ExamenesCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExamenesCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TableLayoutPanel9.SetColumnSpan(Me.ExamenesCombo, 3)
        Me.ExamenesCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamenesCombo.FormattingEnabled = True
        Me.ExamenesCombo.Location = New System.Drawing.Point(123, 3)
        Me.ExamenesCombo.Name = "ExamenesCombo"
        Me.ExamenesCombo.Size = New System.Drawing.Size(237, 24)
        Me.ExamenesCombo.TabIndex = 102
        '
        'TipoExamenL
        '
        Me.TipoExamenL.AutoSize = True
        Me.TipoExamenL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoExamenL.ForeColor = System.Drawing.Color.Navy
        Me.TipoExamenL.Location = New System.Drawing.Point(3, 0)
        Me.TipoExamenL.Name = "TipoExamenL"
        Me.TipoExamenL.Size = New System.Drawing.Size(65, 16)
        Me.TipoExamenL.TabIndex = 161
        Me.TipoExamenL.Text = "*Examen:"
        '
        'ExamenesGrid
        '
        Me.ExamenesGrid.AllowUserToAddRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Purple
        Me.ExamenesGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.ExamenesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExamenesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ExamenesGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.ExamenesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel9.SetColumnSpan(Me.ExamenesGrid, 4)
        Me.ExamenesGrid.Location = New System.Drawing.Point(3, 106)
        Me.ExamenesGrid.Name = "ExamenesGrid"
        Me.ExamenesGrid.ReadOnly = True
        Me.ExamenesGrid.RowHeadersWidth = 20
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamenesGrid.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.ExamenesGrid.Size = New System.Drawing.Size(357, 261)
        Me.ExamenesGrid.TabIndex = 11
        '
        'BorrarCitaLabButton
        '
        Me.BorrarCitaLabButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrarCitaLabButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrarCitaLabButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarCitaLabButton.ForeColor = System.Drawing.Color.White
        Me.BorrarCitaLabButton.Location = New System.Drawing.Point(246, 64)
        Me.BorrarCitaLabButton.Name = "BorrarCitaLabButton"
        Me.BorrarCitaLabButton.Size = New System.Drawing.Size(114, 26)
        Me.BorrarCitaLabButton.TabIndex = 204
        Me.BorrarCitaLabButton.Text = "Borrar Cita"
        Me.BorrarCitaLabButton.UseVisualStyleBackColor = False
        '
        'LimpiarLabsButton
        '
        Me.LimpiarLabsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LimpiarLabsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LimpiarLabsButton.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimpiarLabsButton.ForeColor = System.Drawing.Color.Black
        Me.LimpiarLabsButton.Location = New System.Drawing.Point(3, 64)
        Me.LimpiarLabsButton.Name = "LimpiarLabsButton"
        Me.LimpiarLabsButton.Size = New System.Drawing.Size(114, 26)
        Me.LimpiarLabsButton.TabIndex = 202
        Me.LimpiarLabsButton.Text = "Limpiar campos"
        Me.LimpiarLabsButton.UseVisualStyleBackColor = False
        '
        'BorrarLabButton
        '
        Me.BorrarLabButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorrarLabButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BorrarLabButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarLabButton.ForeColor = System.Drawing.Color.Black
        Me.BorrarLabButton.Location = New System.Drawing.Point(123, 64)
        Me.BorrarLabButton.Name = "BorrarLabButton"
        Me.BorrarLabButton.Size = New System.Drawing.Size(102, 26)
        Me.BorrarLabButton.TabIndex = 203
        Me.BorrarLabButton.Text = "Borrar Lab."
        Me.BorrarLabButton.UseVisualStyleBackColor = False
        '
        'NuevoLabButton
        '
        Me.NuevoLabButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevoLabButton.BackColor = System.Drawing.Color.Chocolate
        Me.NuevoLabButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoLabButton.ForeColor = System.Drawing.Color.White
        Me.NuevoLabButton.Location = New System.Drawing.Point(246, 33)
        Me.NuevoLabButton.Name = "NuevoLabButton"
        Me.NuevoLabButton.Size = New System.Drawing.Size(114, 25)
        Me.NuevoLabButton.TabIndex = 104
        Me.NuevoLabButton.Text = "Guardar Lab."
        Me.NuevoLabButton.UseVisualStyleBackColor = False
        '
        'IdCitaLabL
        '
        Me.IdCitaLabL.AutoSize = True
        Me.IdCitaLabL.Location = New System.Drawing.Point(3, 93)
        Me.IdCitaLabL.Name = "IdCitaLabL"
        Me.IdCitaLabL.Size = New System.Drawing.Size(15, 10)
        Me.IdCitaLabL.TabIndex = 167
        Me.IdCitaLabL.Text = "0"
        Me.IdCitaLabL.Visible = False
        '
        'IdLabL
        '
        Me.IdLabL.AutoSize = True
        Me.IdLabL.Location = New System.Drawing.Point(123, 93)
        Me.IdLabL.Name = "IdLabL"
        Me.IdLabL.Size = New System.Drawing.Size(15, 10)
        Me.IdLabL.TabIndex = 201
        Me.IdLabL.Text = "0"
        Me.IdLabL.Visible = False
        '
        'ResultadoLabL
        '
        Me.ResultadoLabL.AutoSize = True
        Me.ResultadoLabL.Location = New System.Drawing.Point(231, 93)
        Me.ResultadoLabL.Name = "ResultadoLabL"
        Me.ResultadoLabL.Size = New System.Drawing.Size(9, 10)
        Me.ResultadoLabL.TabIndex = 201
        Me.ResultadoLabL.Text = "0"
        Me.ResultadoLabL.Visible = False
        '
        'RefInterPanel
        '
        Me.RefInterPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefInterPanel.BackColor = System.Drawing.Color.Transparent
        Me.RefInterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel4.SetColumnSpan(Me.RefInterPanel, 2)
        Me.RefInterPanel.Controls.Add(Me.Label7)
        Me.RefInterPanel.Controls.Add(Me.TableLayoutPanel9)
        Me.RefInterPanel.Location = New System.Drawing.Point(3, 121)
        Me.RefInterPanel.Name = "RefInterPanel"
        Me.RefInterPanel.Size = New System.Drawing.Size(373, 408)
        Me.RefInterPanel.TabIndex = 62
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.RefInterPanel, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.StatusC, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.DoctorC, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.DateP, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DateL, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DoctorL, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 39)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(379, 532)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'PanelSecundario
        '
        Me.PanelSecundario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSecundario.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelSecundario.ColumnCount = 5
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelSecundario.Controls.Add(Me.NombreL, 0, 0)
        Me.PanelSecundario.Controls.Add(Me.NombreV, 1, 0)
        Me.PanelSecundario.Controls.Add(Me.EdadV, 2, 0)
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 156)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.RowCount = 2
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.PanelSecundario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PanelSecundario.Size = New System.Drawing.Size(784, 25)
        Me.PanelSecundario.TabIndex = 243
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
        Me.NombreV.Location = New System.Drawing.Point(66, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(1, 16)
        Me.NombreV.TabIndex = 2
        '
        'EdadV
        '
        Me.EdadV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdadV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EdadV.Location = New System.Drawing.Point(72, 0)
        Me.EdadV.Name = "EdadV"
        Me.EdadV.Size = New System.Drawing.Size(709, 23)
        Me.EdadV.TabIndex = 198
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.ColumnCount = 5
        Me.Panel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385.0!))
        Me.Panel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.Panel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Panel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.Panel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.Panel3.Controls.Add(Me.AvisosL, 4, 0)
        Me.Panel3.Controls.Add(Me.InfoCitaL, 0, 0)
        Me.Panel3.Controls.Add(Me.AgendaGrid, 2, 1)
        Me.Panel3.Controls.Add(Me.AvisosGrid, 4, 1)
        Me.Panel3.Controls.Add(Me.AgendaCheck, 2, 0)
        Me.Panel3.Location = New System.Drawing.Point(0, 185)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.RowCount = 2
        Me.Panel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Panel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel3.Size = New System.Drawing.Size(784, 574)
        Me.Panel3.TabIndex = 244
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
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteV, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 3, 0)
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
        Me.FamiliaV.Location = New System.Drawing.Point(667, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.ReadOnly = True
        Me.FamiliaV.Size = New System.Drawing.Size(112, 29)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(3, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(123, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Paciente:"
        Me.PacienteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PacienteV
        '
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PacienteV.Location = New System.Drawing.Point(132, 3)
        Me.PacienteV.MaxLength = 10
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.ReadOnly = True
        Me.PacienteV.Size = New System.Drawing.Size(112, 29)
        Me.PacienteV.TabIndex = 204
        Me.PacienteV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(552, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(109, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Title.Text = "Modificar Cita de Laboratorio"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ModificarCitaLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ModificarCitaLab"
        Me.Text = "Modificar Cita Lab"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvisosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.ExamenesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RefInterPanel.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.PanelSecundario.ResumeLayout(False)
        Me.PanelSecundario.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AvisosL As System.Windows.Forms.Label
    Friend WithEvents InfoCitaL As System.Windows.Forms.Label
    Friend WithEvents AgendaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents AgendaCheck As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusC As System.Windows.Forms.ComboBox
    Friend WithEvents DoctorC As System.Windows.Forms.ComboBox
    Friend WithEvents DateP As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateL As System.Windows.Forms.Label
    Friend WithEvents DoctorL As System.Windows.Forms.Label
    Friend WithEvents AvisosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents NotesV As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NotesL As System.Windows.Forms.Label
    Friend WithEvents ExamenesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipoExamenL As System.Windows.Forms.Label
    Friend WithEvents ExamenesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents BorrarCitaLabButton As System.Windows.Forms.Button
    Friend WithEvents LimpiarLabsButton As System.Windows.Forms.Button
    Friend WithEvents BorrarLabButton As System.Windows.Forms.Button
    Friend WithEvents NuevoLabButton As System.Windows.Forms.Button
    Friend WithEvents IdCitaLabL As System.Windows.Forms.Label
    Friend WithEvents IdLabL As System.Windows.Forms.Label
    Friend WithEvents ResultadoLabL As System.Windows.Forms.Label
    Friend WithEvents RefInterPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelSecundario As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents EdadV As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents PacienteV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
