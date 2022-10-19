using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public record PackingListId
{
    public Guid Value { get; set; }

    public PackingListId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new EmptyPackingListIdException();
        }

        Value = value;
    }
};