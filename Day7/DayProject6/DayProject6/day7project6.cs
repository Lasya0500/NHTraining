using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProject6
{

    /**********************************************************
    Author: G V S S SRI LASYA
    Purpose :Create customers list and 
     initialize with 5 customers
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

            //printing values using for loop
            for (int i = 0; i < customers.Count; i++)
                Console.Write($"\nID : {customers[i].id}\tName : {customers[i].name}\tMail ID : {customers[i].mailID}");

            Console.WriteLine("\n\n");
            //printing values using foreach
            foreach (var customer in customers)
                Console.Write($"\nID : {customer.id}\tName : {customer.name}\tMail ID : {customer.mailID}");

            Console.WriteLine("\n\n");
            //printing values using lambda expression
            customers.ForEach(customer => Console.Write($"\nID : {customer.id}\tName : {customer.name}\tMail ID : {customer.mailID}"));

            Console.ReadLine();
        }
    }
}
