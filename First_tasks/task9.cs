using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task9()
        {
            const double UAtoUSD = 27.2d;
            const double UAtoEUR = 30.2d;
            const double EURtoUSD = 1.2d;
            Console.WriteLine("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter currency: ");
            string currency = Console.ReadLine();
            double result1, result2;
            switch (currency)
            {
                case "USD":
                    {
                        result1 = amount * UAtoUSD;
                        result2 = amount / EURtoUSD;
                        Console.WriteLine("{0} грн   {1} evro", result1, result2);
                    }
                    break;
                case "EUR":
                    {
                        result1 = amount * UAtoEUR;
                        result2 = amount * EURtoUSD;
                        Console.WriteLine("{0} грн   {1} $", result1, result2);
                    }
                    break;
                case "UA":
                    {
                        result1 = amount / UAtoUSD;
                        result2 = amount / UAtoEUR;
                        Console.WriteLine("{0} $   {1} evro", result1, result2);
                    }
                    break;
            } 
        }
    }
}