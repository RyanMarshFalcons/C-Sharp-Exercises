using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Celsius to Fahrenheit program. Enter a temperature in celsius and I will tell you the temperature in fahrenheit. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterTemperature()
        {
            Console.Write("Please enter the number of degrees celsius: ");
        }

        public static void NotATemperature(string input)
        {
            Console.Write($"\nSorry but {input} celsius is not a temperature. Please input a valid number of\ndegrees celsius: ");
        }

        public static void DisplayFahrenheit(double numOfCelsius, double numOfFahrenheit)
        {
            Console.WriteLine($"\n{numOfCelsius} dgrees celsius is equal to degrees {numOfFahrenheit} fahrenheit.");
        }
    }
}
