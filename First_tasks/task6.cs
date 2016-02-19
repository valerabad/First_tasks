using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task6()
        {
            int total = 0, tmp = 1, stand = 0;
            Console.WriteLine("Enter distanse");
            int distance = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            int minutes = Convert.ToByte(Console.ReadLine());
            stand = minutes * 1;
            if (distance <= 5)
                total = distance * 20;
            else
                while (tmp <= 5)
                {
                    total = total + 20;
                    tmp++;
                }
            for (int i = 6; i <= distance; i++)
                total = total + 3;
            total = total + stand;
            Console.WriteLine("The cost of your trip is {0}{1}", total, " hrn");
        }
    }
}