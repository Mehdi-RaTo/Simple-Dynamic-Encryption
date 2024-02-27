Module Program
    Public Function Encode(ByVal strInput As String) As String
        Dim rand As New Random()
        Dim rndInt As Integer = rand.Next(1, 10)

        Dim result As String = ""
        For Each c As Char In strInput
            result += Chr(Asc(c) + rndInt + 2)
        Next

        result += Chr(rndInt + 33)

        Return result
    End Function

    Public Function Decode(ByVal strInput As String) As String
        Dim rndInt As Integer = Asc(strInput(strInput.Length - 1)) - 33

        strInput = strInput.Substring(0, strInput.Length - 1)

        Dim result As String = ""
        For Each c As Char In strInput
            result += Chr(Asc(c) - rndInt - 2)
        Next

        Return result
    End Function

    Sub Main()
        ' Example usage
        Dim input_string As String = "Mehdi-RaTo"
        Dim encoded_string As String = Encode(input_string)
        Dim decoded_string As String = Decode(encoded_string)

        Console.WriteLine("Original: " + input_string)
        Console.WriteLine("Encoded:  " + encoded_string)
        Console.WriteLine("Decoded:  " + decoded_string)
    End Sub
End Module