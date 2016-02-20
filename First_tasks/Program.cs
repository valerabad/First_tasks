using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {               
                Console.WriteLine("Select task 1..10 or 0 for exit");
                int task;
                task = Convert.ToInt16(Console.ReadLine());
                switch (task)
                {                   
                    case 0: task0();
                        break;
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        {
                            task3();
                        }
                        break;
                    case 4:
                        {
                            task4();
                        }
                        break;
                    case 5:
                        {
                            task5();
                        }
                        break;
                    case 6:
                        {
                            task6();
                         break;
                        }
                    case 7:
                        {
                            task7();
                        }
                        break;
                    case 8:
                        {
                            task8();
                        }
                        break;
                    case 9:
                        {
                            task9();
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Enter N:");
                            double N = Convert.ToDouble(Console.ReadLine());
                            task11(N);
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("Enter N:");
                            double N = Convert.ToDouble(Console.ReadLine());
                            task12(N);
                        }
                        break;
                    case 13:
                        {                           
                            task13();
                        }
                        break;
                    default: System.Environment.Exit(0);
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
