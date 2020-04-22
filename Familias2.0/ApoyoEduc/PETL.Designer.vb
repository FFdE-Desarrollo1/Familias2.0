<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PETL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PETL))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliasPETLLink = New System.Windows.Forms.LinkLabel()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.añoL = New System.Windows.Forms.Label()
        Me.CandidatosLink = New System.Windows.Forms.LinkLabel()
        Me.participantesCombo = New System.Windows.Forms.ComboBox()
        Me.participantesL = New System.Windows.Forms.Label()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.ListadoGrid = New System.Windows.Forms.DataGridView()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.FamiliasPETLLink, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoV, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.añoL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CandidatosLink, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.participantesCombo, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.participantesL, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalL, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 124)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 63)
        Me.TableLayoutPanel1.TabIndex = 238
        '
        'FamiliasPETLLink
        '
        Me.FamiliasPETLLink.AutoSize = True
        Me.FamiliasPETLLink.Location = New System.Drawing.Point(553, 0)
        Me.FamiliasPETLLink.Name = "FamiliasPETLLink"
        Me.FamiliasPETLLink.Size = New System.Drawing.Size(228, 16)
        Me.FamiliasPETLLink.TabIndex = 214
        Me.FamiliasPETLLink.TabStop = True
        Me.FamiliasPETLLink.Text = "Familias que han participado en PETL"
        '
        'AñoV
        '
        Me.AñoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoV.Location = New System.Drawing.Point(417, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(100, 22)
        Me.AñoV.TabIndex = 1
        '
        'añoL
        '
        Me.añoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.añoL.AutoSize = True
        Me.añoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.añoL.Location = New System.Drawing.Point(237, 0)
        Me.añoL.Name = "añoL"
        Me.añoL.Size = New System.Drawing.Size(174, 16)
        Me.añoL.TabIndex = 2
        Me.añoL.Text = "Año:"
        Me.añoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CandidatosLink
        '
        Me.CandidatosLink.AutoSize = True
        Me.CandidatosLink.Location = New System.Drawing.Point(553, 28)
        Me.CandidatosLink.Name = "CandidatosLink"
        Me.CandidatosLink.Size = New System.Drawing.Size(109, 16)
        Me.CandidatosLink.TabIndex = 209
        Me.CandidatosLink.TabStop = True
        Me.CandidatosLink.Text = "Candidatos PETL"
        '
        'participantesCombo
        '
        Me.participantesCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.participantesCombo.FormattingEnabled = True
        Me.participantesCombo.Items.AddRange(New Object() {"SI", "NO"})
        Me.participantesCombo.Location = New System.Drawing.Point(417, 31)
        Me.participantesCombo.Name = "participantesCombo"
        Me.participantesCombo.Size = New System.Drawing.Size(63, 24)
        Me.participantesCombo.TabIndex = 3
        Me.participantesCombo.Visible = False
        '
        'participantesL
        '
        Me.participantesL.AutoSize = True
        Me.participantesL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.participantesL.Location = New System.Drawing.Point(237, 28)
        Me.participantesL.Name = "participantesL"
        Me.participantesL.Size = New System.Drawing.Size(174, 16)
        Me.participantesL.TabIndex = 208
        Me.participantesL.Text = "Participación de Candidatos:"
        Me.participantesL.Visible = False
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.Location = New System.Drawing.Point(3, 28)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(15, 16)
        Me.TotalL.TabIndex = 215
        Me.TotalL.Text = "_"
        Me.TotalL.Visible = False
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
        Me.ListadoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListadoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ListadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListadoGrid.Location = New System.Drawing.Point(0, 193)
        Me.ListadoGrid.Name = "ListadoGrid"
        Me.ListadoGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListadoGrid.Size = New System.Drawing.Size(784, 550)
        Me.ListadoGrid.TabIndex = 239
        Me.ListadoGrid.Visible = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 242
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 2
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
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
        Me.inicioButton.Location = New System.Drawing.Point(640, 3)
        Me.inicioButton.Name = "inicioButton"
        Me.inicioButton.Size = New System.Drawing.Size(45, 45)
        Me.inicioButton.TabIndex = 236
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
        Me.Title.Size = New System.Drawing.Size(629, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "PETL"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PETL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ListadoGrid)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PETL"
        Me.Text = "PETL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ListadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliasPETLLink As System.Windows.Forms.LinkLabel
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents añoL As System.Windows.Forms.Label
    Friend WithEvents CandidatosLink As System.Windows.Forms.LinkLabel
    Friend WithEvents participantesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents participantesL As System.Windows.Forms.Label
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents ListadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
