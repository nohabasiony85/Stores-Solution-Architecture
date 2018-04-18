﻿using System.Collections.Generic;

namespace Stores.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual List<SoldProduct> SoldProducts { get; set; }
    }
}
