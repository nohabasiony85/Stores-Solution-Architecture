using Stores.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Stores.Data
{
    public class StoreSeedData : DropCreateDatabaseIfModelChanges<StoreEntities>
    {
        protected override void Seed(StoreEntities context)
        {

            GetCustomers().ForEach(c => context.Customers.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
            GetStores().ForEach(s => context.Stores.Add(s));
            GetSoldProducts().ForEach(sp => context.SoldProducts.Add(sp));

            base.Seed(context);
        }

        private static List<SoldProduct> GetSoldProducts()
        {
            return new List<SoldProduct>
            {
                new SoldProduct
                {
                    SoldDate =DateTime.Now,
                    CustomerId=1,
                    ProductId=1,
                    StoreId=1,
                },
                new SoldProduct
                {
                    SoldDate =DateTime.Now,
                    CustomerId=2,
                    ProductId=2,
                    StoreId=2,
                },
                new SoldProduct
                {
                    SoldDate =DateTime.Now,
                    CustomerId=3,
                    ProductId=3,
                    StoreId=3,
                },
            };
        }

        private static List<Store> GetStores()
        {
            return new List<Store>
            {
                new Store
                {
                    Name="Store 1",
                    Address="Store 1 address"
                },
                new Store
                {
                    Name="Store 2",
                    Address="Store 2 address"
                },
                new Store
                {
                    Name="Store 3",
                    Address="Store 3 address"
                }

            };
        }

        private static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name="Product 1",
                    Price=10
                },
                new Product
                {
                    Name="Product 2",
                    Price=20
                },
                new Product
                {
                    Name="Product 3",
                    Price=30
                }
            };
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Name="Customer 1",
                    Address="Customer 1 address"
                },
                new Customer
                {
                    Name="Customer 2",
                    Address="Customer 2 address"
                },
                new Customer
                {
                    Name="Customer 3",
                    Address="Customer 3 address"
                }
            };
        }
    }
}
