using Grocery_list;



 static void Menu()
{
    Console.WriteLine("Welcome in Grocery lis");
    var flag = false;
    List<Product> products = new List<Product>();
   
    while (flag == false)
    {
        Console.WriteLine("Choose option");
        Console.WriteLine("1:Open new grocery list");
        Console.WriteLine("2:Check products list");
        Console.WriteLine("3:Exit");
        int input = int.Parse(Console.ReadLine());
        switch(input)
        {
            case 1:
                {
                    products.RemoveRange(0, products.Count);
                   
                    break;
                }

                case 2: 
                {
                    Console.WriteLine("E");
                    break;

                }

            case 3:

                
                break;


            default: throw new Exception("Bad option");
        }
    }
}

Menu();