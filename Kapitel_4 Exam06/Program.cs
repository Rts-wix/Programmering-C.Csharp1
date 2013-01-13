using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapitel_4_Exam06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the unit price: "); string text = Console.ReadLine();
            double price = Convert.ToDouble(text); Console.Write("Enter the number of units: "); text = Console.ReadLine();
            int quantity = Convert.ToInt32(text);
            double amount = price * quantity;
            double vat = amount * 0.25;
            double total = amount + vat;
            Console.WriteLine("{0, -15} {1, 10:F}", "Unit price", price); 
            Console.WriteLine("{0, -15} {1, 10:D}", "Number of units", quantity); 
            Console.WriteLine("{0, -15} {1, 10:F}", "Total excl. VAT", amount); 
            Console.WriteLine("{0, -15} {1, 10:F}", "VAT", vat);
            Console.WriteLine("{0, -15} {1, 10:F}", "Total incl. VAT", total);
        }
    }
}
