using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scores_Increasing_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Scores Increasing program where you will enter five scores and\nthen I will tell you whether or not all the scores that you inputted are equal\nto or greater than the score preceding it. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterScore(string firstSecondThirdFourthFifth)
        {
            Console.Write($"\nPlease enter the {firstSecondThirdFourthFifth} score: ");
        }

        public static void NotAScore(string input, string firstSecondThirdFourthFifth)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {firstSecondThirdFourthFifth} score: ");
        }

        public static void CantBeNegative(string firstSecondThirdFourthFifth)
        {
            Console.Write($"\nSorry but scores cannot be negative. Please input the {firstSecondThirdFourthFifth} score: ");
        }

        public static void AreIncreasing()
        {
            Console.WriteLine($"\nCongratulations all of the scores you inputted are increasing in value!!! Press enter to close the program");
        }

        public static void AreNotIncreasing()
        {
            Console.WriteLine($"\nUnfortunately not all of the scores you inputted are increasing in value. Press enter to close the program");
        }
    }
}
