using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature;

internal sealed class LowTemperaturePolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
        => data.Temperature < 10D;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
    {
        return new List<PackingItem>()
        {
            new PackingItem(name: "Winter hat", quantity: 1),
            new PackingItem(name: "Scarf", quantity: 1),
            new PackingItem(name: "Gloves", 1),
            new PackingItem(name: "Hoodie", 1),
            new PackingItem(name: "Warm jacket", 1),
        };
    }
}