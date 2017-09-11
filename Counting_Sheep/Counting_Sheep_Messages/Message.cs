using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sheep_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Counting Sheep program where I will help you to fall asleep by\ncounting sheep for you at a frequency of your choosing and also giving you\nencouraging messages to help you fall asleep. Press enter to continue.");
            Console.ReadLine();
        }

        public static void SelectFrequency()
        {
            Console.WriteLine("Please select the frequency for me to count sheep for you:\nA) Half a second\nB) One second\nC) One and a half seconds\nD) Two seconds\nE) Two and a half seconds\nF) Three seconds\nG) Three and a half seconds\nH) Four seconds\nI) Four and a half seconds\nJ) Five seconds");
        }

        public static void NotAValidSelection(string input)
        {
            Console.WriteLine($"\nSorry but {input} is not a valid selection. Please select the frequency\nfor me to count sheep for you:\nA) Half a second\nB) One second\nC) One and a half seconds\nD) Two seconds\nE) Two and a half seconds\nF) Three seconds\nG) Three and a half seconds\nH) Four seconds\nI) Four and a half seconds\nJ) Five seconds");
        }

        public static void RequestUserName()
        {
            Console.Write("\nPlease input your name: ");
        }

        public static void NameTooShort()
        {
            Console.Write("\nSorry but your name must be at least one character long. Please input your\nname: ");
        }

        public static void CountSheep(int num)
        {
            Console.WriteLine($"\n{num} sheep...");
        }

        public static void GettingSleepy(string name)
        {
            Console.WriteLine($"\nYou're getting very sleepy {name}.");
        }

        public static void DriftToSlumberland(string name)
        {
            Console.WriteLine($"\nTime to drift off to slumberland {name}.");
        }

        public static void CoolKids(string name)
        {
            Console.WriteLine($"\nAll the cool kids are asleep right now {name}.");
        }

        public static void BigDay(string name)
        {
            Console.WriteLine($"\nYou've got a big day tomorrow {name}.");
        }

        public static void FunTimes(string name)
        {
            Console.WriteLine($"\nFun times await you in your dreams {name}.");
        }

        public static void ThankYou(string name)
        {
            Console.WriteLine($"\nThank you for using my Counting Sheep program. I hope that you're reading this\nafter having a good night's sleep last night {name}.\nPress enter to close the program.");
        }
    }
}
