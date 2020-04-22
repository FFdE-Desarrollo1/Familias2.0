<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarClaseCombo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarClaseCombo))
        Me.Table1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClaseEL = New System.Windows.Forms.Label()
        Me.ClaseEspV = New System.Windows.Forms.TextBox()
        Me.CategoriaL = New System.Windows.Forms.Label()
        Me.TipoCombo = New System.Windows.Forms.ComboBox()
        Me.TituloL = New System.Windows.Forms.Label()
        Me.GuardarButton = New System.Windows.Forms.Button()
        Me.ClaseIL = New System.Windows.Forms.Label()
        Me.ClaseIngV = New System.Windows.Forms.TextBox()
        Me.Table1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Table1
        '
        Me.Table1.BackColor = System.Drawing.Color.Transparent
        Me.Table1.ColumnCount = 2
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Table1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table1.Controls.Add(Me.ClaseIngV, 1, 2)
        Me.Table1.Controls.Add(Me.ClaseIL, 0, 2)
        Me.Table1.Controls.Add(Me.TituloL, 0, 0)
        Me.Table1.Controls.Add(Me.ClaseEL, 0, 1)
        Me.Table1.Controls.Add(Me.ClaseEspV, 1, 1)
        Me.Table1.Controls.Add(Me.CategoriaL, 0, 3)
        Me.Table1.Controls.Add(Me.TipoCombo, 1, 3)
        Me.Table1.Controls.Add(Me.GuardarButton, 1, 4)
        Me.Table1.Location = New System.Drawing.Point(12, 12)
        Me.Table1.Name = "Table1"
        Me.Table1.RowCount = 5
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Table1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Table1.Size = New System.Drawing.Size(469, 158)
        Me.Table1.TabIndex = 0
        '
        'ClaseEL
        '
        Me.ClaseEL.AutoSize = True
        Me.ClaseEL.Location = New System.Drawing.Point(3, 30)
        Me.ClaseEL.Name = "ClaseEL"
        Me.ClaseEL.Size = New System.Drawing.Size(100, 16)
        Me.ClaseEL.TabIndex = 0
        Me.ClaseEL.Text = "Clase (Español)"
        '
        'ClaseEspV
        '
        Me.ClaseEspV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClaseEspV.Location = New System.Drawing.Point(113, 33)
        Me.ClaseEspV.Name = "ClaseEspV"
        Me.ClaseEspV.Size = New System.Drawing.Size(353, 22)
        Me.ClaseEspV.TabIndex = 0
        '
        'CategoriaL
        '
        Me.CategoriaL.AutoSize = True
        Me.CategoriaL.Location = New System.Drawing.Point(3, 86)
        Me.CategoriaL.Name = "CategoriaL"
        Me.CategoriaL.Size = New System.Drawing.Size(104, 16)
        Me.CategoriaL.TabIndex = 2
        Me.CategoriaL.Text = "Seleccionar Tipo"
        '
        'TipoCombo
        '
        Me.TipoCombo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoCombo.FormattingEnabled = True
        Me.TipoCombo.Location = New System.Drawing.Point(113, 89)
        Me.TipoCombo.Name = "TipoCombo"
        Me.TipoCombo.Size = New System.Drawing.Size(353, 24)
        Me.TipoCombo.TabIndex = 2
        '
        'TituloL
        '
        Me.TituloL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TituloL.AutoSize = True
        Me.Table1.SetColumnSpan(Me.TituloL, 2)
        Me.TituloL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloL.Location = New System.Drawing.Point(3, 0)
        Me.TituloL.Name = "TituloL"
        Me.TituloL.Size = New System.Drawing.Size(463, 19)
        Me.TituloL.TabIndex = 1
        Me.TituloL.Text = "Agregar Nueva Clase"
        Me.TituloL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GuardarButton
        '
        Me.GuardarButton.Location = New System.Drawing.Point(113, 116)
        Me.GuardarButton.Name = "GuardarButton"
        Me.GuardarButton.Size = New System.Drawing.Size(75, 23)
        Me.GuardarButton.TabIndex = 3
        Me.GuardarButton.Text = "Guardar"
        Me.GuardarButton.UseVisualStyleBackColor = True
        '
        'ClaseIL
        '
        Me.ClaseIL.AutoSize = True
        Me.ClaseIL.Location = New System.Drawing.Point(3, 58)
        Me.ClaseIL.Name = "ClaseIL"
        Me.ClaseIL.Size = New System.Drawing.Size(87, 16)
        Me.ClaseIL.TabIndex = 1
        Me.ClaseIL.Text = "Clase (Inglés)"
        '
        'ClaseIngV
        '
        Me.ClaseIngV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClaseIngV.Location = New System.Drawing.Point(113, 61)
        Me.ClaseIngV.Name = "ClaseIngV"
        Me.ClaseIngV.Size = New System.Drawing.Size(353, 22)
        Me.ClaseIngV.TabIndex = 1
        '
        'AgregarClaseCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(493, 182)
        Me.Controls.Add(Me.Table1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AgregarClaseCombo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Clase al Combo"
        Me.Table1.ResumeLayout(False)
        Me.Table1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Table1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TituloL As System.Windows.Forms.Label
    Friend WithEvents ClaseEL As System.Windows.Forms.Label
    Friend WithEvents ClaseEspV As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaL As System.Windows.Forms.Label
    Friend WithEvents TipoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GuardarButton As System.Windows.Forms.Button
    Friend WithEvents ClaseIngV As System.Windows.Forms.TextBox
    Friend WithEvents ClaseIL As System.Windows.Forms.Label
End Class
