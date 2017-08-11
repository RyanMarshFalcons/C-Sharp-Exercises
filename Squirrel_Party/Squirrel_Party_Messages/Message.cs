using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squirrel_Party_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Squirrel Party program. The squirrels are having a party lets findout if it will be a success. Press enter to continue.");
            Console.ReadLine();
        }

        public static void HowManyNuts()
        {
            Console.Write("How many nuts do the squirrels have gathered for the party: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but the number of nuts cannot be negative. How many nuts do the squirrels\nhave gathered for the party: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input how many nuts the squirrels\nhave gathered for the party: ");
        }

        public static void SelectDayOfWeek()
        {
            Console.WriteLine("\nIs the party on:\nA) Monday\nB) Tuesday\nC) Wednesday\nD) Thursday\nE) Friday\nF) Saturday\nG) Sunday");
        }

        public static void NotADayOfTheWeek(string input)
        {
            Console.Write($"\nSorry but {input} is not a valid seclection please enter A, B, C, D, E, F, or G: ");
        }

        public static void PartyWillBeSuccessful()
        {
            Console.WriteLine("\nHooray the squirrel's party is going to be a success!!! Press enter to close theprogram.");
        }

        public static void PartyWillBeAFailure()
        {
            Console.WriteLine("\nOh no the squirrel's party is going to be a failure. Press enter to close the\nprogram.");
        }
    }
}
