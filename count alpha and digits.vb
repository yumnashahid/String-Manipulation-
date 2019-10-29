Module Module1

    Sub Main()
        Dim str1 As String
        Dim nextChar As Char
        Dim digit, alpha, count As Integer

        str1 = ""
        nextChar = ""
        digit = 0
        alpha = 0
        count = 0

        Console.Write("Enter string 1: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextChar = Mid(str1, count, 1)
            If nextChar >= "0" And nextChar <= "9" Then
                digit = digit + 1
            Else
                alpha = alpha + 1
            End If
        Next

        Console.WriteLine("Digit = " & digit)
        Console.WriteLine("alpha = " & alpha)
        Console.ReadKey()

    End Sub

End Module
