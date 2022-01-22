Public Class Form4
    Dim red, green, yellow, blue As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.BackColor = Color.Azure
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
        go()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            go()
        End If
    End Sub

    Private Sub go()
        If TextBox1.Text = "" Then
            MsgBox("You cannot play without naming your character", MsgBoxStyle.Information, "Oops..")
        Else
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class