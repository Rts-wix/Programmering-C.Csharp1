using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam02
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
            More();
        }

        private static void Title()
        {
            Console.WriteLine("Pro C# 2010 and the .NET 4 Platform");
            Console.WriteLine("Andrew Troelsen");
            Console.WriteLine("ISBN: 978-1-4302-2549-2");
            Console.WriteLine("Apress");
        }

        private static void More()
        {
            Console.WriteLine("Fifth edition");
            Console.WriteLine("Published 2010");
            Console.WriteLine("1712 pages");
        }
    }
}