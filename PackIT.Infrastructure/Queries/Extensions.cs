using PackIT.Application.DTO;
using PackIT.Domain.ValueObjects;
using PackIT.Infrastructure.EF.Models;

namespace PackIT.Infrastructure.Queries;

internal static class Extensions
{
    public static PackingListDto ToDto(this PackingListReadModel readModel) =>
        new PackingListDto()
        {
            Id = readModel.Id,
            Name = readModel.Name,
            Localization = new LocalizationDto()
            {
                City = readModel.Localization.City,
                Country = readModel.Localization.Country,
            },
            Items = readModel.Items?.Select(pi => new PackingItemDto()
            {
                Name = pi.Name,
                Quantity = pi.Quantity,
                IsPacked = pi.IsPacked
            })
        };
}