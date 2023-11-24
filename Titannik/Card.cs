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
            if (value < 1000000000000000 || value >= 10000000000000000)
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
    public string? PaymentType { get; set; }
    public decimal CurrentBalance { get; set; }
}