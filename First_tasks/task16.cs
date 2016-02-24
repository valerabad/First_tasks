using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task16()
        {
            Random rndm = new Random();
            int[] randomNumbers = new int[5];
            for (int i=0; i<5;i++)
            {
                randomNumbers[i] = rndm.Next(100);
                Console.WriteLine(randomNumbers[i]);
            }
            Console.WriteLine("Avrage of random numbers = {0}",randomNumbers.Average());           
        }
    }
}