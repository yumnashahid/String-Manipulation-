Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim chr1, chr2, nextChar As Char
        Dim counter As Integer

        str1 = ""
        str2 = ""
        chr1 = ""
        chr2 = ""
        nextChar = ""
        counter = 0

        Console.Write("Enput string 1: ")
        str1 = Console.ReadLine

        Console.Write("Enter character to replace: ")
        chr1 = Console.ReadLine

        Console.Write("Enter character to replace with: ")
        chr2 = Console.ReadLine

        For count = 1 To Len(str1)
            nextChar = Mid(str1, count, 1)
            If nextChar = chr1 Then
                str2 = str2 & chr2
            Else
                str2 = str2 & nextChar
            End If
        Next

        Console.WriteLine(str2)
        Console.ReadKey()


    End Sub

End Module
