using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessLibrary
{
    public static class EmployeeDAL
    {
        public static string filePath = "C:\\Users\\gottu\\Desktop\\csc images\\Employees.txt";

        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                string textContent = string.Concat(empId, ",",empName, ",",empSalary, ",", empAge);
                File.AppendAllText(filePath, textContent + Environment.NewLine);
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }

        }

        public static List<string> GetEmployeeById(int id)
        {
            var allEmployees = File.ReadAllLines(filePath);
            bool isFound = false;
            List<string> employeeFound = new List<string>();

            foreach(string employee in allEmployees)
            {
                var employeeDetails = employee.Split(',');
                if(Convert.ToInt32(employeeDetails[0]) == id)
                {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;

                }
            }

            return employeeFound;
        }

        public static List<string> GetEmployeeByName(string name)
        {
            var allEmployees = File.ReadAllLines(filePath);
            bool isFound = false;
            List<string> employeeFound = new List<string>();

            foreach (string employee in allEmployees)
            {
                var employeeDetails = employee.Split(',');
                if (employeeDetails[1].Contains(name))
                {
                    isFound = true;
                    employeeFound.Add(employee);                    

                }
            }

            return employeeFound;
        }

        public static string[] GetAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filePath);
            return allEmployees;
        }
    }
}
