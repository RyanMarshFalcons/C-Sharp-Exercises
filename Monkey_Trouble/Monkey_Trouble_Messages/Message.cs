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
            Console.WriteLine("Hello and welcome to my Monkey Trouble program. You see two monkeys out in the\nwild, lets find out if you're in trouble. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterIfSmiling(string firstOrSecond)
        {
            Console.Write($"\nIs the {firstOrSecond} monkey smiling? y/n: ");
        }

        public static void NotyOrn(string firstOrSecond)
        {
            Console.Write($"\nSorry but you must input a y or an n. Is the {firstOrSecond} monkey smiling? y/n: ");
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
