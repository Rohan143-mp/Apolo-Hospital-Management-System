Public Class Regisration
    Dim hos, name, adds, desig, email As String
    Dim phone As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Registration successfully", MsgBoxStyle.OkOnly, "Registered")
        Form2.Show()
        Me.Hide()
    End Sub
End Class