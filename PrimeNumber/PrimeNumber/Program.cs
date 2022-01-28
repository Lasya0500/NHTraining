using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding if a number is prime or not using for loop

            int input,i;

            Console.Write("\nEnter a number : ");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("\nIt is not a prime number");
                    break;
                }
            }

            if (i == input)
                    Console.WriteLine("It is a prime number");

            Console.ReadLine();






        }
    }
}
