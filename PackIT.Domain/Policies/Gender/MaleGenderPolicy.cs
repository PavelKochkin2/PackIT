using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Gender;

internal sealed class MaleGenderPolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
    {
        return data.Gender is Consts.Gender.Male;
    }

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
    {
        return new List<PackingItem>()
        {
            new PackingItem(name: "Laptop", quantity: 1),
            new PackingItem(name: "Beer", quantity: 10),
            new PackingItem(name: "Book",
                quantity: (uint)Math.Ceiling(data.Days / 7m)),
        };
    }
}