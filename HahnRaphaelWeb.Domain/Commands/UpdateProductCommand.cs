using FluentValidation;
using HahnRaphaelWeb.Domain.Commands.Contracts;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Commands
{
    public class UpdateProductCommand
    {
        public UpdateProductCommand() { }

        public UpdateProductCommand(Guid id, string name, string description, double price)
        {
            Id = id;   
            Name = name;
            Description = description;
            Price = price;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
