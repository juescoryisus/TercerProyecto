Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listas As New Listas()
        Me.Hide()
        listas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim listas As New Colas()
        Me.Hide()
        listas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim listas As New Stack()
        Me.Hide()
        listas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim listas As New Form2()
        Me.Hide()
        listas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim listas As New Form3()
        Me.Hide()
        listas.Show()
    End Sub
End Class
