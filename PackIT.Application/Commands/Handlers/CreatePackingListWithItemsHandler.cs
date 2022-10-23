using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands.Handlers;

public class CreatePackingListWithItemsHandler :
    ICommandHandler<CreatePackingListWithItems>
{
    public Task HandleAsync(CreatePackingListWithItems command)
    {
        //check if the list exists in db(we don't allow name duplicates)

        return Task.CompletedTask;
    }
}