namespace Titannik;

public class TextStorage : IStorable
{
    public int GetValue()
    {
        using (StreamReader sr = new StreamReader("sample.txt"))
        {
            string? content = sr.ReadLine();
            if (!string.IsNullOrWhiteSpace(content))
            {
                return int.Parse(content);
            }
            else
            {
                return 0;
            }
        }
    }

    public void SetValue(int value)
    {
        using (StreamWriter sw = new StreamWriter("sample.txt", false))
        {
            sw.WriteLine(value);
        }
    }

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}