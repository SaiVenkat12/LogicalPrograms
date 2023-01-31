using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TemperatureConversion
    {
        public static void Conversion()
        {
            double celsius, fahrenheit;
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("\n1.Celsius to Fahrenheit \n2.Fahrenheit to Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Temperature in Celsius : ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = (celsius * (9 / 5) + 32);
                    Console.WriteLine("{0} Celsius in Fahrenheit is {1}", celsius, fahrenheit);
                    break;
                case 2:
                    Console.WriteLine("Enter the Temperature in Fahrenheit : ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * (5 / 9);
                    Console.WriteLine("{0} Fahrenheit in Celsius is {1}", fahrenheit, celsius);
                    break;
            }
        }
    }
}
