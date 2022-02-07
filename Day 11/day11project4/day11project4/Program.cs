using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************
Author : G V S S SRI LASYA
Purpose : Create Mathematics class and add 3 static methods and call the 
methods in main method.
**************************************************************************/

namespace day11project4
{
    class Maths
    {
        /// <summary>
        /// adding 2 integers and returning sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>
        /// int
        /// </returns>
        public static int Add(int a,int b)
        {
            return a + b;
        }


        /// <summary>
        /// subtracting 2 integers and returning difference
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>
        /// int
        /// </returns>
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// multiplying 2 integers and returning product
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>
        /// int
        /// </returns>
        public static int Multiply(int a,int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("\n\nPrinting sum,difference,product of 2 integers");

            //taking user inputs
            Console.Write("\n\n\n\nEnter first integer : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter second integer : ");
            b = Convert.ToInt32(Console.ReadLine());

            //printing outputs
            Console.Write("\n\n\n\nSum of " + a + " and " + b + " : " + Maths.Add(a, b));
            Console.Write("\n\nDifference of " + a + " and " + b + " : " + Maths.Subtract(a, b));
            Console.Write("\n\nProduct of " + a + " and " + b + " : " + Maths.Multiply(a, b));

            Console.ReadLine();
        }
    }
}
