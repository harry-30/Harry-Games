Public Class Form3
    Dim red, green, yellow, blue As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Beige
        Label4.Text = Form2.point
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        red = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)

        Label1.ForeColor = Color.FromArgb(red, green, yellow, blue)
        red = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form4.Close()
        Form2.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class