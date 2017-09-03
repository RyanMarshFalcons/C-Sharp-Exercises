using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Planets program where I will perform calculations about how you\nwould be different on other planets. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectPlanet()
        {
            Console.WriteLine("Which planet would you like to learn how you would be different on:\nA) Mercury\nB) Venus\nC) Mars\nD) Jupiter\nE) Saturn\nF) Uranus\nG) Neptune\nH) Pluto");
        }

        public static void InvalidPlanetSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nWhich planet would you like to learn how you would be different on:\nA) Mercury\nB) Venus\nC) Mars\nD) Jupiter\nE) Saturn\nF) Uranus\nG) Neptune\nH) Pluto");
        }

        public static void MeasureSelections(string planet)
        {
            Console.WriteLine($"\nWould you like to find out:\nA) How much you would weigh on {planet}\nB) What your vertical leap on {planet} would be\nC) How old you would be on {planet}");
        }

        public static void InvalidMeasureSelection(string input, string planet)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection.\nWould you like to find out:\nA) How much you would weigh on {planet}\nB) What your vertical leap on {planet} would be\nC) How old you would be on {planet}");
        }

        public static void EnterNumber(string unitOfMeasurement, string action)
        {
            Console.Write($"\nPlease enter how many {unitOfMeasurement} {action}: ");
        }

        public static void NotAValidMeasurement(string input, string typeOfMeasurement, string unitOfMeasurement)
        {
            Console.Write($"\nSorry but {input} is not a valid {typeOfMeasurement}. Please input a valid\nnumber of {unitOfMeasurement}: ");
        }

        public static void MustBePositive(string typeOfMeasurement, string unitOfMeasurement)
        {
            Console.Write($"\nSorry but {typeOfMeasurement} must be positive. Please input a valid\nnumber of {unitOfMeasurement}: ");
        }

        public static void DisplayResults(string typeOfMeasurement, string planet, string unitOfMeasurement, double amount)
        {
            Console.WriteLine($"\nYour {typeOfMeasurement} on {planet} is {amount} {unitOfMeasurement}. Press enter to close\nthe program.");
        }
    }
}
