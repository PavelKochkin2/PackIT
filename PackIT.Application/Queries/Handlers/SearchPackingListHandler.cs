using PackIT.Application.DTO;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries.Handlers;

public class SearchPackingListHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
{
    public Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
    {
        throw new NotImplementedException();
    }
}