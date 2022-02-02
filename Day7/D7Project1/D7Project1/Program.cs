using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7Project1
{
    /********************************************************************
     Author : G V S S SRI LASYA
     Purpose : Create Employee class with three variables and two methods
     ReadEmployee and PrintEmployee and create an object and call methods.
    *********************************************************************/

    class Employee
    {
        public int employeeID;
        public string employeeName;
        public int employeeSalary;

        public void ReadEmployee()
        {
            Console.Write("\nEnter employee ID : ");
            employeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee name : ");
            employeeName = (Console.ReadLine());

            Console.Write("Enter employee salary : ");
            employeeSalary = Convert.ToInt32(Console.ReadLine());

        }

        public void PrintEmployee()
        {
            Console.Write("\nEmployee ID : " + employeeID);
            Console.Write("\nEmployee name: " + employeeName);
            Console.Write("\nEmployee salary : " + employeeSalary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.ReadEmployee();
            Console.Write("\n");
            emp2.ReadEmployee();

            Console.Write("\n\n");

            emp1.PrintEmployee();
            Console.Write("\n");
            emp2.PrintEmployee();

            Console.ReadLine();


        }

    }
}
