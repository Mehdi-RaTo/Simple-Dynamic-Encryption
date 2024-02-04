Public Module SimpleDynamicEncryption
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
End Module