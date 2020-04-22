<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Planilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Planilla))
        Me.GradoV = New System.Windows.Forms.ComboBox()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.EstadoV = New System.Windows.Forms.ComboBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.SearchTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CantidadL = New System.Windows.Forms.Label()
        Me.TipoV = New System.Windows.Forms.ComboBox()
        Me.TipoL = New System.Windows.Forms.Label()
        Me.CantidadV = New System.Windows.Forms.TextBox()
        Me.CarreraV = New System.Windows.Forms.ComboBox()
        Me.CarreraL = New System.Windows.Forms.Label()
        Me.NivelV = New System.Windows.Forms.ComboBox()
        Me.NivelL = New System.Windows.Forms.Label()
        Me.EscuelaV = New System.Windows.Forms.ComboBox()
        Me.PayTitle = New System.Windows.Forms.Label()
        Me.EscuelaL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.SeguirButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradoV
        '
        Me.GradoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.GradoV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GradoV.FormattingEnabled = True
        Me.GradoV.Location = New System.Drawing.Point(86, 51)
        Me.GradoV.Name = "GradoV"
        Me.GradoV.Size = New System.Drawing.Size(361, 24)
        Me.GradoV.TabIndex = 1
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(86, 11)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.ReadOnly = True
        Me.AñoV.Size = New System.Drawing.Size(69, 22)
        Me.AñoV.TabIndex = 0
        Me.AñoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EstadoV
        '
        Me.EstadoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.EstadoV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadoV.FormattingEnabled = True
        Me.EstadoV.Location = New System.Drawing.Point(86, 143)
        Me.EstadoV.Name = "EstadoV"
        Me.EstadoV.Size = New System.Drawing.Size(361, 24)
        Me.EstadoV.TabIndex = 3
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.BackColor = System.Drawing.Color.Transparent
        Me.AñoL.Location = New System.Drawing.Point(17, 14)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(35, 16)
        Me.AñoL.TabIndex = 45
        Me.AñoL.Text = "Año:"
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.BackColor = System.Drawing.Color.Transparent
        Me.GradoL.Location = New System.Drawing.Point(13, 54)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(47, 16)
        Me.GradoL.TabIndex = 41
        Me.GradoL.Text = "Grado:"
        '
        'EstadoL
        '
        Me.EstadoL.AutoSize = True
        Me.EstadoL.BackColor = System.Drawing.Color.Transparent
        Me.EstadoL.Location = New System.Drawing.Point(13, 146)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(53, 16)
        Me.EstadoL.TabIndex = 42
        Me.EstadoL.Text = "Estado:"
        '
        'SearchTitle
        '
        Me.SearchTitle.AutoSize = True
        Me.SearchTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchTitle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTitle.ForeColor = System.Drawing.Color.White
        Me.SearchTitle.Location = New System.Drawing.Point(158, 0)
        Me.SearchTitle.Name = "SearchTitle"
        Me.SearchTitle.Size = New System.Drawing.Size(238, 18)
        Me.SearchTitle.TabIndex = 71
        Me.SearchTitle.Text = "Datos para Realizar la Búsqueda"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CantidadL)
        Me.Panel1.Controls.Add(Me.TipoV)
        Me.Panel1.Controls.Add(Me.TipoL)
        Me.Panel1.Controls.Add(Me.CantidadV)
        Me.Panel1.Location = New System.Drawing.Point(158, 369)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 108)
        Me.Panel1.TabIndex = 69
        '
        'CantidadL
        '
        Me.CantidadL.AutoSize = True
        Me.CantidadL.BackColor = System.Drawing.Color.Transparent
        Me.CantidadL.Location = New System.Drawing.Point(13, 69)
        Me.CantidadL.Name = "CantidadL"
        Me.CantidadL.Size = New System.Drawing.Size(63, 16)
        Me.CantidadL.TabIndex = 54
        Me.CantidadL.Text = "Cantidad:"
        '
        'TipoV
        '
        Me.TipoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoV.FormattingEnabled = True
        Me.TipoV.Location = New System.Drawing.Point(86, 23)
        Me.TipoV.Name = "TipoV"
        Me.TipoV.Size = New System.Drawing.Size(361, 24)
        Me.TipoV.TabIndex = 0
        '
        'TipoL
        '
        Me.TipoL.AutoSize = True
        Me.TipoL.BackColor = System.Drawing.Color.Transparent
        Me.TipoL.Location = New System.Drawing.Point(44, 26)
        Me.TipoL.Name = "TipoL"
        Me.TipoL.Size = New System.Drawing.Size(36, 16)
        Me.TipoL.TabIndex = 53
        Me.TipoL.Text = "Tipo:"
        '
        'CantidadV
        '
        Me.CantidadV.Location = New System.Drawing.Point(85, 66)
        Me.CantidadV.Name = "CantidadV"
        Me.CantidadV.Size = New System.Drawing.Size(128, 22)
        Me.CantidadV.TabIndex = 1
        '
        'CarreraV
        '
        Me.CarreraV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CarreraV.FormattingEnabled = True
        Me.CarreraV.Location = New System.Drawing.Point(86, 239)
        Me.CarreraV.Name = "CarreraV"
        Me.CarreraV.Size = New System.Drawing.Size(361, 24)
        Me.CarreraV.TabIndex = 5
        '
        'CarreraL
        '
        Me.CarreraL.AutoSize = True
        Me.CarreraL.BackColor = System.Drawing.Color.Transparent
        Me.CarreraL.Location = New System.Drawing.Point(13, 242)
        Me.CarreraL.Name = "CarreraL"
        Me.CarreraL.Size = New System.Drawing.Size(54, 16)
        Me.CarreraL.TabIndex = 49
        Me.CarreraL.Text = "Carrera:"
        '
        'NivelV
        '
        Me.NivelV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NivelV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NivelV.FormattingEnabled = True
        Me.NivelV.Location = New System.Drawing.Point(86, 96)
        Me.NivelV.Name = "NivelV"
        Me.NivelV.Size = New System.Drawing.Size(361, 24)
        Me.NivelV.TabIndex = 2
        '
        'NivelL
        '
        Me.NivelL.AutoSize = True
        Me.NivelL.BackColor = System.Drawing.Color.Transparent
        Me.NivelL.Location = New System.Drawing.Point(13, 90)
        Me.NivelL.Name = "NivelL"
        Me.NivelL.Size = New System.Drawing.Size(68, 32)
        Me.NivelL.TabIndex = 47
        Me.NivelL.Text = "Nivel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Educativo:"
        '
        'EscuelaV
        '
        Me.EscuelaV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.EscuelaV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EscuelaV.FormattingEnabled = True
        Me.EscuelaV.Location = New System.Drawing.Point(86, 192)
        Me.EscuelaV.Name = "EscuelaV"
        Me.EscuelaV.Size = New System.Drawing.Size(361, 24)
        Me.EscuelaV.TabIndex = 4
        '
        'PayTitle
        '
        Me.PayTitle.AutoSize = True
        Me.PayTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.PayTitle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayTitle.ForeColor = System.Drawing.Color.White
        Me.PayTitle.Location = New System.Drawing.Point(158, 346)
        Me.PayTitle.Name = "PayTitle"
        Me.PayTitle.Size = New System.Drawing.Size(185, 18)
        Me.PayTitle.TabIndex = 71
        Me.PayTitle.Text = "Datos para Realizar pago"
        '
        'EscuelaL
        '
        Me.EscuelaL.AutoSize = True
        Me.EscuelaL.BackColor = System.Drawing.Color.Transparent
        Me.EscuelaL.Location = New System.Drawing.Point(13, 195)
        Me.EscuelaL.Name = "EscuelaL"
        Me.EscuelaL.Size = New System.Drawing.Size(59, 16)
        Me.EscuelaL.TabIndex = 43
        Me.EscuelaL.Text = "Escuela:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SearchTitle, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PayTitle, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(784, 570)
        Me.TableLayoutPanel2.TabIndex = 244
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.CarreraV)
        Me.Panel2.Controls.Add(Me.CarreraL)
        Me.Panel2.Controls.Add(Me.NivelV)
        Me.Panel2.Controls.Add(Me.NivelL)
        Me.Panel2.Controls.Add(Me.EscuelaV)
        Me.Panel2.Controls.Add(Me.GradoV)
        Me.Panel2.Controls.Add(Me.AñoV)
        Me.Panel2.Controls.Add(Me.EstadoV)
        Me.Panel2.Controls.Add(Me.AñoL)
        Me.Panel2.Controls.Add(Me.GradoL)
        Me.Panel2.Controls.Add(Me.EscuelaL)
        Me.Panel2.Controls.Add(Me.EstadoL)
        Me.Panel2.Location = New System.Drawing.Point(158, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 269)
        Me.Panel2.TabIndex = 72
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 254
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
        Me.opcionesTable.Controls.Add(Me.SeguirButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'SeguirButton
        '
        Me.SeguirButton.BackColor = System.Drawing.Color.AliceBlue
        Me.SeguirButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.seguir
        Me.SeguirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SeguirButton.Location = New System.Drawing.Point(636, 3)
        Me.SeguirButton.Name = "SeguirButton"
        Me.SeguirButton.Size = New System.Drawing.Size(49, 44)
        Me.SeguirButton.TabIndex = 235
        Me.SeguirButton.UseVisualStyleBackColor = False
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
        Me.Title.Text = "Planillas de Reembolsos"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Planilla"
        Me.Text = "Planilla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradoV As System.Windows.Forms.ComboBox
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents EstadoV As System.Windows.Forms.ComboBox
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents SearchTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CantidadL As System.Windows.Forms.Label
    Friend WithEvents TipoV As System.Windows.Forms.ComboBox
    Friend WithEvents TipoL As System.Windows.Forms.Label
    Friend WithEvents CantidadV As System.Windows.Forms.TextBox
    Friend WithEvents CarreraV As System.Windows.Forms.ComboBox
    Friend WithEvents CarreraL As System.Windows.Forms.Label
    Friend WithEvents NivelV As System.Windows.Forms.ComboBox
    Friend WithEvents NivelL As System.Windows.Forms.Label
    Friend WithEvents EscuelaV As System.Windows.Forms.ComboBox
    Friend WithEvents PayTitle As System.Windows.Forms.Label
    Friend WithEvents EscuelaL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SeguirButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
