namespace Titannik;

public class Cow : Animal
{
    public override void Say()
    {
        Console.WriteLine("Muuuuuuu");
    }

    public void GiveMilk()
    {
        Console.WriteLine("Give me your staff and take my milk!");
    }
}