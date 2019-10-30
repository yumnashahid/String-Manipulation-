Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim nextChar As Char
        Dim count As Integer

        str1 = ""
        str2 = ""
        nextChar = ""
        count = 0

        Console.Write("Enter string 1= ")
        str1 = Console.ReadLine

        For count = Len(str1) To 1 Step -1
            nextChar = Mid(str1, count, 1)
            str2 = str2 & nextChar
        Next

        Console.WriteLine("str2 = " & str2)
        Console.ReadKey()



    End Sub

End Module
