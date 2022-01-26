using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding sum of first n natural numbers using for loop

            int input, sum = 0;

            Console.Write("Enter the number of natural numbers to be added : ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
                sum = sum + i;

            Console.Write("\nSum of first " + input + " natural numbers is: " + sum);

            Console.ReadLine();


        }
    }
}
