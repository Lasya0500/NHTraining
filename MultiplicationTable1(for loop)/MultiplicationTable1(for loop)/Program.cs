using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable1_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Multiplication table of a number using concatenation
             and for loop*/

            int input;

            Console.Write("Enter the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            for(int i = 1 ; i <= 10 ; i++)
                Console.Write("\n" + input + " * " + i + " = " + input*i);

                Console.ReadLine();
        }
    }
}
