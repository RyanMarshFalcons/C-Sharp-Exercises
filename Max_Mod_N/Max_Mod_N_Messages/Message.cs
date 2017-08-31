using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Mod_N_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Max Mod N program where you enter two numbers and a Modulus numberand then I will tell you which one of the first two numbers is more powerful.\nThe more powerful number is whichever number is larger except when they both\nhave the same remainder when divided by the Modulus number, in which case the\nsmaller number is more powerful. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(string firstSecondModulus)
        {
            Console.Write($"\nEnter the {firstSecondModulus} number: ");
        }

        public static void NotANumber(string input, string firstSecondModulus)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the {firstSecondModulus} number: ");
        }

        public static void CantBeZero(string firstSecondModulus)
        {
            Console.Write($"\nSorry but the number cannot be zero. Please enter the {firstSecondModulus} number: ");
        }

        public static void MorePowerful(int num)
        {
            Console.WriteLine($"\n{num} is the more powerful number. Press enter to close the program.");
        }

        public static void NeitherMorePowerful(int num)
        {
            Console.WriteLine($"\nNeither number is more powerful because they are both the number {num}. Press enter to close the program.");
        }
    }
}
