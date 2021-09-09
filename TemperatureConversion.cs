using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitPrograms
{

    
    /// this is class TemperatureConversion
    
    public class TemperatureConversion
    {
        
        /// Conversion, this is instance.
        
        public static void Conversion()
        {
            Console.WriteLine("\nEnter your option:\n1.Celsius To Fahrenheit\n2.Fahrenheit To Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter value in Celsius:");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Celsius To Fahrenheit: " + Utility.CelsiusToFahrenheit(celsius));
                    break;
                case 2:
                    Console.WriteLine("Enter value in Fahrenheit:");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fahrenheit To Celsius: " + Utility.FahrenheitToCelsius(fahrenheit));
                    break;
                default:
                    Console.WriteLine("Wrong option!!!");
                    break;
            }
        }
    }
}
