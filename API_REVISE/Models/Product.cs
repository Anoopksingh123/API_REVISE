using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REVISE.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
    }
}
