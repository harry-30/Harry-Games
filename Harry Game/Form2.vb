Public Class Form2
    Dim x As Integer
    Dim y As Integer
    Dim mode As Boolean = False
    Dim monster As Integer
    Dim count As Integer
    Dim coin As Integer
    Dim dir As Boolean = False
    Dim di As Boolean = False
    Public point As Integer
    Dim fire As Integer
    Dim collect As Integer

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If mode = False Then

        Else
            If Asc(e.KeyChar) <> 119 And Asc(e.KeyChar) <> 65 And Asc(e.KeyChar) <> 68 And Asc(e.KeyChar) <> 115 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 119 And pic.Location.Y > -1 Then
                pic.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y - 25)
                If Timer2.Enabled = False Then
                    pic2.Location = pic.Location
                Else

                End If
            End If
            If Asc(e.KeyChar) = 115 And pic.Location.X >= -30 And pic.Location.X <= 620 Then
                Timer2.Enabled = True
            ElseIf Asc(e.KeyChar) <> 115 Then
                If Asc(e.KeyChar) = 97 And pic.Location.X >= 0 And pic.Location.X <= 650 Then
                    pic.Location = New System.Drawing.Point(pic.Location.X - 20, pic.Location.Y)
                    If Timer2.Enabled = False Then
                        pic2.Location = pic.Location
                    Else

                    End If
                End If
                If Asc(e.KeyChar) = 100 And pic.Location.X >= -20 And pic.Location.X <= 620 Then
                    pic.Location = New System.Drawing.Point(pic.Location.X + 20, pic.Location.Y)
                    If Timer2.Enabled = False Then
                        pic2.Location = pic.Location
                    Else

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then 'And pic.Location.Y = 424

        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer2.Enabled = False Then
            If pic.Location.Y < 424 Then
                pic.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y + 10)
                pic2.Location = pic.Location
            Else

            End If
        ElseIf Timer2.Enabled = True Then
            If pic.Location.Y < 424 Then
                pic.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y + 10)
            Else

            End If
        End If

        go()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If pic2.Location.Y <= 440 And pic2.Location.X >= -30 And pic2.Location.X <= 650 Then
            pic2.Location = New System.Drawing.Point(pic2.Location.X + 15, pic2.Location.Y)
        End If
        If pic2.Location.X >= 650 Then
            pic2.Location = pic.Location
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mode = True
        Button1.Visible = False
        Timer3.Enabled = True
        Timer4.Enabled = True
        Timer5.Enabled = True
        Timer7.Enabled = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mode = False
        l.Text = Form4.TextBox1.Text
        Timer8.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If b1.Location.X > 2 And b1.Location.Y = 12 And b4.Location = b4o.Location Then
            b1.Location = New System.Drawing.Point(b1.Location.X - 25, b1.Location.Y)
        ElseIf b1.Location.X <= 2 And b1.Location.Y = 12 Then
            b1.Location = b1o.Location
        End If

        If b2.Location.X > 2 And b2.Location.Y = 280 And b4.Location = b4o.Location Then
            b2.Location = New System.Drawing.Point(b2.Location.X - 25, b2.Location.Y)
        ElseIf b2.Location.X <= 2 And b2.Location.Y = 280 Then
            b2.Location = b2o.Location
        End If

        If b3.Location.X > 2 And b3.Location.Y = 145 And b1.Location = b1o.Location Then
            b3.Location = New System.Drawing.Point(b3.Location.X - 25, b3.Location.Y)
        ElseIf b3.Location.X <= 2 And b3.Location.Y = 145 Then
            b3.Location = b3o.Location
        End If

        If b4.Location.X > 2 And b4.Location.Y = 415 And b1.Location = b1o.Location Then
            b4.Location = New System.Drawing.Point(b4.Location.X - 25, b4.Location.Y)
        ElseIf b4.Location.X <= 2 And b4.Location.Y = 415 Then
            b4.Location = b4o.Location
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If fire = 1 Then
            m1.Location = m10.Location
            count = count + 1
            fire = 0
        End If

        If monster > 15 And m1.Location.X > 362 And count Mod 2 = 0 Then
            m1.Location = New System.Drawing.Point(m1.Location.X - 10, m1.Location.Y + 10)
        ElseIf m1.Location.X <= 362 And m1.Location.X > 0 And count Mod 2 = 0 Then
            m1.Location = New System.Drawing.Point(m1.Location.X - 10, m1.Location.Y - 10)
        ElseIf m1.Location.X <= 0 Or fire = 1 Then
            m1.Location = m10.Location
            count = count + 1
            fire = 0
        End If

        If monster > 15 And m2.Location.X > 362 And count Mod 2 = 1 Then
            m2.Location = New System.Drawing.Point(m2.Location.X - 10, m2.Location.Y - 10)
        ElseIf m2.Location.X <= 362 And m2.Location.X > 0 And count Mod 2 = 1 Then
            m2.Location = New System.Drawing.Point(m2.Location.X - 10, m2.Location.Y + 10)
        ElseIf m2.Location.X <= 0 Or fire = 1 Then
            m2.Location = m20.Location
            count = count + 1
            fire = 0
        End If

        If c1.Location.X = 10 Then
            dir = True
        ElseIf c1.Location.X = 190 Then
            dir = False
        End If
        If c2.Location.X = 510 Then
            di = False
        ElseIf c2.Location.X = 330 Then
            di = True
        End If

        If c1.Location.Y <= 10 Then
            c1.Location = c10.Location
            coin = coin + 1
            dir = False
            collect = 0
        ElseIf collect = 1 Then
            c1.Location = c10.Location
            coin = coin + 1
            dir = False
            collect = 0
        End If

        If c1.Location.Y >= 10 And coin Mod 2 = 0 And dir = False And c2.Location = c20.Location Then
            c1.Location = New System.Drawing.Point(c1.Location.X - 10, c1.Location.Y - 10)
        ElseIf c1.Location.Y >= 10 And dir = True And c2.Location = c20.Location Then
            c1.Location = New System.Drawing.Point(c1.Location.X + 10, c1.Location.Y - 10)
        ElseIf c1.Location.Y <= 10 Then
            c1.Location = c10.Location
            coin = coin + 1
            dir = False
            collect = 0
        ElseIf collect = 1 Then
            c1.Location = c10.Location
            coin = coin + 1
            dir = False
            collect = 0
        End If

        If c2.Location.Y >= 10 And coin Mod 2 = 1 And di = False And c1.Location = c10.Location Then
            c2.Location = New System.Drawing.Point(c2.Location.X - 10, c2.Location.Y - 10)
        ElseIf c2.Location.Y >= 10 And di = True And c1.Location = c10.Location Then
            c2.Location = New System.Drawing.Point(c2.Location.X + 10, c2.Location.Y - 10)
        ElseIf c2.Location.Y <= 10 Then
            c2.Location = c20.Location
            coin = coin + 1
            di = False
            collect = 0
        ElseIf collect = 1 Then
            c2.Location = c20.Location
            coin = coin + 1
            di = False
            collect = 0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        monster = monster + 1
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        l.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y - 20)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        point = point + 100
    End Sub

    Private Sub go()
        If pic.Location.X >= b1.Location.X - 30 And pic.Location.X <= b1.Location.X + 210 And pic.Location.Y >= b1.Location.Y - 50 And pic.Location.Y <= b1.Location.Y + 80 Then
            Me.Hide()
            Form3.Show()
        ElseIf pic.Location.X >= b2.Location.X - 30 And pic.Location.X <= b2.Location.X + 210 And pic.Location.Y >= b2.Location.Y - 50 And pic.Location.Y <= b2.Location.Y + 80 Then
            Me.Hide()
            Form3.Show()
        ElseIf pic.Location.X >= b3.Location.X - 30 And pic.Location.X <= b3.Location.X + 210 And pic.Location.Y >= b3.Location.Y - 50 And pic.Location.Y <= b3.Location.Y + 80 Then
            Me.Hide()
            Form3.Show()
        ElseIf pic.Location.X >= b4.Location.X - 30 And pic.Location.X <= b4.Location.X + 210 And pic.Location.Y >= b4.Location.Y - 50 And pic.Location.Y <= b4.Location.Y + 80 Then
            Me.Hide()
            Form3.Show()
        End If

        If pic.Location.X >= m1.Location.X - 50 And pic.Location.X <= m1.Location.X + 60 And pic.Location.Y <= m1.Location.Y + 60 And pic.Location.Y >= m1.Location.Y - 40 And pic.Location = pic2.Location Then
            Me.Hide()
            Form3.Show()
        End If

        If pic.Location.X >= m2.Location.X - 50 And pic.Location.X <= m2.Location.X + 60 And pic.Location.Y <= m2.Location.Y + 60 And pic.Location.Y >= m2.Location.Y - 40 And pic.Location = pic2.Location Then
            Me.Hide()
            Form3.Show()
        End If

        If pic.Location.X >= c1.Location.X - 50 And pic.Location.X <= c1.Location.X And pic.Location.Y <= c1.Location.Y + 60 And pic.Location.Y >= c1.Location.Y - 40 Then
            point = point + 200
            c1.Location = c10.Location
            collect = 1
        End If

        If pic.Location.X >= c2.Location.X - 50 And pic.Location.X <= c2.Location.X And pic.Location.Y <= c2.Location.Y + 60 And pic.Location.Y >= c2.Location.Y - 40 Then
            point = point + 200
            c2.Location = c20.Location
            collect = 1
        End If

        If pic2.Location.X <= m1.Location.X + 60 And pic2.Location.X >= m1.Location.X And pic2.Location.Y <= m1.Location.Y + 60 And pic2.Location.Y >= m1.Location.Y - 30 And pic.Location <> pic2.Location Then
            fire = 1
            point = point + 200
            m1.Location = m10.Location
        ElseIf pic2.Location.X <= m2.Location.X + 60 And pic2.Location.X >= m2.Location.X And pic2.Location.Y <= m2.Location.Y + 60 And pic2.Location.Y >= m2.Location.Y - 30 And pic.Location <> pic2.Location Then
            fire = 1
            point = point + 200
            m2.Location = m20.Location
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        go()
        Label2.Text = point
    End Sub
End Class