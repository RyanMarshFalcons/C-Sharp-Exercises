using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_ScoreCard_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to Ryan's Golf Course. It's a beautiful 18 hole golf course\nwith a par of 72. Let's see how you do. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterScore(int holeNumber, int par)
        {
            Console.Write($"\nEnter the number of shots that you took on hole {holeNumber} which is a par {par}: ");
        }

        public static void NotANumber(string input, int holeNumber)
        {
            Console.Write($"\nSorry but {input} is not a number. Pease enter the number of shots you took\non hole {holeNumber}: ");
        }

        public static void MustBePositive(int holeNumber)
        {
            Console.Write($"\nNumbers of shots can only be positive. Pease enter the number of shots you took on hole {holeNumber}: ");
        }

        public static void OverPar(int totalShots, int shotsOverPar)
        {
            Console.WriteLine($"\nYou shot a {totalShots} which is {shotsOverPar} shots over par. Press enter to close the program.");
        }

        public static void UnderPar(int totalShots, int shotsUnderPar)
        {
            Console.WriteLine($"\nCongratulations you shot a {totalShots} which is {shotsUnderPar} shots under par!!! Press enter to\nclose the program.");
        }

        public static void EvenPar()
        {
            Console.WriteLine($"\nIt looks like this course was built with you in mind because you just shot a 72 even par my friend. Press enter to close the program.");
        }
    }
}
