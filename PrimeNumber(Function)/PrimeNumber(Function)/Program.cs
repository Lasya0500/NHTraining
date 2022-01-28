using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber_Function_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking for prime number using functions
            int input;

            Console.Write("\nEnter a number to be checked : ");
            input = Convert.ToInt32(Console.ReadLine());

            CheckPrimeNumber(input);

            Console.ReadLine();
        }

        //Method to check if the numbwe is prime and print    
       static void CheckPrimeNumber(int number)
            {
                for (int i = 2; i < number; i++)
                    {
                    if (number % i == 0)
                    {
                        Console.Write("\nIt is not prime number");
                        break;
                    }
                    else if (i == number - 1)
                        Console.Write("\nIt is prime number");
                    }
            }
        
    }
}
