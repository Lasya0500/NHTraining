using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindExponent_Console_App_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, exponent, result = 1;

            Console.Write("Enter the number : ");
            number   = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the exponnet : ");
            exponent = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < exponent ; i++)
            {
                result = result * number;
            }

            Console.WriteLine("\nResult is : "+ result);

            Console.ReadLine();
        }
    }
}
