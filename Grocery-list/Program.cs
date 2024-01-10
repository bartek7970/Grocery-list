using Grocery_list;
using Newtonsoft.Json;
using System.Net.Http.Headers;

ProductsList LoadList( ProductsList list)
{
    var deserialiazedProduct = File.ReadAllText(@"C:\Users\barte\source\repos\Grocery-list\Grocery-list\JSON\ProductsDatabaseList.json");
    list = JsonConvert.DeserializeObject<ProductsList>(deserialiazedProduct);
    return list;
    
}   

 static void Menu(ProductsList list)
{
  

    Console.WriteLine("Welcome in Grocery lis");
    var flag = false;
    List<Product> groceryList = new List<Product>();
    while (flag == false)
    {
        Console.WriteLine();
        Console.WriteLine("Choose option");
        Console.WriteLine("1:New grocery list");
        Console.WriteLine("2:Check products list");
        Console.WriteLine("3:Check your grocery list");
        Console.WriteLine("4:Exit");
        var input = Console.ReadLine();
        switch(input)
        {
            case "1":
                {
                    groceryList.Clear();
                    break;
                }

                case "2": 
                {
                    for (int i = 0; i < list.productsList.Count; i++)
                    {
                        groceryList[i]= list.productsList[i];
                        Console.WriteLine($"{groceryList[i].Name} {groceryList[i].PriceInPLN} PLN ");
                    }
                    
                    break;

                }

            case "3":
                {
                
                    for(int i = 0; i < groceryList.Count; i++)
                    {
                        
                        Console.WriteLine($"{ groceryList[i].Name} {groceryList[i].PriceInPLN} PLN");
                    }

                    break;
                }

            case "4":
                {
                    flag = true;
                    break;
                    
                }
                


            default:
                break;
                
        }
    }
}

ProductsList productsList = LoadList(new ProductsList());

//Menu(productsList);
