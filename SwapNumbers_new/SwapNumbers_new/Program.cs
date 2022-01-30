using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swapping numbers using 3rd variable

            int firstNumber,secondNumber, intermediate;

            Console.Write("\nEnter first number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter second number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nValues before swapping : {0} {1}",firstNumber,secondNumber);

            intermediate = firstNumber;            
            firstNumber = secondNumber;
            secondNumber = intermediate;

            Console.Write("\nValues after swapping  : {0} {1}", firstNumber, secondNumber);

            Console.ReadLine();

        }
    }
}
