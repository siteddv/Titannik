namespace Titannik;

public class CreditCard : Card
{
    public decimal Dept { get; set; }
    
    public override bool Withdraw(decimal sumToChange)
    {
        if (sumToChange > CurrentBalance)
        {
            sumToChange -= CurrentBalance;
            if (Dept + sumToChange > BankStandards.CreditCardDeptLimit)
            {
                // Console.WriteLine("It's impossible to withdraw such sum of money because of you exceed your dept limit");
                return false;
            }

            CurrentBalance = 0;
            Dept += sumToChange;
            return true;
        }
        
        CurrentBalance -= sumToChange;
        return true;
    }
}