using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task2()
        {
            Console.WriteLine("Enter command: мяу or гав");
            string str = Console.ReadLine();
            switch (str)
            {
                case "мяу":
                    Console.WriteLine("Покорми кота");
                    break;
                case "гав":
                    Console.WriteLine("Погуляй с собакой");
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }
    }
}