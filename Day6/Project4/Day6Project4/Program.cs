using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /************************************************
             Author : G V S S SRI LASYA
             Purpose : declare List<int> and assign some values
             and find sum
            ************************************************/

            int sum = 0;
            List<int> numbers = new List<int>(5);

            //assigning values 
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            //calculating sum and printing it
            foreach (int number in numbers)
                sum += number;
            Console.WriteLine("\nSum of values of the list is : {0}",sum);

            Console.ReadLine();
        }
    }
}
