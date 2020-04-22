<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarioENE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalendarioENE))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.CicloCombo = New System.Windows.Forms.ComboBox()
        Me.AsistenciasV = New System.Windows.Forms.TextBox()
        Me.CicloL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NoSemanaV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlV = New System.Windows.Forms.TextBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.MesL = New System.Windows.Forms.Label()
        Me.MesCombo = New System.Windows.Forms.ComboBox()
        Me.DelV = New System.Windows.Forms.TextBox()
        Me.FechasGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FechasGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 15
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NotasV, 13, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NotasL, 13, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CicloCombo, 11, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AsistenciasV, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CicloL, 11, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NoSemanaV, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AlV, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoV, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MesL, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MesCombo, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DelV, 4, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 117)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(934, 98)
        Me.TableLayoutPanel1.TabIndex = 259
        '
        'NotasV
        '
        Me.NotasV.Location = New System.Drawing.Point(692, 52)
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(170, 23)
        Me.NotasV.TabIndex = 260
        '
        'NotasL
        '
        Me.NotasL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasL.AutoSize = True
        Me.NotasL.Location = New System.Drawing.Point(692, 0)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(170, 49)
        Me.NotasL.TabIndex = 262
        Me.NotasL.Text = "Notas"
        Me.NotasL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CicloCombo
        '
        Me.CicloCombo.FormattingEnabled = True
        Me.CicloCombo.Location = New System.Drawing.Point(576, 52)
        Me.CicloCombo.Name = "CicloCombo"
        Me.CicloCombo.Size = New System.Drawing.Size(90, 24)
        Me.CicloCombo.TabIndex = 260
        '
        'AsistenciasV
        '
        Me.AsistenciasV.Location = New System.Drawing.Point(478, 53)
        Me.AsistenciasV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AsistenciasV.Name = "AsistenciasV"
        Me.AsistenciasV.Size = New System.Drawing.Size(44, 23)
        Me.AsistenciasV.TabIndex = 267
        Me.AsistenciasV.Text = "5"
        '
        'CicloL
        '
        Me.CicloL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CicloL.AutoSize = True
        Me.CicloL.Location = New System.Drawing.Point(576, 0)
        Me.CicloL.Name = "CicloL"
        Me.CicloL.Size = New System.Drawing.Size(90, 49)
        Me.CicloL.TabIndex = 261
        Me.CicloL.Text = "Ciclo"
        Me.CicloL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 49)
        Me.Label4.TabIndex = 265
        Me.Label4.Text = "Asistencia"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoSemanaV
        '
        Me.NoSemanaV.Location = New System.Drawing.Point(367, 53)
        Me.NoSemanaV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NoSemanaV.Name = "NoSemanaV"
        Me.NoSemanaV.Size = New System.Drawing.Size(44, 23)
        Me.NoSemanaV.TabIndex = 266
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 49)
        Me.Label3.TabIndex = 264
        Me.Label3.Text = "No. Semana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(del mes)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 49)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "Al"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 49)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "Del"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AlV
        '
        Me.AlV.Location = New System.Drawing.Point(288, 53)
        Me.AlV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AlV.Name = "AlV"
        Me.AlV.Size = New System.Drawing.Size(53, 23)
        Me.AlV.TabIndex = 265
        '
        'AñoL
        '
        Me.AñoL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AñoL.AutoSize = True
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(53, 49)
        Me.AñoL.TabIndex = 261
        Me.AñoL.Text = "Año"
        Me.AñoL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(3, 53)
        Me.AñoV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(53, 23)
        Me.AñoV.TabIndex = 262
        '
        'MesL
        '
        Me.MesL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MesL.AutoSize = True
        Me.MesL.Location = New System.Drawing.Point(82, 0)
        Me.MesL.Name = "MesL"
        Me.MesL.Size = New System.Drawing.Size(121, 49)
        Me.MesL.TabIndex = 263
        Me.MesL.Text = "Mes"
        Me.MesL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MesCombo
        '
        Me.MesCombo.FormattingEnabled = True
        Me.MesCombo.Location = New System.Drawing.Point(82, 52)
        Me.MesCombo.Name = "MesCombo"
        Me.MesCombo.Size = New System.Drawing.Size(121, 24)
        Me.MesCombo.TabIndex = 260
        '
        'DelV
        '
        Me.DelV.Location = New System.Drawing.Point(229, 53)
        Me.DelV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DelV.Name = "DelV"
        Me.DelV.Size = New System.Drawing.Size(53, 23)
        Me.DelV.TabIndex = 264
        '
        'FechasGrid
        '
        Me.FechasGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechasGrid.Location = New System.Drawing.Point(0, 221)
        Me.FechasGrid.Name = "FechasGrid"
        Me.FechasGrid.RowTemplate.Height = 28
        Me.FechasGrid.Size = New System.Drawing.Size(736, 482)
        Me.FechasGrid.TabIndex = 260
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(934, 108)
        Me.bannerPanel.TabIndex = 261
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(838, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(787, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 262
        Me.GuardarButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(732, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(681, 3)
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
        Me.Title.Size = New System.Drawing.Size(670, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Calendario Asistencias - Escuela NE"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalendarioENE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(934, 749)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.FechasGrid)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CalendarioENE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario ENE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.FechasGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents MesL As System.Windows.Forms.Label
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents DelV As System.Windows.Forms.TextBox
    Friend WithEvents AsistenciasV As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NoSemanaV As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AlV As System.Windows.Forms.TextBox
    Friend WithEvents CicloCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CicloL As System.Windows.Forms.Label
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents FechasGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
End Class
