using FluentValidation.Results;
using HahnRaphaelWeb.Domain.Commands;
using HahnRaphaelWeb.Domain.Commands.Contracts;
using HahnRaphaelWeb.Domain.Entities;
using HahnRaphaelWeb.Domain.Handlers.Contracts;
using HahnRaphaelWeb.Domain.Repositories;

namespace HahnRaphaelWeb.Domain.Handlers
{
    public class ProductHandler : IHandler<CreateProductCommand>
    {
        private readonly IProductRepository _repository;
        public ProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateProductCommand command)
        {
            command.Validate();
            if (command.Validate(command).IsValid == false)
            {
                return new GenericCommandResult(false, "Ops, it is not valid", command);
            };

            var product = new Product(command.Name, command.Description, command.Price);

            _repository.Create(product);

            return new GenericCommandResult(true, "product is saved", product);
        }
    }
}
