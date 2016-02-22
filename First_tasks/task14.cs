using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task14()
        {
            Console.WriteLine("Enter limit:");
            int limit = Convert.ToInt16(Console.ReadLine());
            int n = 0; 
            while (Math.Pow(n, 2) < limit)
            {                
                Console.WriteLine(Math.Pow(n, 2));
                n++;
            }
            
        }
    }
}