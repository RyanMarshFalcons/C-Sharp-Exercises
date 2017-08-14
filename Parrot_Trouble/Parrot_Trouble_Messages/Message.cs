using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot_Trouble_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Parrot Trouble program. You have a loud talking parrot\nas a pet. Lets find out if they're causing trouble when they make noise. Press\nenter to continue.");
            Console.ReadLine();
        }

        public static void EnterIfDoing(string activity)
        {
            Console.Write($"\nIs anyone in your household {activity}? y/n: ");
        }

        public static void NotyOrn(string activity)
        {
            Console.Write($"\nSorry but you must input a y or an n. Is anyone in your household\n{activity}? y/n: ");
        }

        public static void CausingTrouble()
        {
            Console.WriteLine("\nOh no your parrot is causing trouble!!! Press enter to close the program.");
        }

        public static void NotCausingTrouble()
        {
            Console.WriteLine("\nWhew that was close, your parrot is not causing trouble. Press enter to close\nthe program.");
        }
    }
}
