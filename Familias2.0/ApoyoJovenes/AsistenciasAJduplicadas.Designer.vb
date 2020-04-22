<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsistenciasAJduplicadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsistenciasAJduplicadas))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.GenerarButton = New System.Windows.Forms.Button()
        Me.TipoList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AñoV = New System.Windows.Forms.TextBox()
        Me.ListGrid = New System.Windows.Forms.DataGridView()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.AñoL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GenerarButton, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoList, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoV, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 35)
        Me.TableLayoutPanel1.TabIndex = 240
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.BackColor = System.Drawing.Color.Transparent
        Me.AñoL.ForeColor = System.Drawing.Color.Black
        Me.AñoL.Location = New System.Drawing.Point(3, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(35, 16)
        Me.AñoL.TabIndex = 69
        Me.AñoL.Text = "Año:"
        '
        'GenerarButton
        '
        Me.GenerarButton.Location = New System.Drawing.Point(667, 3)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(114, 29)
        Me.GenerarButton.TabIndex = 45
        Me.GenerarButton.Text = "Generar Listado"
        Me.GenerarButton.UseVisualStyleBackColor = True
        '
        'TipoList
        '
        Me.TipoList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoList.FormattingEnabled = True
        Me.TipoList.Location = New System.Drawing.Point(389, 3)
        Me.TipoList.Name = "TipoList"
        Me.TipoList.Size = New System.Drawing.Size(272, 24)
        Me.TipoList.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(323, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Actividad"
        '
        'AñoV
        '
        Me.AñoV.Location = New System.Drawing.Point(44, 3)
        Me.AñoV.Name = "AñoV"
        Me.AñoV.Size = New System.Drawing.Size(100, 22)
        Me.AñoV.TabIndex = 70
        '
        'ListGrid
        '
        Me.ListGrid.AllowUserToAddRows = False
        Me.ListGrid.AllowUserToDeleteRows = False
        Me.ListGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListGrid.Location = New System.Drawing.Point(0, 178)
        Me.ListGrid.Name = "ListGrid"
        Me.ListGrid.ReadOnly = True
        Me.ListGrid.RowHeadersWidth = 28
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListGrid.Size = New System.Drawing.Size(782, 581)
        Me.ListGrid.TabIndex = 242
        Me.ListGrid.Visible = False
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Navy
        Me.TotalL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.ForeColor = System.Drawing.Color.White
        Me.TotalL.Location = New System.Drawing.Point(4, 158)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(16, 17)
        Me.TotalL.TabIndex = 241
        Me.TotalL.Text = "_"
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
        Me.bannerPanel.TabIndex = 253
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
        Me.Title.Text = "Listado de Asistencias Duplicadas "
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AsistenciasAJduplicadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ListGrid)
        Me.Controls.Add(Me.TotalL)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AsistenciasAJduplicadas"
        Me.Text = "Asistencias AJ duplicadas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents GenerarButton As System.Windows.Forms.Button
    Friend WithEvents TipoList As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AñoV As System.Windows.Forms.TextBox
    Friend WithEvents ListGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
