using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*******************************************************************************
Author : G V S S SRI LASYA
Purpose : Create Employee class with two constructors as discussed in the class.
*******************************************************************************/



namespace Day9Project4
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "ABC";

        /// <summary>
        /// To read data from the user 
        /// </summary>
        ///<return>
        ///void
        /// </return>
        public void ReadData()
        {

           
            Console.Write("\nEmployee ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEmployee Name : ");
            name =Console.ReadLine();
            Console.Write("\nEmployee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());

        }

        /// <summary>
        /// To print data
        /// </summary>
        ///<return>
        ///void
        /// </return>
        public void PrintData()
        {
            Console.Write($"\nID : {id}\tName : {name}\tSalary : {salary}\t\tCompany : {company}");

        }

        //parameterised constructor
        public Employee(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        //default constructor
        public Employee()
        {
            id = 0;
            name = null;
            salary = 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Ritu", 150000);
            
            Employee emp2 = new Employee();
            emp2.ReadData();

            Console.WriteLine("\n");
            emp1.PrintData();
            emp2.PrintData();

            Console.ReadLine();
            

        }
    }
}
