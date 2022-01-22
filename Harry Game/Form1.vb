Public Class Form1
    Dim red, green, yellow, blue As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.BackColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        red = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)

        l1.ForeColor = Color.FromArgb(red, green, yellow, blue)
        red = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class
