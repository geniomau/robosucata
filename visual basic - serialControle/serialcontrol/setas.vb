Public Class setas

    Private Sub setas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Frm_Controlserial.Show()

    End Sub

    Private Sub setas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'MsgBox(e.KeyCode)
        If e.KeyCode = 37 Then

        End If

        Select Case e.KeyCode
            Case 37
                pcbe.Visible = 1
                Frm_Controlserial.escreve("E")
            Case 38
                pcbf.Visible = 1
                Frm_Controlserial.escreve("F")
            Case 39
                pcbd.Visible = 1
                Frm_Controlserial.escreve("D")
            Case 40
                pcbt.Visible = 1
                Frm_Controlserial.escreve("T")
            Case Else
                MsgBox("Use as teclas direcionais - setas", MsgBoxStyle.Information, "Atenção")
        End Select

    End Sub

    Private Sub setas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub setas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = 37 Then

        End If

        Select Case e.KeyCode
            Case 37
                pcbe.Visible = 0
                Debug.Print("nada")

                Frm_Controlserial.para()
            Case 38
                pcbf.Visible = 0
                Frm_Controlserial.para()
            Case 39
                pcbd.Visible = 0
                Frm_Controlserial.para()
            Case 40
                pcbt.Visible = 0
                Frm_Controlserial.para()
            Case Else
                ' MsgBox("Use as teclas direcionais - setas", MsgBoxStyle.Information, "Atenção")
        End Select
    End Sub


End Class