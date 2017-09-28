using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Bowling program where you will enter the number of pins that you\nknocked down with each roll in a game of bowling and then I will calculate your final score for you. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber(string firstSecond, int frameNumber)
        {
            Console.Write($"\nPlease enter the number of pins that you knocked down on your {firstSecond} roll\nof frame number {frameNumber}: ");
        }

        public static void NotANumber(string input, string firstSecond, int frameNumber)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the number of pins\nthat you knocked down on your {firstSecond} roll of frame number {frameNumber}: ");
        }

        public static void OutOfRange(string input, string firstSecond, int frameNumber)
        {
            Console.Write($"\nSorry but {input} is out of range. The number of pins that you knock down in a\nroll must be between 0 and 10. Please enter the number of pins that you knocked down on your {firstSecond} roll of frame number {frameNumber}: ");
        }

        public static void NotEnoughPinsLeft(string input, int pinsAlreadyKnockedDown, int frameNumber)
        {
            Console.Write($"\nSorry but {input} is an invalid number of pins because you already knocked down {pinsAlreadyKnockedDown}\npins on your first roll. Please enter the number of pins that you knocked down\non your second roll of frame number {frameNumber}: ");
        }

        public static void DisplayScore(int score)
        {
            Console.WriteLine($"\nCongratulations your final score for the game was {score} pins. Press enter to\nclose the program.");
        }
    }
}
