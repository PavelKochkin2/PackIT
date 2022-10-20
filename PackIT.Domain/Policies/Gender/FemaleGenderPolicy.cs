using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Gender;

internal sealed class FemaleGenderPolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
    {
        return data.Gender is Consts.Gender.Female;
    }

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
    {
        return new List<PackingItem>()
        {
            new PackingItem(name: "Lipstick", quantity: 1),
            new PackingItem(name: "Powder", quantity: 1),
            new PackingItem(name: "Eyeliner",quantity: 1)
        };
    }
}