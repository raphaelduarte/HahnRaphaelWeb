using FluentValidation.Results;
using HahnRaphaelWeb.Domain.Commands;
using HahnRaphaelWeb.Domain.Commands.Contracts;
using HahnRaphaelWeb.Domain.Entities;
using HahnRaphaelWeb.Domain.Handlers.Contracts;
using HahnRaphaelWeb.Domain.Repositories;

namespace HahnRaphaelWeb.Domain.Handlers
{
    public class ProductHandler : IHandler<CreateProductCommand>, IHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _repository;
        public ProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateProductCommand command)
        {
            if (!command.Validate(command).IsValid)
            {
                return new GenericCommandResult(false, "Ops, it is not valid", command);
            };
            
            
        }

        public ICommandResult Handle(UpdateProductCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
