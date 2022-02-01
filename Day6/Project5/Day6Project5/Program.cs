using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /************************************************
             Author : G V S S SRI LASYA
             Purpose : Implicit and explicit type casting.
            ************************************************/

            
            short value1 = 10;
            int value2 = 40;
            int value3 = 13;
            double value4 = 100d;

            //implicit type conversion
            Console.Write("\nValue before implicit type conversion : {0}", value2);

            value2 = value1;
            Console.Write("\nValue after implicit type conversion : {0}", value2);

            //explicit type conversion
            Console.Write("\n\n\nValue before explicit type conversion : {0}", value3);

            value3 = (int)value4;
            Console.Write("\nValue after explicit type conversion : {0}", value3);

            Console.ReadLine();
        }
    }
}
