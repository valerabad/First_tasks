using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task18()
        {
            string password = "root";
            string enteredPassword;
            Console.WriteLine("Enter the password:");
            do
            {               
                enteredPassword = Console.ReadLine();
                if (password.Equals(enteredPassword))
                {
                    Console.WriteLine("Success! Correct password");
                }
                else Console.WriteLine("Error! Try again");
            }
            while (password.Equals(enteredPassword) != true);
                
        }
    }
}