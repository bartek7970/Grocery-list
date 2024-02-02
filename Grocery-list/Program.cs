using Grocery_list;
using Newtonsoft.Json;
using System.Net.Http.Headers;



ProductsList productsList = new ProductsList();
 productsList = FileService.LoadProductsDatabase();
Menu.ProductcsMenu(productsList);
