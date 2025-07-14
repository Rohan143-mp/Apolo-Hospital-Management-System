Public Class Appointment
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Patient.TextBox9.Text
        TextBox2.Text = Patient.TextBox8.Text
        TextBox3.Text = Regisration.TextBox4.Text
        TextBox4.Text = Patient.TextBox12.Text
        TextBox5.Text = Patient.TextBox10.Text
        TextBox6.Text = Patient.TextBox11.Text
        TextBox7.Text = Patient.DateTimePicker1.Text
        TextBox8.Text = Payment.TextBox1.Text
        TextBox9.Text = doctor.ComboBox1.SelectedItem
        TextBox10.Text = doctor.ComboBox2.SelectedItem
        TextBox11.Text = doctor.ComboBox3.SelectedItem

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Payment.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Not Available", MsgBoxStyle.OkOnly, "Server Not Found")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class