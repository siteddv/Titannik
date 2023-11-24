namespace Titannik;

public static class DefaultCredentials
{
    public const string Login = "admin";    
    public const string Password = "1234";

    public static DebitCard DefaultDebitCard = new DebitCard()
    {
        BankName = "Optima",
        CardNumber = 32 /*1234567890123456*/,
        CurrentBalance = 322,
        ExpiryDate = new DateTime(2027, 11, 1),
        OwnerName = "Ivan Ivanov",
        PaymentType = "Visa"
    };
    
    
}