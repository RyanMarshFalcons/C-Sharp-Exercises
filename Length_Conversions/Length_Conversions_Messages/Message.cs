using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_Conversions_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Length Conversions program where I will convert a specified unit\nof length for you based on your input. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectConversion()
        {
            Console.WriteLine("Select one of the following types of length conversions:\nA) Feet to Meters\nB) Meters to Feet\nC) Kilometers to Miles\nD) Miles to Kilometers");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Select one of the following types\nof length conversions:\nA) Feet to Meters\nB) Meters to Feet\nC) Kilometers to Miles\nD) Miles to Kilometers");
        }

        public static void EnterLength(string lengthType)
        {
            Console.Write($"\nPlease enter the length in {lengthType}: ");
        }

        public static void NotALength(string input, string lengthType)
        {
            Console.Write($"\nSorry but {input} {lengthType} is not a length. Please input a valid\nnumber of {lengthType}: ");
        }

        public static void CantBeNegative(string lengthType)
        {
            Console.Write($"\nSorry but lengths cannot be negative. Please input a valid number of\n{lengthType}: ");
        }

        public static void DisplayResult(double numOfOriginal, double numOfNew, string oldTempType, string newTempType)
        {
            Console.WriteLine($"\n{numOfOriginal} {oldTempType} is equal to {numOfNew} {newTempType}. Press enter to close the\nprogram.");
        }
    }
}
