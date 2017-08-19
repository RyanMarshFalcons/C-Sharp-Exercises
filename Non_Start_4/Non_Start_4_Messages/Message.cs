using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Start_4_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my Non Start 4 program where you will input four strings\nand I will make a new string out of deleting their first characters and\ncombining them. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput(int stringNumber)
        {
            Console.Write($"\nPlease enter a series of characters for string number {stringNumber}: ");
        }

        public static void MustBeAtLeast1Character()
        {
            Console.Write("\nSorry but you must input at least one character for me to be able to form a new string for you. Please try again: ");
        }

        public static void DisplayResults(string newString)
        {
            Console.WriteLine($"\nYour new string is {newString}.\nPress enter to close the program.");
        }
    }
}
