using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Multiplication table of a number using 
             flower bracket format */

            int input;

            Console.Write("Enter the numebr : ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.Write("\n{0} * {1} = {2}", input, i, input * i);

            Console.ReadLine();
            
        }
    }
}
