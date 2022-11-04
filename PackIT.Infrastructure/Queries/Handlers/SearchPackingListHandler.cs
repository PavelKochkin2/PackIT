using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Infrastructure.EF.Models;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries.Handlers;

public class SearchPackingListHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListReadModel>>
{
    public Task<IEnumerable<PackingListReadModel>> HandleAsync(SearchPackingLists query)
    {
        throw new NotImplementedException();
    }
}