using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking if a number is armstrong

            int n, rem, m, result = 0;

            Console.Write("\nEnter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

            m = n;
            while(m > 0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem * rem * rem;

            }
            if (result == n)
                Console.Write("\n{0} is armstrong number", n);
            else
                Console.Write("\n{0} is not armstrong number", n);

            Console.ReadLine();
        }
    }
}
