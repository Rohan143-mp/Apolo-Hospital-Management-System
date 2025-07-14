Public Class doctor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Patient.Show()
        Me.Hide()

    End Sub

    Private Sub doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("DR.Rohan M Pednekar")
        ComboBox1.Items.Add("DR.Raj S Bhonkar")
        ComboBox1.Items.Add("DR.Soham Bhosale")

        ComboBox2.Items.Add("1 Years")
        ComboBox2.Items.Add("2 Years")
        ComboBox2.Items.Add("3 Years")
        ComboBox2.Items.Add("4 Years")
        ComboBox2.Items.Add("5 Years")
        ComboBox2.Items.Add("6 Years")
        ComboBox2.Items.Add("7 Years")
        ComboBox2.Items.Add("8 Years")
        ComboBox2.Items.Add("9 Years")
        ComboBox2.Items.Add("Above 10 Years")

        ComboBox3.Items.Add("PEDIATRICIAN")
        ComboBox3.Items.Add("CARDIOLOGIST")
        ComboBox3.Items.Add("NEUROLOGIST")
        ComboBox3.Items.Add("GYNACOLOGIST")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Payment.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class