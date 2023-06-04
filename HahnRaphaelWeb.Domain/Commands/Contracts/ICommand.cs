using FluentValidation;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Commands.Contracts
{
    public interface ICommand
    {
        bool Validate();
    }
}
