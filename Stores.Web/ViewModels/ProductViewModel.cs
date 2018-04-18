using Stores.Model;
using System.Collections.Generic;

namespace Stores.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual List<SoldProduct> SoldProducts { get; set; }
    }
}