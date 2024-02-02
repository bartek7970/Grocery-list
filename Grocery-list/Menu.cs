using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_list
{
    public static class Menu
    {

       public static void ProductcsMenu(ProductsList list)
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
                switch (input)
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
                                            var nameOfProduct = Console.ReadLine();
                                            var Selected_Product_If_It_Egxist = productDatabase.FirstOrDefault(n => n.Name == nameOfProduct);
                                            if (Selected_Product_If_It_Egxist != null)
                                            {
                                                groceryList.Add(Selected_Product_If_It_Egxist);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Produktu nie znaleziono");
                                            }
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
                                            default:

                                                Console.WriteLine("\n Wrong number ");
                                                break;
                                        }
                            }
                            break;
                        }

                    case "3":
                        {
                            if (groceryList != null)
                            {
                                for (int i = 0; i < groceryList.Count; i++)
                                {
                                         Console.WriteLine($"{groceryList[i].Name} {groceryList[i].PriceInPLN} PLN");
                                }
                            }
                            else
                            {

                                Console.WriteLine("Grocery list is null");
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
            FileService.SaveGroceryList(groceryList);
        }
    }
}
