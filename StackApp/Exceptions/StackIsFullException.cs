namespace StackApp.Exceptions;

public class StackIsFullException : Exception
{
    public StackIsFullException(string? message) : base(message)
    {
        
    }
}