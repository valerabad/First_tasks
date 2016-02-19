using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task7()
        {
            Console.WriteLine("Enter number for checking: ");
            byte number = Convert.ToByte(Console.ReadLine());
            bool fl = false;
            int result = 0;
            if (number % 2 == 0)
                Console.WriteLine("Even number - not prime number!");
            else
            {
                for (int i = 2; i <= number - 1; i++)
                    if (number % i == 0)
                    {
                        fl = false;
                        break;
                    }
                    else
                    {
                        fl = true;
                        //break;
                    }
                if (fl)
                    Console.WriteLine("Prime number");
                else
                    Console.WriteLine("Not prime number!");
            }
        }
    }
}