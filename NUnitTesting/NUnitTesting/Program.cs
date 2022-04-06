// See https://aka.ms/new-console-template for more information
using System;

namespace NUnitTesting
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            double N = Convert.ToDouble(Console.ReadLine());
            // L is the tolerence level
            double L = 0.00001;
            double t = N;
            double sqRoot;
            int count = 0;

            while (true)
            {
                count++;
                sqRoot = 0.5 * (t + (N / t));

                if (Math.Abs(sqRoot - t) < L)
                {
                    break;
                }
                t = sqRoot;
            }
            Console.WriteLine("Root Value is : " + Math.Round(sqRoot, 2));
            Console.ReadLine();
        }
    }
}
