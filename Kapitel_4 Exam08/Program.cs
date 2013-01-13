using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitel_4_Exam08
{
    class Program
    {
        static void Main(string[] args)
        {
            long t1 = Convert.ToInt64(args[0]);
            long t2 = Convert.ToInt64(args[1]);
            Console.WriteLine("Quotient of {0} and {1} is {2}", t1, t2, t1 / t2);
            Console.WriteLine("Modulus of {0} and {1} is {2}", t1, t2, t1 % t2);
        }
    }
}
