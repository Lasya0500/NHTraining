using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int variable1, variable2, variable3;

            Console.Write("\nenter first number : ");
            variable1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nenter second number : ");
            variable2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nbefore swap:number1={0} and number2={1}", variable1, variable2);

            variable1 = variable1+ variable2;
            variable2= variable1-variable2;
            variable1 = variable1- variable2;

            Console.Write("\nafter swap:number1={0} and number2={1}", variable1, variable2);

            Console.ReadLine();
        }
    }
}
