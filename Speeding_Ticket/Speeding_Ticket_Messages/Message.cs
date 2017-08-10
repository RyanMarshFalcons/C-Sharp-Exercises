using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeding_Ticket_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Good afternoon I'm Officer Ryan and the reason that I pulled you over today was because you were speeding. The speed limit on this highway is 55 miles per hour.Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("Do you know how many miles per hour you were driving: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\n{input} is not a number. How many miles per hour you were driving: ");
        }

        public static void Lying()
        {
            Console.Write($"\nDon't lie to me I know that you were going over the speed limit. Now tell me howmany miles per hour you were driving: ");
        }

        public static void LessThanFive(int mphOver)
        {
            Console.WriteLine($"\nBecause you were only going {mphOver} miles per hour over the speed limit I'm going to\nlet you off with a warning. Be more mindful of how fast you're going in the\nfuture. Press enter to continue.");
        }

        public static void FiveToTen(int mphOver)
        {
            Console.WriteLine($"\nThe fine for going {mphOver} miles per hour over the speed limit is $40.00. Here is\nyour ticket.");
        }

        public static void ElevenToEighteen(int mphOver)
        {
            Console.WriteLine($"\nThe fine for going {mphOver} miles per hour over the speed limit is $89.00. Here is\nyour ticket.");
        }

        public static void NineteenToTwentyThree(int mphOver)
        {
            Console.WriteLine($"\nThe fine for going {mphOver} miles per hour over the speed limit is is $145.00. Here isyour ticket.");
        }
        public static void TwentyFourToThirty(int mphOver)
        {
            Console.WriteLine($"\nThe fine for going {mphOver} miles per hour over the speed limit is is $285.00. Here isyour ticket.");
        }
        public static void ThirtyOneToForty(int mphOver)
        {
            Console.WriteLine($"\nThe fine for going {mphOver} miles per hour over the speed limit is is $425.00. Here isyour ticket.");
        }
        public static void FortyOneOrMore(int mphOver)
        {
            Console.WriteLine($"\nThe fine for going {mphOver} miles per hour over the speed limit is is $1355.00. Here \nis your ticket.");
        }
    }
}



