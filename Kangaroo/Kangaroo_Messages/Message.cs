using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Kangaroo program where there are two kangaroos about to jump\nendlessly in the same direction away from you. You will enter how many feet awayfrom you each kangaroo is and how many feet each kangaroo covers each jump. I\nwill then calculate whether or not the two kangaroos will ever land on the same location at the same time. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputStartingDistance(string firstSecond)
        {
            Console.Write($"\nPlease enter how many feet away from where you're standing the {firstSecond} kangaroo\nis starting: ");
        }

        public static void StartingDistanceNotANumber(string input, string firstSecond)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how many feet away\nfrom where you're standing the {firstSecond} kangaroo is starting: ");
        }

        public static void StartingDistanceMustBePositive(string firstSecond)
        {
            Console.Write($"\nSorry but starting distance must be positive. Please enter how many feet away\nfrom where you're standing the {firstSecond} kangaroo is starting: ");
        }

        public static void SecondKangarooMustBeFarther()
        {
            Console.Write($"\nSorry but the second kangaroo must start farther away from you than the first.\nPlease enter how many feet away from where you're standing the second kangaroo\nis starting: ");
        }

        public static void InputJumpingDistance(string firstSecond)
        {
            Console.Write($"\nPlease enter how many feet the {firstSecond} kangaroo covers with each jump: ");
        }

        public static void JumpingDistanceNotANumber(string input, string firstSecond)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter how many feet the\n{firstSecond} kangaroo covers with each jump: ");
        }

        public static void JumpingDistanceMustBePositive(string firstSecond)
        {
            Console.Write($"\nSorry but jumping distance must be positive. Please enter how many meters the\n{firstSecond} kangaroo covers with each jump: ");
        }

        public static void DisplayHowManyJumps(int numJumps, int sameSpotDistance)
        {
            Console.WriteLine($"\nCongratulations after {numJumps} jumps both kangaroos will land at the same spot\n{sameSpotDistance} feet away from you!!! Press enter to close the program.");
        }

        public static void WillNeverLandOnSameSpot()
        {
            Console.WriteLine("\nUnfortunately there will never be a time where the two kangaroos will land on\nthe same spot after the same number of jumps. Press enter to close the program.");
        }
    }
}
