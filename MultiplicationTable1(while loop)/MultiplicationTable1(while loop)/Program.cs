using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable1_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Multiplication table of a number using concatenation
             and while loop */

            int input,i=1;

            Console.Write("Enter the the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            while(i <= 10)
            {
                Console.Write("\n" + input + " * " + i + " = " + input * i);
                i++;
            }

            Console.ReadLine();
            
        }
    }
}
