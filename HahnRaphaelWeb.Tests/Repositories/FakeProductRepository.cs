using HahnRaphaelWeb.Domain.Entities;
using HahnRaphaelWeb.Domain.Repositories;

namespace HahnRaphaelWeb.Tests.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public void Create(Product product)
        {
            
        }

        public void Update(Product product)
        {
            
        }

        public void Remove(Product product)
        {
            
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid id, string name)
        {
            return new Product("banana","That's a banana",1);
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
