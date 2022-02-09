using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/****************************************************************************
Author : G V S S SRI LASYA
Purpose : WACP to declare a jagged array and print values
****************************************************************************/

namespace Day13project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[][] matrix1 = new int[5][];


            Console.Write("\n\nPrinting a jagged array\n\n\n");
            //giving user inputs for jagged array
            matrix1[0] = new int[] { 1, 2, 3 };
            matrix1[1] = new int[] { 4, 5, 6, 7, 5};
            matrix1[2] = new int[] { 7, 8, 9 };
            matrix1[3] = new int[] { 11, 21, 1, 3, 53, 23, 4 };
            matrix1[4] = new int[] { 2, 4, 12, 34, 22, 3 };


            //printing the jagged array
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                    Console.Write(matrix1[i][j] + "\t");

                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
