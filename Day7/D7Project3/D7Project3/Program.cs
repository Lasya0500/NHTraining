using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7Project3
{
    /****************************************************
     Author : G V S S SRI LASYA
     Purpose :Create Employee class with 3 public variables.
     Create Employee object and initialize with values while 
     creating object and print the values.
    *****************************************************/

    internal class Employee
    {
        public int employeeSalary;
        public string employeeName;
        public int employeeID;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { employeeID = 1,employeeName = "Meena",employeeSalary = 100000};
            Console.WriteLine($@"ID :        {emp1.employeeID}

Name :      {emp1.employeeName}

Salary :    {emp1.employeeSalary}");

            Console.ReadLine();
        }
    }
}
