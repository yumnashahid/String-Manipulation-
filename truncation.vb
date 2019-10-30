Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim chr, nextChar As Char
        Dim count As Integer

        str1 = ""
        str2 = ""
        chr = ""
        nextChar = ""
        count = 0

        Console.Write("Enter string 1: ")
        str1 = Console.ReadLine

        Console.Write("Enter character to replace: ")
        chr = Console.ReadLine

        For count = 1 To Len(str1)
            nextChar = Mid(str1, count, 1)
            If nextChar <> chr Then
                str2 = str2 & nextChar
            End If
        Next

        Console.WriteLine("String 2: " & str2)

        Console.ReadKey()


    End Sub

End Module
