using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListIdException : PackItException
{
    public EmptyPackingListIdException() : 
        base("Packing list Id cannot be empty.")
    {
        
    }
}