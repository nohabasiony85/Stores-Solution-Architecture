using Stores.Data.Infrastructure;
using Stores.Model;

namespace Stores.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbFactory dbFactory)
               : base(dbFactory) { }

    }

    public interface ICustomerRepository : IRepository<Customer>
    {

    }
}
