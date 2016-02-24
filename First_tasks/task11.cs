using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task11(double N)
        {           
            for (int i=1; i<=20; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",i,N,i*N);
            }
        }
    }
}