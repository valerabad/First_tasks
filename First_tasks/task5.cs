using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task5()
        {
            byte number;
            Console.WriteLine("Enter number day: ");
            number = Convert.ToByte(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default: Console.WriteLine("Number better 7");
                    break;
            }
        }
    }
}