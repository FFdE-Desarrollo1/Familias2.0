<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Familias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Familias))
        Me.bannerPanel = New System.Windows.Forms.Panel()
        Me.opcionesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Title = New System.Windows.Forms.Label()
        Me.PrincipalPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BusquedaIdPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FamiliaV = New System.Windows.Forms.TextBox()
        Me.MiembroV = New System.Windows.Forms.TextBox()
        Me.FamiliaL = New System.Windows.Forms.Label()
        Me.MiembroL = New System.Windows.Forms.Label()
        Me.BusquedaPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.InfoEducLink = New System.Windows.Forms.LinkLabel()
        Me.OtraInfoLink = New System.Windows.Forms.LinkLabel()
        Me.otrasBusquedasL = New System.Windows.Forms.Label()
        Me.bannerPanel.SuspendLayout()
        Me.opcionesTable.SuspendLayout()
        Me.PrincipalPanel.SuspendLayout()
        Me.BusquedaIdPanel.SuspendLayout()
        Me.BusquedaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'bannerPanel
        '
        Me.bannerPanel.BackColor = System.Drawing.Color.White
        Me.bannerPanel.Controls.Add(Me.opcionesTable)
        Me.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.bannerPanel.Location = New System.Drawing.Point(0, 0)
        Me.bannerPanel.Name = "bannerPanel"
        Me.bannerPanel.Size = New System.Drawing.Size(784, 118)
        Me.bannerPanel.TabIndex = 67
        '
        'opcionesTable
        '
        Me.opcionesTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opcionesTable.BackColor = System.Drawing.Color.Transparent
        Me.opcionesTable.ColumnCount = 1
        Me.opcionesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Controls.Add(Me.Title, 0, 0)
        Me.opcionesTable.Location = New System.Drawing.Point(94, 61)
        Me.opcionesTable.Name = "opcionesTable"
        Me.opcionesTable.RowCount = 1
        Me.opcionesTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.opcionesTable.Size = New System.Drawing.Size(688, 53)
        Me.opcionesTable.TabIndex = 68
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
        Me.Title.Size = New System.Drawing.Size(680, 53)
        Me.Title.TabIndex = 197
        Me.Title.Text = "Búsqueda por Número"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrincipalPanel
        '
        Me.PrincipalPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrincipalPanel.BackColor = System.Drawing.Color.Transparent
        Me.PrincipalPanel.ColumnCount = 1
        Me.PrincipalPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.Controls.Add(Me.BusquedaIdPanel, 0, 0)
        Me.PrincipalPanel.Controls.Add(Me.BusquedaPanel, 0, 2)
        Me.PrincipalPanel.Location = New System.Drawing.Point(0, 124)
        Me.PrincipalPanel.Name = "PrincipalPanel"
        Me.PrincipalPanel.RowCount = 3
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PrincipalPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PrincipalPanel.Size = New System.Drawing.Size(784, 614)
        Me.PrincipalPanel.TabIndex = 66
        '
        'BusquedaIdPanel
        '
        Me.BusquedaIdPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusquedaIdPanel.ColumnCount = 3
        Me.BusquedaIdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BusquedaIdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.BusquedaIdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BusquedaIdPanel.Controls.Add(Me.FamiliaV, 1, 1)
        Me.BusquedaIdPanel.Controls.Add(Me.MiembroV, 1, 0)
        Me.BusquedaIdPanel.Controls.Add(Me.FamiliaL, 0, 1)
        Me.BusquedaIdPanel.Controls.Add(Me.MiembroL, 0, 0)
        Me.BusquedaIdPanel.Location = New System.Drawing.Point(3, 3)
        Me.BusquedaIdPanel.Name = "BusquedaIdPanel"
        Me.BusquedaIdPanel.RowCount = 3
        Me.BusquedaIdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.BusquedaIdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.BusquedaIdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BusquedaIdPanel.Size = New System.Drawing.Size(778, 120)
        Me.BusquedaIdPanel.TabIndex = 0
        '
        'FamiliaV
        '
        Me.FamiliaV.AccessibleName = "Familia"
        Me.FamiliaV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FamiliaV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaV.Location = New System.Drawing.Point(234, 33)
        Me.FamiliaV.MaxLength = 5
        Me.FamiliaV.Name = "FamiliaV"
        Me.FamiliaV.Size = New System.Drawing.Size(94, 33)
        Me.FamiliaV.TabIndex = 1
        '
        'MiembroV
        '
        Me.MiembroV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiembroV.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroV.Location = New System.Drawing.Point(234, 3)
        Me.MiembroV.Name = "MiembroV"
        Me.MiembroV.Size = New System.Drawing.Size(94, 33)
        Me.MiembroV.TabIndex = 0
        '
        'FamiliaL
        '
        Me.FamiliaL.AutoSize = True
        Me.FamiliaL.BackColor = System.Drawing.Color.Transparent
        Me.FamiliaL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FamiliaL.Location = New System.Drawing.Point(3, 30)
        Me.FamiliaL.Name = "FamiliaL"
        Me.FamiliaL.Size = New System.Drawing.Size(209, 26)
        Me.FamiliaL.TabIndex = 200
        Me.FamiliaL.Text = "Número de Familia:"
        '
        'MiembroL
        '
        Me.MiembroL.AutoSize = True
        Me.MiembroL.BackColor = System.Drawing.Color.Transparent
        Me.MiembroL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiembroL.Location = New System.Drawing.Point(3, 0)
        Me.MiembroL.Name = "MiembroL"
        Me.MiembroL.Size = New System.Drawing.Size(225, 26)
        Me.MiembroL.TabIndex = 198
        Me.MiembroL.Text = "Número de Miembro:"
        '
        'BusquedaPanel
        '
        Me.BusquedaPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BusquedaPanel.ColumnCount = 2
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BusquedaPanel.Controls.Add(Me.InfoEducLink, 0, 2)
        Me.BusquedaPanel.Controls.Add(Me.OtraInfoLink, 0, 1)
        Me.BusquedaPanel.Controls.Add(Me.otrasBusquedasL, 0, 0)
        Me.BusquedaPanel.Location = New System.Drawing.Point(3, 517)
        Me.BusquedaPanel.Name = "BusquedaPanel"
        Me.BusquedaPanel.RowCount = 3
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.BusquedaPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.BusquedaPanel.Size = New System.Drawing.Size(778, 94)
        Me.BusquedaPanel.TabIndex = 1
        '
        'InfoEducLink
        '
        Me.InfoEducLink.ActiveLinkColor = System.Drawing.Color.Fuchsia
        Me.InfoEducLink.AutoSize = True
        Me.InfoEducLink.BackColor = System.Drawing.Color.Purple
        Me.InfoEducLink.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoEducLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InfoEducLink.LinkColor = System.Drawing.Color.White
        Me.InfoEducLink.Location = New System.Drawing.Point(3, 56)
        Me.InfoEducLink.Name = "InfoEducLink"
        Me.InfoEducLink.Size = New System.Drawing.Size(321, 28)
        Me.InfoEducLink.TabIndex = 69
        Me.InfoEducLink.TabStop = True
        Me.InfoEducLink.Text = "por Información de Educación"
        Me.InfoEducLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.OtraInfoLink.Size = New System.Drawing.Size(225, 28)
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
        Me.otrasBusquedasL.Size = New System.Drawing.Size(241, 26)
        Me.otrasBusquedasL.TabIndex = 13
        Me.otrasBusquedasL.Text = "OTRAS BUSQUEDAS"
        '
        'Familias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Familias2._0.My.Resources.Resources.backFam
        Me.ClientSize = New System.Drawing.Size(784, 741)
        Me.Controls.Add(Me.bannerPanel)
        Me.Controls.Add(Me.PrincipalPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Familias"
        Me.Text = "Familias 2.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.bannerPanel.ResumeLayout(False)
        Me.opcionesTable.ResumeLayout(False)
        Me.PrincipalPanel.ResumeLayout(False)
        Me.BusquedaIdPanel.ResumeLayout(False)
        Me.BusquedaIdPanel.PerformLayout()
        Me.BusquedaPanel.ResumeLayout(False)
        Me.BusquedaPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bannerPanel As System.Windows.Forms.Panel
    Friend WithEvents opcionesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents PrincipalPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BusquedaIdPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FamiliaV As System.Windows.Forms.TextBox
    Friend WithEvents MiembroV As System.Windows.Forms.TextBox
    Friend WithEvents FamiliaL As System.Windows.Forms.Label
    Friend WithEvents MiembroL As System.Windows.Forms.Label
    Friend WithEvents BusquedaPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InfoEducLink As System.Windows.Forms.LinkLabel
    Friend WithEvents OtraInfoLink As System.Windows.Forms.LinkLabel
    Friend WithEvents otrasBusquedasL As System.Windows.Forms.Label
End Class
