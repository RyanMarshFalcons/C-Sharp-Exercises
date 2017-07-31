﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredMessages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Squared program. Enter a number and I will tell you what that\nnumber squared is. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("Please enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void NumberSquared(int num, int numSquared)
        {
            Console.WriteLine($"\n{num} squared is {numSquared}.");
        }
    }
}
