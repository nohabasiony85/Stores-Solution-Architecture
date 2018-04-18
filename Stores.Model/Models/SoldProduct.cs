using System;

namespace Stores.Model
{
    public class SoldProduct
    {
        public int Id { get; set; }
        public DateTime SoldDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
