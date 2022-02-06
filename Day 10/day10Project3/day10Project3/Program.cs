using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************
Author : G V S S SRI LASYA
Purpose : Write example code for multi level inheritance
****************************************************************/


namespace day10project2
{
    class MathsOperaations1
    {
        /// <summary>
        /// adds 2 integers and retuns sum
        /// </summary>
        /// <returns>
        /// int
        /// </returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// subtracts 2 integers and returns difference
        /// </summary>
        /// <returns>
        /// int
        /// </returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

    }

    class MathsOperations2 : MathsOperaations1
    {
        /// <summary>
        /// multiplies 2 integers and returns product
        /// </summary>
       /// <returns>
        /// int
        /// </returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class MathsOperations3 : MathsOperations2
    {
        /// <summary>
        /// Divides 2 integers and returns quotient
        /// </summary>
        /// <returns>
        /// float
        /// </returns>
        public float Divide(int a, int b)
        {
            return (float)a / b;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0, d = 0, e = 1;
            float f = 1f;

            MathsOperations3 object1 = new MathsOperations3();

            Console.Write("\nFinding sum,difference,product,quotient of division for 2 integers");

            //taking user inputs
            Console.Write("\n\n\nEnter  first integer : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter  second integer : ");
            b = Convert.ToInt32(Console.ReadLine());

            //calling methods using object
            c = object1.Add(a, b);
            d = object1.Subtract(a, b);
            e = object1.Multiply(a, b);
            f = object1.Divide(a, b);

            //printing outputs
            Console.Write($"\n\n\nSum : {c}");
            Console.Write($"\n\nDifference : {d}");
            Console.Write($"\n\nProduct : {e}");
            Console.Write($"\n\nQuotient of division : {f}");

            Console.ReadLine();

        }
    }
}

