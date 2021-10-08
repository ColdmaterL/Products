using System;
using System.Collections.Generic;
using System.Text;
using Products.Entities;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int ProductNumb, Product;
            char TypeOfProduct;
            string NameProduct;
            double PriceProduct, FeeProduct;
            DateTime DateOfProduct;
            List<Product> ListProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            ProductNumb = int.Parse(Console.ReadLine());
            for(Product = 1; Product <= ProductNumb; Product++)
            {
                Console.WriteLine($"Product #{Product} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                TypeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                NameProduct = Console.ReadLine();
                Console.Write("Price: ");
                PriceProduct = double.Parse(Console.ReadLine());
                switch (TypeOfProduct)
                {
                    case 'c':
                        ListProducts.Add(new Product(NameProduct, PriceProduct));
                        break;
                    case 'u':
                        Console.Write("Manufactured Date (DD/MM/YYYY): ");
                        DateOfProduct = DateTime.Parse(Console.ReadLine());
                        ListProducts.Add(new UsedProduct(NameProduct, PriceProduct, DateOfProduct));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        FeeProduct = double.Parse(Console.ReadLine());
                        ListProducts.Add(new ImportedProduct(NameProduct, PriceProduct, FeeProduct));
                        break;
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach(Product prod in ListProducts)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
