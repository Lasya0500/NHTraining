using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong3_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checking for armstrong numbers in a given range

            int startingNumber, endingNumber;

            //taking inputs
            Console.Write("\nEnter the starting 3 digit number : ");
            startingNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the ending 3 digit number : ");
            endingNumber = Convert.ToInt32(Console.ReadLine());

            //calling the method
            CheckArmstrong(startingNumber, endingNumber);

            Console.ReadLine();
        }

            static void CheckArmstrong(int startingNumber,int endingNumber)
            {

                //looping through the range 
                for (int n = startingNumber; n < endingNumber; n++)
                {
                    int copy, remainder = 0, sum = 0;
                    
                    //checking if the number is armstrong
                    copy = n;
                    while (copy != 0)
                    {
                    remainder = copy % 10;
                    sum += remainder * remainder * remainder;
                    copy /= 10;

                    }

                    //printing armstrong numbers in the given range
                    if (sum == n)
                    Console.Write("\n{0}", n);
                }


            }

            

        
    }
}
