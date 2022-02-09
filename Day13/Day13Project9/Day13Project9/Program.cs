using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/****************************************************************************
Author : G V S S SRI LASYA
Purpose : WACP to illustrate usage of Stack<>
****************************************************************************/


namespace Day13Project9
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Stack<int> numbers =new Stack<int>();

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(34);
            numbers.Push(24);
            numbers.Push(46);
            numbers.Push(58);


            Console.Write("\n\nAdding integers to the stack and removing them based on last in-first out algorithm");

            Console.Write("\n\n\n\nLast number added to the stack is : {0}", numbers.Peek());
            Console.Write("\n\n\n\nTotal count of numbers in the stack is : {0}", numbers.Count());
            
            Console.Write("\n\n\n\nNumbers of the stack by displaying recently added ones first\n");
            for(int i = 1; i <= 6; i++) 
                Console.Write("\n{0}",numbers.Pop());

            Console.Write("\n\n\n\nUpdated total count of numbers in the stack is : {0}", numbers.Count());

            Console.ReadLine();

        }
    }
}
