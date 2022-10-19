using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListNameException : PackItException
{
    public EmptyPackingListNameException() : 
        base("packing name list cannot be empty.")
    {
    }
}