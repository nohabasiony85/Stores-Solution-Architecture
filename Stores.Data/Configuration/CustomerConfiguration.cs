using Stores.Model;
using System.Data.Entity.ModelConfiguration;

namespace Stores.Data.Configuration
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            ToTable("Customers");
            Property(c => c.Name).IsRequired().HasMaxLength(100);
            Property(c => c.Address).IsRequired();
        }
    }
}
