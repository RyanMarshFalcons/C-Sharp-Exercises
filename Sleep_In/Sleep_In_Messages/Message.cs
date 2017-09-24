using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleep_In_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Sleep In program where I tell you whether or not you can sleep in tomorrow morning. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectDayOfWeek()
        {
            Console.WriteLine("Is tomorrow:\nA) Monday\nB) Tuesday\nC) Wednesday\nD) Thursday\nE) Friday\nF) Saturday\nG) Sunday");
        }

        public static void NotADayOfTheWeek(string input)
        {
            Console.Write($"\nSorry but {input} is not a valid seclection please enter A, B, C, D, E, F, or G: ");
        }

        public static void AskIfVacationDay()
        {
            Console.Write("\nAre you going to be on vacation tomorrow? y/n: ");
        }

        public static void AskIfHaveBigPlans()
        {
            Console.Write("\nDid you make plans to spend time with your kids tomorrow morning? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void YesCanSleepIn()
        {
            Console.WriteLine("\nCongratulations you can sleep in tomorrow!!! Press enter to close the program.");
        }

        public static void NoCannotSleepIn()
        {
            Console.WriteLine("\nSorry but you can't sleep in tomorrow. Press enter to close the program.");
        }
    }
}
