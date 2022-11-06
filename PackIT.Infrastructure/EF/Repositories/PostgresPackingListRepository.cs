using System.Formats.Asn1;
using Microsoft.EntityFrameworkCore;
using PackIT.Domain.Entities;
using PackIT.Domain.Repositories;
using PackIT.Domain.ValueObjects;
using PackIT.Infrastructure.EF.Contexts;

namespace PackIT.Infrastructure.EF.Repositories;

internal class PostgresPackingListRepository : IPackingListRepository
{
    private readonly DbSet<PackingList> _packingLists;
    private readonly WriteDbContext _writeDbContext;

    public PostgresPackingListRepository(WriteDbContext writeDbContext)
    {
        _writeDbContext = writeDbContext;
        _packingLists = writeDbContext.PackingLists;
    }

    public Task<PackingList> GetAsync(PackingListId id)
    {
        //not adding asNoTracking here because we might need to track
        //the aggregate for updating 
        var result =  _packingLists
            .Include("_items")
            .SingleOrDefaultAsync(pl => pl.Id == id);

        return result;
    }

    public async Task AddAsync(PackingList packingList)
    {
        await _packingLists.AddAsync(packingList);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(PackingList packingList)
    {
        _packingLists.Update(packingList);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(PackingList packingList)
    {
        _packingLists.Remove(packingList);
        await _writeDbContext.SaveChangesAsync();
    }
}