using Titannik.Helpers;

namespace Titannik;

public class Menu
{
    private const int ShowBalanceOperationId = 1;
    private const int TopUpBalanceOperationId = 2;
    private int[] availableOperationIds = new[] { ShowBalanceOperationId, TopUpBalanceOperationId };
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

        login = InputHelper.ReadString("Login");
        password = InputHelper.ReadString("Password: ");

        bool isSignInSuccess = Session.SignIn(login, password);
        if (isSignInSuccess)
        {
            return;
        }

        Console.WriteLine("login unsuccessful, please try again");
        AuthenticateUser();
    }

    public void ShowMenu()
    {
        Console.WriteLine("Welcome to mobile bank!");
        Console.WriteLine($"{ShowBalanceOperationId} - Show your balance");
        Console.WriteLine($"{TopUpBalanceOperationId} - Top up your balance");
        Console.WriteLine();
        int operationId = InputHelper.ReadNumber("Please choose necessary option");

        ProcessOperation(operationId);
    }

    private void ProcessOperation(int operationId)
    {
        switch (operationId)
        {
            case ShowBalanceOperationId:
                break;
            case TopUpBalanceOperationId:
                break;
            default:
                ProcessIncorrectOperationId();
                break;
        }
    }

    private void ProcessIncorrectOperationId()
    {
        string availableOperations = string.Join(", ", availableOperationIds);
        Console.WriteLine($"Please enter available operations from range: {availableOperations}");
        
        ShowMenu();
    }
}