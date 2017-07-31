using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roman_Numerals
{
    public static class Message
    {
        public static void Welcome ()
        {
            Console.Write("Hello. Welcome to the Roman Numerals Exercise. Please input an arabic number " + 
                          "\nthat you would like to see displayed as a Roman numeral and then press "+
                          "\nenter: ");
        }

        public static void IsEmpty()
        {
            Console.WriteLine("\nNo input was given so I cannot do a conversion for you.");
        }

        public static void IsZero()
        {
            Console.WriteLine("\nSorry but the ancient Romans never discovered the number zero.");
        }

        public static void IsNotAnInteger (string userInput)
        {
            Console.WriteLine($"\nSorry but {userInput} is not an arabic number.");
        }

        public static void IsNegative()
        {
            Console.WriteLine("\nSorry but the ancient Romans had no concept of negative numbers.");
        }

        public static void IsTooHigh()
        {
            Console.WriteLine("\nSorry but the Romans didn't count past 3,999");
        }

        public static void RomanNumeral(string output)
        {
            Console.WriteLine($"\nAs a Roman Numeral your number is {output}");
        }
    }
}
