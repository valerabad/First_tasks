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
            int geeseLegs = 64;         
            for (int rabbitsLegs = 0; rabbitsLegs <= 64; rabbitsLegs = rabbitsLegs + 4)
            {
                Console.WriteLine(rabbitsLegs / 4 + "\t" + geeseLegs / 2);
                geeseLegs = geeseLegs - 4;
            }  
        }
    }
}