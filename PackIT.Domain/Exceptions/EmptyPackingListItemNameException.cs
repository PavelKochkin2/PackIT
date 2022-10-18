using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class EmptyPackingListItemNameException : PackITException
{
    public EmptyPackingListItemNameException() : base($"Packing list item name cannot be empty.")
    {
        
    }
}