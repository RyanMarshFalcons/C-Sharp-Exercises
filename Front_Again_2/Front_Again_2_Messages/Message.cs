﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_Again_2_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Front Again 2 program where you will input a string and I will\ntell you whether or not the first two characters and the last two characters arethe same. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestString()
        {
            Console.Write("Please input a series of characters: ");
        }

        public static void NotEnoughCharacters()
        {
            Console.Write("\nYou must input at least four characters for it to be a valid string. Please try\nagain: ");
        }

        public static void DoMatch(string matchingChars)
        {
            Console.WriteLine($"\nCongratulations your string both begins and ends with {matchingChars}!!! Press enter to closethe program.");
        }

        public static void DontMatch(string begining, string ending)
        {
            Console.WriteLine($"\nUnfortunatly {begining} and {ending} are not a match. Press enter to close the program.");
        }
    }
}
