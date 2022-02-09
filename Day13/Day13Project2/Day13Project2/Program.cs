using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/****************************************************************************
Author : G V S S SRI LASYA
Purpose : Declare a 2-D array of size (3,2) and initialize in the same line
while declaring and print the values using nested for loop
****************************************************************************/


namespace Day13Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creating an array and initialising it during declaration
            int[,] matrix1 = new int[,] { { 1, 2 }, { 3, 4 },{ 5, 6 } };


            Console.Write("\n\nPrinting a 3*2 matrix\n\n\n\n");
            //printing matrix1 using for loop
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                  Console.Write(matrix1[i, j] + "\t");

            Console.WriteLine("\n");
            }

            Console.ReadLine();

        }
    }
}
