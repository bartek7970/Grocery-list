using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_list
{
    public static class FileService
    {

      public static ProductsList LoadList()
        {
            var deserialiazedProduct = File.ReadAllText(@"C:\Users\barte\source\repos\Grocery-list\Grocery-list\JSON\ProductsDatabaseList.json");
            var list = JsonConvert.DeserializeObject<ProductsList>(deserialiazedProduct);
            return list;

        }

       public static void SaveList(List<Product> product1)
        {
            var serializedProduct = JsonConvert.SerializeObject(product1);
            File.WriteAllText(@"C:\Users\barte\source\repos\Grocery-list\Grocery-list\JSON\groceryList.json", serializedProduct);

        }
    }
}
