<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaOtraInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaOtraInfo))
        Me.TotalL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.CamposPanel = New System.Windows.Forms.Panel()
        Me.buscarButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.InactivosCheck = New System.Windows.Forms.CheckBox()
        Me.AreaCombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TSL = New System.Windows.Forms.Label()
        Me.PuebloL = New System.Windows.Forms.Label()
        Me.AreaL = New System.Windows.Forms.Label()
        Me.TiposL = New System.Windows.Forms.Label()
        Me.familiaresDCheck = New System.Windows.Forms.CheckBox()
        Me.graduadosCheck = New System.Windows.Forms.CheckBox()
        Me.DesafiliadosCheck = New System.Windows.Forms.CheckBox()
        Me.ApadrinadosCheck = New System.Windows.Forms.CheckBox()
        Me.familiaresACheck = New System.Windows.Forms.CheckBox()
        Me.familiaresGCheck = New System.Windows.Forms.CheckBox()
        Me.NombresL = New System.Windows.Forms.Label()
        Me.NombresV = New System.Windows.Forms.TextBox()
        Me.ApellidosL = New System.Windows.Forms.Label()
        Me.ApellidosV = New System.Windows.Forms.TextBox()
        Me.nombreUL = New System.Windows.Forms.Label()
        Me.nombreUV = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.añoNacV = New System.Windows.Forms.TextBox()
        Me.diaNacV = New System.Windows.Forms.TextBox()
        Me.MesCombo = New System.Windows.Forms.ComboBox()
        Me.nacimientoL = New System.Windows.Forms.Label()
        Me.PuebloCombo = New System.Windows.Forms.ComboBox()
        Me.OtrosCheck = New System.Windows.Forms.CheckBox()
        Me.EducIncludTable = New System.Windows.Forms.TableLayoutPanel()
        Me.conInfoEducL = New System.Windows.Forms.RadioButton()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CamposPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.EducIncludTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Navy
        Me.TotalL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.ForeColor = System.Drawing.Color.White
        Me.TotalL.Location = New System.Drawing.Point(11, 125)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(46, 17)
        Me.TotalL.TabIndex = 236
        Me.TotalL.Text = "Total: "
        Me.TotalL.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 249
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
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
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
        Me.inicioButton.Location = New System.Drawing.Point(585, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 45)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(636, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(49, 44)
        Me.NuevoButton.TabIndex = 236
        Me.NuevoButton.UseVisualStyleBackColor = False
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
        Me.Title.Text = "Busqueda por Otra Información"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListadoGrid
        '
        Me.ListadoGrid.AllowUserToAddRows = False
        Me.ListadoGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(8, 145)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        Me.ListadoGrid.RowHeadersWidth = 60
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(764, 585)
        Me.ListadoGrid.TabIndex = 250
        Me.ListadoGrid.Visible = False
        '
        'CamposPanel
        '
        Me.CamposPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CamposPanel.BackColor = System.Drawing.Color.Transparent
        Me.CamposPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CamposPanel.Controls.Add(Me.buscarButton)
        Me.CamposPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.CamposPanel.Location = New System.Drawing.Point(28, 146)
        Me.CamposPanel.Name = "CamposPanel"
        Me.CamposPanel.Size = New System.Drawing.Size(728, 450)
        Me.CamposPanel.TabIndex = 251
        '
        'buscarButton
        '
        Me.buscarButton.BackColor = System.Drawing.Color.White
        Me.buscarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.searchFam
        Me.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.buscarButton.Location = New System.Drawing.Point(18, 357)
        Me.buscarButton.Name = "buscarButton"
        Me.buscarButton.Size = New System.Drawing.Size(59, 48)
        Me.buscarButton.TabIndex = 7
        Me.buscarButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.InactivosCheck, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AreaCombo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TSL, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.PuebloL, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AreaL, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TiposL, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.familiaresDCheck, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.graduadosCheck, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DesafiliadosCheck, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ApadrinadosCheck, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.familiaresACheck, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.familiaresGCheck, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NombresL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NombresV, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ApellidosL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ApellidosV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nombreUL, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nombreUV, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nacimientoL, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PuebloCombo, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.OtrosCheck, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EducIncludTable, 3, 7)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(696, 338)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'InactivosCheck
        '
        Me.InactivosCheck.AutoSize = True
        Me.InactivosCheck.BackColor = System.Drawing.Color.Transparent
        Me.InactivosCheck.ForeColor = System.Drawing.Color.Purple
        Me.InactivosCheck.Location = New System.Drawing.Point(339, 145)
        Me.InactivosCheck.Name = "InactivosCheck"
        Me.InactivosCheck.Size = New System.Drawing.Size(77, 20)
        Me.InactivosCheck.TabIndex = 211
        Me.InactivosCheck.Text = "Inactivos"
        Me.InactivosCheck.UseVisualStyleBackColor = False
        '
        'AreaCombo
        '
        Me.AreaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AreaCombo.FormattingEnabled = True
        Me.AreaCombo.Location = New System.Drawing.Point(112, 115)
        Me.AreaCombo.Name = "AreaCombo"
        Me.AreaCombo.Size = New System.Drawing.Size(121, 24)
        Me.AreaCombo.TabIndex = 231
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(3, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 227
        Me.Label5.Text = "Género:"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 226
        Me.Label4.Text = "Estado TS:"
        Me.Label4.Visible = False
        '
        'TSL
        '
        Me.TSL.AutoSize = True
        Me.TSL.BackColor = System.Drawing.Color.Transparent
        Me.TSL.Location = New System.Drawing.Point(3, 172)
        Me.TSL.Name = "TSL"
        Me.TSL.Size = New System.Drawing.Size(28, 16)
        Me.TSL.TabIndex = 226
        Me.TSL.Text = "TS:"
        Me.TSL.Visible = False
        '
        'PuebloL
        '
        Me.PuebloL.AutoSize = True
        Me.PuebloL.BackColor = System.Drawing.Color.Transparent
        Me.PuebloL.Location = New System.Drawing.Point(3, 142)
        Me.PuebloL.Name = "PuebloL"
        Me.PuebloL.Size = New System.Drawing.Size(52, 16)
        Me.PuebloL.TabIndex = 226
        Me.PuebloL.Text = "Pueblo:"
        '
        'AreaL
        '
        Me.AreaL.AutoSize = True
        Me.AreaL.BackColor = System.Drawing.Color.Transparent
        Me.AreaL.Location = New System.Drawing.Point(3, 112)
        Me.AreaL.Name = "AreaL"
        Me.AreaL.Size = New System.Drawing.Size(39, 16)
        Me.AreaL.TabIndex = 226
        Me.AreaL.Text = "Area:"
        '
        'TiposL
        '
        Me.TiposL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiposL.AutoSize = True
        Me.TiposL.BackColor = System.Drawing.Color.Navy
        Me.TableLayoutPanel1.SetColumnSpan(Me.TiposL, 3)
        Me.TiposL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiposL.ForeColor = System.Drawing.Color.White
        Me.TiposL.Location = New System.Drawing.Point(339, 0)
        Me.TiposL.Name = "TiposL"
        Me.TiposL.Size = New System.Drawing.Size(354, 20)
        Me.TiposL.TabIndex = 223
        Me.TiposL.Text = "Tipo de Miembros"
        Me.TiposL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'familiaresDCheck
        '
        Me.familiaresDCheck.AutoSize = True
        Me.familiaresDCheck.BackColor = System.Drawing.Color.Transparent
        Me.familiaresDCheck.ForeColor = System.Drawing.Color.Purple
        Me.familiaresDCheck.Location = New System.Drawing.Point(457, 59)
        Me.familiaresDCheck.Name = "familiaresDCheck"
        Me.familiaresDCheck.Size = New System.Drawing.Size(206, 20)
        Me.familiaresDCheck.TabIndex = 209
        Me.familiaresDCheck.Text = "Pariente de Familia Desafiliada"
        Me.familiaresDCheck.UseVisualStyleBackColor = False
        '
        'graduadosCheck
        '
        Me.graduadosCheck.AutoSize = True
        Me.graduadosCheck.BackColor = System.Drawing.Color.Transparent
        Me.graduadosCheck.ForeColor = System.Drawing.Color.Purple
        Me.graduadosCheck.Location = New System.Drawing.Point(339, 87)
        Me.graduadosCheck.Name = "graduadosCheck"
        Me.graduadosCheck.Size = New System.Drawing.Size(83, 20)
        Me.graduadosCheck.TabIndex = 209
        Me.graduadosCheck.Text = "Graduado"
        Me.graduadosCheck.UseVisualStyleBackColor = False
        '
        'DesafiliadosCheck
        '
        Me.DesafiliadosCheck.AutoSize = True
        Me.DesafiliadosCheck.BackColor = System.Drawing.Color.Transparent
        Me.DesafiliadosCheck.ForeColor = System.Drawing.Color.Purple
        Me.DesafiliadosCheck.Location = New System.Drawing.Point(339, 59)
        Me.DesafiliadosCheck.Name = "DesafiliadosCheck"
        Me.DesafiliadosCheck.Size = New System.Drawing.Size(90, 20)
        Me.DesafiliadosCheck.TabIndex = 208
        Me.DesafiliadosCheck.Text = "Desafiliado"
        Me.DesafiliadosCheck.UseVisualStyleBackColor = False
        '
        'ApadrinadosCheck
        '
        Me.ApadrinadosCheck.AutoSize = True
        Me.ApadrinadosCheck.BackColor = System.Drawing.Color.Transparent
        Me.ApadrinadosCheck.Checked = True
        Me.ApadrinadosCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ApadrinadosCheck.ForeColor = System.Drawing.Color.Navy
        Me.ApadrinadosCheck.Location = New System.Drawing.Point(339, 31)
        Me.ApadrinadosCheck.Name = "ApadrinadosCheck"
        Me.ApadrinadosCheck.Size = New System.Drawing.Size(92, 20)
        Me.ApadrinadosCheck.TabIndex = 207
        Me.ApadrinadosCheck.Text = "Apadrinado"
        Me.ApadrinadosCheck.UseVisualStyleBackColor = False
        '
        'familiaresACheck
        '
        Me.familiaresACheck.AutoSize = True
        Me.familiaresACheck.BackColor = System.Drawing.Color.Transparent
        Me.familiaresACheck.ForeColor = System.Drawing.Color.Navy
        Me.familiaresACheck.Location = New System.Drawing.Point(457, 31)
        Me.familiaresACheck.Name = "familiaresACheck"
        Me.familiaresACheck.Size = New System.Drawing.Size(69, 20)
        Me.familiaresACheck.TabIndex = 208
        Me.familiaresACheck.Text = "Afiliado"
        Me.familiaresACheck.UseVisualStyleBackColor = False
        '
        'familiaresGCheck
        '
        Me.familiaresGCheck.AutoSize = True
        Me.familiaresGCheck.BackColor = System.Drawing.Color.Transparent
        Me.familiaresGCheck.ForeColor = System.Drawing.Color.Purple
        Me.familiaresGCheck.Location = New System.Drawing.Point(457, 87)
        Me.familiaresGCheck.Name = "familiaresGCheck"
        Me.familiaresGCheck.Size = New System.Drawing.Size(199, 20)
        Me.familiaresGCheck.TabIndex = 210
        Me.familiaresGCheck.Text = "Pariente de Familia Graduada"
        Me.familiaresGCheck.UseVisualStyleBackColor = False
        '
        'NombresL
        '
        Me.NombresL.AutoSize = True
        Me.NombresL.BackColor = System.Drawing.Color.Transparent
        Me.NombresL.Location = New System.Drawing.Point(3, 0)
        Me.NombresL.Name = "NombresL"
        Me.NombresL.Size = New System.Drawing.Size(73, 16)
        Me.NombresL.TabIndex = 222
        Me.NombresL.Text = "Nombres: *"
        '
        'NombresV
        '
        Me.NombresV.Location = New System.Drawing.Point(112, 3)
        Me.NombresV.Name = "NombresV"
        Me.NombresV.Size = New System.Drawing.Size(159, 22)
        Me.NombresV.TabIndex = 219
        '
        'ApellidosL
        '
        Me.ApellidosL.AutoSize = True
        Me.ApellidosL.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosL.Location = New System.Drawing.Point(3, 28)
        Me.ApellidosL.Name = "ApellidosL"
        Me.ApellidosL.Size = New System.Drawing.Size(74, 16)
        Me.ApellidosL.TabIndex = 223
        Me.ApellidosL.Text = "Apellidos: *"
        '
        'ApellidosV
        '
        Me.ApellidosV.Location = New System.Drawing.Point(112, 31)
        Me.ApellidosV.Name = "ApellidosV"
        Me.ApellidosV.Size = New System.Drawing.Size(159, 22)
        Me.ApellidosV.TabIndex = 220
        '
        'nombreUL
        '
        Me.nombreUL.AutoSize = True
        Me.nombreUL.BackColor = System.Drawing.Color.Transparent
        Me.nombreUL.Location = New System.Drawing.Point(3, 56)
        Me.nombreUL.Name = "nombreUL"
        Me.nombreUL.Size = New System.Drawing.Size(103, 16)
        Me.nombreUL.TabIndex = 224
        Me.nombreUL.Text = "Nombre Usual: *"
        '
        'nombreUV
        '
        Me.nombreUV.Location = New System.Drawing.Point(112, 59)
        Me.nombreUV.Name = "nombreUV"
        Me.nombreUV.Size = New System.Drawing.Size(159, 22)
        Me.nombreUV.TabIndex = 221
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.añoNacV, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.diaNacV, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MesCombo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(112, 87)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(159, 22)
        Me.TableLayoutPanel2.TabIndex = 227
        '
        'añoNacV
        '
        Me.añoNacV.Location = New System.Drawing.Point(102, 3)
        Me.añoNacV.Name = "añoNacV"
        Me.añoNacV.Size = New System.Drawing.Size(54, 22)
        Me.añoNacV.TabIndex = 221
        Me.añoNacV.Visible = False
        '
        'diaNacV
        '
        Me.diaNacV.Location = New System.Drawing.Point(3, 3)
        Me.diaNacV.Name = "diaNacV"
        Me.diaNacV.Size = New System.Drawing.Size(34, 22)
        Me.diaNacV.TabIndex = 220
        Me.diaNacV.Visible = False
        '
        'MesCombo
        '
        Me.MesCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MesCombo.FormattingEnabled = True
        Me.MesCombo.Items.AddRange(New Object() {"", "1" & Global.Microsoft.VisualBasic.ChrW(9) & "Ene", "2" & Global.Microsoft.VisualBasic.ChrW(9) & "Feb", "3" & Global.Microsoft.VisualBasic.ChrW(9) & "Mar", "4" & Global.Microsoft.VisualBasic.ChrW(9) & "Abr", "5" & Global.Microsoft.VisualBasic.ChrW(9) & "May", "6" & Global.Microsoft.VisualBasic.ChrW(9) & "Jun", "7" & Global.Microsoft.VisualBasic.ChrW(9) & "Jul", "8" & Global.Microsoft.VisualBasic.ChrW(9) & "Ago", "9" & Global.Microsoft.VisualBasic.ChrW(9) & "Sep", "10" & Global.Microsoft.VisualBasic.ChrW(9) & "Oct", "11" & Global.Microsoft.VisualBasic.ChrW(9) & "Nov", "12" & Global.Microsoft.VisualBasic.ChrW(9) & "Dic"})
        Me.MesCombo.Location = New System.Drawing.Point(43, 3)
        Me.MesCombo.Name = "MesCombo"
        Me.MesCombo.Size = New System.Drawing.Size(53, 24)
        Me.MesCombo.TabIndex = 222
        Me.MesCombo.Visible = False
        '
        'nacimientoL
        '
        Me.nacimientoL.AutoSize = True
        Me.nacimientoL.BackColor = System.Drawing.Color.Transparent
        Me.nacimientoL.Location = New System.Drawing.Point(3, 84)
        Me.nacimientoL.Name = "nacimientoL"
        Me.nacimientoL.Size = New System.Drawing.Size(77, 16)
        Me.nacimientoL.TabIndex = 225
        Me.nacimientoL.Text = "Nacimiento:"
        Me.nacimientoL.Visible = False
        '
        'PuebloCombo
        '
        Me.PuebloCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PuebloCombo.FormattingEnabled = True
        Me.PuebloCombo.Location = New System.Drawing.Point(112, 145)
        Me.PuebloCombo.Name = "PuebloCombo"
        Me.PuebloCombo.Size = New System.Drawing.Size(121, 24)
        Me.PuebloCombo.TabIndex = 230
        '
        'OtrosCheck
        '
        Me.OtrosCheck.AutoSize = True
        Me.OtrosCheck.BackColor = System.Drawing.Color.Transparent
        Me.OtrosCheck.ForeColor = System.Drawing.Color.Purple
        Me.OtrosCheck.Location = New System.Drawing.Point(339, 115)
        Me.OtrosCheck.Name = "OtrosCheck"
        Me.OtrosCheck.Size = New System.Drawing.Size(59, 20)
        Me.OtrosCheck.TabIndex = 209
        Me.OtrosCheck.Text = "Otros"
        Me.OtrosCheck.UseVisualStyleBackColor = False
        '
        'EducIncludTable
        '
        Me.EducIncludTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EducIncludTable.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.EducIncludTable, 3)
        Me.EducIncludTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.EducIncludTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.EducIncludTable.Controls.Add(Me.conInfoEducL, 0, 0)
        Me.EducIncludTable.Controls.Add(Me.AñoV, 1, 0)
        Me.EducIncludTable.Location = New System.Drawing.Point(339, 191)
        Me.EducIncludTable.Name = "EducIncludTable"
        Me.EducIncludTable.RowCount = 1
        Me.EducIncludTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.EducIncludTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.EducIncludTable.Size = New System.Drawing.Size(354, 33)
        Me.EducIncludTable.TabIndex = 232
        '
        'conInfoEducL
        '
        Me.conInfoEducL.AutoSize = True
        Me.conInfoEducL.Location = New System.Drawing.Point(3, 3)
        Me.conInfoEducL.Name = "conInfoEducL"
        Me.conInfoEducL.Size = New System.Drawing.Size(166, 20)
        Me.conInfoEducL.TabIndex = 229
        Me.conInfoEducL.TabStop = True
        Me.conInfoEducL.Text = "Incluir Info. Año Escolar "
        Me.conInfoEducL.UseVisualStyleBackColor = True
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(175, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(54, 22)
        Me.AñoV.TabIndex = 222
        '
        'BusquedaOtraInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 742)
        Me.Controls.Add(Me.CamposPanel)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TotalL)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BusquedaOtraInfo"
        Me.Text = "Busqueda Otra Info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CamposPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.EducIncludTable.ResumeLayout(False)
        Me.EducIncludTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CamposPanel As System.Windows.Forms.Panel
    Friend WithEvents buscarButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InactivosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents AreaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TSL As System.Windows.Forms.Label
    Friend WithEvents PuebloL As System.Windows.Forms.Label
    Friend WithEvents AreaL As System.Windows.Forms.Label
    Friend WithEvents TiposL As System.Windows.Forms.Label
    Friend WithEvents familiaresDCheck As System.Windows.Forms.CheckBox
    Friend WithEvents graduadosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents DesafiliadosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ApadrinadosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents familiaresACheck As System.Windows.Forms.CheckBox
    Friend WithEvents familiaresGCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NombresL As System.Windows.Forms.Label
    Friend WithEvents NombresV As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosL As System.Windows.Forms.Label
    Friend WithEvents ApellidosV As System.Windows.Forms.TextBox
    Friend WithEvents nombreUL As System.Windows.Forms.Label
    Friend WithEvents nombreUV As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents añoNacV As System.Windows.Forms.TextBox
    Friend WithEvents diaNacV As System.Windows.Forms.TextBox
    Friend WithEvents MesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nacimientoL As System.Windows.Forms.Label
    Friend WithEvents PuebloCombo As System.Windows.Forms.ComboBox
    Friend WithEvents OtrosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents EducIncludTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents conInfoEducL As System.Windows.Forms.RadioButton
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
End Class
