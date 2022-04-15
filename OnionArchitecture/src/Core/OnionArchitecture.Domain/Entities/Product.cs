using OnionArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProducStock { get; set; } 
        public decimal ProducPrice { get; set; } 

    }
}
