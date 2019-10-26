Module Module1

    Sub Main()
        Dim str1, str2, str3, firstWord, secWord As String
        Dim Sp As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        firstWord = ""
        secWord = ""
        Sp = 0

        Console.Write("Enter string 1: ")
        str1 = Console.ReadLine

        Console.Write("Enter string 2: ")
        str2 = Console.ReadLine

        Sp = InStr(str1, " ")
        firstWord = Left(str1, Sp - 1)

        Sp = InStr(str2, " ")
        secWord = Right(str2, Len(str2) - Sp)

        str3 = firstWord & " " & secWord
        Console.WriteLine(str3)

        Console.ReadKey()

    End Sub

End Module
