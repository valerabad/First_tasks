using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task12(double N)
        {
            int count = 0;
            while (N!=0)
            {
                N = N / 10;
                N = Math.Truncate(N);
                count++;
            }           
            Console.WriteLine(count);
        }
    }
}