Imports System.IO
Public Class Parcer
    Dim fileReader As String
    Dim Task_word As String = ("Задание #")
    Dim Array() As String
    Dim fw As StreamReader
    Public Sub Connect_file()
        fw = New StreamReader("C:\Users\Saddy\Source\Repos\SaddyST\MTX_Analog\WinFormsApp2\Main_logic\vopr.txt")
    End Sub

    Public Function qwe(num() As String)
        Dim QQ As String
        Dim schet As Integer
        If (fw IsNot Nothing) Then
            Do
                QQ = fw.ReadLine

                If (QQ.IndexOf(Task_word) <> -1) Then
                    num(schet) = QQ
                    schet += 1
                End If
            Loop Until fw.EndOfStream
            Return num
        End If
    End Function
End Class


'ваш сын смотрит хентай  т  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит т  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит 'ваш