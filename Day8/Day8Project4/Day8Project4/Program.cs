using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************************
Author : G V S S SRI LASYA
Purpose : Create a Department class and add variables id,name,empcount
write code to print id,name of departments whose empcount is greater than 50
using
for
foreach
lambda
linq query
****************************************************************************/




namespace Day8Project4
{
    class Department
    {

        public int id;
        public string name;
        public int empCount;
      
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //creating a Department list,initialising it 
            List<Department> departments = new List<Department>()
            {
                new Department() { id = 1, name = "Department1", empCount = 20 },
                new Department() { id = 2, name = "Department2", empCount = 30 },
                new Department() { id = 3, name = "Department3", empCount = 70},
                new Department() { id = 4, name = "Department4", empCount = 60},
                new Department() { id = 5, name = "Department5", empCount = 100}
            };


            //printing name and id of departments whose empCount>50 using for loop
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].empCount > 50)
                    Console.Write($"\ndepartment : {departments[i].name}\t\tid : {departments[i].id}");

            }


            Console.WriteLine("\n\n");
            //printing name and id of departments whose empCount>50 using foreach
            foreach (var department in departments)
            {
                if (department.empCount > 50)
                    Console.Write($"\ndepartment : {department.name}\t\tid: {department.id}");
            }


            Console.WriteLine("\n\n");
            //printing name and id of departments whose empCount>50 using lambda expression
            departments.ToList().Where(department => department.empCount > 50).ToList().ForEach(department => Console.Write($"\ndepartment : {department.name}\t\tid : {department.id}"));


            Console.WriteLine("\n\n");
            //printing name and id of departments whose empCount>50 using LINQ
            var result = from department in departments
                         where department.empCount > 50
                         select department;

            result.ToList().ForEach(department => Console.Write($"\ndepartment : {department.name}\t\tid : {department.id}"));

            Console.ReadLine();

        }

    }

}













