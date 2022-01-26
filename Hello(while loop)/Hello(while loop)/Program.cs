using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_while_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printing "Hello" 5 times,using while loop

            string word = "Hello";
            int i = 1;

            while(i <= 5)
            {
                Console.WriteLine(word + "\n");
                i++;
            }

            Console.ReadLine();
        }
    }
}
