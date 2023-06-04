using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Repositories
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Update(Product product);
        void Remove(Product product);
        Product GetById(Guid id, string name);
    }
}
