<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolAfiliacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolAfiliacion))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.EstadoFamV = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.FechaPicker = New System.Windows.Forms.DateTimePicker()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.TipoCombo = New System.Windows.Forms.ComboBox()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.EstadoCombo = New System.Windows.Forms.ComboBox()
        Me.VisitaL = New System.Windows.Forms.Label()
        Me.NombreL = New System.Windows.Forms.Label()
        Me.NombreV = New System.Windows.Forms.Label()
        Me.VisitaV = New System.Windows.Forms.MaskedTextBox()
        Me.EstadoAfilMembV = New System.Windows.Forms.Label()
        Me.InfoGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.Table1.SuspendLayout()
        CType(Me.InfoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(934, 104)
        Me.bannerPanel.TabIndex = 260
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
        Me.opcionesTable.Location = New System.Drawing.Point(94, 52)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(838, 49)
        Me.opcionesTable.TabIndex = 68
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(732, 3)
        Me.NuevoButton.Name = "NuevoButton"
        Me.NuevoButton.Size = New System.Drawing.Size(49, 43)
        Me.NuevoButton.TabIndex = 235
        Me.NuevoButton.UseVisualStyleBackColor = False
        '
        'inicioButton
        '
        Me.inicioButton.BackColor = System.Drawing.Color.AliceBlue
        Me.inicioButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Menu
        Me.inicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioButton.Location = New System.Drawing.Point(681, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 43)
        Me.inicioButton.TabIndex = 235
        Me.inicioButton.UseVisualStyleBackColor = False
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(787, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 43)
        Me.GuardarButton.TabIndex = 4
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
        Me.Title.Size = New System.Drawing.Size(670, 49)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Ingresar Solicitud de afiliación de miembro"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PrincipalPanel.Controls.Add(Me.MiembroV, 4, 0)
        Me.PrincipalPanel.Controls.Add(Me.PacienteL, 3, 0)
        Me.PrincipalPanel.Controls.Add(Me.FamiliaL, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.EstadoFamV, 2, 0)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 107)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 1
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(934, 36)
        Me.PrincipalPanel.TabIndex = 251
        '
        'FamiliaV
        '
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FamiliaV.Location = New System.Drawing.Point(149, 3)
        Me.FamiliaV.MaxLength = 10
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(112, 40)
        Me.FamiliaV.TabIndex = 1
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MiembroV
        '
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MiembroV.Location = New System.Drawing.Point(817, 3)
        Me.MiembroV.MaxLength = 10
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(112, 40)
        Me.MiembroV.TabIndex = 0
        Me.MiembroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PacienteL
        '
        Me.PacienteL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteL.Location = New System.Drawing.Point(656, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(155, 36)
        Me.PacienteL.TabIndex = 204
        Me.PacienteL.Text = "No. Miembro:"
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
        Me.FamiliaL.Size = New System.Drawing.Size(140, 36)
        Me.FamiliaL.TabIndex = 0
        Me.FamiliaL.Text = "No. Familia:"
        Me.FamiliaL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EstadoFamV
        '
        Me.EstadoFamV.AutoSize = True
        Me.EstadoFamV.Location = New System.Drawing.Point(269, 0)
        Me.EstadoFamV.Name = "EstadoFamV"
        Me.EstadoFamV.Size = New System.Drawing.Size(17, 23)
        Me.EstadoFamV.TabIndex = 205
        Me.EstadoFamV.Text = "-"
        Me.EstadoFamV.Visible = False
        '
        'Table1
        '
        Me.Table1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Table1.ColumnCount = 11
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.Controls.Add(Me.FechaL, 0, 1)
        Me.Table1.Controls.Add(Me.FechaPicker, 1, 1)
        Me.Table1.Controls.Add(Me.TipoL, 3, 1)
        Me.Table1.Controls.Add(Me.TipoCombo, 4, 1)
        Me.Table1.Controls.Add(Me.EstadoL, 6, 1)
        Me.Table1.Controls.Add(Me.EstadoCombo, 7, 1)
        Me.Table1.Controls.Add(Me.VisitaL, 9, 1)
        Me.Table1.Controls.Add(Me.NombreL, 0, 0)
        Me.Table1.Controls.Add(Me.NombreV, 1, 0)
        Me.Table1.Controls.Add(Me.VisitaV, 10, 1)
        Me.Table1.Controls.Add(Me.EstadoAfilMembV, 9, 0)
        Me.Table1.Location = New System.Drawing.Point(0, 147)
        Me.Table1.Name = "Table1"
        Me.Table1.RowCount = 2
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.Size = New System.Drawing.Size(934, 61)
        Me.Table1.TabIndex = 261
        Me.Table1.Visible = False
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.Location = New System.Drawing.Point(3, 20)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(143, 46)
        Me.FechaL.TabIndex = 0
        Me.FechaL.Text = "Fecha Solicitud" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y estado:"
        '
        'FechaPicker
        '
        Me.FechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPicker.Location = New System.Drawing.Point(152, 23)
        Me.FechaPicker.Name = "FechaPicker"
        Me.FechaPicker.Size = New System.Drawing.Size(112, 30)
        Me.FechaPicker.TabIndex = 1
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.Location = New System.Drawing.Point(286, 20)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(93, 46)
        Me.TipoL.TabIndex = 2
        Me.TipoL.Text = "Tipo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Afiliación:"
        '
        'TipoCombo
        '
        Me.TipoCombo.FormattingEnabled = True
        Me.TipoCombo.Location = New System.Drawing.Point(385, 23)
        Me.TipoCombo.Name = "TipoCombo"
        Me.TipoCombo.Size = New System.Drawing.Size(121, 31)
        Me.TipoCombo.TabIndex = 3
        '
        'EstadoL
        '
        Me.EstadoL.AutoSize = True
        Me.EstadoL.Location = New System.Drawing.Point(528, 20)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(78, 23)
        Me.EstadoL.TabIndex = 4
        Me.EstadoL.Text = "Estado:"
        '
        'EstadoCombo
        '
        Me.EstadoCombo.FormattingEnabled = True
        Me.EstadoCombo.Location = New System.Drawing.Point(612, 23)
        Me.EstadoCombo.Name = "EstadoCombo"
        Me.EstadoCombo.Size = New System.Drawing.Size(121, 31)
        Me.EstadoCombo.TabIndex = 5
        '
        'VisitaL
        '
        Me.VisitaL.AutoSize = True
        Me.VisitaL.Location = New System.Drawing.Point(755, 20)
        Me.VisitaL.Name = "VisitaL"
        Me.VisitaL.Size = New System.Drawing.Size(70, 46)
        Me.VisitaL.TabIndex = 6
        Me.VisitaL.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Visita:"
        '
        'NombreL
        '
        Me.NombreL.AutoSize = True
        Me.NombreL.Location = New System.Drawing.Point(3, 0)
        Me.NombreL.Name = "NombreL"
        Me.NombreL.Size = New System.Drawing.Size(85, 20)
        Me.NombreL.TabIndex = 70
        Me.NombreL.Text = "Nombre:"
        '
        'NombreV
        '
        Me.NombreV.AutoSize = True
        Me.NombreV.BackColor = System.Drawing.Color.Transparent
        Me.Table1.SetColumnSpan(Me.NombreV, 5)
        Me.NombreV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreV.Location = New System.Drawing.Point(152, 0)
        Me.NombreV.Name = "NombreV"
        Me.NombreV.Size = New System.Drawing.Size(98, 20)
        Me.NombreV.TabIndex = 71
        Me.NombreV.Text = "Nombre"
        '
        'VisitaV
        '
        Me.VisitaV.Location = New System.Drawing.Point(831, 23)
        Me.VisitaV.Name = "VisitaV"
        Me.VisitaV.Size = New System.Drawing.Size(100, 30)
        Me.VisitaV.TabIndex = 73
        '
        'EstadoAfilMembV
        '
        Me.EstadoAfilMembV.AutoSize = True
        Me.Table1.SetColumnSpan(Me.EstadoAfilMembV, 2)
        Me.EstadoAfilMembV.Location = New System.Drawing.Point(755, 0)
        Me.EstadoAfilMembV.Name = "EstadoAfilMembV"
        Me.EstadoAfilMembV.Size = New System.Drawing.Size(17, 20)
        Me.EstadoAfilMembV.TabIndex = 206
        Me.EstadoAfilMembV.Text = "-"
        Me.EstadoAfilMembV.Visible = False
        '
        'InfoGrid
        '
        Me.InfoGrid.AllowUserToAddRows = False
        Me.InfoGrid.AllowUserToDeleteRows = False
        Me.InfoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoGrid.BackgroundColor = System.Drawing.Color.White
        Me.InfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InfoGrid.Location = New System.Drawing.Point(0, 232)
        Me.InfoGrid.Name = "InfoGrid"
        Me.InfoGrid.ReadOnly = True
        Me.InfoGrid.Size = New System.Drawing.Size(934, 505)
        Me.InfoGrid.TabIndex = 262
        Me.InfoGrid.Visible = False
        '
        'SolAfiliacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.InfoGrid)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SolAfiliacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SolAfiliacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.PrincipalPanel.ResumeLayout(False)
        Me.PrincipalPanel.PerformLayout()
        Me.Table1.ResumeLayout(False)
        Me.Table1.PerformLayout()
        CType(Me.InfoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents Table1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents FechaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents TipoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents EstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents VisitaL As System.Windows.Forms.Label
    Friend WithEvents InfoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents NombreL As System.Windows.Forms.Label
    Friend WithEvents NombreV As System.Windows.Forms.Label
    Friend WithEvents VisitaV As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EstadoFamV As System.Windows.Forms.Label
    Friend WithEvents EstadoAfilMembV As System.Windows.Forms.Label
End Class
