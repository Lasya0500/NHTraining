using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProject6
{

    /**********************************************************
    Author: G V S S SRI LASYA
    Purpose :Create customers List and 
    initialize with 5 customers with an if conidtion of id >=3
    ************************************************************/

    class Customer
    {
        public string name;
        public int id;
        public string mailID;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){id = 1,name = "Sanjana",mailID = "sanjana@abc.com" },
                new Customer(){id = 2,name = "Akshaya",mailID = "akshaya@abc.com"},
                new Customer(){id = 3,name = "Keerthi",mailID = "keerthi@abc.com"},
                new Customer(){id = 4,name = "Srusti",mailID = "srusti@abc.com"},
                new Customer(){id = 5,name = "Havya",mailID = "havya@abc.com"}
            };

            //printing values with cutomer id >=3 using for loop
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].id >= 3)
                    Console.Write($"\nID : {customers[i].id}\tName : {customers[i].name}\tMail ID : {customers[i].mailID}");
            }

            Console.WriteLine("\n\n");
            //printing values with cutomer id >=3 using foreach
            foreach (var customer in customers)
            {

                if (customer.id >= 3)
                    Console.Write($"\nID : {customer.id}\tName : {customer.name}\tMail ID : {customer.mailID}");
            }
            Console.WriteLine("\n\n");
            //printing values with cutomer id >=3 using lambda expression
            customers.ToList().Where(customer => customer.id >= 3).ToList().ForEach(customer => Console.Write($"\nID : {customer.id}\tName : {customer.name}\tMail ID : {customer.mailID}"));

            Console.ReadLine();


        }
    }
}


