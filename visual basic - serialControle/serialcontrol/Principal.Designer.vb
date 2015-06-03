<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Controlserial
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
        Me.components = New System.ComponentModel.Container()
        Me.Btnf = New System.Windows.Forms.Button()
        Me.btne = New System.Windows.Forms.Button()
        Me.btnd = New System.Windows.Forms.Button()
        Me.btnt = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cmb_porta = New System.Windows.Forms.ComboBox()
        Me.cmb_vel = New System.Windows.Forms.ComboBox()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ovl_2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovl_1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.btnopc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb_db5 = New System.Windows.Forms.RadioButton()
        Me.rdb_db6 = New System.Windows.Forms.RadioButton()
        Me.rdb_db7 = New System.Windows.Forms.RadioButton()
        Me.rdb_db8 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_sb2 = New System.Windows.Forms.RadioButton()
        Me.rdb_sb1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.rdb_cfN = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.rdb_P = New System.Windows.Forms.RadioButton()
        Me.tmrserial = New System.Windows.Forms.Timer(Me.components)
        Me.txtmens = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnf
        '
        Me.Btnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnf.Location = New System.Drawing.Point(123, 125)
        Me.Btnf.Name = "Btnf"
        Me.Btnf.Size = New System.Drawing.Size(54, 33)
        Me.Btnf.TabIndex = 0
        Me.Btnf.Text = ".^"
        Me.Btnf.UseVisualStyleBackColor = True
        '
        'btne
        '
        Me.btne.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btne.Location = New System.Drawing.Point(89, 159)
        Me.btne.Name = "btne"
        Me.btne.Size = New System.Drawing.Size(39, 33)
        Me.btne.TabIndex = 1
        Me.btne.Text = "<"
        Me.btne.UseVisualStyleBackColor = True
        '
        'btnd
        '
        Me.btnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnd.Location = New System.Drawing.Point(172, 159)
        Me.btnd.Name = "btnd"
        Me.btnd.Size = New System.Drawing.Size(39, 33)
        Me.btnd.TabIndex = 2
        Me.btnd.Text = ">"
        Me.btnd.UseVisualStyleBackColor = True
        '
        'btnt
        '
        Me.btnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnt.Location = New System.Drawing.Point(123, 192)
        Me.btnt.Name = "btnt"
        Me.btnt.Size = New System.Drawing.Size(54, 33)
        Me.btnt.TabIndex = 3
        Me.btnt.Text = "V"
        Me.btnt.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'cmb_porta
        '
        Me.cmb_porta.FormattingEnabled = True
        Me.cmb_porta.Location = New System.Drawing.Point(69, 13)
        Me.cmb_porta.Name = "cmb_porta"
        Me.cmb_porta.Size = New System.Drawing.Size(112, 21)
        Me.cmb_porta.TabIndex = 4
        '
        'cmb_vel
        '
        Me.cmb_vel.FormattingEnabled = True
        Me.cmb_vel.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200"})
        Me.cmb_vel.Location = New System.Drawing.Point(69, 41)
        Me.cmb_vel.Name = "cmb_vel"
        Me.cmb_vel.Size = New System.Drawing.Size(112, 21)
        Me.cmb_vel.TabIndex = 5
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(188, 13)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(83, 23)
        Me.btn_open.TabIndex = 6
        Me.btn_open.Text = "Conectar"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Porta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Velocidade"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1, Me.LineShape1, Me.ovl_2, Me.ovl_1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(448, 262)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Trellis
        Me.OvalShape1.Location = New System.Drawing.Point(136, 163)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(28, 25)
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 290
        Me.LineShape1.X2 = 290
        Me.LineShape1.Y1 = 15
        Me.LineShape1.Y2 = 252
        '
        'ovl_2
        '
        Me.ovl_2.BackColor = System.Drawing.SystemColors.Control
        Me.ovl_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ovl_2.FillColor = System.Drawing.Color.Yellow
        Me.ovl_2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl_2.Location = New System.Drawing.Point(232, 42)
        Me.ovl_2.Name = "ovl_2"
        Me.ovl_2.Size = New System.Drawing.Size(21, 20)
        '
        'ovl_1
        '
        Me.ovl_1.BackColor = System.Drawing.Color.Red
        Me.ovl_1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ovl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ovl_1.FillColor = System.Drawing.Color.LightGreen
        Me.ovl_1.FillGradientColor = System.Drawing.Color.White
        Me.ovl_1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovl_1.Location = New System.Drawing.Point(202, 42)
        Me.ovl_1.Name = "ovl_1"
        Me.ovl_1.Size = New System.Drawing.Size(21, 20)
        '
        'btnopc
        '
        Me.btnopc.Location = New System.Drawing.Point(70, 68)
        Me.btnopc.Name = "btnopc"
        Me.btnopc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnopc.Size = New System.Drawing.Size(201, 22)
        Me.btnopc.TabIndex = 10
        Me.btnopc.Text = "Opções    >>>>>"
        Me.btnopc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb_db5)
        Me.GroupBox1.Controls.Add(Me.rdb_db6)
        Me.GroupBox1.Controls.Add(Me.rdb_db7)
        Me.GroupBox1.Controls.Add(Me.rdb_db8)
        Me.GroupBox1.Location = New System.Drawing.Point(301, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(84, 62)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Bits"
        '
        'rdb_db5
        '
        Me.rdb_db5.AutoSize = True
        Me.rdb_db5.Location = New System.Drawing.Point(43, 36)
        Me.rdb_db5.Name = "rdb_db5"
        Me.rdb_db5.Size = New System.Drawing.Size(31, 17)
        Me.rdb_db5.TabIndex = 3
        Me.rdb_db5.Text = "5"
        Me.rdb_db5.UseVisualStyleBackColor = True
        '
        'rdb_db6
        '
        Me.rdb_db6.AutoSize = True
        Me.rdb_db6.Location = New System.Drawing.Point(43, 19)
        Me.rdb_db6.Name = "rdb_db6"
        Me.rdb_db6.Size = New System.Drawing.Size(31, 17)
        Me.rdb_db6.TabIndex = 2
        Me.rdb_db6.Text = "6"
        Me.rdb_db6.UseVisualStyleBackColor = True
        '
        'rdb_db7
        '
        Me.rdb_db7.AutoSize = True
        Me.rdb_db7.Location = New System.Drawing.Point(6, 36)
        Me.rdb_db7.Name = "rdb_db7"
        Me.rdb_db7.Size = New System.Drawing.Size(31, 17)
        Me.rdb_db7.TabIndex = 1
        Me.rdb_db7.Text = "7"
        Me.rdb_db7.UseVisualStyleBackColor = True
        '
        'rdb_db8
        '
        Me.rdb_db8.AutoSize = True
        Me.rdb_db8.Checked = True
        Me.rdb_db8.Location = New System.Drawing.Point(6, 19)
        Me.rdb_db8.Name = "rdb_db8"
        Me.rdb_db8.Size = New System.Drawing.Size(31, 17)
        Me.rdb_db8.TabIndex = 0
        Me.rdb_db8.TabStop = True
        Me.rdb_db8.Text = "8"
        Me.rdb_db8.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdb_sb2)
        Me.GroupBox2.Controls.Add(Me.rdb_sb1)
        Me.GroupBox2.Location = New System.Drawing.Point(303, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(84, 43)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stop Bits"
        '
        'rdb_sb2
        '
        Me.rdb_sb2.AutoSize = True
        Me.rdb_sb2.Location = New System.Drawing.Point(43, 19)
        Me.rdb_sb2.Name = "rdb_sb2"
        Me.rdb_sb2.Size = New System.Drawing.Size(31, 17)
        Me.rdb_sb2.TabIndex = 2
        Me.rdb_sb2.Text = "2"
        Me.rdb_sb2.UseVisualStyleBackColor = True
        '
        'rdb_sb1
        '
        Me.rdb_sb1.AutoSize = True
        Me.rdb_sb1.Checked = True
        Me.rdb_sb1.Location = New System.Drawing.Point(6, 19)
        Me.rdb_sb1.Name = "rdb_sb1"
        Me.rdb_sb1.Size = New System.Drawing.Size(31, 17)
        Me.rdb_sb1.TabIndex = 0
        Me.rdb_sb1.TabStop = True
        Me.rdb_sb1.Text = "1"
        Me.rdb_sb1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton7)
        Me.GroupBox3.Controls.Add(Me.RadioButton9)
        Me.GroupBox3.Controls.Add(Me.rdb_cfN)
        Me.GroupBox3.Location = New System.Drawing.Point(303, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 62)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = "0"
        Me.GroupBox3.Text = "Controle Fluxo"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(63, 36)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton5.TabIndex = 3
        Me.RadioButton5.Tag = "3"
        Me.RadioButton5.Text = "sr485"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(63, 19)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton7.TabIndex = 2
        Me.RadioButton7.Tag = "1"
        Me.RadioButton7.Text = "rts/cts"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(6, 36)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton9.TabIndex = 1
        Me.RadioButton9.Tag = "2"
        Me.RadioButton9.Text = "dtr/dsr"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'rdb_cfN
        '
        Me.rdb_cfN.AutoSize = True
        Me.rdb_cfN.Checked = True
        Me.rdb_cfN.Location = New System.Drawing.Point(6, 19)
        Me.rdb_cfN.Name = "rdb_cfN"
        Me.rdb_cfN.Size = New System.Drawing.Size(51, 17)
        Me.rdb_cfN.TabIndex = 0
        Me.rdb_cfN.TabStop = True
        Me.rdb_cfN.Text = "None"
        Me.rdb_cfN.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton11)
        Me.GroupBox4.Controls.Add(Me.RadioButton12)
        Me.GroupBox4.Controls.Add(Me.RadioButton13)
        Me.GroupBox4.Controls.Add(Me.rdb_P)
        Me.GroupBox4.Location = New System.Drawing.Point(301, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(134, 57)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Paridade"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(63, 36)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton11.TabIndex = 3
        Me.RadioButton11.Tag = "4"
        Me.RadioButton11.Text = "Espaco"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(63, 19)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton12.TabIndex = 2
        Me.RadioButton12.Tag = "1"
        Me.RadioButton12.Text = "Odd"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(6, 36)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton13.TabIndex = 1
        Me.RadioButton13.Tag = "2"
        Me.RadioButton13.Text = "Even"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'rdb_P
        '
        Me.rdb_P.AutoSize = True
        Me.rdb_P.Checked = True
        Me.rdb_P.Location = New System.Drawing.Point(6, 19)
        Me.rdb_P.Name = "rdb_P"
        Me.rdb_P.Size = New System.Drawing.Size(51, 17)
        Me.rdb_P.TabIndex = 0
        Me.rdb_P.TabStop = True
        Me.rdb_P.Tag = "0"
        Me.rdb_P.Text = "None"
        Me.rdb_P.UseVisualStyleBackColor = True
        '
        'tmrserial
        '
        '
        'txtmens
        '
        Me.txtmens.BackColor = System.Drawing.Color.ForestGreen
        Me.txtmens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmens.Enabled = False
        Me.txtmens.Font = New System.Drawing.Font("Courier New", 11.75!)
        Me.txtmens.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtmens.Location = New System.Drawing.Point(6, 230)
        Me.txtmens.Name = "txtmens"
        Me.txtmens.Size = New System.Drawing.Size(96, 25)
        Me.txtmens.TabIndex = 14
        Me.txtmens.Text = "444"
        Me.txtmens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Controlserial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 262)
        Me.Controls.Add(Me.txtmens)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnopc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.cmb_vel)
        Me.Controls.Add(Me.cmb_porta)
        Me.Controls.Add(Me.btnt)
        Me.Controls.Add(Me.btnd)
        Me.Controls.Add(Me.btne)
        Me.Controls.Add(Me.Btnf)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_Controlserial"
        Me.Text = "Controle serial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnf As System.Windows.Forms.Button
    Friend WithEvents btne As System.Windows.Forms.Button
    Friend WithEvents btnd As System.Windows.Forms.Button
    Friend WithEvents btnt As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cmb_porta As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_vel As System.Windows.Forms.ComboBox
    Friend WithEvents btn_open As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ovl_2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovl_1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnopc As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_db8 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_db5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_db6 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_db7 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_sb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_sb1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_cfN As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_P As System.Windows.Forms.RadioButton
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents tmrserial As System.Windows.Forms.Timer
    Friend WithEvents txtmens As System.Windows.Forms.TextBox

End Class
