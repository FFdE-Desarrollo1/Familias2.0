<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaInfoEduc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaInfoEduc))
        Me.TotalL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.DataGridListado = New System.Windows.Forms.DataGridView()
        Me.CamposPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ExcepcionEstadoCombo = New System.Windows.Forms.ComboBox()
        Me.ExcepcionL = New System.Windows.Forms.Label()
        Me.TipoAfilL = New System.Windows.Forms.Label()
        Me.CbCarrera = New System.Windows.Forms.ComboBox()
        Me.EscuelaL = New System.Windows.Forms.Label()
        Me.CarreraL = New System.Windows.Forms.Label()
        Me.TiposL = New System.Windows.Forms.Label()
        Me.ChApadrinados = New System.Windows.Forms.CheckBox()
        Me.AñoL = New System.Windows.Forms.Label()
        Me.TbAño = New System.Windows.Forms.TextBox()
        Me.EstadoEducL = New System.Windows.Forms.Label()
        Me.GradoL = New System.Windows.Forms.Label()
        Me.NivelEducL = New System.Windows.Forms.Label()
        Me.CbEscuela = New System.Windows.Forms.ComboBox()
        Me.CbTipoEscuela = New System.Windows.Forms.ComboBox()
        Me.TipoEscuelaL = New System.Windows.Forms.Label()
        Me.CbEstadoEduc = New System.Windows.Forms.ComboBox()
        Me.CbGrado = New System.Windows.Forms.ComboBox()
        Me.CbNivelEduc = New System.Windows.Forms.ComboBox()
        Me.CbTipoAfil = New System.Windows.Forms.ComboBox()
        Me.CbPueblo = New System.Windows.Forms.ComboBox()
        Me.CbMaestro = New System.Windows.Forms.ComboBox()
        Me.PuebloL = New System.Windows.Forms.Label()
        Me.MaestroL = New System.Windows.Forms.Label()
        Me.ChDesafiliados = New System.Windows.Forms.CheckBox()
        Me.ChGraduados = New System.Windows.Forms.CheckBox()
        Me.BusquedaPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OtraInfoLink = New System.Windows.Forms.LinkLabel()
        Me.otrasBusquedasL = New System.Windows.Forms.Label()
        Me.buscarButton = New System.Windows.Forms.Button()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        CType(Me.DataGridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CamposPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.BusquedaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalL
        '
        Me.TotalL.AutoSize = True
        Me.TotalL.BackColor = System.Drawing.Color.Navy
        Me.TotalL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalL.ForeColor = System.Drawing.Color.White
        Me.TotalL.Location = New System.Drawing.Point(13, 125)
        Me.TotalL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalL.Name = "TotalL"
        Me.TotalL.Size = New System.Drawing.Size(46, 17)
        Me.TotalL.TabIndex = 246
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
        Me.bannerPanel.TabIndex = 248
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
        Me.Title.Text = "Busqueda por Información de Educación"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridListado
        '
        Me.DataGridListado.AllowUserToAddRows = False
        Me.DataGridListado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridListado.BackgroundColor = System.Drawing.Color.White
        Me.DataGridListado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridListado.Location = New System.Drawing.Point(13, 146)
        Me.DataGridListado.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridListado.Name = "DataGridListado"
        Me.DataGridListado.ReadOnly = True
        Me.DataGridListado.RowHeadersWidth = 40
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridListado.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridListado.Size = New System.Drawing.Size(748, 585)
        Me.DataGridListado.TabIndex = 249
        Me.DataGridListado.Visible = False
        '
        'CamposPanel
        '
        Me.CamposPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CamposPanel.BackColor = System.Drawing.Color.Transparent
        Me.CamposPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CamposPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.CamposPanel.Controls.Add(Me.BusquedaPanel)
        Me.CamposPanel.Controls.Add(Me.buscarButton)
        Me.CamposPanel.Location = New System.Drawing.Point(29, 166)
        Me.CamposPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CamposPanel.Name = "CamposPanel"
        Me.CamposPanel.Size = New System.Drawing.Size(708, 523)
        Me.CamposPanel.TabIndex = 250
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.ExcepcionEstadoCombo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ExcepcionL, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoAfilL, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.CbCarrera, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.EscuelaL, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CarreraL, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TiposL, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ChApadrinados, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AñoL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TbAño, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EstadoEducL, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GradoL, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.NivelEducL, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CbEscuela, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CbTipoEscuela, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.TipoEscuelaL, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.CbEstadoEduc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CbGrado, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CbNivelEduc, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CbTipoAfil, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.CbPueblo, 1, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.CbMaestro, 1, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.PuebloL, 0, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.MaestroL, 0, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.ChDesafiliados, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ChGraduados, 3, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 19
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(675, 354)
        Me.TableLayoutPanel1.TabIndex = 249
        '
        'ExcepcionEstadoCombo
        '
        Me.ExcepcionEstadoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExcepcionEstadoCombo.FormattingEnabled = True
        Me.ExcepcionEstadoCombo.Location = New System.Drawing.Point(168, 66)
        Me.ExcepcionEstadoCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.ExcepcionEstadoCombo.Name = "ExcepcionEstadoCombo"
        Me.ExcepcionEstadoCombo.Size = New System.Drawing.Size(256, 24)
        Me.ExcepcionEstadoCombo.TabIndex = 249
        Me.ExcepcionEstadoCombo.TabStop = False
        '
        'ExcepcionL
        '
        Me.ExcepcionL.AutoSize = True
        Me.ExcepcionL.BackColor = System.Drawing.Color.Transparent
        Me.ExcepcionL.Location = New System.Drawing.Point(4, 62)
        Me.ExcepcionL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExcepcionL.Name = "ExcepcionL"
        Me.ExcepcionL.Size = New System.Drawing.Size(156, 16)
        Me.ExcepcionL.TabIndex = 249
        Me.ExcepcionL.Text = "Excepción Estado Educ.:"
        '
        'TipoAfilL
        '
        Me.TipoAfilL.AutoSize = True
        Me.TipoAfilL.BackColor = System.Drawing.Color.Transparent
        Me.TipoAfilL.Location = New System.Drawing.Point(4, 254)
        Me.TipoAfilL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TipoAfilL.Name = "TipoAfilL"
        Me.TipoAfilL.Size = New System.Drawing.Size(91, 16)
        Me.TipoAfilL.TabIndex = 235
        Me.TipoAfilL.Text = "Tipo Afiliación:"
        '
        'CbCarrera
        '
        Me.CbCarrera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbCarrera.FormattingEnabled = True
        Me.CbCarrera.Location = New System.Drawing.Point(168, 162)
        Me.CbCarrera.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCarrera.Name = "CbCarrera"
        Me.CbCarrera.Size = New System.Drawing.Size(256, 24)
        Me.CbCarrera.TabIndex = 5
        '
        'EscuelaL
        '
        Me.EscuelaL.AutoSize = True
        Me.EscuelaL.BackColor = System.Drawing.Color.Transparent
        Me.EscuelaL.Location = New System.Drawing.Point(4, 190)
        Me.EscuelaL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EscuelaL.Name = "EscuelaL"
        Me.EscuelaL.Size = New System.Drawing.Size(59, 16)
        Me.EscuelaL.TabIndex = 226
        Me.EscuelaL.Text = "Escuela:"
        '
        'CarreraL
        '
        Me.CarreraL.AutoSize = True
        Me.CarreraL.BackColor = System.Drawing.Color.Transparent
        Me.CarreraL.Location = New System.Drawing.Point(4, 158)
        Me.CarreraL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CarreraL.Name = "CarreraL"
        Me.CarreraL.Size = New System.Drawing.Size(54, 16)
        Me.CarreraL.TabIndex = 226
        Me.CarreraL.Text = "Carrera:"
        '
        'TiposL
        '
        Me.TiposL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TiposL.AutoSize = True
        Me.TiposL.BackColor = System.Drawing.Color.Navy
        Me.TiposL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiposL.ForeColor = System.Drawing.Color.White
        Me.TiposL.Location = New System.Drawing.Point(545, 0)
        Me.TiposL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TiposL.Name = "TiposL"
        Me.TiposL.Size = New System.Drawing.Size(126, 20)
        Me.TiposL.TabIndex = 223
        Me.TiposL.Text = "Tipo de Miembro"
        Me.TiposL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChApadrinados
        '
        Me.ChApadrinados.AutoSize = True
        Me.ChApadrinados.BackColor = System.Drawing.Color.Transparent
        Me.ChApadrinados.Checked = True
        Me.ChApadrinados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChApadrinados.ForeColor = System.Drawing.Color.Navy
        Me.ChApadrinados.Location = New System.Drawing.Point(545, 34)
        Me.ChApadrinados.Margin = New System.Windows.Forms.Padding(4)
        Me.ChApadrinados.Name = "ChApadrinados"
        Me.ChApadrinados.Size = New System.Drawing.Size(92, 20)
        Me.ChApadrinados.TabIndex = 11
        Me.ChApadrinados.Text = "Apadrinado"
        Me.ChApadrinados.UseVisualStyleBackColor = False
        '
        'AñoL
        '
        Me.AñoL.AutoSize = True
        Me.AñoL.BackColor = System.Drawing.Color.Transparent
        Me.AñoL.Location = New System.Drawing.Point(4, 0)
        Me.AñoL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AñoL.Name = "AñoL"
        Me.AñoL.Size = New System.Drawing.Size(35, 16)
        Me.AñoL.TabIndex = 222
        Me.AñoL.Text = "Año:"
        '
        'TbAño
        '
        Me.TbAño.Location = New System.Drawing.Point(168, 4)
        Me.TbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(62, 22)
        Me.TbAño.TabIndex = 1
        '
        'EstadoEducL
        '
        Me.EstadoEducL.AutoSize = True
        Me.EstadoEducL.BackColor = System.Drawing.Color.Transparent
        Me.EstadoEducL.Location = New System.Drawing.Point(4, 30)
        Me.EstadoEducL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EstadoEducL.Name = "EstadoEducL"
        Me.EstadoEducL.Size = New System.Drawing.Size(136, 16)
        Me.EstadoEducL.TabIndex = 223
        Me.EstadoEducL.Text = "Estado de Educación:"
        '
        'GradoL
        '
        Me.GradoL.AutoSize = True
        Me.GradoL.BackColor = System.Drawing.Color.Transparent
        Me.GradoL.Location = New System.Drawing.Point(4, 94)
        Me.GradoL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GradoL.Name = "GradoL"
        Me.GradoL.Size = New System.Drawing.Size(47, 16)
        Me.GradoL.TabIndex = 224
        Me.GradoL.Text = "Grado:"
        '
        'NivelEducL
        '
        Me.NivelEducL.AutoSize = True
        Me.NivelEducL.BackColor = System.Drawing.Color.Transparent
        Me.NivelEducL.Location = New System.Drawing.Point(4, 126)
        Me.NivelEducL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NivelEducL.Name = "NivelEducL"
        Me.NivelEducL.Size = New System.Drawing.Size(122, 16)
        Me.NivelEducL.TabIndex = 225
        Me.NivelEducL.Text = "Nivel de Educación:"
        '
        'CbEscuela
        '
        Me.CbEscuela.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbEscuela.FormattingEnabled = True
        Me.CbEscuela.Location = New System.Drawing.Point(168, 194)
        Me.CbEscuela.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEscuela.Name = "CbEscuela"
        Me.CbEscuela.Size = New System.Drawing.Size(256, 24)
        Me.CbEscuela.TabIndex = 6
        '
        'CbTipoEscuela
        '
        Me.CbTipoEscuela.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbTipoEscuela.FormattingEnabled = True
        Me.CbTipoEscuela.Location = New System.Drawing.Point(168, 226)
        Me.CbTipoEscuela.Margin = New System.Windows.Forms.Padding(4)
        Me.CbTipoEscuela.Name = "CbTipoEscuela"
        Me.CbTipoEscuela.Size = New System.Drawing.Size(256, 24)
        Me.CbTipoEscuela.TabIndex = 7
        '
        'TipoEscuelaL
        '
        Me.TipoEscuelaL.AutoSize = True
        Me.TipoEscuelaL.BackColor = System.Drawing.Color.Transparent
        Me.TipoEscuelaL.Location = New System.Drawing.Point(4, 222)
        Me.TipoEscuelaL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TipoEscuelaL.Name = "TipoEscuelaL"
        Me.TipoEscuelaL.Size = New System.Drawing.Size(87, 16)
        Me.TipoEscuelaL.TabIndex = 232
        Me.TipoEscuelaL.Text = "Tipo Escuela:"
        '
        'CbEstadoEduc
        '
        Me.CbEstadoEduc.FormattingEnabled = True
        Me.CbEstadoEduc.Location = New System.Drawing.Point(168, 34)
        Me.CbEstadoEduc.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEstadoEduc.Name = "CbEstadoEduc"
        Me.CbEstadoEduc.Size = New System.Drawing.Size(256, 24)
        Me.CbEstadoEduc.TabIndex = 2
        '
        'CbGrado
        '
        Me.CbGrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbGrado.FormattingEnabled = True
        Me.CbGrado.Location = New System.Drawing.Point(168, 98)
        Me.CbGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.CbGrado.Name = "CbGrado"
        Me.CbGrado.Size = New System.Drawing.Size(256, 24)
        Me.CbGrado.TabIndex = 3
        Me.CbGrado.TabStop = False
        '
        'CbNivelEduc
        '
        Me.CbNivelEduc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbNivelEduc.FormattingEnabled = True
        Me.CbNivelEduc.Location = New System.Drawing.Point(168, 130)
        Me.CbNivelEduc.Margin = New System.Windows.Forms.Padding(4)
        Me.CbNivelEduc.Name = "CbNivelEduc"
        Me.CbNivelEduc.Size = New System.Drawing.Size(256, 24)
        Me.CbNivelEduc.TabIndex = 4
        Me.CbNivelEduc.TabStop = False
        '
        'CbTipoAfil
        '
        Me.CbTipoAfil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbTipoAfil.FormattingEnabled = True
        Me.CbTipoAfil.Location = New System.Drawing.Point(168, 258)
        Me.CbTipoAfil.Margin = New System.Windows.Forms.Padding(4)
        Me.CbTipoAfil.Name = "CbTipoAfil"
        Me.CbTipoAfil.Size = New System.Drawing.Size(256, 24)
        Me.CbTipoAfil.TabIndex = 8
        '
        'CbPueblo
        '
        Me.CbPueblo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPueblo.FormattingEnabled = True
        Me.CbPueblo.Location = New System.Drawing.Point(168, 322)
        Me.CbPueblo.Margin = New System.Windows.Forms.Padding(4)
        Me.CbPueblo.Name = "CbPueblo"
        Me.CbPueblo.Size = New System.Drawing.Size(256, 24)
        Me.CbPueblo.TabIndex = 10
        '
        'CbMaestro
        '
        Me.CbMaestro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbMaestro.FormattingEnabled = True
        Me.CbMaestro.Location = New System.Drawing.Point(168, 290)
        Me.CbMaestro.Margin = New System.Windows.Forms.Padding(4)
        Me.CbMaestro.Name = "CbMaestro"
        Me.CbMaestro.Size = New System.Drawing.Size(256, 24)
        Me.CbMaestro.TabIndex = 9
        '
        'PuebloL
        '
        Me.PuebloL.AutoSize = True
        Me.PuebloL.BackColor = System.Drawing.Color.Transparent
        Me.PuebloL.Location = New System.Drawing.Point(4, 318)
        Me.PuebloL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PuebloL.Name = "PuebloL"
        Me.PuebloL.Size = New System.Drawing.Size(52, 16)
        Me.PuebloL.TabIndex = 238
        Me.PuebloL.Text = "Pueblo:"
        '
        'MaestroL
        '
        Me.MaestroL.AutoSize = True
        Me.MaestroL.BackColor = System.Drawing.Color.Transparent
        Me.MaestroL.Location = New System.Drawing.Point(4, 286)
        Me.MaestroL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaestroL.Name = "MaestroL"
        Me.MaestroL.Size = New System.Drawing.Size(59, 16)
        Me.MaestroL.TabIndex = 239
        Me.MaestroL.Text = "Maestro:"
        '
        'ChDesafiliados
        '
        Me.ChDesafiliados.AutoSize = True
        Me.ChDesafiliados.BackColor = System.Drawing.Color.Transparent
        Me.ChDesafiliados.ForeColor = System.Drawing.Color.Purple
        Me.ChDesafiliados.Location = New System.Drawing.Point(545, 66)
        Me.ChDesafiliados.Margin = New System.Windows.Forms.Padding(4)
        Me.ChDesafiliados.Name = "ChDesafiliados"
        Me.ChDesafiliados.Size = New System.Drawing.Size(90, 20)
        Me.ChDesafiliados.TabIndex = 12
        Me.ChDesafiliados.Text = "Desafiliado"
        Me.ChDesafiliados.UseVisualStyleBackColor = False
        '
        'ChGraduados
        '
        Me.ChGraduados.AutoSize = True
        Me.ChGraduados.BackColor = System.Drawing.Color.Transparent
        Me.ChGraduados.ForeColor = System.Drawing.Color.Purple
        Me.ChGraduados.Location = New System.Drawing.Point(545, 98)
        Me.ChGraduados.Margin = New System.Windows.Forms.Padding(4)
        Me.ChGraduados.Name = "ChGraduados"
        Me.ChGraduados.Size = New System.Drawing.Size(83, 20)
        Me.ChGraduados.TabIndex = 13
        Me.ChGraduados.Text = "Graduado"
        Me.ChGraduados.UseVisualStyleBackColor = False
        '
        'BusquedaPanel
        '
        Me.BusquedaPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BusquedaPanel.BackColor = System.Drawing.Color.Transparent
        Me.BusquedaPanel.ColumnCount = 2
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaPanel.Controls.Add(Me.OtraInfoLink, 0, 1)
        Me.BusquedaPanel.Controls.Add(Me.otrasBusquedasL, 0, 0)
        Me.BusquedaPanel.Location = New System.Drawing.Point(3, 455)
        Me.BusquedaPanel.Name = "BusquedaPanel"
        Me.BusquedaPanel.RowCount = 2
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.BusquedaPanel.Size = New System.Drawing.Size(697, 49)
        Me.BusquedaPanel.TabIndex = 15
        '
        'OtraInfoLink
        '
        Me.OtraInfoLink.ActiveLinkColor = System.Drawing.Color.Fuchsia
        Me.OtraInfoLink.AutoSize = True
        Me.OtraInfoLink.BackColor = System.Drawing.Color.Purple
        Me.OtraInfoLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtraInfoLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OtraInfoLink.LinkColor = System.Drawing.Color.White
        Me.OtraInfoLink.Location = New System.Drawing.Point(3, 28)
        Me.OtraInfoLink.Name = "OtraInfoLink"
        Me.OtraInfoLink.Size = New System.Drawing.Size(143, 17)
        Me.OtraInfoLink.TabIndex = 0
        Me.OtraInfoLink.TabStop = True
        Me.OtraInfoLink.Text = "por Otra Información"
        Me.OtraInfoLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'otrasBusquedasL
        '
        Me.otrasBusquedasL.AutoSize = True
        Me.otrasBusquedasL.BackColor = System.Drawing.Color.Navy
        Me.otrasBusquedasL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otrasBusquedasL.ForeColor = System.Drawing.Color.White
        Me.otrasBusquedasL.Location = New System.Drawing.Point(3, 0)
        Me.otrasBusquedasL.Name = "otrasBusquedasL"
        Me.otrasBusquedasL.Size = New System.Drawing.Size(155, 17)
        Me.otrasBusquedasL.TabIndex = 13
        Me.otrasBusquedasL.Text = "OTRAS BUSQUEDAS"
        '
        'buscarButton
        '
        Me.buscarButton.BackColor = System.Drawing.Color.White
        Me.buscarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.searchFam
        Me.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.buscarButton.Location = New System.Drawing.Point(20, 379)
        Me.buscarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.buscarButton.Name = "buscarButton"
        Me.buscarButton.Size = New System.Drawing.Size(59, 48)
        Me.buscarButton.TabIndex = 13
        Me.buscarButton.UseVisualStyleBackColor = False
        '
        'BusquedaInfoEduc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 749)
        Me.Controls.Add(Me.CamposPanel)
        Me.Controls.Add(Me.DataGridListado)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TotalL)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "BusquedaInfoEduc"
        Me.Text = "Busqueda Info. Educ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        CType(Me.DataGridListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CamposPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.BusquedaPanel.ResumeLayout(False)
        Me.BusquedaPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents DataGridListado As System.Windows.Forms.DataGridView
    Friend WithEvents CamposPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ExcepcionEstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ExcepcionL As System.Windows.Forms.Label
    Friend WithEvents TipoAfilL As System.Windows.Forms.Label
    Friend WithEvents CbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents EscuelaL As System.Windows.Forms.Label
    Friend WithEvents CarreraL As System.Windows.Forms.Label
    Friend WithEvents TiposL As System.Windows.Forms.Label
    Friend WithEvents ChApadrinados As System.Windows.Forms.CheckBox
    Friend WithEvents AñoL As System.Windows.Forms.Label
    Friend WithEvents TbAño As System.Windows.Forms.TextBox
    Friend WithEvents EstadoEducL As System.Windows.Forms.Label
    Friend WithEvents GradoL As System.Windows.Forms.Label
    Friend WithEvents NivelEducL As System.Windows.Forms.Label
    Friend WithEvents CbEscuela As System.Windows.Forms.ComboBox
    Friend WithEvents CbTipoEscuela As System.Windows.Forms.ComboBox
    Friend WithEvents TipoEscuelaL As System.Windows.Forms.Label
    Friend WithEvents CbEstadoEduc As System.Windows.Forms.ComboBox
    Friend WithEvents CbGrado As System.Windows.Forms.ComboBox
    Friend WithEvents CbNivelEduc As System.Windows.Forms.ComboBox
    Friend WithEvents CbTipoAfil As System.Windows.Forms.ComboBox
    Friend WithEvents CbPueblo As System.Windows.Forms.ComboBox
    Friend WithEvents CbMaestro As System.Windows.Forms.ComboBox
    Friend WithEvents PuebloL As System.Windows.Forms.Label
    Friend WithEvents MaestroL As System.Windows.Forms.Label
    Friend WithEvents ChDesafiliados As System.Windows.Forms.CheckBox
    Friend WithEvents ChGraduados As System.Windows.Forms.CheckBox
    Friend WithEvents BusquedaPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OtraInfoLink As System.Windows.Forms.LinkLabel
    Friend WithEvents otrasBusquedasL As System.Windows.Forms.Label
    Friend WithEvents buscarButton As System.Windows.Forms.Button
End Class
