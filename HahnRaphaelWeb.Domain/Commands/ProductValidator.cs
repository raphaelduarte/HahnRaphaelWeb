using FluentValidation;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Commands
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name)
                .NotNull().WithMessage("Product' name can not be null")
                .NotEmpty().WithMessage("Product' name can not be empty")
                .Length(1, 25).WithMessage("Product's lenght have to be between 1 and 25 character");

            RuleFor(product => product.Description)
                .NotNull().WithMessage("Product' description can not be null")
                .NotEmpty().WithMessage("Produc's description can not be empty")
                .Length(10, 255).WithMessage("Product's description of lenght have to be between 10 and 255 character"); ;

            RuleFor(product => product.Price)
                .NotNull().WithMessage("Product' price can not be null")
                .NotEmpty().WithMessage("Product' price can not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Price have to be greater than or equal to 0");
        }
    }
}
