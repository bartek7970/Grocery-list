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
        private const string ProductsDatabaseFilePath = @"JSON\ProductsDatabaseList.json";
        private const string GroceryListFilePath = @"JSON\groceryList.json";

        public static ProductsList LoadProductsDatabase()
        {
            try
            {
                string json = File.ReadAllText(ProductsDatabaseFilePath);
                return JsonConvert.DeserializeObject<ProductsList>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the products database: {ex.Message}");
                return null;
            }
        }

        public static void SaveGroceryList(List<Product> groceryList)
        {
            try
            {
                string json = JsonConvert.SerializeObject(groceryList);
                File.WriteAllText(GroceryListFilePath, json);
                Console.WriteLine("Grocery list saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the grocery list: {ex.Message}");
            }
        }
    }
 
}
