using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task3()
        {
            Console.WriteLine("Enter number ");
            int number = Convert.ToInt16(Console.ReadLine());           
            if (number == 1 || number == 2 || number == 12)
                Console.WriteLine("Зима");
            else 
                if (number >= 3 && number <= 5)
                    Console.WriteLine("Весна");
                else
                    if (number >= 6 && number <= 8)
                        Console.WriteLine("Лето");
                    else 
                        if (number >= 9 && number <= 11)
                           Console.WriteLine("Осень");
                        else                            
                            Console.WriteLine("Такого месяца нет");
        }
    }
}