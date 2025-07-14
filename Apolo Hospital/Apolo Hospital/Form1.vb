Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text = TextBox1.Text) Then
            MsgBox("Login Successfully", MsgBoxStyle.OkOnly, "Login page")
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Login Unsuccessfully", MsgBoxStyle.OkOnly, "Invalid Password")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
End Class
