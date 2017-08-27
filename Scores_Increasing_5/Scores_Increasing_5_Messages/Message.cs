using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scores_Increasing_5_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Scores Increasing 5 program where you will enter five numbers and then I will tell you whether or not all the numbers you inputted are equal to orgreater than the number preceding it. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecondThirdFourthFifth)
        {
            Console.Write($"\nPlease enter the {firstSecondThirdFourthFifth} number: ");
        }

        public static void NotANumber(string input, string firstSecondThirdFourthFifth)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {firstSecondThirdFourthFifth} number: ");
        }

        public static void AreIncreasing()
        {
            Console.WriteLine($"\nCongratulations all the numbers you inputted are increasing in value!!! Press\nenter to close the program");
        }

        public static void AreNotIncreasing()
        {
            Console.WriteLine($"\nUnfortunately not all the numbers you inputted are increasing in value. Press\nenter to close the program");
        }
    }
}
