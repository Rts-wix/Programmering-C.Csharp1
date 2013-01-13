using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitel_4_Exam05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: "); 
            string text = Console.ReadLine(); 
            double r = Convert.ToDouble(text); 
            double p = r * 2 * Math.PI; 
            double a = r * r * Math.PI; 
            Console.WriteLine("Perimeter and area of a circle with radius {0:F4}: {1:F4}, {2:F4}", r, p, a);
        }
    }
}
