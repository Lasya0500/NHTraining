using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/********************************************************
Author : G V S S SRI LASYA
Purpose : Create a class Product and add variables
id, name, price, brand and print product (name and brand) 
whose price is more than 500 using 
for
foreach loop
lambda
linq query
********************************************************/


namespace Day8Project3
{
    class Product
    {

        public int id;
        public string name;
        public int price;
        public string brand;

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //creating array of objects for Product class
            Product[] products = new Product[]
            {
                new Product(){id = 1, name = "laptop", price = 40000, brand = "asus" },
                new Product() { id = 2, name = "bag", price = 3000, brand = "wildcraft"},
                new Product() { id = 3, name = "fan", price = 1000, brand = "bajaj"},
                new Product() { id = 4, name = "shoes", price = 3000, brand = "adidas" },
                new Product() { id = 5, name = "phone", price = 10000, brand = "samsung"}
            };


            //printing name and brand of products whose price is >5000 using for loop
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].price > 5000)
                    Console.Write($"\nproduct : {products[i].name}\t\t\tbrand : {products[i].brand}");

            }


            Console.WriteLine("\n\n");
            //printing name and brand of products whose price is >5000 using foreach
            foreach (var product in products)
            {
                if (product.price > 5000)
                    Console.Write($"\nproduct : {product.name}\t\t\tbrand : {product.brand}");
            }


            Console.WriteLine("\n\n");
            //printing name and brand of products whose price is >5000 using lambda expression
            products.ToList().Where(product => product.price > 5000).ToList().ForEach(product => Console.Write($"\nproduct : {product.name}\t\t\tbrand : {product.brand}"));


            Console.WriteLine("\n\n");
            //printing name and brand of products whose price is >5000 using LINQ
            var result = from product in products
                         where product.price > 1000
                         select product;

            result.ToList().Where(product => product.price > 5000).ToList().ForEach(product => Console.Write($"\nproduct : {product.name}\t\t\tbrand : {product.brand}"));

            Console.ReadLine();

        }

    }

}












