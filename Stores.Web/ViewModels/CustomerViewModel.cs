using Stores.Model;
using System.Collections.Generic;

namespace Stores.Web.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual List<SoldProduct> SoldProducts { get; set; }
    }
}