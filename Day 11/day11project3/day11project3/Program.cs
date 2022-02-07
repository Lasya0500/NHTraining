using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************************************************
Author : G V S S SRI LASYA
Purpose: Write sample code to illustrate properties as discussed in class.
id-get, set
name-get,set
designation-set (writeonly)
salary-get (get with some functionality)
**********************************************************************/


namespace day11project3
{
    public class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;


        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Designation
        {
            set { designation = value; }
        }

        public int Salary
        {
            get
            {
                salary = (designation == "HR") ? 250000 : 150000;
                return salary;
            }
        }

    }

        
        

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            //setting properties
            emp1.Id = 1;
            emp1.Name = "Raksha";
            emp1.Designation = "HR";

            //getting properties
            Console.Write("\n\nPrinting employee details");
            Console.Write("\n\n\nEmployee Id : " + emp1.Id);
            Console.Write("\n\nEmployee name : " + emp1.Name);
            Console.Write("\n\nEmployee salary : " + emp1.Salary);

            Console.ReadLine();




        }
    }
}
