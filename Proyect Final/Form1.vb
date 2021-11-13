Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Dim N As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        N = N + 1
        ProgressBar1.Value = N
        Label4.Text = N.ToString
        If N = 100 Then
            Timer1.Stop()
            Me.Hide()
            FrmLogin.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class
