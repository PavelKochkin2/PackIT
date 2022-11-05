using PackIT.Application.DTO;
using PackIT.Domain.ValueObjects;
using PackIT.Infrastructure.EF.Models;

namespace PackIT.Infrastructure.Queries;

internal class Extensions
{
    public static PackingListDto ToDto(this PackingListReadModel readModel)=>
    new PackingListDto()
    {
        Id = readModel.Id,
        Name = readModel.Name,
        Localization = new LocalizationDto(readModel.Localization)
    }
}