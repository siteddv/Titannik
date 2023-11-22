namespace Titannik;

public static class Session
{
    public static bool IsSignedIn { get; set; }
    public static string? CurrentUserName { get; set; }

    public static bool SignIn(string login, string password)
    {
        if (login != DefaultCredentials.Login ||
            password != DefaultCredentials.Password) 
            return false;
        
        IsSignedIn = true;
        CurrentUserName = login;
            
        return true;

    }
}