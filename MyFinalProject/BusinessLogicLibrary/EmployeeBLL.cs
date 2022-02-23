using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataAccessLibrary;
using System.IO;
namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static string filePath = "C:\\Users\\gottu\\Desktop\\csc images\\Employees.txt";
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            //todo add validations
            //if all validations are succesful then call dal

                var allEmployees = File.ReadAllLines(filePath);
                bool isFound = false;
                
                foreach (string employee in allEmployees)
                {
                    var employeeDetails = employee.Split(',');
                    if (Convert.ToInt32(employeeDetails[0]) == empId)
                    {
                        isFound = true;
                        break;
                     }
                }
                         
                
            if (Regex.Match(empName, "^[a-zA-Z.]{3,50}$").Success && Regex.Match(empId.ToString(), @"^[1-9]\d*$").Success && isFound == false)
            
            {

                var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);

                return result;
            }
            else
            {
                return false;
                
            }
        }

        public static List<string> GetEmployeeById(int id)
        {
            var result = EmployeeDAL.GetEmployeeById(id);
            return result;
        }

        public static List<string> GetEmployeeByName(string name)
        {
            var result = EmployeeDAL.GetEmployeeByName(name);
            return result;
        }

        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }


    }
}
