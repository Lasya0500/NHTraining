using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_usingMethod_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding factorial using method

            int input,result=0;

            Console.Write("\nenter number : ");
            input = Convert.ToInt32(Console.ReadLine());

            result = FindFactorial(input);

            Console.Write("\nFactorial of {0} is {1}", input, result);

            Console.ReadLine();

        }

        static int FindFactorial(int n)
        {
            int factorial = 1;
            for(int i = 1; i <= n ; i++)
            {
                factorial *= i;
               
            }
            return factorial;


        }

        
    }
}
