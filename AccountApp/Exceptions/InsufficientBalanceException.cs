namespace AccountApp.Exceptions;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string s) : base(s)
    {
        
    }
}