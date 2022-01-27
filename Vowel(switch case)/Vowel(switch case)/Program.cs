using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_switch_case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*taking a letter as user input and 
            checking if it is vowel using switch case*/

            char letter;

            //taking letter input from user

            Console.Write("\nEnter the letter to be checked : ");
            letter = Convert.ToChar(Console.ReadLine());

            //checking if its a vowel

            switch(letter)
            {
                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u':
                    Console.Write("\nIt is a vowel");
                    break;
                default:
                    Console.Write("\nIt is a consonent");
                    break;
            }

            Console.ReadLine();
        }
    }
}
