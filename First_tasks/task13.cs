using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task13()
        {           
            Random random = new Random();
            double randomNumber = random.Next(1,147);
            Console.WriteLine("Guess the number");
            while (true)
            {
                double N = Convert.ToDouble(Console.ReadLine());
                if (N == randomNumber)
                {
                    Console.WriteLine("You guessed number");
                    break;
                }
                else
                {
                    if (randomNumber < N)
                        Console.WriteLine("less. Try again");
                    else Console.WriteLine("larger. Try again");
                }
            }
        }
    }
}