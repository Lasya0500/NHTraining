using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project2
{
    /************************************************************************
    Author : G V S S SRI LASYA
    Purpose :  Create a class Employee with three variables and 
    create a list of Employees.write  for loop,foreach loop,lambda expression
    linq query
    ************************************************************************/
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee() { id = 1, name = "Karthika", salary = 200000 },
            new Employee() {id = 2, name = "Sravani", salary = 200000 },
            new Employee() {id = 3, name = "Pranavi", salary = 150000 },
            new Employee() {id = 4, name = "Tara", salary = 100000 },
            new Employee() {id = 3, name = "Manaswi", salary = 100000 }
            };

           
            
            //printing employees with salary>100000 using for loop
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].salary > 100000)
                    Console.Write($"\n{employees[i].name} with salary of {employees[i].salary}");
            }

           
            Console.WriteLine("\n\n");
            //printing employees with salary>100000 using foreach 
            foreach (var employee in employees)
            {
                if (employee.salary > 100000)
                    Console.Write($"\n{employee.name} with salary of {employee.salary}");
            }

            
            Console.WriteLine("\n\n");
            //printing employees with salary>100000 using lambda expression
            employees.Where(employee => employee.salary > 100000).ToList().ForEach(employee => Console.Write($"\n{employee.name} with salary of {employee.salary}"));

            
            Console.WriteLine("\n\n");
            //printing employees with salary>100000 using LINQ
            var result = from employee in employees
                         where employee.salary > 100000
                         select employee;
            result.ToList().ForEach(employee => Console.Write($"\n{employee.name} with salary of {employee.salary}"));
            
            
            Console.ReadLine();

        }
    } }
