using FluentAssertions;
using FluentValidation;
using HahnRaphaelWeb.Domain.Commands.Contracts;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Commands
{
    public class CreateProductCommand
    {
        public CreateProductCommand() { }

        public CreateProductCommand(string name, string description, double price)
        {
            Name = name; 
            Description = description; 
            Price = price;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
