<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarDatosPadrinos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarDatosPadrinos))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ContactoV = New System.Windows.Forms.TextBox()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.NombreV = New System.Windows.Forms.TextBox()
        Me.contactoL = New System.Windows.Forms.Label()
        Me.nombresPadrinosL = New System.Windows.Forms.Label()
        Me.idPadrinoL = New System.Windows.Forms.Label()
        Me.IdPadrinoV = New System.Windows.Forms.TextBox()
        Me.EspañolCheck = New System.Windows.Forms.CheckBox()
        Me.InfoPadrinoGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.principalTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        CType(Me.InfoPadrinoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bannerPanel.TabIndex = 263
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
        Me.Title.Text = "Update Sponsor Information"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'principalTable
        '
        Me.principalTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.principalTable.BackColor = System.Drawing.Color.Transparent
        Me.principalTable.ColumnCount = 5
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.principalTable.Controls.Add(Me.PrincipalPanel, 2, 0)
        Me.principalTable.Controls.Add(Me.InfoPadrinoGrid, 1, 2)
        Me.principalTable.Location = New System.Drawing.Point(7, 124)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 3
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.principalTable.Size = New System.Drawing.Size(972, 371)
        Me.principalTable.TabIndex = 264
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.PrincipalPanel.ColumnCount = 3
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PrincipalPanel.Controls.Add(Me.ContactoV, 1, 2)
        Me.PrincipalPanel.Controls.Add(Me.BuscarButton, 2, 0)
        Me.PrincipalPanel.Controls.Add(Me.NombreV, 1, 1)
        Me.PrincipalPanel.Controls.Add(Me.contactoL, 0, 2)
        Me.PrincipalPanel.Controls.Add(Me.nombresPadrinosL, 0, 1)
        Me.PrincipalPanel.Controls.Add(Me.idPadrinoL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.IdPadrinoV, 1, 0)
        Me.PrincipalPanel.Controls.Add(Me.EspañolCheck, 1, 3)
        Me.PrincipalPanel.Location = New System.Drawing.Point(163, 3)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 4
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.Size = New System.Drawing.Size(644, 124)
        Me.PrincipalPanel.TabIndex = 2
        '
        'ContactoV
        '
        Me.ContactoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.SetColumnSpan(Me.ContactoV, 2)
        Me.ContactoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactoV.Location = New System.Drawing.Point(188, 61)
        Me.ContactoV.Name = "ContactoV"
        Me.ContactoV.Size = New System.Drawing.Size(453, 22)
        Me.ContactoV.TabIndex = 266
        Me.ContactoV.Visible = False
        '
        'BuscarButton
        '
        Me.BuscarButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarButton.Location = New System.Drawing.Point(328, 3)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(69, 24)
        Me.BuscarButton.TabIndex = 3
        Me.BuscarButton.Text = "Search"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'NombreV
        '
        Me.NombreV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.SetColumnSpan(Me.NombreV, 2)
        Me.NombreV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.Location = New System.Drawing.Point(188, 33)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(453, 22)
        Me.NombreV.TabIndex = 265
        Me.NombreV.Visible = False
        '
        'contactoL
        '
        Me.contactoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contactoL.AutoSize = True
        Me.contactoL.Location = New System.Drawing.Point(3, 58)
        Me.contactoL.Name = "contactoL"
        Me.contactoL.Size = New System.Drawing.Size(179, 28)
        Me.contactoL.TabIndex = 272
        Me.contactoL.Text = "Organization Contact Names:"
        Me.contactoL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.contactoL.Visible = False
        '
        'nombresPadrinosL
        '
        Me.nombresPadrinosL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nombresPadrinosL.AutoSize = True
        Me.nombresPadrinosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombresPadrinosL.Location = New System.Drawing.Point(3, 30)
        Me.nombresPadrinosL.Name = "nombresPadrinosL"
        Me.nombresPadrinosL.Size = New System.Drawing.Size(179, 28)
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
        Me.idPadrinoL.Size = New System.Drawing.Size(179, 30)
        Me.idPadrinoL.TabIndex = 263
        Me.idPadrinoL.Text = "Sponsor Id:"
        Me.idPadrinoL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdPadrinoV
        '
        Me.IdPadrinoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPadrinoV.Location = New System.Drawing.Point(188, 3)
        Me.IdPadrinoV.Name = "IdPadrinoV"
        Me.IdPadrinoV.Size = New System.Drawing.Size(134, 22)
        Me.IdPadrinoV.TabIndex = 2
        '
        'EspañolCheck
        '
        Me.EspañolCheck.AutoSize = True
        Me.EspañolCheck.Location = New System.Drawing.Point(188, 89)
        Me.EspañolCheck.Name = "EspañolCheck"
        Me.EspañolCheck.Size = New System.Drawing.Size(115, 20)
        Me.EspañolCheck.TabIndex = 273
        Me.EspañolCheck.Text = "Speak Spanish"
        Me.EspañolCheck.UseVisualStyleBackColor = True
        Me.EspañolCheck.Visible = False
        '
        'InfoPadrinoGrid
        '
        Me.InfoPadrinoGrid.AllowUserToAddRows = False
        Me.InfoPadrinoGrid.AllowUserToDeleteRows = False
        Me.InfoPadrinoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoPadrinoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.InfoPadrinoGrid.BackgroundColor = System.Drawing.Color.White
        Me.InfoPadrinoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.principalTable.SetColumnSpan(Me.InfoPadrinoGrid, 3)
        Me.InfoPadrinoGrid.Location = New System.Drawing.Point(83, 153)
        Me.InfoPadrinoGrid.Name = "InfoPadrinoGrid"
        Me.InfoPadrinoGrid.ReadOnly = True
        Me.InfoPadrinoGrid.RowHeadersVisible = False
        Me.InfoPadrinoGrid.Size = New System.Drawing.Size(804, 215)
        Me.InfoPadrinoGrid.TabIndex = 264
        Me.InfoPadrinoGrid.Visible = False
        '
        'ActualizarDatosPadrinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.principalTable)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActualizarDatosPadrinos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Sponsor Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.principalTable.ResumeLayout(False)
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        CType(Me.InfoPadrinoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ContactoV As System.Windows.Forms.TextBox
    Friend WithEvents NombreV As System.Windows.Forms.TextBox
    Friend WithEvents contactoL As System.Windows.Forms.Label
    Friend WithEvents nombresPadrinosL As System.Windows.Forms.Label
    Friend WithEvents idPadrinoL As System.Windows.Forms.Label
    Friend WithEvents IdPadrinoV As System.Windows.Forms.TextBox
    Friend WithEvents BuscarButton As System.Windows.Forms.Button
    Friend WithEvents EspañolCheck As System.Windows.Forms.CheckBox
    Friend WithEvents InfoPadrinoGrid As System.Windows.Forms.DataGridView
End Class
