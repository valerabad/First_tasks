using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task1()
        {
            Console.WriteLine("Enter two numbers ");
            try
            {
                int result;
                int A = Convert.ToInt16(Console.ReadLine());
                int B = Convert.ToInt16(Console.ReadLine());
                if (A > B) Console.WriteLine(A);
                else if (A < B)
                    Console.WriteLine(B);
                else Console.WriteLine("equal");
                //result = ((A > B) ? A : B);                                                                         
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}