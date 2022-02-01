using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***********************************************
                Author : G V S S SRI LASYA
                Purpose : declare a List<string> with 5 user inputs and print
                using for loop,foreach and Lambda expression
            ***********************************************/

            List<string> colors = new List<string>(5);

            //taking user inputs using for loop
            for(int i = 1; i <= 5; i++)
            {
                Console.Write("\nEnter color{0} : ",i);
                colors.Add(Console.ReadLine());
            }

            //printing values using for loop
            Console.Write("\n\n\nColors(using for loop) :");
            for (int j = 0; j < colors.Count; j++ )
                 Console.Write("\t{0}",colors[j]);          

            //printing values using foreach
            Console.Write("\n\n\nColors(using foreach) :");
            foreach(var color in colors)
                Console.Write("\t{0}",color);            

            //printing values using Lambda expression
            Console.Write("\n\n\nColors(using Lambda expression) :");
            colors.ForEach(color => Console.Write("\t" + color));

            Console.ReadLine();





        }
    }
}
