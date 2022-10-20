using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature;

internal sealed class HighTemperaturePolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data) 
        => data.Temperature > 25D;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
    {
        return new List<PackingItem>()
        {
            new PackingItem(name: "Hat", quantity: 1),
            new PackingItem(name: "Sunglasses", quantity: 1),
            new PackingItem(name: "Cream with UV filter", 1)
        };
    }
}