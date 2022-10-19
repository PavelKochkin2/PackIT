using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;

namespace PackIT.Domain.Entities;

/// <summary>
///     Represents a list of items to pack.
/// </summary>
public class PackingList : AggregateRoot<Guid>
{
    public Guid Id { get; private set; }

    private PackingListName _name;

    private Localization _localization;

    private readonly LinkedList<PackingItem> _items = new LinkedList<PackingItem>();

    public PackingList(Guid id,
        PackingListName name,
        Localization localization, LinkedList<PackingItem> items)
    {
        Id = id;
        _name = name;
        _localization = localization;
        _items = items;
    }

    public void AddItem(PackingItem item)
    {
        var alreadyExists = _items.Any(i => i.Name == item.Name);

        if (alreadyExists)
            throw new PackingItemAlreadyExistsException(_name, item.Name);

        _items.AddLast(item);
    }
}