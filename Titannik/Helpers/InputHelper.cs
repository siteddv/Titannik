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

    public static int ReadNumber(string inputMessage)
    {
        string value = ReadString(inputMessage);
        if (int.TryParse(value, out int number))
        {
            return number;
        }
        
        Console.WriteLine("Input number using digits");
        return ReadNumber(inputMessage);
    }
    
    public static decimal ReadDecimal(string inputMessage, bool allowNegativeValues = true)
    {
        string value = ReadString(inputMessage);
        if (decimal.TryParse(value, out decimal number) && (allowNegativeValues || number > 0))
        {
            return number;
        }
        
        Console.WriteLine("Input number using digits");
        return ReadDecimal(inputMessage);
    }
}