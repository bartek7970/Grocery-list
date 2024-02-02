using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_list
{
    public class Product
    {
        public  Product(int id, string name, double priceInPLN)
        {
            Id = id;
            Name = name;
            PriceInPLN = priceInPLN;
        }
        private int Id { get; set; }
        public string Name { get; set; }
        public double PriceInPLN { get; set; }

    }
}
