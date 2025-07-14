Public Class Form2
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Regisration.Show()
        Me.Hide()
        Button6.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Payment.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Patient.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        doctor.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Not Available", MsgBoxStyle.OkOnly, "Under Development")
    End Sub


End Class