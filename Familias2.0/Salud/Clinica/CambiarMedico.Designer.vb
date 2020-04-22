<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarMedico))
        Me.CitaInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MedicoL = New System.Windows.Forms.Label()
        Me.MedicoV = New System.Windows.Forms.Label()
        Me.nuevoMedicoL = New System.Windows.Forms.Label()
        Me.nuevoMedico = New System.Windows.Forms.ComboBox()
        Me.PacienteL = New System.Windows.Forms.Label()
        Me.PacienteV = New System.Windows.Forms.Label()
        Me.memberIdL = New System.Windows.Forms.Label()
        Me.memberIdV = New System.Windows.Forms.Label()
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.AgendaGrid = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.InstruccionesL = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.RetornoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.CitaInfoTable.SuspendLayout()
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'CitaInfoTable
        '
        Me.CitaInfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CitaInfoTable.BackColor = System.Drawing.Color.Gainsboro
        Me.CitaInfoTable.ColumnCount = 5
        Me.CitaInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.CitaInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.CitaInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.CitaInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.CitaInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.CitaInfoTable.Controls.Add(Me.MedicoL, 0, 1)
        Me.CitaInfoTable.Controls.Add(Me.MedicoV, 1, 1)
        Me.CitaInfoTable.Controls.Add(Me.nuevoMedicoL, 0, 2)
        Me.CitaInfoTable.Controls.Add(Me.nuevoMedico, 1, 2)
        Me.CitaInfoTable.Controls.Add(Me.PacienteL, 0, 0)
        Me.CitaInfoTable.Controls.Add(Me.PacienteV, 1, 0)
        Me.CitaInfoTable.Controls.Add(Me.memberIdL, 3, 0)
        Me.CitaInfoTable.Controls.Add(Me.memberIdV, 4, 0)
        Me.CitaInfoTable.Controls.Add(Me.ActualizarButton, 4, 1)
        Me.CitaInfoTable.Location = New System.Drawing.Point(3, 513)
        Me.CitaInfoTable.Name = "CitaInfoTable"
        Me.CitaInfoTable.RowCount = 3
        Me.CitaInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.CitaInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.CitaInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.CitaInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CitaInfoTable.Size = New System.Drawing.Size(778, 99)
        Me.CitaInfoTable.TabIndex = 218
        Me.CitaInfoTable.Visible = False
        '
        'MedicoL
        '
        Me.MedicoL.AutoSize = True
        Me.MedicoL.Location = New System.Drawing.Point(3, 28)
        Me.MedicoL.Name = "MedicoL"
        Me.MedicoL.Size = New System.Drawing.Size(54, 16)
        Me.MedicoL.TabIndex = 2
        Me.MedicoL.Text = "Médico:"
        '
        'MedicoV
        '
        Me.MedicoV.AutoSize = True
        Me.MedicoV.Location = New System.Drawing.Point(80, 28)
        Me.MedicoV.Name = "MedicoV"
        Me.MedicoV.Size = New System.Drawing.Size(15, 16)
        Me.MedicoV.TabIndex = 5
        Me.MedicoV.Text = "_"
        '
        'nuevoMedicoL
        '
        Me.nuevoMedicoL.AutoSize = True
        Me.nuevoMedicoL.Location = New System.Drawing.Point(3, 56)
        Me.nuevoMedicoL.Name = "nuevoMedicoL"
        Me.nuevoMedicoL.Size = New System.Drawing.Size(71, 16)
        Me.nuevoMedicoL.TabIndex = 6
        Me.nuevoMedicoL.Text = "Cambiar a:"
        '
        'nuevoMedico
        '
        Me.nuevoMedico.FormattingEnabled = True
        Me.nuevoMedico.Location = New System.Drawing.Point(80, 59)
        Me.nuevoMedico.Name = "nuevoMedico"
        Me.nuevoMedico.Size = New System.Drawing.Size(121, 24)
        Me.nuevoMedico.TabIndex = 7
        '
        'PacienteL
        '
        Me.PacienteL.AutoSize = True
        Me.PacienteL.Location = New System.Drawing.Point(3, 0)
        Me.PacienteL.Name = "PacienteL"
        Me.PacienteL.Size = New System.Drawing.Size(63, 16)
        Me.PacienteL.TabIndex = 3
        Me.PacienteL.Text = "Paciente:"
        '
        'PacienteV
        '
        Me.PacienteV.AutoSize = True
        Me.PacienteV.Location = New System.Drawing.Point(80, 0)
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(15, 16)
        Me.PacienteV.TabIndex = 4
        Me.PacienteV.Text = "_"
        '
        'memberIdL
        '
        Me.memberIdL.AutoSize = True
        Me.memberIdL.Location = New System.Drawing.Point(247, 0)
        Me.memberIdL.Name = "memberIdL"
        Me.memberIdL.Size = New System.Drawing.Size(24, 16)
        Me.memberIdL.TabIndex = 0
        Me.memberIdL.Text = "ID:"
        Me.memberIdL.Visible = False
        '
        'memberIdV
        '
        Me.memberIdV.AutoSize = True
        Me.memberIdV.Location = New System.Drawing.Point(277, 0)
        Me.memberIdV.Name = "memberIdV"
        Me.memberIdV.Size = New System.Drawing.Size(15, 16)
        Me.memberIdV.TabIndex = 1
        Me.memberIdV.Text = "_"
        Me.memberIdV.Visible = False
        '
        'ActualizarButton
        '
        Me.ActualizarButton.BackColor = System.Drawing.Color.Chocolate
        Me.ActualizarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarButton.ForeColor = System.Drawing.Color.White
        Me.ActualizarButton.Location = New System.Drawing.Point(277, 31)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.CitaInfoTable.SetRowSpan(Me.ActualizarButton, 2)
        Me.ActualizarButton.Size = New System.Drawing.Size(237, 46)
        Me.ActualizarButton.TabIndex = 198
        Me.ActualizarButton.Text = "Guardar cambio de médico"
        Me.ActualizarButton.UseVisualStyleBackColor = False
        '
        'AgendaGrid
        '
        Me.AgendaGrid.AllowUserToAddRows = False
        Me.AgendaGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AgendaGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgendaGrid.BackgroundColor = System.Drawing.Color.White
        Me.AgendaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AgendaGrid.Location = New System.Drawing.Point(3, 3)
        Me.AgendaGrid.Name = "AgendaGrid"
        Me.AgendaGrid.ReadOnly = True
        Me.AgendaGrid.RowHeadersWidth = 60
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.AgendaGrid.Size = New System.Drawing.Size(778, 484)
        Me.AgendaGrid.TabIndex = 219
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CitaInfoTable, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AgendaGrid, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 145)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 615)
        Me.TableLayoutPanel1.TabIndex = 243
        '
        'InstruccionesL
        '
        Me.InstruccionesL.AutoSize = True
        Me.InstruccionesL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InstruccionesL.Location = New System.Drawing.Point(0, 120)
        Me.InstruccionesL.Name = "InstruccionesL"
        Me.InstruccionesL.Size = New System.Drawing.Size(503, 16)
        Me.InstruccionesL.TabIndex = 242
        Me.InstruccionesL.Text = "Seleccione al paciente con un clic en el nombre (pre-consultas actuales y complet" & _
    "as)"
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
        Me.opcionesTable.Controls.Add(Me.RetornoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
        '
        'RetornoButton
        '
        Me.RetornoButton.BackColor = System.Drawing.Color.AliceBlue
        Me.RetornoButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.retorno
        Me.RetornoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RetornoButton.Location = New System.Drawing.Point(636, 3)
        Me.RetornoButton.Name = "RetornoButton"
        Me.RetornoButton.Size = New System.Drawing.Size(49, 44)
        Me.RetornoButton.TabIndex = 235
        Me.RetornoButton.UseVisualStyleBackColor = False
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
        Me.Title.Text = "Cambiar médico"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CambiarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.InstruccionesL)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CambiarMedico"
        Me.Text = "Cambiar Medico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CitaInfoTable.ResumeLayout(False)
        Me.CitaInfoTable.PerformLayout()
        CType(Me.AgendaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CitaInfoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MedicoL As System.Windows.Forms.Label
    Friend WithEvents MedicoV As System.Windows.Forms.Label
    Friend WithEvents nuevoMedicoL As System.Windows.Forms.Label
    Friend WithEvents nuevoMedico As System.Windows.Forms.ComboBox
    Friend WithEvents PacienteL As System.Windows.Forms.Label
    Friend WithEvents PacienteV As System.Windows.Forms.Label
    Friend WithEvents memberIdL As System.Windows.Forms.Label
    Friend WithEvents memberIdV As System.Windows.Forms.Label
    Friend WithEvents ActualizarButton As System.Windows.Forms.Button
    Friend WithEvents AgendaGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InstruccionesL As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RetornoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
