using Titannik.Enums;

namespace Titannik;

public static class DefaultCredentials
{
    public const string Login = "admin";    
    public const string Password = "1234";

    public static DebitCard DefaultDebitCard = new DebitCard()
    {
        BankName = "Optima",
        CardNumber = 1234567890123456,
        CurrentBalance = 322,
        ExpiryDate = new DateTime(2027, 11, 1),
        OwnerName = "Ivan Ivanov",
        PaymentType = PaymentType.Visa,
        Currency = Currency.KGS
    };
    
    public static CreditCard DefaultCreditCard = new CreditCard()
    {
        BankName = "Optima",
        CardNumber = 1234567890123457,
        CurrentBalance = 322,
        ExpiryDate = new DateTime(2027, 11, 1),
        OwnerName = "Ivan Ivanov",
        PaymentType = PaymentType.Visa,
        Currency = Currency.KGS
    };
    
    public static Card? DefaultCard { get; set; }
}