namespace Titannik;

public class Menu
{
    public void ShowGreetings()
    {
        Console.WriteLine("**********************");
        Console.WriteLine("*                    *");
        Console.WriteLine("*    Hello, nigga    *");
        Console.WriteLine("*                    *");
        Console.WriteLine("**********************");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void AuthenticateUser()
    {
        Console.WriteLine("Please enter your login and password");
        string? login, password;

        Console.Write("Login: ");
        login = Console.ReadLine();
        
        Console.Write("Password: ");
        password = Console.ReadLine();

        if (string.IsNullOrEmpty(login)
            || string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Please fill in the credentials!");
            AuthenticateUser();
            return;
        }
        
        bool IsSignInSuccess = Session.SignIn(login, password);
        if (IsSignInSuccess)
        {
            Console.WriteLine("Welcome to mobile banking");
        }
        else
        {
            Console.WriteLine("login unsuccessful, please try again");
            AuthenticateUser();
        }
        
    }
}