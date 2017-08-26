using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenly_Spaced_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Evenly Spaced program where you will enter three numbers and then I will tell you if they are evenly spaced or not. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecondThird)
        {
            Console.Write($"\nPlease enter the {firstSecondThird} number: ");
        }

        public static void NotANumber(string input, string firstSecondThird)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {firstSecondThird} number: ");
        }

        public static void AreEvenlySpaced(int num1, int num2, int num3, int space)
        {
            Console.WriteLine($"\nCongratulations {num1} and {num2} are {space} apart just like {num2} and {num3} are {space}\napart!!! Press enter to close the program.");
        }

        public static void AreNotEvenlySpaced(int num1, int num2, int num3, int space1, int space2)
        {
            Console.WriteLine($"\nUnfortunately {num1} and {num2} are {space1} apart while {num2} and {num3} are {space2} apart.\nPress enter to close the program.");
        }
    }
}
