using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFronttoEnd.Models
{
    public class Category
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public bool isDeleted { get; set; }
        public int ProductCount{ get; set; }
    }
}
