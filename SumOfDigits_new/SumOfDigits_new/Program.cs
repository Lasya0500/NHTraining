using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //finding sum of digits of a given number

            int input,sum = 0;

            //taking the input from user
            Console.Write("\nEnter the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            //calling the method
            sum = FindSum(input);

            //printing the sum
            Console.Write("\nSum of digits of {0} is {1} ",input,sum);

            Console.ReadLine();
        }
        
           //method is calculating sum of digits of the given number
        static int FindSum(int input)
            {
                int remainder = 0, sum = 0, copy;

                copy = input;
                while(copy != 0)
                {
                    remainder = copy % 10;
                    sum += remainder;
                    copy /= 10;
                }

                return sum;

            }
        
    }
}
