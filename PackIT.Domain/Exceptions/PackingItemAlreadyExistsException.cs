using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions;

public class PackingItemAlreadyExistsException : PackITException
{
    public PackingItemAlreadyExistsException(string listName, string itemName)
        : base($"Packing list {listName} already contains item {itemName}")
    {
    }
}