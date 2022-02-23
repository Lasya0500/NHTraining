using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            string choice;

            do
            {
                Console.Write("\n1.Add Employee : ");
                Console.Write("\n2.Search Employee by Id: ");
                Console.Write("\n3.Search Employee byname: ");
                Console.Write("\n4.Display all Employees : ");
                Console.Write("\nEnter your choice : ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        GetEmployeeById();
                        break;
                    case 3:
                        GetEmployeeByName();
                        break;
                    case 4:
                        GetAllEmployees();
                        break;
                    default:
                        Console.Write("Invalid option");
                        break;

                }

                Console.Write("\nDo you want to choose more options(y/n)? :");
                choice = Console.ReadLine();

            } while (choice.Equals("y"));
            }

            public static void AddEmployee()
            {
                int id, salary, age;
                string name;
               
                Console.Write("\n Enter id : ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Enter name : ");
                name = Console.ReadLine();
                Console.Write("\n Enter salary : ");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Enter age : ");
                age = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.AddEmployee(id, name, salary, age);

            if (result)
                Console.Write("\nEmployee details are succesfuly saved");
            else
                Console.Write("\nSome error occured,check input");

        }

            public static void GetEmployeeById()
            {

            int id;
            Console.Write("Enter id : ");
            id =Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBLL.GetEmployeeById(id);

            if (result.Count == 0)
                Console.Write("\n\nNo records exist witg this id");
            else
                result.ForEach(p => Console.Write("\n" + p));

            }

            public static void GetEmployeeByName()
            {
            string name;
            Console.Write("Enter name : ");
            name = Console.ReadLine();
            var result = EmployeeBLL.GetEmployeeByName(name);

            if (result.Count == 0)
                Console.Write("\n\nNo records exist with this name");
            else
                result.ForEach(p => Console.Write("\n" + p));

        }

            public static void GetAllEmployees()
        {
            Console.Write("\nComplete details of all the empoyees : ");
            var result = EmployeeBLL.GetAllEmployees();
            result.ToList().ForEach(p => Console.Write("\n" + p));

        }

    }
    }

