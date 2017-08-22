using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversions_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Temperature Conversions program where I will convert a specified\nunit of temperature for you based on your input. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectConversion()
        {
            Console.WriteLine("Select one of the following types of temperature conversions:\nA) Celsius to Fahrenheit\nB) Fahrenheit to Celsius\nC) Kelvin to Rankine\nD) Rankine to Kelvin");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Select one of the following types\nof temperature conversions:\nA) Celsius to Fahrenheit\nB) Fahrenheit to Celsius\nC) Kelvin to Rankine\nD) Rankine to Kelvin");
        }

        public static void EnterTemperature(string temperatureType)
        {
            Console.Write($"\nPlease enter the number of degrees {temperatureType}: ");
        }

        public static void NotATemperature(string input, string temperatureType)
        {
            Console.Write($"\nSorry but {input} degrees {temperatureType} is not a temperature. Please input a valid\nnumber of degrees {temperatureType}: ");
        }

        public static void DisplayResult(double numOfOriginal, double numOfNew, string oldTempType, string newTempType)
        {
            Console.WriteLine($"\n{numOfOriginal} dgrees {oldTempType} is equal to {numOfNew} degrees {newTempType}. Press enter to close\nthe program.");
        }
    }
}
