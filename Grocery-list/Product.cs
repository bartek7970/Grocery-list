using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_list
{
    internal class Product
    {
        public  Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        protected int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
