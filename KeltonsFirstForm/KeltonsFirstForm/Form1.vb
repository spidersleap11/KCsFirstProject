Public Class Form1
    Public Sub RefreshLabel()
        Label1.Text = A
        Label2.Text = B
        Label3.Text = C
    End Sub
    Dim A = 0
    Dim B = 0
    Dim C = 0
    Dim D = 0
    Dim J = 0
    Dim F = 0
    Dim G = 0
    Dim H = 0
    Dim I = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = A
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = B

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = C
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = D
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label5.Text = J
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label6.Text = F
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Label7.Text = G
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Label8.Text = H
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Label9.Text = I
    End Sub

    Private Sub AddToCorners_Click(sender As Object, e As EventArgs) Handles AddToCorners.Click
        A = A + 1
        C = C + 1
        G = G + 1
        I = I + 1
    End Sub

    Private Sub AddToOutside_Click(sender As Object, e As EventArgs) Handles AddToOutside.Click
        A = A + 1
        B = B + 1
        C = C + 1
        D = D + 1
        F = F + 1
        G = G + 1
        H = H + 1
        I = I + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        D = D + 1
        J = J + 1
        F = F + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        B = B + 1
        J = J + 1
        H = H + 1
    End Sub
End Class
