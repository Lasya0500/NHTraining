using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorail_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding factorial of a number using for loop

            int input, factorial = 1;

            Console.Write("Enter the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= input ; i++)
                factorial = factorial * i;

            Console.Write("\nFactorial of " + input + " is : " + factorial);

            Console.ReadLine();
        }
    }
}
