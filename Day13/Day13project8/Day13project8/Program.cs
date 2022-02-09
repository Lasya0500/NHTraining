using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/****************************************************************************
Author : G V S S SRI LASYA
Purpose : WACP to illustrate usage of Recursion.
****************************************************************************/


namespace Day13project8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number,factorial;

            Console.Write("\n\nFinding factorial for a user given input");

            Console.Write("\n\n\nEnter the number to find factorial : ");
            number = Convert.ToInt32(Console.ReadLine());

            factorial = FindFactorial(number);

            Console.Write($"\nFactorial of {number} is : {factorial}");

            Console.ReadLine();

        }


        /// <summary>
        /// Finding factorial for user given input
        /// </summary>
        /// <param name="n"></param>
        /// <returns>
        /// int
        /// </returns>
        static int FindFactorial(int n)
        {
            int factorial = 1;

            if (n == 0)
                return 1;
            else
                factorial = n * FindFactorial(n - 1);

            return factorial;
        }
    }
}
