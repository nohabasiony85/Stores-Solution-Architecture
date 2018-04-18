using Stores.Data.Configuration;
using Stores.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Stores.Data
{
    public class StoreEntities : DbContext
    {
        public StoreEntities() : base("StoreEntities") { }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<SoldProduct> SoldProducts { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new StoreConfiguration());
            modelBuilder.Configurations.Add(new SoldProductConfiguration());
        }
    }
}
