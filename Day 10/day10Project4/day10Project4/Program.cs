using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***********************************************************************
Author : G V S S SRI LASYA
Purpose :  Write sample code for method overriding(using new key word)
***********************************************************************/


namespace day10Project4
{
    class Greeting
    {
        /// <summary>
        /// Prints "Hi"
        /// </summary>
        ///<return>
        ///void
        /// </return>
        public void PrintHi()
        {
            Console.Write("\nHi");
        }


        /// <summary>
        /// Prints Good morning message in English
        /// </summary>
        /// <return>
        /// void
        /// </return>
        public void PrintGoodMornig()
        {
            Console.Write("\nGood morning");

        }

    }

    class GreetingInTelugu : Greeting
    {
        /// <summary>
        /// Prints Good morning in Telugu
        /// </summary>
        /// <return>
        /// void
        /// </return>
        public new void PrintGoodMornig()
        {
            Console.Write("\nSubhodayam");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetingInTelugu object1 = new GreetingInTelugu();

            Console.Write("\nGreetings\n\n");
            object1.PrintHi();
            object1.PrintGoodMornig();


            Console.ReadLine();
        }
    }
}
