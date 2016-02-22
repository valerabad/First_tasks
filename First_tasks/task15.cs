using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task15()
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter nember:" + i);
                array[i] = Convert.ToInt16(Console.ReadLine());
            }
            double average = array.Average();
            Console.WriteLine("Average = {0}",average) ;            
        }
    }
}
