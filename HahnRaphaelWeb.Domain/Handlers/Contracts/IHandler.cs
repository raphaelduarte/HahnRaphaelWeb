using HahnRaphaelWeb.Domain.Commands.Contracts;

namespace HahnRaphaelWeb.Domain.Handlers.Contracts
{
    public interface IHandler<T>
    {
        ICommandResult Handle(T command);
    }
}
