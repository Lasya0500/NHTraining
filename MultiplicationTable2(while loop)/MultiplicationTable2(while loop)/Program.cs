using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Multiplication table of a number using 
             flower bracket format and while loop*/

            int input,i = 1;

            Console.Write("Enter the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                Console.Write("\n{0} * {1} = {2}", input, i, input * i);
                i++;
            }

            Console.ReadLine();
            
               
            
            
        }
    }
}
