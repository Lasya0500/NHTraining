using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_foreach_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading 4 user input values and printing them using foreach

            int[] numbers = new int[4];

            //Taking 4 user inputs using for loop

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write("\nEnter number {0} : ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            //Printing the 4 user inputs using foreach loop

            Console.Write("\n\nThe 4 inputs given by user are : ");
            foreach(int number in numbers)
                Console.Write("{0}\t",number);

             Console.ReadLine();

        }
    }
}
