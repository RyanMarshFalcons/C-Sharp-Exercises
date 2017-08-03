﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Count_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my vowel count program where I will count the number of\nvowels that you input. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Please input as many words, numbers, spaces, and symbols as you please and I\nwill tell you how many vowels there are: ");
        }

        public static void NoEmptyStrings()
        {
            Console.Write("\nYou must input at least one character for me to perform a count of the\nvowels. Please try again: ");
        }

        public static void DisplayCount(int count)
        {
            Console.WriteLine($"\nAccording to my calculations there are {count} vowels in your input.");
        }
    }
}
