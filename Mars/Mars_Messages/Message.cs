using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Mars program where I will perform calculations about how you\nwould be different on the planet Mars. Press enter to continue.");
            Console.ReadLine();
        }

        public static void Selections()
        {
            Console.WriteLine("Would you like to:\nA) Find out how much you would weigh on Mars\nB) Find out how high you could jump on Mars\nC) Find out how old you would be on Mars\nD) Close the Mars program");
        }

        public static void InvalidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string unitOfMeasurement, string action)
        {
            Console.Write($"\nPlease enter how many {unitOfMeasurement} {action}: ");
        }

        public static void NotAValidEntry(string input, string typeOfMeasurement, string unitOfMeasurement)
        {
            Console.Write($"\nSorry but {input} is not a valid {typeOfMeasurement}. Please input a valid\nnumber of {unitOfMeasurement}: ");
        }

        public static void MustBePositive(string typeOfMeasurement, string unitOfMeasurement)
        {
            Console.Write($"\nSorry but {typeOfMeasurement} must be positive. Please input a valid\nnumber of {unitOfMeasurement}: ");
        }

        public static void DisplayResults(string typeOfMeasurement, string unitOfMeasurement, double amountOnMars)
        {
            Console.WriteLine($"\nYour {typeOfMeasurement} on Mars is {amountOnMars} {unitOfMeasurement}. Press enter to continue.");
            Console.ReadLine();
        }

        public static void ThankYou()
        {
            Console.WriteLine("\nThank you for taking the time to use my Mars program I hope that it was\neducational. Press enter to close the program.");
        }
    }
}
