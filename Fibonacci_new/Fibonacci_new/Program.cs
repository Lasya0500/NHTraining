using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printing fibonacci series

            int firstNumber = 0, secondNumber = 1, currentNumber = 0,input;

            Console.Write("\nEnter number of values in the series to print : ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
                Console.Write("\nSeries : " + firstNumber);
            else
            {
                Console.Write("\nSeries : " + firstNumber + "\t" + secondNumber);

                for (int i = 1; i <= input - 2; i++)
                {
                    currentNumber = firstNumber + secondNumber;
                    Console.Write("\t" + currentNumber);
                    firstNumber = secondNumber;
                    secondNumber = currentNumber;
                }
            }

            Console.ReadLine();



                

        }
    }
}
