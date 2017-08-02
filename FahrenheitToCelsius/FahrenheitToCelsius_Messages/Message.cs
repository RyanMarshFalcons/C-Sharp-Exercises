using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsius_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Fahrenheit to Celsius program. Enter a temperature in fahrenheit\nand I will tell you the temperature in celsius. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterTemperature()
        {
            Console.Write("Please enter the number of degrees fahrenheit: ");
        }

        public static void NotATemperature(string input)
        {
            Console.Write($"\nSorry but {input} fahrenheit is not a temperature. Please input a valid number\nof degrees fahrenheit: ");
        }

        public static void DisplayCelsius(double numOfFahrenheit, double numOfCelsius)
        {
            Console.WriteLine($"\n{numOfFahrenheit} degrees fahrenheit is equal to {numOfCelsius} degrees celsius.");
        }
    }
}
