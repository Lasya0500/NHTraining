using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Checking for armstrong number

            int input, copy,remainder = 0,sum = 0;

            //takig input
            Console.Write("\nEnter the 3 digit number to check : ");
            input = Convert.ToInt32(Console.ReadLine());
            copy = input;

            //evaluating sum of digits of given number
            while(copy != 0)
            {
                remainder = copy % 10;
                sum = sum + (remainder * remainder * remainder);
                copy = copy / 10;
            }

            //checking if the sum of digits is same as the given input
            if (sum == input)
                Console.Write("\n{0} is an armstrong number",input);
            else
                Console.Write("\n{0} is not an armstrong number",input);

            Console.ReadLine();



            
        }
    }
}
