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
                Console.WriteLine("Welcome in Grocery list");

                var groceryList = new List<Product>();
                var productDatabase = list.productsList;

                while (true)
                {
                    ShowMenuOptions();
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            groceryList.Clear();
                            break;
                        case "2":
                            ShowProductsDatabase(productDatabase);
                            ProductDatabaseMenu(productDatabase, groceryList);
                            break;
                        case "3":
                            ShowGroceryList(groceryList);
                            break;
                        case "4":
                            FileService.SaveGroceryList(groceryList);
                            return;
                        default:
                            Console.WriteLine("\n Wrong option. Please choose again.");
                            break;
                    }
                }
            }

            private static void ShowMenuOptions()
            {
                Console.WriteLine();
                Console.WriteLine("Choose option:");
                Console.WriteLine("1: New grocery list");
                Console.WriteLine("2: Check products database");
                Console.WriteLine("3: Check your grocery list");
                Console.WriteLine("4: Exit");
             }

            private static void ShowProductsDatabase(List<Product> productDatabase)
            {
                Console.WriteLine("\nProducts Database:");
                ShowDetailsProductsOfList(productDatabase);
            }
            private static void ProductDatabaseMenu(List<Product> productDatabase, List<Product> groceryList)
                {
                    while (true)
                    {
                        ShowProductsDatabase(productDatabase);
                        Console.WriteLine();
                        Console.WriteLine("Choose option:");
                        Console.WriteLine("1: Add product to grocery list");
                        Console.WriteLine("2: Add product to products database");
                        Console.WriteLine("3: Delete product");
                        Console.WriteLine("4: Back to menu");

                        string input = Console.ReadLine();

                        switch (input)
                        {
                            case "1":
                                AddProductToGroceryList(productDatabase, groceryList);
                                break;
                            case "2":
                                AddProductToDatabase(productDatabase);
                                break;
                            case "3":
                                DeleteProductFromDatabase(productDatabase);
                                break;
                            case "4":
                                return;
                            default:
                                Console.WriteLine("\n Wrong option. Please choose again.");
                                break;
                        }
                    }
                }

            private static void AddProductToGroceryList(List<Product> productDatabase, List<Product> groceryList)
            {
                Console.WriteLine("Insert name of product");
                string nameOfProduct = Console.ReadLine();
                var selectedProduct = productDatabase.FirstOrDefault(p => p.Name == nameOfProduct);
                if (selectedProduct != null)
                {
                    groceryList.Add(selectedProduct);
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }

            private static void AddProductToDatabase(List<Product> productDatabase)     // dodać walidację danych wejściowych
            {
                Console.WriteLine("Insert name of product");
                string nameOfProduct = Console.ReadLine();
                Console.WriteLine("Insert price of product");
                double priceOfProduct = double.Parse(Console.ReadLine());
                productDatabase.Add(new Product(productDatabase.Count + 1, nameOfProduct, priceOfProduct));
            }

            private static void DeleteProductFromDatabase(List<Product> productDatabase)
            {
                Console.WriteLine("Insert name of product to delete");
                string nameOfProductToDelete = Console.ReadLine();
                var productToDelete = productDatabase.SingleOrDefault(p => p.Name == nameOfProductToDelete);
                if (productToDelete != null)
                {
                    productDatabase.Remove(productToDelete);
                    Console.WriteLine("Product deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }

            private static void ShowGroceryList(List<Product> groceryList)
            {
                if (groceryList.Any())
                {
                    Console.WriteLine("\nYour grocery list:");
                    ShowDetailsProductsOfList(groceryList);
                }
                else
                {
                    Console.WriteLine("\nYour grocery list is empty.");
                }
            }

        public static void ShowDetailsProductsOfList(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} {product.PriceInPLN} PLN");

            }
        }
        }

    }
