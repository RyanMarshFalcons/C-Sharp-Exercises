using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cut_The_Sticks_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my cut the sticks program where you will enter the lengths of each\nstick in a bundle of sticks and then I will cut each stick by the current lengthof the shortest stick who's length has not yet been reduced to nothing until allthe sticks in the bundle's lengths have been reduced to nothing. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterLengthOfStick(int stickNumber)
        {
            Console.Write($"\nPlease enter how many inches long stick number {stickNumber} is: ");
        }

        public static void StickLengthNotANumber(string input, int stickNumber)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how many inches long stick number {stickNumber} is: ");
        }

        public static void StickLengthMustBePositive(int stickNumber)
        {
            Console.Write($"\nSorry but the length of the stick must be positive. Please enter how many inches long stick number {stickNumber} is: ");
        }

        public static void AddAnotherStick()
        {
            Console.Write("\nWould you like to add another stick to the bundle? y/n: ");
        }

        public static void NotyOrn()
        {
            Console.Write($"\nSorry but you must input either \"y\" or \"n\". Would you like to add another stick to the bundle? y/n: ");
        }

        public static void DisplayInitialStickLengths(List<int> stickLengths, int numCuts, int numSticks)
        {
            Console.WriteLine($"\nHere are all of the lengths of the {numSticks} sticks before any cuts have been made: ");
            foreach (var stick in stickLengths)
            {
                Console.WriteLine($"{stick} inches");
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void DisplayStickLengths(List<int> stickLengths, int cutNumber, int cutLength, int numSticks)
        {
            Console.WriteLine($"Cut number {cutNumber} removed {cutLength} inches from each stick. Here are the lengths of the\nremaining {numSticks} sticks:");
            foreach (var stick in stickLengths)
            {
                Console.WriteLine($"{stick} inches");
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }

        public static void AllSticksAreZero(int cutNumber, int cutLength)
        {
            Console.WriteLine($"Cut number {cutNumber} removed {cutLength} inches from each stick. All of the sticks in the\nbundle have been reduced to nothing. Press enter to continue.");
            Console.ReadLine();
        }

        public static void DisplayResults(int numCuts, int numInitialSticks)
        {
            Console.WriteLine($"After a total of {numCuts} cuts all {numInitialSticks} sticks in the bundle have been reduced to\nnothing. Press enter to close the program.");
        }
    }
}
