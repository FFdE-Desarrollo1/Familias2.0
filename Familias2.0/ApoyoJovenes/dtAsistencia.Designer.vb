<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dtAsistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dtAsistencia))
        Me.Title = New System.Windows.Forms.Label()
        Me.dtTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(584, 61)
        Me.Title.TabIndex = 198
        Me.Title.Text = "Datos de Asistencia"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtTable
        '
        Me.dtTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtTable.ColumnCount = 2
        Me.dtTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.dtTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.dtTable.Controls.Add(Me.Label1, 0, 0)
        Me.dtTable.Controls.Add(Me.Label2, 1, 0)
        Me.dtTable.Location = New System.Drawing.Point(6, 64)
        Me.dtTable.Name = "dtTable"
        Me.dtTable.RowCount = 2
        Me.dtTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.dtTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.dtTable.Size = New System.Drawing.Size(566, 255)
        Me.dtTable.TabIndex = 199
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'dtAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.dtTable)
        Me.Controls.Add(Me.Title)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dtAsistencia"
        Me.Text = "dtAsistencia"
        Me.dtTable.ResumeLayout(False)
        Me.dtTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents dtTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
