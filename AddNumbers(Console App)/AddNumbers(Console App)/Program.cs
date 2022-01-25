using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers_Console_App_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, sum = 0;

            Console.Write("Enter 1st number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 2nd  number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            sum = firstNumber + secondNumber;

            Console.Write("\nResult : " + sum);

            Console.ReadLine();
        }
    }
}
