using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HahnRaphaelWeb.Domain.Commands.Contracts;

namespace HahnRaphaelWeb.Domain.Commands
{
    public class CreateProductCommand : ICommand
    {
        public CreateProductCommand() { }

        public CreateProductCommand(string name, string description, double price)
        {
            Name = name; 
            Description = description; 
            Price = price;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
