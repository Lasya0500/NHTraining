using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************************
Author : G V S S SRI LASYA
Purpose : Declare a 2-D array of size (3,3) and print trace of the array
****************************************************************************/


namespace Day13Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j,trace = 0;
            int[,] matrix1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            Console.Write("\n\nPrinting out trace of the matrix\n\n\n");

            //calculating trace of the matrix
            for (i = 0; i < 3; i++)
            {

                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                        trace += matrix1[i, j];
                }

            }

            Console.Write($"\nTrace of the matrix {matrix1[0,0]} + {matrix1[1,1]} + {matrix1[2,2]} : {trace}");

            Console.ReadLine();


        }
    }
}
    

