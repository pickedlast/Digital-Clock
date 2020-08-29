Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        REM get the time
        Dim time As String
        time = Format$(Now, "Long Time")
        REM display the time
        Label1.Text = time
    End Sub
End Class
