using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitel_5_Exam09
{
    class Program
    {

        static int Enter()
        {
            Console.Write("Enter an integer: ");
            string text = Console.ReadLine();
            return Convert.ToInt32(text);
        }

        static void Sort1(int a, int b)
        {
            if (a > b)
            {
                int t = a; a = b;
                b = t; Console.WriteLine("{0} {1}", a, b);
            }
        }

        static void Main(string[] args)
        {
            int a = Enter();
            int b = Enter();
            Sort1(a, b);
        }
    }
}
