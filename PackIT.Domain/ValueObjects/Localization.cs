namespace PackIT.Domain.ValueObjects;

/// <summary>
///     Represents a place where you are packing for.
/// </summary>
/// <param name="City">City where you are going.</param>
/// <param name="Country">Country of the city.</param>
public record Localization(string City, string Country) 
{
    public static Localization Create(string value)
    {
        var splitLocalization = value.Split(',');

        var localization = new Localization(splitLocalization.First(),
            splitLocalization.Last());

        return localization;
    }

    public override string ToString()
    {
        return $"{City} {Country}";
    }
}