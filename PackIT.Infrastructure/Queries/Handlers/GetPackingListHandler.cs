using Microsoft.EntityFrameworkCore;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Infrastructure.EF.Contexts;
using PackIT.Infrastructure.EF.Models;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries.Handlers;

internal class GetPackingListHandler :
    IQueryHandler<GetPackingList, PackingListDto>
{

    private readonly DbSet<PackingListReadModel> _packingLists;

    public GetPackingListHandler(ReadDbContext dbContext)
    {
        _packingLists = dbContext.PackingLists;
    }

    public Task<PackingListDto> HandleAsync(GetPackingList query) =>
        _packingLists
            .Include(pl => pl.Items)
            .Where(pl => pl.Id == query.Id)
            .Select(pl => pl.ToDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();
}
