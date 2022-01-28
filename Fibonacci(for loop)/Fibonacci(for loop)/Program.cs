using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing fibonacci series

            int n, i, firstNumber=0, secondNumber=1,currentNumber=0,input;

            Console.Write("\nenter number of terms to be printed(n>2) : ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.Write("0\t1");
            for(i = 1; i <= input - 2; i++)
            {
                currentNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = currentNumber;
                Console.Write("\t" + currentNumber);
            }

            Console.ReadLine();

        }
    }
}
