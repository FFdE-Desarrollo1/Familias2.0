<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecetasPendientes
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecetasPendientes))
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FechaTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MostrarButton = New System.Windows.Forms.Button()
        Me.FechaL = New System.Windows.Forms.Label()
        Me.ActualDateP = New System.Windows.Forms.DateTimePicker()
        Me.RecetasGrid = New System.Windows.Forms.DataGridView()
        Me.RecetaSelGrid = New System.Windows.Forms.DataGridView()
        Me.Entregado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SelectPresPanel = New System.Windows.Forms.Panel()
        Me.DrV = New System.Windows.Forms.TextBox()
        Me.PacienteV = New System.Windows.Forms.Label()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.PrincipalPanel.SuspendLayout()
        Me.FechaTable.SuspendLayout()
        CType(Me.RecetasGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetaSelGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectPresPanel.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.Transparent
        Me.PrincipalPanel.ColumnCount = 1
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.Controls.Add(Me.FechaTable, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.RecetasGrid, 0, 1)
        Me.PrincipalPanel.Controls.Add(Me.RecetaSelGrid, 0, 4)
        Me.PrincipalPanel.Controls.Add(Me.SelectPresPanel, 0, 3)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 124)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 5
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 618)
        Me.PrincipalPanel.TabIndex = 251
        '
        'FechaTable
        '
        Me.FechaTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaTable.BackColor = System.Drawing.Color.SteelBlue
        Me.FechaTable.ColumnCount = 4
        Me.FechaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FechaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FechaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FechaTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.FechaTable.Controls.Add(Me.MostrarButton, 3, 0)
        Me.FechaTable.Controls.Add(Me.FechaL, 1, 0)
        Me.FechaTable.Controls.Add(Me.ActualDateP, 2, 0)
        Me.FechaTable.Location = New System.Drawing.Point(3, 3)
        Me.FechaTable.Name = "FechaTable"
        Me.FechaTable.RowCount = 1
        Me.FechaTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FechaTable.Size = New System.Drawing.Size(778, 32)
        Me.FechaTable.TabIndex = 218
        '
        'MostrarButton
        '
        Me.MostrarButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MostrarButton.Location = New System.Drawing.Point(681, 3)
        Me.MostrarButton.Name = "MostrarButton"
        Me.MostrarButton.Size = New System.Drawing.Size(94, 26)
        Me.MostrarButton.TabIndex = 0
        Me.MostrarButton.Text = "Mostrar recetas"
        Me.MostrarButton.UseVisualStyleBackColor = True
        '
        'FechaL
        '
        Me.FechaL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaL.BackColor = System.Drawing.Color.Transparent
        Me.FechaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaL.ForeColor = System.Drawing.Color.White
        Me.FechaL.Location = New System.Drawing.Point(316, 0)
        Me.FechaL.Name = "FechaL"
        Me.FechaL.Size = New System.Drawing.Size(53, 32)
        Me.FechaL.TabIndex = 64
        Me.FechaL.Text = "Fecha:"
        Me.FechaL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActualDateP
        '
        Me.ActualDateP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualDateP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualDateP.Location = New System.Drawing.Point(375, 3)
        Me.ActualDateP.Name = "ActualDateP"
        Me.ActualDateP.Size = New System.Drawing.Size(300, 22)
        Me.ActualDateP.TabIndex = 66
        '
        'RecetasGrid
        '
        Me.RecetasGrid.AllowUserToAddRows = False
        Me.RecetasGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple
        Me.RecetasGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RecetasGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecetasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RecetasGrid.BackgroundColor = System.Drawing.Color.White
        Me.RecetasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecetasGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.RecetasGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RecetasGrid.Location = New System.Drawing.Point(3, 41)
        Me.RecetasGrid.Name = "RecetasGrid"
        Me.RecetasGrid.RowHeadersWidth = 55
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetasGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.RecetasGrid.Size = New System.Drawing.Size(778, 312)
        Me.RecetasGrid.TabIndex = 217
        '
        'RecetaSelGrid
        '
        Me.RecetaSelGrid.AllowUserToAddRows = False
        Me.RecetaSelGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Purple
        Me.RecetaSelGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.RecetaSelGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecetaSelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RecetaSelGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.RecetaSelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecetaSelGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Entregado})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecetaSelGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.RecetaSelGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RecetaSelGrid.Location = New System.Drawing.Point(3, 409)
        Me.RecetaSelGrid.Name = "RecetaSelGrid"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecetaSelGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.RecetaSelGrid.Size = New System.Drawing.Size(778, 206)
        Me.RecetaSelGrid.TabIndex = 213
        Me.RecetaSelGrid.Visible = False
        '
        'Entregado
        '
        Me.Entregado.Frozen = True
        Me.Entregado.HeaderText = "Entregar"
        Me.Entregado.Name = "Entregado"
        Me.Entregado.Width = 63
        '
        'SelectPresPanel
        '
        Me.SelectPresPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectPresPanel.BackColor = System.Drawing.Color.Navy
        Me.SelectPresPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectPresPanel.Controls.Add(Me.DrV)
        Me.SelectPresPanel.Controls.Add(Me.PacienteV)
        Me.SelectPresPanel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectPresPanel.Location = New System.Drawing.Point(3, 379)
        Me.SelectPresPanel.Name = "SelectPresPanel"
        Me.SelectPresPanel.Size = New System.Drawing.Size(778, 22)
        Me.SelectPresPanel.TabIndex = 215
        Me.SelectPresPanel.Visible = False
        '
        'DrV
        '
        Me.DrV.BackColor = System.Drawing.Color.Navy
        Me.DrV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DrV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrV.ForeColor = System.Drawing.Color.White
        Me.DrV.Location = New System.Drawing.Point(484, 4)
        Me.DrV.Name = "DrV"
        Me.DrV.ReadOnly = True
        Me.DrV.Size = New System.Drawing.Size(229, 18)
        Me.DrV.TabIndex = 60
        Me.DrV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PacienteV
        '
        Me.PacienteV.AutoSize = True
        Me.PacienteV.BackColor = System.Drawing.Color.Transparent
        Me.PacienteV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacienteV.ForeColor = System.Drawing.Color.White
        Me.PacienteV.Location = New System.Drawing.Point(3, 4)
        Me.PacienteV.Name = "PacienteV"
        Me.PacienteV.Size = New System.Drawing.Size(16, 17)
        Me.PacienteV.TabIndex = 57
        Me.PacienteV.Text = "_"
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 259
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
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 2, 0)
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
        Me.inicioButton.Location = New System.Drawing.Point(586, 3)
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
        Me.Title.Size = New System.Drawing.Size(575, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Recetas Pendientes de Entregar"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecetasPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RecetasPendientes"
        Me.Text = "Recetas Pendientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PrincipalPanel.ResumeLayout(False)
        Me.FechaTable.ResumeLayout(False)
        CType(Me.RecetasGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetaSelGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectPresPanel.ResumeLayout(False)
        Me.SelectPresPanel.PerformLayout()
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FechaTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MostrarButton As System.Windows.Forms.Button
    Friend WithEvents FechaL As System.Windows.Forms.Label
    Friend WithEvents ActualDateP As System.Windows.Forms.DateTimePicker
    Friend WithEvents RecetasGrid As System.Windows.Forms.DataGridView
    Friend WithEvents RecetaSelGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Entregado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SelectPresPanel As System.Windows.Forms.Panel
    Friend WithEvents DrV As System.Windows.Forms.TextBox
    Friend WithEvents PacienteV As System.Windows.Forms.Label
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
