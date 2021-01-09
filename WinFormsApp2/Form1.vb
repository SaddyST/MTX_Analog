Imports System.IO
Public Class Form1
    Dim num() As String = New String(999) {}
    Dim numm() As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Parcer As New Parcer
        'Parcer.Par()

        numm = Parcer.qwe(num)
        For i As Integer = 0 To 10
            If (numm(i) IsNot Nothing) Then
                ListBox1.Items.Add(numm(i))
            End If
        Next
    End Sub

End Class

