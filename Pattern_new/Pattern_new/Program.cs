using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing star pattern using  for loop

            int rows;

            //taking input from user
            Console.Write("\nEnter number of rows to print : ");
            rows = Convert.ToInt32(Console.ReadLine());

            //printing pattern
            for(int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for(int j = 1; j <= i; j++)
                    Console.Write("* ");
            }

            Console.ReadLine();

        }
    }
}
