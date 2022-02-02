using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8Project1
{

    /*********************************************************************
     Author : G V S S SRI LASYA
     Purpose : Declare and initialize a list with 8 values.
     write for loop, foreach loop, lambda, linq query to print even numbers

    *********************************************************************/


    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 11, 12, 13, 14, 15, 16, 17 };

            //printing even numbers using for loop
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.Write($"\n{numbers[i]}");
            }


            Console.WriteLine("\n");
            //printing even numbers using foreach 
            foreach(var number in numbers)
            {
                if(number%2 == 0)
                    Console.Write($"\n{number}");
            }

            Console.WriteLine("\n");
            //printing even numbers using lambda expression
            numbers.Where(number => number % 2 == 0).ToList().ForEach(number => Console.Write($"\n{number}"));

            Console.WriteLine("\n");
            //printing even numbers using linq
            var result = from number in numbers
                         where number % 2 == 0 
                         select number;
            result.ToList().ForEach(number => Console.Write($"\n{number}"));


            Console.ReadLine();
        }
    }
}
