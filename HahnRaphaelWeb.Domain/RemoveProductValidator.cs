using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HahnRaphaelWeb.Domain.Commands;
using HahnRaphaelWeb.Domain.Commands.Contracts;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain
{
    public class RemoveProductValidator : AbstractValidator<RemoveProductCommand>
    {
        public RemoveProductValidator()
        {
            RuleFor(product => product.Name)
                .NotNull().WithMessage("Product's name can not be null")
                .NotEmpty().WithMessage("Product's name can not be empty")
                .Length(2, 25).WithMessage("Product's lenght have to be between 1 and 25 character");

            RuleFor(product => product.Description)
                .NotNull().WithMessage("Product's description can not be null")
                .NotEmpty().WithMessage("Product's description can not be empty")
                .Length(5, 255).WithMessage("Product's description of lenght have to be between 10 and 255 character"); ;

            RuleFor(product => product.Price)
                .NotNull().WithMessage("Product's price can not be null")
                .NotEmpty().WithMessage("Product's price can not be empty")
                .GreaterThan(0).WithMessage("Price have to be greater than 0");
        }
    }
}
