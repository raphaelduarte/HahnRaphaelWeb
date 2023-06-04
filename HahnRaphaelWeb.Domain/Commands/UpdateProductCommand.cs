using FluentValidation;
using HahnRaphaelWeb.Domain.Commands.Contracts;

namespace HahnRaphaelWeb.Domain.Commands
{
    public class UpdateProductCommand : AbstractValidator<UpdateProductCommand>, ICommand
    {
        public UpdateProductCommand() { }

        public UpdateProductCommand(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public void Validate()
        {
            RuleFor(product => product.Name)
                .NotNull().WithMessage("Product's name can not be null")
                .NotEmpty().WithMessage("Product's name can not be empty")
                .Length(1, 25).WithMessage("Product's lenght have to be between 1 and 25 character");

            RuleFor(product => product.Description)
                .NotNull().WithMessage("Product's description can not be null")
                .NotEmpty().WithMessage("Product's description can not be empty")
                .Length(10, 255).WithMessage("Product's description of lenght have to be between 10 and 255 character"); ;

            RuleFor(product => product.Price)
                .NotNull().WithMessage("Product's price can not be null")
                .NotEmpty().WithMessage("Product's price can not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Price have to be greater than or equal to 0");
        }
    }
}
