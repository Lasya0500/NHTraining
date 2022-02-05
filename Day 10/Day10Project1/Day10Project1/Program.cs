using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**************************************************************
Author : G V S S SRI LASYA
Purpose :  Write sample code for method overloading
**************************************************************/


namespace Day10Project1
{
    class Algebra
    {
        /// <summary>
        /// Adds two integers and returns sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>
        /// int
        /// </returns>
        public int Add(int a,int b)
        {
            return a + b;
        }


        /// <summary>
        /// Adds 3 integers and returns sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>
        /// int
        /// </returns>
        public int Add(int a, int b,int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Adds 2 floats and returns sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>
        /// float
        /// </returns>
        public float Add(float a,float b)
        {
            return a + b;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float c, d;

            Algebra object1 = new Algebra();

            //taking user inputs
            Console.Write("\nAdding 2 integers");
            Console.Write("\nEnter first integer : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n\nAdding 2 decimal numbers");
            Console.Write("\nEnter first decimal number : ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second decimal number: ");
            d = Convert.ToSingle(Console.ReadLine());


            //printing output
            Console.Write($"\n\n\nSum of the 2 integers is : {object1.Add(a, b)}");
            Console.Write($"\n\nSum of the 2 decimal numbers is : {object1.Add(c,d)}");

            Console.ReadLine();






        }
    }
}
