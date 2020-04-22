<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExonerarMedicina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExonerarMedicina))
        Me.ExonerarMedButton = New System.Windows.Forms.Button()
        Me.totalML = New System.Windows.Forms.Label()
        Me.MedicoML = New System.Windows.Forms.Label()
        Me.FechaML = New System.Windows.Forms.Label()
        Me.MedL = New System.Windows.Forms.Label()
        Me.IdTransacV = New System.Windows.Forms.Label()
        Me.TotalMedV = New System.Windows.Forms.Label()
        Me.DrMedV = New System.Windows.Forms.Label()
        Me.MedV = New System.Windows.Forms.Label()
        Me.actualizarMedTable = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaMedV = New System.Windows.Forms.Label()
        Me.MedsGrid = New System.Windows.Forms.DataGridView()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.UpdateTable = New System.Windows.Forms.TableLayoutPanel()
        Me.ExonerarButton = New System.Windows.Forms.Button()
        Me.TotalV = New System.Windows.Forms.Label()
        Me.IdConsultaV = New System.Windows.Forms.Label()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.DrV = New System.Windows.Forms.Label()
        Me.DrL = New System.Windows.Forms.Label()
        Me.FechaV = New System.Windows.Forms.Label()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.GenInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.InfoPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.PacienteV = New System.Windows.Forms.TextBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.actualizarMedTable.SuspendLayout()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateTable.SuspendLayout()
        Me.GenInfoTable.SuspendLayout()
        Me.InfoPanel.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExonerarMedButton
        '
        Me.ExonerarMedButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExonerarMedButton.BackColor = System.Drawing.Color.Chocolate
        Me.ExonerarMedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExonerarMedButton.ForeColor = System.Drawing.Color.White
        Me.ExonerarMedButton.Location = New System.Drawing.Point(91, 161)
        Me.ExonerarMedButton.Name = "ExonerarMedButton"
        Me.ExonerarMedButton.Size = New System.Drawing.Size(200, 44)
        Me.ExonerarMedButton.TabIndex = 197
        Me.ExonerarMedButton.Text = "Exonerar Medicina"
        Me.ExonerarMedButton.UseVisualStyleBackColor = False
        '
        'totalML
        '
        Me.totalML.AutoSize = True
        Me.totalML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalML.Location = New System.Drawing.Point(3, 106)
        Me.totalML.Name = "totalML"
        Me.totalML.Size = New System.Drawing.Size(82, 32)
        Me.totalML.TabIndex = 198
        Me.totalML.Text = "Total a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exonerar  Q:"
        '
        'MedicoML
        '
        Me.MedicoML.AutoSize = True
        Me.MedicoML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicoML.Location = New System.Drawing.Point(3, 78)
        Me.MedicoML.Name = "MedicoML"
        Me.MedicoML.Size = New System.Drawing.Size(54, 16)
        Me.MedicoML.TabIndex = 197
        Me.MedicoML.Text = "Médico:"
        '
        'FechaML
        '
        Me.FechaML.AutoSize = True
        Me.FechaML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaML.Location = New System.Drawing.Point(3, 50)
        Me.FechaML.Name = "FechaML"
        Me.FechaML.Size = New System.Drawing.Size(48, 16)
        Me.FechaML.TabIndex = 0
        Me.FechaML.Text = "Fecha:"
        '
        'MedL
        '
        Me.MedL.AutoSize = True
        Me.MedL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedL.Location = New System.Drawing.Point(3, 0)
        Me.MedL.Name = "MedL"
        Me.MedL.Size = New System.Drawing.Size(64, 16)
        Me.MedL.TabIndex = 245
        Me.MedL.Text = "Medicina:"
        '
        'IdTransacV
        '
        Me.IdTransacV.AutoSize = True
        Me.IdTransacV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTransacV.Location = New System.Drawing.Point(91, 138)
        Me.IdTransacV.Name = "IdTransacV"
        Me.IdTransacV.Size = New System.Drawing.Size(15, 16)
        Me.IdTransacV.TabIndex = 199
        Me.IdTransacV.Text = "_"
        Me.IdTransacV.Visible = False
        '
        'TotalMedV
        '
        Me.TotalMedV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalMedV.AutoSize = True
        Me.TotalMedV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalMedV.Location = New System.Drawing.Point(91, 106)
        Me.TotalMedV.Name = "TotalMedV"
        Me.TotalMedV.Size = New System.Drawing.Size(15, 32)
        Me.TotalMedV.TabIndex = 199
        Me.TotalMedV.Text = "_"
        Me.TotalMedV.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DrMedV
        '
        Me.DrMedV.AutoSize = True
        Me.DrMedV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrMedV.Location = New System.Drawing.Point(91, 78)
        Me.DrMedV.Name = "DrMedV"
        Me.DrMedV.Size = New System.Drawing.Size(15, 16)
        Me.DrMedV.TabIndex = 197
        Me.DrMedV.Text = "_"
        '
        'MedV
        '
        Me.MedV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedV.AutoSize = True
        Me.MedV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedV.Location = New System.Drawing.Point(91, 0)
        Me.MedV.Name = "MedV"
        Me.MedV.Size = New System.Drawing.Size(200, 50)
        Me.MedV.TabIndex = 245
        Me.MedV.Text = "_"
        '
        'actualizarMedTable
        '
        Me.actualizarMedTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actualizarMedTable.ColumnCount = 2
        Me.actualizarMedTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.actualizarMedTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.actualizarMedTable.Controls.Add(Me.ExonerarMedButton, 1, 5)
        Me.actualizarMedTable.Controls.Add(Me.totalML, 0, 3)
        Me.actualizarMedTable.Controls.Add(Me.MedicoML, 0, 2)
        Me.actualizarMedTable.Controls.Add(Me.FechaML, 0, 1)
        Me.actualizarMedTable.Controls.Add(Me.MedL, 0, 0)
        Me.actualizarMedTable.Controls.Add(Me.IdTransacV, 1, 4)
        Me.actualizarMedTable.Controls.Add(Me.TotalMedV, 1, 3)
        Me.actualizarMedTable.Controls.Add(Me.DrMedV, 1, 2)
        Me.actualizarMedTable.Controls.Add(Me.FechaMedV, 1, 1)
        Me.actualizarMedTable.Controls.Add(Me.MedV, 1, 0)
        Me.actualizarMedTable.Location = New System.Drawing.Point(487, 269)
        Me.actualizarMedTable.Name = "actualizarMedTable"
        Me.actualizarMedTable.RowCount = 7
        Me.actualizarMedTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.actualizarMedTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.actualizarMedTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.actualizarMedTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.actualizarMedTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.actualizarMedTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.actualizarMedTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.actualizarMedTable.Size = New System.Drawing.Size(294, 210)
        Me.actualizarMedTable.TabIndex = 226
        Me.actualizarMedTable.Visible = False
        '
        'FechaMedV
        '
        Me.FechaMedV.AutoSize = True
        Me.FechaMedV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaMedV.Location = New System.Drawing.Point(91, 50)
        Me.FechaMedV.Name = "FechaMedV"
        Me.FechaMedV.Size = New System.Drawing.Size(15, 16)
        Me.FechaMedV.TabIndex = 197
        Me.FechaMedV.Text = "_"
        '
        'MedsGrid
        '
        Me.MedsGrid.AllowUserToAddRows = False
        Me.MedsGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MedsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MedsGrid.BackgroundColor = System.Drawing.Color.White
        Me.MedsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MedsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedsGrid.Location = New System.Drawing.Point(3, 269)
        Me.MedsGrid.Name = "MedsGrid"
        Me.MedsGrid.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedsGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MedsGrid.Size = New System.Drawing.Size(438, 241)
        Me.MedsGrid.TabIndex = 225
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(3, 3)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListadoGrid.Size = New System.Drawing.Size(438, 240)
        Me.ListadoGrid.TabIndex = 223
        '
        'UpdateTable
        '
        Me.UpdateTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateTable.ColumnCount = 2
        Me.UpdateTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.UpdateTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.UpdateTable.Controls.Add(Me.ExonerarButton, 1, 4)
        Me.UpdateTable.Controls.Add(Me.TotalV, 1, 2)
        Me.UpdateTable.Controls.Add(Me.IdConsultaV, 1, 3)
        Me.UpdateTable.Controls.Add(Me.TotalL, 0, 2)
        Me.UpdateTable.Controls.Add(Me.DrV, 1, 1)
        Me.UpdateTable.Controls.Add(Me.DrL, 0, 1)
        Me.UpdateTable.Controls.Add(Me.FechaV, 1, 0)
        Me.UpdateTable.Controls.Add(Me.FechaL, 0, 0)
        Me.UpdateTable.Location = New System.Drawing.Point(487, 3)
        Me.UpdateTable.Name = "UpdateTable"
        Me.UpdateTable.RowCount = 6
        Me.UpdateTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.UpdateTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.UpdateTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.UpdateTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.UpdateTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.UpdateTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.UpdateTable.Size = New System.Drawing.Size(294, 176)
        Me.UpdateTable.TabIndex = 224
        Me.UpdateTable.Visible = False
        '
        'ExonerarButton
        '
        Me.ExonerarButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExonerarButton.BackColor = System.Drawing.Color.Chocolate
        Me.ExonerarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExonerarButton.ForeColor = System.Drawing.Color.White
        Me.ExonerarButton.Location = New System.Drawing.Point(91, 111)
        Me.ExonerarButton.Name = "ExonerarButton"
        Me.ExonerarButton.Size = New System.Drawing.Size(200, 44)
        Me.ExonerarButton.TabIndex = 197
        Me.ExonerarButton.Text = "Exonerar Consulta"
        Me.ExonerarButton.UseVisualStyleBackColor = False
        '
        'TotalV
        '
        Me.TotalV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalV.AutoSize = True
        Me.TotalV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalV.Location = New System.Drawing.Point(91, 56)
        Me.TotalV.Name = "TotalV"
        Me.TotalV.Size = New System.Drawing.Size(15, 32)
        Me.TotalV.TabIndex = 199
        Me.TotalV.Text = "_"
        Me.TotalV.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'IdConsultaV
        '
        Me.IdConsultaV.AutoSize = True
        Me.IdConsultaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdConsultaV.Location = New System.Drawing.Point(91, 88)
        Me.IdConsultaV.Name = "IdConsultaV"
        Me.IdConsultaV.Size = New System.Drawing.Size(15, 16)
        Me.IdConsultaV.TabIndex = 199
        Me.IdConsultaV.Text = "_"
        Me.IdConsultaV.Visible = False
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.Location = New System.Drawing.Point(3, 56)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(82, 32)
        Me.TotalL.TabIndex = 198
        Me.TotalL.Text = "Total a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exonerar  Q:"
        '
        'DrV
        '
        Me.DrV.AutoSize = True
        Me.DrV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrV.Location = New System.Drawing.Point(91, 28)
        Me.DrV.Name = "DrV"
        Me.DrV.Size = New System.Drawing.Size(15, 16)
        Me.DrV.TabIndex = 197
        Me.DrV.Text = "_"
        '
        'DrL
        '
        Me.DrL.AutoSize = True
        Me.DrL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrL.Location = New System.Drawing.Point(3, 28)
        Me.DrL.Name = "DrL"
        Me.DrL.Size = New System.Drawing.Size(54, 16)
        Me.DrL.TabIndex = 197
        Me.DrL.Text = "Médico:"
        '
        'FechaV
        '
        Me.FechaV.AutoSize = True
        Me.FechaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaV.Location = New System.Drawing.Point(91, 0)
        Me.FechaV.Name = "FechaV"
        Me.FechaV.Size = New System.Drawing.Size(15, 16)
        Me.FechaV.TabIndex = 197
        Me.FechaV.Text = "_"
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.Location = New System.Drawing.Point(3, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(48, 16)
        Me.FechaL.TabIndex = 0
        Me.FechaL.Text = "Fecha:"
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
        Me.GenInfoTable.Location = New System.Drawing.Point(0, 157)
        Me.GenInfoTable.Name = "GenInfoTable"
        Me.GenInfoTable.RowCount = 1
        Me.GenInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.GenInfoTable.Size = New System.Drawing.Size(784, 36)
        Me.GenInfoTable.TabIndex = 247
        Me.GenInfoTable.Visible = False
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
        'InfoPanel
        '
        Me.InfoPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPanel.BackColor = System.Drawing.Color.Transparent
        Me.InfoPanel.ColumnCount = 3
        Me.InfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.InfoPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.InfoPanel.Controls.Add(Me.MedsGrid, 0, 2)
        Me.InfoPanel.Controls.Add(Me.ListadoGrid, 0, 0)
        Me.InfoPanel.Controls.Add(Me.UpdateTable, 2, 0)
        Me.InfoPanel.Controls.Add(Me.actualizarMedTable, 2, 2)
        Me.InfoPanel.Location = New System.Drawing.Point(0, 199)
        Me.InfoPanel.Name = "InfoPanel"
        Me.InfoPanel.RowCount = 3
        Me.InfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InfoPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InfoPanel.Size = New System.Drawing.Size(784, 513)
        Me.InfoPanel.TabIndex = 248
        Me.InfoPanel.Visible = False
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
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 121)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 36)
        Me.PrincipalPanel.TabIndex = 246
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
        Me.Title.Text = "Exonerar Medicina"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExonerarMedicina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.GenInfoTable)
        Me.Controls.Add(Me.InfoPanel)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ExonerarMedicina"
        Me.Text = "Exonerar Medicina"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.actualizarMedTable.ResumeLayout(False)
        Me.actualizarMedTable.PerformLayout()
        CType(Me.MedsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateTable.ResumeLayout(False)
        Me.UpdateTable.PerformLayout()
        Me.GenInfoTable.ResumeLayout(False)
        Me.GenInfoTable.PerformLayout()
        Me.InfoPanel.ResumeLayout(False)
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExonerarMedButton As System.Windows.Forms.Button
    Friend WithEvents totalML As System.Windows.Forms.Label
    Friend WithEvents MedicoML As System.Windows.Forms.Label
    Friend WithEvents FechaML As System.Windows.Forms.Label
    Friend WithEvents MedL As System.Windows.Forms.Label
    Friend WithEvents IdTransacV As System.Windows.Forms.Label
    Friend WithEvents TotalMedV As System.Windows.Forms.Label
    Friend WithEvents DrMedV As System.Windows.Forms.Label
    Friend WithEvents MedV As System.Windows.Forms.Label
    Friend WithEvents actualizarMedTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaMedV As System.Windows.Forms.Label
    Friend WithEvents MedsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents UpdateTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ExonerarButton As System.Windows.Forms.Button
    Friend WithEvents TotalV As System.Windows.Forms.Label
    Friend WithEvents IdConsultaV As System.Windows.Forms.Label
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents DrV As System.Windows.Forms.Label
    Friend WithEvents DrL As System.Windows.Forms.Label
    Friend WithEvents FechaV As System.Windows.Forms.Label
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents GenInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents InfoPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
