Imports System.IO
Public Class Form1
    Dim num() As String = New String(999) {}
    Dim Ex_s() As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Parcer As New Parcer
        Parcer.Connect_file()

        Ex_s = Parcer.qwe(num)
        For i As Integer = 0 To 10
            If (Ex_s IsNot Nothing) Then
                If (Ex_s(i) IsNot Nothing) Then
                    ListBox1.Items.Add(Ex_s(i))

                End If
            End If
            Label1.Text = Ex_s(0)
        Next

    End Sub

End Class

