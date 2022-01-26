using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingFactors_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding factors of a number using for loop

            int input;

            Console.Write("Enter the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            for(int i = 1 ; i <= input ; i++)
            {
                if(input % i == 0)
                    Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
