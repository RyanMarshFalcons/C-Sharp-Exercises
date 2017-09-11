using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey_Trouble_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Monkey Trouble program. You see two monkeys staring at\nyou, lets find out if you're in trouble. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterIfSmiling(string firstOrSecond)
        {
            Console.Write($"\nIs the {firstOrSecond} monkey smiling? y/n: ");
        }

        public static void EnterIfwearingYellow()
        {
            Console.Write("\nAre you wearing yellow? y/n: ");
        }

        public static void EnterIfCaged()
        {
            Console.Write("\nAre the monkeys in a cage? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please try again: ");
        }

        public static void InTrouble()
        {
            Console.WriteLine("\nOh no you're in trouble!!! Press enter to close the program.");
        }

        public static void NotInTrouble()
        {
            Console.WriteLine("\nWhew that was close, you're not in trouble. Press enter to close the program.");
        }
    }
}
