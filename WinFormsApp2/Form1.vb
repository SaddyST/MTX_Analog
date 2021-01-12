Imports System.IO
Public Class Form1
    Dim num() As String = New String(100) {}
    Dim Ex_s() As String
    Dim Parcer As New Parcer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Parcer.Connect_file()

        Ex_s = Parcer.qwe(num)
        For i As Integer = 0 To 10
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = Ex_s(ListBox1.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ex_s = Parcer.scan_otv(num)
    End Sub
End Class

