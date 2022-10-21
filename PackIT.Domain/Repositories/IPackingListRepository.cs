using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Repositories;

public interface IPackingListRepository
{
    Task<PackingList> GetAsync(PackingListId id);
    Task AddAsync(PackingListId packingList);
    Task UpdateAsync(PackingListId packingList);
    Task DeleteAsync(PackingListId packingList);
}