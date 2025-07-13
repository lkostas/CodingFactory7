namespace StackApp.Exceptions;

public class StackIsEmptyException : Exception
{
    public StackIsEmptyException(string? message) : base(message)
    {
        
    }
}