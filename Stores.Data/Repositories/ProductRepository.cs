using Stores.Data.Infrastructure;
using Stores.Model;

namespace Stores.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
               : base(dbFactory) { }

    }

    public interface IProductRepository : IRepository<Product>
    {

    }
}
