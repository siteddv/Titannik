using Titannik.Enums;

namespace Titannik;

public abstract class Card
{
    public long CardNumber
    {
        get
        {
            return _cardNumber;
        }
        set
        {
            if (value is < 1000000000000000 or >= 10000000000000000)
            {
                throw new NotSupportedException($"{nameof(CardNumber)} doesn't support incorrect number {value}");
            }

            _cardNumber = value;
        }
    }

    private long _cardNumber;

    public DateTime ExpiryDate { get; set; }
    public string? OwnerName { get; set; }
    public string? BankName { get; set; }
    public PaymentType PaymentType { get; set; }
    public decimal CurrentBalance { get; set; }
    public Currency Currency { get; set; }

    public virtual bool Withdraw(decimal sumToChange)
    {
        return default;
    }

    public virtual bool TopUp(decimal sumToChange)
    {
        return default;
    }

    public virtual string? GetBalance()
    {
        return default;
    }
}