using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/****************************************************************************
Author : G V S S SRI LASYA
Purpose : Declare TWO 2-D arrays of size (2,2) and read values from user and 
print the sum of the two matrices.
****************************************************************************/


namespace Day13Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int[,] sumMatrix = new int[2, 2];


            Console.WriteLine("\nTaking user inputs for 2 matrices,calculating sum and printing the matrix");

            //taking user inputs for matrix1
            Console.Write("\n\n\n\nTaking inputs for matrix1\n\n");
            for (int i = 0; i < 2; i++)
            {

                for(int j = 0; j < 2; j++)
                {
                    Console.Write($"\nEnter the number matrix1[{i},{j}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //taking user inputs for matrix2
            Console.Write("\n\n\n\nTaking inputs for matrix2\n\n");
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"\nEnter the number matrix2[{i},{j}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //calculating sum matrix
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                    sumMatrix[i, j] = matrix1[i,j] + matrix2[i,j];

            }

            //printing out the sum matrix
            Console.Write("\n\n\n\nPrinting out the sum matrix\n\n");
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                    Console.Write(sumMatrix[i, j] + "\t");

                Console.WriteLine("\n");

            }

            Console.ReadLine();


        }
    }
}
