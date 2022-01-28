using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  m, input,rem=0, result = 0;
            Console.Write("\nenter a number : ");
            input = Convert.ToInt32(Console.ReadLine());

            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem;
            }

            Console.Write("\nSum of digits of {0} is {1}", input, result);
            Console.ReadLine();




        }
    }
}
