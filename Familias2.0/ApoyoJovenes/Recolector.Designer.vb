<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recolector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recolector))
        Me.TipoMiembro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.j = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.i = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.h = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.e = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalL = New System.Windows.Forms.Label()
        Me.TotalV = New System.Windows.Forms.TextBox()
        Me.NotesL = New System.Windows.Forms.Label()
        Me.DuplicadosV = New System.Windows.Forms.TextBox()
        Me.NotesV = New System.Windows.Forms.TextBox()
        Me.d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duplicados = New System.Windows.Forms.Button()
        Me.ListGrid = New System.Windows.Forms.DataGridView()
        Me.a = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Edadv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.UploadButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TipoMiembro
        '
        Me.TipoMiembro.HeaderText = "Tipo Miembro"
        Me.TipoMiembro.Name = "TipoMiembro"
        Me.TipoMiembro.Width = 111
        '
        'j
        '
        Me.j.HeaderText = "Responsable"
        Me.j.Name = "j"
        Me.j.Width = 108
        '
        'i
        '
        DataGridViewCellStyle1.Format = "f"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.i.DefaultCellStyle = DataGridViewCellStyle1
        Me.i.HeaderText = "i"
        Me.i.Name = "i"
        Me.i.Width = 36
        '
        'h
        '
        Me.h.HeaderText = "Actividad"
        Me.h.Name = "h"
        Me.h.Width = 85
        '
        'g
        '
        Me.g.HeaderText = "Fecha/Hora"
        Me.g.Name = "g"
        '
        'k
        '
        Me.k.HeaderText = "Nombre"
        Me.k.Name = "k"
        Me.k.Width = 78
        '
        'f
        '
        Me.f.HeaderText = "f"
        Me.f.Name = "f"
        Me.f.Width = 36
        '
        'e
        '
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.e.DefaultCellStyle = DataGridViewCellStyle2
        Me.e.HeaderText = "e"
        Me.e.Name = "e"
        Me.e.Width = 40
        '
        'TotalL
        '
        Me.TotalL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Transparent
        Me.TotalL.Location = New System.Drawing.Point(3, 0)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(124, 16)
        Me.TotalL.TabIndex = 227
        Me.TotalL.Text = "Registros cargados:"
        '
        'TotalV
        '
        Me.TotalV.Location = New System.Drawing.Point(133, 3)
        Me.TotalV.Name = "TotalV"
        Me.TotalV.ReadOnly = True
        Me.TotalV.Size = New System.Drawing.Size(32, 22)
        Me.TotalV.TabIndex = 224
        '
        'NotesL
        '
        Me.NotesL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesL.AutoSize = True
        Me.NotesL.BackColor = System.Drawing.Color.Transparent
        Me.NotesL.Location = New System.Drawing.Point(481, 0)
        Me.NotesL.Name = "NotesL"
        Me.NotesL.Size = New System.Drawing.Size(93, 16)
        Me.NotesL.TabIndex = 225
        Me.NotesL.Text = "Observaciones"
        '
        'DuplicadosV
        '
        Me.DuplicadosV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DuplicadosV.Location = New System.Drawing.Point(133, 34)
        Me.DuplicadosV.Name = "DuplicadosV"
        Me.DuplicadosV.ReadOnly = True
        Me.DuplicadosV.Size = New System.Drawing.Size(255, 22)
        Me.DuplicadosV.TabIndex = 228
        '
        'NotesV
        '
        Me.NotesV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesV.Location = New System.Drawing.Point(580, 3)
        Me.NotesV.MaxLength = 120
        Me.NotesV.Name = "NotesV"
        Me.NotesV.Size = New System.Drawing.Size(201, 22)
        Me.NotesV.TabIndex = 223
        '
        'd
        '
        Me.d.HeaderText = "No. Miembro"
        Me.d.Name = "d"
        Me.d.Width = 107
        '
        'c
        '
        Me.c.HeaderText = "c"
        Me.c.Name = "c"
        Me.c.Width = 40
        '
        'b
        '
        Me.b.HeaderText = "b"
        Me.b.Name = "b"
        Me.b.Width = 40
        '
        'Duplicados
        '
        Me.Duplicados.BackColor = System.Drawing.Color.Khaki
        Me.Duplicados.ForeColor = System.Drawing.Color.Black
        Me.Duplicados.Location = New System.Drawing.Point(3, 34)
        Me.Duplicados.Name = "Duplicados"
        Me.Duplicados.Size = New System.Drawing.Size(106, 26)
        Me.Duplicados.TabIndex = 226
        Me.Duplicados.Text = "Duplicados"
        Me.Duplicados.UseVisualStyleBackColor = False
        '
        'ListGrid
        '
        Me.ListGrid.AllowUserToAddRows = False
        Me.ListGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ListGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListGrid.BackgroundColor = System.Drawing.Color.White
        Me.ListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.a, Me.b, Me.c, Me.d, Me.e, Me.f, Me.k, Me.g, Me.h, Me.i, Me.j, Me.Edadv, Me.TipoMiembro})
        Me.ListGrid.Location = New System.Drawing.Point(0, 186)
        Me.ListGrid.Name = "ListGrid"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListGrid.Size = New System.Drawing.Size(784, 562)
        Me.ListGrid.TabIndex = 240
        Me.ListGrid.Visible = False
        '
        'a
        '
        Me.a.HeaderText = "Agregar"
        Me.a.Name = "a"
        Me.a.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.a.Width = 78
        '
        'Edadv
        '
        Me.Edadv.HeaderText = "Edad"
        Me.Edadv.Name = "Edadv"
        Me.Edadv.Width = 63
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TotalL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalV, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NotesL, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DuplicadosV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NotesV, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Duplicados, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 120)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 63)
        Me.TableLayoutPanel1.TabIndex = 239
        Me.TableLayoutPanel1.Visible = False
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
        Me.opcionesTable.ColumnCount = 5
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.UploadButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'UploadButton
        '
        Me.UploadButton.BackColor = System.Drawing.Color.White
        Me.UploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UploadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadButton.ForeColor = System.Drawing.Color.OrangeRed
        Me.UploadButton.Image = Global.Familias2._0.My.Resources.Resources.searchFam
        Me.UploadButton.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.UploadButton.Location = New System.Drawing.Point(549, 3)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(82, 46)
        Me.UploadButton.TabIndex = 236
        Me.UploadButton.Text = "Buscar Archivo"
        Me.UploadButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.UploadButton.UseVisualStyleBackColor = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(494, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(443, 3)
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
        Me.GuardarButton.Location = New System.Drawing.Point(637, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 236
        Me.GuardarButton.UseVisualStyleBackColor = False
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
        Me.Title.Size = New System.Drawing.Size(432, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Carga de Asistencia - Recolector"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Recolector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.ListGrid)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Recolector"
        Me.Text = "Recolector"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TipoMiembro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents j As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents i As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents h As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents k As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents f As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents e As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents TotalV As System.Windows.Forms.TextBox
    Friend WithEvents NotesL As System.Windows.Forms.Label
    Friend WithEvents DuplicadosV As System.Windows.Forms.TextBox
    Friend WithEvents NotesV As System.Windows.Forms.TextBox
    Friend WithEvents d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents b As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duplicados As System.Windows.Forms.Button
    Friend WithEvents ListGrid As System.Windows.Forms.DataGridView
    Friend WithEvents a As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Edadv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UploadButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
