using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task17()
        {            
            Console.WriteLine("Rabits\tGeese");
            int geese = 64;
            int r_res = 0, g_res = geese;
            for (int rabbits = 0; rabbits <= 64; rabbits = rabbits + 4)
            {
                Console.WriteLine(rabbits / 4 + "\t" + geese / 2);
                geese = geese - 4;
            }  
        }
    }
}