using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong2_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking for armstrong  number using function

            int input;

            Console.Write("\nEnter the 3 digit number to be checked : ");
            input = Convert.ToInt32(Console.ReadLine());

            if (CheckArmstrong(input))
                Console.Write("\n{0} is an armstrong number", input);
            else
                Console.Write("\n{0} is not an armstrong number", input);

            Console.ReadLine();
        }

        static bool CheckArmstrong(int argument)
        {
            int remainder = 0, sum = 0,copy;

            copy = argument;
            while(copy != 0)
            {
                remainder = copy % 10;
                sum = sum + remainder * remainder * remainder;
                copy = copy / 10;
            }

            return (sum == argument) ? (true) : (false);

        }
    }
}
