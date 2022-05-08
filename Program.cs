using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMgtUsingDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("1:Add New Product\n2:Show Product List\n3)Update the existing Product\n4)Delete the existing Product\n5)Exit");

                string inputstatus = "";
            programStart:
                Console.Write("Select the Operation(1,2,3,4,5) : ");
                ProductService productService = new ProductService();
                ProductList productList = new ProductList();
                inputstatus = Console.ReadLine();
                bool IsContinue = true;
                while (IsContinue)
                {
                    switch (inputstatus)
                    {
                        case "1":
                            {
                                Console.Write("Enter Product Id :");
                                productList.Id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Product Name :");
                                productList.Name = Console.ReadLine();
                                Console.Write("Enter  Product Price :");
                                productList.Price = decimal.Parse(Console.ReadLine());
                                Console.Write("Enter Product Category :");
                                productList.Category = Console.ReadLine();
                               
                                
                                productService.SaveProductList(productList);
                                goto programStart;
                            }
                            
                        case "2":
                            {
                                List<ProductList> products = productService.GetShopMgtDb();
                                Console.WriteLine("Product Information Here");
                                Console.WriteLine("ProductId\tName\t\tPrice\t\t\tCategory");
                                foreach (ProductList p in products)
                                {
                                    Console.WriteLine(p.Id + "\t" + p.Name + "\t\t\t" + p.Price + "\t\t" + p.Category) ;
                                }
                                
                                goto programStart;
                                
                            }
                            
                        case "3":
                            {

                                Console.Write("Chooose Product to update :");
                                int id = int.Parse(Console.ReadLine());
                                Console.Write("Enter your Product Name");
                                string productname = Console.ReadLine();
                                Console.Write("Enter your Product Price");
                                decimal productprice =decimal.Parse(Console.ReadLine());
                                Console.Write("Enter your Product Category");
                                string productcategory = Console.ReadLine();
                                ProductList product = new ProductList();
                                product.Id = id;
                                product.Name = productname;
                                product.Price = productprice;
                                product.Category = productcategory;
                                productService.UpdateByProductId(product);
                                goto programStart;
                            }
                        case "4":
                            {
                                Console.WriteLine("Please type User Id to delete.");
                                int id = int.Parse(Console.ReadLine());
                                productService.DeleteByProductId(id);
                                goto programStart;
                            }
                        case "5":
                            {
                                Console.WriteLine("Good Bye!!");
                                IsContinue = false;
                            }
                            break;
                            
                        default:
                            Console.WriteLine("Invalid Input(Accept only 1,2,3,4 or 5)");
                            goto programStart;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
        
    }
}
