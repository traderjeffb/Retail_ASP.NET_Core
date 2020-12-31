using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retail_ASP.NET_Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string PhotoFile { get; set; }
        public int Product_number { get; set; }
        public string Catagory { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public Product()
        {

        }
    }
}
