using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, m, rem, rev = 0;
            Console.Write("\nenter a number : ");
            input=Convert.ToInt32(Console.ReadLine());

            m = input;
            while(m>0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;

            }

            if (rev == input)
                Console.Write("\nit is palindrome");
            else
                Console.Write("\nit is not palindrome");

            Console.ReadLine();
        }
    }
}
