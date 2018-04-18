using Stores.Model;
using System.Data.Entity.ModelConfiguration;

namespace Stores.Data.Configuration
{
    public class StoreConfiguration : EntityTypeConfiguration<Store>
    {
        public StoreConfiguration()
        {
            ToTable("Stores");
            Property(c => c.Name).IsRequired().HasMaxLength(100);
            Property(c => c.Address).IsRequired();
        }
    }
}
