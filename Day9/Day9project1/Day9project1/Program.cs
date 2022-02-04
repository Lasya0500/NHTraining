using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/****************************************************************
Author : G V S S SRI LASYA
Purpose :  Write a C# program to read input from user and print
   a. factorial of a number
   b. factors of a number
   c. check if it prime or not
****************************************************************/



namespace Day9project1
{
    class MathOperations
    {
        private int input;

       /// <summary>
       /// To take input from the user
       /// </summary>
       /// <return>
       /// void
       /// </return>
      
        public void ReadInput()
        {
            Console.Write("\nEnter the number : ");
            input = Convert.ToInt32(Console.ReadLine());
        }


        /// <summary>
        /// To find factorial of given number and return factorial
        ///</summary>
        ///<returns>
        ///int
        ///</returns>

        public int FindFactorial()
        {
            int factorial = 1;

            for(int i = 1; i <= input; i++)
                factorial *= i;
            
            return factorial;
           
        }

        /// <summary>
        /// To check if a number is prime or not
        /// </summary>
        /// <returns>
        /// bool
        /// </returns>
               public bool IsPrime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }

           return (count == 2) ? true : false;

        }

        /// <summary>
        /// To print factors of give number
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        public void PrintFactors()
        {
            
            Console.Write($"\n\nFactors of {input} are : ");
            for(int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.Write("\t" + i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations object1 = new MathOperations();

            //calling all the methods of MathOperations class
            object1.ReadInput();

            Console.Write($"\n\nFactorial is : {object1.FindFactorial()}");

            if (object1.IsPrime())
                Console.Write("\n\nGiven number is prime");
            else
                Console.Write("\n\nGiven number is not prime");
            
            object1.PrintFactors();

            Console.ReadLine();

        }
    }
}
