using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************
Author : G V S S SRI LASYA
Purpose :  Create a class Employee with only properties.
***************************************************************************/


namespace Day11Project2
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary
        {
            get
            {
                return (Designation == "HR") ? (200000) : (100000);

            }
           
        }

        public string Designation { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            //setting properties
            emp1.Id = 1;
            emp1.Name = "Juhi";
            emp1.Designation = "Software Trainee";
            

            Console.Write("\nPrinting employee details");

            //getting properties
            Console.Write("\n\n\n\nEmployee Id : " +  emp1.Id);
            Console.Write("\n\nEmployee name : " + emp1.Name);
            Console.Write("\n\nEmployee designation : " + emp1.Designation);
            Console.Write("\n\nEmployee salary : " + emp1.Salary);

            Console.ReadLine();

        }
    }
}
