using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers2_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swapping 2 numbers without using third variable

            int firstNumber,secondNumber;

            //taking inputs
            Console.Write("\nEnter first number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter second number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nValues before swapping : {0} {1}",firstNumber,secondNumber);

            //swapping numbers
            firstNumber = firstNumber + secondNumber; 
            secondNumber = firstNumber - secondNumber; 
            firstNumber = firstNumber - secondNumber; 

            //printing outputs
            Console.Write("\nValues after swapping : {0} {1}", firstNumber, secondNumber);

            Console.ReadLine();
        }
    }
}
