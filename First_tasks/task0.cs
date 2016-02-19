using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_tasks
{
    partial class Program
    {
        static public void task0()       
        {
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
        }
    }
}