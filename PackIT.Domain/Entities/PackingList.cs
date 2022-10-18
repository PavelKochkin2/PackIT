namespace PackIT.Domain.Entities;

public class PackingList
{
    public Guid Id { get; private set; }

    private string _name;

    private string _localization;
} 