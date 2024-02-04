using Newtonsoft.Json;

namespace Grocery_list
{


    public class ProductsList
    {
        [JsonProperty("listOfProducts")]
        public List<Product> productsList { get; set; }

        public ProductsList(List<Product> productsList)
        {
            this.productsList = productsList;
        }
    }




}
