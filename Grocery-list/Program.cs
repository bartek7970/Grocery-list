using Grocery_list;
using Newtonsoft.Json;
using System.Net.Http.Headers;

ProductsList LoadList( ProductsList list)
{
    var deserialiazedProduct = File.ReadAllText(@"C:\Users\barte\source\repos\Grocery-list\Grocery-list\JSON\ProductsDatabaseList.json");
    list = JsonConvert.DeserializeObject<ProductsList>(deserialiazedProduct);
    return list;
    
}

 static void SaveList(List<Product> product1)
{
    var serializedProduct = JsonConvert.SerializeObject(product1);
    File.WriteAllText(@"C:\Users\barte\source\repos\Grocery-list\Grocery-list\JSON\groceryList.json", serializedProduct);

}

static void Menu(ProductsList list)
{

    Console.WriteLine("Welcome in Grocery lis");
    var flag = false;
    List<Product> groceryList = new List<Product>();
    List<Product> productDatabase = new List<Product>();
    productDatabase = list.productsList;
    while (flag == false)
    {
        Console.WriteLine();
        Console.WriteLine("Choose option");
        Console.WriteLine("1:New grocery list");
        Console.WriteLine("2:Check products database");
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
                    int n = 0;

                    while (n != -1)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < productDatabase.Count; i++)
                        {
                            Console.WriteLine($"{productDatabase[i].Name} {productDatabase[i].PriceInPLN} PLN ");
                        }
                        Console.WriteLine();

                        Console.WriteLine("Choose option");
                        Console.WriteLine("1:Add product to grocery list");
                        Console.WriteLine("2:Add product to products database");
                        Console.WriteLine("3:Delete product");
                        Console.WriteLine("4:Back to menu");

                        n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Insert name of product");
                                    string nameOfProduct = Console.ReadLine();
                                    groceryList.Add(productDatabase.FirstOrDefault(n => n.Name == nameOfProduct));
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Insert name of produt");
                                    string nameOfProductToAdd = Console.ReadLine();
                                    Console.WriteLine("Insert price of produt");
                                    double priceOfProtuctToAdd = double.Parse(Console.ReadLine());
                                    productDatabase.Add(new Product(productDatabase.Count + 1, nameOfProductToAdd, priceOfProtuctToAdd));
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Insert name of product to delete");
                                    string nameOfProductToDelete = Console.ReadLine();
                                    productDatabase.Remove(productDatabase.FirstOrDefault(p => p.Name == nameOfProductToDelete));
                                    Console.WriteLine(productDatabase.Count);
                                    break;

                                    
                                }

                            case 4:
                                {
                                    n = -1;
                                    break;
                                }
                            case 5:
                                {
                                    SaveList(groceryList);
                                    break;
                                }
                            default:

                                Console.WriteLine("\n Wrong number ");
                                break;
                        }
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
    SaveList(groceryList);
}

ProductsList productsList = LoadList(new ProductsList());
Menu(productsList);
