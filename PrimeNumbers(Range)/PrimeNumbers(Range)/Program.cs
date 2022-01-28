using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers_Range_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding prime numbers in a given range

            int startingNumber, endingNumber;

            Console.Write("\nEnter starting number : ");
            startingNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter ending number : ");
            endingNumber = Convert.ToInt32(Console.ReadLine());

            for (int i=startingNumber; i <= endingNumber; i++)
            {
                for(int j = 2 ; j <= i-1; j++)
                {
                    if (i % j == 0)
                        break;
                    else if (j == i - 1)
                        Console.Write("\n" + i);
                }

            }

            Console.ReadLine();
        }
    }
}
