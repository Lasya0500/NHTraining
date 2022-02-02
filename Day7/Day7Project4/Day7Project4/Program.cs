using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4
{
    /**********************************************
     Author : G V S S SRI LASYA
     Purpose : Create employees array object and 
     initialize with 5 employees
    **********************************************/

   internal class Employee
    {
          
        public int id;
        public string name;
        public int salary;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){id = 1,name = "Sanjana",salary = 100000 },
                new Employee(){id = 2,name = "Akshaya",salary = 150000},
                new Employee(){id = 3,name = "Keerthi",salary = 100000},
                new Employee(){id = 4,name = "Srusti",salary = 100000},
                new Employee(){id = 5,name = "Havya",salary = 200000}
            };

            //printing values using for loop
            for (int i = 0; i < employees.Length; i++)
                Console.Write($"\nID : {employees[i].id}\tName : {employees[i].name}\tSalary : {employees[i].salary}");

            Console.WriteLine("\n\n");
            //printing values using foreach
            foreach (var employee in employees)
                Console.Write($"\nID : {employee.id}\tName : {employee.name}\tSalary : {employee.salary}");

            Console.WriteLine("\n\n");
            //printing values using lambda expression
            employees.ToList().ForEach(employee => Console.Write($"\nID : {employee.id}\tName : {employee.name}\tSalary : {employee.salary}"));

            Console.ReadLine();
        }
    }
}
