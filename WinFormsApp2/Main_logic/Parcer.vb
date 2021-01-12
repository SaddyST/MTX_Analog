Imports System.IO
Public Class Parcer
    Dim fileReader As String
    Dim Task_word As String = ("Задание #")
    Dim Array() As String
    Dim fw As StreamReader
    Public Sub Connect_file()
        fw = New StreamReader("C:\Users\Saddy\source\repos\MTX_Analog\WinFormsApp2\Main_logic\vopr.txt")
    End Sub

    Public Function qwe(vopr() As String)
        Dim QQ As String
        Dim schet As Integer
        If (fw IsNot Nothing) Then
            QQ = fw.ReadLine
            Do
                If (QQ.IndexOf(Task_word) <> -1) Then
                    Do
                        vopr(schet) = vopr(schet) + QQ + vbCrLf
                        QQ = fw.ReadLine
                        If (fw.EndOfStream) Then
                            Exit Do
                        End If
                    Loop Until (QQ.IndexOf(Task_word) <> -1)

                    schet += 1
                End If
            Loop Until fw.EndOfStream
            Return vopr
        End If
    End Function

    Function scan_otv(vopr() As String)
        Dim stroka As String
        Dim id As Integer
        fw = New StreamReader("C:\Users\Saddy\source\repos\MTX_Analog\WinFormsApp2\Main_logic\vopr.txt")
        Do
            stroka = fw.ReadLine
            If (stroka Is "") Then
                MsgBox("ya nashel")
            Else
                MsgBox("ne nashel")
            End If
            id += 1
        Loop Until fw.EndOfStream
    End Function
End Class


'ваш сын смотрит хентай  т  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит т  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит нтайт  смотрит 'ваш