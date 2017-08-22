using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight_Conversions_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Weight Conversions program where I will convert a specified unit\nof weight for you based on your input. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectConversion()
        {
            Console.WriteLine("Select one of the following types of weight conversions:\nA) Grams to Ounces\nB) Ounces to Grams\nC) Kilograms to Pounds\nD) Pounds to Kilograms");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Select one of the following types\nof weight conversions:\nA) Grams to Ounces\nB) Ounces to Grams\nC) Kilograms to Pounds\nD) Pounds to Kilograms");
        }

        public static void EnterWeight(string weightType)
        {
            Console.Write($"\nPlease enter the weight in {weightType}: ");
        }

        public static void NotAWeight(string input, string weightType)
        {
            Console.Write($"\nSorry but {input} {weightType} is not a weight. Please input a valid\nnumber of {weightType}: ");
        }

        public static void CantBeNegative(string weightType)
        {
            Console.Write($"\nSorry but weights cannot be negative. Please input a valid number of\n{weightType}: ");
        }

        public static void DisplayResult(double numOfOriginal, double numOfNew, string oldWeightType, string newWeightType)
        {
            Console.WriteLine($"\n{numOfOriginal} {oldWeightType} is equal to {numOfNew} {newWeightType}. Press enter to close the\nprogram.");
        }
    }
}
