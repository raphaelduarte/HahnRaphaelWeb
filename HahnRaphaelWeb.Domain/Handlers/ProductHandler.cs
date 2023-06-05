using System.Collections.Immutable;
using FluentValidation;
using FluentValidation.Results;
using HahnRaphaelWeb.Domain.Commands;
using HahnRaphaelWeb.Domain.Commands.Contracts;
using HahnRaphaelWeb.Domain.Entities;
using HahnRaphaelWeb.Domain.Handlers.Contracts;
using HahnRaphaelWeb.Domain.Repositories;

namespace HahnRaphaelWeb.Domain.Handlers
{
    public class ProductHandler : IHandler<CreateProductCommand>, IHandler<UpdateProductCommand>, IHandler<RemoveProductCommand>
    {
        private readonly IProductRepository _repository;
        public ProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateProductCommand command)
        {
            CreateProductValidator validator = new CreateProductValidator();
            var validation = validator.Validate(command);
            

            if (validation.IsValid == false)
            {
                return new GenericCommandResult(false, "Ops, it is not valid", command);
            };

            var product = new Product(command.Name, command.Description, command.Price);
            _repository.Create(product);

            return new GenericCommandResult(true, "Product saved", product);
        }

        public ICommandResult Handle(UpdateProductCommand command)
        {
            UpdateProductValidator validator = new UpdateProductValidator();
            var validation = validator.Validate(command);


            if (validation.IsValid == false)
            {
                return new GenericCommandResult(false, "Ops, it is not valid", command);
            };

            var product = _repository.GetById(command.Id);

            product.UpdateProduct(command.Name,command.Description, command.Price);

            _repository.Update(product);

            return new GenericCommandResult(true,"Product is updated", product);
        }

        public ICommandResult Handle(RemoveProductCommand command)
        {
            RemoveProductValidator validator = new RemoveProductValidator();
            var validation = validator.Validate(command);


            if (validation.IsValid == false)
            {
                return new GenericCommandResult(false, "Ops, it is not valid", command);
            };

            var product = _repository.GetById(command.Id);
            _repository.Remove(product);

            return new GenericCommandResult(true, "Product is removed", true);
        }
    }
}
