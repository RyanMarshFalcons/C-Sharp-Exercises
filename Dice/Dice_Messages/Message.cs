using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Dice program. The dice that you are rolling are six sided with\neach side having a value of one through six. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumberOfDice()
        {
            Console.Write("How many dice would you like to roll: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the number of dice that you\nwould like to roll: ");
        }

        public static void MustBePositive()
        {
            Console.Write("\nSorry but the number of dice must be poitive. Please input the number of dice\nthat you would like to roll: ");
        }

        public static void ShowRolls()
        {
            Console.WriteLine("\nThe results of your rolls are listed below: ");
        }

        public static void DisplaySum(int numDice, int sum)
        {
            Console.WriteLine($"\nThe sum of the {numDice} dice that you rolled was {sum}.");
        }
    }
}
