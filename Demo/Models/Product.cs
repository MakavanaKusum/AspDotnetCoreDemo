using System;
using System.Collections.Generic;

namespace Demo.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public Category Category { get; set; }
    }
}
