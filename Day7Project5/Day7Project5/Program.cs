using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project5
{
    /***********************************************
    Author : G V S S SRI LASYA
    Purpose : For Employee class,write code to print 
    employees who is getting salary >=5000 using
    for loop
    foreach loop
    lambda expression
    ************************************************/

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

            //printing employee details with salary>=150000 using for loop
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].salary >= 150000)
                    Console.Write($"\nID : {employees[i].id}\t\tName : {employees[i].name}\t\tSalary : {employees[i].salary}");
            }


            Console.WriteLine("\n\n");
            //printing employee details with salary>=150000 using foreach loop
            foreach(var employee in employees)
            {
                if (employee.salary >= 150000)
                    Console.Write($"\nID : {employee.id}\t\tName : {employee.name}\t\tSalary : {employee.salary}");

            }


            Console.WriteLine("\n\n");
            //printing employee details with salary>=150000 using lambda expression
            employees.ToList().Where(employee => employee.salary >= 150000).ToList().ForEach(employee => Console.Write($"\nID : {employee.id}\t\tName : {employee.name}\t\tsalary : {employee.salary}"));

            Console.ReadLine();

        }



    }
    }

