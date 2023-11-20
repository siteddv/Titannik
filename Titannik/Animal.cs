namespace Titannik;

public class Animal
{
    public Animal(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public void Move()
    {
        Console.WriteLine($"Animal {Name} is moving");
    }
}