using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_Phone_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Answer Phone program. You're about to recieve a phone\ncall, lets see if you're going to answer it. Press enter to continue.");
            Console.ReadLine();
        }

        public static void FamilyAndFriends()
        {
            Console.Write("\nIs the person calling you a family member or a close friend? y/n: ");
        }

        public static void Busy()
        {
            Console.Write("\nAre you currently busy doing something really important? y/n: ");
        }

        public static void Asleep()
        {
            Console.Write("\nAre you currently asleep? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input a y or an n. Please input y or n to procede: ");
        }

        public static void DoAnswerPhone()
        {
            Console.WriteLine("\nHooray you're going to answer your phone!!! Press enter to close the program.");
        }

        public static void DontAnswerPhone()
        {
            Console.WriteLine("\nYou're not going to answer your phone, hopefully they leave a message. Press\nenter to close the program.");
        }
    }
}
