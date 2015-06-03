<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setas))
        Me.pcbd = New System.Windows.Forms.PictureBox()
        Me.pcbe = New System.Windows.Forms.PictureBox()
        Me.pcbf = New System.Windows.Forms.PictureBox()
        Me.pcbt = New System.Windows.Forms.PictureBox()
        CType(Me.pcbd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbd
        '
        Me.pcbd.Image = CType(resources.GetObject("pcbd.Image"), System.Drawing.Image)
        Me.pcbd.Location = New System.Drawing.Point(241, 131)
        Me.pcbd.Name = "pcbd"
        Me.pcbd.Size = New System.Drawing.Size(115, 112)
        Me.pcbd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbd.TabIndex = 0
        Me.pcbd.TabStop = False
        Me.pcbd.Visible = False
        '
        'pcbe
        '
        Me.pcbe.Image = CType(resources.GetObject("pcbe.Image"), System.Drawing.Image)
        Me.pcbe.Location = New System.Drawing.Point(21, 131)
        Me.pcbe.Name = "pcbe"
        Me.pcbe.Size = New System.Drawing.Size(115, 112)
        Me.pcbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbe.TabIndex = 1
        Me.pcbe.TabStop = False
        Me.pcbe.Visible = False
        '
        'pcbf
        '
        Me.pcbf.Image = CType(resources.GetObject("pcbf.Image"), System.Drawing.Image)
        Me.pcbf.Location = New System.Drawing.Point(135, 18)
        Me.pcbf.Name = "pcbf"
        Me.pcbf.Size = New System.Drawing.Size(115, 112)
        Me.pcbf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbf.TabIndex = 2
        Me.pcbf.TabStop = False
        Me.pcbf.Visible = False
        '
        'pcbt
        '
        Me.pcbt.Image = CType(resources.GetObject("pcbt.Image"), System.Drawing.Image)
        Me.pcbt.Location = New System.Drawing.Point(135, 242)
        Me.pcbt.Name = "pcbt"
        Me.pcbt.Size = New System.Drawing.Size(115, 112)
        Me.pcbt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbt.TabIndex = 3
        Me.pcbt.TabStop = False
        Me.pcbt.Visible = False
        '
        'setas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(375, 371)
        Me.Controls.Add(Me.pcbt)
        Me.Controls.Add(Me.pcbf)
        Me.Controls.Add(Me.pcbe)
        Me.Controls.Add(Me.pcbd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "setas"
        Me.Text = "setas"
        CType(Me.pcbd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbd As System.Windows.Forms.PictureBox
    Friend WithEvents pcbe As System.Windows.Forms.PictureBox
    Friend WithEvents pcbf As System.Windows.Forms.PictureBox
    Friend WithEvents pcbt As System.Windows.Forms.PictureBox
End Class
