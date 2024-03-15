Public Class Form1

    Dim checker As Boolean
    Dim plusone As Integer

    Private Sub Enable_False()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button6.Enabled = False
        Button4.Enabled = False
        Button7.Enabled = False
        Button5.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False


    End Sub

    Private Sub score()
        If (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Then
            Button1.BackColor = System.Drawing.Color.PowderBlue
            Button2.BackColor = Color.PowderBlue
            Button3.BackColor = Color.PowderBlue
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Then
            Button1.BackColor = System.Drawing.Color.Pink
            Button4.BackColor = Color.Pink
            Button7.BackColor = Color.Pink
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Then
            Button1.BackColor = System.Drawing.Color.Red
            Button5.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            Button3.BackColor = System.Drawing.Color.Green
            Button5.BackColor = Color.Green
            Button7.BackColor = Color.Green
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Then
            Button2.BackColor = System.Drawing.Color.Yellow
            Button5.BackColor = Color.Yellow
            Button8.BackColor = Color.Yellow
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Then
            Button3.BackColor = System.Drawing.Color.Orange
            Button6.BackColor = Color.Orange
            Button9.BackColor = Color.Orange
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Then
            Button4.BackColor = System.Drawing.Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Then
            Button7.BackColor = System.Drawing.Color.GreenYellow
            Button8.BackColor = Color.GreenYellow
            Button9.BackColor = Color.GreenYellow
            MessageBox.Show("The Winner Is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Then
            Button1.BackColor = System.Drawing.Color.PowderBlue
            Button2.BackColor = Color.PowderBlue
            Button3.BackColor = Color.PowderBlue
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Then
            Button1.BackColor = System.Drawing.Color.Pink
            Button4.BackColor = Color.Pink
            Button7.BackColor = Color.Pink
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Then
            Button1.BackColor = System.Drawing.Color.Red
            Button5.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            Button3.BackColor = System.Drawing.Color.Green
            Button5.BackColor = Color.Green
            Button7.BackColor = Color.Green
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Then
            Button2.BackColor = System.Drawing.Color.Yellow
            Button5.BackColor = Color.Yellow
            Button8.BackColor = Color.Yellow
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Then
            Button3.BackColor = System.Drawing.Color.Orange
            Button6.BackColor = Color.Orange
            Button9.BackColor = Color.Orange
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Then
            Button4.BackColor = System.Drawing.Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
        If (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Then
            Button7.BackColor = System.Drawing.Color.GreenYellow
            Button8.BackColor = Color.GreenYellow
            Button9.BackColor = Color.GreenYellow
            MessageBox.Show("The Winner Is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (checker = False) Then
            Button1.Text = "X"
            checker = True
        Else
            Button1.Text = "O"
            checker = False
        End If
        score()
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (checker = False) Then
            Button2.Text = "X"
            checker = True
        Else
            Button2.Text = "O"
            checker = False
        End If
        score()
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (checker = False) Then
            Button3.Text = "X"
            checker = True
        Else
            Button3.Text = "O"
            checker = False
        End If
        score()
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (checker = False) Then
            Button4.Text = "X"
            checker = True
        Else
            Button4.Text = "O"
            checker = False
        End If
        score()
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (checker = False) Then
            Button5.Text = "X"
            checker = True
        Else
            Button5.Text = "O"
            checker = False
        End If
        score()
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (checker = False) Then
            Button6.Text = "X"
            checker = True
        Else
            Button6.Text = "O"
            checker = False
        End If
        score()
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (checker = False) Then
            Button7.Text = "X"
            checker = True
        Else
            Button7.Text = "O"
            checker = False
        End If
        score()
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (checker = False) Then
            Button8.Text = "X"
            checker = True
        Else
            Button8.Text = "O"
            checker = False
        End If
        score()
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (checker = False) Then
            Button9.Text = "X"
            checker = True
        Else
            Button9.Text = "O"
            checker = False
        End If
        score()
        Button9.Enabled = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button6.Enabled = True
        Button4.Enabled = True
        Button7.Enabled = True
        Button5.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        lblPlayerX.Text = "0"
        lblPlayerO.Text = "0"

        Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Button2.BackColor = Color.WhiteSmoke
        Button3.BackColor = Color.WhiteSmoke
        Button4.BackColor = Color.WhiteSmoke
        Button5.BackColor = Color.WhiteSmoke
        Button6.BackColor = Color.WhiteSmoke
        Button7.BackColor = Color.WhiteSmoke
        Button8.BackColor = Color.WhiteSmoke
        Button9.BackColor = Color.WhiteSmoke


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button6.Enabled = True
        Button4.Enabled = True
        Button7.Enabled = True
        Button5.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button12.Enabled = True

        Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Button2.BackColor = Color.WhiteSmoke
        Button3.BackColor = Color.WhiteSmoke
        Button4.BackColor = Color.WhiteSmoke
        Button5.BackColor = Color.WhiteSmoke
        Button6.BackColor = Color.WhiteSmoke
        Button7.BackColor = Color.WhiteSmoke
        Button8.BackColor = Color.WhiteSmoke
        Button9.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to exit", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
