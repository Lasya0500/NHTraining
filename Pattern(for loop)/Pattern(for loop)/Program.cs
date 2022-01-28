using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_for_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print pattern

            int input;
            Console.Write("\nenter number of rows to be printed : ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=input;i++)
                {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                    Console.Write("\n");

                }
            Console.ReadLine();    
        }
    }
}
