<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialMedicinasMiembroFarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistorialMedicinasMiembroFarm))
        Me.NombreL = New System.Windows.Forms.Label()
        Me.CantidadOL = New System.Windows.Forms.Label()
        Me.IdTransL = New System.Windows.Forms.Label()
        Me.idTransV = New System.Windows.Forms.Label()
        Me.MedicinaL = New System.Windows.Forms.Label()
        Me.CantidadL = New System.Windows.Forms.Label()
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.CantidadV = New System.Windows.Forms.TextBox()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.MedicinaV = New System.Windows.Forms.TextBox()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.PacienteV = New System.Windows.Forms.TextBox()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.GenInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.MedsGrid = New System.Windows.Forms.DataGridView()
        Me.MedsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MedicinaModTabla = New System.Windows.Forms.TableLayoutPanel()
        Me.AlCreditoCheckBox = New System.Windows.Forms.CheckBox()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.PrincipalPanel.SuspendLayout()
        Me.GenInfoTable.SuspendLayout()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MedsTable.SuspendLayout()
        Me.MedicinaModTabla.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreL
        '
        Me.NombreL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreL.AutoSize = True
        Me.NombreL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(57, 36)
        Me.NombreL.TabIndex = 0
        Me.NombreL.Text = "Nombre:"
        Me.NombreL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CantidadOL
        '
        Me.CantidadOL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadOL.Location = New System.Drawing.Point(99, 78)
        Me.CantidadOL.Name = "CantidadOL"
        Me.CantidadOL.Size = New System.Drawing.Size(318, 30)
        Me.CantidadOL.TabIndex = 198
        Me.CantidadOL.Text = "Solo puede puede cambiar la cantidad a  0."
        '
        'IdTransL
        '
        Me.IdTransL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IdTransL.AutoSize = True
        Me.IdTransL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTransL.Location = New System.Drawing.Point(3, 108)
        Me.IdTransL.Name = "IdTransL"
        Me.IdTransL.Size = New System.Drawing.Size(50, 16)
        Me.IdTransL.TabIndex = 210
        Me.IdTransL.Text = "IdTrans"
        Me.IdTransL.Visible = False
        '
        'idTransV
        '
        Me.idTransV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idTransV.AutoSize = True
        Me.idTransV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTransV.Location = New System.Drawing.Point(99, 108)
        Me.idTransV.Name = "idTransV"
        Me.idTransV.Size = New System.Drawing.Size(331, 16)
        Me.idTransV.TabIndex = 209
        Me.idTransV.Text = "#Paciente"
        Me.idTransV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.idTransV.Visible = False
        '
        'MedicinaL
        '
        Me.MedicinaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedicinaL.AutoSize = True
        Me.MedicinaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicinaL.Location = New System.Drawing.Point(3, 0)
        Me.MedicinaL.Name = "MedicinaL"
        Me.MedicinaL.Size = New System.Drawing.Size(90, 50)
        Me.MedicinaL.TabIndex = 205
        Me.MedicinaL.Text = "Medicamento:"
        Me.MedicinaL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CantidadL
        '
        Me.CantidadL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CantidadL.AutoSize = True
        Me.CantidadL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadL.Location = New System.Drawing.Point(3, 50)
        Me.CantidadL.Name = "CantidadL"
        Me.CantidadL.Size = New System.Drawing.Size(90, 28)
        Me.CantidadL.TabIndex = 206
        Me.CantidadL.Text = "Cantidad:"
        Me.CantidadL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActualizarButton
        '
        Me.ActualizarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualizarButton.BackColor = System.Drawing.Color.Chocolate
        Me.ActualizarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarButton.ForeColor = System.Drawing.Color.White
        Me.ActualizarButton.Location = New System.Drawing.Point(99, 153)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.ActualizarButton.Size = New System.Drawing.Size(331, 30)
        Me.ActualizarButton.TabIndex = 211
        Me.ActualizarButton.Text = "Guardar Cambios"
        Me.ActualizarButton.UseVisualStyleBackColor = False
        '
        'CantidadV
        '
        Me.CantidadV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CantidadV.Location = New System.Drawing.Point(99, 53)
        Me.CantidadV.MaxLength = 10
        Me.CantidadV.Name = "CantidadV"
        Me.CantidadV.Size = New System.Drawing.Size(33, 22)
        Me.CantidadV.TabIndex = 205
        Me.CantidadV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.BackColor = System.Drawing.Color.Tan
        Me.CancelarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarButton.ForeColor = System.Drawing.Color.Black
        Me.CancelarButton.Location = New System.Drawing.Point(99, 190)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(331, 30)
        Me.CancelarButton.TabIndex = 212
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = False
        '
        'MedicinaV
        '
        Me.MedicinaV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedicinaV.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MedicinaV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MedicinaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicinaV.Location = New System.Drawing.Point(99, 3)
        Me.MedicinaV.Multiline = True
        Me.MedicinaV.Name = "MedicinaV"
        Me.MedicinaV.ReadOnly = True
        Me.MedicinaV.Size = New System.Drawing.Size(331, 44)
        Me.MedicinaV.TabIndex = 213
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
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaV, 1, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 120)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 36)
        Me.PrincipalPanel.TabIndex = 221
        '
        'FamiliaL
        '
        Me.FamiliaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 0)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(92, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(559, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(102, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Paciente:"
        Me.PacienteL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PacienteV
        '
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PacienteV.Location = New System.Drawing.Point(667, 3)
        Me.PacienteV.MaxLength = 10
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(112, 26)
        Me.PacienteV.TabIndex = 204
        Me.PacienteV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(101, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 26)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GenInfoTable.Controls.Add(Me.NombreL, 0, 0)
        Me.GenInfoTable.Controls.Add(Me.NombreV, 1, 0)
        Me.GenInfoTable.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenInfoTable.Location = New System.Drawing.Point(0, 156)
        Me.GenInfoTable.Name = "GenInfoTable"
        Me.GenInfoTable.RowCount = 1
        Me.GenInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.GenInfoTable.Size = New System.Drawing.Size(784, 36)
        Me.GenInfoTable.TabIndex = 222
        Me.GenInfoTable.Visible = False
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreV.AutoSize = True
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.Location = New System.Drawing.Point(66, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(15, 36)
        Me.NombreV.TabIndex = 207
        Me.NombreV.Text = "_"
        Me.NombreV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MedsGrid
        '
        Me.MedsGrid.AllowUserToAddRows = False
        Me.MedsGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown
        Me.MedsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MedsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MedsGrid.BackgroundColor = System.Drawing.Color.White
        Me.MedsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MedsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedsGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.MedsGrid.GridColor = System.Drawing.Color.White
        Me.MedsGrid.Location = New System.Drawing.Point(3, 3)
        Me.MedsGrid.Name = "MedsGrid"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedsGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MedsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MedsGrid.Size = New System.Drawing.Size(319, 555)
        Me.MedsGrid.TabIndex = 224
        Me.MedsGrid.Visible = False
        '
        'MedsTable
        '
        Me.MedsTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsTable.ColumnCount = 3
        Me.MedsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MedsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MedsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedsTable.Controls.Add(Me.MedsGrid, 0, 0)
        Me.MedsTable.Controls.Add(Me.MedicinaModTabla, 2, 0)
        Me.MedsTable.Location = New System.Drawing.Point(3, 198)
        Me.MedsTable.Name = "MedsTable"
        Me.MedsTable.RowCount = 1
        Me.MedsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MedsTable.Size = New System.Drawing.Size(784, 561)
        Me.MedsTable.TabIndex = 223
        Me.MedsTable.Visible = False
        '
        'MedicinaModTabla
        '
        Me.MedicinaModTabla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedicinaModTabla.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MedicinaModTabla.ColumnCount = 2
        Me.MedicinaModTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaModTabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.MedicinaModTabla.Controls.Add(Me.CantidadOL, 1, 2)
        Me.MedicinaModTabla.Controls.Add(Me.IdTransL, 0, 3)
        Me.MedicinaModTabla.Controls.Add(Me.idTransV, 0, 3)
        Me.MedicinaModTabla.Controls.Add(Me.MedicinaL, 0, 0)
        Me.MedicinaModTabla.Controls.Add(Me.CantidadL, 0, 1)
        Me.MedicinaModTabla.Controls.Add(Me.ActualizarButton, 1, 6)
        Me.MedicinaModTabla.Controls.Add(Me.CantidadV, 1, 1)
        Me.MedicinaModTabla.Controls.Add(Me.CancelarButton, 1, 7)
        Me.MedicinaModTabla.Controls.Add(Me.MedicinaV, 1, 0)
        Me.MedicinaModTabla.Controls.Add(Me.AlCreditoCheckBox, 1, 5)
        Me.MedicinaModTabla.Location = New System.Drawing.Point(348, 3)
        Me.MedicinaModTabla.Name = "MedicinaModTabla"
        Me.MedicinaModTabla.RowCount = 8
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MedicinaModTabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MedicinaModTabla.Size = New System.Drawing.Size(433, 224)
        Me.MedicinaModTabla.TabIndex = 225
        Me.MedicinaModTabla.Visible = False
        '
        'AlCreditoCheckBox
        '
        Me.AlCreditoCheckBox.AutoSize = True
        Me.AlCreditoCheckBox.Location = New System.Drawing.Point(99, 127)
        Me.AlCreditoCheckBox.Name = "AlCreditoCheckBox"
        Me.AlCreditoCheckBox.Size = New System.Drawing.Size(136, 20)
        Me.AlCreditoCheckBox.TabIndex = 214
        Me.AlCreditoCheckBox.Text = "Medicina al crédito"
        Me.AlCreditoCheckBox.UseVisualStyleBackColor = True
        Me.AlCreditoCheckBox.Visible = False
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
        Me.opcionesTable.ColumnCount = 3
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
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
        Me.NuevoButton.Location = New System.Drawing.Point(636, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(585, 3)
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
        Me.Title.Size = New System.Drawing.Size(574, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Historial de Medicamentos"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistorialMedicinasMiembroFarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.MedsTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.GenInfoTable)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "HistorialMedicinasMiembroFarm"
        Me.Text = "Historial Medicinas Miembro - Farmacia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.GenInfoTable.ResumeLayout(False)
        Me.GenInfoTable.PerformLayout()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MedsTable.ResumeLayout(False)
        Me.MedicinaModTabla.ResumeLayout(False)
        Me.MedicinaModTabla.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents CantidadOL As System.Windows.Forms.Label
    Friend WithEvents IdTransL As System.Windows.Forms.Label
    Friend WithEvents idTransV As System.Windows.Forms.Label
    Friend WithEvents MedicinaL As System.Windows.Forms.Label
    Friend WithEvents CantidadL As System.Windows.Forms.Label
    Friend WithEvents ActualizarButton As System.Windows.Forms.Button
    Friend WithEvents CantidadV As System.Windows.Forms.TextBox
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents MedicinaV As System.Windows.Forms.TextBox
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents PacienteV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents GenInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents MedsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MedsTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MedicinaModTabla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents AlCreditoCheckBox As System.Windows.Forms.CheckBox
End Class
