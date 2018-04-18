using System.Collections.Generic;
using Stores.Data.Infrastructure;
using Stores.Model;

namespace Stores.Data.Repositories
{
    public class SoldProductRepository : RepositoryBase<SoldProduct>, ISoldProductRepository
    {
        protected SoldProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ISoldProductRepository
    {
        void Add(SoldProduct soldProduct);
        SoldProduct GetById(int id);
        IEnumerable<SoldProduct> GetAll();
    }
}
