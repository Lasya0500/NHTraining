using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_foreach_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taking 5 user inputs and finding their sum using foreach

            int[] numbers = new int[5];
            int sum = 0;

            //taking 5 user inputs using for loop
            
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\nEnter number {0} : ",i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*finding sum of the 5 user inputs using foreach loop 
             and printing it*/

            foreach(int number in numbers)
            {
                sum += number;
            }    

            Console.Write("\nSum of 5 user inputs : " + sum);

            Console.ReadLine();


        }
    }
}
