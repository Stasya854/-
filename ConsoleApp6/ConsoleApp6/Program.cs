using System;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Abc123Def456";
        string resultString = GetDigitsString(inputString);

        Console.WriteLine($"Input string: {inputString}");
        Console.WriteLine($"Result string: {resultString}");
        Console.WriteLine($"Number of digits: {resultString.Length}");
    }

    static string GetDigitsString(string input)
    {
        string digitsString = "";

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digitsString += c;
            }
        }

        return digitsString;
    }
}