using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/******************************************************************
Author : G V S S SRI LASYA
Purpose : Declare a 2-D array of size (3,3) and read values from 
user and print the array values.
*******************************************************************/


namespace Day13Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrix1 = new int[3, 3];

            Console.Write("\n\nTaking user input for a 3*3 matrix and printing out the matrix");


            //taking user inputs for the matrix
            Console.Write("\n\n\n\nEnter inputs for the matrix\n\n");
            for(int i = 0; i< 3; i++)
            {
                for(int j = 0; j< 3; j++)
                {

                    Console.Write($"Enter number matrx1[{i},{j}]: ");
                    matrix1[i,j] = Convert.ToInt32(Console.ReadLine());

                }

            }

            //printing the matrix
            Console.Write("\n\n\nPrinting out the matrix\n\n");
            for(int i = 0; i< 3; i++)
            {

                for(int j = 0; j< 3; j++)
                    Console.Write(matrix1[i,j] + "\t");

                Console.Write("\n\n");
            }

            Console.ReadLine();
           
        }
    }
}
