using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_Conversions_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Volume Conversions program where I will convert a specified unit\nof volume for you based on your input. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectConversion()
        {
            Console.WriteLine("Select one of the following types of volume conversions:\nA) Gallons to Liters\nB) Liters to Gallons\nC) Milliliters to Teaspoons\nD) Teaspoons to Milliliters");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Select one of the following types\nof volume conversions:\nA) Gallons to Liters\nB) Liters to Gallons\nC) Milliliters to Teaspoons\nD) Teaspoons to Milliliters");
        }

        public static void EnterVolume(string volumeType)
        {
            Console.Write($"\nPlease enter the volume in {volumeType}: ");
        }

        public static void NotAVolume(string input, string volumeType)
        {
            Console.Write($"\nSorry but {input} {volumeType} is not a volume. Please input a valid\nnumber of {volumeType}: ");
        }

        public static void CantBeNegative(string volumeType)
        {
            Console.Write($"\nSorry but volumes cannot be negative. Please input a valid number of\n{volumeType}: ");
        }

        public static void DisplayResult(double numOfOriginal, double numOfNew, string oldVolumeType, string newVolumeType)
        {
            Console.WriteLine($"\n{numOfOriginal} {oldVolumeType} is equal to {numOfNew} {newVolumeType}. Press enter to close the\nprogram.");
        }
    }
}
