using FluentValidation;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Commands.Contracts
{
    public abstract class ICommand : ProductValidator
    {
        public abstract bool Validate();
    }
}
