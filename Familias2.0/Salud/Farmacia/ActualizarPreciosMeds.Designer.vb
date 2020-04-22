<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarPreciosMeds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarPreciosMeds))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Q1 = New System.Windows.Forms.Label()
        Me.QActualV = New System.Windows.Forms.TextBox()
        Me.QActualL = New System.Windows.Forms.Label()
        Me.NuevoPrecioL = New System.Windows.Forms.Label()
        Me.NuevoPrecioV = New System.Windows.Forms.TextBox()
        Me.Q2 = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.MedL = New System.Windows.Forms.Label()
        Me.MedBoxV = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.NuevoButton = New System.Windows.Forms.Button()
        Me.inicioButton = New System.Windows.Forms.Button()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Q1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.QActualV, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.QActualL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NuevoPrecioL, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NuevoPrecioV, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Q2, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 131)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(597, 63)
        Me.TableLayoutPanel1.TabIndex = 206
        Me.TableLayoutPanel1.Visible = False
        '
        'Q1
        '
        Me.Q1.AutoSize = True
        Me.Q1.BackColor = System.Drawing.Color.Transparent
        Me.Q1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q1.Location = New System.Drawing.Point(3, 31)
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(32, 23)
        Me.Q1.TabIndex = 112
        Me.Q1.Text = "Q."
        Me.Q1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'QActualV
        '
        Me.QActualV.Enabled = False
        Me.QActualV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QActualV.Location = New System.Drawing.Point(41, 34)
        Me.QActualV.Name = "QActualV"
        Me.QActualV.Size = New System.Drawing.Size(89, 30)
        Me.QActualV.TabIndex = 108
        '
        'QActualL
        '
        Me.QActualL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QActualL.AutoSize = True
        Me.QActualL.BackColor = System.Drawing.Color.Transparent
        Me.QActualL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QActualL.Location = New System.Drawing.Point(41, 0)
        Me.QActualL.Name = "QActualL"
        Me.QActualL.Size = New System.Drawing.Size(125, 31)
        Me.QActualL.TabIndex = 109
        Me.QActualL.Text = "Precio Actual"
        Me.QActualL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NuevoPrecioL
        '
        Me.NuevoPrecioL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevoPrecioL.AutoSize = True
        Me.NuevoPrecioL.BackColor = System.Drawing.Color.Transparent
        Me.NuevoPrecioL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoPrecioL.Location = New System.Drawing.Point(468, 0)
        Me.NuevoPrecioL.Name = "NuevoPrecioL"
        Me.NuevoPrecioL.Size = New System.Drawing.Size(126, 31)
        Me.NuevoPrecioL.TabIndex = 110
        Me.NuevoPrecioL.Text = "Nuevo Precio"
        Me.NuevoPrecioL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NuevoPrecioV
        '
        Me.NuevoPrecioV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoPrecioV.Location = New System.Drawing.Point(468, 34)
        Me.NuevoPrecioV.Name = "NuevoPrecioV"
        Me.NuevoPrecioV.Size = New System.Drawing.Size(89, 30)
        Me.NuevoPrecioV.TabIndex = 111
        Me.NuevoPrecioV.Text = "0.00"
        '
        'Q2
        '
        Me.Q2.AutoSize = True
        Me.Q2.BackColor = System.Drawing.Color.Transparent
        Me.Q2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q2.Location = New System.Drawing.Point(430, 31)
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(32, 23)
        Me.Q2.TabIndex = 113
        Me.Q2.Text = "Q."
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(219, 99)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(229, 26)
        Me.UpdateButton.TabIndex = 115
        Me.UpdateButton.Text = "Mostrar Precio Actual"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'MedL
        '
        Me.MedL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedL.BackColor = System.Drawing.Color.Transparent
        Me.MedL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedL.Location = New System.Drawing.Point(15, 10)
        Me.MedL.Name = "MedL"
        Me.MedL.Size = New System.Drawing.Size(597, 19)
        Me.MedL.TabIndex = 107
        Me.MedL.Text = "Medicamento"
        Me.MedL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MedBoxV
        '
        Me.MedBoxV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MedBoxV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MedBoxV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MedBoxV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedBoxV.FormattingEnabled = True
        Me.MedBoxV.Location = New System.Drawing.Point(15, 32)
        Me.MedBoxV.Name = "MedBoxV"
        Me.MedBoxV.Size = New System.Drawing.Size(597, 31)
        Me.MedBoxV.TabIndex = 106
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
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 124)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(784, 452)
        Me.TableLayoutPanel2.TabIndex = 247
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Controls.Add(Me.MedL)
        Me.Panel1.Controls.Add(Me.MedBoxV)
        Me.Panel1.Location = New System.Drawing.Point(76, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 214)
        Me.Panel1.TabIndex = 204
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.Transparent
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 257
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 4
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.opcionesTable.Controls.Add(Me.NuevoButton, 2, 0)
        Me.opcionesTable.Controls.Add(Me.inicioButton, 1, 0)
        Me.opcionesTable.Controls.Add(Me.GuardarButton, 3, 0)
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
        Me.NuevoButton.Location = New System.Drawing.Point(582, 3)
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
        Me.inicioButton.Location = New System.Drawing.Point(531, 3)
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
        Me.Title.Size = New System.Drawing.Size(520, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Actualizar Precio Medicamento"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActualizarPreciosMeds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 762)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ActualizarPreciosMeds"
        Me.Text = "Actualizar Precios Medicinas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Q1 As System.Windows.Forms.Label
    Friend WithEvents QActualV As System.Windows.Forms.TextBox
    Friend WithEvents QActualL As System.Windows.Forms.Label
    Friend WithEvents NuevoPrecioL As System.Windows.Forms.Label
    Friend WithEvents NuevoPrecioV As System.Windows.Forms.TextBox
    Friend WithEvents Q2 As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents MedL As System.Windows.Forms.Label
    Friend WithEvents MedBoxV As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NuevoButton As System.Windows.Forms.Button
    Friend WithEvents inicioButton As System.Windows.Forms.Button
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.Label
End Class
