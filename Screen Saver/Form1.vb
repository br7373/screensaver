Public Class Form1
    Dim time As Integer = 10

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        Static counter As Byte

        If time = 0 Then
            time = 0
            counter = counter + 1
        End If

        If counter = 1 Then
            counter = 0
            reset()
            Exit Sub
        End If

        time = time - 1
    End Sub
    Private Sub reset()
        Dim first As Single
        Dim second As Single

        Randomize()

        first = CInt(Int(350 * Rnd(+1)))
        second = CInt(Int(225 * Rnd(+1)))
        picBox1.Location = New Point(first, second)
    End Sub
End Class
