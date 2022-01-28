using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber_function_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("\nEnter a number : ");
            input = Convert.ToInt32(Console.ReadLine());

            if (isArmstrong(input))
                Console.Write("\nit is armstrong");
            else
                Console.Write("\nit is not armstrong");

            Console.ReadLine();
        }


            static bool isArmstrong(int n)
            {
                int m, result = 0, rem;
                m = n;
                while(m>0)
                {
                    rem = m % 10;
                    m = m / 10;
                    result = result + rem * rem * rem;

                }

                if (result == n)
                    return true;
                else
                    return false;
            }





        
    }
}
