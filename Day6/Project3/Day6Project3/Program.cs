using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /***********************************************
             Author : G V S S SRI LASYA
             Purpose : declare ArrayList and assign some values
             and find sum.
            ************************************************/

            int sum = 0;
            ArrayList numbers = new ArrayList();

            //assigning values
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            //calculating sum using and printing it
            foreach (var number in numbers)
                sum += (int)number;
            Console.Write("\nSum of ArrayList values is : {0}",sum);

            Console.ReadLine(); 
        }
    }
}
