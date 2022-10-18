using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public record PackingListName
{
    public PackingListName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyPackingListNameException();
        }

        Value = value;
    }

    public string Value { get; }
}