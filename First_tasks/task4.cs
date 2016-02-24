using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task4()
        {
            Console.WriteLine("Enter 1 or 0 ");
            int number = Convert.ToInt16(Console.ReadLine());
            string result;
            result = (number == 1) ? "хорошо" : ((number == 0) ? "плохо" : "другое число");
            Console.WriteLine(result);
        }
    }
}