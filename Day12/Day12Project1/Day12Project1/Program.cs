using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/******************************************************************************
Author : G V S S SRI LASYA
Purpose :  Write a simple division program and handle three exceptions discussed
in the class., also add super exception at the last.
******************************************************************************/


namespace Day12Project1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;

                //taking inputs
                Console.Write("\nEnter dividend : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter divisor : ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;

                Console.Write("\n\n\n\nQuotient of division of {0} and {1} is : {2}", a, b, c);

            }

            catch (DivideByZeroException)
            {
                Console.Write("\n\n\n\nCan't divide with zero.");
            }

            catch (OverflowException)
            {
                Console.Write("\n\n\n\nNumbers only in range of 1 and 500000 are acceptable");
            }

            catch(FormatException)
            {
                Console.Write("\n\n\n\nOnly numbers are allowed.Please enter valid inputs");
            }

            catch(Exception)
            {
                Console.Write("\n\n\n\nSystem error occured.Please contact admin");
            }

            finally
            {
                Console.Write("\n\n\n\nSimple division program");
                Console.ReadLine();
            }




        }
    }
}
