using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListNameException : PackITException
{
    public EmptyPackingListNameException() : 
        base("packing name list cannot be empty.")
    {
    }
}