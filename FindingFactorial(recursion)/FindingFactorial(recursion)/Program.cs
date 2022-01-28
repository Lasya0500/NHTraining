using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingFactorial_recursion_
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Finding factorial using recursion

            int input,result;

            //taking only valid inputs
            Console.Write("\nEnter the number : ");
            input = Convert.ToInt32(Console.ReadLine());
            
            if (input < 0)
                Console.Write("\nNumber not valid");
            else
            {
                result = FindFactorial(input);
                Console.Write("\nFactorial of given number is : {0} ", result);
            }

            Console.ReadLine();

        }

        //Method to find factorial of given number
        static int FindFactorial(int number)
        {
         
            if (number > 0)
                return number * FindFactorial(number - 1);
           
            else if (number == 0)
                return 1;

            //anyhow we dont call method for negative numbers
            else
                return 0;
        }




        
    }
}
