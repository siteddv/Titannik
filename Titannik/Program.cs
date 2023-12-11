using Titannik;

// Menu menu = new Menu();
// menu.ShowGreetings();
// menu.AuthenticateUser();
// menu.ShowMenu();

IStorable storage = new TextStorage();
int val1 = storage.GetValue();
storage = new VirtualStorage();
int val2 = storage.GetValue();

Console.WriteLine($"{val1} {val2}");

// Animal a = new Animal();
// a.Say();
//
// Cow c = new Cow();
// c.Say();
// c.GiveMilk();
//
// Dog d = new Dog();
// d.Say();
//
//
// Console.WriteLine("Cow as Animal");
// Animal ac = new Cow();
// ac.Say();

// using (StreamWriter sw = new StreamWriter("sample.txt"))
// {
//     sw.WriteLine("Hello world");
// }
//
// using (StreamReader sr = new StreamReader("sample.txt"))
// {
//     string? content = sr.ReadLine();
//     Console.ReadLine();
//     Console.WriteLine(content);
// }