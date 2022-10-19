using PackIT.Domain.Events;
using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;

namespace PackIT.Domain.Entities;

/// <summary>
///     Represents a list of items to pack.
/// </summary>
public class PackingList : AggregateRoot<PackingListId>
{
    public PackingListId Id { get; private set; }

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

        AddEvent(new PackingItemAdded(this, item));
    }

    public void AddItems(IEnumerable<PackingItem> items)
    {
        foreach (var item in items)
        {
            AddItem(item);
        }
    }

    public void PackItem(string itemName)
    {
        var item = GetItem(itemName);

        //makes copy of the item with changed property.
        var packedItem = item with { IsPacked = true };

        _items.Find(item).Value = packedItem;

        AddEvent(new PackingItemPacked(this, item));
    }


    public void RemoveItem(string itemName)
    {
        var item = GetItem(itemName);

        _items.Remove(item);

        AddEvent(new PackingItemRemoved(this, item));
    }

    private PackingItem GetItem(string itemName)
    {
        var item = _items.
            SingleOrDefault(i => i.Name == itemName);

        if (item is null)
        {
            throw new PackingItemNotFoundException(itemName);
        }

        return item;
    }
}