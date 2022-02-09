using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************************
Author : G V S S SRI LASYA
Purpose : WACP to illustrate usage of Queue<>
****************************************************************************/


namespace Day13Project10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(10);
            numbers.Enqueue(20);
            numbers.Enqueue(30);
            numbers.Enqueue(40);

            Console.Write("\n\nAdding integers to the queue and removing them using first in-first out algorithm");
            Console.Write("\n\n\n\nTotal count of elements of queue : {0}\n\n\n",numbers.Count);
            Console.Write("\nFirst number added to the queue : {0}\n\n\n\n", numbers.Peek());
            
           
            Console.Write("\nValues in order of addition to the queue\n");
            for(int i = 1; i <= 4; i++)
                Console.Write("\n" + numbers.Dequeue());

            
            Console.Write("\n\n\n\n\nUpdated total count of elements of queue : {0}", numbers.Count);

            
            Console.ReadLine();


        }
    }
}
