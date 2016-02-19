using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    class Program
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
                    case 0: System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Enter your lastname ");
                        string lastName = Console.ReadLine();

                        Console.WriteLine("Enter yor name ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter yor father name ");
                        string fatherName = Console.ReadLine();

                        Console.WriteLine("+---------------------------------------------+");
                        //Console.WriteLine('\u007C'+ lastName +'\t'+ name + '\t' + fatherName + '\u007C');
                        Console.WriteLine("\u007C {0}\t{1}\t{2} \u007C", lastName, name, fatherName);
                        Console.WriteLine("+---------------------------------------------+");
                        break;
                    case 2:
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
                        break;
                    case 3:
                        Console.WriteLine("Enter command: мяу or гав");
                        string str = Console.ReadLine();
                        switch (str)
                        {
                            case "мяу":
                                Console.WriteLine("Покорми кота");
                                break;
                            case "гав":
                                Console.WriteLine("Погуляй с собакой");
                                break;
                            default:
                                Console.WriteLine("Неизвестная команда");
                                break;
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter number ");
                            int number = Convert.ToInt16(Console.ReadLine());
                            if (number == 1 || number == 2 || number == 12)
                                Console.WriteLine("Зима");
                            if (number >= 3 && number <= 5)
                                Console.WriteLine("Весна");
                            if (number >= 6 && number <= 8)
                                Console.WriteLine("Лето");
                            if (number >= 9 && number <= 11)
                                Console.WriteLine("Осень");
                            if (number > 12)
                                Console.WriteLine("Такого месяца нет");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter 1 or 0 ");
                            int number = Convert.ToInt16(Console.ReadLine());
                            string result;
                            result = (number == 1) ? "хорошо" : ((number == 0) ? "плохо" : "другое число");
                            Console.WriteLine(result);

                        }
                        break;
                    case 6:
                        {
                            byte number;
                            Console.WriteLine("Enter number day: ");
                            number = Convert.ToByte(Console.ReadLine());

                            switch (number)
                            {
                                case 1:
                                    Console.WriteLine("Monday");
                                    break;
                                case 2:
                                    Console.WriteLine("Tuesday");
                                    break;
                                case 3:
                                    Console.WriteLine("Wednesday");
                                    break;
                                case 4:
                                    Console.WriteLine("Thursday");
                                    break;
                                case 5:
                                    Console.WriteLine("Friday");
                                    break;
                                default: Console.WriteLine("Number better 7");
                                    break;
                            }
                            break;
                        }
                    case 7:
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
                        break;
                    case 8:
                        {
                            Console.WriteLine("Enter number for checking: ");
                            byte number = Convert.ToByte(Console.ReadLine());
                            bool fl = false;
                            int result = 0;
                            if (number % 2 == 0)
                                Console.WriteLine("Even number - not prime number!");
                            else
                            {
                                for (int i = 2; i <= number - 1; i++)
                                    if (number % i == 0)
                                    {
                                        fl = false;
                                        break;
                                    }
                                    else
                                    {
                                        fl = true;
                                        //break;
                                    }
                                if (fl)
                                    Console.WriteLine("Prime number");
                                else
                                    Console.WriteLine("Not prime number!");
                            }
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Enter bet: ");
                            int bet = Convert.ToInt16(Console.ReadLine());
                            int dice_1, win = 0;

                            Random rndv = new Random();
                            dice_1 = rndv.Next(1, 13);
                            Console.WriteLine("Random: {0} ", dice_1);

                            if (dice_1 >= 1 && dice_1 <= 5) win = 0;
                            if (dice_1 >= 6 && dice_1 <= 8) win = bet;
                            if (dice_1 >= 9 && dice_1 <= 11) win = 2 * bet;
                            if (dice_1 == 12) win = bet * 10;

                            Console.WriteLine("your winnings = {0}", win);

                        }
                        break;
                    case 10:
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
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
