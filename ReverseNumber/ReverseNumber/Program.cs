using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fidning reverse of given number

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

            Console.Write("\nReverse of {0} is {1}", input, rev);
            Console.ReadLine();


        }
    }
}
