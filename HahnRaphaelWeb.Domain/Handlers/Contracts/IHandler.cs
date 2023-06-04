using HahnRaphaelWeb.Domain.Commands.Contracts;

namespace HahnRaphaelWeb.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T: ICommand
    {
        ICommandResult Handle(T command);
    }
}
