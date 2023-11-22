namespace Titannik.Helpers;

public static class InputHelper
{
    public static string ReadString(string inputMessage)
    {
        Console.WriteLine(inputMessage);
        string? value = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        Console.WriteLine("Please try again");
        return ReadString(inputMessage);
    }

    public static int ReadNumber(string input)
    {
        string value = ReadString(input);
        if (int.TryParse(value, out int number))
        {
            return number;
        }
        
        Console.WriteLine("Input number using digits");
        return ReadNumber(input);
    }
}