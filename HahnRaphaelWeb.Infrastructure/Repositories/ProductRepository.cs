using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HahnRaphaelWeb.Domain.Entities;
using HahnRaphaelWeb.Domain.Queries;
using HahnRaphaelWeb.Domain.Repositories;
using HahnRaphaelWeb.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HahnRaphaelWeb.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }

        public Product GetById(Guid id)
        {
            _context.Products.FirstOrDefault(x => x.Id == id);

            return _context
                .Products
                .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products
                .AsNoTracking()
                .Where(ProductQueries.GetAll())
                .OrderBy(x => x.Price);
        }
    }
}
