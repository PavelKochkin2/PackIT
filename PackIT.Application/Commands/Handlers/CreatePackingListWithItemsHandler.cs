using PackIT.Application.Services;
using PackIT.Domain.Factories;
using PackIT.Domain.Repositories;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands.Handlers;

public class CreatePackingListWithItemsHandler :
    ICommandHandler<CreatePackingListWithItems>
{
    private readonly IPackingListRepository _repository;
    private readonly IPackingListFactory _factory;
    private readonly IPackingListReadService _readService;

    public CreatePackingListWithItemsHandler(IPackingListRepository repository, IPackingListFactory factory, IPackingListReadService readService)
    {
        _repository = repository;
        _factory = factory;
        _readService = readService;
    }

    public Task HandleAsync(CreatePackingListWithItems command)
    {
        //check if the list exists in db(we don't allow name duplicates)

        return Task.CompletedTask;
    }
}