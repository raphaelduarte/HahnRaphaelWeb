using FluentValidation;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Commands
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name)
                .NotNull()
                .NotEmpty()
                .Length(1, 25);

            RuleFor(product => product.Description)
                .NotEmpty()
                .NotEmpty()
                .Length(10, 255);

            RuleFor(product => product.Price)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
        }
    }
}
