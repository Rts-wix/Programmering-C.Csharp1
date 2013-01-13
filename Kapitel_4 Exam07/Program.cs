using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitel_4_Exam07
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now; Time1(dt); Time2(dt);
        }
        static void Time1(DateTime t)
        {
            Console.WriteLine("{0:D2} {1:D2} {2:D2} {3:D3}", t.Hour, t.Minute, t.Second, t.Millisecond);
        }
        static void Time2(DateTime t)
        {
            Console.WriteLine(t.ToLongDateString());
            Console.WriteLine(t.ToLongTimeString());
        }



    }
}
