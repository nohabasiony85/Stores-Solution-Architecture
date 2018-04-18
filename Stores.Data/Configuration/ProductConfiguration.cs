using Stores.Model;
using System.Data.Entity.ModelConfiguration;

namespace Stores.Data.Configuration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products");
            Property(c => c.Name).IsRequired().HasMaxLength(100);
            Property(c => c.Price).IsRequired().HasPrecision(8, 2);
        }
    }
}
