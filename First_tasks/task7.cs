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
            int[] divider = new int[] {2,3,5,7};
            Console.WriteLine("Enter number for checking: ");
            int number = Convert.ToInt16(Console.ReadLine());
            bool flag = false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if ((number % i) == 0)
                {                    
                    flag = false;
                    break;
                }
                else 
                    flag = true;
            }
            switch (flag)
            {
                case true:
                    Console.WriteLine("Prime number");
                    break;
                case false:
                    Console.WriteLine("Number isn`t prime");
                    break;
            }
            
        }
    }
}