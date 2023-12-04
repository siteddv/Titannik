using Titannik.Enums;
using Titannik.Helpers;

namespace Titannik;

public class Menu
{
    private const int ShowBalanceOperationId = 1;
    private const int TopUpBalanceOperationId = 2;
    private const int WithdrawFromBalanceOperationId = 3;
    private int[] availableOperationIds = { ShowBalanceOperationId, TopUpBalanceOperationId, WithdrawFromBalanceOperationId };
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
            Console.WriteLine("Please choose card for operations:");
            Console.WriteLine("1 - Debit card");
            Console.WriteLine("2 - Credit card");

            int choice = InputHelper.ReadNumber("Please choose necessary option");

            switch (choice)
            {
                case 1:
                    DefaultCredentials.DefaultCard = DefaultCredentials.DefaultDebitCard;
                    break;
                case 2:
                    DefaultCredentials.DefaultCard = DefaultCredentials.DefaultCreditCard;
                    break;
            }
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
        Console.WriteLine($"{WithdrawFromBalanceOperationId} - Withdraw money");
        Console.WriteLine();
        int operationId = InputHelper.ReadNumber("Please choose necessary option");

        ProcessOperation(operationId);
    }

    private void ProcessOperation(int operationId)
    {
        switch (operationId)
        {
            case ShowBalanceOperationId:
                ShowBalance();
                break;
            case TopUpBalanceOperationId:
                ChangeBalance(CardOperation.TopUp);
                break;
            case WithdrawFromBalanceOperationId:
                ChangeBalance(CardOperation.Withdraw);
                break;
            default:
                ProcessIncorrectOperationId();
                break;
        }
    }

    private void ChangeBalance(CardOperation operation)
    {
        decimal sumToChange = InputHelper.ReadDecimal($"Please enter sum to {operation}", false);
        
        switch (operation)
        {
            case CardOperation.Withdraw:
                bool? isSuccess = DefaultCredentials.DefaultCard?.Withdraw(sumToChange);
                if (isSuccess == false)
                {
                    Console.WriteLine("Something went wrong");
                }
                break;
            case CardOperation.TopUp:
                break;
        }
        
        Console.Clear();
        ReturnToMenu();
    }

    private void ShowBalance()
    {
        Console.Clear();
        
        decimal? currentBalance = DefaultCredentials.DefaultCard?.CurrentBalance;
        Currency? currency = DefaultCredentials.DefaultCard?.Currency;
        Console.WriteLine($"Your current balance is: {currentBalance} {currency}");
        if (DefaultCredentials.DefaultCard is CreditCard cc)
        {
            Console.WriteLine($"Your dept is {cc.Dept} {cc.Currency}");
        }
        ReturnToMenu();
    }

    private void ReturnToMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter any key to return to main menu");
        Console.ReadKey();
        Console.Clear();
        ShowMenu();
    }

    private void ProcessIncorrectOperationId()
    {
        string availableOperations = string.Join(", ", availableOperationIds);
        Console.WriteLine($"Please enter available operations from range: {availableOperations}");
        
        ShowMenu();
    }
}