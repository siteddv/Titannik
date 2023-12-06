namespace Titannik;

public class DebitCard : Card
{
    
    
    public override bool Withdraw(decimal sumToChange)
    {
        if (sumToChange > CurrentBalance)
        {
            // Console.WriteLine("It's impossible to withdraw such sum of money");
            return false;
        }
        
        CurrentBalance -= sumToChange;
        return true;
    }

    public override string? GetBalance()
    {
        return $"{CurrentBalance} {Currency}";
    }

    public override bool TopUp(decimal sumToChange)
    {
        CurrentBalance += sumToChange;
        return true;
    }
}