using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7Project8
{
    /**********************************************
    Author : G V S S SRI LASYA
    Purpose : Create producr array object and 
    initialize with 5 producs with an if conidtion of id >=3
   **********************************************/
    class Product
    {
        public int id;
        public string name;
        public int price;


        internal class Program
        {
            static void Main(string[] args)
            {
                Product[] products = new Product[]
            {
                new Product(){id = 1,name = "product1",price = 5000 },
                new Product(){id = 2,name = "product2",price = 5000},
                new Product(){id = 3,name = "product3",price = 10000},
                new Product(){id = 4,name = "product4",price = 3000},
                new Product(){id = 5,name = "product5",price = 4000}
            };

                //printing values  with id >=3 using for loop
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].id >= 3)
                        Console.Write($"\nID : {products[i].id}\tName : {products[i].name}\tPrice : {products[i].price}");
                }

                Console.WriteLine("\n\n");
                //printing values  with id >=3 using foreach
                foreach (var product in products)
                {
                    if (product.id >= 3)
                        Console.Write($"\nID : {product.id}\tName : {product.name}\tPrice : {product.price}");
                }

                Console.WriteLine("\n\n");
                //printing values  with id >=3 using lambda expression
                products.ToList().Where(product => product.id >=3).ToList().ForEach(product => Console.Write($"\nID : {product.id}\tName : {product.name}\tPrice : {product.price}"));

                Console.ReadLine();
            }
        }
    }
}
