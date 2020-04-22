<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPadrino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarPadrino))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.memberTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.miembroL = New System.Windows.Forms.Label()
        Me.SitioCombo = New System.Windows.Forms.ComboBox()
        Me.nombreMiembroL = New System.Windows.Forms.Label()
        Me.NombreMiembroV = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nombrePadrinoV = New System.Windows.Forms.Label()
        Me.TipoCombo = New System.Windows.Forms.ComboBox()
        Me.tipoL = New System.Windows.Forms.Label()
        Me.NivelCombo = New System.Windows.Forms.ComboBox()
        Me.nivelL = New System.Windows.Forms.Label()
        Me.nombresPadrinosL = New System.Windows.Forms.Label()
        Me.idPadrinoL = New System.Windows.Forms.Label()
        Me.IdPadrinoV = New System.Windows.Forms.TextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.PadrinosGrid = New System.Windows.Forms.DataGridView()
        Me.sponsorsL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.principalTable.SuspendLayout()
        Me.memberTable.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PadrinosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.White
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(984, 118)
        Me.bannerPanel.TabIndex = 261
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
        Me.Title.Size = New System.Drawing.Size(720, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Add Sponsor"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 6
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.principalTable.Controls.Add(Me.memberTable, 1, 0)
        Me.principalTable.Controls.Add(Me.TableLayoutPanel1, 3, 0)
        Me.principalTable.Controls.Add(Me.BuscarButton, 4, 0)
        Me.principalTable.Location = New System.Drawing.Point(7, 124)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 1
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.Size = New System.Drawing.Size(972, 111)
        Me.principalTable.TabIndex = 0
        '
        'memberTable
        '
        Me.memberTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memberTable.BackColor = System.Drawing.Color.Lavender
        Me.memberTable.ColumnCount = 3
        Me.memberTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.memberTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.memberTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.memberTable.Controls.Add(Me.MiembroV, 2, 0)
        Me.memberTable.Controls.Add(Me.miembroL, 0, 0)
        Me.memberTable.Controls.Add(Me.SitioCombo, 1, 0)
        Me.memberTable.Controls.Add(Me.nombreMiembroL, 0, 1)
        Me.memberTable.Controls.Add(Me.NombreMiembroV, 1, 1)
        Me.memberTable.Location = New System.Drawing.Point(26, 3)
        Me.memberTable.Name = "memberTable"
        Me.memberTable.RowCount = 3
        Me.memberTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.memberTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.memberTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.memberTable.Size = New System.Drawing.Size(394, 105)
        Me.memberTable.TabIndex = 1
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.Location = New System.Drawing.Point(153, 3)
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(100, 22)
        Me.MiembroV.TabIndex = 1
        '
        'miembroL
        '
        Me.miembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.miembroL.AutoSize = True
        Me.miembroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miembroL.Location = New System.Drawing.Point(3, 0)
        Me.miembroL.Name = "miembroL"
        Me.miembroL.Size = New System.Drawing.Size(97, 30)
        Me.miembroL.TabIndex = 267
        Me.miembroL.Text = "Member Id:"
        Me.miembroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SitioCombo
        '
        Me.SitioCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SitioCombo.FormattingEnabled = True
        Me.SitioCombo.Location = New System.Drawing.Point(106, 3)
        Me.SitioCombo.Name = "SitioCombo"
        Me.SitioCombo.Size = New System.Drawing.Size(41, 24)
        Me.SitioCombo.TabIndex = 0
        '
        'nombreMiembroL
        '
        Me.nombreMiembroL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nombreMiembroL.AutoSize = True
        Me.nombreMiembroL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreMiembroL.Location = New System.Drawing.Point(3, 30)
        Me.nombreMiembroL.Name = "nombreMiembroL"
        Me.nombreMiembroL.Size = New System.Drawing.Size(97, 16)
        Me.nombreMiembroL.TabIndex = 269
        Me.nombreMiembroL.Text = "Member Name:"
        Me.nombreMiembroL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nombreMiembroL.Visible = False
        '
        'NombreMiembroV
        '
        Me.NombreMiembroV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NombreMiembroV.AutoSize = True
        Me.memberTable.SetColumnSpan(Me.NombreMiembroV, 2)
        Me.NombreMiembroV.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreMiembroV.ForeColor = System.Drawing.Color.Black
        Me.NombreMiembroV.Location = New System.Drawing.Point(106, 30)
        Me.NombreMiembroV.Name = "NombreMiembroV"
        Me.NombreMiembroV.Size = New System.Drawing.Size(15, 16)
        Me.NombreMiembroV.TabIndex = 274
        Me.NombreMiembroV.Text = "_"
        Me.NombreMiembroV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NombreMiembroV.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.nombrePadrinoV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoCombo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tipoL, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NivelCombo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nivelL, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nombresPadrinosL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.idPadrinoL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IdPadrinoV, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(476, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(394, 105)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'nombrePadrinoV
        '
        Me.nombrePadrinoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nombrePadrinoV.AutoSize = True
        Me.nombrePadrinoV.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombrePadrinoV.ForeColor = System.Drawing.Color.Black
        Me.nombrePadrinoV.Location = New System.Drawing.Point(114, 28)
        Me.nombrePadrinoV.Name = "nombrePadrinoV"
        Me.nombrePadrinoV.Size = New System.Drawing.Size(15, 16)
        Me.nombrePadrinoV.TabIndex = 273
        Me.nombrePadrinoV.Text = "_"
        Me.nombrePadrinoV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nombrePadrinoV.Visible = False
        '
        'TipoCombo
        '
        Me.TipoCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoCombo.FormattingEnabled = True
        Me.TipoCombo.Location = New System.Drawing.Point(114, 77)
        Me.TipoCombo.Name = "TipoCombo"
        Me.TipoCombo.Size = New System.Drawing.Size(96, 24)
        Me.TipoCombo.TabIndex = 273
        Me.TipoCombo.Visible = False
        '
        'tipoL
        '
        Me.tipoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tipoL.AutoSize = True
        Me.tipoL.Location = New System.Drawing.Point(3, 74)
        Me.tipoL.Name = "tipoL"
        Me.tipoL.Size = New System.Drawing.Size(105, 31)
        Me.tipoL.TabIndex = 271
        Me.tipoL.Text = "Type:"
        Me.tipoL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tipoL.Visible = False
        '
        'NivelCombo
        '
        Me.NivelCombo.Enabled = False
        Me.NivelCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NivelCombo.FormattingEnabled = True
        Me.NivelCombo.Location = New System.Drawing.Point(114, 47)
        Me.NivelCombo.Name = "NivelCombo"
        Me.NivelCombo.Size = New System.Drawing.Size(96, 24)
        Me.NivelCombo.TabIndex = 274
        Me.NivelCombo.Visible = False
        '
        'nivelL
        '
        Me.nivelL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nivelL.AutoSize = True
        Me.nivelL.Location = New System.Drawing.Point(3, 44)
        Me.nivelL.Name = "nivelL"
        Me.nivelL.Size = New System.Drawing.Size(105, 30)
        Me.nivelL.TabIndex = 272
        Me.nivelL.Text = "Level:"
        Me.nivelL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nivelL.Visible = False
        '
        'nombresPadrinosL
        '
        Me.nombresPadrinosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nombresPadrinosL.AutoSize = True
        Me.nombresPadrinosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombresPadrinosL.Location = New System.Drawing.Point(3, 28)
        Me.nombresPadrinosL.Name = "nombresPadrinosL"
        Me.nombresPadrinosL.Size = New System.Drawing.Size(105, 16)
        Me.nombresPadrinosL.TabIndex = 265
        Me.nombresPadrinosL.Text = "Sponsor Names:"
        Me.nombresPadrinosL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nombresPadrinosL.Visible = False
        '
        'idPadrinoL
        '
        Me.idPadrinoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.idPadrinoL.AutoSize = True
        Me.idPadrinoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPadrinoL.Location = New System.Drawing.Point(3, 0)
        Me.idPadrinoL.Name = "idPadrinoL"
        Me.idPadrinoL.Size = New System.Drawing.Size(105, 28)
        Me.idPadrinoL.TabIndex = 263
        Me.idPadrinoL.Text = "Sponsor Id:"
        Me.idPadrinoL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdPadrinoV
        '
        Me.IdPadrinoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPadrinoV.Location = New System.Drawing.Point(114, 3)
        Me.IdPadrinoV.Name = "IdPadrinoV"
        Me.IdPadrinoV.Size = New System.Drawing.Size(134, 22)
        Me.IdPadrinoV.TabIndex = 2
        '
        'BuscarButton
        '
        Me.BuscarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarButton.Location = New System.Drawing.Point(876, 3)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(69, 24)
        Me.BuscarButton.TabIndex = 3
        Me.BuscarButton.Text = "Search"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'PadrinosGrid
        '
        Me.PadrinosGrid.AllowUserToAddRows = False
        Me.PadrinosGrid.AllowUserToDeleteRows = False
        Me.PadrinosGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PadrinosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PadrinosGrid.BackgroundColor = System.Drawing.Color.White
        Me.PadrinosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PadrinosGrid.Location = New System.Drawing.Point(7, 291)
        Me.PadrinosGrid.Name = "PadrinosGrid"
        Me.PadrinosGrid.ReadOnly = True
        Me.PadrinosGrid.Size = New System.Drawing.Size(966, 218)
        Me.PadrinosGrid.TabIndex = 263
        Me.PadrinosGrid.Visible = False
        '
        'sponsorsL
        '
        Me.sponsorsL.AutoSize = True
        Me.sponsorsL.Font = New System.Drawing.Font("Arial", 11.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sponsorsL.Location = New System.Drawing.Point(5, 271)
        Me.sponsorsL.Name = "sponsorsL"
        Me.sponsorsL.Size = New System.Drawing.Size(75, 17)
        Me.sponsorsL.TabIndex = 264
        Me.sponsorsL.Text = "Sponsors:"
        Me.sponsorsL.Visible = False
        '
        'AgregarPadrino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PadrinosGrid)
        Me.Controls.Add(Me.sponsorsL)
        Me.Controls.Add(Me.principalTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgregarPadrino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Sponsor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.principalTable.ResumeLayout(False)
        Me.memberTable.ResumeLayout(False)
        Me.memberTable.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PadrinosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PadrinosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents sponsorsL As System.Windows.Forms.Label
    Friend WithEvents memberTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents miembroL As System.Windows.Forms.Label
    Friend WithEvents SitioCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nombreMiembroL As System.Windows.Forms.Label
    Friend WithEvents NombreMiembroV As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents nombrePadrinoV As System.Windows.Forms.Label
    Friend WithEvents TipoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents tipoL As System.Windows.Forms.Label
    Friend WithEvents NivelCombo As System.Windows.Forms.ComboBox
    Friend WithEvents nivelL As System.Windows.Forms.Label
    Friend WithEvents nombresPadrinosL As System.Windows.Forms.Label
    Friend WithEvents idPadrinoL As System.Windows.Forms.Label
    Friend WithEvents IdPadrinoV As System.Windows.Forms.TextBox
    Friend WithEvents BuscarButton As System.Windows.Forms.Button
End Class
