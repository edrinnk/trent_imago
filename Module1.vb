Module Module1

    Sub Main()
        Dim Notes() As String = Nothing
        Dim FileLength As Integer
        Dim FileName As String

        Console.WriteLine("WELCOME TO THIS NOTE APP!")
        FileName = MakeNameFile()
        Console.WriteLine("YOUR FILE NAME:    " & FileName)
        Console.WriteLine("")
        AddNotes(Notes, FileLength)
        SaveFile(Notes, FileName, FileLength)

        Console.ReadLine()
    End Sub
    Function MakeNameFile()
        Dim temp As String
        Console.WriteLine("NAME YOUR FILE BELOW (letters and numbers only):")
        temp = Console.ReadLine
        ' make an error checker here
        temp = "S:\" + temp + ".txt"
        Return temp
    End Function
    Sub AddNotes(ByRef Notes() As String, ByRef FileLength As Integer)
        FileLength = 1
        Console.WriteLine("ADD NOTES BELOW. TYPE * TO FINISH.")
        Do
            ReDim Preserve Notes(FileLength)
            Notes(FileLength) = Console.ReadLine()
            FileLength = FileLength + 1
        Loop Until Notes(FileLength - 1) = "*"

        ' FileLength = FileLength
    End Sub
    Sub SaveFile(ByVal Notes() As String, ByVal FileName As String, ByVal FileLength As Integer)

        FileOpen(1, FileName, OpenMode.Output)

        For Looper = 1 To FileLength - 2
            PrintLine(1, Notes(Looper))
        Next
        FileClose(1)
    End Sub
End Module
