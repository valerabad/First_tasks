using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task8()
        {
            Console.WriteLine("Enter bet: ");
            int bet = Convert.ToInt16(Console.ReadLine());
            int dice_1, win = 0;

            Random rndv = new Random();
            dice_1 = rndv.Next(1, 13);
            Console.WriteLine("Random: {0} ", dice_1);

            if (dice_1 >= 1 && dice_1 <= 5) win = 0;
            else
                if (dice_1 >= 6 && dice_1 <= 8) win = bet;
                else
                    if (dice_1 >= 9 && dice_1 <= 11) win = 2 * bet;
                    else
                        win = bet * 10;

            Console.WriteLine("your winnings = {0}", win);
        }
    }
}