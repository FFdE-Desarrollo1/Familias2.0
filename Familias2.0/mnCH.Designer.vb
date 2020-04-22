<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mnCH
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.bannerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.sNombre = New System.Windows.Forms.Label()
        Me.logoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuList = New System.Windows.Forms.Panel()
        Me.bannerTable.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.logoTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerTable
        '
        Me.bannerTable.BackColor = System.Drawing.Color.Transparent
        Me.bannerTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bannerTable.ColumnCount = 3
        Me.bannerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353.0!))
        Me.bannerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.bannerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.bannerTable.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.bannerTable.Controls.Add(Me.logoTable, 0, 0)
        Me.bannerTable.Location = New System.Drawing.Point(0, 0)
        Me.bannerTable.Name = "bannerTable"
        Me.bannerTable.RowCount = 1
        Me.bannerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.bannerTable.Size = New System.Drawing.Size(848, 85)
        Me.bannerTable.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Usuario, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.sNombre, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(356, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(484, 79)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Usuario
        '
        Me.Usuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Font = New System.Drawing.Font("Candara", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Usuario.Location = New System.Drawing.Point(3, 23)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(478, 19)
        Me.Usuario.TabIndex = 5
        Me.Usuario.Text = "_"
        Me.Usuario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'sNombre
        '
        Me.sNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sNombre.AutoSize = True
        Me.sNombre.BackColor = System.Drawing.Color.Transparent
        Me.sNombre.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sNombre.ForeColor = System.Drawing.Color.DimGray
        Me.sNombre.Location = New System.Drawing.Point(3, 0)
        Me.sNombre.Name = "sNombre"
        Me.sNombre.Size = New System.Drawing.Size(478, 23)
        Me.sNombre.TabIndex = 6
        Me.sNombre.Text = "_"
        Me.sNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'logoTable
        '
        Me.logoTable.BackColor = System.Drawing.Color.Transparent
        Me.logoTable.BackgroundImage = Global.Familias2._0.My.Resources.Resources.logoFam
        Me.logoTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoTable.ColumnCount = 2
        Me.logoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.logoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.logoTable.Controls.Add(Me.MenuList, 1, 0)
        Me.logoTable.Location = New System.Drawing.Point(3, 3)
        Me.logoTable.Name = "logoTable"
        Me.logoTable.RowCount = 2
        Me.logoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.logoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.logoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.logoTable.Size = New System.Drawing.Size(347, 79)
        Me.logoTable.TabIndex = 4
        '
        'MenuList
        '
        Me.MenuList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuList.BackColor = System.Drawing.Color.Transparent
        Me.MenuList.Location = New System.Drawing.Point(32, 3)
        Me.MenuList.Name = "MenuList"
        Me.MenuList.Size = New System.Drawing.Size(312, 33)
        Me.MenuList.TabIndex = 3
        '
        'mnCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.bannerTable)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mnCH"
        Me.Size = New System.Drawing.Size(848, 100)
        Me.bannerTable.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.logoTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Usuario As System.Windows.Forms.Label
    Friend WithEvents sNombre As System.Windows.Forms.Label
    Friend WithEvents logoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuList As System.Windows.Forms.Panel

End Class
