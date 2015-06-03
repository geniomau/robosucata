Imports System
Imports System.IO.Ports

Public Class Frm_Controlserial
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_vel.Text = SerialPort1.BaudRate
        Dim portas() As String
        portas = IO.Ports.SerialPort.GetPortNames
        cmb_porta.Items.AddRange(portas)
        cmb_porta.Text = SerialPort1.PortName
        'cmb_porta.Items.CopyTo(portas, 0)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_db8.CheckedChanged

    End Sub

    Private Sub btnopc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopc.Click
        If (Me.Width = 460) Then
            Me.Width = 300
            btnopc.Text = "Opções  >>>>>>"
        Else
            Me.Width = 460
            btnopc.Text = "<<<< Fechar Opções"
        End If
    End Sub



    Private Sub btn_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_open.Click
        Try


            If Not SerialPort1.IsOpen And cmb_porta.SelectedIndex > 0 And cmb_vel.SelectedIndex > 0 And btn_open.Text = "Conectar" Then
                With SerialPort1
                    .PortName = cmb_porta.SelectedItem.ToString
                    .BaudRate = cmb_vel.SelectedItem.ToString
                    If (rdb_sb1.Checked) Then
                        .StopBits = IO.Ports.StopBits.One
                    Else
                        .StopBits = IO.Ports.StopBits.Two
                    End If
                    .ReadTimeout = 7000
                    .WriteTimeout = 7000
                End With

                With GroupBox1.Controls
                    For j = 0 To .Count - 1
                        If DirectCast(.Item(j), RadioButton).Checked = True Then
                            SerialPort1.DataBits = .Item(j).Text
                        End If
                    Next
                End With

                With GroupBox3.Controls
                    For j = 0 To .Count - 1
                        If DirectCast(.Item(j), RadioButton).Checked = True Then
                            SerialPort1.Handshake = .Item(j).Tag
                        End If
                    Next
                End With
                With GroupBox4.Controls
                    For j = 0 To .Count - 1
                        If DirectCast(.Item(j), RadioButton).Checked = True Then
                            SerialPort1.Parity = .Item(j).Tag
                        End If
                    Next
                End With
                SerialPort1.Open()
                ovl_1.FillColor = Color.Red
                'btn_open.Enabled = False
                cmb_porta.Enabled = False
                cmb_vel.Enabled = False
                btn_open.Text = "Desconectar"

            ElseIf btn_open.Text = "Desconectar" Then

                SerialPort1.Close()
                ovl_1.FillColor = Color.LightGreen
                cmb_porta.Enabled = 1
                cmb_vel.Enabled = 1
                btn_open.Text = "Conectar"

            End If



        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show(ex.Message)

        Catch ex As System.IO.IOException
            MessageBox.Show(ex.Message)

        End Try

    End Sub



    Private Sub cmb_porta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_porta.SelectedIndexChanged
        SerialPort1.PortName = cmb_porta.SelectedItem.ToString
    End Sub

    Private Sub SendSlave(ByVal sendCmd As Byte, ByVal sendData As Byte)
        'send command to slave PICmicro in form of cmd, data 
        Dim buffer(2) As Byte
        buffer(0) = sendCmd
        buffer(1) = sendData
        SerialPort1.Write(buffer, 0, 2)
    End Sub
    'To send one byte, use this. 
    '   Dim buffer() As Byte = {1}
    'mySerialPort.Write(buffer, 0, 1) 
    'mySerialPort.Write(buffer, 0, 1) 
    'To read one line (blocking). 
    '    Dim returnValue As String
    ' returnValue = mySerialPort.ReadLine
    'To read one byte (blocking). 
    ' Dim returnValue As Integer
    'returnValue = mySerialPort.ReadByte


    Public Sub escreve(ByVal letra As String)
        Try

            SerialPort1.Write(letra)
            tmrserial.Start()
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show(ex.Message)

        Catch ex As System.IO.IOException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub para()
        Try

            SerialPort1.Write("P")
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show(ex.Message)

        Catch ex As System.IO.IOException
            MessageBox.Show(ex.Message)

        End Try
        tmrserial.Stop()
        ovl_2.FillColor = Color.Yellow
    End Sub


    Private Sub Btnf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnf.Click
        'SerialPort1.Write("P")
        para()

    End Sub
    Private Sub Btnf_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Btnf.MouseDown
        escreve("F")
    End Sub




    Private Sub btne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btne.Click
        para()
    End Sub
    Private Sub btne_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btne.MouseDown
        escreve("E")
    End Sub

    Private Sub btnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnd.Click
        para()
    End Sub

    Private Sub btnd_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnd.MouseDown
        escreve("D")
    End Sub

    Private Sub btnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnt.Click
        para()
    End Sub

    Private Sub btnt_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnt.MouseDown
        escreve("T")
    End Sub


    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click

        If btn_open.Text = "Desconectar" Then
            setas.Show()
            Me.Hide()
        Else
            MsgBox("Primeiro conclua a conexão.", MsgBoxStyle.Information, "Atenção")
        End If

    End Sub

    Private Sub tmrserial_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrserial.Tick
        'ovl_2.FillColor = Color.LightGreen
        If ovl_2.FillColor = Color.Yellow Then
            ovl_2.FillColor = Color.Lime
        Else
            ovl_2.FillColor = Color.Yellow
        End If
    End Sub
    Public Sub vermens(ByVal mens As String)

        txtmens.Text = mens

        ' txtn.Text = mens
    End Sub

    Public Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Try
            recebetext(SerialPort1.ReadExisting())
         

        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show(ex.Message)

        Catch ex As System.IO.IOException
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub recebetext(ByVal [text] As String)
        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.txtmens.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf recebetext)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.txtmens.Text &= [text]
        End If
    End Sub
End Class


