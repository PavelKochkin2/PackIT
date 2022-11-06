using Microsoft.EntityFrameworkCore;
using PackIT.Application.DTO;
using PackIT.Application.Services;
using PackIT.Infrastructure.EF.Contexts;
using PackIT.Infrastructure.EF.Models;

namespace PackIT.Infrastructure.EF.Services;

internal sealed class PostgresPackingListReadService :
    IPackingListReadService
{
    private readonly DbSet<PackingListReadModel> _packingList;

    public PostgresPackingListReadService(ReadDbContext dbContext)
    {
        _packingList = dbContext.PackingLists;
    }


    public Task<IEnumerable<PackingListDto>> SearchAsync(string searchPhrase)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsByNameAsync(string name)
    {
        return _packingList.AnyAsync(pl => pl.Name ==
                                    name);
    }
}