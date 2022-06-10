using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }

    }
}
