using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking if given input is palindrome

            int input;

            //taking user input
            Console.Write("\nEnter the number : ");
            input = Convert.ToInt32(Console.ReadLine());

            //calling method and printing result
            if(CheckPalindrome(input))
                Console.Write("\n{0} is palindrome",input);
            else
                Console.Write("\n{0} is not palindrome",input);

            Console.ReadLine();
        }

        //method to check if given input is palindrome
        static bool CheckPalindrome(int input)
        {
            int copy, remainder = 1, reverse = 0;

            copy = input;
            while(copy > 0)
            {
                remainder = copy % 10;
                reverse = reverse * 10 + remainder;
                copy = copy / 10;
            }

            return (input == reverse) ? true : false;
        }
    }
}
