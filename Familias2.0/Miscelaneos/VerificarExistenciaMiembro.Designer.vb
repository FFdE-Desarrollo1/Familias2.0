<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerificarExistenciaMiembro
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerificarExistenciaMiembro))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.CamposPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MesCombo = New System.Windows.Forms.ComboBox()
        Me.añoNacV = New System.Windows.Forms.TextBox()
        Me.diaNacV = New System.Windows.Forms.TextBox()
        Me.nacimientoL = New System.Windows.Forms.Label()
        Me.ApellidosV = New System.Windows.Forms.TextBox()
        Me.ApellidosL = New System.Windows.Forms.Label()
        Me.NombresV = New System.Windows.Forms.TextBox()
        Me.NombresL = New System.Windows.Forms.Label()
        Me.buscarButton = New System.Windows.Forms.Button()
        Me.ListGridMiembros = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListGridMiembros2 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.CamposPanel.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ListGridMiembros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListGridMiembros2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ToolTip1.SetToolTip(Me.inicioButton, "Mensaje")
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
        Me.Title.Text = "Verificación Existencia de Miembro"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CamposPanel
        '
        Me.CamposPanel.BackColor = System.Drawing.Color.Transparent
        Me.CamposPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.CamposPanel.Controls.Add(Me.TableLayoutPanel3)
        Me.CamposPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CamposPanel.Location = New System.Drawing.Point(0, 118)
        Me.CamposPanel.Name = "CamposPanel"
        Me.CamposPanel.Size = New System.Drawing.Size(784, 624)
        Me.CamposPanel.TabIndex = 250
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ApellidosV, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ApellidosL, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.NombresV, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.NombresL, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.buscarButton, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.nacimientoL, 3, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(18, 14)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(756, 70)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.añoNacV, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.diaNacV, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MesCombo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(410, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(394, 31)
        Me.TableLayoutPanel2.TabIndex = 228
        '
        'MesCombo
        '
        Me.MesCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MesCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesCombo.FormattingEnabled = True
        Me.MesCombo.Location = New System.Drawing.Point(43, 3)
        Me.MesCombo.Name = "MesCombo"
        Me.MesCombo.Size = New System.Drawing.Size(288, 24)
        Me.MesCombo.TabIndex = 221
        '
        'añoNacV
        '
        Me.añoNacV.Location = New System.Drawing.Point(337, 3)
        Me.añoNacV.Name = "añoNacV"
        Me.añoNacV.Size = New System.Drawing.Size(54, 22)
        Me.añoNacV.TabIndex = 221
        '
        'diaNacV
        '
        Me.diaNacV.Location = New System.Drawing.Point(3, 3)
        Me.diaNacV.Name = "diaNacV"
        Me.diaNacV.Size = New System.Drawing.Size(34, 22)
        Me.diaNacV.TabIndex = 220
        '
        'nacimientoL
        '
        Me.nacimientoL.AutoSize = True
        Me.nacimientoL.BackColor = System.Drawing.Color.Transparent
        Me.nacimientoL.Location = New System.Drawing.Point(327, 0)
        Me.nacimientoL.Name = "nacimientoL"
        Me.nacimientoL.Size = New System.Drawing.Size(77, 16)
        Me.nacimientoL.TabIndex = 225
        Me.nacimientoL.Text = "Nacimiento:"
        '
        'ApellidosV
        '
        Me.ApellidosV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApellidosV.Location = New System.Drawing.Point(-23, 40)
        Me.ApellidosV.Name = "ApellidosV"
        Me.ApellidosV.Size = New System.Drawing.Size(344, 22)
        Me.ApellidosV.TabIndex = 220
        Me.ToolTip1.SetToolTip(Me.ApellidosV, "Sustituir las letras tildadas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por el signo de guión mayor ""_""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ej." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pérez -> " & _
        "    P_rez")
        '
        'ApellidosL
        '
        Me.ApellidosL.AutoSize = True
        Me.ApellidosL.BackColor = System.Drawing.Color.Transparent
        Me.ApellidosL.Location = New System.Drawing.Point(-103, 37)
        Me.ApellidosL.Name = "ApellidosL"
        Me.ApellidosL.Size = New System.Drawing.Size(74, 16)
        Me.ApellidosL.TabIndex = 223
        Me.ApellidosL.Text = "Apellidos: *"
        '
        'NombresV
        '
        Me.NombresV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombresV.Location = New System.Drawing.Point(-23, 3)
        Me.NombresV.Name = "NombresV"
        Me.NombresV.Size = New System.Drawing.Size(344, 22)
        Me.NombresV.TabIndex = 219
        Me.ToolTip1.SetToolTip(Me.NombresV, "Sustituir las letras tildadas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por el signo de guión mayor ""_""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ej." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "María -> " & _
        "    Mar_a")
        '
        'NombresL
        '
        Me.NombresL.AutoSize = True
        Me.NombresL.BackColor = System.Drawing.Color.Transparent
        Me.NombresL.Location = New System.Drawing.Point(-103, 0)
        Me.NombresL.Name = "NombresL"
        Me.NombresL.Size = New System.Drawing.Size(73, 16)
        Me.NombresL.TabIndex = 222
        Me.NombresL.Text = "Nombres: *"
        '
        'buscarButton
        '
        Me.buscarButton.BackColor = System.Drawing.Color.White
        Me.buscarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.searchFam
        Me.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.buscarButton.Location = New System.Drawing.Point(810, 3)
        Me.buscarButton.Name = "buscarButton"
        Me.TableLayoutPanel3.SetRowSpan(Me.buscarButton, 2)
        Me.buscarButton.Size = New System.Drawing.Size(50, 48)
        Me.buscarButton.TabIndex = 7
        Me.buscarButton.UseVisualStyleBackColor = False
        '
        'ListGridMiembros
        '
        Me.ListGridMiembros.AllowUserToAddRows = False
        Me.ListGridMiembros.AllowUserToDeleteRows = False
        Me.ListGridMiembros.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        Me.ListGridMiembros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListGridMiembros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListGridMiembros.BackgroundColor = System.Drawing.Color.White
        Me.ListGridMiembros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListGridMiembros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListGridMiembros.GridColor = System.Drawing.Color.White
        Me.ListGridMiembros.Location = New System.Drawing.Point(3, 23)
        Me.ListGridMiembros.Name = "ListGridMiembros"
        Me.ListGridMiembros.ReadOnly = True
        Me.ListGridMiembros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListGridMiembros.Size = New System.Drawing.Size(364, 467)
        Me.ListGridMiembros.TabIndex = 8
        '
        'ToolTip1
        '
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Recomendación"
        '
        'ListGridMiembros2
        '
        Me.ListGridMiembros2.AllowUserToAddRows = False
        Me.ListGridMiembros2.AllowUserToDeleteRows = False
        Me.ListGridMiembros2.AllowUserToResizeColumns = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        Me.ListGridMiembros2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListGridMiembros2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListGridMiembros2.BackgroundColor = System.Drawing.Color.White
        Me.ListGridMiembros2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListGridMiembros2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListGridMiembros2.DefaultCellStyle = DataGridViewCellStyle3
        Me.ListGridMiembros2.GridColor = System.Drawing.Color.White
        Me.ListGridMiembros2.Location = New System.Drawing.Point(388, 23)
        Me.ListGridMiembros2.Name = "ListGridMiembros2"
        Me.ListGridMiembros2.ReadOnly = True
        Me.ListGridMiembros2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListGridMiembros2.Size = New System.Drawing.Size(365, 467)
        Me.ListGridMiembros2.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListGridMiembros, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ListGridMiembros2, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 119)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(756, 493)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ordenado por Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(388, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ordenado por Fecha Nacimiento:"
        '
        'VerificarExistenciaMiembro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 742)
        Me.Controls.Add(Me.CamposPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "VerificarExistenciaMiembro"
        Me.Text = "VerificarExistenciaDeMiembro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.CamposPanel.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ListGridMiembros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListGridMiembros2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents CamposPanel As System.Windows.Forms.Panel
    Friend WithEvents NombresL As System.Windows.Forms.Label
    Friend WithEvents NombresV As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosL As System.Windows.Forms.Label
    Friend WithEvents ApellidosV As System.Windows.Forms.TextBox
    Friend WithEvents ListGridMiembros As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents añoNacV As System.Windows.Forms.TextBox
    Friend WithEvents diaNacV As System.Windows.Forms.TextBox
    Friend WithEvents nacimientoL As System.Windows.Forms.Label
    Friend WithEvents buscarButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ListGridMiembros2 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
