using System;

class Program
{
    static string Encode(string strInput)
    {
        Random rand = new Random();
        int rndInt = rand.Next(1, 10);

        string result = "";
        foreach (char c in strInput)
        {
            result += (char)(c + rndInt + 2);
        }

        result += (char)(rndInt + 33);

        return result;
    }

    static string Decode(string strInput)
    {
        int rndInt = strInput[strInput.Length - 1] - 33;

        strInput = strInput.Substring(0, strInput.Length - 1);

        string result = "";
        foreach (char c in strInput)
        {
            result += (char)(c - rndInt - 2);
        }

        return result;
    }

    static void Main()
    {
        // Example usage:
        string input_string = "Mehdi-RaTo";
        string encoded_string = Encode(input_string);
        string decoded_string = Decode(encoded_string);

        Console.WriteLine("Original: " + input_string);
        Console.WriteLine("Encoded:  " + encoded_string);
        Console.WriteLine("Decoded:  " + decoded_string);
    }
}