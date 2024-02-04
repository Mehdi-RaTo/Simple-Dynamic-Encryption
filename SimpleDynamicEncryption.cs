using System;

public static class SimpleDynamicEncryption
{
    public static string Encode(string strInput)
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

    public static string Decode(string strInput)
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
}