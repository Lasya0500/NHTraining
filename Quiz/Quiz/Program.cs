using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Building a quiz code and creating its .exe file to be played
            in any computer even with different OS*/
           
            int score = 0;
            string name;

            //Greeting and collecting details
            Console.Write("Welcome to the quiz.Good Luck.");
            Console.Write("\nEnter your name : ");
            name = Console.ReadLine();

            //asking 5 quiz questions,collecting responses and updating score

            Console.Write("\nQ1)Find the odd one out");
            Console.Write("\n1.Circle\t2.Square\t3.Rectangle\t4.Triangle");
            Console.Write("\nEnter your response : ");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
                score = score + 20;

            Console.Write("\nQ1)Find the odd one out");
            Console.Write("\n1.Monitor\t2.Keyboard\t3.Scanner\t4.Mouse");
            Console.Write("\nEnter your response : ");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
                score = score + 20;

            Console.Write("\nQ1)Find the odd one out");
            Console.Write("\n1.Shillong\t2.Raipur\t3.Tripura\t4.Kohima");
            Console.Write("\nEnter your response : ");
            if (Convert.ToInt32(Console.ReadLine()) == 3)
                score = score + 20;

            Console.Write("\nQ1)Find the odd one out");
            Console.Write("\n1.Computer\t2.Gas stove\t3.Fan\t4.Television");
            Console.Write("\nEnter your response : ");
            if (Convert.ToInt32(Console.ReadLine()) == 2)
                score = score + 20;

            Console.Write("\nQ1)Find the odd one out");
            Console.Write("\n1.January\t2.May\t3.August\t4.November");
            Console.Write("\nEnter your response : ");
            if (Convert.ToInt32(Console.ReadLine()) == 4)
                score = score + 20;

            //Displaying score and end result
            Console.Write("\nTotal score is : " + score);
            if (score >= 60)
                Console.Write("\nCongrats {0},you won",name);
            else
                Console.Write("\nSorry {0},you lost.Better luck next time",name);

            
            Console.ReadLine();






        }
    }
}
