﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    class TempConvert
    {
       
        public void CelsiusToFahrenheit()
        {
            double celsius, fahrenheit;
            Console.WriteLine("Enter the Temperature in Celsius (°C) : ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is (°F) : " + fahrenheit);
        }

       
        public void FahrenheitToCelsius()
        {
            double fahrenheit, celsius;
            Console.WriteLine("Enter the Temperature in Farhenheit(°F) : ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius is (°C) : " + celsius);
        }
    }
}