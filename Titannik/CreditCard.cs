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

    public override string? GetBalance()
    {
        return $"{CurrentBalance} {Currency}\n" +
               $"Dept: {Dept} {Currency}";
    }

    public override bool TopUp(decimal sumToChange)
    {
        if (sumToChange > Dept)
        {
            CurrentBalance = sumToChange - Dept;
            Dept = 0;
        }
        else
        {
            Dept -= sumToChange;
        }

        return true;
    }
}