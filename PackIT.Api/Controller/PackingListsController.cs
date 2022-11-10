using Microsoft.AspNetCore.Mvc;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Shared.Abstractions.Commands;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Api.Controller;

public class PackingListsController : BaseController
{
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly IQueryDispatcher _queryDispatcher;

    public PackingListsController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
    {
        _commandDispatcher = commandDispatcher;
        _queryDispatcher = queryDispatcher;
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<PackingListDto>> Get(
        [FromRoute] GetPackingList query)
    {
        var result = await _queryDispatcher.QueryAsync(query);

        return OkOrNotFound(result);
    }


    [HttpGet("{id:guid}")]
    public async Task<ActionResult<IEnumerable<PackingListDto>>> Get(
        [FromQuery] SearchPackingLists query)
    {
        var result = await _queryDispatcher.QueryAsync(query);

        return OkOrNotFound(result);
    }
}