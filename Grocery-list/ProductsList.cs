using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_list
{
    public  class ProductsList
    {
        [JsonProperty("listOfProducts")]
        public List<Product> productsList { get; set; }
    }
}
