using System.Collections.Generic;

namespace Stores.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual List<SoldProduct> SoldProducts { get; set; }
    }
}
