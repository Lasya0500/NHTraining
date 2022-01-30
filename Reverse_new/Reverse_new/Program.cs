using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing reverse of given number
            int input,reverse;

            //taking the input
            Console.Write("\nEnter the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            //calling the method
            GetReverse(input);            

            Console.ReadLine();

        }

        //calculating reverse of give number
        static void GetReverse(int input)
        {
            int copy, remainder = 0;

            Console.Write("\nReverse of {0} is : ", input);
            copy = input;
            while(copy !=  0)
            {
                remainder = copy % 10;
                Console.Write(remainder);
                copy /= 10;
            }
        }
    }
}
