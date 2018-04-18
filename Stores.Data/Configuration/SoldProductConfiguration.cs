using Stores.Model;
using System.Data.Entity.ModelConfiguration;

namespace Stores.Data.Configuration
{
    public class SoldProductConfiguration : EntityTypeConfiguration<SoldProduct>
    {
        public SoldProductConfiguration()
        {
            ToTable("SoldProducts");
            Property(c => c.SoldDate).IsRequired();
            Property(c => c.CustomerId).IsRequired();
            Property(c => c.ProductId).IsRequired();
            Property(c => c.StoreId).IsRequired();
        }
    }
}
