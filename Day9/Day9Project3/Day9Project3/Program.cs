using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************************
Author : G V S S SRI LASYA
Purpose : Create an employee class with the variables id,name,salary,company.
Write methods to read data and print data.
****************************************************************************/

namespace Day9Project3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "ABC";

        /// <summary>
        /// To take user inputs
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        public void ReadData()
        {
            Console.Write("\nEnter employee id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name : ");
            name = Console.ReadLine();
            Console.Write("Enter employee salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// To print data
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        public void PrintData()
        {
            Console.Write($"\nEmployee id is : {id}\tname : {name}\tsalary : {salary}\tcompany : {company}");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.ReadData();
            emp2.ReadData();

            emp1.PrintData();
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}
