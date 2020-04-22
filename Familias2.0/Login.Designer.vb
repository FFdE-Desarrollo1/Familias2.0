<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.principalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliasName = New System.Windows.Forms.Label()
        Me.LogoPicture = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContraseñaL = New System.Windows.Forms.Label()
        Me.UsuarioL = New System.Windows.Forms.Label()
        Me.ContraseñaV = New System.Windows.Forms.TextBox()
        Me.UsuarioV = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ErrorV = New System.Windows.Forms.Label()
        Me.principalTable.SuspendLayout()
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'principalTable
        '
        Me.principalTable.BackColor = System.Drawing.Color.Gray
        Me.principalTable.ColumnCount = 1
        Me.principalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.principalTable.Controls.Add(Me.FamiliasName, 0, 4)
        Me.principalTable.Controls.Add(Me.LogoPicture, 0, 0)
        Me.principalTable.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.principalTable.Controls.Add(Me.ErrorV, 0, 3)
        Me.principalTable.Location = New System.Drawing.Point(69, 55)
        Me.principalTable.Margin = New System.Windows.Forms.Padding(4)
        Me.principalTable.Name = "principalTable"
        Me.principalTable.RowCount = 5
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.principalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.principalTable.Size = New System.Drawing.Size(438, 250)
        Me.principalTable.TabIndex = 1
        '
        'FamiliasName
        '
        Me.FamiliasName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliasName.AutoSize = True
        Me.FamiliasName.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FamiliasName.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliasName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FamiliasName.Location = New System.Drawing.Point(4, 224)
        Me.FamiliasName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FamiliasName.Name = "FamiliasName"
        Me.FamiliasName.Size = New System.Drawing.Size(430, 16)
        Me.FamiliasName.TabIndex = 2
        Me.FamiliasName.Text = "Familias 2.0"
        Me.FamiliasName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LogoPicture
        '
        Me.LogoPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPicture.BackColor = System.Drawing.Color.White
        Me.LogoPicture.BackgroundImage = Global.Familias2._0.My.Resources.Resources.logoFam
        Me.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPicture.Location = New System.Drawing.Point(4, 4)
        Me.LogoPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPicture.Name = "LogoPicture"
        Me.LogoPicture.Size = New System.Drawing.Size(430, 94)
        Me.LogoPicture.TabIndex = 1
        Me.LogoPicture.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ContraseñaL, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.UsuarioL, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ContraseñaV, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.UsuarioV, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LoginButton, 3, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 111)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(430, 94)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ContraseñaL
        '
        Me.ContraseñaL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContraseñaL.AutoSize = True
        Me.ContraseñaL.BackColor = System.Drawing.Color.Transparent
        Me.ContraseñaL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ContraseñaL.Location = New System.Drawing.Point(24, 43)
        Me.ContraseñaL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ContraseñaL.Name = "ContraseñaL"
        Me.ContraseñaL.Size = New System.Drawing.Size(163, 16)
        Me.ContraseñaL.TabIndex = 4
        Me.ContraseñaL.Text = "Contraseña / Password:"
        Me.ContraseñaL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UsuarioL
        '
        Me.UsuarioL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioL.AutoSize = True
        Me.UsuarioL.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.UsuarioL.Location = New System.Drawing.Point(24, 13)
        Me.UsuarioL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsuarioL.Name = "UsuarioL"
        Me.UsuarioL.Size = New System.Drawing.Size(163, 16)
        Me.UsuarioL.TabIndex = 3
        Me.UsuarioL.Text = "Usuario / User:"
        Me.UsuarioL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ContraseñaV
        '
        Me.ContraseñaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContraseñaV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaV.ForeColor = System.Drawing.Color.Black
        Me.ContraseñaV.Location = New System.Drawing.Point(195, 47)
        Me.ContraseñaV.Margin = New System.Windows.Forms.Padding(4)
        Me.ContraseñaV.Name = "ContraseñaV"
        Me.ContraseñaV.Size = New System.Drawing.Size(136, 22)
        Me.ContraseñaV.TabIndex = 1
        Me.ContraseñaV.UseSystemPasswordChar = True
        '
        'UsuarioV
        '
        Me.UsuarioV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuarioV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioV.ForeColor = System.Drawing.Color.Black
        Me.UsuarioV.Location = New System.Drawing.Point(195, 17)
        Me.UsuarioV.Margin = New System.Windows.Forms.Padding(4)
        Me.UsuarioV.Name = "UsuarioV"
        Me.UsuarioV.Size = New System.Drawing.Size(136, 22)
        Me.UsuarioV.TabIndex = 0
        '
        'LoginButton
        '
        Me.LoginButton.BackgroundImage = Global.Familias2._0.My.Resources.Resources.login
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(338, 16)
        Me.LoginButton.Name = "LoginButton"
        Me.TableLayoutPanel2.SetRowSpan(Me.LoginButton, 2)
        Me.LoginButton.Size = New System.Drawing.Size(69, 61)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ErrorV
        '
        Me.ErrorV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorV.AutoSize = True
        Me.ErrorV.BackColor = System.Drawing.Color.Transparent
        Me.ErrorV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorV.ForeColor = System.Drawing.Color.Gold
        Me.ErrorV.Location = New System.Drawing.Point(4, 209)
        Me.ErrorV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrorV.Name = "ErrorV"
        Me.ErrorV.Size = New System.Drawing.Size(430, 15)
        Me.ErrorV.TabIndex = 4
        Me.ErrorV.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(576, 361)
        Me.Controls.Add(Me.principalTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Familias 2.0"
        Me.principalTable.ResumeLayout(False)
        Me.principalTable.PerformLayout()
        CType(Me.LogoPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents principalTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliasName As System.Windows.Forms.Label
    Friend WithEvents LogoPicture As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ContraseñaL As System.Windows.Forms.Label
    Friend WithEvents UsuarioL As System.Windows.Forms.Label
    Friend WithEvents ContraseñaV As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioV As System.Windows.Forms.TextBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents ErrorV As System.Windows.Forms.Label

End Class
