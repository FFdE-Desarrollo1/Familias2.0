<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarSolicitud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarSolicitud))
        Me.xL = New System.Windows.Forms.Label()
        Me.Table2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FotoFV = New System.Windows.Forms.TextBox()
        Me.VisitaPicker = New System.Windows.Forms.DateTimePicker()
        Me.VisitaL = New System.Windows.Forms.Label()
        Me.VerCarpetaButton = New System.Windows.Forms.Button()
        Me.BrigadaV = New System.Windows.Forms.TextBox()
        Me.BrigadaL = New System.Windows.Forms.Label()
        Me.FotoInicialButton = New System.Windows.Forms.Button()
        Me.ConstruccionPicker = New System.Windows.Forms.DateTimePicker()
        Me.ConstruccionL = New System.Windows.Forms.Label()
        Me.FotoFinalButton = New System.Windows.Forms.Button()
        Me.EntregaL = New System.Windows.Forms.Label()
        Me.EntregaPicker = New System.Windows.Forms.DateTimePicker()
        Me.FotoIV = New System.Windows.Forms.TextBox()
        Me.horasTL = New System.Windows.Forms.Label()
        Me.TotalHorasV = New System.Windows.Forms.TextBox()
        Me.ListadoT = New System.Windows.Forms.Label()
        Me.SolicitudL = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TechoCombo = New System.Windows.Forms.ComboBox()
        Me.ParedCombo = New System.Windows.Forms.ComboBox()
        Me.ParedL = New System.Windows.Forms.Label()
        Me.techoL = New System.Windows.Forms.Label()
        Me.SolicitaCombo = New System.Windows.Forms.ComboBox()
        Me.SolicitaL = New System.Windows.Forms.Label()
        Me.CantidadL = New System.Windows.Forms.Label()
        Me.CantidadV = New System.Windows.Forms.TextBox()
        Me.DimensionXV = New System.Windows.Forms.TextBox()
        Me.DimensionYV = New System.Windows.Forms.TextBox()
        Me.DimensionL = New System.Windows.Forms.Label()
        Me.PisoL = New System.Windows.Forms.Label()
        Me.PisoCombo = New System.Windows.Forms.ComboBox()
        Me.complementoInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotasPAV = New System.Windows.Forms.Label()
        Me.FechaPAV = New System.Windows.Forms.Label()
        Me.AplicaPAV = New System.Windows.Forms.Label()
        Me.aplicaPAL = New System.Windows.Forms.Label()
        Me.fechaPAL = New System.Windows.Forms.Label()
        Me.notasPAL = New System.Windows.Forms.Label()
        Me.listadoGrid = New System.Windows.Forms.DataGridView()
        Me.PreAnalisisL = New System.Windows.Forms.Label()
        Me.SolPanel = New System.Windows.Forms.Panel()
        Me.SolTable1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EstadoPicker = New System.Windows.Forms.DateTimePicker()
        Me.fEstadoL = New System.Windows.Forms.Label()
        Me.FechaV = New System.Windows.Forms.DateTimePicker()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.ExoneradaCheck = New System.Windows.Forms.CheckBox()
        Me.HorasV = New System.Windows.Forms.TextBox()
        Me.HorasL = New System.Windows.Forms.Label()
        Me.EstadoV = New System.Windows.Forms.ComboBox()
        Me.EstadoL = New System.Windows.Forms.Label()
        Me.UsuarioL = New System.Windows.Forms.Label()
        Me.UsuarioV = New System.Windows.Forms.Label()
        Me.NotasV = New System.Windows.Forms.TextBox()
        Me.NotasL = New System.Windows.Forms.Label()
        Me.ListadoButton = New System.Windows.Forms.Button()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.RegionV = New System.Windows.Forms.Label()
        Me.regionL = New System.Windows.Forms.Label()
        Me.DireccionV = New System.Windows.Forms.Label()
        Me.DireccionL = New System.Windows.Forms.Label()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VerMiembrosL = New System.Windows.Forms.Label()
        Me.VerHorasL = New System.Windows.Forms.Label()
        Me.Table2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.complementoInfoTable.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.listadoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SolPanel.SuspendLayout()
        Me.SolTable1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'xL
        '
        Me.xL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xL.AutoSize = True
        Me.xL.BackColor = System.Drawing.Color.Transparent
        Me.xL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xL.ForeColor = System.Drawing.Color.Black
        Me.xL.Location = New System.Drawing.Point(325, 16)
        Me.xL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.xL.Name = "xL"
        Me.xL.Size = New System.Drawing.Size(15, 16)
        Me.xL.TabIndex = 271
        Me.xL.Text = "x"
        Me.xL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Table2
        '
        Me.Table2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Table2.BackColor = System.Drawing.Color.Gainsboro
        Me.Table2.ColumnCount = 8
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table2.Controls.Add(Me.FotoFV, 5, 2)
        Me.Table2.Controls.Add(Me.VisitaPicker, 1, 0)
        Me.Table2.Controls.Add(Me.VisitaL, 0, 0)
        Me.Table2.Controls.Add(Me.VerCarpetaButton, 3, 2)
        Me.Table2.Controls.Add(Me.BrigadaV, 4, 1)
        Me.Table2.Controls.Add(Me.BrigadaL, 3, 1)
        Me.Table2.Controls.Add(Me.FotoInicialButton, 0, 2)
        Me.Table2.Controls.Add(Me.ConstruccionPicker, 4, 0)
        Me.Table2.Controls.Add(Me.ConstruccionL, 3, 0)
        Me.Table2.Controls.Add(Me.FotoFinalButton, 6, 2)
        Me.Table2.Controls.Add(Me.EntregaL, 6, 0)
        Me.Table2.Controls.Add(Me.EntregaPicker, 7, 0)
        Me.Table2.Controls.Add(Me.FotoIV, 2, 2)
        Me.Table2.Location = New System.Drawing.Point(6, 328)
        Me.Table2.Name = "Table2"
        Me.Table2.RowCount = 3
        Me.Table2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Table2.Size = New System.Drawing.Size(970, 95)
        Me.Table2.TabIndex = 266
        Me.Table2.Visible = False
        '
        'FotoFV
        '
        Me.FotoFV.Location = New System.Drawing.Point(613, 59)
        Me.FotoFV.Name = "FotoFV"
        Me.FotoFV.Size = New System.Drawing.Size(95, 22)
        Me.FotoFV.TabIndex = 276
        Me.FotoFV.Visible = False
        '
        'VisitaPicker
        '
        Me.VisitaPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitaPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VisitaPicker.Location = New System.Drawing.Point(110, 3)
        Me.VisitaPicker.Name = "VisitaPicker"
        Me.VisitaPicker.Size = New System.Drawing.Size(129, 22)
        Me.VisitaPicker.TabIndex = 0
        '
        'VisitaL
        '
        Me.VisitaL.AutoSize = True
        Me.VisitaL.BackColor = System.Drawing.Color.Transparent
        Me.VisitaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisitaL.ForeColor = System.Drawing.Color.Black
        Me.VisitaL.Location = New System.Drawing.Point(2, 0)
        Me.VisitaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VisitaL.Name = "VisitaL"
        Me.VisitaL.Size = New System.Drawing.Size(103, 16)
        Me.VisitaL.TabIndex = 266
        Me.VisitaL.Text = "Visita Ambiente:"
        Me.VisitaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'VerCarpetaButton
        '
        Me.VerCarpetaButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerCarpetaButton.BackColor = System.Drawing.Color.DimGray
        Me.Table2.SetColumnSpan(Me.VerCarpetaButton, 2)
        Me.VerCarpetaButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerCarpetaButton.ForeColor = System.Drawing.Color.White
        Me.VerCarpetaButton.Location = New System.Drawing.Point(346, 59)
        Me.VerCarpetaButton.Name = "VerCarpetaButton"
        Me.VerCarpetaButton.Size = New System.Drawing.Size(261, 33)
        Me.VerCarpetaButton.TabIndex = 272
        Me.VerCarpetaButton.Text = "Ver Carpeta Fotos"
        Me.VerCarpetaButton.UseVisualStyleBackColor = False
        '
        'BrigadaV
        '
        Me.BrigadaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrigadaV.Location = New System.Drawing.Point(478, 31)
        Me.BrigadaV.MaxLength = 100
        Me.BrigadaV.Name = "BrigadaV"
        Me.BrigadaV.Size = New System.Drawing.Size(129, 22)
        Me.BrigadaV.TabIndex = 271
        '
        'BrigadaL
        '
        Me.BrigadaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrigadaL.AutoSize = True
        Me.BrigadaL.BackColor = System.Drawing.Color.Transparent
        Me.BrigadaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrigadaL.ForeColor = System.Drawing.Color.Black
        Me.BrigadaL.Location = New System.Drawing.Point(345, 28)
        Me.BrigadaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BrigadaL.Name = "BrigadaL"
        Me.BrigadaL.Size = New System.Drawing.Size(128, 16)
        Me.BrigadaL.TabIndex = 270
        Me.BrigadaL.Text = "Brigada:"
        Me.BrigadaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FotoInicialButton
        '
        Me.FotoInicialButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FotoInicialButton.BackColor = System.Drawing.Color.SteelBlue
        Me.Table2.SetColumnSpan(Me.FotoInicialButton, 2)
        Me.FotoInicialButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FotoInicialButton.ForeColor = System.Drawing.Color.White
        Me.FotoInicialButton.Location = New System.Drawing.Point(3, 59)
        Me.FotoInicialButton.Name = "FotoInicialButton"
        Me.FotoInicialButton.Size = New System.Drawing.Size(236, 33)
        Me.FotoInicialButton.TabIndex = 273
        Me.FotoInicialButton.Text = "Foto Inicial"
        Me.FotoInicialButton.UseVisualStyleBackColor = False
        '
        'ConstruccionPicker
        '
        Me.ConstruccionPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConstruccionPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConstruccionPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ConstruccionPicker.Location = New System.Drawing.Point(478, 3)
        Me.ConstruccionPicker.Name = "ConstruccionPicker"
        Me.ConstruccionPicker.Size = New System.Drawing.Size(129, 22)
        Me.ConstruccionPicker.TabIndex = 270
        '
        'ConstruccionL
        '
        Me.ConstruccionL.AutoSize = True
        Me.ConstruccionL.BackColor = System.Drawing.Color.Transparent
        Me.ConstruccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConstruccionL.ForeColor = System.Drawing.Color.Black
        Me.ConstruccionL.Location = New System.Drawing.Point(345, 0)
        Me.ConstruccionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ConstruccionL.Name = "ConstruccionL"
        Me.ConstruccionL.Size = New System.Drawing.Size(128, 16)
        Me.ConstruccionL.TabIndex = 270
        Me.ConstruccionL.Text = "Fecha Construcción:"
        Me.ConstruccionL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FotoFinalButton
        '
        Me.FotoFinalButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FotoFinalButton.BackColor = System.Drawing.Color.SteelBlue
        Me.Table2.SetColumnSpan(Me.FotoFinalButton, 2)
        Me.FotoFinalButton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FotoFinalButton.ForeColor = System.Drawing.Color.White
        Me.FotoFinalButton.Location = New System.Drawing.Point(714, 59)
        Me.FotoFinalButton.Name = "FotoFinalButton"
        Me.FotoFinalButton.Size = New System.Drawing.Size(253, 33)
        Me.FotoFinalButton.TabIndex = 274
        Me.FotoFinalButton.Text = "Foto Final"
        Me.FotoFinalButton.UseVisualStyleBackColor = False
        '
        'EntregaL
        '
        Me.EntregaL.AutoSize = True
        Me.EntregaL.BackColor = System.Drawing.Color.Transparent
        Me.EntregaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntregaL.ForeColor = System.Drawing.Color.Black
        Me.EntregaL.Location = New System.Drawing.Point(713, 0)
        Me.EntregaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EntregaL.Name = "EntregaL"
        Me.EntregaL.Size = New System.Drawing.Size(97, 16)
        Me.EntregaL.TabIndex = 271
        Me.EntregaL.Text = "Fecha Entrega:"
        Me.EntregaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EntregaPicker
        '
        Me.EntregaPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntregaPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntregaPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EntregaPicker.Location = New System.Drawing.Point(815, 3)
        Me.EntregaPicker.Name = "EntregaPicker"
        Me.EntregaPicker.Size = New System.Drawing.Size(152, 22)
        Me.EntregaPicker.TabIndex = 271
        '
        'FotoIV
        '
        Me.FotoIV.Location = New System.Drawing.Point(245, 59)
        Me.FotoIV.Name = "FotoIV"
        Me.FotoIV.Size = New System.Drawing.Size(95, 22)
        Me.FotoIV.TabIndex = 275
        Me.FotoIV.Visible = False
        '
        'horasTL
        '
        Me.horasTL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.horasTL.AutoSize = True
        Me.horasTL.BackColor = System.Drawing.Color.Transparent
        Me.horasTL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horasTL.ForeColor = System.Drawing.Color.Black
        Me.horasTL.Location = New System.Drawing.Point(306, 30)
        Me.horasTL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.horasTL.Name = "horasTL"
        Me.horasTL.Size = New System.Drawing.Size(100, 28)
        Me.horasTL.TabIndex = 270
        Me.horasTL.Text = "Hrs. trabajadas:"
        '
        'TotalHorasV
        '
        Me.TotalHorasV.Enabled = False
        Me.TotalHorasV.Location = New System.Drawing.Point(411, 33)
        Me.TotalHorasV.Name = "TotalHorasV"
        Me.TotalHorasV.Size = New System.Drawing.Size(38, 22)
        Me.TotalHorasV.TabIndex = 267
        '
        'ListadoT
        '
        Me.ListadoT.AutoSize = True
        Me.ListadoT.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoT.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ListadoT.Location = New System.Drawing.Point(421, 50)
        Me.ListadoT.Name = "ListadoT"
        Me.ListadoT.Size = New System.Drawing.Size(218, 16)
        Me.ListadoT.TabIndex = 3
        Me.ListadoT.Text = "MIEMBROS MAYORES A 17 AÑOS"
        '
        'SolicitudL
        '
        Me.SolTable1.SetColumnSpan(Me.SolicitudL, 2)
        Me.SolicitudL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitudL.Location = New System.Drawing.Point(3, 58)
        Me.SolicitudL.Name = "SolicitudL"
        Me.SolicitudL.Size = New System.Drawing.Size(160, 18)
        Me.SolicitudL.TabIndex = 265
        Me.SolicitudL.Text = "FAMILIA SOLICITA:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TechoCombo, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ParedCombo, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ParedL, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.techoL, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SolicitaCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SolicitaL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CantidadV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DimensionXV, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.xL, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DimensionYV, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DimensionL, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PisoL, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PisoCombo, 5, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 92)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(962, 51)
        Me.TableLayoutPanel1.TabIndex = 264
        '
        'TechoCombo
        '
        Me.TechoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TechoCombo.Enabled = False
        Me.TechoCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechoCombo.FormattingEnabled = True
        Me.TechoCombo.Location = New System.Drawing.Point(779, 19)
        Me.TechoCombo.Name = "TechoCombo"
        Me.TechoCombo.Size = New System.Drawing.Size(180, 24)
        Me.TechoCombo.TabIndex = 6
        '
        'ParedCombo
        '
        Me.ParedCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParedCombo.Enabled = False
        Me.ParedCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParedCombo.FormattingEnabled = True
        Me.ParedCombo.Location = New System.Drawing.Point(593, 19)
        Me.ParedCombo.Name = "ParedCombo"
        Me.ParedCombo.Size = New System.Drawing.Size(180, 24)
        Me.ParedCombo.TabIndex = 5
        '
        'ParedL
        '
        Me.ParedL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ParedL.AutoSize = True
        Me.ParedL.BackColor = System.Drawing.Color.Transparent
        Me.ParedL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParedL.ForeColor = System.Drawing.Color.Black
        Me.ParedL.Location = New System.Drawing.Point(592, 0)
        Me.ParedL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ParedL.Name = "ParedL"
        Me.ParedL.Size = New System.Drawing.Size(182, 16)
        Me.ParedL.TabIndex = 270
        Me.ParedL.Text = "Pared"
        Me.ParedL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'techoL
        '
        Me.techoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.techoL.AutoSize = True
        Me.techoL.BackColor = System.Drawing.Color.Transparent
        Me.techoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.techoL.ForeColor = System.Drawing.Color.Black
        Me.techoL.Location = New System.Drawing.Point(778, 0)
        Me.techoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.techoL.Name = "techoL"
        Me.techoL.Size = New System.Drawing.Size(182, 16)
        Me.techoL.TabIndex = 270
        Me.techoL.Text = "Techo"
        Me.techoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SolicitaCombo
        '
        Me.SolicitaCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolicitaCombo.Enabled = False
        Me.SolicitaCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitaCombo.FormattingEnabled = True
        Me.SolicitaCombo.Location = New System.Drawing.Point(3, 19)
        Me.SolicitaCombo.Name = "SolicitaCombo"
        Me.SolicitaCombo.Size = New System.Drawing.Size(180, 24)
        Me.SolicitaCombo.TabIndex = 0
        '
        'SolicitaL
        '
        Me.SolicitaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolicitaL.AutoSize = True
        Me.SolicitaL.BackColor = System.Drawing.Color.Transparent
        Me.SolicitaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitaL.ForeColor = System.Drawing.Color.Black
        Me.SolicitaL.Location = New System.Drawing.Point(2, 0)
        Me.SolicitaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SolicitaL.Name = "SolicitaL"
        Me.SolicitaL.Size = New System.Drawing.Size(182, 16)
        Me.SolicitaL.TabIndex = 266
        Me.SolicitaL.Text = "Descripción"
        Me.SolicitaL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CantidadL
        '
        Me.CantidadL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CantidadL.AutoSize = True
        Me.CantidadL.BackColor = System.Drawing.Color.Transparent
        Me.CantidadL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadL.ForeColor = System.Drawing.Color.Black
        Me.CantidadL.Location = New System.Drawing.Point(188, 0)
        Me.CantidadL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CantidadL.Name = "CantidadL"
        Me.CantidadL.Size = New System.Drawing.Size(71, 16)
        Me.CantidadL.TabIndex = 267
        Me.CantidadL.Text = "Cantidad"
        Me.CantidadL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CantidadV
        '
        Me.CantidadV.Enabled = False
        Me.CantidadV.Location = New System.Drawing.Point(189, 19)
        Me.CantidadV.Name = "CantidadV"
        Me.CantidadV.Size = New System.Drawing.Size(69, 22)
        Me.CantidadV.TabIndex = 1
        '
        'DimensionXV
        '
        Me.DimensionXV.Enabled = False
        Me.DimensionXV.Location = New System.Drawing.Point(264, 19)
        Me.DimensionXV.Name = "DimensionXV"
        Me.DimensionXV.Size = New System.Drawing.Size(56, 22)
        Me.DimensionXV.TabIndex = 2
        '
        'DimensionYV
        '
        Me.DimensionYV.Enabled = False
        Me.DimensionYV.Location = New System.Drawing.Point(345, 19)
        Me.DimensionYV.Name = "DimensionYV"
        Me.DimensionYV.Size = New System.Drawing.Size(56, 22)
        Me.DimensionYV.TabIndex = 3
        '
        'DimensionL
        '
        Me.DimensionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DimensionL.AutoSize = True
        Me.DimensionL.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.DimensionL, 3)
        Me.DimensionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DimensionL.ForeColor = System.Drawing.Color.Black
        Me.DimensionL.Location = New System.Drawing.Point(263, 0)
        Me.DimensionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DimensionL.Name = "DimensionL"
        Me.DimensionL.Size = New System.Drawing.Size(139, 16)
        Me.DimensionL.TabIndex = 272
        Me.DimensionL.Text = "Dimensión p/construir"
        Me.DimensionL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PisoL
        '
        Me.PisoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PisoL.AutoSize = True
        Me.PisoL.BackColor = System.Drawing.Color.Transparent
        Me.PisoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PisoL.ForeColor = System.Drawing.Color.Black
        Me.PisoL.Location = New System.Drawing.Point(406, 0)
        Me.PisoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PisoL.Name = "PisoL"
        Me.PisoL.Size = New System.Drawing.Size(182, 16)
        Me.PisoL.TabIndex = 268
        Me.PisoL.Text = "Piso"
        Me.PisoL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PisoCombo
        '
        Me.PisoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PisoCombo.Enabled = False
        Me.PisoCombo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PisoCombo.FormattingEnabled = True
        Me.PisoCombo.Location = New System.Drawing.Point(407, 19)
        Me.PisoCombo.Name = "PisoCombo"
        Me.PisoCombo.Size = New System.Drawing.Size(180, 24)
        Me.PisoCombo.TabIndex = 4
        '
        'complementoInfoTable
        '
        Me.complementoInfoTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.complementoInfoTable.ColumnCount = 4
        Me.complementoInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.complementoInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.complementoInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.complementoInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.complementoInfoTable.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.complementoInfoTable.Controls.Add(Me.listadoGrid, 2, 2)
        Me.complementoInfoTable.Controls.Add(Me.PreAnalisisL, 0, 1)
        Me.complementoInfoTable.Controls.Add(Me.ListadoT, 2, 1)
        Me.complementoInfoTable.Controls.Add(Me.VerMiembrosL, 2, 0)
        Me.complementoInfoTable.Controls.Add(Me.VerHorasL, 3, 0)
        Me.complementoInfoTable.Location = New System.Drawing.Point(6, 429)
        Me.complementoInfoTable.Name = "complementoInfoTable"
        Me.complementoInfoTable.RowCount = 3
        Me.complementoInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.complementoInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.complementoInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.complementoInfoTable.Size = New System.Drawing.Size(970, 227)
        Me.complementoInfoTable.TabIndex = 274
        Me.complementoInfoTable.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.NotasPAV, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.FechaPAV, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.AplicaPAV, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.aplicaPAL, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.fechaPAL, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.notasPAL, 0, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 73)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(362, 151)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'NotasPAV
        '
        Me.NotasPAV.AutoSize = True
        Me.NotasPAV.Location = New System.Drawing.Point(57, 56)
        Me.NotasPAV.Name = "NotasPAV"
        Me.NotasPAV.Size = New System.Drawing.Size(12, 16)
        Me.NotasPAV.TabIndex = 5
        Me.NotasPAV.Text = "."
        '
        'FechaPAV
        '
        Me.FechaPAV.AutoSize = True
        Me.FechaPAV.Location = New System.Drawing.Point(57, 26)
        Me.FechaPAV.Name = "FechaPAV"
        Me.FechaPAV.Size = New System.Drawing.Size(12, 16)
        Me.FechaPAV.TabIndex = 4
        Me.FechaPAV.Text = "."
        '
        'AplicaPAV
        '
        Me.AplicaPAV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AplicaPAV.AutoSize = True
        Me.AplicaPAV.Location = New System.Drawing.Point(57, 0)
        Me.AplicaPAV.Name = "AplicaPAV"
        Me.AplicaPAV.Size = New System.Drawing.Size(302, 16)
        Me.AplicaPAV.TabIndex = 3
        Me.AplicaPAV.Text = "."
        '
        'aplicaPAL
        '
        Me.aplicaPAL.AutoSize = True
        Me.aplicaPAL.Location = New System.Drawing.Point(3, 0)
        Me.aplicaPAL.Name = "aplicaPAL"
        Me.aplicaPAL.Size = New System.Drawing.Size(48, 16)
        Me.aplicaPAL.TabIndex = 0
        Me.aplicaPAL.Text = "Aplica:"
        '
        'fechaPAL
        '
        Me.fechaPAL.AutoSize = True
        Me.fechaPAL.Location = New System.Drawing.Point(3, 26)
        Me.fechaPAL.Name = "fechaPAL"
        Me.fechaPAL.Size = New System.Drawing.Size(48, 16)
        Me.fechaPAL.TabIndex = 1
        Me.fechaPAL.Text = "Fecha:"
        '
        'notasPAL
        '
        Me.notasPAL.AutoSize = True
        Me.notasPAL.Location = New System.Drawing.Point(3, 56)
        Me.notasPAL.Name = "notasPAL"
        Me.notasPAL.Size = New System.Drawing.Size(46, 16)
        Me.notasPAL.TabIndex = 2
        Me.notasPAL.Text = "Notas:"
        '
        'listadoGrid
        '
        Me.listadoGrid.AllowUserToAddRows = False
        Me.listadoGrid.AllowUserToDeleteRows = False
        Me.listadoGrid.AllowUserToResizeColumns = False
        Me.listadoGrid.AllowUserToResizeRows = False
        Me.listadoGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listadoGrid.BackgroundColor = System.Drawing.Color.White
        Me.listadoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.complementoInfoTable.SetColumnSpan(Me.listadoGrid, 2)
        Me.listadoGrid.Location = New System.Drawing.Point(421, 73)
        Me.listadoGrid.Name = "listadoGrid"
        Me.listadoGrid.ReadOnly = True
        Me.listadoGrid.RowHeadersVisible = False
        Me.listadoGrid.Size = New System.Drawing.Size(546, 151)
        Me.listadoGrid.TabIndex = 1
        '
        'PreAnalisisL
        '
        Me.PreAnalisisL.AutoSize = True
        Me.PreAnalisisL.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreAnalisisL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PreAnalisisL.Location = New System.Drawing.Point(3, 50)
        Me.PreAnalisisL.Name = "PreAnalisisL"
        Me.PreAnalisisL.Size = New System.Drawing.Size(99, 16)
        Me.PreAnalisisL.TabIndex = 2
        Me.PreAnalisisL.Text = "PRE-ANALISIS"
        '
        'SolPanel
        '
        Me.SolPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolPanel.BackColor = System.Drawing.Color.LightBlue
        Me.SolPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.SolPanel.Controls.Add(Me.SolTable1)
        Me.SolPanel.Location = New System.Drawing.Point(6, 170)
        Me.SolPanel.Name = "SolPanel"
        Me.SolPanel.Size = New System.Drawing.Size(970, 154)
        Me.SolPanel.TabIndex = 273
        Me.SolPanel.Visible = False
        '
        'SolTable1
        '
        Me.SolTable1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolTable1.BackColor = System.Drawing.Color.Transparent
        Me.SolTable1.ColumnCount = 9
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SolTable1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SolTable1.Controls.Add(Me.SolicitudL, 0, 2)
        Me.SolTable1.Controls.Add(Me.EstadoPicker, 8, 0)
        Me.SolTable1.Controls.Add(Me.TotalHorasV, 5, 1)
        Me.SolTable1.Controls.Add(Me.horasTL, 4, 1)
        Me.SolTable1.Controls.Add(Me.fEstadoL, 7, 0)
        Me.SolTable1.Controls.Add(Me.FechaV, 1, 0)
        Me.SolTable1.Controls.Add(Me.FechaL, 0, 0)
        Me.SolTable1.Controls.Add(Me.ExoneradaCheck, 2, 1)
        Me.SolTable1.Controls.Add(Me.HorasV, 1, 1)
        Me.SolTable1.Controls.Add(Me.HorasL, 0, 1)
        Me.SolTable1.Controls.Add(Me.EstadoV, 5, 0)
        Me.SolTable1.Controls.Add(Me.EstadoL, 4, 0)
        Me.SolTable1.Controls.Add(Me.UsuarioL, 7, 2)
        Me.SolTable1.Controls.Add(Me.UsuarioV, 8, 2)
        Me.SolTable1.Controls.Add(Me.NotasV, 8, 1)
        Me.SolTable1.Controls.Add(Me.NotasL, 7, 1)
        Me.SolTable1.Location = New System.Drawing.Point(4, 7)
        Me.SolTable1.Name = "SolTable1"
        Me.SolTable1.RowCount = 3
        Me.SolTable1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SolTable1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SolTable1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.SolTable1.Size = New System.Drawing.Size(961, 82)
        Me.SolTable1.TabIndex = 263
        '
        'EstadoPicker
        '
        Me.EstadoPicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoPicker.Enabled = False
        Me.EstadoPicker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EstadoPicker.Location = New System.Drawing.Point(875, 3)
        Me.EstadoPicker.Name = "EstadoPicker"
        Me.EstadoPicker.Size = New System.Drawing.Size(83, 22)
        Me.EstadoPicker.TabIndex = 2
        '
        'fEstadoL
        '
        Me.fEstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fEstadoL.AutoSize = True
        Me.fEstadoL.BackColor = System.Drawing.Color.Transparent
        Me.fEstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fEstadoL.ForeColor = System.Drawing.Color.Black
        Me.fEstadoL.Location = New System.Drawing.Point(777, 0)
        Me.fEstadoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fEstadoL.Name = "fEstadoL"
        Me.fEstadoL.Size = New System.Drawing.Size(93, 16)
        Me.fEstadoL.TabIndex = 270
        Me.fEstadoL.Text = "Fecha Estado:"
        '
        'FechaV
        '
        Me.FechaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolTable1.SetColumnSpan(Me.FechaV, 2)
        Me.FechaV.Enabled = False
        Me.FechaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaV.Location = New System.Drawing.Point(119, 3)
        Me.FechaV.Name = "FechaV"
        Me.FechaV.Size = New System.Drawing.Size(139, 22)
        Me.FechaV.TabIndex = 0
        '
        'FechaL
        '
        Me.FechaL.AutoSize = True
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.ForeColor = System.Drawing.Color.Black
        Me.FechaL.Location = New System.Drawing.Point(2, 0)
        Me.FechaL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(102, 16)
        Me.FechaL.TabIndex = 42
        Me.FechaL.Text = "Fecha Solicitud:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ExoneradaCheck
        '
        Me.ExoneradaCheck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExoneradaCheck.AutoSize = True
        Me.ExoneradaCheck.Enabled = False
        Me.ExoneradaCheck.Location = New System.Drawing.Point(169, 33)
        Me.ExoneradaCheck.Name = "ExoneradaCheck"
        Me.ExoneradaCheck.Size = New System.Drawing.Size(89, 20)
        Me.ExoneradaCheck.TabIndex = 4
        Me.ExoneradaCheck.Text = "Exonerada"
        Me.ExoneradaCheck.UseVisualStyleBackColor = True
        '
        'HorasV
        '
        Me.HorasV.Enabled = False
        Me.HorasV.Location = New System.Drawing.Point(119, 33)
        Me.HorasV.Name = "HorasV"
        Me.HorasV.Size = New System.Drawing.Size(38, 22)
        Me.HorasV.TabIndex = 3
        '
        'HorasL
        '
        Me.HorasL.AutoSize = True
        Me.HorasL.BackColor = System.Drawing.Color.Transparent
        Me.HorasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorasL.ForeColor = System.Drawing.Color.Black
        Me.HorasL.Location = New System.Drawing.Point(2, 30)
        Me.HorasL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HorasL.Name = "HorasL"
        Me.HorasL.Size = New System.Drawing.Size(104, 16)
        Me.HorasL.TabIndex = 265
        Me.HorasL.Text = "Asignación Hrs.:"
        Me.HorasL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EstadoV
        '
        Me.EstadoV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoV.Enabled = False
        Me.EstadoV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoV.FormattingEnabled = True
        Me.EstadoV.Location = New System.Drawing.Point(411, 3)
        Me.EstadoV.Name = "EstadoV"
        Me.EstadoV.Size = New System.Drawing.Size(318, 24)
        Me.EstadoV.TabIndex = 1
        '
        'EstadoL
        '
        Me.EstadoL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoL.AutoSize = True
        Me.EstadoL.BackColor = System.Drawing.Color.Transparent
        Me.EstadoL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoL.ForeColor = System.Drawing.Color.Black
        Me.EstadoL.Location = New System.Drawing.Point(306, 0)
        Me.EstadoL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.Size = New System.Drawing.Size(100, 16)
        Me.EstadoL.TabIndex = 41
        Me.EstadoL.Text = "Estado:"
        Me.EstadoL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UsuarioL
        '
        Me.UsuarioL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioL.AutoSize = True
        Me.UsuarioL.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioL.ForeColor = System.Drawing.Color.Black
        Me.UsuarioL.Location = New System.Drawing.Point(777, 58)
        Me.UsuarioL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsuarioL.Name = "UsuarioL"
        Me.UsuarioL.Size = New System.Drawing.Size(93, 16)
        Me.UsuarioL.TabIndex = 275
        Me.UsuarioL.Text = "Usuario:"
        Me.UsuarioL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UsuarioV
        '
        Me.UsuarioV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioV.AutoSize = True
        Me.UsuarioV.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioV.ForeColor = System.Drawing.Color.Black
        Me.UsuarioV.Location = New System.Drawing.Point(874, 58)
        Me.UsuarioV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsuarioV.Name = "UsuarioV"
        Me.UsuarioV.Size = New System.Drawing.Size(85, 16)
        Me.UsuarioV.TabIndex = 276
        Me.UsuarioV.Text = "_"
        '
        'NotasV
        '
        Me.NotasV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasV.Location = New System.Drawing.Point(875, 33)
        Me.NotasV.MaxLength = 100
        Me.NotasV.Name = "NotasV"
        Me.NotasV.Size = New System.Drawing.Size(83, 22)
        Me.NotasV.TabIndex = 5
        '
        'NotasL
        '
        Me.NotasL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasL.AutoSize = True
        Me.NotasL.BackColor = System.Drawing.Color.Transparent
        Me.NotasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotasL.ForeColor = System.Drawing.Color.Black
        Me.NotasL.Location = New System.Drawing.Point(777, 30)
        Me.NotasL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NotasL.Name = "NotasL"
        Me.NotasL.Size = New System.Drawing.Size(93, 16)
        Me.NotasL.TabIndex = 264
        Me.NotasL.Text = "Notas:"
        Me.NotasL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ListadoButton
        '
        Me.ListadoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.ListadoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.ListaIcon
        Me.ListadoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ListadoButton.Location = New System.Drawing.Point(837, 3)
        Me.ListadoButton.Name = "ListadoButton"
        Me.ListadoButton.Size = New System.Drawing.Size(48, 45)
        Me.ListadoButton.TabIndex = 236
        Me.ListadoButton.UseVisualStyleBackColor = False
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(984, 118)
        Me.bannerPanel.TabIndex = 271
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
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 3, 0)
        Me.opcionesTable.Controls.Add(Me.ListadoButton, 4, 0)
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(888, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'GuardarButton
        '
        Me.GuardarButton.BackColor = System.Drawing.Color.AliceBlue
        Me.GuardarButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Save
        Me.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GuardarButton.Location = New System.Drawing.Point(783, 3)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(48, 45)
        Me.GuardarButton.TabIndex = 237
        Me.GuardarButton.UseVisualStyleBackColor = False
        Me.GuardarButton.Visible = False
        '
        'NuevoButton
        '
        Me.NuevoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.Nuevo
        Me.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NuevoButton.Location = New System.Drawing.Point(728, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(677, 3)
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
        Me.Title.Size = New System.Drawing.Size(666, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Actualizar Solicitud de Viviendas"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel7.ColumnCount = 8
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.RegionV, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.regionL, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.DireccionV, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.DireccionL, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.FamiliaV, 7, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 6, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 126)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(973, 38)
        Me.TableLayoutPanel7.TabIndex = 272
        '
        'RegionV
        '
        Me.RegionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RegionV.AutoSize = True
        Me.RegionV.BackColor = System.Drawing.Color.Transparent
        Me.RegionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegionV.Location = New System.Drawing.Point(452, 0)
        Me.RegionV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RegionV.Name = "RegionV"
        Me.RegionV.Size = New System.Drawing.Size(15, 38)
        Me.RegionV.TabIndex = 264
        Me.RegionV.Text = "_"
        Me.RegionV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RegionV.Visible = False
        '
        'regionL
        '
        Me.regionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.regionL.AutoSize = True
        Me.regionL.BackColor = System.Drawing.Color.Transparent
        Me.regionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.regionL.Location = New System.Drawing.Point(396, 0)
        Me.regionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.regionL.Name = "regionL"
        Me.regionL.Size = New System.Drawing.Size(52, 38)
        Me.regionL.TabIndex = 264
        Me.regionL.Text = "Región:"
        Me.regionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.regionL.Visible = False
        '
        'DireccionV
        '
        Me.DireccionV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DireccionV.AutoSize = True
        Me.DireccionV.BackColor = System.Drawing.Color.Transparent
        Me.DireccionV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DireccionV.Location = New System.Drawing.Point(72, 0)
        Me.DireccionV.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionV.Name = "DireccionV"
        Me.DireccionV.Size = New System.Drawing.Size(15, 38)
        Me.DireccionV.TabIndex = 48
        Me.DireccionV.Text = "_"
        Me.DireccionV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DireccionV.Visible = False
        '
        'DireccionL
        '
        Me.DireccionL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DireccionL.AutoSize = True
        Me.DireccionL.BackColor = System.Drawing.Color.Transparent
        Me.DireccionL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DireccionL.Location = New System.Drawing.Point(2, 0)
        Me.DireccionL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DireccionL.Name = "DireccionL"
        Me.DireccionL.Size = New System.Drawing.Size(66, 38)
        Me.DireccionL.TabIndex = 47
        Me.DireccionL.Text = "Dirección:"
        Me.DireccionL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DireccionL.Visible = False
        '
        'FamiliaV
        '
        Me.FamiliaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaV.BackColor = System.Drawing.Color.White
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FamiliaV.Location = New System.Drawing.Point(856, 3)
        Me.FamiliaV.MaxLength = 6
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(114, 29)
        Me.FamiliaV.TabIndex = 49
        Me.FamiliaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(776, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 22)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Familia:"
        '
        'VerMiembrosL
        '
        Me.VerMiembrosL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerMiembrosL.AutoSize = True
        Me.VerMiembrosL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerMiembrosL.ForeColor = System.Drawing.Color.Blue
        Me.VerMiembrosL.Location = New System.Drawing.Point(421, 0)
        Me.VerMiembrosL.Name = "VerMiembrosL"
        Me.VerMiembrosL.Size = New System.Drawing.Size(270, 16)
        Me.VerMiembrosL.TabIndex = 4
        Me.VerMiembrosL.Text = "Ver Miembros mayores a 17 años"
        Me.VerMiembrosL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VerHorasL
        '
        Me.VerHorasL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerHorasL.AutoSize = True
        Me.VerHorasL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerHorasL.ForeColor = System.Drawing.Color.Blue
        Me.VerHorasL.Location = New System.Drawing.Point(697, 0)
        Me.VerHorasL.Name = "VerHorasL"
        Me.VerHorasL.Size = New System.Drawing.Size(270, 16)
        Me.VerHorasL.TabIndex = 5
        Me.VerHorasL.Text = "Ver Horas Trabajadas"
        Me.VerHorasL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ActualizarSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.complementoInfoTable)
        Me.Controls.Add(Me.SolPanel)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActualizarSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Solicitud"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Table2.ResumeLayout(False)
        Me.Table2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.complementoInfoTable.ResumeLayout(False)
        Me.complementoInfoTable.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.listadoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SolPanel.ResumeLayout(False)
        Me.SolTable1.ResumeLayout(False)
        Me.SolTable1.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents xL As System.Windows.Forms.Label
    Friend WithEvents Table2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EntregaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EntregaL As System.Windows.Forms.Label
    Friend WithEvents BrigadaV As System.Windows.Forms.TextBox
    Friend WithEvents ConstruccionPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VisitaPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VisitaL As System.Windows.Forms.Label
    Friend WithEvents ConstruccionL As System.Windows.Forms.Label
    Friend WithEvents BrigadaL As System.Windows.Forms.Label
    Friend WithEvents VerCarpetaButton As System.Windows.Forms.Button
    Friend WithEvents FotoInicialButton As System.Windows.Forms.Button
    Friend WithEvents FotoFinalButton As System.Windows.Forms.Button
    Friend WithEvents ListadoT As System.Windows.Forms.Label
    Friend WithEvents SolicitudL As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TechoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ParedCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ParedL As System.Windows.Forms.Label
    Friend WithEvents techoL As System.Windows.Forms.Label
    Friend WithEvents SolicitaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents SolicitaL As System.Windows.Forms.Label
    Friend WithEvents CantidadL As System.Windows.Forms.Label
    Friend WithEvents CantidadV As System.Windows.Forms.TextBox
    Friend WithEvents DimensionXV As System.Windows.Forms.TextBox
    Friend WithEvents DimensionYV As System.Windows.Forms.TextBox
    Friend WithEvents DimensionL As System.Windows.Forms.Label
    Friend WithEvents PisoL As System.Windows.Forms.Label
    Friend WithEvents PisoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents complementoInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NotasPAV As System.Windows.Forms.Label
    Friend WithEvents FechaPAV As System.Windows.Forms.Label
    Friend WithEvents AplicaPAV As System.Windows.Forms.Label
    Friend WithEvents aplicaPAL As System.Windows.Forms.Label
    Friend WithEvents fechaPAL As System.Windows.Forms.Label
    Friend WithEvents notasPAL As System.Windows.Forms.Label
    Friend WithEvents listadoGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PreAnalisisL As System.Windows.Forms.Label
    Friend WithEvents SolPanel As System.Windows.Forms.Panel
    Friend WithEvents SolTable1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TotalHorasV As System.Windows.Forms.TextBox
    Friend WithEvents horasTL As System.Windows.Forms.Label
    Friend WithEvents EstadoPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents fEstadoL As System.Windows.Forms.Label
    Friend WithEvents FechaV As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents ExoneradaCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NotasV As System.Windows.Forms.TextBox
    Friend WithEvents HorasV As System.Windows.Forms.TextBox
    Friend WithEvents NotasL As System.Windows.Forms.Label
    Friend WithEvents HorasL As System.Windows.Forms.Label
    Friend WithEvents EstadoV As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoL As System.Windows.Forms.Label
    Friend WithEvents ListadoButton As System.Windows.Forms.Button
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RegionV As System.Windows.Forms.Label
    Friend WithEvents regionL As System.Windows.Forms.Label
    Friend WithEvents DireccionV As System.Windows.Forms.Label
    Friend WithEvents DireccionL As System.Windows.Forms.Label
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UsuarioV As System.Windows.Forms.Label
    Friend WithEvents UsuarioL As System.Windows.Forms.Label
    Friend WithEvents FotoFV As System.Windows.Forms.TextBox
    Friend WithEvents FotoIV As System.Windows.Forms.TextBox
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents VerMiembrosL As System.Windows.Forms.Label
    Friend WithEvents VerHorasL As System.Windows.Forms.Label
End Class
