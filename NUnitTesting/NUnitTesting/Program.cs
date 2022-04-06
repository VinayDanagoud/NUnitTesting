// See https://aka.ms/new-console-template for more information
using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter a Principal");
            double principal = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter Interest Rate");
            double rate = Convert.ToDouble(Console.ReadLine());
            
            rate = (rate / 100) / 12;
            
            Console.WriteLine("Enter a Year");
            int year = Convert.ToInt32(Console.ReadLine());
            year = year * 12;

           
            double pay = (principal * rate) / (1 - Math.Pow(1 + rate, -year));

            Console.WriteLine("Payment " + pay);
            Console.ReadLine();
        }

    }
}

