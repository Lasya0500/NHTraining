using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************************************************************
Author : G V S S SRI LASYA
Purpose : Declare a 2 dimentional array of size (2,2) and initialize using indices 
and print the values using nested for loop
*********************************************************************************/



namespace Day13Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crearing array and initialising it using index
            int[,] matrix1 = new int[2, 2];
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1,0] = 3;
            matrix1[1,1] = 4;

            Console.WriteLine("\n\nPrinting a 2*2  matrix\n\n\n\n");

            //printing the values of matrix using for loop
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                    Console.Write(matrix1[i, j] + "\t");
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
