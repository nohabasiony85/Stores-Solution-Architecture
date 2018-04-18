using Stores.Data.Infrastructure;
using Stores.Model;

namespace Stores.Data.Repositories
{
    public class StoreRepository : RepositoryBase<Stores.Model.Store> , IStoreRepository
    {
        public StoreRepository(IDbFactory dbFactory):base(dbFactory) { }
    }

    public interface IStoreRepository:IRepository<Store>
    {

    }
}
