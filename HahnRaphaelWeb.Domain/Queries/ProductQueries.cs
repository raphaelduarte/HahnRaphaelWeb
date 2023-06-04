using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Queries
{
    public static class ProductQueries
    {
        public static Expression<Func<Product, bool>> GetAll(string name, string description, double price)
        {
            return x => x.Name == name &&
                        x.Description == description &&
                        x.Price == price;
        }
    }
}
