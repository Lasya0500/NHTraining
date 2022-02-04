using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************
Author : G V S S SRI LASYA
Purpose : Write C# program to read two numbers from use and print
   a. sum of two numbers
   b. difference of two numbers
   c. product of two numbers
   d. division of two numbers.
*******************************************************************/


namespace Day9Project2
{
    class MathTasks
    {
       private int number1, number2;

        /// <summary>
        /// To take inputs from user 
        /// </summary>
        ///<return>
        ///void
        /// </return>
        public void ReadInput()
        {
            Console.Write("\nEnter number1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter number2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());

        }

        /// <summary>
        /// To add given inputs 
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int AddNumbers()
        {
            return number1 + number2;
           
        }

        /// <summary>
        /// To subtract given inputs 
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int SubtractNumbers()
        {
            return number1 - number2;
        }

        /// <summary>
        /// To multiply given inputs 
        ///<return>
        ///int
        /// </return>
        public int MultiplyNumbers()
        {

            return number1 * number2;

        }

        /// <summary>
        /// To divide given inputs 
        /// </summary>
        ///<return>
        ///int
        /// </return>
        public int DivideNumbers()
        {
            return number1 / number2;
            
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathTasks object1 = new MathTasks();

            //calling methods of the class MathTasks
            object1.ReadInput();
            Console.Write($"\n\n\nSum of given numbers is : {object1.AddNumbers()}");
            Console.Write($"\n\n\nDifference of given numbers is : {object1.SubtractNumbers()}");
            Console.Write($"\n\n\nProduct of given numbers is : {object1.MultiplyNumbers()}");
            Console.Write($"\n\n\nDivision of given numbers gives quotient : {object1.DivideNumbers()}");


            Console.ReadLine();
        }
    }
}
