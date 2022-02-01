using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /************************************************
             Author: G V S S SRI LASYA
             Purpose: Declare List<int> and read 5 values from user 
             and find sum using for loop,foreach and Lambda expression
            ************************************************/

            List<int> numbers = new List<int>(5);
            int intermediate,sum1 = 0,sum2 = 0,sum3 = 0;

            //taking number inputs from user
            for(int i = 0 ; i < 5 ; i++)
            {
                Console.Write("\nEnter number{0} : ",i+1);
                intermediate = Convert.ToInt32(Console.ReadLine());
                numbers.Add(intermediate);
            }

            //printing sum using for loop
            for(int i = 0; i < numbers.Count ; i++)
                sum1 += numbers[i];
            Console.Write("\n\nSum of numbers(using for loop) :{0}", sum1);

            //printing sum using foreach
            foreach (var number in numbers)
                sum2 += number;
            Console.Write("\n\nSum of numbers(using foreach) :{0}", sum2);

            //printing sum using Lambda expression
            numbers.ForEach(number => sum3 += number);
            Console.Write("\n\nSum of numbers(using Lambda expression) :{0}", sum3);

            Console.ReadLine();
        }
    }
}
