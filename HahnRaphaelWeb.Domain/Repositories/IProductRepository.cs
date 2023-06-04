using HahnRaphaelWeb.Domain.Entities;

namespace HahnRaphaelWeb.Domain.Repositories
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Update(Product product);
    }
}
