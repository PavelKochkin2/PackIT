using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Universal;

internal sealed class BasicPolicy : IPackingItemsPolicy
{
    private const uint MaxQuantityOfClothes = 7;

    public bool IsApplicable(PolicyData data) => true;

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
    {
        return new List<PackingItem>()
        {
            new PackingItem("Pants", Math.Min(data.Days, MaxQuantityOfClothes)),
            new PackingItem("Socks", Math.Min(data.Days, MaxQuantityOfClothes)),
            new PackingItem("T-Shirt", Math.Min(data.Days, MaxQuantityOfClothes)),
            new PackingItem("Trousers", data.Days < 7 ? 1u : 2u),
            new PackingItem("Shampoo", 1),
            new PackingItem("Toothbrush", 1),
            new PackingItem("Toothpaste", 1),
            new PackingItem("Towel", 1),
            new PackingItem("Pag pack", 1),
            new PackingItem("Passport", 1),
            new PackingItem("Phone Charger", 1),
        };
    }
}