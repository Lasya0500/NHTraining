using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finding sum and average of 5 user inputs using arrays 

            int sum = 0;
            float average = 0.0f;
            int[] numbers = new int[5];

            /*Finding sum of given 5 numbers using for loop 
            and printing it*/
            for (int i = 0; i < 5; i++)
            {

                Console.Write("\nEnter number {0} : ", i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                sum += numbers[i];

            }

            Console.Write("\n\nSum of given numbers : " + sum);

            //Calculating average of given 5 numbers and printing it
            average = sum / 5.0f;
            Console.Write("\nAverage of given numbers is : " + average);

            Console.ReadLine();



        }
    }
}
