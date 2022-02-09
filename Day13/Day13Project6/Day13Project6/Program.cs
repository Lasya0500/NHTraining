using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/****************************************************************************
Author : G V S S SRI LASYA
Purpose : Declare TWO 2-D arrays of size (2,2) and read values from user and 
print the product of the two matrices.
****************************************************************************/


namespace Day13Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int m,n,p;

            int[,] matrix1 ;
            int[,] matrix2;
            int[,] productMatrix;

            Console.Write("\n\nTaking user inputs for 2 2D matrices,calculating product and printing the product matrix");

            Console.Write("\n\n\n\nEnter the number of rows of the matrix1 : ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the number of columns of the matrix2 : ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease ensure that the number of columns of matrix1 and number of rows of matrix2 are equal,give a number : ");
            n = Convert.ToInt32(Console.ReadLine()); 

           matrix1 = new int[m,n];
           matrix2 = new int[n,p];
           productMatrix = new int[m,p];


            //taking user inputs for matrix1
            Console.Write("\n\n\n\nTaking inputs for matrix1\n");
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"\nEnter the number for matrix1[{i},{j}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //taking user inputs for matrix2
            Console.Write("\n\n\n\nTaking inputs for matrix2\n");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < p; j++)
                {
                    Console.Write($"\nEnter the number for matrix2[{i},{j}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //calculating product matrix
            for (int i = 0; i < m; i++)
            {

                for(int j = 0; j < p; j++)
                {
                    for(int k = 0; k < n; k++)
                    {
                        productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }

            }

            //printing out the product matrix
            Console.Write("\n\n\n\nPrinting out the product matrix\n\n");
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < p; j++)
                    Console.Write(productMatrix[i,j] + "\t");

                Console.WriteLine("\n");

            }

            Console.ReadLine();


        }
    }
}
