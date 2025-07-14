Public Class Patient


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        doctor.Show()
        Me.Hide()
        MsgBox("DETAIL ENTERED", MsgBoxStyle.OkOnly, "Doctor Detail")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        DateTimePicker1.ResetText()
    End Sub
End Class