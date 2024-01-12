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

        //zamiast case 3?
        /* public ProductsList deleteProduct(string name, ProductsList productsDatabasex)
           {
               productsDatabasex.productsList.Remove(productsDatabasex.productsList.FirstOrDefault(p => p.Name == name));
               return productsDatabasex;
           } */

      /*public  static void SaveList(List<Product> product1)
        {
            var serializedProduct = JsonConvert.SerializeObject(product1);
            File.WriteAllText(@"C:\Users\barte\source\repos\Grocery-list\Grocery-list\JSON\groceryList.json", serializedProduct);

        }*/
    }

  
    
    
}
