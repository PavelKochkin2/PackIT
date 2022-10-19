namespace PackIT.Shared.Abstractions.Exceptions;

public abstract class PackItException : Exception
{
    protected PackItException(string msg) : base(msg)
    {
        
    }
}